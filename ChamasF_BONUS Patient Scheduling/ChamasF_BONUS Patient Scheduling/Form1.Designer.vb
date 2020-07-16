<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dtpBook = New System.Windows.Forms.DateTimePicker()
        Me.lstBook = New System.Windows.Forms.ListBox()
        Me.btnBook = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbBook = New System.Windows.Forms.ComboBox()
        Me.lblBook = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpBook
        '
        Me.dtpBook.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBook.Location = New System.Drawing.Point(18, 26)
        Me.dtpBook.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpBook.Name = "dtpBook"
        Me.dtpBook.Size = New System.Drawing.Size(192, 23)
        Me.dtpBook.TabIndex = 0
        '
        'lstBook
        '
        Me.lstBook.ColumnWidth = 1
        Me.lstBook.FormattingEnabled = True
        Me.lstBook.ItemHeight = 16
        Me.lstBook.Location = New System.Drawing.Point(218, 58)
        Me.lstBook.Margin = New System.Windows.Forms.Padding(4)
        Me.lstBook.MultiColumn = True
        Me.lstBook.Name = "lstBook"
        Me.lstBook.Size = New System.Drawing.Size(174, 260)
        Me.lstBook.TabIndex = 1
        '
        'btnBook
        '
        Me.btnBook.AutoSize = True
        Me.btnBook.Location = New System.Drawing.Point(18, 261)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(76, 26)
        Me.btnBook.TabIndex = 2
        Me.btnBook.Text = "Book"
        Me.btnBook.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.AutoSize = True
        Me.btnRemove.Location = New System.Drawing.Point(114, 261)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(77, 26)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(18, 293)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(173, 26)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbBook
        '
        Me.cbBook.FormattingEnabled = True
        Me.cbBook.Location = New System.Drawing.Point(18, 56)
        Me.cbBook.Name = "cbBook"
        Me.cbBook.Size = New System.Drawing.Size(193, 24)
        Me.cbBook.TabIndex = 5
        Me.cbBook.Text = "10:00 AM"
        '
        'lblBook
        '
        Me.lblBook.BackColor = System.Drawing.Color.White
        Me.lblBook.Location = New System.Drawing.Point(215, 26)
        Me.lblBook.Name = "lblBook"
        Me.lblBook.Size = New System.Drawing.Size(177, 23)
        Me.lblBook.TabIndex = 6
        Me.lblBook.Text = "April 5, 2019 10:00 AM"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(529, 330)
        Me.Controls.Add(Me.lblBook)
        Me.Controls.Add(Me.cbBook)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnBook)
        Me.Controls.Add(Me.lstBook)
        Me.Controls.Add(Me.dtpBook)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpBook As DateTimePicker
    Friend WithEvents lstBook As ListBox
    Friend WithEvents btnBook As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cbBook As ComboBox
    Friend WithEvents lblBook As Label
End Class
