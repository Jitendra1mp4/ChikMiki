<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.containerPanel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CodeBox = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuOfCodeBox = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CutOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.PastPast = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompileCodeOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunCodeOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ButifyOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.lineNumberPanel = New System.Windows.Forms.Panel()
        Me.DownStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.numberOfWords = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkPendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseCTRLScrollToZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormateCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendFeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayNightMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RUNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SAVEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.codeBoxFontDialog = New System.Windows.Forms.FontDialog()
        Me.containerPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ContextMenuOfCodeBox.SuspendLayout()
        Me.DownStatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'containerPanel
        '
        Me.containerPanel.BackColor = System.Drawing.Color.DimGray
        Me.containerPanel.Controls.Add(Me.Panel3)
        Me.containerPanel.Controls.Add(Me.lineNumberPanel)
        Me.containerPanel.Controls.Add(Me.DownStatusStrip)
        Me.containerPanel.Controls.Add(Me.MenuStrip1)
        Me.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.containerPanel.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.containerPanel.Location = New System.Drawing.Point(0, 0)
        Me.containerPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.containerPanel.Name = "containerPanel"
        Me.containerPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.containerPanel.Size = New System.Drawing.Size(759, 321)
        Me.containerPanel.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Controls.Add(Me.CodeBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(22, 35)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 260)
        Me.Panel3.TabIndex = 6
        '
        'CodeBox
        '
        Me.CodeBox.AcceptsTab = True
        Me.CodeBox.AutoWordSelection = True
        Me.CodeBox.BackColor = System.Drawing.Color.DimGray
        Me.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CodeBox.ContextMenuStrip = Me.ContextMenuOfCodeBox
        Me.CodeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CodeBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CodeBox.EnableAutoDragDrop = True
        Me.CodeBox.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodeBox.ForeColor = System.Drawing.Color.Aqua
        Me.CodeBox.Location = New System.Drawing.Point(0, 0)
        Me.CodeBox.Margin = New System.Windows.Forms.Padding(26, 35, 32, 43)
        Me.CodeBox.Name = "CodeBox"
        Me.CodeBox.Size = New System.Drawing.Size(733, 260)
        Me.CodeBox.TabIndex = 4
        Me.CodeBox.Text = "#include <stdio.h>" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "int main(){" & Global.Microsoft.VisualBasic.ChrW(10) & "    printf(""hello world\n"") ;" & Global.Microsoft.VisualBasic.ChrW(10) & "    return 0 ;" & Global.Microsoft.VisualBasic.ChrW(10) & "}"
        Me.CodeBox.WordWrap = False
        '
        'ContextMenuOfCodeBox
        '
        Me.ContextMenuOfCodeBox.BackColor = System.Drawing.Color.DimGray
        Me.ContextMenuOfCodeBox.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutOption, Me.CopyOption, Me.PastPast, Me.ToolStripSeparator1, Me.CompileCodeOption, Me.RunCodeOption, Me.ToolStripSeparator2, Me.ButifyOption})
        Me.ContextMenuOfCodeBox.Margin = New System.Windows.Forms.Padding(5)
        Me.ContextMenuOfCodeBox.Name = "ContextMenuStrip1"
        Me.ContextMenuOfCodeBox.Size = New System.Drawing.Size(151, 148)
        '
        'CutOption
        '
        Me.CutOption.BackColor = System.Drawing.Color.DimGray
        Me.CutOption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CutOption.Name = "CutOption"
        Me.CutOption.Size = New System.Drawing.Size(150, 22)
        Me.CutOption.Text = "Cut"
        '
        'CopyOption
        '
        Me.CopyOption.BackColor = System.Drawing.Color.DimGray
        Me.CopyOption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CopyOption.Name = "CopyOption"
        Me.CopyOption.Size = New System.Drawing.Size(150, 22)
        Me.CopyOption.Text = "Copy"
        '
        'PastPast
        '
        Me.PastPast.BackColor = System.Drawing.Color.DimGray
        Me.PastPast.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.PastPast.Name = "PastPast"
        Me.PastPast.Size = New System.Drawing.Size(150, 22)
        Me.PastPast.Text = "Past"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'CompileCodeOption
        '
        Me.CompileCodeOption.BackColor = System.Drawing.Color.DimGray
        Me.CompileCodeOption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.CompileCodeOption.Name = "CompileCodeOption"
        Me.CompileCodeOption.Size = New System.Drawing.Size(150, 22)
        Me.CompileCodeOption.Text = "Compile Code"
        '
        'RunCodeOption
        '
        Me.RunCodeOption.BackColor = System.Drawing.Color.DimGray
        Me.RunCodeOption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RunCodeOption.Name = "RunCodeOption"
        Me.RunCodeOption.Size = New System.Drawing.Size(150, 22)
        Me.RunCodeOption.Text = "Run Code"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'ButifyOption
        '
        Me.ButifyOption.BackColor = System.Drawing.Color.DimGray
        Me.ButifyOption.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButifyOption.Name = "ButifyOption"
        Me.ButifyOption.Size = New System.Drawing.Size(150, 22)
        Me.ButifyOption.Text = "^Butify Code"
        '
        'lineNumberPanel
        '
        Me.lineNumberPanel.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.lineNumberPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.lineNumberPanel.Enabled = False
        Me.lineNumberPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lineNumberPanel.Location = New System.Drawing.Point(4, 35)
        Me.lineNumberPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.lineNumberPanel.Name = "lineNumberPanel"
        Me.lineNumberPanel.Size = New System.Drawing.Size(18, 260)
        Me.lineNumberPanel.TabIndex = 5
        '
        'DownStatusStrip
        '
        Me.DownStatusStrip.BackColor = System.Drawing.Color.Gray
        Me.DownStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.numberOfWords, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.DownStatusStrip.Location = New System.Drawing.Point(4, 295)
        Me.DownStatusStrip.Name = "DownStatusStrip"
        Me.DownStatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.DownStatusStrip.Size = New System.Drawing.Size(751, 22)
        Me.DownStatusStrip.TabIndex = 4
        Me.DownStatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel1.Text = "Length"
        '
        'numberOfWords
        '
        Me.numberOfWords.Name = "numberOfWords"
        Me.numberOfWords.Size = New System.Drawing.Size(13, 17)
        Me.numberOfWords.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel2.Text = "        Lines"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel3.Text = "0"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(140, 17)
        Me.ToolStripStatusLabel4.Text = "            |                   C/C++"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ViewToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem, Me.DayNightMenuItem, Me.ToolStripMenuItem1, Me.RUNToolStripMenuItem, Me.SAVEToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(4, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(751, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "mainMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(50, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(185, 28)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(185, 28)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(185, 28)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(185, 28)
        Me.SaveAsToolStripMenuItem.Text = "Save As.."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutMenuItem, Me.CopyMenuItem, Me.PasteMenuItem, Me.GoToMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(52, 27)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutMenuItem
        '
        Me.CutMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CutMenuItem.Name = "CutMenuItem"
        Me.CutMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.CutMenuItem.Text = "Cut"
        '
        'CopyMenuItem
        '
        Me.CopyMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyMenuItem.Name = "CopyMenuItem"
        Me.CopyMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.CopyMenuItem.Text = "Copy"
        '
        'PasteMenuItem
        '
        Me.PasteMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasteMenuItem.Name = "PasteMenuItem"
        Me.PasteMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.PasteMenuItem.Text = "Paste"
        '
        'GoToMenuItem
        '
        Me.GoToMenuItem.Enabled = False
        Me.GoToMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoToMenuItem.Name = "GoToMenuItem"
        Me.GoToMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GoToMenuItem.Size = New System.Drawing.Size(180, 28)
        Me.GoToMenuItem.Text = "Go to"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkPendingToolStripMenuItem})
        Me.SearchToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(74, 27)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'WorkPendingToolStripMenuItem
        '
        Me.WorkPendingToolStripMenuItem.Enabled = False
        Me.WorkPendingToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkPendingToolStripMenuItem.Name = "WorkPendingToolStripMenuItem"
        Me.WorkPendingToolStripMenuItem.Size = New System.Drawing.Size(186, 28)
        Me.WorkPendingToolStripMenuItem.Text = "Work pending"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(60, 27)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UseCTRLScrollToZoomToolStripMenuItem})
        Me.ZoomToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(159, 28)
        Me.ZoomToolStripMenuItem.Text = "Zoom"
        '
        'UseCTRLScrollToZoomToolStripMenuItem
        '
        Me.UseCTRLScrollToZoomToolStripMenuItem.Name = "UseCTRLScrollToZoomToolStripMenuItem"
        Me.UseCTRLScrollToZoomToolStripMenuItem.Size = New System.Drawing.Size(329, 28)
        Me.UseCTRLScrollToZoomToolStripMenuItem.Text = "Use CTRL+Mouse Scroll to zoom"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(159, 28)
        Me.StatusBarToolStripMenuItem.Text = "Status Bar"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorToolStripMenuItem, Me.FontToolStripMenuItem, Me.FormateCodeToolStripMenuItem})
        Me.FormatToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormatToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(76, 27)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'WorToolStripMenuItem
        '
        Me.WorToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorToolStripMenuItem.Name = "WorToolStripMenuItem"
        Me.WorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.WorToolStripMenuItem.Size = New System.Drawing.Size(284, 28)
        Me.WorToolStripMenuItem.Text = "Word Wrap"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(284, 28)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'FormateCodeToolStripMenuItem
        '
        Me.FormateCodeToolStripMenuItem.Name = "FormateCodeToolStripMenuItem"
        Me.FormateCodeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FormateCodeToolStripMenuItem.Size = New System.Drawing.Size(284, 28)
        Me.FormateCodeToolStripMenuItem.Text = "^Butify Code"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.SendFeedbackToolStripMenuItem, Me.AboutDeveloperToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(57, 27)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Enabled = False
        Me.ViewHelpToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.ViewHelpToolStripMenuItem.Text = "View help"
        '
        'SendFeedbackToolStripMenuItem
        '
        Me.SendFeedbackToolStripMenuItem.Enabled = False
        Me.SendFeedbackToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem"
        Me.SendFeedbackToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.SendFeedbackToolStripMenuItem.Text = "Send feedback"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Software"
        '
        'DayNightMenuItem
        '
        Me.DayNightMenuItem.BackColor = System.Drawing.Color.Honeydew
        Me.DayNightMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DayNightMenuItem.Name = "DayNightMenuItem"
        Me.DayNightMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.DayNightMenuItem.Size = New System.Drawing.Size(61, 27)
        Me.DayNightMenuItem.Text = "Light"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.SlateGray
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(83, 27)
        Me.ToolStripMenuItem1.Text = "Compile"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(333, 28)
        Me.ToolStripMenuItem3.Text = "Run"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(333, 28)
        Me.ToolStripMenuItem4.Text = "Compile"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(333, 28)
        Me.ToolStripMenuItem5.Text = "Give Args and RUN"
        '
        'RUNToolStripMenuItem
        '
        Me.RUNToolStripMenuItem.BackColor = System.Drawing.Color.LightGreen
        Me.RUNToolStripMenuItem.Font = New System.Drawing.Font("Sitka Small", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RUNToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RUNToolStripMenuItem.Name = "RUNToolStripMenuItem"
        Me.RUNToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RUNToolStripMenuItem.Size = New System.Drawing.Size(57, 27)
        Me.RUNToolStripMenuItem.Text = "RUN"
        '
        'SAVEToolStripMenuItem1
        '
        Me.SAVEToolStripMenuItem1.BackColor = System.Drawing.Color.Gold
        Me.SAVEToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.SAVEToolStripMenuItem1.Name = "SAVEToolStripMenuItem1"
        Me.SAVEToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SAVEToolStripMenuItem1.Size = New System.Drawing.Size(60, 27)
        Me.SAVEToolStripMenuItem1.Text = "SAVE"
        '
        'Editor
        '
        Me.AccessibleName = "EditorForm"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(759, 321)
        Me.Controls.Add(Me.containerPanel)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Editor"
        Me.Text = "Code Editor Alpha"
        Me.containerPanel.ResumeLayout(False)
        Me.containerPanel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ContextMenuOfCodeBox.ResumeLayout(False)
        Me.DownStatusStrip.ResumeLayout(False)
        Me.DownStatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents containerPanel As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkPendingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendFeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RUNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lineNumberPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CodeBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SAVEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents codeBoxFontDialog As System.Windows.Forms.FontDialog
    Friend WithEvents ContextMenuOfCodeBox As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PastPast As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunCodeOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UseCTRLScrollToZoomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompileCodeOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents numberOfWords As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DayNightMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormateCodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ButifyOption As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
