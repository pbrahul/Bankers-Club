<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockPrint))
        Me.rbnCurrent = New DevComponents.DotNetBar.Controls.CheckBoxX()
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
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.rbnTill = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.dtpTill = New System.Windows.Forms.DateTimePicker()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtBarcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnCurrent
        '
        Me.rbnCurrent.AutoSize = True
        Me.rbnCurrent.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnCurrent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnCurrent.CheckBoxImageChecked = CType(resources.GetObject("rbnCurrent.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnCurrent.CheckBoxImageUnChecked = CType(resources.GetObject("rbnCurrent.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnCurrent.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnCurrent.Checked = True
        Me.rbnCurrent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnCurrent.CheckValue = "Y"
        Me.rbnCurrent.FocusCuesEnabled = False
        Me.rbnCurrent.ForeColor = System.Drawing.Color.Black
        Me.rbnCurrent.Location = New System.Drawing.Point(41, 32)
        Me.rbnCurrent.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnCurrent.Name = "rbnCurrent"
        Me.rbnCurrent.Size = New System.Drawing.Size(205, 22)
        Me.rbnCurrent.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnCurrent.TabIndex = 302
        Me.rbnCurrent.Text = " Current Product Stock Print"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(204, 259)
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
        Me.Label3.Size = New System.Drawing.Size(170, 26)
        Me.Label3.TabIndex = 318
        Me.Label3.Text = "Product Stock Print"
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
        Me.LabelX4.Location = New System.Drawing.Point(82, 225)
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
        Me.LabelX5.Location = New System.Drawing.Point(64, 192)
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
        Me.dtpFrom.Location = New System.Drawing.Point(147, 192)
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
        Me.dtpTo.Location = New System.Drawing.Point(147, 225)
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
        Me.rbnSelected.Location = New System.Drawing.Point(41, 137)
        Me.rbnSelected.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnSelected.Name = "rbnSelected"
        Me.rbnSelected.Size = New System.Drawing.Size(227, 22)
        Me.rbnSelected.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnSelected.TabIndex = 337
        Me.rbnSelected.Text = " Selected Product Stock History "
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
        Me.LabelX1.Location = New System.Drawing.Point(82, 161)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(60, 22)
        Me.LabelX1.TabIndex = 339
        Me.LabelX1.Text = "Product :"
        '
        'rbnTill
        '
        Me.rbnTill.AutoSize = True
        Me.rbnTill.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnTill.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnTill.CheckBoxImageChecked = CType(resources.GetObject("rbnTill.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnTill.CheckBoxImageUnChecked = CType(resources.GetObject("rbnTill.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnTill.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnTill.FocusCuesEnabled = False
        Me.rbnTill.ForeColor = System.Drawing.Color.Black
        Me.rbnTill.Location = New System.Drawing.Point(41, 67)
        Me.rbnTill.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnTill.Name = "rbnTill"
        Me.rbnTill.Size = New System.Drawing.Size(228, 22)
        Me.rbnTill.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnTill.TabIndex = 340
        Me.rbnTill.Text = " Till Date Current Product Stock"
        '
        'dtpTill
        '
        Me.dtpTill.BackColor = System.Drawing.Color.White
        Me.dtpTill.CustomFormat = "dd MMM yyyy"
        Me.dtpTill.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpTill.ForeColor = System.Drawing.Color.Black
        Me.dtpTill.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTill.Location = New System.Drawing.Point(147, 97)
        Me.dtpTill.Name = "dtpTill"
        Me.dtpTill.Size = New System.Drawing.Size(225, 27)
        Me.dtpTill.TabIndex = 342
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
        Me.LabelX2.Location = New System.Drawing.Point(80, 97)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(62, 22)
        Me.LabelX2.TabIndex = 341
        Me.LabelX2.Text = "Till Date :"
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBarcode.Border.Class = "TextBoxBorder"
        Me.txtBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBarcode.Font = New System.Drawing.Font("Tahoma", 12.5!)
        Me.txtBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode.Location = New System.Drawing.Point(147, 158)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(226, 28)
        Me.txtBarcode.TabIndex = 343
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'FrmStockPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 314)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.dtpTill)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.rbnTill)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.rbnSelected)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbnCurrent)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStockPrint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stock Print"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnCurrent As DevComponents.DotNetBar.Controls.CheckBoxX
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
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents rbnTill As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents dtpTill As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBarcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
End Class
