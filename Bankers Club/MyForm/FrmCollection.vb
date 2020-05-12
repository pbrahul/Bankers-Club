Imports DevComponents.DotNetBar

Public Class FrmCollection
    Dim TransID As String
    Dim scAccounts As New AutoCompleteStringCollection
    Dim Cust_Name As String
    Dim Col_ID As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Collection"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ClearAll(TableLayoutPanel2, Highlighter1)

        SingleComboBox("SELECT Cash_Name FROM tbl_CashBank ORDER BY Cash_ID ASC", cmbFrom)

        SingleComboBox("SELECT Type_Details FROM tbl_Collection_Type ORDER BY Type_ID ASC", cmbType)

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
        txtBank.Text = "N/A"
        txtCheque.Text = "N/A"
        txtRemarks.Text = "N/A"
        dtpIssue.Visible = False
        lblIssue.Visible = False

        txtSearch.Select()
    End Sub

    Private Sub Discount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles swPayment.KeyDown
        If e.KeyCode = Keys.Enter Then
            If swPayment.Value = False Then
                swPayment.Value = True
            ElseIf swPayment.Value = True Then
                swPayment.Value = False
            End If
        End If
    End Sub

    Private Sub swPayment_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles swPayment.ValueChanged
        If swPayment.Value = True Then
            dtpIssue.Visible = False
            lblIssue.Visible = False
            txtPayment.Clear()
            txtPayment.Select()
        ElseIf swPayment.Value = False Then
            dtpIssue.Visible = True
            lblIssue.Visible = True
            txtPayment.Clear()
            txtBank.Select()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Pre_Date As Date
        Dim ColID As String

        If FillTextBox(TableLayoutPanel2, Highlighter1) = False Then
            Exit Sub
        End If

        If txtPayment.Text <= 0 Then
            Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.Red)
            txtPayment.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtPayment, Validator.eHighlightColor.None)
        End If

        If txtYear.Text.Length <> 4 Then
            Highlighter1.SetHighlightColor(txtYear, Validator.eHighlightColor.Red)
            txtYear.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtYear, Validator.eHighlightColor.None)

        End If

        Pre_Date = dtpDate.Text & " " & TimeOfDay

        '=================== tbl_Ac_Ledger ===================
        sqlSTR = "INSERT INTO tbl_collections(Col_Date, Fee_Type, Collection_Type, Bank_Name, Cheque_No, Cheque_Date, Col_Amt, Col_Year, Remarks, Type_ID, Mem_ID, Cash_ID, User_ID) VALUES ('" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                 "', '" & cmbType.SelectedItem & "', '" & IIf(swPayment.Value = True, "Cash", "Checque") & "', '" & txtBank.Text & "',  '" & txtCheque.Text & "', '" & Format(dtpIssue.Value, "yyyy/MM/dd") & "', " & CDbl(txtPayment.Text) & ", " & txtYear.Text & ",  '" & txtRemarks.Text & _
                 "', " & Col_ID & ", '" & CustID & "', '" & Cash_ID & "', '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)

        '============= tbl_Cash_Ledger ==================
        sqlSTR = "SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date<='" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & "' ORDER BY Led_Date DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            Cash_Bal = sqlDT.Rows(0)("Bal_Amt")
        Else
            Cash_Bal = txtBalance.Text
        End If

        ExecuteSQLQuery("SELECT MAX(Col_ID) AS Ledger_ID FROM tbl_Collections")
        ColID = sqlDT.Rows(0)("Ledger_ID")

        sqlSTR = "INSERT INTO tbl_cashbank_ledger (Cash_ID, Led_Particulars, Led_Date, Receive_Amt, Bal_Amt, Ac_ID, Ledger_ID, User_ID) VALUES('" & Cash_ID & "', 'Receive from " & Cust_Name & "', '" & Format(Pre_Date, "yyyy/MM/dd HH:mm:ss") & _
                 "', " & CDbl(txtPayment.Text) & ", " & CDbl(Cash_Bal) + CDbl(txtPayment.Text) & ", '" & CustID & "', '" & ColID & "', '" & UserID & "') "
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
        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(dtpDate.Value, "yyyy/MM/dd") & "'"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
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
            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtPayment.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
            GetSQLQuery(sqlSTR)
        Next

        'MessageBoxEx.Show("Record Save Successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If MessageBoxEx.Show("Record Save Successfully. Do you want print the receipt?", "Receipt Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            RptStr = "SELECT C.Col_ID, C.Col_Date, C.Bank_Name, C.Cheque_Date, C.Collection_Type, M.Mem_ID, M.Mem_Name, CONCAT(T.Type_Details, ' - ', C.Col_Year) AS Type_Details, C.Cheque_No, C.Col_Amt FROM tbl_Collections AS C " & _
                     "INNER JOIN tbl_Member AS M ON M.Mem_ID=C.Mem_ID INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID WHERE C.Col_ID='" & ColID & "'"

            mReport.Load(Application.StartupPath & "\MyReports\rptCollectionReceipt.rpt")
            mReport.SetDataSource(ExecuteSQLQuery(RptStr))

            FrmReports.CompanyInfo()

            mReport.PrintToPrinter(1, True, 0, 0)
        End If

        Me.Close()
        FrmCollectionList.RefreshCollections()
    End Sub

    Private Sub txtPayment_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPayment.KeyPress
        NumKey(txtPayment.Text, e)
    End Sub


    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text <> "" Then
                sqlSTR = "SELECT Mem_ID, Mem_Name, Mem_Contact, Bank_Name FROM tbl_Member WHERE Mem_ID='" & txtSearch.Text & "' OR Mem_Contact='" & txtSearch.Text & "'" 'RIGHT(Mem_ID," & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR RIGHT(Mem_Contact," & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    CustID = sqlDT.Rows(0)("Mem_ID")

                    txtID.Text = sqlDT.Rows(0)("Mem_ID")
                    txtName.Text = sqlDT.Rows(0)("Mem_Name")
                    txtBankName.Text = sqlDT.Rows(0)("Bank_Name")
                    txtContact.Text = sqlDT.Rows(0)("Mem_Contact")
                Else
                    MessageBoxEx.Show("Result not found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub cmbFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFrom.SelectedIndexChanged
        sqlSTR = "SELECT Cash_ID, Bal_Amt FROM tbl_CashBank WHERE Cash_Name='" & cmbFrom.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Cash_ID = sqlDT.Rows(0)("Cash_ID")
            txtBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If
    End Sub

    
    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        sqlSTR = "SELECT Type_ID, Type_Amt FROM tbl_Collection_Type WHERE Type_Details='" & cmbType.SelectedItem & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            Col_ID = sqlDT.Rows(0)("Type_ID")
            txtPayment.Text = Format(sqlDT.Rows(0)("Type_Amt"), "###,###.00")
        End If
    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        FrmCollectionType.ShowDialog()
    End Sub

    Private Sub txtYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYear.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

End Class