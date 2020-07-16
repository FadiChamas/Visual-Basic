Public Class frmSelect
	Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
		lstFilms.Enabled = True
		If IsNumeric(txtName.Text) Then
			MessageBox.Show("Please use Roman Numerals for numbers in your name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtName.Clear()
			txtName.Focus()
		Else
		End If
	End Sub
	Public Sub frmSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim film0 As String = "Black Panther"
        Dim film1 As String = "I, Tonya"
        Dim film2 As String = "Jumanji"
        Dim film3 As String = "Lady Bird"
        Dim film4 As String = "Maze Runner"
        Dim film5 As String = "Paddington 2"
        Dim film6 As String = "Star Wars"
        Dim film7 As String = "The Greatest Showman"
        Dim film8 As String = "The Post"
        Dim film9 As String = "Winchester"
        lstFilms.Items.Add(film0)
        lstFilms.Items.Add(film1)
		lstFilms.Items.Add(film2)
		lstFilms.Items.Add(film3)
		lstFilms.Items.Add(film4)
		lstFilms.Items.Add(film5)
		lstFilms.Items.Add(film6)
		lstFilms.Items.Add(film7)
		lstFilms.Items.Add(film8)
		lstFilms.Items.Add(film9)
	End Sub
	Private Sub lstFilms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFilms.SelectedIndexChanged
		btnContinue.Enabled = True
	End Sub
	Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim startDate As DateTime
        Dim iAddedDays As Integer
        startDate = DateTime.Today()
        Do
            iAddedDays += 1
            startDate = startDate.AddDays(1)
            frmDateandTime.lstDate.Items.Add(startDate)
        Loop Until iAddedDays = 5
        frmDateandTime.Text = "MOVIE CHOSEN: " & lstFilms.SelectedItem
        If Asc(txtName.Text) = 32 Then
        ElseIf Asc(txtName.Text) = 65 Then
        ElseIf Asc(txtName.Text) = 66 Then
        ElseIf Asc(txtName.Text) = 67 Then
        ElseIf Asc(txtName.Text) = 68 Then
        ElseIf Asc(txtName.Text) = 69 Then
        ElseIf Asc(txtName.Text) = 70 Then
        ElseIf Asc(txtName.Text) = 71 Then
        ElseIf Asc(txtName.Text) = 72 Then
        ElseIf Asc(txtName.Text) = 73 Then
        ElseIf Asc(txtName.Text) = 74 Then
        ElseIf Asc(txtName.Text) = 75 Then
        ElseIf Asc(txtName.Text) = 76 Then
        ElseIf Asc(txtName.Text) = 77 Then
        ElseIf Asc(txtName.Text) = 78 Then
        ElseIf Asc(txtName.Text) = 79 Then
        ElseIf Asc(txtName.Text) = 80 Then
        ElseIf Asc(txtName.Text) = 81 Then
        ElseIf Asc(txtName.Text) = 82 Then
        ElseIf Asc(txtName.Text) = 83 Then
        ElseIf Asc(txtName.Text) = 84 Then
        ElseIf Asc(txtName.Text) = 85 Then
        ElseIf Asc(txtName.Text) = 86 Then
        ElseIf Asc(txtName.Text) = 87 Then
        ElseIf Asc(txtName.Text) = 88 Then
        ElseIf Asc(txtName.Text) = 89 Then
        ElseIf Asc(txtName.Text) = 90 Then
        ElseIf Asc(txtName.Text) = 97 Then
        ElseIf Asc(txtName.Text) = 98 Then
        ElseIf Asc(txtName.Text) = 99 Then
        ElseIf Asc(txtName.Text) = 100 Then
        ElseIf Asc(txtName.Text) = 101 Then
        ElseIf Asc(txtName.Text) = 102 Then
        ElseIf Asc(txtName.Text) = 103 Then
        ElseIf Asc(txtName.Text) = 104 Then
        ElseIf Asc(txtName.Text) = 105 Then
        ElseIf Asc(txtName.Text) = 106 Then
        ElseIf Asc(txtName.Text) = 107 Then
        ElseIf Asc(txtName.Text) = 108 Then
        ElseIf Asc(txtName.Text) = 109 Then
        ElseIf Asc(txtName.Text) = 110 Then
        ElseIf Asc(txtName.Text) = 111 Then
        ElseIf Asc(txtName.Text) = 112 Then
        ElseIf Asc(txtName.Text) = 113 Then
        ElseIf Asc(txtName.Text) = 114 Then
        ElseIf Asc(txtName.Text) = 115 Then
        ElseIf Asc(txtName.Text) = 116 Then
        ElseIf Asc(txtName.Text) = 117 Then
        ElseIf Asc(txtName.Text) = 118 Then
        ElseIf Asc(txtName.Text) = 119 Then
        ElseIf Asc(txtName.Text) = 120 Then
        ElseIf Asc(txtName.Text) = 121 Then
        ElseIf Asc(txtName.Text) = 122 Then
        Else
            MessageBox.Show("Please write an actual name.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
			txtName.Focus()
			txtName.Clear()
			Exit Sub
		End If
		frmDateandTime.Show()
		Me.Hide()
	End Sub
End Class
