<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyPANCHAYAT
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
        Me.VILLAGE_NUMBER = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.DISTRICT_NAME = New System.Windows.Forms.RadioButton()
        Me.VILLAGE_NAME = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'VILLAGE_NUMBER
        '
        Me.VILLAGE_NUMBER.AutoSize = True
        Me.VILLAGE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VILLAGE_NUMBER.Location = New System.Drawing.Point(84, 101)
        Me.VILLAGE_NUMBER.Name = "VILLAGE_NUMBER"
        Me.VILLAGE_NUMBER.Size = New System.Drawing.Size(115, 13)
        Me.VILLAGE_NUMBER.TabIndex = 0
        Me.VILLAGE_NUMBER.Text = "VILLAGE NUMBER"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(299, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.DISTRICT_NAME)
        Me.MODIFY_OPTION.Controls.Add(Me.VILLAGE_NAME)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(87, 212)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(150, 145)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'DISTRICT_NAME
        '
        Me.DISTRICT_NAME.AutoSize = True
        Me.DISTRICT_NAME.BackColor = System.Drawing.Color.White
        Me.DISTRICT_NAME.Location = New System.Drawing.Point(13, 93)
        Me.DISTRICT_NAME.Name = "DISTRICT_NAME"
        Me.DISTRICT_NAME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DISTRICT_NAME.Size = New System.Drawing.Size(122, 17)
        Me.DISTRICT_NAME.TabIndex = 1
        Me.DISTRICT_NAME.TabStop = True
        Me.DISTRICT_NAME.Text = "DISTRICT NAME"
        Me.DISTRICT_NAME.UseVisualStyleBackColor = False
        '
        'VILLAGE_NAME
        '
        Me.VILLAGE_NAME.AutoSize = True
        Me.VILLAGE_NAME.BackColor = System.Drawing.Color.White
        Me.VILLAGE_NAME.Location = New System.Drawing.Point(13, 34)
        Me.VILLAGE_NAME.Name = "VILLAGE_NAME"
        Me.VILLAGE_NAME.Size = New System.Drawing.Size(115, 17)
        Me.VILLAGE_NAME.TabIndex = 0
        Me.VILLAGE_NAME.TabStop = True
        Me.VILLAGE_NAME.Text = "VILLAGE NAME"
        Me.VILLAGE_NAME.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(311, 243)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(439, 336)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(99, 35)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyPANCHAYAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 493)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.VILLAGE_NUMBER)
        Me.Name = "ModifyPANCHAYAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyPANCHAYAT"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VILLAGE_NUMBER As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents DISTRICT_NAME As RadioButton
    Friend WithEvents VILLAGE_NAME As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
