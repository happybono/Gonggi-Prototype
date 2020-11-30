Imports LiveCharts

Module FieldData
    Public timeCreated As New List(Of String)
    Public pm25 As New ChartValues(Of Double)
    Public pm10 As New ChartValues(Of Double)
    Public temp As New ChartValues(Of Double)
    Public lat As New List(Of String)
    Public lng As New List(Of String)
    Public ReadOnly dataLimit As Integer = 180

    Public Sub AddTimeCreated(ByRef item As String)
        If timeCreated.Count = dataLimit Then
            timeCreated.RemoveAt(0)
        End If
        timeCreated.Add(item)
    End Sub

    Public Sub AddPm25(ByRef item As Double)
        If pm25.Count = dataLimit Then
            pm25.RemoveAt(0)
        End If
        pm25.Add(item)
    End Sub

    Public Sub AddPm10(ByRef item As Double)
        If pm10.Count = dataLimit Then
            pm10.RemoveAt(0)
        End If
        pm10.Add(item)
    End Sub

    Public Sub AddTemp(ByRef item As Double)
        If temp.Count = dataLimit Then
            temp.RemoveAt(0)
        End If
        temp.Add(item)
    End Sub

    Public Sub AddLat(ByRef item As String)
        If lat.Count = dataLimit Then
            lat.RemoveAt(0)
        End If
        lat.Add(item)
    End Sub

    Public Sub AddLng(ByRef item As String)
        If lng.Count = dataLimit Then
            lng.RemoveAt(0)
        End If
        lng.Add(item)
    End Sub
End Module
