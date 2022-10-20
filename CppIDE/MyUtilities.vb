
Public Class MyUtilities
    
    Shared Sub RunCommandCom(ByVal command As String, ByVal arguments As String, ByVal permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

End Class