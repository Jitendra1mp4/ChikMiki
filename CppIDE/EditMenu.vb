Public Class EditMenu


    Public Sub cutText()
        If Editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(Editor.CodeBox.SelectedText)
            Editor.CodeBox.SelectedText = ""
        End If
    End Sub

    Public Sub copyText()
        If Editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(Editor.CodeBox.SelectedText)
        End If
    End Sub

    Public Sub pasteText()
        Editor.CodeBox.SelectedText = Clipboard.GetText
    End Sub

    Public Sub undoText()
        If Editor.CodeBox.CanUndo Then
            Editor.CodeBox.Undo()
        End If

    End Sub

    Public Sub RedoText()
        If Editor.CodeBox.CanRedo Then
            Editor.CodeBox.Redo()
        End If
    End Sub

End Class
