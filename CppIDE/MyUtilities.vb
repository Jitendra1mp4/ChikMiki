
Public Class MyUtilities


    Const codeFormater As String = "codeFormater\codeFormater.bat"
    Const formatedOutputLocation As String = "codeFormater\"
    Const formatedOutputFileName As String = "formatedCode.out"

    Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Shared Sub formateCode(ByVal filePath As String)
        Const comd As String = codeFormater
        Dim arguments As String = filePath
        MyUtilities.RunCommandCom(comd, arguments, False)
        Threading.Thread.Sleep(900) 'Wait for code to get formate / wait execution of external command
        Return
    End Sub

    Shared Function putInsideDoubleQuouts(ByVal str As String) As String
        Return """" & str & """"
    End Function

    Shared Function setFileExtension(ByVal fileName As String, ByVal extension As String) As String
        Return fileName.Substring(0, fileName.LastIndexOf(".") + 1) & extension
    End Function



End Class