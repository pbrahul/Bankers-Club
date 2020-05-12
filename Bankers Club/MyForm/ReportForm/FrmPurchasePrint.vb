Imports DevComponents.DotNetBar

Public Class FrmPurchasePrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(417, 312)

        SingleComboBox("SELECT AC_Name FROM tbl_Accounts ORDER BY Ac_Name ASC", cmbSupplier)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        If rbnSelect.Checked = True Then
            If FrmPurchaseList.dgvPurchase.SelectedRows.Count > 0 Then
                RptStr = "SELECT A.Ac_ID, A.Ac_Name, A.AC_Address, A.Contact_No, P.Purchase_ID, P.Purcahse_Date, D.Barcode, D.Product_Name, D.QTY, D.Item_Price, D.Total_Price, D.Units, (D.Qty * Pr.Qty) AS PcsQty, " & _
                         "P.Approved, P.Memo_No FROM TBL_Purchase AS P INNER JOIN tbl_purchase_details AS D ON P.Purchase_ID = D.Purchase_ID INNER JOIN tbl_Accounts AS A ON P.AC_ID = A.AC_ID INNER JOIN tbl_products AS Pr " & _
                         "ON D.Barcode=Pr.Barcode WHERE P.Purchase_ID ='" & FrmPurchaseList.dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                globalFRM = "SelectedPurchase"
            Else
                MessageBoxEx.Show("No record selected...", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

        ElseIf rbnApproved.Checked = True Then
            RptStr = "SELECT P.Purchase_ID, P.Memo_No, P.Purcahse_Date, A.Ac_Name, D.Product_Name, D.BarCode, D.QTY, D.Item_Price, D.Total_Price, A.Ac_ID, P.Purchase_Total, T.Debit_Amt, T.Discount, T.Balance_Amt FROM tbl_Purchase AS P " & _
                     "INNER JOIN tbl_purchase_details AS D ON P.Purchase_ID = D.Purchase_ID INNER JOIN tbl_Accounts AS A ON P.Ac_ID=A.Ac_ID  INNER JOIN tbl_ac_ledger AS T ON P.Purchase_ID = T.Purchase_ID WHERE P.Approved='Yes' " & _
                     "AND (P.Purcahse_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND P.Purcahse_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY P.Purcahse_Date ASC"
            globalFRM = "PurchaseApproved"

        ElseIf rbnSupplier.Checked = True Then
            RptStr = "SELECT P.Purchase_ID, P.Memo_No, DATE_FORMAT(P.Purcahse_Date, '%d-%b-%Y') AS Purcahse_Date, A.Ac_ID, A.Ac_Name, A.Ac_Address, A.Contact_No, D.Product_Name, D.BarCode, D.QTY, D.Item_Price, D.Total_Price, P.Purchase_Total, " & _
                     "T.Debit_Amt, T.Discount, T.Balance_Amt FROM tbl_Purchase AS P INNER JOIN tbl_purchase_details AS D ON P.Purchase_ID = D.Purchase_ID INNER JOIN tbl_Accounts AS A ON P.Ac_ID=A.Ac_ID  INNER JOIN tbl_ac_ledger AS T ON P.Purchase_ID = T.Purchase_ID " & _
                     "WHERE A.Ac_Name='" & cmbSupplier.Text & "' AND (P.Purcahse_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND P.Purcahse_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY P.Purcahse_Date ASC"
            globalFRM = "PurchaseSupplier"
        End If

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        rptReport.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rbnSelect_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSelect.CheckedChanged, rbnApproved.CheckedChanged
        cmbSupplier.Enabled = False
    End Sub

    Private Sub rbnSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSupplier.CheckedChanged
        cmbSupplier.Enabled = True
    End Sub
End Class