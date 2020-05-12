<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCollectionType
    Inherits DevComponents.DotNetBar.Metro.MetroAppForm

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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCollectionType))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colEmail = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.panExistTitle = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panExistTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.AllowUserToResizeRows = False
        Me.dgvCustomers.BackgroundColor = System.Drawing.Color.White
        Me.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCustomers.CausesValidation = False
        Me.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCustomers.ColumnHeadersHeight = 32
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCustomers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colEmail, Me.colName, Me.col, Me.colDiscount})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCustomers.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvCustomers.EnableHeadersVisualStyles = False
        Me.dgvCustomers.Location = New System.Drawing.Point(37, 57)
        Me.dgvCustomers.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvCustomers.RowHeadersVisible = False
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("SolaimanLipi", 11.0!)
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvCustomers.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvCustomers.RowTemplate.Height = 30
        Me.dgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvCustomers.ShowEditingIcon = False
        Me.dgvCustomers.Size = New System.Drawing.Size(416, 282)
        Me.dgvCustomers.TabIndex = 266
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colID.Visible = False
        '
        'colEmail
        '
        Me.colEmail.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.colEmail.HeaderText = ""
        Me.colEmail.Image = CType(resources.GetObject("colEmail.Image"), System.Drawing.Image)
        Me.colEmail.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.colEmail.Name = "colEmail"
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEmail.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.colEmail.Text = Nothing
        Me.colEmail.ToolTipText = "Save"
        Me.colEmail.Width = 40
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle6
        Me.colName.HeaderText = "Type of Collection"
        Me.colName.Name = "colName"
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'col
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.col.DefaultCellStyle = DataGridViewCellStyle7
        Me.col.HeaderText = "Amount"
        Me.col.Name = "col"
        '
        'colDiscount
        '
        Me.colDiscount.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.colDiscount.HeaderText = ""
        Me.colDiscount.Image = CType(resources.GetObject("colDiscount.Image"), System.Drawing.Image)
        Me.colDiscount.ImageFixedSize = New System.Drawing.Size(25, 25)
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDiscount.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.colDiscount.Text = Nothing
        Me.colDiscount.ToolTipText = "Update"
        Me.colDiscount.Width = 40
        '
        'panExistTitle
        '
        Me.panExistTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.panExistTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panExistTitle.Controls.Add(Me.Label1)
        Me.panExistTitle.Location = New System.Drawing.Point(29, 20)
        Me.panExistTitle.Name = "panExistTitle"
        Me.panExistTitle.Size = New System.Drawing.Size(438, 31)
        Me.panExistTitle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panExistTitle.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panExistTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panExistTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panExistTitle.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panExistTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panExistTitle.Style.GradientAngle = 90
        Me.panExistTitle.TabIndex = 301
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 25)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Type of Collection"
        '
        'btnClose
        '
        Me.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FocusCuesEnabled = False
        Me.btnClose.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnClose.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnClose.Location = New System.Drawing.Point(217, 345)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnClose.Size = New System.Drawing.Size(80, 30)
        Me.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnClose.Symbol = ""
        Me.btnClose.TabIndex = 302
        Me.btnClose.Text = "Close"
        '
        'FrmCollectionType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderColor = New DevComponents.DotNetBar.Metro.BorderColors(System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer)))
        Me.BorderThickness = New DevComponents.DotNetBar.Metro.Thickness(1.0R, 1.0R, 1.0R, 1.0R)
        Me.ClientSize = New System.Drawing.Size(494, 398)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.panExistTitle)
        Me.Controls.Add(Me.dgvCustomers)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCollectionType"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Prescription Rules"
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panExistTitle.ResumeLayout(False)
        Me.panExistTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents dgvCustomers As System.Windows.Forms.DataGridView
    Friend WithEvents panExistTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As DevComponents.DotNetBar.ButtonX
    Friend WithEvents colID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colEmail As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
End Class
