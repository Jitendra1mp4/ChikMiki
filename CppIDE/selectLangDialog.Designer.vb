<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectLangDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(selectLangDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_C = New System.Windows.Forms.Button()
        Me.OK_CPP = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_C, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_CPP, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(31, 47)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 62)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_C
        '
        Me.OK_C.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_C.Location = New System.Drawing.Point(4, 8)
        Me.OK_C.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_C.Name = "OK_C"
        Me.OK_C.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.OK_C.Size = New System.Drawing.Size(89, 45)
        Me.OK_C.TabIndex = 0
        Me.OK_C.Text = "C"
        '
        'OK_CPP
        '
        Me.OK_CPP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_CPP.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK_CPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_CPP.Location = New System.Drawing.Point(101, 8)
        Me.OK_CPP.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_CPP.Name = "OK_CPP"
        Me.OK_CPP.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.OK_CPP.Size = New System.Drawing.Size(89, 45)
        Me.OK_CPP.TabIndex = 1
        Me.OK_CPP.Text = "C++"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Language"
        '
        'selectLangDialog
        '
        Me.AcceptButton = Me.OK_C
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OK_CPP
        Me.ClientSize = New System.Drawing.Size(267, 122)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "selectLangDialog"
        Me.ShowInTaskbar = False
        Me.Text = "Select Language"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_C As System.Windows.Forms.Button
    Friend WithEvents OK_CPP As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
