Public Class EditMenu

    Private _editor As Editor
    Private undoStack As New Stack(Of String)
    Private redoStack As New Stack(Of String)

    Sub New(ByRef edtr As Editor)
        ' TODO: Complete member initialization 
        _editor = edtr
        'undoStack.Push(_editor.CodeBox.Text)
    End Sub

    Public Sub cutText()
        If _editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(_editor.CodeBox.SelectedText)
            _editor.CodeBox.SelectedText = ""
            _editor.EventMessage.Text = "Cut success..."
        End If
    End Sub

    Public Sub copyText()
        If _editor.CodeBox.SelectedText <> "" Then
            Clipboard.SetText(_editor.CodeBox.SelectedText)
            _editor.EventMessage.Text = " Text Copied"
        End If
    End Sub

    Public Sub pasteText()
        _editor.CodeBox.SelectedText = Clipboard.GetText
        _editor.EventMessage.Text = "Text Pasted..."
    End Sub

    Public Sub undoText()
        If canUndo() Then
            AddToRedoStack()
            undoStack.Pop() 'To remove last push
            _editor.CodeBox.Text = undoStack.Pop()
        End If

    End Sub

    Public Sub RedoText()
        If canRedo() Then
            _editor.CodeBox.Text = redoStack.Pop()
        End If
    End Sub

    Public Sub AddToUndoStack()
        undoStack.Push(_editor.CodeBox.Text)
    End Sub

    Public Sub AddToRedoStack()
        redoStack.Push(_editor.CodeBox.Text)
    End Sub

    Public Function canUndo() As Boolean
        Return undoStack.Count > 1
    End Function

    Public Function canRedo() As Boolean
        Return redoStack.Count <> 0
    End Function

End Class
