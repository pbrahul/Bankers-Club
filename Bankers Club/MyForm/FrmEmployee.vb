Imports DevComponents.DotNetBar
Imports ComponentFactory.Krypton.Toolkit
Imports DevComponents.DotNetBar.Validator
Imports System.IO

Public Class FrmEmployee
    Dim FlePath, FleExt, PicPath As String
    Dim xx As Image


    Public Function Byte2Image(ByVal byteArr() As Byte) As Drawing.Image
        Using ImageStream As New MemoryStream(byteArr)
            Dim newImage As Drawing.Image
            Try
                If byteArr.GetUpperBound(0) > 0 Then
                    newImage = System.Drawing.Image.FromStream(ImageStream)
                Else
                    newImage = Nothing
                End If
            Catch ex As Exception
                newImage = Nothing
            End Try
            Return newImage
        End Using
    End Function

    Private Sub FrmEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Employee"
    End Sub

    Private Sub FrmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(486, 431)
        dtpJoin.Value = Today.Date

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                xx = Image.FromStream(str)
            End Using
            logo.Image = xx
            FlePath = Nothing
            txtName.Select()

            chkActive.Checked = False
            txtRemarks.Enabled = False
            txtRemarks.Clear()

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM tbl_Employees WHERE Emp_ID='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            Try
                If sqlDT.Rows.Count > 0 Then
                    txtName.Text = sqlDT.Rows(0)("Emp_Name")
                    txtGuardian.Text = sqlDT.Rows(0)("Emp_Guardian")
                    txtAddress.Text = sqlDT.Rows(0)("Emp_Address")
                    txtAge.Text = sqlDT.Rows(0)("Emp_Age")
                    txtAge.Text = sqlDT.Rows(0)("Emp_Contact")
                    dtpJoin.Value = Format(sqlDT.Rows(0)("Join_Date"), "dd MMM yyyy")
                    txtIdentity.Text = sqlDT.Rows(0)("Emp_Identity")
                    chkActive.Checked = IIf(sqlDT.Rows(0)("Emp_Status") = "Inactive", True, False)
                    txtRemarks.Text = sqlDT.Rows(0)("Emp_Remarks")

                    logo.Image = Byte2Image(sqlDT.Rows(0)("Emp_Picture"))
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png;"

            If fopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                FlePath = fopen.FileName
                Using str As Stream = File.OpenRead(fopen.FileName)
                    xx = Image.FromStream(str)
                End Using
                logo.Image = xx
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
            xx = Image.FromStream(str)
        End Using
        logo.Image = xx

        If Split(Me.Text, " - ")(1) = "Add" Then
            FlePath = Nothing
        Else
            FlePath = Application.StartupPath & "\Nothing.png"
        End If
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If txtRemarks.Enabled = True And txtRemarks.Text = "" Then
            txtRemarks.Select()
            Highlighter1.SetHighlightColor(txtRemarks, Validator.eHighlightColor.Red)
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtRemarks, Validator.eHighlightColor.None)
        End If

        If txtContact.Text <> "0" Then
            If Len(txtContact.Text) < 11 Then
                MessageBoxEx.Show("Contact No Must Be At least 11 Characters", "Contact No", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Highlighter1.SetHighlightColor(txtContact, eHighlightColor.Red)
                txtContact.Select()
                Exit Sub
            End If
        End If


        If Split(Me.Text, " - ")(1) = "Add" Then
            GetID = ManualID("tbl_Employees", "Emp_ID", "E")

            If FlePath <> Nothing Then
                FlePath = Replace(FlePath, "\", "/")
            Else
                FlePath = Replace(Application.StartupPath & "\Nothing.png", "\", "/")
            End If

            sqlSTR = "INSERT INTO tbl_Employees(Emp_ID, Emp_Name, Emp_Guardian, Emp_Address, Emp_Contact, Emp_Age, Emp_Picture, Join_Date, Emp_Identity, Emp_Status, Emp_Remarks, User_ID) VALUES('" & GetID & "', '" & txtName.Text & "', '" & txtGuardian.Text & _
                     "', '" & txtAddress.Text & "', '" & txtContact.Text & "', '" & txtAge.Text & "', LOAD_FILE('" & FlePath & "'), '" & Format(dtpJoin.Value, "yyyy/MM/dd") & "', '" & txtIdentity.Text & "', '" & IIf(chkActive.Checked = False, "Active", "Inactive") & _
                     "', '" & txtRemarks.Text & "', '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            MessageBoxEx.Show("Record Save Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            If FlePath <> Nothing Then
                FlePath = Replace(FlePath, "\", "/")
                sqlSTR = "UPDATE tbl_Employees SET Emp_Name='" & txtName.Text & "', Emp_Guardian='" & txtGuardian.Text & "', Emp_Address='" & txtAddress.Text & "', Emp_Contact='" & txtContact.Text & _
                         "', Emp_Age='" & txtAge.Text & "', Emp_Picture=LOAD_FILE('" & FlePath & "'), Join_Date='" & Format(dtpJoin.Value, "yyyy/MM/dd") & "', Emp_Identity='" & txtIdentity.Text & _
                         "', Emp_Status='" & IIf(chkActive.Checked = False, "Active", "Inactive") & "', Emp_Remarks='" & txtRemarks.Text & "', User_ID='" & UserID & "' WHERE Emp_ID='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)
            Else
                sqlSTR = "UPDATE tbl_Employees SET Emp_Name='" & txtName.Text & "', Emp_Guardian='" & txtGuardian.Text & "', Emp_Address='" & txtAddress.Text & "', Emp_Contact='" & txtContact.Text & _
                         "', Emp_Age='" & txtAge.Text & "', Join_Date='" & Format(dtpJoin.Value, "yyyy/MM/dd") & "', Emp_Identity='" & txtIdentity.Text & _
                         "', Emp_Status='" & IIf(chkActive.Checked = False, "Active", "Inactive") & "', Emp_Remarks='" & txtRemarks.Text & "', User_ID='" & UserID & "' WHERE Emp_ID='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)

            End If

            MessageBoxEx.Show("Record Successfully Updated....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        FrmEmployeeList.RefreshEmployee()
        Me.Close()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "+", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtAge_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAge.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        If chkActive.Checked = True Then
            txtRemarks.Enabled = True
            txtRemarks.Select()
        Else
            txtRemarks.Enabled = False
        End If
    End Sub
End Class