Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmTransferList

    Public Sub RefreshTransfer()
        sqlSTR = "SELECT T.Tr_ID, DATE_FORMAT(T.Tr_Date, '%d-%b-%Y') AS Tr_Date, (SELECT Cash_Name FROM tbl_cashbank WHERE Cash_ID=T.Tr_From) AS CashFrom, (SELECT Cash_Name FROM tbl_cashbank WHERE Cash_ID=T.Tr_To) AS CashTo, " & _
                 "T.Tr_Details, FORMAT(T.Tr_Amt,2) AS Tr_Amt FROM tbl_transfer AS T WHERE DATE_FORMAT(T.Tr_Date, '%Y/%m/%d')='" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY T.Tr_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)

        lblTotal.Text = Format(GridTotal(dgvCustomers, 5), "###,###.00")
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpSales.Width = FrmMain.Width - 180
        grpSales.Height = FrmMain.Height - 180
        grpSales.Location = New Point(100, 30)

        dgvCustomers.Width = grpSales.Width - 40
        dgvCustomers.Height = grpSales.Height - 90

        dtpDate.Left = dgvCustomers.Width - 206
        lblType.Left = dtpDate.Left - 60

        lblTotal.Top = dgvCustomers.Bottom + 7
        lblTotal.Left = dgvCustomers.Right - 120

        lblTitle.Top = dgvCustomers.Bottom + 7
        lblTitle.Left = lblTotal.Left - 70
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshTransfer()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshTransfer()
    End Sub
End Class