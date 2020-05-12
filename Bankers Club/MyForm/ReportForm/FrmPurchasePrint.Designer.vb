<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasePrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchasePrint))
        Me.rbnApproved = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rbnSelect = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.rbnSupplier = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmbSupplier = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnApproved
        '
        Me.rbnApproved.AutoSize = True
        Me.rbnApproved.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnApproved.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnApproved.CheckBoxImageChecked = CType(resources.GetObject("rbnApproved.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnApproved.CheckBoxImageUnChecked = CType(resources.GetObject("rbnApproved.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnApproved.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnApproved.FocusCuesEnabled = False
        Me.rbnApproved.ForeColor = System.Drawing.Color.Black
        Me.rbnApproved.Location = New System.Drawing.Point(54, 193)
        Me.rbnApproved.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnApproved.Name = "rbnApproved"
        Me.rbnApproved.Size = New System.Drawing.Size(178, 22)
        Me.rbnApproved.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnApproved.TabIndex = 308
        Me.rbnApproved.Text = " Approve purchase only"
        '
        'rbnSelect
        '
        Me.rbnSelect.AutoSize = True
        Me.rbnSelect.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnSelect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnSelect.CheckBoxImageChecked = CType(resources.GetObject("rbnSelect.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnSelect.CheckBoxImageUnChecked = CType(resources.GetObject("rbnSelect.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnSelect.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnSelect.Checked = True
        Me.rbnSelect.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnSelect.CheckValue = "Y"
        Me.rbnSelect.FocusCuesEnabled = False
        Me.rbnSelect.ForeColor = System.Drawing.Color.Black
        Me.rbnSelect.Location = New System.Drawing.Point(53, 106)
        Me.rbnSelect.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnSelect.Name = "rbnSelect"
        Me.rbnSelect.Size = New System.Drawing.Size(193, 22)
        Me.rbnSelect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnSelect.TabIndex = 302
        Me.rbnSelect.Text = " Selected Purchase Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(191, 225)
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
        Me.Label3.Location = New System.Drawing.Point(48, -3)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 26)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "Purchase Details Print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(48, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(324, 25)
        Me.Label4.TabIndex = 319
        Me.Label4.Text = "_______________________________________"
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
        Me.LabelX4.Location = New System.Drawing.Point(65, 66)
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
        Me.LabelX5.Location = New System.Drawing.Point(51, 33)
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
        Me.dtpFrom.Location = New System.Drawing.Point(135, 33)
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
        Me.dtpTo.Location = New System.Drawing.Point(135, 66)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(225, 27)
        Me.dtpTo.TabIndex = 336
        '
        'rbnSupplier
        '
        Me.rbnSupplier.AutoSize = True
        Me.rbnSupplier.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnSupplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnSupplier.CheckBoxImageChecked = CType(resources.GetObject("rbnSupplier.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnSupplier.CheckBoxImageUnChecked = CType(resources.GetObject("rbnSupplier.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnSupplier.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnSupplier.FocusCuesEnabled = False
        Me.rbnSupplier.ForeColor = System.Drawing.Color.Black
        Me.rbnSupplier.Location = New System.Drawing.Point(54, 137)
        Me.rbnSupplier.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnSupplier.Name = "rbnSupplier"
        Me.rbnSupplier.Size = New System.Drawing.Size(250, 22)
        Me.rbnSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnSupplier.TabIndex = 337
        Me.rbnSupplier.Text = " Selected Supplier Purchase Details"
        '
        'cmbSupplier
        '
        Me.cmbSupplier.DisplayMember = "Text"
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbSupplier.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmbSupplier.ForeColor = System.Drawing.Color.Black
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.ItemHeight = 18
        Me.cmbSupplier.Location = New System.Drawing.Point(146, 161)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(158, 26)
        Me.cmbSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.cmbSupplier.TabIndex = 338
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
        Me.LabelX1.Location = New System.Drawing.Point(79, 163)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(63, 22)
        Me.LabelX1.TabIndex = 339
        Me.LabelX1.Text = "Supplier :"
        '
        'FrmPurchasePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 283)
        Me.Controls.Add(Me.cmbSupplier)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.rbnSupplier)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbnSelect)
        Me.Controls.Add(Me.rbnApproved)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPurchasePrint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Print"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnApproved As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rbnSelect As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbnSupplier As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbSupplier As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
