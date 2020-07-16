Public Class frmTaxOnSalary
	Private iSalary As Integer
	Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
		If Not IsNumeric(txtSalary.Text) Then
			MessageBox.Show("Salaries only come in numbers, please enter a numeric value!", "ERROR - Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If
		iSalary = txtSalary.Text
		FindTax(iSalary)
	End Sub
	Private Function FindTax(salary As Decimal) As Decimal
		If salary < 0 Then
			MessageBox.Show("Salary not in range of 0 - 100,000, please choose a higher salary.", "ERROR - Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Function
		ElseIf salary < 15000 Then
			salary = salary * 0.15
		ElseIf salary < 30000 Then
			salary = (((salary - 15000) * 0.16) + 225)
		ElseIf salary < 50000 Then
			salary = (((salary - 30000) * 0.18) + 465)
		ElseIf salary < 100000 Then
			salary = (((salary - 50000) * 0.2) + 825)
		Else
			MessageBox.Show("Salary not in range of 0 - 100,000, please choose a lower salary.", "ERROR - Invalid Salary", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Function
		End If
		lstTax.Items.Clear()
		lstTax.Items.Add("The tax on salary of " & iSalary & " is " & salary)
		Return salary
	End Function
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Application.Exit()
	End Sub
End Class
