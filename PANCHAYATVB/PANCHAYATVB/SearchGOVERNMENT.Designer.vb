﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchGOVERNMENT
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
        Me.GOVERNMENT_ID = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SEARCH = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GOVERNMENT_ID
        '
        Me.GOVERNMENT_ID.AutoSize = True
        Me.GOVERNMENT_ID.Location = New System.Drawing.Point(65, 91)
        Me.GOVERNMENT_ID.Name = "GOVERNMENT_ID"
        Me.GOVERNMENT_ID.Size = New System.Drawing.Size(98, 13)
        Me.GOVERNMENT_ID.TabIndex = 0
        Me.GOVERNMENT_ID.Text = "GOVERNMENT ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(357, 20)
        Me.TextBox1.TabIndex = 1
        '
        'SEARCH
        '
        Me.SEARCH.Location = New System.Drawing.Point(313, 141)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(78, 28)
        Me.SEARCH.TabIndex = 2
        Me.SEARCH.Text = "SEARCH"
        Me.SEARCH.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 211)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(694, 268)
        Me.DataGridView1.TabIndex = 3
        '
        'SearchGOVERNMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.images__8_
        Me.ClientSize = New System.Drawing.Size(739, 491)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SEARCH)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GOVERNMENT_ID)
        Me.Name = "SearchGOVERNMENT"
        Me.Text = "SearchGOVERNMENT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GOVERNMENT_ID As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SEARCH As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
