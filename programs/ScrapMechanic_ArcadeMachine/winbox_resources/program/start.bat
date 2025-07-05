@echo off
cd C:\WinboxProgram\ScrapMechanic\Release
:loop
start /wait "" "ScrapMechanic.exe"
taskkill /f /im BsSndRpt64.exe >nul 2>&1
goto loop