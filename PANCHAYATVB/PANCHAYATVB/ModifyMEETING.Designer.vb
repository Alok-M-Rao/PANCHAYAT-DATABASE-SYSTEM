<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyMEETING
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
        Me.MEETING_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TIME = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MEETING_ID
        '
        Me.MEETING_ID.AutoSize = True
        Me.MEETING_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEETING_ID.Location = New System.Drawing.Point(82, 109)
        Me.MEETING_ID.Name = "MEETING_ID"
        Me.MEETING_ID.Size = New System.Drawing.Size(80, 13)
        Me.MEETING_ID.TabIndex = 0
        Me.MEETING_ID.Text = "MEETING ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(282, 101)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(390, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'TIME
        '
        Me.TIME.AutoSize = True
        Me.TIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIME.Location = New System.Drawing.Point(82, 229)
        Me.TIME.Name = "TIME"
        Me.TIME.Size = New System.Drawing.Size(37, 13)
        Me.TIME.TabIndex = 2
        Me.TIME.Text = "TIME"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(282, 222)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(390, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(346, 338)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(85, 31)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyMEETING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 485)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TIME)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MEETING_ID)
        Me.Name = "ModifyMEETING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyMEETING"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MEETING_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TIME As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MODIFY As Button
End Class
