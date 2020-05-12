Imports DevComponents.DotNetBar
Imports System.IO

Public Class FrmCompanyInfo
    Dim UrlImage As String
    Dim xx As Image
    Public FlePath, FleExt, PicPath As String

    Private Sub FrmCompanyInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(518, 357)
        ClearAll(TableLayoutPanel1, Highlighter1)
        Try
            sqlSTR = "SELECT * FROM tbl_Company_Info"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtName.Text = sqlDT.Rows(0)("Company_Name")
                txtAddress.Text = sqlDT.Rows(0)("Company_Address")
                txtRegNo.Text = sqlDT.Rows(0)("Reg_No")
                txtContact.Text = sqlDT.Rows(0)("Contact_No")
                txtEmail.Text = sqlDT.Rows(0)("Email")
                txtWeb.Text = sqlDT.Rows(0)("Website")

                Using str As Stream = File.OpenRead(sqlDT.Rows(0)("Logo_Url"))
                    xx = Image.FromStream(str)
                End Using
                picLogo.Image = xx

                PicPath = sqlDT.Rows(0)("Logo_Url")
                FlePath = sqlDT.Rows(0)("Logo_Url")
            Else
                Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                    xx = Image.FromStream(str)
                End Using
                picLogo.Image = xx
                FlePath = Nothing
            End If
        Catch ex As Exception
            Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                xx = Image.FromStream(str)
            End Using
            picLogo.Image = xx
            FlePath = Nothing
        End Try
        txtName.Select()
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If sqlDT.Rows.Count > 0 Then

            If FlePath <> PicPath Then
                If FlePath <> Nothing Then
                    System.IO.File.Copy(FlePath, Application.StartupPath & "\Logo\Company_Logo" & FleExt, True)
                    FlePath = Replace(Application.StartupPath & "\Logo\Company_Logo" & FleExt, "\", "\\")
                Else
                    FlePath = Replace(Application.StartupPath & "\Nothing.png", "\", "\\")
                End If
            Else
                FlePath = Replace(PicPath, "\", "\\")
            End If

            sqlSTR = "UPDATE tbl_Company_Info SET Company_Name='" & txtName.Text & "', Company_Address='" & txtAddress.Text & _
                     "', Reg_No='" & txtRegNo.Text & "', Contact_No='" & txtContact.Text & "', Email='" & txtEmail.Text & _
                     "', Website='" & txtWeb.Text & "', Logo_Url='" & FlePath & "' WHERE Company_ID = '1001'"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("Records Successfully Update !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            If FlePath <> Nothing Then
                System.IO.File.Copy(FlePath, Application.StartupPath & "\Logo\Company_Logo" & FleExt, True)
                FlePath = Replace(Application.StartupPath & "\Logo\Company_Logo" & FleExt, "\", "\\")
            Else
                FlePath = Replace(Application.StartupPath & "\Nothing.png", "\", "\\")
            End If

            sqlSTR = "INSERT INTO tbl_Company_Info(Company_ID, Company_Name, Company_Address, Reg_No, Contact_No, Email, Website, Logo_Url) " & _
                     "VALUES ('1001', '" & txtName.Text & "', '" & txtAddress.Text & "', '" & txtRegNo.Text & "', '" & txtContact.Text & _
                     "', '" & txtEmail.Text & "', '" & txtWeb.Text & "', '" & FlePath & "')"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("Records Save Successfully !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ExecuteSQLQuery("SELECT * FROM tbl_Company_Info")
        PrmName.Value = sqlDT.Rows(0)("Company_Name")
        PrmAddress.Value = sqlDT.Rows(0)("Company_Address")
        PrmContact.Value = sqlDT.Rows(0)("Contact_No")
        PrmEmail.Value = sqlDT.Rows(0)("Email")
        PrmPicPath.Value = sqlDT.Rows(0)("Logo_Url")

        Me.Close()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png;"

            If fopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                FlePath = fopen.FileName
                FleExt = IO.Path.GetExtension(fopen.SafeFileName)
                Using str As Stream = File.OpenRead(fopen.FileName)
                    xx = Image.FromStream(str)
                End Using
                picLogo.Image = xx
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class