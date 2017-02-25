<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertMEMBER
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
        Me.MEMBER_ID = New System.Windows.Forms.Label()
        Me.MEMBER_UID = New System.Windows.Forms.Label()
        Me.DEPARTMENT = New System.Windows.Forms.Label()
        Me.SALARY = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'MEMBER_ID
        '
        Me.MEMBER_ID.AutoSize = True
        Me.MEMBER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEMBER_ID.Location = New System.Drawing.Point(58, 80)
        Me.MEMBER_ID.Name = "MEMBER_ID"
        Me.MEMBER_ID.Size = New System.Drawing.Size(77, 13)
        Me.MEMBER_ID.TabIndex = 0
        Me.MEMBER_ID.Text = "MEMBER ID"
        '
        'MEMBER_UID
        '
        Me.MEMBER_UID.AutoSize = True
        Me.MEMBER_UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEMBER_UID.Location = New System.Drawing.Point(58, 164)
        Me.MEMBER_UID.Name = "MEMBER_UID"
        Me.MEMBER_UID.Size = New System.Drawing.Size(86, 13)
        Me.MEMBER_UID.TabIndex = 1
        Me.MEMBER_UID.Text = "MEMBER UID"
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.AutoSize = True
        Me.DEPARTMENT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DEPARTMENT.Location = New System.Drawing.Point(58, 235)
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.Size = New System.Drawing.Size(92, 13)
        Me.DEPARTMENT.TabIndex = 2
        Me.DEPARTMENT.Text = "DEPARTMENT"
        '
        'SALARY
        '
        Me.SALARY.AutoSize = True
        Me.SALARY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALARY.Location = New System.Drawing.Point(58, 301)
        Me.SALARY.Name = "SALARY"
        Me.SALARY.Size = New System.Drawing.Size(55, 13)
        Me.SALARY.TabIndex = 3
        Me.SALARY.Text = "SALARY"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(275, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(275, 294)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(293, 20)
        Me.TextBox3.TabIndex = 7
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(304, 387)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(90, 35)
        Me.INSERT.TabIndex = 8
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(275, 156)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(293, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(275, 227)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(293, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'InsertMEMBER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(695, 458)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SALARY)
        Me.Controls.Add(Me.DEPARTMENT)
        Me.Controls.Add(Me.MEMBER_UID)
        Me.Controls.Add(Me.MEMBER_ID)
        Me.Name = "InsertMEMBER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertMEMBER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MEMBER_ID As Label
    Friend WithEvents MEMBER_UID As Label
    Friend WithEvents DEPARTMENT As Label
    Friend WithEvents SALARY As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents INSERT As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
