Imports DevComponents.DotNetBar

Public Class FrmMeasurement
    Dim UpdateID As String

    Private Sub FrmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstMeasure.BackColor = Color.White
        Me.Height = 322

        FillList(ExecuteSQLQuery("SELECT Measure_ID, Descripation, Short_Name FROM tbl_Measure"), lstMeasure, 0)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Height = 322
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Me.Height = 460

        txtCode.Clear()
        txtDescription.Clear()
        txtDescription.Select()

        btnSave.Text = "Save"
    End Sub

    Private Sub lstMeasure_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstMeasure.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBoxEx.Show("Do you want to delete this record ???", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                sqlSTR = "SELECT Unit_Measure FROM tbl_Order_Details WHERE Unit_Measure='" & lstMeasure.SelectedItems(0).SubItems(2).Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MessageBoxEx.Show("The item is already use", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    sqlSTR = "DELETE FROM tbl_Measure WHERE Measure_ID='" & lstMeasure.SelectedItems(0).Text & "'"
                    ExecuteSQLQuery(sqlSTR)
                    FillList(ExecuteSQLQuery("SELECT Measure_ID, Descripation, Short_Name FROM tbl_Measure"), lstMeasure, 0)
                End If
            Else
                Exit Sub
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If lstMeasure.SelectedItems.Count > 0 Then
                UpdateID = lstMeasure.SelectedItems(0).SubItems(0).Text
                txtDescription.Text = lstMeasure.SelectedItems(0).SubItems(1).Text
                txtCode.Text = lstMeasure.SelectedItems(0).SubItems(2).Text
                btnSave.Text = "Update"
                Me.Height = 460
            Else
                MessageBoxEx.Show("No Record Select For Edit." & vbNewLine & "Please Select One!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If btnSave.Text = "Save" Then
            GetID = AutoIDPreFix("tbl_Measure", "Measure_ID", PreFix)
            sqlSTR = "INSERT INTO tbl_Measure(Measure_ID, Short_Name, Descripation) VALUES('" & GetID & "', '" & txtCode.Text & "', '" & txtDescription.Text & "')"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("New Measure add successfully.", "Measure Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Add New Measure", TimeOfDay.ToString("hh:mm:ss tt"))

        ElseIf btnSave.Text = "Update" Then
            sqlSTR = "UPDATE tbl_Measure SET Short_Name ='" & txtCode.Text & "', Descripation = '" & txtDescription.Text & "' WHERE Measure_ID= '" & UpdateID & "'"
            ExecuteSQLQuery(sqlSTR)
            MessageBoxEx.Show("Measure update successfully.", "Measure Add", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Edit a Measure", TimeOfDay.ToString("hh:mm:ss tt"))
        End If

        FillList(ExecuteSQLQuery("SELECT Measure_ID, Descripation, Short_Name FROM tbl_Measure"), lstMeasure, 0)
        Me.Height = 322
    End Sub
End Class