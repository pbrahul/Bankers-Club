<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayment
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
        Me.swPayment = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.dtpIssue = New System.Windows.Forms.DateTimePicker()
        Me.lblIssue = New DevComponents.DotNetBar.LabelX()
        Me.txtAcBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPayment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtDiscount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.txtAccounts = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX13 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtCheque = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCarrier = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX11 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX12 = New DevComponents.DotNetBar.LabelX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'swPayment
        '
        Me.swPayment.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.swPayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swPayment.ForeColor = System.Drawing.Color.Black
        Me.swPayment.Location = New System.Drawing.Point(116, 125)
        Me.swPayment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.swPayment.Name = "swPayment"
        Me.swPayment.OffBackColor = System.Drawing.Color.Transparent
        Me.swPayment.OffText = "Cheque"
        Me.swPayment.OnText = "Cash"
        Me.swPayment.Size = New System.Drawing.Size(134, 27)
        Me.swPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swPayment.SwitchBackColor = System.Drawing.Color.DarkSlateGray
        Me.swPayment.SwitchWidth = 55
        Me.swPayment.TabIndex = 5
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFrom, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpIssue, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblIssue, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAcBalance, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.swPayment, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayment, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDiscount, 4, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRemarks, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX8, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAccounts, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBalance, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX13, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCheque, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCarrier, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX11, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX10, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX12, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dtpDate, 1, 2)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 30)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(695, 256)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cmbFrom
        '
        Me.cmbFrom.BackColor = System.Drawing.Color.White
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbFrom.ForeColor = System.Drawing.Color.Black
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(115, 3)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(223, 28)
        Me.cmbFrom.TabIndex = 216
        '
        'dtpIssue
        '
        Me.dtpIssue.BackColor = System.Drawing.Color.White
        Me.dtpIssue.CustomFormat = "dd MMM yyyy"
        Me.dtpIssue.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpIssue.ForeColor = System.Drawing.Color.Black
        Me.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIssue.Location = New System.Drawing.Point(462, 123)
        Me.dtpIssue.Name = "dtpIssue"
        Me.dtpIssue.Size = New System.Drawing.Size(223, 27)
        Me.dtpIssue.TabIndex = 216
        '
        'lblIssue
        '
        Me.lblIssue.AutoSize = True
        '
        '
        '
        Me.lblIssue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblIssue.ForeColor = System.Drawing.Color.Black
        Me.lblIssue.Location = New System.Drawing.Point(365, 124)
        Me.lblIssue.Margin = New System.Windows.Forms.Padding(4)
        Me.lblIssue.Name = "lblIssue"
        Me.lblIssue.Size = New System.Drawing.Size(76, 22)
        Me.lblIssue.TabIndex = 221
        Me.lblIssue.Text = "Issue Date :"
        '
        'txtAcBalance
        '
        Me.txtAcBalance.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAcBalance.Border.Class = "TextBoxBorder"
        Me.txtAcBalance.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAcBalance.Enabled = False
        Me.txtAcBalance.ForeColor = System.Drawing.Color.Black
        Me.txtAcBalance.Location = New System.Drawing.Point(462, 37)
        Me.txtAcBalance.Name = "txtAcBalance"
        Me.txtAcBalance.Size = New System.Drawing.Size(223, 27)
        Me.txtAcBalance.TabIndex = 3
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
        Me.txtPayment.Location = New System.Drawing.Point(115, 193)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(223, 27)
        Me.txtPayment.TabIndex = 8
        '
        'txtDiscount
        '
        Me.txtDiscount.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDiscount.Border.Class = "TextBoxBorder"
        Me.txtDiscount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDiscount.ForeColor = System.Drawing.Color.Black
        Me.txtDiscount.Location = New System.Drawing.Point(462, 193)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(223, 27)
        Me.txtDiscount.TabIndex = 9
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(115, 226)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(223, 27)
        Me.txtRemarks.TabIndex = 10
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
        Me.LabelX1.Size = New System.Drawing.Size(104, 22)
        Me.LabelX1.TabIndex = 208
        Me.LabelX1.Text = "Cash Accounts :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 124)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(101, 22)
        Me.LabelX2.TabIndex = 216
        Me.LabelX2.Text = "Payment Type :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 194)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(66, 22)
        Me.LabelX4.TabIndex = 217
        Me.LabelX4.Text = "Payment :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(365, 194)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(67, 22)
        Me.LabelX5.TabIndex = 218
        Me.LabelX5.Text = "Discount :"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 227)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(65, 22)
        Me.LabelX6.TabIndex = 219
        Me.LabelX6.Text = "Remarks :"
        '
        'LabelX8
        '
        Me.LabelX8.AutoSize = True
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.ForeColor = System.Drawing.Color.Black
        Me.LabelX8.Location = New System.Drawing.Point(365, 38)
        Me.LabelX8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(90, 22)
        Me.LabelX8.TabIndex = 221
        Me.LabelX8.Text = "Balance Amt :"
        '
        'txtAccounts
        '
        Me.txtAccounts.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAccounts.Border.Class = "TextBoxBorder"
        Me.txtAccounts.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAccounts.ForeColor = System.Drawing.Color.Black
        Me.txtAccounts.Location = New System.Drawing.Point(115, 37)
        Me.txtAccounts.Name = "txtAccounts"
        Me.txtAccounts.Size = New System.Drawing.Size(223, 27)
        Me.txtAccounts.TabIndex = 223
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
        Me.txtBalance.Location = New System.Drawing.Point(462, 3)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(223, 27)
        Me.txtBalance.TabIndex = 1
        '
        'LabelX13
        '
        Me.LabelX13.AutoSize = True
        '
        '
        '
        Me.LabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX13.ForeColor = System.Drawing.Color.Black
        Me.LabelX13.Location = New System.Drawing.Point(4, 38)
        Me.LabelX13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX13.Name = "LabelX13"
        Me.LabelX13.Size = New System.Drawing.Size(86, 22)
        Me.LabelX13.TabIndex = 216
        Me.LabelX13.Text = "Payment To :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(365, 4)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(90, 22)
        Me.LabelX3.TabIndex = 209
        Me.LabelX3.Text = "Balance Amt :"
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
        Me.txtCheque.Location = New System.Drawing.Point(115, 160)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(223, 27)
        Me.txtCheque.TabIndex = 7
        '
        'txtCarrier
        '
        Me.txtCarrier.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCarrier.Border.Class = "TextBoxBorder"
        Me.txtCarrier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCarrier.ForeColor = System.Drawing.Color.Black
        Me.txtCarrier.Location = New System.Drawing.Point(462, 160)
        Me.txtCarrier.Name = "txtCarrier"
        Me.txtCarrier.Size = New System.Drawing.Size(223, 27)
        Me.txtCarrier.TabIndex = 6
        '
        'LabelX11
        '
        Me.LabelX11.AutoSize = True
        '
        '
        '
        Me.LabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX11.ForeColor = System.Drawing.Color.Black
        Me.LabelX11.Location = New System.Drawing.Point(365, 161)
        Me.LabelX11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX11.Name = "LabelX11"
        Me.LabelX11.Size = New System.Drawing.Size(53, 22)
        Me.LabelX11.TabIndex = 217
        Me.LabelX11.Text = "Carrier :"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(4, 161)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(83, 22)
        Me.LabelX10.TabIndex = 217
        Me.LabelX10.Text = "Cheque No :"
        '
        'LabelX12
        '
        Me.LabelX12.AutoSize = True
        '
        '
        '
        Me.LabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX12.ForeColor = System.Drawing.Color.Black
        Me.LabelX12.Location = New System.Drawing.Point(4, 71)
        Me.LabelX12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX12.Name = "LabelX12"
        Me.LabelX12.Size = New System.Drawing.Size(100, 22)
        Me.LabelX12.TabIndex = 220
        Me.LabelX12.Text = "Payment Date :"
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.White
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(115, 70)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(223, 27)
        Me.dtpDate.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, -5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 26)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Receive / Collection"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(700, 25)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "_________________________________________________________________________________" & _
    "_____"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(537, 294)
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
        'FrmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 340)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents swPayment As DevComponents.DotNetBar.Controls.SwitchButton
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPayment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtAcBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCarrier As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX11 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCheque As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX12 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX13 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtAccounts As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtpIssue As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblIssue As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
End Class
