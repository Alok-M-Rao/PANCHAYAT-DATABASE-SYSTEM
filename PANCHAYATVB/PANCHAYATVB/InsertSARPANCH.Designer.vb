<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertSARPANCH
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
        Me.SARPANCH_UID = New System.Windows.Forms.Label()
        Me.SALARY = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.INSERT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SARPANCH_ID
        '
        Me.SARPANCH_ID.AutoSize = True
        Me.SARPANCH_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARPANCH_ID.Location = New System.Drawing.Point(60, 79)
        Me.SARPANCH_ID.Name = "SARPANCH_ID"
        Me.SARPANCH_ID.Size = New System.Drawing.Size(91, 13)
        Me.SARPANCH_ID.TabIndex = 0
        Me.SARPANCH_ID.Text = "SARPANCH ID"
        '
        'SARPANCH_UID
        '
        Me.SARPANCH_UID.AutoSize = True
        Me.SARPANCH_UID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARPANCH_UID.Location = New System.Drawing.Point(60, 171)
        Me.SARPANCH_UID.Name = "SARPANCH_UID"
        Me.SARPANCH_UID.Size = New System.Drawing.Size(100, 13)
        Me.SARPANCH_UID.TabIndex = 1
        Me.SARPANCH_UID.Text = "SARPANCH UID"
        '
        'SALARY
        '
        Me.SALARY.AutoSize = True
        Me.SALARY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALARY.Location = New System.Drawing.Point(60, 263)
        Me.SALARY.Name = "SALARY"
        Me.SALARY.Size = New System.Drawing.Size(55, 13)
        Me.SALARY.TabIndex = 2
        Me.SALARY.Text = "SALARY"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(304, 256)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(281, 20)
        Me.TextBox2.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(304, 163)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(281, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'INSERT
        '
        Me.INSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INSERT.Location = New System.Drawing.Point(264, 358)
        Me.INSERT.Name = "INSERT"
        Me.INSERT.Size = New System.Drawing.Size(124, 38)
        Me.INSERT.TabIndex = 8
        Me.INSERT.Text = "INSERT"
        Me.INSERT.UseVisualStyleBackColor = True
        '
        'InsertSARPANCH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.article_2720779_206417E200000578_758_634x475
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 477)
        Me.Controls.Add(Me.INSERT)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SALARY)
        Me.Controls.Add(Me.SARPANCH_UID)
        Me.Controls.Add(Me.SARPANCH_ID)
        Me.Name = "InsertSARPANCH"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InsertSARPANCH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SARPANCH_ID As Label
    Friend WithEvents SARPANCH_UID As Label
    Friend WithEvents SALARY As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents INSERT As Button
End Class
