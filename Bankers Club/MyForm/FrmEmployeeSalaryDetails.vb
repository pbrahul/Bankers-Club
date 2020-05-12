Imports DevComponents.DotNetBar

Public Class FrmEmployeeSalaryDetails

    Public Sub RefreshEmployeeSalary()
        txtSearch.Clear()
        sqlSTR = "SELECT S.Salary_ID, DATE_FORMAT(S.Paid_Date,'%d-%b-%Y') AS Paid_Date, E.Emp_ID, E.Emp_Name, FORMAT(S.Paid_Amt,2) AS Paid_Amt FROM tbl_Employee_Salary AS S INNER JOIN tbl_Employees AS E ON S.Emp_ID=E.Emp_ID " & _
                 "WHERE S.Paid_Date='" & Format(dtpDate.Value, "yyyy/MM/dd") & "' ORDER BY S.Paid_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPayment)

        lblTotal.Text = Format(GridTotal(dgvPayment, 4), "###,###.00")
    End Sub


    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpSupPayment.Width = (FrmMain.Width / 2) + 400
        grpSupPayment.Height = FrmMain.Height - 200
        grpSupPayment.Left = (Me.Width / 2) - 530
        grpSupPayment.Top = (FrmMain.Height / 2) - 340

        dtpDate.Left = grpSupPayment.Width - 245
        lblDate.Left = dtpDate.Left - 120

        dgvPayment.Width = grpSupPayment.Width - 30
        dgvPayment.Height = grpSupPayment.Height - 70

        lblTotal.Top = grpSupPayment.Height - 30
        lblTotal.Left = grpSupPayment.Width - 150
        lblTitle.Top = grpSupPayment.Height - 30
        lblTitle.Left = lblTotal.Left - 95
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshEmployeeSalary()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT S.Salary_ID, DATE_FORMAT(S.Paid_Date,'%d-%b-%Y') AS Paid_Date, E.Emp_ID, E.Emp_Name, FORMAT(S.Paid_Amt,2) AS Paid_Amt FROM tbl_Employee_Salary AS S INNER JOIN tbl_Employees AS E ON S.Emp_ID=E.Emp_ID " & _
                 "WHERE LEFT(E.Emp_ID," & Len(txtSearch.Text) & " )='" & txtSearch.Text & "' OR E.Emp_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR RIGHT(E.Emp_Contact," & Len(txtSearch.Text) & " )='" & txtSearch.Text & "' ORDER BY S.Paid_Date ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPayment)

        lblTotal.Text = Format(GridTotal(dgvPayment, 4), "###,###.00")

        If sqlDT.Rows.Count = 0 Then
            MessageBoxEx.Show("Employee Not Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        RefreshEmployeeSalary()
    End Sub
End Class