Imports ComponentFactory.Krypton.Toolkit
Imports DevComponents.DotNetBar

Public Class FrmPermission

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim FrmAccess As String

        For Each ctrl As Control In tableLayoutPanel1.Controls
            If TypeOf ctrl Is KryptonCheckBox Then
                If DirectCast(ctrl, KryptonCheckBox).Checked Then
                    FrmAccess = 1 & FrmAccess
                    'MsgBox(ctrl.Name)
                Else
                    FrmAccess = 0 & FrmAccess
                    'MsgBox(ctrl.Name)
                End If
            End If
        Next

        'MsgBox(btnAccess)
        'MessageBoxEx.Show(FrmAccess)

        sqlSTR = "UPDATE tbl_Users SET User_Permission = '" & FrmAccess & "' WHERE User_ID='" & UserEdit & "'"
        ExecuteSQLQuery(sqlSTR)

        MessageBoxEx.Show("Record Successfully Updated...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Permission As String

        Me.Size = New Point(598, 311)

        sqlSTR = "SELECT User_Permission FROM tbl_Users WHERE User_ID='" & UserEdit & "'"
        ExecuteSQLQuery(sqlSTR)
        Permission = sqlDT.Rows(0)("User_Permission")

        For i As Integer = 0 To Len(Permission) - 1
            If i = 0 Then
                chk1.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 1 Then
                chk2.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 2 Then
                chk3.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 3 Then
                chk4.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 4 Then
                chk5.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 5 Then
                chk6.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 6 Then
                chk7.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 7 Then
                chk8.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 8 Then
                chk9.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 9 Then
                chk10.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 10 Then
                chk11.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 11 Then
                chk12.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 12 Then
                chk13.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 13 Then
                chk14.Checked = IIf(Permission.Chars(i) = "1", True, False)
            ElseIf i = 14 Then
                chk15.Checked = IIf(Permission.Chars(i) = "1", True, False)
            End If
        Next
    End Sub
End Class