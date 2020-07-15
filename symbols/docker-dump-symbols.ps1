[CmdletBinding()]
param()

$DockerFilePath = Join-Path $PSScriptRoot "buildtools.dockerfile"
$PSCmdlet.WriteVerbose("Performing the operation `"docker build`" on target `"$DockerFilePath`"")
$DockerImageId = "thnetii/windows-api-buildtools:10.0.17134.0"
Get-Content $DockerFilePath `
| & docker build -t "`"$DockerImageId`"" -
$PSCmdlet.WriteVerbose("Performing the operation `"docker run dump-symbols.ps1`" on target `"$DockerImageId`"")
$DockerRunWorkdir = "C:\SymbolDump"
$DockerRunArguments = @(
    "run", "-it", "--rm",
    "-v", "`"${PSScriptRoot}:$DockerRunWorkdir`"",
    "-w", "`"$DockerRunWorkdir`"",
    "`"$DockerImageId`"",
    ".\dump-symbols.ps1"
    "-ErrorAction", "$ErrorActionPreference"
)
if ($VerbosePreference -ne [System.Management.Automation.ActionPreference]::SilentlyContinue) {
    $DockerRunArguments += "-Verbose"
}
$PSCmdlet.WriteVerbose("docker $DockerRunArguments")
& docker $DockerRunArguments
