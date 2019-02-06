Public Class Form2048
    'Cette fonction permet de charger form2048 qui est le nom de notre interface 
    Private Sub Form2048_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' La commande Msgbox permet d'afficher une boite de dialogue
        MsgBox("Bonjour, je suis Captain. J'ai 101 ans, je ne sais pas utiliser le clavier comme mon ami Tony Stark (alias IronMan), vous devez donc utiliser la souris. Bonne chance ! ")
        'Le lblscoremax correspond au score maximum qui l'a fait
        lblscoremax.Text = scoremax
        'Le lblscore sera de 0 car nous sommes au début du jeu, le joueur n'a pas encore commencé à jouer
        lblScore.Text = 0
        'Le bouton retour est inaccessible car aucune action n'a été faite
        btnUndo.Enabled = False
        'Les boutons de direction sont inaccessibles car le joueur n'a pas encore lancé le jeu en appuyant sur "Jouer"
        btnUp.Enabled = False
        btnDown.Enabled = False
        btnLeft.Enabled = False
        btnRight.Enabled = False

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
                            lbl1.Text = String.Empty
                        Else
                            lbl1.Text = Jeu(i, j)
                        End If
                        lbl1.BackColor = couleur(i, j)
                    Case 2
                        If Jeu(i, j) = 0 Then
                            lbl2.Text = String.Empty
                        Else
                            lbl2.Text = Jeu(i, j)
                        End If
                        lbl2.BackColor = couleur(i, j)
                    Case 3
                        If Jeu(i, j) = 0 Then
                            lbl3.Text = String.Empty
                        Else
                            lbl3.Text = Jeu(i, j)
                        End If
                        lbl3.BackColor = couleur(i, j)
                    Case 4
                        If Jeu(i, j) = 0 Then
                            lbl4.Text = String.Empty
                        Else
                            lbl4.Text = Jeu(i, j)
                        End If
                        lbl4.BackColor = couleur(i, j)
                    Case 5
                        If Jeu(i, j) = 0 Then
                            lbl5.Text = String.Empty
                        Else
                            lbl5.Text = Jeu(i, j)
                        End If
                        lbl5.BackColor = couleur(i, j)
                    Case 6
                        If Jeu(i, j) = 0 Then
                            lbl6.Text = String.Empty
                        Else
                            lbl6.Text = Jeu(i, j)
                        End If
                        lbl6.BackColor = couleur(i, j)
                    Case 7
                        If Jeu(i, j) = 0 Then
                            lbl7.Text = String.Empty
                        Else
                            lbl7.Text = Jeu(i, j)
                        End If
                        lbl7.BackColor = couleur(i, j)
                    Case 8
                        If Jeu(i, j) = 0 Then
                            lbl8.Text = String.Empty
                        Else
                            lbl8.Text = Jeu(i, j)
                        End If
                        lbl8.BackColor = couleur(i, j)
                    Case 9
                        If Jeu(i, j) = 0 Then
                            lbl9.Text = String.Empty
                        Else
                            lbl9.Text = Jeu(i, j)
                        End If
                        lbl9.BackColor = couleur(i, j)
                    Case 10
                        If Jeu(i, j) = 0 Then
                            lbl10.Text = String.Empty
                        Else
                            lbl10.Text = Jeu(i, j)
                        End If
                        lbl10.BackColor = couleur(i, j)
                    Case 11
                        If Jeu(i, j) = 0 Then
                            lbl11.Text = String.Empty
                        Else
                            lbl11.Text = Jeu(i, j)
                        End If
                        lbl11.BackColor = couleur(i, j)
                    Case 12
                        If Jeu(i, j) = 0 Then
                            lbl12.Text = String.Empty
                        Else
                            lbl12.Text = Jeu(i, j)
                        End If
                        lbl12.BackColor = couleur(i, j)
                    Case 13
                        If Jeu(i, j) = 0 Then
                            lbl13.Text = String.Empty
                        Else
                            lbl13.Text = Jeu(i, j)
                        End If
                        lbl13.BackColor = couleur(i, j)
                    Case 14
                        If Jeu(i, j) = 0 Then
                            lbl14.Text = String.Empty
                        Else
                            lbl14.Text = Jeu(i, j)
                        End If
                        lbl14.BackColor = couleur(i, j)
                    Case 15
                        If Jeu(i, j) = 0 Then
                            lbl15.Text = String.Empty
                        Else
                            lbl15.Text = Jeu(i, j)
                        End If
                        lbl15.BackColor = couleur(i, j)
                    Case 16
                        If Jeu(i, j) = 0 Then
                            lbl16.Text = String.Empty
                        Else
                            lbl16.Text = Jeu(i, j)
                        End If
                        lbl16.BackColor = couleur(i, j)
                End Select

            Next
        Next

        'Le lblscore et lblscoremax sont affichés
        lblScore.Text = Score
        lblscoremax.Text = scoremax

        'Détecter si le joueur abtient 2048
        If case2048() = True Then
            MsgBox("Félicitation, vous obtenez 2048 !")
        End If

        'Nous avons fait une condition qui permet l'accessiblité des touches
        'Si le jeu est terminé, alors les boutons de direction ainsi que de retour sont plus accessible
        'De plus, un Msgbox s'affiche en disant que le jeu est terminé
        ' Sinon, les boutons sont accessibles
        If JeuTermine() = True Then
            MsgBox("Le jeu est terminé, votre score est " & Score)
            btnUndo.Enabled = False
            btnUp.Enabled = False
            btnDown.Enabled = False
            btnLeft.Enabled = False
            btnRight.Enabled = False
        Else
            btnUp.Enabled = True
            btnDown.Enabled = True
            btnLeft.Enabled = True
            btnRight.Enabled = True
        End If

    End Sub

    Private Sub btnRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnRestart.Click
        'Cette fonction gère le demarrage et le redémarage d'une partie en appellant Initialiser() qui se trouve dans le module
        'Elle affiche aussi la fonction précédente donc l'interface du jeu
        Initialiser()
        Affiche()
    End Sub

    Private Sub btnUndo_Click(sender As System.Object, e As System.EventArgs) Handles btnUndo.Click
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
        btnUndo.Enabled = False

    End Sub

    Private Sub btnLeft_Click(sender As System.Object, e As System.EventArgs) Handles btnLeft.Click
        'Cette fonction gère le déplacement à gauche

        'Le bouton retour est accessible
        btnUndo.Enabled = True
        'On prends en compte les derniers changements en appellant preserver() qui se trouve dans le module
        DeplacerGauche()
        'Si on utilise changement(), alors on appelle TirerAleatoirement() et on Affiche()
        'Dans ce cas, on appuyant ici, un nouveau chiffre apparait dans une case vide
        'Si on ne peut pas aller à gauche, alors un Msgbox apparait
        If changement() Then
            TirerAleatoirement()
            Affiche()
            preserver()
            'On appelle DeplacerGauche() qui se trouve dans le module
        Else
            MsgBox("Choisissez une autre direction SVP")
        End If



    End Sub

    Private Sub btnRight_Click(sender As System.Object, e As System.EventArgs) Handles btnRight.Click
        'Cette fonction gère le déplacement à droite

        'Le bouton retour est accessible
        btnUndo.Enabled = True
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

    End Sub

    Private Sub btnUp_Click(sender As System.Object, e As System.EventArgs) Handles btnUp.Click
        'Cette fonction gère le déplacement en haut

        'Le bouton retour est accessible
        btnUndo.Enabled = True
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
    End Sub

    Private Sub btnDown_Click(sender As System.Object, e As System.EventArgs) Handles btnDown.Click
        'Cette fonction gère le déplacement en bas

        'Le bouton retour est accessible
        btnUndo.Enabled = True
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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

   
    Private Sub btnaccueil_Click(sender As System.Object, e As System.EventArgs) Handles btnaccueil.Click
        'Retour au form accueil
        Dim message As String = "Vous êtes sûr de quitter le jeu ? "
        Dim caption As String = "Fermer le form2048"
        Dim button As MessageBoxButtons = MessageBoxButtons.YesNo
        Dim resultat As DialogResult

        resultat = MessageBox.Show(message, caption, button)

        If resultat = System.Windows.Forms.DialogResult.Yes Then
            Accueil.Show()
            Me.Close()
        End If
    End Sub
End Class
