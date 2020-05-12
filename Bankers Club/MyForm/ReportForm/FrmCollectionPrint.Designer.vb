<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCollectionPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCollectionPrint))
        Me.rbnAll = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.rbnMember = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.panPatient = New DevComponents.DotNetBar.PanelEx()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rbnBank = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cmbBank = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1.SuspendLayout()
        Me.panPatient.SuspendLayout()
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
        Me.rbnAll.FocusCuesEnabled = False
        Me.rbnAll.ForeColor = System.Drawing.Color.Black
        Me.rbnAll.Location = New System.Drawing.Point(41, 145)
        Me.rbnAll.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnAll.Name = "rbnAll"
        Me.rbnAll.Size = New System.Drawing.Size(196, 22)
        Me.rbnAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnAll.TabIndex = 308
        Me.rbnAll.Text = " All Collection Deatils Print"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(181, 244)
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
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(55, 69)
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
        Me.LabelX5.Location = New System.Drawing.Point(41, 36)
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
        Me.dtpFrom.Location = New System.Drawing.Point(125, 36)
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
        Me.dtpTo.Location = New System.Drawing.Point(125, 69)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(225, 27)
        Me.dtpTo.TabIndex = 336
        '
        'rbnMember
        '
        Me.rbnMember.AutoSize = True
        Me.rbnMember.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnMember.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnMember.CheckBoxImageChecked = CType(resources.GetObject("rbnMember.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnMember.CheckBoxImageUnChecked = CType(resources.GetObject("rbnMember.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnMember.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnMember.Checked = True
        Me.rbnMember.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnMember.CheckValue = "Y"
        Me.rbnMember.FocusCuesEnabled = False
        Me.rbnMember.ForeColor = System.Drawing.Color.Black
        Me.rbnMember.Location = New System.Drawing.Point(41, 113)
        Me.rbnMember.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnMember.Name = "rbnMember"
        Me.rbnMember.Size = New System.Drawing.Size(259, 22)
        Me.rbnMember.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnMember.TabIndex = 337
        Me.rbnMember.Text = " Selected Member Collection Details"
        '
        'panPatient
        '
        Me.panPatient.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPatient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPatient.Controls.Add(Me.lblTitle)
        Me.panPatient.Location = New System.Drawing.Point(31, -12)
        Me.panPatient.Name = "panPatient"
        Me.panPatient.Size = New System.Drawing.Size(332, 39)
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
        Me.lblTitle.Size = New System.Drawing.Size(191, 25)
        Me.lblTitle.TabIndex = 297
        Me.lblTitle.Text = "Collection Deatils Print"
        '
        'rbnBank
        '
        Me.rbnBank.AutoSize = True
        Me.rbnBank.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnBank.CheckBoxImageChecked = CType(resources.GetObject("rbnBank.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnBank.CheckBoxImageUnChecked = CType(resources.GetObject("rbnBank.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnBank.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnBank.FocusCuesEnabled = False
        Me.rbnBank.ForeColor = System.Drawing.Color.Black
        Me.rbnBank.Location = New System.Drawing.Point(41, 175)
        Me.rbnBank.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnBank.Name = "rbnBank"
        Me.rbnBank.Size = New System.Drawing.Size(294, 22)
        Me.rbnBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnBank.TabIndex = 344
        Me.rbnBank.Text = " Selected Bank Employee Payment Details"
        '
        'cmbBank
        '
        Me.cmbBank.DisplayMember = "Text"
        Me.cmbBank.DropDownHeight = 160
        Me.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBank.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbBank.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmbBank.ForeColor = System.Drawing.Color.Black
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.IntegralHeight = False
        Me.cmbBank.ItemHeight = 18
        Me.cmbBank.Location = New System.Drawing.Point(123, 200)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(225, 26)
        Me.cmbBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.cmbBank.TabIndex = 345
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
        Me.LabelX1.Location = New System.Drawing.Point(69, 201)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 22)
        Me.LabelX1.TabIndex = 346
        Me.LabelX1.Text = "Bank : "
        '
        'FrmCollectionPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 316)
        Me.Controls.Add(Me.cmbBank)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.rbnBank)
        Me.Controls.Add(Me.panPatient)
        Me.Controls.Add(Me.rbnMember)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbnAll)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCollectionPrint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Collection Print"
        Me.Panel1.ResumeLayout(False)
        Me.panPatient.ResumeLayout(False)
        Me.panPatient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnAll As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbnMember As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents panPatient As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents rbnBank As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cmbBank As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
