Imports DevComponents.DotNetBar

Module ModActiveForm
    Public globalID ' PASS AND USED CURRENT ID, THE MAIN PURPOSE IS TO STORE THE ID
    Public globalID2
    Public globalFRM ' PASS AND USED CURRENT FORM NAME, MAIN PURPOSE IS TO GET THE CURRENT OPEN FORMS


    Public Function ConInfo(ByVal lstItem As DataGridView) As Boolean
        If lstItem.SelectedRows.Count > 0 Then
            ConInfo = True
        Else
            ConInfo = False
            MessageBoxEx.Show("No Record Select For Edit. Please Select one!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If
    End Function

    Public Function ConPrint(ByVal lstItem As DataGridView) As Boolean
        If lstItem.SelectedRows.Count > 0 Then
            ConPrint = True
        Else
            ConPrint = False
            MessageBoxEx.Show("No Record Select For Print. Please Select One!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If
    End Function

    Public Function ConfirmDelete(ByVal lstItem As DataGridView) As Boolean
        If lstItem.SelectedRows.Count > 0 Then
            If MessageBoxEx.Show("Do you want to delete this record ???", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                ConfirmDelete = True
            Else
                Exit Function
            End If
        Else
            ConfirmDelete = False
            MessageBoxEx.Show("No Record Select For Delete. Please Select One!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        End If
    End Function


    Public Sub xclose()
        Dim oFrm As Form
        For Each oFrm In FrmMain.MdiChildren
            'MsgBox(oFrm.Name)
            If oFrm.Name <> "FrmBG" And Not (TypeOf oFrm Is FrmMain) Then oFrm.Close()
        Next
    End Sub


    Public Sub FormShow(ByVal FrmShow As Form, ByVal ShowEdit As Boolean, ByVal CurrentID As String)
        If ShowEdit = True Then
            FrmShow.Text = FrmShow.Text & " - Edit"
            EditID = CurrentID ' pass current ID
        Else
            FrmShow.Text = FrmShow.Text & " - Add"
        End If
        FrmShow.ShowDialog()
    End Sub


    Public Sub FormClose(ByVal FrmName As Form)
        With FrmMain
            FrmName.Close()
            If UCase(FrmName.Name) = UCase("frmreports") Then
                FrmName.Close()
            ElseIf UCase(FrmName.Name) = UCase("frmreportsdated") Then
                FrmName.Close()
            End If
            ButtonActivated(.ActiveMdiChild)
        End With
    End Sub


    Public Sub NewFrm(ByVal FrmName As String)
        Select Case UCase(FrmName)
            Case UCase("FrmUserView")
                FormShow(FrmUserAdd, False, 0)

            Case UCase("FrmMemberDetails")
                With FrmMemberDetails
                    If .tabMain.SelectedTabIndex = 0 Then
                        .tabMain.SelectedTabIndex = 1
                        .RefreshMember()
                        .txtName.Select()
                    End If
                End With

            Case UCase("FrmCashBank")
                FormShow(FrmCashBankAdd, False, 0)

            Case UCase("FrmAllAccounts")
                FormShow(FrmAccountsAdd, False, 0)

            Case UCase("FrmCollectionList")
                With FrmCollectionList
                    If .tabMain.SelectedTabIndex = 0 Then
                        FormShow(FrmCollection, False, 0)
                    Else
                        FormShow(FrmCollectionOthers, False, 0)
                    End If
                End With

            Case UCase("FrmPaymentList")
                FormShow(FrmPayment, False, 0)

            Case UCase("FrmTransferList")
                FormShow(FrmTransfer, False, 0)

            Case UCase("FrmAssetList")
                FormShow(FrmAsset, False, 0)

            Case UCase("FrmReturnList")
                FormShow(FrmPurchaseReturn, False, 0)

            Case UCase("FrmDefectiveList")
                FormShow(FrmDefective, False, 0)

            Case UCase("FrmSupplierPaymentDetails")
                FormShow(FrmSupplierPaid, False, 0)

            Case UCase("FrmCustomerPaymentDetails")
                FormShow(FrmCustomerPayment, False, 0)

            Case UCase("FrmExpenseList")
                FormShow(FrmExpense, False, 0)

            Case UCase("FrmEmployeeList")
                FormShow(FrmEmployee, False, 0)

            Case UCase("FrmEmployeeSalaryDetails")
                FormShow(FrmEmployeeSalary, False, 0)


        End Select
    End Sub


    Public Sub EditFrm(ByVal FrmName As String)
        Select Case UCase(FrmName)
            Case UCase("FrmProductsList")
                With FrmProductsList
                    If .rbnCategory.Checked = True Then
                        If ConInfo(.dgvCategory) = True Then
                            FormShow(FrmCategory, True, .dgvCategory.SelectedRows(0).Cells(0).Value)
                        End If

                    ElseIf .rbnProducts.Checked = True Then
                        If ConInfo(.dgvProduct) = True Then
                            FormShow(FrmBrandProducts, True, .dgvProduct.SelectedRows(0).Cells(0).Value)
                        End If

                    End If
                End With

            Case UCase("FrmMemberDetails")
                With FrmMemberDetails
                    If .tabMain.SelectedTabIndex = 0 Then
                        If ConInfo(.dgvMemberList) = True Then
                            .tabMain.SelectedTabIndex = 2
                            EditID = .dgvMemberList.SelectedRows(0).Cells(1).Value
                            sqlSTR = "SELECT Mem_ID, Mem_Name, Mem_Father, Mem_Mother, Mem_Spouse, Pre_Address, Per_Address, DOB, Mem_Sex, Mem_Contact, Mem_Email, Near_Contact, Nat_ID, Passport, Marriage_Day, Mem_Picture, " & _
                                     "Mem_Type, Entry_Date, Bank_Name, Branch, Bank_Designation, Join_Date, Mem_Status FROM tbl_Member WHERE Mem_ID = '" & EditID & "'"
                            ExecuteSQLQuery(sqlSTR)

                            .EditShow()

                            .txtSearchEx.Select()
                        End If
                    End If
                End With

            Case UCase("FrmCashBank")
                With FrmCashBank
                    If ConInfo(.dgvCash) = True Then
                        If .dgvCash.SelectedRows(0).Cells(0).Value = "B-1001" Then
                            MessageBoxEx.Show("Selected cash isn't editable. ", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            FormShow(FrmCashBankAdd, True, .dgvCash.SelectedRows(0).Cells(0).Value)
                        End If
                    End If
                End With

            Case UCase("FrmAllAccounts")
                With FrmAllAccounts
                    If ConInfo(.dgvCustomers) = True Then
                        If .dgvCustomers.SelectedRows(0).Cells(0).Value = "C-1001" Or .dgvCustomers.SelectedRows(0).Cells(0).Value = "S-1001" Then
                            MessageBoxEx.Show("Selected accounts isn't editable. ", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            FormShow(FrmAccountsAdd, True, .dgvCustomers.SelectedRows(0).Cells(0).Value)
                        End If
                    End If
                End With


            Case UCase("FrmSupplierList")
                With FrmSupplierList
                    If ConInfo(.dgvSuppliers) = True Then
                        FormShow(FrmSupplier, True, .dgvSuppliers.SelectedRows(0).Cells(0).Value)
                    End If

                End With

            Case UCase("FrmPurchaseList")
                With FrmPurchaseList
                    If ConInfo(.dgvPurchase) = True Then
                        If .dgvPurchase.SelectedRows(0).Cells(4).Value = "Yes" Then
                            MessageBoxEx.Show("Purchase product is approved. It's can't edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            FormShow(FrmPurchase, True, .dgvPurchase.SelectedRows(0).Cells(0).Value)
                        End If
                    End If
                End With


            Case UCase("FrmCustomerList")
                With FrmAllAccounts
                    If ConInfo(.dgvCustomers) = True Then
                        If .dgvCustomers.Rows(0).Selected = True Then
                            MessageBoxEx.Show("This customer is not editable. Select another customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit Sub
                        Else
                            FormShow(FrmCustomer, True, .dgvCustomers.SelectedRows(0).Cells(0).Value)
                        End If
                    End If

                End With

            Case UCase("FrmEmployeeList")
                With FrmEmployeeList
                    If ConInfo(.dgvCustomers) = True Then
                        FormShow(FrmEmployee, True, .dgvCustomers.SelectedRows(0).Cells(0).Value)
                    End If
                End With

            Case UCase("FrmExpenseList")
                With FrmExpenseList
                    If ConInfo(.dgvExpense) = True Then
                        FormShow(FrmExpense, True, .dgvExpense.SelectedRows(0).Cells(0).Value)
                    End If
                End With


            Case UCase("FrmUserView")
                With FrmUserView
                    If ConInfo(.dgvUser) = True Then
                        FormShow(FrmUserAdd, True, .dgvUser.SelectedRows(0).Cells(0).Value)
                    End If
                End With




        End Select
    End Sub


    Public Sub DeleteFrm(ByVal FrmName As String)
        Dim SelectDate As Date
        Dim Debit_Amt, Credit_Amt As Double
        Dim Ac_ID, Ledger_ID As String

        Select Case UCase(FrmName)
            Case UCase("FrmProductsList")
                With FrmProductsList
                    If .rbnCategory.Checked = True Then
                        If ConfirmDelete(.dgvCategory) = True Then
                            sqlSTR = "SELECT Cat_ID FROM tbl_Products WHERE Cat_ID ='" & .dgvCategory.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                MessageBoxEx.Show("This category is currently used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                sqlSTR = "DELETE FROM tbl_Product_Category WHERE Cat_ID ='" & .dgvCategory.SelectedRows(0).Cells(0).Value & "'"
                                ExecuteSQLQuery(sqlSTR)
                                .RefreshProducts()
                            End If
                        End If

                    ElseIf .rbnProducts.Checked = True Then
                        If ConfirmDelete(.dgvProduct) = True Then
                            sqlSTR = "SELECT Barcode FROM tbl_stock_products WHERE Barcode ='" & .dgvProduct.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                MessageBoxEx.Show("This Product is currently used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                sqlSTR = "DELETE FROM tbl_Products WHERE Barcode ='" & .dgvProduct.SelectedRows(0).Cells(0).Value & "'"
                                ExecuteSQLQuery(sqlSTR)
                                .RefreshProducts()
                            End If
                        End If
                    End If

                End With

            Case UCase("FrmCashBank")
                With FrmCashBank
                    If .dgvCash.SelectedRows(0).Cells(0).Value = "B-1001" Then
                        MessageBoxEx.Show("Select cash isn't delete. ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        If ConfirmDelete(.dgvCash) = True Then
                            sqlSTR = "SELECT Cash_ID FROM tbl_Cashbank_Ledger WHERE Cash_ID ='" & .dgvCash.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                MessageBoxEx.Show("Selected Cash is currently used.. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                sqlSTR = "DELETE FROM tbl_CashBank WHERE Cash_ID ='" & .dgvCash.SelectedRows(0).Cells(0).Value & "'"
                                ExecuteSQLQuery(sqlSTR)
                                .RefreshCashBank()
                            End If
                        End If
                    End If
                End With

            Case UCase("FrmAllAccounts")
                With FrmAllAccounts
                    If .dgvCustomers.SelectedRows(0).Cells(0).Value = "C-1001" Or .dgvCustomers.SelectedRows(0).Cells(0).Value = "S-1001" Then
                        MessageBoxEx.Show("Select Account isn't delete. ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        If ConfirmDelete(.dgvCustomers) = True Then
                            sqlSTR = "SELECT Ac_ID FROM tbl_Ac_ledger WHERE AC_ID ='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)
                            If sqlDT.Rows.Count > 0 Then
                                MessageBoxEx.Show("Selected Account is currently used.. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit Sub
                            Else
                                sqlSTR = "DELETE FROM tbl_Accounts WHERE AC_ID ='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                                ExecuteSQLQuery(sqlSTR)
                                .RefreshAccounts()
                            End If
                        End If
                    End If
                End With

            Case UCase("FrmPurchaseList")
                With FrmPurchaseList
                    If ConfirmDelete(.dgvPurchase) = True Then
                        If .dgvPurchase.SelectedRows(0).Cells(4).Value = "No" Then
                            sqlSTR = "DELETE FROM tbl_Purchase_Details WHERE Purchase_ID ='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Purchase WHERE Purchase_ID ='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                        ElseIf .dgvPurchase.SelectedRows(0).Cells(4).Value = "Yes" Then
                            sqlSTR = "SELECT Ledger_ID, Ac_ID, Cash_ID, Ledger_Date, Debit_Amt, Credit_Amt FROM tbl_Ac_Ledger WHERE Purchase_ID='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            If sqlDT.Rows.Count > 0 Then
                                SelectDate = sqlDT.Rows(0)("Ledger_Date")
                                Debit_Amt = sqlDT.Rows(0)("Debit_Amt")
                                Ac_ID = sqlDT.Rows(0)("Ac_ID")
                            Else
                                Debit_Amt = 0
                            End If

                            If sqlDT.Rows.Count > 1 Then
                                Credit_Amt = sqlDT.Rows(1)("Credit_Amt")
                                Cash_ID = sqlDT.Rows(1)("Cash_ID")
                                Ledger_ID = sqlDT.Rows(1)("Ledger_ID")
                            Else
                                Credit_Amt = 0
                                Cash_ID = 0
                                Ledger_ID = 0
                            End If


                            '========== tbl_Ac_Ledger =============
                            sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & Ac_ID & "' AND Ledger_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt+" & (CDbl(Debit_Amt) - CDbl(Credit_Amt)) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = Bal_Amt+" & (CDbl(Debit_Amt) - CDbl(Credit_Amt)) & " WHERE Ac_ID = '" & Ac_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_CashBank ============
                            sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt+" & CDbl(Credit_Amt) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt+ " & CDbl(Credit_Amt) & " WHERE Cash_ID = '" & Cash_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_Balance ===========
                            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(Credit_Amt) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                                GetSQLQuery(sqlSTR)
                            Next


                            '============= tbl_Product_History ===========
                            For Each LI As DataGridViewRow In .dgvProduct.Rows
                                sqlSTR = "SELECT Hy_ID FROM tbl_product_history WHERE Barcode='" & LI.Cells(0).Value & "' AND Hy_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                                ExecuteSQLQuery(sqlSTR)

                                For i As Integer = 0 To sqlDT.Rows.Count - 1
                                    sqlSTR = "UPDATE tbl_product_history SET Bal_Qty=Bal_Qty-" & CDbl(LI.Cells(2).Value) & " WHERE Hy_ID=" & sqlDT.Rows(i)("Hy_ID")
                                    GetSQLQuery(sqlSTR)
                                Next

                                sqlSTR = "UPDATE tbl_Stock_Products SET  Qty = Qty - " & CDbl(LI.Cells(2).Value) & " WHERE Barcode = '" & LI.Cells(0).Value & "'"
                                ExecuteSQLQuery(sqlSTR)
                            Next


                            '============= Delete ===========
                            sqlSTR = "DELETE FROM tbl_Ac_Ledger WHERE Purchase_ID ='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Ledger_ID ='" & Ledger_ID & "'"
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_product_history WHERE Purchase_ID ='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Purchase_Details WHERE Purchase_ID ='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Purchase WHERE Purchase_ID ='" & .dgvPurchase.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)
                        End If

                        .RefreshPurchase()
                    End If
                End With

            Case UCase("FrmCollectionList")
                With FrmCollectionList
                    If .tabMain.SelectedTabIndex = 0 Then
                        If ConfirmDelete(.dgvCollection) = True Then
                            sqlSTR = "SELECT Col_Date, Mem_ID, Cash_ID FROM tbl_Collections WHERE Col_ID=" & .dgvCollection.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            SelectDate = sqlDT.Rows(0)("Col_Date")
                            Ac_ID = sqlDT.Rows(0)("Mem_ID")
                            Cash_ID = sqlDT.Rows(0)("Cash_ID")

                            ''========== tbl_Ac_Ledger =============
                            'sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & Ac_ID & "' AND Ledger_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            'ExecuteSQLQuery(sqlSTR)

                            'For i As Integer = 0 To sqlDT.Rows.Count - 1
                            '    sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt+" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                            '    GetSQLQuery(sqlSTR)
                            'Next

                            'sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = Bal_Amt+" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Ac_ID = '" & Ac_ID & "'"
                            'ExecuteSQLQuery(sqlSTR)


                            '============= tbl_CashBank ============
                            sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt-" & CDbl(.dgvCollection.SelectedRows(0).Cells(7).Value) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt-" & CDbl(.dgvCollection.SelectedRows(0).Cells(7).Value) & " WHERE Cash_ID = '" & Cash_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_Balance ===========
                            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(.dgvCollection.SelectedRows(0).Cells(7).Value) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            '============= Delete ===========
                            sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Ledger_ID =" & .dgvCollection.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Collections WHERE Col_ID =" & .dgvCollection.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            .RefreshCollections()
                        End If

                    ElseIf .tabMain.SelectedTabIndex = 1 Then
                        If ConfirmDelete(.dgvDonation) = True Then
                            sqlSTR = "SELECT Col_Date, Mem_ID, Cash_ID FROM tbl_Collections WHERE Col_ID=" & .dgvDonation.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            SelectDate = sqlDT.Rows(0)("Col_Date")
                            Cash_ID = sqlDT.Rows(0)("Cash_ID")


                            '============= tbl_CashBank ============
                            sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt-" & CDbl(.dgvDonation.SelectedRows(0).Cells(6).Value) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt-" & CDbl(.dgvDonation.SelectedRows(0).Cells(6).Value) & " WHERE Cash_ID = '" & Cash_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_Balance ===========
                            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(.dgvDonation.SelectedRows(0).Cells(6).Value) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            '============= Delete ===========
                            sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Ledger_ID =" & .dgvDonation.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Collections WHERE Col_ID =" & .dgvDonation.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            .RefreshCollections()
                        End If
                    End If
                End With

            Case UCase("FrmAssetList")
                With FrmAssetList
                    If ConfirmDelete(.dgvCustomers) = True Then
                        Dim Paid_Amt, Due_Amt As Double
                        Dim Sup_ID, Led_ID As String

                        sqlSTR = "SELECT As_Date FROM tbl_assets WHERE AS_ID='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        ExecuteSQLQuery(sqlSTR)

                        SelectDate = sqlDT.Rows(0)("As_Date")

                        sqlSTR = "SELECT Ac_ID FROM tbl_Ac_Ledger WHERE Purchase_ID='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        ExecuteSQLQuery(sqlSTR)
                        Sup_ID = sqlDT.Rows(0)("Ac_ID")

                        '============= tbl_CashBank ============
                        sqlSTR = "SELECT Cash_ID, Led_ID, Paid_Amt FROM tbl_cashbank_ledger WHERE Ac_ID='" & Sup_ID & "'"
                        ExecuteSQLQuery(sqlSTR)
                        Cash_ID = sqlDT.Rows(0)("Cash_ID")
                        Paid_Amt = sqlDT.Rows(0)("Paid_Amt")
                        Led_ID = sqlDT.Rows(0)("Led_ID")

                        sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                        ExecuteSQLQuery(sqlSTR)

                        For i As Integer = 0 To sqlDT.Rows.Count - 1
                            sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt+" & CDbl(Paid_Amt) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                            GetSQLQuery(sqlSTR)
                        Next

                        sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt+" & CDbl(Paid_Amt) & " WHERE Cash_ID = '" & Cash_ID & "'"
                        ExecuteSQLQuery(sqlSTR)


                        '============= tbl_Balance ===========
                        sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                        ExecuteSQLQuery(sqlSTR)

                        For i As Integer = 0 To sqlDT.Rows.Count - 1
                            sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(Paid_Amt) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                            GetSQLQuery(sqlSTR)
                        Next

                        '=========== Supplier Ledger ==========

                        Due_Amt = CDbl(.dgvCustomers.SelectedRows(0).Cells(3).Value) - CDbl(Paid_Amt)


                        sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & Sup_ID & "' AND Ledger_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                        ExecuteSQLQuery(sqlSTR)

                        For i As Integer = 0 To sqlDT.Rows.Count - 1
                            sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt-" & Due_Amt & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                            GetSQLQuery(sqlSTR)
                        Next

                        sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = Bal_Amt+" & Due_Amt & " WHERE Ac_ID = '" & Sup_ID & "'"
                        ExecuteSQLQuery(sqlSTR)


                        '============= Delete ===========
                        sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Led_ID ='" & Led_ID & "'"
                        ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "DELETE FROM tbl_assets WHERE As_ID ='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "DELETE FROM tbl_accounts WHERE Ac_ID ='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "DELETE FROM tbl_ac_ledger WHERE Ac_ID ='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        ExecuteSQLQuery(sqlSTR)

                        sqlSTR = "DELETE FROM tbl_ac_ledger WHERE Purchase_ID ='" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        ExecuteSQLQuery(sqlSTR)

                        .RefreshAsset()
                    End If
                End With


            Case UCase("FrmPaymentList")
                With FrmPaymentList
                    If ConfirmDelete(.dgvCustomers) = True Then
                        sqlSTR = "SELECT Purchase_ID, Ledger_Date, Ac_ID, Cash_ID FROM tbl_Ac_Ledger WHERE Ledger_ID=" & .dgvCustomers.SelectedRows(0).Cells(0).Value
                        ExecuteSQLQuery(sqlSTR)

                        If IsDBNull(sqlDT.Rows(0)("Purchase_ID")) Then
                            SelectDate = sqlDT.Rows(0)("Ledger_Date")
                            Ac_ID = sqlDT.Rows(0)("Ac_ID")
                            Cash_ID = sqlDT.Rows(0)("Cash_ID")

                            '========== tbl_Ac_Ledger =============
                            sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & Ac_ID & "' AND Ledger_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt-" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = Bal_Amt-" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Ac_ID = '" & Ac_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_CashBank ============
                            sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt+" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt+" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Cash_ID = '" & Cash_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_Balance ===========
                            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(.dgvCustomers.SelectedRows(0).Cells(7).Value) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            '============= Delete ===========
                            sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Ledger_ID =" & .dgvCustomers.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Ac_Ledger WHERE Ledger_ID =" & .dgvCustomers.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)
                        Else
                            MessageBoxEx.Show("Selected record currently used...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'sqlSTR = "DELETE FROM tbl_Discount WHERE Barcode = '" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        'ExecuteSQLQuery(sqlSTR)
                        '.RefreshPayment()
                    End If
                End With

            Case UCase("FrmExpenseList")
                With FrmExpenseList
                    If ConfirmDelete(.dgvExpense) = True Then
                        sqlSTR = "SELECT Ledger_Date, Ac_ID, Cash_ID FROM tbl_Ac_Ledger WHERE Ledger_ID=" & .dgvExpense.SelectedRows(0).Cells(0).Value
                        ExecuteSQLQuery(sqlSTR)

                        If sqlDT.Rows.Count > 0 Then
                            SelectDate = sqlDT.Rows(0)("Ledger_Date")
                            Ac_ID = sqlDT.Rows(0)("Ac_ID")
                            Cash_ID = sqlDT.Rows(0)("Cash_ID")

                            '========== tbl_Ac_Ledger =============
                            sqlSTR = "SELECT Ledger_ID FROM tbl_Ac_ledger WHERE Ac_ID='" & Ac_ID & "' AND Ledger_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Ac_ledger SET Balance_Amt=Balance_Amt-" & CDbl(.dgvExpense.SelectedRows(0).Cells(5).Value) & " WHERE Ledger_ID=" & sqlDT.Rows(i)("Ledger_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_Accounts SET Bal_Amt = Bal_Amt-" & CDbl(.dgvExpense.SelectedRows(0).Cells(5).Value) & " WHERE Ac_ID = '" & Ac_ID & "'"
                            ExecuteSQLQuery(sqlSTR)

                            '============= tbl_CashBank ============
                            sqlSTR = "SELECT Led_ID FROM tbl_cashbank_ledger WHERE Cash_ID='" & Cash_ID & "' AND Led_Date>'" & Format(SelectDate, "yyyy/MM/dd HH:mm:ss") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Cashbank_Ledger SET Bal_Amt=Bal_Amt+" & CDbl(.dgvExpense.SelectedRows(0).Cells(5).Value) & " WHERE Led_ID=" & sqlDT.Rows(i)("Led_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "UPDATE tbl_CashBank SET Bal_Amt=Bal_Amt+" & CDbl(.dgvExpense.SelectedRows(0).Cells(5).Value) & " WHERE Cash_ID = '" & Cash_ID & "'"
                            ExecuteSQLQuery(sqlSTR)


                            '============= tbl_Balance ===========
                            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt+" & CDbl(.dgvExpense.SelectedRows(0).Cells(5).Value) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            '============= Delete ===========
                            sqlSTR = "DELETE FROM tbl_Cashbank_ledger WHERE Ledger_ID =" & .dgvExpense.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)

                            sqlSTR = "DELETE FROM tbl_Ac_Ledger WHERE Ledger_ID =" & .dgvExpense.SelectedRows(0).Cells(0).Value
                            ExecuteSQLQuery(sqlSTR)
                        Else
                            MessageBoxEx.Show("Selected record currently used...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        'sqlSTR = "DELETE FROM tbl_Discount WHERE Barcode = '" & .dgvCustomers.SelectedRows(0).Cells(0).Value & "'"
                        'ExecuteSQLQuery(sqlSTR)
                        '.RefreshPayment()
                    End If
                End With


            Case UCase("FrmSupplierPaymentDetails")
                With FrmSupplierPaymentDetails
                    If ConfirmDelete(.dgvPayment) = True Then
                        If .dgvPayment.SelectedRows(0).Cells(8).Value <> "0" Then
                            MessageBoxEx.Show("This record is currently used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            sqlSTR = "UPDATE tbl_Suppliers SET Due_Amount=Due_Amount+" & CDbl(.dgvPayment.SelectedRows(0).Cells(7).Value) + CDbl(.dgvPayment.SelectedRows(0).Cells(9).Value) & " WHERE Supp_ID='" & .dgvPayment.SelectedRows(0).Cells(2).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            SelectDate = FormatDateTime(.dgvPayment.SelectedRows(0).Cells(1).Value)

                            sqlSTR = "SELECT Transcation_ID FROM tbl_supplier_transaction WHERE Transaction_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_supplier_transaction SET Due_Amt=Due_Amt+" & CDbl(.dgvPayment.SelectedRows(0).Cells(7).Value) + CDbl(.dgvPayment.SelectedRows(0).Cells(9).Value) & " WHERE Transcation_ID='" & sqlDT.Rows(i)("Transcation_ID") & "'"
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "DELETE FROM tbl_supplier_transaction WHERE Transcation_ID ='" & .dgvPayment.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            .RefreshSupplierPayment()
                        End If

                    End If
                End With


            Case UCase("FrmCustomerPaymentDetails")
                With FrmCustomerPaymentDetails
                    If ConfirmDelete(.dgvPayment) = True Then
                        If .dgvPayment.SelectedRows(0).Cells(8).Value <> "0" Then
                            MessageBoxEx.Show("This record is currently used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else
                            sqlSTR = "UPDATE tbl_Customers SET Due_Amount=Due_Amount+" & CDbl(.dgvPayment.SelectedRows(0).Cells(7).Value) + CDbl(.dgvPayment.SelectedRows(0).Cells(9).Value) & " WHERE Cust_ID='" & .dgvPayment.SelectedRows(0).Cells(2).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            SelectDate = FormatDateTime(.dgvPayment.SelectedRows(0).Cells(1).Value)

                            sqlSTR = "SELECT Paid_ID FROM tbl_customers_paid WHERE Paid_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "' AND Cust_ID='" & .dgvPayment.SelectedRows(0).Cells(2).Value & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_customers_paid SET Due_Amt=Due_Amt+" & CDbl(.dgvPayment.SelectedRows(0).Cells(7).Value) + CDbl(.dgvPayment.SelectedRows(0).Cells(9).Value) & " WHERE Paid_ID='" & sqlDT.Rows(i)("Paid_ID") & "'"
                                GetSQLQuery(sqlSTR)
                            Next

                            '============= tbl_Balance ===========
                            sqlSTR = "SELECT Bal_ID FROM tbl_Balance WHERE Bal_Date>='" & Format(SelectDate, "yyyy/MM/dd") & "'"
                            ExecuteSQLQuery(sqlSTR)

                            For i As Integer = 0 To sqlDT.Rows.Count - 1
                                sqlSTR = "UPDATE tbl_Balance SET Bal_Amt=Bal_Amt-" & CDbl(.dgvPayment.SelectedRows(0).Cells(7).Value) & " WHERE Bal_ID=" & sqlDT.Rows(i)("Bal_ID")
                                GetSQLQuery(sqlSTR)
                            Next

                            sqlSTR = "DELETE FROM tbl_customers_paid WHERE Paid_ID ='" & .dgvPayment.SelectedRows(0).Cells(0).Value & "'"
                            ExecuteSQLQuery(sqlSTR)
                            .RefreshCustomerPayment()
                        End If

                    End If
                End With
        End Select
    End Sub


    Public Sub RefreshList(ByVal FrmName As String)
        Select Case UCase(FrmName)
            Case UCase("FrmProductsList")
                FrmProductsList.RefreshProducts()

            Case UCase("FrmCashBank")
                FrmCashBank.RefreshCashBank()

            Case UCase("FrmAllAccounts")
                FrmAllAccounts.RefreshAccounts()

            Case UCase("FrmPurchaseList")
                FrmPurchaseList.RefreshPurchase()

            Case UCase("FrmStock")
                FrmStock.RefreshStock()

            Case UCase("FrmAssetList")
                FrmSalesReceipt.RefreshSales()

            Case UCase("FrmSalesReceipt")
                FrmAssetList.RefreshAsset()

            Case UCase("FrmExpenseList")
                FrmExpenseList.RefreshExpense()

            Case UCase("FrmCollectionList")
                FrmCollectionList.RefreshCollections()

            Case UCase("FrmPaymentList")
                FrmPaymentList.RefreshPayment()

            Case UCase("FrmTransferList")
                FrmTransferList.RefreshTransfer()

            Case UCase("FrmUserView")
                FrmUserView.UserRefresh()


        End Select
    End Sub

    Public Sub FormPrint(ByVal FrmName As String)
        Dim Report As New FrmReports

        Select Case UCase(FrmName)
            Case UCase("FrmMemberDetails")
                FrmMemberPrint.ShowDialog()

            Case UCase("FrmCashBank")
                FrmCashPrint.ShowDialog()

            Case UCase("FrmAllAccounts")
                FrmAccountsPrint.ShowDialog()

            Case UCase("FrmSupplierList")
                With FrmSupplierList
                    RptStr = "SELECT * FROM tbl_Suppliers ORDER BY LPAD(LOWER(Supp_ID), 10,0) ASC"
                    globalFRM = "SupplierList"
                    Report.Show()
                End With

            Case UCase("FrmStock")
                FrmStockPrint.ShowDialog()

            Case UCase("FrmCritical")
                With FrmCritical
                    RptStr = "SELECT P.Barcode, P.Product_Name, P.Reorder_Label, P.Purchase_Price, S.Qty FROM tbl_Stock_Products AS S INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode " & _
                             "INNER JOIN tbl_Product_Category AS C ON C.Cat_ID=P.Cat_ID WHERE S.Qty <= P.Reorder_Label ORDER BY LPAD(LOWER(P.Barcode), 10,0) ASC"
                    PrmCategory.Value = "Cosmetic"

                    globalFRM = "CriticalStock"
                    Report.Show()
                End With

            Case UCase("FrmCustomerList")
                RptStr = "SELECT * FROM tbl_Customers ORDER BY LPAD(LOWER(Cust_ID), 10,0) ASC"
                globalFRM = "CustomerList"
                Report.Show()

            Case UCase("FrmBarcode")
                RptStr = "SELECT * FROM Tbl_Barcode"

                globalFRM = "Barcode"
                Report.Show()

            Case UCase("FrmCritical")
                RptStr = "SELECT S.Barcode, P.Product_Name, P.Reorder_Label, P.Purchase_Price, S.Qty FROM tbl_stock_products AS S INNER JOIN tbl_Products AS P ON S.Barcode = P.Barcode WHERE S.Qty <= P.Reorder_Label"
                globalFRM = "CriticalProduct"
                Report.Show()

            Case UCase("FrmPurchaseList")
                FrmPurchasePrint.ShowDialog()

            Case UCase("FrmTransferList")
                With FrmPrint
                    .Text = "Cash Transfer"
                    .ShowDialog()
                End With

            Case UCase("FrmCollectionList")
                With FrmCollectionList
                    If .tabMain.SelectedTabIndex = 0 Then
                        FrmCollectionPrint.ShowDialog()
                    ElseIf .tabMain.SelectedTabIndex = 1 Then
                        FrmOthersIncomePrint.ShowDialog()
                    End If
                End With

            Case UCase("FrmPaymentList")
                With FrmPrint
                    .Text = "Payment"
                    .ShowDialog()
                End With

            Case UCase("FrmSalesReceipt")
                FrmSalesPrint.ShowDialog()

            Case UCase("FrmExpenseList")
                FrmExpensePrint.ShowDialog()

            Case UCase("FrmReports")
                mReport.PrintToPrinter(1, True, 0, 0)

        End Select
    End Sub
End Module
