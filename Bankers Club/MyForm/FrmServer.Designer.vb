<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServer))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbnWindows = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbnSQL = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtServerName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.panPatient = New DevComponents.DotNetBar.PanelEx()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(274, 67)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 19)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "(Windows Authentication)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(32, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "(SQL Server Authentication)"
        '
        'rbnWindows
        '
        Me.rbnWindows.BackColor = System.Drawing.Color.White
        Me.rbnWindows.ForeColor = System.Drawing.Color.Black
        Me.rbnWindows.Images.CheckedNormal = CType(resources.GetObject("rbnWindows.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnWindows.Images.CheckedPressed = CType(resources.GetObject("rbnWindows.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnWindows.Images.CheckedTracking = CType(resources.GetObject("rbnWindows.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnWindows.Images.UncheckedNormal = CType(resources.GetObject("rbnWindows.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnWindows.Images.UncheckedPressed = CType(resources.GetObject("rbnWindows.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnWindows.Images.UncheckedTracking = CType(resources.GetObject("rbnWindows.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnWindows.Location = New System.Drawing.Point(258, 50)
        Me.rbnWindows.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbnWindows.Name = "rbnWindows"
        Me.rbnWindows.Size = New System.Drawing.Size(212, 22)
        Me.rbnWindows.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnWindows.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rbnWindows.TabIndex = 25
        Me.rbnWindows.Values.Text = "STANDALONE CONNECTION"
        '
        'rbnSQL
        '
        Me.rbnSQL.BackColor = System.Drawing.Color.White
        Me.rbnSQL.Checked = True
        Me.rbnSQL.ForeColor = System.Drawing.Color.Black
        Me.rbnSQL.Images.CheckedNormal = CType(resources.GetObject("rbnSQL.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnSQL.Images.CheckedPressed = CType(resources.GetObject("rbnSQL.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnSQL.Images.CheckedTracking = CType(resources.GetObject("rbnSQL.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnSQL.Images.UncheckedNormal = CType(resources.GetObject("rbnSQL.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnSQL.Images.UncheckedPressed = CType(resources.GetObject("rbnSQL.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnSQL.Images.UncheckedTracking = CType(resources.GetObject("rbnSQL.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnSQL.Location = New System.Drawing.Point(18, 50)
        Me.rbnSQL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbnSQL.Name = "rbnSQL"
        Me.rbnSQL.Size = New System.Drawing.Size(185, 22)
        Me.rbnSQL.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnSQL.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rbnSQL.TabIndex = 24
        Me.rbnSQL.Values.Text = "LAN BASE CONNECTION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(436, 13)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Database Connectivity Setup. Select option in below which database connection you" & _
    " use." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.txtServerName, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtUserName, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtPassword, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(19, 94)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 9
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(439, 121)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'txtServerName
        '
        Me.txtServerName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtServerName.Border.Class = "TextBoxBorder"
        Me.txtServerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtServerName.ForeColor = System.Drawing.Color.Black
        Me.txtServerName.Location = New System.Drawing.Point(176, 5)
        Me.txtServerName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(259, 27)
        Me.txtServerName.TabIndex = 0
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.Location = New System.Drawing.Point(176, 42)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(259, 27)
        Me.txtUserName.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(176, 79)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(259, 27)
        Me.txtPassword.TabIndex = 2
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(5, 80)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(71, 22)
        Me.LabelX3.TabIndex = 210
        Me.LabelX3.Text = "Password :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(5, 43)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(82, 22)
        Me.LabelX2.TabIndex = 207
        Me.LabelX2.Text = "User Name :"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(5, 6)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(162, 22)
        Me.LabelX1.TabIndex = 206
        Me.LabelX1.Text = "IP Address/Sever Name :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(286, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 36)
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
        Me.btnCancel.Location = New System.Drawing.Point(88, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(80, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FocusCuesEnabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnSave.Size = New System.Drawing.Size(80, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.Symbol = ""
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'panPatient
        '
        Me.panPatient.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPatient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPatient.Controls.Add(Me.lblTitle)
        Me.panPatient.Location = New System.Drawing.Point(12, -12)
        Me.panPatient.Name = "panPatient"
        Me.panPatient.Size = New System.Drawing.Size(446, 39)
        Me.panPatient.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPatient.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panPatient.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPatient.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panPatient.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panPatient.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPatient.Style.GradientAngle = 90
        Me.panPatient.TabIndex = 343
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(4, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 25)
        Me.lblTitle.TabIndex = 297
        Me.lblTitle.Text = "Bankers Club Chittagong"
        '
        'FrmServer
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 299)
        Me.Controls.Add(Me.panPatient)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbnWindows)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.rbnSQL)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmServer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Setting"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panPatient.ResumeLayout(False)
        Me.panPatient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rbnWindows As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbnSQL As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtServerName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panPatient As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
