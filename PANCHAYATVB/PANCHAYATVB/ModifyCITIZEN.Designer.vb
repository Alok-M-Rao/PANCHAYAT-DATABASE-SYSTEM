<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyCITIZEN
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.ADDRESS = New System.Windows.Forms.RadioButton()
        Me.PHONE = New System.Windows.Forms.RadioButton()
        Me.LAST_NAME = New System.Windows.Forms.RadioButton()
        Me.MIDDLE_NAME = New System.Windows.Forms.RadioButton()
        Me.FIRST_NAME = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'AADHAAR_ID
        '
        Me.AADHAAR_ID.AutoSize = True
        Me.AADHAAR_ID.BackColor = System.Drawing.SystemColors.Control
        Me.AADHAAR_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AADHAAR_ID.Location = New System.Drawing.Point(64, 102)
        Me.AADHAAR_ID.Name = "AADHAAR_ID"
        Me.AADHAAR_ID.Size = New System.Drawing.Size(83, 13)
        Me.AADHAAR_ID.TabIndex = 0
        Me.AADHAAR_ID.Text = "AADHAAR ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(288, 94)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(407, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.ADDRESS)
        Me.MODIFY_OPTION.Controls.Add(Me.PHONE)
        Me.MODIFY_OPTION.Controls.Add(Me.LAST_NAME)
        Me.MODIFY_OPTION.Controls.Add(Me.MIDDLE_NAME)
        Me.MODIFY_OPTION.Controls.Add(Me.FIRST_NAME)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(67, 177)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(138, 202)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'ADDRESS
        '
        Me.ADDRESS.AutoSize = True
        Me.ADDRESS.BackColor = System.Drawing.Color.White
        Me.ADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS.Location = New System.Drawing.Point(17, 163)
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Size = New System.Drawing.Size(84, 17)
        Me.ADDRESS.TabIndex = 4
        Me.ADDRESS.TabStop = True
        Me.ADDRESS.Text = "ADDRESS"
        Me.ADDRESS.UseVisualStyleBackColor = False
        '
        'PHONE
        '
        Me.PHONE.AutoSize = True
        Me.PHONE.BackColor = System.Drawing.Color.White
        Me.PHONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHONE.Location = New System.Drawing.Point(17, 130)
        Me.PHONE.Name = "PHONE"
        Me.PHONE.Size = New System.Drawing.Size(68, 17)
        Me.PHONE.TabIndex = 3
        Me.PHONE.TabStop = True
        Me.PHONE.Text = "PHONE"
        Me.PHONE.UseVisualStyleBackColor = False
        '
        'LAST_NAME
        '
        Me.LAST_NAME.AutoSize = True
        Me.LAST_NAME.BackColor = System.Drawing.Color.White
        Me.LAST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAST_NAME.Location = New System.Drawing.Point(17, 98)
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.Size = New System.Drawing.Size(95, 17)
        Me.LAST_NAME.TabIndex = 2
        Me.LAST_NAME.TabStop = True
        Me.LAST_NAME.Text = "LAST NAME"
        Me.LAST_NAME.UseVisualStyleBackColor = False
        '
        'MIDDLE_NAME
        '
        Me.MIDDLE_NAME.AutoSize = True
        Me.MIDDLE_NAME.BackColor = System.Drawing.Color.White
        Me.MIDDLE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIDDLE_NAME.Location = New System.Drawing.Point(17, 66)
        Me.MIDDLE_NAME.Name = "MIDDLE_NAME"
        Me.MIDDLE_NAME.Size = New System.Drawing.Size(111, 17)
        Me.MIDDLE_NAME.TabIndex = 1
        Me.MIDDLE_NAME.TabStop = True
        Me.MIDDLE_NAME.Text = "MIDDLE NAME"
        Me.MIDDLE_NAME.UseVisualStyleBackColor = False
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.AutoSize = True
        Me.FIRST_NAME.BackColor = System.Drawing.Color.White
        Me.FIRST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRST_NAME.Location = New System.Drawing.Point(17, 31)
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.Size = New System.Drawing.Size(100, 17)
        Me.FIRST_NAME.TabIndex = 0
        Me.FIRST_NAME.TabStop = True
        Me.FIRST_NAME.Text = "FIRST NAME"
        Me.FIRST_NAME.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(288, 261)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(407, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Location = New System.Drawing.Point(399, 333)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(121, 33)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyCITIZEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(771, 486)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AADHAAR_ID)
        Me.Name = "ModifyCITIZEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyCITIZEN"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AADHAAR_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents ADDRESS As RadioButton
    Friend WithEvents PHONE As RadioButton
    Friend WithEvents LAST_NAME As RadioButton
    Friend WithEvents MIDDLE_NAME As RadioButton
    Friend WithEvents FIRST_NAME As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
