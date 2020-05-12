<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panProducts = New DevComponents.DotNetBar.PanelEx()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.colBarcode = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colQty = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colUnits = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPurchase = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colSale = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPoint = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colTotal = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.panProducts.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "1363183678_add-user.png")
        Me.imageList1.Images.SetKeyName(1, "1363183687_add-notes.png")
        Me.imageList1.Images.SetKeyName(2, "1363183698_add-group.png")
        Me.imageList1.Images.SetKeyName(3, "1363183700_shopcartadd_128x128.png")
        Me.imageList1.Images.SetKeyName(4, "1363183706_shopping-basket-add.png")
        Me.imageList1.Images.SetKeyName(5, "1363183726_shoppingcart_add.png")
        Me.imageList1.Images.SetKeyName(6, "1363183771_Money.png")
        Me.imageList1.Images.SetKeyName(7, "1363183773_Business.png")
        Me.imageList1.Images.SetKeyName(8, "1363183788_Delivery.png")
        Me.imageList1.Images.SetKeyName(9, "1363183986_man-24.png")
        Me.imageList1.Images.SetKeyName(10, "1363195124_product-sales-report.png")
        Me.imageList1.Images.SetKeyName(11, "1363195426_sale.png")
        Me.imageList1.Images.SetKeyName(12, "1363195447_corbeille box sale v.png")
        Me.imageList1.Images.SetKeyName(13, "bag1_16.png")
        Me.imageList1.Images.SetKeyName(14, "billing.png")
        Me.imageList1.Images.SetKeyName(15, "checkout.png")
        Me.imageList1.Images.SetKeyName(16, "delivery.png")
        Me.imageList1.Images.SetKeyName(17, "document_library.png")
        Me.imageList1.Images.SetKeyName(18, "empty-shopping-cart.png")
        Me.imageList1.Images.SetKeyName(19, "khexedit.png")
        Me.imageList1.Images.SetKeyName(20, "Measure.png")
        Me.imageList1.Images.SetKeyName(21, "offer_50.png")
        '
        'panProducts
        '
        Me.panProducts.CanvasColor = System.Drawing.SystemColors.Control
        Me.panProducts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panProducts.Controls.Add(Me.txtSearch)
        Me.panProducts.Controls.Add(Me.dgvStock)
        Me.panProducts.Controls.Add(Me.lblCategory)
        Me.panProducts.Location = New System.Drawing.Point(12, 8)
        Me.panProducts.Name = "panProducts"
        Me.panProducts.Size = New System.Drawing.Size(926, 537)
        Me.panProducts.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panProducts.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panProducts.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panProducts.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panProducts.Style.GradientAngle = 90
        Me.panProducts.TabIndex = 282
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(19, 20)
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
        Me.txtSearch.TabIndex = 290
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.btnSearch.UniqueName = ""
        '
        'dgvStock
        '
        Me.dgvStock.AllowUserToAddRows = False
        Me.dgvStock.AllowUserToDeleteRows = False
        Me.dgvStock.AllowUserToResizeRows = False
        Me.dgvStock.BackgroundColor = System.Drawing.Color.White
        Me.dgvStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvStock.CausesValidation = False
        Me.dgvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStock.ColumnHeadersHeight = 32
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.colName, Me.colQty, Me.colUnits, Me.colPurchase, Me.colSale, Me.colPoint, Me.colTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStock.EnableHeadersVisualStyles = False
        Me.dgvStock.Location = New System.Drawing.Point(19, 58)
        Me.dgvStock.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvStock.MultiSelect = False
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.ReadOnly = True
        Me.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvStock.RowHeadersVisible = False
        Me.dgvStock.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvStock.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvStock.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvStock.RowTemplate.Height = 27
        Me.dgvStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStock.ShowEditingIcon = False
        Me.dgvStock.Size = New System.Drawing.Size(889, 455)
        Me.dgvStock.TabIndex = 265
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(28, 284)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(108, 17)
        Me.lblCategory.TabIndex = 275
        Me.lblCategory.Text = "Category Details"
        '
        'colBarcode
        '
        Me.colBarcode.HeaderText = "Barcode"
        Me.colBarcode.Name = "colBarcode"
        Me.colBarcode.ReadOnly = True
        Me.colBarcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colBarcode.Width = 120
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colName.HeaderText = "Product Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colQty
        '
        Me.colQty.HeaderText = "Stock Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 120
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        '
        'colPurchase
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPurchase.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPurchase.HeaderText = "Purchase Price"
        Me.colPurchase.Name = "colPurchase"
        Me.colPurchase.ReadOnly = True
        Me.colPurchase.Width = 120
        '
        'colSale
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSale.DefaultCellStyle = DataGridViewCellStyle4
        Me.colSale.HeaderText = "Sale Price"
        Me.colSale.Name = "colSale"
        Me.colSale.ReadOnly = True
        Me.colSale.Width = 120
        '
        'colPoint
        '
        Me.colPoint.HeaderText = "Reorder Point"
        Me.colPoint.Name = "colPoint"
        Me.colPoint.ReadOnly = True
        Me.colPoint.Width = 120
        '
        'colTotal
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle5
        Me.colTotal.HeaderText = "Total Price"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        Me.colTotal.Width = 120
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panProducts)
        Me.DoubleBuffered = True
        Me.Name = "FrmStock"
        Me.Text = "Stock Monitoring"
        Me.panProducts.ResumeLayout(False)
        Me.panProducts.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents panProducts As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents colBarcode As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colQty As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colUnits As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPurchase As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colSale As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPoint As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colTotal As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
