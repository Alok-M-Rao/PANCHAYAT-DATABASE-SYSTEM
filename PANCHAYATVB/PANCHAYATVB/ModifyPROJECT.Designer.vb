<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyPROJECT
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
        Me.PROJECT_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.LAND_ALLOTED = New System.Windows.Forms.RadioButton()
        Me.FUNDING = New System.Windows.Forms.RadioButton()
        Me.LEAD_ENGINEER = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'PROJECT_ID
        '
        Me.PROJECT_ID.AutoSize = True
        Me.PROJECT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROJECT_ID.Location = New System.Drawing.Point(88, 116)
        Me.PROJECT_ID.Name = "PROJECT_ID"
        Me.PROJECT_ID.Size = New System.Drawing.Size(80, 13)
        Me.PROJECT_ID.TabIndex = 0
        Me.PROJECT_ID.Text = "PROJECT ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(308, 108)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.LAND_ALLOTED)
        Me.MODIFY_OPTION.Controls.Add(Me.FUNDING)
        Me.MODIFY_OPTION.Controls.Add(Me.LEAD_ENGINEER)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(91, 225)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(154, 178)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'LAND_ALLOTED
        '
        Me.LAND_ALLOTED.AutoSize = True
        Me.LAND_ALLOTED.BackColor = System.Drawing.Color.White
        Me.LAND_ALLOTED.Location = New System.Drawing.Point(11, 138)
        Me.LAND_ALLOTED.Name = "LAND_ALLOTED"
        Me.LAND_ALLOTED.Size = New System.Drawing.Size(118, 17)
        Me.LAND_ALLOTED.TabIndex = 2
        Me.LAND_ALLOTED.TabStop = True
        Me.LAND_ALLOTED.Text = "LAND ALLOTED"
        Me.LAND_ALLOTED.UseVisualStyleBackColor = False
        '
        'FUNDING
        '
        Me.FUNDING.AutoSize = True
        Me.FUNDING.BackColor = System.Drawing.Color.White
        Me.FUNDING.Location = New System.Drawing.Point(11, 90)
        Me.FUNDING.Name = "FUNDING"
        Me.FUNDING.Size = New System.Drawing.Size(81, 17)
        Me.FUNDING.TabIndex = 1
        Me.FUNDING.TabStop = True
        Me.FUNDING.Text = "FUNDING"
        Me.FUNDING.UseVisualStyleBackColor = False
        '
        'LEAD_ENGINEER
        '
        Me.LEAD_ENGINEER.AutoSize = True
        Me.LEAD_ENGINEER.BackColor = System.Drawing.Color.White
        Me.LEAD_ENGINEER.Location = New System.Drawing.Point(11, 43)
        Me.LEAD_ENGINEER.Name = "LEAD_ENGINEER"
        Me.LEAD_ENGINEER.Size = New System.Drawing.Size(125, 17)
        Me.LEAD_ENGINEER.TabIndex = 0
        Me.LEAD_ENGINEER.TabStop = True
        Me.LEAD_ENGINEER.Text = "LEAD ENGINEER"
        Me.LEAD_ENGINEER.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(308, 264)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(396, 338)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(92, 28)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyPROJECT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 482)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PROJECT_ID)
        Me.Name = "ModifyPROJECT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyPROJECT"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PROJECT_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents LAND_ALLOTED As RadioButton
    Friend WithEvents FUNDING As RadioButton
    Friend WithEvents LEAD_ENGINEER As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
