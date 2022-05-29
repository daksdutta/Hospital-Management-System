Public Class prgBar
    Dim a As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum - 1 Then
            ProgressBar1.Value += 4
            If ProgressBar1.Value = ProgressBar1.Maximum Then
                Timer1.Stop()
                Me.Hide()
                homepage.Show()
            End If
        End If
    End Sub

    Private Sub prgBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class