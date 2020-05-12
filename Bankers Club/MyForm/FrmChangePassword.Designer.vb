<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtOldPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtNewPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtVerifyPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.KryptonLabel7 = New DevComponents.DotNetBar.LabelX()
        Me.KryptonLabel1 = New DevComponents.DotNetBar.LabelX()
        Me.KryptonLabel2 = New DevComponents.DotNetBar.LabelX()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnExit = New DevComponents.DotNetBar.ButtonX()
        Me.btnSignIn = New DevComponents.DotNetBar.ButtonX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 48)
        Me.Panel1.TabIndex = 219
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(62, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 16)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "Enter Complex and Secure Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hobo BT", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(61, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Your Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtOldPassword)
        Me.PanelEx2.Controls.Add(Me.txtNewPassword)
        Me.PanelEx2.Controls.Add(Me.txtVerifyPassword)
        Me.PanelEx2.Controls.Add(Me.PictureBox1)
        Me.PanelEx2.Controls.Add(Me.KryptonLabel7)
        Me.PanelEx2.Controls.Add(Me.KryptonLabel1)
        Me.PanelEx2.Controls.Add(Me.KryptonLabel2)
        Me.PanelEx2.Location = New System.Drawing.Point(10, 54)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(350, 148)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'txtOldPassword
        '
        Me.txtOldPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtOldPassword.Border.Class = "RibbonGalleryContainer"
        Me.txtOldPassword.Border.CornerDiameter = 4
        Me.txtOldPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txtOldPassword.ForeColor = System.Drawing.Color.Black
        Me.txtOldPassword.Location = New System.Drawing.Point(149, 25)
        Me.txtOldPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtOldPassword.Size = New System.Drawing.Size(187, 22)
        Me.txtOldPassword.TabIndex = 0
        Me.txtOldPassword.WatermarkText = "Current Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNewPassword.Border.Class = "RibbonGalleryContainer"
        Me.txtNewPassword.Border.CornerDiameter = 4
        Me.txtNewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txtNewPassword.ForeColor = System.Drawing.Color.Black
        Me.txtNewPassword.Location = New System.Drawing.Point(149, 70)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword.Size = New System.Drawing.Size(187, 22)
        Me.txtNewPassword.TabIndex = 1
        Me.txtNewPassword.WatermarkText = "New Password"
        '
        'txtVerifyPassword
        '
        Me.txtVerifyPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtVerifyPassword.Border.Class = "RibbonGalleryContainer"
        Me.txtVerifyPassword.Border.CornerDiameter = 4
        Me.txtVerifyPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.txtVerifyPassword.ForeColor = System.Drawing.Color.Black
        Me.txtVerifyPassword.Location = New System.Drawing.Point(149, 117)
        Me.txtVerifyPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtVerifyPassword.Name = "txtVerifyPassword"
        Me.txtVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtVerifyPassword.Size = New System.Drawing.Size(187, 22)
        Me.txtVerifyPassword.TabIndex = 2
        Me.txtVerifyPassword.WatermarkText = "Repat New Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 158
        Me.PictureBox1.TabStop = False
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.KryptonLabel7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.KryptonLabel7.ForeColor = System.Drawing.Color.Black
        Me.KryptonLabel7.Location = New System.Drawing.Point(149, 4)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Size = New System.Drawing.Size(108, 22)
        Me.KryptonLabel7.TabIndex = 153
        Me.KryptonLabel7.Text = "Current Password :"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.KryptonLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.KryptonLabel1.ForeColor = System.Drawing.Color.Black
        Me.KryptonLabel1.Location = New System.Drawing.Point(149, 49)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(115, 22)
        Me.KryptonLabel1.TabIndex = 155
        Me.KryptonLabel1.Text = "New Password :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.KryptonLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.KryptonLabel2.ForeColor = System.Drawing.Color.Black
        Me.KryptonLabel2.Location = New System.Drawing.Point(149, 96)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(125, 22)
        Me.KryptonLabel2.TabIndex = 157
        Me.KryptonLabel2.Text = "Confirm Password :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnExit)
        Me.Panel3.Controls.Add(Me.btnSignIn)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(184, 213)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 32)
        Me.Panel3.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.FocusCuesEnabled = False
        Me.btnExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(91, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnExit.Size = New System.Drawing.Size(85, 32)
        Me.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnExit.Symbol = ""
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Cancel"
        '
        'btnSignIn
        '
        Me.btnSignIn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignIn.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSignIn.FocusCuesEnabled = False
        Me.btnSignIn.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSignIn.Image = CType(resources.GetObject("btnSignIn.Image"), System.Drawing.Image)
        Me.btnSignIn.ImageFixedSize = New System.Drawing.Size(30, 30)
        Me.btnSignIn.Location = New System.Drawing.Point(0, 0)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnSignIn.Size = New System.Drawing.Size(85, 32)
        Me.btnSignIn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSignIn.TabIndex = 0
        Me.btnSignIn.Text = "Change"
        Me.btnSignIn.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'FrmChangePassword
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(372, 254)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmChangePassword"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents KryptonLabel7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents KryptonLabel1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents KryptonLabel2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSignIn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents txtVerifyPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNewPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtOldPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
