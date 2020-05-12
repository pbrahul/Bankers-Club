Public Class FrmOthersIncomePrint

    Private Sub FrmWorkerStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        SingleComboBox("SELECT Type_Details From tbl_Collection_Type ORDER BY Type_Details ASC", cmbType)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Report As New FrmReports

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        If rbnAll.Checked = True Then
            RptStr = "SELECT Date_FORMAT(C.Col_Date,'%d-%b-%Y') AS Col_Date, C.Col_Name, T.Type_Details, Ca.Cash_Name, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID INNER JOIN tbl_cashbank AS Ca " & _
                     "ON C.Cash_ID=Ca.Cash_ID WHERE ISNULL(C.Mem_ID) AND (Date_FORMAT(C.Col_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(C.Col_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY C.Col_Date ASC"
            globalFRM = "Income Print"

        ElseIf rbnSelected.Checked = True Then
            RptStr = "SELECT T.Type_Details, C.Col_Name, C.Col_Details, C.Col_Date, C.Col_Amt FROM tbl_collections AS C INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID WHERE T.Type_Details='" & cmbType.Text & "' " & _
                     "AND (DATE_FORMAT(C.Col_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(C.Col_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY C.Col_Date ASC"
            globalFRM = "Others Income"
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