Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Windows.Media
Imports LiveCharts
Imports LiveCharts.Wpf
Imports LiveCharts.Configurations
Imports System.Windows.Forms
Imports SHDocVw

Public Class MainForm
    Private formActive As Boolean

    Private Enum Exec
        OLECMDID_OPTICAL_ZOOM = 63
    End Enum

    Private Enum ExecOpt
        OLECMDEXECOPT_DODEFAULT = 0
        OLECMDEXECOPT_PROMPTUSER = 1
        OLECMDEXECOPT_DONTPROMPTUSER = 2
        OLECMDEXECOPT_SHOWHELP = 3
    End Enum

    Dim minCount As Integer

    Public Property pm10Avg As Integer = 0
    Public Property pm25Avg As Integer = 0

    Dim pm25AQI As Integer
    Dim pm10AQI As Integer
    Dim AQILevel As Integer
    Dim OldAQILevel As Integer
    Dim jsonCachePath As String = Path.GetTempPath() & "\Gonggi-Cached.json"
    Dim isOffline As Boolean = False

    Private Sub MainForm_Activate(sender As Object, e As EventArgs) Handles MyBase.Activated
        formActive = True
    End Sub

    Private Sub MainForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        formActive = False
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ParseJson("minutes=" & dataLimit)
        InitGauges()
        InitHtml()
        If timeCreated.Count > 0 Then
            ' only if data in lists
            DisplayData()
            InitCharts()
        End If

        PnlChart.Visible = False
        PnlInfo.Visible = True

        If My.Settings.AutoUpdate = True Then
            Updater.RunWorkerAsync()
        End If

        minCount = 0
        CalcAverage()
    End Sub

    Private Sub WriteJson()
        Dim json As String
        json = "{""feeds"":["
        For i As Integer = 0 To timeCreated.Count - 1
            json &= $"{{""created_at"":""{timeCreated(i)}"",""field1"":""{pm25(i)}"",""field2"":""{pm10(i)}"",""field3"":""{temp(i)}"",""field4"":""{lat(i)}"",""field5"":""{lng(i)}""}}"
            json &= IIf(i < timeCreated.Count - 1, ",", "]}")
        Next

        My.Computer.FileSystem.WriteAllText(jsonCachePath, json, False)
    End Sub


    Private Sub InitGauges()
        gaugePM25.From = 0
        gaugePM25.To = 60
        gaugePM25.Uses360Mode = True
        gaugePM25.InnerRadius = 55
        gaugePM25.Base.GaugeRenderTransform = New TransformGroup With {
            .Children = New TransformCollection From {
                New RotateTransform(90),
                New ScaleTransform With {
                    .ScaleX = 1
                }
            }
        }

        gaugePM10.From = 0
        gaugePM10.To = 120
        gaugePM10.Uses360Mode = True
        gaugePM10.InnerRadius = 55
        gaugePM10.Base.GaugeRenderTransform = New TransformGroup With {
            .Children = New TransformCollection From {
                New RotateTransform(90),
                New ScaleTransform With {
                    .ScaleX = 1
                }
            }
        }

        gaugeTemp.From = 0
        gaugeTemp.To = 50
        gaugeTemp.Uses360Mode = True
        gaugeTemp.InnerRadius = 55
        gaugeTemp.Base.GaugeRenderTransform = New TransformGroup With {
            .Children = New TransformCollection From {
                New RotateTransform(90),
                New ScaleTransform With {
                    .ScaleX = 1
                }
            }
        }
    End Sub

    Private Sub InitCharts()
        ' Chart 1 - PM data
        chartPM.Series = New SeriesCollection From {
            New LineSeries With {
                .Title = "PM 10.0",
                .Values = pm10,
                .PointGeometry = DefaultGeometries.Square,
                                .PointGeometrySize = 7
            },
            New LineSeries With {
                .Title = "PM 2.5",
                .Values = pm25,
                .PointGeometry = DefaultGeometries.Circle,
                                .PointGeometrySize = 7
            }
        }

        chartPM.AxisX.Add(New Axis With {
            .Title = "Time",
            .Labels = timeCreated,
            .Separator = New Separator With {
                .Step = 30,
                .IsEnabled = False
             },
             .LabelsRotation = 15
        })

        chartPM.AxisY.Add(New Axis With {
            .Title = "μg / m³"
        })

        chartPM.LegendLocation = LegendLocation.Right

        'chartPM.Zoom = ZoomingOptions.X
        'chartPM.AxisX(0).MaxRange = pm10.Count - 1
        'chartPM.AxisX(0).MinRange = 15

        ' Chart 2 - Temperature data
        Dim mapper = Mappers.Xy(Of MeasureModel)().X(Function(model) model.DateTime.Ticks).Y(Function(model) model.Value)
        Charting.For(Of MeasureModel)(mapper)
        Dim TempChartValues = New ChartValues(Of MeasureModel)

        chartTemp.Series = New SeriesCollection From {
            New LineSeries With {
                .Title = "Temp",
                .Values = temp,
                .PointGeometry = DefaultGeometries.Diamond,
                .PointGeometrySize = 8
            }
        }

        chartTemp.AxisX.Add(New Axis With {
            .Title = "Time",
            .Labels = timeCreated,
            .Separator = New Separator With {
                .Step = 30,
                .IsEnabled = False
            },
             .LabelsRotation = 15
        })

        chartTemp.AxisY.Add(New Axis With {
            .Title = "섭씨 (°C)",
            .Separator = New Separator With {
                .Step = 0.5
            }
        })
        chartTemp.LegendLocation = LegendLocation.Right

        'chartTemp.Zoom = ZoomingOptions.X
        'chartTemp.AxisX(0).MaxRange = temp.Count - 1
        'chartTemp.AxisX(0).MinRange = 15
    End Sub

    Private Sub InitHtml()
        GMapWebBrowser.Navigate("about:blank")
        GMapWebBrowser.Document.Write(String.Empty)
        GMapWebBrowser.DocumentText = My.Resources.HAPPYBONO_DMS_RTL
    End Sub

    Private Sub chartTemp_UpdaterTick(sender As Object) Handles chartTemp.UpdaterTick
        If chartTemp.AxisX(0).MaxValue > 179 Then
            chartTemp.AxisX(0).MaxValue = Double.NaN
        End If

        If chartTemp.AxisX(0).MinValue < 0 Then
            chartTemp.AxisX(0).MinValue = Double.NaN
        End If
    End Sub

    Private Sub chartPM_UpdaterTick(sender As Object) Handles chartPM.UpdaterTick
        If chartPM.AxisX(0).MaxValue > 179 Then
            chartPM.AxisX(0).MaxValue = Double.NaN
        End If

        If chartPM.AxisX(0).MinValue < 0 Then
            chartPM.AxisX(0).MinValue = Double.NaN
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ParseJson("results=1")
        DisplayData()
        CalcAverage()
    End Sub


    Private Sub CalcDustLevel()
        If pm10.Count > 0 Then
            pm10Avg = 0
            pm25Avg = 0

            Dim calcMin As Integer = IIf(pm10.Count - 31 > 0, pm10.Count - 31, 0)
            For i As Integer = calcMin To pm10.Count - 1
                pm10Avg += pm10(i)
                pm25Avg += pm25(i)
            Next
            pm10Avg /= pm10.Count - 1 - calcMin
            pm25Avg /= pm25.Count - 1 - calcMin

            FrmNotify.lblTitle.Text = "실시간 대기 알림 (최근 30분간 평균)"
            FrmNotify.lblAirContents.Text = "PM 2.5 : " & pm25Avg.ToString & " µg / m³" & vbCrLf & "PM 10.0 : " & pm10Avg.ToString & " µg / m³" & vbCrLf & "알림 수신 : " & DateStatusLabel.Text & " " & TimeStatusLabel.Text
            Exit Sub
        End If
    End Sub

    Private Sub CalcAQILevel()
        If pm25Avg < 9 Then
            pm25AQI = 1
        ElseIf pm25Avg < 17 Then
            pm25AQI = 2
        ElseIf pm25Avg < 27 Then
            pm25AQI = 3
        ElseIf pm25Avg < 35 Then
            pm25AQI = 4
        ElseIf pm25Avg < 44 Then
            pm25AQI = 5
        ElseIf pm25Avg < 52 Then
            pm25AQI = 6
        Else
            pm25AQI = 7
        End If

        If pm10Avg < 9 Then
            pm10AQI = 1
        ElseIf pm10Avg < 17 Then
            pm10AQI = 2
        ElseIf pm10Avg < 52 Then
            pm10AQI = 3
        ElseIf pm10Avg < 69 Then
            pm10AQI = 4
        ElseIf pm10Avg < 85 Then
            pm10AQI = 5
        ElseIf pm10Avg < 102 Then
            pm10AQI = 6
        Else
            pm10AQI = 7
        End If

        If pm10AQI <= pm25AQI Then
            AQILevel = pm25AQI
        ElseIf pm10AQI > pm25AQI Then
            AQILevel = pm10AQI
        End If

        Dim NotiAQI As String = My.Settings.NotiAQI
        If NotiAQI = Nothing Then
            Exit Sub
        End If

        If AQILevel = 1 Then
            FrmNotify.lblAirState.Text = "매우 좋음"
            FrmNotify.lblAirComment.Text = "신선한 공기 마음껏 마시세요~"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv1
            FrmNotify.Icon = My.Resources.IDustLv1
        ElseIf AQILevel = 2 Then
            FrmNotify.lblAirState.Text = "좋음"
            FrmNotify.lblAirComment.Text = "환기하셔도 좋습니다!"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv2
            FrmNotify.Icon = My.Resources.IDustLv2
        ElseIf AQILevel = 3 Then
            FrmNotify.lblAirState.Text = "양호"
            FrmNotify.lblAirComment.Text = "그럭저럭 괜찮은 날이네요!"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv3
            FrmNotify.Icon = My.Resources.IDustLv3
        ElseIf AQILevel = 4 Then
            FrmNotify.lblAirState.Text = "조금 나쁨"
            FrmNotify.lblAirComment.Text = "공기가 탁하네요. 조심하세요~"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv4
            FrmNotify.Icon = My.Resources.IDustLv4
        ElseIf AQILevel = 5 Then
            FrmNotify.lblAirState.Text = "나쁨"
            FrmNotify.lblAirComment.Text = "열린 창문이 있다면 닫아주세요~"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv5
            FrmNotify.Icon = My.Resources.IDustLv5
        ElseIf AQILevel = 6 Then
            FrmNotify.lblAirState.Text = "매우 나쁨"
            FrmNotify.lblAirComment.Text = "외출 시 마스크를 꼭 착용해주세요.!"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv6
            FrmNotify.Icon = My.Resources.IDustLv6
        ElseIf AQILevel = 7 Then
            FrmNotify.lblAirState.Text = "최악"
            FrmNotify.lblAirComment.Text = "가능하다면 외출을 삼가해주세요!"
            FrmNotify.AQIPictureBox.Image = My.Resources.DustLv7
            FrmNotify.Icon = My.Resources.IDustLv7
        End If
    End Sub

    Public Sub CalcAverage()
        minCount += 1

        If minCount = 30 And (Me.Visible = False OrElse Me.WindowState = FormWindowState.Minimized OrElse formActive = False) Then
            Dim NotiAQI As String = My.Settings.NotiAQI
            If NotiAQI = String.Empty Then
                Exit Sub
            End If

            CalcDustLevel()
            CalcAQILevel()

            If Not NotiAQI.Contains("1") And AQILevel = 1 Then
                Exit Sub
            End If
            If Not NotiAQI.Contains("2") And AQILevel = 2 Then
                Exit Sub
            End If
            If Not NotiAQI.Contains("3") And AQILevel = 3 Then
                Exit Sub
            End If
            If Not NotiAQI.Contains("4") And AQILevel = 4 Then
                Exit Sub
            End If
            If Not NotiAQI.Contains("5") And AQILevel = 5 Then
                Exit Sub
            End If
            If Not NotiAQI.Contains("6") And AQILevel = 6 Then
                Exit Sub
            End If
            If Not NotiAQI.Contains("7") And AQILevel = 7 Then
                Exit Sub
            End If

            If My.Settings.AQINoChgNoti = True And AQILevel = OldAQILevel Then
                Exit Sub
            End If

            OldAQILevel = AQILevel
            FrmNotify.Show()
            minCount = 0
        ElseIf minCount = 30 Then
            minCount = 0
        End If
    End Sub

    Public Function ServerAvailable() As Boolean
        Try
            Return My.Computer.Network.Ping("http://thingspeak.com/channels/920137")
        Catch
            Return False
        End Try
    End Function

    Private Sub ParseJson(ByRef arg As String)
        ' if last call failed, and trying to update for recent value, and server still unavailable,
        ' change the api call to retrieve since last value
        If isOffline And arg = "results=1" Then
            Dim timeSinceOffline As Integer = DateDiff(DateInterval.Minute, Date.Parse(timeCreated.Last), Now)
            arg = "minutes=" & IIf(timeSinceOffline > dataLimit, dataLimit, timeSinceOffline)
        End If

        ' Try to get json from API
        Dim json As String = String.Empty
        Try
            Dim url As String = "https://api.thingspeak.com/channels/976688/feeds.json?" & arg
            Dim request As WebRequest = WebRequest.Create(url)
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
            Dim datastream As Stream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(datastream)
            json = reader.ReadToEnd()
            isOffline = False
            OnlineStatusLabel.Text = "연결됨"
            If GMapWebBrowser.Tag = "Offline" Then
                GMapWebBrowser.Refresh()
                GMapWebBrowser.Tag = "Online"
                Panel3.Visible = False
                GMapWebBrowser.Visible = True
            End If
            GMapWebBrowser.Tag = "Online"
        Catch ex As Exception
            ' API call failed
            isOffline = True
            OnlineStatusLabel.Text = "연결끊김"
            GMapWebBrowser.Visible = False
            Panel3.Visible = True
            lblAddress.Text = "오프라인 상태에서는 위도, 경도 값을 주소로 변환할 수 없습니다."

            If GMapWebBrowser.Tag = "Online" Then
                GMapWebBrowser.Refresh()
                GMapWebBrowser.Tag = "Offline"
            End If

            ' check if trying to init app with data - use cache if available
            If pm25.Count = 0 And File.Exists(jsonCachePath) Then
                json = My.Computer.FileSystem.ReadAllText(jsonCachePath)
            Else
                ' no live or cached data
                Exit Sub
            End If
        End Try

        ' Check json has feed data
        Dim feedMatch = Regex.Match(json, "(},|{)""feeds"":")
        If feedMatch.Success = False Then
            ' cache empty or corrupt
            Forms.MessageBox.Show("PC 에 저장된 미세먼지 측정 기록이 올바른 JSON 형식이 아닙니다.")
            Exit Sub
        End If

        ' Extract data from json
        json = json.Remove(0, feedMatch.Index)
        Dim nodeMatches As MatchCollection
        nodeMatches = Regex.Matches(json, "{[^}]+}")

        ' Check json has any values
        If nodeMatches.Count = 0 Then
            ' no data found in json
            Exit Sub
        End If

        For Each nodeMatch As Match In nodeMatches
            Dim jDate As String = String.Empty
            Dim jField1 As Double = -1
            Dim jField2 As Double = -1
            Dim jField3 As Double = -1
            Dim jField4 As String = String.Empty
            Dim jField5 As String = String.Empty
            Dim res As Double

            Dim fieldMatches As MatchCollection
            fieldMatches = Regex.Matches(nodeMatch.Value, "(""(?<f>c)reated_at"":""(?<v>[^""]+)""|""field(?<f>\d)"":""(?<v>(\d+|\d+\.\d+))"")")

            For Each fieldMatch As Match In fieldMatches
                Select Case fieldMatch.Groups("f").Value
                    Case "c"
                        jDate = IIf(isOffline, fieldMatch.Groups("v").Value, Date.Parse(fieldMatch.Groups("v").Value).ToLocalTime.ToString)
                    Case "1"
                        Double.TryParse(fieldMatch.Groups("v").Value, res)
                        jField1 = res
                    Case "2"
                        Double.TryParse(fieldMatch.Groups("v").Value, res)
                        jField2 = res
                    Case "3"
                        Double.TryParse(fieldMatch.Groups("v").Value, res)
                        jField3 = res
                    Case "4"
                        jField4 = fieldMatch.Groups("v").Value
                    Case "5"
                        jField5 = fieldMatch.Groups("v").Value
                End Select
            Next

            AddTimeCreated(jDate)
            AddPm25(jField1)
            AddPm10(jField2)
            AddTemp(jField3)
            AddLat(jField4)
            AddLng(jField5)

            WriteJson()
        Next
    End Sub


    Public Sub DisplayData()
        If pm25.Count = 0 OrElse pm10.Count = 0 Then
            ' no data in list to display
            Exit Sub
        End If

        Dim PM25AQI As Integer
        Dim PM10AQI As Integer
        Dim RTAQILevel As Integer

        ' PM2.5
        lblPM25.Text = $"{pm25.Last} μg / m³  (" & Val(pm25.Last) / 20 * 100 & " %)"
        gaugePM25.Value = pm25.Last

        If pm25.Last <= 8 Then
            PM25AQI = 1
            ImgPM25.Image = My.Resources.DustLv1
            lblPM25Lv.Text = "매우 좋음"
        ElseIf pm25.Last <= 16 Then
            PM25AQI = 2
            ImgPM25.Image = My.Resources.DustLv2
            lblPM25Lv.Text = "좋음"
        ElseIf pm25.Last <= 35 Then
            PM25AQI = 3
            ImgPM25.Image = My.Resources.DustLv3
            lblPM25Lv.Text = "양호"
        ElseIf pm25.Last <= 35 Then
            PM25AQI = 4
            ImgPM25.Image = My.Resources.DustLv4
            lblPM25Lv.Text = "조금 나쁨"
        ElseIf pm25.Last <= 44 Then
            PM25AQI = 5
            ImgPM25.Image = My.Resources.DustLv5
            lblPM25Lv.Text = "나쁨"
        ElseIf pm25.Last <= 52 Then
            PM25AQI = 6
            ImgPM25.Image = My.Resources.DustLv6
            lblPM25Lv.Text = "매우 나쁨"
        Else
            PM25AQI = 7
            ImgPM25.Image = My.Resources.DustLv7
            lblPM25Lv.Text = "최악"
        End If

        ' PM10
        lblPM10.Text = $"{pm10.Last} μg / m³  (" & Val(pm10.Last) / 50 * 100 & " %)"
        gaugePM10.Value = pm10.Last

        If pm10.Last <= 8 Then
            PM10AQI = 1
            ImgPM10.Image = My.Resources.DustLv1
            lblPM10Lv.Text = "매우 좋음"
        ElseIf pm10.Last <= 16 Then
            PM10AQI = 2
            ImgPM10.Image = My.Resources.DustLv2
            lblPM10Lv.Text = "좋음"
        ElseIf pm10.Last <= 51 Then
            PM10AQI = 3
            ImgPM10.Image = My.Resources.DustLv3
            lblPM10Lv.Text = "양호"
        ElseIf pm10.Last <= 68 Then
            PM10AQI = 4
            ImgPM10.Image = My.Resources.DustLv4
            lblPM10Lv.Text = "조금 나쁨"
        ElseIf pm10.Last <= 84 Then
            PM10AQI = 5
            ImgPM10.Image = My.Resources.DustLv5
            lblPM10Lv.Text = "나쁨"
        ElseIf pm10.Last <= 101 Then
            PM10AQI = 6
            ImgPM10.Image = My.Resources.DustLv6
            lblPM10Lv.Text = "매우 나쁨"
        Else
            PM10AQI = 7
            ImgPM10.Image = My.Resources.DustLv7
            lblPM10Lv.Text = "최악"
        End If

        'Realtime Icon Update
        If My.Settings.IconUpdate = True Then
            If PM10AQI <= PM25AQI Then
                RTAQILevel = PM25AQI
            ElseIf PM10AQI > PM25AQI Then
                RTAQILevel = PM10AQI
            End If
        End If

        If My.Settings.IconUpdate = True Then
            Select Case RTAQILevel
                Case 1
                    GonggiIcon.Icon = My.Resources.IDustLv1
                    Icon = My.Resources.IDustLv1
                Case 2
                    GonggiIcon.Icon = My.Resources.IDustLv2
                    Icon = My.Resources.IDustLv2
                Case 3
                    GonggiIcon.Icon = My.Resources.IDustLv3
                    Icon = My.Resources.IDustLv3
                Case 4
                    GonggiIcon.Icon = My.Resources.IDustLv4
                    Icon = My.Resources.IDustLv4
                Case 5
                    GonggiIcon.Icon = My.Resources.IDustLv5
                    Icon = My.Resources.IDustLv5
                Case 6
                    GonggiIcon.Icon = My.Resources.IDustLv6
                    Icon = My.Resources.IDustLv6
                Case 7
                    GonggiIcon.Icon = My.Resources.IDustLv7
                    Icon = My.Resources.IDustLv7
            End Select
        End If

        ' Temperature
        lblTemp.Text = $"{temp.Last} °C  ({CStr(Math.Round(temp.Last / (5 / 9) + 32, 2))} °F)"
        gaugeTemp.Value = temp.Last

        ' Lat, Lng
        lblGPSLoc.Text = $"{lat.Last}, {lng.Last}"
        GetAddress()

        ' Last update
        DateStatusLabel.Text = timeCreated.Last.Split(" ")(0)
        TimeStatusLabel.Text = timeCreated.Last.Split(" ")(1) & " " & timeCreated.Last.Split(" ")(2)

        GonggiIcon.Text = "PM2.5 : " & $"{pm25.Last}" & " ㎍ / ㎥" & vbCrLf & "PM10 : " & $"{pm10.Last}" & " ㎍ / ㎥" & vbCrLf & timeCreated.Last.Split(" ")(0) & " " & timeCreated.Last.Split(" ")(1) & " " & timeCreated.Last.Split(" ")(2)
    End Sub

    Private Function GetAddress() As String
        Dim response As HttpWebResponse = DirectCast(Nothing, HttpWebResponse)
        Dim json As String = Nothing
        Dim addressCheck As Match

        Try
            Dim request As HttpWebRequest = CType(WebRequest.Create("https://maps.googleapis.com/maps/api/geocode/json?latlng=" & lat.Last & "," & lng.Last & "&key=AIzaSyCyft7DMS6e6eHotFm167cCDOzpMYJ-yRo"), HttpWebRequest)
            response = CType(request.GetResponse(), HttpWebResponse)

            Dim reader As StreamReader = New StreamReader(response.GetResponseStream())
            json = reader.ReadToEnd()
            response.Close()

            addressCheck = Regex.Match(json, "(?<=""formatted_address"" : "").+?(?="",)")
            If addressCheck.Success Then
                lblAddress.Text = addressCheck.Value
            Else
                lblAddress.Text = "주소 변환이 불가능하거나 변환할 수 있는 주소가 없습니다."
            End If

        Catch ex As Exception
            Dim Message As String = "오류 : " & ex.ToString()
        Finally
            If response IsNot Nothing Then response.Close()
        End Try

        Return json
    End Function

    Private Sub GonggiIcon_MouseUp(sender As Object, e As MouseEventArgs) Handles GonggiIcon.MouseUp
        If Me.Visible = False Then
            Me.Show()
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.Activate()
        Else
            Me.Activate()
        End If
    End Sub

    'Private Sub TempChartClearZoom()
    '    chartTemp.AxisX(0).MinValue = Double.NaN
    '    chartTemp.AxisX(0).MaxValue = Double.NaN
    '    chartTemp.AxisY(0).MinValue = Double.NaN
    '    chartTemp.AxisY(0).MaxValue = Double.NaN
    'End Sub

    'Private Sub PMChartClearZoom()
    '    chartPM.AxisX(0).MinValue = Double.NaN
    '    chartPM.AxisX(0).MaxValue = Double.NaN
    '    chartPM.AxisY(0).MinValue = Double.NaN
    '    chartPM.AxisY(0).MaxValue = Double.NaN
    'End Sub

    'Private Sub lblChartPM_Click(sender As Object, e As EventArgs) Handles lblChartPM.Click
    '    PMChartClearZoom()
    'End Sub

    'Private Sub lblChartTemp_Click(sender As Object, e As EventArgs) Handles lblChartTemp.Click
    '    TempChartClearZoom()
    'End Sub

    Private Sub MainForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            GonggiIcon.Visible = True
            Me.Visible = False
        Else
            Me.Activate()
        End If
    End Sub

    Private Sub lblbtnInfo_Click(sender As Object, e As EventArgs) Handles lblbtnInfo.Click
        If PnlInfo.Visible = True Then
            Exit Sub
        Else
            lblbtnInfo.ForeColor = System.Drawing.Color.Black
            lbliconInfo.ForeColor = System.Drawing.Color.Black
            lbliconHistory.ForeColor = System.Drawing.Color.Gray
            lblbtnChart.ForeColor = System.Drawing.Color.Gray
            PnlInfo.Visible = True
            PnlChart.Visible = False
            pnlSelect1.Visible = True
            pnlSelect2.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub lblbtnChart_Click(sender As Object, e As EventArgs) Handles lblbtnChart.Click
        If PnlChart.Visible = True Then
            Exit Sub
        Else
            lblbtnInfo.ForeColor = System.Drawing.Color.Gray
            lbliconInfo.ForeColor = System.Drawing.Color.Gray
            lblbtnChart.ForeColor = System.Drawing.Color.Black
            lbliconHistory.ForeColor = System.Drawing.Color.Black
            PnlInfo.Visible = False
            PnlChart.Visible = True
            pnlSelect1.Visible = False
            pnlSelect2.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub lbliconInfo_Click(sender As Object, e As EventArgs) Handles lbliconInfo.Click
        If PnlInfo.Visible = True Then
            Exit Sub
        Else
            lblbtnInfo.ForeColor = System.Drawing.Color.Black
            lbliconInfo.ForeColor = System.Drawing.Color.Black
            lbliconHistory.ForeColor = System.Drawing.Color.Gray
            lblbtnChart.ForeColor = System.Drawing.Color.Gray
            PnlInfo.Visible = True
            PnlChart.Visible = False
            pnlSelect1.Visible = True
            pnlSelect2.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub lbliconHistory_Click(sender As Object, e As EventArgs) Handles lbliconHistory.Click
        If PnlChart.Visible = True Then
            Exit Sub
        Else
            lblbtnInfo.ForeColor = System.Drawing.Color.Gray
            lbliconInfo.ForeColor = System.Drawing.Color.Gray
            lblbtnChart.ForeColor = System.Drawing.Color.Black
            lbliconHistory.ForeColor = System.Drawing.Color.Black
            PnlInfo.Visible = False
            PnlChart.Visible = True
            pnlSelect1.Visible = False
            pnlSelect2.Visible = True
            Exit Sub
        End If
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        FrmSettings.ShowDialog()
    End Sub

    Private Sub btnSettings_MouseHover(sender As Object, e As EventArgs) Handles btnSettings.MouseHover
        tooltipIconBtn.SetToolTip(btnSettings, "설정")
        btnSettings.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub btnSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnSettings.MouseLeave
        btnSettings.ForeColor = System.Drawing.Color.Gray
    End Sub

    Private Function getSrc(ByVal url As String)
        Dim r As HttpWebRequest = HttpWebRequest.Create(url)
        Dim re As HttpWebResponse = r.GetResponse()
        Dim src As String = New StreamReader(re.GetResponseStream()).ReadToEnd()
        Return src
    End Function

    Private Sub Updater_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Updater.DoWork

        Try
            Dim src As String = getSrc("https://onedrive.live.com/download?cid=406282C4FD4D2A6B&resid=406282C4FD4D2A6B%21535352&authkey=AGCVQXOlz6pU47Y")
            Dim srcv() As String = src.Split(",") '0 = version number / 1 = download url
            If srcv(0) <= Me.ProductVersion Then
                Exit Sub
            ElseIf Forms.Application.OpenForms().OfType(Of FrmUpdate).Any Then
                Exit Sub
            Else
                FrmUpdate.ShowDialog()
            End If
        Catch
            Exit Sub
        End Try
    End Sub

    Private Sub btnUpdate_MouseHover(sender As Object, e As EventArgs) Handles btnUpdate.MouseHover
        btnUpdate.ForeColor = System.Drawing.Color.Black
        tooltipIconBtn.SetToolTip(btnUpdate, "업데이트")
    End Sub

    Private Sub btnUpdate_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdate.MouseLeave
        btnUpdate.ForeColor = System.Drawing.Color.Gray
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        FrmUpdate.ShowDialog()
        FrmUpdate.TopMost = True
    End Sub

    Private Sub btnFeedback_Click(sender As Object, e As EventArgs) Handles btnFeedback.Click
        System.Diagnostics.Process.Start("https://forms.office.com/Pages/ResponsePage.aspx?id=DQSIkWdsW0yxEjajBLZtrQAAAAAAAAAAAANAAaL_Ps9UQVI0T1FMNTUwVEdFUklFWVoxRTZVRURTTS4u")
    End Sub

    Private Sub btnFeedback_MouseHover(sender As Object, e As EventArgs) Handles btnFeedback.MouseHover
        btnFeedback.ForeColor = System.Drawing.Color.Black
        tooltipIconBtn.SetToolTip(btnFeedback, "피드백")
    End Sub

    Private Sub btnFeedback_MouseLeave(sender As Object, e As EventArgs) Handles btnFeedback.MouseLeave
        btnFeedback.ForeColor = System.Drawing.Color.Gray
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub btnAbout_MouseHover(sender As Object, e As EventArgs) Handles btnAbout.MouseHover
        btnAbout.ForeColor = System.Drawing.Color.Black
        tooltipIconBtn.SetToolTip(btnAbout, "정보")
    End Sub

    Private Sub btnAbout_MouseLeave(sender As Object, e As EventArgs) Handles btnAbout.MouseLeave
        btnAbout.ForeColor = System.Drawing.Color.Gray
    End Sub

    Public Sub zoom(ByVal zoomvalue As Integer)

        Try
            Dim Res As Object = Nothing
            Dim MyWeb As Object
            MyWeb = Me.GMapWebBrowser.ActiveXInstance
            MyWeb.ExecWB(Exec.OLECMDID_OPTICAL_ZOOM, ExecOpt.OLECMDEXECOPT_DONTPROMPTUSER, CObj(zoomvalue), CObj(IntPtr.Zero))
        Catch ex As Exception
            MsgBox("Error:" + ex.Message)
        End Try

    End Sub
End Class
