<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaymentList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaymentList))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.grpSales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblTitle = New DevComponents.DotNetBar.LabelX()
        Me.lblTotal = New DevComponents.DotNetBar.LabelX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colEmail = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colAddress = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colType = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDetails = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colRemarks = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colContact = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(18, 6)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtSearch.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtSearch.Size = New System.Drawing.Size(247, 28)
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCustomers.ColumnHeadersHeight = 32
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colEmail, Me.colName, Me.colAddress, Me.colType, Me.colDetails, Me.colRemarks, Me.colContact})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCustomers.EnableHeadersVisualStyles = False
        Me.dgvCustomers.Location = New System.Drawing.Point(18, 40)
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
        Me.dgvCustomers.Size = New System.Drawing.Size(886, 452)
        Me.dgvCustomers.TabIndex = 265
        '
        'grpSales
        '
        Me.grpSales.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpSales.CanvasColor = System.Drawing.Color.WhiteSmoke
        Me.grpSales.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.grpSales.Controls.Add(Me.lblTitle)
        Me.grpSales.Controls.Add(Me.lblTotal)
        Me.grpSales.Controls.Add(Me.dtpDate)
        Me.grpSales.Controls.Add(Me.lblType)
        Me.grpSales.Controls.Add(Me.txtSearch)
        Me.grpSales.Controls.Add(Me.dgvCustomers)
        Me.grpSales.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpSales.Location = New System.Drawing.Point(18, 15)
        Me.grpSales.Margin = New System.Windows.Forms.Padding(4)
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
        Me.grpSales.TabIndex = 285
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblTitle.Location = New System.Drawing.Point(703, 496)
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
        Me.lblTotal.Location = New System.Drawing.Point(789, 496)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(113, 23)
        Me.lblTotal.TabIndex = 294
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.White
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(681, 7)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(223, 27)
        Me.dtpDate.TabIndex = 292
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.White
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblType.Location = New System.Drawing.Point(625, 8)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(50, 24)
        Me.lblType.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblType.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblType.TabIndex = 291
        Me.lblType.Values.Text = "Date :"
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colID.Visible = False
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Payment Date"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEmail.Width = 140
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle7
        Me.colName.HeaderText = "Payment From"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle8
        Me.colAddress.HeaderText = "Payment To"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colType
        '
        Me.colType.HeaderText = "Payment Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 120
        '
        'colDetails
        '
        Me.colDetails.HeaderText = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.ReadOnly = True
        Me.colDetails.Width = 150
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Remarks"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        Me.colRemarks.Visible = False
        '
        'colContact
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colContact.DefaultCellStyle = DataGridViewCellStyle9
        Me.colContact.HeaderText = "Amount"
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        Me.colContact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colContact.Width = 120
        '
        'FrmPaymentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.grpSales)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPaymentList"
        Me.Text = "Payment"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents grpSales As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lblType As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents colID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colEmail As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colAddress As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colType As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDetails As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colRemarks As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colContact As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
