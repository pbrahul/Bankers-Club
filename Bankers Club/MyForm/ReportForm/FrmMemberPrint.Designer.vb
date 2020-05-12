<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMemberPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMemberPrint))
        Me.rbnBank = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.rbnAll = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.cmbBank = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.panPatient = New DevComponents.DotNetBar.PanelEx()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.panPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnBank
        '
        Me.rbnBank.AutoSize = True
        Me.rbnBank.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnBank.CheckBoxImageChecked = CType(resources.GetObject("rbnBank.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnBank.CheckBoxImageUnChecked = CType(resources.GetObject("rbnBank.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnBank.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnBank.FocusCuesEnabled = False
        Me.rbnBank.ForeColor = System.Drawing.Color.Black
        Me.rbnBank.Location = New System.Drawing.Point(48, 69)
        Me.rbnBank.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnBank.Name = "rbnBank"
        Me.rbnBank.Size = New System.Drawing.Size(167, 22)
        Me.rbnBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnBank.TabIndex = 302
        Me.rbnBank.Text = " Member List for Bank"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(210, 129)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(169, 33)
        Me.Panel1.TabIndex = 208
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.FocusCuesEnabled = False
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(24, 24)
        Me.btnCancel.Location = New System.Drawing.Point(89, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnCancel.Size = New System.Drawing.Size(80, 33)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.Symbol = ""
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.BackColor = System.Drawing.Color.AliceBlue
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrint.FocusCuesEnabled = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(0, 0)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnPrint.Size = New System.Drawing.Size(80, 33)
        Me.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnPrint.TabIndex = 285
        Me.btnPrint.Text = "Print"
        '
        'rbnAll
        '
        Me.rbnAll.AutoSize = True
        Me.rbnAll.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.rbnAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rbnAll.CheckBoxImageChecked = CType(resources.GetObject("rbnAll.CheckBoxImageChecked"), System.Drawing.Image)
        Me.rbnAll.CheckBoxImageUnChecked = CType(resources.GetObject("rbnAll.CheckBoxImageUnChecked"), System.Drawing.Image)
        Me.rbnAll.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.rbnAll.Checked = True
        Me.rbnAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.rbnAll.CheckValue = "Y"
        Me.rbnAll.FocusCuesEnabled = False
        Me.rbnAll.ForeColor = System.Drawing.Color.Black
        Me.rbnAll.Location = New System.Drawing.Point(48, 34)
        Me.rbnAll.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.rbnAll.Name = "rbnAll"
        Me.rbnAll.Size = New System.Drawing.Size(130, 22)
        Me.rbnAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rbnAll.TabIndex = 337
        Me.rbnAll.Text = " All Member List"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        Me.LabelX2.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(80, 94)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(84, 22)
        Me.LabelX2.TabIndex = 339
        Me.LabelX2.Text = "Bank Name :"
        '
        'cmbBank
        '
        Me.cmbBank.DisplayMember = "Text"
        Me.cmbBank.DropDownHeight = 160
        Me.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBank.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.cmbBank.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmbBank.ForeColor = System.Drawing.Color.Black
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.IntegralHeight = False
        Me.cmbBank.ItemHeight = 18
        Me.cmbBank.Location = New System.Drawing.Point(170, 94)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(209, 26)
        Me.cmbBank.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.cmbBank.TabIndex = 338
        '
        'panPatient
        '
        Me.panPatient.CanvasColor = System.Drawing.SystemColors.Control
        Me.panPatient.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.panPatient.Controls.Add(Me.lblTitle)
        Me.panPatient.Location = New System.Drawing.Point(39, -13)
        Me.panPatient.Name = "panPatient"
        Me.panPatient.Size = New System.Drawing.Size(357, 39)
        Me.panPatient.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panPatient.Style.BackColor1.Color = System.Drawing.Color.Transparent
        Me.panPatient.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panPatient.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionInactiveText
        Me.panPatient.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.panPatient.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panPatient.Style.GradientAngle = 90
        Me.panPatient.TabIndex = 344
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Yu Gothic UI Light", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(4, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(191, 25)
        Me.lblTitle.TabIndex = 297
        Me.lblTitle.Text = "Collection Deatils Print"
        '
        'FrmMemberPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 191)
        Me.Controls.Add(Me.panPatient)
        Me.Controls.Add(Me.cmbBank)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.rbnAll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbnBank)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMemberPrint"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Member List"
        Me.Panel1.ResumeLayout(False)
        Me.panPatient.ResumeLayout(False)
        Me.panPatient.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbnBank As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents rbnAll As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cmbBank As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents panPatient As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
