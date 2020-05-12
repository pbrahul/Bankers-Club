Public Class FrmExpensePrint

    Private Sub FrmWorkerStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        SingleComboBox("SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE Type_Details='Expense' ORDER BY A.Ac_Name ASC", cmbType)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Report As New FrmReports

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        If rbnAll.Checked = True Then

            RptStr = "SELECT L.Ledger_Date, A.Ac_Name, L.Led_Particulars, L.Credit_Amt FROM tbl_ac_ledger AS L INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID = T.Type_ID " & _
                     "WHERE T.Type_Details='Expense' AND (DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "')"
            globalFRM = "DailyExpense"

        ElseIf rbnSelected.Checked = True Then
            PrmName.Value = cmbType.SelectedItem

            RptStr = "SELECT L.Ledger_Date, A.Ac_Name, L.Led_Particulars, L.Credit_Amt FROM tbl_ac_ledger AS L INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID = T.Type_ID " & _
                     "WHERE T.Type_Details='Expense' AND A.Ac_Name='" & cmbType.Text & "' AND (DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(L.Ledger_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "')"
            globalFRM = "Expense"
        End If

        Report.Show()
        Me.Close()
    End Sub

    Private Sub rbnAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSelected.CheckedChanged
        If rbnSelected.Checked = True Then
            cmbType.Enabled = True
        End If
    End Sub


    Private Sub rbnSummary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnAll.CheckedChanged
        If rbnAll.Checked = True Then
            cmbType.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub




End Class