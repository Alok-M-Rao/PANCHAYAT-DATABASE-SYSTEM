<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.ADMIN_LOGIN = New System.Windows.Forms.Button()
        Me.SECRETARY_LOGIN = New System.Windows.Forms.Button()
        Me.SARPANCH_LOGIN = New System.Windows.Forms.Button()
        Me.CITIZEN_LOGIN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ADMIN_LOGIN
        '
        Me.ADMIN_LOGIN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ADMIN_LOGIN.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADMIN_LOGIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ADMIN_LOGIN.Location = New System.Drawing.Point(86, 143)
        Me.ADMIN_LOGIN.Name = "ADMIN_LOGIN"
        Me.ADMIN_LOGIN.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ADMIN_LOGIN.Size = New System.Drawing.Size(135, 58)
        Me.ADMIN_LOGIN.TabIndex = 0
        Me.ADMIN_LOGIN.Text = "ADMIN LOGIN"
        Me.ADMIN_LOGIN.UseVisualStyleBackColor = False
        '
        'SECRETARY_LOGIN
        '
        Me.SECRETARY_LOGIN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SECRETARY_LOGIN.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SECRETARY_LOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SECRETARY_LOGIN.Location = New System.Drawing.Point(485, 143)
        Me.SECRETARY_LOGIN.Name = "SECRETARY_LOGIN"
        Me.SECRETARY_LOGIN.Size = New System.Drawing.Size(135, 58)
        Me.SECRETARY_LOGIN.TabIndex = 1
        Me.SECRETARY_LOGIN.Text = "SECRETARY LOGIN"
        Me.SECRETARY_LOGIN.UseVisualStyleBackColor = False
        '
        'SARPANCH_LOGIN
        '
        Me.SARPANCH_LOGIN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SARPANCH_LOGIN.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SARPANCH_LOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SARPANCH_LOGIN.Location = New System.Drawing.Point(86, 289)
        Me.SARPANCH_LOGIN.Name = "SARPANCH_LOGIN"
        Me.SARPANCH_LOGIN.Size = New System.Drawing.Size(135, 58)
        Me.SARPANCH_LOGIN.TabIndex = 2
        Me.SARPANCH_LOGIN.Text = "SARPANCH LOGIN"
        Me.SARPANCH_LOGIN.UseVisualStyleBackColor = False
        '
        'CITIZEN_LOGIN
        '
        Me.CITIZEN_LOGIN.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CITIZEN_LOGIN.Font = New System.Drawing.Font("Baskerville Old Face", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CITIZEN_LOGIN.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CITIZEN_LOGIN.Location = New System.Drawing.Point(485, 289)
        Me.CITIZEN_LOGIN.Name = "CITIZEN_LOGIN"
        Me.CITIZEN_LOGIN.Size = New System.Drawing.Size(135, 58)
        Me.CITIZEN_LOGIN.TabIndex = 3
        Me.CITIZEN_LOGIN.Text = "CITIZEN LOGIN"
        Me.CITIZEN_LOGIN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Perpetua Titling MT", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PANCHAYAT DATABASE SYSTEM"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PANCHAYATVB.My.Resources.Resources.unnamed__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(751, 504)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CITIZEN_LOGIN)
        Me.Controls.Add(Me.SARPANCH_LOGIN)
        Me.Controls.Add(Me.SECRETARY_LOGIN)
        Me.Controls.Add(Me.ADMIN_LOGIN)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ADMIN_LOGIN As Button
    Friend WithEvents SECRETARY_LOGIN As Button
    Friend WithEvents SARPANCH_LOGIN As Button
    Friend WithEvents CITIZEN_LOGIN As Button
    Friend WithEvents Label1 As Label
End Class
