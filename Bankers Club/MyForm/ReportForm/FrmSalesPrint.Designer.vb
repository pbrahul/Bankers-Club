<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalesPrint))
        Me.rbnCosmetics = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.rbnSummary = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rbnMedicine = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnCosmetics
        '
        Me.rbnCosmetics.AutoSize = True
        Me.rbnCosmetics.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnCosmetics.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnCosmetics.CheckBoxImageChecked = CType(resources.GetObject("rbnCosmetics.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnCosmetics.CheckBoxImageUnChecked = CType(resources.GetObject("rbnCosmetics.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnCosmetics.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnCosmetics.FocusCuesEnabled = False
        Me.rbnCosmetics.ForeColor = System.Drawing.Color.Black
        Me.rbnCosmetics.Location = New System.Drawing.Point(31, 144)
        Me.rbnCosmetics.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnCosmetics.Name = "rbnCosmetics"
        Me.rbnCosmetics.Size = New System.Drawing.Size(179, 22)
        Me.rbnCosmetics.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnCosmetics.TabIndex = 308
        Me.rbnCosmetics.Text = " Cosmetics Sales Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(188, 209)
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
        Me.Label3.Location = New System.Drawing.Point(27, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 26)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "Sales Details Print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 25)
        Me.Label4.TabIndex = 319
        Me.Label4.Text = "________________________________________"
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
        Me.LabelX4.Location = New System.Drawing.Point(42, 69)
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
        Me.LabelX5.Location = New System.Drawing.Point(28, 36)
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
        Me.dtpFrom.Location = New System.Drawing.Point(112, 36)
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
        Me.dtpTo.Location = New System.Drawing.Point(112, 69)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(225, 27)
        Me.dtpTo.TabIndex = 336
        '
        'rbnSummary
        '
        Me.rbnSummary.AutoSize = True
        Me.rbnSummary.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnSummary.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnSummary.CheckBoxImageChecked = CType(resources.GetObject("rbnSummary.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnSummary.CheckBoxImageUnChecked = CType(resources.GetObject("rbnSummary.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnSummary.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnSummary.FocusCuesEnabled = False
        Me.rbnSummary.ForeColor = System.Drawing.Color.Black
        Me.rbnSummary.Location = New System.Drawing.Point(31, 114)
        Me.rbnSummary.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnSummary.Name = "rbnSummary"
        Me.rbnSummary.Size = New System.Drawing.Size(174, 22)
        Me.rbnSummary.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnSummary.TabIndex = 337
        Me.rbnSummary.Text = " Sales Summary Report"
        '
        'rbnMedicine
        '
        Me.rbnMedicine.AutoSize = True
        Me.rbnMedicine.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnMedicine.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnMedicine.CheckBoxImageChecked = CType(resources.GetObject("rbnMedicine.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnMedicine.CheckBoxImageUnChecked = CType(resources.GetObject("rbnMedicine.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnMedicine.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnMedicine.Checked = True
        Me.rbnMedicine.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnMedicine.CheckValue = "Y"
        Me.rbnMedicine.FocusCuesEnabled = False
        Me.rbnMedicine.ForeColor = System.Drawing.Color.Black
        Me.rbnMedicine.Location = New System.Drawing.Point(31, 175)
        Me.rbnMedicine.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnMedicine.Name = "rbnMedicine"
        Me.rbnMedicine.Size = New System.Drawing.Size(172, 22)
        Me.rbnMedicine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnMedicine.TabIndex = 338
        Me.rbnMedicine.Text = " Medicine Sales Details"
        '
        'FrmSalesPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 275)
        Me.Controls.Add(Me.rbnMedicine)
        Me.Controls.Add(Me.rbnSummary)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbnCosmetics)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSalesPrint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Print"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnCosmetics As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbnSummary As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rbnMedicine As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
