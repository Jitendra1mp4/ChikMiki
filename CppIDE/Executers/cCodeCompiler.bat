@ECHO OFF
set compilerLoaction=%1
set tempFilePath=%2
set outputPath=%3
@REM cd %tempFilePath%
@REM adding minGW to enviroment variable
set PATH=%compilerLoaction%;%PATH%
echo working on it...
@rem compiling
gcc %tempFilePath% -o %outputPath%
if errorLevel 1 (ECHO Error && pause ) else (echo Successfully Compiled && pause)
