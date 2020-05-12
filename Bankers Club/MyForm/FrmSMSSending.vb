Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls
Imports GsmComm.PduConverter

Public Class FrmSMSSending

    Dim pdu As SmsSubmitPdu
    Dim dcs As Byte = CByte(DataCodingScheme.GeneralCoding.Alpha7BitDefault)


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Attendance()
    End Sub

    Private Sub Attendance()
        Dim cb As DataGridViewCheckBoxXColumn = TryCast(dgvFee.Columns("colParentSMS"), DataGridViewCheckBoxXColumn)
        Dim Employee_SMS As DataGridViewCheckBoxXColumn = TryCast(dgvNotification.Columns("colNotify"), DataGridViewCheckBoxXColumn)
        Dim SMS_Status As DataGridViewCheckBoxXColumn = TryCast(dgvMember.Columns("colSMS"), DataGridViewCheckBoxXColumn)
        ' Hook onto the BeforeCellPaint event so we can
        ' demonstrate cell customization

        If cb IsNot Nothing Then
            AddHandler cb.BeforeCellPaint, AddressOf Attendance_Status
        End If

        If Employee_SMS IsNot Nothing Then
            AddHandler Employee_SMS.BeforeCellPaint, AddressOf Attendance_Status
        End If

        If SMS_Status IsNot Nothing Then
            AddHandler SMS_Status.BeforeCellPaint, AddressOf Attendance_Status
        End If

    End Sub

    Private Sub Attendance_Status(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
        Dim sc As DataGridViewCheckBoxXColumn = TryCast(sender, DataGridViewCheckBoxXColumn)

        If sc IsNot Nothing Then
            Select Case sc.CheckState
                Case CheckState.Checked
                    sc.Text = "Send"
                    sc.TextColor = Color.Green
                    Exit Select

                Case CheckState.Unchecked
                    sc.Text = "Not Send"
                    sc.TextColor = Color.Red
                    Exit Select
                Case Else
                    sc.Text = "----"
                    sc.TextColor = Color.DarkGray
                    Exit Select
            End Select
        End If
    End Sub

    Public Sub RefreshEmployee()
        If tabMain.SelectedTabIndex = 0 Then
            sqlSTR = "SELECT Mem_ID, Mem_Name, Bank_Name, Bank_Designation, Mem_Contact, Mem_Email, IF(Mem_Contact<>0, 'True', 'False') AS SMS_Status FROM tbl_Member ORDER BY LPAD(LOWER(Mem_ID), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvMember)

        ElseIf tabMain.SelectedTabIndex = 1 Then
            sqlSTR = "SELECT C.Col_ID, M.Mem_ID, M.Mem_Name, M.Bank_Name,  DATE_FORMAT(C.Col_Date, '%d-%b-%Y') AS Col_Date, M.Mem_Contact, FORMAT(C.Col_Amt,2) AS Debit_Amt, IF(SMS_Status='No', 'False', 'True') AS SMS_Status FROM tbl_Collections AS C " & _
                     "INNER JOIN tbl_Member AS M ON C.Mem_ID=M.Mem_ID INNER JOIN tbl_collection_type AS T ON T.Type_ID=C.Type_ID WHERE T.Type_Details='" & cmbType.SelectedItem & "'"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvFee)

        ElseIf tabMain.SelectedTabIndex = 2 Then
            sqlSTR = "SELECT C.Col_ID, M.Mem_ID, M.Mem_Name, M.Bank_Name,  M.Mem_Contact, M.Mem_Email, IF(Mem_Contact<>0, 'True', 'False') AS SMS_Status FROM tbl_Collections AS C " & _
                     "INNER JOIN tbl_Member AS M ON C.Mem_ID=M.Mem_ID INNER JOIN tbl_collection_type AS T ON T.Type_ID=C.Type_ID WHERE T.Type_Details='" & cmbNotification.SelectedItem & "'"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvNotification)
        End If

    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        panProducts.Width = FrmMain.Width - 180
        panProducts.Height = FrmMain.Height - 180
        panProducts.Location = New Point(100, 30)

        panStudent.Width = panProducts.Width - 240

        dgvMember.Width = panProducts.Width - 240
        dgvMember.Height = panProducts.Height - 110

        'dtpSMS.Left = panProducts.Width - 443
        'lblSMS.Left = dtpSMS.Left - 50

        btnSend.Left = panProducts.Width - 330

        '========== Parents ===========
        panMachine.Width = panProducts.Width - 240

        dgvFee.Width = panProducts.Width - 240
        dgvFee.Height = panProducts.Height - 105

        btnParentSMS.Left = panProducts.Width - 330

        '========= Notification ========
        panAttendance.Width = panProducts.Width - 236

        dgvNotification.Width = panProducts.Width - 240
        dgvNotification.Height = panProducts.Height - 105

        btnEmployeeSMS.Left = panProducts.Width - 330


    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SingleComboBox("SELECT C_Name FROM tbl_class ORDER BY C_ID ASC", cmbClass)
        SingleComboBox("SELECT Type_Details FROM tbl_Collection_Type WHERE Type_ID<>1 ORDER BY Type_ID ASC", cmbType)
        SingleComboBox("SELECT Type_Details FROM tbl_Collection_Type WHERE Type_ID<>1 AND Type_ID<>2 AND Type_ID<>3 ORDER BY Type_ID ASC", cmbNotification)
        'RefreshEmployee()
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT Mem_ID, Mem_Name, Bank_Name, Bank_Designation, Mem_Contact, Mem_Email, IF(Mem_Contact<>0, 'True', 'False') AS SMS_Status FROM tbl_Member AS M WHERE RIGHT(M.Mem_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(M.Mem_Name, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(SUBSTRING_INDEX(M.Mem_Name, ' ', 1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR " & _
                 "LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 2), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 3), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 4), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & _
                 "' OR LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 5), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR Bank_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(M.Mem_Contact, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' ORDER BY LPAD(LOWER(M.Mem_Name), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvMember)

        If sqlDT.Rows.Count = 0 Then
            dgvMember.Rows.Clear()
            txtSearch.Select()

            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub



    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
         ContactCount = 0
        For Each drv As DataGridViewRow In dgvMember.Rows
            If drv.Cells(6).Value = "True" Then
                ContactCount += 1
            End If
        Next

        If ContactCount > 0 Then
            If SMS_Status = False Then
                MessageBoxEx.Show("Device is not connected. Please connect a device.", "Device", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                With FrmSMS
                    .Text = "Member SMS"
                    .ShowDialog()
                End With
            End If
        Else
            MessageBoxEx.Show("No contact selected for send SMS..", "Sending SMS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tabMain_SelectedTabChanged(sender As Object, e As SuperTabStripSelectedTabChangedEventArgs) Handles tabMain.SelectedTabChanged
        RefreshEmployee()
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs)
        RefreshEmployee()
    End Sub

    Private Sub dtpSMS_ValueChanged(sender As Object, e As EventArgs)
        RefreshEmployee()
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        RefreshEmployee()
    End Sub

    Private Sub cmbNotification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNotification.SelectedIndexChanged
        RefreshEmployee()
    End Sub


    Private Sub btnParentSMS_Click(sender As Object, e As EventArgs) Handles btnParentSMS.Click
        ContactCount = 0
        For Each drv As DataGridViewRow In dgvFee.Rows
            If drv.Cells(7).Value = "False" Then
                ContactCount += 1
            End If
        Next

        If ContactCount > 0 Then
            If SMS_Status = False Then
                MessageBoxEx.Show("Device is not connected. Please connect a device.", "Device", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                With FrmSMS
                    .Text = "Fee Collection"
                    .ShowDialog()
                End With
            End If
        Else
            MessageBoxEx.Show("No contact selected for send SMS..", "Sending SMS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnEmployeeSMS_Click(sender As Object, e As EventArgs) Handles btnEmployeeSMS.Click
        ContactCount = 0
        For Each drv As DataGridViewRow In dgvNotification.Rows
            If drv.Cells(6).Value = "True" Then
                ContactCount += 1
            End If
        Next

        If ContactCount > 0 Then
            If SMS_Status = False Then
                MessageBoxEx.Show("Device is not connected. Please connect a device.", "Device", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                With FrmSMS
                    .Text = "Notification"
                    .ShowDialog()
                End With
            End If
        Else
            MessageBoxEx.Show("No contact selected for send SMS..", "Sending SMS", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class