<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarcode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarcode))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.rbnBarcode = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.rbnQrCode = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.grpUser = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.panButton = New System.Windows.Forms.Panel()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnView = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.dgvBarcode = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Product = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Price = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Dscount = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpUser.SuspendLayout()
        Me.panButton.SuspendLayout()
        CType(Me.dgvBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'rbnBarcode
        '
        Me.rbnBarcode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.rbnBarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnBarcode.CheckBoxImageChecked = CType(resources.GetObject("rbnBarcode.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnBarcode.CheckBoxImageUnChecked = CType(resources.GetObject("rbnBarcode.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnBarcode.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnBarcode.Checked = True
        Me.rbnBarcode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnBarcode.CheckValue = "Y"
        Me.rbnBarcode.FocusCuesEnabled = False
        Me.rbnBarcode.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnBarcode.ForeColor = System.Drawing.Color.Black
        Me.rbnBarcode.Location = New System.Drawing.Point(815, 14)
        Me.rbnBarcode.Name = "rbnBarcode"
        Me.rbnBarcode.Size = New System.Drawing.Size(87, 20)
        Me.rbnBarcode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnBarcode.TabIndex = 297
        Me.rbnBarcode.Text = " Barcode"
        '
        'rbnQrCode
        '
        Me.rbnQrCode.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.rbnQrCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnQrCode.CheckBoxImageChecked = CType(resources.GetObject("rbnQrCode.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnQrCode.CheckBoxImageUnChecked = CType(resources.GetObject("rbnQrCode.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnQrCode.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnQrCode.FocusCuesEnabled = False
        Me.rbnQrCode.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnQrCode.ForeColor = System.Drawing.Color.Black
        Me.rbnQrCode.Location = New System.Drawing.Point(711, 14)
        Me.rbnQrCode.Name = "rbnQrCode"
        Me.rbnQrCode.Size = New System.Drawing.Size(89, 20)
        Me.rbnQrCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnQrCode.TabIndex = 296
        Me.rbnQrCode.Text = " QR Code"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Tahoma", 13.0!)
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(16, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(66, 23)
        Me.LabelX1.TabIndex = 294
        Me.LabelX1.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(88, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(258, 27)
        Me.txtSearch.TabIndex = 293
        '
        'grpUser
        '
        Me.grpUser.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpUser.CanvasColor = System.Drawing.Color.WhiteSmoke
        Me.grpUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.grpUser.Controls.Add(Me.panButton)
        Me.grpUser.Controls.Add(Me.dgvBarcode)
        Me.grpUser.Controls.Add(Me.rbnBarcode)
        Me.grpUser.Controls.Add(Me.rbnQrCode)
        Me.grpUser.Controls.Add(Me.LabelX1)
        Me.grpUser.Controls.Add(Me.txtSearch)
        Me.grpUser.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpUser.Location = New System.Drawing.Point(12, 12)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(920, 529)
        '
        '
        '
        Me.grpUser.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grpUser.Style.BackColorGradientAngle = 90
        Me.grpUser.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grpUser.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderBottomWidth = 1
        Me.grpUser.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grpUser.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderLeftWidth = 1
        Me.grpUser.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderRightWidth = 1
        Me.grpUser.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderTopWidth = 1
        Me.grpUser.Style.CornerDiameter = 4
        Me.grpUser.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grpUser.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grpUser.Style.TextColor = System.Drawing.Color.Black
        '
        '
        '
        Me.grpUser.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpUser.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpUser.TabIndex = 283
        '
        'panButton
        '
        Me.panButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panButton.BackColor = System.Drawing.Color.Transparent
        Me.panButton.Controls.Add(Me.btnClear)
        Me.panButton.Controls.Add(Me.btnView)
        Me.panButton.Controls.Add(Me.btnPrint)
        Me.panButton.ForeColor = System.Drawing.Color.Black
        Me.panButton.Location = New System.Drawing.Point(380, 457)
        Me.panButton.Name = "panButton"
        Me.panButton.Size = New System.Drawing.Size(215, 60)
        Me.panButton.TabIndex = 300
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FocusCuesEnabled = False
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnClear.Location = New System.Drawing.Point(146, 3)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnClear.Size = New System.Drawing.Size(63, 53)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnClear.TabIndex = 266
        Me.btnClear.Text = "Clear"
        '
        'btnView
        '
        Me.btnView.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.FocusCuesEnabled = False
        Me.btnView.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnView.Location = New System.Drawing.Point(8, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnView.Size = New System.Drawing.Size(63, 53)
        Me.btnView.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnView.Symbol = ""
        Me.btnView.SymbolSize = 24.0!
        Me.btnView.TabIndex = 263
        Me.btnView.Text = "View"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FocusCuesEnabled = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnPrint.Location = New System.Drawing.Point(77, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnPrint.Size = New System.Drawing.Size(63, 53)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnPrint.TabIndex = 262
        Me.btnPrint.Text = "Print"
        '
        'dgvBarcode
        '
        Me.dgvBarcode.AllowUserToAddRows = False
        Me.dgvBarcode.AllowUserToDeleteRows = False
        Me.dgvBarcode.AllowUserToResizeRows = False
        Me.dgvBarcode.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBarcode.CausesValidation = False
        Me.dgvBarcode.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvBarcode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvBarcode.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBarcode.ColumnHeadersHeight = 32
        Me.dgvBarcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvBarcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Product, Me.Price, Me.Dscount, Me.DataGridViewLabelXColumn2, Me.Quantity})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBarcode.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvBarcode.EnableHeadersVisualStyles = False
        Me.dgvBarcode.Location = New System.Drawing.Point(16, 42)
        Me.dgvBarcode.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvBarcode.MultiSelect = False
        Me.dgvBarcode.Name = "dgvBarcode"
        Me.dgvBarcode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvBarcode.RowHeadersVisible = False
        Me.dgvBarcode.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dgvBarcode.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvBarcode.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvBarcode.RowTemplate.Height = 27
        Me.dgvBarcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBarcode.ShowEditingIcon = False
        Me.dgvBarcode.Size = New System.Drawing.Size(886, 409)
        Me.dgvBarcode.TabIndex = 299
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'Product
        '
        Me.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Product.DefaultCellStyle = DataGridViewCellStyle2
        Me.Product.HeaderText = "Product Name"
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        Me.Product.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Price
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Price.DefaultCellStyle = DataGridViewCellStyle3
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Price.Width = 110
        '
        'Dscount
        '
        Me.Dscount.HeaderText = "Discount"
        Me.Dscount.Name = "Dscount"
        Me.Dscount.ReadOnly = True
        Me.Dscount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dscount.Width = 110
        '
        'DataGridViewLabelXColumn2
        '
        Me.DataGridViewLabelXColumn2.HeaderText = "VAT"
        Me.DataGridViewLabelXColumn2.Name = "DataGridViewLabelXColumn2"
        Me.DataGridViewLabelXColumn2.ReadOnly = True
        Me.DataGridViewLabelXColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLabelXColumn2.Width = 110
        '
        'Quantity
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantity.Width = 120
        '
        'FrmBarcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 575)
        Me.Controls.Add(Me.grpUser)
        Me.DoubleBuffered = True
        Me.Name = "FrmBarcode"
        Me.Text = "Barcode"
        Me.grpUser.ResumeLayout(False)
        Me.panButton.ResumeLayout(False)
        CType(Me.dgvBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents rbnBarcode As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents rbnQrCode As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents grpUser As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnView As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvBarcode As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Product As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Price As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Dscount As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn2 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents panButton As System.Windows.Forms.Panel
End Class
