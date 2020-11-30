<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettings))
        Me.pnlGeneral = New System.Windows.Forms.Panel()
        Me.gbxUpdate = New System.Windows.Forms.GroupBox()
        Me.chbUpdate = New System.Windows.Forms.CheckBox()
        Me.gbxTrayIcon = New System.Windows.Forms.GroupBox()
        Me.chbTrayIcon = New System.Windows.Forms.CheckBox()
        Me.gbxStartup = New System.Windows.Forms.GroupBox()
        Me.chbStartup = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbliconNoti = New System.Windows.Forms.Label()
        Me.lblbtnGeneral = New System.Windows.Forms.Label()
        Me.lblbtnNoti = New System.Windows.Forms.Label()
        Me.lbliconGeneral = New System.Windows.Forms.Label()
        Me.pnlSelect1 = New System.Windows.Forms.Panel()
        Me.pnlSelect2 = New System.Windows.Forms.Panel()
        Me.pnlNoti = New System.Windows.Forms.Panel()
        Me.gbxNoti = New System.Windows.Forms.GroupBox()
        Me.btnInvSel = New System.Windows.Forms.Button()
        Me.chbAQL7 = New System.Windows.Forms.CheckBox()
        Me.chbAQL6 = New System.Windows.Forms.CheckBox()
        Me.chbAQL5 = New System.Windows.Forms.CheckBox()
        Me.chbAQL4 = New System.Windows.Forms.CheckBox()
        Me.chbAQL3 = New System.Windows.Forms.CheckBox()
        Me.chbAQL2 = New System.Windows.Forms.CheckBox()
        Me.chbAQL1 = New System.Windows.Forms.CheckBox()
        Me.gbxAdvanced = New System.Windows.Forms.GroupBox()
        Me.chbNChgNoti = New System.Windows.Forms.CheckBox()
        Me.chbNotiSound = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlGeneral.SuspendLayout()
        Me.gbxUpdate.SuspendLayout()
        Me.gbxTrayIcon.SuspendLayout()
        Me.gbxStartup.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlNoti.SuspendLayout()
        Me.gbxNoti.SuspendLayout()
        Me.gbxAdvanced.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.gbxUpdate)
        Me.pnlGeneral.Controls.Add(Me.gbxTrayIcon)
        Me.pnlGeneral.Controls.Add(Me.gbxStartup)
        Me.pnlGeneral.Location = New System.Drawing.Point(-4, 98)
        Me.pnlGeneral.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(928, 577)
        Me.pnlGeneral.TabIndex = 0
        '
        'gbxUpdate
        '
        Me.gbxUpdate.Controls.Add(Me.chbUpdate)
        Me.gbxUpdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.gbxUpdate.Location = New System.Drawing.Point(92, 398)
        Me.gbxUpdate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxUpdate.Name = "gbxUpdate"
        Me.gbxUpdate.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxUpdate.Size = New System.Drawing.Size(744, 144)
        Me.gbxUpdate.TabIndex = 5
        Me.gbxUpdate.TabStop = False
        Me.gbxUpdate.Text = "업데이트 알림"
        '
        'chbUpdate
        '
        Me.chbUpdate.AutoSize = True
        Me.chbUpdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbUpdate.Location = New System.Drawing.Point(26, 67)
        Me.chbUpdate.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbUpdate.Name = "chbUpdate"
        Me.chbUpdate.Size = New System.Drawing.Size(654, 39)
        Me.chbUpdate.TabIndex = 4
        Me.chbUpdate.Text = "실행 시 업데이트가 필요한 경우 업데이트 창을 표시합니다."
        Me.chbUpdate.UseVisualStyleBackColor = True
        '
        'gbxTrayIcon
        '
        Me.gbxTrayIcon.Controls.Add(Me.chbTrayIcon)
        Me.gbxTrayIcon.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.gbxTrayIcon.Location = New System.Drawing.Point(92, 223)
        Me.gbxTrayIcon.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxTrayIcon.Name = "gbxTrayIcon"
        Me.gbxTrayIcon.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxTrayIcon.Size = New System.Drawing.Size(744, 144)
        Me.gbxTrayIcon.TabIndex = 3
        Me.gbxTrayIcon.TabStop = False
        Me.gbxTrayIcon.Text = "아이콘 표시 설정"
        '
        'chbTrayIcon
        '
        Me.chbTrayIcon.AutoSize = True
        Me.chbTrayIcon.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbTrayIcon.Location = New System.Drawing.Point(26, 67)
        Me.chbTrayIcon.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbTrayIcon.Name = "chbTrayIcon"
        Me.chbTrayIcon.Size = New System.Drawing.Size(571, 39)
        Me.chbTrayIcon.TabIndex = 4
        Me.chbTrayIcon.Text = "미세먼지 등급에 따라 트레이 아이콘을 변경합니다."
        Me.chbTrayIcon.UseVisualStyleBackColor = True
        '
        'gbxStartup
        '
        Me.gbxStartup.Controls.Add(Me.chbStartup)
        Me.gbxStartup.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.gbxStartup.Location = New System.Drawing.Point(92, 48)
        Me.gbxStartup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxStartup.Name = "gbxStartup"
        Me.gbxStartup.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxStartup.Size = New System.Drawing.Size(744, 144)
        Me.gbxStartup.TabIndex = 2
        Me.gbxStartup.TabStop = False
        Me.gbxStartup.Text = "시작 설정"
        '
        'chbStartup
        '
        Me.chbStartup.AutoSize = True
        Me.chbStartup.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbStartup.Location = New System.Drawing.Point(26, 67)
        Me.chbStartup.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbStartup.Name = "chbStartup"
        Me.chbStartup.Size = New System.Drawing.Size(584, 39)
        Me.chbStartup.TabIndex = 0
        Me.chbStartup.Text = "Windows 시작 시 프로그램을 자동으로 실행합니다."
        Me.chbStartup.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbliconNoti)
        Me.Panel1.Controls.Add(Me.lblbtnGeneral)
        Me.Panel1.Controls.Add(Me.lblbtnNoti)
        Me.Panel1.Controls.Add(Me.lbliconGeneral)
        Me.Panel1.Controls.Add(Me.pnlSelect1)
        Me.Panel1.Controls.Add(Me.pnlSelect2)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 96)
        Me.Panel1.TabIndex = 5
        '
        'lbliconNoti
        '
        Me.lbliconNoti.AutoSize = True
        Me.lbliconNoti.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.lbliconNoti.ForeColor = System.Drawing.Color.Gray
        Me.lbliconNoti.Location = New System.Drawing.Point(290, 29)
        Me.lbliconNoti.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbliconNoti.Name = "lbliconNoti"
        Me.lbliconNoti.Size = New System.Drawing.Size(55, 38)
        Me.lbliconNoti.TabIndex = 14
        Me.lbliconNoti.Text = ""
        '
        'lblbtnGeneral
        '
        Me.lblbtnGeneral.AutoSize = True
        Me.lblbtnGeneral.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblbtnGeneral.Location = New System.Drawing.Point(92, 19)
        Me.lblbtnGeneral.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblbtnGeneral.Name = "lblbtnGeneral"
        Me.lblbtnGeneral.Size = New System.Drawing.Size(178, 51)
        Me.lblbtnGeneral.TabIndex = 9
        Me.lblbtnGeneral.Tag = ""
        Me.lblbtnGeneral.Text = "기본 설정 "
        Me.lblbtnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblbtnNoti
        '
        Me.lblbtnNoti.AutoSize = True
        Me.lblbtnNoti.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblbtnNoti.ForeColor = System.Drawing.Color.Gray
        Me.lblbtnNoti.Location = New System.Drawing.Point(336, 19)
        Me.lblbtnNoti.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblbtnNoti.Name = "lblbtnNoti"
        Me.lblbtnNoti.Size = New System.Drawing.Size(178, 51)
        Me.lblbtnNoti.TabIndex = 10
        Me.lblbtnNoti.Tag = ""
        Me.lblbtnNoti.Text = "알림 설정 "
        Me.lblbtnNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbliconGeneral
        '
        Me.lbliconGeneral.AutoSize = True
        Me.lbliconGeneral.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.lbliconGeneral.Location = New System.Drawing.Point(46, 29)
        Me.lbliconGeneral.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbliconGeneral.Name = "lbliconGeneral"
        Me.lbliconGeneral.Size = New System.Drawing.Size(55, 38)
        Me.lbliconGeneral.TabIndex = 13
        Me.lbliconGeneral.Text = ""
        '
        'pnlSelect1
        '
        Me.pnlSelect1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnlSelect1.ForeColor = System.Drawing.Color.Transparent
        Me.pnlSelect1.Location = New System.Drawing.Point(54, 75)
        Me.pnlSelect1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlSelect1.Name = "pnlSelect1"
        Me.pnlSelect1.Size = New System.Drawing.Size(200, 4)
        Me.pnlSelect1.TabIndex = 11
        '
        'pnlSelect2
        '
        Me.pnlSelect2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnlSelect2.ForeColor = System.Drawing.Color.Transparent
        Me.pnlSelect2.Location = New System.Drawing.Point(300, 75)
        Me.pnlSelect2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlSelect2.Name = "pnlSelect2"
        Me.pnlSelect2.Size = New System.Drawing.Size(200, 4)
        Me.pnlSelect2.TabIndex = 12
        '
        'pnlNoti
        '
        Me.pnlNoti.Controls.Add(Me.gbxNoti)
        Me.pnlNoti.Controls.Add(Me.gbxAdvanced)
        Me.pnlNoti.Location = New System.Drawing.Point(-4, 98)
        Me.pnlNoti.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.pnlNoti.Name = "pnlNoti"
        Me.pnlNoti.Size = New System.Drawing.Size(928, 577)
        Me.pnlNoti.TabIndex = 7
        Me.pnlNoti.Visible = False
        '
        'gbxNoti
        '
        Me.gbxNoti.Controls.Add(Me.btnInvSel)
        Me.gbxNoti.Controls.Add(Me.chbAQL7)
        Me.gbxNoti.Controls.Add(Me.chbAQL6)
        Me.gbxNoti.Controls.Add(Me.chbAQL5)
        Me.gbxNoti.Controls.Add(Me.chbAQL4)
        Me.gbxNoti.Controls.Add(Me.chbAQL3)
        Me.gbxNoti.Controls.Add(Me.chbAQL2)
        Me.gbxNoti.Controls.Add(Me.chbAQL1)
        Me.gbxNoti.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.gbxNoti.Location = New System.Drawing.Point(92, 48)
        Me.gbxNoti.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxNoti.Name = "gbxNoti"
        Me.gbxNoti.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxNoti.Size = New System.Drawing.Size(744, 298)
        Me.gbxNoti.TabIndex = 3
        Me.gbxNoti.TabStop = False
        Me.gbxNoti.Text = "알림 받을 미세먼지 등급"
        '
        'btnInvSel
        '
        Me.btnInvSel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvSel.Location = New System.Drawing.Point(388, 194)
        Me.btnInvSel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnInvSel.Name = "btnInvSel"
        Me.btnInvSel.Size = New System.Drawing.Size(328, 56)
        Me.btnInvSel.TabIndex = 7
        Me.btnInvSel.Text = "전체 선택"
        Me.btnInvSel.UseVisualStyleBackColor = True
        '
        'chbAQL7
        '
        Me.chbAQL7.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL7.Location = New System.Drawing.Point(48, 60)
        Me.chbAQL7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL7.Name = "chbAQL7"
        Me.chbAQL7.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL7.TabIndex = 6
        Me.chbAQL7.Text = "최악"
        Me.chbAQL7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL7.UseVisualStyleBackColor = True
        '
        'chbAQL6
        '
        Me.chbAQL6.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL6.Location = New System.Drawing.Point(218, 60)
        Me.chbAQL6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL6.Name = "chbAQL6"
        Me.chbAQL6.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL6.TabIndex = 5
        Me.chbAQL6.Text = "매우 나쁨"
        Me.chbAQL6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL6.UseVisualStyleBackColor = True
        '
        'chbAQL5
        '
        Me.chbAQL5.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL5.Location = New System.Drawing.Point(388, 60)
        Me.chbAQL5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL5.Name = "chbAQL5"
        Me.chbAQL5.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL5.TabIndex = 4
        Me.chbAQL5.Text = "나쁨"
        Me.chbAQL5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL5.UseVisualStyleBackColor = True
        '
        'chbAQL4
        '
        Me.chbAQL4.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL4.Location = New System.Drawing.Point(558, 60)
        Me.chbAQL4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL4.Name = "chbAQL4"
        Me.chbAQL4.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL4.TabIndex = 3
        Me.chbAQL4.Text = "조금 나쁨"
        Me.chbAQL4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL4.UseVisualStyleBackColor = True
        '
        'chbAQL3
        '
        Me.chbAQL3.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL3.Location = New System.Drawing.Point(48, 112)
        Me.chbAQL3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL3.Name = "chbAQL3"
        Me.chbAQL3.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL3.TabIndex = 2
        Me.chbAQL3.Text = "양호"
        Me.chbAQL3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL3.UseVisualStyleBackColor = True
        '
        'chbAQL2
        '
        Me.chbAQL2.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL2.Location = New System.Drawing.Point(218, 112)
        Me.chbAQL2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL2.Name = "chbAQL2"
        Me.chbAQL2.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL2.TabIndex = 1
        Me.chbAQL2.Text = "좋음"
        Me.chbAQL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL2.UseVisualStyleBackColor = True
        '
        'chbAQL1
        '
        Me.chbAQL1.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbAQL1.Location = New System.Drawing.Point(388, 112)
        Me.chbAQL1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbAQL1.Name = "chbAQL1"
        Me.chbAQL1.Size = New System.Drawing.Size(158, 40)
        Me.chbAQL1.TabIndex = 0
        Me.chbAQL1.Text = "매우 좋음"
        Me.chbAQL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbAQL1.UseVisualStyleBackColor = True
        '
        'gbxAdvanced
        '
        Me.gbxAdvanced.Controls.Add(Me.chbNChgNoti)
        Me.gbxAdvanced.Controls.Add(Me.chbNotiSound)
        Me.gbxAdvanced.Font = New System.Drawing.Font("Microsoft NeoGothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.gbxAdvanced.Location = New System.Drawing.Point(92, 358)
        Me.gbxAdvanced.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxAdvanced.Name = "gbxAdvanced"
        Me.gbxAdvanced.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.gbxAdvanced.Size = New System.Drawing.Size(744, 185)
        Me.gbxAdvanced.TabIndex = 3
        Me.gbxAdvanced.TabStop = False
        Me.gbxAdvanced.Text = "세부 설정"
        '
        'chbNChgNoti
        '
        Me.chbNChgNoti.AutoSize = True
        Me.chbNChgNoti.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbNChgNoti.Location = New System.Drawing.Point(26, 115)
        Me.chbNChgNoti.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbNChgNoti.Name = "chbNChgNoti"
        Me.chbNChgNoti.Size = New System.Drawing.Size(680, 39)
        Me.chbNChgNoti.TabIndex = 1
        Me.chbNChgNoti.Text = "AQI 등급이 30분 전과 동일하다면 알림을 표시하지 않습니다."
        Me.chbNChgNoti.UseVisualStyleBackColor = True
        '
        'chbNotiSound
        '
        Me.chbNotiSound.AutoSize = True
        Me.chbNotiSound.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chbNotiSound.Location = New System.Drawing.Point(26, 63)
        Me.chbNotiSound.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chbNotiSound.Name = "chbNotiSound"
        Me.chbNotiSound.Size = New System.Drawing.Size(403, 39)
        Me.chbNotiSound.TabIndex = 0
        Me.chbNotiSound.Text = "알림 시 알림음도 함께 재생합니다."
        Me.chbNotiSound.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(458, 683)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(212, 56)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "변경 설정 저장"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(682, 683)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 56)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "취소"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 775)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(924, 46)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(417, 36)
        Me.ToolStripStatusLabel1.Text = "설정하실 항목의 설정 값을 변경하세요."
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 821)
        Me.Controls.Add(Me.pnlNoti)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "설정"
        Me.pnlGeneral.ResumeLayout(False)
        Me.gbxUpdate.ResumeLayout(False)
        Me.gbxUpdate.PerformLayout()
        Me.gbxTrayIcon.ResumeLayout(False)
        Me.gbxTrayIcon.PerformLayout()
        Me.gbxStartup.ResumeLayout(False)
        Me.gbxStartup.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlNoti.ResumeLayout(False)
        Me.gbxNoti.ResumeLayout(False)
        Me.gbxAdvanced.ResumeLayout(False)
        Me.gbxAdvanced.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGeneral As Panel
    Friend WithEvents gbxTrayIcon As GroupBox
    Friend WithEvents chbTrayIcon As CheckBox
    Friend WithEvents gbxStartup As GroupBox
    Friend WithEvents chbStartup As CheckBox
    Friend WithEvents gbxUpdate As GroupBox
    Friend WithEvents chbUpdate As CheckBox
    Friend WithEvents lbliconNoti As Label
    Friend WithEvents lblbtnGeneral As Label
    Friend WithEvents lblbtnNoti As Label
    Friend WithEvents lbliconGeneral As Label
    Friend WithEvents pnlSelect1 As Panel
    Friend WithEvents pnlSelect2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlNoti As Panel
    Friend WithEvents gbxNoti As GroupBox
    Friend WithEvents btnInvSel As Button
    Friend WithEvents chbAQL7 As CheckBox
    Friend WithEvents chbAQL6 As CheckBox
    Friend WithEvents chbAQL5 As CheckBox
    Friend WithEvents chbAQL4 As CheckBox
    Friend WithEvents chbAQL3 As CheckBox
    Friend WithEvents chbAQL2 As CheckBox
    Friend WithEvents chbAQL1 As CheckBox
    Friend WithEvents gbxAdvanced As GroupBox
    Friend WithEvents chbNChgNoti As CheckBox
    Friend WithEvents chbNotiSound As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
