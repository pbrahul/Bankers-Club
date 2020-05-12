<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployee))
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtAge = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtGuardian = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtIdentity = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.chkActive = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpJoin = New System.Windows.Forms.DateTimePicker()
        Me.Panel2.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(301, 348)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 36)
        Me.Panel2.TabIndex = 3
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
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.dtpJoin, 1, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.txtAge, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX7, 0, 6)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.txtGuardian, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtName, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtContact, 1, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.txtAddress, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.txtIdentity, 1, 6)
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(22, 34)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(334, 267)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtAge.Border.Class = "TextBoxBorder"
        Me.txtAge.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAge.ForeColor = System.Drawing.Color.Black
        Me.txtAge.Location = New System.Drawing.Point(94, 136)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(229, 27)
        Me.txtAge.TabIndex = 3
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(4, 236)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 22)
        Me.LabelX7.TabIndex = 296
        Me.LabelX7.Text = "National ID :"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 203)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(70, 22)
        Me.LabelX6.TabIndex = 295
        Me.LabelX6.Text = "Join Date :"
        '
        'txtGuardian
        '
        Me.txtGuardian.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtGuardian.Border.Class = "TextBoxBorder"
        Me.txtGuardian.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtGuardian.ForeColor = System.Drawing.Color.Black
        Me.txtGuardian.Location = New System.Drawing.Point(94, 36)
        Me.txtGuardian.Name = "txtGuardian"
        Me.txtGuardian.Size = New System.Drawing.Size(229, 27)
        Me.txtGuardian.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(94, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 27)
        Me.txtName.TabIndex = 0
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 170)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(83, 22)
        Me.LabelX5.TabIndex = 213
        Me.LabelX5.Text = "Contact No :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 137)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(35, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Age :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 70)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(62, 22)
        Me.LabelX3.TabIndex = 210
        Me.LabelX3.Text = "Address :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 37)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(69, 22)
        Me.LabelX2.TabIndex = 207
        Me.LabelX2.Text = "Guardian :"
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
        Me.LabelX1.Size = New System.Drawing.Size(48, 22)
        Me.LabelX1.TabIndex = 206
        Me.LabelX1.Text = "Name :"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(94, 169)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(229, 27)
        Me.txtContact.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtAddress.Border.Class = "TextBoxBorder"
        Me.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(94, 69)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(229, 61)
        Me.txtAddress.TabIndex = 2
        '
        'txtIdentity
        '
        Me.txtIdentity.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtIdentity.Border.Class = "TextBoxBorder"
        Me.txtIdentity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIdentity.ForeColor = System.Drawing.Color.Black
        Me.txtIdentity.Location = New System.Drawing.Point(94, 235)
        Me.txtIdentity.Name = "txtIdentity"
        Me.txtIdentity.Size = New System.Drawing.Size(229, 27)
        Me.txtIdentity.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, -2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 26)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "Employee Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(452, 25)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "_______________________________________________________"
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FocusCuesEnabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnClear.Location = New System.Drawing.Point(437, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnClear.Size = New System.Drawing.Size(30, 30)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnClear.Symbol = ""
        Me.btnClear.SymbolSize = 15.0!
        Me.btnClear.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FocusCuesEnabled = False
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnBrowse.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnBrowse.Location = New System.Drawing.Point(363, 162)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnBrowse.Size = New System.Drawing.Size(30, 30)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnBrowse.Symbol = ""
        Me.btnBrowse.SymbolSize = 15.0!
        Me.btnBrowse.TabIndex = 0
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.logo.ForeColor = System.Drawing.Color.Black
        Me.logo.Location = New System.Drawing.Point(363, 34)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(104, 123)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 259
        Me.logo.TabStop = False
        '
        'chkActive
        '
        Me.chkActive.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chkActive.ForeColor = System.Drawing.Color.Black
        Me.chkActive.Images.CheckedNormal = CType(resources.GetObject("chkActive.Images.CheckedNormal"), System.Drawing.Image)
        Me.chkActive.Images.CheckedPressed = CType(resources.GetObject("chkActive.Images.CheckedPressed"), System.Drawing.Image)
        Me.chkActive.Images.CheckedTracking = CType(resources.GetObject("chkActive.Images.CheckedTracking"), System.Drawing.Image)
        Me.chkActive.Images.UncheckedNormal = CType(resources.GetObject("chkActive.Images.UncheckedNormal"), System.Drawing.Image)
        Me.chkActive.Images.UncheckedPressed = CType(resources.GetObject("chkActive.Images.UncheckedPressed"), System.Drawing.Image)
        Me.chkActive.Images.UncheckedTracking = CType(resources.GetObject("chkActive.Images.UncheckedTracking"), System.Drawing.Image)
        Me.chkActive.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.chkActive.Location = New System.Drawing.Point(22, 308)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.chkActive.Size = New System.Drawing.Size(159, 24)
        Me.chkActive.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.chkActive.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.TabIndex = 1
        Me.chkActive.Text = "Inactive && Remarks :"
        Me.chkActive.Values.Text = "Inactive && Remarks :"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(177, 305)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(168, 27)
        Me.txtRemarks.TabIndex = 2
        '
        'dtpJoin
        '
        Me.dtpJoin.CustomFormat = "dd MMM yyyy"
        Me.dtpJoin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJoin.Location = New System.Drawing.Point(94, 202)
        Me.dtpJoin.Name = "dtpJoin"
        Me.dtpJoin.Size = New System.Drawing.Size(229, 27)
        Me.dtpJoin.TabIndex = 5
        '
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 455)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmployee"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee"
        Me.Panel2.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents txtGuardian As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtIdentity As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents chkActive As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAge As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpJoin As System.Windows.Forms.DateTimePicker
End Class
