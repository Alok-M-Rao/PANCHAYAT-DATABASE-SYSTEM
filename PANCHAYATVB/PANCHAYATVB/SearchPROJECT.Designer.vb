<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPROJECT
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SEARCH = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROJECT_ID
        '
        Me.PROJECT_ID.AutoSize = True
        Me.PROJECT_ID.Location = New System.Drawing.Point(99, 97)
        Me.PROJECT_ID.Name = "PROJECT_ID"
        Me.PROJECT_ID.Size = New System.Drawing.Size(70, 13)
        Me.PROJECT_ID.TabIndex = 0
        Me.PROJECT_ID.Text = "PROJECT ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(257, 90)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(418, 20)
        Me.TextBox1.TabIndex = 1
        '
        'SEARCH
        '
        Me.SEARCH.Location = New System.Drawing.Point(377, 146)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(88, 28)
        Me.SEARCH.TabIndex = 2
        Me.SEARCH.Text = "SEARCH"
        Me.SEARCH.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(706, 281)
        Me.DataGridView1.TabIndex = 3
        '
        'SearchPROJECT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.images__8_
        Me.ClientSize = New System.Drawing.Size(767, 497)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SEARCH)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PROJECT_ID)
        Me.Name = "SearchPROJECT"
        Me.Text = "SearchPROJECT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PROJECT_ID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SEARCH As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
