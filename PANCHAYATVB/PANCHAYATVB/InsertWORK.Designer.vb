<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertWORK
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
        Me.WORKER_UID = New System.Windows.Forms.Label()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.WORKER_ID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PROJECT_ID
        '
        Me.PROJECT_ID.AutoSize = True
        Me.PROJECT_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PROJECT_ID.Location = New System.Drawing.Point(73, 192)
        Me.PROJECT_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PROJECT_ID.Name = "PROJECT_ID"
        Me.PROJECT_ID.Size = New System.Drawing.Size(97, 16)
        Me.PROJECT_ID.TabIndex = 0
        Me.PROJECT_ID.Text = "PROJECT ID"
        '
        'WORKER_UID
        '
        Me.WORKER_UID.AutoSize = True
        Me.WORKER_UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WORKER_UID.Location = New System.Drawing.Point(73, 283)
        Me.WORKER_UID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WORKER_UID.Name = "WORKER_UID"
        Me.WORKER_UID.Size = New System.Drawing.Size(104, 16)
        Me.WORKER_UID.TabIndex = 1
        Me.WORKER_UID.Text = "WORKER UID"
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(332, 357)
        Me.INSERT.Margin = New System.Windows.Forms.Padding(4)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(140, 41)
        Me.INSERT.TabIndex = 2
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(269, 184)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(360, 24)
        Me.ComboBox1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(269, 275)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(360, 24)
        Me.ComboBox2.TabIndex = 4
        '
        'WORKER_ID
        '
        Me.WORKER_ID.AutoSize = True
        Me.WORKER_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WORKER_ID.Location = New System.Drawing.Point(73, 106)
        Me.WORKER_ID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WORKER_ID.Name = "WORKER_ID"
        Me.WORKER_ID.Size = New System.Drawing.Size(93, 16)
        Me.WORKER_ID.TabIndex = 5
        Me.WORKER_ID.Text = "WORKER ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(269, 100)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(360, 22)
        Me.TextBox1.TabIndex = 6
        '
        'InsertWORK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(725, 484)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WORKER_ID)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.WORKER_UID)
        Me.Controls.Add(Me.PROJECT_ID)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "InsertWORK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertWORK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PROJECT_ID As Label
    Friend WithEvents WORKER_UID As Label
    Friend WithEvents INSERT As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents WORKER_ID As Label
    Friend WithEvents TextBox1 As TextBox
End Class
