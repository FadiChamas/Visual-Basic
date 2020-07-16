'**************************************************************
' PROGRAMME	: ARRAY Ex01 Even And Odd Numbers
'  
' OUTLINE : With the click of a button, this programme 
'           generates an array Of random numbers, checks the 
'           array for even And odd numbers, and displays which 
'           values are even Or odd, all In one list box.
' 
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	April 12th, 2019
' **************************************************************
Public Class frmEvenAndOddNumbers
    Private iNum(9) As Integer
    Private rand As New Random
    Private strOutput As String = Nothing
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        FillArray()
        lstArray.Items.Add("")
        lstArray.Items.Add("EVEN NUMBERS IN ARRAY:")
        EvenNumbers()
        lstArray.Items.Add("")
        lstArray.Items.Add("ODD NUMBERS IN ARRAY:")
        OddNumbers()
    End Sub
    Private Sub FillArray()
        For i = 0 To iNum.Length - 1
            iNum(i) = rand.Next(0, 100)
        Next
        DisplayArray(iNum)
    End Sub
    Private Sub DisplayArray(iNum)
        For j = 0 To iNum.Length - 1
            lstArray.Items.Add(j & vbTab & iNum(j))
        Next
    End Sub
    Private Sub EvenNumbers()
        For k = 0 To iNum.Length - 1
            Dim iRemainder As Integer = iNum(k) Mod 2
            If iRemainder = 0 Then
                lstArray.Items.Add(iNum(k))
            End If
        Next
    End Sub
    Private Sub OddNumbers()
        For l = 0 To iNum.Length - 1
            Dim iRemainder As Integer = iNum(l) Mod 2
            If iRemainder = 1 Then
                lstArray.Items.Add(iNum(l))
            End If
        Next
    End Sub
End Class
