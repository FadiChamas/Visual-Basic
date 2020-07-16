<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmColourMatch
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.txtColour = New System.Windows.Forms.TextBox()
		Me.lblDisplay = New System.Windows.Forms.Label()
		Me.lblItemsLeft = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblAqua = New System.Windows.Forms.Label()
		Me.lblYellow = New System.Windows.Forms.Label()
		Me.lblGreen = New System.Windows.Forms.Label()
		Me.lblBlue = New System.Windows.Forms.Label()
		Me.lblFuschia = New System.Windows.Forms.Label()
		Me.lblBlack = New System.Windows.Forms.Label()
		Me.tmrRound1 = New System.Windows.Forms.Timer(Me.components)
		Me.lblRound = New System.Windows.Forms.Label()
		Me.lblScore = New System.Windows.Forms.Label()
		Me.lblTime = New System.Windows.Forms.Label()
		Me.lblTimeLeft = New System.Windows.Forms.Label()
		Me.lblScoreNum = New System.Windows.Forms.Label()
		Me.lblItems = New System.Windows.Forms.Label()
		Me.pbGif = New System.Windows.Forms.PictureBox()
		Me.pbBlack = New System.Windows.Forms.PictureBox()
		Me.pbMagenta = New System.Windows.Forms.PictureBox()
		Me.pbBlue = New System.Windows.Forms.PictureBox()
		Me.pbCyan = New System.Windows.Forms.PictureBox()
		Me.pbGreen = New System.Windows.Forms.PictureBox()
		Me.pbYellow = New System.Windows.Forms.PictureBox()
		Me.pbOrange = New System.Windows.Forms.PictureBox()
		Me.pbRed = New System.Windows.Forms.PictureBox()
		CType(Me.pbGif, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbMagenta, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbCyan, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbOrange, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txtColour
		'
		Me.txtColour.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtColour.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtColour.Location = New System.Drawing.Point(140, 68)
		Me.txtColour.Name = "txtColour"
		Me.txtColour.Size = New System.Drawing.Size(148, 23)
		Me.txtColour.TabIndex = 0
		'
		'lblDisplay
		'
		Me.lblDisplay.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDisplay.Location = New System.Drawing.Point(137, 9)
		Me.lblDisplay.Name = "lblDisplay"
		Me.lblDisplay.Size = New System.Drawing.Size(151, 53)
		Me.lblDisplay.TabIndex = 1
		Me.lblDisplay.Text = "Colour"
		Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblItemsLeft
		'
		Me.lblItemsLeft.AutoSize = True
		Me.lblItemsLeft.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItemsLeft.Location = New System.Drawing.Point(8, 85)
		Me.lblItemsLeft.Name = "lblItemsLeft"
		Me.lblItemsLeft.Size = New System.Drawing.Size(98, 16)
		Me.lblItemsLeft.TabIndex = 10
		Me.lblItemsLeft.Text = "Items Left ="
		Me.lblItemsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(354, 30)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(35, 16)
		Me.Label2.TabIndex = 11
		Me.Label2.Text = "Red"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(354, 85)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(61, 16)
		Me.Label3.TabIndex = 12
		Me.Label3.Text = "Orange"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblAqua
		'
		Me.lblAqua.AutoSize = True
		Me.lblAqua.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAqua.Location = New System.Drawing.Point(557, 30)
		Me.lblAqua.Name = "lblAqua"
		Me.lblAqua.Size = New System.Drawing.Size(98, 16)
		Me.lblAqua.TabIndex = 14
		Me.lblAqua.Text = "Aqua Marine"
		Me.lblAqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblYellow
		'
		Me.lblYellow.AutoSize = True
		Me.lblYellow.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblYellow.Location = New System.Drawing.Point(354, 138)
		Me.lblYellow.Name = "lblYellow"
		Me.lblYellow.Size = New System.Drawing.Size(56, 16)
		Me.lblYellow.TabIndex = 15
		Me.lblYellow.Text = "Yellow"
		Me.lblYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGreen
		'
		Me.lblGreen.AutoSize = True
		Me.lblGreen.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGreen.Location = New System.Drawing.Point(354, 199)
		Me.lblGreen.Name = "lblGreen"
		Me.lblGreen.Size = New System.Drawing.Size(51, 16)
		Me.lblGreen.TabIndex = 16
		Me.lblGreen.Text = "Green"
		Me.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblBlue
		'
		Me.lblBlue.AutoSize = True
		Me.lblBlue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBlue.Location = New System.Drawing.Point(557, 89)
		Me.lblBlue.Name = "lblBlue"
		Me.lblBlue.Size = New System.Drawing.Size(40, 16)
		Me.lblBlue.TabIndex = 17
		Me.lblBlue.Text = "Blue"
		Me.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblFuschia
		'
		Me.lblFuschia.AutoSize = True
		Me.lblFuschia.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFuschia.Location = New System.Drawing.Point(557, 138)
		Me.lblFuschia.Name = "lblFuschia"
		Me.lblFuschia.Size = New System.Drawing.Size(64, 16)
		Me.lblFuschia.TabIndex = 18
		Me.lblFuschia.Text = "Fuschia"
		Me.lblFuschia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblBlack
		'
		Me.lblBlack.AutoSize = True
		Me.lblBlack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblBlack.Location = New System.Drawing.Point(557, 199)
		Me.lblBlack.Name = "lblBlack"
		Me.lblBlack.Size = New System.Drawing.Size(47, 16)
		Me.lblBlack.TabIndex = 19
		Me.lblBlack.Text = "Black"
		Me.lblBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'tmrRound1
		'
		Me.tmrRound1.Interval = 1000
		'
		'lblRound
		'
		Me.lblRound.AutoSize = True
		Me.lblRound.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblRound.Location = New System.Drawing.Point(12, 30)
		Me.lblRound.Name = "lblRound"
		Me.lblRound.Size = New System.Drawing.Size(71, 16)
		Me.lblRound.TabIndex = 20
		Me.lblRound.Text = "Round: 1"
		Me.lblRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScore
		'
		Me.lblScore.AutoSize = True
		Me.lblScore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScore.Location = New System.Drawing.Point(8, 138)
		Me.lblScore.Name = "lblScore"
		Me.lblScore.Size = New System.Drawing.Size(102, 16)
		Me.lblScore.TabIndex = 21
		Me.lblScore.Text = "Your Score ="
		Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblTime
		'
		Me.lblTime.AutoSize = True
		Me.lblTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTime.Location = New System.Drawing.Point(112, 199)
		Me.lblTime.Name = "lblTime"
		Me.lblTime.Size = New System.Drawing.Size(17, 16)
		Me.lblTime.TabIndex = 22
		Me.lblTime.Text = "8"
		Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblTimeLeft
		'
		Me.lblTimeLeft.AutoSize = True
		Me.lblTimeLeft.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTimeLeft.Location = New System.Drawing.Point(8, 199)
		Me.lblTimeLeft.Name = "lblTimeLeft"
		Me.lblTimeLeft.Size = New System.Drawing.Size(90, 16)
		Me.lblTimeLeft.TabIndex = 23
		Me.lblTimeLeft.Text = "Time Left ="
		Me.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblScoreNum
		'
		Me.lblScoreNum.AutoSize = True
		Me.lblScoreNum.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScoreNum.Location = New System.Drawing.Point(112, 138)
		Me.lblScoreNum.Name = "lblScoreNum"
		Me.lblScoreNum.Size = New System.Drawing.Size(17, 16)
		Me.lblScoreNum.TabIndex = 25
		Me.lblScoreNum.Text = "0"
		'
		'lblItems
		'
		Me.lblItems.AutoSize = True
		Me.lblItems.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblItems.Location = New System.Drawing.Point(108, 85)
		Me.lblItems.Name = "lblItems"
		Me.lblItems.Size = New System.Drawing.Size(26, 16)
		Me.lblItems.TabIndex = 26
		Me.lblItems.Text = "10"
		Me.lblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'pbGif
		'
		Me.pbGif.Image = Global.ChamasF_ASSN01_ColourMatch.My.Resources.Resources.slowgif
		Me.pbGif.Location = New System.Drawing.Point(144, 104)
		Me.pbGif.Name = "pbGif"
		Me.pbGif.Size = New System.Drawing.Size(144, 126)
		Me.pbGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.pbGif.TabIndex = 27
		Me.pbGif.TabStop = False
		'
		'pbBlack
		'
		Me.pbBlack.BackColor = System.Drawing.Color.Black
		Me.pbBlack.Location = New System.Drawing.Point(497, 180)
		Me.pbBlack.Name = "pbBlack"
		Me.pbBlack.Size = New System.Drawing.Size(54, 50)
		Me.pbBlack.TabIndex = 9
		Me.pbBlack.TabStop = False
		'
		'pbMagenta
		'
		Me.pbMagenta.BackColor = System.Drawing.Color.Magenta
		Me.pbMagenta.Location = New System.Drawing.Point(497, 124)
		Me.pbMagenta.Name = "pbMagenta"
		Me.pbMagenta.Size = New System.Drawing.Size(54, 50)
		Me.pbMagenta.TabIndex = 8
		Me.pbMagenta.TabStop = False
		'
		'pbBlue
		'
		Me.pbBlue.BackColor = System.Drawing.Color.Blue
		Me.pbBlue.Location = New System.Drawing.Point(497, 68)
		Me.pbBlue.Name = "pbBlue"
		Me.pbBlue.Size = New System.Drawing.Size(54, 50)
		Me.pbBlue.TabIndex = 7
		Me.pbBlue.TabStop = False
		'
		'pbCyan
		'
		Me.pbCyan.BackColor = System.Drawing.Color.Cyan
		Me.pbCyan.Location = New System.Drawing.Point(497, 12)
		Me.pbCyan.Name = "pbCyan"
		Me.pbCyan.Size = New System.Drawing.Size(54, 50)
		Me.pbCyan.TabIndex = 6
		Me.pbCyan.TabStop = False
		'
		'pbGreen
		'
		Me.pbGreen.BackColor = System.Drawing.Color.Green
		Me.pbGreen.Location = New System.Drawing.Point(294, 180)
		Me.pbGreen.Name = "pbGreen"
		Me.pbGreen.Size = New System.Drawing.Size(54, 50)
		Me.pbGreen.TabIndex = 5
		Me.pbGreen.TabStop = False
		'
		'pbYellow
		'
		Me.pbYellow.BackColor = System.Drawing.Color.Yellow
		Me.pbYellow.Location = New System.Drawing.Point(294, 124)
		Me.pbYellow.Name = "pbYellow"
		Me.pbYellow.Size = New System.Drawing.Size(54, 50)
		Me.pbYellow.TabIndex = 4
		Me.pbYellow.TabStop = False
		'
		'pbOrange
		'
		Me.pbOrange.BackColor = System.Drawing.Color.Orange
		Me.pbOrange.Location = New System.Drawing.Point(294, 68)
		Me.pbOrange.Name = "pbOrange"
		Me.pbOrange.Size = New System.Drawing.Size(54, 50)
		Me.pbOrange.TabIndex = 3
		Me.pbOrange.TabStop = False
		'
		'pbRed
		'
		Me.pbRed.BackColor = System.Drawing.Color.Red
		Me.pbRed.Location = New System.Drawing.Point(294, 12)
		Me.pbRed.Name = "pbRed"
		Me.pbRed.Size = New System.Drawing.Size(54, 50)
		Me.pbRed.TabIndex = 2
		Me.pbRed.TabStop = False
		'
		'frmColourMatch
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.WindowFrame
		Me.ClientSize = New System.Drawing.Size(662, 245)
		Me.Controls.Add(Me.pbGif)
		Me.Controls.Add(Me.lblItems)
		Me.Controls.Add(Me.lblScoreNum)
		Me.Controls.Add(Me.lblTimeLeft)
		Me.Controls.Add(Me.lblTime)
		Me.Controls.Add(Me.lblScore)
		Me.Controls.Add(Me.lblRound)
		Me.Controls.Add(Me.lblBlack)
		Me.Controls.Add(Me.lblFuschia)
		Me.Controls.Add(Me.lblBlue)
		Me.Controls.Add(Me.lblGreen)
		Me.Controls.Add(Me.lblYellow)
		Me.Controls.Add(Me.lblAqua)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.lblItemsLeft)
		Me.Controls.Add(Me.pbBlack)
		Me.Controls.Add(Me.pbMagenta)
		Me.Controls.Add(Me.pbBlue)
		Me.Controls.Add(Me.pbCyan)
		Me.Controls.Add(Me.pbGreen)
		Me.Controls.Add(Me.pbYellow)
		Me.Controls.Add(Me.pbOrange)
		Me.Controls.Add(Me.pbRed)
		Me.Controls.Add(Me.lblDisplay)
		Me.Controls.Add(Me.txtColour)
		Me.Name = "frmColourMatch"
		Me.Text = " Assignment 1: Colour Match"
		CType(Me.pbGif, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbMagenta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbCyan, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbOrange, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtColour As TextBox
	Friend WithEvents lblDisplay As Label
	Friend WithEvents pbRed As PictureBox
	Friend WithEvents pbOrange As PictureBox
	Friend WithEvents pbYellow As PictureBox
	Friend WithEvents pbGreen As PictureBox
	Friend WithEvents pbCyan As PictureBox
	Friend WithEvents pbBlue As PictureBox
	Friend WithEvents pbMagenta As PictureBox
	Friend WithEvents pbBlack As PictureBox
	Friend WithEvents lblItemsLeft As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblAqua As Label
	Friend WithEvents lblYellow As Label
	Friend WithEvents lblGreen As Label
	Friend WithEvents lblBlue As Label
	Friend WithEvents lblFuschia As Label
	Friend WithEvents lblBlack As Label
	Friend WithEvents tmrRound1 As Timer
	Friend WithEvents lblRound As Label
	Friend WithEvents lblScore As Label
	Friend WithEvents lblTime As Label
	Friend WithEvents lblTimeLeft As Label
	Friend WithEvents lblScoreNum As Label
	Friend WithEvents lblItems As Label
	Friend WithEvents pbGif As PictureBox
End Class
