<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2048
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2048))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lbl14 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.lbl16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblscoremax = New System.Windows.Forms.Label()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnaccueil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(206, 125)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(76, 20)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "le score..."
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRestart
        '
        Me.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestart.Location = New System.Drawing.Point(76, 61)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(80, 40)
        Me.btnRestart.TabIndex = 6
        Me.btnRestart.Text = "Jouer"
        Me.btnRestart.UseVisualStyleBackColor = False
        '
        'btnUndo
        '
        Me.btnUndo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.Location = New System.Drawing.Point(76, 115)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(80, 40)
        Me.btnUndo.TabIndex = 7
        Me.btnUndo.Text = "Retour"
        Me.btnUndo.UseVisualStyleBackColor = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(74, 180)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(70, 70)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "2048"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(144, 180)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(70, 70)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "2048"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(214, 180)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(70, 70)
        Me.lbl3.TabIndex = 10
        Me.lbl3.Text = "2048"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Black
        Me.lbl4.Location = New System.Drawing.Point(284, 180)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(70, 70)
        Me.lbl4.TabIndex = 11
        Me.lbl4.Text = "2048"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl5
        '
        Me.lbl5.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.Black
        Me.lbl5.Location = New System.Drawing.Point(74, 250)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(70, 70)
        Me.lbl5.TabIndex = 12
        Me.lbl5.Text = "2048"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl6
        '
        Me.lbl6.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.Black
        Me.lbl6.Location = New System.Drawing.Point(144, 250)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(70, 70)
        Me.lbl6.TabIndex = 13
        Me.lbl6.Text = "2048"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl7
        '
        Me.lbl7.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.Black
        Me.lbl7.Location = New System.Drawing.Point(214, 250)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(70, 70)
        Me.lbl7.TabIndex = 14
        Me.lbl7.Text = "2048"
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl8
        '
        Me.lbl8.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.Black
        Me.lbl8.Location = New System.Drawing.Point(284, 250)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(70, 70)
        Me.lbl8.TabIndex = 15
        Me.lbl8.Text = "2048"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl9
        '
        Me.lbl9.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.Black
        Me.lbl9.Location = New System.Drawing.Point(74, 320)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(70, 70)
        Me.lbl9.TabIndex = 16
        Me.lbl9.Text = "2048"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl10
        '
        Me.lbl10.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.Black
        Me.lbl10.Location = New System.Drawing.Point(144, 320)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(70, 70)
        Me.lbl10.TabIndex = 17
        Me.lbl10.Text = "2048"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl11
        '
        Me.lbl11.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl11.ForeColor = System.Drawing.Color.Black
        Me.lbl11.Location = New System.Drawing.Point(214, 320)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(70, 70)
        Me.lbl11.TabIndex = 18
        Me.lbl11.Text = "2048"
        Me.lbl11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl12
        '
        Me.lbl12.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.Black
        Me.lbl12.Location = New System.Drawing.Point(284, 320)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(70, 70)
        Me.lbl12.TabIndex = 19
        Me.lbl12.Text = "2048"
        Me.lbl12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl13
        '
        Me.lbl13.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.Color.Black
        Me.lbl13.Location = New System.Drawing.Point(74, 390)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(70, 70)
        Me.lbl13.TabIndex = 20
        Me.lbl13.Text = "2048"
        Me.lbl13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(899, 564)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(73, 179)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(281, 281)
        '
        'lbl14
        '
        Me.lbl14.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl14.ForeColor = System.Drawing.Color.Black
        Me.lbl14.Location = New System.Drawing.Point(144, 390)
        Me.lbl14.Name = "lbl14"
        Me.lbl14.Size = New System.Drawing.Size(70, 70)
        Me.lbl14.TabIndex = 22
        Me.lbl14.Text = "2048"
        Me.lbl14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl15
        '
        Me.lbl15.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl15.ForeColor = System.Drawing.Color.Black
        Me.lbl15.Location = New System.Drawing.Point(214, 390)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(70, 70)
        Me.lbl15.TabIndex = 23
        Me.lbl15.Text = "2048"
        Me.lbl15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl16
        '
        Me.lbl16.BackColor = System.Drawing.Color.SteelBlue
        Me.lbl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl16.ForeColor = System.Drawing.Color.Black
        Me.lbl16.Location = New System.Drawing.Point(284, 390)
        Me.lbl16.Name = "lbl16"
        Me.lbl16.Size = New System.Drawing.Size(70, 70)
        Me.lbl16.TabIndex = 24
        Me.lbl16.Text = "2048"
        Me.lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(452, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Règles"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Meilleur"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblscoremax
        '
        Me.lblscoremax.AutoSize = True
        Me.lblscoremax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscoremax.Location = New System.Drawing.Point(297, 126)
        Me.lblscoremax.Name = "lblscoremax"
        Me.lblscoremax.Size = New System.Drawing.Size(70, 20)
        Me.lblscoremax.TabIndex = 27
        Me.lblscoremax.Text = "Le score"
        Me.lblscoremax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeft.Location = New System.Drawing.Point(381, 332)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(73, 40)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "A gauche"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRight.Location = New System.Drawing.Point(536, 332)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(70, 40)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = "A droite"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(460, 308)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(70, 40)
        Me.btnUp.TabIndex = 2
        Me.btnUp.Text = "En haut"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.Location = New System.Drawing.Point(460, 357)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(70, 40)
        Me.btnDown.TabIndex = 3
        Me.btnDown.Text = "En bas"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnaccueil
        '
        Me.btnaccueil.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnaccueil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaccueil.Location = New System.Drawing.Point(452, 498)
        Me.btnaccueil.Name = "btnaccueil"
        Me.btnaccueil.Size = New System.Drawing.Size(85, 30)
        Me.btnaccueil.TabIndex = 28
        Me.btnaccueil.Text = "Accueil"
        Me.btnaccueil.UseVisualStyleBackColor = False
        '
        'Form2048
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(899, 564)
        Me.Controls.Add(Me.btnaccueil)
        Me.Controls.Add(Me.lblscoremax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl16)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl14)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.lbl7)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form2048"
        Me.Text = "Jeu du 2048"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl11 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl14 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label
    Friend WithEvents lbl16 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblscoremax As System.Windows.Forms.Label
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnaccueil As System.Windows.Forms.Button

End Class
