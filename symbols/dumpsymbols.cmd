@ECHO OFF
IF NOT EXIST "%~dp0.\Windows.System32" MD "%~dp0.\Windows.System32"
FOR %%D IN (%WINDIR%\System32\*.dll) DO (
    ECHO.dumpbin.exe /EXPORTS "%%~D"
    dumpbin.exe /EXPORTS "%%~D"> "%~dp0.\Windows.System32\%%~nD.txt"
)
