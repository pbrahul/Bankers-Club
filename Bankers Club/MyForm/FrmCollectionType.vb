Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class FrmCollectionType
    Dim scAutoComplete As New AutoCompleteStringCollection

    Public Sub RefreshRules()
        sqlSTR = "SELECT Type_ID, '', Type_Details, Type_Amt FROM tbl_Collection_Type ORDER BY Type_ID ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Type of Collection"
        SingleComboBox("SELECT Type_Details FROM tbl_Collection_Type ORDER BY Type_ID ASC", FrmCollection.cmbType)
        SingleComboBox("SELECT Type_Details FROM tbl_Collection_Type ORDER BY Type_ID ASC", FrmCollectionOthers.cmbType)
        'SingleComboBox("SELECT Type_Details FROM tbl_Collection_Type ORDER BY Type_ID ASC", FrmCollection.cmbType)
    End Sub

    Private Sub FrmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        RefreshRules()
    End Sub


    Private Sub dgvCustomers_CellContentClick(sender As System.Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick
        Dim senderGrid = DirectCast(sender, DataGridView)
        Dim MyValue As String

        If dgvCustomers.CurrentRow.Cells(2).Value = Nothing Then
            dgvCustomers.CurrentRow.Cells(2).ErrorText = "Enter Value"
            Exit Sub
        Else
            dgvCustomers.CurrentRow.Cells(2).ErrorText = ""
        End If

        If dgvCustomers.CurrentRow.Cells(3).Value = Nothing Then
            dgvCustomers.CurrentRow.Cells(3).ErrorText = "Enter Value"
            Exit Sub
        Else
            dgvCustomers.CurrentRow.Cells(3).ErrorText = ""
        End If

        If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 1 Then
            MyValue = dgvCustomers.CurrentRow.Cells(0).Value

            If MyValue = "" Then
                sqlSTR = "SELECT Type_Details FROM tbl_Collection_Type WHERE Type_Details='" & dgvCustomers.CurrentRow.Cells(2).Value & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    dgvCustomers.CurrentRow.Cells(2).ErrorText = "Type is already on the list !!"
                    Exit Sub
                Else
                    dgvCustomers.CurrentRow.Cells(2).ErrorText = ""
                End If

                sqlSTR = "INSERT INTO tbl_Collection_Type(Type_Details, Type_Amt) VALUES('" & dgvCustomers.CurrentRow.Cells(2).Value & "', '" & dgvCustomers.CurrentRow.Cells(3).Value & "')"
                ExecuteSQLQuery(sqlSTR)

                MessageBoxEx.Show("Record Save Successfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 4 Then
            MyValue = dgvCustomers.CurrentRow.Cells(0).Value

            If MyValue <> "" Then
                sqlSTR = "SELECT Type_Details FROM tbl_Collection_Type WHERE Type_ID=" & MyValue
                ExecuteSQLQuery(sqlSTR)

                If UCase(sqlDT.Rows(0)("Type_Details")) <> UCase(dgvCustomers.CurrentRow.Cells(2).Value) Then
                    sqlSTR = "SELECT Type_Details FROM tbl_Collection_Type WHERE Type_Details ='" & dgvCustomers.CurrentRow.Cells(2).Value & "'"
                    ExecuteSQLQuery(sqlSTR)
                    If sqlDT.Rows.Count > 0 Then
                        dgvCustomers.CurrentRow.Cells(2).ErrorText = "Type is already on the list !!"
                        Exit Sub
                    Else
                        dgvCustomers.CurrentRow.Cells(2).ErrorText = ""
                    End If
                End If


                If MyValue <> "" And dgvCustomers.CurrentRow.Cells(1).Value <> "" Then
                    sqlSTR = "UPDATE tbl_Collection_Type SET Type_Details ='" & dgvCustomers.CurrentRow.Cells(2).Value & "', Type_Amt='" & dgvCustomers.CurrentRow.Cells(3).Value & "' WHERE Type_ID=" & dgvCustomers.CurrentRow.Cells(0).Value & ""
                    ExecuteSQLQuery(sqlSTR)
                    MessageBoxEx.Show("Record Update Successfully...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBoxEx.Show("Record does not exist in database. Please record save first.", "Token", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
        End If

        'ExecuteSQLQuery("SELECT DISTINCT Rules_Type FROM tbl_prescription_rules ORDER BY Rules_Type ASC")
        'For i As Integer = 0 To sqlDT.Rows.Count - 1
        '    scAutoComplete.Add(sqlDT.Rows(i)("Rules_Type"))
        'Next

        'RefreshRules()
    End Sub


    Private Sub dgvCollection_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCustomers.EditingControlShowing
        If dgvCustomers.CurrentCell.ColumnIndex = 3 And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)

            '---add an event handler to the TextBox control---
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class