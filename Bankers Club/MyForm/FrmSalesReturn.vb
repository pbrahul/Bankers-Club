Imports DevComponents.DotNetBar

Public Class FrmSalesReturn
    Dim VatAmount, TotalVat, PrdTotal, Purchase_Price As Double
    Dim VatUse As String
    Dim xStock As Integer
    Dim ProductFound As Boolean
    Dim ProductDiscout As Double

    Public Sub TotalAmount()
        lblSubTotal.Text = Format(GridTotal(dgvSales, 6), "###,###.00")
        lblDiscount.Text = Format(GridTotal(dgvSales, 4), "###,###.00")
        lblVat.Text = Format(GridTotal(dgvSales, 5), "###,###.00")
        lblGrandTotal.Text = "TK " & Format(CDbl(lblSubTotal.Text) + CDbl(lblVat.Text) - CDbl(lblDiscount.Text), "###,###.00")
        GrandTotal = CDbl(lblSubTotal.Text) + CDbl(lblVat.Text) - CDbl(lblDiscount.Text)
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmSalesReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(740, 530)
        dtpReturn.Value = Today.Date

        ExecuteSQLQuery("SELECT * FROM tbl_VAT")
        If sqlDT.Rows.Count > 0 Then
            VatUse = sqlDT.Rows(0)("Use_Vat")
            VatAmount = sqlDT.Rows(0)("Vat_Amount")
        End If

        dgvSales.Rows.Clear()
        txtBarcode.Clear()
        txtBarcode.Select()

        sqlSTR = "SELECT A.Ac_ID, A.AC_Name, D.Barcode, D.Product_Name, D.Sales_Price, D.Vat_Amount, " & _
                 "D.Discount_Amount, D.Sub_Total, S.Sub_Total AS Total, S.Total_Vat, S.Total_Discount, " & _
                 "S.Grand_Total, (S.Receive_Amount-S.Change_Amount) AS PaidTK, S.Disount_Amount, D.Qty, D.Profit_Amt FROM tbl_Sales AS S INNER JOIN " & _
                 "tbl_Sales_Details AS D ON S.Sales_ID = D.Sales_ID INNER JOIN tbl_Accounts AS A ON S.Ac_ID = A.Ac_ID " & _
                 "WHERE (S.Sales_ID = '" & txtInvoice.Text & "')"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            txtID.Text = sqlDT.Rows(0)("Ac_ID")
            txtCustomer.Text = sqlDT.Rows(0)("Ac_Name")
            lblSubTotal.Text = Format(sqlDT.Rows(0)("Total"), "###,###.00")
            lblDiscount.Text = Format(sqlDT.Rows(0)("Total_Discount"), "###,###.00")
            lblVat.Text = Format(sqlDT.Rows(0)("Total_Vat"), "###,###.00")
            lblReceive.Text = Format(sqlDT.Rows(0)("PaidTK"), "###,###.00")
            lblDiscount2.Text = Format(sqlDT.Rows(0)("Disount_Amount"), "###,###.00")
            lblGrandTotal.Text = "TK " & Format(sqlDT.Rows(0)("Grand_Total"), "###,###.00")
            GrandTotal = sqlDT.Rows(0)("Grand_Total")

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                dgvSales.Rows.Add(sqlDT.Rows(i)("Barcode"), sqlDT.Rows(i)("Product_Name"), sqlDT.Rows(i)("Qty"), Format(sqlDT.Rows(i)("Sales_Price"), "###,###.00"), Format(sqlDT.Rows(i)("Discount_Amount"), "###,###.00"), Format(sqlDT.Rows(i)("Vat_Amount"), "###,###.00"), Format(sqlDT.Rows(i)("Sub_Total"), "###,###.00"), _
                                  Format(((sqlDT.Rows(i)("Sub_Total") - sqlDT.Rows(i)("Discount_Amount")) - sqlDT.Rows(i)("Profit_Amt")), "###,###.00"))
            Next
        End If
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            xStock = 0
            ProductFound = False

            sqlSTR = "SELECT P.Barcode, P.Product_Name, P.Sales_Price, P.Reorder_Label, P.Vat, P.Purchase_Price, " & _
                     "S.Qty, IFNULL((SELECT Discount FROM tbl_Discount WHERE (Barcode=P.Barcode AND Discount_Date>=DATE_FORMAT(Now(), '%Y/%m/%d'))),0) AS Discount, " & _
                     "IFNULL((SELECT Qty FROM tbl_Sales_Details WHERE Barcode=P.Barcode AND Sales_ID='" & txtInvoice.Text & "'), 0) AS ReturnQty " & _
                     "FROM tbl_Products AS P INNER JOIN tbl_Stock_Products AS S ON P.Barcode = S.Barcode WHERE P.Barcode = '" & txtBarcode.Text & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                If VatUse = "Yes" Then
                    VatAmount = VatAmount
                Else
                    VatAmount = sqlDT.Rows(0)("Vat")
                End If

                ProductDiscout = (sqlDT.Rows(0)("Sales_Price") * sqlDT.Rows(0)("Discount")) / 100
                TotalVat = (sqlDT.Rows(0)("Sales_Price") * VatAmount) / 100
                PrdTotal = sqlDT.Rows(0)("Sales_Price") ' (sqlDT.Rows(0)("Sales_Price") + TotalVat) - ProductDiscout
                Purchase_Price = sqlDT.Rows(0)("Purchase_Price")

                With dgvSales
                    For i = 0 To .Rows.Count - 1
                        If UCase(.Rows(i).Cells(0).Value) = UCase(txtBarcode.Text) Then
                            ProductFound = True
                            xStock = .Rows(i).Cells(2).Value
                        End If
                    Next
                End With

                If (CDbl(sqlDT.Rows(0)("QTY")) + CDbl(sqlDT.Rows(0)("ReturnQty")) - CDbl(xStock)) <= 0 Then
                    MessageBoxEx.Show("Insufficient number of stocks !! " & Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("QTY"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                ElseIf sqlDT.Rows(0)("Qty") = 0 Then
                    MessageBoxEx.Show("Insufficient number of stocks !! " & Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("QTY"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                Else
                    If ProductFound = False Then
                        dgvSales.Rows.Add(sqlDT.Rows(0)("Barcode"), sqlDT.Rows(0)("Product_Name"), 1, Format(sqlDT.Rows(0)("Sales_Price"), "###,###.00"), Format(ProductDiscout, "###,###.00"), Format(TotalVat, "###,###.00"), Format(PrdTotal, "###,###.00"), Format(sqlDT.Rows(0)("Purchase_Price"), "###,###.00"))
                    Else
                        For i = 0 To dgvSales.Rows.Count - 1
                            If UCase(dgvSales.Rows(i).Cells(0).Value) = UCase(txtBarcode.Text) Then
                                dgvSales.Rows(i).Cells(2).Value = dgvSales.Rows(i).Cells(2).Value + 1
                                dgvSales.Rows(i).Cells(4).Value = Format(ProductDiscout * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                dgvSales.Rows(i).Cells(5).Value = Format(TotalVat * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                dgvSales.Rows(i).Cells(6).Value = Format(PrdTotal * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                dgvSales.Rows(i).Cells(7).Value = Format(Purchase_Price * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                            End If
                        Next
                    End If
                    TotalAmount()
                End If
            Else
                MessageBoxEx.Show("Product Not Found. Please Enter Correct Barcode !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            txtBarcode.Clear()
            txtBarcode.Select()

        End If
    End Sub

    Private Sub dgvSales_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSales.CellEndEdit
        If dgvSales.CurrentCell.ColumnIndex = 2 Then
            sqlSTR = "SELECT P.Sales_Price, P.Purchase_Price, P.Vat, S.Qty, IFNULL((SELECT Discount FROM tbl_Discount WHERE (Barcode=P.Barcode AND Discount_Date>=DATE_FORMAT(NOW(), '%Y/%m/%d'))),0) AS Discount " & _
                     "FROM tbl_Products AS P INNER JOIN tbl_Stock_Products AS S ON P.Barcode = S.Barcode WHERE P.Barcode = '" & dgvSales.CurrentRow.Cells(0).Value & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                ProductDiscout = (sqlDT.Rows(0)("Sales_Price") * sqlDT.Rows(0)("Discount")) / 100
                TotalVat = (sqlDT.Rows(0)("Sales_Price") * VatAmount) / 100
                PrdTotal = sqlDT.Rows(0)("Sales_Price") ' (sqlDT.Rows(0)("Sales_Price") + TotalVat) - ProductDiscout

                If CDbl(dgvSales.CurrentRow.Cells(2).Value) > CDbl(sqlDT.Rows(0)("QTY")) Then
                    MessageBoxEx.Show("Insufficient number of stocks !! " & Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("QTY"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvSales.CurrentRow.Cells(2).Value = sqlDT.Rows(0)("QTY")
                    dgvSales.CurrentRow.Cells(4).Value = Format(ProductDiscout * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(5).Value = Format(TotalVat * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(6).Value = Format(PrdTotal * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(7).Value = Format(Purchase_Price * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    TotalAmount()

                    Exit Sub
                Else
                    dgvSales.CurrentRow.Cells(4).Value = Format(ProductDiscout * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(5).Value = Format(TotalVat * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(6).Value = Format(PrdTotal * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(7).Value = Format(Purchase_Price * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    TotalAmount()
                End If
            End If
        End If
    End Sub

    Private Sub dgvSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSales.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBoxEx.Show("Do you want to delete this product ??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                dgvSales.Rows.Remove(dgvSales.CurrentRow)
                TotalAmount()
                txtBarcode.Select()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim SalesDetailsID As String
        Dim Stock_To_Update(0) As String
        Dim counter As Integer = 0
        Dim PaidAmount As Double

        If dgvSales.RowCount = 0 Then
            MessageBoxEx.Show("No products found. ", "Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If CDbl(GrandTotal) <= CDbl(lblReceive.Text) Then
            PaidAmount = CDbl(lblReceive.Text) - CDbl(GrandTotal)
            Dim ans As String = MessageBoxEx.Show("Refund : TK " & Format(PaidAmount, "###,###.00") & "; Do you want to refund this amount??", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If ans = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            ElseIf ans = Windows.Forms.DialogResult.No Then
                sqlSTR = "SELECT Barcode, Qty FROM tbl_Sales_Details WHERE Sales_ID = '" & txtInvoice.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                For X = 0 To sqlDT.Rows.Count - 1
                    ReDim Preserve Stock_To_Update(counter)
                    Stock_To_Update(counter) = "UPDATE tbl_Stock_Products SET Qty = Qty+'" & sqlDT.Rows(X)("Qty") & "' WHERE Barcode = '" & sqlDT.Rows(X)("Barcode") & "'"
                    counter += 1
                Next

                For X = 0 To UBound(Stock_To_Update)
                    If Len(Stock_To_Update(X)) > 0 Then
                        ExecuteSQLQuery(Stock_To_Update(X))
                    End If
                Next

                ExecuteSQLQuery("DELETE FROM tbl_Sales_Details WHERE Sales_ID = '" & txtInvoice.Text & "'")

                sqlSTR = "UPDATE tbl_Sales SET Exchange_Status = 'Yes', Sub_Total = " & CDbl(lblSubTotal.Text) & ", Total_Vat = " & CDbl(lblVat.Text) & ", Total_Discount = " & CDbl(lblDiscount.Text) & ", Grand_Total = " & CDbl(GrandTotal) & _
                         ", Exchange_Profit=" & CDbl(PaidAmount) & " WHERE Sales_ID = '" & txtInvoice.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                'sqlSTR = "UPDATE tbl_Sales SET Exchange = 'Yes', Sub_Total = " & CDbl(lblSubTotal.Text) & ", Total_Vat = " & CDbl(lblVat.Text) & ", Total_Discount = " & CDbl(lblDiscount.Text) & ", Grand_Total = " & CDbl(GrandTotal) & _
                '         ", Receive_Amount = " & CDbl(PaidAmount) & ", Change_Amount=0, Disount_Amount=0 WHERE Sales_ID = '" & txtInvoice.Text & "'"
                'ExecuteSQLQuery(sqlSTR)

                For Each dgv As DataGridViewRow In dgvSales.Rows
                    SalesDetailsID = YearIDPreFix("tbl_Sales_Details", "Sales_Details_ID", PreFix)

                    sqlSTR = "INSERT INTO tbl_Sales_Details(Sales_Details_ID, Sales_ID, Barcode, Product_Name, Qty, Sales_Price, Discount_Amount, Vat_Amount, Sub_Total, Profit_Amt) " & _
                             "VALUES ('" & SalesDetailsID & "', '" & txtInvoice.Text & "', '" & dgv.Cells(0).Value & "', '" & dgv.Cells(1).Value & "', " & CDbl(dgv.Cells(2).Value) & _
                             ", " & CDbl(dgv.Cells(3).Value) & ", " & CDbl(dgv.Cells(4).Value) & ", " & CDbl(dgv.Cells(5).Value) & ", " & CDbl(dgv.Cells(6).Value) & ", " & (CDbl(dgv.Cells(6).Value) - CDbl(dgv.Cells(4).Value)) - CDbl(dgv.Cells(7).Value) & ")"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE TBL_Stock_Products SET QTY = QTY - " & CDbl(dgv.Cells(2).Value) & " WHERE Barcode = '" & dgv.Cells(0).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                Next

                Me.Close()

            ElseIf ans = Windows.Forms.DialogResult.Yes Then
                PaidAmount = CDbl(lblReceive.Text) - CDbl(GrandTotal)

                sqlSTR = "SELECT Barcode, Qty FROM tbl_Sales_Details WHERE Sales_ID = '" & txtInvoice.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                For X = 0 To sqlDT.Rows.Count - 1
                    ReDim Preserve Stock_To_Update(counter)
                    Stock_To_Update(counter) = "UPDATE tbl_Stock_Products SET Qty = Qty+'" & sqlDT.Rows(X)("Qty") & "' WHERE Barcode = '" & sqlDT.Rows(X)("Barcode") & "'"
                    counter += 1
                Next

                For X = 0 To UBound(Stock_To_Update)
                    If Len(Stock_To_Update(X)) > 0 Then
                        ExecuteSQLQuery(Stock_To_Update(X))
                    End If
                Next

                ExecuteSQLQuery("DELETE FROM tbl_Sales_Details WHERE Sales_ID = '" & txtInvoice.Text & "'")

                sqlSTR = "UPDATE tbl_Sales SET Exchange_Status = 'Yes', Sub_Total = " & CDbl(lblSubTotal.Text) & ", Total_Vat = " & CDbl(lblVat.Text) & ", Total_Discount = " & CDbl(lblDiscount.Text) & ", Grand_Total = " & CDbl(GrandTotal) & _
                         ", Receive_Amount = Receive_Amount-" & CDbl(PaidAmount) & ", Disount_Amount=0 WHERE Sales_ID = '" & txtInvoice.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                For Each dgv As DataGridViewRow In dgvSales.Rows
                    SalesDetailsID = YearIDPreFix("tbl_Sales_Details", "Sales_Details_ID", PreFix)

                    sqlSTR = "INSERT INTO tbl_Sales_Details(Sales_Details_ID, Sales_ID, Barcode, Product_Name, Qty, Sales_Price, Discount_Amount, Vat_Amount, Sub_Total, Profit_Amt) " & _
                             "VALUES ('" & SalesDetailsID & "', '" & txtInvoice.Text & "', '" & dgv.Cells(0).Value & "', '" & dgv.Cells(1).Value & "', " & CDbl(dgv.Cells(2).Value) & _
                             ", " & CDbl(dgv.Cells(3).Value) & ", " & CDbl(dgv.Cells(4).Value) & ", " & CDbl(dgv.Cells(5).Value) & ", " & CDbl(dgv.Cells(6).Value) & ", " & (CDbl(dgv.Cells(6).Value) - CDbl(dgv.Cells(4).Value)) - CDbl(dgv.Cells(7).Value) & ")"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE TBL_Stock_Products SET QTY = QTY - " & CDbl(dgv.Cells(2).Value) & " WHERE Barcode = '" & dgv.Cells(0).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                Next

                '============== tbl_Customers ================
                sqlSTR = "SELECT Cust_ID, (SELECT Cust_ID FROM tbl_Customers ORDER BY Cust_ID ASC LIMIT 1) AS TopCust FROM tbl_Customers WHERE Cust_ID = '" & txtID.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows(0)("TopCust") <> sqlDT.Rows(0)("Cust_ID") Then
                    ''sqlSTR = "SELECT Paid_Taka, Due_Amt FROM tbl_customers_paid WHERE Sales_ID='" & txtInvoice.Text & "'"
                    ''ExecuteSQLQuery(sqlSTR)

                    ''If sqlDT.Rows.Count > 0 Then
                    ''    PaidAmount = sqlDT.Rows(0)("Paid_Taka")
                    ''    DueAmount = (CDbl(dgvSales.SelectedRows(0).Cells(6).Value) - CDbl(dgvSales.SelectedRows(0).Cells(8).Value)) - PaidAmount

                    'sqlSTR = "SELECT Paid_ID FROM tbl_customers_paid WHERE Paid_Date>'" & Format(dtpReturn.Value, "yyyy/MM/dd") & "' AND Cust_ID='" & txtID.Text & _
                    '         "' ORDER BY LPAD(LOWER(Sales_ID), 10,0) ASC"
                    'ExecuteSQLQuery(sqlSTR)

                    'For i As Integer = 0 To sqlDT.Rows.Count - 1
                    '    sqlSTR = "UPDATE tbl_customers_paid SET Due_Amt=Due_Amt-" & CDbl(DueAmount) & " WHERE Paid_ID='" & sqlDT.Rows(i)("Paid_ID") & "'"
                    '    GetSQLQuery(sqlSTR)
                    'Next

                    sqlSTR = "UPDATE tbl_customers_paid SET Paid_Taka=Paid_Taka-" & CDbl(PaidAmount) & " WHERE Cust_ID='" & txtID.Text & "' AND Sales_ID='" & txtInvoice.Text & "'"
                    ExecuteSQLQuery(sqlSTR)
                End If

                '============== tbl_Sales_Return =============
                sqlSTR = "INSERT INTO tbl_sales_return(Rtn_Date, Rtn_Amt, Sales_ID, Cust_ID, User_ID) VALUES('" & Format(dtpReturn.Value, "yyyy/MM/dd") & "', " & CDbl(PaidAmount) & ", '" & txtInvoice.Text & "','" & txtID.Text & "', '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                '============= tbl_Balance ==================
                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(dtpReturn.Value, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(PaidAmount) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
                    ExecuteSQLQuery(sqlSTR)
                Else
                    sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(dtpReturn.Value, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
                    ExecuteSQLQuery(sqlSTR)

                    If sqlDT.Rows.Count > 0 Then
                        BalAmt = sqlDT.Rows(0)("Bal_Amt")
                    Else
                        BalAmt = 0
                    End If

                    sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) - CDbl(PaidAmount) & ", '" & Format(dtpReturn.Value, "yyyy/MM/dd") & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If

                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(dtpReturn.Value, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(PaidAmount) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                    GetSQLQuery(sqlSTR)
                Next

                Me.Close()
            End If

        Else
            sqlSTR = "SELECT Cust_ID, (SELECT Cust_ID FROM tbl_Customers ORDER BY Cust_ID ASC LIMIT 1) AS TopCust FROM tbl_Customers WHERE Cust_ID = '" & txtID.Text & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows(0)("TopCust") <> sqlDT.Rows(0)("Cust_ID") Then

            Else
                GrandTotal = Math.Round(CDbl(GrandTotal))
                EditID = txtInvoice.Text
                FrmSalesReturnPayment.ShowDialog()

            End If

        End If
    End Sub

    Private Sub dgvCollection_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSales.EditingControlShowing
        If dgvSales.CurrentCell.ColumnIndex = 2 And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)

            '---add an event handler to the TextBox control---
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            'AddHandler tb.TextChanged, AddressOf Textbox_TextChanged
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub
End Class