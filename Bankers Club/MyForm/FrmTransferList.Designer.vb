<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransferList
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
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colEmail = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colAddress = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDetails = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colContact = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.grpSales = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblTitle = New DevComponents.DotNetBar.LabelX()
        Me.lblTotal = New DevComponents.DotNetBar.LabelX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSales.SuspendLayout()
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
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colEmail, Me.colName, Me.colAddress, Me.colDetails, Me.colContact})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle6
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
        Me.colEmail.HeaderText = "Date"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEmail.Width = 140
        '
        'colName
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colName.HeaderText = "From"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colName.Width = 200
        '
        'colAddress
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAddress.HeaderText = "To"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAddress.Width = 200
        '
        'colDetails
        '
        Me.colDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colDetails.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDetails.HeaderText = "Details"
        Me.colDetails.Name = "colDetails"
        Me.colDetails.ReadOnly = True
        '
        'colContact
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colContact.DefaultCellStyle = DataGridViewCellStyle5
        Me.colContact.HeaderText = "Amount"
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        Me.colContact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colContact.Width = 120
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
        'FrmTransferList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.grpSales)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTransferList"
        Me.Text = "Cash Transfer"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSales.ResumeLayout(False)
        Me.grpSales.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents colDetails As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colContact As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
