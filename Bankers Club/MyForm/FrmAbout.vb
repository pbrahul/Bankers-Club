Imports DevComponents.DotNetBar

Public Class FrmAbout
    Dim exFlag As Boolean = False

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProfile.Click
        PageSlider1.SelectedPage = PageSliderPage1
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWe.Click
        PageSlider1.SelectedPage = PageSliderPage2
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducts.Click
        PageSlider1.SelectedPage = PageSliderPage3
    End Sub

    Private Sub btnContact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContact.Click
        PageSlider1.SelectedPage = PageSliderPage4
    End Sub

    Private Sub FrmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PageSlider1.SelectedPage = PageSliderPage1

        exCable.Expanded = False
        exMulti.Expanded = False
        exParty.Expanded = False
        exSchool.Expanded = False
        exTailor.Expanded = False
        exPOS.Expanded = True
    End Sub


    'Private Sub FrmTransaction_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '    PageSlider1.Left = (Me.Width / 2) - 335
    '    PageSlider1.Top = (Me.Height / 2) - 270

    '    PictureBox6.Left = (Me.Width / 2) - 100
    '    PictureBox6.Top = (Me.Height / 2) - 350

    '    Page.Left = (Me.Width / 2) - 250
    '    Page.Top = Me.Height - 150
    'End Sub

    Private Sub exPOS_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles exPOS.ExpandedChanged
        If exPOS.Expanded = True Then
            exCable.Expanded = False
            exMulti.Expanded = False
            exParty.Expanded = False
            exSchool.Expanded = False
            exTailor.Expanded = False
        End If
    End Sub

    Private Sub exSchool_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles exSchool.ExpandedChanged
        If exSchool.Expanded = True Then
            exCable.Expanded = False
            exMulti.Expanded = False
            exPOS.Expanded = False
            exParty.Expanded = False
            exTailor.Expanded = False
        End If
    End Sub


    Private Sub exParty_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles exParty.ExpandedChanged
        If exParty.Expanded = True Then
            exCable.Expanded = False
            exMulti.Expanded = False
            exPOS.Expanded = False
            exSchool.Expanded = False
            exTailor.Expanded = False
        End If

    End Sub

    Private Sub exTailor_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles exTailor.ExpandedChanged
        If exTailor.Expanded Then
            exCable.Expanded = False
            exMulti.Expanded = False
            exPOS.Expanded = False
            exSchool.Expanded = False
            exParty.Expanded = False
        End If
    End Sub


    Private Sub exMulti_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles exMulti.ExpandedChanged
        If exMulti.Expanded = True Then
            exCable.Expanded = False
            exParty.Expanded = False
            exPOS.Expanded = False
            exSchool.Expanded = False
            exTailor.Expanded = False
        End If
    End Sub

    Private Sub exCable_ExpandedChanged(ByVal sender As Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs) Handles exCable.ExpandedChanged
        If exCable.Expanded = True Then
            exParty.Expanded = False
            exMulti.Expanded = False
            exPOS.Expanded = False
            exSchool.Expanded = False
            exTailor.Expanded = False
        End If
    End Sub



End Class