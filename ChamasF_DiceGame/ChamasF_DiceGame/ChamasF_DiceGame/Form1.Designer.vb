<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiceGame
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.lblRisk = New System.Windows.Forms.Label()
		Me.txtRisk = New System.Windows.Forms.TextBox()
		Me.lblPoints = New System.Windows.Forms.Label()
		Me.picCard = New System.Windows.Forms.PictureBox()
		Me.picCard2 = New System.Windows.Forms.PictureBox()
		Me.btnRoll = New System.Windows.Forms.Button()
		CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblRisk
		'
		Me.lblRisk.AutoSize = True
		Me.lblRisk.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRisk.Location = New System.Drawing.Point(12, 21)
		Me.lblRisk.Name = "lblRisk"
		Me.lblRisk.Size = New System.Drawing.Size(114, 16)
		Me.lblRisk.TabIndex = 1
		Me.lblRisk.Text = "Points to Risk :"
		'
		'txtRisk
		'
		Me.txtRisk.Location = New System.Drawing.Point(163, 21)
		Me.txtRisk.Name = "txtRisk"
		Me.txtRisk.Size = New System.Drawing.Size(100, 20)
		Me.txtRisk.TabIndex = 0
		'
		'lblPoints
		'
		Me.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblPoints.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPoints.Location = New System.Drawing.Point(12, 53)
		Me.lblPoints.Name = "lblPoints"
		Me.lblPoints.Size = New System.Drawing.Size(251, 19)
		Me.lblPoints.TabIndex = 2
		Me.lblPoints.Text = "Total Points : 1000"
		'
		'picCard
		'
		Me.picCard.Location = New System.Drawing.Point(15, 75)
		Me.picCard.Name = "picCard"
		Me.picCard.Size = New System.Drawing.Size(100, 100)
		Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picCard.TabIndex = 3
		Me.picCard.TabStop = False
		'
		'picCard2
		'
		Me.picCard2.Location = New System.Drawing.Point(163, 75)
		Me.picCard2.Name = "picCard2"
		Me.picCard2.Size = New System.Drawing.Size(100, 100)
		Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picCard2.TabIndex = 4
		Me.picCard2.TabStop = False
		'
		'btnRoll
		'
		Me.btnRoll.AutoSize = True
		Me.btnRoll.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRoll.Location = New System.Drawing.Point(81, 189)
		Me.btnRoll.Name = "btnRoll"
		Me.btnRoll.Size = New System.Drawing.Size(121, 26)
		Me.btnRoll.TabIndex = 3
		Me.btnRoll.Text = "Roll Dice"
		Me.btnRoll.UseVisualStyleBackColor = True
		'
		'frmDiceGame
		'
		Me.AcceptButton = Me.btnRoll
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(282, 229)
		Me.Controls.Add(Me.btnRoll)
		Me.Controls.Add(Me.picCard2)
		Me.Controls.Add(Me.picCard)
		Me.Controls.Add(Me.lblPoints)
		Me.Controls.Add(Me.txtRisk)
		Me.Controls.Add(Me.lblRisk)
		Me.Name = "frmDiceGame"
		Me.Text = "Dice Game"
		CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblRisk As Label
	Friend WithEvents txtRisk As TextBox
	Friend WithEvents lblPoints As Label
	Friend WithEvents picCard As PictureBox
	Friend WithEvents picCard2 As PictureBox
	Friend WithEvents btnRoll As Button
End Class
