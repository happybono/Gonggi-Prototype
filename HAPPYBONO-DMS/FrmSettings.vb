Imports System.Security.Principal

Public Class FrmSettings

    Private Sub btnInvSel_Click(sender As Object, e As EventArgs) Handles btnInvSel.Click
        If chbAQL1.CheckState = CheckState.Checked And
           chbAQL2.CheckState = CheckState.Checked And
           chbAQL3.CheckState = CheckState.Checked And
           chbAQL4.CheckState = CheckState.Checked And
           chbAQL5.CheckState = CheckState.Checked And
           chbAQL6.CheckState = CheckState.Checked And
           chbAQL7.CheckState = CheckState.Checked Then
            chbAQL1.CheckState = CheckState.Unchecked
            chbAQL2.CheckState = CheckState.Unchecked
            chbAQL3.CheckState = CheckState.Unchecked
            chbAQL4.CheckState = CheckState.Unchecked
            chbAQL5.CheckState = CheckState.Unchecked
            chbAQL6.CheckState = CheckState.Unchecked
            chbAQL7.CheckState = CheckState.Unchecked
        Else
            chbAQL1.CheckState = CheckState.Checked
            chbAQL2.CheckState = CheckState.Checked
            chbAQL3.CheckState = CheckState.Checked
            chbAQL4.CheckState = CheckState.Checked
            chbAQL5.CheckState = CheckState.Checked
            chbAQL6.CheckState = CheckState.Checked
            chbAQL7.CheckState = CheckState.Checked
        End If
    End Sub

    Private Sub invSelBtnLblChange()
        If CheckState.Checked And
           chbAQL1.CheckState = CheckState.Checked And
           chbAQL2.CheckState = CheckState.Checked And
           chbAQL3.CheckState = CheckState.Checked And
           chbAQL4.CheckState = CheckState.Checked And
           chbAQL5.CheckState = CheckState.Checked And
           chbAQL6.CheckState = CheckState.Checked And
           chbAQL7.CheckState = CheckState.Checked Then
            btnInvSel.Text = "전체 해제 (모든 알림 거부)"
            ToolStripStatusLabel1.Text = "미세먼지 등급에 따른 모든 알림을 전체 해제하고, 모든 알림을 거부합니다."
        Else
            btnInvSel.Text = "전체 선택 (모든 알림 수신)"
            ToolStripStatusLabel1.Text = "미세먼지 등급에 따른 모든 알림을 전체 선택하고. 모든 알림을 수신합니다."
        End If
    End Sub

    Private Sub LoadNotiAsAQILevel()

        Dim AQILvlList As String = My.Settings.NotiAQI

        If AQILvlList.Contains("1") Then chbAQL1.Checked = True
        If AQILvlList.Contains("2") Then chbAQL2.Checked = True
        If AQILvlList.Contains("3") Then chbAQL3.Checked = True
        If AQILvlList.Contains("4") Then chbAQL4.Checked = True
        If AQILvlList.Contains("5") Then chbAQL5.Checked = True
        If AQILvlList.Contains("6") Then chbAQL6.Checked = True
        If AQILvlList.Contains("7") Then chbAQL7.Checked = True
        If AQILvlList = Nothing Then Exit Sub
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveUpdateNotiSettings()
        SaveAdvSettings()
        SetAsStartup()
        SaveNotiAsAQILevel()
        SaveTrayUpdateSettings()

        My.Settings.Save()
        My.Settings.Reload()

        Try
            If chbStartup.Checked Then
                SetAsStartup()
            Else
                If StartupCheck() Then
                    RemoveFromStartup()
                End If
            End If
        Catch ex As Exception
            MsgBox("시작프로그램 설정 중 오류가 발생했습니다." + vbCr + "해당 설정을 제외한 설정은 저장됩니다.", vbCritical)
        End Try

        If My.Settings.IconUpdate = True Then
            MainForm.DisplayData()
        Else
            MainForm.GonggiIcon.Icon = My.Resources.Gonggi
            MainForm.Icon = My.Resources.Gonggi
        End If

        Me.Close()
    End Sub

    Private Sub SaveUpdateNotiSettings()
        My.Settings.AutoUpdate = chbUpdate.Checked
    End Sub

    Private Sub LoadUpdateNotiSettings()
        chbUpdate.Checked = My.Settings.AutoUpdate
    End Sub

    Private Sub SaveTrayUpdateSettings()
        My.Settings.IconUpdate = chbTrayIcon.Checked
    End Sub

    Private Sub LoadtrayUpdSettings()
        chbTrayIcon.Checked = My.Settings.IconUpdate
    End Sub

    Private Sub LoadAdvSettings()
        chbNotiSound.Checked = My.Settings.NotiWithSound
        chbNChgNoti.Checked = My.Settings.AQINoChgNoti
    End Sub

    Private Sub SaveAdvSettings()
        My.Settings.NotiWithSound = chbNotiSound.Checked
        My.Settings.AQINoChgNoti = chbNChgNoti.Checked
    End Sub

    Private Sub SaveNotiAsAQILevel()
        Dim AQILvlList As String = Nothing

        If chbAQL1.Checked Then AQILvlList += "1"
        If chbAQL2.Checked Then AQILvlList += "2"
        If chbAQL3.Checked Then AQILvlList += "3"
        If chbAQL4.Checked Then AQILvlList += "4"
        If chbAQL5.Checked Then AQILvlList += "5"
        If chbAQL6.Checked Then AQILvlList += "6"
        If chbAQL7.Checked Then AQILvlList += "7"

        My.Settings.NotiAQI = AQILvlList
    End Sub

    Private Function StartupCheck()
        Dim destlnk As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Gonggi.lnk"

        If IO.File.Exists(destlnk) Then
            If GetTargetPath(destlnk) = Application.ExecutablePath Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Function GetTargetPath(ByVal FileName As String)
        Dim Obj As Object
        Obj = CreateObject("WScript.Shell")
        Dim Shortcut As Object
        Shortcut = Obj.CreateShortcut(FileName)
        GetTargetPath = Shortcut.TargetPath
    End Function

    Private Sub LoadStartupReg()
        Try
            chbStartup.Checked = StartupCheck()
        Catch ex As Exception
            MsgBox("시작프로그램 설정 여부 확인 도중 오류가 발생했습니다.", vbCritical)
        End Try
    End Sub

    Private Sub SetAsStartup()
        Dim Path As String
        Dim identity = WindowsIdentity.GetCurrent()
        Dim principal = New WindowsPrincipal(identity)

        Path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Gonggi.lnk"

        Dim wsh As Object = CreateObject("WScript.Shell")

        Dim MyShortcut
        MyShortcut = wsh.CreateShortcut(Path)
        MyShortcut.TargetPath = wsh.ExpandEnvironmentStrings(Application.ExecutablePath)
        MyShortcut.WindowStyle = 4
        MyShortcut.Save()
    End Sub

    Sub RemoveFromStartup()
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup) & "\Gonggi.lnk")
    End Sub

    Private Sub chbAQL1_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL1.CheckedChanged
        invSelBtnLblChange()
    End Sub

    Private Sub chbAQL2_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL2.CheckedChanged
        invSelBtnLblChange()
    End Sub

    Private Sub chbAQL3_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL3.CheckedChanged
        invSelBtnLblChange()
    End Sub

    Private Sub chbAQL4_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL4.CheckedChanged
        invSelBtnLblChange()
    End Sub

    Private Sub chbAQL5_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL5.CheckedChanged
        invSelBtnLblChange()
    End Sub

    Private Sub chbAQL6_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL6.CheckedChanged
        invSelBtnLblChange()
    End Sub

    Private Sub chbAQL7_CheckedChanged(sender As Object, e As EventArgs) Handles chbAQL7.CheckedChanged
        invSelBtnLblChange()
    End Sub


