Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmPaymentList

    Public Sub RefreshPayment()
        txtSearch.Clear()

        sqlSTR = "SELECT L.Ledger_ID, DATE_FORMAT(L.Ledger_Date, '%d-%b-%Y') AS Led_Date, A.AC_Name, C.Cash_Name, L.Payment_Type, L.Cheque_No, L.Remarks, FORMAT(L.Credit_Amt,2) AS Credit_Amt FROM tbl_ac_ledger AS L " & _
                 "INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_cashbank AS C ON L.Cash_ID=C.Cash_ID WHERE LEFT(L.Led_Particulars,7)='Receive' " & _
                 "AND DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')='" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)

        lblTotal.Text = Format(GridTotal(dgvCustomers, 7), "###,###.00")
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
        RefreshPayment()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT L.Ledger_ID, DATE_FORMAT(L.Ledger_Date, '%d-%b-%Y') AS Led_Date, A.AC_Name, C.Cash_Name, L.Payment_Type, L.Cheque_No, L.Remarks, FORMAT(L.Credit_Amt,2) AS Credit_Amt FROM tbl_ac_ledger AS L " & _
                 "INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_cashbank AS C ON L.Cash_ID=C.Cash_ID WHERE LEFT(L.Led_Particulars,7)='Receive' AND (RIGHT(A.Ac_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR " & _
                 " A.Ac_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(A.Contact_No, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "') ORDER BY Led_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)

        If sqlDT.Rows.Count = 0 Then
            dgvCustomers.Rows.Clear()
            txtSearch.Select()
            lblTotal.Text = "0.00"
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lblTotal.Text = Format(GridTotal(dgvCustomers, 7), "###,###.00")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshPayment()
    End Sub
End Class