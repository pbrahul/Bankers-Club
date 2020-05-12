Imports DevComponents.DotNetBar

Public Class FrmStockPrint
    Dim scSalesProduct As New AutoCompleteStringCollection

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(416, 358)

        sqlSTR = "SELECT P.Product_Name FROM tbl_Products AS P INNER JOIN tbl_Stock_Products AS S ON P.Barcode = S.Barcode ORDER BY Product_name ASC"
        ExecuteSQLQuery(sqlSTR)
        For i As Integer = 0 To sqlDT.Rows.Count - 1
            scSalesProduct.Add(sqlDT.Rows(i)("Product_Name"))
        Next

        With txtBarcode
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scSalesProduct
        End With

        txtBarcode.Clear()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        If rbnCurrent.Checked = True Then
            RptStr = "SELECT S.Barcode, S.Product_Name, S.Qty, P.Units, (P.Qty*S.Qty) AS PcsQty, P.Purchase_Price, " & _
                     "(S.Qty * P.Purchase_Price) AS PurTotal, P.Sales_Price, (S.Qty * P.Sales_Price) AS SaleTotal FROM tbl_Stock_Products AS S " & _
                     "INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode INNER JOIN tbl_Product_category AS C ON P.Cat_ID=C.Cat_ID ORDER BY LPAD(LOWER(S.Barcode), 10,0) ASC"
            PrmFormDate.Value = Today.Date
            globalFRM = "ProductStock"

        ElseIf rbnTill.Checked = True Then
            RptStr = "SELECT P.Barcode, P.Product_Name, P.Qty, P.Units, (SELECT Bal_Qty FROM tbl_product_history WHERE Barcode=P.Barcode AND DATE_FORMAT(Hy_Date,'%Y/%m/%d')<='" & Format(dtpTill.Value, "yyyy/MM/dd") & "' ORDER BY Hy_Date DESC, Hy_ID DESC LIMIT 1) AS StockQty, " & _
                     "P.Purchase_Price, P.Purchase_Price, P.Sales_Price, P.Sales_Price FROM tbl_Products AS P ORDER BY LPAD(LOWER(P.Barcode), 10,0) ASC"
            PrmFormDate.Value = dtpTill.Value
            globalFRM = "ProductStockTillDate"

        ElseIf rbnSelected.Checked = True Then
            If txtBarcode.Text = "" Then
                Highlighter1.SetHighlightColor(txtBarcode, Validator.eHighlightColor.Red)
                txtBarcode.Select()
                Exit Sub
            Else
                Highlighter1.SetHighlightColor(txtBarcode, Validator.eHighlightColor.None)
            End If

            PrmFormDate.Value = dtpFrom.Value
            PrmToDate.Value = dtpTo.Value

            RptStr = "SELECT H.Barcode, H.Hy_Date, P.Product_Name, H.Hy_Particulars, P.Qty, IFNULL(H.In_Qty, 0) AS In_Qty, IFNULL(H.Out_Qty, 0) AS Out_Qty, H.Bal_Qty, P.Units FROM tbl_product_history AS H INNER JOIN tbl_Products AS P ON H.Barcode=P.Barcode " & _
                     "WHERE P.Product_Name='" & txtBarcode.Text & "' OR P.Barcode='" & txtBarcode.Text & "' AND (DATE_FORMAT(H.Hy_Date,'%Y/%m/%d')>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(H.Hy_Date,'%Y/%m/%d')<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY H.Hy_Date ASC"
            globalFRM = "StockHistory"
        End If

        rptReport.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub rbnSelect_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCurrent.CheckedChanged
        If rbnCurrent.Checked = True Then
            txtBarcode.Enabled = False
            dtpFrom.Enabled = False
            dtpTo.Enabled = False
            dtpTill.Enabled = False
        End If
    End Sub

    Private Sub rbnSupplier_CheckedChanged(sender As Object, e As EventArgs) Handles rbnSelected.CheckedChanged
        If rbnSelected.Checked = True Then
            txtBarcode.Enabled = True
            dtpFrom.Enabled = True
            dtpTo.Enabled = True
            dtpTill.Enabled = False
        End If
    End Sub

    Private Sub rbnTill_CheckedChanged(sender As Object, e As EventArgs) Handles rbnTill.CheckedChanged
        If rbnTill.Checked = True Then
            dtpTill.Enabled = True
            txtBarcode.Enabled = False
            dtpFrom.Enabled = False
            dtpTo.Enabled = False

        End If
    End Sub
End Class