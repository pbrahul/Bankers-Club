<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevice
    Inherits DevComponents.DotNetBar.Metro.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDevice))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnConnect = New DevComponents.DotNetBar.ButtonX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtPort = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panStudent = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panStudent.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnConnect)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(250, 158)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 36)
        Me.Panel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.Location = New System.Drawing.Point(93, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnConnect
        '
        Me.btnConnect.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnConnect.FocusCuesEnabled = False
        Me.btnConnect.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnConnect.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnConnect.Location = New System.Drawing.Point(0, 0)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnConnect.Size = New System.Drawing.Size(87, 36)
        Me.btnConnect.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnConnect.Symbol = ""
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 133)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 213
        Me.PictureBox1.TabStop = False
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Bank", "Person"})
        Me.cmbType.Location = New System.Drawing.Point(107, 4)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(201, 28)
        Me.cmbType.TabIndex = 0
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPort.Border.Class = "TextBoxBorder"
        Me.txtPort.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPort.Enabled = False
        Me.txtPort.ForeColor = System.Drawing.Color.Black
        Me.txtPort.Location = New System.Drawing.Point(106, 39)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(202, 27)
        Me.txtPort.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(95, 22)
        Me.LabelX1.TabIndex = 207
        Me.LabelX1.Text = "Select Device :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 40)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(60, 22)
        Me.LabelX2.TabIndex = 208
        Me.LabelX2.Text = "Port No :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 73)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(95, 22)
        Me.LabelX3.TabIndex = 209
        Me.LabelX3.Text = "Device Name :"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPort, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbType, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtName, 1, 2)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(122, 47)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(314, 103)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.Enabled = False
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(106, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(202, 27)
        Me.txtName.TabIndex = 2
        '
        'panStudent
        '
        Me.panStudent.CanvasColor = System.Drawing.SystemColors.Control
        Me.panStudent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panStudent.Controls.Add(Me.Label3)
        Me.panStudent.Location = New System.Drawing.Point(18, -8)
        Me.panStudent.Name = "panStudent"
        Me.panStudent.Size = New System.Drawing.Size(418, 39)
        Me.panStudent.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panStudent.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panStudent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panStudent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panStudent.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panStudent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panStudent.Style.GradientAngle = 90
        Me.panStudent.TabIndex = 300
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 25)
        Me.Label3.TabIndex = 297
        Me.Label3.Text = "Connect a GSM Mobile / Modem"
        '
        'FrmDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 215)
        Me.Controls.Add(Me.panStudent)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDevice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connect Device"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panStudent.ResumeLayout(False)
        Me.panStudent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnConnect As DevComponents.DotNetBar.ButtonX
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPort As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents panStudent As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
