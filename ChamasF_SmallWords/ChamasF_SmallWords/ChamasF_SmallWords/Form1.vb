'**************************************************************
' PROGRAMME	: Strings Ex01 Small Words
'  
' OUTLINE : This programme reads the information from a file
'           named "smallwords.txt", and checks to see if any of
'           the letters in the inputted word, that is less than
'           5 characters, can spell out a word in the file. If
'           so, the programme displays the word from the file
'           in the listbox.
' 
' PROGRAMMER :	Fadi Chamas
'
' DATE	:	June 4th, 2019
' **************************************************************
Imports System.IO
Public Class frmSmallWords
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        lstOut.Items.Clear()
        Dim strLetter As String = txtEnter.Text
        Dim str As String
        Dim chr(2) As Char
        Dim steamReader As StreamReader
        If strLetter.Length > 5 Then
            MessageBox.Show("This word exceeds 5 characters, please enter a word 5 characters or shorter.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If File.Exists("smallwords.txt") Then
            steamReader = File.OpenText("smallwords.txt")
            Do Until steamReader.Peek = -1
                str = steamReader.ReadLine
                For i = 0 To str.Length - 1
                    chr(i) = str.Chars(i)
                Next
                If strLetter.Contains(chr(0)) = True And strLetter.Contains(chr(1)) = True And strLetter.Contains(chr(2)) = True Then
                    lstOut.Items.Add(str)
                End If
            Loop
        End If
    End Sub
End Class
