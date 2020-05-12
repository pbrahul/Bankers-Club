<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDefectiveList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDefectiveList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panProducts = New DevComponents.DotNetBar.PanelEx()
        Me.lblReturn = New DevComponents.DotNetBar.LabelX()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.dgvPurchase = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.panProducts.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panProducts
        '
        Me.panProducts.CanvasColor = System.Drawing.SystemColors.Control
        Me.panProducts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panProducts.Controls.Add(Me.dtpReturn)
        Me.panProducts.Controls.Add(Me.lblReturn)
        Me.panProducts.Controls.Add(Me.txtSearch)
        Me.panProducts.Controls.Add(Me.dgvProduct)
        Me.panProducts.Controls.Add(Me.Pic)
        Me.panProducts.Controls.Add(Me.dgvPurchase)
        Me.panProducts.Controls.Add(Me.Label1)
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
        'lblReturn
        '
        Me.lblReturn.AutoSize = True
        '
        '
        '
        Me.lblReturn.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblReturn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblReturn.ForeColor = System.Drawing.Color.Black
        Me.lblReturn.Location = New System.Drawing.Point(655, 23)
        Me.lblReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.lblReturn.Name = "lblReturn"
        Me.lblReturn.Size = New System.Drawing.Size(40, 22)
        Me.lblReturn.TabIndex = 292
        Me.lblReturn.Text = "Date :"
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProduct.EnableHeadersVisualStyles = False
        Me.dgvProduct.Location = New System.Drawing.Point(27, 308)
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
        Me.dgvProduct.Size = New System.Drawing.Size(879, 213)
        Me.dgvProduct.TabIndex = 280
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPurchase.ColumnHeadersHeight = 32
        Me.dgvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPurchase.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPurchase.EnableHeadersVisualStyles = False
        Me.dgvPurchase.Location = New System.Drawing.Point(19, 58)
        Me.dgvPurchase.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPurchase.MultiSelect = False
        Me.dgvPurchase.Name = "dgvPurchase"
        Me.dgvPurchase.ReadOnly = True
        Me.dgvPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvPurchase.RowHeadersVisible = False
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvPurchase.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPurchase.RowTemplate.Height = 27
        Me.dgvPurchase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPurchase.ShowEditingIcon = False
        Me.dgvPurchase.Size = New System.Drawing.Size(889, 221)
        Me.dgvPurchase.TabIndex = 279
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 275
        Me.Label1.Text = "Return Product"
        '
        'dtpReturn
        '
        Me.dtpReturn.CustomFormat = "dd MMM yyyy"
        Me.dtpReturn.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReturn.Location = New System.Drawing.Point(702, 20)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(208, 27)
        Me.dtpReturn.TabIndex = 304
        '
        'FrmDefectiveList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panProducts)
        Me.DoubleBuffered = True
        Me.Name = "FrmDefectiveList"
        Me.Text = "Defective Products"
        Me.panProducts.ResumeLayout(False)
        Me.panProducts.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panProducts As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblReturn As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents dgvPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpReturn As System.Windows.Forms.DateTimePicker
End Class
