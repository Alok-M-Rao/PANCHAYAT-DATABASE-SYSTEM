<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyISSUE
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
        Me.ISSUE_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.MEETING_ID = New System.Windows.Forms.RadioButton()
        Me.ISSUE_TYPE = New System.Windows.Forms.RadioButton()
        Me.ISSUE_UID = New System.Windows.Forms.RadioButton()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'ISSUE_ID
        '
        Me.ISSUE_ID.AutoSize = True
        Me.ISSUE_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSUE_ID.Location = New System.Drawing.Point(78, 99)
        Me.ISSUE_ID.Name = "ISSUE_ID"
        Me.ISSUE_ID.Size = New System.Drawing.Size(61, 13)
        Me.ISSUE_ID.TabIndex = 0
        Me.ISSUE_ID.Text = "ISSUE ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 219)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(339, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.MEETING_ID)
        Me.MODIFY_OPTION.Controls.Add(Me.ISSUE_TYPE)
        Me.MODIFY_OPTION.Controls.Add(Me.ISSUE_UID)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(81, 176)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(129, 211)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'MEETING_ID
        '
        Me.MEETING_ID.AutoSize = True
        Me.MEETING_ID.BackColor = System.Drawing.Color.White
        Me.MEETING_ID.Location = New System.Drawing.Point(15, 165)
        Me.MEETING_ID.Name = "MEETING_ID"
        Me.MEETING_ID.Size = New System.Drawing.Size(98, 17)
        Me.MEETING_ID.TabIndex = 2
        Me.MEETING_ID.TabStop = True
        Me.MEETING_ID.Text = "MEETING ID"
        Me.MEETING_ID.UseVisualStyleBackColor = False
        '
        'ISSUE_TYPE
        '
        Me.ISSUE_TYPE.AutoSize = True
        Me.ISSUE_TYPE.BackColor = System.Drawing.Color.White
        Me.ISSUE_TYPE.Location = New System.Drawing.Point(15, 108)
        Me.ISSUE_TYPE.Name = "ISSUE_TYPE"
        Me.ISSUE_TYPE.Size = New System.Drawing.Size(98, 17)
        Me.ISSUE_TYPE.TabIndex = 1
        Me.ISSUE_TYPE.TabStop = True
        Me.ISSUE_TYPE.Text = "ISSUE TYPE"
        Me.ISSUE_TYPE.UseVisualStyleBackColor = False
        '
        'ISSUE_UID
        '
        Me.ISSUE_UID.AutoSize = True
        Me.ISSUE_UID.BackColor = System.Drawing.Color.White
        Me.ISSUE_UID.Location = New System.Drawing.Point(15, 47)
        Me.ISSUE_UID.Name = "ISSUE_UID"
        Me.ISSUE_UID.Size = New System.Drawing.Size(88, 17)
        Me.ISSUE_UID.TabIndex = 0
        Me.ISSUE_UID.TabStop = True
        Me.ISSUE_UID.Text = "ISSUE UID"
        Me.ISSUE_UID.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(307, 337)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(339, 21)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(307, 280)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(339, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(307, 91)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(339, 21)
        Me.ComboBox4.TabIndex = 5
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(398, 406)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(97, 28)
        Me.MODIFY.TabIndex = 6
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyISSUE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(758, 489)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ISSUE_ID)
        Me.Name = "ModifyISSUE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyISSUE"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ISSUE_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents MEETING_ID As RadioButton
    Friend WithEvents ISSUE_TYPE As RadioButton
    Friend WithEvents ISSUE_UID As RadioButton
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents MODIFY As Button
End Class
