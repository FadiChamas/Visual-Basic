<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDuplicatedNumbers
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
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.lblDuplicates = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.ItemHeight = 16
        Me.lstArray.Location = New System.Drawing.Point(18, 15)
        Me.lstArray.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(362, 20)
        Me.lstArray.TabIndex = 0
        '
        'lblDuplicates
        '
        Me.lblDuplicates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDuplicates.Location = New System.Drawing.Point(18, 39)
        Me.lblDuplicates.Name = "lblDuplicates"
        Me.lblDuplicates.Size = New System.Drawing.Size(362, 93)
        Me.lblDuplicates.TabIndex = 1
        '
        'btnShow
        '
        Me.btnShow.AutoSize = True
        Me.btnShow.Location = New System.Drawing.Point(18, 135)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(103, 41)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(277, 135)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(103, 41)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDuplicatedNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(399, 188)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblDuplicates)
        Me.Controls.Add(Me.lstArray)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDuplicatedNumbers"
        Me.Text = "ARRAY Ex02 Duplicated Values"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstArray As ListBox
    Friend WithEvents lblDuplicates As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnExit As Button
End Class
