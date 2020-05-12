Module ModFrmMain
    Public Sub UserBtnAccess()
        'sqlSTR = "SELECT Button_Access FROM tbl_Users WHERE User_ID='" & UserID & "'"
        'ExecuteSQLQuery(sqlSTR)

        'Dim BtnAccess As String = sqlDT.Rows(0)("Button_Access")
        'With FrmMain
        '    For x As Integer = 0 To Len(BtnAccess) - 1
        '        If x = 0 Then
        '            If .btnNew.Enabled = True Then
        '                .btnNew.Enabled = IIf(BtnAccess.Chars(x) = "1", True, False)
        '            End If
        '        ElseIf x = 1 Then
        '            If .btnEdit.Enabled = True Then
        '                .btnEdit.Enabled = IIf(BtnAccess.Chars(x) = "1", True, False)
        '            End If
        '        ElseIf x = 2 Then
        '            If .btnDelete.Enabled = True Then
        '                .btnDelete.Enabled = IIf(BtnAccess.Chars(x) = "1", True, False)
        '            End If
        '        ElseIf x = 3 Then
        '            If .btnPrint.Enabled = True Then
        '                .btnPrint.Enabled = IIf(BtnAccess.Chars(x) = "1", True, False)
        '            End If
        '        End If
        '    Next
        'End With

    End Sub

    Public Sub ButtonActivated(ByVal FrmName As Form)
        Try
            With FrmMain
                Select Case UCase(FrmName.Name)
                    Case UCase("FrmUserView")
                        MdiRefresh()
                        .btnPrint.Enabled = False
                        .lblTitle.Text = "User Details"
                        UserBtnAccess()

                    Case UCase("FrmUserLoginDetails")
                        MdiRefresh()
                        .btnNew.Enabled = False
                        .btnEdit.Enabled = False
                        .btnDelete.Enabled = False
                        UserBtnAccess()

                    Case UCase("FrmMemberDetails")
                        MdiRefresh()
                        .lblTitle.Text = "Member Details"
                        UserBtnAccess()

                    Case UCase("FrmCashBank")
                        MdiRefresh()
                        .lblTitle.Text = "Cash && Bank"
                        UserBtnAccess()

                    Case UCase("FrmAllAccounts")
                        MdiRefresh()
                        .lblTitle.Text = "Account Details"
                        UserBtnAccess()

                    Case UCase("FrmCollectionList")
                        MdiRefresh()
                        .lblTitle.Text = "Collection/Receive"
                        UserBtnAccess()

                    Case UCase("FrmPaymentList")
                        MdiRefresh()
                        .lblTitle.Text = "Payment"
                        UserBtnAccess()

                    Case UCase("FrmTransferList")
                        MdiRefresh()
                        .lblTitle.Text = "Cash Transfer"
                        UserBtnAccess()

                    Case UCase("FrmPurchaseList")
                        MdiRefresh()
                        .lblTitle.Text = "Purchase Product"
                        UserBtnAccess()

                    Case UCase("FrmStock")
                        MdiRefresh()
                        .lblTitle.Text = "Product Stock"
                        .btnNew.Enabled = False
                        .btnEdit.Enabled = False
                        .btnDelete.Enabled = False
                        UserBtnAccess()

                    Case UCase("FrmReturnList")
                        MdiRefresh()
                        .lblTitle.Text = "Purchase Return"
                        UserBtnAccess()

                    Case UCase("FrmDefectiveList")
                        MdiRefresh()
                        .lblTitle.Text = "Defective Product"
                        UserBtnAccess()

                    Case UCase("FrmCritical")
                        MdiRefresh()
                        .btnNew.Enabled = False
                        .btnEdit.Enabled = False
                        .btnDelete.Enabled = False
                        .lblTitle.Text = "Out of Stock List"
                        UserBtnAccess()

                    Case UCase("FrmSMSSending")
                        MdiRefresh()
                        .btnNew.Enabled = False
                        .btnEdit.Enabled = False
                        .btnDelete.Enabled = False
                        .lblTitle.Text = "Send SMS"
                        UserBtnAccess()

                    Case UCase("FrmPatientList")
                        MdiRefresh()
                        .lblTitle.Text = "Patient List"
                        UserBtnAccess()

                    Case UCase("FrmAssetList")
                        MdiRefresh()
                        .btnEdit.Enabled = False
                        .lblTitle.Text = "Asset List"
                        UserBtnAccess()

                    Case UCase("FrmSales")
                        MdiRefresh()
                        .btnNew.Enabled = False
                        .btnEdit.Enabled = False
                        .btnDelete.Enabled = False
                        .btnRefresh.Enabled = False
                        .btnPrint.Enabled = False
                        .lblTitle.Text = "Point of Sale"
                        UserBtnAccess()

                    Case UCase("FrmSalesReceipt")
                        MdiRefresh()
                        .btnNew.Enabled = False
                        .btnEdit.Enabled = False
                        .btnDelete.Enabled = False
                        .lblTitle.Text = "Sale Receipt"
                        UserBtnAccess()

                    Case UCase("FrmSupplierPaymentDetails")
                        MdiRefresh()
                        .btnEdit.Enabled = False
                        .lblTitle.Text = "Supplier Transcation"
                        UserBtnAccess()

                    Case UCase("FrmCustomerPaymentDetails")
                        MdiRefresh()
                        .btnEdit.Enabled = False
                        .lblTitle.Text = "Customer Transcation"
                        UserBtnAccess()

                    Case UCase("FrmEmployeeSalaryDetails")
                        MdiRefresh()
                        .lblTitle.Text = "Employee Salary"
                        UserBtnAccess()

                    Case UCase("FrmExpenseList")
                        MdiRefresh()
                        .lblTitle.Text = "Expenditure"
                        UserBtnAccess()

                    Case UCase("FrmBankDetails")
                        MdiRefresh()
                        .btnEdit.Enabled = False
                        .lblTitle.Text = "Bank Details"
                        UserBtnAccess()

                    Case UCase("FrmEmployeeList")
                        MdiRefresh()
                        .lblTitle.Text = "Employee Details"
                        UserBtnAccess()

                    Case UCase("FrmReminderList")
                        MdiRefresh()
                        .lblTitle.Text = "Remind"
                        UserBtnAccess()

                    Case UCase("FrmContactList")
                        MdiRefresh()
                        .lblTitle.Text = "Contact List"
                        UserBtnAccess()

                        '============================
                    Case UCase("FrmReports")
                        MdiDisable()
                        .btnHome.Enabled = True
                        .btnPrint.Enabled = True
                        .btnClose.Enabled = True
                        'UserBtnAccess()

                    Case UCase("FrmReportsDate")
                        MdiDisable()
                        .btnClose.Enabled = True
                        .btnHome.Enabled = True
                        'UserBtnAccess()

                    Case UCase("FrmBG")
                        MdiDisable()
                        .SlidePanel1.IsOpen = True
                        ' .panBtn.Visible = False
                        .btnPannel.Visible = False
                End Select
            End With

        Catch ex As Exception
            FrmMain.SlidePanel1.IsOpen = True
            FrmMain.lblTitle.Text = PrmName.Value
        End Try

    End Sub

    Public Sub MdiRefresh()
        With FrmMain
            .btnHome.Enabled = True
            .btnNew.Enabled = True
            .btnEdit.Enabled = True
            .btnDelete.Enabled = True
            .btnRefresh.Enabled = True
            .btnClose.Enabled = True
            .btnPrint.Enabled = True
            '.panBtn.Enabled = True
            '.panBtn.Visible = True
            .btnPannel.Visible = True

        End With
    End Sub

    Public Sub MdiDisable()
        With FrmMain
            .btnHome.Enabled = False
            .btnNew.Enabled = False
            .btnEdit.Enabled = False
            .btnDelete.Enabled = False
            .btnRefresh.Enabled = False
            .btnClose.Enabled = False
            .btnPrint.Enabled = False
        End With
    End Sub
    
End Module
