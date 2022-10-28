Imports System
Imports Alpha_C_CPP_IDE.fileManipulator
Imports Alpha_C_CPP_IDE.CodeExecuters
Imports Alpha_C_CPP_IDE.EditMenu
Imports Alpha_C_CPP_IDE.MyUtilities
Imports Alpha_C_CPP_IDE.Theme

Public Class Editor

    Public Const appName As String = "Alpha C/C++ IDE"


    Dim themer As New Theme(Me)
    Dim Mfile As New fileManipulator(Me)
    Dim edtMenu As New EditMenu(Me)
    Dim Executer As New CodeExecuters(Me, Mfile.filePath)


    Public Sub callCodeRunner(ByVal compileOnly As Boolean)
        If ((CodeBox.Text.IndexOf("clrscr")) > -1 And (CodeBox.Text.IndexOf("// clrscr") = -1)) Then
            CodeBox.Text = CodeBox.Text.Replace("clrscr", "// clrscr")
        End If
        '_editor.butifyCode() 'user may not able to undo code 
        If Mfile.filePath <> "\0" Then
            Mfile.saver()
        End If
        Executer.codeRunner(Mfile.Saved, compileOnly)
    End Sub

    '**************************Auto-created functions***********************************'

    Private Sub WorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorToolStripMenuItem.Click
        If CodeBox.WordWrap Then
            CodeBox.WordWrap = False
        Else
            CodeBox.WordWrap = True
        End If
    End Sub


    Private Sub CodeBox_FontChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodeBox.FontChanged
        '****************For line number
        lineNumberBox.Font = CodeBox.Font

    End Sub


    Private Sub CodeBox_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodeBox.SelectionChanged
        Dim pt As Point = CodeBox.GetPositionFromCharIndex(CodeBox.SelectionStart)
        If (pt.X = 1) Then
            AddLineNumbers()
        End If
    End Sub


    Private Sub CodeBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeBox.TextChanged
        numberOfWords.Text = CStr(CodeBox.Text.Length)
        Status_NumberOfLine.Text = CStr(CodeBox.Lines.Length)
        SAVEToolStripMenuItem1.Text = "^SAVE"
        If CodeBox.Text = "" Then
            AddLineNumbers()
        End If
        Mfile.Saved = False
    End Sub


    Private Sub SAVEToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEToolStripMenuItem1.Click
        Mfile.saver()
    End Sub

    Private Sub CutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Cut.Click
        edtMenu.cutText()
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
        Executer.programArgs = putInsideDoubleQuouts(InputBox("Enter Arguments", "Cpp IDE", ""))
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
        edtMenu.pasteText()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyMenuItem.Click
        edtMenu.copyText()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutMenuItem.Click
        edtMenu.cutText()

    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Mfile.callSaveAs()

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Mfile.saver()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Mfile.openFile()
        AddLineNumbers()
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        createNewForm()
        AddLineNumbers()
    End Sub


    Private Sub Editor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.MySettings.Default.Save()
        If Mfile.Saved = False Then
            Dim mr As Integer
            mr = MsgBox("Do you want to Save File..?", CType(3, MsgBoxStyle), "Editor")
            If mr = DialogResult.Yes Then
                Mfile.saver()
                If Mfile.Saved <> True Then
                    e.Cancel = True
                End If
            ElseIf mr = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub


    Sub InitialSetups()

        'Setting last theme
        themer.SetTheme(My.MySettings.Default.Theme)

        'opening last opened file (if any)
        If (Not (My.MySettings.Default.lastOpenedFileName.Contains("\0"))) Then
            'CodeBox.Text = My.MySettings.Default.lastOpenedFileName
            Mfile.setCodeBoxText(My.MySettings.Default.lastOpenedFileName)
        End If

        'Updating status strip
        numberOfWords.Text = CStr(CodeBox.Text.Length)
        Status_NumberOfLine.Text = CStr(CodeBox.Lines.Length)

        'Adding line number
        lineNumberBox.Font = CodeBox.Font
        CodeBox.Select()
        AddLineNumbers()

    End Sub


    Private Sub Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = appName + " - Untitled"
        InitialSetups()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayNightMenuItem.Click
        themer.manageTheme()
    End Sub

    Private Sub FormateCodeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormateCodeToolStripMenuItem.Click
        Executer.butifyCode()
    End Sub

    Private Sub ToolStripMenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Butify.Click
        Executer.butifyCode()
    End Sub

    Private Sub CopyOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Copy.Click
        edtMenu.copyText()

    End Sub

    Private Sub PastPast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles contex_Past.Click
        edtMenu.pasteText()
    End Sub

    Private Sub AboutDeveloperToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutDeveloperToolStripMenuItem.Click
        AboutSoftwareBox.Show()
    End Sub

    Private Sub Edit_Undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_Undo.Click
        edtMenu.undoText()
    End Sub

    Private Sub Edit_Redo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit_Redo.Click
        edtMenu.RedoText()

    End Sub


    Sub resetCodeEditor()
        Mfile.filePath = "\0"
        My.MySettings.Default.lastOpenedFileName = Mfile.filePath
        Me.Text = appName + " - Untitled"
        CodeBox.Text = My.MySettings.Default.preAvalibleCode
        'codeChanged = False
        Mfile.Saved = True
    End Sub

    Private Sub createNewForm()
        If Not Mfile.Saved Then
            Dim mr As MsgBoxResult
            mr = MsgBox("Do yo want to save file", MsgBoxStyle.YesNoCancel, appName)
            If mr = MsgBoxResult.Yes Then
                Mfile.saver()
                If Mfile.Saved <> True Then
                    MsgBox("Unable to save", , appName)
                End If
            ElseIf mr = MsgBoxResult.No Then
                resetCodeEditor()
            End If
        Else
            resetCodeEditor()
        End If
    End Sub



    '*******************Adding line number*****************************


    Private Sub Editor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        AddLineNumbers()
    End Sub

    Function getWidth() As Integer
        Dim w As Integer = 0
        Dim line As Integer
        'Get total lines of CodeBox
        line = CodeBox.Lines.Length
        If (line <= 99) Then
            w = 60 ' + CInt(CodeBox.Lines.Length)
        ElseIf (line <= 999) Then
            w = 80 ' + CInt(CodeBox.Lines.Length)
        ElseIf (line <= 9999) Then
            w = 100 '+ CInt(CodeBox.Lines.Length)
        Else
            w = 120 '+ CInt(CodeBox.Lines.Length)
        End If
        Return w
    End Function

    Sub AddLineNumbers()
        'clear lineNumberBox 
        lineNumberBox.Clear()
        'Create and set pointer to (0,0)
        Dim pt As Point = New Point(0, 0)
        'Get first index and first line number form CodeBox
        Dim firstIndex As Integer
        Dim firstLine As Integer
        Dim lastIndex As Integer
        Dim lastLine As Integer
        firstIndex = CodeBox.GetCharIndexFromPosition(pt)
        firstLine = CodeBox.GetLineFromCharIndex(firstIndex)
        'Set X and Y co-ordinate of point to clientRectangle Width & Height respactively
        pt.X = ClientRectangle.Width
        pt.Y = ClientRectangle.Height
        'Get last index and last line number form CodeBox
        lastIndex = CodeBox.GetCharIndexFromPosition(pt)
        lastLine = CodeBox.GetLineFromCharIndex(lastIndex)
        'Set center alignment to LineNumber textBox
        lineNumberBox.SelectionAlignment = HorizontalAlignment.Center
        'Set lineNumberTextBox to null & width to getWidth function
        lineNumberBox.Text = ""
        lineNumberAndSepraterContainer.Width = getWidth()
        'Now add each line number to lineNumber text box upto last line
        For i As Integer = firstLine To (lastLine + 2) Step 1
            lineNumberBox.Text += CStr(i + 1) + Environment.NewLine
        Next
    End Sub

    Private Sub CodeBox_VScroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodeBox.VScroll
        lineNumberBox.Font = CodeBox.Font
        CodeBox.Select()
        AddLineNumbers()
    End Sub

    Private Sub lineNumberBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lineNumberBox.MouseDown
        CodeBox.Select()
        lineNumberBox.DeselectAll()
    End Sub

    Private Sub Editor_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll

    End Sub

    Private Sub containerPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles containerPanel.Paint

    End Sub

    Private Sub ResetZoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetZoomToolStripMenuItem.Click
        CodeBox.ZoomFactor = 1
        'lineNumberBox.ZoomFactor = 1
        'CodeBox.Font = codeBoxFontDialog.Font
        'lineNumberAndSepraterContainer.Width = lineNumberBox.ZoomFactor * getWidth()

    End Sub

    Private Sub prepairAppearenceForDragEnter()
        CodeBox.SendToBack()
        CodeBox.Visible = False
        CodeBox.Enabled = False
        DropFilePanel.BringToFront()
        CodeboxSepraterPanel.Visible = False
        lineNumberBox.Visible = False
        lineNumberAndSepraterContainer.Visible = False
    End Sub

    Private Sub resetAppearanceAfterDragAction()
        DropFilePanel.SendToBack()
        CodeBox.BringToFront()
        CodeBox.Visible = True
        CodeBox.Enabled = True
        CodeboxSepraterPanel.Visible = True
        lineNumberBox.Visible = True
        lineNumberAndSepraterContainer.Visible = True
    End Sub

    Private Sub Editor_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        prepairAppearenceForDragEnter()
    End Sub

    Private Sub DropFilePanel_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DropFilePanel.DragEnter
        prepairAppearenceForDragEnter()

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub DropFilePanel_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles DropFilePanel.DragDrop
        resetAppearanceAfterDragAction()
        Dim file() As String = CType(e.Data.GetData(DataFormats.FileDrop), String()) 'Returns path
        Dim fileExt As String = file(0).Substring(file(0).LastIndexOf("."))
        Dim allowedExtenstion() As String = {".c", ".cpp", ".txt"}
        If Array.IndexOf(allowedExtenstion, fileExt) > -1 Then
            If Not Mfile.Saved Then
                Dim mr As MsgBoxResult = MsgBox("Do yo want to save Current file", MsgBoxStyle.YesNoCancel, appName)
                If mr = MsgBoxResult.Yes Then
                    If Mfile.saver() <> True Then
                        MsgBox("Unable to save", , appName)
                    End If
                ElseIf mr = MsgBoxResult.No Then
                    Mfile.setCodeBoxText(file(0))
                    AddLineNumbers()
                End If
            Else
                Mfile.setCodeBoxText(file(0))
                AddLineNumbers()
            End If
        Else
            MsgBox("Only C,C++,Text file are allowed")
        End If

    End Sub

    Private Sub DropFilePanel_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropFilePanel.DragLeave
        resetAppearanceAfterDragAction()
    End Sub


    Private Sub Editor_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DragLeave
        resetAppearanceAfterDragAction()
    End Sub


End Class
