<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAssetList
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAssetList))
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colEmail = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDetails = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colAddress = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colContact = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.lblTitle = New DevComponents.DotNetBar.LabelX()
        Me.lblTotal = New DevComponents.DotNetBar.LabelX()
        Me.panCustomers = New DevComponents.DotNetBar.PanelEx()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panCustomers.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCustomers.CausesValidation = False
        Me.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCustomers.ColumnHeadersHeight = 32
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colEmail, Me.colName, Me.colDetails, Me.colAddress, Me.colContact})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCustomers.EnableHeadersVisualStyles = False
        Me.dgvCustomers.Location = New System.Drawing.Point(19, 43)
        Me.dgvCustomers.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvCustomers.RowTemplate.Height = 27
        Me.dgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.ShowEditingIcon = False
        Me.dgvCustomers.Size = New System.Drawing.Size(886, 450)
        Me.dgvCustomers.TabIndex = 265
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colEmail.DefaultCellStyle = DataGridViewCellStyle2
        Me.colEmail.HeaderText = "Asset Name"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle3
        Me.colName.HeaderText = "Asset Details"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colDetails
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDetails.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDetails.HeaderText = "Purchase Value"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.ReadOnly = True
        Me.colDetails.Width = 140
        '
        'colAddress
        '
        Me.colAddress.HeaderText = "Depreciation"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAddress.Width = 140
        '
        'colContact
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colContact.DefaultCellStyle = DataGridViewCellStyle5
        Me.colContact.HeaderText = "Current Value"
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        Me.colContact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colContact.Width = 140
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblTitle.Location = New System.Drawing.Point(706, 494)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(95, 23)
        Me.lblTitle.TabIndex = 293
        Me.lblTitle.Text = "Grand Total :"
        Me.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(792, 494)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(113, 23)
        Me.lblTotal.TabIndex = 294
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'panCustomers
        '
        Me.panCustomers.CanvasColor = System.Drawing.SystemColors.Control
        Me.panCustomers.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panCustomers.Controls.Add(Me.lblTitle)
        Me.panCustomers.Controls.Add(Me.lblTotal)
        Me.panCustomers.Controls.Add(Me.dgvCustomers)
        Me.panCustomers.Controls.Add(Me.txtSearch)
        Me.panCustomers.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.panCustomers.Location = New System.Drawing.Point(12, 8)
        Me.panCustomers.Name = "panCustomers"
        Me.panCustomers.Size = New System.Drawing.Size(926, 537)
        Me.panCustomers.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panCustomers.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panCustomers.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panCustomers.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panCustomers.Style.GradientAngle = 90
        Me.panCustomers.TabIndex = 286
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(19, 7)
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
        'FrmAssetList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panCustomers)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAssetList"
        Me.Text = "Asset List"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panCustomers.ResumeLayout(False)
        Me.panCustomers.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents colID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colEmail As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDetails As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colAddress As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colContact As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents panCustomers As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
End Class
