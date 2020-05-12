Imports DevComponents.DotNetBar

Public Class FrmSalesPrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(377, 295)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        If rbnSummary.Checked = True Then
            'RptStr = "SELECT Sales_ID, DATE_FORMAT(Sales_Date,'%d-%b-%Y') AS SDate, Sub_Total, Total_Vat, Total_Discount, Grand_Total, Disount_Amount FROM tbl_sales  " & _
            '         "WHERE Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY Sales_Date ASC"

            RptStr = "SELECT S.Sales_ID, DATE_FORMAT(S.Sales_Date,'%d-%b-%Y') AS SDate, S.Sub_Total, S.Total_Vat, S.Grand_Total, S.Disount_Amount, " & _
                     "(SELECT SUM(Profit_Amt) FROM tbl_Sales_Details WHERE Sales_ID=S.Sales_ID) AS Profit FROM tbl_sales AS S " & _
                     "WHERE Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY Sales_Date ASC"

            globalFRM = "SalesSummary"

        ElseIf rbnCosmetics.Checked = True Then
            RptStr = "SELECT DATE_FORMAT(S.Sales_Date,'%d-%b-%Y') AS S_Date, D.Barcode, D.Product_Name, D.Qty, D.Sales_Price, D.Sub_Total, S.Grand_Total, S.Disount_Amount FROM tbl_sales_details AS D " & _
                     "INNER JOIN tbl_Sales AS S ON D.Sales_ID=S.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode INNER JOIN tbl_Category AS C ON P.Cat_ID=C.Cat_ID " & _
                     "WHERE C.Cat_Type='Cosmetic' AND (S.Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND S.Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY S.Sales_Date ASC"
            globalFRM = "SalesDetails"

            PrmCategory.Value = "Cosmetic"

        ElseIf rbnMedicine.Checked = True Then
            RptStr = "SELECT DATE_FORMAT(S.Sales_Date,'%d-%b-%Y') AS S_Date, D.Barcode, D.Product_Name, D.Qty, D.Sales_Price, D.Sub_Total, S.Grand_Total, S.Disount_Amount FROM tbl_sales_details AS D " & _
                     "INNER JOIN tbl_Sales AS S ON D.Sales_ID=S.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode INNER JOIN tbl_Category AS C ON P.Cat_ID=C.Cat_ID " & _
                     "WHERE C.Cat_Type='Medicine' AND (S.Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND S.Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY S.Sales_Date ASC"
            globalFRM = "SalesDetails"

            PrmCategory.Value = "Medicine"
        End If


        rptReport.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class