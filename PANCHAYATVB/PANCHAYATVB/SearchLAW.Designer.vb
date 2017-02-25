<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchLAW
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
        Me.SEARCH = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LAW_NUMBER = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEARCH
        '
        Me.SEARCH.Location = New System.Drawing.Point(348, 172)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(83, 30)
        Me.SEARCH.TabIndex = 0
        Me.SEARCH.Text = "SEARCH"
        Me.SEARCH.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(716, 249)
        Me.DataGridView1.TabIndex = 1
        '
        'LAW_NUMBER
        '
        Me.LAW_NUMBER.AutoSize = True
        Me.LAW_NUMBER.Location = New System.Drawing.Point(105, 110)
        Me.LAW_NUMBER.Name = "LAW_NUMBER"
        Me.LAW_NUMBER.Size = New System.Drawing.Size(81, 13)
        Me.LAW_NUMBER.TabIndex = 2
        Me.LAW_NUMBER.Text = "LAW NUMBER"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(269, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(429, 20)
        Me.TextBox1.TabIndex = 3
        '
        'SearchLAW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.images__8_
        Me.ClientSize = New System.Drawing.Size(766, 498)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LAW_NUMBER)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SEARCH)
        Me.Name = "SearchLAW"
        Me.Text = "SearchLAW"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SEARCH As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LAW_NUMBER As Label
    Friend WithEvents TextBox1 As TextBox
End Class
