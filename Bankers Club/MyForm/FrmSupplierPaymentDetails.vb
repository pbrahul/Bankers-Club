Imports DevComponents.DotNetBar

Public Class FrmSupplierPaymentDetails

    Public Sub RefreshSupplierPayment()
        txtSearch.Clear()
        sqlSTR = "SELECT T.Transcation_ID, DATE_FORMAT(T.Transaction_Date,'%d-%b-%Y') AS 'TransDate', S.Supp_ID, S.Supp_Name, T.Payment_Type, T.Bank_Name, T.Cheque_No, FORMAT(T.Paid_Taka,2) AS Paid_Amt, T.Purchase_ID, T.Discount FROM tbl_Supplier_Transaction AS T " & _
                 "INNER JOIN tbl_Suppliers AS S ON T.Supp_ID=S.Supp_ID WHERE T.Transaction_Date='" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY T.Transaction_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPayment)

        lblTotal.Text = Format(GridTotal(dgvPayment, 7), "###,###.00")
    End Sub


    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpSupPayment.Width = (FrmMain.Width / 2) + 400
        grpSupPayment.Height = FrmMain.Height - 200
        grpSupPayment.Left = (Me.Width / 2) - 530
        grpSupPayment.Top = (FrmMain.Height / 2) - 340

        dtpDate.Left = grpSupPayment.Width - 245
        lblDate.Left = dtpDate.Left - 70

        dgvPayment.Width = grpSupPayment.Width - 35
        dgvPayment.Height = grpSupPayment.Height - 74

        lblTotal.Top = grpSupPayment.Height - 35
        lblTotal.Left = grpSupPayment.Width - 195
        lblTitle.Top = grpSupPayment.Height - 30
        lblTitle.Left = lblTotal.Left - 95
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshSupplierPayment()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT T.Transcation_ID, DATE_FORMAT(T.Transaction_Date,'%d-%b-%Y') AS 'TransDate', S.Supp_ID, S.Supp_Name, T.Payment_Type, T.Bank_Name, T.Cheque_No, FORMAT(T.Paid_Taka,2) AS Paid_Amt, T.Purchase_ID, T.Discount FROM tbl_Supplier_Transaction AS T " & _
                 "INNER JOIN tbl_Suppliers AS S ON T.Supp_ID=S.Supp_ID WHERE LEFT(S.Supp_ID," & Len(txtSearch.Text) & " )='" & txtSearch.Text & "' OR S.Supp_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(S.Contact_No," & Len(txtSearch.Text) & " )='" & txtSearch.Text & "' ORDER BY T.Transaction_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPayment)

        lblTotal.Text = Format(GridTotal(dgvPayment, 7), "###,###.00")

        If sqlDT.Rows.Count = 0 Then
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshSupplierPayment()
    End Sub
End Class