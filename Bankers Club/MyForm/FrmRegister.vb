Imports DevComponents.DotNetBar
Imports System.IO

Public Class FrmRegister
    Dim RegRead As String

    Private Sub btnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSignIn.Click
        Writevalue(txtRegkey.Text)
        If checkreg() = True Then
            MessageBoxEx.Show("Thanks for Registration ", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            FrmServer.Show()
            Me.Close()
        Else
            MessageBoxEx.Show("Invalid Registation Key! " & vbNewLine & "Please Contact to you Software Vendor.", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub FrmRegister_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RegFile(GetProcessorId.ToString.Substring(3), Application.StartupPath & "\Reg.ini")
        If checkpid() = False Then Writepid()
        txtPKey.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Registry\Key\", "PrimaryKey", "0")

        Dim fileLoc = Application.StartupPath & "\Reg.ini"
        If File.Exists(fileLoc) Then
            Using tr As TextReader = New StreamReader(fileLoc)
                RegRead = tr.ReadLine()
            End Using
        End If

        If RegRead <> txtPKey.Text Then
            MessageBoxEx.Show("Invalid Registation Key! " & vbNewLine & "Please Contact to you Software Vendor.", "Invalid Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If checkreg() = True Then
            FrmServer.Show()
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class