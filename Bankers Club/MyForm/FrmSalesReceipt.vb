Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmSalesReceipt

    Public Sub RefreshSales()
        txtSearch.Clear()
        sqlSTR = "SELECT S.Sales_ID, A.Ac_Name, DATE_FORMAT(S.Sales_Date, '%d-%b-%Y') AS 'SaleDate', FORMAT(S.Sub_Total, 2) AS 'SubTotal', FORMAT(S.Total_Vat, 2) AS VAT, FORMAT(S.Lb_Amt, 2) AS 'TotalDiscount', FORMAT(S.Grand_Total, 2) AS 'GrandTotal', FORMAT(S.Receive_Amount, 2) AS 'ReceiveAmonut', " & _
                 "FORMAT(S.Disount_Amount, 2) AS 'Discount', A.Ac_ID  FROM tbl_Sales AS S INNER JOIN tbl_accounts AS A ON S.Ac_ID = A.Ac_ID WHERE DATE_FORMAT(S.Sales_Date, '%Y/%m/%d')  = '" & Format(dtpSale.Value, "yyyy/MM/dd") & "' ORDER BY S.Sales_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvSales)

        If sqlDT.Rows.Count > 0 Then
            dgvSales.Focus()
            dgvSales.Rows(0).Selected = True

            sqlSTR = "SELECT S.Barcode, S.Product_Name, S.Qty, CONCAT(S.Qty_Pcs, ' Pcs') AS Qty_Pcs, FORMAT(S.Sales_Price, 2) AS Sales_Price, FORMAT(S.Vat_Amount, 2) AS VAT, FORMAT(S.Discount_Amount, 2) AS Discount, FORMAT(S.Sub_Total, 2) AS Sub_Total FROM tbl_Sales_Details AS S " & _
                     "INNER JOIN tbl_products AS P ON S.Barcode=P.Barcode  WHERE S.Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        Else
            dgvProduct.Rows.Clear()
        End If
    End Sub

    Public Sub SearchSales()
        sqlSTR = "SELECT S.Sales_ID, A.Ac_Name, DATE_FORMAT(S.Sales_Date, '%d-%b-%Y') AS 'SaleDate', FORMAT(S.Sub_Total, 2) AS 'SubTotal', FORMAT(S.Total_Vat, 2) AS VAT, FORMAT(S.Lb_Amt, 2) AS 'TotalDiscount', FORMAT(S.Grand_Total, 2) AS 'GrandTotal', FORMAT(S.Receive_Amount, 2) AS 'ReceiveAmonut', " & _
                 "FORMAT(S.Disount_Amount, 2) AS 'Discount', A.Ac_ID  FROM tbl_Sales AS S INNER JOIN tbl_accounts AS A ON S.Ac_ID = A.Ac_ID WHERE RIGHT(S.Ac_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR RIGHT(S.Sales_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "'"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvSales)

        If sqlDT.Rows.Count > 0 Then
            dgvSales.Focus()
            dgvSales.Rows(0).Selected = True

            sqlSTR = "SELECT Barcode, Product_Name, Qty, FORMAT(Sales_Price, 2) AS 'Product Price', FORMAT(Vat_Amount, 2) AS VAT, FORMAT(Discount_Amount, 2) AS Discount, " & _
                 "FORMAT(Sub_Total, 2) AS 'Sub Total' FROM tbl_Sales_Details WHERE Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        Else
            MessageBoxEx.Show("No Record(s) Found..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgvProduct.Rows.Clear()
            txtSearch.Clear()
            txtSearch.Select()
        End If
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpSales.Width = FrmMain.Width - 180
        grpSales.Height = FrmMain.Height - 180
        grpSales.Location = New Point(100, 30)

        dgvSales.Width = grpSales.Width - 45
        dgvProduct.Width = grpSales.Width - 52
        dgvProduct.Height = grpSales.Height - 375

        'dgvBarcode.Width = grpUser.Width - 40
        'dgvBarcode.Height = grpUser.Height - 120

        dtpSale.Left = grpSales.Width - 250
        lblPurchase.Left = dtpSale.Left - 100

        panButton.Top = dgvProduct.Bottom + 5
        panButton.Left = (grpSales.Width / 2) - 115
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpSale.Value = Today.Date
        RefreshSales()
    End Sub

    Private Sub dtpPurchase_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpSale.ValueChanged
        RefreshSales()
    End Sub

    Private Sub lstSales_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvSales.MouseClick
        If dgvSales.SelectedRows.Count > 0 Then
            sqlSTR = "SELECT S.Barcode, S.Product_Name, S.Qty, CONCAT(S.Qty_Pcs, ' Pcs') AS Qty_Pcs, FORMAT(S.Sales_Price, 2) AS Sales_Price, FORMAT(S.Vat_Amount, 2) AS VAT, FORMAT(S.Discount_Amount, 2) AS Discount, FORMAT(S.Sub_Total, 2) AS Sub_Total FROM tbl_Sales_Details AS S " & _
                     "INNER JOIN tbl_products AS P ON S.Barcode=P.Barcode  WHERE S.Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        End If

    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        If dgvSales.SelectedRows.Count > 0 Then
            sqlSTR = "SELECT Void, Exchange_Status FROM tbl_Sales WHERE Sales_ID = '" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows(0)("Void") = "Yes" Or sqlDT.Rows(0)("Exchange_Status") = "Yes" Then
                MessageBoxEx.Show("Sale receipt already Void or Exchange. Please select another receipt.", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                With FrmSalesReturn
                    .txtInvoice.Text = dgvSales.SelectedRows(0).Cells(0).Value
                    .ShowDialog()
                End With
            End If
        Else
            MessageBoxEx.Show("Please Select a Sales Product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchSales()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvSales.SelectedRows.Count > 0 Then
            'RptStr = "SELECT A.Ac_Name, S.Sales_ID, S.Sales_Date, D.Barcode, D.Product_Name, D.Sales_Price, D.Qty, D.Sub_Total AS sTotal, S.Sub_Total, S.Total_Discount, S.Total_Vat, S.Lb_Amt, S.Disount_Amount, " & _
            '         "S.Grand_Total, S.Receive_Amount, S.Change_Amount, (SELECT Bal_Amt FROM tbl_Ac_Ledger WHERE Sales_ID=S.Sales_ID LIMIT 1) AS Due_Amount, U.UserName FROM tbl_Sales AS S " & _
            '         "INNER JOIN tbl_sales_details AS D ON D.Sales_ID=S.Sales_ID INNER JOIN tbl_Accounts AS A ON A.Ac_ID=S.Ac_ID INNER JOIN tbl_Users AS U ON U.User_ID=S.User_ID WHERE S.Sales_ID ='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            RptStr = "SELECT A.Ac_ID, A.Ac_Name, A.Ac_Address, A.Contact_No, S.Sales_ID, S.Memo_No, S.Sales_Date, S.Sub_total, S.Disount_Amount, S.Lb_Amt, S.Grand_Total, S.Receive_Amount, D.Barcode, D.Product_Name, D.Qty, P.Units, " & _
                     "D.Qty_Pcs, D.Sales_Price, D.Sub_Total AS PrdTotal, U.UserName FROM didarenterprise_db.tbl_sales AS S INNER JOIN tbl_sales_details AS D ON S.Sales_ID=D.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode " & _
                     "INNER JOIN tbl_Accounts AS A ON S.Ac_ID=A.Ac_ID INNER JOIN tbl_users AS U ON S.User_ID=U.User_ID WHERE S.Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            mReport.Load(Application.StartupPath & "\MyReports\rptInvoice.rpt")
            mReport.SetDataSource(ExecuteSQLQuery(RptStr))

            FrmReports.CompanyInfo()

            For Each rptPrinter In PrinterSettings.InstalledPrinters
                If rptPrinter = "POS Printer" Then
                    mReport.PrintOptions.PrinterName = rptPrinter
                    Exit For
                End If
            Next

            mReport.PrintToPrinter(1, True, 0, 0)
        Else
            MessageBoxEx.Show("No Record Select For Print. Please Select One!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim SelectDate As Date
        Dim Debit_Amt, Credit_Amt As Double
        Dim Ac_ID, Ledger_ID As String
        'Dim PaidAmount As Double
        'Dim DueAmount As Double

        If dgvSales.SelectedRows.Count > 0 Then
            'If MessageBoxEx.Show("Do you want to delete this receipt?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            '    sqlSTR = "SELECT Void, Exchange_Status FROM tbl_sales WHERE Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            '    ExecuteSQLQuery(sqlSTR)

            '    If sqlDT.Rows(0)("Void") = "Yes" Or sqlDT.Rows(0)("Exchange_Status") = "Yes" Then
            '        MessageBoxEx.Show("Sale receipt already void. Please select another receipt.", "Sale Receipt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    Else
            '        SelectDate = FormatDateTime(dgvSales.SelectedRows(0).Cells(2).Value)

            '        sqlSTR = "SELECT Cust_ID, (SELECT Cust_ID FROM tbl_Customers ORDER BY Cust_ID ASC LIMIT 1) AS TopCust FROM tbl_Customers WHERE Cust_ID = '" & dgvSales.SelectedRows(0).Cells(10).Value & "'"
            '        ExecuteSQLQuery(sqlSTR)

            '        If sqlDT.Rows(0)("TopCust") <> sqlDT.Rows(0)("Cust_ID") Then
            '            sqlSTR = "SELECT Paid_Taka, Due_Amt FROM tbl_customers_paid WHERE Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            '            ExecuteSQLQuery(sqlSTR)

            '            If sqlDT.Rows.Count > 0 Then
            '                PaidAmount = sqlDT.Rows(0)("Paid_Taka")
            '                DueAmount = (CDbl(dgvSales.SelectedRows(0).Cells(6).Value) - CDbl(dgvSales.SelectedRows(0).Cells(8).Value)) - PaidAmount
            '            End If

            '            sqlSTR = "SELECT Paid_ID FROM tbl_customers_paid WHERE Paid_Date>'" & Format(SelectDate, "yyyy/MM/dd") & "' AND Cust_ID='" & dgvSales.SelectedRows(0).Cells(10).Value & _
            '                     "' ORDER BY LPAD(LOWER(Sales_ID), 10,0) ASC"
            '            ExecuteSQLQuery(sqlSTR)

            '            For i As Integer = 0 To sqlDT.Rows.Count - 1
            '                sqlSTR = "UPDATE tbl_customers_paid SET Due_Amt=Due_Amt-" & CDbl(DueAmount) & " WHERE Paid_ID='" & sqlDT.Rows(i)("Paid_ID") & "'"
            '                GetSQLQuery(sqlSTR)
            '            Next

            '            sqlSTR = "UPDATE tbl_Customers SET Due_Amount=Due_Amount-" & CDbl(DueAmount) & " WHERE Cust_ID='" & dgvSales.SelectedRows(0).Cells(10).Value & "'"
            '            ExecuteSQLQuery(sqlSTR)
            '        Else
            '            PaidAmount = CDbl(dgvSales.SelectedRows(0).Cells(7).Value) - (CDbl(dgvSales.SelectedRows(0).Cells(8).Value) + CDbl(dgvSales.SelectedRows(0).Cells(9).Value))
            '        End If


            '        '========= Return Stock=========
            '        sqlSTR = "SELECT Barcode, Qty FROM tbl_Sales_Details WHERE Sales_ID = '" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
            '        ExecuteSQLQuery(sqlSTR)

            '        Dim Stock_To_Update(0) As String
            '        Dim counter As Integer = 0

            '        For X = 0 To sqlDT.Rows.Count - 1
            '            ReDim Preserve Stock_To_Update(counter)
            '            Stock_To_Update(counter) = "UPDATE tbl_Stock_Products SET Qty = Qty+'" & sqlDT.Rows(X)("Qty") & "' WHERE Barcode = '" & sqlDT.Rows(X)("Barcode") & "'"
            '            counter += 1
            '        Next

            '        For X = 0 To UBound(Stock_To_Update)
            '            If Len(Stock_To_Update(X)) > 0 Then
            '                ExecuteSQLQuery(Stock_To_Update(X))
            '            End If
            '        Next


            '        '============== tbl_Sales_Return =============
            '        sqlSTR = "INSERT INTO tbl_sales_return(Rtn_Date, Rtn_Amt, Sales_ID, Cust_ID, User_ID) VALUES('" & Format(Now, "yyyy/MM/dd") & "', " & CDbl(PaidAmount) & ", '" & dgvSales.SelectedRows(0).Cells(0).Value & "', '" & dgvSales.SelectedRows(0).Cells(10).Value & "', '" & UserID & "')"
            '        ExecuteSQLQuery(sqlSTR)

            '        ''============= tbl_Balance ==================
            '        ''sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
            '        ''ExecuteSQLQuery(sqlSTR)

            '        ''For i As Integer = 0 To sqlDT.Rows.Count - 1
            '        ''    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(PaidAmount) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
            '        ''    GetSQLQuery(sqlSTR)
            '        ''Next


            '        '============= tbl_Balance ==================
            '        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(Now, "yyyy/MM/dd") & "'"
            '        ExecuteSQLQuery(sqlSTR)

            '        If sqlDT.Rows.Count > 0 Then
            '            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(PaidAmount) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
            '            ExecuteSQLQuery(sqlSTR)
            '        Else
            '            sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(Now, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
            '            ExecuteSQLQuery(sqlSTR)

            '            If sqlDT.Rows.Count > 0 Then
            '                BalAmt = sqlDT.Rows(0)("Bal_Amt")
            '            Else
            '                BalAmt = 0
            '            End If

            '            sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) - CDbl(PaidAmount) & ", '" & Format(Now, "yyyy/MM/dd") & "')"
            '            ExecuteSQLQuery(sqlSTR)
            '        End If

            '        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(Now, "yyyy/MM/dd") & "'"
            '        ExecuteSQLQuery(sqlSTR)

            '        For i As Integer = 0 To sqlDT.Rows.Count - 1
            '            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(PaidAmount) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
            '            GetSQLQuery(sqlSTR)
            '        Next

            '        ExecuteSQLQuery("DELETE FROM tbl_customers_paid WHERE Sales_ID = '" & dgvSales.SelectedRows(0).Cells(0).Value & "'")
            '        'ExecuteSQLQuery("DELETE FROM tbl_Sales_Details WHERE Sales_ID = '" & dgvSales.SelectedRows(0).Cells(0).Value & "'")
            '        ExecuteSQLQuery("UPDATE tbl_Sales SET Void='Yes' WHERE Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'")

            '        RefreshSales()
            '    End If
            'End If


            If ConfirmDelete(dgvSales) = True Then
                sqlSTR = "SELECT Ledger_ID, Ac_ID, Cash_ID, Ledger_Date, Debit_Amt, Credit_Amt FROM tbl_Ac_Ledger WHERE Sales_ID='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    SelectDate = sqlDT.Rows(0)("Ledger_Date")
                    Debit_Amt = sqlDT.Rows(0)("Credit_Amt")
                    Ac_ID = sqlDT.Rows(0)("Ac_ID")
                Else
                    Debit_Amt = 0
                End If

                If sqlDT.Rows.Count > 1 Then
                    Credit_Amt = sqlDT.Rows(1)("Debit_Amt")
                    Cash_ID = sqlDT.Rows(1)("Cash_ID")
                    Ledger_ID = sqlDT.Rows(1)("Ledger_ID")
                Else
                    Credit_Amt = 0
                    Cash_ID = 0
                    Ledger_ID = 0
                End If


                '========== tbl_Ac_Ledger =============
                sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & Ac_ID & "' AND Ledger_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt-" & (CDbl(Debit_Amt) - CDbl(Credit_Amt)) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                    GetSQLQuery(sqlSTR)
                Next

                sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = Bal_Amt-" & (CDbl(Debit_Amt) - CDbl(Credit_Amt)) & " WHERE Ac_ID = '" & Ac_ID & "'"
                ExecuteSQLQuery(sqlSTR)


                '============= tbl_CashBank ============
                sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt-" & CDbl(Credit_Amt) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                    GetSQLQuery(sqlSTR)
                Next

                sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt- " & CDbl(Credit_Amt) & " WHERE Cash_ID = '" & Cash_ID & "'"
                ExecuteSQLQuery(sqlSTR)


                '============= tbl_Balance ===========
                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(Credit_Amt) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                    GetSQLQuery(sqlSTR)
                Next


                '============= tbl_Product_History ===========
                For Each LI As DataGridViewRow In dgvProduct.Rows
                    sqlSTR = "SELECT Hy_ID FROM tbl_product_history WHERE Barcode='" & LI.Cells(0).Value & "' AND Hy_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                    ExecuteSQLQuery(sqlSTR)

                    For i As Integer = 0 To sqlDT.Rows.Count - 1
                        sqlSTR = "UPDATE tbl_product_history SET Bal_Qty=Bal_Qty+" & CDbl(LI.Cells(2).Value) & " WHERE Hy_ID=" & sqlDT.Rows(i)("Hy_ID")
                        GetSQLQuery(sqlSTR)
                    Next

                    sqlSTR = "UPDATE tbl_Stock_Products SET  Qty = Qty + " & CDbl(LI.Cells(2).Value) & " WHERE Barcode = '" & LI.Cells(0).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                Next


                '============= Delete ===========
                sqlSTR = "DELETE FROM tbl_Ac_Ledger WHERE Sales_ID ='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Ledger_ID ='" & Ledger_ID & "'"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "DELETE FROM tbl_product_history WHERE Sales_ID ='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "DELETE FROM tbl_Sales_Details WHERE Sales_ID ='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "DELETE FROM tbl_Sales WHERE Sales_ID ='" & dgvSales.SelectedRows(0).Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)
            End If

            '.RefreshPurchase()
        Else
            MessageBoxEx.Show("No Record Select For Delete. Please Select One!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub
End Class