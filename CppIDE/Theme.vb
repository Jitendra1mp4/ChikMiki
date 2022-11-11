Public Class Theme

    Private _editor As Editor

    Sub New(ByVal editor As Editor)
        ' TODO: Complete member initialization 
        _editor = editor
    End Sub

    Public Sub SetTheme(ByVal Theme As Boolean)

        My.MySettings.Default.Theme = Theme

        Dim i As Integer = 0
        If (Not Theme) Then

            'Setting Appearence for Light Mode
            _editor.lineNumberBox.BackColor = Color.White
            _editor.lineNumberBox.ForeColor = Color.Gray

            'Setting Colors for CodeBox
            _editor.CodeBox.BackColor = Color.WhiteSmoke
            _editor.CodeBox.ForeColor = Color.Maroon
            _editor.CodeboxSepraterPanel.BackColor = _editor.CodeBox.BackColor


            _editor.mainMenuStrip.BackColor = Color.White
            _editor.DownStatusStrip.BackColor = Color.White
            _editor.containerPanel.BackColor = Color.White

            _editor.DropFilePanel.BackColor = Color.YellowGreen
            _editor.DropFilePanel.ForeColor = Color.GreenYellow

            _editor.EventMessage.ForeColor = Color.Black

            For i = 0 To 5
                _editor.mainMenuStrip.Items(i).ForeColor = Color.Black
            Next

            For i = 0 To _editor.ContextMenuOfCodeBox.Items.Count - 1 Step 1
                _editor.ContextMenuOfCodeBox.Items(i).ForeColor = Color.Black
                _editor.ContextMenuOfCodeBox.Items(i).BackColor = Color.Honeydew
            Next

            For i = 0 To _editor.DownStatusStrip.Items.Count - 1
                _editor.DownStatusStrip.Items(i).ForeColor = Color.Gray
            Next

            _editor.DayNightMenuItem.BackColor = Color.Black
            _editor.DayNightMenuItem.ForeColor = Color.Honeydew

            _editor.DayNightMenuItem.Text = "Night"
            _editor.EventMessage.Text = "Light Mode Activated"

        Else

            'Setting Appearence for Night Mode

            _editor.mainMenuStrip.BackColor = Color.DimGray
            _editor.DownStatusStrip.BackColor = _editor.mainMenuStrip.BackColor
            _editor.containerPanel.BackColor = Color.Gray

            _editor.lineNumberBox.BackColor = Color.DimGray
            _editor.lineNumberBox.ForeColor = Color.LightBlue

            _editor.CodeBox.BackColor = Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
            _editor.CodeBox.ForeColor = Color.LightBlue
            _editor.CodeboxSepraterPanel.BackColor = _editor.CodeBox.BackColor

            _editor.DropFilePanel.BackColor = Color.Gray
            _editor.DropFilePanel.ForeColor = Color.DarkGray

            _editor.EventMessage.ForeColor = Color.Honeydew

            For i = 0 To 5
                _editor.mainMenuStrip.Items(i).ForeColor = Color.WhiteSmoke
            Next

            For i = 0 To _editor.ContextMenuOfCodeBox.Items.Count - 1 Step 1
                _editor.ContextMenuOfCodeBox.Items(i).ForeColor = Color.White
                _editor.ContextMenuOfCodeBox.Items(i).BackColor = Color.DimGray

            Next

            For i = 0 To _editor.DownStatusStrip.Items.Count - 1 Step 1
                _editor.DownStatusStrip.Items(i).ForeColor = Color.WhiteSmoke
            Next

            _editor.DayNightMenuItem.BackColor = Color.Honeydew
            _editor.DayNightMenuItem.ForeColor = Color.Black

            _editor.DayNightMenuItem.Text = "Light"
            _editor.EventMessage.Text = "Night Mode Activated"

        End If

        'fileManipulator.saveFile(fileManipulator.tempFilePath)
        _editor.codeChanged = False

    End Sub

    Private currentTheme As Boolean

    Public Sub manageTheme()
        SetTheme(currentTheme)
        currentTheme = Not currentTheme
    End Sub
End Class
