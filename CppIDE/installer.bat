@echo off

@rem Set source and destination 
set Source=ChikMiki_v0.1.0.0
set Destination=C:\%Source%

@rem Set link location
set linkSource="%Destination%\ChikMiki.exe"
set linkDest="%USERPROFILE%\Desktop\ChikMiki.lnk"

@rem copy files
robocopy %Source% %Destination% /IT /S

@rem create a shortcut
set SCRIPT="%TEMP%\%RANDOM%-%RANDOM%-%RANDOM%-%RANDOM%.vbs"
echo Set oWS = WScript.CreateObject("WScript.Shell") >> %SCRIPT%
echo sLinkFile = %linkDest% >> %SCRIPT%
echo Set oLink = oWS.CreateShortcut(sLinkFile) >> %SCRIPT%
echo oLink.TargetPath = %linkSource% >> %SCRIPT%
echo oLink.WorkingDirectory = "%Destination%" >> %SCRIPT%
@rem echo oLink.Arguments = "-h JitendraKumar -a ifix" >> %SCRIPT%
echo oLink.Save >> %SCRIPT%
cscript /nologo %SCRIPT%
del %SCRIPT%
cls
Echo "Sucessfully installed"
pause