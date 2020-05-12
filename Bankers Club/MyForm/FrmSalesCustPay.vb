Imports DevComponents.DotNetBar
'Imports CrystalDecisions.Shared
Imports System.Drawing.Printing

Public Class FrmSalesCustPay
    Dim TransID As String
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Payment"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(416, 375)
        txtPayment.Clear()
        txtPayment.Select()
        txtCheque.Text = "N/A"
        txtRemarks.Text = "N/A"
        txtDiscount.Text = 0

        lblDue.ForeColor = Color.White
        lblDueAmt.ForeColor = Color.White
        lblPurchase.ForeColor = Color.White
        lblPurchaseAmt.ForeColor = Color.White
        lblGrandTotal.ForeColor = Color.White
        lblGrandTotalAmt.ForeColor = Color.White

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_ID ASC", cmbFrom)
        swPayment.Value = True

        'sqlSTR = "SELECT Supp_ID, Supp_Name, Due_Amount FROM tbl_Suppliers WHERE Supp_Name = '" & FrmPurchase.cmbSuppName.Text & "'"
        'ExecuteSQLQuery(sqlSTR)

        'SuppID = sqlDT.Rows(0)("Supp_ID")
        'lblDue.Text = Format(Math.Round(CDbl(sqlDT.Rows(0)("Due_Amount"))), "###,###.00")
        'lblTotal.Text = Format(Math.Round(CDbl(FrmPurchase.lblTotal.Text)), "###,###.00")
        'lblGrandTotal.Text = Format(Math.Round(CDbl(lblTotal.Text) + CDbl(lblDue.Text)), "###,###.00")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Pre_Date As Date
        Dim Bal_Qty As Double


        'DueAmount = CDbl(lblGrandTotalAmt.Text)
        'PaidAmount = Val(txtPayment.Text) + Val(txtDiscount.Text)

        'If PaidAmount > DueAmount Then
        '    MessageBoxEx.Show("Payment Amount Should be Equal or " & vbNewLine & "Less Than Due Amount.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.Red)
        '    txtPayment.Focus()
        '    Exit Sub
        'Else
        '    PaidDue = DueAmount - PaidAmount
        '    Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.None)
        'End If

        If FillTextBox(TableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If


        With FrmSales
            Pre_Date = .dtpPurchase.Text & " " & TimeOfDay

            'If Split(FrmPurchase.Text, " - ")(1) = "Add" Then
            GetID = YearIDPreFix("tbl_Sales", "Sales_ID", PreFix)

            sqlSTR = "INSERT INTO tbl_Sales(Sales_ID, Memo_No, Sales_Date, Void, Sub_Total, Total_Vat, Total_Discount, Lb_Amt, Grand_Total, Receive_Amount, Change_Amount, Disount_Amount, Ac_ID, Order_No, User_ID) " & _
                     "VALUES ('" & GetID & "', '" & .txtMemo.Text & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', 'No', " & CDbl(.lblSubTotal.Text) & ", " & CDbl(.lblVat.Text) & ", " & CDbl(.lblDiscount.Text) & ", " & CDbl(.lblLabour.Text) & ", " & CDbl(GrandTotal) & ", " & CDbl(txtPayment.Text) & _
                     ", 0, " & CDbl(txtDiscount.Text) & ", '" & CustID & "',  '0', '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            For Each dgv As DataGridViewRow In .dgvSales.Rows
                sqlSTR = "INSERT INTO tbl_Sales_Details(Sales_ID, Barcode, Product_Name, Qty, Qty_Pcs, Sales_Price, Discount_Amount, Vat_Amount, Sub_Total, Profit_Amt) " & _
                         "VALUES ('" & GetID & "', '" & dgv.Cells(0).Value & "', '" & dgv.Cells(1).Value & "', " & CDbl(dgv.Cells(2).Value) & ", " & CDbl(dgv.Cells(2).Value) & _
                         ", " & CDbl(dgv.Cells(4).Value) & ", " & CDbl(dgv.Cells(5).Value) & ", " & CDbl(dgv.Cells(6).Value) & ", " & CDbl(dgv.Cells(7).Value) & ", " & CDbl(dgv.Cells(7).Value) - CDbl(dgv.Cells(8).Value) & ")"
                ExecuteSQLQuery(sqlSTR)
            Next

            'ElseIf Split(FrmPurchase.Text, " - ")(1) = "Edit" Then
            '    GetID = EditID

            '    sqlSTR = "DELETE FROM tbl_Purchase_Details WHERE Purchase_ID = '" & EditID & "'"
            '    ExecuteSQLQuery(sqlSTR)

            '    sqlSTR = "UPDATE tbl_Purchase SET Supp_ID = '" & SuppID & "', Memo_No = '" & .txtMemo.Text & "', Purcahse_Date = '" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "', " & _
            '             "Approved = '" & IIf(.chkApproved.Checked = True, "Yes", "No") & "', Approved_By = '" & IIf(.chkApproved.Checked = True, UserName, "") & "', " & _
            '             "Purchase_Total = " & CDbl(.lblTotal.Text) & ", Remarks = '" & txtRemarks.Text & "' WHERE Purchase_ID = '" & EditID & "'"
            '    ExecuteSQLQuery(sqlSTR)

            '    For Each LI As DataGridViewRow In .dgvPurchase.Rows
            '        PurDetailsID = YearIDPreFix("tbl_Purchase_Details", "Purchase_Details_ID", PreFix)

            '        sqlSTR = "INSERT INTO tbl_Purchase_Details(Purchase_Details_ID, Barcode, Product_Name, Qty, Units, Item_Price, Total_Price, Purchase_ID) " & _
            '                 "VALUES ('" & PurDetailsID & "', '" & LI.Cells(0).Value & "', '" & LI.Cells(1).Value & "', " & LI.Cells(2).Value & ", '" & LI.Cells(3).Value & _
            '                 "', " & CDbl(LI.Cells(5).Value) & ", " & CDbl(LI.Cells(6).Value) & ", '" & GetID & "')"
            '        ExecuteSQLQuery(sqlSTR)
            '    Next
            'End If

            '=============== tbl_Stock==================
            For Each LI As DataGridViewRow In .dgvSales.Rows
                sqlSTR = "SELECT Qty FROM tbl_Stock_Products WHERE Barcode = '" & LI.Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    Bal_Qty = sqlDT.Rows(0)("Qty")
                End If

                sqlSTR = "UPDATE tbl_Stock_Products SET  Qty = Qty - " & LI.Cells(2).Value & ", Units = '" & LI.Cells(3).Value & "' WHERE Barcode = '" & LI.Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                ' ============= tbl_Product_History ==================
                sqlSTR = "SELECT Bal_Qty FROM tbl_product_history WHERE Barcode='" & LI.Cells(0).Value & "' AND Hy_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Hy_Date DESC, Hy_ID DESC LIMIT 1"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    Bal_Qty = sqlDT.Rows(0)("Bal_Qty")
                    'Else
                    '    Cash_Bal = txtBalance.Text
                End If

                sqlSTR = "INSERT INTO tbl_product_history (Barcode, Hy_Particulars, Hy_Date, Out_Qty, Bal_Qty, Sales_ID) VALUES('" & LI.Cells(0).Value & "', 'Sale to " & .txtBillAddress.Lines(0) & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', " & LI.Cells(2).Value & ", " & Bal_Qty - LI.Cells(2).Value & ", '" & GetID & "')"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "SELECT Hy_ID FROM tbl_product_history WHERE Barcode='" & LI.Cells(0).Value & "' AND Hy_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_product_history SET Bal_Qty=Bal_Qty-" & CDbl(LI.Cells(2).Value) & " WHERE Hy_ID=" & sqlDT.Rows(i)("Hy_ID")
                    GetSQLQuery(sqlSTR)
                Next
            Next

            '=================== tbl_Ac_Ledger ===================
            sqlSTR = "SELECT Balance_Amt FROM tbl_Ac_ledger WHERE Ac_ID='" & CustID & "' AND Ledger_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Ledger_Date DESC, Ledger_ID DESC LIMIT 1"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                Cust_Bal = sqlDT.Rows(0)("Balance_Amt") + CDbl(lblPurchaseAmt.Text)
            Else
                Cust_Bal = lblGrandTotalAmt.Text
            End If

            sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & CustID & "' AND Ledger_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt+" & CDbl(lblPurchaseAmt.Text) - (CDbl(txtPayment.Text) + CDbl(txtDiscount.Text)) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                GetSQLQuery(sqlSTR)
            Next

            sqlSTR = "INSERT INTO tbl_Ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Credit_Amt, Balance_Amt, Sales_ID, User_ID) VALUES ('" & CustID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', 'Purchase Product', " & CDbl(lblPurchaseAmt.Text) & _
                     ", " & CDbl(Cust_Bal) & ", '" & GetID & "', '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = " & CDbl(lblGrandTotalAmt.Text) - (CDbl(txtPayment.Text) + CDbl(txtDiscount.Text)) & " WHERE Ac_ID = '" & CustID & "'"
            ExecuteSQLQuery(sqlSTR)

            If txtPayment.Text > 0 Then
                sqlSTR = "INSERT INTO tbl_ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Payment_Type, Cheque_No, Debit_Amt, Discount, Balance_Amt, Remarks, Sales_ID, Cash_ID, User_ID) VALUES ('" & CustID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                         "', 'Payment to " & cmbFrom.SelectedItem & "', '" & IIf(swPayment.Value = True, "Cash", "Checque") & "',  '" & txtCheque.Text & "', " & CDbl(txtPayment.Text) & ", " & CDbl(txtDiscount.Text) & ", " & CDbl(Cust_Bal) - (CDbl(txtPayment.Text) + CDbl(txtDiscount.Text)) & ", '" & txtRemarks.Text & _
                         "', '" & GetID & "',  '" & Cash_ID & "', '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                ' ============= tbl_Cash_Ledger ==================
                sqlSTR = "SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Led_Date DESC LIMIT 1"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    Cash_Bal = sqlDT.Rows(0)("Bal_Amt")
                Else
                    Cash_Bal = txtBalance.Text
                End If

                ExecuteSQLQuery("SELECT MAX(Ledger_ID) AS Ledger_ID FROM tbl_Ac_Ledger")

                sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Receive_Amt, Bal_Amt, Ac_ID, Ledger_ID, User_ID) VALUES('" & Cash_ID & "', 'Receive from " & .txtBillAddress.Lines(0) & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                         "', " & CDbl(txtPayment.Text) & ", " & CDbl(Cash_Bal) + CDbl(txtPayment.Text) & ", '" & CustID & "', '" & sqlDT.Rows(0)("Ledger_ID") & "', '" & UserID & "') "
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                    GetSQLQuery(sqlSTR)
                Next

                sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt+ " & CDbl(txtPayment.Text) & " WHERE Cash_ID = '" & Cash_ID & "'"
                ExecuteSQLQuery(sqlSTR)


                '============= tbl_Balance ==================
                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
                    ExecuteSQLQuery(sqlSTR)
                Else
                    sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
                    ExecuteSQLQuery(sqlSTR)

                    If sqlDT.Rows.Count > 0 Then
                        BalAmt = sqlDT.Rows(0)("Bal_Amt")
                    Else
                        BalAmt = 0
                    End If

                    sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) + CDbl(txtPayment.Text) & ", '" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If

                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                    GetSQLQuery(sqlSTR)
                Next
            End If
        End With

        'MessageBoxEx.Show("Record Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''FrmPurchase.Close()
        'Me.Close()


        ''====== clear & Print ==========
        With FrmSales
            sqlSTR = "SELECT A.AC_ID, A.Ac_Name, A.Contact_No, C.Type_Details, A.Bal_Amt FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID WHERE A.Ac_ID = 'C-1001'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                CustID = sqlDT.Rows(0)("Ac_ID")
                .txtBillAddress.Text = sqlDT.Rows(0)("Ac_Name") '& vbNewLine & sqlDT.Rows(0)("Type_Details") & vbNewLine & sqlDT.Rows(0)("Contact_No")
                .txtCustBal.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
            End If

            .cmbType.SelectedIndex = 0
            .lblSubTotal.Text = "0.00"
            .lblDiscount.Text = "0.00"
            .lblVat.Text = "0.00"
            .lblLabour.Text = "0.00"
            .txtMemo.Text = "N/A"
            .lblGrandTotal.Text = "0.00"
            .dgvSales.Rows.Clear()
            .txtBarcode.Focus()
        End With

        Me.Close()

        RptStr = "SELECT A.Ac_ID, A.Ac_Name, A.Ac_Address, A.Contact_No, S.Sales_ID, S.Memo_No, S.Sales_Date, S.Sub_total, S.Disount_Amount, S.Lb_Amt, S.Grand_Total, S.Receive_Amount, D.Barcode, D.Product_Name, D.Qty, P.Units, " & _
         "D.Qty_Pcs, D.Sales_Price, D.Sub_Total AS PrdTotal, U.UserName FROM didarenterprise_db.tbl_sales AS S INNER JOIN tbl_sales_details AS D ON S.Sales_ID=D.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode " & _
         "INNER JOIN tbl_Accounts AS A ON S.Ac_ID=A.Ac_ID INNER JOIN tbl_users AS U ON S.User_ID=U.User_ID WHERE S.Sales_ID='" & GetID & "'"
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


        'RptStr = "SELECT C.Cust_Name, S.Sales_ID, S.Sales_Date, D.Barcode, D.Product_Name, D.Sales_Price, D.Qty, D.Sub_Total AS sTotal, S.Sub_Total, S.Total_Vat, S.Disount_Amount, S.Total_Discount, " & _
        '       "S.Grand_Total, S.Receive_Amount, S.Change_Amount, C.Due_Amount, IFNULL((SELECT Due_Amt FROM tbl_customers_paid WHERE Sales_ID=S.Sales_ID),0) AS Due_Amount, U.UserName FROM tbl_Sales AS S " & _
        '       "INNER JOIN tbl_sales_details AS D ON S.Sales_ID=D.Sales_ID INNER JOIN tbl_Customers AS C ON S.Cust_ID=C.Cust_ID INNER JOIN tbl_Users AS U ON S.User_ID=U.User_ID WHERE S.Sales_ID ='" & GetID & "'"
        'mReport.Load(Application.StartupPath & "\MyReports\rptReceipt.rpt")
        'mReport.SetDataSource(ExecuteSQLQuery(RptStr))

        'CompanyInfo()

        'For Each rptPrinter In PrinterSettings.InstalledPrinters
        '    If rptPrinter = "POS Printer" Then
        '        mReport.PrintOptions.PrinterName = rptPrinter
        '        Exit For
        '    End If
        'Next

        'mReport.PrintToPrinter(1, True, 0, 0)

        'sqlSTR = "SELECT S.Barcode, S.Product_Name, S.Qty, P.Reorder_Label FROM tbl_Stock_Products AS S INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode " & _
        '         "WHERE S.Qty <= P.Reorder_Label"
        'ExecuteSQLQuery(sqlSTR)

        'If sqlDT.Rows.Count > 0 Then
        '    With FrmSales
        '        .lblReach.ForeColor = Color.Red
        '        .Timer1.Enabled = True
        '    End With
        'End If
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        NumKey(txtPayment.Text, e)
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        NumKey(txtDiscount.Text, e)
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbFrom.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Cash_ID = sqlDT.Rows(0)("Cash_ID")
            txtBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If
    End Sub

    Private Sub swPayment_ValueChanged(sender As Object, e As EventArgs) Handles swPayment.ValueChanged
        If swPayment.Value = True Then
            txtCheque.Text = "N/A"
            txtRemarks.Text = "N/A"
            txtPayment.Select()
        Else
            txtCheque.Text = ""
            txtRemarks.Text = ""
            txtCheque.Select()
        End If
    End Sub
End Class