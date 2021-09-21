﻿Public Class progresibar

    Private Sub progresibar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgressBar1.Value = 40
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim contador As Integer = 0
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString + "%"

        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
            contador += 1
        End If

        If CircularProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Opacity -= 0.05
        If Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
        End If
    End Sub
End Class