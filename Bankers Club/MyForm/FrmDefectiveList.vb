Public Class FrmDefectiveList

    Private Sub FrmDefectiveList_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        panProducts.Width = (FrmMain.Width / 2) + 450
        panProducts.Height = FrmMain.Height - 150
        panProducts.Left = (Me.Width / 2) - 570
        panProducts.Top = (FrmMain.Height / 2) - 370

        dtpReturn.Left = panProducts.Width - 215
        lblReturn.Left = dtpReturn.Left - 90

        dgvPurchase.Width = panProducts.Width - 28
        dgvProduct.Width = panProducts.Width - 37
        dgvProduct.Height = panProducts.Height - 320

    End Sub

  
End Class