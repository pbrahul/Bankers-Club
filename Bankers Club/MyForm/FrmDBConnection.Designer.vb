<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDBConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDBConnection))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rbnWindows = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbnSQL = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtServerName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUserName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.rbnWindows, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rbnSQL, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtServerName, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtUserName, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPassword, 1, 5)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(17, 8)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(379, 155)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(231, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "(Windows Authentication) "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(20, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "(SQL Server Authentication)"
        '
        'rbnWindows
        '
        Me.rbnWindows.BackColor = System.Drawing.Color.White
        Me.rbnWindows.Dock = System.Windows.Forms.DockStyle.Right
        Me.rbnWindows.ForeColor = System.Drawing.Color.Black
        Me.rbnWindows.Images.CheckedNormal = CType(resources.GetObject("rbnWindows.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnWindows.Images.CheckedPressed = CType(resources.GetObject("rbnWindows.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnWindows.Images.CheckedTracking = CType(resources.GetObject("rbnWindows.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnWindows.Images.UncheckedNormal = CType(resources.GetObject("rbnWindows.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnWindows.Images.UncheckedPressed = CType(resources.GetObject("rbnWindows.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnWindows.Images.UncheckedTracking = CType(resources.GetObject("rbnWindows.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnWindows.Location = New System.Drawing.Point(218, 3)
        Me.rbnWindows.Name = "rbnWindows"
        Me.rbnWindows.Size = New System.Drawing.Size(158, 17)
        Me.rbnWindows.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnWindows.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rbnWindows.TabIndex = 25
        Me.rbnWindows.Values.Text = "DEFAULT CONNECTION          "
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
        Me.rbnSQL.Location = New System.Drawing.Point(3, 3)
        Me.rbnSQL.Name = "rbnSQL"
        Me.rbnSQL.Size = New System.Drawing.Size(163, 17)
        Me.rbnSQL.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnSQL.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rbnSQL.TabIndex = 24
        Me.rbnSQL.Values.Text = "LAN BASE CONNECTION"
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 32)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "IP Address/Sever Name :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 32)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "User Name :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(3, 115)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 32)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Password"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtServerName
        '
        Me.txtServerName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtServerName.Border.Class = "TextBoxBorder"
        Me.txtServerName.Border.CornerDiameter = 5
        Me.txtServerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txtServerName.ForeColor = System.Drawing.Color.Black
        Me.txtServerName.Location = New System.Drawing.Point(172, 54)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(184, 26)
        Me.txtServerName.TabIndex = 30
        Me.txtServerName.WatermarkText = "Write Server IP or Server Name"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUserName.Border.Class = "TextBoxBorder"
        Me.txtUserName.Border.CornerDiameter = 5
        Me.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.Location = New System.Drawing.Point(172, 86)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(184, 26)
        Me.txtUserName.TabIndex = 31
        Me.txtUserName.WatermarkText = "User Name"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerDiameter = 5
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(172, 118)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(184, 26)
        Me.txtPassword.TabIndex = 32
        Me.txtPassword.WatermarkText = "Password"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.PanelEx3.Controls.Add(Me.Label2)
        Me.PanelEx3.Controls.Add(Me.PictureBox1)
        Me.PanelEx3.Controls.Add(Me.Label1)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(439, 50)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 260
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 26)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Database Connectivity Setup. Select option in below " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "which database connection y" & _
            "ou use" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 202
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hobo BT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(55, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 19)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Party Management System"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelEx2.Location = New System.Drawing.Point(13, 56)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(413, 170)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 261
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(268, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(158, 30)
        Me.Panel1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.Location = New System.Drawing.Point(82, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnCancel.Size = New System.Drawing.Size(76, 30)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FocusCuesEnabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnSave.Size = New System.Drawing.Size(76, 30)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.Symbol = ""
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'FrmDBConnection
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 274)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx3)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDBConnection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Setting"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rbnWindows As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbnSQL As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtServerName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUserName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
End Class
