<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPurchasePayment
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.lblGrandTotalAmt = New DevComponents.DotNetBar.LabelX()
        Me.lblDueAmt = New DevComponents.DotNetBar.LabelX()
        Me.lblPurchaseAmt = New DevComponents.DotNetBar.LabelX()
        Me.lblPurchase = New DevComponents.DotNetBar.LabelX()
        Me.lblDue = New DevComponents.DotNetBar.LabelX()
        Me.lblGrandTotal = New DevComponents.DotNetBar.LabelX()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.swPayment = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtPayment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCheque = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX10 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtDiscount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Panel2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(213, 323)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 36)
        Me.Panel2.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
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
        Me.btnSave.Text = "Accept"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelEx1.Controls.Add(Me.Panel2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(416, 369)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.PanelEx2.Controls.Add(Me.lblGrandTotalAmt)
        Me.PanelEx2.Controls.Add(Me.lblDueAmt)
        Me.PanelEx2.Controls.Add(Me.lblPurchaseAmt)
        Me.PanelEx2.Controls.Add(Me.lblPurchase)
        Me.PanelEx2.Controls.Add(Me.lblDue)
        Me.PanelEx2.Controls.Add(Me.lblGrandTotal)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(416, 76)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'lblGrandTotalAmt
        '
        '
        '
        '
        Me.lblGrandTotalAmt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGrandTotalAmt.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotalAmt.ForeColor = System.Drawing.Color.Black
        Me.lblGrandTotalAmt.Location = New System.Drawing.Point(232, 5)
        Me.lblGrandTotalAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGrandTotalAmt.Name = "lblGrandTotalAmt"
        Me.lblGrandTotalAmt.Size = New System.Drawing.Size(147, 24)
        Me.lblGrandTotalAmt.TabIndex = 223
        Me.lblGrandTotalAmt.Text = "0.00"
        '
        'lblDueAmt
        '
        '
        '
        '
        Me.lblDueAmt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDueAmt.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.lblDueAmt.ForeColor = System.Drawing.Color.Black
        Me.lblDueAmt.Location = New System.Drawing.Point(232, 49)
        Me.lblDueAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDueAmt.Name = "lblDueAmt"
        Me.lblDueAmt.Size = New System.Drawing.Size(147, 24)
        Me.lblDueAmt.TabIndex = 222
        Me.lblDueAmt.Text = "0.00"
        '
        'lblPurchaseAmt
        '
        '
        '
        '
        Me.lblPurchaseAmt.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPurchaseAmt.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.lblPurchaseAmt.ForeColor = System.Drawing.Color.Black
        Me.lblPurchaseAmt.Location = New System.Drawing.Point(232, 28)
        Me.lblPurchaseAmt.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPurchaseAmt.Name = "lblPurchaseAmt"
        Me.lblPurchaseAmt.Size = New System.Drawing.Size(147, 24)
        Me.lblPurchaseAmt.TabIndex = 221
        Me.lblPurchaseAmt.Text = "0.00"
        '
        'lblPurchase
        '
        Me.lblPurchase.AutoSize = True
        '
        '
        '
        Me.lblPurchase.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPurchase.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.lblPurchase.ForeColor = System.Drawing.Color.Black
        Me.lblPurchase.Location = New System.Drawing.Point(102, 31)
        Me.lblPurchase.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(120, 19)
        Me.lblPurchase.TabIndex = 219
        Me.lblPurchase.Text = "Purchase Amount :"
        Me.lblPurchase.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'lblDue
        '
        Me.lblDue.AutoSize = True
        '
        '
        '
        Me.lblDue.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblDue.Font = New System.Drawing.Font("Tahoma", 10.5!)
        Me.lblDue.ForeColor = System.Drawing.Color.Black
        Me.lblDue.Location = New System.Drawing.Point(133, 52)
        Me.lblDue.Margin = New System.Windows.Forms.Padding(4)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(89, 19)
        Me.lblDue.TabIndex = 220
        Me.lblDue.Text = "Due Amount :"
        Me.lblDue.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        '
        '
        '
        Me.lblGrandTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblGrandTotal.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lblGrandTotal.Location = New System.Drawing.Point(89, 4)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(133, 29)
        Me.lblGrandTotal.TabIndex = 220
        Me.lblGrandTotal.Text = "Grand Total :"
        Me.lblGrandTotal.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.swPayment, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbFrom, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPayment, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCheque, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX10, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDiscount, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRemarks, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBalance, 1, 1)
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(37, 80)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(352, 240)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 71)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(101, 22)
        Me.LabelX2.TabIndex = 222
        Me.LabelX2.Text = "Payment Type :"
        '
        'swPayment
        '
        Me.swPayment.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.swPayment.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.swPayment.ForeColor = System.Drawing.Color.Black
        Me.swPayment.Location = New System.Drawing.Point(133, 72)
        Me.swPayment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.swPayment.Name = "swPayment"
        Me.swPayment.OffBackColor = System.Drawing.Color.Transparent
        Me.swPayment.OffText = "Cheque"
        Me.swPayment.OnText = "Cash"
        Me.swPayment.Size = New System.Drawing.Size(134, 27)
        Me.swPayment.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.swPayment.SwitchBackColor = System.Drawing.Color.DarkSlateGray
        Me.swPayment.SwitchWidth = 55
        Me.swPayment.TabIndex = 2
        '
        'cmbFrom
        '
        Me.cmbFrom.BackColor = System.Drawing.Color.White
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbFrom.ForeColor = System.Drawing.Color.Black
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(132, 3)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(210, 28)
        Me.cmbFrom.TabIndex = 0
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
        Me.LabelX1.Text = "Payment From :"
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
        Me.txtPayment.Location = New System.Drawing.Point(132, 140)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(212, 27)
        Me.txtPayment.TabIndex = 4
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
        Me.txtCheque.Location = New System.Drawing.Point(132, 107)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(212, 27)
        Me.txtCheque.TabIndex = 3
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 141)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(66, 22)
        Me.LabelX4.TabIndex = 217
        Me.LabelX4.Text = "Payment :"
        '
        'LabelX10
        '
        Me.LabelX10.AutoSize = True
        '
        '
        '
        Me.LabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX10.ForeColor = System.Drawing.Color.Black
        Me.LabelX10.Location = New System.Drawing.Point(4, 108)
        Me.LabelX10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX10.Name = "LabelX10"
        Me.LabelX10.Size = New System.Drawing.Size(121, 22)
        Me.LabelX10.TabIndex = 217
        Me.LabelX10.Text = "Receipt / Cheque :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 38)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(116, 22)
        Me.LabelX3.TabIndex = 221
        Me.LabelX3.Text = "Balance Amount :"
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
        Me.txtDiscount.Location = New System.Drawing.Point(132, 173)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(212, 27)
        Me.txtDiscount.TabIndex = 5
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 174)
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
        Me.LabelX6.Location = New System.Drawing.Point(4, 207)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(65, 22)
        Me.LabelX6.TabIndex = 219
        Me.LabelX6.Text = "Remarks :"
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
        Me.txtRemarks.Location = New System.Drawing.Point(132, 206)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(212, 27)
        Me.txtRemarks.TabIndex = 6
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
        Me.txtBalance.Location = New System.Drawing.Point(132, 37)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(212, 27)
        Me.txtBalance.TabIndex = 1
        '
        'FrmPurchasePayment
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(416, 369)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPurchasePayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.Panel2.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPayment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCheque As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX10 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblGrandTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPurchase As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDue As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDiscount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblPurchaseAmt As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblGrandTotalAmt As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDueAmt As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents swPayment As DevComponents.DotNetBar.Controls.SwitchButton
End Class
