'*******************************************************
' PROGRAMME	: ASSN01 ColourMatch
'  
' OUTLINE : This programme asks the user to wager 
'           "points" and to roll 2 die. If the total
'           value of the die is even, they will lose their
'           wager, if the total value is odd, they will
'           double it.
' 
' PROGRAMMER :	Fadi Chamas
'
'  DATE	:	March 23rd, 2019
' *****************************************************
Public Class frmDiceGame
	Private iRisk As Integer = 1000
	Private iRisk2, rand1, rand2, dice As Integer
	Private strRisk As String
	Private rand As New Random
	' procedure DicePics generates the pictures for the pictureboxes and determines the total value of the dice
	Private Sub DicePics(picture As PictureBox, number As Integer)
		Select Case number
			Case 1
				picture.Image = My.Resources.Dice_1
				dice += 1
			Case 2
				picture.Image = My.Resources.Dice_2
				dice += 2
			Case 3
				picture.Image = My.Resources.Dice_3
				dice += 3
			Case 4
				picture.Image = My.Resources.Dice_4
				dice += 4
			Case 5
				picture.Image = My.Resources.Dice_5
				dice += 5
			Case 6
				picture.Image = My.Resources.Dice_6
				dice += 6
		End Select
	End Sub
	Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
		strRisk = txtRisk.Text
		If Not IsNumeric(txtRisk.Text) Then
			MessageBox.Show("Invalid Input!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtRisk.Clear()
			txtRisk.Focus()
			Exit Sub
		End If
		iRisk2 = strRisk
		If iRisk2 <= 0 Then
			MessageBox.Show("Cannot risk this amount!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtRisk.Clear()
			txtRisk.Focus()
			Exit Sub
		ElseIf iRisk2 > iRisk Then
			MessageBox.Show("Cannot risk this amount!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtRisk.Clear()
			txtRisk.Focus()
			Exit Sub
		End If
		rand1 = rand.Next(1, 7)
		rand2 = rand.Next(1, 7)
		DicePics(picCard, rand1)
		DicePics(picCard2, rand2)
		Select Case dice
			Case 2
				iRisk -= iRisk2
			Case 3
				iRisk += iRisk2
			Case 4
				iRisk -= iRisk2
			Case 5
				iRisk += iRisk2
			Case 6
				iRisk -= iRisk2
			Case 7
				iRisk += iRisk2
			Case 8
				iRisk -= iRisk2
			Case 9
				iRisk += iRisk2
			Case 10
				iRisk -= iRisk2
			Case 11
				iRisk += iRisk2
			Case 12
				iRisk -= iRisk2
		End Select
		If iRisk = 0 Then
			MessageBox.Show("Back on the poverty line you go.", "You're broke!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Application.Exit()
		End If
		lblPoints.Text = "Total Points : " & iRisk
		dice = 0
	End Sub
End Class
