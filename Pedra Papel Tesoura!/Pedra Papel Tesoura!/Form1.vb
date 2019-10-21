Public Class Form1
    Dim number As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3

        number = (3 * Rnd())

        If rdbRock.Checked And number = ROCK Then
            Label1.Text = "Computador jogou Pedra, Empate!"
        ElseIf rdbRock.Checked And number = PAPER Then
            Label1.Text = "Computador jogou Papel, Perdes-te!"
        ElseIf rdbRock.Checked And number = SCISSORS Then
            Label1.Text = "Computador jogou Tesoura, Ganhas-te!"
        End If

        If rdbPaper.Checked And number = ROCK Then
            Label1.Text = "Computador jogou Pedra, Perdes-te!"
        ElseIf rdbPaper.Checked And number = PAPER Then
            Label1.Text = "Computador jogou Papel, Empate!"
        ElseIf rdbPaper.Checked And number = SCISSORS Then
            Label1.Text = "Computador jogou Tesoura, Perdes-te!"
        End If

        If rdbScissor.Checked And number = ROCK Then
            Label1.Text = "Computador jogou Pedra, Perdes-te!"
        ElseIf rdbScissor.Checked And number = PAPER Then
            Label1.Text = "Computador jogou Papel, Ganhanhas-te!"
        ElseIf rdbScissor.Checked And number = SCISSORS Then
            Label1.Text = "Computador jogou Tesoura, Empate!"
        End If

    End Sub

End Class
