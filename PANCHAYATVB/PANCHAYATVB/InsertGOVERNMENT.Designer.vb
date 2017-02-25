<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertGOVERNMENT
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
        Me.STATE_NAME = New System.Windows.Forms.Label()
        Me.CHIEF_MINISTER = New System.Windows.Forms.Label()
        Me.GOVERNOR = New System.Windows.Forms.Label()
        Me.GOVERNMENT_ID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'STATE_NAME
        '
        Me.STATE_NAME.AutoSize = True
        Me.STATE_NAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STATE_NAME.Location = New System.Drawing.Point(77, 63)
        Me.STATE_NAME.Name = "STATE_NAME"
        Me.STATE_NAME.Size = New System.Drawing.Size(86, 13)
        Me.STATE_NAME.TabIndex = 0
        Me.STATE_NAME.Text = "STATE NAME"
        '
        'CHIEF_MINISTER
        '
        Me.CHIEF_MINISTER.AutoSize = True
        Me.CHIEF_MINISTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHIEF_MINISTER.Location = New System.Drawing.Point(77, 133)
        Me.CHIEF_MINISTER.Name = "CHIEF_MINISTER"
        Me.CHIEF_MINISTER.Size = New System.Drawing.Size(107, 13)
        Me.CHIEF_MINISTER.TabIndex = 1
        Me.CHIEF_MINISTER.Text = "CHIEF MINISTER"
        '
        'GOVERNOR
        '
        Me.GOVERNOR.AutoSize = True
        Me.GOVERNOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOVERNOR.Location = New System.Drawing.Point(77, 198)
        Me.GOVERNOR.Name = "GOVERNOR"
        Me.GOVERNOR.Size = New System.Drawing.Size(77, 13)
        Me.GOVERNOR.TabIndex = 2
        Me.GOVERNOR.Text = "GOVERNOR"
        '
        'GOVERNMENT_ID
        '
        Me.GOVERNMENT_ID.AutoSize = True
        Me.GOVERNMENT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GOVERNMENT_ID.Location = New System.Drawing.Point(77, 266)
        Me.GOVERNMENT_ID.Name = "GOVERNMENT_ID"
        Me.GOVERNMENT_ID.Size = New System.Drawing.Size(111, 13)
        Me.GOVERNMENT_ID.TabIndex = 5
        Me.GOVERNMENT_ID.Text = "GOVERNMENT ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(316, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(316, 126)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(236, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(316, 191)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(236, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(316, 259)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(236, 20)
        Me.TextBox6.TabIndex = 11
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(280, 352)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(85, 29)
        Me.INSERT.TabIndex = 12
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'InsertGOVERNMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.images__7_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(688, 437)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GOVERNMENT_ID)
        Me.Controls.Add(Me.GOVERNOR)
        Me.Controls.Add(Me.CHIEF_MINISTER)
        Me.Controls.Add(Me.STATE_NAME)
        Me.Name = "InsertGOVERNMENT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertGOVERNMENT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents STATE_NAME As Label
    Friend WithEvents CHIEF_MINISTER As Label
    Friend WithEvents GOVERNOR As Label
    Friend WithEvents GOVERNMENT_ID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents INSERT As Button
End Class
