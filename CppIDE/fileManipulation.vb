Public Class fileManipulation

    Public Shared Saved As Boolean = False
    Public Shared codeChanged As Boolean = False
    Public Shared filePath As String = My.MySettings.Default.lastOpenedFileName

    Const configurationFile As String = "Configuration\configure.conf"
    Const tempFileLocation As String = "Executers\Helper\"
    Const tempFileName As String = "tempCodeRunnerFile.cpp"

    Public Const tempFilePath As String = tempFileLocation + tempFileName

    Public Shared Function getFileName(ByVal filePath As String)
        Return filePath.Substring(filePath.LastIndexOf("\") + 1)
    End Function

    Public Shared Function putInsideDoubleQuouts(ByVal str As String) As String
        Return """" & str & """"
    End Function

    Public Shared Function setFileExtension(ByVal fileName As String, ByVal extension As String) As String
        Return fileName.Substring(0, fileName.LastIndexOf(".") + 1) & extension
    End Function

    Shared Function saveFile(ByVal savingPath As String) As Boolean

        My.Computer.FileSystem.WriteAllText _
            (savingPath, Editor.CodeBox.Text, False)
        saveFile = True
    End Function

    Shared Sub callSaveAs()
        Editor.SaveFileDialog1.Filter = "Cpp files (*.cpp)|*.cpp|C files (*.c)|*.c |All files (*.*)|*.*"
        If Editor.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
            filePath = Editor.SaveFileDialog1.FileName
        End If
        saveFile(tempFilePath)
        Saved = saveFile(filePath)
        My.MySettings.Default.lastOpenedFileName = filePath
        Editor.Text = Editor.appName + " - " + getFileName(filePath)
    End Sub

    Shared Function saver() As Boolean
        If (filePath = "\0") Then 'if file path is not set then open save file dailog
            Editor.SaveFileDialog1.Filter = "Cpp files (*.cpp)|*.cpp|C files (*.c)|*.c |All files (*.*)|*.*"
            If Editor.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
                Then
                filePath = Editor.SaveFileDialog1.FileName
            Else
                Return False
            End If
        End If

        saveFile(tempFilePath)
        Saved = saveFile(filePath)
        If (Saved) Then
            codeChanged = False
            Editor.SAVEToolStripMenuItem1.Text = "SAVE"
            fileName = getFileName(filePath)
            Editor.Text = Editor.appName + " - " + fileName
            My.MySettings.Default.lastOpenedFileName = filePath
        End If
        Return True
    End Function

    Shared Function setCodeBoxText(ByVal path As String) As Boolean

        If (My.Computer.FileSystem.FileExists(path)) Then
            Editor.CodeBox.Text = My.Computer.FileSystem.ReadAllText(path) 'copy text to codeBox
            filePath = path
            Saved = True                        'set saved = true
            codeChanged = False
            fileName = getFileName(path)    'set file name
            Editor.Text = Editor.appName + " - " + fileName
            My.MySettings.Default.lastOpenedFileName = path 'save file path for next time
            setCodeBoxText = True
        Else
            filePath = "\0"
        End If

        setCodeBoxText = False
    End Function

    Shared Function openFile() As Boolean
        Editor.OpenFileDialog1.Filter = "Cpp files (*.cpp)|*.cpp|C files (*.c)|*.c |All files (*.*)|*.*"

        If Editor.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
            filePath = Editor.OpenFileDialog1.FileName 'get file path
            Return setCodeBoxText(filePath)
        Else
            Return False
        End If

    End Function

End Class
