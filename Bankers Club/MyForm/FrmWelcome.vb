Imports DevComponents.DotNetBar

Public Class FrmWelcome
    Dim TmValue As Integer

    Public Sub New()
        StyleManager.MetroColorGeneratorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("EAEAEA"), ColorScheme.GetColor("4A8A2F"))
        'StyleManager.MetroColorGeneratorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(ColorScheme.GetColor("F5F5F5"), ColorScheme.GetColor("4A8A2F"))
        InitializeComponent()
        ToggleEndlessProgress.Execute()
    End Sub

    Private Sub ToggleEndlessProgress_Executed(ByVal sender As Object, ByVal e As EventArgs) Handles ToggleEndlessProgress.Executed
        Dim running As Boolean = Not ToggleEndlessProgress.Checked
        ToggleEndlessProgress.Checked = Not ToggleEndlessProgress.Checked

        If running Then
            ToggleEndlessProgress.Text = "Stop"
        Else
            ToggleEndlessProgress.Text = "Start"
        End If

        CircularProgress1.IsRunning = running
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TmValue += 5

        If TmValue = 100 Then
            Timer1.Dispose()
            FrmLogin.Show()
            ' FrmMain.Show()
            Me.Close()
        End If

    End Sub

    Private Sub FrmWelcome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True

        'If check_dt_trap() = True Then create_dt_trap()
        'check_trap()

        'If checkdt() = False Then
        '    Me.Enabled = False
        '    MessageBoxEx.Show("Please Contact Your Software Vendor. " & vbNewLine & "Cell : 01670397332, 01814435023 " & vbNewLine & "Web : www.signinit.com", "Critical ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End
        'Else
        '    Timer1.Enabled = True
        'End If
    End Sub

End Class