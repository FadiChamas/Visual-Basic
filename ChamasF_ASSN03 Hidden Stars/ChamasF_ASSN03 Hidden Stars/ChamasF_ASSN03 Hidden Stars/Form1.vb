Public Class frmHiddenStars
    Private kaboom As Integer = Nothing
    Private stars As Integer = Nothing
    Private tries As Integer = Nothing
    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        Dim picArray As PictureBox() = {picOne, picTwo, picThree, picFour, picFive, picSix, picSeven, picEight, picNine, picTen, picEleven, picTwelve, picThirteen,
                                        picFourteen, picFifteen, picSixteen, picSeventeen, picEighteen, picNineteen, picTwenty, picTwentyOne, picTwentyTwo, picTwentyThree,
                                        picTwentyFour, picTwentyFive}
        Static instructions As Integer = Nothing
        stars = 0
        tries = 0
        kaboom = 0
        For i = 0 To picArray.Length - 1
            picArray(i).Enabled = True
            picArray(i).Image = Nothing
            picArray(i).BackColor = Color.White
        Next
        If instructions = 0 Then
            instructions = 1
            MessageBox.Show("There are 5 hidden stars" & vbNewLine & vbNewLine & "Find 3 in 10 clicks and WIN!!", "Hidden Stars", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub picOne_Click(sender As Object, e As EventArgs) Handles picOne.Click, picTwo.Click, picThree.Click, picFour.Click, picFive.Click, picSix.Click, picSeven.Click,
                                                                       picEight.Click, picNine.Click, picTen.Click, picEleven.Click, picTwelve.Click, picThirteen.Click,
                                                                       picFourteen.Click, picFifteen.Click, picSixteen.Click, picSeventeen.Click, picEighteen.Click,
                                                                       picNineteen.Click, picTwenty.Click, picTwentyOne.Click, picTwentyTwo.Click, picTwentyThree.Click,
                                                                       picTwentyFour.Click, picTwentyFive.Click
        Dim picArray As PictureBox() = {picOne, picTwo, picThree, picFour, picFive, picSix, picSeven, picEight, picNine, picTen, picEleven, picTwelve, picThirteen,
                                        picFourteen, picFifteen, picSixteen, picSeventeen, picEighteen, picNineteen, picTwenty, picTwentyOne, picTwentyTwo, picTwentyThree,
                                        picTwentyFour, picTwentyFive}
        Dim fakeArray(24) As Integer
        Dim rand As New Random
        Dim picInt As PictureBox = sender
        Dim starcount, kaboomcount, iRand As Integer
        picInt.Enabled = False
        If stars = 3 Then stars = 0
        If tries = 10 Then tries = 0
        tries += 1
        For y = 0 To 24
            iRand = rand.Next(0, 25)
            If kaboom = 20 Then iRand = 1
            If starcount = 5 Then iRand = 5
            fakeArray(y) = iRand
            Select Case fakeArray(y)
                Case 0 To 4
                    picInt.Image = My.Resources.betterstars
                    starcount += 1
                Case 5 To 24
                    picInt.Image = My.Resources.bomber
                    kaboomcount += 1
            End Select
        Next
        If stars = 3 Then
            MessageBox.Show("You win!", "Hidden Stars", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For k = 0 To picArray.Length - 1
                picArray(k).Enabled = False
                If fakeArray(k) >= 0 And fakeArray(k) <= 4 Then
                    picArray(k).Image = My.Resources.betterstars
                ElseIf fakeArray(k) >= 5 And fakeArray(k) <= 24 Then
                    picArray(k).Image = My.Resources.bomber
                End If
            Next
            Exit Sub
        End If
        If tries = 10 Then
            MessageBox.Show("10 tries have been reached!", "Hidden Stars", MessageBoxButtons.OK, MessageBoxIcon.Information)
            For j = 0 To picArray.Length - 1
                If fakeArray(j) >= 0 And fakeArray(j) <= 4 Then
                    picArray(j).Image = My.Resources.betterstars
                ElseIf fakeArray(j) >= 5 And fakeArray(j) <= 24 Then
                    picArray(j).Image = My.Resources.bomber
                End If
            Next
        End If
    End Sub
End Class