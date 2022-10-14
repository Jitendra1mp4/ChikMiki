Public Class fileManipulation

    Public Shared Saved As Boolean = False
    Public Shared codeChanged As Boolean = False
    Public Shared filePath As String = "\0"

    Const configurationFile As String = "Configuration\configure.conf"
    Const tempFileLocation As String = "Executers\Helper\"
    Const tempFileName As String = "tempCodeRunnerFile.cpp"

    Public Const tempFilePath As String = tempFileLocation & tempFileName

    Public Shared Function getFileName(ByVal filePath As String)
        Return filePath.Substring(filePath.LastIndexOf("\") + 1)
    End Function

    Public Shared Function putInsideDoubleQuouts(ByVal str As String) As String
        Return """" & str & """"
    End Function

    Public Shared Function setFileExtension(ByVal fileName As String, ByVal extension As String) As String
        Return fileName.Substring(0, fileName.LastIndexOf(".") + 1) & extension
    End Function

    Shared Function saveFile(ByVal Path As String) As Boolean
        My.Computer.FileSystem.WriteAllText _
            (Path, Editor.CodeBox.Text, False)
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
        codeChanged = False

        If (Saved) Then
            Editor.SAVEToolStripMenuItem1.Text = "SAVE"
            fileName = getFileName(filePath)
            Editor.Text = Editor.appName + " - " + fileName
        End If

        Return True
    End Function

    Shared Function openFile() As Boolean
        Editor.OpenFileDialog1.Filter = "Cpp files (*.cpp)|*.cpp|C files (*.c)|*.c |All files (*.*)|*.*"

        If Editor.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
            filePath = Editor.OpenFileDialog1.FileName 'get file path
            fileName = getFileName(filePath)    'set file name
            Editor.CodeBox.Text = My.Computer.FileSystem.ReadAllText(filePath) 'copy text to codeBox
            Saved = True                        'set saved = true
            codeChanged = False
            Editor.Text = Editor.appName + " - " + fileName
            Return True
        Else
            Return False
        End If

    End Function


End Class
