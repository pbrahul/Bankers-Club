<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchase
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchase))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dtpPurchase = New System.Windows.Forms.DateTimePicker()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtChallen = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMemo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.lblTotal = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgvPurchase = New System.Windows.Forms.DataGridView()
        Me.chkApproved = New ComponentFactory.Krypton.Toolkit.KryptonCheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAccounts = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBillAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.Barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.dtpPurchase, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 8)
        Me.tableLayoutPanel1.Controls.Add(Me.txtRemarks, 1, 8)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX7, 0, 7)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtChallen, 1, 7)
        Me.tableLayoutPanel1.Controls.Add(Me.txtMemo, 1, 1)
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(428, 9)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(345, 135)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'dtpPurchase
        '
        Me.dtpPurchase.BackColor = System.Drawing.Color.White
        Me.dtpPurchase.CustomFormat = "dd MMM yyyy"
        Me.dtpPurchase.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpPurchase.ForeColor = System.Drawing.Color.Black
        Me.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPurchase.Location = New System.Drawing.Point(113, 3)
        Me.dtpPurchase.Name = "dtpPurchase"
        Me.dtpPurchase.Size = New System.Drawing.Size(223, 27)
        Me.dtpPurchase.TabIndex = 2
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 4)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(102, 22)
        Me.LabelX3.TabIndex = 211
        Me.LabelX3.Text = "Purchase Date :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 103)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(65, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Remarks :"
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
        Me.txtRemarks.Location = New System.Drawing.Point(113, 102)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(223, 27)
        Me.txtRemarks.TabIndex = 3
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(4, 70)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(81, 22)
        Me.LabelX7.TabIndex = 308
        Me.LabelX7.Text = "Challen No :"
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
        Me.LabelX2.Size = New System.Drawing.Size(52, 22)
        Me.LabelX2.TabIndex = 210
        Me.LabelX2.Text = "Bill No :"
        '
        'txtChallen
        '
        Me.txtChallen.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtChallen.Border.Class = "TextBoxBorder"
        Me.txtChallen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtChallen.ForeColor = System.Drawing.Color.Black
        Me.txtChallen.Location = New System.Drawing.Point(113, 69)
        Me.txtChallen.Name = "txtChallen"
        Me.txtChallen.Size = New System.Drawing.Size(223, 27)
        Me.txtChallen.TabIndex = 307
        '
        'txtMemo
        '
        Me.txtMemo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMemo.Border.Class = "TextBoxBorder"
        Me.txtMemo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMemo.ForeColor = System.Drawing.Color.Black
        Me.txtMemo.Location = New System.Drawing.Point(113, 36)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.Size = New System.Drawing.Size(223, 27)
        Me.txtMemo.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FocusCuesEnabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnAdd.Location = New System.Drawing.Point(376, 11)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnAdd.Size = New System.Drawing.Size(33, 28)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnAdd.Symbol = ""
        Me.btnAdd.TabIndex = 300
        Me.btnAdd.Tooltip = "Add Type"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(8, 14)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(53, 22)
        Me.LabelX1.TabIndex = 207
        Me.LabelX1.Text = "Search :"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.LabelX6)
        Me.PanelEx3.Controls.Add(Me.lblTotal)
        Me.PanelEx3.Controls.Add(Me.LabelX5)
        Me.PanelEx3.Controls.Add(Me.txtSearch)
        Me.PanelEx3.Controls.Add(Me.dgvPurchase)
        Me.PanelEx3.Location = New System.Drawing.Point(20, 197)
        Me.PanelEx3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(776, 256)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(558, 227)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(98, 22)
        Me.LabelX6.TabIndex = 281
        Me.LabelX6.Text = "Total Amount :"
        '
        'lblTotal
        '
        '
        '
        '
        Me.lblTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(647, 227)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(121, 22)
        Me.lblTotal.TabIndex = 282
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(17, 9)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(86, 22)
        Me.LabelX5.TabIndex = 211
        Me.LabelX5.Text = "Search Item :"
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
        Me.txtSearch.Location = New System.Drawing.Point(110, 7)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(299, 27)
        Me.txtSearch.TabIndex = 0
        '
        'dgvPurchase
        '
        Me.dgvPurchase.AllowUserToAddRows = False
        Me.dgvPurchase.AllowUserToDeleteRows = False
        Me.dgvPurchase.AllowUserToResizeRows = False
        Me.dgvPurchase.BackgroundColor = System.Drawing.Color.White
        Me.dgvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPurchase.CausesValidation = False
        Me.dgvPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPurchase.ColumnHeadersHeight = 32
        Me.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Barcode, Me.Product, Me.Quantity, Me.Unit, Me.Price, Me.TotalAmount})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchase.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPurchase.EnableHeadersVisualStyles = False
        Me.dgvPurchase.Location = New System.Drawing.Point(17, 38)
        Me.dgvPurchase.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPurchase.MultiSelect = False
        Me.dgvPurchase.Name = "dgvPurchase"
        Me.dgvPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvPurchase.RowHeadersVisible = False
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPurchase.RowTemplate.Height = 27
        Me.dgvPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPurchase.ShowEditingIcon = False
        Me.dgvPurchase.Size = New System.Drawing.Size(750, 183)
        Me.dgvPurchase.TabIndex = 280
        '
        'chkApproved
        '
        Me.chkApproved.BackColor = System.Drawing.Color.White
        Me.chkApproved.Checked = True
        Me.chkApproved.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkApproved.ForeColor = System.Drawing.Color.Black
        Me.chkApproved.Images.CheckedNormal = CType(resources.GetObject("chkApproved.Images.CheckedNormal"), System.Drawing.Image)
        Me.chkApproved.Images.CheckedPressed = CType(resources.GetObject("chkApproved.Images.CheckedPressed"), System.Drawing.Image)
        Me.chkApproved.Images.CheckedTracking = CType(resources.GetObject("chkApproved.Images.CheckedTracking"), System.Drawing.Image)
        Me.chkApproved.Images.UncheckedNormal = CType(resources.GetObject("chkApproved.Images.UncheckedNormal"), System.Drawing.Image)
        Me.chkApproved.Images.UncheckedPressed = CType(resources.GetObject("chkApproved.Images.UncheckedPressed"), System.Drawing.Image)
        Me.chkApproved.Images.UncheckedTracking = CType(resources.GetObject("chkApproved.Images.UncheckedTracking"), System.Drawing.Image)
        Me.chkApproved.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.chkApproved.Location = New System.Drawing.Point(17, 462)
        Me.chkApproved.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkApproved.Name = "chkApproved"
        Me.chkApproved.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black
        Me.chkApproved.Size = New System.Drawing.Size(260, 24)
        Me.chkApproved.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.chkApproved.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkApproved.TabIndex = 2
        Me.chkApproved.Text = "Purchase Approved and Stock Product"
        Me.chkApproved.Values.Text = "Purchase Approved and Stock Product"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, -4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 26)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "Purchase Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(788, 25)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "_________________________________________________________________________________" & _
    "________________"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(628, 456)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 36)
        Me.Panel1.TabIndex = 0
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
        Me.btnSave.Text = "Accept"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtBalance)
        Me.PanelEx2.Controls.Add(Me.txtAccounts)
        Me.PanelEx2.Controls.Add(Me.tableLayoutPanel1)
        Me.PanelEx2.Controls.Add(Me.txtBillAddress)
        Me.PanelEx2.Controls.Add(Me.btnAdd)
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Controls.Add(Me.LabelX10)
        Me.PanelEx2.Controls.Add(Me.LabelX8)
        Me.PanelEx2.Location = New System.Drawing.Point(20, 31)
        Me.PanelEx2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(776, 155)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
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
        Me.txtBalance.Location = New System.Drawing.Point(101, 120)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(271, 27)
        Me.txtBalance.TabIndex = 309
        '
        'txtAccounts
        '
        Me.txtAccounts.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAccounts.Border.Class = "TextBoxBorder"
        Me.txtAccounts.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtAccounts.Location = New System.Drawing.Point(101, 12)
        Me.txtAccounts.Name = "txtAccounts"
        Me.txtAccounts.Size = New System.Drawing.Size(271, 27)
        Me.txtAccounts.TabIndex = 283
        '
        'txtBillAddress
        '
        Me.txtBillAddress.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBillAddress.Border.Class = "TextBoxBorder"
        Me.txtBillAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBillAddress.Enabled = False
        Me.txtBillAddress.ForeColor = System.Drawing.Color.Black
        Me.txtBillAddress.Location = New System.Drawing.Point(101, 45)
        Me.txtBillAddress.Multiline = True
        Me.txtBillAddress.Name = "txtBillAddress"
        Me.txtBillAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBillAddress.Size = New System.Drawing.Size(271, 70)
        Me.txtBillAddress.TabIndex = 305
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(8, 122)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(90, 22)
        Me.LabelX10.TabIndex = 306
        Me.LabelX10.Text = "Balance Amt :"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(8, 41)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(85, 22)
        Me.LabelX8.TabIndex = 304
        Me.LabelX8.Text = "Bill Address :"
        '
        'Barcode
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Barcode.DefaultCellStyle = DataGridViewCellStyle2
        Me.Barcode.HeaderText = "Barcode"
        Me.Barcode.Name = "Barcode"
        Me.Barcode.ReadOnly = True
        '
        'Product
        '
        Me.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        '
        'Quantity
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantity.Width = 60
        '
        'Unit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Unit.DefaultCellStyle = DataGridViewCellStyle4
        Me.Unit.HeaderText = "Unit"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Unit.Width = 80
        '
        'Price
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Price.DefaultCellStyle = DataGridViewCellStyle5
        Me.Price.HeaderText = "Rate"
        Me.Price.Name = "Price"
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Width = 80
        '
        'TotalAmount
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotalAmount.DefaultCellStyle = DataGridViewCellStyle6
        Me.TotalAmount.HeaderText = "Total"
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.ReadOnly = True
        Me.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FrmPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkApproved)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.PanelEx2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPurchase"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Public WithEvents chkApproved As ComponentFactory.Krypton.Toolkit.KryptonCheckBox
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMemo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dtpPurchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtChallen As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBillAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtAccounts As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Barcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Product As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
