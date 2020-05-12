<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExpense
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbFrom = New System.Windows.Forms.ComboBox()
        Me.txtBalance = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtDesc = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPayment = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.btnType = New DevComponents.DotNetBar.ButtonX()
        Me.Panel2.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(206, 275)
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
        Me.btnSave.Text = "Save"
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.Controls.Add(Me.cmbFrom, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtBalance, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.cmbType, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.txtDesc, 1, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.txtPayment, 1, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.dtpDate, 1, 6)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX5, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX6, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 5)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 6)
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(21, 29)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(366, 241)
        Me.tableLayoutPanel1.TabIndex = 0
        '
        'cmbFrom
        '
        Me.cmbFrom.BackColor = System.Drawing.Color.White
        Me.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrom.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbFrom.ForeColor = System.Drawing.Color.Black
        Me.cmbFrom.FormattingEnabled = True
        Me.cmbFrom.Location = New System.Drawing.Point(130, 3)
        Me.cmbFrom.Name = "cmbFrom"
        Me.cmbFrom.Size = New System.Drawing.Size(223, 28)
        Me.cmbFrom.TabIndex = 218
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
        Me.txtBalance.Location = New System.Drawing.Point(130, 37)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(223, 27)
        Me.txtBalance.TabIndex = 218
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.Color.White
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbType.ForeColor = System.Drawing.Color.Black
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(131, 71)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(180, 28)
        Me.cmbType.TabIndex = 0
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtDesc.Border.Class = "TextBoxBorder"
        Me.txtDesc.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDesc.ForeColor = System.Drawing.Color.Black
        Me.txtDesc.Location = New System.Drawing.Point(130, 106)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(223, 61)
        Me.txtDesc.TabIndex = 1
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
        Me.txtPayment.Location = New System.Drawing.Point(130, 173)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(223, 27)
        Me.txtPayment.TabIndex = 2
        '
        'dtpDate
        '
        Me.dtpDate.BackColor = System.Drawing.Color.White
        Me.dtpDate.CustomFormat = "dd MMM yyyy"
        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDate.ForeColor = System.Drawing.Color.Black
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(130, 206)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(223, 27)
        Me.dtpDate.TabIndex = 3
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 4)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(104, 22)
        Me.LabelX5.TabIndex = 213
        Me.LabelX5.Text = "Cash Accounts :"
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 38)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(116, 22)
        Me.LabelX6.TabIndex = 219
        Me.LabelX6.Text = "Balance Amount :"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(4, 71)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(115, 22)
        Me.LabelX1.TabIndex = 206
        Me.LabelX1.Text = "Type of Expense :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 107)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(83, 22)
        Me.LabelX2.TabIndex = 207
        Me.LabelX2.Text = "Description :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 174)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(119, 22)
        Me.LabelX3.TabIndex = 210
        Me.LabelX3.Text = "Expense Amount :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 207)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(97, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Expense Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, -5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "Expenditure"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 25)
        Me.Label4.TabIndex = 216
        Me.Label4.Text = "_____________________________________________"
        '
        'btnType
        '
        Me.btnType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnType.FocusCuesEnabled = False
        Me.btnType.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnType.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnType.Location = New System.Drawing.Point(339, 100)
        Me.btnType.Name = "btnType"
        Me.btnType.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnType.Size = New System.Drawing.Size(33, 28)
        Me.btnType.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnType.Symbol = ""
        Me.btnType.TabIndex = 217
        Me.btnType.Tooltip = "Add Type"
        '
        'FrmExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 329)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmExpense"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense"
        Me.Panel2.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtDesc As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtPayment As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnType As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbFrom As System.Windows.Forms.ComboBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtBalance As DevComponents.DotNetBar.Controls.TextBoxX
End Class
