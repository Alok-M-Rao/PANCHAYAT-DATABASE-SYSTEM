<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertMEETING
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
        Me.MEETING_ID = New System.Windows.Forms.Label()
        Me.TIME = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(256, 299)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(103, 38)
        Me.INSERT.TabIndex = 0
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'MEETING_ID
        '
        Me.MEETING_ID.AutoSize = True
        Me.MEETING_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEETING_ID.Location = New System.Drawing.Point(80, 80)
        Me.MEETING_ID.Name = "MEETING_ID"
        Me.MEETING_ID.Size = New System.Drawing.Size(80, 13)
        Me.MEETING_ID.TabIndex = 1
        Me.MEETING_ID.Text = "MEETING ID"
        '
        'TIME
        '
        Me.TIME.AutoSize = True
        Me.TIME.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIME.Location = New System.Drawing.Point(80, 177)
        Me.TIME.Name = "TIME"
        Me.TIME.Size = New System.Drawing.Size(37, 13)
        Me.TIME.TabIndex = 2
        Me.TIME.Text = "TIME"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(237, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 20)
        Me.TextBox1.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(237, 170)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(259, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'InsertMEETING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 447)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TIME)
        Me.Controls.Add(Me.MEETING_ID)
        Me.Controls.Add(Me.INSERT)
        Me.Name = "InsertMEETING"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertMEETING"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INSERT As Button
    Friend WithEvents MEETING_ID As Label
    Friend WithEvents TIME As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
