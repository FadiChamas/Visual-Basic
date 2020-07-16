Public Class Form1
    Private strName As String
    Private date1 As Date
    Private date2 As String = date1.ToLongDateString
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        date1 = dtpBook.Value
        cbBook.Items.Add("10:00 AM")
        cbBook.Items.Add("11:00 AM")
        cbBook.Items.Add("12:00 PM")
        cbBook.Items.Add("1:00 PM")
        cbBook.Items.Add("2:00 PM")
        cbBook.Items.Add("3:00 PM")
        cbBook.Items.Add("4:00 PM")
        cbBook.Items.Add("5:00 PM")
        cbBook.Items.Add("6:00 PM")
        lstBook.Items.Add("10:00 AM")
        lstBook.Items.Add("11:00 AM")
        lstBook.Items.Add("12:00 PM")
        lstBook.Items.Add("1:00 PM")
        lstBook.Items.Add("2:00 PM")
        lstBook.Items.Add("3:00 PM")
        lstBook.Items.Add("4:00 PM")
        lstBook.Items.Add("5:00 PM")
        lstBook.Items.Add("6:00 PM")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        strName = InputBox("Enter a name " & vbNewLine & "or type Exit to exit.")
    End Sub
    Private Sub dtpBook_ValueChanged(sender As Object, e As EventArgs) Handles dtpBook.ValueChanged
        lblBook.Text = date2 & cbBook.SelectedItem
    End Sub
    Private Sub cbBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBook.SelectedIndexChanged
        lblBook.Text = date2 & cbBook.SelectedItem
    End Sub
End Class
