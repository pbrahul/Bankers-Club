Imports GsmComm.GsmCommunication
Imports System.Globalization
Imports System.Management
Imports DevComponents.DotNetBar
Imports GsmComm.PduConverter

Public Class FrmSMS
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(447, 315)

        cmbType.SelectedIndex = 0
        txtSMS.Text = ""
        lblChar.Text = "Total Writing Characters : 1/0"
        txtSend.Text = "1 Out of " & ContactCount

        txtSMS.Select()
    End Sub

    Private Sub txtSMS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSMS.TextChanged
        Dim smsCount As Integer

        If cmbType.Text = "English" Then
            If txtSMS.Text.Length <= 159 Then
                smsCount = 1
            ElseIf txtSMS.Text.Length <= 319 Then
                smsCount = 2
            ElseIf txtSMS.Text.Length <= 479 Then
                smsCount = 3
            ElseIf txtSMS.Text.Length <= 639 Then
                smsCount = 4
            ElseIf txtSMS.Text.Length <= 799 Then
                smsCount = 5
            End If
        Else
            If txtSMS.Text.Length <= 69 Then
                smsCount = 1
            ElseIf txtSMS.Text.Length <= 139 Then
                smsCount = 2
            ElseIf txtSMS.Text.Length <= 219 Then
                smsCount = 3
            ElseIf txtSMS.Text.Length <= 279 Then
                smsCount = 4
            ElseIf txtSMS.Text.Length <= 349 Then
                smsCount = 5
            ElseIf txtSMS.Text.Length <= 419 Then
                smsCount = 6
            End If
        End If

        'lblChar.Text = "Total Writing Characters : " & txtSMS.Text.Length

        lblChar.Text = "Total Writing Characters : " & smsCount & "/" & txtSMS.Text.Length
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Me.Close()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim SendSMS As String
        Dim i As Integer = 0
        Dim pdu As SmsSubmitPdu
        Dim CellNo As String

        If txtSMS.Text = "" Then
            Highlighter1.SetHighlightColor(txtSMS, Validator.eHighlightColor.Red)
            txtSMS.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtSMS, Validator.eHighlightColor.None)
        End If

        Dim SMS As String = txtSMS.Text

        If Me.Text = "Member SMS" Then
            With FrmSMSSending
                For Each dgv As DataGridViewRow In .dgvMember.Rows
                    If dgv.Cells(4).Value <> 0 And dgv.Cells(6).Value = "True" Then
                        CellNo = "+88" & dgv.Cells(4).Value
                        Try
                            If cmbType.Text = "English" Then
                                Dim dcs As Byte = CByte(DataCodingScheme.GeneralCoding.Alpha7BitDefault)

                                For j As Integer = 0 To SMS.Length - 1 Step 159
                                    If (SMS.Length) > (j + 159) Then
                                        SendSMS = SMS.Substring(j, 159)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    Else
                                        SendSMS = SMS.Substring(j, SMS.Length - j)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    End If
                                Next
                            Else
                                Dim dcs As Byte = CByte(DataCodingScheme.NoClass_16Bit)

                                For j As Integer = 0 To SMS.Length - 1 Step 69
                                    If (SMS.Length) > (j + 69) Then
                                        SendSMS = SMS.Substring(j, 69)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    Else
                                        SendSMS = SMS.Substring(j, SMS.Length - j)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    End If
                                Next
                            End If


                            sqlSTR = "INSERT INTO tbl_sendsms(SMS_Type, SMS_Details, Send_Date, Send_Time, Mem_ID) Values ('Notification', '" & SMS & "', '" & Format(Now.Date, "yyyy/MM/dd") & _
                                       "', '" & Format(TimeOfDay, "hh:mm:ss tt") & "', '" & dgv.Cells(0).Value & "')"
                            ExecuteSQLQuery(sqlSTR)

                        Catch ex As Exception
                            MessageBoxEx.Show("Message not send. Please try again later.", "Send", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        i += 1
                        txtSend.Text = "Sending SMS " & i & " Out of " & ContactCount
                    End If
                Next
            End With

        ElseIf Me.Text = "Fee Collection" Then
            With FrmSMSSending
                For Each dgv As DataGridViewRow In .dgvFee.Rows
                    If dgv.Cells(5).Value <> 0 And dgv.Cells(7).Value = "False" Then
                        CellNo = "+88" & dgv.Cells(5).Value
                        Try
                            If cmbType.Text = "English" Then
                                Dim dcs As Byte = CByte(DataCodingScheme.GeneralCoding.Alpha7BitDefault)

                                For j As Integer = 0 To SMS.Length - 1 Step 159
                                    If (SMS.Length) > (j + 159) Then
                                        SendSMS = SMS.Substring(j, 159)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    Else
                                        SendSMS = SMS.Substring(j, SMS.Length - j)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    End If
                                Next
                            Else
                                Dim dcs As Byte = CByte(DataCodingScheme.NoClass_16Bit)

                                For j As Integer = 0 To SMS.Length - 1 Step 69
                                    If (SMS.Length) > (j + 69) Then
                                        SendSMS = SMS.Substring(j, 69)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    Else
                                        SendSMS = SMS.Substring(j, SMS.Length - j)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    End If
                                Next
                            End If


                            sqlSTR = "INSERT INTO tbl_sendsms(SMS_Type, SMS_Details, Send_Date, Send_Time, Mem_ID) Values ('Collection', '" & SMS & "', '" & Format(Now.Date, "yyyy/MM/dd") & _
                                       "', '" & Format(TimeOfDay, "hh:mm:ss tt") & "', '" & dgv.Cells(1).Value & "')"
                            ExecuteSQLQuery(sqlSTR)

                        Catch ex As Exception
                            MessageBoxEx.Show("Message not send. Please try again later.", "Send", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        i += 1
                        txtSend.Text = "Sending SMS " & i & " Out of " & ContactCount
                    End If
                Next
            End With


        ElseIf Me.Text = "Notification" Then
            With FrmSMSSending
                For Each dgv As DataGridViewRow In .dgvNotification.Rows
                    If dgv.Cells(4).Value <> 0 And dgv.Cells(6).Value = "True" Then
                        CellNo = "+88" & dgv.Cells(4).Value
                        Try
                            If cmbType.Text = "English" Then
                                Dim dcs As Byte = CByte(DataCodingScheme.GeneralCoding.Alpha7BitDefault)

                                For j As Integer = 0 To SMS.Length - 1 Step 159
                                    If (SMS.Length) > (j + 159) Then
                                        SendSMS = SMS.Substring(j, 159)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    Else
                                        SendSMS = SMS.Substring(j, SMS.Length - j)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    End If
                                Next
                            Else
                                Dim dcs As Byte = CByte(DataCodingScheme.NoClass_16Bit)

                                For j As Integer = 0 To SMS.Length - 1 Step 69
                                    If (SMS.Length) > (j + 69) Then
                                        SendSMS = SMS.Substring(j, 69)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    Else
                                        SendSMS = SMS.Substring(j, SMS.Length - j)
                                        pdu = New SmsSubmitPdu(SendSMS, CellNo, dcs)
                                        comm.SendMessage(pdu)
                                    End If
                                Next
                            End If


                            sqlSTR = "INSERT INTO tbl_sendsms(SMS_Type, SMS_Details, Send_Date, Send_Time, Mem_ID) Values ('Training Notification', '" & SMS & "', '" & Format(Now.Date, "yyyy/MM/dd") & _
                                       "', '" & Format(TimeOfDay, "hh:mm:ss tt") & "', '" & dgv.Cells(1).Value & "')"
                            ExecuteSQLQuery(sqlSTR)

                        Catch ex As Exception
                            MessageBoxEx.Show("Message not send. Please try again later.", "Send", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End Try
                        i += 1
                        txtSend.Text = "Sending SMS " & i & " Out of " & ContactCount
                    End If
                Next
            End With
        End If
    End Sub
End Class