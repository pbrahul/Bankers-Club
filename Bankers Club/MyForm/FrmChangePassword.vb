Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Validator

Public Class FrmChangePassword

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        'If FillTextBox(PanelEx2, Highlighter1) = False Then
        '    Exit Sub
        'End If

        If txtOldPassword.Text = "" Then
            Highlighter1.SetHighlightColor(txtOldPassword, eHighlightColor.Red)
            txtOldPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtOldPassword, eHighlightColor.None)
        End If

        If txtNewPassword.Text = "" Then
            Highlighter1.SetHighlightColor(txtNewPassword, eHighlightColor.Red)
            txtNewPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtNewPassword, eHighlightColor.None)
        End If

        If txtVerifyPassword.Text = "" Then
            Highlighter1.SetHighlightColor(txtVerifyPassword, eHighlightColor.Red)
            txtVerifyPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtVerifyPassword, eHighlightColor.None)
        End If

        If Len(txtNewPassword.Text) < 5 Then
            Highlighter1.SetHighlightColor(txtNewPassword, eHighlightColor.Red)
            txtNewPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtNewPassword, eHighlightColor.None)
        End If

        If txtNewPassword.Text <> txtVerifyPassword.Text Then
            MessageBoxEx.Show("New password does not match your verified password.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtVerifyPassword.Clear()
            txtVerifyPassword.Select()
            Exit Sub
        End If

        sqlSTR = "SELECT UserPass FROM tbl_Users WHERE User_ID ='" & UserID & "'"
        ExecuteSQLQuery(sqlSTR)

        If Not Decrypt(sqlDT.Rows(0)("UserPass")) = txtOldPassword.Text Then
            MessageBoxEx.Show("The old password you typed does not match.", "Mismatch password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOldPassword.Text = ""
            txtOldPassword.Focus()
            Exit Sub
        End If

        If txtNewPassword.Text = txtVerifyPassword.Text Then
            sqlSTR = "UPDATE tbl_Users SET UserPass = '" & Encrypt(txtNewPassword.Text) & "' WHERE User_ID = '" & UserID & "'"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("Password Successfully Change.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub FrmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtOldPassword.Text = ""
        txtNewPassword.Text = ""
        txtVerifyPassword.Text = ""
        txtOldPassword.Select()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class