<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccountsPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccountsPrint))
        Me.rbnAll = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.rbnSelected = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmbAccounts = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnAll
        '
        Me.rbnAll.AutoSize = True
        Me.rbnAll.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnAll.CheckBoxImageChecked = CType(resources.GetObject("rbnAll.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnAll.CheckBoxImageUnChecked = CType(resources.GetObject("rbnAll.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnAll.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnAll.Checked = True
        Me.rbnAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnAll.CheckValue = "Y"
        Me.rbnAll.FocusCuesEnabled = False
        Me.rbnAll.ForeColor = System.Drawing.Color.Black
        Me.rbnAll.Location = New System.Drawing.Point(41, 32)
        Me.rbnAll.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnAll.Name = "rbnAll"
        Me.rbnAll.Size = New System.Drawing.Size(299, 22)
        Me.rbnAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnAll.TabIndex = 302
        Me.rbnAll.Text = " Current Date Accounts Balance Statement"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(204, 219)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(169, 36)
        Me.Panel1.TabIndex = 208
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.Location = New System.Drawing.Point(89, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(80, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FocusCuesEnabled = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnPrint.Size = New System.Drawing.Size(80, 36)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnPrint.TabIndex = 285
        Me.btnPrint.Text = "Print"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, -3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 26)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "Cash Accounts Print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(340, 25)
        Me.Label4.TabIndex = 319
        Me.Label4.Text = "_________________________________________"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(82, 184)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(60, 22)
        Me.LabelX4.TabIndex = 329
        Me.LabelX4.Text = "Date To :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        Me.LabelX5.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(64, 151)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(78, 22)
        Me.LabelX5.TabIndex = 326
        Me.LabelX5.Text = "Date From :"
        '
        'dtpFrom
        '
        Me.dtpFrom.BackColor = System.Drawing.Color.White
        Me.dtpFrom.CustomFormat = "dd MMM yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(147, 151)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(225, 27)
        Me.dtpFrom.TabIndex = 335
        '
        'dtpTo
        '
        Me.dtpTo.BackColor = System.Drawing.Color.White
        Me.dtpTo.CustomFormat = "dd MMM yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpTo.ForeColor = System.Drawing.Color.Black
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(147, 184)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(225, 27)
        Me.dtpTo.TabIndex = 336
        '
        'rbnSelected
        '
        Me.rbnSelected.AutoSize = True
        Me.rbnSelected.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnSelected.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnSelected.CheckBoxImageChecked = CType(resources.GetObject("rbnSelected.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnSelected.CheckBoxImageUnChecked = CType(resources.GetObject("rbnSelected.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnSelected.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnSelected.FocusCuesEnabled = False
        Me.rbnSelected.ForeColor = System.Drawing.Color.Black
        Me.rbnSelected.Location = New System.Drawing.Point(41, 97)
        Me.rbnSelected.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnSelected.Name = "rbnSelected"
        Me.rbnSelected.Size = New System.Drawing.Size(194, 22)
        Me.rbnSelected.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnSelected.TabIndex = 337
        Me.rbnSelected.Text = " Selected Accounts Details"
        '
        'cmbAccounts
        '
        Me.cmbAccounts.DisplayMember = "Text"
        Me.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbAccounts.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmbAccounts.ForeColor = System.Drawing.Color.Black
        Me.cmbAccounts.FormattingEnabled = True
        Me.cmbAccounts.ItemHeight = 18
        Me.cmbAccounts.Location = New System.Drawing.Point(147, 121)
        Me.cmbAccounts.Name = "cmbAccounts"
        Me.cmbAccounts.Size = New System.Drawing.Size(225, 26)
        Me.cmbAccounts.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.cmbAccounts.TabIndex = 338
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(73, 123)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(69, 22)
        Me.LabelX1.TabIndex = 339
        Me.LabelX1.Text = "Accounts :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(73, 57)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(121, 22)
        Me.LabelX2.TabIndex = 339
        Me.LabelX2.Text = "Type of Accounts :"
        '
        'cmbType
        '
        Me.cmbType.DisplayMember = "Text"
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbType.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.ItemHeight = 18
        Me.cmbType.Location = New System.Drawing.Point(199, 57)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(173, 26)
        Me.cmbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.cmbType.TabIndex = 338
        '
        'FrmAccountsPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 271)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.cmbAccounts)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.rbnSelected)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbnAll)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAccountsPrint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Accounts Print"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnAll As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbnSelected As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbAccounts As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbType As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
