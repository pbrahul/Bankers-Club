Imports DevComponents.DotNetBar
Imports ComponentFactory.Krypton.Toolkit

Public Class FrmCustomer

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Customer"
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(387, 325)

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            txtName.Select()

        Else
            sqlSTR = "SELECT * FROM tbl_Customers WHERE Cust_ID = '" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            txtName.Text = sqlDT.Rows(0)("Cust_Name")
            txtAddress.Text = sqlDT.Rows(0)("Cust_Address")
            txtEmail.Text = sqlDT.Rows(0)("Email")
            txtContact.Text = sqlDT.Rows(0)("Contact_No")
            txtDiscount.Text = sqlDT.Rows(0)("Discount")

        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DuplicateName As Boolean

        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "SELECT Contact_No FROM tbl_Customers"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Contact_No")) = UCase(txtName.Text) Then
                    MessageBoxEx.Show("Contact no is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtName.Select()
                    Exit Sub
                End If
            Next

            GetID = AutoIDPreFix("tbl_Customers", "Cust_ID", PreFix)
            sqlSTR = "INSERT INTO tbl_Customers(Cust_ID, Cust_Name, Cust_Address, Contact_No, Email, User_ID, Due_Amount, Discount) VALUES('" & GetID & "', '" & txtName.Text & _
                     "', '" & txtAddress.Text & "', '" & txtContact.Text & "', '" & txtEmail.Text & "', '" & UserID & "', 0, " & txtDiscount.Text & ")"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("Record Save Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Add a New Supplier", TimeOfDay.ToString("hh:mm:ss tt"))

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT Contact_No FROM tbl_Customers WHERE Cust_ID='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Contact_No")) = UCase(txtName.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT Contact_No FROM tbl_Customers WHERE Cust_Name ='" & txtName.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MessageBoxEx.Show("Contact no already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    DuplicateName = True
                    txtName.Select()
                    Exit Sub
                Else
                    DuplicateName = False
                End If
            End If

            If DuplicateName = False Then
                sqlSTR = "UPDATE tbl_Customers SET Cust_Name = '" & txtName.Text & "', Cust_Address = '" & txtAddress.Text & "', Contact_No = '" & txtContact.Text & _
                         "', Email = '" & txtEmail.Text & "', Discount='" & txtDiscount.Text & "' User_ID = '" & UserID & "' WHERE Cust_ID ='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("Record Successfully Updated...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'UsersLogDetails("Edit Supplier Details", TimeOfDay.ToString("hh:mm:ss tt"))
            End If
        End If

        FrmAllAccounts.RefreshAccounts()
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

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        NumKey(txtDiscount.Text, e)
    End Sub
End Class