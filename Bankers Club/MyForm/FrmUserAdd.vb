Imports DevComponents.DotNetBar

Public Class FrmUserAdd
    Private Sub FrmUserAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "User Account"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub FrmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(431, 423)

        KeyPreview = True
        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            txtFullName.Select()
            chkLogin.Checked = False

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM tbl_Users WHERE User_ID = '" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            txtFullName.Text = sqlDT.Rows(0)("Full_Name")
            txtAddress.Text = sqlDT.Rows(0)("User_Address")
            txtContact.Text = sqlDT.Rows(0)("User_Contact")
            txtUserName.Text = sqlDT.Rows(0)("UserName")
            cmbType.Text = sqlDT.Rows(0)("Access_Type")
            txtPassword.Text = Decrypt(sqlDT.Rows(0)("UserPass"))
            txtConPass.Text = Decrypt(sqlDT.Rows(0)("UserPass"))
            chkLogin.Checked = IIf(sqlDT.Rows(0)("System_Login") = "Active", True, False)
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DuplicateName As Boolean
        Dim strErr, strNoErr, UserPermission As String

        If FillTextBox(TableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If
        'strErr = "Please complete the following requirements!" & _
        '    Chr(10) & "__________________________________" & Chr(10)
        'strNoErr = strErr

        'If txtFullName.Text = "" Then
        '    strErr = strErr & Chr(10) & "User Full Name"
        '    txtFullName.Select()
        'End If

        'If txtAddress.Text = "" Then
        '    strErr = strErr & Chr(10) & "Address"
        '    txtAddress.Select()
        'End If

        'If txtContact.Text = "" Then
        '    strErr = strErr & Chr(10) & "Mobile / Phone "
        '    txtContact.Select()
        'End If

        'If txtUserName.Text = "" Then
        '    strErr = strErr & Chr(10) & "User Login Name"
        '    txtUserName.Select()
        'End If

        'If cmbType.Text = "" Then
        '    strErr = strErr & Chr(10) & "Account Type"
        '    cmbType.Select()
        'End If

        'If txtPassword.Text = "" Then
        '    strErr = strErr & Chr(10) & "Password "
        '    txtPassword.Select()
        'End If

        'If txtPassword.Text <> txtConPass.Text Then
        '    strErr = strErr & Chr(10) & "Password not match"
        '    txtConPass.Select()
        'End If

        'If Len(txtPassword.Text) < 5 Then
        '    strErr = strErr & Chr(10) & "Password Must Be At least 5 Characters"
        '    txtPassword.Select()
        'End If

        'If strNoErr <> strErr Then
        '    MessageBoxEx.Show(strErr, "Sign In IT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If


        If Len(txtPassword.Text) < 5 Then
            Highlighter1.SetHighlightColor(txtPassword, Validator.eHighlightColor.Red)
            MessageBoxEx.Show("Password Must Be At least 5 Characters", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtPassword, Validator.eHighlightColor.None)
        End If

        If txtPassword.Text <> txtConPass.Text Then
            Highlighter1.SetHighlightColor(txtPassword, Validator.eHighlightColor.Red)
            MessageBoxEx.Show("Password not match.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtPassword, Validator.eHighlightColor.None)
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            If cmbType.Text = "Administrator" Then
                UserPermission = "111111111111111"
            Else
                UserPermission = "111111111100010"
            End If

            sqlSTR = "SELECT * FROM tbl_Users"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("UserName")) <> UCase(txtUserName.Text) Then
                    DuplicateName = False
                Else
                    MessageBoxEx.Show("User Name Already Exist !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUserName.Select()
                    DuplicateName = True
                    Exit Sub
                End If
            Next

            GetID = ManualID("tbl_Users", "User_ID", "U")

            If DuplicateName = False Then
                sqlSTR = "INSERT INTO tbl_Users(User_ID, Full_Name, User_Address, User_Contact, UserName, UserPass, Access_Type, System_Login, User_Permission) VALUES('" & GetID & "', '" & txtFullName.Text & "', '" & txtAddress.Text & "', '" & txtContact.Text & "', '" & txtUserName.Text & _
                         "', '" & Encrypt(txtPassword.Text) & "', '" & cmbType.Text & "', '" & IIf(chkLogin.Checked = True, "Active", "Inactive") & "', '" & UserPermission & "')"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("Record Saved Successfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT UserName FROM tbl_Users WHERE User_ID ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("UserName")) = UCase(txtUserName.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT UserName FROM tbl_Users WHERE UserName ='" & txtUserName.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MessageBoxEx.Show("User Name Already Exist !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DuplicateName = True
                    txtUserName.Select()
                    Exit Sub
                Else
                    DuplicateName = False
                End If
            End If

            If DuplicateName = False Then
                sqlSTR = "UPDATE tbl_Users SET Full_Name ='" & txtFullName.Text & "', User_Address = '" & txtAddress.Text & "', " & _
                         "User_Contact='" & txtContact.Text & "', UserName='" & txtUserName.Text & "',UserPass='" & Encrypt(txtPassword.Text) & _
                         "', Access_Type='" & cmbType.Text & "', System_Login = '" & IIf(chkLogin.Checked = True, "Active", "Inactive") & "' WHERE User_ID ='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("Record Successfully Updated...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        FrmUserView.UserRefresh()
        Me.Close()
    End Sub
End Class