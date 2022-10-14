Public Class EditMenu


    Shared Sub cutText()
        If Editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(Editor.CodeBox.SelectedText)
            Editor.CodeBox.SelectedText = ""
        End If
    End Sub

    Shared Sub copyText()
        If Editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(Editor.CodeBox.SelectedText)
        End If
    End Sub

    Shared Sub pasteText()
        Editor.CodeBox.SelectedText = Clipboard.GetText
    End Sub




End Class
