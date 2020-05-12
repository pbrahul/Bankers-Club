<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCollectionList
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
        Dim SuperTabColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabColorTable = New DevComponents.DotNetBar.Rendering.SuperTabColorTable()
        Dim SuperTabLinearGradientColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable = New DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SuperTabItemColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates2 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim SuperTabItemColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates1 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim SuperTabItemColorTable3 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates3 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable3 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCollectionList))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCollection = New System.Windows.Forms.DataGridView()
        Me.lblTitle = New DevComponents.DotNetBar.LabelX()
        Me.lblTotal = New DevComponents.DotNetBar.LabelX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblType = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.panProducts = New DevComponents.DotNetBar.PanelEx()
        Me.tabMain = New DevComponents.DotNetBar.SuperTabControl()
        Me.tbRecognize = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.txtSearchDonation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblDonation = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpDonation = New System.Windows.Forms.DateTimePicker()
        Me.dgvDonation = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLabelXColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn3 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn4 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn5 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn6 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn8 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.panExistTitle = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabExisting = New DevComponents.DotNetBar.SuperTabItem()
        Me.tbPatient = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panPatient = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabPatient = New DevComponents.DotNetBar.SuperTabItem()
        Me.tabIncome = New DevComponents.DotNetBar.SuperTabItem()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPrint = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.colEmail = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colAddress = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colType = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colDetails = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colRemarks = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colContact = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Column1 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        CType(Me.dgvCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panProducts.SuspendLayout()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.tbRecognize.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.dgvDonation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panExistTitle.SuspendLayout()
        Me.tbPatient.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.panPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCollection
        '
        Me.dgvCollection.AllowUserToAddRows = False
        Me.dgvCollection.AllowUserToDeleteRows = False
        Me.dgvCollection.AllowUserToResizeRows = False
        Me.dgvCollection.BackgroundColor = System.Drawing.Color.White
        Me.dgvCollection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCollection.CausesValidation = False
        Me.dgvCollection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvCollection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCollection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCollection.ColumnHeadersHeight = 32
        Me.dgvCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCollection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colPrint, Me.colEmail, Me.colName, Me.colAddress, Me.colType, Me.colDetails, Me.colRemarks, Me.colContact, Me.Column1})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCollection.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCollection.EnableHeadersVisualStyles = False
        Me.dgvCollection.Location = New System.Drawing.Point(23, 85)
        Me.dgvCollection.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvCollection.MultiSelect = False
        Me.dgvCollection.Name = "dgvCollection"
        Me.dgvCollection.ReadOnly = True
        Me.dgvCollection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvCollection.RowHeadersVisible = False
        Me.dgvCollection.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvCollection.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvCollection.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvCollection.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvCollection.RowTemplate.Height = 27
        Me.dgvCollection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCollection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCollection.ShowEditingIcon = False
        Me.dgvCollection.Size = New System.Drawing.Size(678, 408)
        Me.dgvCollection.TabIndex = 265
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblTitle.Location = New System.Drawing.Point(482, 500)
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
        Me.lblTotal.Location = New System.Drawing.Point(583, 500)
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
        Me.dtpDate.Location = New System.Drawing.Point(481, 51)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(223, 27)
        Me.dtpDate.TabIndex = 292
        '
        'lblType
        '
        Me.lblType.BackColor = System.Drawing.Color.White
        Me.lblType.ForeColor = System.Drawing.Color.Black
        Me.lblType.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblType.Location = New System.Drawing.Point(425, 52)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(50, 24)
        Me.lblType.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblType.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblType.TabIndex = 291
        Me.lblType.Values.Text = "Date :"
        '
        'panProducts
        '
        Me.panProducts.CanvasColor = System.Drawing.SystemColors.Control
        Me.panProducts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panProducts.Controls.Add(Me.tabMain)
        Me.panProducts.Location = New System.Drawing.Point(16, 8)
        Me.panProducts.Name = "panProducts"
        Me.panProducts.Size = New System.Drawing.Size(919, 537)
        Me.panProducts.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panProducts.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panProducts.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panProducts.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.panProducts.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panProducts.Style.GradientAngle = 90
        Me.panProducts.TabIndex = 287
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        '
        '
        '
        Me.tabMain.ControlBox.CloseBox.Name = ""
        Me.tabMain.ControlBox.CloseBox.Visible = True
        '
        '
        '
        Me.tabMain.ControlBox.MenuBox.Name = ""
        Me.tabMain.ControlBox.Name = ""
        Me.tabMain.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabMain.ControlBox.MenuBox, Me.tabMain.ControlBox.CloseBox})
        Me.tabMain.ControlBox.Visible = False
        Me.tabMain.Controls.Add(Me.tbPatient)
        Me.tabMain.Controls.Add(Me.tbRecognize)
        Me.tabMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.FixedTabSize = New System.Drawing.Size(200, 0)
        Me.tabMain.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.tabMain.ForeColor = System.Drawing.Color.Black
        Me.tabMain.Location = New System.Drawing.Point(0, 0)
        Me.tabMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.ReorderTabsEnabled = True
        Me.tabMain.SelectedTabFont = New System.Drawing.Font("Yu Gothic UI Light", 14.0!, System.Drawing.FontStyle.Bold)
        Me.tabMain.SelectedTabIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(919, 537)
        Me.tabMain.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
        Me.tabMain.TabFont = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.tabMain.TabIndex = 4
        Me.tabMain.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabPatient, Me.tabExisting})
        SuperTabLinearGradientColorTable1.Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))}
        SuperTabColorTable1.Background = SuperTabLinearGradientColorTable1
        Me.tabMain.TabStripColor = SuperTabColorTable1
        Me.tabMain.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.tabMain.TabVerticalSpacing = 10
        Me.tabMain.Text = "superTabControl2"
        Me.tabMain.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
        '
        'tbRecognize
        '
        Me.tbRecognize.BackgroundImage = CType(resources.GetObject("tbRecognize.BackgroundImage"), System.Drawing.Image)
        Me.tbRecognize.Controls.Add(Me.PanelEx1)
        Me.tbRecognize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbRecognize.Location = New System.Drawing.Point(202, 0)
        Me.tbRecognize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbRecognize.Name = "tbRecognize"
        Me.tbRecognize.Size = New System.Drawing.Size(717, 537)
        Me.tbRecognize.TabIndex = 2
        Me.tbRecognize.TabItem = Me.tabExisting
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.txtSearchDonation)
        Me.PanelEx1.Controls.Add(Me.lblDonation)
        Me.PanelEx1.Controls.Add(Me.dtpDonation)
        Me.PanelEx1.Controls.Add(Me.dgvDonation)
        Me.PanelEx1.Controls.Add(Me.panExistTitle)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(717, 537)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'txtSearchDonation
        '
        Me.txtSearchDonation.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtSearchDonation.Border.Class = "RibbonGalleryContainer"
        Me.txtSearchDonation.Border.CornerDiameter = 4
        Me.txtSearchDonation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearchDonation.Border.PaddingBottom = 4
        Me.txtSearchDonation.Border.PaddingLeft = 4
        Me.txtSearchDonation.Border.PaddingTop = 4
        Me.txtSearchDonation.ButtonCustom.Image = CType(resources.GetObject("txtSearchDonation.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtSearchDonation.ButtonCustom.Visible = True
        Me.txtSearchDonation.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchDonation.ForeColor = System.Drawing.Color.Black
        Me.txtSearchDonation.Location = New System.Drawing.Point(23, 49)
        Me.txtSearchDonation.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtSearchDonation.Name = "txtSearchDonation"
        Me.txtSearchDonation.Size = New System.Drawing.Size(250, 31)
        Me.txtSearchDonation.TabIndex = 318
        Me.txtSearchDonation.WatermarkText = "Search Here"
        '
        'lblDonation
        '
        Me.lblDonation.BackColor = System.Drawing.Color.White
        Me.lblDonation.ForeColor = System.Drawing.Color.Black
        Me.lblDonation.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblDonation.Location = New System.Drawing.Point(422, 52)
        Me.lblDonation.Name = "lblDonation"
        Me.lblDonation.Size = New System.Drawing.Size(50, 24)
        Me.lblDonation.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonation.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDonation.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblDonation.StateNormal.ShortText.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblDonation.TabIndex = 301
        Me.lblDonation.Values.Text = "Date :"
        '
        'dtpDonation
        '
        Me.dtpDonation.BackColor = System.Drawing.Color.White
        Me.dtpDonation.CustomFormat = "dd MMM yyyy"
        Me.dtpDonation.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDonation.ForeColor = System.Drawing.Color.Black
        Me.dtpDonation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDonation.Location = New System.Drawing.Point(478, 50)
        Me.dtpDonation.Name = "dtpDonation"
        Me.dtpDonation.Size = New System.Drawing.Size(223, 27)
        Me.dtpDonation.TabIndex = 302
        '
        'dgvDonation
        '
        Me.dgvDonation.AllowUserToAddRows = False
        Me.dgvDonation.AllowUserToDeleteRows = False
        Me.dgvDonation.AllowUserToResizeRows = False
        Me.dgvDonation.BackgroundColor = System.Drawing.Color.White
        Me.dgvDonation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDonation.CausesValidation = False
        Me.dgvDonation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvDonation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDonation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDonation.ColumnHeadersHeight = 32
        Me.dgvDonation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDonation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLabelXColumn1, Me.DataGridViewLabelXColumn2, Me.DataGridViewLabelXColumn3, Me.DataGridViewLabelXColumn4, Me.DataGridViewLabelXColumn5, Me.DataGridViewLabelXColumn6, Me.DataGridViewLabelXColumn8})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDonation.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvDonation.EnableHeadersVisualStyles = False
        Me.dgvDonation.Location = New System.Drawing.Point(23, 85)
        Me.dgvDonation.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvDonation.MultiSelect = False
        Me.dgvDonation.Name = "dgvDonation"
        Me.dgvDonation.ReadOnly = True
        Me.dgvDonation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvDonation.RowHeadersVisible = False
        Me.dgvDonation.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvDonation.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvDonation.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvDonation.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvDonation.RowTemplate.Height = 27
        Me.dgvDonation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDonation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDonation.ShowEditingIcon = False
        Me.dgvDonation.Size = New System.Drawing.Size(678, 430)
        Me.dgvDonation.TabIndex = 299
        '
        'DataGridViewLabelXColumn1
        '
        Me.DataGridViewLabelXColumn1.HeaderText = "ID"
        Me.DataGridViewLabelXColumn1.Name = "DataGridViewLabelXColumn1"
        Me.DataGridViewLabelXColumn1.ReadOnly = True
        Me.DataGridViewLabelXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn1.Visible = False
        '
        'DataGridViewLabelXColumn2
        '
        Me.DataGridViewLabelXColumn2.HeaderText = "Receive Date"
        Me.DataGridViewLabelXColumn2.Name = "DataGridViewLabelXColumn2"
        Me.DataGridViewLabelXColumn2.ReadOnly = True
        Me.DataGridViewLabelXColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLabelXColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn2.Width = 120
        '
        'DataGridViewLabelXColumn3
        '
        Me.DataGridViewLabelXColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewLabelXColumn3.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewLabelXColumn3.HeaderText = "Receive From"
        Me.DataGridViewLabelXColumn3.Name = "DataGridViewLabelXColumn3"
        Me.DataGridViewLabelXColumn3.ReadOnly = True
        Me.DataGridViewLabelXColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLabelXColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewLabelXColumn4
        '
        Me.DataGridViewLabelXColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewLabelXColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewLabelXColumn4.HeaderText = "Receive To"
        Me.DataGridViewLabelXColumn4.Name = "DataGridViewLabelXColumn4"
        Me.DataGridViewLabelXColumn4.ReadOnly = True
        Me.DataGridViewLabelXColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewLabelXColumn5
        '
        Me.DataGridViewLabelXColumn5.HeaderText = "Payment Type"
        Me.DataGridViewLabelXColumn5.Name = "DataGridViewLabelXColumn5"
        Me.DataGridViewLabelXColumn5.ReadOnly = True
        Me.DataGridViewLabelXColumn5.Width = 120
        '
        'DataGridViewLabelXColumn6
        '
        Me.DataGridViewLabelXColumn6.HeaderText = "Payment Details"
        Me.DataGridViewLabelXColumn6.Name = "DataGridViewLabelXColumn6"
        Me.DataGridViewLabelXColumn6.ReadOnly = True
        Me.DataGridViewLabelXColumn6.Width = 150
        '
        'DataGridViewLabelXColumn8
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewLabelXColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewLabelXColumn8.HeaderText = "Amount"
        Me.DataGridViewLabelXColumn8.Name = "DataGridViewLabelXColumn8"
        Me.DataGridViewLabelXColumn8.ReadOnly = True
        Me.DataGridViewLabelXColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLabelXColumn8.Width = 120
        '
        'panExistTitle
        '
        Me.panExistTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.panExistTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panExistTitle.Controls.Add(Me.Label3)
        Me.panExistTitle.Location = New System.Drawing.Point(17, 4)
        Me.panExistTitle.Name = "panExistTitle"
        Me.panExistTitle.Size = New System.Drawing.Size(687, 39)
        Me.panExistTitle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panExistTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panExistTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panExistTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panExistTitle.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panExistTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panExistTitle.Style.GradientAngle = 90
        Me.panExistTitle.TabIndex = 298
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 297
        Me.Label3.Text = "Others Income"
        '
        'tabExisting
        '
        Me.tabExisting.AttachedControl = Me.tbRecognize
        Me.tabExisting.GlobalItem = False
        Me.tabExisting.Image = CType(resources.GetObject("tabExisting.Image"), System.Drawing.Image)
        Me.tabExisting.ImageAlignment = DevComponents.DotNetBar.ImageAlignment.TopCenter
        Me.tabExisting.Name = "tabExisting"
        SuperTabItemStateColorTable2.Text = System.Drawing.Color.Black
        SuperTabColorStates2.Normal = SuperTabItemStateColorTable2
        SuperTabItemColorTable2.Default = SuperTabColorStates2
        Me.tabExisting.TabColor = SuperTabItemColorTable2
        Me.tabExisting.Text = "Other Income"
        '
        'tbPatient
        '
        Me.tbPatient.BackgroundImage = CType(resources.GetObject("tbPatient.BackgroundImage"), System.Drawing.Image)
        Me.tbPatient.Controls.Add(Me.PanelEx2)
        Me.tbPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbPatient.Location = New System.Drawing.Point(202, 0)
        Me.tbPatient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPatient.Name = "tbPatient"
        Me.tbPatient.Size = New System.Drawing.Size(717, 537)
        Me.tbPatient.TabIndex = 4
        Me.tbPatient.TabItem = Me.tabPatient
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtSearch)
        Me.PanelEx2.Controls.Add(Me.lblTitle)
        Me.PanelEx2.Controls.Add(Me.lblTotal)
        Me.PanelEx2.Controls.Add(Me.lblType)
        Me.PanelEx2.Controls.Add(Me.panPatient)
        Me.PanelEx2.Controls.Add(Me.dtpDate)
        Me.PanelEx2.Controls.Add(Me.dgvCollection)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(717, 537)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 300
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtSearch.Border.Class = "RibbonGalleryContainer"
        Me.txtSearch.Border.CornerDiameter = 4
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.Border.PaddingBottom = 4
        Me.txtSearch.Border.PaddingLeft = 4
        Me.txtSearch.Border.PaddingTop = 4
        Me.txtSearch.ButtonCustom.Image = CType(resources.GetObject("txtSearch.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtSearch.ButtonCustom.Visible = True
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(23, 49)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(250, 31)
        Me.txtSearch.TabIndex = 317
        Me.txtSearch.WatermarkText = "Search Here"
        '
        'panPatient
        '
        Me.panPatient.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPatient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPatient.Controls.Add(Me.Label1)
        Me.panPatient.Location = New System.Drawing.Point(17, 4)
        Me.panPatient.Name = "panPatient"
        Me.panPatient.Size = New System.Drawing.Size(687, 39)
        Me.panPatient.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPatient.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panPatient.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPatient.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panPatient.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panPatient.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPatient.Style.GradientAngle = 90
        Me.panPatient.TabIndex = 299
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 25)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Fee Collection"
        '
        'tabPatient
        '
        Me.tabPatient.AttachedControl = Me.tbPatient
        Me.tabPatient.GlobalItem = False
        Me.tabPatient.Image = CType(resources.GetObject("tabPatient.Image"), System.Drawing.Image)
        Me.tabPatient.ImageAlignment = DevComponents.DotNetBar.ImageAlignment.TopCenter
        Me.tabPatient.Name = "tabPatient"
        SuperTabItemStateColorTable1.Text = System.Drawing.Color.Black
        SuperTabColorStates1.Normal = SuperTabItemStateColorTable1
        SuperTabItemColorTable1.Default = SuperTabColorStates1
        Me.tabPatient.TabColor = SuperTabItemColorTable1
        Me.tabPatient.Text = "Fee Collection"
        '
        'tabIncome
        '
        Me.tabIncome.GlobalItem = False
        Me.tabIncome.Image = CType(resources.GetObject("tabIncome.Image"), System.Drawing.Image)
        Me.tabIncome.ImageAlignment = DevComponents.DotNetBar.ImageAlignment.TopCenter
        Me.tabIncome.Name = "tabIncome"
        SuperTabItemStateColorTable3.Text = System.Drawing.Color.Black
        SuperTabColorStates3.Normal = SuperTabItemStateColorTable3
        SuperTabItemColorTable3.Default = SuperTabColorStates3
        Me.tabIncome.TabColor = SuperTabItemColorTable3
        Me.tabIncome.Text = "Others Income"
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colID.Visible = False
        '
        'colPrint
        '
        Me.colPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colPrint.HeaderText = ""
        Me.colPrint.HoverImage = CType(resources.GetObject("colPrint.HoverImage"), System.Drawing.Image)
        Me.colPrint.Image = CType(resources.GetObject("colPrint.Image"), System.Drawing.Image)
        Me.colPrint.Name = "colPrint"
        Me.colPrint.ReadOnly = True
        Me.colPrint.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPrint.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.colPrint.Text = Nothing
        Me.colPrint.Width = 28
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Receive Date"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colEmail.Width = 110
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colName.HeaderText = "Receive From"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colAddress
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAddress.HeaderText = "Receive To"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAddress.Width = 130
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
        Me.colDetails.Width = 130
        '
        'colRemarks
        '
        Me.colRemarks.HeaderText = "Fee Type"
        Me.colRemarks.Name = "colRemarks"
        Me.colRemarks.ReadOnly = True
        '
        'colContact
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colContact.DefaultCellStyle = DataGridViewCellStyle4
        Me.colContact.HeaderText = "Amount"
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        Me.colContact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colContact.Width = 120
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'FrmCollectionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.panProducts)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCollectionList"
        Me.Text = "Collection / Receive"
        CType(Me.dgvCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panProducts.ResumeLayout(False)
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.tbRecognize.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.dgvDonation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panExistTitle.ResumeLayout(False)
        Me.panExistTitle.PerformLayout()
        Me.tbPatient.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.panPatient.ResumeLayout(False)
        Me.panPatient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCollection As System.Windows.Forms.DataGridView
    Friend WithEvents lblType As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents panProducts As DevComponents.DotNetBar.PanelEx
    Public WithEvents tabMain As DevComponents.DotNetBar.SuperTabControl
    Private WithEvents tbPatient As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panPatient As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents tabPatient As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents tbRecognize As DevComponents.DotNetBar.SuperTabControlPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panExistTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents tabExisting As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents dgvDonation As System.Windows.Forms.DataGridView
    Private WithEvents tabIncome As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents lblDonation As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpDonation As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewLabelXColumn1 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn2 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn3 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn4 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn5 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn6 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn8 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents txtSearchDonation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents colID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPrint As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents colEmail As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colAddress As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colType As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colDetails As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colRemarks As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colContact As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Column1 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
