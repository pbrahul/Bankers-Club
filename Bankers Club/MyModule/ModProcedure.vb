Option Explicit On
Imports System.IO
Imports ComponentFactory.Krypton.Toolkit
Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Validator
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar.Controls
Imports System.Drawing.Printing

Module ModProcedure

    Public Sub FillListView(ByVal sqlData As DataTable, ByVal lvList As ListView, ByVal imageID As Integer)
        Dim xsize As Integer
        Dim i As Integer
        Dim j As Integer
        lvList.Clear()
        For i = 0 To sqlData.Columns.Count - 1
            lvList.Columns.Add(sqlData.Columns(i).ColumnName)
        Next i

        For i = 0 To sqlData.Rows.Count - 1
            lvList.Items.Add(sqlData.Rows(i).Item(0), imageID)
            For j = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(j)) Then
                    lvList.Items(i).SubItems.Add(sqlData.Rows(i).Item(j))
                Else
                    lvList.Items(i).SubItems.Add("")
                End If
            Next j

            Dim rCount As Integer = lvList.Items.Count
            If rCount Mod 2 = 1 Then
                lvList.Items(i).BackColor = Color.AntiqueWhite
            Else
                lvList.Items(i).BackColor = Color.White
            End If
        Next i

        For i = 0 To sqlData.Columns.Count - 1
            xsize = lvList.Width / sqlData.Columns.Count - 7
            lvList.Columns(i).Width = xsize
        Next i

    End Sub

    Public Sub FillList(ByVal sqlData As DataTable, ByVal myList As ListView, ByVal ImageID As Integer)
        Dim i, x As Integer
        myList.Items.Clear()

        For i = 0 To sqlData.Rows.Count - 1
            myList.Items.Add(sqlData.Rows(i).Item(0), ImageID)

            For x = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(x)) Then
                    myList.Items(i).SubItems.Add(sqlData.Rows(i).Item(x))
                Else
                    myList.Items(i).SubItems.Add("")
                End If

                Dim rCount As Integer = myList.Items.Count
                If rCount Mod 2 = 1 Then
                    'myList.Items(i).BackColor = Color.LightGreen
                    myList.Items(i).BackColor = System.Drawing.Color.FromArgb((CType(((CType((208), Byte))), Integer)), (CType(((CType((234), Byte))), Integer)), (CType(((CType((189), Byte))), Integer)))
                Else
                    myList.Items(i).BackColor = Color.White
                End If
            Next x
        Next i
    End Sub

    Public Sub FillTreeViewWithColumn(ByVal sqlData As DataTable, ByVal myList As AdvTree)
        Dim i, x As Integer

        myList.Nodes.Clear()

        For i = 0 To sqlData.Columns.Count - 1
            myList.Columns.Add(New ColumnHeader(sqlData.Columns(i).ColumnName))
            'myList.Columns.Add(sqlData.Columns(i).ColumnName)
            myList.Columns(i).Width.Absolute = myList.Width / sqlData.Columns.Count - 2
        Next i

        For i = 0 To sqlData.Rows.Count - 1
            myList.Nodes.Add(New Node(sqlData.Rows(i).Item(0)))

            For x = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(x)) Then
                    myList.Nodes(i).Cells.Add(New Cell(sqlData.Rows(i).Item(x)))
                Else
                    myList.Nodes(i).Cells.Add(New Cell(""))
                End If
            Next x
        Next i
    End Sub

    Public Sub FillGridViewWithColumn(ByVal sqlData As DataTable, ByVal myList As DataGridView)
        Dim i As Integer
        Dim dr As DataRow

        myList.Columns.Clear()
        myList.Rows.Clear()

        For i = 0 To sqlData.Columns.Count - 1
            myList.Columns.Add(sqlData.Columns(i).ColumnName, sqlData.Columns(i).ColumnName)
            myList.Columns(i).Width = myList.Width / sqlData.Columns.Count - 2
        Next i

        For Each dr In sqlDT.Rows
            myList.Rows.Add(dr.ItemArray)
        Next
        If myList.Rows.Count > 0 Then
            myList.Rows(0).Selected = True
        End If
    End Sub

    Public Sub FillGridViewWithoutColumn(ByVal sqlData As DataTable, ByVal myList As DataGridView)
        Dim i As Integer
        Dim dr As DataRow

        myList.Rows.Clear()

        For Each dr In sqlDT.Rows
            myList.Rows.Add(dr.ItemArray)
        Next
        If myList.Rows.Count > 0 Then
            myList.Rows(0).Selected = False
        End If
    End Sub

    Public Sub FillTreeView(ByVal sqlData As DataTable, ByVal myList As AdvTree)
        Dim i, x As Integer
        myList.Nodes.Clear()

        For i = 0 To sqlData.Rows.Count - 1
            myList.Nodes.Add(New Node(sqlData.Rows(i).Item(0)))

            For x = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(x)) Then
                    myList.Nodes(i).Cells.Add(New Cell(sqlData.Rows(i).Item(x)))
                Else
                    myList.Nodes(i).Cells.Add(New Cell(""))
                End If
            Next x
        Next i
    End Sub

    Public Sub FillLstView(ByVal sqlData As DataTable, ByVal myList As ListView, ByVal ImageID As Integer)
        Dim i, x As Integer
        myList.Items.Clear()

        myList.Clear()
        For i = 0 To sqlData.Columns.Count - 1
            myList.Columns.Add(sqlData.Columns(i).ColumnName)
            myList.Columns(i).Width = myList.Width / sqlData.Columns.Count - 3
        Next i

        For i = 0 To sqlData.Rows.Count - 1
            myList.Items.Add(sqlData.Rows(i).Item(0), ImageID)

            For x = 1 To sqlData.Columns.Count - 1
                If Not IsDBNull(sqlData.Rows(i).Item(x)) Then
                    myList.Items(i).SubItems.Add(sqlData.Rows(i).Item(x))
                Else
                    myList.Items(i).SubItems.Add("")
                End If
            Next x
        Next i
    End Sub

    Public Function FindTotal(ByVal lstView As ListView, ByVal i As Integer)
        Dim TotalSum As Double = 0
        Dim TempNode As ListViewItem
        For Each TempNode In lstView.Items
            TotalSum += CDbl(TempNode.SubItems.Item(i).Text)
        Next
        Return TotalSum
    End Function

    Public Function GridTotal(ByVal grdView As DataGridView, ByVal i As Integer)
        Dim TotalSum As Double = 0
        Dim TempNode As DataGridViewRow
        For Each TempNode In grdView.Rows
            TotalSum += CDbl(TempNode.Cells(i).Value)
        Next
        Return TotalSum
    End Function

    Public Sub SingleComboBox(ByVal sql As String, ByVal cb As ComboBox)
        cb.Items.Clear()
        ExecuteSQLQuery(sql)
        Dim Col As String = sqlDT.Columns(0).ColumnName
        If sqlDT.Rows.Count > 0 Then
            For i As Integer = 0 To sqlDT.Rows.Count - 1
                cb.Items.Add(sqlDT.Rows(i)(Col).ToString)
            Next
            cb.SelectedIndex = 0
        End If
    End Sub


    Public Sub DoubleComboBox(ByVal sql As String, ByVal cb As ComboBox)
        cb.Items.Clear()
        ExecuteSQLQuery(sql)
        Dim Col As String = sqlDT.Columns(0).ColumnName
        Dim Col2 As String = sqlDT.Columns(1).ColumnName

        If sqlDT.Rows.Count > 0 Then
            For i As Integer = 0 To sqlDT.Rows.Count - 1
                cb.Items.Add((sqlDT.Rows(i)(Col).ToString) & " | " & sqlDT.Rows(i)(Col2).ToString)
            Next
            cb.SelectedIndex = 0
        End If
    End Sub


    Public Function AutoIDPreFix(ByVal TableName As String, ByVal FieldName As String, ByVal Branch As String)
        Dim ID As String

        sqlSTR = "SELECT " & FieldName & " FROM " & TableName & " WHERE RIGHT(" & FieldName & ", 1)='" & Branch & _
                 "' ORDER BY LPAD(LOWER(" & FieldName & "), 10,0) DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            ID = Val(sqlDT.Rows(0)(FieldName))
            ID = (ID + 1) & Branch
        Else
            ID = 1001 & Branch
        End If

        Return ID
    End Function

    Public Function BarcodeID(ByVal TableName As String, ByVal FieldName As String, ByVal Branch As String)
        Dim ID As String

        sqlSTR = "SELECT " & FieldName & " FROM " & TableName & " WHERE SUBSTRING_INDEX(" & FieldName & ", '-', 1)='" & Branch & "' ORDER BY LPAD(LOWER(" & FieldName & "), 10,0) DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            ID = Split(sqlDT.Rows(0)(FieldName), "-")(1)
            ID = Branch & "-" & (ID + 1)
        Else
            ID = Branch & "-" & 10001
        End If

        Return ID
    End Function


    Public Function YearIDPreFix(ByVal TableName As String, ByVal FieldName As String, ByVal Branch As String)
        Dim ID As String

        sqlSTR = "SELECT " & FieldName & " FROM " & TableName & " WHERE " & "RIGHT(" & FieldName & ", 1)='" & Branch & "' ORDER BY LPAD(LOWER(" & FieldName & "), 10,0) DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            If Split(sqlDT.Rows(0)(FieldName), "-")(0) = Today.Year Then
                ID = Split(sqlDT.Rows(0)(FieldName), "-")(1)
                ID = Today.Year & "-" & (Val(ID) + 1) & Branch
            Else
                ID = Today.Year & "-" & 1001 & Branch
            End If
        Else
            ID = Today.Year & "-" & 1001 & Branch
        End If

        Return ID
    End Function



    Public Function ManualID(ByVal TableName As String, ByVal FieldName As String, ByVal PreFix As String)
        Dim ID As String

        sqlSTR = "SELECT " & FieldName & " AS ManualID FROM " & TableName & " WHERE SUBSTRING_INDEX(" & FieldName & ", '-', 1)='" & PreFix & "' ORDER BY LPAD(LOWER(" & FieldName & "), 10,0) DESC LIMIT 1"
        ExecuteSQLQuery(sqlSTR)

        If sqlDT.Rows.Count > 0 Then
            ID = Split(sqlDT.Rows(0)("ManualID"), "-")(1)
            ID = Val(ID) + 1
            ID = PreFix & "-" & ID.ToString().PadLeft(3, "00")
        Else
            ID = PreFix & "-" & "001"
        End If

        Return ID
    End Function

    Public Function x_Access(ByRef xAccnt As String) As Boolean
        If UCase(xAccnt) <> UCase("Administrator") Then
            MessageBoxEx.Show("Only Administrator are allowed to access this module.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            x_Access = False
        Else
            x_Access = True
        End If
    End Function

    Public Function x_Permission(ByRef xAccnt As String) As Boolean
        If xAccnt = 0 Then
            MessageBoxEx.Show("Pemission Deny. " & vbNewLine & "Please contact your System Administrator. ", "Permission Deny", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            x_Permission = False
        Else
            x_Permission = True
        End If
    End Function


    Public Sub UsersLogDetails(ByVal iAction As String, ByVal LogTime As String)
        Dim HistoryID As String
        HistoryID = YearIDPreFix("tbl_User_Log_Details", "Log_Details_ID", PreFix)

        sqlSTR = "INSERT INTO tbl_User_Log_Details (Log_Details_ID, Log_Action, Log_Date, Log_Time, Log_ID, User_ID) " & _
                 "VALUES ('" & HistoryID & "', '" & iAction & "', '" & Format(Now, "MM/dd/yyyy") & _
                 "', '" & LogTime & "', '" & LogID & "', '" & UserID & "')"
        ExecuteSQLQuery(sqlSTR)

        'FrmUserLoginDetails.ViewLOG(0)
    End Sub


    Public Function FilterKey(ByVal e As KeyPressEventArgs) As Boolean
        If e.KeyChar = Chr(8) Then Exit Function
        'MsgBox(Asc(e.KeyChar))
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 97 To 122, 48 To 57, 1, 3, 22, 32, 38, 44 To 46, 64, 47, 95
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Function


    Public Function NumKey(ByVal KCode As String, ByVal e As KeyPressEventArgs) As Boolean
        Const x As Integer = 1
        If e.KeyChar = Chr(8) Then Exit Function
        Select Case e.KeyChar
            Case "0" To "9"
                e.Handled = False
            Case "."
                If (InStr(KCode, ".")) > x Then
                    e.Handled = True
                End If
            Case Else
                e.Handled = True
        End Select
    End Function


    Public Sub ClearAll(ByVal pan As Control, ByVal Err As Highlighter)
        For Each Crt As Control In pan.Controls
            If TypeOf Crt Is TextBoxX Then
                Dim cText As TextBoxX = CType(Crt, TextBoxX)
                cText.Text = ""
                Err.SetHighlightColor(Crt, eHighlightColor.None)
            End If
        Next

        For Each Crt As Control In pan.Controls
            If TypeOf Crt Is ComboBox Then
                Dim cCombo As ComboBox = CType(Crt, ComboBox)
                If cCombo.Items.Count > 0 Then
                    cCombo.SelectedIndex = 0
                    Err.SetHighlightColor(Crt, eHighlightColor.None)
                End If
            End If
        Next

    End Sub


    Public Function FillTextBox(ByVal root As Control, ByVal Err As Highlighter) As Boolean
        For Each Crt As Control In root.Controls
            If TypeOf Crt Is TextBoxX Then
                If Crt.Text = "" And Crt.Enabled = True And Crt.Visible = True Then
                    Err.SetHighlightColor(Crt, eHighlightColor.Red)
                    Crt.Select()
                    FillTextBox = False
                    Exit Function
                Else
                    Err.SetHighlightColor(Crt, eHighlightColor.None)
                    FillTextBox = True
                End If
            End If

            If TypeOf Crt Is ComboBox Then
                If Crt.Text = "" And Crt.Enabled = True And Crt.Visible = True Then
                    Err.SetHighlightColor(Crt, eHighlightColor.Red)
                    Crt.Select()
                    FillTextBox = False
                    Exit Function
                Else
                    Err.SetHighlightColor(Crt, eHighlightColor.None)
                    FillTextBox = True
                End If
            End If
        Next
    End Function

    Public Function Encrypt(ByVal icText As String) As String
        Dim icChar As String
        Dim icLen As Integer
        Dim icNewText As String = ""
        Dim i As Integer = 0

        icChar = ""
        icLen = Len(icText)
        For i = 1 To icLen
            icChar = Mid(icText, i, 1)
            Select Case Asc(icChar)
                Case 65 To 90
                    icChar = Chr(Asc(icChar) + 127)
                Case 97 To 122
                    icChar = Chr(Asc(icChar) + 121)
                Case 48 To 57
                    icChar = Chr(Asc(icChar) + 196)
                Case 32
                    icChar = Chr(32)
            End Select
            icNewText = icNewText + icChar
        Next
        Encrypt = icNewText
    End Function

    Public Function Decrypt(ByVal icText As String) As String
        Dim icChar As String
        Dim icLen As Integer
        Dim icNewText As String = ""
        Dim i As Integer = 0
        icChar = ""
        icLen = Len(icText)
        For i = 1 To icLen
            icChar = Mid(icText, i, 1)
            Select Case Asc(icChar)
                Case 192 To 217
                    icChar = Chr(Asc(icChar) - 127)
                Case 218 To 243
                    icChar = Chr(Asc(icChar) - 121)
                Case 244 To 253
                    icChar = Chr(Asc(icChar) - 196)
                Case 32
                    icChar = Chr(32)
            End Select
            icNewText = icNewText + icChar
        Next
        Decrypt = icNewText
    End Function


    Public Sub EnterTab(ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub InsPrinterList()
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            MessageBoxEx.Show(pkInstalledPrinters)
        Next
    End Sub

    'Public Sub KeyDown_2(ByVal root As Form, ByVal grp As GroupBox, ByVal e As KeyPressEventArgs)
    '    If Char.IsControl(e.KeyChar) Then
    '        If e.KeyChar.Equals(Chr(Keys.Return)) Then
    '            grp.SelectNextControl(root.ActiveControl, True, True, False, True)
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub


    'Public Sub FilterKeyAll(ByVal pan As KryptonPanel, ByVal e As KeyPressEventArgs)
    '    For Each t As Control In pan.Controls
    '        If TypeOf t Is KryptonTextBox Then
    '            If e.KeyChar = Chr(8) Then Exit Sub
    '            Select Case Asc(e.KeyChar)
    '                Case 65 To 90, 97 To 122, 48 To 57, 1, 3, 22, 32, 44, 45, 64
    '                    e.Handled = False
    '                Case Else
    '                    e.Handled = True
    '            End Select
    '        End If
    '    Next
    'End Sub

End Module
