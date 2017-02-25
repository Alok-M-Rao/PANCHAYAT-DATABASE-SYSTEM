<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyWELFARE
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
        Me.WELFARE_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MODIFY_OPTION = New System.Windows.Forms.GroupBox()
        Me.DURATION = New System.Windows.Forms.RadioButton()
        Me.AMOUNT = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.MODIFY_OPTION.SuspendLayout()
        Me.SuspendLayout()
        '
        'WELFARE_ID
        '
        Me.WELFARE_ID.AutoSize = True
        Me.WELFARE_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WELFARE_ID.Location = New System.Drawing.Point(86, 99)
        Me.WELFARE_ID.Name = "WELFARE_ID"
        Me.WELFARE_ID.Size = New System.Drawing.Size(83, 13)
        Me.WELFARE_ID.TabIndex = 0
        Me.WELFARE_ID.Text = "WELFARE ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(278, 91)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(377, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'MODIFY_OPTION
        '
        Me.MODIFY_OPTION.BackColor = System.Drawing.Color.Transparent
        Me.MODIFY_OPTION.Controls.Add(Me.DURATION)
        Me.MODIFY_OPTION.Controls.Add(Me.AMOUNT)
        Me.MODIFY_OPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY_OPTION.Location = New System.Drawing.Point(89, 198)
        Me.MODIFY_OPTION.Name = "MODIFY_OPTION"
        Me.MODIFY_OPTION.Size = New System.Drawing.Size(136, 182)
        Me.MODIFY_OPTION.TabIndex = 2
        Me.MODIFY_OPTION.TabStop = False
        Me.MODIFY_OPTION.Text = "MODIFY OPTION"
        '
        'DURATION
        '
        Me.DURATION.AutoSize = True
        Me.DURATION.BackColor = System.Drawing.Color.White
        Me.DURATION.Location = New System.Drawing.Point(8, 130)
        Me.DURATION.Name = "DURATION"
        Me.DURATION.Size = New System.Drawing.Size(90, 17)
        Me.DURATION.TabIndex = 2
        Me.DURATION.TabStop = True
        Me.DURATION.Text = "DURATION"
        Me.DURATION.UseVisualStyleBackColor = False
        '
        'AMOUNT
        '
        Me.AMOUNT.AutoSize = True
        Me.AMOUNT.BackColor = System.Drawing.Color.White
        Me.AMOUNT.Location = New System.Drawing.Point(8, 59)
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.Size = New System.Drawing.Size(78, 17)
        Me.AMOUNT.TabIndex = 1
        Me.AMOUNT.TabStop = True
        Me.AMOUNT.Text = "AMOUNT"
        Me.AMOUNT.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(278, 224)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(377, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(410, 331)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(91, 34)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifyWELFARE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 497)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MODIFY_OPTION)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.WELFARE_ID)
        Me.Name = "ModifyWELFARE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyWELFARE"
        Me.MODIFY_OPTION.ResumeLayout(False)
        Me.MODIFY_OPTION.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WELFARE_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MODIFY_OPTION As GroupBox
    Friend WithEvents DURATION As RadioButton
    Friend WithEvents AMOUNT As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
