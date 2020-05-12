Imports DevComponents.DotNetBar

Public Class FrmPurchase
    Dim PriceTotal As Double
    Dim scPurchaseProduct As New AutoCompleteStringCollection
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

    Private Sub FrmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(816, 537)

        'SingleComboBox("SELECT Supp_Name FROM tbl_Suppliers ORDER BY Supp_Name ASC", cmbSuppName)
        scPurchaseProduct.Clear()

        SearchAccounts()

        sqlSTR = "SELECT Product_Name FROM tbl_Products ORDER BY Product_name ASC"
        ExecuteSQLQuery(sqlSTR)
        For i As Integer = 0 To sqlDT.Rows.Count - 1
            scPurchaseProduct.Add(sqlDT.Rows(i)("Product_Name"))
        Next

        With txtSearch
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scPurchaseProduct
        End With

        With txtAccounts
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scAccounts
        End With

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            txtBillAddress.Clear()
            txtBalance.Clear()
            txtAccounts.Clear()

            dgvPurchase.Rows.Clear()
            dtpPurchase.Value = Today.Date
            lblTotal.Text = "0.00"
            txtMemo.Text = "N/A"
            txtRemarks.Text = "N/A"
            txtChallen.Text = "N/A"
            txtAccounts.Select()

        Else
            dgvPurchase.Rows.Clear()

            sqlSTR = "SELECT S.Supp_Name, P.Memo_No, DATE_FORMAT(P.Purcahse_Date, '%d-%b-%Y') AS Purchase_Date, P.Remarks, D.Barcode, D.Product_Name, D.Qty, D.Units, D.Item_Price, " & _
                     "D.Total_Price, P.Purchase_Total FROM tbl_Purchase AS P INNER JOIN tbl_Purchase_Details AS D ON P.Purchase_ID = D.Purchase_ID " & _
                     "INNER JOIN tbl_Suppliers AS S ON P.Supp_ID = S.Supp_ID WHERE P.Purchase_ID = '" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                txtMemo.Text = sqlDT.Rows(0)("Memo_No")
                txtRemarks.Text = sqlDT.Rows(0)("Remarks")
                dtpPurchase.Text = sqlDT.Rows(0)("Purcahse_Date")

                For i As Integer = 0 To sqlDT.Rows.Count - 1
                    dgvPurchase.Rows.Add(sqlDT.Rows(i)("Barcode"), sqlDT.Rows(i)("Product_Name"), sqlDT.Rows(i)("Qty"), sqlDT.Rows(i)("Units"), Format(sqlDT.Rows(i)("Item_Price"), "###,###.00"), Format(sqlDT.Rows(i)("Total_Price"), "###,###.00"))
                Next
                lblTotal.Text = Format(sqlDT.Rows(0)("Purchase_Total"), "###,###.00")
                'cmbSuppName.Text = sqlDT.Rows(0)("Supp_Name")
                'cmbSuppName.Enabled = True
            End If
        End If
    End Sub

    Private Sub FrmUserAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Purchase"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text <> "" Then
                sqlSTR = "SELECT Barcode, Product_Name, Units, FORMAT(Purchase_Price, 2) AS 'Purchase_Price' FROM tbl_Products WHERE " & _
                         "Barcode = '" & txtSearch.Text & "' OR Product_Name = '" & txtSearch.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    For Each LI As DataGridViewRow In dgvPurchase.Rows
                        If sqlDT.Rows(0)("Barcode") = LI.Cells(0).Value Then
                            MessageBoxEx.Show("Item already exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        End If
                    Next

                    dgvPurchase.Rows.Add(sqlDT.Rows(0)("Barcode"), sqlDT.Rows(0)("Product_Name"), 1, sqlDT.Rows(0)("Units"), _
                                         Format(CDbl(sqlDT.Rows(0)("Purchase_Price")), "###,###.00"), Format(CDbl(sqlDT.Rows(0)("Purchase_Price")), "###,###.00"))

                    txtSearch.Clear()
                    txtSearch.Select()

                    lblTotal.Text = Format(GridTotal(dgvPurchase, 5), "###,###.00")
                Else
                    MessageBoxEx.Show("Products not found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txtAccounts_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccounts.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtAccounts.Text <> "" Then
                sqlSTR = "SELECT A.AC_ID, A.Ac_Name, A.Contact_No, C.Type_Details, A.Bal_Amt FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS C ON A.Type_ID=C.Type_ID WHERE A.Ac_Name = '" & txtAccounts.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    SuppID = sqlDT.Rows(0)("Ac_ID")
                    txtBillAddress.Text = sqlDT.Rows(0)("Ac_Name") & vbNewLine & sqlDT.Rows(0)("Type_Details") & vbNewLine & sqlDT.Rows(0)("Contact_No")
                    txtBalance.Text = Format(sqlDT.Rows(0)("Bal_Amt"), "###,###.00")
                    txtSearch.Clear()
                    txtSearch.Select()
                Else
                    MessageBoxEx.Show("Result not found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub dgrPurchase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPurchase.CellEndEdit
        If dgvPurchase.Rows.Count > 0 Then
            If dgvPurchase.CurrentCell.ColumnIndex = 2 Or dgvPurchase.CurrentCell.ColumnIndex = 4 Then
                'sqlSTR = "SELECT TOP 1 Rate_ID, Taka FROM tbl_Rate ORDER BY Rate_ID DESC"
                'ExecuteSQLQuery(sqlSTR)
                PriceTotal = CDbl(dgvPurchase.CurrentRow.Cells(2).Value) * CDbl(dgvPurchase.CurrentRow.Cells(4).Value)
                dgvPurchase.CurrentRow.Cells(5).Value = Format(PriceTotal, "###,###.00")
                lblTotal.Text = Format(GridTotal(dgvPurchase, 5), "###,###.00")
            End If
        End If
    End Sub

    Private Sub dgvCollection_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvPurchase.EditingControlShowing
        If dgvPurchase.CurrentCell.ColumnIndex = 2 Or dgvPurchase.CurrentCell.ColumnIndex = 4 And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)

            '---add an event handler to the TextBox control---
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
            'AddHandler tb.TextChanged, AddressOf Textbox_TextChanged
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

    Private Sub dgrPurchase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvPurchase.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvPurchase.SelectedCells.Count > 0 Then
                'If Split(Me.Text, " - ")(1) = "Edit" Then
                If MessageBoxEx.Show("Do you want to delete this record ???", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    dgvPurchase.Rows.Remove(dgvPurchase.CurrentRow)
                    lblTotal.Text = Format(GridTotal(dgvPurchase, 5), "###,###.00")

                    'If dgvPurchase.RowCount = 0 Then
                    '    cmbSuppName.Enabled = True
                    'End If
                End If
                'Else
                '    dgrPurchase.Rows.Remove(dgrPurchase.CurrentRow)
                '    lblTotal.Text = Format(GridTotal(dgrPurchase, 5), "###,###.00")
                'End If
            End If
        End If
    End Sub

    Private Sub dgrPurchase_RowsAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs)
        'cmbSuppName.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'FrmSupplierPayment.ShowDialog()
        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If txtBillAddress.Text = "" Then
            txtAccounts.Select()
            Exit Sub
        End If

        If dgvPurchase.Rows.Count = 0 Then
            MessageBoxEx.Show("No product added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            If chkApproved.Checked = True Then
                With FrmPurchasePayment
                    .lblPurchaseAmt.Text = Format(CDbl(lblTotal.Text), "###,###.00")
                    .lblDueAmt.Text = Format(CDbl(txtBalance.Text), "###,###.00")
                    .lblGrandTotalAmt.Text = Format(CDbl(-lblTotal.Text) + CDbl(txtBalance.Text), "###,###.00")
                    .ShowDialog()

                End With
                'Exit Sub
            Else
                'GetID = AutoIDPreFix("tbl_Purchase", "Purchase_ID", PreFix)

                ''SuppID = sqlDT.Rows(0)("Supp_ID")

                'sqlSTR = "INSERT INTO tbl_Purchase(Purchase_ID, Supp_ID, Memo_No, Purcahse_Date, Approved, Approved_By, Purchase_Total, Remarks, Challen_No, User_ID) " & _
                '         "VALUES ('" & GetID & "', '" & SuppID & "', '" & txtMemo.Text & "', '" & Format(dtpPurchase.Value, "yyyy/MM/dd") & "', '" & IIf(chkApproved.Checked = True, "Yes", "No") & _
                '         "', '" & IIf(chkApproved.Checked = True, UserName, "") & "', " & CDbl(lblTotal.Text) & ", '" & txtRemarks.Text & "', '" & txtChallen.Text & "', '" & UserID & "')"
                'ExecuteSQLQuery(sqlSTR)

                'For Each LI As DataGridViewRow In dgvPurchase.Rows
                '    sqlSTR = "INSERT INTO tbl_Purchase_Details(Barcode, Product_Name, Qty, Units, Item_Price, Total_Price, Purchase_ID) " & _
                '             "VALUES ('" & LI.Cells(0).Value & "', '" & LI.Cells(1).Value & "', '" & LI.Cells(2).Value & "', '" & LI.Cells(3).Value & _
                '             "', " & CDbl(LI.Cells(4).Value) & ", " & CDbl(LI.Cells(5).Value) & ", '" & GetID & "')"
                '    ExecuteSQLQuery(sqlSTR)
                'Next

                GetID = YearIDPreFix("tbl_Purchase", "Purchase_ID", PreFix)

                sqlSTR = "INSERT INTO tbl_Purchase(Purchase_ID, Ac_ID, Memo_No, Purcahse_Date, Approved, Approved_By, Purchase_Total, Remarks, Challen_No, User_ID) " & _
                         "VALUES ('" & GetID & "', '" & SuppID & "', '" & txtMemo.Text & "', '" & Format(dtpPurchase.Value, "yyyy/MM/dd") & "', '" & IIf(chkApproved.Checked = True, "Yes", "No") & _
                         "', '" & IIf(chkApproved.Checked = True, UserName, "") & "', " & CDbl(lblTotal.Text) & ", '" & txtRemarks.Text & "', '" & txtChallen.Text & "', '" & UserID & "')"
                ExecuteSQLQuery(sqlSTR)

                For Each LI As DataGridViewRow In dgvPurchase.Rows
                    sqlSTR = "INSERT INTO tbl_Purchase_Details(Barcode, Product_Name, Qty, Units, Item_Price, Total_Price, Purchase_ID) VALUES ('" & LI.Cells(0).Value & _
                             "', '" & LI.Cells(1).Value & "', " & CDbl(LI.Cells(2).Value) & ", '" & LI.Cells(3).Value & "', " & CDbl(LI.Cells(4).Value) & ", " & CDbl(LI.Cells(5).Value) & ", '" & GetID & "')"
                    ExecuteSQLQuery(sqlSTR)
                Next

                MessageBoxEx.Show("Record Save Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                FrmPurchaseList.RefreshPurchase()
            End If
        Else
            If chkApproved.Checked = False Then
                MessageBoxEx.Show("Please Select Approved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                FrmPurchasePayment.ShowDialog()
            End If
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        FormShow(FrmAccountsAdd, False, 0)
    End Sub


End Class