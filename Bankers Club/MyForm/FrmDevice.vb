Imports GsmComm.GsmCommunication
Imports System.Globalization
Imports System.Management
Imports DevComponents.DotNetBar

Public Class FrmDevice
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If FillTextBox(TableLayoutPanel2, Highlighter1) = False Then
            Exit Sub
        End If

        comm = New GsmCommMain(Split(cmbType.Text, " - ")(0), 9600, 150)

        Cursor.Current = Cursors.Default

        Try
            Cursor.Current = Cursors.WaitCursor
            comm.Open()
            Cursor.Current = Cursors.Default
            MessageBoxEx.Show("Device Connected Sucessfully..", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'FrmMain.btnDevice.TitleText = "Disconnect Device"
            SMS_Status = True
            Me.Close()
        Catch generatedExceptionName As Exception
            Cursor.Current = Cursors.Default
            MessageBoxEx.Show("GSM Modem is not available.", "Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'comm.Close()
            SMS_Status = False

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(455, 244)

        Highlighter1.SetHighlightColor(cmbType, Validator.eHighlightColor.None)

        txtPort.Text = "0"
        txtName.Text = "No Device"
        cmbType.Items.Clear()

        Dim ports() As String
        ports = Split(ModemsConnected(), "***")

        For i As Integer = 0 To ports.Length - 2
            cmbType.Items.Add(ports(i))
        Next
    End Sub

    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")

            For Each queryObject As ManagementObject In searcher.Get()
                If queryObject("Status") = "OK" Then
                    modems = modems & (queryObject("AttachedTo") & " - " & queryObject("Description") & "***")
                End If
            Next
        Catch ex As Exception
            MessageBoxEx.Show("An error occured while querying for WMI data: ", "Error")
            Return ""
        End Try

        Return modems
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmbCOM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        txtPort.Text = Split(cmbType.Text, " - ")(0)
        txtName.Text = Split(cmbType.Text, " - ")(1)
    End Sub
End Class