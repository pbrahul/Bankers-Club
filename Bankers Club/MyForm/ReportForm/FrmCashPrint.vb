Imports DevComponents.DotNetBar

Public Class FrmCashPrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(406, 272)

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_Name ASC", cmbAccounts)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        If rbnAll.Checked = True Then
            RptStr = "SELECT * FROM tbl_CashBank ORDER BY Cash_Name ASC"
            globalFRM = "CashBalance"

        ElseIf rbnSelected.Checked = True Then
            PrmFormDate.Value = dtpFrom.Value
            PrmToDate.Value = dtpTo.Value

            RptStr = "SELECT C.Cash_ID, C.Cash_Name, C.Cash_Address, C.Cash_Type, C.Cash_Details, (IFNULL((SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID=L.Cash_ID AND DATE_FORMAT(Led_Date,'%Y/%m/%d')<'" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' ORDER BY Led_Date DESC LIMIT 1),0)) AS Opening, L.Led_Date, L.Led_Particulars, IFNULL(L.Receive_Amt, 0) AS Receive_Amt, " & _
                     "L.Paid_Amt, L.Bal_Amt FROM tbl_Cashbank_Ledger AS L INNER JOIN tbl_CashBank AS C ON L.Cash_ID=C.Cash_ID WHERE C.Cash_Name='" & cmbAccounts.Text & "' AND (DATE_FORMAT(L.Led_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(L.Led_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY L.Led_Date, L.Led_ID ASC"
            globalFRM = "CashLedger"
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
        End If
    End Sub

    Private Sub rbnSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSelected.CheckedChanged
        If rbnSelected.Checked = True Then
            cmbAccounts.Enabled = True
            dtpFrom.Enabled = True
            dtpTo.Enabled = True
        End If
    End Sub
End Class