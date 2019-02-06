Module Module2048

    'On déclare en public les variables ci-dessous car elle concerne l'ensemble de l'application
    Public n As Byte = 4
    Public Jeu(n, n) As Short
    Public Score As Short
    Public Jeuavant(n, n) As Short
    Public Scoreavant As Short
    Public scoremax As Short = 0
    Public scoremaxavant As Short


    Public Sub Initialiser() 'On initialise ici le jeu 
        'Le score est de 0 au départ
        Score = 0
        Dim i As Byte, j As Byte '"i" et "j" sont des variables
        'ces boucles permettent de donner comme valeur 0 pour l'ensemble des cases du jeu 
        For i = 1 To n
            For j = 1 To n
                Jeu(i, j) = 0
            Next
        Next
        'On appelle TirerAleatoirement() 2 fois pour pouvoir avoir les 2 nouveaux numéros (2 ou 4)
        TirerAleatoirement()
        TirerAleatoirement()
    End Sub

    Public Function JeuTermine() As Boolean 'Cette fonction permet de terminer le jeu
        Dim vide As Boolean = False 'On déclare la variable vide en boolean avec pour valeur false
        Dim i, j As Byte 'On déclare 2 variables
        'On fait 2 boucles
        'Le but de ces boucles est de regarder si les cases sont vides ou pas
        'Si elles sont vides, alors le jeu continue et jeutermine = false
        'Si elles ne sont pas vides, alors le jeu se termine et jeutermine = true
        'Il faut aussi que fusionpossible soit impossible pour que le jeu se termine
        For i = 1 To n
            For j = 1 To n
                If Jeu(i, j) = 0 Then
                    vide = True
                End If
            Next
        Next
        If vide = False And fusionpossible() = False Then
            JeuTermine = True
        Else
            JeuTermine = False
        End If
    End Function

    Public Function case2048() As Boolean
        Dim trouver As Boolean = False
        'Cette fonction permet de détecter si le numéro 2048 apparaît
        Dim i, j As Byte
        For i = 1 To n
            For j = 1 To n
                If Jeu(i, j) = 2048 Then
                    trouver = True
                End If
            Next
        Next
        Return trouver
    End Function

    Public Sub TirerAleatoirement() 'Cette fonction permet d'avoir des nouveaux chiffres aléatoirement (avec comme valeur 2 ou 4)
        Dim lig As Byte, col As Byte 'On déclare 2 variables
        Randomize() 'On utilise Randomize() pour pouvoir générer aléatoirement des nombres aléatoires
        lig = CByte(Int(n * Rnd() + 1))
        col = CByte(Int(n * Rnd() + 1))
        'On utilise un if pour pouvoir rajouter aléatoirement des chiffres dans les cases vides
        'On aura donc comme valeur 2 ou 4
        If Jeu(lig, col) = 0 Then
            Jeu(lig, col) = CByte(Int(2 * Rnd() + 1) * 2)
        Else
            Do Until Jeu(lig, col) = 0
                lig = CByte(Int(n * Rnd() + 1))
                col = CByte(Int(n * Rnd() + 1))
            Loop
            Jeu(lig, col) = CByte(Int(2 * Rnd() + 1) * 2)
        End If

    End Sub

    Public Sub DeplacerGauche() 'Cette fonction va permettre le déplacement à gauche

        Dim i As Byte 'On déclare une variable
        'Cette boucle va pouvoir déplacer les chiffres dans les cases de droite à gauche
        'On a mis toutes les possibilités
        For i = 1 To n
            'Les cases ne pourront aller vers la gauche que jusqu'à ce qu'un chiffre bloque son déplacement vers la gauche
            'Par ex, si un chiffre est à droite, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement à gauche
            If Jeu(i, 1) + Jeu(i, 2) + Jeu(i, 3) + Jeu(i, 4) <> 0 Then
                Do While Jeu(i, 1) = 0
                    Jeu(i, 1) = Jeu(i, 2)
                    Jeu(i, 2) = Jeu(i, 3)
                    Jeu(i, 3) = Jeu(i, 4)
                    Jeu(i, 4) = 0

                Loop
                'Si le chiffre est à la 2ème case en partant de la droite, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement à gauche
                'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                If Jeu(i, 2) + Jeu(i, 3) + Jeu(i, 4) <> 0 Then
                    Do While Jeu(i, 2) = 0
                        Jeu(i, 2) = Jeu(i, 3)
                        Jeu(i, 3) = Jeu(i, 4)
                        Jeu(i, 4) = 0

                    Loop
                    'Si le chiffre est à la 3ème case en partant de la droite, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement à gauche
                    'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                    If Jeu(i, 3) + Jeu(i, 4) <> 0 Then
                        If Jeu(i, 3) = 0 Then
                            Jeu(i, 3) = Jeu(i, 4)
                            Jeu(i, 4) = 0
                        End If
                    End If
                End If
            End If

            'Ces différents if vont pouvoir exécuter la fusion et calculer le score à chaque déplacement
            'On regarde si les 2 chiffres sont égaux, si c'est le cas, alors on les multiplie ensemble
            'le score aussi se met à jour à chaque fusion. Il ajoute à son score actuel le résultat de la fusion
            'Si le score actuel est supérieur au meilleur score, alors le score actuel devient le meilleur
            If Jeu(i, 1) = Jeu(i, 2) Then
                Jeu(i, 1) = 2 * Jeu(i, 1)
                Score = Score + Jeu(i, 1)
                If scoremax < Score Then
                    scoremax = Score
                End If
                If Jeu(i, 3) = Jeu(i, 4) Then
                    Jeu(i, 2) = 2 * Jeu(i, 3)
                    Score = Score + Jeu(i, 2)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(i, 3) = 0
                    Jeu(i, 4) = 0
                Else
                    Jeu(i, 2) = Jeu(i, 3)
                    Jeu(i, 3) = Jeu(i, 4)
                    Jeu(i, 4) = 0
                End If
            Else
                If Jeu(i, 2) = Jeu(i, 3) Then
                    Jeu(i, 2) = 2 * Jeu(i, 2)
                    Score = Score + Jeu(i, 2)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(i, 3) = Jeu(i, 4)
                    Jeu(i, 4) = 0
                Else
                    If Jeu(i, 3) = Jeu(i, 4) Then
                        Jeu(i, 3) = 2 * Jeu(i, 3)
                        Score = Score + Jeu(i, 3)
                        If scoremax < Score Then
                            scoremax = Score
                        End If
                        Jeu(i, 4) = 0
                    End If
                End If
            End If
        Next


    End Sub

    Public Sub DeplacerDroite() 'Cette fonction va permettre le déplacement à droite
        Dim i As Byte 'On déclare une variable
        'Cette boucle va pouvoir déplacer les chiffres dans les cases de gauche à droite
        'On a mis toutes les possibilités
        For i = 1 To n   'Les cases ne pourront aller vers la droite que jusqu'à ce qu'un chiffre bloque son déplacement
            'Par ex, si un chiffre est à gauche, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement à droite
            If Jeu(i, 1) + Jeu(i, 2) + Jeu(i, 3) + Jeu(i, 4) <> 0 Then
                Do While Jeu(i, 4) = 0
                    Jeu(i, 4) = Jeu(i, 3)
                    Jeu(i, 3) = Jeu(i, 2)
                    Jeu(i, 2) = Jeu(i, 1)
                    Jeu(i, 1) = 0
                Loop
                'Si le chiffre est à la 2ème case en partant de la gauche, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement à droite
                'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                If Jeu(i, 1) + Jeu(i, 2) + Jeu(i, 3) <> 0 Then
                    Do While Jeu(i, 3) = 0
                        Jeu(i, 3) = Jeu(i, 2)
                        Jeu(i, 2) = Jeu(i, 1)
                        Jeu(i, 1) = 0
                    Loop
                    'Si le chiffre est à la 3ème case en partant de la gauche, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement à droite
                    'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                    If Jeu(i, 1) + Jeu(i, 2) <> 0 Then
                        If Jeu(i, 2) = 0 Then
                            Jeu(i, 2) = Jeu(i, 1)
                            Jeu(i, 1) = 0
                        End If
                    End If
                End If
            End If
            'Ces différents if vont pouvoir exécuter la fusion et calculer le score à chaque déplacement
            'On regarde si les 2 chiffres sont égaux, si c'est le cas, alors on les multiplie ensemble
            'le score aussi se met à jour à chaque fusion. Il ajoute à son score actuel le résultat de la fusion
            'Si le score actuel est supérieur au meilleur score, alors le score actuel devient le meilleur

            If Jeu(i, 4) = Jeu(i, 3) Then
                Jeu(i, 4) = 2 * Jeu(i, 4)
                Score = Score + Jeu(i, 4)
                If scoremax < Score Then
                    scoremax = Score
                End If
                If Jeu(i, 2) = Jeu(i, 1) Then
                    Jeu(i, 3) = 2 * Jeu(i, 2)
                    Score = Score + Jeu(i, 3)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(i, 2) = 0
                    Jeu(i, 1) = 0
                Else
                    Jeu(i, 3) = Jeu(i, 2)
                    Jeu(i, 2) = Jeu(i, 1)
                    Jeu(i, 1) = 0
                End If
            Else
                If Jeu(i, 3) = Jeu(i, 2) Then
                    Jeu(i, 3) = 2 * Jeu(i, 3)
                    Score = Score + Jeu(i, 3)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(i, 2) = Jeu(i, 1)
                    Jeu(i, 1) = 0
                Else
                    If Jeu(i, 2) = Jeu(i, 1) Then
                        Jeu(i, 2) = 2 * Jeu(i, 2)
                        Score = Score + Jeu(i, 2)
                        If scoremax < Score Then
                            scoremax = Score
                        End If
                        Jeu(i, 1) = 0
                    End If
                End If
            End If
        Next

    End Sub

    Public Sub DeplacerHaut() 'Cette fonction va permettre le déplacement en haut
        Dim j As Byte 'On déclare une variable
        'Cette boucle va pouvoir déplacer les chiffres dans les cases de bas en haut
        'On a mis toutes les possibilités
        For j = 1 To n 'Les cases ne pourront aller vers le haut que jusqu'à ce qu'un chiffre
            'Par ex, si un chiffre est à haut, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement en bas
            If Jeu(1, j) + Jeu(2, j) + Jeu(3, j) + Jeu(4, j) <> 0 Then
                Do While Jeu(1, j) = 0
                    Jeu(1, j) = Jeu(2, j)
                    Jeu(2, j) = Jeu(3, j)
                    Jeu(3, j) = Jeu(4, j)
                    Jeu(4, j) = 0
                Loop
                'Si le chiffre est à la 2ème case en partant du bas, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement en haut
                'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                If Jeu(2, j) + Jeu(3, j) + Jeu(4, j) <> 0 Then
                    Do While Jeu(2, j) = 0
                        Jeu(2, j) = Jeu(3, j)
                        Jeu(3, j) = Jeu(4, j)
                        Jeu(4, j) = 0
                    Loop
                    'Si le chiffre est à la 3ème case en partant du bas, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement en haut
                    'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                    If Jeu(3, j) + Jeu(4, j) <> 0 Then
                        If Jeu(3, j) = 0 Then
                            Jeu(3, j) = Jeu(4, j)
                            Jeu(4, j) = 0
                        End If
                    End If
                End If
            End If
            'Ces différents if vont pouvoir exécuter la fusion et calculer le score à chaque déplacement
            'On regarde si les 2 chiffres sont égaux, si c'est le cas, alors on les multiplie ensemble
            'le score aussi se met à jour à chaque fusion. Il ajoute à son score actuel le résultat de la fusion
            'Si le score actuel est supérieur au meilleur score, alors le score actuel devient le meilleur

            If Jeu(1, j) = Jeu(2, j) Then
                Jeu(1, j) = 2 * Jeu(1, j)
                Score = Score + Jeu(1, j)
                If scoremax < Score Then
                    scoremax = Score
                End If
                If Jeu(3, j) = Jeu(4, j) Then
                    Jeu(2, j) = 2 * Jeu(3, j)
                    Score = Score + Jeu(2, j)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(3, j) = 0
                    Jeu(4, j) = 0
                Else
                    Jeu(2, j) = Jeu(3, j)
                    Jeu(3, j) = Jeu(4, j)
                    Jeu(4, j) = 0
                End If
            Else
                If Jeu(2, j) = Jeu(3, j) Then
                    Jeu(2, j) = 2 * Jeu(2, j)
                    Score = Score + Jeu(2, j)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(3, j) = Jeu(4, j)
                    Jeu(4, j) = 0
                Else
                    If Jeu(3, j) = Jeu(4, j) Then
                        Jeu(3, j) = 2 * Jeu(3, j)
                        Score = Score + Jeu(3, j)
                        If scoremax < Score Then
                            scoremax = Score
                        End If
                        Jeu(4, j) = 0
                    End If
                End If
            End If
        Next


    End Sub

    Public Sub DeplacerBas() 'Cette fonction va permettre le déplacement en bas
        Dim j As Byte 'On déclare une variable
        'Cette boucle va pouvoir déplacer les chiffres dans les cases de haut en bas
        'On a mis toutes les possibilités
        For j = 1 To n 'Les cases ne pourront aller vers le bas que jusqu'à ce qu'un chiffre bloque son déplacement 
            'Par ex, si un chiffre est en haut, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement en bas
            If Jeu(1, j) + Jeu(2, j) + Jeu(3, j) + Jeu(4, j) <> 0 Then
                Do While Jeu(4, j) = 0
                    Jeu(4, j) = Jeu(3, j)
                    Jeu(3, j) = Jeu(2, j)
                    Jeu(2, j) = Jeu(1, j)
                    Jeu(1, j) = 0
                Loop
                'Si le chiffre est à la 2ème case en partant du haut, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement en bas
                'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                If Jeu(1, j) + Jeu(2, j) + Jeu(3, j) <> 0 Then
                    Do While Jeu(3, j) = 0
                        Jeu(3, j) = Jeu(2, j)
                        Jeu(2, j) = Jeu(1, j)
                        Jeu(1, j) = 0
                    Loop
                    'Si le chiffre est à la 3ème case en partant du haut, et qu'il n'y a aucun chiffre dans sa trajectoire, il ira directement en bas
                    'iL s'arretera dès qu'un chiffre est sur sa trajectoire
                    If Jeu(1, j) + Jeu(2, j) <> 0 Then
                        If Jeu(2, j) = 0 Then
                            Jeu(2, j) = Jeu(1, j)
                            Jeu(1, j) = 0
                        End If
                    End If
                End If
            End If
            'Ces différents if vont pouvoir exécuter la fusion et calculer le score à chaque déplacement
            'On regarde si les 2 chiffres sont égaux, si c'est le cas, alors on les multiplie ensemble
            'le score aussi se met à jour à chaque fusion. Il ajoute à son score actuel le résultat de la fusion
            'Si le score actuel est supérieur au meilleur score, alors le score actuel devient le meilleur
            If Jeu(4, j) = Jeu(3, j) Then
                Jeu(4, j) = 2 * Jeu(4, j)
                Score = Score + Jeu(4, j)
                If scoremax < Score Then
                    scoremax = Score
                End If
                If Jeu(2, j) = Jeu(1, j) Then
                    Jeu(3, j) = 2 * Jeu(2, j)
                    Score = Score + Jeu(3, j)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(2, j) = 0
                    Jeu(1, j) = 0
                Else
                    Jeu(3, j) = Jeu(2, j)
                    Jeu(2, j) = Jeu(1, j)
                    Jeu(1, j) = 0
                End If
            Else
                If Jeu(2, j) = Jeu(3, j) Then
                    Jeu(3, j) = 2 * Jeu(3, j)
                    Score = Score + Jeu(3, j)
                    If scoremax < Score Then
                        scoremax = Score
                    End If
                    Jeu(2, j) = Jeu(1, j)
                    Jeu(1, j) = 0
                Else
                    If Jeu(2, j) = Jeu(1, j) Then
                        Jeu(2, j) = 2 * Jeu(2, j)
                        Score = Score + Jeu(2, j)
                        If scoremax < Score Then
                            scoremax = Score
                        End If
                        Jeu(1, j) = 0
                    End If
                End If
            End If
        Next

    End Sub

    Public Sub preserver() 'Cette fonction permet de garder les valeurs actuelles

        Dim i, j As Byte 'On déclare 2 variables
        'On a fait 2 boucles pour le tableau à 2 dimensions
        For i = 1 To n
            For j = 1 To n
                Jeuavant(i, j) = Jeu(i, j) 'Affecter les valeurs actuelles dans le tableau jeuavant(i,j)
            Next
        Next
        Scoreavant = Score 'On garde le score actuel dans scoreavant
        scoremaxavant = scoremax 'On garde le score actuel dans scoremaxavant
    End Sub

    Public Function fusionpossible() As Boolean 'Cette fonction permet de détecter si les cases ont la possibilité d'être fusionnée
        fusionpossible = False 'Fusion possible est false au début
        Dim i, j As Byte 'On déclare 2 variables
        'On vérifie les cases côte à côte (en ligne)
        For i = 1 To 4
            For j = 1 To 3
                If Jeu(i, j) <> 0 Then 'Si les cases ne sont pas vides
                    If Jeu(i, j) = Jeu(i, j + 1) Then 'On compare 2 cases côte à côte (en ligne)
                        fusionpossible = True 'Si ce sont les mêmes alors fusions possibles
                    End If
                End If
            Next
        Next
        'On vérifie les cases côte à côte (en colonne)
        For i = 1 To 3
            For j = 1 To 4
                If Jeu(i, j) <> 0 Then 'Si les cases ne sont pas vides
                    If Jeu(i, j) = Jeu(i + 1, j) Then 'On compare 2 cases côte à côte (en colonne)
                        fusionpossible = True 'Si ce sont les mêmes alors fusions possibles
                    End If
                End If
            Next
        Next

    End Function

    Public Function changement() As Boolean 'Cette fonction permet de procéder au changement du jeu précédent au jeu actuel 
        changement = False 'Changement est false au début
        Dim i, j As Byte 'On déclare 2 variables
        'Ces 2 boucles faisant le tableau à 2 dimensions permettent de comparer les valeurs précédentes et actuelles
        For i = 1 To n
            For j = 1 To n
                Do While Jeu(i, j) <> Jeuavant(i, j)
                    'Si il y a de changement, retourner true
                    Return True
                Loop
            Next
        Next

    End Function

    Public Function couleur(ByVal i As Byte, ByVal j As Byte) As Color 'Cette fonction permet d'associer aux cases des couleurs différentes
        'Les couleurs changeront en fonction des chiffres liés aux fusions par exemple
        '2 = blanches
        '4 = jaune
        '8 = beige

        Select Case Jeu(i, j)
            Case 2
                couleur = Color.WhiteSmoke
            Case 2
                couleur = Color.LemonChiffon
            Case 4
                couleur = Color.Yellow
            Case 8
                couleur = Color.Beige
            Case 16
                couleur = Color.RosyBrown
            Case 32
                couleur = Color.PeachPuff
            Case 64
                couleur = Color.Coral
            Case 128
                couleur = Color.Orange
            Case 256
                couleur = Color.OrangeRed
            Case 512
                couleur = Color.Fuchsia
            Case 1024
                couleur = Color.Pink
            Case 2048
                couleur = Color.Purple
        End Select
    End Function

End Module 'FIn du module