#Region "<Behavior : Custom Controls>"
    Private Sub lblBtnGeneral_Click(sender As Object, e As EventArgs) Handles lblbtnGeneral.Click
        If pnlGeneral.Visible = True Then
            Exit Sub
        Else
            lblbtnGeneral.ForeColor = Color.Black
            lbliconGeneral.ForeColor = Color.Black
            lblbtnNoti.ForeColor = Color.Gray
            lbliconNoti.ForeColor = Color.Gray
            pnlSelect1.Visible = True
            pnlSelect2.Visible = False
            pnlGeneral.Visible = True
            pnlNoti.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub FrmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadUpdateNotiSettings()
        LoadNotiAsAQILevel()
        LoadStartupReg()
        LoadAdvSettings()
        LoadtrayUpdSettings()

        lblbtnGeneral.ForeColor = Color.Black
        lbliconGeneral.ForeColor = Color.Black
        lblbtnNoti.ForeColor = Color.Gray
        lbliconNoti.ForeColor = Color.Gray
        pnlSelect1.Visible = True
        pnlSelect2.Visible = False
        pnlGeneral.Visible = True
        pnlNoti.Visible = False
        Exit Sub
    End Sub

    Private Sub lbliconGeneral_Click(sender As Object, e As EventArgs) Handles lbliconGeneral.Click
        If pnlGeneral.Visible = True Then
            Exit Sub
        Else
            lblbtnGeneral.ForeColor = Color.Black
            lbliconGeneral.ForeColor = Color.Black
            lblbtnNoti.ForeColor = Color.Gray
            lbliconNoti.ForeColor = Color.Gray
            pnlSelect1.Visible = True
            pnlSelect2.Visible = False
            pnlGeneral.Visible = True
            pnlNoti.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub lbliconNoti_Click(sender As Object, e As EventArgs) Handles lbliconNoti.Click
        If pnlNoti.Visible = True Then
            Exit Sub
        Else
            lblbtnGeneral.ForeColor = Color.Gray
            lbliconGeneral.ForeColor = Color.Gray
            lblbtnNoti.ForeColor = Color.Black
            lbliconNoti.ForeColor = Color.Black
            pnlGeneral.Visible = False
            pnlNoti.Visible = True
            pnlSelect1.Visible = False
            pnlSelect2.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub lblbtnNoti_Click(sender As Object, e As EventArgs) Handles lblbtnNoti.Click
        If pnlNoti.Visible = True Then
            Exit Sub
        Else
            pnlNoti.Visible = True
            lblbtnGeneral.ForeColor = Color.Gray
            lbliconGeneral.ForeColor = Color.Gray
            lblbtnNoti.ForeColor = Color.Black
            lbliconNoti.ForeColor = Color.Black
            pnlGeneral.Visible = False
            pnlSelect1.Visible = False
            pnlSelect2.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnInvSel_MouseEnter(sender As Object, e As EventArgs) Handles btnInvSel.MouseEnter
        If CheckState.Checked And
   chbAQL1.CheckState = CheckState.Checked And
   chbAQL2.CheckState = CheckState.Checked And
   chbAQL3.CheckState = CheckState.Checked And
   chbAQL4.CheckState = CheckState.Checked And
   chbAQL5.CheckState = CheckState.Checked And
   chbAQL6.CheckState = CheckState.Checked And
   chbAQL7.CheckState = CheckState.Checked Then
            ToolStripStatusLabel1.Text = "미세먼지 등급에 따른 모든 알림을 전체 해제하고, 모든 알림을 거부합니다."
        Else
            ToolStripStatusLabel1.Text = "미세먼지 등급에 따른 모든 알림을 전체 선택하고. 모든 알림을 수신합니다."
        End If
    End Sub
