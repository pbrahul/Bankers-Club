<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplierPaymentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplierPaymentDetails))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPayment = New System.Windows.Forms.DataGridView()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.grpSupPayment = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.lblTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblTitle = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.colTransID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDate = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colSupID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colType = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colBank = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colCheque = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPaid = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPurID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDiscount = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSupPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPayment
        '
        Me.dgvPayment.AllowUserToAddRows = False
        Me.dgvPayment.AllowUserToDeleteRows = False
        Me.dgvPayment.AllowUserToResizeColumns = False
        Me.dgvPayment.AllowUserToResizeRows = False
        Me.dgvPayment.BackgroundColor = System.Drawing.Color.White
        Me.dgvPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPayment.CausesValidation = False
        Me.dgvPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPayment.ColumnHeadersHeight = 32
        Me.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTransID, Me.colDate, Me.colSupID, Me.colName, Me.colType, Me.colBank, Me.colCheque, Me.colPaid, Me.colPurID, Me.colDiscount})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPayment.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPayment.EnableHeadersVisualStyles = False
        Me.dgvPayment.Location = New System.Drawing.Point(17, 44)
        Me.dgvPayment.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvPayment.MultiSelect = False
        Me.dgvPayment.Name = "dgvPayment"
        Me.dgvPayment.ReadOnly = True
        Me.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvPayment.RowHeadersVisible = False
        Me.dgvPayment.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvPayment.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvPayment.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPayment.RowTemplate.Height = 27
        Me.dgvPayment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPayment.ShowEditingIcon = False
        Me.dgvPayment.Size = New System.Drawing.Size(880, 466)
        Me.dgvPayment.TabIndex = 281
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(671, 9)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(225, 27)
        Me.dtpDate.TabIndex = 295
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.lblDate.Location = New System.Drawing.Point(613, 12)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(50, 24)
        Me.lblDate.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.lblDate.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblDate.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblDate.TabIndex = 294
        Me.lblDate.TabStop = False
        Me.lblDate.Values.Text = "Date :"
        '
        'grpSupPayment
        '
        Me.grpSupPayment.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.grpSupPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpSupPayment.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpSupPayment.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.grpSupPayment.Controls.Add(Me.dgvPayment)
        Me.grpSupPayment.Controls.Add(Me.lblDate)
        Me.grpSupPayment.Controls.Add(Me.dtpDate)
        Me.grpSupPayment.Controls.Add(Me.txtSearch)
        Me.grpSupPayment.Controls.Add(Me.lblTotal)
        Me.grpSupPayment.Controls.Add(Me.lblTitle)
        Me.grpSupPayment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSupPayment.Location = New System.Drawing.Point(15, 12)
        Me.grpSupPayment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpSupPayment.Name = "grpSupPayment"
        Me.grpSupPayment.Size = New System.Drawing.Size(920, 529)
        '
        '
        '
        Me.grpSupPayment.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grpSupPayment.Style.BackColorGradientAngle = 90
        Me.grpSupPayment.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grpSupPayment.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSupPayment.Style.BorderBottomWidth = 1
        Me.grpSupPayment.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grpSupPayment.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSupPayment.Style.BorderLeftWidth = 1
        Me.grpSupPayment.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSupPayment.Style.BorderRightWidth = 1
        Me.grpSupPayment.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpSupPayment.Style.BorderTopWidth = 1
        Me.grpSupPayment.Style.CornerDiameter = 4
        Me.grpSupPayment.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grpSupPayment.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grpSupPayment.Style.TextColor = System.Drawing.Color.Black
        '
        '
        '
        Me.grpSupPayment.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpSupPayment.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpSupPayment.TabIndex = 283
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(17, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtSearch.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtSearch.Size = New System.Drawing.Size(227, 28)
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
        Me.txtSearch.TabIndex = 297
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.btnSearch.UniqueName = ""
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = False
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblTotal.Location = New System.Drawing.Point(1024, 769)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(179, 38)
        Me.lblTotal.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblTotal.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.lblTotal.TabIndex = 295
        Me.lblTotal.Values.Text = "0"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblTitle.Location = New System.Drawing.Point(877, 769)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(97, 24)
        Me.lblTitle.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblTitle.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblTitle.TabIndex = 294
        Me.lblTitle.Values.Text = "Grand Total :"
        '
        'colTransID
        '
        Me.colTransID.HeaderText = "ID"
        Me.colTransID.Name = "colTransID"
        Me.colTransID.ReadOnly = True
        '
        'colDate
        '
        Me.colDate.HeaderText = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.ReadOnly = True
        Me.colDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colSupID
        '
        Me.colSupID.HeaderText = "Supplier ID"
        Me.colSupID.Name = "colSupID"
        Me.colSupID.ReadOnly = True
        Me.colSupID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colSupID.Width = 120
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colName.HeaderText = "Supplier Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colType
        '
        Me.colType.HeaderText = "Payment Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 120
        '
        'colBank
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colBank.DefaultCellStyle = DataGridViewCellStyle3
        Me.colBank.HeaderText = "Bank Details"
        Me.colBank.Name = "colBank"
        Me.colBank.ReadOnly = True
        Me.colBank.Width = 160
        '
        'colCheque
        '
        Me.colCheque.HeaderText = "Cheque No"
        Me.colCheque.Name = "colCheque"
        Me.colCheque.ReadOnly = True
        Me.colCheque.Width = 120
        '
        'colPaid
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPaid.DefaultCellStyle = DataGridViewCellStyle4
        Me.colPaid.HeaderText = "Paid Amount"
        Me.colPaid.Name = "colPaid"
        Me.colPaid.ReadOnly = True
        Me.colPaid.Width = 120
        '
        'colPurID
        '
        Me.colPurID.HeaderText = "Purchase ID"
        Me.colPurID.Name = "colPurID"
        Me.colPurID.ReadOnly = True
        Me.colPurID.Visible = False
        '
        'colDiscount
        '
        Me.colDiscount.HeaderText = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.ReadOnly = True
        Me.colDiscount.Visible = False
        '
        'FrmSupplierPaymentDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.grpSupPayment)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSupplierPaymentDetails"
        Me.Text = "Supplier Payment"
        CType(Me.dgvPayment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSupPayment.ResumeLayout(False)
        Me.grpSupPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPayment As System.Windows.Forms.DataGridView
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Private WithEvents lblDate As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents grpSupPayment As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents lblTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblTitle As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents colTransID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDate As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colSupID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colType As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colBank As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colCheque As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPaid As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPurID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDiscount As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
