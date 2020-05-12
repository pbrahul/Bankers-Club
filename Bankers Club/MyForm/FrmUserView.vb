Imports DevComponents.DotNetBar

Public Class FrmUserView

    Public Sub UserRefresh()
        sqlSTR = "SELECT User_ID, Full_Name,  UserName, Access_Type, User_Contact, System_Login FROM tbl_Users ORDER BY User_ID ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvUser)
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'grpUser.Left = (Me.Width / 2) - 460
        'grpUser.Top = (Me.Height / 2) - 285

        grpUser.Width = FrmMain.Width - 200
        grpUser.Height = FrmMain.Height - 200
        grpUser.Location = New Point(100, 50)

        dgvUser.Width = grpUser.Width - 33
        dgvUser.Height = grpUser.Height - 70

        Panel3.Left = dgvUser.Width - 216

    End Sub


    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        If dgvUser.SelectedRows.Count > 0 Then
            If MessageBoxEx.Show("Do you want to sure reset password ??", "Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sqlSTR = "UPDATE tbl_Users SET UserPass = '" & Encrypt("12345") & "' WHERE User_ID = '" & dgvUser.SelectedRows(0).Cells(0).Value & "'"
                ExecuteSQLQuery(sqlSTR)
                MessageBoxEx.Show("User Password Reset Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBoxEx.Show("No User Select For Set Reset Password." & vbNewLine & "Please Select one !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub

        End If
    End Sub

    Private Sub btnPermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermission.Click
        If dgvUser.SelectedRows.Count > 0 Then
            If dgvUser.SelectedRows(0).Cells(3).Value <> "Administrator" Then
                UserEdit = dgvUser.SelectedRows(0).Cells(0).Value
                FrmPermission.ShowDialog()
            Else
                MessageBoxEx.Show("Administrator User Can't be Change Permission." & vbNewLine & "First Change User Access Type!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        Else
            MessageBoxEx.Show("No User Select For Set Permission." & vbNewLine & "Please Select one !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub FrmUserView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserRefresh()
    End Sub
End Class