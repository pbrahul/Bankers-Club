Imports DevComponents.DotNetBar
Imports System.Drawing.Printing

Public Class FrmSales
    Dim VatAmount, TotalVat, PrdTotal, Purchase_Price As Double
    Dim VatUse As String
    Dim xStock As Integer
    Dim ProductFound As Boolean
    Dim ProductDiscout As Double
    Dim iz As Integer
    Dim scSalesProduct As New AutoCompleteStringCollection
    Dim scAccounts As New AutoCompleteStringCollection

    Public Sub SearchAccounts()
        scAccounts.Clear()

        sqlSTR = "SELECT A.Ac_Name FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID " & _
         "WHERE C.Type_Details<>'Expense' ORDER BY A.Ac_Name ASC"
        ExecuteSQLQuery(sqlSTR)
        For i As Integer = 0 To sqlDT.Rows.Count - 1
            scAccounts.Add(sqlDT.Rows(i)("Ac_Name"))
        Next

    End Sub

    Public Sub TotalAmount()
        lblSubTotal.Text = Format(GridTotal(dgvSales, 7), "###,###.00")
        lblVat.Text = Format(GridTotal(dgvSales, 6), "###,###.00")
        lblDiscount.Text = Format(GridTotal(dgvSales, 5), "###,###.00")
        lblLabour.Text = Format(GridTotal(dgvSales, 2) * 0, "###,###.00")
        lblGrandTotal.Text = Format(Math.Round(CDbl(lblSubTotal.Text) + CDbl(lblVat.Text) + CDbl(lblLabour.Text) - CDbl(lblDiscount.Text)), "###,###.00")
        GrandTotal = CDbl(lblSubTotal.Text) + CDbl(lblVat.Text) + CDbl(lblLabour.Text) - CDbl(lblDiscount.Text)
    End Sub

    Private Sub FrmUserView_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpUser.Width = FrmMain.Width - 200
        grpUser.Height = FrmMain.Height - 200
        grpUser.Location = New Point(100, 30)

        dgvSales.Width = grpUser.Width - 40
        dgvSales.Height = grpUser.Height - 180
        TableLayoutPanel1.Width = grpUser.Width - 40

        panButton.Top = dgvSales.Bottom + 7
        panButton.Left = dgvSales.Right - 330

        lblReach.Top = (Me.Height) - 82
        lblReach.Left = (Me.Width / 2) - 240

        lblDate.Left = dgvSales.Left + 90
        lblDate.Top = grpUser.Bottom + 10

        lblTime.Left = dgvSales.Right - 5
        lblTime.Top = grpUser.Bottom + 10

        lblGrandTotal.Left = (dgvSales.Width / 2) - 90
        lblGrandTotal.Top = grpUser.Height - 53

        Label1.Left = (dgvSales.Width / 2) - 90
        Label1.Top = grpUser.Height - 75

        Label2.Left = dgvSales.Left + 10
        Label2.Top = grpUser.Height - 90

        lblSubTotal.Left = dgvSales.Left + 105
        lblSubTotal.Top = grpUser.Height - 85

        'Label3.Left = dgvSales.Left + 10
        'Label3.Top = grpUser.Height - 65

        'lblDiscount.Left = dgvSales.Left + 105
        'lblDiscount.Top = grpUser.Height - 35

        'Label6.Left = dgvSales.Left + 17
        'Label6.Top = grpUser.Height - 65

        'lblLabour.Left = dgvSales.Left + 105
        'lblLabour.Top = grpUser.Height - 60


        lblVat.Left = dgvSales.Left + 105
        lblVat.Top = grpUser.Height - 60

        Label4.Left = dgvSales.Left + 17
        Label4.Top = grpUser.Height - 65
    End Sub

    Private Sub btnHold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHold.Click
        Dim Frm As New FrmSales
        Frm.MdiParent = FrmMain
        Frm.btnHold.Enabled = False
        Frm.btnCancel.Text = "Close"
        Frm.Show()
    End Sub

    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        'FrmSalesPayment.ShowDialog()
        If dgvSales.Rows.Count > 0 Then
            If CustID = "" Then
                txtCustomer.Clear()
                txtCustomer.Select()
            Else
                With FrmSalesCustPay
                    .lblPurchaseAmt.Text = Format(CDbl(lblGrandTotal.Text), "###,###.00")
                    .lblDueAmt.Text = Format(CDbl(txtCustBal.Text), "###,###.00")
                    .lblGrandTotalAmt.Text = Format(CDbl(lblGrandTotal.Text) + CDbl(txtCustBal.Text), "###,###.00")
                    .ShowDialog()
                End With
            End If


            'If CustID = "C-1001" Then
            '    If cmbType.SelectedIndex = 1 Then
            '        'If StockPass = True Then
            '        '    sqlSTR = "SELECT Paid_Amount FROM TBL_Orders WHERE Order_No='" & txtBarcode.Text & "'"
            '        '    ExecuteSQLQuery(sqlSTR)
            '        '    .TotalAmount = Math.Round(CDbl(txtamountdue.Text) - CDbl(sqlDT.Rows(0)("Paid_Amount")))
            '        '    '.TotalAmount = Math.Round(CDbl(txtamountdue.Text))
            '        '    .lblAmountDue.Text = Format(Math.Round(CDbl(txtamountdue.Text) - CDbl(sqlDT.Rows(0)("Paid_Amount"))), "###,###.00")
            '        '    .Discount = 0
            '        '    .txtDiscount.Clear()
            '        'Else
            '        '    MsgBox("This order can't submitted." & vbNewLine & "Beacuse Insufficient Stock Balance.", MsgBoxStyle.Information, "Information")
            '        '    Exit Sub
            '        'End If
            '    Else
            '        GrandTotal = Math.Round(CDbl(lblGrandTotal.Text))
            '        FrmSalesPayment.ShowDialog()
            '    End If
            'Else
            '    With FrmSalesCustPay
            '        .lblPurchaseAmt.Text = Format(CDbl(lblGrandTotal.Text), "###,###.00")
            '        .lblDueAmt.Text = Format(CDbl(txtCustBal.Text), "###,###.00")
            '        .lblGrandTotalAmt.Text = Format(CDbl(lblGrandTotal.Text) + CDbl(txtCustBal.Text), "###,###.00")
            '        .ShowDialog()
            '    End With
            'End If

        Else
            txtBarcode.Select()
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "Cancel" Then
            cmbType.SelectedIndex = 0

            sqlSTR = "SELECT A.AC_ID, A.Ac_Name, A.Contact_No, C.Type_Details, A.Bal_Amt FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID WHERE A.Ac_ID = 'C-1001'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                CustID = sqlDT.Rows(0)("Ac_ID")
                txtBillAddress.Text = sqlDT.Rows(0)("Ac_Name") '& vbNewLine & sqlDT.Rows(0)("Type_Details") & vbNewLine & sqlDT.Rows(0)("Contact_No")
                txtCustBal.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
            End If

            lblSubTotal.Text = "0.00"
            lblDiscount.Text = "0.00"
            lblVat.Text = "0.00"
            lblGrandTotal.Text = "0.00"
            lblLabour.Text = "0.00"
            txtMemo.Text = "N/A"
            dgvSales.Rows.Clear()
            txtBarcode.Select()
        ElseIf btnCancel.Text = "Close" Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormShow(FrmCustomer, False, 0)
    End Sub

    Private Sub FrmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbType.SelectedIndex = 0

        SearchAccounts()

        With txtCustomer
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scAccounts
        End With

        ExecuteSQLQuery("SELECT * FROM tbl_VAT")
        If sqlDT.Rows.Count > 0 Then
            VatUse = sqlDT.Rows(0)("Use_Vat")
            VatAmount = sqlDT.Rows(0)("Vat_Amount")
        End If

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

        sqlSTR = "SELECT S.Barcode, S.Product_Name, S.Qty, P.Reorder_Label FROM tbl_Stock_Products AS S INNER JOIN tbl_Products AS P " & _
                 "ON S.Barcode = P.Barcode WHERE S.Qty <= P.Reorder_Label"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            'lblReach.BackColor = Color.Transparent
            lblReach.ForeColor = Color.Red
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If

        sqlSTR = "SELECT A.AC_ID, A.Ac_Name, A.Contact_No, C.Type_Details, A.Bal_Amt FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID WHERE A.Ac_ID = 'C-1001'"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            CustID = sqlDT.Rows(0)("Ac_ID")
            txtBillAddress.Text = sqlDT.Rows(0)("Ac_Name") '& ", " & sqlDT.Rows(0)("Type_Details") & ", " & sqlDT.Rows(0)("Contact_No")
            txtCustBal.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
        End If


        txtMemo.Text = "N/A"
        txtCustomer.Select()
        'txtBarcode.Select()

    End Sub

    Private Sub txtBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If cmbType.SelectedIndex = 0 And txtBarcode.Text <> "" Then
                xStock = 0
                ProductFound = False

                sqlSTR = "SELECT P.Barcode, P.Product_Name, P.Units, P.Sales_Price, P.Purchase_Price, P.Reorder_Label, 0 AS Vat, S.Qty, 0 AS Discount FROM tbl_Products AS P " & _
                         "INNER JOIN tbl_Stock_Products AS S ON P.Barcode = S.Barcode WHERE P.Barcode = '" & txtBarcode.Text & "' OR P.Product_Name='" & txtBarcode.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    If VatUse = "Yes" Then
                        VatAmount = VatAmount
                    Else
                        VatAmount = sqlDT.Rows(0)("Vat")
                    End If

                    ProductDiscout = (sqlDT.Rows(0)("Sales_Price") * sqlDT.Rows(0)("Discount")) / 100
                    TotalVat = (sqlDT.Rows(0)("Sales_Price") * VatAmount) / 100
                    PrdTotal = sqlDT.Rows(0)("Sales_Price") ' (sqlDT.Rows(0)("Sales_Price") + TotalVat) - ProductDiscout
                    Purchase_Price = sqlDT.Rows(0)("Purchase_Price")
                    With dgvSales
                        For i = 0 To .Rows.Count - 1
                            'MsgBox(lstItems.Items(i).Text)
                            If UCase(.Rows(i).Cells(0).Value) = UCase(sqlDT.Rows(0)("Barcode")) Then
                                ProductFound = True
                                xStock = .Rows(i).Cells(2).Value
                            End If
                        Next
                    End With

                    If (CDbl(sqlDT.Rows(0)("QTY")) - CDbl(xStock)) <= 0 Then
                        MessageBoxEx.Show("Insufficient number of stocks !! " & Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("QTY"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    ElseIf sqlDT.Rows(0)("Qty") = 0 Then
                        MessageBoxEx.Show("Insufficient number of stocks !! " & Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("QTY"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    Else
                        If ProductFound = False Then
                            dgvSales.Rows.Add(sqlDT.Rows(0)("Barcode"), sqlDT.Rows(0)("Product_Name"), 1, sqlDT.Rows(0)("Units"), Format(sqlDT.Rows(0)("Sales_Price"), "###,###.00"), _
                                              Format(ProductDiscout, "###,###.00"), Format(TotalVat, "###,###.00"), Format(PrdTotal, "###,###.00"), Format(sqlDT.Rows(0)("Purchase_Price"), "###,###.00"))
                        Else
                            For i = 0 To dgvSales.Rows.Count - 1
                                'MsgBox(lstItems.Items(i).Text)
                                If UCase(dgvSales.Rows(i).Cells(0).Value) = UCase(sqlDT.Rows(0)("Barcode")) Then
                                    dgvSales.Rows(i).Cells(2).Value = dgvSales.Rows(i).Cells(2).Value + 1
                                    dgvSales.Rows(i).Cells(5).Value = Format(ProductDiscout * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                    dgvSales.Rows(i).Cells(6).Value = Format(TotalVat * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                    dgvSales.Rows(i).Cells(7).Value = Format(PrdTotal * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                    dgvSales.Rows(i).Cells(8).Value = Format(Purchase_Price * dgvSales.Rows(i).Cells(2).Value, "###,###.00")
                                End If
                            Next
                        End If
                        TotalAmount()
                    End If
                Else
                    MessageBoxEx.Show("Product Not Found. Please Enter Correct Barcode !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            ElseIf cmbType.SelectedIndex = 1 And txtBarcode.Text <> "" Then
                MessageBoxEx.Show("Order No Not Found. Please Enter Correct Order No !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            txtBarcode.Clear()
            txtBarcode.Select()
        End If
    End Sub

    Private Sub txtCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCustomer.Text <> "" Then
                sqlSTR = "SELECT A.AC_ID, A.Ac_Name, A.Contact_No, C.Type_Details, A.Bal_Amt FROM tbl_Accounts AS A " & _
                         "INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID WHERE A.Ac_ID = '" & txtCustomer.Text & "' OR A.AC_Name='" & txtCustomer.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    CustID = sqlDT.Rows(0)("Ac_ID")
                    txtBillAddress.Text = sqlDT.Rows(0)("Ac_Name") '& vbNewLine & sqlDT.Rows(0)("Type_Details") & vbNewLine & sqlDT.Rows(0)("Contact_No")
                    txtCustBal.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
                    txtBarcode.Clear()
                    txtBarcode.Select()
                Else
                    CustID = ""
                    txtBillAddress.Clear()
                    txtCustBal.Clear()
                    txtCustomer.Select()

                    MessageBoxEx.Show("Result not found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub dgvSales_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSales.CellEndEdit
        If dgvSales.CurrentCell.ColumnIndex = 2 Then
            sqlSTR = "SELECT P.Sales_Price, Purchase_Price, 0 AS Vat, S.Qty, 0 AS Discount FROM tbl_Products AS P INNER JOIN tbl_Stock_Products AS S " & _
                     "ON P.Barcode = S.Barcode WHERE P.Barcode = '" & dgvSales.CurrentRow.Cells(0).Value & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                ProductDiscout = (sqlDT.Rows(0)("Sales_Price") * sqlDT.Rows(0)("Discount")) / 100
                TotalVat = (sqlDT.Rows(0)("Sales_Price") * VatAmount) / 100
                'PrdTotal = sqlDT.Rows(0)("Sales_Price") ' (sqlDT.Rows(0)("Sales_Price") + TotalVat) - ProductDiscout
                PrdTotal = dgvSales.CurrentRow.Cells(4).Value
                Purchase_Price = sqlDT.Rows(0)("Purchase_Price")

                If CDbl(dgvSales.CurrentRow.Cells(2).Value) > CDbl(sqlDT.Rows(0)("QTY")) Then
                    MessageBoxEx.Show("Insufficient number of stocks !! " & Chr(10) & "Current Stocks : " & sqlDT.Rows(0)("QTY"), "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    dgvSales.CurrentRow.Cells(2).Value = sqlDT.Rows(0)("QTY")
                    dgvSales.CurrentRow.Cells(5).Value = Format(ProductDiscout * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(6).Value = Format(TotalVat * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(7).Value = Format(PrdTotal * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(8).Value = Format(Purchase_Price * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    TotalAmount()

                    Exit Sub
                Else
                    dgvSales.CurrentRow.Cells(5).Value = Format(ProductDiscout * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(6).Value = Format(TotalVat * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(7).Value = Format(PrdTotal * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    dgvSales.CurrentRow.Cells(8).Value = Format(Purchase_Price * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                    TotalAmount()
                End If
            End If

        ElseIf dgvSales.CurrentCell.ColumnIndex = 4 Then
            sqlSTR = "SELECT P.Sales_Price, P.Vat, S.Qty, 0 AS Discount " & _
                     "FROM tbl_Products AS P INNER JOIN tbl_Stock_Products AS S ON P.Barcode = S.Barcode WHERE P.Barcode = '" & dgvSales.CurrentRow.Cells(0).Value & "'"
            ExecuteSQLQuery(sqlSTR)

            If sqlDT.Rows.Count > 0 Then
                ProductDiscout = (sqlDT.Rows(0)("Sales_Price") * sqlDT.Rows(0)("Discount")) / 100
                TotalVat = (sqlDT.Rows(0)("Sales_Price") * VatAmount) / 100
                'PrdTotal = sqlDT.Rows(0)("Sales_Price") ' (sqlDT.Rows(0)("Sales_Price") + TotalVat) - ProductDiscout

                dgvSales.CurrentRow.Cells(5).Value = Format(ProductDiscout * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                dgvSales.CurrentRow.Cells(6).Value = Format(TotalVat * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                dgvSales.CurrentRow.Cells(7).Value = Format(CDbl(dgvSales.CurrentRow.Cells(4).Value) * dgvSales.CurrentRow.Cells(2).Value, "###,###.00")
                TotalAmount()
            End If

        End If
    End Sub

    Private Sub dgvSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvSales.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MessageBoxEx.Show("Do you want to delete this product ??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                dgvSales.Rows.Remove(dgvSales.CurrentRow)
                TotalAmount()
                txtBarcode.Select()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        iz = iz + 1
        If (iz Mod 2) = 0 Then
            lblReach.Visible = False
        Else
            lblReach.Visible = True
        End If
    End Sub

    Private Sub dgvCollection_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvSales.EditingControlShowing
        If dgvSales.CurrentCell.ColumnIndex = 2 And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)

            '---add an event handler to the TextBox control---
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 46 Then
            If Asc(e.KeyChar) = 46 Then
                If CType(sender, TextBox).Text.Contains(Chr(46)) Then
                    e.Handled = True
                Else
                    e.Handled = False
                End If
            Else
                e.Handled = False
            End If
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FormShow(FrmAccountsAdd, False, 0)
    End Sub
End Class