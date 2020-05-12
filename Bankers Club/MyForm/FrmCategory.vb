Imports DevComponents.DotNetBar.Validator
Imports DevComponents.DotNetBar

Public Class FrmCategory

    Private Sub FrmBrand_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Category"
    End Sub

    Private Sub FrmBrand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Point(320, 188)

        If Split(Me.Text, " - ")(1) = "Add" Then
            ClearAll(tableLayoutPanel1, Highlighter1)
            txtCat.Select()

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT * FROM tbl_Product_Category WHERE Cat_ID ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)
            txtCat.Text = sqlDT.Rows(0)("Cat_Name")
            txtCode.Text = sqlDT.Rows(0)("Cat_Code")
            txtCat.Select()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim DuplicateName As Boolean

        If FillTextBox(tableLayoutPanel1, Highlighter1) = False Then
            Exit Sub
        End If

        If Split(Me.Text, " - ")(1) = "Add" Then
            sqlSTR = "SELECT Cat_Name, Cat_Code FROM tbl_Product_Category"
            ExecuteSQLQuery(sqlSTR)

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Cat_Name")) = UCase(txtCat.Text) Then
                    MessageBoxEx.Show("Category is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Highlighter1.SetHighlightColor(txtCat, Validator.eHighlightColor.Red)
                    txtCat.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtCat, Validator.eHighlightColor.None)
                End If
            Next

            For i As Integer = 0 To sqlDT.Rows.Count - 1
                If UCase(sqlDT.Rows(i)("Cat_Code")) = UCase(txtCode.Text) Then
                    MessageBoxEx.Show("Category Code already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Highlighter1.SetHighlightColor(txtCode, Validator.eHighlightColor.Red)
                    txtCode.Select()
                    Exit Sub
                Else
                    Highlighter1.SetHighlightColor(txtCode, Validator.eHighlightColor.None)
                End If
            Next
            GetID = AutoIDPreFix("tbl_Product_Category", "Cat_ID", PreFix)
            sqlSTR = "INSERT INTO tbl_Product_Category(Cat_ID, Cat_Name, Cat_Code) VALUES('" & GetID & "', '" & txtCat.Text & "', '" & UCase(txtCode.Text) & "')"
            ExecuteSQLQuery(sqlSTR)

            MessageBoxEx.Show("Record Save Successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'UsersLogDetails("Add a New Supplier", TimeOfDay.ToString("hh:mm:ss tt"))

        ElseIf Split(Me.Text, " - ")(1) = "Edit" Then
            sqlSTR = "SELECT Cat_Name FROM tbl_Product_Category WHERE Cat_ID ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Cat_Name")) = UCase(txtCat.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT Cat_Name FROM tbl_Product_Category WHERE Cat_Name ='" & txtCat.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MessageBoxEx.Show("Category is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DuplicateName = True
                    Highlighter1.SetHighlightColor(txtCat, Validator.eHighlightColor.Red)
                    txtCat.Select()
                    Exit Sub
                Else
                    DuplicateName = False
                    Highlighter1.SetHighlightColor(txtCat, Validator.eHighlightColor.None)
                End If
            End If

            sqlSTR = "SELECT Cat_Code FROM tbl_Product_Category WHERE Cat_ID ='" & EditID & "'"
            ExecuteSQLQuery(sqlSTR)

            If UCase(sqlDT.Rows(0)("Cat_Code")) = UCase(txtCode.Text) Then
                DuplicateName = False
            Else
                sqlSTR = "SELECT Cat_Code FROM tbl_Product_Category WHERE Cat_Code ='" & txtCode.Text & "'"
                ExecuteSQLQuery(sqlSTR)
                If sqlDT.Rows.Count > 0 Then
                    MessageBoxEx.Show("Category Code is already on the list !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DuplicateName = True
                    Highlighter1.SetHighlightColor(txtCode, Validator.eHighlightColor.Red)
                    txtCode.Select()
                    Exit Sub
                Else
                    DuplicateName = False
                    Highlighter1.SetHighlightColor(txtCode, Validator.eHighlightColor.None)
                End If
            End If

            If DuplicateName = False Then
                sqlSTR = "UPDATE tbl_Product_Category SET Cat_Name ='" & txtCat.Text & "', Cat_Code = '" & UCase(txtCode.Text) & _
                         "' WHERE Cat_ID ='" & EditID & "'"
                ExecuteSQLQuery(sqlSTR)

                MessageBoxEx.Show("Record Successfully Updated...", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'UsersLogDetails("Edit Supplier Details", TimeOfDay.ToString("hh:mm:ss tt"))
            End If
        End If

        FrmProductsList.RefreshProducts()
        Me.Close()
    End Sub


End Class