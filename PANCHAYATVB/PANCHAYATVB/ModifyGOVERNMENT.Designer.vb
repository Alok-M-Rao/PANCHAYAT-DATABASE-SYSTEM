<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyGOVERNMENT
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
        Me.GOVERNMENT_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.GOVERNOR = New System.Windows.Forms.RadioButton()
        Me.CHIEF_MINISTER = New System.Windows.Forms.RadioButton()
        Me.STATE_NAME = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'GOVERNMENT_ID
        '
        Me.GOVERNMENT_ID.AutoSize = True
        Me.GOVERNMENT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOVERNMENT_ID.Location = New System.Drawing.Point(91, 72)
        Me.GOVERNMENT_ID.Name = "GOVERNMENT_ID"
        Me.GOVERNMENT_ID.Size = New System.Drawing.Size(111, 13)
        Me.GOVERNMENT_ID.TabIndex = 0
        Me.GOVERNMENT_ID.Text = "GOVERNMENT ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(308, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(358, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.GOVERNOR)
        Me.MODIFY_OPTION.Controls.Add(Me.CHIEF_MINISTER)
        Me.MODIFY_OPTION.Controls.Add(Me.STATE_NAME)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(94, 184)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(148, 204)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'GOVERNOR
        '
        Me.GOVERNOR.AutoSize = True
        Me.GOVERNOR.BackColor = System.Drawing.Color.White
        Me.GOVERNOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOVERNOR.Location = New System.Drawing.Point(10, 160)
        Me.GOVERNOR.Name = "GOVERNOR"
        Me.GOVERNOR.Size = New System.Drawing.Size(95, 17)
        Me.GOVERNOR.TabIndex = 2
        Me.GOVERNOR.TabStop = True
        Me.GOVERNOR.Text = "GOVERNOR"
        Me.GOVERNOR.UseVisualStyleBackColor = False
        '
        'CHIEF_MINISTER
        '
        Me.CHIEF_MINISTER.AutoSize = True
        Me.CHIEF_MINISTER.BackColor = System.Drawing.Color.White
        Me.CHIEF_MINISTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHIEF_MINISTER.Location = New System.Drawing.Point(10, 99)
        Me.CHIEF_MINISTER.Name = "CHIEF_MINISTER"
        Me.CHIEF_MINISTER.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CHIEF_MINISTER.Size = New System.Drawing.Size(125, 17)
        Me.CHIEF_MINISTER.TabIndex = 1
        Me.CHIEF_MINISTER.TabStop = True
        Me.CHIEF_MINISTER.Text = "CHIEF MINISTER"
        Me.CHIEF_MINISTER.UseVisualStyleBackColor = False
        '
        'STATE_NAME
        '
        Me.STATE_NAME.AutoSize = True
        Me.STATE_NAME.BackColor = System.Drawing.Color.White
        Me.STATE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STATE_NAME.Location = New System.Drawing.Point(10, 37)
        Me.STATE_NAME.Name = "STATE_NAME"
        Me.STATE_NAME.Size = New System.Drawing.Size(104, 17)
        Me.STATE_NAME.TabIndex = 0
        Me.STATE_NAME.TabStop = True
        Me.STATE_NAME.Text = "STATE NAME"
        Me.STATE_NAME.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 222)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(358, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(426, 313)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(90, 31)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyGOVERNMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.images__7_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 471)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GOVERNMENT_ID)
        Me.Name = "ModifyGOVERNMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyGOVERNMENT"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GOVERNMENT_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents GOVERNOR As RadioButton
    Friend WithEvents CHIEF_MINISTER As RadioButton
    Friend WithEvents STATE_NAME As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
