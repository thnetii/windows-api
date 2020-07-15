[CmdletBinding()]
param(
    $SdkVersion = "10.0.17134.0",
    $Architecture = "x64"
)

# Ensure dumpbin command exists
Get-Command "dumpbin.exe" -ErrorAction Stop | Out-Null
Get-Command "lib.exe" -ErrorAction Stop | Out-Null

function Invoke-DumpSymbols {
    param ()
    $LibOutputRoot = Join-Path $PSScriptRoot "lib"
    $DllOutputRoot = Join-Path $PSScriptRoot "dll"

    $WindowsKitsRoot10 = Get-ItemPropertyValue `
        -Path 'Registry::HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows Kits\Installed Roots' `
        -Name "KitsRoot10"

    [System.Collections.Generic.Dictionary[string, System.Collections.Generic.List[PSCustomObject]]]$WindowsDllLibMappings = New-Object `
        "System.Collections.Generic.Dictionary[string, System.Collections.Generic.List[PSCustomObject]]" @([System.StringComparer]::OrdinalIgnoreCase)
    $LibsRootPath = Join-Path -Resolve $WindowsKitsRoot10 "Lib\$SdkVersion"
    $UserModeLibsPath = Join-Path -Resolve $LibsRootPath "um\$Architecture"
    $LibInformations = Get-ChildItem -Recurse -File -Filter "*.lib" $UserModeLibsPath | ForEach-Object {
        $LibFilePath = $_.FullName
        if (Get-Member -Name GetRelativePath -Static -InputObject ([System.IO.Path])) {
            $LibRelativePath = [System.IO.Path]::GetRelativePath($LibsRootPath, $LibFilePath)
        } else {
            $LibRelativePath = $LibFilePath.Substring($LibsRootPath.Length + 1)
        }

        $LibInfo = Get-StaticLibraryInformation $LibFilePath | Add-Member `
            -Type NoteProperty -Name RelativePath -Value $LibRelativePath `
            -PassThru

        $LibInfo.DllNames | ForEach-Object {
            $DllLibInfoList = $null
            if (-not ($WindowsDllLibMappings.TryGetValue($_, [ref] $DllLibInfoList))) {
                $DllLibInfoList = New-Object "System.Collections.Generic.List[PSCustomObject]" @(1)
                $WindowsDllLibMappings[$_] = $DllLibInfoList
            }
            $DllLibInfoList.Add($LibInfo) | Out-Null
        }

        $LibInfo
    }

    $SpecialFolders = @(
        [System.Environment+SpecialFolder]::Windows,
        [System.Environment+SpecialFolder]::System,
        [System.Environment+SpecialFolder]::SystemX86
    )
    $SpecialFolderPaths = $SpecialFolders | ForEach-Object {
        [System.Environment]::GetFolderPath($_)
    }

    $WindowsDllInformations = $WindowsDllLibMappings.Keys | Sort-Object | ForEach-Object {
        $DllName = $_
        if ([System.IO.Path]::IsPathRooted($_)) {
            $DllFileItem = Get-ChildItem $_ -ErrorAction SilentlyContinue
        }
        else {
            $DllFileItem = $SpecialFolderPaths | ForEach-Object {
                Get-ChildItem (Join-Path $_ $DllName) -ErrorAction SilentlyContinue
            } | Select-Object -First 1
        }
        if ($DllFileItem) {
            [PSCustomObject]@{
                DllName  = $DllName;
                FileItem = $DllFileItem;
            }
        }
    } | ForEach-Object {
        $DllInfo = $_ | Add-DynamicLinkerLibraryInformation -PassThru
        $LibReferencingInfos = $WindowsDllLibMappings[$DllInfo.DllName]
        $DllInfo.ExportedSymbols.Values | ForEach-Object {
            $DllSymbolInfo = $_
            $LibReferencingInfos | Where-Object {
                $_.ExportedSymbols.ContainsKey($DllSymbolInfo.SymbolName)
            } | ForEach-Object {
                $_.ExportedSymbols[$DllSymbolInfo.SymbolName].Definitions.Add($DllInfo) | Out-Null
                $DllSymbolInfo.ReferencedBy.Add($_) | Out-Null
            }
        }
        $DllInfo
    }

    Remove-Item -Force -Recurse $LibOutputRoot, $DllOutputRoot -ErrorAction SilentlyContinue

    $XmlWriterSettings = New-Object System.Xml.XmlWriterSettings
    $XmlWriterSettings.Encoding = New-Object System.Text.UTF8Encoding @($false)
    $XmlWriterSettings.Indent = $true

    $LibInformations | ForEach-Object {
        $LibInfoXmlPath = Join-Path $LibOutputRoot ($_.RelativePath + ".xml")
        $PSCmdlet.WriteVerbose("Performing the operation `"Out-StaticLibraryInformation`" on target `"$LibInfoXmlPath`"")
        New-Item -Force $LibInfoXmlPath | Out-Null
        $LibInfoXmlBuilder = [System.Xml.XmlWriter]::Create($LibInfoXmlPath, $XmlWriterSettings)

        $LibInfoXmlBuilder.WriteStartDocument()
        $LibInfoXmlBuilder.WriteStartElement("StaticLibrary")
        $LibInfoXmlBuilder.WriteElementString("RelativeName", $_.RelativePath)
        $LibInfoXmlBuilder.WriteElementString("OriginalPath", (Resolve-Path $_.FilePath))

        $LibInfoXmlBuilder.WriteStartElement("ReferencedLibraries")
        $_.DllNames | Sort-Object -CaseSensitive:$false | ForEach-Object {
            $LibInfoXmlBuilder.WriteStartElement("DynamicLibrary")
            $LibInfoXmlBuilder.WriteAttributeString("Name", $_)
            $LibInfoXmlBuilder.WriteEndElement()
        }
        $LibInfoXmlBuilder.WriteEndElement()

        $LibInfoXmlBuilder.WriteStartElement("ExportedSymbols")
        $_.ExportedSymbols.Values | Sort-Object -Property Index | ForEach-Object {
            $LibInfoXmlBuilder.WriteStartElement("Symbol")
            $LibInfoXmlBuilder.WriteAttributeString("Name", $_.SymbolName)

            if ($_.ForwardTo) {
                $LibInfoXmlBuilder.WriteElementString("ForwardSymbol", $_.ForwardTo)
            }

            if ($_.Definitions) {
                $LibInfoXmlBuilder.WriteStartElement("Definitions")
                $_.Definitions | ForEach-Object {
                    $LibInfoXmlBuilder.WriteStartElement("DynamicLibrary")
                    $LibInfoXmlBuilder.WriteAttributeString("Name", $_.DllName)
                    $LibInfoXmlBuilder.WriteEndElement()
                }
                $LibInfoXmlBuilder.WriteEndElement()
            }

            $LibInfoXmlBuilder.WriteEndElement()
        }
        $LibInfoXmlBuilder.WriteEndElement()

        $LibInfoXmlBuilder.WriteEndElement()
        $LibInfoXmlBuilder.WriteEndDocument()

        $LibInfoXmlBuilder.Flush()
        $LibInfoXmlBuilder.Close()
        Remove-Variable LibInfoXmlBuilder
    }

    $WindowsDllInformations | ForEach-Object {
        $DllOriginalPath = Resolve-Path $_.FileItem.FullName
        $DllInfoXmlPath = Join-Path $DllOutputRoot ([System.IO.Path]::GetFileName($DllOriginalPath) + ".xml")
        $PSCmdlet.WriteVerbose("Performing the operation `"Out-DynamicLibraryInformation`" on target `"$DllInfoXmlPath`"")
        New-Item -Force $DllInfoXmlPath | Out-Null
        $DllInfoXmlBuilder = [System.Xml.XmlWriter]::Create($DllInfoXmlPath, $XmlWriterSettings)
        $DllInfoXmlBuilder.WriteStartDocument()

        $DllInfoXmlBuilder.WriteStartElement("DynamicLibrary")
        $DllInfoXmlBuilder.WriteAttributeString("Name", $_.DllName)

        $DllInfoXmlBuilder.WriteElementString("OriginalPath", $DllOriginalPath)
        $DllInfoXmlBuilder.WriteStartElement("ExportedSymbols")
        $_.ExportedSymbols.Values | Sort-Object -Property Index | ForEach-Object {
            $DllInfoXmlBuilder.WriteStartElement("Symbol")
            $DllInfoXmlBuilder.WriteAttributeString("Name", $_.SymbolName)

            if ($_.ForwardTo) {
                $DllInfoXmlBuilder.WriteElementString("ForwardSymbol", $_.ForwardTo)
            }

            if ($_.ReferencedBy) {
                $DllInfoXmlBuilder.WriteStartElement("ReferencedBy")
                $_.ReferencedBy | ForEach-Object {
                    $DllInfoXmlBuilder.WriteStartElement("StaticLibrary")
                    $DllInfoXmlBuilder.WriteAttributeString("Name", $_.RelativePath)
                    $DllInfoXmlBuilder.WriteEndElement()
                }
                $DllInfoXmlBuilder.WriteEndElement()
            }

            $DllInfoXmlBuilder.WriteEndElement()
        }
        $DllInfoXmlBuilder.WriteEndElement()

        $DllInfoXmlBuilder.WriteEndElement()

        $DllInfoXmlBuilder.WriteEndDocument()
        $DllInfoXmlBuilder.Flush()
        $DllInfoXmlBuilder.Close()
        Remove-Variable DllInfoXmlBuilder
    }
}

