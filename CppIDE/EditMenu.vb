Public Class EditMenu

    Private _editor As Editor

    Sub New(ByRef editor As Editor)
        ' TODO: Complete member initialization 
        _editor = editor
    End Sub

    Public Sub cutText()
        If _editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(_editor.CodeBox.SelectedText)
            _editor.CodeBox.SelectedText = ""
        End If
    End Sub

    Public Sub copyText()
        If _editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(_editor.CodeBox.SelectedText)
        End If
    End Sub

    Public Sub pasteText()
        _editor.CodeBox.SelectedText = Clipboard.GetText
    End Sub

    Public Sub undoText()
        If _editor.CodeBox.CanUndo Then
            _editor.CodeBox.Undo()
        End If

    End Sub

    Public Sub RedoText()
        If _editor.CodeBox.CanRedo Then
            _editor.CodeBox.Redo()
        End If
    End Sub

End Class
