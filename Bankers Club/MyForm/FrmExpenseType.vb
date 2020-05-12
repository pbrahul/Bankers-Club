Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class FrmExpenseType

    Public Sub RefreshRules()
        sqlSTR = "SELECT A.Ac_ID, A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE Type_Details='Expense'"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Expense Type"
        SingleComboBox("SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE Type_Details='Expense' ORDER BY A.Ac_Name ASC", FrmExpense.cmbType)
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(374, 289)

        RefreshRules()
    End Sub


    Private Sub dgvCustomers_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim MyValue As String
        Dim Type_ID, Type_Code As String

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 2 Then
            MyValue = dgvCustomers.CurrentRow.Cells(0).Value

            If dgvCustomers.CurrentRow.Cells(1).Value = Nothing Then
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                Exit Sub
            Else
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
            End If

            If MyValue = "" Then
                sqlSTR = "SELECT T.Type_Code, A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE T.Type_Details='Expense'"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    If UCase(sqlDT.Rows(i)("Ac_Name")) = UCase(dgvCustomers.CurrentRow.Cells(1).Value) Then
                        MessageBoxEx.Show("Account type is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                        dgvCustomers.CurrentRow.Cells(1).Selected = True
                        Exit Sub
                    Else
                        dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
                    End If
                Next

                sqlSTR = "SELECT Type_ID, Type_Code FROM tbl_Accounts_Type WHERE Type_Details='Expense'"
                ExecuteSQLQuery(sqlSTR)

                'sqlSTR = "SELECT T.Type_Code FROM tbl_Accounts AS A INNER JOIN tbl_Accounts_Type AS T ON A.Type_ID=T.Type_ID WHERE T.Type_Details='Expense'"
                'ExecuteSQLQuery(sqlSTR)

                Type_ID = sqlDT.Rows(0)("Type_ID")
                Type_Code = sqlDT.Rows(0)("Type_Code")

                GetID = ManualID("tbl_Accounts", "Ac_ID", Type_Code)

                sqlSTR = "INSERT INTO tbl_Accounts(AC_ID, AC_Name, Ac_Address, Contact_No, Ac_Email, Type_ID, Bal_Amt, User_ID) VALUES('" & GetID & "', '" & dgvCustomers.CurrentRow.Cells(1).Value & _
                         "', 'N/A', 'N/A', 'N/A', " & Type_ID & ", 0, '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                MessageBoxEx.Show("Record Save Successfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 3 Then
            Dim DuplicateName As Boolean

            MyValue = dgvCustomers.CurrentRow.Cells(0).Value

            If dgvCustomers.CurrentRow.Cells(1).Value = Nothing Then
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                Exit Sub
            Else
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
            End If

            If MyValue <> "" Then
                sqlSTR = "SELECT Ac_Name FROM tbl_Accounts WHERE Ac_ID='" & MyValue & "'"
                ExecuteSQLQuery(sqlSTR)

                'sqlSTR = "SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_ID =" & MyValue
                'ExecuteSQLQuery(sqlSTR)

                If UCase(sqlDT.Rows(0)("Ac_Name")) = UCase(dgvCustomers.CurrentRow.Cells(1).Value) Then
                    DuplicateName = False
                Else
                    sqlSTR = "SELECT Ac_Name FROM tbl_Accounts WHERE Ac_Name='" & dgvCustomers.CurrentRow.Cells(1).Value & "'"
                    ExecuteSQLQuery(sqlSTR)

                    'sqlSTR = "SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_Details ='" & dgvCustomers.CurrentRow.Cells(1).Value & "'"
                    'ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        MessageBoxEx.Show("Account type is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DuplicateName = True
                        dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                        dgvCustomers.CurrentRow.Cells(1).Selected = True
                        Exit Sub
                    Else
                        DuplicateName = False
                        dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
                    End If
                End If


                If dgvCustomers.CurrentRow.Cells(1).Value <> "" Then
                    sqlSTR = "UPDATE tbl_accounts SET Ac_Name ='" & dgvCustomers.CurrentRow.Cells(1).Value & "' WHERE AC_ID='" & MyValue & "'"
                    ExecuteSQLQuery(sqlSTR)
                    MessageBoxEx.Show("Record Update Successfully...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBoxEx.Show("Record does not exist in database. Please record save first.", "Token", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End If
    End Sub

End Class