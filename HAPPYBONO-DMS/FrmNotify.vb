Public Class FrmNotify

#Region "AeroShadow Effect"
    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub
#End Region

#Region "Fade-In Transition"
    Dim MouseOn = False

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Refresh()
        FadeIn(Me, 1)
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
#End Region


    Private Sub FrmNotify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim margin As Integer = dpicalc(Me, 10)
        Dim showx = 0
        Dim showy = 0

        showx = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - margin
        showy = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - margin

        Select Case Convert.ToInt32(Mid(My.Settings.NotiPosition, 2, 1))
            Case 0 '우하단
                showx = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - margin
                showy = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - margin

            Case 1 '우상단
                showx = Screen.PrimaryScreen.WorkingArea.Width - Me.Width - margin
                showy = margin

            Case 2 '좌하단
                showx = margin
                showy = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - margin

            Case 3 '좌상단
                showx = margin
                showy = margin
        End Select

        If My.Settings.NotiWithSound = True Then My.Computer.Audio.Play(My.Resources.Notification, AudioPlayMode.Background)
        Me.SetDesktopLocation(showx, showy)

        LoadingTimer.Start()
    End Sub

    Private Sub CloseBT_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CloseBT_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        sender.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.5)
    End Sub

    Private Sub CloseBT_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        sender.BackColor = TopPanel.BackColor
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        TransitionTimer.Start()
        LoadingTimer.Stop()
    End Sub

    Private Sub TransitionTimer_Tick(sender As Object, e As EventArgs) Handles TransitionTimer.Tick
        If MouseOn Then
            If Not Opacity = 1 Then
                Opacity += 0.02
            End If
        Else
            If Opacity > 0.8 Then
                Opacity -= 0.02
            Else
                TransitionTimer.Stop()
            End If
        End If
    End Sub


    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        If MainForm.Visible = False Or MainForm.WindowState = FormWindowState.Minimized Then
            MainForm.Show()
            MainForm.Visible = True
            MainForm.WindowState = FormWindowState.Normal
            MainForm.Activate()
        Else
            MainForm.Show()
            MainForm.Activate()
        End If
    End Sub

    Private Sub btnMain_MouseEnter(sender As Object, e As EventArgs) Handles btnMain.MouseEnter
        sender.BackColor = ControlPaint.Light(TopPanel.BackColor, 0.5)
    End Sub

    Private Sub btnMain_MouseLeave(sender As Object, e As EventArgs) Handles btnMain.MouseLeave
        sender.BackColor = TopPanel.BackColor
    End Sub

    Private Sub TitleLabel_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        TransitionTimer.Start()
        MouseOn = True
    End Sub

    Private Sub TitleLabel_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        MouseOn = False
    End Sub

    Private Sub MainPanel_MouseEnter(sender As Object, e As EventArgs) Handles MainPanel.MouseEnter
        TransitionTimer.Start()
        MouseOn = True
    End Sub

    Private Sub MainPanel_MouseLeave(sender As Object, e As EventArgs) Handles MainPanel.MouseLeave
        MouseOn = False
    End Sub

    Private Sub AQIPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles AQIPictureBox.MouseEnter
        TransitionTimer.Start()
        MouseOn = True
    End Sub

    Private Sub AQIPictureBox_MouseLeave(sender As Object, e As EventArgs) Handles AQIPictureBox.MouseLeave
        MouseOn = False
    End Sub

    Private Sub lblAirComment_MouseEnter(sender As Object, e As EventArgs) Handles lblAirComment.MouseEnter
        TransitionTimer.Start()
        MouseOn = True
    End Sub
    Private Sub lblAirComment_MouseLeave(sender As Object, e As EventArgs) Handles lblAirComment.MouseLeave
        MouseOn = False
    End Sub

    Private Sub lblAirContents_MouseEnter(sender As Object, e As EventArgs) Handles lblAirContents.MouseEnter
        TransitionTimer.Start()
        MouseOn = True
    End Sub

    Private Sub lblAirContents_MouseLeave(sender As Object, e As EventArgs) Handles lblAirContents.MouseLeave
        MouseOn = False
    End Sub

    Private Sub lblAirState_MouseEnter(sender As Object, e As EventArgs) Handles lblAirState.MouseEnter
        TransitionTimer.Start()
        MouseOn = True
    End Sub

    Private Sub lblAirState_MouseLeave(sender As Object, e As EventArgs) Handles lblAirState.MouseLeave
        MouseOn = False
    End Sub
End Class