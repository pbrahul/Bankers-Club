Imports DevComponents.DotNetBar

Public Class FrmLogin
    Dim xcountx As Integer

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Clear()
        txtPassword.Clear()
        txtUser.Select()

        'txtUser.Text = "MMH"
        'txtPassword.Text = "22233"

        'txtUser.Text = "Admin"
        'txtPassword.Text = "admin"

    End Sub

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        If txtUser.Text = "" Then
            Highlighter1.SetHighlightColor(txtUser, Validator.eHighlightColor.Red)
            txtUser.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtUser, Validator.eHighlightColor.None)
        End If

        If txtPassword.Text = "" Then
            Highlighter1.SetHighlightColor(txtPassword, Validator.eHighlightColor.Red)
            txtPassword.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtPassword, Validator.eHighlightColor.None)
        End If

        sqlSTR = "SELECT * FROM TBL_Users WHERE UserName='" & txtUser.Text & "' AND UserPass ='" & Encrypt(txtPassword.Text) & "'"
        ExecuteSQLQuery(sqlSTR)
        If sqlDT.Rows.Count > 0 Then
            If sqlDT.Rows(0)("System_Login") = "Active" Then
                For i = 0 To sqlDT.Rows.Count - 1
                    If UCase(sqlDT.Rows(i)("username")) <> UCase(txtUser.Text) Or sqlDT.Rows(i)("userpass") <> Encrypt(txtPassword.Text) Then
                        MessageBoxEx.Show("Access denied. Please Enter Correct User and Password !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        xcountx = xcountx + 1
                        If xcountx >= 3 Then
                            MessageBoxEx.Show("You have reach the maximum time of Sign In !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End
                        End If
                        Exit Sub
                    End If
                Next
                UserName = sqlDT.Rows(0)("Username")
                UserID = sqlDT.Rows(0)("User_id")
                UserType = sqlDT.Rows(0)("Access_Type")
                uPermission = sqlDT.Rows(0)("User_Permission")

                With FrmMain
                    .btnSignIn.Text = sqlDT.Rows(0)("Full_Name")
                    .Show()
                End With
                Me.Close()

            Else
                MessageBoxEx.Show("Your account is inactive." & vbNewLine & "Please, Contact Your System Administrator.", "Sign-in IT", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End
            End If
        Else
            xcountx = xcountx + 1
            If xcountx >= 3 Then
                MessageBoxEx.Show("You have reach the maximum time of login !!", "Sales and Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End
            End If
            MessageBoxEx.Show("Access denied. Please Enter Correct User and Password !!!", "Sales and Inventory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class