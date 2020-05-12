<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpUser = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnReset = New DevComponents.DotNetBar.ButtonX()
        Me.btnPermission = New DevComponents.DotNetBar.ButtonX()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.colID = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colName = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colAddress = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colContact = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colEmail = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.colStatus = New DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn()
        Me.lblTotal = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.grpUser.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUser
        '
        Me.grpUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpUser.CanvasColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grpUser.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.grpUser.Controls.Add(Me.Panel3)
        Me.grpUser.Controls.Add(Me.dgvUser)
        Me.grpUser.Controls.Add(Me.lblTotal)
        Me.grpUser.Controls.Add(Me.KryptonLabel1)
        Me.grpUser.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.grpUser.Location = New System.Drawing.Point(15, 12)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(920, 529)
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
        Me.grpUser.TabIndex = 266
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnReset)
        Me.Panel3.Controls.Add(Me.btnPermission)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(673, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(229, 36)
        Me.Panel3.TabIndex = 297
        '
        'btnReset
        '
        Me.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnReset.FocusCuesEnabled = False
        Me.btnReset.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnReset.Location = New System.Drawing.Point(119, 0)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnReset.Size = New System.Drawing.Size(110, 36)
        Me.btnReset.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnReset.TabIndex = 246
        Me.btnReset.Text = "Reset Password"
        '
        'btnPermission
        '
        Me.btnPermission.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPermission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPermission.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPermission.FocusCuesEnabled = False
        Me.btnPermission.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnPermission.Location = New System.Drawing.Point(0, 0)
        Me.btnPermission.Name = "btnPermission"
        Me.btnPermission.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnPermission.Size = New System.Drawing.Size(110, 36)
        Me.btnPermission.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnPermission.TabIndex = 246
        Me.btnPermission.Text = "Set Permission"
        Me.btnPermission.Visible = False
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.BackgroundColor = System.Drawing.Color.White
        Me.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvUser.CausesValidation = False
        Me.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUser.ColumnHeadersHeight = 32
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colName, Me.colAddress, Me.colContact, Me.colEmail, Me.colStatus})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUser.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvUser.EnableHeadersVisualStyles = False
        Me.dgvUser.Location = New System.Drawing.Point(13, 46)
        Me.dgvUser.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvUser.MultiSelect = False
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dgvUser.RowHeadersVisible = False
        Me.dgvUser.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.dgvUser.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.dgvUser.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUser.RowTemplate.Height = 27
        Me.dgvUser.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUser.ShowEditingIcon = False
        Me.dgvUser.Size = New System.Drawing.Size(889, 463)
        Me.dgvUser.TabIndex = 296
        '
        'colID
        '
        Me.colID.HeaderText = "User ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colName.DefaultCellStyle = DataGridViewCellStyle2
        Me.colName.HeaderText = "Full Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colAddress
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colAddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.colAddress.HeaderText = "User Name"
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAddress.Width = 180
        '
        'colContact
        '
        Me.colContact.HeaderText = "Privilege"
        Me.colContact.Name = "colContact"
        Me.colContact.ReadOnly = True
        Me.colContact.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colContact.Width = 170
        '
        'colEmail
        '
        Me.colEmail.HeaderText = "Contact No"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEmail.Width = 200
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.ReadOnly = True
        Me.colStatus.Width = 140
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = False
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblTotal.Location = New System.Drawing.Point(620, 473)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(128, 20)
        Me.lblTotal.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.lblTotal.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.StateNormal.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Far
        Me.lblTotal.TabIndex = 295
        Me.lblTotal.Values.Text = "0"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.BackColor = System.Drawing.Color.White
        Me.KryptonLabel1.ForeColor = System.Drawing.Color.Black
        Me.KryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.KryptonLabel1.Location = New System.Drawing.Point(530, 473)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Size = New System.Drawing.Size(91, 20)
        Me.KryptonLabel1.StateDisabled.LongText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateDisabled.ShortText.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.KryptonLabel1.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonLabel1.TabIndex = 294
        Me.KryptonLabel1.Values.Text = "Grand Total :"
        '
        'FrmUserView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 553)
        Me.Controls.Add(Me.grpUser)
        Me.DoubleBuffered = True
        Me.Name = "FrmUserView"
        Me.Text = "User View"
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpUser As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPermission As DevComponents.DotNetBar.ButtonX
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents colID As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colName As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colAddress As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colContact As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colEmail As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
    Friend WithEvents colStatus As DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn
End Class
