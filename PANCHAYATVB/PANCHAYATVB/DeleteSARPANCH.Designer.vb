<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteSARPANCH
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
        Me.SARPANCH_ID = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'SARPANCH_ID
        '
        Me.SARPANCH_ID.AutoSize = True
        Me.SARPANCH_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARPANCH_ID.Location = New System.Drawing.Point(104, 87)
        Me.SARPANCH_ID.Name = "SARPANCH_ID"
        Me.SARPANCH_ID.Size = New System.Drawing.Size(91, 13)
        Me.SARPANCH_ID.TabIndex = 1
        Me.SARPANCH_ID.Text = "SARPANCH ID"
        '
        'DELETE
        '
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(324, 186)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(81, 29)
        Me.DELETE.TabIndex = 2
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(272, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(344, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'DeleteSARPANCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.An_early_nineteenth_century_painting_depicting
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(737, 488)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.SARPANCH_ID)
        Me.Name = "DeleteSARPANCH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteSARPANCH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SARPANCH_ID As Label
    Friend WithEvents DELETE As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
