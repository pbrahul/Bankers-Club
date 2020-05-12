Imports DevComponents.DotNetBar

Public Class FrmPurchaseList

    Public Sub RefreshPurchase()
        txtSearch.Clear()

        sqlSTR = "SELECT P.Purchase_ID, A.Ac_Name, P.Memo_No, DATE_FORMAT(P.Purcahse_Date, '%d-%b-%Y') AS PurchaseDate, P.Approved, FORMAT(P.Purchase_Total, 2) AS 'Total' FROM tbl_Purchase AS P " & _
                 "INNER JOIN tbl_Accounts AS A ON P.Ac_ID = A.Ac_ID WHERE P.Purcahse_Date = '" & Format(dtpPurchase.Value, "yyyy/MM/dd") & "' ORDER BY LPAD(LOWER(P.Purchase_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPurchase)

        If sqlDT.Rows.Count > 0 Then
            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If sqlDT.Rows(i)("Approved") = "Yes" Then
                    dgvPurchase.RowsDefaultCellStyle.ForeColor = Color.IndianRed
                Else
                    dgvPurchase.RowsDefaultCellStyle.ForeColor = Color.Black
                End If
            Next

            dgvPurchase.Focus()
            dgvPurchase.Rows(0).Selected = True
            sqlSTR = "SELECT Barcode, Product_Name, Qty, Units, FORMAT(Item_Price, 2) AS 'Price', FORMAT(Total_Price, 2) AS 'Total Price' " & _
                     "FROM tbl_Purchase_Details WHERE Purchase_ID = '" & dgvPurchase.SelectedRows(0).Cells(0).Value & "' ORDER BY LPAD(LOWER(Barcode), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        Else
            dgvProduct.Rows.Clear()
        End If

    End Sub

    Private Sub SearchPurchase()
        sqlSTR = "SELECT P.Purchase_ID, A.Ac_Name, P.Memo_No, DATE_FORMAT(P.Purcahse_Date, '%d-%b-%Y') AS PurchaseDate, P.Approved, FORMAT(P.Purchase_Total, 2) AS 'Total' FROM tbl_Purchase AS P " & _
                 "INNER JOIN tbl_Accounts AS A ON P.Ac_ID = A.Ac_ID WHERE P.Purchase_ID = '" & txtSearch.Text & "' OR P.Memo_No = '" & txtSearch.Text & "' OR A.Ac_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' OR " & _
                 "RIGHT(A.Ac_ID, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR RIGHT(A.Contact_No, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' ORDER BY LPAD(LOWER(P.Purchase_ID), 10,0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvPurchase)

        If sqlDT.Rows.Count > 0 Then
            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If sqlDT.Rows(i)("Approved") = "Yes" Then
                    dgvPurchase.RowsDefaultCellStyle.ForeColor = Color.IndianRed
                Else
                    dgvPurchase.RowsDefaultCellStyle.ForeColor = Color.Black
                End If
            Next

            dgvPurchase.Focus()
            dgvPurchase.Rows(0).Selected = True
            sqlSTR = "SELECT Barcode, Product_Name, Qty, Units, FORMAT(Item_Price, 2) AS 'Price', FORMAT(Total_Price, 2) AS 'Total Price' " & _
                     "FROM tbl_Purchase_Details WHERE Purchase_ID = '" & dgvPurchase.SelectedRows(0).Cells(0).Value & "' ORDER BY LPAD(LOWER(Barcode), 10,0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        Else
            MessageBoxEx.Show("No Record(s) Found!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvProduct.Rows.Clear()
        End If
    End Sub

    Private Sub ViewPurchase()
        If dgvPurchase.SelectedRows.Count > 0 Then
            sqlSTR = "SELECT Barcode, Product_Name, Qty, Units, FORMAT(Item_Price, 2) AS 'Price', FORMAT(Total_Price, 2) AS 'Total Price' " & _
                     "FROM tbl_Purchase_Details WHERE Purchase_ID = '" & dgvPurchase.SelectedRows(0).Cells(0).Value & "' ORDER BY LPAD(LOWER(Barcode), 10, 0) ASC"
            FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvProduct)
        End If
    End Sub


    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'panProduct.Width = (FrmMain.Width / 2) + 450
        'panProduct.Height = FrmMain.Height - 150
        'panProduct.Left = (Me.Width / 2) - 570
        'panProduct.Top = (FrmMain.Height / 2) - 370

        panProduct.Width = FrmMain.Width - 180
        panProduct.Height = FrmMain.Height - 180
        panProduct.Location = New Point(100, 10)

        dtpPurchase.Left = panProduct.Width - 238
        lblPurchase.Left = dtpPurchase.Left - 120

        dgvPurchase.Width = panProduct.Width - 28
        dgvProduct.Width = panProduct.Width - 37
        dgvProduct.Height = panProduct.Height - 320

    End Sub

    Private Sub FrmUserView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpPurchase.Value = Today.Date
        RefreshPurchase()
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchPurchase()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchPurchase()
        End If
    End Sub

    Private Sub MouseClick_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvPurchase.MouseClick
        ViewPurchase()
    End Sub

    Private Sub dgvPurchase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ViewPurchase()
        ElseIf e.KeyCode = Keys.Back Then
            txtSearch.Select()
        End If
    End Sub

    Private Sub dtpPurchase_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpPurchase.ValueChanged
        RefreshPurchase()
    End Sub
End Class