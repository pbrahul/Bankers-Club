<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCollection
    Inherits DevComponents.DotNetBar.Metro.MetroAppForm

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
        Me.swPayment = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.dtpIssue = New System.Windows.Forms.DateTimePicker()
        Me.lblIssue = New DevComponents.DotNetBar.LabelX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPayment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtCheque = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBank = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBankName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panExistTitle = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtYear = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.btnType = New DevComponents.DotNetBar.ButtonX()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2.SuspendLayout()
        Me.panExistTitle.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'swPayment
        '
        Me.swPayment.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.swPayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swPayment.ForeColor = System.Drawing.Color.Black
        Me.swPayment.Location = New System.Drawing.Point(121, 158)
        Me.swPayment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.swPayment.Name = "swPayment"
        Me.swPayment.OffBackColor = System.Drawing.Color.Transparent
        Me.swPayment.OffText = "Cheque"
        Me.swPayment.OnText = "Cash"
        Me.swPayment.Size = New System.Drawing.Size(134, 27)
        Me.swPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swPayment.SwitchBackColor = System.Drawing.Color.DarkSlateGray
        Me.swPayment.SwitchWidth = 55
        Me.swPayment.TabIndex = 7
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'cmbFrom
        '
        Me.cmbFrom.BackColor = System.Drawing.Color.White
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbFrom.ForeColor = System.Drawing.Color.Black
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(120, 122)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(223, 28)
        Me.cmbFrom.TabIndex = 5
        '
        'dtpIssue
        '
        Me.dtpIssue.BackColor = System.Drawing.Color.White
        Me.dtpIssue.CustomFormat = "dd MMM yyyy"
        Me.dtpIssue.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpIssue.ForeColor = System.Drawing.Color.Black
        Me.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssue.Location = New System.Drawing.Point(531, 156)
        Me.dtpIssue.Name = "dtpIssue"
        Me.dtpIssue.Size = New System.Drawing.Size(223, 27)
        Me.dtpIssue.TabIndex = 8
        '
        'lblIssue
        '
        Me.lblIssue.AutoSize = True
        '
        '
        '
        Me.lblIssue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblIssue.ForeColor = System.Drawing.Color.Black
        Me.lblIssue.Location = New System.Drawing.Point(430, 157)
        Me.lblIssue.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.Size = New System.Drawing.Size(94, 22)
        Me.lblIssue.TabIndex = 221
        Me.lblIssue.Text = "Cheque Date :"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.Enabled = False
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(531, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 27)
        Me.txtName.TabIndex = 2
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPayment.Border.Class = "TextBoxBorder"
        Me.txtPayment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPayment.ForeColor = System.Drawing.Color.Black
        Me.txtPayment.Location = New System.Drawing.Point(120, 260)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(223, 27)
        Me.txtPayment.TabIndex = 12
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(120, 293)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(223, 27)
        Me.txtRemarks.TabIndex = 13
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(4, 123)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(79, 22)
        Me.LabelX1.TabIndex = 208
        Me.LabelX1.Text = "Receive To :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 157)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(109, 22)
        Me.LabelX2.TabIndex = 216
        Me.LabelX2.Text = "Collection Type :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 261)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(66, 22)
        Me.LabelX4.TabIndex = 217
        Me.LabelX4.Text = "Payment :"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 294)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(65, 22)
        Me.LabelX6.TabIndex = 219
        Me.LabelX6.Text = "Remarks :"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(430, 37)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(48, 22)
        Me.LabelX8.TabIndex = 221
        Me.LabelX8.Text = "Name :"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtID.Border.Class = "TextBoxBorder"
        Me.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtID.Enabled = False
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(120, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(223, 27)
        Me.txtID.TabIndex = 1
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBalance.Border.Class = "TextBoxBorder"
        Me.txtBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBalance.Enabled = False
        Me.txtBalance.ForeColor = System.Drawing.Color.Black
        Me.txtBalance.Location = New System.Drawing.Point(531, 122)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(223, 27)
        Me.txtBalance.TabIndex = 6
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(4, 37)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(47, 22)
        Me.LabelX13.TabIndex = 216
        Me.LabelX13.Text = "ID No :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(430, 123)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(90, 22)
        Me.LabelX3.TabIndex = 209
        Me.LabelX3.Text = "Balance Amt :"
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCheque.Border.Class = "TextBoxBorder"
        Me.txtCheque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCheque.ForeColor = System.Drawing.Color.Black
        Me.txtCheque.Location = New System.Drawing.Point(531, 193)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(223, 27)
        Me.txtCheque.TabIndex = 9
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBank.Border.Class = "TextBoxBorder"
        Me.txtBank.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBank.ForeColor = System.Drawing.Color.Black
        Me.txtBank.Location = New System.Drawing.Point(120, 193)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(223, 27)
        Me.txtBank.TabIndex = 10
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(4, 194)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(84, 22)
        Me.LabelX11.TabIndex = 217
        Me.LabelX11.Text = "Bank Name :"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(430, 194)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(83, 22)
        Me.LabelX10.TabIndex = 217
        Me.LabelX10.Text = "Cheque No :"
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(4, 70)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(84, 22)
        Me.LabelX12.TabIndex = 220
        Me.LabelX12.Text = "Bank Name :"
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.White
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(531, 260)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(223, 27)
        Me.dtpDate.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(614, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
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
        Me.btnCancel.Size = New System.Drawing.Size(80, 32)
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
        Me.btnSave.Size = New System.Drawing.Size(80, 32)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.Symbol = ""
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "OK"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(120, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(223, 27)
        Me.txtSearch.TabIndex = 0
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(4, 4)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(53, 22)
        Me.LabelX7.TabIndex = 217
        Me.LabelX7.Text = "Search :"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(430, 261)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(93, 22)
        Me.LabelX9.TabIndex = 221
        Me.LabelX9.Text = "Receive Date :"
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(430, 70)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(83, 22)
        Me.LabelX14.TabIndex = 221
        Me.LabelX14.Text = "Contact No :"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact.Enabled = False
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(531, 69)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(223, 27)
        Me.txtContact.TabIndex = 4
        '
        'txtBankName
        '
        Me.txtBankName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBankName.Border.Class = "TextBoxBorder"
        Me.txtBankName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBankName.Enabled = False
        Me.txtBankName.ForeColor = System.Drawing.Color.Black
        Me.txtBankName.Location = New System.Drawing.Point(120, 69)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(223, 27)
        Me.txtBankName.TabIndex = 3
        '
        'panExistTitle
        '
        Me.panExistTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.panExistTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panExistTitle.Controls.Add(Me.Label1)
        Me.panExistTitle.Location = New System.Drawing.Point(24, 23)
        Me.panExistTitle.Name = "panExistTitle"
        Me.panExistTitle.Size = New System.Drawing.Size(768, 31)
        Me.panExistTitle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panExistTitle.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panExistTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panExistTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panExistTitle.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panExistTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panExistTitle.Style.GradientAngle = 90
        Me.panExistTitle.TabIndex = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 25)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Receive / Collection"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.txtYear, 4, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX5, 3, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.btnType, 2, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX9, 3, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbType, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX15, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX14, 3, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpIssue, 4, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblIssue, 3, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSearch, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.swPayment, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX13, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtID, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtName, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX8, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX12, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtBankName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtContact, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX1, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbFrom, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 3, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtBalance, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpDate, 4, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.txtCheque, 4, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtBank, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX10, 3, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX11, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtRemarks, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX6, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX4, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPayment, 1, 9)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(28, 60)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(764, 325)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtYear.Border.Class = "TextBoxBorder"
        Me.txtYear.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtYear.ForeColor = System.Drawing.Color.Black
        Me.txtYear.Location = New System.Drawing.Point(531, 226)
        Me.txtYear.MaxLength = 4
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(223, 27)
        Me.txtYear.TabIndex = 301
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(430, 227)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(38, 22)
        Me.LabelX5.TabIndex = 301
        Me.LabelX5.Text = "Year :"
        '
        'btnType
        '
        Me.btnType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnType.FocusCuesEnabled = False
        Me.btnType.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnType.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnType.Location = New System.Drawing.Point(349, 226)
        Me.btnType.Name = "btnType"
        Me.btnType.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnType.Size = New System.Drawing.Size(33, 28)
        Me.btnType.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnType.Symbol = ""
        Me.btnType.TabIndex = 302
        Me.btnType.Tooltip = "Add Type"
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(120, 226)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(223, 28)
        Me.cmbType.TabIndex = 11
        '
        'LabelX15
        '
        Me.LabelX15.AutoSize = True
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(4, 227)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(101, 22)
        Me.LabelX15.TabIndex = 302
        Me.LabelX15.Text = "Payment Type :"
        '
        'FrmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = New DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)))
        Me.BorderThickness = New DevComponents.DotNetBar.Metro.Thickness(1.0R, 1.0R, 1.0R, 1.0R)
        Me.ClientSize = New System.Drawing.Size(822, 443)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.panExistTitle)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCollection"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.Panel2.ResumeLayout(False)
        Me.panExistTitle.ResumeLayout(False)
        Me.panExistTitle.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents swPayment As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPayment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBank As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCheque As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIssue As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBankName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents panExistTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnType As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtYear As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
End Class
