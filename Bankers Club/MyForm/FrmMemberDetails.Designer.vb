<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemberDetails
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
        Dim SuperTabColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabColorTable = New DevComponents.DotNetBar.Rendering.SuperTabColorTable()
        Dim SuperTabLinearGradientColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable = New DevComponents.DotNetBar.Rendering.SuperTabLinearGradientColorTable()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMemberDetails))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim SuperTabItemColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates1 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable1 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim SuperTabItemColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates2 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable2 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim SuperTabItemColorTable3 As DevComponents.DotNetBar.Rendering.SuperTabItemColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemColorTable()
        Dim SuperTabColorStates3 As DevComponents.DotNetBar.Rendering.SuperTabColorStates = New DevComponents.DotNetBar.Rendering.SuperTabColorStates()
        Dim SuperTabItemStateColorTable3 As DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable = New DevComponents.DotNetBar.Rendering.SuperTabItemStateColorTable()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabMain = New DevComponents.DotNetBar.SuperTabControl()
        Me.tbPatient = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.dgvMemberList = New System.Windows.Forms.DataGridView()
        Me.panPatient = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearch = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.tabPatient = New DevComponents.DotNetBar.SuperTabItem()
        Me.tbRecognize = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.panAddVisitDetails = New DevComponents.DotNetBar.PanelEx()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.LabelX36 = New DevComponents.DotNetBar.LabelX()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPassport = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtContact2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpJoin = New System.Windows.Forms.DateTimePicker()
        Me.txtDesignation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBranch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBank = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX18 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX19 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX20 = New DevComponents.DotNetBar.LabelX()
        Me.lblVisitDetails = New System.Windows.Forms.Label()
        Me.lblDay = New DevComponents.DotNetBar.LabelX()
        Me.txtNID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panImage = New DevComponents.DotNetBar.PanelEx()
        Me.btnClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.panAddDetails = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.dtpMarriage = New System.Windows.Forms.DateTimePicker()
        Me.cmbMemtype = New System.Windows.Forms.ComboBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtAddress2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.lblVisit = New System.Windows.Forms.Label()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtSpouse = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.lblPayment = New DevComponents.DotNetBar.LabelX()
        Me.txtFather = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtMother = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.lblDate = New DevComponents.DotNetBar.LabelX()
        Me.txtAddress1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panExistTitle = New DevComponents.DotNetBar.PanelEx()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panButton = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.tabExisting = New DevComponents.DotNetBar.SuperTabItem()
        Me.SuperTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.txtSearchEx = New ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox()
        Me.btnSearchEx = New ComponentFactory.Krypton.Toolkit.ButtonSpecAny()
        Me.panEditBankDetails = New DevComponents.DotNetBar.PanelEx()
        Me.cmbEditStatus = New System.Windows.Forms.ComboBox()
        Me.LabelX37 = New DevComponents.DotNetBar.LabelX()
        Me.txtEditEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEditPassport = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEditSecond = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEditContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpEditJoin = New System.Windows.Forms.DateTimePicker()
        Me.txtEditDesignation = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEditBranch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEditBank = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX15 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX16 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX21 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX22 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX23 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX24 = New DevComponents.DotNetBar.LabelX()
        Me.lblProfession = New System.Windows.Forms.Label()
        Me.LabelX33 = New DevComponents.DotNetBar.LabelX()
        Me.txtEditNID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX17 = New DevComponents.DotNetBar.LabelX()
        Me.panEditImage = New DevComponents.DotNetBar.PanelEx()
        Me.btnEditClear = New DevComponents.DotNetBar.ButtonX()
        Me.btnEditBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.picEditImage = New System.Windows.Forms.PictureBox()
        Me.panEditMemberDetails = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX25 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX26 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX27 = New DevComponents.DotNetBar.LabelX()
        Me.dtpEditMarriage = New System.Windows.Forms.DateTimePicker()
        Me.cmbEditType = New System.Windows.Forms.ComboBox()
        Me.cmbEditSex = New System.Windows.Forms.ComboBox()
        Me.dtpEditDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtEditAddress2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX28 = New DevComponents.DotNetBar.LabelX()
        Me.lblMemberDetails = New System.Windows.Forms.Label()
        Me.txtEditName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX29 = New DevComponents.DotNetBar.LabelX()
        Me.txtEditSpouse = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX30 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX31 = New DevComponents.DotNetBar.LabelX()
        Me.txtEditFather = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX32 = New DevComponents.DotNetBar.LabelX()
        Me.txtEditMother = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX34 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX35 = New DevComponents.DotNetBar.LabelX()
        Me.txtEditAddress1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.panEditButton = New System.Windows.Forms.Panel()
        Me.btnEditCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnUpdate = New DevComponents.DotNetBar.ButtonX()
        Me.panToken = New DevComponents.DotNetBar.PanelEx()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabTokenList = New DevComponents.DotNetBar.SuperTabItem()
        Me.panProducts = New DevComponents.DotNetBar.PanelEx()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.colPritn = New DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colAddress = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn4 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colGender = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.DataGridViewLabelXColumn5 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMain.SuspendLayout()
        Me.tbPatient.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.dgvMemberList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panPatient.SuspendLayout()
        Me.tbRecognize.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.panAddVisitDetails.SuspendLayout()
        Me.panImage.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panAddDetails.SuspendLayout()
        Me.panExistTitle.SuspendLayout()
        Me.panButton.SuspendLayout()
        Me.SuperTabControlPanel1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.panEditBankDetails.SuspendLayout()
        Me.panEditImage.SuspendLayout()
        CType(Me.picEditImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panEditMemberDetails.SuspendLayout()
        Me.panEditButton.SuspendLayout()
        Me.panToken.SuspendLayout()
        Me.panProducts.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tabMain.Controls.Add(Me.SuperTabControlPanel1)
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
        Me.tabMain.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tabPatient, Me.tabExisting, Me.tabTokenList})
        SuperTabLinearGradientColorTable1.Colors = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))}
        SuperTabColorTable1.Background = SuperTabLinearGradientColorTable1
        Me.tabMain.TabStripColor = SuperTabColorTable1
        Me.tabMain.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
        Me.tabMain.TabVerticalSpacing = 10
        Me.tabMain.Text = "superTabControl2"
        Me.tabMain.TextAlignment = DevComponents.DotNetBar.eItemAlignment.Center
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
        Me.PanelEx2.Controls.Add(Me.dgvMemberList)
        Me.PanelEx2.Controls.Add(Me.panPatient)
        Me.PanelEx2.Controls.Add(Me.txtSearch)
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
        'dgvMemberList
        '
        Me.dgvMemberList.AllowUserToAddRows = False
        Me.dgvMemberList.AllowUserToDeleteRows = False
        Me.dgvMemberList.AllowUserToResizeRows = False
        Me.dgvMemberList.BackgroundColor = System.Drawing.Color.White
        Me.dgvMemberList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMemberList.CausesValidation = False
        Me.dgvMemberList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvMemberList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMemberList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMemberList.ColumnHeadersHeight = 32
        Me.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMemberList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPritn, Me.colID, Me.colName, Me.colAddress, Me.DataGridViewLabelXColumn4, Me.colGender, Me.DataGridViewLabelXColumn5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMemberList.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvMemberList.EnableHeadersVisualStyles = False
        Me.dgvMemberList.Location = New System.Drawing.Point(17, 86)
        Me.dgvMemberList.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvMemberList.MultiSelect = False
        Me.dgvMemberList.Name = "dgvMemberList"
        Me.dgvMemberList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvMemberList.RowHeadersVisible = False
        Me.dgvMemberList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvMemberList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvMemberList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvMemberList.RowTemplate.Height = 27
        Me.dgvMemberList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMemberList.ShowEditingIcon = False
        Me.dgvMemberList.Size = New System.Drawing.Size(684, 440)
        Me.dgvMemberList.TabIndex = 300
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
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Member List"
        '
        'txtSearch
        '
        Me.txtSearch.AlwaysActive = False
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearch.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearch})
        Me.txtSearch.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearch.Location = New System.Drawing.Point(18, 51)
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
        Me.txtSearch.TabIndex = 291
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.btnSearch.UniqueName = ""
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
        Me.tabPatient.Text = "Member List"
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
        Me.PanelEx1.Controls.Add(Me.panAddVisitDetails)
        Me.PanelEx1.Controls.Add(Me.panImage)
        Me.PanelEx1.Controls.Add(Me.panAddDetails)
        Me.PanelEx1.Controls.Add(Me.panExistTitle)
        Me.PanelEx1.Controls.Add(Me.panButton)
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
        'panAddVisitDetails
        '
        Me.panAddVisitDetails.CanvasColor = System.Drawing.SystemColors.Control
        Me.panAddVisitDetails.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panAddVisitDetails.Controls.Add(Me.cmbStatus)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX36)
        Me.panAddVisitDetails.Controls.Add(Me.txtEmail)
        Me.panAddVisitDetails.Controls.Add(Me.txtPassport)
        Me.panAddVisitDetails.Controls.Add(Me.txtContact2)
        Me.panAddVisitDetails.Controls.Add(Me.txtContact)
        Me.panAddVisitDetails.Controls.Add(Me.dtpJoin)
        Me.panAddVisitDetails.Controls.Add(Me.txtDesignation)
        Me.panAddVisitDetails.Controls.Add(Me.txtBranch)
        Me.panAddVisitDetails.Controls.Add(Me.txtBank)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX11)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX18)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX9)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX10)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX14)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX12)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX19)
        Me.panAddVisitDetails.Controls.Add(Me.LabelX20)
        Me.panAddVisitDetails.Controls.Add(Me.lblVisitDetails)
        Me.panAddVisitDetails.Controls.Add(Me.lblDay)
        Me.panAddVisitDetails.Controls.Add(Me.txtNID)
        Me.panAddVisitDetails.Location = New System.Drawing.Point(491, 67)
        Me.panAddVisitDetails.Name = "panAddVisitDetails"
        Me.panAddVisitDetails.Size = New System.Drawing.Size(323, 453)
        Me.panAddVisitDetails.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panAddVisitDetails.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panAddVisitDetails.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.panAddVisitDetails.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panAddVisitDetails.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panAddVisitDetails.Style.GradientAngle = 90
        Me.panAddVisitDetails.TabIndex = 1
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.White
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbStatus.ForeColor = System.Drawing.Color.Black
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(136, 395)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(223, 28)
        Me.cmbStatus.TabIndex = 9
        '
        'LabelX36
        '
        Me.LabelX36.AutoSize = True
        '
        '
        '
        Me.LabelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX36.ForeColor = System.Drawing.Color.Black
        Me.LabelX36.Location = New System.Drawing.Point(16, 398)
        Me.LabelX36.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX36.Name = "LabelX36"
        Me.LabelX36.Size = New System.Drawing.Size(49, 22)
        Me.LabelX36.TabIndex = 318
        Me.LabelX36.Text = "Status :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEmail.Border.Class = "TextBoxBorder"
        Me.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(136, 359)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(223, 27)
        Me.txtEmail.TabIndex = 8
        '
        'txtPassport
        '
        Me.txtPassport.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtPassport.Border.Class = "TextBoxBorder"
        Me.txtPassport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassport.ForeColor = System.Drawing.Color.Black
        Me.txtPassport.Location = New System.Drawing.Point(136, 320)
        Me.txtPassport.Name = "txtPassport"
        Me.txtPassport.Size = New System.Drawing.Size(223, 27)
        Me.txtPassport.TabIndex = 7
        '
        'txtContact2
        '
        Me.txtContact2.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtContact2.Border.Class = "TextBoxBorder"
        Me.txtContact2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact2.ForeColor = System.Drawing.Color.Black
        Me.txtContact2.Location = New System.Drawing.Point(136, 239)
        Me.txtContact2.Name = "txtContact2"
        Me.txtContact2.Size = New System.Drawing.Size(223, 27)
        Me.txtContact2.TabIndex = 5
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(136, 201)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(223, 27)
        Me.txtContact.TabIndex = 4
        '
        'dtpJoin
        '
        Me.dtpJoin.BackColor = System.Drawing.Color.White
        Me.dtpJoin.CustomFormat = "dd MMM yyyy"
        Me.dtpJoin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpJoin.ForeColor = System.Drawing.Color.Black
        Me.dtpJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpJoin.Location = New System.Drawing.Point(136, 163)
        Me.dtpJoin.Name = "dtpJoin"
        Me.dtpJoin.Size = New System.Drawing.Size(223, 27)
        Me.dtpJoin.TabIndex = 3
        '
        'txtDesignation
        '
        Me.txtDesignation.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtDesignation.Border.Class = "TextBoxBorder"
        Me.txtDesignation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDesignation.ForeColor = System.Drawing.Color.Black
        Me.txtDesignation.Location = New System.Drawing.Point(136, 125)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(223, 27)
        Me.txtDesignation.TabIndex = 2
        '
        'txtBranch
        '
        Me.txtBranch.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtBranch.Border.Class = "TextBoxBorder"
        Me.txtBranch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBranch.ForeColor = System.Drawing.Color.Black
        Me.txtBranch.Location = New System.Drawing.Point(136, 87)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(223, 27)
        Me.txtBranch.TabIndex = 1
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtBank.Border.Class = "TextBoxBorder"
        Me.txtBank.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBank.ForeColor = System.Drawing.Color.Black
        Me.txtBank.Location = New System.Drawing.Point(136, 49)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(223, 27)
        Me.txtBank.TabIndex = 0
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(16, 51)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(84, 22)
        Me.LabelX11.TabIndex = 316
        Me.LabelX11.Text = "Bank Name :"
        '
        'LabelX18
        '
        Me.LabelX18.AutoSize = True
        '
        '
        '
        Me.LabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX18.ForeColor = System.Drawing.Color.Black
        Me.LabelX18.Location = New System.Drawing.Point(16, 89)
        Me.LabelX18.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX18.Name = "LabelX18"
        Me.LabelX18.Size = New System.Drawing.Size(54, 22)
        Me.LabelX18.TabIndex = 312
        Me.LabelX18.Text = "Branch :"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(16, 361)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(44, 22)
        Me.LabelX9.TabIndex = 304
        Me.LabelX9.Text = "Email :"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(16, 279)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(83, 22)
        Me.LabelX10.TabIndex = 305
        Me.LabelX10.Text = "National ID :"
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(16, 241)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(112, 22)
        Me.LabelX14.TabIndex = 307
        Me.LabelX14.Text = "Second Contact :"
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(16, 203)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(83, 22)
        Me.LabelX12.TabIndex = 303
        Me.LabelX12.Text = "Contact No :"
        '
        'LabelX19
        '
        Me.LabelX19.AutoSize = True
        '
        '
        '
        Me.LabelX19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX19.ForeColor = System.Drawing.Color.Black
        Me.LabelX19.Location = New System.Drawing.Point(16, 166)
        Me.LabelX19.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX19.Name = "LabelX19"
        Me.LabelX19.Size = New System.Drawing.Size(70, 22)
        Me.LabelX19.TabIndex = 313
        Me.LabelX19.Text = "Join Date :"
        '
        'LabelX20
        '
        Me.LabelX20.AutoSize = True
        '
        '
        '
        Me.LabelX20.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX20.ForeColor = System.Drawing.Color.Black
        Me.LabelX20.Location = New System.Drawing.Point(16, 128)
        Me.LabelX20.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX20.Name = "LabelX20"
        Me.LabelX20.Size = New System.Drawing.Size(87, 22)
        Me.LabelX20.TabIndex = 314
        Me.LabelX20.Text = "Designation :"
        '
        'lblVisitDetails
        '
        Me.lblVisitDetails.AutoSize = True
        Me.lblVisitDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblVisitDetails.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.lblVisitDetails.ForeColor = System.Drawing.Color.Black
        Me.lblVisitDetails.Location = New System.Drawing.Point(128, 7)
        Me.lblVisitDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVisitDetails.Name = "lblVisitDetails"
        Me.lblVisitDetails.Size = New System.Drawing.Size(155, 25)
        Me.lblVisitDetails.TabIndex = 300
        Me.lblVisitDetails.Text = "Other Information"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        '
        '
        '
        Me.lblDay.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDay.ForeColor = System.Drawing.Color.Black
        Me.lblDay.Location = New System.Drawing.Point(16, 322)
        Me.lblDay.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(89, 22)
        Me.lblDay.TabIndex = 217
        Me.lblDay.Text = "Passport No :"
        '
        'txtNID
        '
        Me.txtNID.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtNID.Border.Class = "TextBoxBorder"
        Me.txtNID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNID.ForeColor = System.Drawing.Color.Black
        Me.txtNID.Location = New System.Drawing.Point(136, 277)
        Me.txtNID.Name = "txtNID"
        Me.txtNID.Size = New System.Drawing.Size(223, 27)
        Me.txtNID.TabIndex = 6
        '
        'panImage
        '
        Me.panImage.CanvasColor = System.Drawing.SystemColors.Control
        Me.panImage.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panImage.Controls.Add(Me.btnClear)
        Me.panImage.Controls.Add(Me.btnBrowse)
        Me.panImage.Controls.Add(Me.picImage)
        Me.panImage.Location = New System.Drawing.Point(405, 106)
        Me.panImage.Name = "panImage"
        Me.panImage.Size = New System.Drawing.Size(150, 206)
        Me.panImage.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panImage.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panImage.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panImage.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panImage.Style.GradientAngle = 90
        Me.panImage.TabIndex = 303
        '
        'btnClear
        '
        Me.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FocusCuesEnabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnClear.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnClear.Location = New System.Drawing.Point(96, 162)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnClear.Size = New System.Drawing.Size(30, 30)
        Me.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnClear.Symbol = ""
        Me.btnClear.SymbolSize = 15.0!
        Me.btnClear.TabIndex = 264
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FocusCuesEnabled = False
        Me.btnBrowse.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnBrowse.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnBrowse.Location = New System.Drawing.Point(22, 162)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnBrowse.Size = New System.Drawing.Size(30, 30)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnBrowse.Symbol = ""
        Me.btnBrowse.SymbolSize = 15.0!
        Me.btnBrowse.TabIndex = 263
        '
        'picImage
        '
        Me.picImage.BackColor = System.Drawing.Color.White
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.ForeColor = System.Drawing.Color.Black
        Me.picImage.Location = New System.Drawing.Point(22, 33)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(104, 123)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 265
        Me.picImage.TabStop = False
        '
        'panAddDetails
        '
        Me.panAddDetails.CanvasColor = System.Drawing.SystemColors.Control
        Me.panAddDetails.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panAddDetails.Controls.Add(Me.LabelX6)
        Me.panAddDetails.Controls.Add(Me.LabelX5)
        Me.panAddDetails.Controls.Add(Me.LabelX4)
        Me.panAddDetails.Controls.Add(Me.dtpMarriage)
        Me.panAddDetails.Controls.Add(Me.cmbMemtype)
        Me.panAddDetails.Controls.Add(Me.cmbGender)
        Me.panAddDetails.Controls.Add(Me.dtpDOB)
        Me.panAddDetails.Controls.Add(Me.txtAddress2)
        Me.panAddDetails.Controls.Add(Me.LabelX3)
        Me.panAddDetails.Controls.Add(Me.lblVisit)
        Me.panAddDetails.Controls.Add(Me.txtName)
        Me.panAddDetails.Controls.Add(Me.LabelX1)
        Me.panAddDetails.Controls.Add(Me.txtSpouse)
        Me.panAddDetails.Controls.Add(Me.LabelX13)
        Me.panAddDetails.Controls.Add(Me.lblPayment)
        Me.panAddDetails.Controls.Add(Me.txtFather)
        Me.panAddDetails.Controls.Add(Me.LabelX8)
        Me.panAddDetails.Controls.Add(Me.txtMother)
        Me.panAddDetails.Controls.Add(Me.LabelX2)
        Me.panAddDetails.Controls.Add(Me.lblDate)
        Me.panAddDetails.Controls.Add(Me.txtAddress1)
        Me.panAddDetails.Location = New System.Drawing.Point(30, 67)
        Me.panAddDetails.Name = "panAddDetails"
        Me.panAddDetails.Size = New System.Drawing.Size(365, 453)
        Me.panAddDetails.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panAddDetails.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panAddDetails.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.panAddDetails.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panAddDetails.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panAddDetails.Style.GradientAngle = 90
        Me.panAddDetails.TabIndex = 0
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(12, 412)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(100, 22)
        Me.LabelX6.TabIndex = 310
        Me.LabelX6.Text = "Spouse Name :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(12, 375)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(97, 22)
        Me.LabelX5.TabIndex = 309
        Me.LabelX5.Text = "Marriage Day :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(12, 338)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(107, 22)
        Me.LabelX4.TabIndex = 308
        Me.LabelX4.Text = "Mameber Type :"
        '
        'dtpMarriage
        '
        Me.dtpMarriage.BackColor = System.Drawing.Color.White
        Me.dtpMarriage.CustomFormat = "dd MMM yyyy"
        Me.dtpMarriage.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpMarriage.ForeColor = System.Drawing.Color.Black
        Me.dtpMarriage.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMarriage.Location = New System.Drawing.Point(123, 373)
        Me.dtpMarriage.Name = "dtpMarriage"
        Me.dtpMarriage.Size = New System.Drawing.Size(223, 27)
        Me.dtpMarriage.TabIndex = 8
        '
        'cmbMemtype
        '
        Me.cmbMemtype.BackColor = System.Drawing.Color.White
        Me.cmbMemtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMemtype.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbMemtype.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbMemtype.ForeColor = System.Drawing.Color.Black
        Me.cmbMemtype.FormattingEnabled = True
        Me.cmbMemtype.Items.AddRange(New Object() {"Life Member", "General Member"})
        Me.cmbMemtype.Location = New System.Drawing.Point(123, 335)
        Me.cmbMemtype.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMemtype.Name = "cmbMemtype"
        Me.cmbMemtype.Size = New System.Drawing.Size(223, 28)
        Me.cmbMemtype.TabIndex = 7
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.White
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbGender.ForeColor = System.Drawing.Color.Black
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbGender.Location = New System.Drawing.Point(123, 297)
        Me.cmbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(223, 28)
        Me.cmbGender.TabIndex = 6
        '
        'dtpDOB
        '
        Me.dtpDOB.BackColor = System.Drawing.Color.White
        Me.dtpDOB.CustomFormat = "dd MMM yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDOB.ForeColor = System.Drawing.Color.Black
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(123, 260)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(223, 27)
        Me.dtpDOB.TabIndex = 5
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtAddress2.Border.Class = "TextBoxBorder"
        Me.txtAddress2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAddress2.ForeColor = System.Drawing.Color.Black
        Me.txtAddress2.Location = New System.Drawing.Point(123, 204)
        Me.txtAddress2.Multiline = True
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(223, 46)
        Me.txtAddress2.TabIndex = 4
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(12, 204)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(74, 22)
        Me.LabelX3.TabIndex = 301
        Me.LabelX3.Text = "Address 2 :"
        '
        'lblVisit
        '
        Me.lblVisit.AutoSize = True
        Me.lblVisit.BackColor = System.Drawing.Color.Transparent
        Me.lblVisit.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.lblVisit.ForeColor = System.Drawing.Color.Black
        Me.lblVisit.Location = New System.Drawing.Point(127, 6)
        Me.lblVisit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVisit.Name = "lblVisit"
        Me.lblVisit.Size = New System.Drawing.Size(176, 25)
        Me.lblVisit.TabIndex = 300
        Me.lblVisit.Text = "Personal Information"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(123, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 27)
        Me.txtName.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(12, 39)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 22)
        Me.LabelX1.TabIndex = 208
        Me.LabelX1.Text = "Name :"
        '
        'txtSpouse
        '
        Me.txtSpouse.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtSpouse.Border.Class = "TextBoxBorder"
        Me.txtSpouse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSpouse.ForeColor = System.Drawing.Color.Black
        Me.txtSpouse.Location = New System.Drawing.Point(123, 410)
        Me.txtSpouse.Name = "txtSpouse"
        Me.txtSpouse.Size = New System.Drawing.Size(223, 27)
        Me.txtSpouse.TabIndex = 9
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(12, 76)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(93, 22)
        Me.LabelX13.TabIndex = 216
        Me.LabelX13.Text = "Father Name :"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        '
        '
        '
        Me.lblPayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPayment.ForeColor = System.Drawing.Color.Black
        Me.lblPayment.Location = New System.Drawing.Point(12, 300)
        Me.lblPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(57, 22)
        Me.lblPayment.TabIndex = 217
        Me.lblPayment.Text = "Gender :"
        '
        'txtFather
        '
        Me.txtFather.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtFather.Border.Class = "TextBoxBorder"
        Me.txtFather.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFather.ForeColor = System.Drawing.Color.Black
        Me.txtFather.Location = New System.Drawing.Point(123, 74)
        Me.txtFather.Name = "txtFather"
        Me.txtFather.Size = New System.Drawing.Size(223, 27)
        Me.txtFather.TabIndex = 1
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(12, 113)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(100, 22)
        Me.LabelX8.TabIndex = 221
        Me.LabelX8.Text = "Mother Name :"
        '
        'txtMother
        '
        Me.txtMother.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtMother.Border.Class = "TextBoxBorder"
        Me.txtMother.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMother.ForeColor = System.Drawing.Color.Black
        Me.txtMother.Location = New System.Drawing.Point(123, 111)
        Me.txtMother.Name = "txtMother"
        Me.txtMother.Size = New System.Drawing.Size(223, 27)
        Me.txtMother.TabIndex = 2
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(12, 148)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(74, 22)
        Me.LabelX2.TabIndex = 216
        Me.LabelX2.Text = "Address 1 :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        '
        '
        '
        Me.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(12, 262)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(92, 22)
        Me.lblDate.TabIndex = 217
        Me.lblDate.Text = "Date of Birth :"
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtAddress1.Border.Class = "TextBoxBorder"
        Me.txtAddress1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAddress1.ForeColor = System.Drawing.Color.Black
        Me.txtAddress1.Location = New System.Drawing.Point(123, 148)
        Me.txtAddress1.Multiline = True
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(223, 46)
        Me.txtAddress1.TabIndex = 3
        '
        'panExistTitle
        '
        Me.panExistTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.panExistTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panExistTitle.Controls.Add(Me.Label3)
        Me.panExistTitle.Location = New System.Drawing.Point(21, 5)
        Me.panExistTitle.Name = "panExistTitle"
        Me.panExistTitle.Size = New System.Drawing.Size(687, 44)
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
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 297
        Me.Label3.Text = "New Member"
        '
        'panButton
        '
        Me.panButton.BackColor = System.Drawing.Color.Transparent
        Me.panButton.Controls.Add(Me.btnCancel)
        Me.panButton.Controls.Add(Me.btnSave)
        Me.panButton.ForeColor = System.Drawing.Color.Black
        Me.panButton.Location = New System.Drawing.Point(405, 474)
        Me.panButton.Name = "panButton"
        Me.panButton.Size = New System.Drawing.Size(150, 36)
        Me.panButton.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.Location = New System.Drawing.Point(75, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.FocusCuesEnabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnSave.Size = New System.Drawing.Size(70, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.Symbol = ""
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
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
        Me.tabExisting.Text = "Add Member"
        '
        'SuperTabControlPanel1
        '
        Me.SuperTabControlPanel1.BackgroundImage = CType(resources.GetObject("SuperTabControlPanel1.BackgroundImage"), System.Drawing.Image)
        Me.SuperTabControlPanel1.Controls.Add(Me.PanelEx3)
        Me.SuperTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SuperTabControlPanel1.Location = New System.Drawing.Point(202, 0)
        Me.SuperTabControlPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SuperTabControlPanel1.Name = "SuperTabControlPanel1"
        Me.SuperTabControlPanel1.Size = New System.Drawing.Size(717, 537)
        Me.SuperTabControlPanel1.TabIndex = 5
        Me.SuperTabControlPanel1.TabItem = Me.tabTokenList
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.txtSearchEx)
        Me.PanelEx3.Controls.Add(Me.panEditBankDetails)
        Me.PanelEx3.Controls.Add(Me.panEditImage)
        Me.PanelEx3.Controls.Add(Me.panEditMemberDetails)
        Me.PanelEx3.Controls.Add(Me.panEditButton)
        Me.PanelEx3.Controls.Add(Me.panToken)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(717, 537)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 301
        '
        'txtSearchEx
        '
        Me.txtSearchEx.AlwaysActive = False
        Me.txtSearchEx.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtSearchEx.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecAny() {Me.btnSearchEx})
        Me.txtSearchEx.Culture = New System.Globalization.CultureInfo("en-AU")
        Me.txtSearchEx.ForeColor = System.Drawing.Color.Black
        Me.txtSearchEx.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtSearchEx.Location = New System.Drawing.Point(27, 49)
        Me.txtSearchEx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchEx.Name = "txtSearchEx"
        Me.txtSearchEx.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver
        Me.txtSearchEx.PromptChar = Global.Microsoft.VisualBasic.ChrW(48)
        Me.txtSearchEx.Size = New System.Drawing.Size(247, 28)
        Me.txtSearchEx.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearchEx.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearchEx.StateActive.Content.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchEx.StateActive.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.txtSearchEx.StateCommon.Border.Color1 = System.Drawing.Color.Gray
        Me.txtSearchEx.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
            Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtSearchEx.StateCommon.Border.Rounding = 1
        Me.txtSearchEx.StateCommon.Border.Width = 1
        Me.txtSearchEx.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txtSearchEx.StateCommon.Content.Padding = New System.Windows.Forms.Padding(2)
        Me.txtSearchEx.TabIndex = 308
        '
        'btnSearchEx
        '
        Me.btnSearchEx.Image = CType(resources.GetObject("btnSearchEx.Image"), System.Drawing.Image)
        Me.btnSearchEx.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Cluster
        Me.btnSearchEx.Text = "Search"
        Me.btnSearchEx.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close
        Me.btnSearchEx.UniqueName = ""
        '
        'panEditBankDetails
        '
        Me.panEditBankDetails.CanvasColor = System.Drawing.SystemColors.Control
        Me.panEditBankDetails.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panEditBankDetails.Controls.Add(Me.cmbEditStatus)
        Me.panEditBankDetails.Controls.Add(Me.LabelX37)
        Me.panEditBankDetails.Controls.Add(Me.txtEditEmail)
        Me.panEditBankDetails.Controls.Add(Me.txtEditPassport)
        Me.panEditBankDetails.Controls.Add(Me.txtEditSecond)
        Me.panEditBankDetails.Controls.Add(Me.txtEditContact)
        Me.panEditBankDetails.Controls.Add(Me.dtpEditJoin)
        Me.panEditBankDetails.Controls.Add(Me.txtEditDesignation)
        Me.panEditBankDetails.Controls.Add(Me.txtEditBranch)
        Me.panEditBankDetails.Controls.Add(Me.txtEditBank)
        Me.panEditBankDetails.Controls.Add(Me.LabelX7)
        Me.panEditBankDetails.Controls.Add(Me.LabelX15)
        Me.panEditBankDetails.Controls.Add(Me.LabelX16)
        Me.panEditBankDetails.Controls.Add(Me.LabelX21)
        Me.panEditBankDetails.Controls.Add(Me.LabelX22)
        Me.panEditBankDetails.Controls.Add(Me.LabelX23)
        Me.panEditBankDetails.Controls.Add(Me.LabelX24)
        Me.panEditBankDetails.Controls.Add(Me.lblProfession)
        Me.panEditBankDetails.Controls.Add(Me.LabelX33)
        Me.panEditBankDetails.Controls.Add(Me.txtEditNID)
        Me.panEditBankDetails.Controls.Add(Me.LabelX17)
        Me.panEditBankDetails.Location = New System.Drawing.Point(479, 83)
        Me.panEditBankDetails.Name = "panEditBankDetails"
        Me.panEditBankDetails.Size = New System.Drawing.Size(323, 407)
        Me.panEditBankDetails.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panEditBankDetails.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panEditBankDetails.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.panEditBankDetails.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panEditBankDetails.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panEditBankDetails.Style.GradientAngle = 90
        Me.panEditBankDetails.TabIndex = 305
        '
        'cmbEditStatus
        '
        Me.cmbEditStatus.BackColor = System.Drawing.Color.White
        Me.cmbEditStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEditStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEditStatus.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbEditStatus.ForeColor = System.Drawing.Color.Black
        Me.cmbEditStatus.FormattingEnabled = True
        Me.cmbEditStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cmbEditStatus.Location = New System.Drawing.Point(136, 371)
        Me.cmbEditStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEditStatus.Name = "cmbEditStatus"
        Me.cmbEditStatus.Size = New System.Drawing.Size(223, 28)
        Me.cmbEditStatus.TabIndex = 319
        '
        'LabelX37
        '
        Me.LabelX37.AutoSize = True
        '
        '
        '
        Me.LabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX37.ForeColor = System.Drawing.Color.Black
        Me.LabelX37.Location = New System.Drawing.Point(16, 374)
        Me.LabelX37.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX37.Name = "LabelX37"
        Me.LabelX37.Size = New System.Drawing.Size(49, 22)
        Me.LabelX37.TabIndex = 320
        Me.LabelX37.Text = "Status :"
        '
        'txtEditEmail
        '
        Me.txtEditEmail.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditEmail.Border.Class = "TextBoxBorder"
        Me.txtEditEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEditEmail.Location = New System.Drawing.Point(136, 337)
        Me.txtEditEmail.Name = "txtEditEmail"
        Me.txtEditEmail.Size = New System.Drawing.Size(223, 27)
        Me.txtEditEmail.TabIndex = 7
        '
        'txtEditPassport
        '
        Me.txtEditPassport.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditPassport.Border.Class = "TextBoxBorder"
        Me.txtEditPassport.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditPassport.ForeColor = System.Drawing.Color.Black
        Me.txtEditPassport.Location = New System.Drawing.Point(136, 301)
        Me.txtEditPassport.Name = "txtEditPassport"
        Me.txtEditPassport.Size = New System.Drawing.Size(223, 27)
        Me.txtEditPassport.TabIndex = 6
        '
        'txtEditSecond
        '
        Me.txtEditSecond.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditSecond.Border.Class = "TextBoxBorder"
        Me.txtEditSecond.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditSecond.ForeColor = System.Drawing.Color.Black
        Me.txtEditSecond.Location = New System.Drawing.Point(136, 229)
        Me.txtEditSecond.Name = "txtEditSecond"
        Me.txtEditSecond.Size = New System.Drawing.Size(223, 27)
        Me.txtEditSecond.TabIndex = 5
        '
        'txtEditContact
        '
        Me.txtEditContact.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditContact.Border.Class = "TextBoxBorder"
        Me.txtEditContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditContact.ForeColor = System.Drawing.Color.Black
        Me.txtEditContact.Location = New System.Drawing.Point(136, 193)
        Me.txtEditContact.Name = "txtEditContact"
        Me.txtEditContact.Size = New System.Drawing.Size(223, 27)
        Me.txtEditContact.TabIndex = 4
        '
        'dtpEditJoin
        '
        Me.dtpEditJoin.BackColor = System.Drawing.Color.White
        Me.dtpEditJoin.CustomFormat = "dd MMM yyyy"
        Me.dtpEditJoin.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpEditJoin.ForeColor = System.Drawing.Color.Black
        Me.dtpEditJoin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEditJoin.Location = New System.Drawing.Point(136, 157)
        Me.dtpEditJoin.Name = "dtpEditJoin"
        Me.dtpEditJoin.Size = New System.Drawing.Size(223, 27)
        Me.dtpEditJoin.TabIndex = 3
        '
        'txtEditDesignation
        '
        Me.txtEditDesignation.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditDesignation.Border.Class = "TextBoxBorder"
        Me.txtEditDesignation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditDesignation.ForeColor = System.Drawing.Color.Black
        Me.txtEditDesignation.Location = New System.Drawing.Point(136, 121)
        Me.txtEditDesignation.Name = "txtEditDesignation"
        Me.txtEditDesignation.Size = New System.Drawing.Size(223, 27)
        Me.txtEditDesignation.TabIndex = 2
        '
        'txtEditBranch
        '
        Me.txtEditBranch.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditBranch.Border.Class = "TextBoxBorder"
        Me.txtEditBranch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditBranch.ForeColor = System.Drawing.Color.Black
        Me.txtEditBranch.Location = New System.Drawing.Point(136, 85)
        Me.txtEditBranch.Name = "txtEditBranch"
        Me.txtEditBranch.Size = New System.Drawing.Size(223, 27)
        Me.txtEditBranch.TabIndex = 1
        '
        'txtEditBank
        '
        Me.txtEditBank.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditBank.Border.Class = "TextBoxBorder"
        Me.txtEditBank.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditBank.ForeColor = System.Drawing.Color.Black
        Me.txtEditBank.Location = New System.Drawing.Point(136, 49)
        Me.txtEditBank.Name = "txtEditBank"
        Me.txtEditBank.Size = New System.Drawing.Size(223, 27)
        Me.txtEditBank.TabIndex = 0
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(16, 51)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(84, 22)
        Me.LabelX7.TabIndex = 316
        Me.LabelX7.Text = "Bank Name :"
        '
        'LabelX15
        '
        Me.LabelX15.AutoSize = True
        '
        '
        '
        Me.LabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX15.ForeColor = System.Drawing.Color.Black
        Me.LabelX15.Location = New System.Drawing.Point(16, 87)
        Me.LabelX15.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX15.Name = "LabelX15"
        Me.LabelX15.Size = New System.Drawing.Size(54, 22)
        Me.LabelX15.TabIndex = 312
        Me.LabelX15.Text = "Branch :"
        '
        'LabelX16
        '
        Me.LabelX16.AutoSize = True
        '
        '
        '
        Me.LabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX16.ForeColor = System.Drawing.Color.Black
        Me.LabelX16.Location = New System.Drawing.Point(16, 339)
        Me.LabelX16.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX16.Name = "LabelX16"
        Me.LabelX16.Size = New System.Drawing.Size(44, 22)
        Me.LabelX16.TabIndex = 304
        Me.LabelX16.Text = "Email :"
        '
        'LabelX21
        '
        Me.LabelX21.AutoSize = True
        '
        '
        '
        Me.LabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX21.ForeColor = System.Drawing.Color.Black
        Me.LabelX21.Location = New System.Drawing.Point(16, 231)
        Me.LabelX21.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX21.Name = "LabelX21"
        Me.LabelX21.Size = New System.Drawing.Size(112, 22)
        Me.LabelX21.TabIndex = 307
        Me.LabelX21.Text = "Second Contact :"
        '
        'LabelX22
        '
        Me.LabelX22.AutoSize = True
        '
        '
        '
        Me.LabelX22.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX22.ForeColor = System.Drawing.Color.Black
        Me.LabelX22.Location = New System.Drawing.Point(16, 195)
        Me.LabelX22.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX22.Name = "LabelX22"
        Me.LabelX22.Size = New System.Drawing.Size(83, 22)
        Me.LabelX22.TabIndex = 303
        Me.LabelX22.Text = "Contact No :"
        '
        'LabelX23
        '
        Me.LabelX23.AutoSize = True
        '
        '
        '
        Me.LabelX23.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX23.ForeColor = System.Drawing.Color.Black
        Me.LabelX23.Location = New System.Drawing.Point(16, 159)
        Me.LabelX23.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX23.Name = "LabelX23"
        Me.LabelX23.Size = New System.Drawing.Size(70, 22)
        Me.LabelX23.TabIndex = 313
        Me.LabelX23.Text = "Join Date :"
        '
        'LabelX24
        '
        Me.LabelX24.AutoSize = True
        '
        '
        '
        Me.LabelX24.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX24.ForeColor = System.Drawing.Color.Black
        Me.LabelX24.Location = New System.Drawing.Point(16, 123)
        Me.LabelX24.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX24.Name = "LabelX24"
        Me.LabelX24.Size = New System.Drawing.Size(87, 22)
        Me.LabelX24.TabIndex = 314
        Me.LabelX24.Text = "Designation :"
        '
        'lblProfession
        '
        Me.lblProfession.AutoSize = True
        Me.lblProfession.BackColor = System.Drawing.Color.Transparent
        Me.lblProfession.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.lblProfession.ForeColor = System.Drawing.Color.Black
        Me.lblProfession.Location = New System.Drawing.Point(128, 7)
        Me.lblProfession.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProfession.Name = "lblProfession"
        Me.lblProfession.Size = New System.Drawing.Size(155, 25)
        Me.lblProfession.TabIndex = 300
        Me.lblProfession.Text = "Other Information"
        '
        'LabelX33
        '
        Me.LabelX33.AutoSize = True
        '
        '
        '
        Me.LabelX33.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX33.ForeColor = System.Drawing.Color.Black
        Me.LabelX33.Location = New System.Drawing.Point(16, 267)
        Me.LabelX33.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX33.Name = "LabelX33"
        Me.LabelX33.Size = New System.Drawing.Size(83, 22)
        Me.LabelX33.TabIndex = 217
        Me.LabelX33.Text = "National ID :"
        '
        'txtEditNID
        '
        Me.txtEditNID.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditNID.Border.Class = "TextBoxBorder"
        Me.txtEditNID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditNID.ForeColor = System.Drawing.Color.Black
        Me.txtEditNID.Location = New System.Drawing.Point(136, 265)
        Me.txtEditNID.Name = "txtEditNID"
        Me.txtEditNID.Size = New System.Drawing.Size(223, 27)
        Me.txtEditNID.TabIndex = 6
        '
        'LabelX17
        '
        Me.LabelX17.AutoSize = True
        '
        '
        '
        Me.LabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX17.ForeColor = System.Drawing.Color.Black
        Me.LabelX17.Location = New System.Drawing.Point(16, 303)
        Me.LabelX17.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX17.Name = "LabelX17"
        Me.LabelX17.Size = New System.Drawing.Size(89, 22)
        Me.LabelX17.TabIndex = 305
        Me.LabelX17.Text = "Passport No :"
        '
        'panEditImage
        '
        Me.panEditImage.CanvasColor = System.Drawing.SystemColors.Control
        Me.panEditImage.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panEditImage.Controls.Add(Me.btnEditClear)
        Me.panEditImage.Controls.Add(Me.btnEditBrowse)
        Me.panEditImage.Controls.Add(Me.picEditImage)
        Me.panEditImage.Location = New System.Drawing.Point(393, 122)
        Me.panEditImage.Name = "panEditImage"
        Me.panEditImage.Size = New System.Drawing.Size(150, 206)
        Me.panEditImage.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panEditImage.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panEditImage.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panEditImage.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panEditImage.Style.GradientAngle = 90
        Me.panEditImage.TabIndex = 307
        '
        'btnEditClear
        '
        Me.btnEditClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEditClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditClear.FocusCuesEnabled = False
        Me.btnEditClear.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnEditClear.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnEditClear.Location = New System.Drawing.Point(96, 162)
        Me.btnEditClear.Name = "btnEditClear"
        Me.btnEditClear.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnEditClear.Size = New System.Drawing.Size(30, 30)
        Me.btnEditClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnEditClear.Symbol = ""
        Me.btnEditClear.SymbolSize = 15.0!
        Me.btnEditClear.TabIndex = 264
        '
        'btnEditBrowse
        '
        Me.btnEditBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnEditBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditBrowse.FocusCuesEnabled = False
        Me.btnEditBrowse.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnEditBrowse.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnEditBrowse.Location = New System.Drawing.Point(22, 162)
        Me.btnEditBrowse.Name = "btnEditBrowse"
        Me.btnEditBrowse.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnEditBrowse.Size = New System.Drawing.Size(30, 30)
        Me.btnEditBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnEditBrowse.Symbol = ""
        Me.btnEditBrowse.SymbolSize = 15.0!
        Me.btnEditBrowse.TabIndex = 0
        '
        'picEditImage
        '
        Me.picEditImage.BackColor = System.Drawing.Color.White
        Me.picEditImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picEditImage.ForeColor = System.Drawing.Color.Black
        Me.picEditImage.Location = New System.Drawing.Point(22, 33)
        Me.picEditImage.Name = "picEditImage"
        Me.picEditImage.Size = New System.Drawing.Size(104, 123)
        Me.picEditImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEditImage.TabIndex = 265
        Me.picEditImage.TabStop = False
        '
        'panEditMemberDetails
        '
        Me.panEditMemberDetails.CanvasColor = System.Drawing.SystemColors.Control
        Me.panEditMemberDetails.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panEditMemberDetails.Controls.Add(Me.LabelX25)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX26)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX27)
        Me.panEditMemberDetails.Controls.Add(Me.dtpEditMarriage)
        Me.panEditMemberDetails.Controls.Add(Me.cmbEditType)
        Me.panEditMemberDetails.Controls.Add(Me.cmbEditSex)
        Me.panEditMemberDetails.Controls.Add(Me.dtpEditDOB)
        Me.panEditMemberDetails.Controls.Add(Me.txtEditAddress2)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX28)
        Me.panEditMemberDetails.Controls.Add(Me.lblMemberDetails)
        Me.panEditMemberDetails.Controls.Add(Me.txtEditName)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX29)
        Me.panEditMemberDetails.Controls.Add(Me.txtEditSpouse)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX30)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX31)
        Me.panEditMemberDetails.Controls.Add(Me.txtEditFather)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX32)
        Me.panEditMemberDetails.Controls.Add(Me.txtEditMother)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX34)
        Me.panEditMemberDetails.Controls.Add(Me.LabelX35)
        Me.panEditMemberDetails.Controls.Add(Me.txtEditAddress1)
        Me.panEditMemberDetails.Location = New System.Drawing.Point(27, 83)
        Me.panEditMemberDetails.Name = "panEditMemberDetails"
        Me.panEditMemberDetails.Size = New System.Drawing.Size(365, 453)
        Me.panEditMemberDetails.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panEditMemberDetails.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panEditMemberDetails.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.panEditMemberDetails.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.panEditMemberDetails.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panEditMemberDetails.Style.GradientAngle = 90
        Me.panEditMemberDetails.TabIndex = 304
        '
        'LabelX25
        '
        Me.LabelX25.AutoSize = True
        '
        '
        '
        Me.LabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX25.ForeColor = System.Drawing.Color.Black
        Me.LabelX25.Location = New System.Drawing.Point(12, 403)
        Me.LabelX25.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX25.Name = "LabelX25"
        Me.LabelX25.Size = New System.Drawing.Size(100, 22)
        Me.LabelX25.TabIndex = 310
        Me.LabelX25.Text = "Spouse Name :"
        '
        'LabelX26
        '
        Me.LabelX26.AutoSize = True
        '
        '
        '
        Me.LabelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX26.ForeColor = System.Drawing.Color.Black
        Me.LabelX26.Location = New System.Drawing.Point(12, 367)
        Me.LabelX26.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX26.Name = "LabelX26"
        Me.LabelX26.Size = New System.Drawing.Size(97, 22)
        Me.LabelX26.TabIndex = 309
        Me.LabelX26.Text = "Marriage Day :"
        '
        'LabelX27
        '
        Me.LabelX27.AutoSize = True
        '
        '
        '
        Me.LabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX27.ForeColor = System.Drawing.Color.Black
        Me.LabelX27.Location = New System.Drawing.Point(12, 331)
        Me.LabelX27.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX27.Name = "LabelX27"
        Me.LabelX27.Size = New System.Drawing.Size(107, 22)
        Me.LabelX27.TabIndex = 308
        Me.LabelX27.Text = "Mameber Type :"
        '
        'dtpEditMarriage
        '
        Me.dtpEditMarriage.BackColor = System.Drawing.Color.White
        Me.dtpEditMarriage.CustomFormat = "dd MMM yyyy"
        Me.dtpEditMarriage.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpEditMarriage.ForeColor = System.Drawing.Color.Black
        Me.dtpEditMarriage.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEditMarriage.Location = New System.Drawing.Point(123, 365)
        Me.dtpEditMarriage.Name = "dtpEditMarriage"
        Me.dtpEditMarriage.Size = New System.Drawing.Size(223, 27)
        Me.dtpEditMarriage.TabIndex = 10
        '
        'cmbEditType
        '
        Me.cmbEditType.BackColor = System.Drawing.Color.White
        Me.cmbEditType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEditType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEditType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbEditType.ForeColor = System.Drawing.Color.Black
        Me.cmbEditType.FormattingEnabled = True
        Me.cmbEditType.Items.AddRange(New Object() {"Life Member", "General Member"})
        Me.cmbEditType.Location = New System.Drawing.Point(123, 328)
        Me.cmbEditType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEditType.Name = "cmbEditType"
        Me.cmbEditType.Size = New System.Drawing.Size(223, 28)
        Me.cmbEditType.TabIndex = 8
        '
        'cmbEditSex
        '
        Me.cmbEditSex.BackColor = System.Drawing.Color.White
        Me.cmbEditSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEditSex.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbEditSex.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbEditSex.ForeColor = System.Drawing.Color.Black
        Me.cmbEditSex.FormattingEnabled = True
        Me.cmbEditSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbEditSex.Location = New System.Drawing.Point(123, 291)
        Me.cmbEditSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbEditSex.Name = "cmbEditSex"
        Me.cmbEditSex.Size = New System.Drawing.Size(223, 28)
        Me.cmbEditSex.TabIndex = 7
        '
        'dtpEditDOB
        '
        Me.dtpEditDOB.BackColor = System.Drawing.Color.White
        Me.dtpEditDOB.CustomFormat = "dd MMM yyyy"
        Me.dtpEditDOB.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpEditDOB.ForeColor = System.Drawing.Color.Black
        Me.dtpEditDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEditDOB.Location = New System.Drawing.Point(123, 255)
        Me.dtpEditDOB.Name = "dtpEditDOB"
        Me.dtpEditDOB.Size = New System.Drawing.Size(223, 27)
        Me.dtpEditDOB.TabIndex = 5
        '
        'txtEditAddress2
        '
        Me.txtEditAddress2.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditAddress2.Border.Class = "TextBoxBorder"
        Me.txtEditAddress2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditAddress2.ForeColor = System.Drawing.Color.Black
        Me.txtEditAddress2.Location = New System.Drawing.Point(123, 200)
        Me.txtEditAddress2.Multiline = True
        Me.txtEditAddress2.Name = "txtEditAddress2"
        Me.txtEditAddress2.Size = New System.Drawing.Size(223, 46)
        Me.txtEditAddress2.TabIndex = 4
        '
        'LabelX28
        '
        Me.LabelX28.AutoSize = True
        '
        '
        '
        Me.LabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX28.ForeColor = System.Drawing.Color.Black
        Me.LabelX28.Location = New System.Drawing.Point(12, 200)
        Me.LabelX28.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX28.Name = "LabelX28"
        Me.LabelX28.Size = New System.Drawing.Size(74, 22)
        Me.LabelX28.TabIndex = 301
        Me.LabelX28.Text = "Address 2 :"
        '
        'lblMemberDetails
        '
        Me.lblMemberDetails.AutoSize = True
        Me.lblMemberDetails.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberDetails.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.lblMemberDetails.ForeColor = System.Drawing.Color.Black
        Me.lblMemberDetails.Location = New System.Drawing.Point(127, 6)
        Me.lblMemberDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMemberDetails.Name = "lblMemberDetails"
        Me.lblMemberDetails.Size = New System.Drawing.Size(176, 25)
        Me.lblMemberDetails.TabIndex = 300
        Me.lblMemberDetails.Text = "Personal Information"
        '
        'txtEditName
        '
        Me.txtEditName.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditName.Border.Class = "TextBoxBorder"
        Me.txtEditName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditName.ForeColor = System.Drawing.Color.Black
        Me.txtEditName.Location = New System.Drawing.Point(123, 37)
        Me.txtEditName.Name = "txtEditName"
        Me.txtEditName.Size = New System.Drawing.Size(223, 27)
        Me.txtEditName.TabIndex = 0
        '
        'LabelX29
        '
        Me.LabelX29.AutoSize = True
        '
        '
        '
        Me.LabelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX29.ForeColor = System.Drawing.Color.Black
        Me.LabelX29.Location = New System.Drawing.Point(12, 39)
        Me.LabelX29.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX29.Name = "LabelX29"
        Me.LabelX29.Size = New System.Drawing.Size(48, 22)
        Me.LabelX29.TabIndex = 208
        Me.LabelX29.Text = "Name :"
        '
        'txtEditSpouse
        '
        Me.txtEditSpouse.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditSpouse.Border.Class = "TextBoxBorder"
        Me.txtEditSpouse.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditSpouse.ForeColor = System.Drawing.Color.Black
        Me.txtEditSpouse.Location = New System.Drawing.Point(123, 401)
        Me.txtEditSpouse.Name = "txtEditSpouse"
        Me.txtEditSpouse.Size = New System.Drawing.Size(223, 27)
        Me.txtEditSpouse.TabIndex = 9
        '
        'LabelX30
        '
        Me.LabelX30.AutoSize = True
        '
        '
        '
        Me.LabelX30.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX30.ForeColor = System.Drawing.Color.Black
        Me.LabelX30.Location = New System.Drawing.Point(12, 75)
        Me.LabelX30.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX30.Name = "LabelX30"
        Me.LabelX30.Size = New System.Drawing.Size(93, 22)
        Me.LabelX30.TabIndex = 216
        Me.LabelX30.Text = "Father Name :"
        '
        'LabelX31
        '
        Me.LabelX31.AutoSize = True
        '
        '
        '
        Me.LabelX31.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX31.ForeColor = System.Drawing.Color.Black
        Me.LabelX31.Location = New System.Drawing.Point(12, 294)
        Me.LabelX31.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX31.Name = "LabelX31"
        Me.LabelX31.Size = New System.Drawing.Size(57, 22)
        Me.LabelX31.TabIndex = 217
        Me.LabelX31.Text = "Gender :"
        '
        'txtEditFather
        '
        Me.txtEditFather.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditFather.Border.Class = "TextBoxBorder"
        Me.txtEditFather.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditFather.ForeColor = System.Drawing.Color.Black
        Me.txtEditFather.Location = New System.Drawing.Point(123, 73)
        Me.txtEditFather.Name = "txtEditFather"
        Me.txtEditFather.Size = New System.Drawing.Size(223, 27)
        Me.txtEditFather.TabIndex = 1
        '
        'LabelX32
        '
        Me.LabelX32.AutoSize = True
        '
        '
        '
        Me.LabelX32.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX32.ForeColor = System.Drawing.Color.Black
        Me.LabelX32.Location = New System.Drawing.Point(12, 111)
        Me.LabelX32.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX32.Name = "LabelX32"
        Me.LabelX32.Size = New System.Drawing.Size(100, 22)
        Me.LabelX32.TabIndex = 221
        Me.LabelX32.Text = "Mother Name :"
        '
        'txtEditMother
        '
        Me.txtEditMother.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditMother.Border.Class = "TextBoxBorder"
        Me.txtEditMother.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditMother.ForeColor = System.Drawing.Color.Black
        Me.txtEditMother.Location = New System.Drawing.Point(123, 109)
        Me.txtEditMother.Name = "txtEditMother"
        Me.txtEditMother.Size = New System.Drawing.Size(223, 27)
        Me.txtEditMother.TabIndex = 2
        '
        'LabelX34
        '
        Me.LabelX34.AutoSize = True
        '
        '
        '
        Me.LabelX34.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX34.ForeColor = System.Drawing.Color.Black
        Me.LabelX34.Location = New System.Drawing.Point(12, 145)
        Me.LabelX34.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX34.Name = "LabelX34"
        Me.LabelX34.Size = New System.Drawing.Size(74, 22)
        Me.LabelX34.TabIndex = 216
        Me.LabelX34.Text = "Address 1 :"
        '
        'LabelX35
        '
        Me.LabelX35.AutoSize = True
        '
        '
        '
        Me.LabelX35.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX35.ForeColor = System.Drawing.Color.Black
        Me.LabelX35.Location = New System.Drawing.Point(12, 257)
        Me.LabelX35.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX35.Name = "LabelX35"
        Me.LabelX35.Size = New System.Drawing.Size(92, 22)
        Me.LabelX35.TabIndex = 217
        Me.LabelX35.Text = "Date of Birth :"
        '
        'txtEditAddress1
        '
        Me.txtEditAddress1.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtEditAddress1.Border.Class = "TextBoxBorder"
        Me.txtEditAddress1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEditAddress1.ForeColor = System.Drawing.Color.Black
        Me.txtEditAddress1.Location = New System.Drawing.Point(123, 145)
        Me.txtEditAddress1.Multiline = True
        Me.txtEditAddress1.Name = "txtEditAddress1"
        Me.txtEditAddress1.Size = New System.Drawing.Size(223, 46)
        Me.txtEditAddress1.TabIndex = 3
        '
        'panEditButton
        '
        Me.panEditButton.BackColor = System.Drawing.Color.Transparent
        Me.panEditButton.Controls.Add(Me.btnEditCancel)
        Me.panEditButton.Controls.Add(Me.btnUpdate)
        Me.panEditButton.ForeColor = System.Drawing.Color.Black
        Me.panEditButton.Location = New System.Drawing.Point(393, 490)
        Me.panEditButton.Name = "panEditButton"
        Me.panEditButton.Size = New System.Drawing.Size(150, 36)
        Me.panEditButton.TabIndex = 306
        '
        'btnEditCancel
        '
        Me.btnEditCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnEditCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEditCancel.FocusCuesEnabled = False
        Me.btnEditCancel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnEditCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnEditCancel.Location = New System.Drawing.Point(75, 0)
        Me.btnEditCancel.Name = "btnEditCancel"
        Me.btnEditCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnEditCancel.Size = New System.Drawing.Size(75, 36)
        Me.btnEditCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnEditCancel.Symbol = ""
        Me.btnEditCancel.TabIndex = 1
        Me.btnEditCancel.Text = "Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnUpdate.FocusCuesEnabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnUpdate.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnUpdate.Location = New System.Drawing.Point(0, 0)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnUpdate.Size = New System.Drawing.Size(70, 36)
        Me.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnUpdate.Symbol = ""
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        '
        'panToken
        '
        Me.panToken.CanvasColor = System.Drawing.SystemColors.Control
        Me.panToken.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panToken.Controls.Add(Me.Label2)
        Me.panToken.Location = New System.Drawing.Point(18, 4)
        Me.panToken.Name = "panToken"
        Me.panToken.Size = New System.Drawing.Size(687, 39)
        Me.panToken.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panToken.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panToken.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panToken.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panToken.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panToken.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panToken.Style.GradientAngle = 90
        Me.panToken.TabIndex = 300
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 297
        Me.Label2.Text = "Existing Member"
        '
        'tabTokenList
        '
        Me.tabTokenList.AttachedControl = Me.SuperTabControlPanel1
        Me.tabTokenList.GlobalItem = False
        Me.tabTokenList.Image = CType(resources.GetObject("tabTokenList.Image"), System.Drawing.Image)
        Me.tabTokenList.ImageAlignment = DevComponents.DotNetBar.ImageAlignment.TopCenter
        Me.tabTokenList.Name = "tabTokenList"
        SuperTabItemStateColorTable3.Text = System.Drawing.Color.Black
        SuperTabColorStates3.Normal = SuperTabItemStateColorTable3
        SuperTabItemColorTable3.Default = SuperTabColorStates3
        Me.tabTokenList.TabColor = SuperTabItemColorTable3
        Me.tabTokenList.Text = "Existing Member"
        '
        'panProducts
        '
        Me.panProducts.CanvasColor = System.Drawing.SystemColors.Control
        Me.panProducts.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.panProducts.Controls.Add(Me.tabMain)
        Me.panProducts.Location = New System.Drawing.Point(12, 8)
        Me.panProducts.Name = "panProducts"
        Me.panProducts.Size = New System.Drawing.Size(919, 537)
        Me.panProducts.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panProducts.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panProducts.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panProducts.Style.BorderColor.Color = System.Drawing.Color.Black
        Me.panProducts.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panProducts.Style.GradientAngle = 90
        Me.panProducts.TabIndex = 286
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'colPritn
        '
        Me.colPritn.HeaderText = ""
        Me.colPritn.HoverImage = CType(resources.GetObject("colPritn.HoverImage"), System.Drawing.Image)
        Me.colPritn.Image = CType(resources.GetObject("colPritn.Image"), System.Drawing.Image)
        Me.colPritn.Name = "colPritn"
        Me.colPritn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPritn.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.colPritn.Text = Nothing
        Me.colPritn.Width = 28
        '
        'colID
        '
        Me.colID.HeaderText = "LM No"
        Me.colID.Name = "colID"
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colID.Width = 80
        '
        'colName
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colName.HeaderText = "Member Name"
        Me.colName.Name = "colName"
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colName.Width = 180
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAddress.HeaderText = "Bank Name"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewLabelXColumn4
        '
        Me.DataGridViewLabelXColumn4.HeaderText = "Designation"
        Me.DataGridViewLabelXColumn4.Name = "DataGridViewLabelXColumn4"
        Me.DataGridViewLabelXColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewLabelXColumn4.Width = 120
        '
        'colGender
        '
        Me.colGender.HeaderText = "Contact No"
        Me.colGender.Name = "colGender"
        Me.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colGender.Width = 120
        '
        'DataGridViewLabelXColumn5
        '
        Me.DataGridViewLabelXColumn5.HeaderText = "Email"
        Me.DataGridViewLabelXColumn5.Name = "DataGridViewLabelXColumn5"
        Me.DataGridViewLabelXColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewLabelXColumn5.Width = 180
        '
        'FrmMemberDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 548)
        Me.Controls.Add(Me.panProducts)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMemberDetails"
        Me.Text = "Member Details"
        CType(Me.tabMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMain.ResumeLayout(False)
        Me.tbPatient.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        CType(Me.dgvMemberList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panPatient.ResumeLayout(False)
        Me.panPatient.PerformLayout()
        Me.tbRecognize.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.panAddVisitDetails.ResumeLayout(False)
        Me.panAddVisitDetails.PerformLayout()
        Me.panImage.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panAddDetails.ResumeLayout(False)
        Me.panAddDetails.PerformLayout()
        Me.panExistTitle.ResumeLayout(False)
        Me.panExistTitle.PerformLayout()
        Me.panButton.ResumeLayout(False)
        Me.SuperTabControlPanel1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx3.PerformLayout()
        Me.panEditBankDetails.ResumeLayout(False)
        Me.panEditBankDetails.PerformLayout()
        Me.panEditImage.ResumeLayout(False)
        CType(Me.picEditImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panEditMemberDetails.ResumeLayout(False)
        Me.panEditMemberDetails.PerformLayout()
        Me.panEditButton.ResumeLayout(False)
        Me.panToken.ResumeLayout(False)
        Me.panToken.PerformLayout()
        Me.panProducts.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tbRecognize As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents tabExisting As DevComponents.DotNetBar.SuperTabItem
    Private WithEvents tbPatient As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents tabPatient As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents panProducts As DevComponents.DotNetBar.PanelEx
    Public WithEvents tabMain As DevComponents.DotNetBar.SuperTabControl
    Friend WithEvents txtSearch As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearch As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Private WithEvents SuperTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
    Private WithEvents tabTokenList As DevComponents.DotNetBar.SuperTabItem
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtFather As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtMother As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAddress1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDay As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPayment As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtSpouse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panExistTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panButton As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panToken As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents panPatient As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents panAddDetails As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblVisit As System.Windows.Forms.Label
    Friend WithEvents panAddVisitDetails As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblVisitDetails As System.Windows.Forms.Label
    Friend WithEvents txtAddress2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMemtype As System.Windows.Forms.ComboBox
    Friend WithEvents dtpMarriage As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents panImage As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX18 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX19 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX20 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDesignation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBranch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBank As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtNID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPassport As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtContact2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSearchEx As ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox
    Private WithEvents btnSearchEx As ComponentFactory.Krypton.Toolkit.ButtonSpecAny
    Friend WithEvents panEditBankDetails As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtEditEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEditPassport As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEditSecond As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEditContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpEditJoin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEditDesignation As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEditBranch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEditBank As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX15 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX16 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX17 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX21 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX22 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX23 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX24 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblProfession As System.Windows.Forms.Label
    Friend WithEvents panEditImage As DevComponents.DotNetBar.PanelEx
    Friend WithEvents btnEditClear As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnEditBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents picEditImage As System.Windows.Forms.PictureBox
    Friend WithEvents panEditMemberDetails As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtEditNID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX25 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX26 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX27 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpEditMarriage As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbEditType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEditSex As System.Windows.Forms.ComboBox
    Friend WithEvents dtpEditDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEditAddress2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX28 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblMemberDetails As System.Windows.Forms.Label
    Friend WithEvents txtEditName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX29 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEditSpouse As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX30 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX31 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEditFather As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX32 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX33 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEditMother As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX34 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX35 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtEditAddress1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panEditButton As System.Windows.Forms.Panel
    Friend WithEvents btnEditCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnUpdate As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX36 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbEditStatus As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX37 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgvMemberList As System.Windows.Forms.DataGridView
    Friend WithEvents colPritn As DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn
    Friend WithEvents colID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colAddress As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn4 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colGender As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents DataGridViewLabelXColumn5 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
