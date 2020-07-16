<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDynamicArrayFIBL
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
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.lblFIBL = New System.Windows.Forms.Label()
        Me.lblFIBLValues = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 16
        Me.lstOut.Location = New System.Drawing.Point(12, 12)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(269, 20)
        Me.lstOut.TabIndex = 0
        '
        'lblFIBL
        '
        Me.lblFIBL.AutoSize = True
        Me.lblFIBL.Location = New System.Drawing.Point(9, 44)
        Me.lblFIBL.Name = "lblFIBL"
        Me.lblFIBL.Size = New System.Drawing.Size(180, 16)
        Me.lblFIBL.TabIndex = 1
        Me.lblFIBL.Text = "First Increased by Last:"
        '
        'lblFIBLValues
        '
        Me.lblFIBLValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFIBLValues.Location = New System.Drawing.Point(12, 60)
        Me.lblFIBLValues.Name = "lblFIBLValues"
        Me.lblFIBLValues.Size = New System.Drawing.Size(269, 41)
        Me.lblFIBLValues.TabIndex = 2
        '
        'btnShow
        '
        Me.btnShow.AutoSize = True
        Me.btnShow.Location = New System.Drawing.Point(15, 114)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(76, 26)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Location = New System.Drawing.Point(113, 114)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 26)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Location = New System.Drawing.Point(205, 114)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 26)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmDynamicArrayFIBL
        '
        Me.AcceptButton = Me.btnShow
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(295, 163)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblFIBLValues)
        Me.Controls.Add(Me.lblFIBL)
        Me.Controls.Add(Me.lstOut)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmDynamicArrayFIBL"
        Me.Text = "First Increased By Last"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOut As ListBox
    Friend WithEvents lblFIBL As Label
    Friend WithEvents lblFIBLValues As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
