Imports System.IO
Imports System.Net

Public Class FrmUpdate
    Private WithEvents httpclient As WebClient
    Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal revert As Integer) As Integer
    Private Declare Function EnableMenuItem Lib "user32" (ByVal menu As Integer, ByVal ideEnableItem As Integer, ByVal enable As Integer) As Integer
    Private Const SC_CLOSE As Integer = &HF060
    Private Const MF_BYCOMMAND As Integer = &H0
    Private Const MF_GRAYED As Integer = &H1
    Private Const MF_ENABLED As Integer = &H0

    Dim src As String = getSrc("https://onedrive.live.com/download?cid=406282C4FD4D2A6B&resid=406282C4FD4D2A6B%21535352&authkey=AGCVQXOlz6pU47Y")
    Dim srcv() As String = src.Split(",") '0 = version number / 1 = download url
    Dim updsummary As String = getSrc("https://onedrive.live.com/download?cid=406282C4FD4D2A6B&resid=406282C4FD4D2A6B%21535353&authkey=AK_h93IisgSk064")

    Public Shared Sub Disable(ByVal form As System.Windows.Forms.Form)
        Select Case EnableMenuItem(GetSystemMenu(form.Handle.ToInt32, 0), SC_CLOSE, MF_BYCOMMAND Or MF_GRAYED)
            Case MF_ENABLED
            Case MF_GRAYED
            Case &HFFFFFFFF
                Throw New Exception("닫기 버튼이 존재하지 않습니다.")
            Case Else
        End Select
    End Sub

    Public Function GetDownloadSize(ByVal URL As String) As String
        Dim r As Net.WebRequest = Net.WebRequest.Create(URL)
        r.Method = Net.WebRequestMethods.Http.Head
        Using rsp = r.GetResponse()
            Return rsp.ContentLength
        End Using
    End Function

    Private Sub LinkLabelRemoveUnderline(Link As LinkLabel)
        Link.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
    End Sub
    Private Function getSrc(ByVal url As String)
        Dim r As HttpWebRequest = HttpWebRequest.Create(url)
        Dim re As HttpWebResponse = r.GetResponse()
        Dim src As String = New StreamReader(re.GetResponseStream()).ReadToEnd()
        Return src
    End Function

    Private Sub FrmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            FrmUpdate.Disable(Me) 'Disable X Button

            lblCVer.Text = Application.ProductVersion
            lblUPVer.Text = srcv(0)
            lblTTLChangelog.Text = srcv(0) & " " & "버전의 새로운 기능"
            lblChangeLog.Text = updsummary

            If srcv(0) <= Application.ProductVersion Then
                lblUPDStatus.Text = "공기 앱이 최신 버전입니다."
                lblTTLUPVer.Text = "현재 버전 :"
                lblTTLDLSize.Text = "배포 일자 :"
                lblUPVer.Text = Application.ProductVersion
                lblDLSize.Text = "2020년 08월 20일"
                lblTTLDLProgs.Visible = False
                lblDLProgs.Visible = False
                btnUpdate.Visible = False
                linkRelNotes.Visible = False
                lblTTLCVer.Visible = False
                lblTTLRelDate.Visible = False
                lblCVer.Visible = False
                lblRelDate.Visible = False
                btnUpdate.Enabled = False

                lblTTLChangelog.Visible = False
                lblChangeLog.Visible = False
                lineSeparator.Visible = False


            ElseIf (srcv(0) > Application.ProductVersion) Then
                lblTTLDLProgs.Visible = True
                lblDLProgs.Visible = True
                linkRelNotes.Visible = True
                lblTTLCVer.Visible = True
                lblTTLRelDate.Visible = True
                lblCVer.Visible = True
                lblRelDate.Visible = True
                btnUpdate.Visible = True
                lblTTLChangelog.Visible = True
                lblChangeLog.Visible = True
                lineSeparator.Visible = True

                lblUPDStatus.Text = "최신 버전이 확인되었습니다. 업데이트를 진행할 수 있습니다."
                lblCVer.ForeColor = Color.Gray
                lblTTLCVer.ForeColor = Color.Gray
                lblTTLRelDate.ForeColor = Color.Gray
                lblRelDate.ForeColor = Color.Gray
                lblTTLDLSize.ForeColor = Color.Black
                lblTTLUPVer.ForeColor = Color.Black
                lblTTLDLProgs.ForeColor = Color.Black
                lblDLSize.Text = "약 " & Math.Round(GetDownloadSize(srcv(1)) / 1024 / 1024, 2) & " " & "MB"
                btnUpdate.Enabled = True
                lblCVer.Text = Application.ProductVersion
                lblRelDate.Text = "2020년 08월 20일"
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            httpclient = New WebClient
            AddHandler(httpclient.DownloadFileCompleted), AddressOf Downloaded
            httpclient.DownloadFileAsync(New Uri(srcv(1)), (My.Computer.FileSystem.SpecialDirectories.Temp & "\Gonggi.msi"))
            '         ToolStripStatusPercentage.Visible = True
            '         ToolStripStatusLabel.Width = 1245
            '         UpdateButton.Enabled = False
            '         CloseButton.Enabled = False
        Catch ex As Exception
            MessageBox.Show("인터넷 연결이 불안정한 상태이거나" & vbCrLf & "업데이트 파일을 찾을 수 없습니다.", "Gonggi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    '  Private Sub dpc(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles httpclient.DownloadProgressChanged
    '      ToolStripStatusPercentage.Visible = True
    '      ModifyProgressBarColor.SetState(ProgressBar, 3)
    '      ToolStripStatusLabel.Width = 1145
    '      ProgressBar.Value = e.ProgressPercentage
    '      ToolStripStatusPercentage.Text = e.ProgressPercentage & " " & "%"
    '      ToolStripStatusLabel.Text = "업데이트에 필요한 파일을 다운로드 하는 중입니다."
    '  End Sub

    Private Sub Downloaded()
        '       ToolStripStatusLabel.Text = "다운로드가 성공적으로 완료되었습니다."
        '       ProgressBar.Value = 100
        MessageBox.Show("업데이트에 필요한 파일들을 모두 다운로드했습니다." & vbCrLf & vbCrLf & "업데이트를 적용하려면 안내에 따라 설치를 진행하신 후" & vbCrLf & "공기 앱을 재실행하세요." & vbCrLf & vbCrLf & "현재 실행 중인 인스턴스가 자동으로 종료됩니다.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        If System.IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.Temp & "\Gonggi.msi") = True Then
            System.Diagnostics.Process.Start(My.Computer.FileSystem.SpecialDirectories.Temp & "\Gonggi.msi")
            Application.Exit()
        Else
            MessageBox.Show("업데이트 파일을 찾을 수 없습니다.", "Gonggi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub linkRelNotes_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkRelNotes.LinkClicked
        frmUpdateLog.ShowDialog()
    End Sub
End Class