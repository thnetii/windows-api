#!/usr/bin/pwsh
[CmdletBinding()]
param()

[uri]$dlUri = "https://github.com/Microsoft/azure-pipelines-task-lib/raw/master/powershell/VstsTaskSdk/LoggingCommandFunctions.ps1"
[string]$fileName = $dlUri.Segments | Select-Object -Last 1
$filePath = Join-Path $PSScriptRoot $fileName
[System.Net.ServicePointManager]::SecurityProtocol = `
    [System.Net.SecurityProtocolType]::Tls12
Invoke-WebRequest -Uri $dlUri -OutFile $filePath
