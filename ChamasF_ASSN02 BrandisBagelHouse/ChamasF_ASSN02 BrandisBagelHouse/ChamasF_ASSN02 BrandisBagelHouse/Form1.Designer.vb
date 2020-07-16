<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBagelHouse
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpBagel = New System.Windows.Forms.GroupBox()
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.grpCoffee = New System.Windows.Forms.GroupBox()
        Me.radCafe = New System.Windows.Forms.RadioButton()
        Me.radCapuccino = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.grpPrice = New System.Windows.Forms.GroupBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTaxAmount = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotalAmount = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpBagel.SuspendLayout()
        Me.grpCoffee.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.grpPrice.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.AutoSize = True
        Me.btnCalculate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(12, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(86, 26)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(207, 319)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(86, 26)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(407, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 26)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpBagel
        '
        Me.grpBagel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpBagel.Controls.Add(Me.radWheat)
        Me.grpBagel.Controls.Add(Me.radWhite)
        Me.grpBagel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBagel.Location = New System.Drawing.Point(12, 59)
        Me.grpBagel.Name = "grpBagel"
        Me.grpBagel.Size = New System.Drawing.Size(196, 80)
        Me.grpBagel.TabIndex = 3
        Me.grpBagel.TabStop = False
        Me.grpBagel.Text = "Pick a Bagel"
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(18, 48)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(181, 20)
        Me.radWheat.TabIndex = 1
        Me.radWheat.TabStop = True
        Me.radWheat.Text = "Whole Wheat ($1.50)"
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Location = New System.Drawing.Point(18, 22)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(127, 20)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White ($1.25)"
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'grpCoffee
        '
        Me.grpCoffee.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpCoffee.Controls.Add(Me.radCafe)
        Me.grpCoffee.Controls.Add(Me.radCapuccino)
        Me.grpCoffee.Controls.Add(Me.radRegular)
        Me.grpCoffee.Controls.Add(Me.radNone)
        Me.grpCoffee.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCoffee.Location = New System.Drawing.Point(258, 59)
        Me.grpCoffee.Name = "grpCoffee"
        Me.grpCoffee.Size = New System.Drawing.Size(241, 134)
        Me.grpCoffee.TabIndex = 4
        Me.grpCoffee.TabStop = False
        Me.grpCoffee.Text = "Do you want Coffee with that?"
        '
        'radCafe
        '
        Me.radCafe.AutoSize = True
        Me.radCafe.Location = New System.Drawing.Point(9, 100)
        Me.radCafe.Name = "radCafe"
        Me.radCafe.Size = New System.Drawing.Size(171, 20)
        Me.radCafe.TabIndex = 4
        Me.radCafe.TabStop = True
        Me.radCafe.Text = "Café au Lait ($1.75)"
        Me.radCafe.UseVisualStyleBackColor = True
        '
        'radCapuccino
        '
        Me.radCapuccino.AutoSize = True
        Me.radCapuccino.Location = New System.Drawing.Point(9, 74)
        Me.radCapuccino.Name = "radCapuccino"
        Me.radCapuccino.Size = New System.Drawing.Size(160, 20)
        Me.radCapuccino.TabIndex = 3
        Me.radCapuccino.TabStop = True
        Me.radCapuccino.Text = "Capuccino ($2.00)"
        Me.radCapuccino.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(9, 48)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(191, 20)
        Me.radRegular.TabIndex = 2
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular Coffee ($1.25)"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(9, 22)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(63, 20)
        Me.radNone.TabIndex = 1
        Me.radNone.TabStop = True
        Me.radNone.Text = "None"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpToppings.Controls.Add(Me.chkPeach)
        Me.grpToppings.Controls.Add(Me.chkRaspberry)
        Me.grpToppings.Controls.Add(Me.chkBlueberry)
        Me.grpToppings.Controls.Add(Me.chkButter)
        Me.grpToppings.Controls.Add(Me.chkCreamCheese)
        Me.grpToppings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpToppings.Location = New System.Drawing.Point(16, 145)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(196, 168)
        Me.grpToppings.TabIndex = 4
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Pick your Toppings:"
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(6, 132)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(167, 20)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Peach Jelly ($0.75)"
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(6, 106)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(194, 20)
        Me.chkRaspberry.TabIndex = 3
        Me.chkRaspberry.Text = "Raspberry Jam ($0.75)"
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(6, 80)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(191, 20)
        Me.chkBlueberry.TabIndex = 2
        Me.chkBlueberry.Text = "Blueberry Jam ($0.75)"
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(6, 54)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(132, 20)
        Me.chkButter.TabIndex = 1
        Me.chkButter.Text = "Butter ($0.25)"
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(6, 28)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(192, 20)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese ($0.50)"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'grpPrice
        '
        Me.grpPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpPrice.Controls.Add(Me.lblTotalAmount)
        Me.grpPrice.Controls.Add(Me.lblTotal)
        Me.grpPrice.Controls.Add(Me.lblTaxAmount)
        Me.grpPrice.Controls.Add(Me.lblTax)
        Me.grpPrice.Controls.Add(Me.lblSubtotalAmount)
        Me.grpPrice.Controls.Add(Me.lblSubtotal)
        Me.grpPrice.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPrice.Location = New System.Drawing.Point(258, 199)
        Me.grpPrice.Name = "grpPrice"
        Me.grpPrice.Size = New System.Drawing.Size(241, 114)
        Me.grpPrice.TabIndex = 5
        Me.grpPrice.TabStop = False
        Me.grpPrice.Text = "Price"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.White
        Me.lblTotalAmount.Location = New System.Drawing.Point(113, 85)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(105, 16)
        Me.lblTotalAmount.TabIndex = 5
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(34, 85)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 16)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total:"
        '
        'lblTaxAmount
        '
        Me.lblTaxAmount.BackColor = System.Drawing.Color.White
        Me.lblTaxAmount.Location = New System.Drawing.Point(113, 53)
        Me.lblTaxAmount.Name = "lblTaxAmount"
        Me.lblTaxAmount.Size = New System.Drawing.Size(105, 16)
        Me.lblTaxAmount.TabIndex = 3
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(34, 53)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(39, 16)
        Me.lblTax.TabIndex = 2
        Me.lblTax.Text = "Tax:"
        '
        'lblSubtotalAmount
        '
        Me.lblSubtotalAmount.BackColor = System.Drawing.Color.White
        Me.lblSubtotalAmount.Location = New System.Drawing.Point(113, 19)
        Me.lblSubtotalAmount.Name = "lblSubtotalAmount"
        Me.lblSubtotalAmount.Size = New System.Drawing.Size(105, 16)
        Me.lblSubtotalAmount.TabIndex = 1
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(34, 19)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(74, 16)
        Me.lblSubtotal.TabIndex = 0
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(121, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(337, 32)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Brandi's Bagel House"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ChamasF_ASSN02_BrandisBagelHouse.My.Resources.Resources.houseofbagel
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmBagelHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 351)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpPrice)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpCoffee)
        Me.Controls.Add(Me.grpBagel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmBagelHouse"
        Me.Text = "ASSN02 Brandi's Bagel House"
        Me.grpBagel.ResumeLayout(False)
        Me.grpBagel.PerformLayout()
        Me.grpCoffee.ResumeLayout(False)
        Me.grpCoffee.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.grpPrice.ResumeLayout(False)
        Me.grpPrice.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents grpBagel As GroupBox
	Friend WithEvents radWheat As RadioButton
	Friend WithEvents radWhite As RadioButton
	Friend WithEvents grpCoffee As GroupBox
	Friend WithEvents radCafe As RadioButton
	Friend WithEvents radCapuccino As RadioButton
	Friend WithEvents radRegular As RadioButton
	Friend WithEvents radNone As RadioButton
	Friend WithEvents grpToppings As GroupBox
	Friend WithEvents grpPrice As GroupBox
	Friend WithEvents chkPeach As CheckBox
	Friend WithEvents chkRaspberry As CheckBox
	Friend WithEvents chkBlueberry As CheckBox
	Friend WithEvents chkButter As CheckBox
	Friend WithEvents chkCreamCheese As CheckBox
	Friend WithEvents lblTotalAmount As Label
	Friend WithEvents lblTotal As Label
	Friend WithEvents lblTaxAmount As Label
	Friend WithEvents lblTax As Label
	Friend WithEvents lblSubtotalAmount As Label
	Friend WithEvents lblSubtotal As Label
	Friend WithEvents lblTitle As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
