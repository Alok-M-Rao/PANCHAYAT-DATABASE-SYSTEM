<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifySECRETARY
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
        Me.SECRETARY_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.SALARY = New System.Windows.Forms.RadioButton()
        Me.PHONE = New System.Windows.Forms.RadioButton()
        Me.LAST_NAME = New System.Windows.Forms.RadioButton()
        Me.MIDDLE_NAME = New System.Windows.Forms.RadioButton()
        Me.FIRST_NAME = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'SECRETARY_ID
        '
        Me.SECRETARY_ID.AutoSize = True
        Me.SECRETARY_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECRETARY_ID.Location = New System.Drawing.Point(83, 96)
        Me.SECRETARY_ID.Name = "SECRETARY_ID"
        Me.SECRETARY_ID.Size = New System.Drawing.Size(98, 13)
        Me.SECRETARY_ID.TabIndex = 0
        Me.SECRETARY_ID.Text = "SECRETARY ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(352, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(398, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.SALARY)
        Me.MODIFY_OPTION.Controls.Add(Me.PHONE)
        Me.MODIFY_OPTION.Controls.Add(Me.LAST_NAME)
        Me.MODIFY_OPTION.Controls.Add(Me.MIDDLE_NAME)
        Me.MODIFY_OPTION.Controls.Add(Me.FIRST_NAME)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(86, 213)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(184, 242)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'SALARY
        '
        Me.SALARY.AutoSize = True
        Me.SALARY.BackColor = System.Drawing.Color.White
        Me.SALARY.Location = New System.Drawing.Point(14, 195)
        Me.SALARY.Name = "SALARY"
        Me.SALARY.Size = New System.Drawing.Size(73, 17)
        Me.SALARY.TabIndex = 4
        Me.SALARY.TabStop = True
        Me.SALARY.Text = "SALARY"
        Me.SALARY.UseVisualStyleBackColor = False
        '
        'PHONE
        '
        Me.PHONE.AutoSize = True
        Me.PHONE.BackColor = System.Drawing.Color.White
        Me.PHONE.Location = New System.Drawing.Point(14, 157)
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
        Me.LAST_NAME.Location = New System.Drawing.Point(14, 114)
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
        Me.MIDDLE_NAME.Location = New System.Drawing.Point(14, 75)
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
        Me.FIRST_NAME.Location = New System.Drawing.Point(14, 31)
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.Size = New System.Drawing.Size(100, 17)
        Me.FIRST_NAME.TabIndex = 0
        Me.FIRST_NAME.TabStop = True
        Me.FIRST_NAME.Text = "FIRST NAME"
        Me.FIRST_NAME.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(352, 265)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(398, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(469, 342)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(93, 32)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifySECRETARY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(890, 492)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SECRETARY_ID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ModifySECRETARY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifySECRETARY"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SECRETARY_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents SALARY As RadioButton
    Friend WithEvents PHONE As RadioButton
    Friend WithEvents LAST_NAME As RadioButton
    Friend WithEvents MIDDLE_NAME As RadioButton
    Friend WithEvents FIRST_NAME As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
