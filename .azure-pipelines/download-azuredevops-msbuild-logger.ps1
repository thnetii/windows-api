#! /usr/bin/pwsh

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12
$resp = Invoke-WebRequest -Uri "https://github.com/thnetii/azure-msbuild/releases/latest" -Method Head
if ($resp.BaseResponse | Get-Member ResponseUri) { # In older PowerShell (beause System.Net.Requests is used)
    [uri]$tagUri = $resp.BaseResponse.ResponseUri
} else { # In newer PowerShell Core (because System.Net.Http is used)
    [uri]$tagUri = $resp.BaseResponse.RequestMessage.RequestUri
}
[string]$tagName = $tagUri.Segments | Select-Object -Last 1
[string]$fileName = "THNETII.AzureDevOps.MSBuild.Logger.zip"
$filePath = Join-Path $PSScriptRoot $fileName
[uri]$dlUri = New-Object System.Uri @($tagUri, "../download/$tagName/$fileName")
Invoke-WebRequest -Uri $dlUri -OutFile $filePath
Expand-Archive -Path $filePath -DestinationPath $PSScriptRoot
