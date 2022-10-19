Public Class Theme

    Shared Sub SetTheme(ByVal Theme As Boolean)

        My.MySettings.Default.Theme = Theme

        Dim i As Integer = 0
        If (Not Theme) Then

            'Setting Appearence for Light Mode
            Editor.lineNumberBox.BackColor = Color.White
            Editor.lineNumberBox.ForeColor = Color.Gray


            Editor.CodeBox.BackColor = Color.WhiteSmoke
            Editor.CodeBox.ForeColor = Color.DarkCyan

            Editor.MainMenuStrip.BackColor = Color.White
            'Editor.LeftPanel.BackColor = Color.White
            Editor.DownStatusStrip.BackColor = Color.White
            Editor.containerPanel.BackColor = Color.White

            For i = 0 To 5
                Editor.MainMenuStrip.Items(i).ForeColor = Color.Black
            Next

            For i = 0 To Editor.ContextMenuOfCodeBox.Items.Count - 1 Step 1
                Editor.ContextMenuOfCodeBox.Items(i).ForeColor = Color.Black
                Editor.ContextMenuOfCodeBox.Items(i).BackColor = Color.Honeydew
            Next


            For i = 0 To Editor.DownStatusStrip.Items.Count - 1
                Editor.DownStatusStrip.Items(i).ForeColor = Color.Gray
            Next

            Editor.DayNightMenuItem.BackColor = Color.Black
            Editor.DayNightMenuItem.ForeColor = Color.Honeydew

            Editor.DayNightMenuItem.Text = "Night"

        Else

            'Setting Appearence for Night Mode


            Editor.lineNumberBox.BackColor = Color.DimGray
            Editor.lineNumberBox.ForeColor = Color.PaleGreen

            'Editor.CodeBox.BackColor = Color.DimGray
            Editor.CodeBox.BackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Editor.CodeBox.ForeColor = Color.Aqua

            Editor.mainMenuStrip.BackColor = Color.DimGray
            'Editor.MainMenuStrip.BackColor = Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
            'Editor.LeftPanel.BackColor = Color.Gray
            Editor.DownStatusStrip.BackColor = Color.DimGray
            Editor.containerPanel.BackColor = Color.Gray
            For i = 0 To 5
                Editor.MainMenuStrip.Items(i).ForeColor = Color.WhiteSmoke
            Next

            For i = 0 To Editor.ContextMenuOfCodeBox.Items.Count - 1 Step 1
                Editor.ContextMenuOfCodeBox.Items(i).ForeColor = Color.White
                Editor.ContextMenuOfCodeBox.Items(i).BackColor = Color.DimGray

            Next

            For i = 0 To Editor.DownStatusStrip.Items.Count - 1 Step 1
                Editor.DownStatusStrip.Items(i).ForeColor = Color.WhiteSmoke
            Next

            Editor.DayNightMenuItem.BackColor = Color.Honeydew
            Editor.DayNightMenuItem.ForeColor = Color.Black

            Editor.DayNightMenuItem.Text = "Light"

        End If

        fileManipulation.saveFile(fileManipulation.tempFilePath)
        fileManipulation.codeChanged = False

    End Sub

    Shared currentTheme As Boolean
    Shared Sub manageTheme()
        SetTheme(currentTheme)
        currentTheme = Not currentTheme
    End Sub
End Class
