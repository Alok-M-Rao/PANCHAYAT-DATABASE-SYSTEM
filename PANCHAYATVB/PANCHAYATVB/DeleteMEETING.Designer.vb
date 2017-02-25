<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteMEETING
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
        Me.MEETING = New System.Windows.Forms.Label()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'MEETING
        '
        Me.MEETING.AutoSize = True
        Me.MEETING.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEETING.Location = New System.Drawing.Point(141, 121)
        Me.MEETING.Name = "MEETING"
        Me.MEETING.Size = New System.Drawing.Size(63, 13)
        Me.MEETING.TabIndex = 0
        Me.MEETING.Text = "MEETING"
        '
        'DELETE
        '
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(359, 238)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(95, 27)
        Me.DELETE.TabIndex = 2
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(309, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(339, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'DeleteMEETING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.An_early_nineteenth_century_painting_depicting
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 503)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DELETE)
        Me.Controls.Add(Me.MEETING)
        Me.Name = "DeleteMEETING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteMEETING"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MEETING As Label
    Friend WithEvents DELETE As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
