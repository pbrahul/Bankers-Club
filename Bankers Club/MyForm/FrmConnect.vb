Imports DevComponents.DotNetBar

Public Class FrmConnect

    Private Sub rbnSQL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSQL.CheckedChanged
        txtServerName.Clear()
        txtPassword.Clear()
        txtUserName.Clear()

        txtServerName.Enabled = True
        txtUserName.Enabled = True
        txtPassword.Enabled = True

        Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
        Highlighter1.SetHighlightColor(txtUserName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
        Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.None)

        txtServerName.Focus()

    End Sub

    Private Sub rbnWindows_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbnWindows.CheckedChanged
        txtServerName.Clear()
        txtPassword.Clear()
        txtUserName.Clear()

        txtServerName.Enabled = True
        txtUserName.Enabled = False
        txtPassword.Enabled = False

        Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
        Highlighter1.SetHighlightColor(txtUserName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
        Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.None)

        txtServerName.Focus()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'If FillTextBox(TableLayoutPanel2, Highlighter1) = True Then
        '    Exit Sub
        'End If
        If rbnSQL.Checked = True Then
            If txtServerName.Text = "" Then
                Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
                txtServerName.Select()
                Exit Sub
            Else
                Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
            End If

            If txtUserName.Text = "" Then
                Highlighter1.SetHighlightColor(txtUserName, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
                txtUserName.Select()
                Exit Sub
            Else
                Highlighter1.SetHighlightColor(txtUserName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
            End If

            If txtPassword.Text = "" Then
                Highlighter1.SetHighlightColor(txtPassword, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
                txtPassword.Select()
                Exit Sub
            Else
                Highlighter1.SetHighlightColor(txtPassword, DevComponents.DotNetBar.Validator.eHighlightColor.None)
            End If

            ConfigFile(txtServerName.Text, txtUserName.Text, txtPassword.Text, IIf(rbnSQL.Checked, 1, 2), Application.StartupPath & "\Config.ini")

        ElseIf rbnWindows.Checked = True Then
            'If txtServerName.Text = "" Then
            '    Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.Red)
            '    txtServerName.Select()
            '    Exit Sub
            'Else
            '    Highlighter1.SetHighlightColor(txtServerName, DevComponents.DotNetBar.Validator.eHighlightColor.None)
            'End If

            ConfigFile("localhost", "root", "SignInIT", IIf(rbnSQL.Checked, 1, 2), Application.StartupPath & "\Config.ini")
        End If


        If checkServer() = True Then
            Me.Close()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub

    Private Sub FrmServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(476, 306)
        'ClearAll(TableLayoutPanel2, Highlighter1)

    End Sub
End Class