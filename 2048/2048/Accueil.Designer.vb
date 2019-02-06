<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accueil))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnjouer = New System.Windows.Forms.Button()
        Me.btnjoueravecclavier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(253, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jeu 2048"
        '
        'btnjouer
        '
        Me.btnjouer.BackColor = System.Drawing.Color.SteelBlue
        Me.btnjouer.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjouer.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnjouer.Location = New System.Drawing.Point(41, 257)
        Me.btnjouer.Name = "btnjouer"
        Me.btnjouer.Size = New System.Drawing.Size(219, 56)
        Me.btnjouer.TabIndex = 1
        Me.btnjouer.Text = "Jouer avec Captain"
        Me.btnjouer.UseVisualStyleBackColor = False
        '
        'btnjoueravecclavier
        '
        Me.btnjoueravecclavier.BackColor = System.Drawing.Color.Brown
        Me.btnjoueravecclavier.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnjoueravecclavier.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnjoueravecclavier.Location = New System.Drawing.Point(335, 257)
        Me.btnjoueravecclavier.Name = "btnjoueravecclavier"
        Me.btnjoueravecclavier.Size = New System.Drawing.Size(225, 56)
        Me.btnjoueravecclavier.TabIndex = 2
        Me.btnjoueravecclavier.Text = "Jouer avec Ironman"
        Me.btnjoueravecclavier.UseVisualStyleBackColor = False
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(619, 348)
        Me.Controls.Add(Me.btnjoueravecclavier)
        Me.Controls.Add(Me.btnjouer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnjouer As System.Windows.Forms.Button
    Friend WithEvents btnjoueravecclavier As System.Windows.Forms.Button
End Class
