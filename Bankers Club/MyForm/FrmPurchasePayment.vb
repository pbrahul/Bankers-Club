Imports DevComponents.DotNetBar

Public Class FrmPurchasePayment

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Payment"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(416, 370)
        ClearAll(TableLayoutPanel1, Highlighter1)

        txtPayment.Clear()
        txtPayment.Select()
        txtCheque.Text = "N/A"
        txtRemarks.Text = "N/A"

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
        Dim Bal_Qty As Double
        Dim Pre_Date As Date

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

        With FrmPurchase
            If Split(FrmPurchase.Text, " - ")(1) = "Add" Then
                GetID = YearIDPreFix("tbl_Purchase", "Purchase_ID", PreFix)

                sqlSTR = "INSERT INTO tbl_Purchase(Purchase_ID, Ac_ID, Memo_No, Purcahse_Date, Approved, Approved_By, Purchase_Total, Remarks, Challen_No, User_ID) " & _
                         "VALUES ('" & GetID & "', '" & SuppID & "', '" & .txtMemo.Text & "', '" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "', '" & IIf(.chkApproved.Checked = True, "Yes", "No") & _
                         "', '" & IIf(.chkApproved.Checked = True, UserName, "") & "', " & CDbl(.lblTotal.Text) & ", '" & txtRemarks.Text & "', '" & .txtChallen.Text & "', '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                For Each LI As DataGridViewRow In .dgvPurchase.Rows
                    sqlSTR = "INSERT INTO tbl_Purchase_Details(Barcode, Product_Name, Qty, Units, Item_Price, Total_Price, Purchase_ID) VALUES ('" & LI.Cells(0).Value & _
                             "', '" & LI.Cells(1).Value & "', " & CDbl(LI.Cells(2).Value) & ", '" & LI.Cells(3).Value & "', " & CDbl(LI.Cells(4).Value) & ", " & CDbl(LI.Cells(5).Value) & ", '" & GetID & "')"
                    ExecuteSQLQuery(sqlSTR)
                Next

            ElseIf Split(FrmPurchase.Text, " - ")(1) = "Edit" Then
                GetID = EditID

                sqlSTR = "DELETE FROM tbl_Purchase_Details WHERE Purchase_ID = '" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "UPDATE tbl_Purchase SET Supp_ID = '" & SuppID & "', Memo_No = '" & .txtMemo.Text & "', Purcahse_Date = '" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "', " & _
                         "Approved = '" & IIf(.chkApproved.Checked = True, "Yes", "No") & "', Approved_By = '" & IIf(.chkApproved.Checked = True, UserName, "") & "', " & _
                         "Purchase_Total = " & CDbl(.lblTotal.Text) & ", Remarks = '" & txtRemarks.Text & "' WHERE Purchase_ID = '" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)

                For Each LI As DataGridViewRow In .dgvPurchase.Rows
                    sqlSTR = "INSERT INTO tbl_Purchase_Details(Barcode, Product_Name, Qty, Units, Item_Price, Total_Price, Purchase_ID) VALUES ('" & LI.Cells(0).Value & _
                             "', '" & LI.Cells(1).Value & "', " & CDbl(LI.Cells(2).Value) & ", '" & LI.Cells(3).Value & "', " & CDbl(LI.Cells(4).Value) & ", " & CDbl(LI.Cells(5).Value) & ", '" & GetID & "')"
                    ExecuteSQLQuery(sqlSTR)
                Next
            End If

            Pre_Date = .dtpPurchase.Text & " " & TimeOfDay

            '=============== tbl_Stock==================
            For Each LI As DataGridViewRow In .dgvPurchase.Rows
                sqlSTR = "SELECT * FROM tbl_Stock_Products WHERE Barcode = '" & LI.Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    Bal_Qty = sqlDT.Rows(0)("Qty")

                    sqlSTR = "UPDATE tbl_Stock_Products SET  Qty = Qty + " & CDbl(LI.Cells(2).Value) & " WHERE Barcode = '" & LI.Cells(0).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                Else
                    Bal_Qty = 0

                    sqlSTR = "INSERT INTO tbl_Stock_Products(Barcode, Product_Name, Qty, Units) " & _
                             "VALUES ('" & LI.Cells(0).Value & "', '" & LI.Cells(1).Value & "', " & CDbl(LI.Cells(2).Value) & ", '" & LI.Cells(3).Value & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If

                ' ============= tbl_Product_History ==================
                sqlSTR = "SELECT Bal_Qty FROM tbl_product_history WHERE Barcode='" & LI.Cells(0).Value & "' AND Hy_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Hy_Date DESC, Hy_ID DESC LIMIT 1"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    Bal_Qty = sqlDT.Rows(0)("Bal_Qty")
                    'Else
                    '    Cash_Bal = txtBalance.Text
                End If

                sqlSTR = "INSERT INTO tbl_product_history (Barcode, Hy_Particulars, Hy_Date, In_Qty, Bal_Qty, Purchase_ID) VALUES('" & LI.Cells(0).Value & "', 'Purchase from " & .txtBillAddress.Lines(0) & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', " & LI.Cells(2).Value & ", " & Bal_Qty + CDbl(LI.Cells(2).Value) & ", '" & GetID & "')"
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "SELECT Hy_ID FROM tbl_product_history WHERE Barcode='" & LI.Cells(0).Value & "' AND Hy_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_product_history SET Bal_Qty=Bal_Qty+" & CDbl(LI.Cells(2).Value) & " WHERE Hy_ID=" & sqlDT.Rows(i)("Hy_ID")
                    GetSQLQuery(sqlSTR)
                Next
            Next

            '=================== tbl_Ac_Ledger ===================
            sqlSTR = "SELECT Balance_Amt FROM tbl_Ac_ledger WHERE Ac_ID='" & SuppID & "' AND Ledger_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Ledger_Date DESC, Ledger_ID DESC LIMIT 1"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                Cust_Bal = sqlDT.Rows(0)("Balance_Amt") - CDbl(lblPurchaseAmt.Text)
            Else
                Cust_Bal = lblGrandTotalAmt.Text
            End If

            sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & SuppID & "' AND Ledger_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt-" & CDbl(lblPurchaseAmt.Text) - (CDbl(txtPayment.Text) + CDbl(txtDiscount.Text)) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                GetSQLQuery(sqlSTR)
            Next

            sqlSTR = "INSERT INTO tbl_Ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Debit_Amt, Balance_Amt, Purchase_ID, User_ID) VALUES ('" & SuppID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', 'Sale Product', " & CDbl(lblPurchaseAmt.Text) & _
                     ", " & CDbl(Cust_Bal) & ", '" & GetID & "', '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = " & CDbl(lblGrandTotalAmt.Text) + (CDbl(txtPayment.Text) + CDbl(txtDiscount.Text)) & " WHERE Ac_ID = '" & SuppID & "'"
            ExecuteSQLQuery(sqlSTR)

            If txtPayment.Text > 0 Then
                sqlSTR = "INSERT INTO tbl_ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Payment_Type, Cheque_No, Credit_Amt, Discount, Balance_Amt, Remarks, Purchase_ID, Cash_ID, User_ID) VALUES ('" & SuppID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                         "', 'Receive to " & cmbFrom.SelectedItem & "', '" & IIf(swPayment.Value = True, "Cash", "Checque") & "',  '" & txtCheque.Text & "', " & CDbl(txtPayment.Text) & ", " & CDbl(txtDiscount.Text) & ", " & CDbl(Cust_Bal) + (CDbl(txtPayment.Text) + CDbl(txtDiscount.Text)) & ", '" & txtRemarks.Text & _
                         "', '" & GetID & "',  '" & Cash_ID & "', '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                ' ============= tbl_Cash_Ledger ==================
                sqlSTR = "SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Led_Date DESC, Led_ID DESC LIMIT 1"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    Cash_Bal = sqlDT.Rows(0)("Bal_Amt")
                Else
                    Cash_Bal = txtBalance.Text
                End If

                ExecuteSQLQuery("SELECT MAX(Ledger_ID) AS Ledger_ID FROM tbl_Ac_Ledger")

                sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Paid_Amt, Bal_Amt, Ac_ID, Ledger_ID, User_ID) VALUES('" & Cash_ID & "', 'Payment to " & .txtBillAddress.Lines(0) & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                         "', " & CDbl(txtPayment.Text) & ", " & CDbl(Cash_Bal) - CDbl(txtPayment.Text) & ", '" & SuppID & "', '" & sqlDT.Rows(0)("Ledger_ID") & "', '" & UserID & "') "
                ExecuteSQLQuery(sqlSTR)

                sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                    GetSQLQuery(sqlSTR)
                Next

                sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt- " & CDbl(txtPayment.Text) & " WHERE Cash_ID = '" & Cash_ID & "'"
                ExecuteSQLQuery(sqlSTR)


                '============= tbl_Balance ==================
                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
                    ExecuteSQLQuery(sqlSTR)
                Else
                    sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
                    ExecuteSQLQuery(sqlSTR)

                    If sqlDT.Rows.Count > 0 Then
                        BalAmt = sqlDT.Rows(0)("Bal_Amt")
                    Else
                        BalAmt = 0
                    End If

                    sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) - CDbl(txtPayment.Text) & ", '" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If

                sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(.dtpPurchase.Value, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                    GetSQLQuery(sqlSTR)
                Next
            End If
        End With

        MessageBoxEx.Show("Record Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmPurchase.Close()
        Me.Close()
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