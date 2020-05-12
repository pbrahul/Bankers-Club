Imports DevComponents.DotNetBar
Imports ComponentFactory.Krypton.Toolkit

Public Class FrmAccountsAdd

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Account"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(417, 364)
        ClearAll(tableLayoutPanel1, Highlighter1)

        SingleComboBox("SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_Details<>'Expense' ORDER BY Type_Details ASC", cmbType)
        chkLiability.Checked = False

        If Split(Me.Text, " - ")(1) = "Add" Then
            txtBalAmt.Enabled = True
            txtName.Select()

        Else
            sqlSTR = "SELECT A.AC_ID, A.AC_Name, A.Ac_Address, C.Type_Details, A.Contact_No, A.Ac_Email, A.Bal_Amt FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS C ON A.Type_ID=C.Type_ID WHERE Ac_ID = '" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            txtName.Text = sqlDT.Rows(0)("AC_Name")
            txtAddress.Text = sqlDT.Rows(0)("Ac_Address")
            cmbType.SelectedItem = sqlDT.Rows(0)("Type_Details")
            txtContact.Text = sqlDT.Rows(0)("Contact_No")
            txtEmail.Text = sqlDT.Rows(0)("Ac_Email")
            txtBalAmt.Text = sqlDT.Rows(0)("Bal_Amt")

            txtBalAmt.Enabled = False
            txtName.Select()
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DuplicateName As Boolean
        Dim Type_ID, Type_Code As String

        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        sqlSTR = "SELECT Type_ID, Type_Code FROM tbl_Accounts_Type WHERE Type_Details='" & cmbType.Text & "'"
        ExecuteSQLQuery(sqlSTR)

        Type_ID = sqlDT.Rows(0)("Type_ID")
        Type_Code = sqlDT.Rows(0)("Type_Code")

        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "SELECT Ac_Name FROM tbl_Accounts"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Ac_Name")) = UCase(txtName.Text) Then
                    'MessageBoxEx.Show("Contact no is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.Red)
                    txtName.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.None)
                End If
            Next

            sqlSTR = "SELECT Contact_No FROM tbl_accounts WHERE Contact_No<>0"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Contact_No")) = UCase(txtContact.Text) Then
                    'MessageBoxEx.Show("Contact no is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Highlighter1.SetHighlightColor(txtContact, Validator.eHighlightColor.Red)
                    txtName.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtContact, Validator.eHighlightColor.None)
                End If
            Next

            GetID = ManualID("tbl_Accounts", "Ac_ID", Type_Code)

            sqlSTR = "INSERT INTO tbl_Accounts(AC_ID, AC_Name, Ac_Address, Contact_No, Ac_Email, Type_ID, Bal_Amt, User_ID) VALUES('" & GetID & "', '" & txtName.Text & _
                     "', '" & txtAddress.Text & "', '" & txtContact.Text & "', '" & txtEmail.Text & "', " & Type_ID & ", " & IIf(chkLiability.Checked = True, -(CDbl(txtBalAmt.Text)), CDbl(txtBalAmt.Text)) & ", '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            sqlSTR = "INSERT INTO tbl_ac_ledger(Ac_ID, Ledger_Date, Led_Particulars, Balance_Amt, User_ID) VALUES('" & GetID & "', '" & Format(Now, "yyyy/MM/dd HH:mm:ss") & "', 'Opening Balance', " & IIf(chkLiability.Checked = True, -(CDbl(txtBalAmt.Text)), CDbl(txtBalAmt.Text)) & ", '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            MessageBoxEx.Show("Record Save Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Add a New Supplier", TimeOfDay.ToString("hh:mm:ss tt"))

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT Ac_Name FROM tbl_Accounts WHERE AC_ID='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Ac_Name")) = UCase(txtName.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT Ac_Name FROM tbl_Accounts WHERE Ac_Name ='" & txtName.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.Red)
                    DuplicateName = True
                    txtContact.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.None)
                    DuplicateName = False
                End If
            End If


            If txtContact.Text <> "0" Then
                sqlSTR = "SELECT Contact_No FROM tbl_accounts WHERE AC_ID='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)

                If UCase(sqlDT.Rows(0)("Contact_No")) = UCase(txtContact.Text) Then
                    DuplicateName = False
                Else
                    sqlSTR = "SELECT Contact_No FROM tbl_accounts WHERE Contact_No ='" & txtContact.Text & "'"
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        Highlighter1.SetHighlightColor(txtContact, Validator.eHighlightColor.Red)
                        DuplicateName = True
                        txtContact.Select()
                        Exit Sub
                    Else
                        Highlighter1.SetHighlightColor(txtContact, Validator.eHighlightColor.None)
                        DuplicateName = False
                    End If
                End If
            End If

            If DuplicateName = False Then
                sqlSTR = "UPDATE tbl_Accounts SET AC_Name = '" & txtName.Text & "', AC_Address = '" & txtAddress.Text & "', Contact_No = '" & txtContact.Text & _
                         "', Ac_Email='" & txtEmail.Text & "', Type_ID=" & Type_ID & ", User_ID = '" & UserID & "' WHERE Ac_ID ='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("Record Successfully Updated...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'UsersLogDetails("Edit Supplier Details", TimeOfDay.ToString("hh:mm:ss tt"))
            End If
        End If

        FrmAllAccounts.RefreshAccounts()
        'FrmPurchase.SearchAccounts()

        SingleComboBox("SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID " & _
                       "WHERE C.Type_Details='Supplier' ORDER BY A.Ac_Name ASC", FrmAsset.cmbSupplier)


        FrmSales.SearchAccounts()

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

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        FrmAccountsType.ShowDialog()
    End Sub
End Class