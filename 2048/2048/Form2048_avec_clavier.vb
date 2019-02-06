Public Class Form2048_avec_clavier

    'Cette fonction permet de charger form2048 qui est le nom de notre interface
    Private Sub Form2048_avec_clavier_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' La commande Msgbox permet d'afficher une boite de dialogue
        MsgBox("Bonjour, je suis Tony Stark, j'ai un certain ego, un QI de 150. Avec moi, c'est plus simple, utilisez les touches de direction de votre clavier. C'est mieux (désolé Captain). Bonne chance à vous !")
        'Le lblscoremax correspond au score maximum qui l'a fait
        lblscoremaxc.Text = scoremax
        'Le lblscore sera de 0 car nous sommes au début du jeu, le joueur n'a pas encore commencé à jouer
        lblScorec.Text = 0
        'Le bouton retour est inaccessible car aucune action n'a été faite
        btnUndoc.Enabled = False

    End Sub

    'Cette fonction permet de mettre à jour les différents besoins de notre interface en attribuant les valeurs correspondantes
    Private Sub Affiche()

        ' affiche le score
        ' gère l'accessibilité des boutons

        Dim l As Byte, i As Byte, j As Byte 'On déclare 3 variables

        'Nous avons créé des boucles pour pouvoir créer le tableau à 2 dimensions
        For i = 1 To n
            For j = 1 To n
                l = (i - 1) * n + j
                'On rends vide les cases qui sont égales à 0
                ' On affiche la variable Jeu dans lbl1, lbl2, ... lbl16
                Select Case l
                    Case 1
                        If Jeu(i, j) = 0 Then
                            lbl1c.Text = String.Empty
                        Else
                            lbl1c.Text = Jeu(i, j)
                        End If
                        lbl1c.BackColor = couleur(i, j)
                    Case 2
                        If Jeu(i, j) = 0 Then
                            lbl2c.Text = String.Empty
                        Else
                            lbl2c.Text = Jeu(i, j)
                        End If
                        lbl2c.BackColor = couleur(i, j)
                    Case 3
                        If Jeu(i, j) = 0 Then
                            lbl3c.Text = String.Empty
                        Else
                            lbl3c.Text = Jeu(i, j)
                        End If
                        lbl3c.BackColor = couleur(i, j)
                    Case 4
                        If Jeu(i, j) = 0 Then
                            lbl4c.Text = String.Empty
                        Else
                            lbl4c.Text = Jeu(i, j)
                        End If
                        lbl4c.BackColor = couleur(i, j)
                    Case 5
                        If Jeu(i, j) = 0 Then
                            lbl5c.Text = String.Empty
                        Else
                            lbl5c.Text = Jeu(i, j)
                        End If
                        lbl5c.BackColor = couleur(i, j)
                    Case 6
                        If Jeu(i, j) = 0 Then
                            lbl6c.Text = String.Empty
                        Else
                            lbl6c.Text = Jeu(i, j)
                        End If
                        lbl6c.BackColor = couleur(i, j)
                    Case 7
                        If Jeu(i, j) = 0 Then
                            lbl7c.Text = String.Empty
                        Else
                            lbl7c.Text = Jeu(i, j)
                        End If
                        lbl7c.BackColor = couleur(i, j)
                    Case 8
                        If Jeu(i, j) = 0 Then
                            lbl8c.Text = String.Empty
                        Else
                            lbl8c.Text = Jeu(i, j)
                        End If
                        lbl8c.BackColor = couleur(i, j)
                    Case 9
                        If Jeu(i, j) = 0 Then
                            lbl9c.Text = String.Empty
                        Else
                            lbl9c.Text = Jeu(i, j)
                        End If
                        lbl9c.BackColor = couleur(i, j)
                    Case 10
                        If Jeu(i, j) = 0 Then
                            lbl10c.Text = String.Empty
                        Else
                            lbl10c.Text = Jeu(i, j)
                        End If
                        lbl10c.BackColor = couleur(i, j)
                    Case 11
                        If Jeu(i, j) = 0 Then
                            lbl11c.Text = String.Empty
                        Else
                            lbl11c.Text = Jeu(i, j)
                        End If
                        lbl11c.BackColor = couleur(i, j)
                    Case 12
                        If Jeu(i, j) = 0 Then
                            lbl12c.Text = String.Empty
                        Else
                            lbl12c.Text = Jeu(i, j)
                        End If
                        lbl12c.BackColor = couleur(i, j)
                    Case 13
                        If Jeu(i, j) = 0 Then
                            lbl13c.Text = String.Empty
                        Else
                            lbl13c.Text = Jeu(i, j)
                        End If
                        lbl13c.BackColor = couleur(i, j)
                    Case 14
                        If Jeu(i, j) = 0 Then
                            lbl14c.Text = String.Empty
                        Else
                            lbl14c.Text = Jeu(i, j)
                        End If
                        lbl14c.BackColor = couleur(i, j)
                    Case 15
                        If Jeu(i, j) = 0 Then
                            lbl15c.Text = String.Empty
                        Else
                            lbl15c.Text = Jeu(i, j)
                        End If
                        lbl15c.BackColor = couleur(i, j)
                    Case 16
                        If Jeu(i, j) = 0 Then
                            lbl16c.Text = String.Empty
                        Else
                            lbl16c.Text = Jeu(i, j)
                        End If
                        lbl16c.BackColor = couleur(i, j)
                End Select

            Next
        Next

        'Le lblscore et lblscoremax sont affichés
        lblScorec.Text = Score
        lblscoremaxc.Text = scoremax

        'Détecter si le joueur abtient 2048
        If case2048() = True Then
            MsgBox("Félicitation, vous obtenez 2048 !")
        End If

        'Nous avons fait une condition qui permet l'accessiblité des touches
        'Si le jeu est terminé, alors le bouton de retour ne sont plus accessible
        'De plus, un Msgbox s'affiche en disant que le jeu est terminé
        If JeuTermine() = True Then
            MsgBox("Le jeu est terminé, votre score est " & Score)
            btnUndoc.Enabled = False
            Me.KeyPreview = False
        End If
    End Sub


    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean
        'détecter si les touches de direction sont pressées
        If keyData = Keys.Up Or keyData = Keys.Down Or keyData = Keys.Left Or keyData = Keys.Right Then
            Return False
        Else
            Return MyBase.ProcessDialogKey(keyData)
        End If
    End Function

    Private Sub Form2048_avec_clavier_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        'Affecter les tâches 8à chaque fois qu'on presse les touches de direction sur le clavier
        Select Case e.KeyCode
            Case Keys.Left
                'Cette fonction gère le déplacement à gauche

                'Le bouton retour est accessible
                btnUndoc.Enabled = True
                'On prends en compte les derniers changements en appellant preserver() qui se trouve dans le module
                preserver()
                'On appelle DeplacerGauche() qui se trouve dans le module
                DeplacerGauche()
                'Si on utilise changement(), alors on appelle TirerAleatoirement() et on Affiche()
                'Dans ce cas, on appuyant ici, un nouveau chiffre apparait dans une case vide
                'Si on ne peut pas aller à gauche, alors un Msgbox apparait
                If changement() Then
                    TirerAleatoirement()
                    Affiche()
                Else
                    MsgBox("Choisissez une autre direction SVP")
                End If
            Case Keys.Right
                'Cette fonction gère le déplacement à droite

                'Le bouton retour est accessible
                btnUndoc.Enabled = True
                'On prends en compte les derniers changements en appellant preserver() qui se trouve dans le module
                preserver()
                'On appelle DeplacerDroit()e qui se trouve dans le module
                DeplacerDroite()
                'Si on utilise changement(), alors on appelle TirerAleatoirement() et on Affiche()
                'Dans ce cas, on appuyant ici, un nouveau chiffre apparait dans une case vide
                'Si on ne peut pas aller à droite, alors un Msgbox apparait
                If changement() Then
                    TirerAleatoirement()
                    Affiche()
                Else
                    MsgBox("Choisissez une autre direction SVP")
                End If
            Case Keys.Down
                'Cette fonction gère le déplacement en bas

                'Le bouton retour est accessible

                btnUndoc.Enabled = True
                'On prends en compte les derniers changements en appellant preserver() qui se trouve dans le module
                preserver()
                'On appelle DeplacerBas() qui se trouve dans le module

                DeplacerBas()
                'Si on utilise changement(), alors on appelle TirerAleatoirement() et on Affiche()
                'Dans ce cas, on appuyant ici, un nouveau chiffre apparait dans une case vide
                'Si on ne peut pas aller en bas, alors un Msgbox apparait
                If changement() Then
                    TirerAleatoirement()
                    Affiche()
                Else
                    MsgBox("Choisissez une autre direction SVP")
                End If

            Case Keys.Up
                'Cette fonction gère le déplacement en haut

                'Le bouton retour est accessible
                btnUndoc.Enabled = True
                'On prends en compte les derniers changements en appellant preserver() qui se trouve dans le module
                preserver()
                'On appelle Deplacerhaut() qui se trouve dans le module

                DeplacerHaut()
                'Si on utilise changement(), alors on appelle TirerAleatoirement() et on Affiche()
                'Dans ce cas, on appuyant ici, un nouveau chiffre apparait dans une case vide
                'Si on ne peut pas aller en haut, alors un Msgbox apparait
                If changement() Then
                    TirerAleatoirement()
                    Affiche()
                Else
                    MsgBox("Choisissez une autre direction SVP")
                End If

        End Select
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndoc.Click
        'Cette fonction gère l'annulation du coup qui vient d'être joué (on ne peut annuler qu'un coup)

        'On utilise la même boucle que précédemment avec les 2 variables (i et j)
        'Les cases et les scores reprennent leurs valeurs précédentes
        Dim i, j As Byte
        For i = 1 To n
            For j = 1 To n
                Jeu(i, j) = Jeuavant(i, j)
            Next
        Next
        Score = Scoreavant
        scoremax = scoremaxavant
        'On appelle Affiche()
        Affiche()
        'Une fois le btnUndo activé, alors il ne peut pas redevenir accessible
        btnUndoc.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1c.Click
        'Cette fonction permet juste au joueur de pouvoir visualiser les règles du jeu
        MsgBox("Le but du jeu est de fusionner des nombres ensembles (puissance de 2) afin d'atteindre le nombre ultime 2048 et gagner la partie." & Chr(10) & Chr(10) &
               "L'aire du jeu 2048 est une grille de 4 lignes par 4 colonnes avec donc 16 cellules carrés. Chaque cellule peut être vide ou contenir un nombre. " & "" &
               "Au début du jeu, il y a 2 cases avec un chiffre '2' ou '4' à l'intérieur. " & Chr(10) & Chr(10) &
               "Lorsque vous parvenez à faire entrer en collision 2 cases avec le même numéro dedans, elles fusionnent en un seul nouveau numéro. " & "" &
               "Le numéro sera l'addition des 2 nombres précédents : 2+2 = 4, 4+4=8,... 1024+1024=2048 !" & Chr(10) & Chr(10) &
               "Pour déplacer les chiffres sur la grille, vous devez juste choisir une direction  (haut, bas, droit, gauche). Tous les numéros vont se " & "" &
               "déplacer dans la direction sélectionnée, jusqu'à ce qu'elles fusionnent avec un numéro de même valeur ou bien qu'elles soient bloquées par une " & "" &
               "case avec un numéro différent." & Chr(10) & Chr(10) &
               "Utilisez simplement les 4 flèches directionnelles du clavier pour déplacer les numéros. ")
    End Sub

    Private Sub btnRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnRestartc.Click
        'Cette fonction gère le demarrage et le redémarage d'une partie en appellant Initialiser() qui se trouve dans le module
        'Elle affiche aussi la fonction précédente donc l'interface du jeu
        Initialiser()
        Affiche()
        Me.KeyPreview = True
    End Sub

    Private Sub btnaccueilc_Click(sender As System.Object, e As System.EventArgs) Handles btnaccueilc.Click
        'Retour au form accueil
        Dim message As String = "Vous êtes sûr de quitter le jeu ? "
        Dim caption As String = "Fermer le form2048_avec_clavier"
        Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim resultat As DialogResult

        resultat = MessageBox.Show(message, caption, button)

        If resultat = System.Windows.Forms.DialogResult.Yes Then
            Accueil.Show()
            Me.Close()
        End If
    End Sub
End Class