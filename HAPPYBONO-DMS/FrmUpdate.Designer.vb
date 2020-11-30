<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUpdate))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbliconInfo = New System.Windows.Forms.Label()
        Me.lblUPDStatus = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblTTLUPVer = New System.Windows.Forms.Label()
        Me.lblTTLDLSize = New System.Windows.Forms.Label()
        Me.lblTTLDLProgs = New System.Windows.Forms.Label()
        Me.lblTTLCVer = New System.Windows.Forms.Label()
        Me.lblTTLRelDate = New System.Windows.Forms.Label()
        Me.lblTTLChangelog = New System.Windows.Forms.Label()
        Me.lblChangeLog = New System.Windows.Forms.Label()
        Me.lblUPVer = New System.Windows.Forms.Label()
        Me.lblDLProgs = New System.Windows.Forms.Label()
        Me.lblCVer = New System.Windows.Forms.Label()
        Me.lblRelDate = New System.Windows.Forms.Label()
        Me.lblDLSize = New System.Windows.Forms.Label()
        Me.linkRelNotes = New System.Windows.Forms.LinkLabel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lineSeparator = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbliconInfo)
        Me.Panel1.Controls.Add(Me.lblUPDStatus)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 113)
        Me.Panel1.TabIndex = 0
        '
        'lbliconInfo
        '
        Me.lbliconInfo.AutoSize = True
        Me.lbliconInfo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliconInfo.Location = New System.Drawing.Point(12, 74)
        Me.lbliconInfo.Name = "lbliconInfo"
        Me.lbliconInfo.Size = New System.Drawing.Size(28, 19)
        Me.lbliconInfo.TabIndex = 38
        Me.lbliconInfo.Text = ""
        '
        'lblUPDStatus
        '
        Me.lblUPDStatus.AutoSize = True
        Me.lblUPDStatus.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUPDStatus.ForeColor = System.Drawing.Color.Black
        Me.lblUPDStatus.Location = New System.Drawing.Point(39, 69)
        Me.lblUPDStatus.Name = "lblUPDStatus"
        Me.lblUPDStatus.Size = New System.Drawing.Size(475, 26)
        Me.lblUPDStatus.TabIndex = 37
        Me.lblUPDStatus.Tag = ""
        Me.lblUPDStatus.Text = "최신 버전이 확인되었습니다. 업데이트를 진행할 수 있습니다."
        Me.lblUPDStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft NeoGothic", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 13)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(197, 36)
        Me.lblTitle.TabIndex = 12
        Me.lblTitle.Text = "공기 앱 업데이트"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(26, 139)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(63, 21)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "Gonggi"
        '
        'lblTTLUPVer
        '
        Me.lblTTLUPVer.AutoSize = True
        Me.lblTTLUPVer.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTTLUPVer.ForeColor = System.Drawing.Color.Gray
        Me.lblTTLUPVer.Location = New System.Drawing.Point(27, 176)
        Me.lblTTLUPVer.Name = "lblTTLUPVer"
        Me.lblTTLUPVer.Size = New System.Drawing.Size(95, 17)
        Me.lblTTLUPVer.TabIndex = 2
        Me.lblTTLUPVer.Text = "업데이트 버전 : "
        '
        'lblTTLDLSize
        '
        Me.lblTTLDLSize.AutoSize = True
        Me.lblTTLDLSize.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTLDLSize.ForeColor = System.Drawing.Color.Gray
        Me.lblTTLDLSize.Location = New System.Drawing.Point(27, 206)
        Me.lblTTLDLSize.Name = "lblTTLDLSize"
        Me.lblTTLDLSize.Size = New System.Drawing.Size(95, 17)
        Me.lblTTLDLSize.TabIndex = 3
        Me.lblTTLDLSize.Text = "다운로드 용량 : "
        '
        'lblTTLDLProgs
        '
        Me.lblTTLDLProgs.AutoSize = True
        Me.lblTTLDLProgs.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTLDLProgs.ForeColor = System.Drawing.Color.Gray
        Me.lblTTLDLProgs.Location = New System.Drawing.Point(27, 235)
        Me.lblTTLDLProgs.Name = "lblTTLDLProgs"
        Me.lblTTLDLProgs.Size = New System.Drawing.Size(95, 17)
        Me.lblTTLDLProgs.TabIndex = 4
        Me.lblTTLDLProgs.Text = "다운로드 진행 : "
        '
        'lblTTLCVer
        '
        Me.lblTTLCVer.AutoSize = True
        Me.lblTTLCVer.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTLCVer.ForeColor = System.Drawing.Color.Gray
        Me.lblTTLCVer.Location = New System.Drawing.Point(27, 337)
        Me.lblTTLCVer.Name = "lblTTLCVer"
        Me.lblTTLCVer.Size = New System.Drawing.Size(71, 17)
        Me.lblTTLCVer.TabIndex = 6
        Me.lblTTLCVer.Text = "현재 버전 : "
        '
        'lblTTLRelDate
        '
        Me.lblTTLRelDate.AutoSize = True
        Me.lblTTLRelDate.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTLRelDate.ForeColor = System.Drawing.Color.Gray
        Me.lblTTLRelDate.Location = New System.Drawing.Point(27, 365)
        Me.lblTTLRelDate.Name = "lblTTLRelDate"
        Me.lblTTLRelDate.Size = New System.Drawing.Size(67, 17)
        Me.lblTTLRelDate.TabIndex = 7
        Me.lblTTLRelDate.Text = "배포 일자 :"
        '
        'lblTTLChangelog
        '
        Me.lblTTLChangelog.AutoSize = True
        Me.lblTTLChangelog.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTTLChangelog.Location = New System.Drawing.Point(353, 139)
        Me.lblTTLChangelog.Name = "lblTTLChangelog"
        Me.lblTTLChangelog.Size = New System.Drawing.Size(187, 21)
        Me.lblTTLChangelog.TabIndex = 8
        Me.lblTTLChangelog.Text = "v1.0.0.0 버전의 추가된 기능"
        '
        'lblChangeLog
        '
        Me.lblChangeLog.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblChangeLog.ForeColor = System.Drawing.Color.Gray
        Me.lblChangeLog.Location = New System.Drawing.Point(354, 176)
        Me.lblChangeLog.Name = "lblChangeLog"
        Me.lblChangeLog.Size = New System.Drawing.Size(347, 207)
        Me.lblChangeLog.TabIndex = 9
        Me.lblChangeLog.Text = "초기 릴리즈 버전입니다."
        '
        'lblUPVer
        '
        Me.lblUPVer.AutoSize = True
        Me.lblUPVer.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUPVer.Location = New System.Drawing.Point(131, 176)
        Me.lblUPVer.Name = "lblUPVer"
        Me.lblUPVer.Size = New System.Drawing.Size(43, 17)
        Me.lblUPVer.TabIndex = 11
        Me.lblUPVer.Text = "1.3.0.0"
        '
        'lblDLProgs
        '
        Me.lblDLProgs.AutoSize = True
        Me.lblDLProgs.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDLProgs.Location = New System.Drawing.Point(131, 235)
        Me.lblDLProgs.Name = "lblDLProgs"
        Me.lblDLProgs.Size = New System.Drawing.Size(106, 17)
        Me.lblDLProgs.TabIndex = 13
        Me.lblDLProgs.Text = "100% 다운로드 됨"
        '
        'lblCVer
        '
        Me.lblCVer.AutoSize = True
        Me.lblCVer.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblCVer.Location = New System.Drawing.Point(131, 337)
        Me.lblCVer.Name = "lblCVer"
        Me.lblCVer.Size = New System.Drawing.Size(43, 17)
        Me.lblCVer.TabIndex = 14
        Me.lblCVer.Text = "1.0.0.0"
        '
        'lblRelDate
        '
        Me.lblRelDate.AutoSize = True
        Me.lblRelDate.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblRelDate.Location = New System.Drawing.Point(131, 365)
        Me.lblRelDate.Name = "lblRelDate"
        Me.lblRelDate.Size = New System.Drawing.Size(101, 17)
        Me.lblRelDate.TabIndex = 15
        Me.lblRelDate.Text = "2020년 8월 20일"
        '
        'lblDLSize
        '
        Me.lblDLSize.AutoSize = True
        Me.lblDLSize.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDLSize.Location = New System.Drawing.Point(131, 206)
        Me.lblDLSize.Name = "lblDLSize"
        Me.lblDLSize.Size = New System.Drawing.Size(48, 17)
        Me.lblDLSize.TabIndex = 16
        Me.lblDLSize.Text = "8.7 MB"
        '
        'linkRelNotes
        '
        Me.linkRelNotes.AutoSize = True
        Me.linkRelNotes.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkRelNotes.LinkColor = System.Drawing.Color.RoyalBlue
        Me.linkRelNotes.Location = New System.Drawing.Point(27, 266)
        Me.linkRelNotes.Name = "linkRelNotes"
        Me.linkRelNotes.Size = New System.Drawing.Size(102, 16)
        Me.linkRelNotes.TabIndex = 17
        Me.linkRelNotes.TabStop = True
        Me.linkRelNotes.Text = "업데이트 세부 사항"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(483, 406)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(106, 29)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "업데이트"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(595, 406)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(106, 29)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "닫기"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lineSeparator})
        Me.ShapeContainer1.Size = New System.Drawing.Size(720, 452)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'lineSeparator
        '
        Me.lineSeparator.Name = "lineSeparator"
        Me.lineSeparator.X1 = 55
        Me.lineSeparator.X2 = 540
        Me.lineSeparator.Y1 = 600
        Me.lineSeparator.Y2 = 600
        '
        'FrmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 452)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.linkRelNotes)
        Me.Controls.Add(Me.lblDLSize)
        Me.Controls.Add(Me.lblRelDate)
        Me.Controls.Add(Me.lblCVer)
        Me.Controls.Add(Me.lblDLProgs)
        Me.Controls.Add(Me.lblUPVer)
        Me.Controls.Add(Me.lblChangeLog)
        Me.Controls.Add(Me.lblTTLChangelog)
        Me.Controls.Add(Me.lblTTLRelDate)
        Me.Controls.Add(Me.lblTTLCVer)
        Me.Controls.Add(Me.lblTTLDLProgs)
        Me.Controls.Add(Me.lblTTLDLSize)
        Me.Controls.Add(Me.lblTTLUPVer)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "앱 업데이트"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lbliconInfo As Label
    Friend WithEvents lblUPDStatus As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblTTLUPVer As Label
    Friend WithEvents lblTTLDLSize As Label
    Friend WithEvents lblTTLDLProgs As Label
    Friend WithEvents lblTTLCVer As Label
    Friend WithEvents lblTTLRelDate As Label
    Friend WithEvents lblTTLChangelog As Label
    Friend WithEvents lblChangeLog As Label
    Friend WithEvents lblUPVer As Label
    Friend WithEvents lblDLProgs As Label
    Friend WithEvents lblCVer As Label
    Friend WithEvents lblRelDate As Label
    Friend WithEvents lblDLSize As Label
    Friend WithEvents linkRelNotes As LinkLabel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lineSeparator As PowerPacks.LineShape
End Class
