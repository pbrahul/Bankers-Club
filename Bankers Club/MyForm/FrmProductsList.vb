Imports DevComponents.DotNetBar

Public Class FrmProductsList

    Public Sub RefreshProducts()
        txtSearch.Clear()
        txtSearch.Select()

        If rbnCategory.Checked = True Then
            sqlSTR = "SELECT Cat_ID, Cat_Name, Cat_Code FROM tbl_Product_Category ORDER BY LPAD(LOWER(Cat_ID), 10,0) ASC" 'ORDER BY CONVERT(SUBSTRING_INDEX(Brand_ID,'-',-1),UNSIGNED INTEGER) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCategory)

            If sqlDT.Rows.Count > 0 Then
                dgvCatProduct.Rows.Clear()
                dgvCategory.Rows(0).Selected = True

                sqlSTR = "SELECT Barcode, Product_Name, Units, Reorder_Label, FORMAT(Purchase_Price, 2) AS 'Purchase Price', FORMAT(Sales_Price, 2) AS 'Sales Price' " & _
                         " FROM tbl_Products WHERE Cat_ID = '" & dgvCategory.SelectedRows(0).Cells(0).Value & "' ORDER BY LPAD(LOWER(Barcode), 10,0) ASC"
                FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCatProduct)
            Else
                dgvCatProduct.Rows.Clear()
            End If

        ElseIf rbnProducts.Checked = True Then
            sqlSTR = "SELECT P.Barcode, P.Product_Name, P.Units, P.Reorder_Label, FORMAT(P.Purchase_Price, 2) AS 'PurchasePrice', FORMAT(P.Sales_Price, 2) AS 'SalesPrice' " & _
                     "FROM tbl_Products AS P INNER JOIN tbl_Product_Category AS C ON P.Cat_ID = C.Cat_ID ORDER BY LPAD(LOWER(P.Barcode), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        End If

    End Sub

    Public Sub ViewDetails()
        dgvCatProduct.Rows.Clear()

        If rbnCategory.Checked = True Then
            sqlSTR = "SELECT Barcode, Product_Name, Units, Reorder_Label, FORMAT(Purchase_Price, 2) AS 'Purchase Price', FORMAT(Sales_Price, 2) AS 'Sales Price' " & _
                     " FROM tbl_Products WHERE Cat_ID = '" & dgvCategory.SelectedRows(0).Cells(0).Value & "' ORDER BY LPAD(LOWER(Barcode), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCatProduct)
        End If
    End Sub

    Public Sub SearchProducts()
        If rbnCategory.Checked = True Then
            sqlSTR = "SELECT Cat_ID, Cat_Name, Cat_Code FROM tbl_Product_Category WHERE LEFT(Cat_ID, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR LEFT(Cat_Name, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' ORDER BY LPAD(LOWER(Cat_ID), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCategory)

            If sqlDT.Rows.Count > 0 Then
                dgvCatProduct.Rows.Clear()

                dgvCategory.Focus()
                dgvCategory.Rows(0).Selected = True

                sqlSTR = "SELECT Barcode, Product_Name, Units, Reorder_Label, FORMAT(Purchase_Price, 2) AS 'Purchase Price', FORMAT(Sales_Price, 2) AS 'Sales Price' " & _
                         " FROM tbl_Products WHERE Cat_ID = '" & dgvCategory.SelectedRows(0).Cells(0).Value & "' ORDER BY LPAD(LOWER(Barcode), 10,0) ASC"
                FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvCatProduct)
            Else
                dgvCategory.Rows.Clear()
                dgvCatProduct.Rows.Clear()
                txtSearch.Select()
                MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        ElseIf rbnProducts.Checked = True Then
            sqlSTR = "SELECT P.Barcode, P.Product_Name, P.Units, P.Reorder_Label, FORMAT(P.Purchase_Price, 2) AS 'PurchasePrice', FORMAT(P.Sales_Price, 2) AS 'SalesPrice' " & _
                     "FROM tbl_Products AS P INNER JOIN tbl_Product_Category AS C ON P.Cat_ID = C.Cat_ID WHERE LEFT(P.Barcode, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & _
                     "' OR P.Product_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR LEFT(P.Product_Name, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR RIGHT(P.Barcode, " & Len(txtSearch.Text) & ") ='" & txtSearch.Text & "' ORDER BY LPAD(LOWER(P.Barcode), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)

            If sqlDT.Rows.Count = 0 Then
                dgvProduct.Rows.Clear()
                txtSearch.Select()

                MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        End If
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panProducts.Width = FrmMain.Width - 180
        panProducts.Height = FrmMain.Height - 180
        panProducts.Location = New Point(100, 10)

        rbnProducts.Left = panProducts.Width - 100
        rbnCategory.Left = rbnProducts.Left - 145

        dgvCategory.Width = panProducts.Width - 28
        dgvCatProduct.Width = panProducts.Width - 37
        dgvCatProduct.Height = panProducts.Height - 315
        dgvProduct.Width = panProducts.Width - 28
        dgvProduct.Height = panProducts.Height - 70

    End Sub


    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbnProducts.Checked = True
    End Sub

    Private Sub dgvBrand_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvCategory.MouseDoubleClick
        ViewDetails()
    End Sub

    Private Sub lstCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchProducts()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchProducts()
        End If
    End Sub

    Private Sub lstBrand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            ViewDetails()
        ElseIf e.KeyCode = Keys.Back Then
            txtSearch.Select()
        End If
    End Sub


    Private Sub rbnMedicineCategory_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCategory.CheckedChanged
        If rbnCategory.Checked = True Then
            dgvCategory.Visible = True
            dgvCatProduct.Visible = True
            dgvProduct.Visible = False
            lblCategory.Visible = True
            Pic.Visible = True

            RefreshProducts()
        End If

    End Sub

    Private Sub rbnMedicineItem_CheckedChanged(sender As Object, e As EventArgs) Handles rbnProducts.CheckedChanged
        If rbnProducts.Checked = True Then
            dgvCategory.Visible = False
            dgvCatProduct.Visible = False
            dgvProduct.Visible = True
            lblCategory.Visible = False
            Pic.Visible = False

            RefreshProducts()
        End If

    End Sub
End Class