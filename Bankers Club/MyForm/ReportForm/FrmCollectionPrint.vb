Imports DevComponents.DotNetBar

Public Class FrmCollectionPrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(405, 335)

        SingleComboBox("SELECT DISTINCT Bank_Name FROM tbl_member ORDER BY Bank_Name ASC", cmbBank)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

       If rbnAll.Checked = True Then
            RptStr = "SELECT Date_FORMAT(C.Col_Date,'%d-%b-%Y') AS Col_Date, M.Mem_ID, M.Mem_Name, T.Type_Details, Ca.Cash_Name, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C INNER JOIN tbl_Member AS M ON M.Mem_ID=C.Mem_ID INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID INNER JOIN tbl_cashbank AS Ca " & _
                     "ON C.Cash_ID=Ca.Cash_ID WHERE Date_FORMAT(C.Col_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(C.Col_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY C.Col_Date ASC"
            globalFRM = "Collections"

        ElseIf rbnBank.Checked = True Then
            RptStr = "SELECT M.Mem_ID, M.Mem_Name, M.Bank_Name, M.Branch, M.Bank_Designation, (IFNULL((SELECT SUM(Col_Amt) FROM tbl_Collections WHERE Mem_ID=M.Mem_ID AND (Date_FORMAT(Col_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(Col_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & _
                     "')),0)) AS Col_Amt FROM tbl_Member AS M WHERE M.Bank_Name='" & cmbBank.SelectedItem & "' AND M.Mem_Status='Active' ORDER BY LPAD(LOWER(M.Mem_ID), 10,0) ASC"
            globalFRM = "CollectionsBank"


        ElseIf rbnMember.Checked = True Then
            If FrmCollectionList.dgvCollection.SelectedRows.Count > 0 Then
                RptStr = "SELECT M.Mem_ID, M.Mem_Name, M.Mem_Contact, M.Bank_Name, M.Bank_Designation, M.Mem_Type, C.Col_Date, C.Col_ID, C.Collection_Type, C.Bank_Name AS Col_Bank, C.Cheque_Date, T.Type_Details, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C INNER JOIN tbl_Member AS M ON M.Mem_ID=C.Mem_ID " & _
                         "INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID WHERE M.Mem_ID='" & FrmCollectionList.dgvCollection.SelectedRows(0).Cells(9).Value & "' AND (DATE_FORMAT(C.Col_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(C.Col_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY C.Col_Date ASC"

                globalFRM = "Collection_Statement"
            Else
                MessageBoxEx.Show("No record selected...", "Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        rptReport.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    
    Private Sub rbnBank_CheckedChanged(sender As Object, e As EventArgs) Handles rbnBank.CheckedChanged
        If rbnBank.Checked = True Then
            cmbBank.Enabled = True
        Else
            cmbBank.Enabled = False
        End If
    End Sub
End Class