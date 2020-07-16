<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelect
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFilm = New System.Windows.Forms.Label()
        Me.lstFilms = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(9, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(108, 23)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Your Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilm
        '
        Me.lblFilm.AllowDrop = True
        Me.lblFilm.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFilm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm.Location = New System.Drawing.Point(12, 73)
        Me.lblFilm.Name = "lblFilm"
        Me.lblFilm.Size = New System.Drawing.Size(232, 40)
        Me.lblFilm.TabIndex = 1
        Me.lblFilm.Text = "Film:"
        Me.lblFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstFilms
        '
        Me.lstFilms.Enabled = False
        Me.lstFilms.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFilms.FormattingEnabled = True
        Me.lstFilms.ItemHeight = 16
        Me.lstFilms.Location = New System.Drawing.Point(12, 116)
        Me.lstFilms.Name = "lstFilms"
        Me.lstFilms.Size = New System.Drawing.Size(232, 164)
        Me.lstFilms.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(123, 24)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(121, 23)
        Me.txtName.TabIndex = 3
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnContinue.Enabled = False
        Me.btnContinue.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(12, 286)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(232, 33)
        Me.btnContinue.TabIndex = 4
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'frmSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(250, 322)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstFilms)
        Me.Controls.Add(Me.lblFilm)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmSelect"
        Me.Text = "Star Cinema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
	Friend WithEvents lblFilm As Label
	Friend WithEvents lstFilms As ListBox
	Friend WithEvents txtName As TextBox
	Friend WithEvents btnContinue As Button
End Class
