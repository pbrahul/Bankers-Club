<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductsList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductsList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panProducts = New DevComponents.DotNetBar.PanelEx()
        Me.rbnCategory = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbnProducts = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.dgvCategory = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLabelXColumn8 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn9 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn10 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.dgvCatProduct = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.ElementStyle21 = New DevComponents.DotNetBar.ElementStyle()
        Me.DataGridViewLabelXColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn3 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn4 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn6 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn7 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colBarcode = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colUnits = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colReorder = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPurchase = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colSale = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.panProducts.SuspendLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCatProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panProducts
        '
        Me.panProducts.CanvasColor = System.Drawing.SystemColors.Control
        Me.panProducts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panProducts.Controls.Add(Me.rbnCategory)
        Me.panProducts.Controls.Add(Me.rbnProducts)
        Me.panProducts.Controls.Add(Me.dgvCategory)
        Me.panProducts.Controls.Add(Me.dgvCatProduct)
        Me.panProducts.Controls.Add(Me.txtSearch)
        Me.panProducts.Controls.Add(Me.Pic)
        Me.panProducts.Controls.Add(Me.lblCategory)
        Me.panProducts.Controls.Add(Me.dgvProduct)
        Me.panProducts.Location = New System.Drawing.Point(12, 1)
        Me.panProducts.Name = "panProducts"
        Me.panProducts.Size = New System.Drawing.Size(926, 537)
        Me.panProducts.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panProducts.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panProducts.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panProducts.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panProducts.Style.GradientAngle = 90
        Me.panProducts.TabIndex = 281
        '
        'rbnCategory
        '
        Me.rbnCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbnCategory.ForeColor = System.Drawing.Color.Black
        Me.rbnCategory.Images.CheckedNormal = CType(resources.GetObject("rbnCategory.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnCategory.Images.CheckedPressed = CType(resources.GetObject("rbnCategory.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnCategory.Images.CheckedTracking = CType(resources.GetObject("rbnCategory.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnCategory.Images.UncheckedNormal = CType(resources.GetObject("rbnCategory.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnCategory.Images.UncheckedPressed = CType(resources.GetObject("rbnCategory.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnCategory.Images.UncheckedTracking = CType(resources.GetObject("rbnCategory.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnCategory.Location = New System.Drawing.Point(667, 24)
        Me.rbnCategory.Name = "rbnCategory"
        Me.rbnCategory.Size = New System.Drawing.Size(131, 20)
        Me.rbnCategory.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnCategory.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnCategory.TabIndex = 293
        Me.rbnCategory.Values.Text = "Product Category"
        '
        'rbnProducts
        '
        Me.rbnProducts.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rbnProducts.ForeColor = System.Drawing.Color.Black
        Me.rbnProducts.Images.CheckedNormal = CType(resources.GetObject("rbnProducts.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnProducts.Images.CheckedPressed = CType(resources.GetObject("rbnProducts.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnProducts.Images.CheckedTracking = CType(resources.GetObject("rbnProducts.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnProducts.Images.UncheckedNormal = CType(resources.GetObject("rbnProducts.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnProducts.Images.UncheckedPressed = CType(resources.GetObject("rbnProducts.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnProducts.Images.UncheckedTracking = CType(resources.GetObject("rbnProducts.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnProducts.Location = New System.Drawing.Point(810, 24)
        Me.rbnProducts.Name = "rbnProducts"
        Me.rbnProducts.Size = New System.Drawing.Size(97, 20)
        Me.rbnProducts.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnProducts.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnProducts.TabIndex = 294
        Me.rbnProducts.Values.Text = "All Products"
        '
        'dgvCategory
        '
        Me.dgvCategory.AllowUserToAddRows = False
        Me.dgvCategory.AllowUserToDeleteRows = False
        Me.dgvCategory.AllowUserToResizeRows = False
        Me.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCategory.CausesValidation = False
        Me.dgvCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCategory.ColumnHeadersHeight = 32
        Me.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCategory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLabelXColumn8, Me.DataGridViewLabelXColumn9, Me.DataGridViewLabelXColumn10})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCategory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCategory.EnableHeadersVisualStyles = False
        Me.dgvCategory.Location = New System.Drawing.Point(19, 58)
        Me.dgvCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCategory.MultiSelect = False
        Me.dgvCategory.Name = "dgvCategory"
        Me.dgvCategory.ReadOnly = True
        Me.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvCategory.RowHeadersVisible = False
        Me.dgvCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvCategory.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCategory.RowTemplate.Height = 27
        Me.dgvCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategory.ShowEditingIcon = False
        Me.dgvCategory.Size = New System.Drawing.Size(889, 221)
        Me.dgvCategory.TabIndex = 292
        '
        'DataGridViewLabelXColumn8
        '
        Me.DataGridViewLabelXColumn8.HeaderText = "Category ID"
        Me.DataGridViewLabelXColumn8.Name = "DataGridViewLabelXColumn8"
        Me.DataGridViewLabelXColumn8.ReadOnly = True
        Me.DataGridViewLabelXColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn8.Width = 200
        '
        'DataGridViewLabelXColumn9
        '
        Me.DataGridViewLabelXColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewLabelXColumn9.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewLabelXColumn9.HeaderText = "Category Details"
        Me.DataGridViewLabelXColumn9.Name = "DataGridViewLabelXColumn9"
        Me.DataGridViewLabelXColumn9.ReadOnly = True
        Me.DataGridViewLabelXColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewLabelXColumn10
        '
        Me.DataGridViewLabelXColumn10.HeaderText = "Category Code"
        Me.DataGridViewLabelXColumn10.Name = "DataGridViewLabelXColumn10"
        Me.DataGridViewLabelXColumn10.ReadOnly = True
        Me.DataGridViewLabelXColumn10.Width = 200
        '
        'dgvCatProduct
        '
        Me.dgvCatProduct.AllowUserToAddRows = False
        Me.dgvCatProduct.AllowUserToDeleteRows = False
        Me.dgvCatProduct.AllowUserToResizeRows = False
        Me.dgvCatProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvCatProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCatProduct.CausesValidation = False
        Me.dgvCatProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCatProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCatProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCatProduct.ColumnHeadersHeight = 32
        Me.dgvCatProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCatProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLabelXColumn1, Me.DataGridViewLabelXColumn2, Me.DataGridViewLabelXColumn3, Me.DataGridViewLabelXColumn4, Me.DataGridViewLabelXColumn6, Me.DataGridViewLabelXColumn7})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCatProduct.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCatProduct.EnableHeadersVisualStyles = False
        Me.dgvCatProduct.Location = New System.Drawing.Point(27, 308)
        Me.dgvCatProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCatProduct.MultiSelect = False
        Me.dgvCatProduct.Name = "dgvCatProduct"
        Me.dgvCatProduct.ReadOnly = True
        Me.dgvCatProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvCatProduct.RowHeadersVisible = False
        Me.dgvCatProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvCatProduct.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvCatProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvCatProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCatProduct.RowTemplate.Height = 27
        Me.dgvCatProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCatProduct.ShowEditingIcon = False
        Me.dgvCatProduct.Size = New System.Drawing.Size(879, 213)
        Me.dgvCatProduct.TabIndex = 291
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
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
        'Pic
        '
        Me.Pic.BackColor = System.Drawing.Color.Transparent
        Me.Pic.ForeColor = System.Drawing.Color.Black
        Me.Pic.Image = CType(resources.GetObject("Pic.Image"), System.Drawing.Image)
        Me.Pic.Location = New System.Drawing.Point(20, 279)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(10, 39)
        Me.Pic.TabIndex = 276
        Me.Pic.TabStop = False
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
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AllowUserToResizeRows = False
        Me.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProduct.CausesValidation = False
        Me.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProduct.ColumnHeadersHeight = 32
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarcode, Me.colName, Me.colUnits, Me.colReorder, Me.colPurchase, Me.colSale})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvProduct.EnableHeadersVisualStyles = False
        Me.dgvProduct.Location = New System.Drawing.Point(19, 58)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProduct.MultiSelect = False
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvProduct.RowHeadersVisible = False
        Me.dgvProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvProduct.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProduct.RowTemplate.Height = 27
        Me.dgvProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.ShowEditingIcon = False
        Me.dgvProduct.Size = New System.Drawing.Size(889, 455)
        Me.dgvProduct.TabIndex = 265
        '
        'ElementStyle21
        '
        Me.ElementStyle21.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle21.Name = "ElementStyle21"
        Me.ElementStyle21.TextColor = System.Drawing.Color.Black
        '
        'DataGridViewLabelXColumn1
        '
        Me.DataGridViewLabelXColumn1.HeaderText = "Barcode"
        Me.DataGridViewLabelXColumn1.Name = "DataGridViewLabelXColumn1"
        Me.DataGridViewLabelXColumn1.ReadOnly = True
        Me.DataGridViewLabelXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn1.Width = 120
        '
        'DataGridViewLabelXColumn2
        '
        Me.DataGridViewLabelXColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewLabelXColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewLabelXColumn2.HeaderText = "Product Name"
        Me.DataGridViewLabelXColumn2.Name = "DataGridViewLabelXColumn2"
        Me.DataGridViewLabelXColumn2.ReadOnly = True
        Me.DataGridViewLabelXColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewLabelXColumn3
        '
        Me.DataGridViewLabelXColumn3.HeaderText = "Units"
        Me.DataGridViewLabelXColumn3.Name = "DataGridViewLabelXColumn3"
        Me.DataGridViewLabelXColumn3.ReadOnly = True
        '
        'DataGridViewLabelXColumn4
        '
        Me.DataGridViewLabelXColumn4.HeaderText = "Reorder Label"
        Me.DataGridViewLabelXColumn4.Name = "DataGridViewLabelXColumn4"
        Me.DataGridViewLabelXColumn4.ReadOnly = True
        Me.DataGridViewLabelXColumn4.Width = 120
        '
        'DataGridViewLabelXColumn6
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewLabelXColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewLabelXColumn6.HeaderText = "Purchase Price"
        Me.DataGridViewLabelXColumn6.Name = "DataGridViewLabelXColumn6"
        Me.DataGridViewLabelXColumn6.ReadOnly = True
        Me.DataGridViewLabelXColumn6.Width = 150
        '
        'DataGridViewLabelXColumn7
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewLabelXColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewLabelXColumn7.HeaderText = "Sales Price"
        Me.DataGridViewLabelXColumn7.Name = "DataGridViewLabelXColumn7"
        Me.DataGridViewLabelXColumn7.ReadOnly = True
        Me.DataGridViewLabelXColumn7.Width = 150
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
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle10
        Me.colName.HeaderText = "Product Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        '
        'colReorder
        '
        Me.colReorder.HeaderText = "Reorder Label"
        Me.colReorder.Name = "colReorder"
        Me.colReorder.ReadOnly = True
        Me.colReorder.Width = 120
        '
        'colPurchase
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPurchase.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPurchase.HeaderText = "Purchase Price"
        Me.colPurchase.Name = "colPurchase"
        Me.colPurchase.ReadOnly = True
        Me.colPurchase.Width = 150
        '
        'colSale
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colSale.DefaultCellStyle = DataGridViewCellStyle12
        Me.colSale.HeaderText = "Sales Price"
        Me.colSale.Name = "colSale"
        Me.colSale.ReadOnly = True
        Me.colSale.Width = 150
        '
        'FrmProductsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panProducts)
        Me.DoubleBuffered = True
        Me.Name = "FrmProductsList"
        Me.Text = "Products Listing"
        Me.panProducts.ResumeLayout(False)
        Me.panProducts.PerformLayout()
        CType(Me.dgvCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCatProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Private WithEvents ElementStyle21 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents panProducts As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvCatProduct As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCategory As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewLabelXColumn8 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn9 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn10 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents rbnCategory As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbnProducts As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents DataGridViewLabelXColumn1 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn2 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn3 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn4 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn6 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn7 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colBarcode As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colUnits As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colReorder As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPurchase As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colSale As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
