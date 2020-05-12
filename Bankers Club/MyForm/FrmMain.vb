Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.Metro.ColorTables
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient

Public Class FrmMain

    Public Sub LoadForm(ByVal ToBeLoadedForm As Form)
        Dim LoadedForm As New Form
        Dim IsLoaded As Boolean = False
        Try
            For Each LoadedForm In Me.MdiChildren
                If LoadedForm.Text = ToBeLoadedForm.Text Then
                    IsLoaded = True
                    Exit For
                End If
            Next
            SlidePanel1.SlideSide = eSlideSide.Right
            SlidePanel1.IsOpen = False

            If Not IsLoaded Then
                ToBeLoadedForm.MdiParent = Me
                ToBeLoadedForm.WindowState = FormWindowState.Maximized
                ToBeLoadedForm.Show()
                ButtonActivated(ActiveMdiChild)
            ElseIf IsLoaded Then
                LoadedForm.WindowState = FormWindowState.Maximized
                LoadedForm.Focus()
                ButtonActivated(ActiveMdiChild)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ToBeLoadedForm = Nothing
        LoadedForm = Nothing
    End Sub


    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim aDate As Date
        Dim dCount As Integer
        Dim dAmt As Double

        checkServer()
        lblPrint.ForeColor = Color.WhiteSmoke

        sqlSTR = "SELECT Location_Code FROM tbl_Location"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            PreFix = sqlDT.Rows(0)("Location_Code")
        End If

        btnPannel.Visible = False

        lblTitle.ForeColor = Color.White
        lblTime.ForeColor = Color.White
        lblDate.ForeColor = Color.White
        lblSign.ForeColor = Color.White

        PageSlider1.SelectedPage = PageSliderPage1

        Me.Location = New Point(0, 0)
        Me.Size = New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)


        ExecuteSQLQuery("SELECT * FROM tbl_Company_Info")
        If sqlDT.Rows.Count > 0 Then
            PrmName.Value = sqlDT.Rows(0)("Company_Name")
            PrmAddress.Value = sqlDT.Rows(0)("Company_Address")
            PrmContact.Value = sqlDT.Rows(0)("Contact_No")
            PrmEmail.Value = sqlDT.Rows(0)("Email")
            PrmPicPath.Value = sqlDT.Rows(0)("Logo_Url")
        End If


        '============ Depriciation =============
        sqlSTR = "SELECT A.Ac_ID, B.Dep_Value, (B.Amount*B.Dep_Rate/100) as Rate, (SELECT Ledger_Date FROM tbl_ac_ledger WHERE Ac_ID=A.Ac_ID ORDER BY Ledger_Date DESC LIMIT 1) AS Led_Date FROM tbl_accounts AS A INNER JOIN tbl_assets AS B ON A.Ac_ID=B.As_ID WHERE B.Dep_Value>0"
        GetSQLQuery(sqlSTR)

        'If SqlDT2.Rows.Count > 0 Then
        'End If
        For i As Integer = 0 To SqlDT2.Rows.Count - 1
            aDate = Format(SqlDT2.Rows(i)("Led_Date"), "MM/dd/yyyy")
            dCount = DateDiff(DateInterval.Day, aDate, Now.Date)

            aDate = aDate & " " & TimeOfDay

            dAmt = SqlDT2.Rows(i)("Dep_Value") - SqlDT2.Rows(i)("Rate")

            'If dCount > 0 Then
            For x As Integer = 1 To dCount
                If dAmt < 0 Then
                    sqlSTR = "INSERT INTO tbl_Ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Debit_Amt, Balance_Amt, User_ID) VALUES ('" & SqlDT2.Rows(i)("Ac_ID") & "', '" & Format(aDate.AddDays(x), "yyyy/MM/dd HH:mm:ss") & "', 'Depriciation', " & CDbl(SqlDT2.Rows(i)("Dep_Value")) & _
                             ", " & CDbl(SqlDT2.Rows(i)("Dep_Value")) & ", '" & UserID & "')"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt=" & CDbl(SqlDT2.Rows(i)("Dep_Value")) & " WHERE Ac_ID='" & SqlDT2.Rows(i)("Ac_ID") & "'"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE tbl_Assets SET Dep_Value=" & CDbl(SqlDT2.Rows(i)("Dep_Value")) & " WHERE Ac_ID='" & SqlDT2.Rows(i)("Ac_ID") & "'"
                    ExecuteSQLQuery(sqlSTR)

                    Exit For
                Else
                    dAmt = SqlDT2.Rows(i)("Dep_Value") - CDbl(SqlDT2.Rows(i)("Rate") * x)

                    sqlSTR = "INSERT INTO tbl_Ac_ledger (Ac_ID, Ledger_Date, Led_Particulars, Debit_Amt, Balance_Amt, User_ID) VALUES ('" & SqlDT2.Rows(i)("Ac_ID") & "', '" & Format(aDate.AddDays(x), "yyyy/MM/dd HH:mm:ss") & "', 'Depriciation', " & CDbl(SqlDT2.Rows(i)("Rate")) & _
                             ", " & CDbl(dAmt) & ", '" & UserID & "')"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt=" & CDbl(dAmt) & " WHERE Ac_ID='" & SqlDT2.Rows(i)("Ac_ID") & "'"
                    ExecuteSQLQuery(sqlSTR)

                    sqlSTR = "UPDATE tbl_Assets SET Dep_Value=" & CDbl(dAmt) & " WHERE As_ID='" & SqlDT2.Rows(i)("Ac_ID") & "'"
                    ExecuteSQLQuery(sqlSTR)
                End If
            Next
            'End If
        Next

        ButtonActivated(ActiveMdiChild)

    End Sub

    Private Sub Default2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Default2.Click
        StyleManager.MetroColorGeneratorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("F5F5F5"), ColorScheme.GetColor("4A8A2F"))
    End Sub

    Private Sub GrayOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrayOrange.Click
        StyleManager.MetroColorGeneratorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("E8E8DC"), ColorScheme.GetColor("4A8A2F"))
    End Sub

    Private Sub Rust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rust.Click
        'Rust.CommandParameter = MetroColorGeneratorParameters.Rust
        'Dim theme As MetroColorGeneratorParameters = CType(Rust.CommandParameter, MetroColorGeneratorParameters)
        'StyleManager.MetroColorGeneratorParameters = theme
        StyleManager.MetroColorGeneratorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("DEEBE4"), ColorScheme.GetColor("588C3F"))
    End Sub

    Private Sub SimplyBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimplyBlue.Click
        SimplyBlue.CommandParameter = MetroColorGeneratorParameters.SimplyBlue
        Dim theme As MetroColorGeneratorParameters = CType(SimplyBlue.CommandParameter, MetroColorGeneratorParameters)
        StyleManager.MetroColorGeneratorParameters = theme
    End Sub

    Private Sub SkyGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkyGreen.Click
        SkyGreen.CommandParameter = MetroColorGeneratorParameters.SkyGreen
        Dim theme As MetroColorGeneratorParameters = CType(SkyGreen.CommandParameter, MetroColorGeneratorParameters)
        StyleManager.MetroColorGeneratorParameters = theme
    End Sub

    Private Sub WashedBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WashedBlue.Click
        Dim theme As MetroColorGeneratorParameters = New MetroColorGeneratorParameters
        theme.CanvasColor = System.Drawing.Color.FromArgb((CType(((CType((188), Byte))), Integer)), (CType(((CType((199), Byte))), Integer)), (CType(((CType((216), Byte))), Integer)))
        theme.BaseColor = System.Drawing.Color.FromArgb((CType(((CType((75), Byte))), Integer)), (CType(((CType((122), Byte))), Integer)), (CType(((CType((203), Byte))), Integer)))
        'theme.CanvasColor = System.Drawing.Color.FromArgb((CType(((CType((255), Byte))), Integer)), (CType(((CType((247), Byte))), Integer)), (CType(((CType((221), Byte))), Integer)))
        'theme.BaseColor = System.Drawing.Color.FromArgb((CType(((CType((255), Byte))), Integer)), (CType(((CType((134), Byte))), Integer)), (CType(((CType((0), Byte))), Integer)))

        StyleManager.MetroColorGeneratorParameters = theme
    End Sub

    Private Sub FrmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SlidePanel1.Width = Me.Width

        PageSlider1.Left = (Me.Width / 2) - 395
        PageSlider1.Top = (Me.Height / 2) - 290
        panBtn.Left = (Me.Width / 2) - 240
        lblPrint.Left = (Me.Width / 2) - 140
        btnSignIn.Left = Me.Width - 250
        btnSignIn.Top = (Me.Height / 2) - 300

    End Sub


    Private Sub FrmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        ButtonActivated(ActiveMdiChild)
        'MsgBox(ActiveMdiChild.ToString)
    End Sub

    Private Sub buttonX6_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignIn.MouseHover
        btnSignIn.ShowSubItems = True
    End Sub

    Private Sub buttonX6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSignIn.MouseLeave
        btnSignIn.ShowSubItems = False
    End Sub

    Private Sub tmr_Print_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Print.Tick
        i_Print += 1
        If i_Print = 1 Then
            lblPrint.Text = "Please wait while printing records."
        ElseIf i_Print = 2 Then
            lblPrint.Text = "Please wait while printing records.."
        ElseIf i_Print = 3 Then
            lblPrint.Text = "Please wait while printing records..."
        ElseIf i_Print = 4 Then
            lblPrint.Text = "Please wait while printing records...."
        ElseIf i_Print = 5 Then
            lblPrint.Text = "Please wait while printing records....."
            i_Print = 0
        End If
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        xclose()
        ButtonActivated(ActiveMdiChild)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        NewFrm(ActiveMdiChild.Name)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        EditFrm(ActiveMdiChild.Name)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        DeleteFrm(ActiveMdiChild.Name)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshList(ActiveMdiChild.Name)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        FormPrint(ActiveMdiChild.Name)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        FormClose(ActiveMdiChild)
    End Sub

    Private Sub btnProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMember.Click
        If x_Permission(uPermission.Chars(0)) Then
            LoadForm(FrmMemberDetails)
        End If
    End Sub

    Private Sub btnSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If x_Permission(uPermission.Chars(1)) Then
            LoadForm(FrmSupplierList)
        End If
    End Sub

    Private Sub btnPurchase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        If x_Permission(uPermission.Chars(2)) Then
            'LoadForm(FrmPurchaseList)
            LoadForm(FrmAssetList)
        End If
    End Sub

    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMS.Click
        If x_Permission(uPermission.Chars(3)) Then
            LoadForm(FrmSMSSending)
        End If
    End Sub

  
    Private Sub btnCritical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCritical.Click
        If x_Access(UserType) Then
            FrmCompanyInfo.ShowDialog()
        End If
    End Sub

    Private Sub btnBarcode_Click(sender As Object, e As EventArgs) Handles btnCashBank.Click
        If x_Permission(uPermission.Chars(6)) Then
            LoadForm(FrmCashBank)
        End If
    End Sub

    Private Sub btnCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCollection.Click
        If x_Permission(uPermission.Chars(7)) Then
            LoadForm(FrmCollectionList)
        End If
    End Sub

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncome.Click
        If x_Permission(uPermission.Chars(8)) Then
            'LoadForm(FrmSales)
            With FrmPrint
                .Text = "Income Statement"
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub btnSalesReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlanceSheet.Click
        globalFRM = "Balance"

        btnPannel.Visible = True
        LoadForm(FrmReports)
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If x_Permission(uPermission.Chars(10)) Then
            LoadForm(FrmPaymentList)
        End If
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        If x_Permission(uPermission.Chars(11)) Then
            LoadForm(FrmExpenseList)
        End If
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        If x_Permission(uPermission.Chars(12)) Then
            LoadForm(FrmTransferList)
        End If
    End Sub

    Private Sub btnUserView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        If x_Access(UserType) Then
            LoadForm(FrmUserView)
        End If
    End Sub

    Private Sub btnMeasure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnits.Click
        If x_Access(UserType) Then
            FrmMeasurement.ShowDialog()
        End If
    End Sub



    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim DBBackup As String

        sqlSTR = "SELECT DATE_FORMAT(CURRENT_TIMESTAMP(), '%M-%d,%Y(%H%i%s)') AS BackupName"
        ExecuteSQLQuery(sqlSTR)
        DBBackup = sqlDT.Rows(0)("BackupName")
        'Process.Start("C:\Program Files\MySQL\MySQL Server 5.6\bin\mysqldump.exe", "--user=" & Split(Decrypt(conStr), ":")(1) & " --password=" & Split(Decrypt(conStr), ":")(2) & " --host=" & Split(Decrypt(conStr), ":")(0) & " --databases grameen_db hospitality -r D:\Backup\" & DBBackup & ".sql")
        'CnString = "host=anik-pc; Port=3306; Database=cemtechb_buying; User Id=anik; Password=arafat"

        Try
            Dim conn As New MySqlConnection(CnString)
            Dim mb As MySqlBackup
            Dim cmd As New MySqlCommand

            cmd.Connection = conn
            conn.Open()

            mb = New MySqlBackup(cmd)
            mb.ExportInfo.AddCreateDatabase = True
            mb.ExportInfo.MaxSqlLength = 35000

            mb.ExportToFile("D:\Backup\" & DBBackup & ".sql")
            conn.Close()

            MessageBoxEx.Show("Database Backup Successfully !!  ", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message)
        End Try
    End Sub


    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        With FrmPrint
            .Text = "Cash Account"
            .ShowDialog()
        End With
    End Sub


    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        If MessageBoxEx.Show("Do you really want to exit the system ??", "System Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.No Then
            Exit Sub
        Else
            End
        End If
    End Sub

    Private Sub btnMini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        FrmAbout.ShowDialog()
    End Sub

    Private Sub btnOut_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOut.Click
        With FrmLogin
            'ClearAll(.PanelEx1, .Highlighter1)
            .txtUser.Select()
            .ShowDialog()
        End With
    End Sub


    Private Sub tmrclock_Tick(sender As Object, e As EventArgs) Handles tmrclock.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = Format(Today.Date, "dddd, MMMM dd, yyyy")

        With FrmSales
            .lblTime.Text = TimeOfDay
            .lblDate.Text = Format(Today.Date, "dd-MMM-yyyy")
        End With
    End Sub


    Private Sub btnToken_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        LoadForm(FrmAllAccounts)
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If x_Access(UserType) Then
            Try
                Dim fopen As New OpenFileDialog
                fopen.FileName = ""
                fopen.Filter = "Database Script File (*.SQL)|*.Sql;"

                If fopen.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim conn As New MySqlConnection(CnString)
                    Dim mb As MySqlBackup
                    Dim cmd As New MySqlCommand

                    cmd.Connection = conn
                    conn.Open()

                    mb = New MySqlBackup(cmd)
                    mb.ImportFromFile(fopen.FileName)
                    conn.Close()

                    MessageBoxEx.Show("Database Restore Successfully!  ", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        If x_Access(UserType) Then
            FrmCompanyInfo.ShowDialog()
        End If
    End Sub

    Private Sub btnDevice_Click(sender As Object, e As EventArgs) Handles btnDevice.Click
        If x_Access(UserType) Then
            FrmDevice.ShowDialog()
        End If

    End Sub
End Class