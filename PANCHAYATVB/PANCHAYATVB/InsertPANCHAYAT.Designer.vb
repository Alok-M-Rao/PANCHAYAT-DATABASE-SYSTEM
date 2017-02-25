<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertPANCHAYAT
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
        Me.VILLAGE_NAME = New System.Windows.Forms.Label()
        Me.DISTRICT_NAME = New System.Windows.Forms.Label()
        Me.SARPANCH_ID = New System.Windows.Forms.Label()
        Me.VILLAGE_NUMBER = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VILLAGE_NAME
        '
        Me.VILLAGE_NAME.AutoSize = True
        Me.VILLAGE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VILLAGE_NAME.Location = New System.Drawing.Point(79, 103)
        Me.VILLAGE_NAME.Name = "VILLAGE_NAME"
        Me.VILLAGE_NAME.Size = New System.Drawing.Size(97, 13)
        Me.VILLAGE_NAME.TabIndex = 0
        Me.VILLAGE_NAME.Text = "VILLAGE NAME"
        '
        'DISTRICT_NAME
        '
        Me.DISTRICT_NAME.AutoSize = True
        Me.DISTRICT_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISTRICT_NAME.Location = New System.Drawing.Point(79, 169)
        Me.DISTRICT_NAME.Name = "DISTRICT_NAME"
        Me.DISTRICT_NAME.Size = New System.Drawing.Size(104, 13)
        Me.DISTRICT_NAME.TabIndex = 1
        Me.DISTRICT_NAME.Text = "DISTRICT NAME"
        '
        'SARPANCH_ID
        '
        Me.SARPANCH_ID.AutoSize = True
        Me.SARPANCH_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARPANCH_ID.Location = New System.Drawing.Point(79, 230)
        Me.SARPANCH_ID.Name = "SARPANCH_ID"
        Me.SARPANCH_ID.Size = New System.Drawing.Size(91, 13)
        Me.SARPANCH_ID.TabIndex = 2
        Me.SARPANCH_ID.Text = "SARPANCH ID"
        '
        'VILLAGE_NUMBER
        '
        Me.VILLAGE_NUMBER.AutoSize = True
        Me.VILLAGE_NUMBER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VILLAGE_NUMBER.Location = New System.Drawing.Point(79, 296)
        Me.VILLAGE_NUMBER.Name = "VILLAGE_NUMBER"
        Me.VILLAGE_NUMBER.Size = New System.Drawing.Size(115, 13)
        Me.VILLAGE_NUMBER.TabIndex = 3
        Me.VILLAGE_NUMBER.Text = "VILLAGE NUMBER"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(279, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(279, 162)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(320, 20)
        Me.TextBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(279, 222)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(320, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(279, 288)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(320, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(334, 374)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(89, 34)
        Me.INSERT.TabIndex = 8
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'InsertPANCHAYAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(748, 486)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.VILLAGE_NUMBER)
        Me.Controls.Add(Me.SARPANCH_ID)
        Me.Controls.Add(Me.DISTRICT_NAME)
        Me.Controls.Add(Me.VILLAGE_NAME)
        Me.Name = "InsertPANCHAYAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertPANCHAYAT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VILLAGE_NAME As Label
    Friend WithEvents DISTRICT_NAME As Label
    Friend WithEvents SARPANCH_ID As Label
    Friend WithEvents VILLAGE_NUMBER As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents INSERT As Button
End Class
