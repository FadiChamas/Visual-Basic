<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvenAndOddNumbers
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lstArray = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.AutoSize = True
        Me.btnGenerate.Location = New System.Drawing.Point(12, 12)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(239, 26)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lstArray
        '
        Me.lstArray.FormattingEnabled = True
        Me.lstArray.ItemHeight = 16
        Me.lstArray.Location = New System.Drawing.Point(12, 44)
        Me.lstArray.Name = "lstArray"
        Me.lstArray.Size = New System.Drawing.Size(239, 356)
        Me.lstArray.TabIndex = 1
        '
        'frmEvenAndOddNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(263, 403)
        Me.Controls.Add(Me.lstArray)
        Me.Controls.Add(Me.btnGenerate)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEvenAndOddNumbers"
        Me.Text = "Even And Odd Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents lstArray As ListBox
End Class
