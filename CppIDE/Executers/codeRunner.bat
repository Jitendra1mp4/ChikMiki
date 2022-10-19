@ECHO OFF
set compilerLoaction=%1
set tempFilePath=%2
set outputPath=%3
set arguments=%4
@REM cd %tempFilePath%
@REM adding minGW to enviroment variable
set PATH=%compilerLoaction%;%PATH%
echo working on it...
@rem compiling
g++ %tempFilePath% -o %outputPath%
@rem checking for error and executting
if errorLevel 1 (ECHO Error && pause ) else (%outputPath% %arguments% && echo: && echo Successfully Executed && pause)

 
  