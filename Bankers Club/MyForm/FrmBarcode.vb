Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
Imports Gma.QrCodeNet.Encoding.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms
Imports System.Drawing.Printing

Public Class FrmBarcode
    Dim sqlCon As New MySqlConnection(CnString)
    Dim dbCommand As MySqlCommand
    Dim PicBarCode As New PictureBox
    Dim QrPic As New QrCodeImgControl
    Dim x, i, cnt, holdI As Integer
    Dim XHOLD As String
    Dim mReport As New ReportDocument
    Dim rptView As New CrystalReportViewer
    Dim CName As String
    Dim scProductName As New AutoCompleteStringCollection

    Public Sub BarcodePic()
        Dim mstream As New System.IO.MemoryStream()
        PicBarCode.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        dbCommand.Parameters.AddWithValue("@Picture", arrImage)
        mstream.Close()
    End Sub

    Public Sub QrCodePic()
        Dim mstream As New System.IO.MemoryStream()
        QrPic.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        dbCommand.Parameters.AddWithValue("@Picture", arrImage)
        mstream.Close()
    End Sub

    Public Sub BarcodePrint()
        cnt = 0
        holdI = 0

        GetSQLQuery("TRUNCATE Tbl_Barcode")

        sqlCon.Open()
        cnt = 1

        For x As Integer = 0 To dgvBarcode.Rows.Count - 1
            For i As Integer = 0 To Int(dgvBarcode.Rows(x).Cells(5).Value) - 1
                PicBarCode.Image = Code128(dgvBarcode.Rows(x).Cells(0).Value, "A")

                If cnt = 1 Then
                    dbCommand = New MySqlCommand("INSERT INTO Tbl_Barcode(Barcode1, Pic1, Name1, Amount1, CompanyName1, Discount1, VAT1) VALUES ('" & dgvBarcode.Rows(x).Cells(0).Value & "', @Picture, '" & dgvBarcode.Rows(x).Cells(1).Value & "', " & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", '" & CName & "', " & dgvBarcode.Rows(x).Cells(3).Value & ", " & dgvBarcode.Rows(x).Cells(4).Value & ")", sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()

                    sqlSTR = "SELECT * FROM Tbl_Barcode ORDER BY ID DESC"
                    ExecuteSQLQuery(sqlSTR)
                    XHOLD = sqlDT.Rows(0)("ID")

                ElseIf cnt = 2 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode2 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic2=@Picture, Name2 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount2 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName2 = '" & CName & "', Discount2=" & dgvBarcode.Rows(x).Cells(3).Value & ", VAT2=" & dgvBarcode.Rows(x).Cells(4).Value & " WHERE ID =" & XHOLD, sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 3 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode3 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic3=@Picture, Name3 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount3 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName3 = '" & CName & "', Discount3=" & dgvBarcode.Rows(x).Cells(3).Value & ", VAT3=" & dgvBarcode.Rows(x).Cells(4).Value & " WHERE ID =" & XHOLD, sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 4 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode4 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic4=@Picture, Name4 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount4 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName4 = '" & CName & "', Discount4=" & dgvBarcode.Rows(x).Cells(3).Value & ", VAT4=" & dgvBarcode.Rows(x).Cells(4).Value & " WHERE ID =" & XHOLD, sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 5 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode5 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic5=@Picture, Name5 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount5 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName5 = '" & CName & "', Discount5=" & dgvBarcode.Rows(x).Cells(3).Value & ", VAT5=" & dgvBarcode.Rows(x).Cells(4).Value & " WHERE ID =" & XHOLD, sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 6 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode6 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic6=@Picture, Name6 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount6 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName6 = '" & CName & "', Discount6=" & dgvBarcode.Rows(x).Cells(3).Value & ", VAT6=" & dgvBarcode.Rows(x).Cells(4).Value & " WHERE ID =" & XHOLD, sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 7 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode7 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic7=@Picture, Name7 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount7 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName7 = '" & CName & "', Discount7=" & dgvBarcode.Rows(x).Cells(3).Value & ", VAT7=" & dgvBarcode.Rows(x).Cells(4).Value & " WHERE ID =" & XHOLD, sqlCon)
                    BarcodePic()
                    dbCommand.ExecuteNonQuery()
                    holdI = holdI + 1

                Else
                    If ((cnt - 1) / (7)) = 1 Then
                        dbCommand = New MySqlCommand("INSERT INTO Tbl_Barcode (Barcode1, Pic1, Name1, Amount1, CompanyName1, Discount1, VAT1) VALUES ('" & dgvBarcode.Rows(x).Cells(0).Value & "', @Picture, '" & dgvBarcode.Rows(x).Cells(1).Value & "', " & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", '" & CName & "', " & dgvBarcode.Rows(x).Cells(3).Value & ", " & dgvBarcode.Rows(x).Cells(4).Value & ")", sqlCon)
                        BarcodePic()
                        dbCommand.ExecuteNonQuery()

                        sqlSTR = "SELECT * FROM Tbl_Barcode ORDER BY ID DESC"
                        ExecuteSQLQuery(sqlSTR)
                        XHOLD = sqlDT.Rows(0)("ID")
                        cnt = 1
                    End If
                End If
                cnt = cnt + 1
            Next
        Next
        sqlCon.Close()
    End Sub

    Public Sub QRCodePrint()
        cnt = 0
        holdI = 0

        GetSQLQuery("TRUNCATE Tbl_Barcode")

        sqlCon.Open()
        cnt = 1
        For x = 0 To dgvBarcode.Rows.Count - 1
            For i = 0 To Int(dgvBarcode.Rows(x).Cells(5).Value) - 1
                QrPic.Text = dgvBarcode.Rows(x).Cells(0).Value

                If cnt = 1 Then
                    dbCommand = New MySqlCommand("INSERT INTO Tbl_Barcode(Barcode1, Pic1, Name1, Amount1, CompanyName1) VALUES ('" & dgvBarcode.Rows(x).Cells(0).Value & "', @Picture, '" & dgvBarcode.Rows(x).Cells(1).Value & "', " & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", '" & CName & "')", sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()

                    sqlSTR = "SELECT ID FROM Tbl_Barcode ORDER BY ID DESC"
                    ExecuteSQLQuery(sqlSTR)
                    XHOLD = sqlDT.Rows(0)("ID")

                ElseIf cnt = 2 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode2 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic2=@Picture, Name2 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount2 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName2 = '" & CName & "' WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 3 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode3 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic3=@Picture, Name3 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount3 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName3 = '" & CName & "' WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 4 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode4 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic4=@Picture, Name4 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount4 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName4 = '" & CName & "' WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 5 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode5 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic5=@Picture, Name5 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount5 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName5 = '" & CName & "' WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()

                ElseIf cnt = 6 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode6 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic6=@Picture, Name6 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount6 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", CompanyName6 = '" & CName & "' WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()
                    holdI = holdI + 1

                ElseIf cnt = 7 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode7 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic7=@Picture, Name7 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount7 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & " WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()
                    holdI = holdI + 1

                ElseIf cnt = 8 Then
                    dbCommand = New MySqlCommand("UPDATE Tbl_Barcode SET Barcode8 ='" & dgvBarcode.Rows(x).Cells(0).Value & "', Pic8=@Picture, Name8 ='" & dgvBarcode.Rows(x).Cells(1).Value & "', Amount8 =" & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & " WHERE ID =" & XHOLD, sqlCon)
                    QrCodePic()
                    dbCommand.ExecuteNonQuery()
                    holdI = holdI + 1

                Else
                    If ((cnt - 1) / 8) = 1 Then
                        dbCommand = New MySqlCommand("INSERT INTO Tbl_Barcode (Barcode1, Pic1, Name1, Amount1, CompanyName1) VALUES ('" & dgvBarcode.Rows(x).Cells(0).Value & "', @Picture, '" & dgvBarcode.Rows(x).Cells(1).Value & "', " & CDbl(dgvBarcode.Rows(x).Cells(2).Value) & ", '" & CName & "')", sqlCon)
                        QrCodePic()
                        dbCommand.ExecuteNonQuery()

                        sqlSTR = "SELECT * FROM Tbl_Barcode ORDER BY ID DESC"
                        GetSQLQuery(sqlSTR)
                        XHOLD = sqlDT.Rows(0)("ID")
                        cnt = 1
                    End If
                End If
                cnt = cnt + 1
            Next
        Next
        sqlCon.Close()
    End Sub


    'Private Sub dgvSearch_KeyDown(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = 8 Then
    '        txtSearch.Focus()
    '    ElseIf e.KeyCode = Keys.Enter Then
    '        sqlSTR = "SELECT P.Barcode,  P.Product_Name, P.Sales_Price, P.VAT, (IFNULL((SELECT Discount FROM tbl_discount WHERE Barcode=P.Barcode),0)) AS Discount " & _
    '                 "FROM tbl_Products AS P WHERE P.Barcode ='" & dgvSearch.SelectedRows(0).Cells(0).Value & "'"
    '        ExecuteSQLQuery(sqlSTR)
    '        With dgvBarcode
    '            For i As Integer = 0 To .Rows.Count - 1
    '                If UCase(.Rows(i).Cells(0).Value) = UCase(dgvSearch.SelectedRows(0).Cells(0).Value) Then
    '                    MessageBoxEx.Show("Item already on the list...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                    Exit Sub
    '                End If
    '            Next
    '            .Rows.Add(sqlDT.Rows(0)("Barcode"), sqlDT.Rows(0)("Product_Name"), Format(sqlDT.Rows(0)("Sales_Price"), "###,###.00"), sqlDT.Rows(0)("Discount"), sqlDT.Rows(0)("VAT"), 1)
    '        End With

    '        dgvSearch.Visible = False
    '        txtSearch.Clear()
    '        txtSearch.Select()
    '    End If
    'End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtSearch.Text <> "" Then
                sqlSTR = "SELECT P.Barcode,  P.Product_Name, P.Sales_Price, P.VAT, (IFNULL((SELECT Discount FROM tbl_discount WHERE Barcode=P.Barcode),0)) AS Discount " & _
                         "FROM tbl_Products AS P WHERE P.Barcode ='" & txtSearch.Text & "' OR P.Product_Name='" & txtSearch.Text & "'"
                ExecuteSQLQuery(sqlSTR)

                If sqlDT.Rows.Count > 0 Then
                    With dgvBarcode
                        For i As Integer = 0 To .Rows.Count - 1
                            If UCase(.Rows(i).Cells(0).Value) = UCase(sqlDT.Rows(0)("Barcode")) Then
                                MessageBoxEx.Show("Item already on the list...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        Next
                        .Rows.Add(sqlDT.Rows(0)("Barcode"), sqlDT.Rows(0)("Product_Name"), Format(sqlDT.Rows(0)("Sales_Price"), "###,###.00"), sqlDT.Rows(0)("Discount"), sqlDT.Rows(0)("VAT"), 1)
                        txtSearch.Clear()
                        txtSearch.Select()
                    End With
                Else
                    MessageBoxEx.Show("Products not found...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub dgvBarcode_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvBarcode.EditingControlShowing
        If dgvBarcode.CurrentCell.ColumnIndex = 5 And Not e.Control Is Nothing Then
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

    Private Sub dgvBarcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvBarcode.KeyDown
        If e.KeyCode = Keys.Delete Then
            If dgvBarcode.SelectedCells.Count > 0 Then
                If MessageBoxEx.Show("Do you want to delete this product ??", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                    dgvBarcode.Rows.Remove(dgvBarcode.CurrentRow)
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub FrmStock_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        'Dim x As Integer = (Me.Width / 2) - 465
        'Dim y As Integer = (Me.Height / 2) - 285
        'grpUser.Location = New Point(x, y)

        grpUser.Width = FrmMain.Width - 180
        grpUser.Height = FrmMain.Height - 180
        grpUser.Location = New Point(100, 30)

        dgvBarcode.Width = grpUser.Width - 40
        dgvBarcode.Height = grpUser.Height - 120

        rbnQrCode.Left = grpUser.Width - 112
        rbnBarcode.Left = rbnQrCode.Left - 100

        panButton.Top = dgvBarcode.Bottom + 7
        panButton.Left = (grpUser.Width / 2) - 115

    End Sub

    Private Sub FrmStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ExecuteSQLQuery("SELECT Company_Name FROM tbl_company_info")
        If sqlDT.Rows.Count > 0 Then
            CName = sqlDT.Rows(0)("Company_Name")
        Else
            CName = "Company_Name"
        End If

        sqlSTR = "SELECT Product_Name FROM tbl_Products ORDER BY Product_name ASC"
        ExecuteSQLQuery(sqlSTR)
        For i As Integer = 0 To sqlDT.Rows.Count - 1
            scProductName.Add(sqlDT.Rows(i)("Product_Name"))
        Next

        With txtSearch
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.CustomSource
            .AutoCompleteCustomSource = scProductName
        End With

        txtSearch.Clear()
        txtSearch.Select()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvBarcode.Rows.Count > 0 Then
            If rbnBarcode.Checked = True Then
                BarcodePrint()

                mReport.Load(Application.StartupPath & "\MyReports\Barcode.rpt")
                RptStr = "SELECT * FROM Tbl_Barcode"
                mReport.SetDataSource(ExecuteSQLQuery(RptStr))

                mReport.PrintToPrinter(1, True, 0, 0)


                dgvBarcode.Rows.Clear()
                txtSearch.Clear()

            ElseIf rbnQrCode.Checked = True Then
                QRCodePrint()

                mReport.Load(Application.StartupPath & "\MyReports\QrCode.rpt")
                RptStr = "SELECT * FROM Tbl_Barcode"
                mReport.SetDataSource(ExecuteSQLQuery(RptStr))
                mReport.PrintToPrinter(1, True, 0, 0)

                dgvBarcode.Rows.Clear()
                txtSearch.Clear()
            End If
        Else
            MessageBoxEx.Show("No Item Add For Print, Please Add Item!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()
        dgvBarcode.Rows.Clear()
        txtSearch.Select()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim Report As New FrmReports

        If rbnBarcode.Checked = True Then
            If dgvBarcode.Rows.Count > 0 Then
                BarcodePrint()
                dgvBarcode.Rows.Clear()
            End If

            RptStr = "SELECT * FROM Tbl_Barcode"

            globalFRM = "Barcode"
            Report.Show()
        Else
            QRCodePrint()
            dgvBarcode.Rows.Clear()

            RptStr = "SELECT * FROM Tbl_Barcode"

            globalFRM = "QRCode"
            Report.Show()

        End If
    End Sub

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    If txtSearch.Text = "" Then
    '        dgvSearch.Visible = False
    '    End If
    'End Sub

End Class