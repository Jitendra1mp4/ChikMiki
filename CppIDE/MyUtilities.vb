
Public Class MyUtilities


    Const codeFormater As String = "codeFormater\codeFormater.bat"
    Const formatedOutputLocation As String = "codeFormater\"
    Const formatedOutputFileName As String = "formatedCode.out"
    Const FormatedOutputPath As String = formatedOutputLocation + formatedOutputFileName


    Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Shared Function formateCode(ByVal filePath As String) As String
        Const comd As String = codeFormater
        Dim arguments As String = filePath + " " + FormatedOutputPath
        'Editor.CodeBox.Text = comd + arguments
        MyUtilities.RunCommandCom(comd, arguments, False)
        Threading.Thread.Sleep(800) 'Wait for code to get formate / wait execution of external command
        Return My.Computer.FileSystem.ReadAllText(FormatedOutputPath)
    End Function

    Shared Function putInsideDoubleQuouts(ByVal str As String) As String
        Return """" & str & """"
    End Function

    Shared Function setFileExtension(ByVal fileName As String, ByVal extension As String) As String
        Return fileName.Substring(0, fileName.LastIndexOf(".") + 1) & extension
    End Function



End Class