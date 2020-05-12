Imports DevComponents.DotNetBar

Public Class FrmAsset
    Dim TransTo As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Fixed Assets"
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FormShow(FrmAccountsAdd, False, 0)
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(817, 423)
        ClearAll(TableLayoutPanel1, Highlighter1)

        SingleComboBox("SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID " & _
                 "WHERE C.Type_Details='Supplier' ORDER BY A.Ac_Name ASC", cmbSupplier)

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_ID ASC", cmbPayment)


        'sqlSTR = "SELECT Ac_ID, Ac_Name FROM tbl_Accounts ORDER BY Ac_Name ASC"
        'ExecuteSQLQuery(sqlSTR)
        'For i As Integer = 0 To sqlDT.Rows.Count - 1
        '    scAccounts.Add(sqlDT.Rows(i)("Ac_Name"))
        'Next

        'With txtAccounts
        '    .AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '    .AutoCompleteSource = AutoCompleteSource.CustomSource
        '    .AutoCompleteCustomSource = scAccounts
        'End With


        swPayment.Value = True
        txtName.Select()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Pre_Date As Date

        Dim Type_ID, Type_Code As String

        If FillTextBox(TableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        sqlSTR = "SELECT Type_ID, Type_Code FROM tbl_Accounts_Type WHERE Type_Details='Fixed Assets'"
        ExecuteSQLQuery(sqlSTR)

        Type_ID = sqlDT.Rows(0)("Type_ID")
        Type_Code = sqlDT.Rows(0)("Type_Code")

        Pre_Date = dtpDate.Text & " " & TimeOfDay

        '=============== tbl_Asset ==================
        GetID = ManualID("tbl_Accounts", "Ac_ID", Type_Code)

        sqlSTR = "INSERT INTO tbl_Accounts(AC_ID, AC_Name, Ac_Address, Contact_No, Ac_Email, Type_ID, Bal_Amt, User_ID) VALUES('" & GetID & "', '" & txtName.Text & _
                 "', '" & txtDetails.Text & "', 'N/A', 'N/A', " & Type_ID & ", " & CDbl(txtPurchase.Text) & ", '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)

        sqlSTR = "INSERT INTO tbl_assets (As_ID, AS_Name, As_Details, Qty, Amount, AC_ID, Invoice_No, As_Type, As_Date, Dep_Rate, Dep_Value) VALUES ('" & GetID & "', '" & txtName.Text & "', '" & txtDetails.Text & _
                 "', 1, " & CDbl(txtPurchase.Text) & ", '" & SuppID & "', '" & txtInvoice.Text & "', '" & cmbType.SelectedItem & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', '" & CDbl(txtDep.Text) & "', '" & CDbl(txtPurchase.Text) & "')"
        ExecuteSQLQuery(sqlSTR)

        sqlSTR = "INSERT INTO tbl_Ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Credit_Amt, Balance_Amt, User_ID) VALUES ('" & GetID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', 'Fixed Asset', " & CDbl(txtPurchase.Text) & _
                 ", " & CDbl(txtPurchase.Text) & ", '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)


        '=================== tbl_Ac_Ledger ===================
        sqlSTR = "SELECT Balance_Amt FROM tbl_Ac_ledger WHERE Ac_ID='" & SuppID & "' AND Ledger_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Ledger_Date DESC, Ledger_ID DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            Cust_Bal = sqlDT.Rows(0)("Balance_Amt") - CDbl(txtPurchase.Text)
        Else
            Cust_Bal = -CDbl(txtPurchase.Text)
        End If

        sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & SuppID & "' AND Ledger_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
        ExecuteSQLQuery(sqlSTR)

        For i As Integer = 0 To sqlDT.Rows.Count - 1
            sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt-" & CDbl(txtPurchase.Text) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
            GetSQLQuery(sqlSTR)
        Next

        sqlSTR = "INSERT INTO tbl_Ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Debit_Amt, Balance_Amt, Purchase_ID, User_ID) VALUES ('" & SuppID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', 'Purchase Fixed Asset', " & CDbl(txtPurchase.Text) & _
                 ", " & CDbl(Cust_Bal) & ", '" & GetID & "', '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)

        sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = " & CDbl(Cust_Bal) + CDbl(txtPayment.Text) & " WHERE Ac_ID = '" & SuppID & "'"
        ExecuteSQLQuery(sqlSTR)

        If txtPayment.Text > 0 Then
            sqlSTR = "INSERT INTO tbl_ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Payment_Type, Cheque_Date, Cheque_No, Credit_Amt, Discount, Balance_Amt, Remarks, Purchase_ID, Cash_ID, User_ID) VALUES ('" & SuppID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                     "', 'Receive to " & cmbPayment.SelectedItem & "', '" & IIf(swPayment.Value = True, "Cash", "Checque") & "', '" & Format(dtpCheque.Value, "yyyy/MM/dd") & "',  '" & txtCheque.Text & "', " & CDbl(txtPayment.Text) & ", 0, " & CDbl(Cust_Bal) + CDbl(txtPayment.Text) & ", '" & txtBank.Text & _
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

            sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Paid_Amt, Bal_Amt, Ac_ID, Ledger_ID, User_ID) VALUES('" & Cash_ID & "', 'Payment to " & cmbSupplier.SelectedItem & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
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
            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
                ExecuteSQLQuery(sqlSTR)
            Else
                sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    BalAmt = sqlDT.Rows(0)("Bal_Amt")
                Else
                    BalAmt = 0
                End If

                sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) - CDbl(txtPayment.Text) & ", '" & Format(dtpDate.Value, "yyyy/MM/dd") & "')"
                ExecuteSQLQuery(sqlSTR)
            End If

            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                GetSQLQuery(sqlSTR)
            Next
        End If

        MessageBoxEx.Show("Record save successfully..", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FrmAssetList.RefreshAsset()
        Me.Close()
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        NumKey(txtInvoice.Text, e)
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayment.SelectedIndexChanged
        sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbPayment.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Cash_ID = sqlDT.Rows(0)("Cash_ID")
            txtBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If
    End Sub

    'Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayment.SelectedIndexChanged
    '    sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbPayment.SelectedItem & "'"
    '    ExecuteSQLQuery(sqlSTR)
    '    If sqlDT.Rows.Count > 0 Then
    '        TransTo = sqlDT.Rows(0)("Cash_ID")
    '        txtBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
    '    End If

    'End Sub

    Private Sub swPayment_ValueChanged(sender As Object, e As EventArgs) Handles swPayment.ValueChanged
        If swPayment.Value = True Then
            txtBank.Text = "N/A"
            txtCheque.Text = "N/A"
            dtpCheque.Visible = False
            lblCheque.Visible = False
            txtPayment.Select()
        Else
            dtpCheque.Visible = True
            lblCheque.Visible = True
            txtBank.Text = ""
            txtCheque.Text = ""
            txtBank.Select()
        End If
    End Sub

    Private Sub txtPurchase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPurchase.KeyPress
        NumKey(txtPayment.Text, e)
    End Sub

    Private Sub cmbSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSupplier.SelectedIndexChanged
        sqlSTR = "SELECT Ac_ID FROM tbl_Accounts WHERE Ac_Name='" & cmbSupplier.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        SuppID = sqlDT.Rows(0)("Ac_ID")
    End Sub

    Private Sub txtDep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDep.KeyPress
        NumKey(txtPayment.Text, e)
    End Sub
End Class