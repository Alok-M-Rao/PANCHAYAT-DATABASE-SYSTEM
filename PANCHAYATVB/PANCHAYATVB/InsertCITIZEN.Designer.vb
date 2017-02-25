<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertCITIZEN
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
        Me.ADDRESS = New System.Windows.Forms.Label()
        Me.PHONE_NUMBER = New System.Windows.Forms.Label()
        Me.DATE_OF_BIRTH = New System.Windows.Forms.Label()
        Me.GENDER = New System.Windows.Forms.Label()
        Me.AADHAAR_ID = New System.Windows.Forms.Label()
        Me.LAST_NAME = New System.Windows.Forms.Label()
        Me.MIDDLE_NAME = New System.Windows.Forms.Label()
        Me.FIRST_NAME = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.MALE = New System.Windows.Forms.RadioButton()
        Me.FEMALE = New System.Windows.Forms.RadioButton()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'VILLAGE_NUMBER
        '
        Me.VILLAGE_NUMBER.AutoSize = True
        Me.VILLAGE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VILLAGE_NUMBER.Location = New System.Drawing.Point(32, 394)
        Me.VILLAGE_NUMBER.Name = "VILLAGE_NUMBER"
        Me.VILLAGE_NUMBER.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VILLAGE_NUMBER.Size = New System.Drawing.Size(115, 13)
        Me.VILLAGE_NUMBER.TabIndex = 17
        Me.VILLAGE_NUMBER.Text = "VILLAGE NUMBER"
        '
        'ADDRESS
        '
        Me.ADDRESS.AutoSize = True
        Me.ADDRESS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESS.Location = New System.Drawing.Point(32, 355)
        Me.ADDRESS.Name = "ADDRESS"
        Me.ADDRESS.Size = New System.Drawing.Size(66, 13)
        Me.ADDRESS.TabIndex = 16
        Me.ADDRESS.Text = "ADDRESS"
        '
        'PHONE_NUMBER
        '
        Me.PHONE_NUMBER.AutoSize = True
        Me.PHONE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PHONE_NUMBER.Location = New System.Drawing.Point(32, 315)
        Me.PHONE_NUMBER.Name = "PHONE_NUMBER"
        Me.PHONE_NUMBER.Size = New System.Drawing.Size(107, 13)
        Me.PHONE_NUMBER.TabIndex = 15
        Me.PHONE_NUMBER.Text = "PHONE NUMBER"
        '
        'DATE_OF_BIRTH
        '
        Me.DATE_OF_BIRTH.AutoSize = True
        Me.DATE_OF_BIRTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATE_OF_BIRTH.Location = New System.Drawing.Point(32, 268)
        Me.DATE_OF_BIRTH.Name = "DATE_OF_BIRTH"
        Me.DATE_OF_BIRTH.Size = New System.Drawing.Size(102, 13)
        Me.DATE_OF_BIRTH.TabIndex = 14
        Me.DATE_OF_BIRTH.Text = "DATE OF BIRTH"
        '
        'GENDER
        '
        Me.GENDER.AutoSize = True
        Me.GENDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GENDER.Location = New System.Drawing.Point(32, 225)
        Me.GENDER.Name = "GENDER"
        Me.GENDER.Size = New System.Drawing.Size(59, 13)
        Me.GENDER.TabIndex = 13
        Me.GENDER.Text = "GENDER"
        '
        'AADHAAR_ID
        '
        Me.AADHAAR_ID.AutoSize = True
        Me.AADHAAR_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AADHAAR_ID.Location = New System.Drawing.Point(32, 187)
        Me.AADHAAR_ID.Name = "AADHAAR_ID"
        Me.AADHAAR_ID.Size = New System.Drawing.Size(83, 13)
        Me.AADHAAR_ID.TabIndex = 12
        Me.AADHAAR_ID.Text = "AADHAAR ID"
        '
        'LAST_NAME
        '
        Me.LAST_NAME.AutoSize = True
        Me.LAST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAST_NAME.Location = New System.Drawing.Point(32, 148)
        Me.LAST_NAME.Name = "LAST_NAME"
        Me.LAST_NAME.Size = New System.Drawing.Size(77, 13)
        Me.LAST_NAME.TabIndex = 11
        Me.LAST_NAME.Text = "LAST NAME"
        '
        'MIDDLE_NAME
        '
        Me.MIDDLE_NAME.AutoSize = True
        Me.MIDDLE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIDDLE_NAME.Location = New System.Drawing.Point(32, 105)
        Me.MIDDLE_NAME.Name = "MIDDLE_NAME"
        Me.MIDDLE_NAME.Size = New System.Drawing.Size(93, 13)
        Me.MIDDLE_NAME.TabIndex = 10
        Me.MIDDLE_NAME.Text = "MIDDLE NAME"
        '
        'FIRST_NAME
        '
        Me.FIRST_NAME.AutoSize = True
        Me.FIRST_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRST_NAME.Location = New System.Drawing.Point(32, 63)
        Me.FIRST_NAME.Name = "FIRST_NAME"
        Me.FIRST_NAME.Size = New System.Drawing.Size(82, 13)
        Me.FIRST_NAME.TabIndex = 9
        Me.FIRST_NAME.Text = "FIRST NAME"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(227, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(408, 20)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(227, 98)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(408, 20)
        Me.TextBox2.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(227, 141)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(408, 20)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(227, 180)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(408, 20)
        Me.TextBox4.TabIndex = 21
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(227, 308)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(408, 20)
        Me.TextBox5.TabIndex = 22
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(227, 348)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(408, 20)
        Me.TextBox6.TabIndex = 23
        '
        'MALE
        '
        Me.MALE.AutoSize = True
        Me.MALE.Checked = True
        Me.MALE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MALE.Location = New System.Drawing.Point(227, 221)
        Me.MALE.Name = "MALE"
        Me.MALE.Size = New System.Drawing.Size(58, 17)
        Me.MALE.TabIndex = 24
        Me.MALE.TabStop = True
        Me.MALE.Text = "MALE"
        Me.MALE.UseVisualStyleBackColor = True
        '
        'FEMALE
        '
        Me.FEMALE.AutoSize = True
        Me.FEMALE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FEMALE.Location = New System.Drawing.Point(399, 223)
        Me.FEMALE.Name = "FEMALE"
        Me.FEMALE.Size = New System.Drawing.Size(73, 17)
        Me.FEMALE.TabIndex = 25
        Me.FEMALE.Text = "FEMALE"
        Me.FEMALE.UseVisualStyleBackColor = True
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(314, 427)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(85, 35)
        Me.INSERT.TabIndex = 26
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(227, 261)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(408, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(227, 386)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(408, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'InsertCITIZEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(755, 498)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.FEMALE)
        Me.Controls.Add(Me.MALE)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.VILLAGE_NUMBER)
        Me.Controls.Add(Me.ADDRESS)
        Me.Controls.Add(Me.PHONE_NUMBER)
        Me.Controls.Add(Me.DATE_OF_BIRTH)
        Me.Controls.Add(Me.GENDER)
        Me.Controls.Add(Me.AADHAAR_ID)
        Me.Controls.Add(Me.LAST_NAME)
        Me.Controls.Add(Me.MIDDLE_NAME)
        Me.Controls.Add(Me.FIRST_NAME)
        Me.Name = "InsertCITIZEN"
        Me.Text = "InsertCITIZEN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VILLAGE_NUMBER As Label
    Friend WithEvents ADDRESS As Label
    Friend WithEvents PHONE_NUMBER As Label
    Friend WithEvents DATE_OF_BIRTH As Label
    Friend WithEvents GENDER As Label
    Friend WithEvents AADHAAR_ID As Label
    Friend WithEvents LAST_NAME As Label
    Friend WithEvents MIDDLE_NAME As Label
    Friend WithEvents FIRST_NAME As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents MALE As RadioButton
    Friend WithEvents FEMALE As RadioButton
    Friend WithEvents INSERT As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
End Class
