<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNotify
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.lblAirState = New System.Windows.Forms.Label()
        Me.lblAirComment = New System.Windows.Forms.Label()
        Me.lblAirContents = New System.Windows.Forms.Label()
        Me.AQIPictureBox = New System.Windows.Forms.PictureBox()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.btnMain = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.TransitionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LoadingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MainPanel.SuspendLayout()
        CType(Me.AQIPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        CType(Me.btnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Controls.Add(Me.lblAirState)
        Me.MainPanel.Controls.Add(Me.lblAirComment)
        Me.MainPanel.Controls.Add(Me.lblAirContents)
        Me.MainPanel.Controls.Add(Me.AQIPictureBox)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 60)
        Me.MainPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(24, 0, 24, 31)
        Me.MainPanel.Size = New System.Drawing.Size(772, 254)
        Me.MainPanel.TabIndex = 12
        '
        'lblAirState
        '
        Me.lblAirState.BackColor = System.Drawing.Color.Transparent
        Me.lblAirState.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAirState.Font = New System.Drawing.Font("Microsoft NeoGothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAirState.ForeColor = System.Drawing.Color.Black
        Me.lblAirState.Location = New System.Drawing.Point(186, 40)
        Me.lblAirState.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAirState.Name = "lblAirState"
        Me.lblAirState.Padding = New System.Windows.Forms.Padding(10, 6, 0, 4)
        Me.lblAirState.Size = New System.Drawing.Size(562, 79)
        Me.lblAirState.TabIndex = 8
        Me.lblAirState.Text = "로드 중"
        Me.lblAirState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAirComment
        '
        Me.lblAirComment.BackColor = System.Drawing.Color.Transparent
        Me.lblAirComment.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAirComment.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAirComment.ForeColor = System.Drawing.Color.Black
        Me.lblAirComment.Location = New System.Drawing.Point(186, 0)
        Me.lblAirComment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAirComment.Name = "lblAirComment"
        Me.lblAirComment.Padding = New System.Windows.Forms.Padding(22, 0, 0, 0)
        Me.lblAirComment.Size = New System.Drawing.Size(562, 40)
        Me.lblAirComment.TabIndex = 10
        Me.lblAirComment.Text = "잠시만 기다려 주세요"
        Me.lblAirComment.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAirContents
        '
        Me.lblAirContents.BackColor = System.Drawing.Color.Transparent
        Me.lblAirContents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAirContents.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAirContents.ForeColor = System.Drawing.Color.Black
        Me.lblAirContents.Location = New System.Drawing.Point(186, 115)
        Me.lblAirContents.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAirContents.Name = "lblAirContents"
        Me.lblAirContents.Padding = New System.Windows.Forms.Padding(22, 2, 0, 0)
        Me.lblAirContents.Size = New System.Drawing.Size(562, 108)
        Me.lblAirContents.TabIndex = 9
        Me.lblAirContents.Text = "pm 2.5 : 15 µg / m³" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pm 10.0 : 15 µg / m³" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "알림 수신 : 2018-06-23 20:00 "
        '
        'AQIPictureBox
        '
        Me.AQIPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.AQIPictureBox.Image = Global.HAPPYBONO_DMS.My.Resources.Resources.DustLv1
        Me.AQIPictureBox.Location = New System.Drawing.Point(24, 0)
        Me.AQIPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AQIPictureBox.Name = "AQIPictureBox"
        Me.AQIPictureBox.Size = New System.Drawing.Size(162, 223)
        Me.AQIPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AQIPictureBox.TabIndex = 7
        Me.AQIPictureBox.TabStop = False
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TopPanel.Controls.Add(Me.btnMain)
        Me.TopPanel.Controls.Add(Me.lblTitle)
        Me.TopPanel.Controls.Add(Me.btnClose)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TopPanel.Size = New System.Drawing.Size(772, 60)
        Me.TopPanel.TabIndex = 11
        '
        'btnMain
        '
        Me.btnMain.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMain.Image = Global.HAPPYBONO_DMS.My.Resources.Resources.MainIcon
        Me.btnMain.Location = New System.Drawing.Point(584, 0)
        Me.btnMain.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.Size = New System.Drawing.Size(94, 60)
        Me.btnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMain.TabIndex = 6
        Me.btnMain.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(10, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(668, 60)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "실시간 대기 알림 (최근 30분간 평균)"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.Image = Global.HAPPYBONO_DMS.My.Resources.Resources.CloseIcon
        Me.btnClose.Location = New System.Drawing.Point(678, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 60)
        Me.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        '
        'TransitionTimer
        '
        Me.TransitionTimer.Interval = 20
        '
        'LoadingTimer
        '
        Me.LoadingTimer.Enabled = True
        Me.LoadingTimer.Interval = 5000
        '
        'FrmNotify
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 314)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmNotify"
        Me.Text = "실시간 대기 알림"
        Me.TopMost = True
        Me.MainPanel.ResumeLayout(False)
        CType(Me.AQIPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        CType(Me.btnMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents lblAirState As Label
    Friend WithEvents lblAirComment As Label
    Friend WithEvents lblAirContents As Label
    Friend WithEvents AQIPictureBox As PictureBox
    Friend WithEvents TopPanel As Panel
    Friend WithEvents btnMain As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As PictureBox
    Friend WithEvents TransitionTimer As Timer
    Friend WithEvents LoadingTimer As Timer
End Class
