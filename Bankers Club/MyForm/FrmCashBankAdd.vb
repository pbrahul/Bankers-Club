Imports DevComponents.DotNetBar
Imports ComponentFactory.Krypton.Toolkit

Public Class FrmCashBankAdd

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Cash"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(420, 358)

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            cmbType.SelectedIndex = 1

            txtBalAmt.Enabled = True
            txtName.Select()
        Else
            sqlSTR = "SELECT * FROM tbl_CashBank WHERE Cash_ID = '" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            txtName.Text = sqlDT.Rows(0)("Cash_Name")
            txtAddress.Text = sqlDT.Rows(0)("Cash_Address")
            txtDetails.Text = sqlDT.Rows(0)("Cash_Details")
            cmbType.SelectedItem = sqlDT.Rows(0)("Cash_Type")
            txtContact.Text = sqlDT.Rows(0)("Contact_No")
            txtBalAmt.Text = sqlDT.Rows(0)("Bal_Amt")

            txtBalAmt.Enabled = False
            txtName.Select()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DuplicateName As Boolean

        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "SELECT Cash_Name FROM tbl_CashBank"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Cash_Name")) = UCase(txtName.Text) Then
                    'MessageBoxEx.Show("Contact no is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.Red)
                    txtName.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.None)
                End If
            Next

            GetID = ManualID("tbl_CashBank", "Cash_ID", "B")

            sqlSTR = "INSERT INTO tbl_cashbank(Cash_ID, Cash_Name, Cash_Address, Cash_Details, Cash_Type, Contact_No, Bal_Amt, User_ID) VALUES('" & GetID & "', '" & txtName.Text & _
                     "', '" & txtAddress.Text & "', '" & txtDetails.Text & "', '" & cmbType.Text & "', '" & txtContact.Text & "', " & CDbl(txtBalAmt.Text) & ", '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "INSERT INTO tbl_Cashbank_Ledger(Cash_ID, Led_Date, Led_Particulars, Bal_Amt, User_ID) VALUES('" & GetID & "', '" & Format(Now, "yyyy/MM/dd HH:mm:ss") & "', 'Opening Balance', " & CDbl(txtBalAmt.Text) & ", '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            '============= tbl_Balance ==================

            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date='" & Format(Now, "yyyy/MM/dd") & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtBalAmt.Text) + CDbl(BalAmt) & " WHERE Bal_ID=" & sqlDT.Rows(0)("Bal_ID")
                ExecuteSQLQuery(sqlSTR)
            Else
                sqlSTR = "SELECT Bal_Amt FROM tbl_Balance WHERE Bal_Date<'" & Format(Now, "yyyy/MM/dd") & "' ORDER BY Bal_Date DESC"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    BalAmt = sqlDT.Rows(0)("Bal_Amt")
                Else
                    BalAmt = 0
                End If

                sqlSTR = "INSERT INTO tbl_Balance(Bal_Amt, Bal_Date) VALUES(" & CDbl(txtBalAmt.Text) & ", '" & Format(Now, "yyyy/MM/dd") & "')"
                ExecuteSQLQuery(sqlSTR)
            End If

            'sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>'" & Format(Now, "yyyy/MM/dd") & "'"
            'ExecuteSQLQuery(sqlSTR)

            'For i As Integer = 0 To sqlDT.Rows.Count - 1
            '    sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(txtBalAmt.Text) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
            '    GetSQLQuery(sqlSTR)
            'Next

            MessageBoxEx.Show("Record Save Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Add a New Supplier", TimeOfDay.ToString("hh:mm:ss tt"))

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT Cash_Name FROM tbl_CashBank WHERE Cash_ID='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Cash_Name")) = UCase(txtName.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT Cash_Name FROM tbl_CashBank WHERE Cash_Name ='" & txtName.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    'MessageBoxEx.Show("Contact no already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.Red)
                    DuplicateName = True
                    txtName.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.None)
                    DuplicateName = False
                End If
            End If

            If DuplicateName = False Then
                sqlSTR = "UPDATE tbl_CashBank SET Cash_Name = '" & txtName.Text & "', Cash_Address = '" & txtAddress.Text & "', Contact_No = '" & txtContact.Text & _
                         "', Cash_Details = '" & txtDetails.Text & "', Cash_Type='" & cmbType.Text & "', User_ID = '" & UserID & "' WHERE Cash_ID ='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("Record Successfully Updated...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'UsersLogDetails("Edit Supplier Details", TimeOfDay.ToString("hh:mm:ss tt"))
            End If
        End If

        FrmCashBank.RefreshCashBank()
        Me.Close()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Then
            If Asc(e.KeyChar) = 45 Then
                If CType(sender, KryptonTextBox).Text.Contains(Chr(45)) Then
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

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBalAmt.KeyPress
        NumKey(txtBalAmt.Text, e)
    End Sub
End Class