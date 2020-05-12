<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtAddress = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtEmail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(194, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 36)
        Me.Panel1.TabIndex = 1
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
        Me.tableLayoutPanel1.Controls.Add(Me.txtName, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.txtAddress, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.txtContact, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.txtEmail, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX3, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.LabelX4, 0, 3)
        Me.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(22, 28)
        Me.tableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 9
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(348, 168)
        Me.tableLayoutPanel1.TabIndex = 0
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
        Me.txtName.Location = New System.Drawing.Point(117, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(218, 27)
        Me.txtName.TabIndex = 0
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtAddress.Border.Class = "TextBoxBorder"
        Me.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(117, 36)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(218, 56)
        Me.txtAddress.TabIndex = 1
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact.ForeColor = System.Drawing.Color.Black
        Me.txtContact.Location = New System.Drawing.Point(117, 98)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(218, 27)
        Me.txtContact.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtEmail.Border.Class = "TextBoxBorder"
        Me.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtEmail.ForeColor = System.Drawing.Color.Black
        Me.txtEmail.Location = New System.Drawing.Point(117, 131)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(218, 27)
        Me.txtEmail.TabIndex = 3
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
        Me.LabelX1.Size = New System.Drawing.Size(106, 22)
        Me.LabelX1.TabIndex = 206
        Me.LabelX1.Text = "Supplier Name :"
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
        Me.LabelX2.Size = New System.Drawing.Size(62, 22)
        Me.LabelX2.TabIndex = 207
        Me.LabelX2.Text = "Address :"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(4, 99)
        Me.LabelX3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(83, 22)
        Me.LabelX3.TabIndex = 211
        Me.LabelX3.Text = "Contact No :"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(4, 132)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(44, 22)
        Me.LabelX4.TabIndex = 212
        Me.LabelX4.Text = "Email :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 16.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, -6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 26)
        Me.Label3.TabIndex = 212
        Me.Label3.Text = "Supplier Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, -1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(340, 25)
        Me.Label4.TabIndex = 213
        Me.Label4.Text = "_________________________________________"
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 248)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSupplier"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Supplier"
        Me.Panel1.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtAddress As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtEmail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
