<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTaxOnSalary
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
		Me.lblEnter = New System.Windows.Forms.Label()
		Me.txtSalary = New System.Windows.Forms.TextBox()
		Me.btnTax = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.lstTax = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'lblEnter
		'
		Me.lblEnter.AutoSize = True
		Me.lblEnter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEnter.Location = New System.Drawing.Point(12, 9)
		Me.lblEnter.Name = "lblEnter"
		Me.lblEnter.Size = New System.Drawing.Size(242, 16)
		Me.lblEnter.TabIndex = 0
		Me.lblEnter.Text = "Enter employee's annual salary:"
		'
		'txtSalary
		'
		Me.txtSalary.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSalary.Location = New System.Drawing.Point(260, 9)
		Me.txtSalary.Name = "txtSalary"
		Me.txtSalary.Size = New System.Drawing.Size(100, 23)
		Me.txtSalary.TabIndex = 1
		'
		'btnTax
		'
		Me.btnTax.AutoSize = True
		Me.btnTax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTax.Location = New System.Drawing.Point(12, 70)
		Me.btnTax.Name = "btnTax"
		Me.btnTax.Size = New System.Drawing.Size(139, 37)
		Me.btnTax.TabIndex = 2
		Me.btnTax.Text = "Find Tax"
		Me.btnTax.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.AutoSize = True
		Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(260, 70)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(139, 37)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'lstTax
		'
		Me.lstTax.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstTax.FormattingEnabled = True
		Me.lstTax.ItemHeight = 18
		Me.lstTax.Location = New System.Drawing.Point(2, 38)
		Me.lstTax.Name = "lstTax"
		Me.lstTax.Size = New System.Drawing.Size(397, 22)
		Me.lstTax.TabIndex = 4
		'
		'frmTaxOnSalary
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(414, 112)
		Me.Controls.Add(Me.lstTax)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnTax)
		Me.Controls.Add(Me.txtSalary)
		Me.Controls.Add(Me.lblEnter)
		Me.Name = "frmTaxOnSalary"
		Me.Text = "FUNC Ex01 Tax On Salary"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblEnter As Label
	Friend WithEvents txtSalary As TextBox
	Friend WithEvents btnTax As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents lstTax As ListBox
End Class
