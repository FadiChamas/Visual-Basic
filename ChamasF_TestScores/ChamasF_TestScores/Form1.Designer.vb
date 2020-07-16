<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTestScores
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
		Me.lblScore1 = New System.Windows.Forms.Label()
		Me.lblScore2 = New System.Windows.Forms.Label()
		Me.lblScore3 = New System.Windows.Forms.Label()
		Me.txtScore1 = New System.Windows.Forms.TextBox()
		Me.txtScore2 = New System.Windows.Forms.TextBox()
		Me.txtScore3 = New System.Windows.Forms.TextBox()
		Me.lblGrade = New System.Windows.Forms.Label()
		Me.lblAverage = New System.Windows.Forms.Label()
		Me.lblAverageScore = New System.Windows.Forms.Label()
		Me.lblGradeLetter = New System.Windows.Forms.Label()
		Me.btnGrade = New System.Windows.Forms.Button()
		Me.btnDrop = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'lblScore1
		'
		Me.lblScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblScore1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScore1.Location = New System.Drawing.Point(43, 20)
		Me.lblScore1.Name = "lblScore1"
		Me.lblScore1.Size = New System.Drawing.Size(143, 30)
		Me.lblScore1.TabIndex = 0
		Me.lblScore1.Text = "Enter Score 1:"
		Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblScore2
		'
		Me.lblScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblScore2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScore2.Location = New System.Drawing.Point(43, 64)
		Me.lblScore2.Name = "lblScore2"
		Me.lblScore2.Size = New System.Drawing.Size(143, 30)
		Me.lblScore2.TabIndex = 2
		Me.lblScore2.Text = "Enter Score 2:"
		Me.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblScore3
		'
		Me.lblScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblScore3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblScore3.Location = New System.Drawing.Point(43, 106)
		Me.lblScore3.Name = "lblScore3"
		Me.lblScore3.Size = New System.Drawing.Size(143, 30)
		Me.lblScore3.TabIndex = 4
		Me.lblScore3.Text = "Enter Score 3:"
		Me.lblScore3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'txtScore1
		'
		Me.txtScore1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtScore1.Location = New System.Drawing.Point(192, 24)
		Me.txtScore1.Name = "txtScore1"
		Me.txtScore1.Size = New System.Drawing.Size(100, 23)
		Me.txtScore1.TabIndex = 1
		'
		'txtScore2
		'
		Me.txtScore2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtScore2.Location = New System.Drawing.Point(192, 68)
		Me.txtScore2.Name = "txtScore2"
		Me.txtScore2.Size = New System.Drawing.Size(100, 23)
		Me.txtScore2.TabIndex = 3
		'
		'txtScore3
		'
		Me.txtScore3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtScore3.Location = New System.Drawing.Point(192, 110)
		Me.txtScore3.Name = "txtScore3"
		Me.txtScore3.Size = New System.Drawing.Size(100, 23)
		Me.txtScore3.TabIndex = 5
		'
		'lblGrade
		'
		Me.lblGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblGrade.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGrade.Location = New System.Drawing.Point(43, 191)
		Me.lblGrade.Name = "lblGrade"
		Me.lblGrade.Size = New System.Drawing.Size(143, 30)
		Me.lblGrade.TabIndex = 8
		Me.lblGrade.Text = "Grade:"
		Me.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblAverage
		'
		Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblAverage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAverage.Location = New System.Drawing.Point(43, 149)
		Me.lblAverage.Name = "lblAverage"
		Me.lblAverage.Size = New System.Drawing.Size(143, 30)
		Me.lblAverage.TabIndex = 6
		Me.lblAverage.Text = "Average Score:"
		Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblAverageScore
		'
		Me.lblAverageScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblAverageScore.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAverageScore.Location = New System.Drawing.Point(192, 149)
		Me.lblAverageScore.Name = "lblAverageScore"
		Me.lblAverageScore.Size = New System.Drawing.Size(100, 30)
		Me.lblAverageScore.TabIndex = 7
		Me.lblAverageScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'lblGradeLetter
		'
		Me.lblGradeLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblGradeLetter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblGradeLetter.Location = New System.Drawing.Point(192, 191)
		Me.lblGradeLetter.Name = "lblGradeLetter"
		Me.lblGradeLetter.Size = New System.Drawing.Size(100, 30)
		Me.lblGradeLetter.TabIndex = 9
		Me.lblGradeLetter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnGrade
		'
		Me.btnGrade.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnGrade.Location = New System.Drawing.Point(43, 235)
		Me.btnGrade.Name = "btnGrade"
		Me.btnGrade.Size = New System.Drawing.Size(143, 37)
		Me.btnGrade.TabIndex = 10
		Me.btnGrade.Text = "Show Grade"
		Me.btnGrade.UseVisualStyleBackColor = True
		'
		'btnDrop
		'
		Me.btnDrop.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDrop.Location = New System.Drawing.Point(43, 278)
		Me.btnDrop.Name = "btnDrop"
		Me.btnDrop.Size = New System.Drawing.Size(143, 37)
		Me.btnDrop.TabIndex = 11
		Me.btnDrop.Text = "Drop Lowest"
		Me.btnDrop.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.Location = New System.Drawing.Point(192, 235)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(100, 37)
		Me.btnClear.TabIndex = 12
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(192, 278)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(100, 37)
		Me.btnExit.TabIndex = 13
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'frmTestScores
		'
		Me.AcceptButton = Me.btnGrade
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.CancelButton = Me.btnExit
		Me.ClientSize = New System.Drawing.Size(377, 349)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnDrop)
		Me.Controls.Add(Me.btnGrade)
		Me.Controls.Add(Me.lblGradeLetter)
		Me.Controls.Add(Me.lblAverageScore)
		Me.Controls.Add(Me.lblAverage)
		Me.Controls.Add(Me.lblGrade)
		Me.Controls.Add(Me.txtScore3)
		Me.Controls.Add(Me.txtScore2)
		Me.Controls.Add(Me.txtScore1)
		Me.Controls.Add(Me.lblScore3)
		Me.Controls.Add(Me.lblScore2)
		Me.Controls.Add(Me.lblScore1)
		Me.Name = "frmTestScores"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblScore1 As Label
	Friend WithEvents lblScore2 As Label
	Friend WithEvents lblScore3 As Label
	Friend WithEvents txtScore1 As TextBox
	Friend WithEvents txtScore2 As TextBox
	Friend WithEvents txtScore3 As TextBox
	Friend WithEvents lblGrade As Label
	Friend WithEvents lblAverage As Label
	Friend WithEvents lblAverageScore As Label
	Friend WithEvents lblGradeLetter As Label
	Friend WithEvents btnGrade As Button
	Friend WithEvents btnDrop As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnExit As Button
End Class
