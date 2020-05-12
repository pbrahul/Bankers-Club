Imports DevComponents.DotNetBar

Public Class FrmExpenseList

    Public Sub RefreshExpense()
        txtSearch.Clear()
        'txtSearch.Select()

        sqlSTR = "SELECT L.Ledger_ID, DATE_FORMAT(L.Ledger_Date, '%d-%b-%Y') AS Led_Date, A.AC_Name, C.Cash_Name, L.Remarks, FORMAT(L.Credit_Amt,2) AS Debit_Amt FROM tbl_ac_ledger AS L " & _
                 "INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_cashbank AS C ON L.Cash_ID=C.Cash_ID INNER JOIN tbl_accounts_type AS T ON A.Type_ID=T.Type_ID " & _
                 "WHERE T.Type_Details='Expense' AND DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')='" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY L.Ledger_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvExpense)

        lblTotal.Text = Format(GridTotal(dgvExpense, 5), "###,###.00")
    End Sub

    Private Sub FrmExpenseList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpExpense.Width = FrmMain.Width - 180
        grpExpense.Height = FrmMain.Height - 180
        grpExpense.Location = New Point(100, 30)

        dgvExpense.Width = grpExpense.Width - 40
        dgvExpense.Height = grpExpense.Height - 90

        dtpDate.Left = dgvExpense.Width - 210
        lblType.Left = dtpDate.Left - 60

        lblTotal.Top = dgvExpense.Bottom + 7
        lblTotal.Left = dgvExpense.Right - 120

        lblTitle.Top = dgvExpense.Bottom + 7
        lblTitle.Left = lblTotal.Left - 70

    End Sub

    Private Sub FrmExpenseList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshExpense()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT L.Ledger_ID, DATE_FORMAT(L.Ledger_Date, '%d-%b-%Y') AS Led_Date, A.AC_Name, C.Cash_Name, L.Remarks, FORMAT(L.Credit_Amt,2) AS Debit_Amt FROM tbl_ac_ledger AS L " & _
                 "INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_cashbank AS C ON L.Cash_ID=C.Cash_ID INNER JOIN tbl_accounts_type AS T ON A.Type_ID=T.Type_ID " & _
                 "WHERE T.Type_Details='Expense' AND A.Ac_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' ORDER BY L.Ledger_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvExpense)

        If sqlDT.Rows.Count = 0 Then
            MessageBoxEx.Show("No record(s) found !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtSearch.Text = ""
            txtSearch.Select()
            lblTotal.Text = "0.00"
        Else
            lblTotal.Text = Format(GridTotal(dgvExpense, 5), "###,###.00")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshExpense()
    End Sub
End Class