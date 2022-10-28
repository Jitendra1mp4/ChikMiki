
Public Class MyUtilities
    
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
        Dim arguments As String = filePath + " " + FormatedOutputPath
        'Editor.CodeBox.Text = comd + arguments
        MyUtilities.RunCommandCom(comd, arguments, False)
    End Sub

    Shared Function putInsideDoubleQuouts(ByVal str As String) As String
        Return """" & str & """"
    End Function



End Class