#End Region

#Region "<ToolStripStatusLabel 툴 팁>"

    Private Sub chbAQL7_MouseHover(sender As Object, e As EventArgs) Handles chbAQL7.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [최악] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbAQL6_MouseHover(sender As Object, e As EventArgs) Handles chbAQL6.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [매우 나쁨] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbAQL5_MouseHover(sender As Object, e As EventArgs) Handles chbAQL5.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [나쁨] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbAQL4_MouseHover(sender As Object, e As EventArgs) Handles chbAQL4.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [조금 나쁨] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbAQL3_MouseHover(sender As Object, e As EventArgs) Handles chbAQL3.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [양호] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbAQL2_MouseHover(sender As Object, e As EventArgs) Handles chbAQL2.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [좋음] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbAQL1_MouseHover(sender As Object, e As EventArgs) Handles chbAQL1.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급이 [매우 좋음] 등급 일 때 미세먼지 알림을 받습니다."
    End Sub

    Private Sub chbNotiSound_MouseHover(sender As Object, e As EventArgs) Handles chbNotiSound.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 알림 창이 표시될 때 알림음을 재생합니다."
    End Sub

    Private Sub chbNChgNoti_MouseHover(sender As Object, e As EventArgs) Handles chbNChgNoti.MouseHover
        ToolStripStatusLabel1.Text = "이전 알림 후 미세먼지 등급에 변함이 없다면 알림 창을 표시하지 않습니다."
    End Sub

    Private Sub chbStartup_MouseHover(sender As Object, e As EventArgs) Handles chbStartup.MouseHover
        ToolStripStatusLabel1.Text = "PC 부팅 후 Windows 가 시작될 때 프로그램을 자동 실행합니댜."
    End Sub

    Private Sub chbTrayIcon_MouseHover(sender As Object, e As EventArgs) Handles chbTrayIcon.MouseHover
        ToolStripStatusLabel1.Text = "미세먼지 등급 변화에 따라 앱 아이콘의 모양도 변경합니다."
    End Sub

    Private Sub chbUpdate_MouseHover(sender As Object, e As EventArgs) Handles chbUpdate.MouseHover
        ToolStripStatusLabel1.Text = "프로그램 실행과 동시에 업데이트 여부를 확인한 후 업데이트 창을 표시합니다."
    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        ToolStripStatusLabel1.Text = "변경된 설정 값을 저장합니다. 개별 설정 값은 [저장] 버튼을 누른 직후 적용됩니다."
    End Sub

    Private Sub btnCancel_MouseHover(sender As Object, e As EventArgs) Handles btnCancel.MouseHover
        ToolStripStatusLabel1.Text = "변경하신 모든 내용을 저장하지 않습니다. 변경 내용 적용을 취소합니다."
    End Sub

    Private Sub FrmSettings_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub gbxNoti_MouseHover(sender As Object, e As EventArgs) Handles gbxNoti.MouseHover
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub gbxAdvanced_MouseHover(sender As Object, e As EventArgs) Handles gbxAdvanced.MouseHover
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub gbxStartup_MouseHover(sender As Object, e As EventArgs) Handles gbxStartup.MouseHover
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub gbxTrayIcon_MouseHover(sender As Object, e As EventArgs) Handles gbxTrayIcon.MouseHover
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub gbxUpdate_MouseHover(sender As Object, e As EventArgs) Handles gbxUpdate.MouseHover
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub chbNotiSound_MouseLeave(sender As Object, e As EventArgs) Handles chbNotiSound.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub chbNChgNoti_MouseLeave(sender As Object, e As EventArgs) Handles chbNChgNoti.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub chbStartup_MouseLeave(sender As Object, e As EventArgs) Handles chbStartup.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub chbTrayIcon_MouseLeave(sender As Object, e As EventArgs) Handles chbTrayIcon.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub chbUpdate_MouseLeave(sender As Object, e As EventArgs) Handles chbUpdate.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        ToolStripStatusLabel1.Text = "변경하실 항목을 선택하시거나 설정 값을 변경하세요."
    End Sub

#End Region

End Class