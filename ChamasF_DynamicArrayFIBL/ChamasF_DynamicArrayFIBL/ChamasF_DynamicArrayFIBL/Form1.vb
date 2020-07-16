'**************************************************************
' PROGRAMME	: ARRAY Ex03 Dynamic Array FIBL
'  
' OUTLINE : With the click of a button, this programme 
'           generates an array of numbers inputted by the user, 
'           displays the array in a listbox, checks the array for
'           the first and last numbers, and adds them together for
'           the number of numbers in the array.
' 
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	April 18th, 2019
' **************************************************************
Public Class frmDynamicArrayFIBL
    Private range As String = Nothing
    Private clean As Boolean
    Private num() As Integer
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim values As String = Nothing
        Dim newfirst As Integer
        Do
            range = InputBox("Enter quantity of numbers (2-7) to input:", "INPUT")
            If ErrorCheck(range) = True Then
                ReDim num(CInt(range) - 1)
                Exit Do
            End If
        Loop
        For i = 0 To num.Length - 1
            Do
                num(i) = InputBox("Enter number " & i + 1 & ":")
                ErrorCheck(num(i))
                values &= num(i) & " "
            Loop Until clean = True
        Next
        lstOut.Items.Add(values)
        lblFIBLValues.Text = num(0) & " "
        newfirst = num(0)
        For j = 1 To num.Length - 1
            newfirst = newfirst + num.Last
            lblFIBLValues.Text &= CInt(newfirst) & " "
        Next
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOut.Items.Clear()
        lblFIBLValues.Text = ""
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Function ErrorCheck(range As String)
        clean = False
        If range = Nothing Then
            MessageBox.Show("You pressed Cancel - Goodbye!", "CANCEL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Function
        ElseIf Not IsNumeric(range) Then
            MessageBox.Show("Use numbers!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        ElseIf range < 2 Then
            MessageBox.Show("Not in 2 - 7 range!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        ElseIf range > 7 Then
            MessageBox.Show("Not in 2 - 7 range!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Function
        End If
        clean = True
        Return clean
    End Function
End Class
