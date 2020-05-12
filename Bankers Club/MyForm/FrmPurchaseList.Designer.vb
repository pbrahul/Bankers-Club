<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchaseList
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPurchaseList))
        Me.panProduct = New DevComponents.DotNetBar.PanelEx()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLabelXColumn6 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn8 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn10 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn9 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn12 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn13 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.dgvPurchase = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLabelXColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn3 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn4 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn5 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn7 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.dtpPurchase = New System.Windows.Forms.DateTimePicker()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblPurchase = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.panProduct.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panProduct
        '
        Me.panProduct.CanvasColor = System.Drawing.SystemColors.Control
        Me.panProduct.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panProduct.Controls.Add(Me.dgvProduct)
        Me.panProduct.Controls.Add(Me.dgvPurchase)
        Me.panProduct.Controls.Add(Me.dtpPurchase)
        Me.panProduct.Controls.Add(Me.txtSearch)
        Me.panProduct.Controls.Add(Me.lblPurchase)
        Me.panProduct.Controls.Add(Me.Label1)
        Me.panProduct.Controls.Add(Me.Pic)
        Me.panProduct.Location = New System.Drawing.Point(12, 8)
        Me.panProduct.Name = "panProduct"
        Me.panProduct.Size = New System.Drawing.Size(926, 537)
        Me.panProduct.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panProduct.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panProduct.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panProduct.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panProduct.Style.GradientAngle = 90
        Me.panProduct.TabIndex = 283
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
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLabelXColumn6, Me.DataGridViewLabelXColumn8, Me.DataGridViewLabelXColumn10, Me.DataGridViewLabelXColumn9, Me.DataGridViewLabelXColumn12, Me.DataGridViewLabelXColumn13})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProduct.EnableHeadersVisualStyles = False
        Me.dgvProduct.Location = New System.Drawing.Point(27, 308)
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
        Me.dgvProduct.Size = New System.Drawing.Size(879, 213)
        Me.dgvProduct.TabIndex = 295
        '
        'DataGridViewLabelXColumn6
        '
        Me.DataGridViewLabelXColumn6.HeaderText = "Barcode"
        Me.DataGridViewLabelXColumn6.Name = "DataGridViewLabelXColumn6"
        Me.DataGridViewLabelXColumn6.ReadOnly = True
        Me.DataGridViewLabelXColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn6.Width = 130
        '
        'DataGridViewLabelXColumn8
        '
        Me.DataGridViewLabelXColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewLabelXColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewLabelXColumn8.HeaderText = "Product Name"
        Me.DataGridViewLabelXColumn8.Name = "DataGridViewLabelXColumn8"
        Me.DataGridViewLabelXColumn8.ReadOnly = True
        Me.DataGridViewLabelXColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewLabelXColumn10
        '
        Me.DataGridViewLabelXColumn10.HeaderText = "Qty"
        Me.DataGridViewLabelXColumn10.Name = "DataGridViewLabelXColumn10"
        Me.DataGridViewLabelXColumn10.ReadOnly = True
        Me.DataGridViewLabelXColumn10.Width = 120
        '
        'DataGridViewLabelXColumn9
        '
        Me.DataGridViewLabelXColumn9.HeaderText = "Units"
        Me.DataGridViewLabelXColumn9.Name = "DataGridViewLabelXColumn9"
        Me.DataGridViewLabelXColumn9.ReadOnly = True
        Me.DataGridViewLabelXColumn9.Width = 140
        '
        'DataGridViewLabelXColumn12
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewLabelXColumn12.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewLabelXColumn12.HeaderText = "Price"
        Me.DataGridViewLabelXColumn12.Name = "DataGridViewLabelXColumn12"
        Me.DataGridViewLabelXColumn12.ReadOnly = True
        Me.DataGridViewLabelXColumn12.Width = 150
        '
        'DataGridViewLabelXColumn13
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewLabelXColumn13.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewLabelXColumn13.HeaderText = "Total Price"
        Me.DataGridViewLabelXColumn13.Name = "DataGridViewLabelXColumn13"
        Me.DataGridViewLabelXColumn13.ReadOnly = True
        Me.DataGridViewLabelXColumn13.Width = 150
        '
        'dgvPurchase
        '
        Me.dgvPurchase.AllowUserToAddRows = False
        Me.dgvPurchase.AllowUserToDeleteRows = False
        Me.dgvPurchase.AllowUserToResizeRows = False
        Me.dgvPurchase.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPurchase.CausesValidation = False
        Me.dgvPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPurchase.ColumnHeadersHeight = 32
        Me.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLabelXColumn1, Me.DataGridViewLabelXColumn2, Me.DataGridViewLabelXColumn3, Me.DataGridViewLabelXColumn4, Me.DataGridViewLabelXColumn5, Me.DataGridViewLabelXColumn7})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchase.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPurchase.EnableHeadersVisualStyles = False
        Me.dgvPurchase.Location = New System.Drawing.Point(19, 58)
        Me.dgvPurchase.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPurchase.MultiSelect = False
        Me.dgvPurchase.Name = "dgvPurchase"
        Me.dgvPurchase.ReadOnly = True
        Me.dgvPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvPurchase.RowHeadersVisible = False
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPurchase.RowTemplate.Height = 27
        Me.dgvPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPurchase.ShowEditingIcon = False
        Me.dgvPurchase.Size = New System.Drawing.Size(889, 221)
        Me.dgvPurchase.TabIndex = 294
        '
        'DataGridViewLabelXColumn1
        '
        Me.DataGridViewLabelXColumn1.HeaderText = "Purchase ID"
        Me.DataGridViewLabelXColumn1.Name = "DataGridViewLabelXColumn1"
        Me.DataGridViewLabelXColumn1.ReadOnly = True
        Me.DataGridViewLabelXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn1.Width = 130
        '
        'DataGridViewLabelXColumn2
        '
        Me.DataGridViewLabelXColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewLabelXColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewLabelXColumn2.HeaderText = "Supplier Name"
        Me.DataGridViewLabelXColumn2.Name = "DataGridViewLabelXColumn2"
        Me.DataGridViewLabelXColumn2.ReadOnly = True
        Me.DataGridViewLabelXColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewLabelXColumn3
        '
        Me.DataGridViewLabelXColumn3.HeaderText = "Batch No"
        Me.DataGridViewLabelXColumn3.Name = "DataGridViewLabelXColumn3"
        Me.DataGridViewLabelXColumn3.ReadOnly = True
        Me.DataGridViewLabelXColumn3.Width = 130
        '
        'DataGridViewLabelXColumn4
        '
        Me.DataGridViewLabelXColumn4.HeaderText = "Date"
        Me.DataGridViewLabelXColumn4.Name = "DataGridViewLabelXColumn4"
        Me.DataGridViewLabelXColumn4.ReadOnly = True
        Me.DataGridViewLabelXColumn4.Width = 130
        '
        'DataGridViewLabelXColumn5
        '
        Me.DataGridViewLabelXColumn5.HeaderText = "Approved"
        Me.DataGridViewLabelXColumn5.Name = "DataGridViewLabelXColumn5"
        Me.DataGridViewLabelXColumn5.ReadOnly = True
        Me.DataGridViewLabelXColumn5.Width = 130
        '
        'DataGridViewLabelXColumn7
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewLabelXColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewLabelXColumn7.HeaderText = "Total Amount"
        Me.DataGridViewLabelXColumn7.Name = "DataGridViewLabelXColumn7"
        Me.DataGridViewLabelXColumn7.ReadOnly = True
        Me.DataGridViewLabelXColumn7.Width = 150
        '
        'dtpPurchase
        '
        Me.dtpPurchase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpPurchase.CustomFormat = "dd MMM yyyy"
        Me.dtpPurchase.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpPurchase.ForeColor = System.Drawing.Color.Black
        Me.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPurchase.Location = New System.Drawing.Point(683, 18)
        Me.dtpPurchase.Name = "dtpPurchase"
        Me.dtpPurchase.Size = New System.Drawing.Size(225, 27)
        Me.dtpPurchase.TabIndex = 293
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(19, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtSearch.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtSearch.Size = New System.Drawing.Size(261, 28)
        Me.txtSearch.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateActive.Content.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.StateActive.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtSearch.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearch.StateCommon.Border.Rounding = 1
        Me.txtSearch.StateCommon.Border.Width = 1
        Me.txtSearch.StateCommon.Content.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSearch.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.txtSearch.TabIndex = 292
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.btnSearch.UniqueName = ""
        '
        'lblPurchase
        '
        Me.lblPurchase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPurchase.ForeColor = System.Drawing.Color.Black
        Me.lblPurchase.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblPurchase.Location = New System.Drawing.Point(563, 21)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(114, 24)
        Me.lblPurchase.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurchase.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.lblPurchase.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblPurchase.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblPurchase.TabIndex = 279
        Me.lblPurchase.TabStop = False
        Me.lblPurchase.Values.Text = "Purcahse Date :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "Product Details"
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
        'FrmPurchaseList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panProduct)
        Me.DoubleBuffered = True
        Me.Name = "FrmPurchaseList"
        Me.Text = "Purchase Products"
        Me.panProduct.ResumeLayout(False)
        Me.panProduct.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panProduct As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dtpPurchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewLabelXColumn6 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn8 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn10 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn9 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn12 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn13 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn1 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn2 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn3 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn4 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn5 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn7 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Private WithEvents lblPurchase As ComponentFactory.Krypton.Toolkit.KryptonLabel
End Class
