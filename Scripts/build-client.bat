@echo off
echo ============================
echo - Build Client for GTAVMP  -
echo ============================
echo Description: Copies files from development environment to 
echo game folder.
echo Results:
REM pause
xcopy /s/y "C:\Users\waltons\Documents\Visual Studio 2017\Projects\GTAVMP\Client\bin\Release" "D:\Program Files (x86)\Rockstar Games\Grand Theft Auto V\scripts"
echo All done!
pause