Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmCollectionList

    Public Sub RefreshCollections()
        If tabMain.SelectedTabIndex = 0 Then
            txtSearch.Clear()

            sqlSTR = "SELECT C.Col_ID, '', DATE_FORMAT(C.Col_Date, '%d-%b-%Y') AS Col_Date, M.Mem_Name, Ca.Cash_Name, C.Collection_Type, C.Cheque_No, CONCAT(C.Fee_Type, '-', C.Col_Year) AS Col_Type, FORMAT(C.Col_Amt,2) AS Debit_Amt, M.Mem_ID FROM tbl_Collections AS C " & _
                     "INNER JOIN tbl_Member AS M ON C.Mem_ID=M.Mem_ID INNER JOIN tbl_cashbank AS Ca ON C.Cash_ID=Ca.Cash_ID WHERE DATE_FORMAT(C.Col_Date, '%Y/%m/%d')='" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCollection)

            lblTotal.Text = Format(GridTotal(dgvCollection, 8), "###,###.00")

            'txtSearch.Select()

        ElseIf tabMain.SelectedTabIndex = 1 Then
            txtSearch.Clear()

            sqlSTR = "SELECT C.Col_ID, DATE_FORMAT(C.Col_Date, '%d-%b-%Y') AS Col_Date, C.Col_Name, Ca.Cash_Name, C.Collection_Type, T.Type_Details, FORMAT(C.Col_Amt,2) AS Debit_Amt FROM tbl_Collections AS C " & _
                     "JOIN tbl_cashbank AS Ca ON C.Cash_ID=Ca.Cash_ID INNER JOIN tbl_Collection_Type AS T ON T.Type_ID=C.Type_ID WHERE DATE_FORMAT(C.Col_Date, '%Y/%m/%d')='" & Format(dtpDonation.Value, "yyyy/MM/dd") & "' AND ISNULL(C.Mem_ID)"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvDonation)

            txtSearch.Select()
        End If
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panProducts.Width = FrmMain.Width - 180
        panProducts.Height = FrmMain.Height - 180
        panProducts.Location = New Point(100, 30)

        '=========== Receive ========================
        dgvCollection.Width = panProducts.Width - 245
        dgvCollection.Height = panProducts.Height - 125

        dtpDate.Left = dgvCollection.Width - 200
        lblType.Left = dtpDate.Left - 60

        lblTotal.Top = dgvCollection.Bottom + 7
        lblTotal.Left = dgvCollection.Right - 120

        lblTitle.Top = dgvCollection.Bottom + 7
        lblTitle.Left = lblTotal.Left - 70

        '=========== Donation =======================
        panExistTitle.Width = panProducts.Width - 240
        panPatient.Width = panProducts.Width - 240

        dgvDonation.Width = panProducts.Width - 245
        dgvDonation.Height = panProducts.Height - 100

        dtpDonation.Left = dgvDonation.Width - 200
        lblDonation.Left = dtpDonation.Left - 60
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCollections()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.ButtonCustomClick
        sqlSTR = "SELECT C.Col_ID, '', DATE_FORMAT(C.Col_Date, '%d-%b-%Y') AS Col_Date, M.Mem_Name, Ca.Cash_Name, C.Collection_Type, C.Cheque_No, CONCAT(C.Fee_Type, '-', C.Col_Year) AS Col_Type, FORMAT(C.Col_Amt,2) AS Debit_Amt, M.Mem_ID FROM tbl_Collections AS C " & _
                 "INNER JOIN tbl_Member AS M ON C.Mem_ID=M.Mem_ID INNER JOIN tbl_cashbank AS Ca ON C.Cash_ID=Ca.Cash_ID WHERE  Type_ID<>1 AND (RIGHT(M.Mem_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & _
                 "' OR M.Mem_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR M.Bank_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(M.Mem_Contact, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "') ORDER BY C.Col_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCollection)

        If sqlDT.Rows.Count = 0 Then
            dgvCollection.Rows.Clear()
            txtSearch.Select()
            lblTotal.Text = "0.00"
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            lblTotal.Text = Format(GridTotal(dgvCollection, 8), "###,###.00")
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dgvCollection_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvCollection.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim rptReports As New FrmReports

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 1 Then
            RptStr = "SELECT C.Col_ID, C.Col_Date, C.Bank_Name, C.Cheque_Date, C.Collection_Type, M.Mem_ID, M.Mem_Name, CONCAT(T.Type_Details, ' - ', C.Col_Year) AS Type_Details, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C " & _
                     "INNER JOIN tbl_Member AS M ON M.Mem_ID=C.Mem_ID INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID WHERE C.Col_ID='" & dgvCollection.SelectedRows(0).Cells(0).Value & "'"
            globalFRM = "Receipt"

            rptReports.Show()
        End If
    End Sub


    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshCollections()
    End Sub

    Private Sub tabMain_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles tabMain.SelectedTabChanged
        RefreshCollections()
    End Sub

    Private Sub txtSearchDonation_Click(sender As Object, e As EventArgs) Handles txtSearchDonation.ButtonCustomClick
        sqlSTR = "SELECT C.Col_ID, DATE_FORMAT(C.Col_Date, '%d-%b-%Y') AS Col_Date, C.Col_Name, Ca.Cash_Name, C.Collection_Type, T.Type_Details, FORMAT(C.Col_Amt,2) AS Debit_Amt FROM tbl_Collections AS C " & _
                     "JOIN tbl_cashbank AS Ca ON C.Cash_ID=Ca.Cash_ID INNER JOIN tbl_Collection_Type AS T ON T.Type_ID=C.Type_ID WHERE ISNULL(C.Mem_ID) AND C.Col_Name REGEXP '[[:<:]]" & txtSearchDonation.Text & "[[:>:]]' ORDER BY C.Col_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvDonation)

        If sqlDT.Rows.Count = 0 Then
            dgvDonation.Rows.Clear()
            txtSearchDonation.Select()
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtDonatioSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchDonation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSearchDonation_Click(Nothing, Nothing)
        End If
    End Sub

  
    Private Sub dtpDonation_ValueChanged(sender As Object, e As EventArgs) Handles dtpDonation.ValueChanged
        RefreshCollections()
    End Sub
End Class