<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblPM25 = New System.Windows.Forms.Label()
        Me.lblPM10 = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblGPSLoc = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OnlineStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LatestDateTimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PM25Label = New System.Windows.Forms.Label()
        Me.PM10Label = New System.Windows.Forms.Label()
        Me.lblPM25Lv = New System.Windows.Forms.Label()
        Me.lblPM10Lv = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gaugePM25 = New LiveCharts.WinForms.SolidGauge()
        Me.gaugePM10 = New LiveCharts.WinForms.SolidGauge()
        Me.gaugeTemp = New LiveCharts.WinForms.SolidGauge()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImgPM25 = New System.Windows.Forms.PictureBox()
        Me.ImgPM10 = New System.Windows.Forms.PictureBox()
        Me.GMapWebBrowser = New System.Windows.Forms.WebBrowser()
        Me.GonggiIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlSelect2 = New System.Windows.Forms.Panel()
        Me.pnlSelect1 = New System.Windows.Forms.Panel()
        Me.lblbtnChart = New System.Windows.Forms.Label()
        Me.lblbtnInfo = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Label()
        Me.lbliconHistory = New System.Windows.Forms.Label()
        Me.lbliconInfo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAbout = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Label()
        Me.btnFeedback = New System.Windows.Forms.Label()
        Me.chartTemp = New LiveCharts.WinForms.CartesianChart()
        Me.chartPM = New LiveCharts.WinForms.CartesianChart()
        Me.lblChartPM = New System.Windows.Forms.Label()
        Me.lblChartTemp = New System.Windows.Forms.Label()
        Me.PnlChart = New System.Windows.Forms.Panel()
        Me.Updater = New System.ComponentModel.BackgroundWorker()
        Me.tooltipIconBtn = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImgPM25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPM10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlInfo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.PnlChart.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPM25
        '
        Me.lblPM25.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblPM25.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPM25.Location = New System.Drawing.Point(172, 0)
        Me.lblPM25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPM25.Name = "lblPM25"
        Me.lblPM25.Size = New System.Drawing.Size(524, 47)
        Me.lblPM25.TabIndex = 0
        Me.lblPM25.Text = "최근 3시간 이내 측정된 기록이 존재하지 않습니다."
        Me.lblPM25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPM10
        '
        Me.lblPM10.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPM10.Location = New System.Drawing.Point(172, 47)
        Me.lblPM10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPM10.Name = "lblPM10"
        Me.lblPM10.Size = New System.Drawing.Size(524, 47)
        Me.lblPM10.TabIndex = 1
        Me.lblPM10.Text = "최근 3시간 이내 측정된 기록이 존재하지 않습니다."
        Me.lblPM10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTemp
        '
        Me.lblTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(172, 94)
        Me.lblTemp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(524, 47)
        Me.lblTemp.TabIndex = 2
        Me.lblTemp.Text = "최근 3시간 이내 측정된 기록이 존재하지 않습니다."
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGPSLoc
        '
        Me.lblGPSLoc.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblGPSLoc.Location = New System.Drawing.Point(172, 141)
        Me.lblGPSLoc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGPSLoc.Name = "lblGPSLoc"
        Me.lblGPSLoc.Size = New System.Drawing.Size(524, 47)
        Me.lblGPSLoc.TabIndex = 3
        Me.lblGPSLoc.Text = "최근 3시간 이내 측정된 기록이 존재하지 않습니다."
        Me.lblGPSLoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60000
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft NeoGothic", 19.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 13)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(326, 36)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "HAPPYBONO-DMS-GPS-I"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.42396!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.57604!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAddress, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPM10, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPM25, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTemp, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGPSLoc, 1, 3)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(463, 12)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(699, 238)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(2, 188)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(166, 49)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "측정 위치"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(172, 188)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(524, 49)
        Me.lblAddress.TabIndex = 10
        Me.lblAddress.Text = "최근 3시간 이내 측정된 기록이 존재하지 않습니다."
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(2, 141)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(166, 47)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "위도, 경도"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(2, 94)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(166, 47)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "온도"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(2, 47)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 47)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "미세먼지 (PM 10.0)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(2, 0)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(166, 47)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "초미세먼지 (PM 2.5)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.OnlineStatusLabel, Me.ToolStripStatusLabel1, Me.LatestDateTimeLabel, Me.DateStatusLabel, Me.TimeStatusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 671)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1232, 24)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!)
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(95, 19)
        Me.ToolStripStatusLabel2.Text = "현재 연결 상태 :"
        '
        'OnlineStatusLabel
        '
        Me.OnlineStatusLabel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!)
        Me.OnlineStatusLabel.ForeColor = System.Drawing.Color.White
        Me.OnlineStatusLabel.Name = "OnlineStatusLabel"
        Me.OnlineStatusLabel.Size = New System.Drawing.Size(56, 19)
        Me.OnlineStatusLabel.Text = "오프라인"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(19, 19)
        Me.ToolStripStatusLabel1.Text = " | "
        '
        'LatestDateTimeLabel
        '
        Me.LatestDateTimeLabel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LatestDateTimeLabel.ForeColor = System.Drawing.Color.White
        Me.LatestDateTimeLabel.Name = "LatestDateTimeLabel"
        Me.LatestDateTimeLabel.Size = New System.Drawing.Size(147, 19)
        Me.LatestDateTimeLabel.Text = "마지막 데이터 전송 시각 :"
        '
        'DateStatusLabel
        '
        Me.DateStatusLabel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateStatusLabel.ForeColor = System.Drawing.Color.White
        Me.DateStatusLabel.Name = "DateStatusLabel"
        Me.DateStatusLabel.Size = New System.Drawing.Size(0, 19)
        '
        'TimeStatusLabel
        '
        Me.TimeStatusLabel.Font = New System.Drawing.Font("Microsoft NeoGothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeStatusLabel.ForeColor = System.Drawing.Color.White
        Me.TimeStatusLabel.Name = "TimeStatusLabel"
        Me.TimeStatusLabel.Size = New System.Drawing.Size(140, 19)
        Me.TimeStatusLabel.Text = "                                 "
        '
        'PM25Label
        '
        Me.PM25Label.AutoSize = True
        Me.PM25Label.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PM25Label.Location = New System.Drawing.Point(74, 16)
        Me.PM25Label.Name = "PM25Label"
        Me.PM25Label.Size = New System.Drawing.Size(80, 21)
        Me.PM25Label.TabIndex = 17
        Me.PM25Label.Text = "초미세먼지"
        '
        'PM10Label
        '
        Me.PM10Label.AutoSize = True
        Me.PM10Label.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PM10Label.Location = New System.Drawing.Point(276, 16)
        Me.PM10Label.Name = "PM10Label"
        Me.PM10Label.Size = New System.Drawing.Size(66, 21)
        Me.PM10Label.TabIndex = 18
        Me.PM10Label.Text = "미세먼지"
        '
        'lblPM25Lv
        '
        Me.lblPM25Lv.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPM25Lv.Location = New System.Drawing.Point(39, 201)
        Me.lblPM25Lv.Name = "lblPM25Lv"
        Me.lblPM25Lv.Size = New System.Drawing.Size(150, 21)
        Me.lblPM25Lv.TabIndex = 19
        Me.lblPM25Lv.Text = "알 수 없음"
        Me.lblPM25Lv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPM10Lv
        '
        Me.lblPM10Lv.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPM10Lv.Location = New System.Drawing.Point(238, 201)
        Me.lblPM10Lv.Name = "lblPM10Lv"
        Me.lblPM10Lv.Size = New System.Drawing.Size(150, 21)
        Me.lblPM10Lv.TabIndex = 20
        Me.lblPM10Lv.Text = "알 수 없음"
        Me.lblPM10Lv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.gaugePM25)
        Me.FlowLayoutPanel1.Controls.Add(Me.gaugePM10)
        Me.FlowLayoutPanel1.Controls.Add(Me.gaugeTemp)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(463, 284)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(722, 217)
        Me.FlowLayoutPanel1.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(236, 32)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "초미세먼지"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.Location = New System.Drawing.Point(242, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(236, 32)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "미세먼지"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label10.Location = New System.Drawing.Point(482, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(236, 32)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "온도"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gaugePM25
        '
        Me.gaugePM25.Font = New System.Drawing.Font("Segoe UI Semibold", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaugePM25.Location = New System.Drawing.Point(2, 34)
        Me.gaugePM25.Margin = New System.Windows.Forms.Padding(2)
        Me.gaugePM25.Name = "gaugePM25"
        Me.gaugePM25.Size = New System.Drawing.Size(236, 151)
        Me.gaugePM25.TabIndex = 5
        Me.gaugePM25.Text = "SolidGauge1"
        '
        'gaugePM10
        '
        Me.gaugePM10.Font = New System.Drawing.Font("Segoe UI Semibold", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaugePM10.Location = New System.Drawing.Point(242, 34)
        Me.gaugePM10.Margin = New System.Windows.Forms.Padding(2)
        Me.gaugePM10.Name = "gaugePM10"
        Me.gaugePM10.Size = New System.Drawing.Size(236, 151)
        Me.gaugePM10.TabIndex = 6
        Me.gaugePM10.Text = "SolidGauge2"
        '
        'gaugeTemp
        '
        Me.gaugeTemp.Font = New System.Drawing.Font("Segoe UI Semibold", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gaugeTemp.Location = New System.Drawing.Point(482, 34)
        Me.gaugeTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.gaugeTemp.Name = "gaugeTemp"
        Me.gaugeTemp.Size = New System.Drawing.Size(236, 151)
        Me.gaugeTemp.TabIndex = 7
        Me.gaugeTemp.Text = "SolidGauge3"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(2, 187)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(236, 32)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "µg / m³"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label12.Location = New System.Drawing.Point(242, 187)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(236, 32)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "µg / m³"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(482, 187)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 32)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "°C"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblPM10Lv)
        Me.Panel1.Controls.Add(Me.ImgPM25)
        Me.Panel1.Controls.Add(Me.ImgPM10)
        Me.Panel1.Controls.Add(Me.PM25Label)
        Me.Panel1.Controls.Add(Me.PM10Label)
        Me.Panel1.Controls.Add(Me.lblPM25Lv)
        Me.Panel1.Location = New System.Drawing.Point(25, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 238)
        Me.Panel1.TabIndex = 26
        '
        'ImgPM25
        '
        Me.ImgPM25.Image = Global.HAPPYBONO_DMS.My.Resources.Resources.DustUnk
        Me.ImgPM25.Location = New System.Drawing.Point(39, 46)
        Me.ImgPM25.Name = "ImgPM25"
        Me.ImgPM25.Size = New System.Drawing.Size(150, 150)
        Me.ImgPM25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPM25.TabIndex = 15
        Me.ImgPM25.TabStop = False
        '
        'ImgPM10
        '
        Me.ImgPM10.Image = Global.HAPPYBONO_DMS.My.Resources.Resources.DustUnk
        Me.ImgPM10.Location = New System.Drawing.Point(238, 46)
        Me.ImgPM10.Name = "ImgPM10"
        Me.ImgPM10.Size = New System.Drawing.Size(150, 150)
        Me.ImgPM10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgPM10.TabIndex = 16
        Me.ImgPM10.TabStop = False
        '
        'GMapWebBrowser
        '
        Me.GMapWebBrowser.IsWebBrowserContextMenuEnabled = False
        Me.GMapWebBrowser.Location = New System.Drawing.Point(21, 267)
        Me.GMapWebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.GMapWebBrowser.Name = "GMapWebBrowser"
        Me.GMapWebBrowser.ScriptErrorsSuppressed = True
        Me.GMapWebBrowser.Size = New System.Drawing.Size(430, 252)
        Me.GMapWebBrowser.TabIndex = 27
        Me.GMapWebBrowser.Tag = "Offline"
        Me.GMapWebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'GonggiIcon
        '
        Me.GonggiIcon.Icon = CType(resources.GetObject("GonggiIcon.Icon"), System.Drawing.Icon)
        Me.GonggiIcon.Text = "Gonggi"
        Me.GonggiIcon.Visible = True
        '
        'PnlInfo
        '
        Me.PnlInfo.Controls.Add(Me.Panel1)
        Me.PnlInfo.Controls.Add(Me.TableLayoutPanel1)
        Me.PnlInfo.Controls.Add(Me.FlowLayoutPanel1)
        Me.PnlInfo.Controls.Add(Me.GMapWebBrowser)
        Me.PnlInfo.Controls.Add(Me.Panel3)
        Me.PnlInfo.Location = New System.Drawing.Point(19, 126)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(1202, 527)
        Me.PnlInfo.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(25, 267)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(428, 251)
        Me.Panel3.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HAPPYBONO_DMS.My.Resources.Resources.ErrorIcon
        Me.PictureBox1.Location = New System.Drawing.Point(157, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "죄송합니다. 오프라인 상태에서는" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Google 지도 기능을 이용 하실 수 없습니다."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSelect2
        '
        Me.pnlSelect2.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnlSelect2.ForeColor = System.Drawing.Color.Transparent
        Me.pnlSelect2.Location = New System.Drawing.Point(145, 98)
        Me.pnlSelect2.Name = "pnlSelect2"
        Me.pnlSelect2.Size = New System.Drawing.Size(100, 2)
        Me.pnlSelect2.TabIndex = 33
        Me.pnlSelect2.Visible = False
        '
        'pnlSelect1
        '
        Me.pnlSelect1.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.pnlSelect1.ForeColor = System.Drawing.Color.Transparent
        Me.pnlSelect1.Location = New System.Drawing.Point(19, 98)
        Me.pnlSelect1.Name = "pnlSelect1"
        Me.pnlSelect1.Size = New System.Drawing.Size(100, 2)
        Me.pnlSelect1.TabIndex = 32
        '
        'lblbtnChart
        '
        Me.lblbtnChart.AutoSize = True
        Me.lblbtnChart.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblbtnChart.ForeColor = System.Drawing.Color.Gray
        Me.lblbtnChart.Location = New System.Drawing.Point(167, 69)
        Me.lblbtnChart.Name = "lblbtnChart"
        Me.lblbtnChart.Size = New System.Drawing.Size(85, 26)
        Me.lblbtnChart.TabIndex = 31
        Me.lblbtnChart.Tag = ""
        Me.lblbtnChart.Text = "측정 기록"
        Me.lblbtnChart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblbtnInfo
        '
        Me.lblbtnInfo.AutoSize = True
        Me.lblbtnInfo.Font = New System.Drawing.Font("Microsoft NeoGothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblbtnInfo.ForeColor = System.Drawing.Color.Black
        Me.lblbtnInfo.Location = New System.Drawing.Point(39, 69)
        Me.lblbtnInfo.Name = "lblbtnInfo"
        Me.lblbtnInfo.Size = New System.Drawing.Size(85, 26)
        Me.lblbtnInfo.TabIndex = 30
        Me.lblbtnInfo.Tag = ""
        Me.lblbtnInfo.Text = "현재 정보"
        Me.lblbtnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSettings
        '
        Me.btnSettings.AutoSize = True
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSettings.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Gray
        Me.btnSettings.Location = New System.Drawing.Point(1103, 71)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(28, 19)
        Me.btnSettings.TabIndex = 34
        Me.btnSettings.Text = ""
        '
        'lbliconHistory
        '
        Me.lbliconHistory.AutoSize = True
        Me.lbliconHistory.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliconHistory.ForeColor = System.Drawing.Color.Gray
        Me.lbliconHistory.Location = New System.Drawing.Point(140, 74)
        Me.lbliconHistory.Name = "lbliconHistory"
        Me.lbliconHistory.Size = New System.Drawing.Size(28, 19)
        Me.lbliconHistory.TabIndex = 35
        Me.lbliconHistory.Text = ""
        '
        'lbliconInfo
        '
        Me.lbliconInfo.AutoSize = True
        Me.lbliconInfo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliconInfo.Location = New System.Drawing.Point(12, 74)
        Me.lbliconInfo.Name = "lbliconInfo"
        Me.lbliconInfo.Size = New System.Drawing.Size(28, 19)
        Me.lbliconInfo.TabIndex = 36
        Me.lbliconInfo.Text = ""
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAbout)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.lbliconInfo)
        Me.Panel2.Controls.Add(Me.lbliconHistory)
        Me.Panel2.Controls.Add(Me.btnSettings)
        Me.Panel2.Controls.Add(Me.pnlSelect2)
        Me.Panel2.Controls.Add(Me.pnlSelect1)
        Me.Panel2.Controls.Add(Me.lblbtnChart)
        Me.Panel2.Controls.Add(Me.lblbtnInfo)
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Controls.Add(Me.btnFeedback)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1290, 113)
        Me.Panel2.TabIndex = 37
        '
        'btnAbout
        '
        Me.btnAbout.AutoSize = True
        Me.btnAbout.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!)
        Me.btnAbout.ForeColor = System.Drawing.Color.Gray
        Me.btnAbout.Location = New System.Drawing.Point(1171, 71)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(28, 19)
        Me.btnAbout.TabIndex = 39
        Me.btnAbout.Text = ""
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSize = True
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Gray
        Me.btnUpdate.Location = New System.Drawing.Point(1069, 71)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(28, 19)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = ""
        '
        'btnFeedback
        '
        Me.btnFeedback.AutoSize = True
        Me.btnFeedback.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFeedback.Font = New System.Drawing.Font("Segoe MDL2 Assets", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFeedback.ForeColor = System.Drawing.Color.Gray
        Me.btnFeedback.Location = New System.Drawing.Point(1137, 71)
        Me.btnFeedback.Name = "btnFeedback"
        Me.btnFeedback.Size = New System.Drawing.Size(28, 19)
        Me.btnFeedback.TabIndex = 38
        Me.btnFeedback.Text = ""
        '
        'chartTemp
        '
        Me.chartTemp.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chartTemp.Location = New System.Drawing.Point(21, 310)
        Me.chartTemp.Name = "chartTemp"
        Me.chartTemp.Size = New System.Drawing.Size(1160, 222)
        Me.chartTemp.TabIndex = 27
        Me.chartTemp.Text = "CartesianChart2"
        '
        'chartPM
        '
        Me.chartPM.Font = New System.Drawing.Font("Microsoft NeoGothic", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.chartPM.Location = New System.Drawing.Point(21, 41)
        Me.chartPM.Name = "chartPM"
        Me.chartPM.Size = New System.Drawing.Size(1160, 222)
        Me.chartPM.TabIndex = 26
        Me.chartPM.Text = "CartesianChart1"
        '
        'lblChartPM
        '
        Me.lblChartPM.AutoSize = True
        Me.lblChartPM.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartPM.Location = New System.Drawing.Point(17, 12)
        Me.lblChartPM.Name = "lblChartPM"
        Me.lblChartPM.Size = New System.Drawing.Size(200, 21)
        Me.lblChartPM.TabIndex = 28
        Me.lblChartPM.Text = "PM 2.5 / PM 10.0 (µg / m³)"
        '
        'lblChartTemp
        '
        Me.lblChartTemp.Font = New System.Drawing.Font("Microsoft NeoGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChartTemp.Location = New System.Drawing.Point(17, 286)
        Me.lblChartTemp.Name = "lblChartTemp"
        Me.lblChartTemp.Size = New System.Drawing.Size(77, 21)
        Me.lblChartTemp.TabIndex = 29
        Me.lblChartTemp.Text = "온도 (°C)"
        Me.lblChartTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlChart
        '
        Me.PnlChart.Controls.Add(Me.lblChartTemp)
        Me.PnlChart.Controls.Add(Me.lblChartPM)
        Me.PnlChart.Controls.Add(Me.chartPM)
        Me.PnlChart.Controls.Add(Me.chartTemp)
        Me.PnlChart.Location = New System.Drawing.Point(12, 118)
        Me.PnlChart.Name = "PnlChart"
        Me.PnlChart.Size = New System.Drawing.Size(1209, 543)
        Me.PnlChart.TabIndex = 29
        '
        'Updater
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1232, 695)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PnlInfo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PnlChart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gonggi"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ImgPM25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPM10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlInfo.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlChart.ResumeLayout(False)
        Me.PnlChart.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPM25 As Label
    Friend WithEvents lblPM10 As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblGPSLoc As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTitle As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ImgPM25 As PictureBox
    Friend WithEvents ImgPM10 As PictureBox
    Friend WithEvents PM25Label As Label
    Friend WithEvents PM10Label As Label
    Friend WithEvents lblPM25Lv As Label
    Friend WithEvents lblPM10Lv As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents gaugePM25 As LiveCharts.WinForms.SolidGauge
    Friend WithEvents gaugePM10 As LiveCharts.WinForms.SolidGauge
    Friend WithEvents gaugeTemp As LiveCharts.WinForms.SolidGauge
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GMapWebBrowser As WebBrowser
    Friend WithEvents GonggiIcon As NotifyIcon
    Friend WithEvents PnlInfo As Panel
    Friend WithEvents pnlSelect2 As Panel
    Friend WithEvents pnlSelect1 As Panel
    Friend WithEvents lblbtnChart As Label
    Friend WithEvents lblbtnInfo As Label
    Friend WithEvents btnSettings As Label
    Friend WithEvents lbliconHistory As Label
    Friend WithEvents lbliconInfo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chartTemp As LiveCharts.WinForms.CartesianChart
    Public WithEvents chartPM As LiveCharts.WinForms.CartesianChart
    Friend WithEvents lblChartPM As Label
    Friend WithEvents lblChartTemp As Label
    Friend WithEvents PnlChart As Panel
    Friend WithEvents LatestDateTimeLabel As ToolStripStatusLabel
    Friend WithEvents DateStatusLabel As ToolStripStatusLabel
    Friend WithEvents TimeStatusLabel As ToolStripStatusLabel
    Friend WithEvents Updater As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnUpdate As Label
    Friend WithEvents tooltipIconBtn As ToolTip
    Friend WithEvents btnFeedback As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents OnlineStatusLabel As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAbout As Label
End Class
