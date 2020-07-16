<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDateandTime
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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDate = New System.Windows.Forms.ListBox()
        Me.lstTime = New System.Windows.Forms.ListBox()
        Me.btnBack2 = New System.Windows.Forms.Button()
        Me.btnContinue2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AllowDrop = True
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(-1, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(122, 40)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date:"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Time"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDate
        '
        Me.lstDate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDate.FormattingEnabled = True
        Me.lstDate.ItemHeight = 16
        Me.lstDate.Location = New System.Drawing.Point(2, 52)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(119, 228)
        Me.lstDate.TabIndex = 6
        '
        'lstTime
        '
        Me.lstTime.Enabled = False
        Me.lstTime.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTime.FormattingEnabled = True
        Me.lstTime.ItemHeight = 16
        Me.lstTime.Location = New System.Drawing.Point(127, 52)
        Me.lstTime.Name = "lstTime"
        Me.lstTime.Size = New System.Drawing.Size(122, 228)
        Me.lstTime.TabIndex = 7
        '
        'btnBack2
        '
        Me.btnBack2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack2.Location = New System.Drawing.Point(2, 291)
        Me.btnBack2.Name = "btnBack2"
        Me.btnBack2.Size = New System.Drawing.Size(119, 29)
        Me.btnBack2.TabIndex = 8
        Me.btnBack2.Text = "Change"
        Me.btnBack2.UseVisualStyleBackColor = False
        '
        'btnContinue2
        '
        Me.btnContinue2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnContinue2.Enabled = False
        Me.btnContinue2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue2.Location = New System.Drawing.Point(127, 291)
        Me.btnContinue2.Name = "btnContinue2"
        Me.btnContinue2.Size = New System.Drawing.Size(122, 29)
        Me.btnContinue2.TabIndex = 9
        Me.btnContinue2.Text = "Continue"
        Me.btnContinue2.UseVisualStyleBackColor = False
        '
        'frmDateandTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(250, 322)
        Me.Controls.Add(Me.btnContinue2)
        Me.Controls.Add(Me.btnBack2)
        Me.Controls.Add(Me.lstTime)
        Me.Controls.Add(Me.lstDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "frmDateandTime"
        Me.Text = "Movie Chosen:"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblDate As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lstDate As ListBox
	Friend WithEvents lstTime As ListBox
	Friend WithEvents btnBack2 As Button
	Friend WithEvents btnContinue2 As Button
End Class
