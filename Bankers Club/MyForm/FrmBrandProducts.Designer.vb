<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrandProducts
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtReorder = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSalePrice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPurchasePrice = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.btnMeasure = New DevComponents.DotNetBar.ButtonX()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.cmbCategory, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtName, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbUnit, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX4, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtReorder, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSalePrice, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPurchasePrice, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX6, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX7, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX5, 0, 4)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(25, 39)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(337, 204)
        Me.TableLayoutPanel2.TabIndex = 0
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
        Me.txtName.Location = New System.Drawing.Point(114, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 27)
        Me.txtName.TabIndex = 1
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.Color.White
        Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbUnit.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbUnit.ForeColor = System.Drawing.Color.Black
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(115, 73)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(178, 28)
        Me.cmbUnit.TabIndex = 2
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 73)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(99, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Measurement :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 40)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(103, 22)
        Me.LabelX3.TabIndex = 210
        Me.LabelX3.Text = "Product Name :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 4)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(68, 22)
        Me.LabelX2.TabIndex = 207
        Me.LabelX2.Text = "Category :"
        '
        'txtReorder
        '
        Me.txtReorder.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtReorder.Border.Class = "TextBoxBorder"
        Me.txtReorder.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtReorder.ForeColor = System.Drawing.Color.Black
        Me.txtReorder.Location = New System.Drawing.Point(114, 174)
        Me.txtReorder.Name = "txtReorder"
        Me.txtReorder.Size = New System.Drawing.Size(216, 27)
        Me.txtReorder.TabIndex = 6
        '
        'txtSalePrice
        '
        Me.txtSalePrice.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtSalePrice.Border.Class = "TextBoxBorder"
        Me.txtSalePrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSalePrice.ForeColor = System.Drawing.Color.Black
        Me.txtSalePrice.Location = New System.Drawing.Point(114, 141)
        Me.txtSalePrice.Name = "txtSalePrice"
        Me.txtSalePrice.Size = New System.Drawing.Size(216, 27)
        Me.txtSalePrice.TabIndex = 5
        '
        'txtPurchasePrice
        '
        Me.txtPurchasePrice.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPurchasePrice.Border.Class = "TextBoxBorder"
        Me.txtPurchasePrice.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPurchasePrice.ForeColor = System.Drawing.Color.Black
        Me.txtPurchasePrice.Location = New System.Drawing.Point(114, 108)
        Me.txtPurchasePrice.Name = "txtPurchasePrice"
        Me.txtPurchasePrice.Size = New System.Drawing.Size(216, 27)
        Me.txtPurchasePrice.TabIndex = 4
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 175)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(99, 22)
        Me.LabelX6.TabIndex = 214
        Me.LabelX6.Text = "Reorder Point :"
        '
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(4, 142)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(78, 22)
        Me.LabelX7.TabIndex = 216
        Me.LabelX7.Text = "Sales Price :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 109)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(103, 22)
        Me.LabelX5.TabIndex = 213
        Me.LabelX5.Text = "Purchase Price :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, -2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 26)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Products Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(340, 25)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "_________________________________________"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(187, 250)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 36)
        Me.Panel1.TabIndex = 2
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
        Me.btnSave.Text = "Save"
        '
        'btnMeasure
        '
        Me.btnMeasure.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnMeasure.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMeasure.FocusCuesEnabled = False
        Me.btnMeasure.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnMeasure.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnMeasure.Location = New System.Drawing.Point(322, 109)
        Me.btnMeasure.Name = "btnMeasure"
        Me.btnMeasure.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnMeasure.Size = New System.Drawing.Size(33, 28)
        Me.btnMeasure.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnMeasure.Symbol = ""
        Me.btnMeasure.TabIndex = 1
        Me.btnMeasure.Tooltip = "Add Type"
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmbCategory.DropDownHeight = 140
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.Black
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.IntegralHeight = False
        Me.cmbCategory.Location = New System.Drawing.Point(115, 4)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(216, 28)
        Me.cmbCategory.TabIndex = 209
        '
        'FrmBrandProducts
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BottomLeftCornerSize = 1
        Me.BottomRightCornerSize = 1
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(378, 310)
        Me.Controls.Add(Me.btnMeasure)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBrandProducts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product"
        Me.TopLeftCornerSize = 1
        Me.TopRightCornerSize = 1
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtReorder As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPurchasePrice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnMeasure As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtSalePrice As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
End Class
