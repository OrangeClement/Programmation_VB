Public Class Accueil

    Private Sub btnjoueravecclavier_Click(sender As System.Object, e As System.EventArgs) Handles btnjoueravecclavier.Click
        'accéder au form2048_avec_clavier

        Form2048_avec_clavier.Show()
        Me.Hide()
    End Sub

    Private Sub btnjouersansclavier_Click(sender As System.Object, e As System.EventArgs) Handles btnjouer.Click
        'accéder au form2048

        Form2048.Show()
        Me.Hide()
    End Sub

End Class