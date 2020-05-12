<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSMS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSMS))
        Me.lblChar = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnStop = New DevComponents.DotNetBar.ButtonX()
        Me.btnSend = New DevComponents.DotNetBar.ButtonX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtSMS = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSend = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.panToken = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panToken.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChar
        '
        Me.lblChar.BackColor = System.Drawing.Color.Transparent
        Me.lblChar.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChar.ForeColor = System.Drawing.Color.Black
        Me.lblChar.Location = New System.Drawing.Point(129, 131)
        Me.lblChar.Name = "lblChar"
        Me.lblChar.Size = New System.Drawing.Size(275, 20)
        Me.lblChar.TabIndex = 256
        Me.lblChar.Text = "Total Writing Characters : 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 202
        Me.PictureBox1.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnStop.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStop.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnStop.FocusCuesEnabled = False
        Me.btnStop.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(100, 0)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnStop.Size = New System.Drawing.Size(89, 36)
        Me.btnStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'btnSend
        '
        Me.btnSend.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSend.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSend.FocusCuesEnabled = False
        Me.btnSend.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.Location = New System.Drawing.Point(0, 0)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnSend.Size = New System.Drawing.Size(91, 36)
        Me.btnSend.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnSend)
        Me.Panel3.Controls.Add(Me.btnStop)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(240, 233)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(189, 36)
        Me.Panel3.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.cmbType, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSMS, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSend, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblChar, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 0, 3)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(18, 40)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(411, 184)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"English", "Bangla"})
        Me.cmbType.Location = New System.Drawing.Point(130, 4)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(274, 28)
        Me.cmbType.TabIndex = 0
        '
        'txtSMS
        '
        Me.txtSMS.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSMS.Border.Class = "TextBoxBorder"
        Me.txtSMS.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSMS.ForeColor = System.Drawing.Color.Black
        Me.txtSMS.Location = New System.Drawing.Point(129, 39)
        Me.txtSMS.Multiline = True
        Me.txtSMS.Name = "txtSMS"
        Me.txtSMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSMS.Size = New System.Drawing.Size(275, 89)
        Me.txtSMS.TabIndex = 1
        '
        'txtSend
        '
        Me.txtSend.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSend.Border.Class = "TextBoxBorder"
        Me.txtSend.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSend.Enabled = False
        Me.txtSend.ForeColor = System.Drawing.Color.Black
        Me.txtSend.Location = New System.Drawing.Point(129, 154)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(275, 27)
        Me.txtSend.TabIndex = 2
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
        Me.LabelX2.Size = New System.Drawing.Size(75, 22)
        Me.LabelX2.TabIndex = 208
        Me.LabelX2.Text = "SMS Body :"
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
        Me.LabelX1.Size = New System.Drawing.Size(74, 22)
        Me.LabelX1.TabIndex = 207
        Me.LabelX1.Text = "SMS Type :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 155)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(118, 22)
        Me.LabelX3.TabIndex = 209
        Me.LabelX3.Text = "Total SMS Count :"
        '
        'panToken
        '
        Me.panToken.CanvasColor = System.Drawing.SystemColors.Control
        Me.panToken.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panToken.Controls.Add(Me.Label2)
        Me.panToken.Controls.Add(Me.PictureBox1)
        Me.panToken.Location = New System.Drawing.Point(18, -4)
        Me.panToken.Name = "panToken"
        Me.panToken.Size = New System.Drawing.Size(404, 39)
        Me.panToken.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panToken.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panToken.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panToken.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panToken.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panToken.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panToken.Style.GradientAngle = 90
        Me.panToken.TabIndex = 301
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(44, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 25)
        Me.Label2.TabIndex = 297
        Me.Label2.Text = "SMS Sending"
        '
        'FrmSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 286)
        Me.Controls.Add(Me.panToken)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSMS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Send SMS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panToken.ResumeLayout(False)
        Me.panToken.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents lblChar As System.Windows.Forms.Label
    Friend WithEvents btnStop As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSend As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSMS As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtSend As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panToken As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
