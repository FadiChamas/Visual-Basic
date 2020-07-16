'**************************************************************
' PROGRAMME	: ASSN02 Brandi's Bagel House
'  
' OUTLINE : This programme forces the user to select one 					
'			from 2 bagels, and 1 from 4 selections of
' 			coffee. The user has an option to choose from
'			1 of 5 toppings. The programme then takes these
'			selections, and calculates the price before tax,
'			the tax itself, and the total price including tax.
' 
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	April 11th, 2019
' **************************************************************
Public Class frmBagelHouse
    Private Sub btnCalculate_Cick(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim subtotal As Decimal = BagelCost(subtotal) + ToppingCost(subtotal) + CoffeeCost(subtotal)
        Dim tax As Decimal = CalcTax(subtotal)
        Dim total As Decimal = subtotal + tax
        If radWhite.Checked = False And radWheat.Checked = False Then
            MessageBox.Show("Please select a Bagel!", "ERROR: Bagel Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf radNone.Checked = False And radRegular.Checked = False And radCapuccino.Checked = False And radCafe.Checked = False Then
            MessageBox.Show("Please select a Coffee!", "ERROR: Coffee Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            lblSubtotalAmount.Text = FormatCurrency(subtotal)
            lblTaxAmount.Text = FormatCurrency(tax)
            lblTotalAmount.Text = FormatCurrency(total)
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetBagels()
        ResetToppings()
        ResetCoffee()
        ResetPrice()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub ResetBagels() 'Resets the bagel type RadioButtons to their initial values
        radWhite.Checked = False
        radWheat.Checked = False
    End Sub
    Private Sub ResetToppings() 'Resets the toppings CheckBoxes to their initial values
        chkCreamCheese.Checked = False
        chkButter.Checked = False
        chkBlueberry.Checked = False
        chkRaspberry.Checked = False
        chkPeach.Checked = False
    End Sub
    Private Sub ResetCoffee() 'Resets the coffee RadioButtons to their initial values
        radNone.Checked = False
        radRegular.Checked = False
        radCapuccino.Checked = False
        radCafe.Checked = False
    End Sub
    Private Sub ResetPrice() 'Sets the 3 labels for Subtotal, Tax and Total to nothing.
        lblSubtotalAmount.Text = ""
        lblTaxAmount.Text = ""
        lblTotalAmount.Text = ""
    End Sub
    Private Function BagelCost(amount As Decimal) As Decimal 'Returns the price of the selected bagel.
        If radWhite.Checked Then
            amount += 1.25
        ElseIf radWheat.Checked Then
            amount += 1.5
        End If
        Return amount
    End Function
    Private Function ToppingCost(amount As Decimal) As Decimal 'Returns the total price of the selected toppings.
        If chkCreamCheese.Checked Then
            amount += 0.5
        End If
        If chkButter.Checked Then
            amount += 0.25
        End If
        If chkBlueberry.Checked Then
            amount += 0.75
        End If
        If chkRaspberry.Checked Then
            amount += 0.75
        End If
        If chkPeach.Checked Then
            amount += 0.75
        End If
        Return amount
    End Function
    Private Function CoffeeCost(amount As Decimal) As Decimal 'Returns the price of the selected coffee
        If radNone.Checked Then
            amount += 0
        ElseIf radRegular.Checked Then
            amount += 1.25
        ElseIf radCapuccino.Checked Then
            amount += 2
        ElseIf radCafe.Checked Then
            amount += 1.75
        End If
        Return amount
    End Function
    Private Function CalcTax(amount As Decimal) As Decimal 'Returns the amount of sales tax on amount, which is the amount of a sale.
        Const taxRate As Decimal = 0.13
        amount = taxRate * amount
        Return amount
    End Function
End Class
