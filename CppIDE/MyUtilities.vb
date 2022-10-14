
Public Class MyUtilities
    Const codeFormater As String = "codeFormater\clang-format.exe"
    Public Const codeFormaterOutput As String = "codeFormater\formatedCode.out"
    Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Shared Sub formateCode(ByVal filePath As String)
        Dim comd As String = codeFormater & " " & filePath & " > " & codeFormaterOutput
        RunCommandCom(comd, "", False)
    End Sub

End Class