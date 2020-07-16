<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSeat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBack3 = New System.Windows.Forms.Button()
        Me.btnContinue3 = New System.Windows.Forms.Button()
        Me.lblSeats = New System.Windows.Forms.Label()
        Me.lblSeatType = New System.Windows.Forms.Label()
        Me.btnFront = New System.Windows.Forms.Button()
        Me.btnMiddle = New System.Windows.Forms.Button()
        Me.btnRear = New System.Windows.Forms.Button()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.lblFrontalPrice = New System.Windows.Forms.Label()
        Me.lblSType = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack3
        '
        Me.btnBack3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBack3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack3.Location = New System.Drawing.Point(15, 173)
        Me.btnBack3.Name = "btnBack3"
        Me.btnBack3.Size = New System.Drawing.Size(119, 29)
        Me.btnBack3.TabIndex = 9
        Me.btnBack3.Text = "Change"
        Me.btnBack3.UseVisualStyleBackColor = False
        '
        'btnContinue3
        '
        Me.btnContinue3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnContinue3.Enabled = False
        Me.btnContinue3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue3.Location = New System.Drawing.Point(194, 174)
        Me.btnContinue3.Name = "btnContinue3"
        Me.btnContinue3.Size = New System.Drawing.Size(122, 29)
        Me.btnContinue3.TabIndex = 10
        Me.btnContinue3.Text = "Continue"
        Me.btnContinue3.UseVisualStyleBackColor = False
        '
        'lblSeats
        '
        Me.lblSeats.AllowDrop = True
        Me.lblSeats.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSeats.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeats.Location = New System.Drawing.Point(9, 120)
        Me.lblSeats.Name = "lblSeats"
        Me.lblSeats.Size = New System.Drawing.Size(162, 40)
        Me.lblSeats.TabIndex = 11
        Me.lblSeats.Text = "Number of Seats:"
        Me.lblSeats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeatType
        '
        Me.lblSeatType.AllowDrop = True
        Me.lblSeatType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSeatType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeatType.Location = New System.Drawing.Point(12, 9)
        Me.lblSeatType.Name = "lblSeatType"
        Me.lblSeatType.Size = New System.Drawing.Size(304, 96)
        Me.lblSeatType.TabIndex = 12
        Me.lblSeatType.Text = "  Seat Type:"
        '
        'btnFront
        '
        Me.btnFront.BackColor = System.Drawing.Color.White
        Me.btnFront.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFront.Location = New System.Drawing.Point(15, 33)
        Me.btnFront.Name = "btnFront"
        Me.btnFront.Size = New System.Drawing.Size(93, 62)
        Me.btnFront.TabIndex = 13
        Me.btnFront.Text = "Front: $8.00"
        Me.btnFront.UseVisualStyleBackColor = False
        '
        'btnMiddle
        '
        Me.btnMiddle.BackColor = System.Drawing.Color.White
        Me.btnMiddle.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMiddle.Location = New System.Drawing.Point(118, 33)
        Me.btnMiddle.Name = "btnMiddle"
        Me.btnMiddle.Size = New System.Drawing.Size(93, 62)
        Me.btnMiddle.TabIndex = 14
        Me.btnMiddle.Text = "Middle: $10.00"
        Me.btnMiddle.UseVisualStyleBackColor = False
        '
        'btnRear
        '
        Me.btnRear.BackColor = System.Drawing.Color.White
        Me.btnRear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRear.Location = New System.Drawing.Point(217, 33)
        Me.btnRear.Name = "btnRear"
        Me.btnRear.Size = New System.Drawing.Size(93, 62)
        Me.btnRear.TabIndex = 15
        Me.btnRear.Text = "Rear: $12.00"
        Me.btnRear.UseVisualStyleBackColor = False
        '
        'txtSeats
        '
        Me.txtSeats.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeats.Location = New System.Drawing.Point(194, 120)
        Me.txtSeats.Multiline = True
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(122, 40)
        Me.txtSeats.TabIndex = 16
        Me.txtSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFrontalPrice
        '
        Me.lblFrontalPrice.AutoSize = True
        Me.lblFrontalPrice.Location = New System.Drawing.Point(69, 181)
        Me.lblFrontalPrice.Name = "lblFrontalPrice"
        Me.lblFrontalPrice.Size = New System.Drawing.Size(13, 13)
        Me.lblFrontalPrice.TabIndex = 23
        Me.lblFrontalPrice.Text = "8"
        '
        'lblSType
        '
        Me.lblSType.AutoSize = True
        Me.lblSType.Location = New System.Drawing.Point(88, 181)
        Me.lblSType.Name = "lblSType"
        Me.lblSType.Size = New System.Drawing.Size(31, 13)
        Me.lblSType.TabIndex = 24
        Me.lblSType.Text = "Front"
        '
        'frmSeat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 204)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.btnRear)
        Me.Controls.Add(Me.btnMiddle)
        Me.Controls.Add(Me.btnFront)
        Me.Controls.Add(Me.lblSeatType)
        Me.Controls.Add(Me.lblSeats)
        Me.Controls.Add(Me.btnContinue3)
        Me.Controls.Add(Me.btnBack3)
        Me.Controls.Add(Me.lblFrontalPrice)
        Me.Controls.Add(Me.lblSType)
        Me.Name = "frmSeat"
        Me.Text = "Star Cinema"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack3 As Button
    Friend WithEvents btnContinue3 As Button
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblSeatType As Label
    Friend WithEvents btnFront As Button
    Friend WithEvents btnMiddle As Button
    Friend WithEvents btnRear As Button
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents lblFrontalPrice As Label
    Friend WithEvents lblSType As Label
End Class
