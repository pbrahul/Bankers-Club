Imports DevComponents.DotNetBar

Public Class FrmCashBank

    Public Sub RefreshCashBank()
        txtSearch.Clear()
        txtSearch.Select()

        sqlSTR = "SELECT Cash_ID, Cash_Name, Cash_Address, Cash_Details, Cash_Type, Contact_No, FORMAT(Bal_Amt, 2) Bal_Amt FROM tbl_CashBank ORDER BY LPAD(LOWER(Cash_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCash)

        If sqlDT.Rows.Count > 0 Then
            dgvCash.Focus()
            dgvCash.Rows(0).Selected = True
            sqlSTR = "SELECT Led_ID, DATE_FORMAT(Led_Date, '%d-%b-%Y') AS LedDate, Led_Particulars, IFNULL(FORMAT(Receive_Amt, 2), 0) AS Receive_Amt, IFNULL(FORMAT(Paid_Amt, 2), 0) AS Paid_Amt, " & _
                     "FORMAT(Bal_Amt,2) AS Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & dgvCash.SelectedRows(0).Cells(0).Value & "' ORDER BY Led_Date DESC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        Else
            dgvProduct.Rows.Clear()
        End If

    End Sub

    Private Sub SearchPurchase()
        sqlSTR = "SELECT Cash_ID, Cash_Name, Cash_Address, Cash_Details, Cash_Type, Contact_No, FORMAT(Bal_Amt, 2) Bal_Amt FROM tbl_CashBank " & _
                 "WHERE RIGHT(Cash_ID, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR Cash_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR " & _
                 "LEFT(Contact_No, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR RIGHT(Contact_No, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' ORDER BY LPAD(LOWER(Cash_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCash)

        If sqlDT.Rows.Count > 0 Then
            dgvCash.Focus()
            dgvCash.Rows(0).Selected = True
            sqlSTR = "SELECT Led_ID, DATE_FORMAT(Led_Date, '%d-%b-%Y') AS LedDate, Led_Particulars, IFNULL(FORMAT(Receive_Amt, 2), 0) AS Receive_Amt, IFNULL(FORMAT(Paid_Amt, 2), 0) AS Paid_Amt, " & _
                     "FORMAT(Bal_Amt,2) AS Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & dgvCash.SelectedRows(0).Cells(0).Value & "' ORDER BY Led_Date DESC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        Else
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvProduct.Rows.Clear()
        End If
    End Sub

    Private Sub ViewPurchase()
        If dgvCash.SelectedRows.Count > 0 Then
            sqlSTR = "SELECT Led_ID, DATE_FORMAT(Led_Date, '%d-%b-%Y') AS LedDate, Led_Particulars, IFNULL(FORMAT(Receive_Amt, 2), 0) AS Receive_Amt, IFNULL(FORMAT(Paid_Amt, 2), 0) AS Paid_Amt, " & _
                     "FORMAT(Bal_Amt,2) AS Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & dgvCash.SelectedRows(0).Cells(0).Value & "' ORDER BY Led_Date DESC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        End If
    End Sub


    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'panProduct.Width = (FrmMain.Width / 2) + 450
        'panProduct.Height = FrmMain.Height - 150
        'panProduct.Left = (Me.Width / 2) - 570
        'panProduct.Top = (FrmMain.Height / 2) - 370

        panProduct.Width = FrmMain.Width - 180
        panProduct.Height = FrmMain.Height - 180
        panProduct.Location = New Point(100, 10)


        dgvCash.Width = panProduct.Width - 28
        dgvProduct.Width = panProduct.Width - 37
        dgvProduct.Height = panProduct.Height - 320

    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCashBank()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchPurchase()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchPurchase()
        End If
    End Sub

    Private Sub dgvPurchase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvCash.MouseDoubleClick
        ViewPurchase()
    End Sub

    Private Sub dgvPurchase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ViewPurchase()
        ElseIf e.KeyCode = Keys.Back Then
            txtSearch.Select()
        End If
    End Sub

End Class