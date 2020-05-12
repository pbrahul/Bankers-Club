<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalesReceipt))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnReturn = New DevComponents.DotNetBar.ButtonX()
        Me.btnDelete = New DevComponents.DotNetBar.ButtonX()
        Me.panButton = New System.Windows.Forms.Panel()
        Me.grpSales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dtpSale = New System.Windows.Forms.DateTimePicker()
        Me.lblPurchase = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.colReceipt = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colCustName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDate = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colSubTotal = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colVat = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colLabour = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colGrandTotal = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colReceiveAmonut = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDiscount = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colCustID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colBarcode = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colProductName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colQty = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPcs = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPrice = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colProductVat = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colProductDisount = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colProductTotal = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panButton.SuspendLayout()
        Me.grpSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(19, 10)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtSearch.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtSearch.Size = New System.Drawing.Size(261, 28)
        Me.txtSearch.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateActive.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.StateActive.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateCommon.Border.Rounding = 1
        Me.txtSearch.StateCommon.Border.Width = 1
        Me.txtSearch.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtSearch.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.txtSearch.TabIndex = 291
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.btnSearch.UniqueName = ""
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AllowUserToResizeColumns = False
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProduct.CausesValidation = False
        Me.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduct.ColumnHeadersHeight = 32
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.colProductName, Me.colQty, Me.colPcs, Me.colPrice, Me.colProductVat, Me.colProductDisount, Me.colProductTotal})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvProduct.EnableHeadersVisualStyles = False
        Me.dgvProduct.Location = New System.Drawing.Point(27, 297)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProduct.MultiSelect = False
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvProduct.RowHeadersVisible = False
        Me.dgvProduct.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProduct.RowTemplate.Height = 27
        Me.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.ShowEditingIcon = False
        Me.dgvProduct.Size = New System.Drawing.Size(881, 176)
        Me.dgvProduct.TabIndex = 281
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(28, 273)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(100, 17)
        Me.lblCategory.TabIndex = 275
        Me.lblCategory.Text = "Product Details"
        '
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.Color.Transparent
        Me.Pic.ForeColor = System.Drawing.Color.Black
        Me.Pic.Image = CType(resources.GetObject("Pic.Image"), System.Drawing.Image)
        Me.Pic.Location = New System.Drawing.Point(20, 268)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(10, 39)
        Me.Pic.TabIndex = 276
        Me.Pic.TabStop = False
        '
        'dgvSales
        '
        Me.dgvSales.AllowUserToAddRows = False
        Me.dgvSales.AllowUserToDeleteRows = False
        Me.dgvSales.AllowUserToResizeRows = False
        Me.dgvSales.BackgroundColor = System.Drawing.Color.White
        Me.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSales.CausesValidation = False
        Me.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSales.ColumnHeadersHeight = 32
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colReceipt, Me.colCustName, Me.colDate, Me.colSubTotal, Me.colVat, Me.colLabour, Me.colGrandTotal, Me.colReceiveAmonut, Me.colDiscount, Me.colCustID})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSales.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvSales.EnableHeadersVisualStyles = False
        Me.dgvSales.Location = New System.Drawing.Point(19, 49)
        Me.dgvSales.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvSales.MultiSelect = False
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.ReadOnly = True
        Me.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvSales.RowHeadersVisible = False
        Me.dgvSales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSales.RowTemplate.Height = 27
        Me.dgvSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSales.ShowEditingIcon = False
        Me.dgvSales.Size = New System.Drawing.Size(889, 220)
        Me.dgvSales.TabIndex = 279
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FocusCuesEnabled = False
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPrint.Location = New System.Drawing.Point(82, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnPrint.Size = New System.Drawing.Size(75, 50)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnPrint.TabIndex = 281
        Me.btnPrint.Text = "Print"
        '
        'btnReturn
        '
        Me.btnReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReturn.FocusCuesEnabled = False
        Me.btnReturn.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnReturn.Location = New System.Drawing.Point(3, 7)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnReturn.Size = New System.Drawing.Size(75, 50)
        Me.btnReturn.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnReturn.Symbol = ""
        Me.btnReturn.SymbolSize = 24.0!
        Me.btnReturn.TabIndex = 282
        Me.btnReturn.Text = "Exchange"
        '
        'btnDelete
        '
        Me.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FocusCuesEnabled = False
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnDelete.Location = New System.Drawing.Point(161, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnDelete.Size = New System.Drawing.Size(75, 50)
        Me.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnDelete.TabIndex = 283
        Me.btnDelete.Text = "Cash Return"
        '
        'panButton
        '
        Me.panButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panButton.BackColor = System.Drawing.Color.Transparent
        Me.panButton.Controls.Add(Me.btnDelete)
        Me.panButton.Controls.Add(Me.btnReturn)
        Me.panButton.Controls.Add(Me.btnPrint)
        Me.panButton.ForeColor = System.Drawing.Color.Black
        Me.panButton.Location = New System.Drawing.Point(368, 456)
        Me.panButton.Name = "panButton"
        Me.panButton.Size = New System.Drawing.Size(240, 60)
        Me.panButton.TabIndex = 280
        '
        'grpSales
        '
        Me.grpSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpSales.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpSales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.grpSales.Controls.Add(Me.dtpSale)
        Me.grpSales.Controls.Add(Me.lblPurchase)
        Me.grpSales.Controls.Add(Me.dgvProduct)
        Me.grpSales.Controls.Add(Me.dgvSales)
        Me.grpSales.Controls.Add(Me.lblCategory)
        Me.grpSales.Controls.Add(Me.Pic)
        Me.grpSales.Controls.Add(Me.txtSearch)
        Me.grpSales.Controls.Add(Me.panButton)
        Me.grpSales.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpSales.Location = New System.Drawing.Point(15, 12)
        Me.grpSales.Name = "grpSales"
        Me.grpSales.Size = New System.Drawing.Size(920, 529)
        '
        '
        '
        Me.grpSales.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grpSales.Style.BackColorGradientAngle = 90
        Me.grpSales.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grpSales.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSales.Style.BorderBottomWidth = 1
        Me.grpSales.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grpSales.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSales.Style.BorderLeftWidth = 1
        Me.grpSales.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSales.Style.BorderRightWidth = 1
        Me.grpSales.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSales.Style.BorderTopWidth = 1
        Me.grpSales.Style.CornerDiameter = 4
        Me.grpSales.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grpSales.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grpSales.Style.TextColor = System.Drawing.Color.Black
        '
        '
        '
        Me.grpSales.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpSales.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpSales.TabIndex = 284
        '
        'dtpSale
        '
        Me.dtpSale.CustomFormat = "dd MMM yyyy"
        Me.dtpSale.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSale.Location = New System.Drawing.Point(683, 11)
        Me.dtpSale.Name = "dtpSale"
        Me.dtpSale.Size = New System.Drawing.Size(225, 27)
        Me.dtpSale.TabIndex = 294
        '
        'lblPurchase
        '
        Me.lblPurchase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPurchase.ForeColor = System.Drawing.Color.Black
        Me.lblPurchase.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblPurchase.Location = New System.Drawing.Point(589, 14)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(88, 24)
        Me.lblPurchase.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchase.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.lblPurchase.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblPurchase.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblPurchase.TabIndex = 292
        Me.lblPurchase.TabStop = False
        Me.lblPurchase.Values.Text = "Sales Date :"
        '
        'colReceipt
        '
        Me.colReceipt.HeaderText = "Receipt No"
        Me.colReceipt.Name = "colReceipt"
        Me.colReceipt.ReadOnly = True
        Me.colReceipt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colCustName
        '
        Me.colCustName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colCustName.DefaultCellStyle = DataGridViewCellStyle9
        Me.colCustName.HeaderText = "Account Name"
        Me.colCustName.Name = "colCustName"
        Me.colCustName.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Sale Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colSubTotal
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSubTotal.DefaultCellStyle = DataGridViewCellStyle10
        Me.colSubTotal.HeaderText = "Sub Total"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        '
        'colVat
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colVat.DefaultCellStyle = DataGridViewCellStyle11
        Me.colVat.HeaderText = "VAT"
        Me.colVat.Name = "colVat"
        Me.colVat.ReadOnly = True
        Me.colVat.Width = 80
        '
        'colLabour
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colLabour.DefaultCellStyle = DataGridViewCellStyle12
        Me.colLabour.HeaderText = "Labour"
        Me.colLabour.Name = "colLabour"
        Me.colLabour.ReadOnly = True
        '
        'colGrandTotal
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colGrandTotal.DefaultCellStyle = DataGridViewCellStyle13
        Me.colGrandTotal.HeaderText = "Grand Total"
        Me.colGrandTotal.Name = "colGrandTotal"
        Me.colGrandTotal.ReadOnly = True
        Me.colGrandTotal.Width = 120
        '
        'colReceiveAmonut
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colReceiveAmonut.DefaultCellStyle = DataGridViewCellStyle14
        Me.colReceiveAmonut.HeaderText = "Receive Amt"
        Me.colReceiveAmonut.Name = "colReceiveAmonut"
        Me.colReceiveAmonut.ReadOnly = True
        Me.colReceiveAmonut.Width = 120
        '
        'colDiscount
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDiscount.DefaultCellStyle = DataGridViewCellStyle15
        Me.colDiscount.HeaderText = "Cash Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.ReadOnly = True
        Me.colDiscount.Width = 120
        '
        'colCustID
        '
        Me.colCustID.HeaderText = "Cust ID"
        Me.colCustID.Name = "colCustID"
        Me.colCustID.ReadOnly = True
        Me.colCustID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCustID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colCustID.Visible = False
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Barcode"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        Me.colBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colBarcode.Width = 120
        '
        'colProductName
        '
        Me.colProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colProductName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colProductName.HeaderText = "Product Name"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.ReadOnly = True
        Me.colProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        '
        'colPcs
        '
        Me.colPcs.HeaderText = "Pcs"
        Me.colPcs.Name = "colPcs"
        Me.colPcs.ReadOnly = True
        '
        'colPrice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPrice.HeaderText = "Product Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 120
        '
        'colProductVat
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colProductVat.DefaultCellStyle = DataGridViewCellStyle4
        Me.colProductVat.HeaderText = "Product Vat"
        Me.colProductVat.Name = "colProductVat"
        Me.colProductVat.ReadOnly = True
        Me.colProductVat.Width = 120
        '
        'colProductDisount
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colProductDisount.DefaultCellStyle = DataGridViewCellStyle5
        Me.colProductDisount.HeaderText = "Product Discount"
        Me.colProductDisount.Name = "colProductDisount"
        Me.colProductDisount.ReadOnly = True
        Me.colProductDisount.Visible = False
        Me.colProductDisount.Width = 130
        '
        'colProductTotal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colProductTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.colProductTotal.HeaderText = "Total Price"
        Me.colProductTotal.Name = "colProductTotal"
        Me.colProductTotal.ReadOnly = True
        Me.colProductTotal.Width = 120
        '
        'FrmSalesReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.grpSales)
        Me.DoubleBuffered = True
        Me.Name = "FrmSalesReceipt"
        Me.Text = "Sales Receipt"
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panButton.ResumeLayout(False)
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnReturn As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnDelete As DevComponents.DotNetBar.ButtonX
    Friend WithEvents panButton As System.Windows.Forms.Panel
    Friend WithEvents grpSales As DevComponents.DotNetBar.Controls.GroupPanel
    Private WithEvents lblPurchase As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpSale As System.Windows.Forms.DateTimePicker
    Friend WithEvents colReceipt As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colCustName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDate As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colSubTotal As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colVat As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colLabour As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colGrandTotal As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colReceiveAmonut As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDiscount As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colCustID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colBarcode As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colProductName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colQty As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPcs As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPrice As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colProductVat As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colProductDisount As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colProductTotal As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
