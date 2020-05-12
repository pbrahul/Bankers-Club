Imports DevComponents.DotNetBar

Public Class FrmExpense
    Dim CatID As String
    Dim AcBalance As Double

    Private Sub FrmExpense_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Expense"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmExpense_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(404, 357)

        ClearAll(tableLayoutPanel1, Highlighter1)

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_ID ASC", cmbFrom)
        SingleComboBox("SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE Type_Details='Expense' ORDER BY A.Ac_Name ASC", cmbType)

        If Split(Me.Text, " - ")(1) = "Add" Then
            cmbType.Select()
        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            cmbType.Select()

            sqlSTR = "SELECT tbl_Expense_Type.Type_Name, tbl_Expense.Ex_Des, FORMAT(tbl_Expense.Ex_Amount,2) AS 'Ex_Amount', tbl_Expense.Ex_Date " & _
                     "FROM tbl_Expense INNER JOIN tbl_Expense_Type ON tbl_Expense_Type.Type_ID=tbl_Expense.Type_ID  WHERE tbl_Expense.Ex_ID='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                cmbType.Text = sqlDT.Rows(0)("Type_Name")
                txtDesc.Text = sqlDT.Rows(0)("Ex_Des")
                txtPayment.Text = sqlDT.Rows(0)("Ex_Amount")
                dtpDate.Value = Format(sqlDT.Rows(0)("Ex_Date"), "dd MMM yyyy")
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Pre_Date As Date

        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If txtPayment.Text <= 0 Then
            Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.Red)
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.None)
        End If

        Pre_Date = dtpDate.Text & " " & TimeOfDay

        '=================== tbl_Ac_Ledger ===================
        sqlSTR = "SELECT Balance_Amt FROM tbl_Ac_ledger WHERE Ac_ID='" & CustID & "' AND Ledger_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Ledger_Date DESC, Ledger_ID DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            Cust_Bal = sqlDT.Rows(0)("Balance_Amt")
        Else
            Cust_Bal = 0
        End If

        sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & CustID & "' AND Ledger_Date>'" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "'"
        ExecuteSQLQuery(sqlSTR)

        For i As Integer = 0 To sqlDT.Rows.Count - 1
            sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt+" & CDbl(txtPayment.Text) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
            GetSQLQuery(sqlSTR)
        Next

        sqlSTR = "INSERT INTO tbl_ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Payment_Type, Cheque_No, Credit_Amt, Discount, Balance_Amt, Remarks, Cash_ID, User_ID) VALUES ('" & CustID & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                     "', 'Expesne from " & cmbFrom.SelectedItem & "', 'N/A',  'N/A', " & CDbl(txtPayment.Text) & ", 0, " & CDbl(Cust_Bal) + CDbl(txtPayment.Text) & ", '" & txtDesc.Text & "',  '" & Cash_ID & "', '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)

        sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = " & CDbl(AcBalance) + CDbl(txtPayment.Text) & " WHERE Ac_ID = '" & CustID & "'"
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

        sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Paid_Amt, Bal_Amt, Ac_ID, Ledger_ID, User_ID) VALUES('" & Cash_ID & "', 'Expense of " & cmbType.SelectedItem & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                 "', " & CDbl(txtPayment.Text) & ", " & CDbl(Cash_Bal) - CDbl(txtPayment.Text) & ", '" & CustID & "', '" & sqlDT.Rows(0)("Ledger_ID") & "', '" & UserID & "') "
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

            sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(BalAmt) + CDbl(txtPayment.Text) & ", '" & Format(dtpDate.Value, "yyyy/MM/dd") & "')"
            ExecuteSQLQuery(sqlSTR)
        End If

        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
        ExecuteSQLQuery(sqlSTR)

        For i As Integer = 0 To sqlDT.Rows.Count - 1
            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
            GetSQLQuery(sqlSTR)
        Next


        MessageBoxEx.Show("Record Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'FrmCustomerPaymentDetails.RefreshCustomerPayment()
        Me.Close()

    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        NumKey(txtPayment.Text, e)
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        FrmExpenseType.ShowDialog()
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbFrom.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Cash_ID = sqlDT.Rows(0)("Cash_ID")
            txtBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        sqlSTR = "SELECT A.AC_ID, A.Ac_Name, A.Contact_No, C.Type_Details, A.Bal_Amt FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID WHERE C.Type_Details='Expense' AND A.Ac_Name = '" & cmbType.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            CustID = sqlDT.Rows(0)("Ac_ID")
            AcBalance = sqlDT.Rows(0)("Bal_Amt")
        End If
    End Sub
End Class