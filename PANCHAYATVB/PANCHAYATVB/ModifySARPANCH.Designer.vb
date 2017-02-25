<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifySARPANCH
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
        Me.SARPANCH_ID = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SALARY = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MODIFY = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SARPANCH_ID
        '
        Me.SARPANCH_ID.AutoSize = True
        Me.SARPANCH_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARPANCH_ID.Location = New System.Drawing.Point(79, 103)
        Me.SARPANCH_ID.Name = "SARPANCH_ID"
        Me.SARPANCH_ID.Size = New System.Drawing.Size(91, 13)
        Me.SARPANCH_ID.TabIndex = 0
        Me.SARPANCH_ID.Text = "SARPANCH ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(284, 95)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(352, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'SALARY
        '
        Me.SALARY.AutoSize = True
        Me.SALARY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALARY.Location = New System.Drawing.Point(79, 211)
        Me.SALARY.Name = "SALARY"
        Me.SALARY.Size = New System.Drawing.Size(55, 13)
        Me.SALARY.TabIndex = 2
        Me.SALARY.Text = "SALARY"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(284, 204)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 20)
        Me.TextBox1.TabIndex = 3
        '
        'MODIFY
        '
        Me.MODIFY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MODIFY.Location = New System.Drawing.Point(354, 307)
        Me.MODIFY.Name = "MODIFY"
        Me.MODIFY.Size = New System.Drawing.Size(93, 32)
        Me.MODIFY.TabIndex = 4
        Me.MODIFY.Text = "MODIFY"
        Me.MODIFY.UseVisualStyleBackColor = True
        '
        'ModifySARPANCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.nirman_village
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 488)
        Me.Controls.Add(Me.MODIFY)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SALARY)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.SARPANCH_ID)
        Me.Name = "ModifySARPANCH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifySARPANCH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SARPANCH_ID As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SALARY As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MODIFY As Button
End Class
