Imports System
Imports CodeEditor.fileManipulation
Imports CodeEditor.CodeExecuters
Imports CodeEditor.EditMenu
Imports CodeEditor.MyUtilities
Imports CodeEditor.Theme
Public Class Editor
    Public Const appName As String = "Code Editor Alpha"
    Public Shared programArgs As String = ""

    Private Sub WorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorToolStripMenuItem.Click
        If CodeBox.WordWrap Then
            CodeBox.WordWrap = False
        Else
            CodeBox.WordWrap = True
        End If
    End Sub

    Shared Sub butifyCode()
        fileManipulation.saveFile(tempFilePath) 'saving file to tempPath
        MyUtilities.formateCode(tempFilePath) 'formating code
        'adding formated code to codeBox
        Threading.Thread.Sleep(800) 'Wait for code to get formate / wait execution of external command
        Editor.CodeBox.Text = My.Computer.FileSystem.ReadAllText(codeFormaterOutput)
    End Sub



    '**************************Auto-created functions***********************************'




    Private Sub CodeBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeBox.TextChanged
        numberOfWords.Text = CStr(CodeBox.Text.Length)
        Status_NumberOfLine.Text = CStr(CodeBox.Lines.Length)
        Saved = False
        codeChanged = True
        SAVEToolStripMenuItem1.Text = "^SAVE"
    End Sub


    Private Sub SAVEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem1.Click
        Saved = saver()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Cut.Click
        cutText()
    End Sub

    Private Sub RunCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_RunCode.Click

        callCodeRunner(False)

    End Sub

    Private Sub RUNToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RUNToolStripMenuItem.Click
        callCodeRunner(False)
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        callCodeRunner(False)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        programArgs = putInsideDoubleQuouts(InputBox("Enter Arguments", "Cpp IDE", ""))
        'CodeBox.Text = programArgs
        callCodeRunner(False)

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        callCodeRunner(True)
    End Sub

    Private Sub CompileCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompileCodeOption.Click
        callCodeRunner(True)
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        If codeBoxFontDialog.ShowDialog <> DialogResult.Cancel Then
            CodeBox.Font = codeBoxFontDialog.Font
        End If

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        If DownStatusStrip.Visible = False Then
            DownStatusStrip.Visible = True
        Else
            DownStatusStrip.Visible = False
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteMenuItem.Click
        pasteText()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyMenuItem.Click
        copyText()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutMenuItem.Click
        cutText()

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        callSaveAs()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Saved = saver()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        openFile()

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        Dim nextForm As New Editor
        nextForm.ShowDialog()

    End Sub

    Private Sub Editor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If codeChanged = True Then
            Dim mr As Integer
            mr = MsgBox("Do you want to Save File..?", 3, "Editor")
            If mr = DialogResult.Yes Then
                If saver() <> True Then
                    e.Cancel = True
                End If
            ElseIf mr = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        numberOfWords.Text = CStr(CodeBox.Text.Length)
        Status_NumberOfLine.Text = CStr(CodeBox.Lines.Length)

        Me.Text = appName + " - Untitled"
        manageTheme()

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayNightMenuItem.Click
        manageTheme()
    End Sub

    Private Sub FormateCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormateCodeToolStripMenuItem.Click
        butifyCode()
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Butify.Click
        butifyCode()
    End Sub

    Private Sub CopyOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Copy.Click
        copyText()

    End Sub

    Private Sub PastPast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Past.Click
        pasteText()

    End Sub

    Private Sub StatusStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles DownStatusStrip.ItemClicked

    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        AboutSoftwareBox.Show()
    End Sub

    Private Sub ToolStripStatusLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status_NumberOfLine.Click

    End Sub

    Private Sub Edit_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_Undo.Click
        undoText()
    End Sub

    Private Sub Edit_Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_Redo.Click
        RedoText()

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
