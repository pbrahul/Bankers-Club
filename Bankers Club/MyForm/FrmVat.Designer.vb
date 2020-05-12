<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVat))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.txtVat = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.rbnSame = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbnIndividual = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.btnSave = New DevComponents.DotNetBar.ButtonX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PictureBox2)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(310, 43)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuBackground
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.ForeColor = System.Drawing.Color.Black
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 206
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 12)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Add new and modify current data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 204
        Me.Label1.Text = "VAT Details"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.txtVat)
        Me.PanelEx2.Controls.Add(Me.rbnSame)
        Me.PanelEx2.Controls.Add(Me.rbnIndividual)
        Me.PanelEx2.Location = New System.Drawing.Point(11, 60)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(286, 94)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 0
        '
        'txtVat
        '
        Me.txtVat.AlwaysActive = False
        Me.txtVat.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtVat.ForeColor = System.Drawing.Color.Black
        Me.txtVat.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Ribbon
        Me.txtVat.Location = New System.Drawing.Point(221, 22)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Silver
        Me.txtVat.Size = New System.Drawing.Size(54, 22)
        Me.txtVat.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtVat.StateActive.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtVat.StateActive.Content.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtVat.StateCommon.Border.DrawBorders = CType((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) _
                    Or ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right), ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)
        Me.txtVat.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias
        Me.txtVat.StateCommon.Border.Rounding = 4
        Me.txtVat.StateCommon.Border.Width = 1
        Me.txtVat.StateCommon.Content.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtVat.StateNormal.Content.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtVat.TabIndex = 248
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbnSame
        '
        Me.rbnSame.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbnSame.Checked = True
        Me.rbnSame.ForeColor = System.Drawing.Color.Black
        Me.rbnSame.Images.CheckedNormal = CType(resources.GetObject("rbnSame.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnSame.Images.CheckedPressed = CType(resources.GetObject("rbnSame.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnSame.Images.CheckedTracking = CType(resources.GetObject("rbnSame.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnSame.Images.UncheckedNormal = CType(resources.GetObject("rbnSame.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnSame.Images.UncheckedPressed = CType(resources.GetObject("rbnSame.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnSame.Images.UncheckedTracking = CType(resources.GetObject("rbnSame.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnSame.Location = New System.Drawing.Point(10, 24)
        Me.rbnSame.Name = "rbnSame"
        Me.rbnSame.Size = New System.Drawing.Size(207, 18)
        Me.rbnSame.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnSame.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnSame.TabIndex = 247
        Me.rbnSame.Values.Text = "Use Same VAT All Products (%) :"
        '
        'rbnIndividual
        '
        Me.rbnIndividual.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbnIndividual.ForeColor = System.Drawing.Color.Black
        Me.rbnIndividual.Images.CheckedNormal = CType(resources.GetObject("rbnIndividual.Images.CheckedNormal"), System.Drawing.Image)
        Me.rbnIndividual.Images.CheckedPressed = CType(resources.GetObject("rbnIndividual.Images.CheckedPressed"), System.Drawing.Image)
        Me.rbnIndividual.Images.CheckedTracking = CType(resources.GetObject("rbnIndividual.Images.CheckedTracking"), System.Drawing.Image)
        Me.rbnIndividual.Images.UncheckedNormal = CType(resources.GetObject("rbnIndividual.Images.UncheckedNormal"), System.Drawing.Image)
        Me.rbnIndividual.Images.UncheckedPressed = CType(resources.GetObject("rbnIndividual.Images.UncheckedPressed"), System.Drawing.Image)
        Me.rbnIndividual.Images.UncheckedTracking = CType(resources.GetObject("rbnIndividual.Images.UncheckedTracking"), System.Drawing.Image)
        Me.rbnIndividual.Location = New System.Drawing.Point(10, 49)
        Me.rbnIndividual.Name = "rbnIndividual"
        Me.rbnIndividual.Size = New System.Drawing.Size(179, 18)
        Me.rbnIndividual.StateNormal.ShortText.Color1 = System.Drawing.Color.Black
        Me.rbnIndividual.StateNormal.ShortText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnIndividual.TabIndex = 246
        Me.rbnIndividual.Values.Text = "Use Individual Products VAT"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnCancel)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(143, 170)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 32)
        Me.Panel3.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.Location = New System.Drawing.Point(76, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnCancel.Size = New System.Drawing.Size(76, 32)
        Me.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(0, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4)
        Me.btnSave.Size = New System.Drawing.Size(76, 32)
        Me.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        '
        'FrmVat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 222)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "VAT"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnSave As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents rbnSame As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbnIndividual As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents txtVat As ComponentFactory.Krypton.Toolkit.KryptonTextBox
End Class
