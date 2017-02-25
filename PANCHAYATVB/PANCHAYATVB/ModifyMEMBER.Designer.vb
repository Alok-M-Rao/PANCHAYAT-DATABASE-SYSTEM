<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyMEMBER
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTIONS = New System.Windows.Forms.GroupBox()
        Me.SALARY = New System.Windows.Forms.RadioButton()
        Me.DEPARTMENT = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTIONS.SuspendLayout()
        Me.SuspendLayout()
        '
        'MEMBER_ID
        '
        Me.MEMBER_ID.AutoSize = True
        Me.MEMBER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEMBER_ID.Location = New System.Drawing.Point(106, 85)
        Me.MEMBER_ID.Name = "MEMBER_ID"
        Me.MEMBER_ID.Size = New System.Drawing.Size(77, 13)
        Me.MEMBER_ID.TabIndex = 0
        Me.MEMBER_ID.Text = "MEMBER ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(355, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(353, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTIONS
        '
        Me.MODIFY_OPTIONS.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTIONS.Controls.Add(Me.SALARY)
        Me.MODIFY_OPTIONS.Controls.Add(Me.DEPARTMENT)
        Me.MODIFY_OPTIONS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTIONS.Location = New System.Drawing.Point(109, 185)
        Me.MODIFY_OPTIONS.Name = "MODIFY_OPTIONS"
        Me.MODIFY_OPTIONS.Size = New System.Drawing.Size(163, 185)
        Me.MODIFY_OPTIONS.TabIndex = 2
        Me.MODIFY_OPTIONS.TabStop = False
        Me.MODIFY_OPTIONS.Text = "MODIFY OPTION"
        '
        'SALARY
        '
        Me.SALARY.AutoSize = True
        Me.SALARY.BackColor = System.Drawing.Color.White
        Me.SALARY.Location = New System.Drawing.Point(17, 128)
        Me.SALARY.Name = "SALARY"
        Me.SALARY.Size = New System.Drawing.Size(73, 17)
        Me.SALARY.TabIndex = 1
        Me.SALARY.TabStop = True
        Me.SALARY.Text = "SALARY"
        Me.SALARY.UseVisualStyleBackColor = False
        '
        'DEPARTMENT
        '
        Me.DEPARTMENT.AutoSize = True
        Me.DEPARTMENT.BackColor = System.Drawing.Color.White
        Me.DEPARTMENT.Location = New System.Drawing.Point(17, 52)
        Me.DEPARTMENT.Name = "DEPARTMENT"
        Me.DEPARTMENT.Size = New System.Drawing.Size(110, 17)
        Me.DEPARTMENT.TabIndex = 0
        Me.DEPARTMENT.TabStop = True
        Me.DEPARTMENT.Text = "DEPARTMENT"
        Me.DEPARTMENT.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(355, 310)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(353, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(465, 384)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(100, 36)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(355, 233)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(353, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'ModifyMEMBER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(761, 494)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTIONS)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MEMBER_ID)
        Me.Name = "ModifyMEMBER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyMEMBER"
        Me.MODIFY_OPTIONS.ResumeLayout(False)
        Me.MODIFY_OPTIONS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MEMBER_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTIONS As GroupBox
    Friend WithEvents SALARY As RadioButton
    Friend WithEvents DEPARTMENT As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
    Friend WithEvents ComboBox2 As ComboBox
End Class
