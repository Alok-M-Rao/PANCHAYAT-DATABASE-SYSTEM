<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertLAW
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
        Me.INSERT = New System.Windows.Forms.Button()
        Me.LAW_NUMBER = New System.Windows.Forms.Label()
        Me.DESCRIPTION = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(306, 367)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(96, 36)
        Me.INSERT.TabIndex = 0
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'LAW_NUMBER
        '
        Me.LAW_NUMBER.AutoSize = True
        Me.LAW_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAW_NUMBER.Location = New System.Drawing.Point(112, 116)
        Me.LAW_NUMBER.Name = "LAW_NUMBER"
        Me.LAW_NUMBER.Size = New System.Drawing.Size(91, 13)
        Me.LAW_NUMBER.TabIndex = 1
        Me.LAW_NUMBER.Text = "LAW NUMBER"
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.AutoSize = True
        Me.DESCRIPTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DESCRIPTION.Location = New System.Drawing.Point(112, 236)
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.Size = New System.Drawing.Size(91, 13)
        Me.DESCRIPTION.TabIndex = 2
        Me.DESCRIPTION.Text = "DESCRIPTION"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(302, 109)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(302, 229)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 4
        '
        'InsertLAW
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 486)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DESCRIPTION)
        Me.Controls.Add(Me.LAW_NUMBER)
        Me.Controls.Add(Me.INSERT)
        Me.Name = "InsertLAW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertLAW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INSERT As Button
    Friend WithEvents LAW_NUMBER As Label
    Friend WithEvents DESCRIPTION As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
