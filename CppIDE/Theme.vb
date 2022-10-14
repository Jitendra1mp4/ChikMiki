Public Class Theme
    Shared Sub manageTheme()
        Dim i As Integer = 0



        If Editor.DayNightMenuItem.Text = "Light" Then
            Editor.DayNightMenuItem.Text = "Night"

            Editor.CodeBox.BackColor = Color.WhiteSmoke
            Editor.CodeBox.ForeColor = Color.DarkCyan

            Editor.MainMenuStrip.BackColor = Color.White
            Editor.lineNumberPanel.BackColor = Color.White
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


        Else
            Editor.DayNightMenuItem.Text = "Light"

            Editor.CodeBox.BackColor = Color.DimGray
            Editor.CodeBox.ForeColor = Color.Aqua

            Editor.MainMenuStrip.BackColor = Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
            Editor.lineNumberPanel.BackColor = Color.Gray
            Editor.DownStatusStrip.BackColor = Color.Gray
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
        End If

        fileManipulation.saveFile(fileManipulation.tempFilePath)
        fileManipulation.codeChanged = False

    End Sub
End Class
