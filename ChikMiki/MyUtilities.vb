
Public Class MyUtilities
    Const codeFormater As String = "codeFormater\codeFormater.bat"
    Const formatedOutputFileName As String = "formatedCode.out"

    Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        Try
            p.Start()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Shared Sub formateCode(ByVal filePath As String)
        Const arguments As String = "-i --style=""{BasedOnStyle: microsoft,IndentWidth: 4}"""
        Const comd As String = "codeFormater\clang-format.exe"
        Dim formater As Process = New Process()
        Dim formaterInfo As ProcessStartInfo = New ProcessStartInfo()
        formaterInfo.FileName = comd
        formaterInfo.Arguments = " " + arguments + " " + filePath
        formaterInfo.WindowStyle = ProcessWindowStyle.Hidden
        formater.StartInfo = formaterInfo
        Try
            formater.Start()
            'Threading.Thread.Sleep(800) 'Wait for code to get formate / wait execution of external command
            formater.WaitForExit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return
    End Sub

    Shared Function putInsideDoubleQuouts(ByVal str As String) As String
        Return """" & str & """"
    End Function

    Shared Function setFileExtension(ByVal fileName As String, ByVal extension As String) As String
        Return fileName.Substring(0, fileName.LastIndexOf(".") + 1) & extension
    End Function

End Class