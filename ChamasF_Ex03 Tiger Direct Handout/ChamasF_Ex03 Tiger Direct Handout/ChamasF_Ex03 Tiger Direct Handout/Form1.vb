Public Class frmTigerDirect
	Private total As Decimal
	Private gateway As String = "Gateway 7326GZ Notebook PC"
	Private toshiba As String = "Toshiba Tecra A3 Notebook PC"
	Private emachines As String = "eMachines M809 Notebook PC"
	Private acar As String = "Acer Ferrari 4005WLMi Notebook PC"
	Private acir As String = "Acer AS3613CI/CM Notebook PC"
	Private acwm As String = "Acer AS3613WLMI Notebook PC"
	Private acIntel As String = "Acer Intel Celeron M 1.4GHz Notebook PC"
	Private systemax1 As String = "Systemax™ Pursuit 4110 Notebook PC"
	Private systemax2 As String = "Systemax Pursuit 4025 Notebook PC"
	Private thinkpad As String = "Thinkpad R51 Notebook PC"
	Private gatewayPrice As Decimal = 1079.97
	Private toshibaPrice As Decimal = 1419.99
	Private emachinesPrice As Decimal = 1214.99
	Private acarPrice As Decimal = 2378.99
	Private acirPrice As Decimal = 784.99
	Private acwmPrice As Decimal = 899.99
	Private acIntelPrice As Decimal = 719.99
	Private systemax1Price As Decimal = 1862.99
	Private systemax2Price As Decimal = 1079.99
	Private thinkpadPrice As Decimal = 1298.99
	Private Sub frmTigerDirect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lblNumber.Text = vsbNumber.Value
		lstComputers.Items.Add(gateway)
		lstComputers.Items.Add(acar)
		lstComputers.Items.Add(acir)
		lstComputers.Items.Add(acwm)
		lstComputers.Items.Add(toshiba)
		lstComputers.Items.Add(acIntel)
		lstComputers.Items.Add(emachines)
		lstComputers.Items.Add(systemax1)
		lstComputers.Items.Add(systemax2)
		lstComputers.Items.Add(thinkpad)
	End Sub
	Private Sub lstComputers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstComputers.SelectedIndexChanged
		If lstComputers.SelectedIndex = 0 Then
			pbComputer.Image = My.Resources.gateway
		End If
		If lstComputers.SelectedIndex = 1 Then
			pbComputer.Image = My.Resources.acer01
		End If
		If lstComputers.SelectedIndex = 2 Then
			pbComputer.Image = My.Resources.acer02
		End If
		If lstComputers.SelectedIndex = 3 Then
			pbComputer.Image = My.Resources.acer03
		End If
		If lstComputers.SelectedIndex = 4 Then
			pbComputer.Image = My.Resources.toshiba
		End If
		If lstComputers.SelectedIndex = 5 Then
			pbComputer.Image = My.Resources.acer04
		End If
		If lstComputers.SelectedIndex = 6 Then
			pbComputer.Image = My.Resources.emachines01
		End If
		If lstComputers.SelectedIndex = 7 Then
			pbComputer.Image = My.Resources.systemax01
		End If
		If lstComputers.SelectedIndex = 8 Then
			pbComputer.Image = My.Resources.systemax02
		End If
		If lstComputers.SelectedIndex = 9 Then
			pbComputer.Image = My.Resources.thinkpad
		End If
	End Sub
	Private Sub vsNumber_Scroll(sender As Object, e As ScrollEventArgs) Handles vsbNumber.Scroll
		lblNumber.Text = vsbNumber.Value
	End Sub
	Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
		Dim exitloop As Integer
		Do
			If lblNumber.Text = "0" Then
				MessageBox.Show("Cannot buy 0 computers, please select 1.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
				Exit Do
			End If
			If lstComputers.SelectedItem = Nothing Then
				MessageBox.Show("You must first select an item!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			ElseIf lstComputers.SelectedItem = gateway Then
				lstBuying.Items.Add(lblNumber.Text & " x " & gateway & " = " & lblNumber.Text * gatewayPrice)
				total += lblNumber.Text * gatewayPrice
			ElseIf lstComputers.SelectedItem = acar Then
				lstBuying.Items.Add(lblNumber.Text & " x " & acar & " = " & lblNumber.Text * acarPrice)
				total += lblNumber.Text * acarPrice
			ElseIf lstComputers.SelectedItem = acir Then
				lstBuying.Items.Add(lblNumber.Text & " x " & acir & " = " & lblNumber.Text * acirPrice)
				total += lblNumber.Text * acirPrice
			ElseIf lstComputers.SelectedItem = acwm Then
				lstBuying.Items.Add(lblNumber.Text & " x " & acwm & " = " & lblNumber.Text * acwmPrice)
				total += lblNumber.Text * acwmPrice
			ElseIf lstComputers.SelectedItem = toshiba Then
				lstBuying.Items.Add(lblNumber.Text & " x " & toshiba & " = " & lblNumber.Text * toshibaPrice)
				total += lblNumber.Text * toshibaPrice
			ElseIf lstComputers.SelectedItem = acIntel Then
				lstBuying.Items.Add(lblNumber.Text & " x " & acIntel & " = " & lblNumber.Text * acIntelPrice)
				total += lblNumber.Text * acIntelPrice
			ElseIf lstComputers.SelectedItem = emachines Then
				lstBuying.Items.Add(lblNumber.Text & " x " & emachines & " = " & lblNumber.Text * emachinesPrice)
				total += lblNumber.Text * emachinesPrice
			ElseIf lstComputers.SelectedItem = systemax1 Then
				lstBuying.Items.Add(lblNumber.Text & " x " & systemax1 & " = " & lblNumber.Text * systemax1Price)
				total += lblNumber.Text * systemax1Price
			ElseIf lstComputers.SelectedItem = systemax2 Then
				lstBuying.Items.Add(lblNumber.Text & " x " & systemax2 & " = " & lblNumber.Text * systemax2Price)
				total += lblNumber.Text * systemax2Price
			ElseIf lstComputers.SelectedItem = thinkpad Then
				lstBuying.Items.Add(lblNumber.Text & " x " & thinkpad & " = " & lblNumber.Text * thinkpadPrice)
				total += lblNumber.Text * thinkpadPrice
			End If
		Loop Until exitloop = 0
	End Sub
	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		lstBuying.Items.Clear()
		pbComputer.Image = Nothing
		vsbNumber.Value = 0
		lblTotal.Text = ""
		lblNumber.Text = "0"
		total = 0
	End Sub
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
	Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
		lblTotal.Text = "Total price is: $" & total
	End Sub
End Class
