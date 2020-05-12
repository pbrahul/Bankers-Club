Imports DevComponents.DotNetBar

Public Class FrmMemberPrint

    Private Sub FrmFeePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Point(437, 223)

        SingleComboBox("SELECT DISTINCT Bank_Name FROM tbl_member ORDER BY Bank_Name ASC", cmbBank)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptReport As New FrmReports

        If rbnBank.Checked = True Then
            RptStr = "SELECT Mem_ID, Mem_Name, Bank_Name, Bank_Designation, Branch, Mem_Contact, Pre_Address, Mem_Email FROM tbl_Member WHERE Bank_Name='" & cmbBank.Text & "' ORDER BY LPAD(LOWER(Mem_ID), 10,0) ASC"
            globalFRM = "MemberListBank"

            rptReport.Show()

        ElseIf rbnAll.Checked = True Then
            RptStr = "SELECT Mem_ID, Mem_Name, Bank_Name, Bank_Designation, Mem_Contact, Mem_Email FROM tbl_Member ORDER BY LPAD(LOWER(Mem_ID), 10,0) ASC"
            globalFRM = "MemberList"
        End If


        rptReport.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class