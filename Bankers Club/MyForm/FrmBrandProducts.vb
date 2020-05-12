Imports DevComponents.DotNetBar

Public Class FrmBrandProducts
    Dim CatID As String

    Private Sub FrmUserAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(380, 342)

        SingleComboBox("SELECT Cat_Name FROM tbl_Product_Category ORDER BY Cat_Name ASC", cmbCategory)
        SingleComboBox("SELECT Descripation FROM tbl_Measure", cmbUnit)

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(TableLayoutPanel2, Highlighter1)

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT C.Cat_Name, P.Product_Name, P.Units, P.Purchase_Price, P.Sales_Price, P.Reorder_Label FROM tbl_Products AS P INNER JOIN tbl_Product_Category AS C ON P.Cat_ID=C.Cat_ID WHERE P.Barcode ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            cmbCategory.SelectedItem = sqlDT.Rows(0)("Cat_Name")
            txtName.Text = sqlDT.Rows(0)("Product_Name")
            cmbUnit.SelectedItem = sqlDT.Rows(0)("Units")
            txtPurchasePrice.Text = Format(sqlDT.Rows(0)("Purchase_Price"), "###,###.00")
            txtSalePrice.Text = Format(sqlDT.Rows(0)("Sales_Price"), "###,###.00")
            txtReorder.Text = sqlDT.Rows(0)("Reorder_Label")
        End If

        cmbCategory.Select()
    End Sub

    Private Sub FrmUserAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Item"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim BarCode As String
        Dim duplicateName As Boolean

        If FillTextBox(TableLayoutPanel2, Highlighter1) = False Then
            Exit Sub
        End If

        If CDbl(txtPurchasePrice.Text) >= CDbl(txtSalePrice.Text) Then
            MessageBoxEx.Show("Purchase Price should be less than Sale Price!! ", "Invaild Price", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Highlighter1.SetHighlightColor(txtSalePrice, Validator.eHighlightColor.Red)
            txtSalePrice.Select()
            Exit Sub
        Else
            Highlighter1.SetHighlightColor(txtSalePrice, Validator.eHighlightColor.None)
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "SELECT Product_Name FROM tbl_Products WHERE Product_Name ='" & txtName.Text & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.Red)
                MessageBoxEx.Show("Product Name Already Exist !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Select()
                Exit Sub
            Else
                Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.None)
            End If

            sqlSTR = "SELECT Cat_ID, Cat_Code FROM tbl_Product_Category WHERE Cat_Name = '" & cmbCategory.SelectedItem & "'"
            ExecuteSQLQuery(sqlSTR)
            If sqlDT.Rows.Count > 0 Then
                BrandCode = sqlDT.Rows(0)("Cat_Code")
                CatID = sqlDT.Rows(0)("Cat_ID")
                Highlighter1.SetHighlightColor(cmbCategory, Validator.eHighlightColor.None)
            Else
                Highlighter1.SetHighlightColor(cmbCategory, Validator.eHighlightColor.Red)
                cmbCategory.Select()
                Exit Sub
            End If

            'sqlSTR = "SELECT  FROM tbl_Category WHERE Cat_Name = '" & cmbCategory.Text & "'"
            'ExecuteSQLQuery(sqlSTR)

            BarCode = BarcodeID("tbl_Products", "Barcode", BrandCode)

            sqlSTR = "INSERT INTO tbl_Products(Barcode, Product_Name, Units, Purchase_Price, Sales_Price, Reorder_Label, Cat_ID) " & _
                     "VALUES ('" & BarCode & "', '" & txtName.Text & "', '" & cmbUnit.Text & "', " & CDbl(txtPurchasePrice.Text) & ", " & CDbl(txtSalePrice.Text) & _
                     ", " & CDbl(txtReorder.Text) & ", '" & CatID & "')"
            ExecuteSQLQuery(sqlSTR)

            If MessageBoxEx.Show("Record Save Successfully. " & vbNewLine & "Product Barcode is : " & BarCode & vbNewLine & "Do you want to add another porduct ? ", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                ClearAll(TableLayoutPanel2, Highlighter1)
                cmbCategory.Select()
            Else
                FrmProductsList.RefreshProducts()
                Me.Close()

            End If

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT Product_Name FROM tbl_Products WHERE Barcode ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Product_Name")) = UCase(txtName.Text) Then
                duplicateName = False
            Else
                sqlSTR = "SELECT Product_Name FROM tbl_Products WHERE Product_Name ='" & txtName.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.Red)
                    MessageBoxEx.Show("Product name already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    duplicateName = True
                    txtName.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtName, Validator.eHighlightColor.None)
                    duplicateName = False
                End If
            End If

            If duplicateName = False Then
                sqlSTR = "SELECT Cat_ID, Cat_Code FROM tbl_Product_Category WHERE Cat_Name = '" & cmbCategory.SelectedItem & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    BrandCode = sqlDT.Rows(0)("Cat_Code")
                    CatID = sqlDT.Rows(0)("Cat_ID")
                    Highlighter1.SetHighlightColor(cmbCategory, Validator.eHighlightColor.None)
                Else
                    Highlighter1.SetHighlightColor(cmbCategory, Validator.eHighlightColor.Red)
                    cmbCategory.Select()
                    Exit Sub
                End If


                sqlSTR = "UPDATE tbl_Products SET Product_Name ='" & txtName.Text & "', Units = '" & cmbUnit.Text & "', Purchase_Price =" & CDbl(txtPurchasePrice.Text) & ", " & _
                         "Sales_Price =" & CDbl(txtSalePrice.Text) & ",  Reorder_Label = " & CDbl(txtReorder.Text) & ", Cat_ID='" & CatID & "' WHERE  Barcode = '" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)

                'sqlSTR = "SELECT Barcode FROM tbl_Stock_Products WHERE Barcode = '" & EditID & "'"
                'ExecuteSQLQuery(sqlSTR)
                'If sqlDT.Rows.Count > 0 Then
                '    sqlSTR = "UPDATE tbl_Stock_Products SET Product_Name ='" & txtName.Text & "', Item_Price = " & CDbl(txtPurchasePrice.Text) & ", Units = '" & cmbUnit.Text & "' WHERE  Barcode = '" & EditID & "'"
                '    ExecuteSQLQuery(sqlSTR)
                'End If
            End If

            MessageBoxEx.Show("Record Successfully Updated.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmProductsList.RefreshProducts()
            Me.Close()
        End If
    End Sub

    Private Sub txtReorder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReorder.KeyPress
        Select Case e.KeyChar
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", vbBack
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtPurchasePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurchasePrice.KeyPress
        NumKey(txtPurchasePrice.Text, e)
    End Sub

    Private Sub txtSalePrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalePrice.KeyPress
        NumKey(txtSalePrice.Text, e)
    End Sub

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress
        FilterKey(e)
    End Sub

End Class