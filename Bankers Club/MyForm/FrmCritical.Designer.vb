<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCritical
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCritical))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panProducts = New DevComponents.DotNetBar.PanelEx()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.colBarocde = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPrice = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colQty = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colUnits = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colReorder = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.panProducts.SuspendLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.panProducts.TabIndex = 283
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
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarocde, Me.colName, Me.colPrice, Me.colQty, Me.colUnits, Me.colReorder})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStock.DefaultCellStyle = DataGridViewCellStyle4
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
        'colBarocde
        '
        Me.colBarocde.HeaderText = "Barcode"
        Me.colBarocde.Name = "colBarocde"
        Me.colBarocde.ReadOnly = True
        Me.colBarocde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colBarocde.Width = 120
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
        'colPrice
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle3
        Me.colPrice.HeaderText = "Purchase Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 150
        '
        'colQty
        '
        Me.colQty.HeaderText = "Current Stock"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Width = 120
        '
        'colUnits
        '
        Me.colUnits.HeaderText = "Qty (Pcs)"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.ReadOnly = True
        Me.colUnits.Width = 120
        '
        'colReorder
        '
        Me.colReorder.HeaderText = "Reorder Label"
        Me.colReorder.Name = "colReorder"
        Me.colReorder.ReadOnly = True
        Me.colReorder.Width = 150
        '
        'FrmCritical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panProducts)
        Me.DoubleBuffered = True
        Me.Name = "FrmCritical"
        Me.Text = "Critical Products"
        Me.panProducts.ResumeLayout(False)
        Me.panProducts.PerformLayout()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panProducts As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents lblCategory As System.Windows.Forms.Label
    Friend WithEvents colBarocde As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPrice As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colQty As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colUnits As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colReorder As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
