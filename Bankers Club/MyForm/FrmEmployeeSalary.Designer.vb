<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeSalary
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
        Me.dtpDiscount = New System.Windows.Forms.DateTimePicker()
        Me.txtAmount = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSearch = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.txtID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.TableLayoutPanel2.Controls.Add(Me.txtID, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX7, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX6, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX5, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtSearch, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX4, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.LabelX1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtRemarks, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtContact, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpDiscount, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAmount, 1, 5)
        Me.TableLayoutPanel2.ForeColor = System.Drawing.Color.Black
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(22, 34)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 9
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(339, 234)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'dtpDiscount
        '
        Me.dtpDiscount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpDiscount.CustomFormat = "dd MMM yyyy"
        Me.dtpDiscount.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.dtpDiscount.ForeColor = System.Drawing.Color.Black
        Me.dtpDiscount.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDiscount.Location = New System.Drawing.Point(105, 201)
        Me.dtpDiscount.Name = "dtpDiscount"
        Me.dtpDiscount.Size = New System.Drawing.Size(229, 27)
        Me.dtpDiscount.TabIndex = 6
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtAmount.Border.Class = "TextBoxBorder"
        Me.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAmount.ForeColor = System.Drawing.Color.Black
        Me.txtAmount.Location = New System.Drawing.Point(105, 168)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(229, 27)
        Me.txtAmount.TabIndex = 5
        '
        'LabelX6
        '
        Me.LabelX6.AutoSize = True
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.ForeColor = System.Drawing.Color.Black
        Me.LabelX6.Location = New System.Drawing.Point(4, 169)
        Me.LabelX6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(94, 22)
        Me.LabelX6.TabIndex = 297
        Me.LabelX6.Text = "Paid Amount :"
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(4, 136)
        Me.LabelX5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(65, 22)
        Me.LabelX5.TabIndex = 296
        Me.LabelX5.Text = "Remarks :"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(105, 135)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(229, 27)
        Me.txtRemarks.TabIndex = 4
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtSearch.Border.Class = "TextBoxBorder"
        Me.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSearch.ForeColor = System.Drawing.Color.Black
        Me.txtSearch.Location = New System.Drawing.Point(105, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(229, 27)
        Me.txtSearch.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtName.Border.Class = "TextBoxBorder"
        Me.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtName.Enabled = False
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(105, 69)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(229, 27)
        Me.txtName.TabIndex = 2
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact.Enabled = False
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(105, 102)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(229, 27)
        Me.txtContact.TabIndex = 3
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 103)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(83, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Contact No :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 70)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(48, 22)
        Me.LabelX3.TabIndex = 210
        Me.LabelX3.Text = "Name :"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(4, 37)
        Me.LabelX2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(91, 22)
        Me.LabelX2.TabIndex = 207
        Me.LabelX2.Text = "Employee ID :"
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
        Me.LabelX1.Size = New System.Drawing.Size(53, 22)
        Me.LabelX1.TabIndex = 206
        Me.LabelX1.Text = "Search :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(19, -6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 26)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "Employee Salary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(17, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 25)
        Me.Label4.TabIndex = 219
        Me.Label4.Text = "__________________________________________"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.btnSave)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(193, 277)
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
        'LabelX7
        '
        Me.LabelX7.AutoSize = True
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.ForeColor = System.Drawing.Color.Black
        Me.LabelX7.Location = New System.Drawing.Point(4, 202)
        Me.LabelX7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(40, 22)
        Me.LabelX7.TabIndex = 298
        Me.LabelX7.Text = "Date :"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.WhiteSmoke
        '
        '
        '
        Me.txtID.Border.Class = "TextBoxBorder"
        Me.txtID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtID.Enabled = False
        Me.txtID.ForeColor = System.Drawing.Color.Black
        Me.txtID.Location = New System.Drawing.Point(105, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(229, 27)
        Me.txtID.TabIndex = 1
        '
        'FrmEmployeeSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 329)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmployeeSalary"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salary"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtAmount As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSearch As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dtpDiscount As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtID As DevComponents.DotNetBar.Controls.TextBoxX
End Class
