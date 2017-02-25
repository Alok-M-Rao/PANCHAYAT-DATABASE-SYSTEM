<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteWELFARE
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
        Me.WELFARE_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WELFARE_ID
        '
        Me.WELFARE_ID.AutoSize = True
        Me.WELFARE_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WELFARE_ID.Location = New System.Drawing.Point(132, 129)
        Me.WELFARE_ID.Name = "WELFARE_ID"
        Me.WELFARE_ID.Size = New System.Drawing.Size(83, 13)
        Me.WELFARE_ID.TabIndex = 0
        Me.WELFARE_ID.Text = "WELFARE ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(299, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'DELETE
        '
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(317, 233)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(96, 33)
        Me.DELETE.TabIndex = 2
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'DeleteWELFARE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.An_early_nineteenth_century_painting_depicting
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 502)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.WELFARE_ID)
        Me.Name = "DeleteWELFARE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteWELFARE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WELFARE_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DELETE As Button
End Class
