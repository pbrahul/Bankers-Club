Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmReports
    Dim ParamCollection As New CrystalDecisions.Shared.ParameterValues

    Public Sub CompanyInfo()
        ParamCollection.Add(PrmName)
        mReport.DataDefinition.ParameterFields("prmCompany").ApplyCurrentValues(ParamCollection)

        ParamCollection.Add(PrmAddress)
        mReport.DataDefinition.ParameterFields("prmAddress").ApplyCurrentValues(ParamCollection)

        ParamCollection.Add(PrmContact)
        mReport.DataDefinition.ParameterFields("prmContact").ApplyCurrentValues(ParamCollection)

        ParamCollection.Add(PrmEmail)
        mReport.DataDefinition.ParameterFields("prmEmail").ApplyCurrentValues(ParamCollection)

        ParamCollection.Add(PrmPicPath)
        mReport.DataDefinition.ParameterFields("PicPath").ApplyCurrentValues(ParamCollection)
    End Sub

    Private Sub FrmReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mReport = New ReportDocument()
        With FrmMain
            i_Print = 0
            .lblPrint.Visible = True
            .tmr_Print.Enabled = True

            Select Case UCase(globalFRM)
                Case UCase("MemberList")
                    mReport.Load(Application.StartupPath & "\MyReports\rptMemberList.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("MemberDetails")
                    mReport.Load(Application.StartupPath & "\MyReports\rptMember.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("MemberListBank")
                    mReport.Load(Application.StartupPath & "\MyReports\rptMemberBank.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("CashLedger")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCashLedger.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("CashBalance")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCash.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("AccountsBalance")
                    mReport.Load(Application.StartupPath & "\MyReports\rptAccounts.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("AccountsLedger")
                    mReport.Load(Application.StartupPath & "\MyReports\rptAccountsLedger.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("ProductStock")
                    mReport.Load(Application.StartupPath & "\MyReports\rptStock.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("PrmFrom").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("ProductStockTillDate")
                    mReport.Load(Application.StartupPath & "\MyReports\rptStockTillDate.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("PrmFrom").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("StockHistory")
                    mReport.Load(Application.StartupPath & "\MyReports\rptStockHistory.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("CriticalStock")
                    mReport.Load(Application.StartupPath & "\MyReports\rptReorderLevel.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmCategory)
                    mReport.DataDefinition.ParameterFields("PrmCategory").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Barcode")
                    mReport.Load(Application.StartupPath & "\MyReports\Barcode.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("QRCode")
                    mReport.Load(Application.StartupPath & "\MyReports\QRCODE.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("CustomerList")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCustomerList.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("CriticalProduct")
                    mReport.Load(Application.StartupPath & "\MyReports\rptReorderLevel.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("SelectedPurchase")
                    mReport.Load(Application.StartupPath & "\MyReports\rptPurchaseSelected.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("PurchaseApproved")
                    mReport.Load(Application.StartupPath & "\MyReports\rptPurchaseApproved.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)


                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Collection_Statement")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCollectionStatement.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)


                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("SalesSummary")
                    mReport.Load(Application.StartupPath & "\MyReports\rptSalesSummary.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)


                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("SalesDetails")
                    mReport.Load(Application.StartupPath & "\MyReports\rptSalesDetails.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmCategory)
                    mReport.DataDefinition.ParameterFields("PrmCategory").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Profit_Statement")
                    mReport.Load(Application.StartupPath & "\MyReports\rptProfit.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)


                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Profit_Details")
                    mReport.Load(Application.StartupPath & "\MyReports\rptProfitDetails.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmCategory)
                    mReport.DataDefinition.ParameterFields("PrmCategory").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Receipt")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCollectionReceipt.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain


                Case UCase("Collections")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCollection.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("CollectionsBank")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCollectionBank.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Income Print")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCollectionDonation.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Others Income")
                    mReport.Load(Application.StartupPath & "\MyReports\rptOthersIncome.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Payment")
                    mReport.Load(Application.StartupPath & "\MyReports\rptPayment.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Income")
                    mReport.Load(Application.StartupPath & "\MyReports\rptIncome.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Balance")
                    RptStr = "SELECT C.Cash_Name, (IFNULL((SELECT Bal_Amt FROM tbl_cashbank_ledger WHERE Cash_ID=C.Cash_ID ORDER BY Led_Date DESC LIMIT 1), 0)) AS Bal_Amt, (IFNULL((SELECT L.Balance_Amt FROM tbl_assets AS A INNER JOIN tbl_ac_ledger AS L ON A.As_ID=L.Ac_ID WHERE A.As_Type='Land' ORDER BY Ledger_Date DESC LIMIT 1),0)) AS Land, " & _
                             "(IFNULL((SELECT Balance_Amt FROM tbl_assets AS A INNER JOIN tbl_ac_ledger AS L ON A.As_ID=L.Ac_ID WHERE A.As_Type='Plant/Equipment' ORDER BY Ledger_Date DESC LIMIT 1),0)) AS Plant, (IFNULL((SELECT L.Balance_Amt FROM tbl_assets AS A INNER JOIN tbl_ac_ledger AS L ON A.As_ID=L.Ac_ID WHERE A.As_Type='Furnitures' ORDER BY Ledger_Date DESC LIMIT 1),0)) AS Furnitures, " & _
                             "(IFNULL((SELECT L.Balance_Amt FROM tbl_assets AS A INNER JOIN tbl_ac_ledger AS L ON A.As_ID=L.Ac_ID WHERE A.As_Type='Machineries' ORDER BY Ledger_Date DESC LIMIT 1),0)) AS Machineries, (IFNULL((SELECT L.Balance_Amt FROM tbl_assets AS A INNER JOIN tbl_ac_ledger AS L ON A.As_ID=L.Ac_ID WHERE A.As_Type='Other non Current Assets' ORDER BY Ledger_Date DESC LIMIT 1),0)) AS Others, " & _
                             "(SELECT SUM(-Bal_Amt) FROM tbl_accounts WHERE Bal_Amt<0) AS Payable FROM tbl_cashbank AS C"

                    mReport.Load(Application.StartupPath & "\MyReports\rptBalanceSheet.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain


                Case UCase("CashAccount")
                    mReport.Load(Application.StartupPath & "\MyReports\rptCashAccount.rpt")

                    Call DataSourceConnection_Report()

                    Dim repOp As ReportObject
                    For Each repOp In mReport.ReportDefinition.ReportObjects
                        If repOp.Kind = ReportObjectKind.SubreportObject Then
                            Dim SubRepName As String = (CType(repOp, SubreportObject)).SubreportName
                            Dim subRepDoc As ReportDocument = mReport.Subreports(SubRepName)
                            If SubRepName = "Income" Then
                                RptStr = "SELECT T.Type_Details AS Fee_Type, SUM(C.Col_Amt) AS Col_Amt, (IFNULL((SELECT Bal_Amt FROM tbl_balance WHERE Bal_Date<'" & Format(FrmPrint.dtpFrom.Value, "yyyy/MM/dd") & "'ORDER BY Bal_Date DESC LIMIT 1),0)) AS Opening, " & _
                                         "(IFNULL((SELECT SUM(Credit_Amt) FROM tbl_ac_ledger WHERE (DATE_FORMAT(Ledger_Date,'%Y/%m/%d')>='" & Format(FrmPrint.dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(Ledger_Date,'%Y/%m/%d')<='" & Format(FrmPrint.dtpTo.Value, "yyyy/MM/dd") & "') AND Led_Particulars<>'Purchase Product'),0)) AS Credit_Amt FROM tbl_collections AS C " & _
                                         "INNER JOIN tbl_Collection_Type AS T ON C.Type_ID=T.Type_ID WHERE (DATE_FORMAT(C.Col_Date,'%Y/%m/%d')>='" & Format(FrmPrint.dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(C.Col_Date,'%Y/%m/%d')<='" & Format(FrmPrint.dtpTo.Value, "yyyy/MM/dd") & "') GROUP BY C.Type_ID"
                                subRepDoc.SetDataSource(ExecuteSQLQuery(RptStr))
                            ElseIf SubRepName = "Expense" Then
                                RptStr = "SELECT A.AC_Name, IFNULL(SUM(L.Credit_Amt),0) AS Credit_Amt FROM tbl_ac_ledger AS L INNER JOIN tbl_accounts AS A ON L.Ac_ID=A.Ac_ID WHERE L.Led_Particulars<>'Purchase Product' AND " & _
                                         "(DATE_FORMAT(L.Ledger_Date,'%Y/%m/%d')>='" & Format(FrmPrint.dtpFrom.Value, "yyyy/MM/dd") & "' AND DATE_FORMAT(L.Ledger_Date,'%Y/%m/%d')<='" & Format(FrmPrint.dtpTo.Value, "yyyy/MM/dd") & "') GROUP BY L.AC_ID"
                                subRepDoc.SetDataSource(ExecuteSQLQuery(RptStr))
                            ElseIf SubRepName = "Cash" Then
                                RptStr = "SELECT Cash_Name, (IFNULL((SELECT Bal_Amt FROM tbl_CashBank_ledger WHERE Cash_ID=C.Cash_ID AND DATE_FORMAT(Led_Date,'%Y/%m/%d')<='" & Format(FrmPrint.dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY Led_Date DESC LIMIT 1),0)) AS Balance FROM tbl_cashbank AS C"
                                subRepDoc.SetDataSource(ExecuteSQLQuery(RptStr))
                            ElseIf SubRepName = "Person" Then
                                RptStr = "SELECT AC_Name, (IFNULL((SELECT Balance_Amt FROM tbl_ac_ledger WHERE AC_ID=A.Ac_ID AND DATE_FORMAT(Ledger_Date,'%Y/%m/%d')<='" & Format(FrmPrint.dtpTo.Value, "yyyy/MM/dd") & "' ORDER BY Ledger_Date DESC LIMIT 1),00)) AS Balance FROM tbl_Accounts AS A INNER JOIN tbl_accounts_type AS T ON A.Type_ID=T.Type_ID WHERE T.Type_Details='Person'"
                                subRepDoc.SetDataSource(ExecuteSQLQuery(RptStr))
                            End If
                        End If
                    Next

                    RptStr = "SELECT * FROM tbl_Balance LIMIT 1"
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("PrmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("PrmDateTo").ApplyCurrentValues(ParamCollection)

                    CompanyInfo()

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Expense")
                    mReport.Load(Application.StartupPath & "\MyReports\rptExpense.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmName)
                    mReport.DataDefinition.ParameterFields("PrmExpense").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("DailyExpense")
                    mReport.Load(Application.StartupPath & "\MyReports\rptExpenseDate.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain

                Case UCase("Cash Transfer")
                    mReport.Load(Application.StartupPath & "\MyReports\rptTransfer.rpt")

                    Call DataSourceConnection_Report()
                    mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                    CompanyInfo()

                    ParamCollection.Add(PrmFormDate)
                    mReport.DataDefinition.ParameterFields("prmDateFrom").ApplyCurrentValues(ParamCollection)

                    ParamCollection.Add(PrmToDate)
                    mReport.DataDefinition.ParameterFields("prmDateTo").ApplyCurrentValues(ParamCollection)

                    CrystalReportViewer1.ReportSource = mReport
                    Me.MdiParent = FrmMain
            End Select

            .lblPrint.Visible = False
            .tmr_Print.Enabled = False
        End With

    End Sub

    Private Sub FrmReport_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        grpPrint.Width = FrmMain.Width - 150
        grpPrint.Height = FrmMain.Height - 150

        grpPrint.Left = Me.Left + 80
        grpPrint.Top = Me.Top + 40

        'grpPrint.Left = (Me.Width / 2) - 450
        'grpPrint.Top = (Me.Height / 2) - 290
    End Sub
End Class