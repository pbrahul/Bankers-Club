Imports DevComponents.DotNetBar

Public Class FrmSupplierList

    Public Sub RefreshSupplier()
        txtSearch.Clear()
        sqlSTR = "SELECT Supp_ID, Supp_Name, Supp_Address, Contact_No, Email, Supp_Group FROM tbl_Suppliers ORDER BY LPAD(LOWER(Supp_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvSuppliers)
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panSupplier.Width = (FrmMain.Width / 2) + 450
        panSupplier.Height = FrmMain.Height - 150
        panSupplier.Left = (Me.Width / 2) - 570
        panSupplier.Top = (FrmMain.Height / 2) - 370

        dgvSuppliers.Width = panSupplier.Width - 28
        dgvSuppliers.Height = panSupplier.Height - 70
    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshSupplier()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT Supp_ID, Supp_Name, Supp_Address, Contact_No, Email, Supp_Group FROM tbl_Suppliers WHERE Supp_ID = '" & txtSearch.Text & "' OR LEFT(Supp_Name, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & _
                 "' OR RIGHT(Contact_No, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' ORDER BY LPAD(LOWER(Supp_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvSuppliers)

     
        If sqlDT.Rows.Count = 0 Then
            dgvSuppliers.Rows.Clear()
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub
End Class