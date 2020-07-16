<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTigerDirect
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
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.btnTotal = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.lstComputers = New System.Windows.Forms.ListBox()
		Me.vsbNumber = New System.Windows.Forms.VScrollBar()
		Me.lstBuying = New System.Windows.Forms.ListBox()
		Me.btnPrice = New System.Windows.Forms.Button()
		Me.lblNumber = New System.Windows.Forms.Label()
		Me.pbComputer = New System.Windows.Forms.PictureBox()
		Me.lblTotal = New System.Windows.Forms.Label()
		CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblTitle
		'
		Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.lblTitle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Location = New System.Drawing.Point(34, 9)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(592, 34)
		Me.lblTitle.TabIndex = 0
		Me.lblTitle.Text = "Welcome to Tiger Direct.ca"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnTotal
		'
		Me.btnTotal.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnTotal.Location = New System.Drawing.Point(563, 331)
		Me.btnTotal.Name = "btnTotal"
		Me.btnTotal.Size = New System.Drawing.Size(111, 48)
		Me.btnTotal.TabIndex = 3
		Me.btnTotal.Text = "Calculate Total"
		Me.btnTotal.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.Location = New System.Drawing.Point(563, 385)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(111, 48)
		Me.btnClear.TabIndex = 5
		Me.btnClear.Text = "Clear All"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnExit.Location = New System.Drawing.Point(563, 439)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(111, 48)
		Me.btnExit.TabIndex = 6
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'lstComputers
		'
		Me.lstComputers.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstComputers.FormattingEnabled = True
		Me.lstComputers.ItemHeight = 25
		Me.lstComputers.Location = New System.Drawing.Point(12, 71)
		Me.lstComputers.Name = "lstComputers"
		Me.lstComputers.Size = New System.Drawing.Size(507, 254)
		Me.lstComputers.TabIndex = 7
		'
		'vsbNumber
		'
		Me.vsbNumber.LargeChange = 1
		Me.vsbNumber.Location = New System.Drawing.Point(530, 71)
		Me.vsbNumber.Name = "vsbNumber"
		Me.vsbNumber.Size = New System.Drawing.Size(14, 499)
		Me.vsbNumber.TabIndex = 10
		'
		'lstBuying
		'
		Me.lstBuying.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstBuying.FormattingEnabled = True
		Me.lstBuying.ItemHeight = 18
		Me.lstBuying.Location = New System.Drawing.Point(12, 331)
		Me.lstBuying.Name = "lstBuying"
		Me.lstBuying.Size = New System.Drawing.Size(507, 220)
		Me.lstBuying.TabIndex = 11
		'
		'btnPrice
		'
		Me.btnPrice.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnPrice.Location = New System.Drawing.Point(563, 277)
		Me.btnPrice.Name = "btnPrice"
		Me.btnPrice.Size = New System.Drawing.Size(111, 48)
		Me.btnPrice.TabIndex = 2
		Me.btnPrice.Text = "Calculate Price"
		Me.btnPrice.UseVisualStyleBackColor = True
		'
		'lblNumber
		'
		Me.lblNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.lblNumber.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNumber.Location = New System.Drawing.Point(560, 71)
		Me.lblNumber.Name = "lblNumber"
		Me.lblNumber.Size = New System.Drawing.Size(43, 30)
		Me.lblNumber.TabIndex = 12
		Me.lblNumber.Text = "1"
		Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'pbComputer
		'
		Me.pbComputer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.pbComputer.Location = New System.Drawing.Point(574, 104)
		Me.pbComputer.Name = "pbComputer"
		Me.pbComputer.Size = New System.Drawing.Size(85, 85)
		Me.pbComputer.TabIndex = 13
		Me.pbComputer.TabStop = False
		'
		'lblTotal
		'
		Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
		Me.lblTotal.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTotal.Location = New System.Drawing.Point(12, 563)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(507, 57)
		Me.lblTotal.TabIndex = 14
		'
		'frmTigerDirect
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Black
		Me.ClientSize = New System.Drawing.Size(745, 629)
		Me.Controls.Add(Me.lblTotal)
		Me.Controls.Add(Me.pbComputer)
		Me.Controls.Add(Me.lblNumber)
		Me.Controls.Add(Me.lstBuying)
		Me.Controls.Add(Me.vsbNumber)
		Me.Controls.Add(Me.lstComputers)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnTotal)
		Me.Controls.Add(Me.btnPrice)
		Me.Controls.Add(Me.lblTitle)
		Me.Name = "frmTigerDirect"
		Me.Text = "Form1"
		CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents lblTitle As Label
	Friend WithEvents btnTotal As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents lstComputers As ListBox
	Friend WithEvents vsbNumber As VScrollBar
	Friend WithEvents lstBuying As ListBox
	Friend WithEvents btnPrice As Button
	Friend WithEvents lblNumber As Label
	Friend WithEvents pbComputer As PictureBox
	Friend WithEvents lblTotal As Label
End Class
