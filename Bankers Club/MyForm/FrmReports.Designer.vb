<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReports
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.grpPrint = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.grpPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Black
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReuseParameterValuesOnRefresh = True
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(868, 549)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'grpPrint
        '
        Me.grpPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.grpPrint.CanvasColor = System.Drawing.SystemColors.Control
        Me.grpPrint.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.grpPrint.Controls.Add(Me.CrystalReportViewer1)
        Me.grpPrint.Location = New System.Drawing.Point(12, 3)
        Me.grpPrint.Name = "grpPrint"
        Me.grpPrint.Size = New System.Drawing.Size(870, 551)
        '
        '
        '
        Me.grpPrint.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.grpPrint.Style.BackColorGradientAngle = 90
        Me.grpPrint.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.grpPrint.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPrint.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.grpPrint.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPrint.Style.BorderLeftWidth = 1
        Me.grpPrint.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPrint.Style.BorderRightWidth = 1
        Me.grpPrint.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.grpPrint.Style.BorderTopWidth = 1
        Me.grpPrint.Style.CornerDiameter = 4
        Me.grpPrint.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpPrint.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.grpPrint.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.grpPrint.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.grpPrint.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.grpPrint.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.grpPrint.TabIndex = 1
        '
        'FrmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 569)
        Me.Controls.Add(Me.grpPrint)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBox = False
        Me.Name = "FrmReports"
        Me.Text = "Report"
        Me.grpPrint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents grpPrint As DevComponents.DotNetBar.Controls.GroupPanel
End Class
