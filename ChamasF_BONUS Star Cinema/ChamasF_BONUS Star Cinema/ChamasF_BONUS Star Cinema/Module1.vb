Module Module1
    Public film As String = frmSelect.lstFilms.SelectedItem
    Public iSeats As Integer = frmSeat.txtSeats.Text
    Public strSeat As String = frmSeat.lblSType.Text
    Public iSeatPrice As Integer = frmSeat.lblFrontalPrice.Text
    Public iPrice As Double = 1.13 * (iSeats * iSeatPrice)
    Public time As String = frmDateandTime.lstTime.SelectedItem
    Public day As String = frmDateandTime.lstDate.SelectedItem
    Public iname As String = frmSelect.txtName.Text
End Module
