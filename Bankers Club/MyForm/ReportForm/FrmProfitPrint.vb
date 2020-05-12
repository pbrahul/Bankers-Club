Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class FrmProfitPrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(371, 284)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        PrmFormDate.Value = dtpFrom.Value
        PrmToDate.Value = dtpTo.Value

        If rbnAll.Checked = True Then
            RptStr = "SELECT D.Barcode, D.Product_Name, C.Cat_Type, DATE_FORMAT(S.Sales_Date, '%d-%b-%Y') AS SDate, P.Purchase_Price, D.Sales_Price, D.Qty, D.Sub_Total, " & _
                     "D.Profit_Amt FROM tbl_sales_details AS D INNER JOIN tbl_Sales AS S ON D.Sales_ID=S.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode " & _
                     "INNER JOIN tbl_Category AS C ON C.Cat_ID=P.Cat_ID WHERE S.Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND S.Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY S.Sales_Date ASC"
            globalFRM = "Profit_Statement"

        ElseIf rbnCosmetics.Checked = True Then
            RptStr = "SELECT D.Barcode, D.Product_Name, C.Cat_Type, DATE_FORMAT(S.Sales_Date, '%d-%b-%Y') AS SDate, P.Purchase_Price, D.Sales_Price, D.Qty, D.Sub_Total, " & _
                     "D.Profit_Amt FROM tbl_sales_details AS D INNER JOIN tbl_Sales AS S ON D.Sales_ID=S.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode " & _
                     "INNER JOIN tbl_Category AS C ON C.Cat_ID=P.Cat_ID WHERE C.Cat_Type='Cosmetic' AND (S.Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND S.Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY S.Sales_Date ASC"
            globalFRM = "Profit_Details"
            PrmCategory.Value = "Cosmetic"

        ElseIf rbnMedicine.Checked = True Then
            RptStr = "SELECT D.Barcode, D.Product_Name, C.Cat_Type, DATE_FORMAT(S.Sales_Date, '%d-%b-%Y') AS SDate, (SELECT SUM(Disount_Amount) FROM tbl_Sales WHERE Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') AS Disount_Amount, " & _
                     "P.Purchase_Price, D.Sales_Price, D.Qty, D.Sub_Total, D.Profit_Amt FROM tbl_sales_details AS D INNER JOIN tbl_Sales AS S ON D.Sales_ID=S.Sales_ID INNER JOIN tbl_products AS P ON D.Barcode=P.Barcode " & _
                     "INNER JOIN tbl_Category AS C ON C.Cat_ID=P.Cat_ID WHERE C.Cat_Type='Medicine' AND (S.Sales_Date>='" & Format(dtpFrom.Value, "yyyy/MM/dd") & "' AND S.Sales_Date<='" & Format(dtpTo.Value, "yyyy/MM/dd") & "') ORDER BY S.Sales_Date ASC"
            globalFRM = "Profit_Details"
            PrmCategory.Value = "Medicine"
        End If

        With FrmMain
            .btnPannel.Visible = True
            .LoadForm(FrmReports)
        End With

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class