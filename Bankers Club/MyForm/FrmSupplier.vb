Imports DevComponents.DotNetBar

Public Class FrmSupplier

    Private Sub FrmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(388, 280)

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            txtName.Select()

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM tbl_Suppliers WHERE Supp_ID ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)
            txtName.Text = sqlDT.Rows(0)("Supp_Name")
            txtAddress.Text = sqlDT.Rows(0)("Supp_Address")
            txtContact.Text = sqlDT.Rows(0)("Contact_No")
            txtEmail.Text = sqlDT.Rows(0)("Email")
            txtName.Select()
        End If
    End Sub

    Private Sub FrmUserAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Supplier"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DuplicateName As Boolean

        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "SELECT Supp_Name FROM tbl_Suppliers"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Supp_Name")) = UCase(txtName.Text) Then
                    MessageBoxEx.Show("Supplier already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtName.Select()
                    Exit Sub
                End If
            Next

            GetID = AutoIDPreFix("tbl_Suppliers", "Supp_ID", PreFix)

            sqlSTR = "INSERT INTO tbl_Suppliers(Supp_ID, Supp_Name, Supp_Address, Contact_No, Email, Supp_Group, User_ID, Due_Amount) " & _
                     "VALUES('" & GetID & "', '" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtContact.Text & _
                     "', '" & txtEmail.Text & "', 'N/A', '" & UserID & "', 0)"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("Record Save Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Add a New Supplier", TimeOfDay.ToString("hh:mm:ss tt"))

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT Supp_Name FROM tbl_Suppliers WHERE Supp_ID ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Supp_Name")) = UCase(txtName.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT Supp_Name FROM tbl_Suppliers WHERE Supp_Name ='" & txtName.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MessageBoxEx.Show("Supplier already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DuplicateName = True
                    txtName.Select()
                    Exit Sub
                Else
                    DuplicateName = False
                End If
            End If

            If DuplicateName = False Then
                sqlSTR = "UPDATE tbl_Suppliers SET Supp_Name ='" & txtName.Text & "', Supp_Address = '" & txtAddress.Text & "', " & _
                         "Contact_No='" & txtContact.Text & "', Email='" & txtEmail.Text & "', User_ID='" & UserID & "' WHERE Supp_ID ='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("Record Successfully Updated...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'UsersLogDetails("Edit Supplier Details", TimeOfDay.ToString("hh:mm:ss tt"))
            End If
        End If

        'FrmSupplierList.RefreshSupplier()
        'SingleComboBox("SELECT Supp_Name FROM tbl_Suppliers ORDER BY Supp_Name ASC", FrmPurchase.cmbSuppName)
        Me.Close()
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "-", vbBack, Space(32)
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

End Class