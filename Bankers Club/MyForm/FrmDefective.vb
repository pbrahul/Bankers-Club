Public Class FrmDefective

    Private Sub FrmDefective_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstSearch.BackColor = Color.White
        lstSearch.Visible = False
    End Sub

    Private Sub FrmUserAdd_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Text = "Return"
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class