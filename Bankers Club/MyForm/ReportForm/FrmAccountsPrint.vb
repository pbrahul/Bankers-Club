Imports DevComponents.DotNetBar

Public Class FrmAccountsPrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(409, 309)

        SingleComboBox("SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_Details<>'Expense' ORDER BY Type_Details ASC", cmbType)
        SingleComboBox("SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE T.Type_Details<>'Expense' ORDER BY Ac_Name ASC", cmbAccounts)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        If rbnAll.Checked = True Then
            RptStr = "SELECT A.AC_ID, A.AC_Name, A.Ac_Address, C.Type_Details, A.Contact_No, A.Bal_Amt FROM tbl_Accounts AS A " & _
                     "INNER JOIN tbl_Accounts_Type AS C ON A.Type_ID=C.Type_ID WHERE C.Type_Details='" & cmbType.Text & "' ORDER BY LPAD(LOWER(A.Ac_ID), 10,0) ASC"
            globalFRM = "AccountsBalance"

        ElseIf rbnSelected.Checked = True Then
            PrmFormDate.Value = dtpFrom.Value
            PrmToDate.Value = dtpTo.Value

            RptStr = "SELECT A.Ac_ID, A.Ac_Name, A.Ac_Address, T.Type_Details, A.Contact_No, (IFNULL((SELECT Balance_Amt FROM tbl_Ac_ledger WHERE Ac_ID=A.Ac_ID AND DATE_FORMAT(Ledger_Date,'%Y/%m/%d')<'" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' ORDER BY Ledger_Date DESC, Ledger_ID DESC LIMIT 1),0)) AS Opening, " & _
                     "L.Ledger_Date, L.Led_Particulars, IFNULL(L.Debit_Amt,0) AS Debit_Amt, IFNULL(L.Credit_Amt,0) AS Credit_Amt, IFNULL(L.Balance_Amt,0) AS Balance_Amt FROM tbl_Ac_Ledger AS L INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_accounts_type AS T ON A.Type_ID=T.Type_ID " & _
                     "WHERE A.Ac_Name='" & cmbAccounts.Text & "' AND (DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY L.Ledger_Date ASC"
            globalFRM = "AccountsLedger"
        End If


        rptReport.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rbnSelect_CheckedChanged(sender As Object, e As EventArgs) Handles rbnAll.CheckedChanged
        If rbnAll.Checked = True Then
            cmbAccounts.Enabled = False
            dtpFrom.Enabled = False
            dtpTo.Enabled = False
            cmbType.Enabled = True
        End If
    End Sub

    Private Sub rbnSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSelected.CheckedChanged
        If rbnSelected.Checked = True Then
            cmbAccounts.Enabled = True
            dtpFrom.Enabled = True
            dtpTo.Enabled = True
            cmbType.Enabled = False
        End If
    End Sub
End Class