<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReflectionImage1 = New DevComponents.DotNetBar.Controls.ReflectionImage()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.txtPassword = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.txtUser = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.lblPassword = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSignIn = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.ReflectionLabel1 = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Panel3.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(135, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please fill out the field below to start."
        '
        'ReflectionImage1
        '
        '
        '
        '
        Me.ReflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.ReflectionImage1.ForeColor = System.Drawing.Color.Black
        Me.ReflectionImage1.Image = CType(resources.GetObject("ReflectionImage1.Image"), System.Drawing.Image)
        Me.ReflectionImage1.Location = New System.Drawing.Point(11, 28)
        Me.ReflectionImage1.Name = "ReflectionImage1"
        Me.ReflectionImage1.Size = New System.Drawing.Size(84, 178)
        Me.ReflectionImage1.TabIndex = 2
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.BackColor = System.Drawing.Color.White
        Me.KryptonLabel3.ForeColor = System.Drawing.Color.Black
        Me.KryptonLabel3.Location = New System.Drawing.Point(110, 100)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Size = New System.Drawing.Size(95, 22)
        Me.KryptonLabel3.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel3.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel3.TabIndex = 17
        Me.KryptonLabel3.Values.Text = "User Name :"
        '
        'txtPassword
        '
        Me.txtPassword.AlwaysActive = False
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtPassword.Location = New System.Drawing.Point(210, 127)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(159, 25)
        Me.txtPassword.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassword.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtPassword.StateActive.Content.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtPassword.StateCommon.Border.Rounding = 4
        Me.txtPassword.StateCommon.Border.Width = 1
        Me.txtPassword.StateCommon.Content.Color1 = System.Drawing.Color.Red
        Me.txtPassword.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.TabIndex = 1
        '
        'txtUser
        '
        Me.txtUser.AlwaysActive = False
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtUser.Location = New System.Drawing.Point(210, 97)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtUser.Size = New System.Drawing.Size(159, 26)
        Me.txtUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtUser.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUser.StateActive.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtUser.StateCommon.Border.Rounding = 4
        Me.txtUser.StateCommon.Border.Width = 1
        Me.txtUser.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.TabIndex = 0
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.Color.White
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(121, 129)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(84, 22)
        Me.lblPassword.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblPassword.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.TabIndex = 14
        Me.lblPassword.Values.Text = "Password :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Controls.Add(Me.btnSignIn)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(210, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(159, 31)
        Me.Panel3.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FocusCuesEnabled = False
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(83, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 31)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnExit.Symbol = ""
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        '
        'btnSignIn
        '
        Me.btnSignIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSignIn.FocusCuesEnabled = False
        Me.btnSignIn.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSignIn.Location = New System.Drawing.Point(0, 0)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(80, 31)
        Me.btnSignIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSignIn.Symbol = ""
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "Sign In"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.ReflectionLabel1)
        Me.PanelEx1.Controls.Add(Me.ReflectionImage1)
        Me.PanelEx1.Controls.Add(Me.Panel3)
        Me.PanelEx1.Controls.Add(Me.KryptonLabel3)
        Me.PanelEx1.Controls.Add(Me.txtPassword)
        Me.PanelEx1.Controls.Add(Me.txtUser)
        Me.PanelEx1.Controls.Add(Me.lblPassword)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(407, 219)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 18
        '
        'ReflectionLabel1
        '
        '
        '
        '
        Me.ReflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ReflectionLabel1.Font = New System.Drawing.Font("Hobo BT", 8.5!)
        Me.ReflectionLabel1.Location = New System.Drawing.Point(138, 12)
        Me.ReflectionLabel1.Name = "ReflectionLabel1"
        Me.ReflectionLabel1.Size = New System.Drawing.Size(253, 47)
        Me.ReflectionLabel1.TabIndex = 18
        Me.ReflectionLabel1.Text = "<b><font size=""+6"" color=""#B02B2C""><i>Bankers Club</i><font  color=""#000000""> Chi" & _
    "ttagong</font></font></b>"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(407, 219)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sing In"
        Me.Panel3.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReflectionImage1 As DevComponents.DotNetBar.Controls.ReflectionImage
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents txtPassword As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents txtUser As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lblPassword As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSignIn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents ReflectionLabel1 As DevComponents.DotNetBar.Controls.ReflectionLabel
End Class
