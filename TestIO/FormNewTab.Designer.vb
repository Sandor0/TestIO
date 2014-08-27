<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewTab
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
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.Location = New System.Drawing.Point(12, 25)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(241, 20)
		Me.TextBox1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(151, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Nom de la nouvelle catégorie :"
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(15, 51)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(113, 23)
		Me.Button1.TabIndex = 2
		Me.Button1.Text = "Ajouter"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.Button2.Location = New System.Drawing.Point(134, 51)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(113, 23)
		Me.Button2.TabIndex = 3
		Me.Button2.Text = "Annuler"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'FormNewTab
		'
		Me.AcceptButton = Me.Button1
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.Button2
		Me.ClientSize = New System.Drawing.Size(265, 85)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TextBox1)
		Me.MaximumSize = New System.Drawing.Size(281, 123)
		Me.MinimumSize = New System.Drawing.Size(281, 123)
		Me.Name = "FormNewTab"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Nouvelle catégorie"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents Button1 As System.Windows.Forms.Button
	Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
