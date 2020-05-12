<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDefective
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDefective))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpurchase = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.lstSearch = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Measurement = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.labelName = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonTextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.dataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(716, 43)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.ForeColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(8, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 206
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 16)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Return Stock Proudcts"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(55, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 22)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "Defective Products"
        '
        'dtpurchase
        '
        Me.dtpurchase.AlwaysActive = False
        Me.dtpurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dtpurchase.CalendarDayOfWeekStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone
        Me.dtpurchase.CalendarDayStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery
        Me.dtpurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpurchase.CustomFormat = "dd MMM yyyy"
        Me.dtpurchase.ForeColor = System.Drawing.Color.Black
        Me.dtpurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpurchase.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.dtpurchase.Location = New System.Drawing.Point(108, 3)
        Me.dtpurchase.Name = "dtpurchase"
        Me.dtpurchase.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.dtpurchase.Size = New System.Drawing.Size(179, 23)
        Me.dtpurchase.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtpurchase.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dtpurchase.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.dtpurchase.StateCommon.Border.Rounding = 4
        Me.dtpurchase.StateCommon.Border.Width = 1
        Me.dtpurchase.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpurchase.StateNormal.Content.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpurchase.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(537, 445)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 30)
        Me.Panel3.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(76, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnCancel.Size = New System.Drawing.Size(76, 30)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnSave.Size = New System.Drawing.Size(76, 30)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.lstSearch)
        Me.PanelEx3.Controls.Add(Me.dataGridViewX2)
        Me.PanelEx3.Controls.Add(Me.tableLayoutPanel1)
        Me.PanelEx3.Controls.Add(Me.Label4)
        Me.PanelEx3.Controls.Add(Me.Label3)
        Me.PanelEx3.Location = New System.Drawing.Point(8, 49)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(696, 384)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 1
        '
        'lstSearch
        '
        Me.lstSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lstSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstSearch.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSearch.ForeColor = System.Drawing.Color.Black
        Me.lstSearch.FullRowSelect = True
        Me.lstSearch.GridLines = True
        Me.lstSearch.Location = New System.Drawing.Point(124, 136)
        Me.lstSearch.MultiSelect = False
        Me.lstSearch.Name = "lstSearch"
        Me.lstSearch.Size = New System.Drawing.Size(324, 164)
        Me.lstSearch.TabIndex = 1
        Me.lstSearch.UseCompatibleStateImageBehavior = False
        Me.lstSearch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Barcode"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 140
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Price"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 80
        '
        'dataGridViewX2
        '
        Me.dataGridViewX2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dataGridViewX2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dataGridViewX2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.ItemName, Me.Qty, Me.Measurement, Me.Remarks, Me.ItemPrice, Me.TotalPrice})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridViewX2.DefaultCellStyle = DataGridViewCellStyle8
        Me.dataGridViewX2.EnableHeadersVisualStyles = False
        Me.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.dataGridViewX2.Location = New System.Drawing.Point(16, 73)
        Me.dataGridViewX2.MultiSelect = False
        Me.dataGridViewX2.Name = "dataGridViewX2"
        Me.dataGridViewX2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGridViewX2.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dataGridViewX2.RowHeadersWidth = 20
        Me.dataGridViewX2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dataGridViewX2.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dataGridViewX2.RowTemplate.Height = 24
        Me.dataGridViewX2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dataGridViewX2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dataGridViewX2.Size = New System.Drawing.Size(670, 278)
        Me.dataGridViewX2.TabIndex = 2
        '
        'ItemID
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ItemID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ItemID.HeaderText = "Barcode"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Width = 80
        '
        'ItemName
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ItemName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        Me.ItemName.Width = 136
        '
        'Qty
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Qty.DefaultCellStyle = DataGridViewCellStyle4
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.Width = 60
        '
        'Measurement
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Measurement.DefaultCellStyle = DataGridViewCellStyle5
        Me.Measurement.HeaderText = "Measurement"
        Me.Measurement.Name = "Measurement"
        Me.Measurement.ReadOnly = True
        Me.Measurement.Width = 85
        '
        'Remarks
        '
        Me.Remarks.HeaderText = "Remarks"
        Me.Remarks.Name = "Remarks"
        '
        'ItemPrice
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ItemPrice.DefaultCellStyle = DataGridViewCellStyle6
        Me.ItemPrice.HeaderText = "Item Price"
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Width = 80
        '
        'TotalPrice
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TotalPrice.DefaultCellStyle = DataGridViewCellStyle7
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 90
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 5
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.labelName, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.KryptonLabel2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.dtpurchase, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.KryptonTextBox1, 1, 1)
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(16, 8)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 8
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(668, 67)
        Me.tableLayoutPanel1.TabIndex = 20
        '
        'labelName
        '
        Me.labelName.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.labelName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelName.ForeColor = System.Drawing.Color.Black
        Me.labelName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.labelName.Location = New System.Drawing.Point(3, 3)
        Me.labelName.Name = "labelName"
        Me.labelName.Size = New System.Drawing.Size(99, 23)
        Me.labelName.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelName.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.labelName.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.labelName.TabIndex = 0
        Me.labelName.TabStop = False
        Me.labelName.Values.Text = "Defective Date :"
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KryptonLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel2.ForeColor = System.Drawing.Color.Black
        Me.KryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalPanel
        Me.KryptonLabel2.Location = New System.Drawing.Point(3, 32)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Size = New System.Drawing.Size(99, 18)
        Me.KryptonLabel2.StateCommon.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel2.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.KryptonLabel2.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel2.TabIndex = 18
        Me.KryptonLabel2.TabStop = False
        Me.KryptonLabel2.Values.Text = "Search Item :"
        '
        'KryptonTextBox1
        '
        Me.KryptonTextBox1.AlwaysActive = False
        Me.KryptonTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KryptonTextBox1.ForeColor = System.Drawing.Color.Black
        Me.KryptonTextBox1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.KryptonTextBox1.Location = New System.Drawing.Point(108, 32)
        Me.KryptonTextBox1.Name = "KryptonTextBox1"
        Me.KryptonTextBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.KryptonTextBox1.Size = New System.Drawing.Size(324, 22)
        Me.KryptonTextBox1.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KryptonTextBox1.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox1.StateActive.Content.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.KryptonTextBox1.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.KryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.KryptonTextBox1.StateCommon.Border.Rounding = 4
        Me.KryptonTextBox1.StateCommon.Border.Width = 1
        Me.KryptonTextBox1.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.KryptonTextBox1.StateNormal.Content.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.KryptonTextBox1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(559, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "0.00"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(458, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Total Amount :"
        '
        'FrmDefective
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 487)
        Me.Controls.Add(Me.PanelEx3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDefective"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Return"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        CType(Me.dataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtpurchase As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Private WithEvents dataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents KryptonTextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents lstSearch As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents labelName As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Private WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ItemID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Measurement As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
