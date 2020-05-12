Imports DevComponents.DotNetBar

Public Class FrmEmployeeList

    Public Sub RefreshEmployee()
        sqlSTR = "SELECT Emp_ID, Emp_Name, Emp_Guardian, Emp_Address, Emp_Contact, DATE_FORMAT(Join_Date, '%d-%b-%Y') AS Join_Date, Emp_Status FROM tbl_Employees ORDER BY LPAD(LOWER(Emp_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panCustomers.Width = (FrmMain.Width / 2) + 450
        panCustomers.Height = FrmMain.Height - 150
        panCustomers.Left = (Me.Width / 2) - 570
        panCustomers.Top = (FrmMain.Height / 2) - 370

        dgvCustomers.Width = panCustomers.Width - 28
        dgvCustomers.Height = panCustomers.Height - 70
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshEmployee()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT Emp_ID, Emp_Name, Emp_Guardian, Emp_Address, Emp_Contact, DATE_FORMAT(Join_Date, '%d-%b-%Y') AS Join_Date, Emp_Status FROM tbl_Employees WHERE LEFT(Emp_ID, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & _
                 "' OR Emp_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(Emp_Contact, " & Len(txtSearch.Text) & ")='" & txtSearch.Text & "' ORDER BY LPAD(LOWER(Emp_ID), 10,0) ASC"
        FillGridViewWithColumn(ExecuteSQLQuery(sqlSTR), dgvCustomers)

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
End Class