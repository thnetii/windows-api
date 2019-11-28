@ECHO OFF
FOR /D %%V IN ("C:\Program Files (x86)\Windows Kits\10\Lib\10.0.17134.0\*") DO (
    FOR /D %%A IN ("%%~V\*") DO (
        IF NOT EXIST "%~dp0.\SDK\%%~nxV\%%~nxA" MD "%~dp0.\SDK\%%~nxV\%%~nxA"
        FOR %%L IN ("%%~A\*.lib") DO (
            ECHO.%%~L
            dumpbin.exe /EXPORTS "%%~L" > "%~dp0.\SDK\%%~nxV\%%~nxA\%%~nL.txt"
        )
    )
)
