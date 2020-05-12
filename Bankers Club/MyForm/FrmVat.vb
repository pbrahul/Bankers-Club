Imports DevComponents.DotNetBar

Public Class FrmVat

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmVat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ExecuteSQLQuery("SELECT * FROM tbl_Vat")
        txtVat.Text = sqlDT.Rows(0)("Vat_Amount")
        If sqlDT.Rows(0)("Use_Vat") = "Yes" Then
            rbnSame.Checked = True
        Else
            rbnIndividual.Checked = True
        End If
        'rbnIndividual.Checked = IIf(sqlDT.Rows(0)("Use_Vat") = "Yes", True, False)
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        sqlSTR = "UPDATE tbl_Vat SET Vat_Amount = '" & txtVat.Text & "', Use_Vat = '" & IIf(rbnSame.Checked = True, "Yes", "No") & "' WHERE Vat_ID = 1"
        ExecuteSQLQuery(sqlSTR)
        MessageBoxEx.Show("Record Save Successfully..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub rbnSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSame.CheckedChanged
        If rbnSame.Checked = True Then
            txtVat.Enabled = True
        Else
            txtVat.Enabled = False
        End If
    End Sub

    Private Sub rbnIndividual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnIndividual.CheckedChanged
        txtVat.Enabled = False
    End Sub

    Private Sub txtVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVat.KeyPress
        NumKey(txtVat.Text, e)
    End Sub

End Class