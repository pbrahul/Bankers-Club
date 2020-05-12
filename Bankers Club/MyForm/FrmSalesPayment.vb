Imports DevComponents.DotNetBar
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing

Public Class FrmSalesPayment
    Dim TotalAmount, ChangeTK As Double

    Dim ParamCollection As New CrystalDecisions.Shared.ParameterValues

    Public Sub CompanyInfo()
        ParamCollection.Add(PrmName)
        mReport.DataDefinition.ParameterFields("prmCompany").ApplyCurrentValues(ParamCollection)

        ParamCollection.Add(PrmAddress)
        mReport.DataDefinition.ParameterFields("prmAddress").ApplyCurrentValues(ParamCollection)

        ParamCollection.Add(PrmContact)
        mReport.DataDefinition.ParameterFields("prmContact").ApplyCurrentValues(ParamCollection)

        'ParamCollection.Add(PrmPicPath)
        'mReport.DataDefinition.ParameterFields("PicPath").ApplyCurrentValues(ParamCollection)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Payment"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(330, 205)
        txtDiscount.Clear()
        txtReceive.Clear()
        txtReceive.Select()
        txtDiscount.Text = 0
        lblTotal.ForeColor = Color.White
        lblTotal.Text = "TK " & Format(GrandTotal, "###,###.00")

        'If Split(Me.Text, " - ")(1) = "Add" Then
        'End If

    End Sub

    Private Sub txtReceive_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReceive.KeyPress
        NumKey(txtReceive.Text, e)
    End Sub

    Private Sub txtReceive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceive.TextChanged
        If txtReceive.Text = "" Then
            txtChange.Text = Format(0 - CDbl(GrandTotal), "###,###.00")
            ChangeTK = txtChange.Text
        Else
            txtChange.Text = Format(CDbl(txtReceive.Text) - CDbl(GrandTotal), "###,###.00")
            ChangeTK = txtChange.Text
        End If

        If txtDiscount.Text <> "" Then
            txtChange.Text = Format(CDbl(ChangeTK) + CDbl(txtDiscount.Text), "###,###.00")
        End If


    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If txtDiscount.Text <> "" Then
            txtChange.Text = Format(CDbl(ChangeTK) + CDbl(txtDiscount.Text), "###,###.00")
        Else
            txtReceive_TextChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim SalesDetailsID As String

        If txtReceive.Text = "" Then
            MessageBoxEx.Show("Insufficient Cash Amount Receive !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Highlighter1.SetHighlightColor(txtReceive, Validator.eHighlightColor.Red)
            txtReceive.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtReceive, Validator.eHighlightColor.None)
        End If

        If CDbl(txtChange.Text) < 0 Then
            MessageBoxEx.Show("Insufficient Cash Amount Receive !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Highlighter1.SetHighlightColor(txtReceive, Validator.eHighlightColor.Red)
            txtReceive.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtReceive, Validator.eHighlightColor.None)
        End If

        '=========== Sales =============
        With FrmSales
            If .cmbType.SelectedIndex = 0 Then
                GetID = YearIDPreFix("tbl_Sales", "Sales_ID", PreFix)

                sqlSTR = "INSERT INTO tbl_Sales(Sales_ID, Sales_Date, Void, Sub_Total, Total_Vat, Total_Discount, Grand_Total, Receive_Amount, Change_Amount, Disount_Amount, Cust_ID, Order_No, User_ID) " & _
                         "VALUES ('" & GetID & "', '" & Format(Now, "yyyy/MM/dd") & "', 'No', " & CDbl(.lblSubTotal.Text) & ", " & CDbl(.lblVat.Text) & ", " & CDbl(.lblDiscount.Text) & ", " & CDbl(GrandTotal) & ", " & CDbl(txtReceive.Text) & _
                         ", " & CDbl(txtChange.Text) & ", " & CDbl(txtDiscount.Text) & ", '" & CustID & "',  '0', '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                For Each dgv As DataGridViewRow In .dgvSales.Rows
                    SalesDetailsID = YearIDPreFix("tbl_Sales_Details", "Sales_Details_ID", PreFix)

                    sqlSTR = "INSERT INTO tbl_Sales_Details(Sales_Details_ID, Sales_ID, Barcode, Product_Name, Qty, Sales_Price, Discount_Amount, Vat_Amount, Sub_Total, Profit_Amt) " & _
                             "VALUES ('" & SalesDetailsID & "', '" & GetID & "', '" & dgv.Cells(0).Value & "', '" & dgv.Cells(1).Value & "', " & CDbl(dgv.Cells(2).Value) & _
                             ", " & CDbl(dgv.Cells(4).Value) & ", " & CDbl(dgv.Cells(5).Value) & ", " & CDbl(dgv.Cells(6).Value) & ", " & CDbl(dgv.Cells(7).Value) & ", " & (CDbl(dgv.Cells(7).Value) - CDbl(dgv.Cells(5).Value)) - CDbl(dgv.Cells(8).Value) & ")"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE TBL_Stock_Products SET QTY = QTY - " & CDbl(dgv.Cells(2).Value) & " WHERE Barcode = '" & dgv.Cells(0).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                Next
            End If
        End With

        '============= tbl_Balance ==================

        Dim PaidAmt As Double
        PaidAmt = CDbl(txtReceive.Text) - CDbl(txtChange.Text)

        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(Now, "yyyy/MM/dd") & "'"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(PaidAmt) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
            ExecuteSQLQuery(sqlSTR)
        Else
            sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(Now, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                BalAmt = sqlDT.Rows(0)("Bal_Amt")
            Else
                BalAmt = 0
            End If

            sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) + CDbl(PaidAmt) & ", '" & Format(Now, "yyyy/MM/dd") & "')"
            ExecuteSQLQuery(sqlSTR)
        End If

        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(Now, "yyyy/MM/dd") & "'"
        ExecuteSQLQuery(sqlSTR)

        For i As Integer = 0 To sqlDT.Rows.Count - 1
            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(PaidAmt) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
            GetSQLQuery(sqlSTR)
        Next

        'MessageBoxEx.Show("Purchase Success !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        With FrmSales
            ExecuteSQLQuery("SELECT Cust_Name FROM tbl_Customers ORDER BY Cust_ID ASC LIMIT 1")
            If sqlDT.Rows.Count > 0 Then
                .txtCustomer.Text = sqlDT.Rows(0)("Cust_Name")
            Else
                .txtCustomer.Text = ""
            End If
            .cmbType.SelectedIndex = 0
            .lblSubTotal.Text = "0.00"
            .lblDiscount.Text = "0.00"
            .lblVat.Text = "0.00"
            .lblGrandTotal.Text = "TK 0.00"
            .dgvSales.Rows.Clear()
            .txtBarcode.Focus()
        End With

        RptStr = "SELECT C.Cust_Name, S.Sales_ID, S.Sales_Date, D.Barcode, D.Product_Name, D.Sales_Price, D.Qty, D.Sub_Total AS sTotal, S.Sub_Total, S.Total_Vat, S.Disount_Amount, S.Total_Discount, " & _
                 "S.Grand_Total, S.Receive_Amount, S.Change_Amount, C.Due_Amount, IFNULL((SELECT Due_Amt FROM tbl_customers_paid WHERE Sales_ID=S.Sales_ID),0) AS Due_Amount, U.UserName FROM tbl_Sales AS S " & _
                 "INNER JOIN tbl_sales_details AS D ON S.Sales_ID=D.Sales_ID INNER JOIN tbl_Customers AS C ON S.Cust_ID=C.Cust_ID INNER JOIN tbl_Users AS U ON S.User_ID=U.User_ID WHERE S.Sales_ID ='" & GetID & "'"
        mReport.Load(Application.StartupPath & "\MyReports\rptReceipt.rpt")
        mReport.SetDataSource(ExecuteSQLQuery(RptStr))

        CompanyInfo()

        For Each rptPrinter In PrinterSettings.InstalledPrinters
            If rptPrinter = "POS Printer" Then
                mReport.PrintOptions.PrinterName = rptPrinter
                Exit For
            End If
        Next

        mReport.PrintToPrinter(1, True, 0, 0)

        sqlSTR = "SELECT S.Barcode, S.Product_Name, S.Qty, P.Reorder_Label FROM tbl_Stock_Products AS S INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode " & _
                 "WHERE S.Qty <= P.Reorder_Label"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            With FrmSales
                .lblReach.ForeColor = Color.Red
                .Timer1.Enabled = True
            End With
        End If

        Me.Close()
    End Sub
End Class