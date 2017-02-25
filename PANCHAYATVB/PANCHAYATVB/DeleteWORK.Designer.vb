<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteWORK
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
        Me.DELETE = New System.Windows.Forms.Button()
        Me.WORKER_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DELETE
        '
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.Location = New System.Drawing.Point(348, 256)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(86, 30)
        Me.DELETE.TabIndex = 0
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = True
        '
        'WORKER_ID
        '
        Me.WORKER_ID.AutoSize = True
        Me.WORKER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WORKER_ID.Location = New System.Drawing.Point(124, 142)
        Me.WORKER_ID.Name = "WORKER_ID"
        Me.WORKER_ID.Size = New System.Drawing.Size(79, 13)
        Me.WORKER_ID.TabIndex = 1
        Me.WORKER_ID.Text = "WORKER ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(312, 134)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(316, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'DeleteWORK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.An_early_nineteenth_century_painting_depicting
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 506)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.WORKER_ID)
        Me.Controls.Add(Me.DELETE)
        Me.Name = "DeleteWORK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DeleteWORK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DELETE As Button
    Friend WithEvents WORKER_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
