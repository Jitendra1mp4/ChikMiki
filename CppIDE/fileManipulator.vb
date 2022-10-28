Public Class fileManipulator

    Public Saved As Boolean = False
    Public codeChanged As Boolean = False
    Public filePath As String = My.MySettings.Default.lastOpenedFileName
    Public fileName As String
    Public savingPath As String
    Private Const fileListFilter As String = "C source files (*.c)|*.c|C++ source files (*.cpp)|*.cpp|All files (*.*)|*.*"

    Public Function getFileName() As String
        Return filePath.Substring(filePath.LastIndexOf("\") + 1)
    End Function


    Public Function setFileExtension(ByVal extension As String) As String
        Return fileName.Substring(0, fileName.LastIndexOf(".") + 1) & extension
    End Function

    Private Function saveFile() As Boolean
        My.Computer.FileSystem.WriteAllText _
            (savingPath, Editor.CodeBox.Text, False)
        saveFile = True
    End Function



    Public Sub callSaveAs()
        Editor.SaveFileDialog1.Filter = fileListFilter
        If Editor.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
            filePath = Editor.SaveFileDialog1.FileName
        End If
        Saved = saveFile()
        My.MySettings.Default.lastOpenedFileName = filePath
        Editor.Text = Editor.appName + " - " + CStr(getFileName())
    End Sub

    Public Function saver() As Boolean
        If (filePath = "\0") Then 'if file path is not set then open save file dailog
            Editor.SaveFileDialog1.Filter = fileListFilter
            If Editor.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
                Then
                filePath = Editor.SaveFileDialog1.FileName
            Else
                Return False
            End If
        End If
        Saved = saveFile()
        If (Saved) Then
            codeChanged = False
            Editor.SAVEToolStripMenuItem1.Text = "SAVE"
            fileName = CStr(getFileName())
            Editor.Text = Editor.appName + " - " + fileName
            My.MySettings.Default.lastOpenedFileName = filePath
        End If
        Return True
    End Function

    Private Function setCodeBoxText(ByVal path As String) As Boolean

        If (My.Computer.FileSystem.FileExists(path)) Then
            Editor.CodeBox.Text = My.Computer.FileSystem.ReadAllText(path) 'copy text to codeBox
            filePath = path
            Saved = True                        'set saved = true
            codeChanged = False
            fileName = CStr(getFileName())    'set file name
            Editor.Text = Editor.appName + " - " + fileName
            My.MySettings.Default.lastOpenedFileName = path 'save file path for next time
            setCodeBoxText = True
        Else
            filePath = "\0"
        End If
        setCodeBoxText = False
    End Function

    Public Function openFile() As Boolean
        Editor.OpenFileDialog1.Filter = fileListFilter

        If Editor.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
            Then
            filePath = Editor.OpenFileDialog1.FileName 'get file path
            Return setCodeBoxText(filePath)
        Else
            Return False
        End If

    End Function

End Class
