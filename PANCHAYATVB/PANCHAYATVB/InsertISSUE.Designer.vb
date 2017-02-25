<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertISSUE
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
        Me.ISSUE_ID = New System.Windows.Forms.Label()
        Me.ISSUE_UID = New System.Windows.Forms.Label()
        Me.ISSUE_TYPE = New System.Windows.Forms.Label()
        Me.MEETING_ID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(301, 378)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(101, 36)
        Me.INSERT.TabIndex = 0
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'ISSUE_ID
        '
        Me.ISSUE_ID.AutoSize = True
        Me.ISSUE_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSUE_ID.Location = New System.Drawing.Point(84, 65)
        Me.ISSUE_ID.Name = "ISSUE_ID"
        Me.ISSUE_ID.Size = New System.Drawing.Size(61, 13)
        Me.ISSUE_ID.TabIndex = 1
        Me.ISSUE_ID.Text = "ISSUE ID"
        '
        'ISSUE_UID
        '
        Me.ISSUE_UID.AutoSize = True
        Me.ISSUE_UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSUE_UID.Location = New System.Drawing.Point(84, 140)
        Me.ISSUE_UID.Name = "ISSUE_UID"
        Me.ISSUE_UID.Size = New System.Drawing.Size(70, 13)
        Me.ISSUE_UID.TabIndex = 2
        Me.ISSUE_UID.Text = "ISSUE UID"
        '
        'ISSUE_TYPE
        '
        Me.ISSUE_TYPE.AutoSize = True
        Me.ISSUE_TYPE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSUE_TYPE.Location = New System.Drawing.Point(84, 213)
        Me.ISSUE_TYPE.Name = "ISSUE_TYPE"
        Me.ISSUE_TYPE.Size = New System.Drawing.Size(80, 13)
        Me.ISSUE_TYPE.TabIndex = 3
        Me.ISSUE_TYPE.Text = "ISSUE TYPE"
        '
        'MEETING_ID
        '
        Me.MEETING_ID.AutoSize = True
        Me.MEETING_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEETING_ID.Location = New System.Drawing.Point(84, 291)
        Me.MEETING_ID.Name = "MEETING_ID"
        Me.MEETING_ID.Size = New System.Drawing.Size(80, 13)
        Me.MEETING_ID.TabIndex = 4
        Me.MEETING_ID.Text = "MEETING ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(326, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(297, 20)
        Me.TextBox1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(326, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(297, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(326, 283)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(297, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(326, 213)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(297, 21)
        Me.ComboBox3.TabIndex = 9
        '
        'InsertISSUE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(763, 491)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MEETING_ID)
        Me.Controls.Add(Me.ISSUE_TYPE)
        Me.Controls.Add(Me.ISSUE_UID)
        Me.Controls.Add(Me.ISSUE_ID)
        Me.Controls.Add(Me.INSERT)
        Me.Name = "InsertISSUE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertISSUE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INSERT As Button
    Friend WithEvents ISSUE_ID As Label
    Friend WithEvents ISSUE_UID As Label
    Friend WithEvents ISSUE_TYPE As Label
    Friend WithEvents MEETING_ID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
