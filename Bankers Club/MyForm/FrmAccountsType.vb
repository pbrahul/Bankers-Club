Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class FrmAccountsType

    Public Sub RefreshRules()
        sqlSTR = "SELECT * FROM tbl_accounts_type WHERE Type_Details<>'Expense' ORDER BY Type_ID ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Account Type"
        SingleComboBox("SELECT Type_Details FROM tbl_accounts_type WHERE Type_Details<>'Expense' ORDER BY Type_Details ASC", FrmAccountsAdd.cmbType)
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(374, 289)

        RefreshRules()

    End Sub


    Private Sub dgvCustomers_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim MyValue As String

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 3 Then
            MyValue = dgvCustomers.CurrentRow.Cells(0).Value

            If dgvCustomers.CurrentRow.Cells(1).Value = Nothing Then
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                Exit Sub
            Else
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
            End If

            If dgvCustomers.CurrentRow.Cells(2).Value = Nothing Then
                dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.Red
                Exit Sub
            Else
                dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.WhiteSmoke
            End If

            If MyValue = "" Then
                sqlSTR = "SELECT Type_Details, Type_Code FROM tbl_Accounts_Type"
                ExecuteSQLQuery(sqlSTR)

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    If UCase(sqlDT.Rows(i)("Type_Details")) = UCase(dgvCustomers.CurrentRow.Cells(1).Value) Then
                        MessageBoxEx.Show("Account type is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                        dgvCustomers.CurrentRow.Cells(1).Selected = True
                        Exit Sub
                    Else
                        dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
                    End If
                Next

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    If UCase(sqlDT.Rows(i)("Type_Code")) = UCase(dgvCustomers.CurrentRow.Cells(2).Value) Then
                        MessageBoxEx.Show("Account code already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.Red
                        dgvCustomers.CurrentRow.Cells(2).Selected = True
                        Exit Sub
                    Else
                        dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.WhiteSmoke
                    End If
                Next

                sqlSTR = "INSERT INTO tbl_accounts_type(Type_Details, Type_Code) VALUES('" & dgvCustomers.CurrentRow.Cells(1).Value & "', '" & UCase(dgvCustomers.CurrentRow.Cells(2).Value) & "')"
                ExecuteSQLQuery(sqlSTR)

                MessageBoxEx.Show("Record Save Successfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 4 Then
            Dim DuplicateName As Boolean

            MyValue = dgvCustomers.CurrentRow.Cells(0).Value

            If dgvCustomers.CurrentRow.Cells(1).Value = Nothing Then
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.Red
                Exit Sub
            Else
                dgvCustomers.CurrentRow.Cells(1).Style.BackColor = Color.WhiteSmoke
            End If

            If dgvCustomers.CurrentRow.Cells(2).Value = Nothing Then
                dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.Red
                Exit Sub
            Else
                dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.WhiteSmoke
            End If

            If MyValue <> "" Then
                sqlSTR = "SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_ID =" & MyValue
                ExecuteSQLQuery(sqlSTR)

                If UCase(sqlDT.Rows(0)("Type_Details")) = UCase(dgvCustomers.CurrentRow.Cells(1).Value) Then
                    DuplicateName = False
                Else
                    sqlSTR = "SELECT Type_Details FROM tbl_Accounts_Type WHERE Type_Details ='" & dgvCustomers.CurrentRow.Cells(1).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
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

                sqlSTR = "SELECT Type_Code FROM tbl_Accounts_Type WHERE Type_ID =" & MyValue
                ExecuteSQLQuery(sqlSTR)

                If UCase(sqlDT.Rows(0)("Type_Code")) = UCase(dgvCustomers.CurrentRow.Cells(2).Value) Then
                    DuplicateName = False
                Else
                    sqlSTR = "SELECT Type_Code FROM tbl_Accounts_Type WHERE Type_Code ='" & dgvCustomers.CurrentRow.Cells(2).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        MessageBoxEx.Show("Category Code is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        DuplicateName = True
                        dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.Red
                        dgvCustomers.CurrentRow.Cells(2).Selected = True
                        Exit Sub
                    Else
                        DuplicateName = False
                        dgvCustomers.CurrentRow.Cells(2).Style.BackColor = Color.WhiteSmoke
                    End If
                End If


                If dgvCustomers.CurrentRow.Cells(1).Value <> "" Then
                    sqlSTR = "UPDATE tbl_accounts_type SET Type_Details ='" & dgvCustomers.CurrentRow.Cells(1).Value & "', Type_Code='" & UCase(dgvCustomers.CurrentRow.Cells(2).Value) & "' WHERE Type_ID=" & MyValue
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