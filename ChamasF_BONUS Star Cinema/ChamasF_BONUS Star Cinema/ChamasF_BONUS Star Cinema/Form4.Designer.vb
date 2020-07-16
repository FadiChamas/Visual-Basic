<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNamePrint = New System.Windows.Forms.Label()
        Me.lblFilmPrint = New System.Windows.Forms.Label()
        Me.lblTimePrint = New System.Windows.Forms.Label()
        Me.lblDatePrint = New System.Windows.Forms.Label()
        Me.lblPricePrint = New System.Windows.Forms.Label()
        Me.lblSeatsPrint = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.lblFilm2 = New System.Windows.Forms.Label()
        Me.lblDate2 = New System.Windows.Forms.Label()
        Me.lblTime2 = New System.Windows.Forms.Label()
        Me.lblSeats2 = New System.Windows.Forms.Label()
        Me.lblPrice2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNamePrint
        '
        Me.lblNamePrint.AllowDrop = True
        Me.lblNamePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNamePrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamePrint.Location = New System.Drawing.Point(12, 9)
        Me.lblNamePrint.Name = "lblNamePrint"
        Me.lblNamePrint.Size = New System.Drawing.Size(122, 40)
        Me.lblNamePrint.TabIndex = 6
        Me.lblNamePrint.Text = "Name"
        Me.lblNamePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilmPrint
        '
        Me.lblFilmPrint.AllowDrop = True
        Me.lblFilmPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFilmPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmPrint.Location = New System.Drawing.Point(12, 61)
        Me.lblFilmPrint.Name = "lblFilmPrint"
        Me.lblFilmPrint.Size = New System.Drawing.Size(122, 40)
        Me.lblFilmPrint.TabIndex = 7
        Me.lblFilmPrint.Text = "Film:"
        Me.lblFilmPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimePrint
        '
        Me.lblTimePrint.AllowDrop = True
        Me.lblTimePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTimePrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimePrint.Location = New System.Drawing.Point(12, 165)
        Me.lblTimePrint.Name = "lblTimePrint"
        Me.lblTimePrint.Size = New System.Drawing.Size(122, 40)
        Me.lblTimePrint.TabIndex = 8
        Me.lblTimePrint.Text = "Time:"
        Me.lblTimePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDatePrint
        '
        Me.lblDatePrint.AllowDrop = True
        Me.lblDatePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDatePrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePrint.Location = New System.Drawing.Point(12, 113)
        Me.lblDatePrint.Name = "lblDatePrint"
        Me.lblDatePrint.Size = New System.Drawing.Size(122, 40)
        Me.lblDatePrint.TabIndex = 9
        Me.lblDatePrint.Text = "Date:"
        Me.lblDatePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPricePrint
        '
        Me.lblPricePrint.AllowDrop = True
        Me.lblPricePrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPricePrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricePrint.Location = New System.Drawing.Point(12, 269)
        Me.lblPricePrint.Name = "lblPricePrint"
        Me.lblPricePrint.Size = New System.Drawing.Size(122, 40)
        Me.lblPricePrint.TabIndex = 10
        Me.lblPricePrint.Text = "Price with tax:"
        Me.lblPricePrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeatsPrint
        '
        Me.lblSeatsPrint.AllowDrop = True
        Me.lblSeatsPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSeatsPrint.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatsPrint.Location = New System.Drawing.Point(12, 217)
        Me.lblSeatsPrint.Name = "lblSeatsPrint"
        Me.lblSeatsPrint.Size = New System.Drawing.Size(122, 40)
        Me.lblSeatsPrint.TabIndex = 11
        Me.lblSeatsPrint.Text = "Seats:"
        Me.lblSeatsPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName2
        '
        Me.lblName2.AllowDrop = True
        Me.lblName2.BackColor = System.Drawing.Color.White
        Me.lblName2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName2.Location = New System.Drawing.Point(140, 9)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(122, 40)
        Me.lblName2.TabIndex = 12
        Me.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFilm2
        '
        Me.lblFilm2.AllowDrop = True
        Me.lblFilm2.BackColor = System.Drawing.Color.White
        Me.lblFilm2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilm2.Location = New System.Drawing.Point(140, 61)
        Me.lblFilm2.Name = "lblFilm2"
        Me.lblFilm2.Size = New System.Drawing.Size(122, 40)
        Me.lblFilm2.TabIndex = 13
        Me.lblFilm2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate2
        '
        Me.lblDate2.AllowDrop = True
        Me.lblDate2.BackColor = System.Drawing.Color.White
        Me.lblDate2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate2.Location = New System.Drawing.Point(140, 113)
        Me.lblDate2.Name = "lblDate2"
        Me.lblDate2.Size = New System.Drawing.Size(122, 40)
        Me.lblDate2.TabIndex = 14
        Me.lblDate2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime2
        '
        Me.lblTime2.AllowDrop = True
        Me.lblTime2.BackColor = System.Drawing.Color.White
        Me.lblTime2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime2.Location = New System.Drawing.Point(140, 165)
        Me.lblTime2.Name = "lblTime2"
        Me.lblTime2.Size = New System.Drawing.Size(122, 40)
        Me.lblTime2.TabIndex = 15
        Me.lblTime2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeats2
        '
        Me.lblSeats2.AllowDrop = True
        Me.lblSeats2.BackColor = System.Drawing.Color.White
        Me.lblSeats2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats2.Location = New System.Drawing.Point(140, 217)
        Me.lblSeats2.Name = "lblSeats2"
        Me.lblSeats2.Size = New System.Drawing.Size(122, 40)
        Me.lblSeats2.TabIndex = 16
        Me.lblSeats2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice2
        '
        Me.lblPrice2.AllowDrop = True
        Me.lblPrice2.BackColor = System.Drawing.Color.White
        Me.lblPrice2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice2.Location = New System.Drawing.Point(140, 269)
        Me.lblPrice2.Name = "lblPrice2"
        Me.lblPrice2.Size = New System.Drawing.Size(122, 40)
        Me.lblPrice2.TabIndex = 17
        Me.lblPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(137, 319)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 29)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack4
        '
        Me.btnBack4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack4.Location = New System.Drawing.Point(12, 319)
        Me.btnBack4.Name = "btnBack4"
        Me.btnBack4.Size = New System.Drawing.Size(119, 29)
        Me.btnBack4.TabIndex = 18
        Me.btnBack4.Text = "Change"
        Me.btnBack4.UseVisualStyleBackColor = False
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(279, 360)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack4)
        Me.Controls.Add(Me.lblPrice2)
        Me.Controls.Add(Me.lblSeats2)
        Me.Controls.Add(Me.lblTime2)
        Me.Controls.Add(Me.lblDate2)
        Me.Controls.Add(Me.lblFilm2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.lblSeatsPrint)
        Me.Controls.Add(Me.lblPricePrint)
        Me.Controls.Add(Me.lblDatePrint)
        Me.Controls.Add(Me.lblTimePrint)
        Me.Controls.Add(Me.lblFilmPrint)
        Me.Controls.Add(Me.lblNamePrint)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPrint"
        Me.Text = "Star Cinema"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNamePrint As Label
    Friend WithEvents lblFilmPrint As Label
    Friend WithEvents lblTimePrint As Label
    Friend WithEvents lblDatePrint As Label
    Friend WithEvents lblPricePrint As Label
    Friend WithEvents lblSeatsPrint As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents lblFilm2 As Label
    Friend WithEvents lblDate2 As Label
    Friend WithEvents lblTime2 As Label
    Friend WithEvents lblSeats2 As Label
    Friend WithEvents lblPrice2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack4 As Button
End Class
