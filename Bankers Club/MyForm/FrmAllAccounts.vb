Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmAllAccounts

    Public Sub RefreshAccounts()
        txtSearch.Clear()
        txtSearch.Select()

        sqlSTR = "SELECT A.AC_ID, A.AC_Name, A.Ac_Address, C.Type_Details, A.Contact_No, FORMAT(A.Bal_Amt, 2) AS Bal_Amt FROM tbl_Accounts AS A " & _
                 "INNER JOIN tbl_Accounts_Type AS C ON A.Type_ID=C.Type_ID WHERE C.Type_Details='" & cmbType.Text & "' ORDER BY LPAD(LOWER(A.Ac_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'grpSales.Width = (FrmMain.Width / 2) + 400
        'grpSales.Height = (FrmMain.Height / 2) + 200
        ''grpSales.Left = (Me.Width / 2) - 530
        ''grpSales.Top = (FrmMain.Height / 2) - 340
        'grpSales.Location = New Point(150, 50)

        grpSales.Width = FrmMain.Width - 180
        grpSales.Height = FrmMain.Height - 180
        grpSales.Location = New Point(100, 30)

        dgvCustomers.Width = grpSales.Width - 40
        dgvCustomers.Height = grpSales.Height - 65

        cmbType.Left = dgvCustomers.Width - 130
        lblType.Left = cmbType.Left - 140


    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SingleComboBox("SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_Details<>'Expense' ORDER BY Type_Details ASC", cmbType)
        RefreshAccounts()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT A.AC_ID, A.AC_Name, A.Ac_Address, C.Type_Details, A.Contact_No, FORMAT(A.Bal_Amt, 2) AS Bal_Amt FROM tbl_Accounts AS A " & _
                 "INNER JOIN tbl_Accounts_Type AS C ON A.Type_ID=C.Type_ID WHERE (RIGHT(AC_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & _
                "' OR AC_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(Contact_No, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & _
                "') AND C.Type_Details<>'Expense' ORDER BY LPAD(LOWER(A.Ac_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)

        If sqlDT.Rows.Count = 0 Then
            dgvCustomers.Rows.Clear()
            txtSearch.Select()
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 5 Then
            If MessageBoxEx.Show("Do you want print a token?", "Token", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                sqlSTR = "SELECT MAX(To_No) AS To_No FROM tbl_Token WHERE DATE_FORMAT(To_Date, '%Y/%m/%d')='" & Format(Now.Date, "yyyy/MM/dd") & "'"
                ExecuteSQLQuery(sqlSTR)

                If Not IsDBNull(sqlDT.Rows(0)("To_No")) Then
                    sqlSTR = "INSERT INTO tbl_token (To_Date, To_No, Pat_ID, User_ID) VALUES('" & Format(Now, "yyyy/MM/dd HH:mm:ss") & "', " & sqlDT.Rows(0)("To_No") + 1 & ", '" & dgvCustomers.CurrentRow.Cells(0).Value & "', '" & UserID & "')"
                    ExecuteSQLQuery(sqlSTR)
                Else
                    sqlSTR = "INSERT INTO tbl_token (To_Date, To_No, Pat_ID, User_ID) VALUES('" & Format(Now, "yyyy/MM/dd HH:mm:ss") & "', 11, '" & dgvCustomers.CurrentRow.Cells(0).Value & "', '" & UserID & "')"
                    ExecuteSQLQuery(sqlSTR)
                End If

                RptStr = "SELECT T.To_No, P.Pat_Name, DATE_FORMAT(T.To_Date,'%d-%b-%Y') AS To_Date FROM tbl_Token AS T INNER JOIN tbl_patient AS P ON T.Pat_ID=P.Pat_ID " & _
                         "WHERE T.To_ID=(SELECT Max(To_ID) FROM tbl_Token)"
                mReport.Load(Application.StartupPath & "\MyReports\rptToken.rpt")
                mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                For Each rptPrinter In PrinterSettings.InstalledPrinters
                    If rptPrinter = "POS Printer" Then
                        mReport.PrintOptions.PrinterName = rptPrinter
                        Exit For
                    End If
                Next

                mReport.PrintToPrinter(1, True, 0, 0)
            End If

        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        RefreshAccounts()
    End Sub
End Class