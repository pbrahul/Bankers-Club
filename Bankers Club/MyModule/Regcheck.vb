Imports System
Imports System.Management
Imports Microsoft.Win32
Imports DevComponents.DotNetBar

Module Regcheck
    Dim pid As String
    Dim fit As String
    Dim icChar As String
    Dim DateFrmat As String = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Control Panel\International\", "sShortDate", "0")
    Dim stDate As Date = Date.Today.Date
    Dim stDateString As String

    Public Function GetProcessorId() As String
        Dim strProcessorId As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strProcessorId = info("processorId").ToString()
        Next
        Return strProcessorId
    End Function


    Public Function checkreg() As Boolean
        'pid = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Registry\Key", "PrimaryKey", "0")
        'fit = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Registry\Key", "RegistryKey", "0")
        pid = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Registry\Key", "PrimaryKey", "0")
        fit = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Registry\Key", "RegistryKey", "0")

        fit = Replace(fit, "-", "")

        If (Val(HexToDec(pid)) - Val(HexToDec(Decrypt(fit))) = 1178934565335655) Then
            checkreg = True
        Else
            checkreg = False
        End If
    End Function

    Public Sub Writevalue(ByVal abc As String)
        Dim regKey As RegistryKey
        Dim keyTop As RegistryKey = Registry.LocalMachine
        regKey = keyTop.OpenSubKey("Software\Microsoft\Registry\Key", True)

        If regKey Is Nothing Then
            regKey = keyTop.CreateSubKey("Software\Microsoft\Registry\Key")
        End If
        regKey.SetValue("RegistryKey", abc, RegistryValueKind.String)
    End Sub

    Public Function checkpid() As Boolean
        Dim keyTop As RegistryKey = Registry.LocalMachine
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Registry\Key\", "PrimaryKey", "") = "" Then
            checkpid = False
        Else
            checkpid = True
        End If
    End Function
    Public Sub Writepid()

        Dim regKey As RegistryKey
        Dim keyTop As RegistryKey = Registry.LocalMachine

        regKey = keyTop.OpenSubKey("Software\Microsoft\Registry\Key\", True)
        regKey = keyTop.CreateSubKey("Software\Microsoft\Registry\Key\")
        regKey.SetValue("PrimaryKey", GetProcessorId.ToString.Substring(3), RegistryValueKind.String)
    End Sub

    Public Function HexToDec(ByVal strHex As String) As Object
        Const cstrHexDigits As String = "0123456789ABCDEF"
        Dim decOut As Object
        Dim i As Integer

        decOut = CDec(0)
        For i = Len(strHex) To 1 Step -1
            decOut = decOut + CDec(16 ^ (Len(strHex) - i)) * (InStr(cstrHexDigits, Mid$(strHex, i, 1)) - 1)
        Next
        HexToDec = decOut
    End Function


    Public Sub create_dt_trap()

        Dim regKey1 As RegistryKey
        Dim regKey2 As RegistryKey
        Dim keyTop As RegistryKey = Registry.LocalMachine

        regKey1 = keyTop.OpenSubKey("Software\Microsoft\InstallDate", True)
        If regKey1 Is Nothing Then
            regKey1 = keyTop.CreateSubKey("Software\Microsoft\InstallDate")
            regKey1.SetValue("InstallDate", Today.Date.ToString(DateFrmat), RegistryValueKind.String)
        End If


        regKey2 = keyTop.OpenSubKey("Software\Microsoft\DayCount", True)

        If regKey2 Is Nothing Then
            regKey2 = keyTop.CreateSubKey("Software\Microsoft\DayCount")
        End If

        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") = "" Then
            regKey2.SetValue("DayCounter", "1", RegistryValueKind.String)
            Exit Sub
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "i", "") = 0 Then
            regKey2.SetValue("DayCounter", "0", RegistryValueKind.String)
        End If
    End Sub

    Public Function check_dt_trap() As Boolean

        Dim regKey1 As RegistryKey

        Dim keyTop As RegistryKey = Registry.LocalMachine
        'regKey1 = keyTop.OpenSubKey("Software\DT\DT", False)

        regKey1 = keyTop.OpenSubKey("Software\Microsoft\InstallDate", False)

        If regKey1 Is Nothing Then
            check_dt_trap = True
        Else
            check_dt_trap = False
        End If
    End Function

    Public Sub check_trap()
        Dim dt = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\InstallDate", "InstallDate", "")
        'Dim it = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount", "DayCounter", "")
        Dim k As Date
        k = Today.Date.ToString(DateFrmat)

        Dim regKey1 As RegistryKey
        Dim regKey2 As RegistryKey
        Dim keyTop As RegistryKey = Registry.LocalMachine

        If dt = "" Then
            regKey1 = keyTop.CreateSubKey("Software\Microsoft\InstallDate")
            regKey1.SetValue("InstallDate", Today.Date.ToString(DateFrmat), RegistryValueKind.String)
            Exit Sub
        Else
            If dt = Today.Date.ToString(DateFrmat) Then

            Else
                regKey1 = keyTop.OpenSubKey("Software\Microsoft\InstallDate", True)

                regKey2 = keyTop.OpenSubKey("Software\Microsoft\DayCount", True)

                If regKey2 Is Nothing Then
                    regKey2 = keyTop.CreateSubKey("Software\Microsoft\DayCount")
                End If

                'MsgBox(My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", ""))

                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") <= DateDiff(DateInterval.Day, dt, k) Then
                    regKey2.SetValue("DayCounter", DateDiff(DateInterval.Day, dt, k), RegistryValueKind.String)
                Else
                    Dim DayCont As String
                    DayCont = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "")
                    regKey2.SetValue("DayCounter", Val(DayCont) + 1, RegistryValueKind.String)

                End If
                'If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") <> 0 Then
                '    'Else
                '    '    'Dim Cont As Integer = DateDiff(DateInterval.Day, dt.ToString("MM/dd/yyyy"), k)
                '    'MsgBox(DateDiff(DateInterval.Day, dt, k))
                'End If
            End If

        End If
    End Sub


    Public Function checkdt() As Boolean
        checkdt = True
        If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") = 0 Then
            checkdt = True
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") = 360 Then
            MessageBoxEx.Show("Please Contact Your Software Vendor Immediately", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            checkdt = True
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") = 361 Then
            MessageBoxEx.Show("Please Contact Your Software Vendor Immediately", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            checkdt = True
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") = 362 Then
            MessageBoxEx.Show("Please Contact Your Software Vendor Immediately", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            checkdt = True
        ElseIf My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\DayCount\", "DayCounter", "") >= 363 Then
            checkdt = False
        End If
    End Function
End Module
