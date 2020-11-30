Public Class AboutBox
    Private Sub AboutBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = " v." & ProductVersion
    End Sub
End Class