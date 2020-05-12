Imports DevComponents.DotNetBar.Controls

Public Class FrmPrint

    Private Sub FrmWorkerStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        If Me.Text = "Cash Account" Then
            lblTitle.Text = "Cash Accounts"
        ElseIf Me.Text = "Discount" Then
            lblTitle.Text = "Product Discount Print"
        ElseIf Me.Text = "Supplier Statement" Then
            lblTitle.Text = "Supplier Payment Statement"
        ElseIf Me.Text = "Profit Statement" Then
            lblTitle.Text = "Sales Profit Statement"
        ElseIf Me.Text = "Income Print" Then
            lblTitle.Text = "Income"
        ElseIf Me.Text = "Cash Transfer" Then
            lblTitle.Text = "Cash Transfer"
        ElseIf Me.Text = "Collection" Then
            lblTitle.Text = "Collection Statement"
        ElseIf Me.Text = "Others Income" Then
            lblTitle.Text = "Others Income Statement"
        ElseIf Me.Text = "Payment" Then
            lblTitle.Text = "Payment Statement"
        ElseIf Me.Text = "Income Statement" Then
            lblTitle.Text = "Income Statement"
        End If

    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim Reports As New FrmReports

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        If Me.Text = "Cash Account" Then
            globalFRM = "CashAccount"

            With FrmMain
                .btnPannel.Visible = True
                .LoadForm(FrmReports)
            End With

            Me.Close()

        ElseIf Me.Text = "Income Statement" Then
            globalFRM = "Income"

            RptStr = "SELECT A.Ac_Name, (SELECT SUM(Credit_Amt) FROM tbl_ac_ledger WHERE Ac_ID=A.Ac_ID AND DATE_FORMAT(Ledger_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(Ledger_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') AS Amt, " & _
                     "(SELECT SUM(Col_Amt) FROM tbl_collections WHERE Type_ID<>1 AND DATE_FORMAT(Col_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(Col_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') AS Col_Amt, " & _
                     "(SELECT SUM(Col_Amt) FROM tbl_collections WHERE Type_ID=1 AND DATE_FORMAT(Col_Date, '%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(Col_Date, '%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') AS Donation FROM tbl_accounts AS A WHERE A.Type_ID=7"
            With FrmMain
                .btnPannel.Visible = True
                .LoadForm(FrmReports)
            End With

            Me.Close()

        ElseIf Me.Text = "Discount" Then
            RptStr = "SELECT D.Barcode, D.Product_Name, DATE_FORMAT(D.Discount_Date,'%d-%b-%Y') AS Discount_Date, DATE_FORMAT(D.Issue_Date,'%d-%b-%Y') AS Issue_Date, CONCAT(D.Discount, '%') AS Discount, ((D.Discount*P.Sales_Price)/100)AS DiscountAmt FROM tbl_Discount AS D " & _
                     "INNER JOIN tbl_Products AS P ON D.Barcode=P.Barcode WHERE D.Issue_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND D.Issue_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY D.Issue_Date ASC"
            globalFRM = "Discount"

            Reports.Show()

        ElseIf Me.Text = "Supplier Statement" Then
            RptStr = "SELECT M.Mem_ID, M.Mem_Name, T.Type_Name, DATE_FORMAT(With_Date, '%d-%b-%Y') AS With_Date, W.Particulars, W.With_Amount FROM tbl_Withdraw AS W INNER JOIN tbl_Member AS M ON W.Mem_ID=M.Mem_ID INNER JOIN tbl_Type AS T ON T.Type_ID=M.Type_ID " & _
                     "WHERE W.With_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND W.With_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY W.With_Date ASC"
            globalFRM = "Withdraw"

            Reports.Show()

        ElseIf Me.Text = "Profit Statement" Then
            RptStr = "SELECT D.Barcode, D.Product_Name, P.Purchase_Price, D.Sales_Price, D.Qty, D.Discount_Amount, D.Sub_Total, D.Profit_Amt  FROM tbl_sales_details AS D INNER JOIN tbl_Sales AS S ON D.Sales_ID=S.Sales_ID " & _
                     "INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode WHERE S.Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND S.Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY Sales_Date ASC"
            globalFRM = "Profit_Statement"

            With FrmMain
                .btnPannel.Visible = True
                .LoadForm(FrmReports)
            End With

            Me.Close()

        ElseIf Me.Text = "Income Print" Then
            RptStr = "SELECT DATE_FORMAT(In_Date, '%d-%b-%Y') AS In_Date, In_Title, In_Details, In_Amt FROM tbl_Income " & _
                     "WHERE In_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND In_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY In_Date ASC"
            globalFRM = "Income Print"

            Reports.Show()

        ElseIf Me.Text = "Cash Transfer" Then
            RptStr = "SELECT T.Tr_ID, T.Tr_Date, (SELECT Cash_Name FROM tbl_cashbank WHERE Cash_ID=T.Tr_From) AS CashFrom, (SELECT Cash_Name FROM tbl_cashbank WHERE Cash_ID=T.Tr_To) AS CashTo, T.Tr_Details, T.Tr_Cheque, T.Tr_Carrier, T.Tr_Amt FROM tbl_transfer AS T " & _
                     "WHERE Date_FORMAT(T.Tr_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(T.Tr_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY T.Tr_Date ASC"
            globalFRM = "Cash Transfer"

            Reports.Show()

        ElseIf Me.Text = "Collection" Then
            RptStr = "SELECT Date_FORMAT(C.Col_Date,'%d-%b-%Y') AS Col_Date, M.Mem_ID, M.Mem_Name, T.Type_Details, Ca.Cash_Name, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C INNER JOIN tbl_Member AS M ON M.Mem_ID=C.Mem_ID INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID INNER JOIN tbl_cashbank AS Ca " & _
                     "ON C.Cash_ID=Ca.Cash_ID WHERE Date_FORMAT(C.Col_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(C.Col_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY C.Col_Date ASC"
            globalFRM = "Collections"

            Reports.Show()

        ElseIf Me.Text = "Others Income" Then
            RptStr = "SELECT Date_FORMAT(C.Col_Date,'%d-%b-%Y') AS Col_Date, C.Col_Name, T.Type_Details, Ca.Cash_Name, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID INNER JOIN tbl_cashbank AS Ca " & _
                     "ON C.Cash_ID=Ca.Cash_ID WHERE ISNULL(C.Mem_ID) AND (Date_FORMAT(C.Col_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(C.Col_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY C.Col_Date ASC"
            globalFRM = "Donation"

            Reports.Show()


        ElseIf Me.Text = "Payment" Then
            RptStr = "SELECT L.Ledger_Date, A.AC_Name, C.Cash_Name, L.Payment_Type, L.Cheque_No, L.Remarks, L.Credit_Amt FROM tbl_ac_ledger AS L INNER JOIN tbl_Accounts AS A ON L.Ac_ID=A.Ac_ID INNER JOIN tbl_cashbank AS C ON L.Cash_ID=C.Cash_ID " & _
                     "WHERE LEFT(L.Led_Particulars,7)='Receive' AND Date_FORMAT(L.Ledger_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Date_FORMAT(L.Ledger_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY L.Ledger_Date ASC"
            globalFRM = "Payment"

            Reports.Show()
        End If

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class