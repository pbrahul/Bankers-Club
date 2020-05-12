Imports DevComponents.DotNetBar

Public Class FrmCustomerPaymentDetails

    Public Sub RefreshCustomerPayment()
        txtSearch.Clear()
        sqlSTR = "SELECT P.Paid_ID, DATE_FORMAT(P.Paid_Date,'%d-%b-%Y') AS 'TransDate', C.Cust_ID, C.Cust_Name, P.Payment_Type, P.Bank_Name, P.Cheque_No, FORMAT(P.Paid_Taka,2) AS Paid_Amt, " & _
                 "P.Sales_ID, P.Discount FROM tbl_customers_paid AS P INNER JOIN tbl_Customers AS C ON P.Cust_ID=C.Cust_ID WHERE P.Paid_Date='" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY P.Paid_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPayment)

        lblTotal.Text = Format(GridTotal(dgvPayment, 7), "###,###.00")
    End Sub


    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpSupPayment.Width = (FrmMain.Width / 2) + 400
        grpSupPayment.Height = FrmMain.Height - 200
        grpSupPayment.Left = (Me.Width / 2) - 530
        grpSupPayment.Top = (FrmMain.Height / 2) - 340

        dtpDate.Left = grpSupPayment.Width - 245
        lblDate.Left = dtpDate.Left - 120

        dgvPayment.Width = grpSupPayment.Width - 30
        dgvPayment.Height = grpSupPayment.Height - 70

        lblTotal.Top = grpSupPayment.Height - 30
        lblTotal.Left = grpSupPayment.Width - 150
        lblTitle.Top = grpSupPayment.Height - 30
        lblTitle.Left = lblTotal.Left - 95
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCustomerPayment()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT P.Paid_ID, DATE_FORMAT(P.Paid_Date,'%d-%b-%Y') AS 'TransDate', C.Cust_ID, C.Cust_Name, P.Payment_Type, P.Bank_Name, P.Cheque_No, FORMAT(P.Paid_Taka,2) AS Paid_Amt, P.Sales_ID, P.Sales_ID, P.Discount FROM tbl_customers_paid AS P " & _
                 "INNER JOIN tbl_Customers AS C ON P.Cust_ID=C.Cust_ID WHERE LEFT(C.Cust_ID," & Len(txtSearch.Text) & " )='" & txtSearch.Text & "' OR C.Cust_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(C.Contact_No," & Len(txtSearch.Text) & " )='" & txtSearch.Text & "' ORDER BY P.Paid_Date ASC"
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
        RefreshCustomerPayment()
    End Sub
End Class