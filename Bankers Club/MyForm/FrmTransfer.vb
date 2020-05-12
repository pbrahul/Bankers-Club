Imports DevComponents.DotNetBar

Public Class FrmTransfer
    Dim TransTo As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Cash Transfer"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(740, 326)
        ClearAll(TableLayoutPanel1, Highlighter1)

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_ID ASC", cmbFrom)

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_ID ASC", cmbTo)

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


        txtCarrier.Text = "N/A"
        txtCheque.Text = "N/A"
        txtRemarks.Text = "N/A"

        cmbFrom.Select()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Pre_Date As Date

        If FillTextBox(TableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If txtPayment.Text = "" Or Val(txtPayment.Text) <= 0 Then
            Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.Red)
            txtPayment.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.None)
        End If

        If Cash_ID = TransTo Then
            Highlighter1.SetHighlightColor(cmbTo, Validator.eHighlightColor.Red)
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(cmbTo, Validator.eHighlightColor.None)
        End If

        Pre_Date = dtpDate.Text & " " & TimeOfDay

        '=================== tbl_Transfer ===================
        sqlSTR = "INSERT INTO tbl_transfer(Tr_Date, Tr_From, Tr_To, Tr_Details, Tr_Cheque, Tr_Carrier, Tr_Amt, User_ID) VALUES('" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "', '" & Cash_ID & _
                 "', '" & TransTo & "','" & txtRemarks.Text & "', '" & txtCheque.Text & "',  '" & txtCarrier.Text & "', " & CDbl(txtPayment.Text) & ", '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)

        ' ============= tbl_Cash_Ledger ==================
        ' ============= Transfer From ====================
        sqlSTR = "SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Led_Date DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            Cash_Bal = sqlDT.Rows(0)("Bal_Amt")
        Else
            Cash_Bal = txtFromBalance.Text
        End If

        ExecuteSQLQuery("SELECT MAX(Tr_ID) AS Tr_ID FROM tbl_Transfer")

        sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Paid_Amt, Bal_Amt, Tr_ID, User_ID) VALUES('" & Cash_ID & "', 'Transfer to " & cmbTo.SelectedItem & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                 "', " & CDbl(txtPayment.Text) & ", " & CDbl(Cash_Bal) - CDbl(txtPayment.Text) & ", '" & sqlDT.Rows(0)("Tr_ID") & "', '" & UserID & "') "
        ExecuteSQLQuery(sqlSTR)

        sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
        ExecuteSQLQuery(sqlSTR)

        For i As Integer = 0 To sqlDT.Rows.Count - 1
            sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
            GetSQLQuery(sqlSTR)
        Next

        sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt- " & CDbl(txtPayment.Text) & " WHERE Cash_ID = '" & Cash_ID & "'"
        ExecuteSQLQuery(sqlSTR)

        ' ============= Transfer To ====================
        sqlSTR = "SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & TransTo & "' AND Led_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Led_Date DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            Cash_Bal = sqlDT.Rows(0)("Bal_Amt")
        Else
            Cash_Bal = txtToBalance.Text
        End If

        ExecuteSQLQuery("SELECT MAX(Tr_ID) AS Tr_ID FROM tbl_Transfer")

        sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Receive_Amt, Bal_Amt, Tr_ID, User_ID) VALUES('" & TransTo & "', 'Transfer from " & cmbFrom.SelectedItem & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                 "', " & CDbl(txtPayment.Text) & ", " & CDbl(Cash_Bal) + CDbl(txtPayment.Text) & ", '" & sqlDT.Rows(0)("Tr_ID") & "', '" & UserID & "') "
        ExecuteSQLQuery(sqlSTR)

        sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & TransTo & "' AND Led_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
        ExecuteSQLQuery(sqlSTR)

        For i As Integer = 0 To sqlDT.Rows.Count - 1
            sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
            GetSQLQuery(sqlSTR)
        Next

        sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt+ " & CDbl(txtPayment.Text) & " WHERE Cash_ID = '" & TransTo & "'"
        ExecuteSQLQuery(sqlSTR)

        ''============= tbl_Balance ==================
        'sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
        'ExecuteSQLQuery(sqlSTR)

        'If sqlDT.Rows.Count > 0 Then
        '    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
        '    ExecuteSQLQuery(sqlSTR)
        'Else
        '    sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
        '    ExecuteSQLQuery(sqlSTR)

        '    If sqlDT.Rows.Count > 0 Then
        '        BalAmt = sqlDT.Rows(0)("Bal_Amt")
        '    Else
        '        BalAmt = 0
        '    End If

        '    sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) + CDbl(txtPayment.Text) & ", '" & Format(dtpDate.Value, "yyyy/MM/dd") & "')"
        '    ExecuteSQLQuery(sqlSTR)
        'End If

        'sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
        'ExecuteSQLQuery(sqlSTR)

        'For i As Integer = 0 To sqlDT.Rows.Count - 1
        '    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
        '    GetSQLQuery(sqlSTR)
        'Next

        MessageBoxEx.Show("Record Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'FrmCustomerPaymentDetails.RefreshCustomerPayment()
        Me.Close()
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        NumKey(txtPayment.Text, e)
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbFrom.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Cash_ID = sqlDT.Rows(0)("Cash_ID")
            txtFromBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If
    End Sub

    Private Sub cmbTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTo.SelectedIndexChanged
        sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbTo.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            TransTo = sqlDT.Rows(0)("Cash_ID")
            txtToBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If

    End Sub
End Class