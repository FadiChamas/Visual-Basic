'**************************************************************
' PROGRAMME	: Arrays Ex04 Array of Labels
'  
' OUTLINE : This programme allows the user to select a button 					
'			which generates random numbers between 1 and 9 which
'           changes the backcolour of the labels, while also
'           informing the user how many times each number is
'           generated.
'
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	April 26th, 2019
' **************************************************************
Public Class frmArrayofLabels
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim iLbl() As Label = {lblOne, lblTwo, lblThree, lblFour, lblFive, lblSix, lblSeven, lblEight, lblNine,
                               lblTen, lblEleven, lblTwelve, lblThirteen, lblFourteen, lblFifteen, lblSixteen,
                               lblSeventeen, lblEighteen, lblNineteen, lblTwenty, lblTwentyOne, lblTwentyTwo,
                               lblTwentyThree, lblTwentyFour, lblTwentyFive}
        Dim rand As New Random
        For i As Integer = 0 To iLbl.Length - 1
            iLbl(i).Text = rand.Next(1, 10)
            Select Case iLbl(i).Text
                Case 1
                    iLbl(i).BackColor = Color.Red
                Case 2
                    iLbl(i).BackColor = Color.Salmon
                Case 3
                    iLbl(i).BackColor = Color.LightGray
                Case 4
                    iLbl(i).BackColor = Color.Yellow
                Case 5
                    iLbl(i).BackColor = Color.Khaki
                Case 6
                    iLbl(i).BackColor = Color.LimeGreen
                Case 7
                    iLbl(i).BackColor = Color.Orange
                Case 8
                    iLbl(i).BackColor = Color.LightBlue
                Case 9
                    iLbl(i).BackColor = Color.LightPink
            End Select
        Next
        CountNumbers(iLbl)
    End Sub
    Private Sub CountNumbers(iLbl As Label())
        Dim times(8) As Integer
        For i As Integer = 0 To iLbl.Length - 1
            Select Case iLbl(i).Text
                Case 1
                    times(0) += 1
                Case 2
                    times(1) += 1
                Case 3
                    times(2) += 1
                Case 4
                    times(3) += 1
                Case 5
                    times(4) += 1
                Case 6
                    times(5) += 1
                Case 7
                    times(6) += 1
                Case 8
                    times(7) += 1
                Case 9
                    times(8) += 1
            End Select
        Next
        For i = 0 To times.Length - 1
            lstOut.Items.Add(i + 1 & " is repeated " & times(i) & " times.")
        Next
    End Sub
End Class
