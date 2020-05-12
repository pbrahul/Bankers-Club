<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSales
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSales))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpUser = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lblLabour = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panButton = New System.Windows.Forms.Panel()
        Me.btnHold = New DevComponents.DotNetBar.ButtonX()
        Me.btnAccept = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New DevComponents.DotNetBar.Controls.ReflectionLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtMemo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dtpPurchase = New System.Windows.Forms.DateTimePicker()
        Me.txtCustBal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtBarcode = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblBarcode = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.txtCustomer = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBillAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.lblReach = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New DevComponents.DotNetBar.LabelX()
        Me.lblTime = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewTextBoxColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Product = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dscount = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.ColVat = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.ColSubTotal = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colPurchase = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.grpUser.SuspendLayout()
        Me.panButton.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUser
        '
        Me.grpUser.BackColor = System.Drawing.Color.White
        Me.grpUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.grpUser.Controls.Add(Me.lblLabour)
        Me.grpUser.Controls.Add(Me.Label6)
        Me.grpUser.Controls.Add(Me.panButton)
        Me.grpUser.Controls.Add(Me.Label1)
        Me.grpUser.Controls.Add(Me.dgvSales)
        Me.grpUser.Controls.Add(Me.lblVat)
        Me.grpUser.Controls.Add(Me.lblDiscount)
        Me.grpUser.Controls.Add(Me.lblSubTotal)
        Me.grpUser.Controls.Add(Me.Label4)
        Me.grpUser.Controls.Add(Me.Label3)
        Me.grpUser.Controls.Add(Me.Label2)
        Me.grpUser.Controls.Add(Me.lblGrandTotal)
        Me.grpUser.Controls.Add(Me.TableLayoutPanel1)
        Me.grpUser.Controls.Add(Me.cmbType)
        Me.grpUser.Location = New System.Drawing.Point(7, 13)
        Me.grpUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(924, 527)
        '
        '
        '
        Me.grpUser.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grpUser.Style.BackColorGradientAngle = 90
        Me.grpUser.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grpUser.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderBottomWidth = 1
        Me.grpUser.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grpUser.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderLeftWidth = 1
        Me.grpUser.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderRightWidth = 1
        Me.grpUser.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpUser.Style.BorderTopWidth = 1
        Me.grpUser.Style.CornerDiameter = 4
        Me.grpUser.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.grpUser.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grpUser.Style.TextColor = System.Drawing.Color.Black
        '
        '
        '
        Me.grpUser.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpUser.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpUser.TabIndex = 0
        '
        'lblLabour
        '
        Me.lblLabour.AutoSize = True
        Me.lblLabour.BackColor = System.Drawing.Color.Transparent
        Me.lblLabour.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabour.ForeColor = System.Drawing.Color.Black
        Me.lblLabour.Location = New System.Drawing.Point(107, 467)
        Me.lblLabour.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabour.Name = "lblLabour"
        Me.lblLabour.Size = New System.Drawing.Size(39, 17)
        Me.lblLabour.TabIndex = 308
        Me.lblLabour.Text = "0.00"
        Me.lblLabour.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLabour.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(11, 466)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 307
        Me.Label6.Text = "Labour :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'panButton
        '
        Me.panButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panButton.BackColor = System.Drawing.Color.Transparent
        Me.panButton.Controls.Add(Me.btnHold)
        Me.panButton.Controls.Add(Me.btnAccept)
        Me.panButton.Controls.Add(Me.btnCancel)
        Me.panButton.ForeColor = System.Drawing.Color.Black
        Me.panButton.Location = New System.Drawing.Point(565, 447)
        Me.panButton.Name = "panButton"
        Me.panButton.Size = New System.Drawing.Size(339, 72)
        Me.panButton.TabIndex = 301
        '
        'btnHold
        '
        Me.btnHold.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnHold.BackColor = System.Drawing.Color.Transparent
        Me.btnHold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHold.FocusCuesEnabled = False
        Me.btnHold.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnHold.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnHold.Location = New System.Drawing.Point(87, 5)
        Me.btnHold.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnHold.Size = New System.Drawing.Size(78, 61)
        Me.btnHold.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnHold.Symbol = ""
        Me.btnHold.SymbolSize = 22.0!
        Me.btnHold.TabIndex = 263
        Me.btnHold.Text = "Hold"
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAccept.BackColor = System.Drawing.Color.Transparent
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.FocusCuesEnabled = False
        Me.btnAccept.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnAccept.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnAccept.Location = New System.Drawing.Point(170, 5)
        Me.btnAccept.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnAccept.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.btnAccept.Size = New System.Drawing.Size(78, 61)
        Me.btnAccept.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnAccept.Symbol = ""
        Me.btnAccept.SymbolSize = 22.0!
        Me.btnAccept.TabIndex = 262
        Me.btnAccept.Text = "Accept"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnCancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.btnCancel.Location = New System.Drawing.Point(253, 5)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(78, 61)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.SymbolSize = 22.0!
        Me.btnCancel.TabIndex = 266
        Me.btnCancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(297, 450)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 24)
        Me.Label1.TabIndex = 252
        Me.Label1.Text = "Grand Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvSales
        '
        Me.dgvSales.AllowUserToAddRows = False
        Me.dgvSales.AllowUserToDeleteRows = False
        Me.dgvSales.AllowUserToResizeRows = False
        Me.dgvSales.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSales.CausesValidation = False
        Me.dgvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvSales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSales.ColumnHeadersHeight = 35
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Product, Me.Quantity, Me.DataGridViewTextBoxColumn2, Me.Price, Me.Dscount, Me.ColVat, Me.ColSubTotal, Me.colPurchase})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSales.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvSales.EnableHeadersVisualStyles = False
        Me.dgvSales.Location = New System.Drawing.Point(13, 83)
        Me.dgvSales.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvSales.MultiSelect = False
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvSales.RowHeadersVisible = False
        Me.dgvSales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.dgvSales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvSales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvSales.RowTemplate.Height = 35
        Me.dgvSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSales.ShowEditingIcon = False
        Me.dgvSales.Size = New System.Drawing.Size(891, 356)
        Me.dgvSales.TabIndex = 281
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.BackColor = System.Drawing.Color.Transparent
        Me.lblVat.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.Black
        Me.lblVat.Location = New System.Drawing.Point(107, 488)
        Me.lblVat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(39, 17)
        Me.lblVat.TabIndex = 260
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblDiscount.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Black
        Me.lblDiscount.Location = New System.Drawing.Point(107, 467)
        Me.lblDiscount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(39, 17)
        Me.lblDiscount.TabIndex = 259
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDiscount.Visible = False
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTotal.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Black
        Me.lblSubTotal.Location = New System.Drawing.Point(107, 445)
        Me.lblSubTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(39, 17)
        Me.lblSubTotal.TabIndex = 258
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 483)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 26)
        Me.Label4.TabIndex = 257
        Me.Label4.Text = "VAT :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 462)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 26)
        Me.Label3.TabIndex = 256
        Me.Label3.Text = "Discounts :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 440)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 26)
        Me.Label2.TabIndex = 255
        Me.Label2.Text = "Sub Total :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblGrandTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGrandTotal.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.lblGrandTotal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lblGrandTotal.Location = New System.Drawing.Point(297, 470)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(220, 49)
        Me.lblGrandTotal.TabIndex = 254
        Me.lblGrandTotal.Text = "0.00"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.txtMemo, 5, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpPurchase, 8, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCustBal, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 7, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX8, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBarcode, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBarcode, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCustomer, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBillAddress, 5, 1)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 5)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(891, 73)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtMemo
        '
        Me.txtMemo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtMemo.Border.Class = "TextBoxBorder"
        Me.txtMemo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMemo.ForeColor = System.Drawing.Color.Black
        Me.txtMemo.Location = New System.Drawing.Point(427, 37)
        Me.txtMemo.Name = "txtMemo"
        Me.txtMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMemo.Size = New System.Drawing.Size(213, 27)
        Me.txtMemo.TabIndex = 309
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(345, 38)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 22)
        Me.LabelX2.TabIndex = 308
        Me.LabelX2.Text = "Memo No :"
        '
        'dtpPurchase
        '
        Me.dtpPurchase.BackColor = System.Drawing.Color.White
        Me.dtpPurchase.CustomFormat = "dd MMM yyyy"
        Me.dtpPurchase.ForeColor = System.Drawing.Color.Black
        Me.dtpPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPurchase.Location = New System.Drawing.Point(666, 37)
        Me.dtpPurchase.Name = "dtpPurchase"
        Me.dtpPurchase.Size = New System.Drawing.Size(223, 27)
        Me.dtpPurchase.TabIndex = 302
        '
        'txtCustBal
        '
        Me.txtCustBal.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCustBal.Border.Class = "TextBoxBorder"
        Me.txtCustBal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustBal.Enabled = False
        Me.txtCustBal.ForeColor = System.Drawing.Color.Black
        Me.txtCustBal.Location = New System.Drawing.Point(666, 3)
        Me.txtCustBal.Name = "txtCustBal"
        Me.txtCustBal.Size = New System.Drawing.Size(223, 27)
        Me.txtCustBal.TabIndex = 304
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(587, 40)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(71, 22)
        Me.LabelX3.TabIndex = 283
        Me.LabelX3.Text = "Sale Date :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(586, 4)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(59, 22)
        Me.LabelX5.TabIndex = 303
        Me.LabelX5.Text = "Balance :"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(345, 4)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(72, 22)
        Me.LabelX8.TabIndex = 307
        Me.LabelX8.Text = "Customer :"
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBarcode.Border.Class = "TextBoxBorder"
        Me.txtBarcode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBarcode.Font = New System.Drawing.Font("Tahoma", 12.5!)
        Me.txtBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode.Location = New System.Drawing.Point(112, 39)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(247, 28)
        Me.txtBarcode.TabIndex = 283
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        '
        '
        '
        Me.lblBarcode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblBarcode.ForeColor = System.Drawing.Color.Black
        Me.lblBarcode.Location = New System.Drawing.Point(5, 40)
        Me.lblBarcode.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(98, 22)
        Me.lblBarcode.TabIndex = 282
        Me.lblBarcode.Text = "Product Code :"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(5, 6)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(56, 22)
        Me.LabelX1.TabIndex = 209
        Me.LabelX1.Text = "Sale To :"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FocusCuesEnabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnAdd.Location = New System.Drawing.Point(366, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnAdd.Size = New System.Drawing.Size(33, 28)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnAdd.Symbol = ""
        Me.btnAdd.TabIndex = 305
        Me.btnAdd.Tooltip = "Add Type"
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCustomer.Border.Class = "TextBoxBorder"
        Me.txtCustomer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustomer.ButtonCustom.Image = CType(resources.GetObject("txtCustomer.ButtonCustom.Image"), System.Drawing.Image)
        Me.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomer.ForeColor = System.Drawing.Color.Black
        Me.txtCustomer.Location = New System.Drawing.Point(111, 3)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(247, 27)
        Me.txtCustomer.TabIndex = 300
        Me.txtCustomer.WatermarkText = "Customers"
        '
        'txtBillAddress
        '
        Me.txtBillAddress.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBillAddress.Border.Class = "TextBoxBorder"
        Me.txtBillAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBillAddress.Enabled = False
        Me.txtBillAddress.ForeColor = System.Drawing.Color.Black
        Me.txtBillAddress.Location = New System.Drawing.Point(427, 3)
        Me.txtBillAddress.Name = "txtBillAddress"
        Me.txtBillAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBillAddress.Size = New System.Drawing.Size(213, 27)
        Me.txtBillAddress.TabIndex = 308
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Product Barcode", "Order No"})
        Me.cmbType.Location = New System.Drawing.Point(785, 214)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(119, 26)
        Me.cmbType.TabIndex = 305
        Me.cmbType.Visible = False
        '
        'lblReach
        '
        Me.lblReach.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblReach.BackColor = System.Drawing.Color.Transparent
        Me.lblReach.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReach.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReach.ForeColor = System.Drawing.Color.Black
        Me.lblReach.Location = New System.Drawing.Point(237, 539)
        Me.lblReach.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReach.Name = "lblReach"
        Me.lblReach.Size = New System.Drawing.Size(515, 38)
        Me.lblReach.TabIndex = 122
        Me.lblReach.Text = "A Product(s) Reached Its Critical Level !!!"
        Me.lblReach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReach.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 800
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDate.Font = New System.Drawing.Font("Hobo BT", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(819, 543)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(112, 31)
        Me.lblDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblDate.TabIndex = 124
        Me.lblDate.Text = "2015/09/02"
        Me.lblDate.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTime.Font = New System.Drawing.Font("Hobo BT", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTime.ForeColor = System.Drawing.Color.Black
        Me.lblTime.Location = New System.Drawing.Point(7, 546)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(125, 31)
        Me.lblTime.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblTime.TabIndex = 123
        Me.lblTime.Text = "11:32:34 PM"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Product
        '
        Me.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Product.DefaultCellStyle = DataGridViewCellStyle10
        Me.Product.HeaderText = "Product"
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        Me.Product.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Quantity
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle11
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Quantity.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Price
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Price.DefaultCellStyle = DataGridViewCellStyle12
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Dscount
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Dscount.DefaultCellStyle = DataGridViewCellStyle13
        Me.Dscount.HeaderText = "Discount"
        Me.Dscount.Name = "Dscount"
        Me.Dscount.ReadOnly = True
        Me.Dscount.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dscount.Visible = False
        '
        'ColVat
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColVat.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColVat.HeaderText = "Vat"
        Me.ColVat.Name = "ColVat"
        Me.ColVat.ReadOnly = True
        Me.ColVat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColVat.Visible = False
        Me.ColVat.Width = 80
        '
        'ColSubTotal
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ColSubTotal.DefaultCellStyle = DataGridViewCellStyle15
        Me.ColSubTotal.HeaderText = "Sub Total"
        Me.ColSubTotal.Name = "ColSubTotal"
        Me.ColSubTotal.ReadOnly = True
        Me.ColSubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColSubTotal.Width = 120
        '
        'colPurchase
        '
        Me.colPurchase.HeaderText = "Purchase Price"
        Me.colPurchase.Name = "colPurchase"
        Me.colPurchase.Visible = False
        '
        'FrmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 574)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblReach)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.grpUser)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSales"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Sales"
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.panButton.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpUser As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblGrandTotal As DevComponents.DotNetBar.Controls.ReflectionLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblVat As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAccept As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnHold As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents lblReach As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents dgvSales As System.Windows.Forms.DataGridView
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDate As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblTime As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBarcode As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCustomer As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents panButton As System.Windows.Forms.Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCustBal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpPurchase As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblBarcode As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBillAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblLabour As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMemo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewTextBoxColumn1 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Product As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dscount As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents ColVat As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents ColSubTotal As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colPurchase As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
