<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteCITIZEN
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
        Me.AADHAAR_ID = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'AADHAAR_ID
        '
        Me.AADHAAR_ID.AutoSize = True
        Me.AADHAAR_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AADHAAR_ID.Location = New System.Drawing.Point(88, 118)
        Me.AADHAAR_ID.Name = "AADHAAR_ID"
        Me.AADHAAR_ID.Size = New System.Drawing.Size(83, 13)
        Me.AADHAAR_ID.TabIndex = 1
        Me.AADHAAR_ID.Text = "AADHAAR ID"
        '
        'DELETE
        '
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(309, 235)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(102, 35)
        Me.DELETE.TabIndex = 2
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(290, 110)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(351, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'DeleteCITIZEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.An_early_nineteenth_century_painting_depicting
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 481)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.AADHAAR_ID)
        Me.Name = "DeleteCITIZEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteCITIZEN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AADHAAR_ID As Label
    Friend WithEvents DELETE As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
