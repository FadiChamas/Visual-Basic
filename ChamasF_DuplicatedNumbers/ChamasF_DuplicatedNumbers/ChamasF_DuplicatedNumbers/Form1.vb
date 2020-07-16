'**************************************************************
' PROGRAMME	: ARRAY Ex02 Duplicated Numbers
'  
' OUTLINE : With the click of a button, this programme 
'           generates an array of random numbers, displays the 
'           array in a listbox, checks the array for any 
'           duplicated numbers, and displays how many times the 
'           numbers are repeated In a label
' 
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	April 16th, 2019
' **************************************************************
Public Class frmDuplicatedNumbers
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim num(9) As Integer
        Dim strOut As String = Nothing
        Dim rand As New Random
        Dim re(10) As Integer
        lstArray.Items.Clear()
        lblDuplicates.Text = ""
        For i = 0 To num.Length - 1
            num(i) = rand.Next(10, 21)
            strOut &= num(i) & "  "
        Next
        lstArray.Items.Add(strOut)
        For j = 0 To num.Length - 1
            Select Case num(j)
                Case 10
                    re(0) += 1
                Case 11
                    re(1) += 1
                Case 12
                    re(2) += 1
                Case 13
                    re(3) += 1
                Case 14
                    re(4) += 1
                Case 15
                    re(5) += 1
                Case 16
                    re(6) += 1
                Case 17
                    re(7) += 1
                Case 18
                    re(8) += 1
                Case 19
                    re(9) += 1
                Case 20
                    re(10) += 1
            End Select
        Next
        For k = 0 To re.Length - 1
            If re(k) > 1 Then
                lblDuplicates.Text &= 10 + k & " repeated " & re(k) & " times." & vbNewLine
            End If
        Next
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
