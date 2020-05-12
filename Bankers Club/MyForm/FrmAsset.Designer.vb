<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsset
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
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.txtDetails = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtInvoice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPurchase = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtDep = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.swPayment = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.dtpCheque = New System.Windows.Forms.DateTimePicker()
        Me.txtBank = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCheque = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPayment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX14 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.lblCheque = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnAdd = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.panPatient = New DevComponents.DotNetBar.PanelEx()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.txtName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbSupplier, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDetails, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtInvoice, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPurchase, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDate, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDep, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbType, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPayment, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBalance, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.swPayment, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpCheque, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBank, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCheque, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayment, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX14, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX7, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCheque, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdd, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX12, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX10, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX11, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX13, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX9, 0, 3)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 37)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(782, 294)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(128, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(223, 27)
        Me.txtName.TabIndex = 0
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.Color.White
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbSupplier.ForeColor = System.Drawing.Color.Black
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(519, 3)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(223, 28)
        Me.cmbSupplier.TabIndex = 1
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDetails.Border.Class = "TextBoxBorder"
        Me.txtDetails.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDetails.ForeColor = System.Drawing.Color.Black
        Me.txtDetails.Location = New System.Drawing.Point(128, 37)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(223, 27)
        Me.txtDetails.TabIndex = 2
        '
        'txtInvoice
        '
        Me.txtInvoice.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtInvoice.Border.Class = "TextBoxBorder"
        Me.txtInvoice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtInvoice.ForeColor = System.Drawing.Color.Black
        Me.txtInvoice.Location = New System.Drawing.Point(519, 37)
        Me.txtInvoice.Name = "txtInvoice"
        Me.txtInvoice.Size = New System.Drawing.Size(223, 27)
        Me.txtInvoice.TabIndex = 3
        '
        'txtPurchase
        '
        Me.txtPurchase.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPurchase.Border.Class = "TextBoxBorder"
        Me.txtPurchase.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchase.ForeColor = System.Drawing.Color.Black
        Me.txtPurchase.Location = New System.Drawing.Point(128, 70)
        Me.txtPurchase.Name = "txtPurchase"
        Me.txtPurchase.Size = New System.Drawing.Size(223, 27)
        Me.txtPurchase.TabIndex = 4
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.White
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(519, 70)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(223, 27)
        Me.dtpDate.TabIndex = 5
        '
        'txtDep
        '
        Me.txtDep.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDep.Border.Class = "TextBoxBorder"
        Me.txtDep.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDep.ForeColor = System.Drawing.Color.Black
        Me.txtDep.Location = New System.Drawing.Point(128, 103)
        Me.txtDep.Name = "txtDep"
        Me.txtDep.Size = New System.Drawing.Size(223, 27)
        Me.txtDep.TabIndex = 6
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Land", "Plant/Equipment", "Furnitures", "Machineries", "Other non Current Assets"})
        Me.cmbType.Location = New System.Drawing.Point(519, 103)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(223, 28)
        Me.cmbType.TabIndex = 7
        '
        'cmbPayment
        '
        Me.cmbPayment.BackColor = System.Drawing.Color.White
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbPayment.ForeColor = System.Drawing.Color.Black
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Location = New System.Drawing.Point(128, 157)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(223, 28)
        Me.cmbPayment.TabIndex = 8
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBalance.Border.Class = "TextBoxBorder"
        Me.txtBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBalance.Enabled = False
        Me.txtBalance.ForeColor = System.Drawing.Color.Black
        Me.txtBalance.Location = New System.Drawing.Point(519, 157)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(223, 27)
        Me.txtBalance.TabIndex = 9
        '
        'swPayment
        '
        Me.swPayment.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.swPayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swPayment.ForeColor = System.Drawing.Color.Black
        Me.swPayment.Location = New System.Drawing.Point(129, 193)
        Me.swPayment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.swPayment.Name = "swPayment"
        Me.swPayment.OffBackColor = System.Drawing.Color.Transparent
        Me.swPayment.OffText = "Cheque"
        Me.swPayment.OnText = "Cash"
        Me.swPayment.Size = New System.Drawing.Size(134, 27)
        Me.swPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swPayment.SwitchBackColor = System.Drawing.Color.DarkSlateGray
        Me.swPayment.SwitchWidth = 55
        Me.swPayment.TabIndex = 10
        '
        'dtpCheque
        '
        Me.dtpCheque.BackColor = System.Drawing.Color.White
        Me.dtpCheque.CustomFormat = "dd MMM yyyy"
        Me.dtpCheque.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpCheque.ForeColor = System.Drawing.Color.Black
        Me.dtpCheque.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheque.Location = New System.Drawing.Point(519, 191)
        Me.dtpCheque.Name = "dtpCheque"
        Me.dtpCheque.Size = New System.Drawing.Size(223, 27)
        Me.dtpCheque.TabIndex = 11
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtBank.Border.Class = "TextBoxBorder"
        Me.txtBank.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBank.ForeColor = System.Drawing.Color.Black
        Me.txtBank.Location = New System.Drawing.Point(128, 228)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(223, 27)
        Me.txtBank.TabIndex = 12
        '
        'txtCheque
        '
        Me.txtCheque.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCheque.Border.Class = "TextBoxBorder"
        Me.txtCheque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCheque.ForeColor = System.Drawing.Color.Black
        Me.txtCheque.Location = New System.Drawing.Point(519, 228)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(223, 27)
        Me.txtCheque.TabIndex = 13
        '
        'txtPayment
        '
        Me.txtPayment.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPayment.Border.Class = "TextBoxBorder"
        Me.txtPayment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPayment.ForeColor = System.Drawing.Color.Black
        Me.txtPayment.Location = New System.Drawing.Point(128, 261)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(223, 27)
        Me.txtPayment.TabIndex = 14
        '
        'LabelX14
        '
        Me.LabelX14.AutoSize = True
        '
        '
        '
        Me.LabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX14.ForeColor = System.Drawing.Color.Black
        Me.LabelX14.Location = New System.Drawing.Point(406, 104)
        Me.LabelX14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX14.Name = "LabelX14"
        Me.LabelX14.Size = New System.Drawing.Size(79, 22)
        Me.LabelX14.TabIndex = 301
        Me.LabelX14.Text = "Asset Type :"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(406, 229)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(83, 22)
        Me.LabelX7.TabIndex = 218
        Me.LabelX7.Text = "Cheque No :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 229)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(84, 22)
        Me.LabelX5.TabIndex = 218
        Me.LabelX5.Text = "Bank Name :"
        '
        'lblCheque
        '
        Me.lblCheque.AutoSize = True
        '
        '
        '
        Me.lblCheque.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblCheque.ForeColor = System.Drawing.Color.Black
        Me.lblCheque.Location = New System.Drawing.Point(406, 192)
        Me.lblCheque.Margin = New System.Windows.Forms.Padding(4)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(94, 22)
        Me.lblCheque.TabIndex = 222
        Me.lblCheque.Text = "Cheque Date :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 192)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(109, 22)
        Me.LabelX2.TabIndex = 217
        Me.LabelX2.Text = "Collection Type :"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 22)
        Me.LabelX1.TabIndex = 208
        Me.LabelX1.Text = "Name :"
        '
        'btnAdd
        '
        Me.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FocusCuesEnabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnAdd.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnAdd.Location = New System.Drawing.Point(748, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnAdd.Size = New System.Drawing.Size(33, 28)
        Me.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnAdd.Symbol = ""
        Me.btnAdd.TabIndex = 219
        Me.btnAdd.Tooltip = "Add Type"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        Me.LabelX6.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 38)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(53, 22)
        Me.LabelX6.TabIndex = 219
        Me.LabelX6.Text = "Details :"
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(406, 71)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(102, 22)
        Me.LabelX12.TabIndex = 220
        Me.LabelX12.Text = "Purchase Date :"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        Me.LabelX10.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(406, 38)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(79, 22)
        Me.LabelX10.TabIndex = 217
        Me.LabelX10.Text = "Invoice No :"
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        Me.LabelX11.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(406, 4)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(106, 22)
        Me.LabelX11.TabIndex = 217
        Me.LabelX11.Text = "Supplier Name :"
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(4, 158)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(108, 22)
        Me.LabelX13.TabIndex = 216
        Me.LabelX13.Text = "Payment Mode :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(406, 158)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(90, 22)
        Me.LabelX3.TabIndex = 209
        Me.LabelX3.Text = "Balance Amt :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 262)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(66, 22)
        Me.LabelX4.TabIndex = 217
        Me.LabelX4.Text = "Payment :"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        Me.LabelX8.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(4, 71)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(108, 22)
        Me.LabelX8.TabIndex = 223
        Me.LabelX8.Text = "Purchase Value :"
        '
        'LabelX9
        '
        Me.LabelX9.AutoSize = True
        Me.LabelX9.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.ForeColor = System.Drawing.Color.Black
        Me.LabelX9.Location = New System.Drawing.Point(4, 104)
        Me.LabelX9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(117, 22)
        Me.LabelX9.TabIndex = 223
        Me.LabelX9.Text = "Depreciation (%) :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(594, 334)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 36)
        Me.Panel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.Location = New System.Drawing.Point(88, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(80, 36)
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
        Me.btnSave.Size = New System.Drawing.Size(80, 36)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.Symbol = ""
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "OK"
        '
        'panPatient
        '
        Me.panPatient.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPatient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPatient.Controls.Add(Me.Label1)
        Me.panPatient.Location = New System.Drawing.Point(20, -13)
        Me.panPatient.Name = "panPatient"
        Me.panPatient.Size = New System.Drawing.Size(782, 39)
        Me.panPatient.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPatient.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panPatient.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPatient.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panPatient.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panPatient.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPatient.Style.GradientAngle = 90
        Me.panPatient.TabIndex = 300
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
        Me.Label1.Size = New System.Drawing.Size(101, 25)
        Me.Label1.TabIndex = 297
        Me.Label1.Text = "Fixed Asset"
        '
        'FrmAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 384)
        Me.Controls.Add(Me.panPatient)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsset"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.panPatient.ResumeLayout(False)
        Me.panPatient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDetails As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbPayment As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swPayment As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents lblCheque As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpCheque As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBank As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCheque As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPayment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPurchase As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents panPatient As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInvoice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDep As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX14 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
End Class
