Imports DevComponents.DotNetBar

Public Class FrmCritical

    Public Sub RefreshCritical()
        txtSearch.Clear()

        sqlSTR = "SELECT S.Barcode, S.Product_Name, FORMAT(P.Purchase_Price, 2) AS Purchase, CONCAT(S.Qty, ' ', P.Units) AS Qty, CONCAT(P.Qty*S.Qty, ' ', 'Pice') AS PcsQty, P.Reorder_Label FROM tbl_Stock_Products AS S " & _
                 "INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode INNER JOIN tbl_Product_category AS C ON P.Cat_ID=C.Cat_ID WHERE S.Qty <= P.Reorder_Label ORDER BY S.Qty ASC" ' LPAD(LOWER(S.Barcode), 10, 0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvStock)
    End Sub

    Private Sub FrmStock_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panProducts.Width = FrmMain.Width - 180
        panProducts.Height = FrmMain.Height - 180
        panProducts.Location = New Point(100, 10)

        dgvStock.Width = panProducts.Width - 28
        dgvStock.Height = panProducts.Height - 70

    End Sub

    Private Sub FrmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshCritical()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        sqlSTR = "SELECT S.Barcode, S.Product_Name, FORMAT(P.Purchase_Price, 2) AS Purchase, CONCAT(S.Qty, ' ', P.Units) AS Qty, CONCAT(P.Qty*S.Qty, ' ', 'Pice') AS PcsQty, P.Reorder_Label FROM tbl_Stock_Products AS S " & _
                 "INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode INNER JOIN tbl_Product_category AS C ON P.Cat_ID=C.Cat_ID WHERE (S.Qty <= P.Reorder_Label) " & _
                 "AND (LEFT(S.Barcode, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR LEFT(P.Product_Name, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "' OR " & _
                 "RIGHT(S.Barcode, " & Len(txtSearch.Text) & ") = '" & txtSearch.Text & "') OR P.Product_Name REGEXP '[[:<:]]" & txtSearch.Text & "[[:>:]]' ORDER BY LPAD(LOWER(S.Barcode), 10, 0) ASC"
        FillGridViewWithoutColumn(ExecuteSQLQuery(sqlSTR), dgvStock)

        If sqlDT.Rows.Count = 0 Then
            MessageBoxEx.Show("No Record(s) Found..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearch_Click(Nothing, Nothing)
        End If
    End Sub

End Class