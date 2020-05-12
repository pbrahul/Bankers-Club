Imports DevComponents.DotNetBar
Imports System.Drawing.Printing
Imports System.IO
Imports DevComponents.DotNetBar.Validator
Imports MySql.Data.MySqlClient
Imports DevComponents.DotNetBar.Controls

Public Class FrmMemberDetails
    Dim VisitDate As Date
    Dim PrinterSettings1 As New Printing.PrinterSettings
    Dim PageSettings1 As New Printing.PageSettings

    Dim xx As Image
    Dim C_ID As Integer
    Dim C_Code As String
    Dim DuplicateName As Boolean

    Dim ms As System.IO.MemoryStream
    Dim photo_aray() As Byte
    Dim conn As New MySqlConnection(CnString)
    Dim mb As MySqlBackup
    Dim cmd As New MySqlCommand

    Dim scAccounts As New AutoCompleteStringCollection


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim cb As DataGridViewCheckBoxXColumn = TryCast(dgvMemberList.Columns("colSMS"), DataGridViewCheckBoxXColumn)

        If cb IsNot Nothing Then
            AddHandler cb.BeforeCellPaint, AddressOf sStatus
        End If
    End Sub

    Public Sub Bank_Name()
        scAccounts.Clear()

        sqlSTR = "SELECT DISTINCT Bank_Name FROM tbl_member ORDER BY Bank_Name ASC"
        ExecuteSQLQuery(sqlSTR)
        For i As Integer = 0 To sqlDT.Rows.Count - 1
            scAccounts.Add(sqlDT.Rows(i)("Bank_Name"))
        Next
    End Sub


    Private Sub sStatus(ByVal sender As Object, ByVal e As BeforeCellPaintEventArgs)
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

    Private Sub conv_photo(ByVal pic As Image)
        Using ms As MemoryStream = New MemoryStream()
            Dim bm As Bitmap = New Bitmap(pic)
            bm.Save(ms, pic.RawFormat)

            Dim arrPic() As Byte = ms.GetBuffer()
            cmd.Parameters.AddWithValue("@Picture", arrPic)
        End Using
    End Sub


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

    Public Sub RefreshMember()
        If tabMain.SelectedTabIndex = 0 Then
            sqlSTR = "SELECT '', Mem_ID, Mem_Name, Bank_Name, Bank_Designation, Mem_Contact, Mem_Email FROM tbl_Member ORDER BY LPAD(LOWER(Mem_ID), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvMemberList)

            txtSearch.Clear()
            txtSearch.Select()

        ElseIf tabMain.SelectedTabIndex = 1 Then
            ClearAll(panAddDetails, Highlighter1)
            ClearAll(panAddVisitDetails, Highlighter1)

            Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                xx = Image.FromStream(str)
            End Using

            picImage.Image = xx
            txtName.Select()

        ElseIf tabMain.SelectedTabIndex = 2 Then
            Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                xx = Image.FromStream(str)
            End Using

            picEditImage.Image = xx

            ClearAll(panEditMemberDetails, Highlighter1)
            ClearAll(panEditBankDetails, Highlighter1)
            EditID = Nothing
            txtSearchEx.Select()
        End If
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panProducts.Width = FrmMain.Width - 180
        panProducts.Height = FrmMain.Height - 180
        panProducts.Location = New Point(100, 30)

        dgvMemberList.Width = panProducts.Width - 240
        dgvMemberList.Height = panProducts.Height - 100

        panExistTitle.Width = panProducts.Width - 240
        panPatient.Width = panProducts.Width - 240

        panAddDetails.Height = panProducts.Height - 130
        panAddVisitDetails.Height = panProducts.Height - 130
        panAddVisitDetails.Width = panProducts.Width - 800

        panImage.Left = panAddDetails.Width + 50
        panButton.Left = panAddDetails.Width + 45
        panImage.Top = panAddDetails.Height / 2 - panImage.Height / 2 + 10
        panAddVisitDetails.Left = panImage.Right + 10

        panAddVisitDetails.Top = 80
        panAddDetails.Top = 80
        panButton.Top = PanelEx1.Bottom - 110

        lblVisitDetails.Left = panAddVisitDetails.Width / 2 - lblVisitDetails.Width / 2
        lblVisit.Left = panAddDetails.Width / 2 - lblVisit.Width / 2

        '============Edit============
        panToken.Width = panProducts.Width - 240

        panEditMemberDetails.Height = panProducts.Height - 130
        panEditBankDetails.Height = panProducts.Height - 130
        panEditBankDetails.Width = panProducts.Width - 800

        panEditImage.Left = panEditMemberDetails.Width + 50
        panEditButton.Left = panEditMemberDetails.Width + 45
        panEditImage.Top = panEditMemberDetails.Height / 2 - panImage.Height / 2 + 10
        panEditBankDetails.Left = panEditImage.Right + 10

        panEditBankDetails.Top = 85
        panEditMemberDetails.Top = 85
        panEditButton.Top = PanelEx3.Bottom - 110

        lblMemberDetails.Left = panEditMemberDetails.Width / 2 - lblMemberDetails.Width / 2
        lblProfession.Left = panEditBankDetails.Width / 2 - lblProfession.Width / 2

    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Select()

        RefreshMember()

        Bank_Name()

        With txtBank
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scAccounts
        End With

        With txtEditBank
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scAccounts
        End With

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT '', Mem_ID, Mem_Name, Bank_Name, Bank_Designation, Mem_Contact, Mem_Email FROM tbl_Member AS M WHERE RIGHT(M.Mem_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(M.Mem_Name, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(SUBSTRING_INDEX(M.Mem_Name, ' ', 1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR " & _
                 "LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 2), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 3), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 4), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & _
                 "' OR LEFT(SUBSTRING_INDEX(SUBSTRING_INDEX(M.Mem_Name, ' ', 5), ' ', -1), " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR RIGHT(M.Mem_Contact, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR M.Bank_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR LEFT(M.Mem_Contact, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' OR RIGHT(M.Mem_Contact, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' ORDER BY LPAD(LOWER(M.Mem_Name), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvMemberList)

        If sqlDT.Rows.Count = 0 Then
            dgvMemberList.Rows.Clear()
            txtSearch.Select()

            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png;"

            If fopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                Using str As Stream = File.OpenRead(fopen.FileName)
                    xx = Image.FromStream(str)
                End Using
                picImage.Image = xx
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
            xx = Image.FromStream(str)
        End Using
        picImage.Image = xx

    End Sub


    Private Sub tabMain_TabStripMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabMain.TabStripMouseClick
        RefreshMember()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            Highlighter1.SetHighlightColor(txtName, eHighlightColor.Red)
            txtName.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtName, eHighlightColor.None)
        End If

        If txtFather.Text = "" Then
            Highlighter1.SetHighlightColor(txtFather, eHighlightColor.Red)
            txtFather.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtFather, eHighlightColor.None)
        End If

        If txtMother.Text = "" Then
            Highlighter1.SetHighlightColor(txtMother, eHighlightColor.Red)
            txtMother.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtMother, eHighlightColor.None)
        End If

        If txtAddress1.Text = "" Then
            Highlighter1.SetHighlightColor(txtAddress1, eHighlightColor.Red)
            txtAddress1.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtAddress1, eHighlightColor.None)
        End If

        If txtBank.Text = "" Then
            Highlighter1.SetHighlightColor(txtBank, eHighlightColor.Red)
            txtBank.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtBank, eHighlightColor.None)
        End If

        If txtBranch.Text = "" Then
            Highlighter1.SetHighlightColor(txtBranch, eHighlightColor.Red)
            txtBranch.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtBranch, eHighlightColor.None)
        End If

        If txtDesignation.Text = "" Then
            Highlighter1.SetHighlightColor(txtDesignation, eHighlightColor.Red)
            txtDesignation.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtDesignation, eHighlightColor.None)
        End If


        If txtContact.Text = "" Then
            Highlighter1.SetHighlightColor(txtContact, eHighlightColor.Red)
            txtContact.Select()
            Exit Sub
        Else
            If Len(txtContact.Text) < 11 Then
                Highlighter1.SetHighlightColor(txtContact, eHighlightColor.Red)
                txtContact.Select()
                Exit Sub
            End If

        End If

        'If DuplicateName = False Then
        If cmbMemtype.SelectedIndex = 0 Then
            GetID = ManualID("tbl_member", "Mem_ID", "LM")
        Else
            GetID = ManualID("tbl_member", "Mem_ID", "G")
        End If

        cmd.Connection = conn
        conn.Open()

        cmd = New MySqlCommand("INSERT INTO tbl_member(Mem_ID, Mem_Name, Mem_Father, Mem_Mother, Mem_Spouse, Pre_Address, Per_Address, DOB, Mem_Sex, Mem_Contact, Mem_Email, Near_Contact, Nat_ID, Passport, Marriage_Day, Mem_Picture, Mem_Type, Entry_Date, Bank_Name, Branch, Bank_Designation, Join_Date, Mem_Status, User_ID) VALUES('" & GetID & "', '" & txtName.Text &
                 "', '" & txtFather.Text & "', '" & txtMother.Text & "', '" & txtSpouse.Text & "', '" & txtAddress1.Text & "', '" & txtAddress2.Text & "', '" & Format(dtpDOB.Value, "yyyy/MM/dd") & _
                 "', '" & cmbGender.Text & "','" & txtContact.Text & "', '" & txtEmail.Text & "', '" & txtContact2.Text & "', '" & txtNID.Text & "', '" & txtPassport.Text & _
                 "', '" & Format(dtpMarriage.Value, "yyyy/MM/dd") & "', @Picture, '" & cmbMemtype.Text & "', '" & Format(Now, "yyyy/MM/dd") & "', '" & txtBank.Text & "', '" & txtBranch.Text & "', '" & txtDesignation.Text & "', '" & Format(dtpJoin.Value, "yyyy/MM/dd") & "', '" & cmbStatus.SelectedItem & "', '" & UserID & "')", conn)

        conv_photo(picImage.Image)

        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBoxEx.Show("Record Save Successfully....", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
        Bank_Name()

        ClearAll(panAddDetails, Highlighter1)
        ClearAll(panAddVisitDetails, Highlighter1)
        txtName.Select()

    End Sub

    Private Sub dgvMemberList_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvMemberList.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim rptReports As New FrmReports

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 0 Then
            RptStr = "SELECT M.* FROM tbl_Member AS M WHERE M.Mem_ID='" & dgvMemberList.SelectedRows(0).Cells(1).Value & "'"
            globalFRM = "MemberDetails"

            rptReports.Show()
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearAll(panAddDetails, Highlighter1)
        txtName.Select()

    End Sub


    Public Sub EditShow()
        If sqlDT.Rows.Count > 0 Then
            EditID = sqlDT.Rows(0)("Mem_ID")
            txtEditName.Text = sqlDT.Rows(0)("Mem_Name")
            txtEditFather.Text = sqlDT.Rows(0)("Mem_Father")
            txtEditMother.Text = sqlDT.Rows(0)("Mem_Mother")
            txtEditAddress1.Text = sqlDT.Rows(0)("Pre_Address")
            txtEditAddress2.Text = sqlDT.Rows(0)("Per_Address")
            dtpEditDOB.Value = Format(sqlDT.Rows(0)("DOB"), "dd MMM yyyy")
            cmbEditSex.SelectedItem = sqlDT.Rows(0)("Mem_Sex")
            cmbEditType.SelectedItem = sqlDT.Rows(0)("Mem_Sex")
            dtpEditMarriage.Value = Format(sqlDT.Rows(0)("Marriage_Day"), "dd MMM yyyy")
            txtEditSpouse.Text = sqlDT.Rows(0)("Mem_Spouse")
            txtEditBank.Text = sqlDT.Rows(0)("Bank_Name")
            txtEditBranch.Text = sqlDT.Rows(0)("Branch")
            txtEditDesignation.Text = sqlDT.Rows(0)("Bank_Designation")
            dtpEditJoin.Value = Format(sqlDT.Rows(0)("Join_Date"), "dd MMM yyyy")
            txtEditContact.Text = sqlDT.Rows(0)("Mem_Contact")
            txtEditSecond.Text = sqlDT.Rows(0)("Near_Contact")
            txtEditNID.Text = sqlDT.Rows(0)("Nat_ID")
            txtEditPassport.Text = sqlDT.Rows(0)("Passport")
            txtEditEmail.Text = sqlDT.Rows(0)("Mem_Email")
            cmbEditStatus.SelectedItem = sqlDT.Rows(0)("Mem_Status")

            If Not IsDBNull(sqlDT.Rows(0)("Mem_Picture")) Then
                picEditImage.Image = Byte2Image(sqlDT.Rows(0)("Mem_Picture"))
            Else
                Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                    xx = Image.FromStream(str)
                End Using
                picEditImage.Image = xx
            End If

            txtSearchEx.Select()
        Else
            ClearAll(panEditMemberDetails, Highlighter1)
            ClearAll(panEditBankDetails, Highlighter1)

            Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
                xx = Image.FromStream(str)
            End Using
            picEditImage.Image = xx

            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub




    Private Sub btnSearchEx_Click(sender As Object, e As EventArgs) Handles btnSearchEx.Click
        'Try
        sqlSTR = "SELECT Mem_ID, Mem_Name, Mem_Father, Mem_Mother, Mem_Spouse, Pre_Address, Per_Address, DOB, Mem_Sex, Mem_Contact, Mem_Email, Near_Contact, Nat_ID, Passport, Marriage_Day, Mem_Picture, " & _
                 "Mem_Type, Entry_Date, Bank_Name, Branch, Bank_Designation, Join_Date, Mem_Status FROM tbl_Member WHERE RIGHT(Mem_ID," & Len(txtSearchEx.Text) & ") = '" & txtSearchEx.Text & "'"
        ExecuteSQLQuery(sqlSTR)

        EditShow()


        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txtSearchEx_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchEx.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchEx_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnEditCancel_Click(sender As Object, e As EventArgs) Handles btnEditCancel.Click
        ClearAll(panEditMemberDetails, Highlighter1)
        ClearAll(panEditBankDetails, Highlighter1)
        EditID = Nothing
        txtSearchEx.Select()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtEditName.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditName, eHighlightColor.Red)
            txtEditName.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditName, eHighlightColor.None)
        End If

        If txtEditFather.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditFather, eHighlightColor.Red)
            txtEditFather.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditFather, eHighlightColor.None)
        End If

        If txtEditMother.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditMother, eHighlightColor.Red)
            txtEditMother.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditMother, eHighlightColor.None)
        End If

        If txtEditAddress1.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditAddress1, eHighlightColor.Red)
            txtEditAddress1.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditAddress1, eHighlightColor.None)
        End If

        If txtEditBank.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditBank, eHighlightColor.Red)
            txtEditBank.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditBank, eHighlightColor.None)
        End If

        If txtEditBranch.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditBranch, eHighlightColor.Red)
            txtEditBranch.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditBranch, eHighlightColor.None)
        End If

        If txtEditDesignation.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditDesignation, eHighlightColor.Red)
            txtEditDesignation.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtEditDesignation, eHighlightColor.None)
        End If


        If txtEditContact.Text = "" Then
            Highlighter1.SetHighlightColor(txtEditContact, eHighlightColor.Red)
            txtEditContact.Select()
            Exit Sub
        Else
            If Len(txtEditContact.Text) < 11 Then
                Highlighter1.SetHighlightColor(txtEditContact, eHighlightColor.Red)
                txtEditContact.Select()
                Exit Sub
            End If

        End If

        'If DuplicateName = False Then
        If EditID <> Nothing Then
            Try

                cmd.Connection = conn
                conn.Open()

                cmd = New MySqlCommand("UPDATE tbl_member SET Mem_Name='" & txtEditName.Text & "', Mem_Father = '" & txtEditFather.Text & "', Mem_Mother = '" & txtEditMother.Text & "', Mem_Spouse='" & txtEditSpouse.Text & "', Pre_Address='" & txtEditAddress1.Text & "', Per_Address='" & txtEditAddress2.Text & "', DOB='" & Format(dtpEditDOB.Value, "yyyy/MM/dd") & _
                                       "', Mem_Sex='" & cmbEditSex.Text & "', Mem_Contact='" & txtEditContact.Text & "', Mem_Email='" & txtEditEmail.Text & "', Near_Contact='" & txtEditSecond.Text & "', Nat_ID='" & txtEditNID.Text & "', Passport='" & txtEditPassport.Text & "', Marriage_Day='" & Format(dtpEditMarriage.Value, "yyyy/MM/dd") & "', Mem_Picture=@Picture, Mem_Type='" & cmbEditType.Text & _
                                       "', Entry_Date='" & Format(Now, "yyyy/MM/dd") & "', Bank_Name='" & txtEditBank.Text & "', Branch='" & txtEditBranch.Text & "', Bank_Designation='" & txtEditDesignation.Text & "', Join_Date='" & Format(dtpEditJoin.Value, "yyyy/MM/dd") & "', Mem_Status='" & cmbEditStatus.SelectedItem & "', User_ID='" & UserID & "' WHERE Mem_ID='" & EditID & "'", conn)
                conv_photo(picEditImage.Image)

                cmd.ExecuteNonQuery()

                MessageBoxEx.Show("Record Update Successfully....", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Bank_Name()

                tabMain.SelectedTabIndex = 0
            Catch ex As Exception

            Finally
                conn.Close()

            End Try

        End If
        'End If
    End Sub

    Private Sub btnEditBrowse_Click(sender As Object, e As EventArgs) Handles btnEditBrowse.Click
        Try
            Dim fopen As New OpenFileDialog
            fopen.FileName = ""
            fopen.Filter = "Image Files (*.jpg, *.bmp, *.png)|*.jpg;*.bmp;*.png;"

            If fopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                Using str As Stream = File.OpenRead(fopen.FileName)
                    xx = Image.FromStream(str)
                End Using
                picEditImage.Image = xx
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnEditClear_Click(sender As Object, e As EventArgs) Handles btnEditClear.Click
        Using str As Stream = File.OpenRead(Application.StartupPath & "\Nothing.png")
            xx = Image.FromStream(str)
        End Using
        picEditImage.Image = xx

    End Sub


    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress, txtContact2.KeyPress, txtEditContact.KeyPress, txtEditSecond.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class