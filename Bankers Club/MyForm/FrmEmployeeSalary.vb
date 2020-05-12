Imports DevComponents.DotNetBar

Public Class FrmEmployeeSalary

    Private Sub FrmDefective_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(385, 360)

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(TableLayoutPanel2, Highlighter1)
            txtSearch.Enabled = True
            txtSearch.Select()
        Else
            sqlSTR = "SELECT D.Barcode, D.Product_Name, D.Discount, D.Discount_Date, P.Sales_Price FROM tbl_Discount AS D " & _
                     "INNER JOIN tbl_Products AS P ON D.Barcode = P.Barcode WHERE D.Barcode = '" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            txtSearch.Text = sqlDT.Rows(0)("Barcode")
            txtName.Text = sqlDT.Rows(0)("Product_Name")
            txtContact.Text = sqlDT.Rows(0)("Sales_Price")
            dtpDiscount.Value = sqlDT.Rows(0)("Discount_Date")
            txtRemarks.Text = sqlDT.Rows(0)("Discount")
            txtSearch.Enabled = False
            txtRemarks.Focus()
        End If
        txtAmount.Text = DateDiff(DateInterval.Day, Today.Date, dtpDiscount.Value)
    End Sub

    Private Sub FrmUserAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Salary"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            sqlSTR = "SELECT Emp_ID, Emp_Name, Emp_Contact FROM tbl_Employees WHERE RIGHT(Emp_ID, " & Len(txtSearch.Text) & ") ='" & txtSearch.Text & "' OR LEFT(Emp_Contact, " & Len(txtSearch.Text) & ") ='" & txtSearch.Text & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtID.Text = sqlDT.Rows(0)("Emp_ID")
                txtName.Text = sqlDT.Rows(0)("Emp_Name")
                txtContact.Text = sqlDT.Rows(0)("Emp_Contact")
                txtRemarks.Select()
            Else
                ClearAll(TableLayoutPanel2, Highlighter1)
                MessageBoxEx.Show("Item Not Found..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSearch.Select()
            End If
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        NumKey(txtAmount.Text, e)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If FillTextBox(TableLayoutPanel2, Highlighter1) = False Then
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            GetID = AutoIDPreFix("tbl_Employee_Salary", "Salary_ID", PreFix)

            sqlSTR = "INSERT INTO tbl_Employee_Salary(Salary_ID, Details, Paid_Amt, Paid_Date, Emp_ID, User_ID) " & _
                     "VALUES('" & GetID & "', '" & txtRemarks.Text & "', " & CDbl(txtAmount.Text) & ", '" & Format(dtpDiscount.Value, "yyyy/MM/dd") & _
                     "', '" & txtID.Text & "', '" & UserID & "')"
            ExecuteSQLQuery(sqlSTR)

            MessageBoxEx.Show("Record Save Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '    sqlSTR = "UPDATE tbl_Discount SET Discount = '" & txtRemarks.Text & "', Discount_Date = '" & Format(dtpDiscount.Value, "yyyy/MM/dd") & _
            '             "', Issue_Date = '" & Format(Today.Date, "yyyy/MM/dd") & "' WHERE Barcode = '" & txtSearch.Text & "'"
            '    ExecuteSQLQuery(sqlSTR)

            '    MessageBoxEx.Show("Record Update Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        FrmEmployeeSalaryDetails.RefreshEmployeeSalary()
        Me.Close()
    End Sub


End Class