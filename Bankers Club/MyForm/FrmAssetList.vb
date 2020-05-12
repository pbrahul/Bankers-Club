Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmAssetList

    Public Sub RefreshAsset()
        sqlSTR = "SELECT A.As_ID, A.As_Name, A.As_Details, FORMAT(A.Amount, 2) AS Amount, A.Dep_Rate, FORMAT(A.Dep_Value, 2) AS Dep_Value  FROM tbl_assets AS A ORDER BY A.As_ID ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)

        lblTotal.Text = Format(GridTotal(dgvCustomers, 5), "###,###.00")
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panCustomers.Width = (FrmMain.Width / 2) + 450
        panCustomers.Height = FrmMain.Height - 150
        panCustomers.Left = (Me.Width / 2) - 570
        panCustomers.Top = (FrmMain.Height / 2) - 370

        dgvCustomers.Width = panCustomers.Width - 28
        dgvCustomers.Height = panCustomers.Height - 70

        lblTotal.Top = dgvCustomers.Bottom + 7
        lblTotal.Left = dgvCustomers.Right - 120

        lblTitle.Top = dgvCustomers.Bottom + 7
        lblTitle.Left = lblTotal.Left - 70
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshAsset()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs)
        RefreshAsset()
    End Sub
End Class