function Add-DynamicLinkerLibraryInformation {
    param(
        [Parameter(ValueFromPipeline = $true)]
        [PSCustomObject]$InputObject,
        [switch]$PassThru
    )
    $DllName = $InputObject.DllName
    $DllFileItem = $InputObject.FileItem

    $PSCmdlet.WriteVerbose("Performing the operation `"Get-DynamicLinkerLibraryInformation`" on target `"$DllName -> $($DllFileItem.FullName)`"")
    $DllExportSymbols = Get-ExportedSymbols $DllFileItem.FullName
    $DllSymbolDictionary = New-Object "System.Collections.Generic.Dictionary[string,PSCustomObject]" @(
        [int]($DllExportSymbols.Count), [System.StringComparer]::OrdinalIgnoreCase)
    $DllExportSymbols | ForEach-Object {
        $DllReferencingLibraries = New-Object "System.Collections.Generic.List[PSCustomObject]"
        $_ | Add-Member -Type ([System.Management.Automation.PSMemberTypes]::NoteProperty) `
            -Name ReferencedBy -Value $DllReferencingLibraries

        $DllSymbolDictionary[$_.SymbolName] = $_
    }

    $InputObject | Add-Member -Type NoteProperty `
        -Name ExportedSymbols -Value $DllSymbolDictionary `
        -PassThru:$PassThru
}

function Get-StaticLibraryInformation {
    [OutputType([PSCustomObject])]
    param(
        [Parameter(Position = 0)]
        [string]$Path
    )

    [System.Collections.Generic.HashSet[string]]$LibDllNames = New-Object `
        "System.Collections.Generic.HashSet[string]" @([System.StringComparer]::OrdinalIgnoreCase)

    $PSCmdlet.WriteVerbose("Performing the operation `"Get-StaticLibraryInformation`" on target `"$Path`"")
    $LibListOutput = & "lib.exe" /NOLOGO /LIST "`"$LibFilePath`""
    $LibDllNames.UnionWith([string[]]$LibListOutput)

    $LibDumpbinSymbols = Get-ExportedSymbols $LibFilePath
    $LibSymbolDictionary = New-Object "System.Collections.Generic.Dictionary[string,PSCustomObject]" @(
        [int]($DllExportSymbols.Count), [System.StringComparer]::OrdinalIgnoreCase)
    $LibDumpbinSymbols | ForEach-Object {
        $LibSymbolDefinitions = New-Object "System.Collections.Generic.List[PSCustomObject]"
        $_ | Add-Member -Type ([System.Management.Automation.PSMemberTypes]::NoteProperty) `
            -Name Definitions -Value $LibSymbolDefinitions

        $LibSymbolDictionary[$_.SymbolName] = $_
    }

    [PSCustomObject]@{
        FilePath        = $Path;
        DllNames        = $LibDllNames;
        ExportedSymbols = $LibSymbolDictionary;
    }
}

function Get-ExportedSymbols {
    [OutputType([PSCustomObject[]])]
    param(
        [Parameter(Position = 0)]
        [string]$Path
    )

    [regex]$DumpbinFileTypeRegex = "File Type\: (\w+)"
    [regex]$SymbolForwardRegex = "(\S+)\s+\(forwarded to (\S+)\)$"
    [regex]$SymbolNameRegex = "\S+$"

    $DumpbinOutput = & "dumpbin.exe" /NOLOGO /EXPORTS "`"$Path`""

    $Index = 0
    $DumpbinFileType = $null
    for (; $Index -lt $DumpbinOutput.Count -and -not $DumpbinFileType; $Index++) {
        [string]$DumpbinLine = $DumpbinOutput[$Index].Trim()
        $DumpbinFileTypeMatch = $DumpbinFileTypeRegex.Match($DumpbinLine)
        if ($DumpbinFileTypeMatch.Success) {
            $DumpbinFileType = $DumpbinFileTypeMatch.Groups[1].Value
        }
    }

    switch -Wildcard ($DumpbinFileType) {
        "LIBRARY" {
            for (; $Index -lt $DumpbinOutput.Count -and `
                    $DumpbinOutput[$Index].Trim() -ine "Exports";
                $Index++) {}
            $Index += 4
            break
        }
        "DLL" {
            for (; $Index -lt $DumpbinOutput.Count -and `
                    $DumpbinOutput[$Index].Trim() -inotlike "Section contains the following exports for *";
                $Index++) {}
            $Index += 2
            for (; $Index -lt $DumpbinOutput.Count -and `
                    $DumpbinOutput[$Index].Trim();
                $Index++) {}
            $Index += 3
            break
        }
    }

    $SymbolIndex = 0
    [System.Collections.Generic.HashSet[string]]$SymbolNameHashSet = New-Object `
        "System.Collections.Generic.HashSet[string]" @([System.StringComparer]::OrdinalIgnoreCase)
    for (; $Index -lt $DumpbinOutput.Count -and -not ([string]::IsNullOrWhiteSpace($DumpbinOutput[$Index])); $Index++) {
        [string]$DumpbinLine = $DumpbinOutput[$Index].Trim()

        if ($SymbolForwardRegex.IsMatch($DumpbinLine)) {
            $SymbolForwardMatch = $SymbolForwardRegex.Match($DumpbinLine)
            $SymbolName = $SymbolForwardMatch.Groups[1].Value
            $ForwardSymbol = $SymbolForwardMatch.Groups[2].Value
            if ($SymbolNameHashSet.Add($SymbolName)) {
                [PSCustomObject]@{
                    Index = $SymbolIndex;
                    SymbolName = $SymbolName;
                    ForwardTo  = $ForwardSymbol;
                }
                $SymbolIndex++
            }
        }
        elseif ($SymbolNameRegex.IsMatch($DumpbinLine)) {
            $SymbolNameMatch = $SymbolNameRegex.Match($DumpbinLine)
            $SymbolName = $SymbolNameMatch.Value
            if ($SymbolNameHashSet.Add($SymbolName)) {
                [PSCustomObject]@{
                    Index = $SymbolIndex;
                    SymbolName = $SymbolName;
                }
                $SymbolIndex++
            }
        }
    }
}

Invoke-DumpSymbols
