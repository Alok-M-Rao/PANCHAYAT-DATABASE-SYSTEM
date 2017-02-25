<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertWELFARE
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
        Me.WELFARE_UID = New System.Windows.Forms.Label()
        Me.WELFARE_NAME = New System.Windows.Forms.Label()
        Me.AMOUNT = New System.Windows.Forms.Label()
        Me.DURATION = New System.Windows.Forms.Label()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'WELFARE_ID
        '
        Me.WELFARE_ID.AutoSize = True
        Me.WELFARE_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WELFARE_ID.Location = New System.Drawing.Point(81, 81)
        Me.WELFARE_ID.Name = "WELFARE_ID"
        Me.WELFARE_ID.Size = New System.Drawing.Size(83, 13)
        Me.WELFARE_ID.TabIndex = 0
        Me.WELFARE_ID.Text = "WELFARE ID"
        '
        'WELFARE_UID
        '
        Me.WELFARE_UID.AutoSize = True
        Me.WELFARE_UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WELFARE_UID.Location = New System.Drawing.Point(81, 146)
        Me.WELFARE_UID.Name = "WELFARE_UID"
        Me.WELFARE_UID.Size = New System.Drawing.Size(92, 13)
        Me.WELFARE_UID.TabIndex = 1
        Me.WELFARE_UID.Text = "WELFARE UID"
        '
        'WELFARE_NAME
        '
        Me.WELFARE_NAME.AutoSize = True
        Me.WELFARE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WELFARE_NAME.Location = New System.Drawing.Point(82, 203)
        Me.WELFARE_NAME.Name = "WELFARE_NAME"
        Me.WELFARE_NAME.Size = New System.Drawing.Size(105, 13)
        Me.WELFARE_NAME.TabIndex = 2
        Me.WELFARE_NAME.Text = "WELFARE NAME"
        '
        'AMOUNT
        '
        Me.AMOUNT.AutoSize = True
        Me.AMOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMOUNT.Location = New System.Drawing.Point(82, 260)
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.Size = New System.Drawing.Size(60, 13)
        Me.AMOUNT.TabIndex = 3
        Me.AMOUNT.Text = "AMOUNT"
        '
        'DURATION
        '
        Me.DURATION.AutoSize = True
        Me.DURATION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DURATION.Location = New System.Drawing.Point(81, 316)
        Me.DURATION.Name = "DURATION"
        Me.DURATION.Size = New System.Drawing.Size(125, 13)
        Me.DURATION.TabIndex = 4
        Me.DURATION.Text = "DURATION (YEARS)"
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(332, 392)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(84, 32)
        Me.INSERT.TabIndex = 5
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(339, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(339, 253)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(300, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(339, 309)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(300, 20)
        Me.TextBox3.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(339, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(300, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(339, 195)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(300, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'InsertWELFARE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 494)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.DURATION)
        Me.Controls.Add(Me.AMOUNT)
        Me.Controls.Add(Me.WELFARE_NAME)
        Me.Controls.Add(Me.WELFARE_UID)
        Me.Controls.Add(Me.WELFARE_ID)
        Me.Name = "InsertWELFARE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertWELFARE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WELFARE_ID As Label
    Friend WithEvents WELFARE_UID As Label
    Friend WithEvents WELFARE_NAME As Label
    Friend WithEvents AMOUNT As Label
    Friend WithEvents DURATION As Label
    Friend WithEvents INSERT As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
