<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSalesReturnPayment
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
        Me.lblPaidTK = New DevComponents.DotNetBar.LabelX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiscount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblPaid = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtChange = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtReceive = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.lblTotal = New DevComponents.DotNetBar.LabelX()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'lblPaidTK
        '
        Me.lblPaidTK.AutoSize = True
        '
        '
        '
        Me.lblPaidTK.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPaidTK.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPaidTK.ForeColor = System.Drawing.Color.Black
        Me.lblPaidTK.Location = New System.Drawing.Point(114, 4)
        Me.lblPaidTK.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPaidTK.Name = "lblPaidTK"
        Me.lblPaidTK.Size = New System.Drawing.Size(11, 22)
        Me.lblPaidTK.TabIndex = 218
        Me.lblPaidTK.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 25)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "_____________________________________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, -2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 26)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Sale Payment "
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
        Me.txtDiscount.Location = New System.Drawing.Point(113, 99)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(138, 27)
        Me.txtDiscount.TabIndex = 217
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        '
        '
        '
        Me.lblPaid.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblPaid.ForeColor = System.Drawing.Color.Black
        Me.lblPaid.Location = New System.Drawing.Point(4, 4)
        Me.lblPaid.Margin = New System.Windows.Forms.Padding(4)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(94, 22)
        Me.lblPaid.TabIndex = 207
        Me.lblPaid.Text = "Paid Amount :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 34)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(94, 22)
        Me.LabelX3.TabIndex = 210
        Me.LabelX3.Text = "Cash Receive :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 67)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(94, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Cash Change :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 100)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(102, 22)
        Me.LabelX5.TabIndex = 213
        Me.LabelX5.Text = "Cash Discount :"
        '
        'txtChange
        '
        Me.txtChange.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtChange.Border.Class = "TextBoxBorder"
        Me.txtChange.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtChange.Enabled = False
        Me.txtChange.ForeColor = System.Drawing.Color.Black
        Me.txtChange.Location = New System.Drawing.Point(113, 66)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(138, 27)
        Me.txtChange.TabIndex = 3
        '
        'txtReceive
        '
        Me.txtReceive.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtReceive.Border.Class = "TextBoxBorder"
        Me.txtReceive.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReceive.ForeColor = System.Drawing.Color.Black
        Me.txtReceive.Location = New System.Drawing.Point(113, 33)
        Me.txtReceive.Name = "txtReceive"
        Me.txtReceive.Size = New System.Drawing.Size(138, 27)
        Me.txtReceive.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.lblPaidTK, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtReceive, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtChange, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX5, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPaid, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDiscount, 1, 3)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(37, 51)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(266, 133)
        Me.TableLayoutPanel2.TabIndex = 213
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.TableLayoutPanel2)
        Me.PanelEx1.Controls.Add(Me.Panel1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(344, 245)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.PanelEx1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 219
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButtonX1)
        Me.Panel1.Controls.Add(Me.ButtonX2)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(120, 191)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 36)
        Me.Panel1.TabIndex = 216
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonX1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonX1.FocusCuesEnabled = False
        Me.ButtonX1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonX1.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX1.Location = New System.Drawing.Point(88, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX1.Size = New System.Drawing.Size(80, 36)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ButtonX1.Symbol = ""
        Me.ButtonX1.TabIndex = 1
        Me.ButtonX1.Text = "Cancel"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonX2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ButtonX2.FocusCuesEnabled = False
        Me.ButtonX2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.ButtonX2.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonX2.Size = New System.Drawing.Size(80, 36)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.ButtonX2.Symbol = ""
        Me.ButtonX2.TabIndex = 0
        Me.ButtonX2.Text = "Accept"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.PanelEx2.Controls.Add(Me.lblTotal)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx2.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(344, 44)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.DoubleLine
        Me.PanelEx2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 217
        '
        'lblTotal
        '
        '
        '
        '
        Me.lblTotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTotal.Font = New System.Drawing.Font("Hobo BT", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(37, 9)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(266, 27)
        Me.lblTotal.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.lblTotal.TabIndex = 216
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'FrmSalesReturnPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 245)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSalesReturnPayment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Payment"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.PanelEx1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents lblPaidTK As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtReceive As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtChange As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblPaid As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtDiscount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblTotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
