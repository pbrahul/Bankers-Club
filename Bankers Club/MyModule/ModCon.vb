Imports MySql.Data.MySqlClient
Imports ComponentFactory.Krypton.Toolkit
Imports DevComponents.DotNetBar
Imports System.IO
Imports GsmComm.GsmCommunication
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine

Module ModCon
    'Public CnString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Application.StartupPath & "\Lable_DB.accdb; Jet OLEDB:Database Password=4F@1234"
    Public CnString As String ' = "server=localhost; database=Cooperative_DB; User Id=root; Password=M@mun"

    Public sqlDT As New DataTable
    Public SqlDT2 As New DataTable

    Public openedFileStream As System.IO.Stream

    Public GetID As String
    Public EditID As String
    Public BrandCode As String
    Public BrandID As String
    Public SuppID As String
    Public UserID As String
    Public LogID As String
    Public PreFix As String
    Public UserName As String
    Public UserType As String
    Public sqlSTR As String
    Public RptStr As String
    Public tmpStr As String
    Public conStr As String
    Public RateAmount As Double
    Public FrmName As String
    Public UserEdit As String
    Public GrandTotal As Double
    Public uPermission As String
    Public BalAmt As Double

    Public Cash_ID As String
    Public Cust_Bal As Double
    Public Cash_Bal As Double

    Public comm As GsmCommMain
    Public SMS_Status As Boolean = False


    Public ContactCount As Integer

    Public VAT As Double
    Public Pending_ID As Integer
    Public Pending_QTY As Integer
    Public Pending_Item_ID As Integer
    Public dataBytes() As Byte
    Public i_Print As Integer
    Public CustID As String
    Public SaleID As String

    Public PrmName As New ParameterDiscreteValue
    Public PrmAddress As New ParameterDiscreteValue
    Public PrmContact As New ParameterDiscreteValue
    Public PrmPicPath As New ParameterDiscreteValue
    Public PrmEmail As New ParameterDiscreteValue
    Public PrmCategory As New ParameterDiscreteValue
    Public PrmUser As New ParameterDiscreteValue
    Public mReport As New ReportDocument
    Public PrmFormDate As New ParameterDiscreteValue
    Public PrmToDate As New ParameterDiscreteValue

    Public Sub ConfigFile(ByVal txt1 As String, ByVal txt2 As String, ByVal txt3 As String, ByVal txt4 As String, ByVal fileLoc As String)
        Try
            Dim fs As FileStream = Nothing
            If (Not File.Exists(fileLoc)) Then
                fs = File.Create(fileLoc)
                Using fs

                End Using
            End If

            If File.Exists(fileLoc) Then
                Using sw As StreamWriter = New StreamWriter(fileLoc)
                    sw.Write(Encrypt(txt1) & ":" & Encrypt(txt2) & ":" & Encrypt(txt3) & ":" & Encrypt(txt4))
                End Using
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message & vbCrLf & ex.StackTrace, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RegFile(ByVal txt1 As String, ByVal fileLoc As String)
        Try
            Dim fs As FileStream = Nothing
            If (Not File.Exists(fileLoc)) Then
                fs = File.Create(fileLoc)
                Using fs

                End Using
            End If

            If File.Exists(fileLoc) Then
                Using sw As StreamWriter = New StreamWriter(fileLoc)
                    sw.Write(txt1)
                End Using
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message & vbCrLf & ex.StackTrace, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function checkServer() As Boolean
        Try
            Dim fileLoc = Application.StartupPath & "\Config.ini"
            If File.Exists(fileLoc) Then
                Using tr As TextReader = New StreamReader(fileLoc)
                    conStr = tr.ReadLine()
                End Using
            End If
            If Split(Decrypt(conStr), ":")(3) = "1" Then
                'CnString = "Provider=SQLOLEDB; Data Source=" & Split(conStr, ":")(0) & "; Initial Catalog=Label_DB; User Id=" & Split(conStr, ":")(1) & "; Password=" & Split(conStr, ":")(2)
                CnString = "host=" & Split(Decrypt(conStr), ":")(0) & "; Port=3306; Database=bankers_db; User Id=" & Split(Decrypt(conStr), ":")(1) & "; Password=" & Split(Decrypt(conStr), ":")(2) & ""
                'CnString = "Provider=SQLOLEDB; SERVER=" & Split(Decrypt(conStr), ":")(0) & ",1433; Network Library=DBMSSOCN; Initial Catalog= Tailors_DB; User ID=" & Split(Decrypt(conStr), ":")(1) & "; Password=" & Split(Decrypt(conStr), ":")(2) & ";"
            Else
                CnString = "server=" & Split(Decrypt(conStr), ":")(0) & "; Database=bankers_db; User Id=" & Split(Decrypt(conStr), ":")(1) & "; Password=" & Split(Decrypt(conStr), ":")(2) & ""
                'CnString = "server=" & Split(Decrypt(conStr), ":")(0) & "; Database=Grameen_db; User Id=root"
                'CnString = "Provider=SQLOLEDB;Server=" & Split(conStr, ":")(0) & ",1433; Network Library=DBMSSOCN; Initial Catalog=Label_DB; Trusted_Connection=YES;"
            End If
            Dim sqlCon As New MySqlConnection
            sqlCon.ConnectionString = CnString
            sqlCon.Open()
            checkServer = True
            sqlCon.Close()

        Catch ex As Exception
            MessageBoxEx.Show("Error: Database Connection Property Has Not Been Initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            checkServer = False
        End Try
    End Function

    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New MySqlConnection(CnString)
            Dim sqlDA As New MySqlDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New MySqlCommandBuilder(sqlDA)
            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
        Catch ex As Exception
            MessageBoxEx.Show("Error Number : " & Err.Number & vbNewLine & "Error is: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return sqlDT
    End Function

    Public Function GetSQLQuery(ByVal SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New MySqlConnection(CnString)
            Dim sqlDA As New MySqlDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New MySqlCommandBuilder(sqlDA)
            SqlDT2.Reset() ' refresh 
            sqlDA.Fill(SqlDT2)
        Catch ex As Exception
            MessageBoxEx.Show("Error Number : " & Err.Number & vbNewLine & "Error is: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return SqlDT2
    End Function

    Public Function DataSourceConnection_Report()
        If Split(conStr, ":")(3) = "1" Then
            mReport.DataSourceConnections(0).SetConnection(Split(Decrypt(conStr), ":")(0), "DidarEnterprise_DB", False)
            mReport.DataSourceConnections(0).SetLogon(Split(Decrypt(conStr), ":")(1), Split(Decrypt(conStr), ":")(2))
        Else
            mReport.DataSourceConnections(0).SetConnection(Split(Decrypt(conStr), ":")(0), "DidarEnterprise_DB", True)
        End If
        Return 0
    End Function

End Module
