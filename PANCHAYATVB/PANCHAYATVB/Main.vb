Public Class Main
    Private Sub ADMIN_LOGIN_Click(sender As Object, e As EventArgs) Handles ADMIN_LOGIN.Click
        ADMINLogin.Show()
        Me.Hide()
    End Sub

    Private Sub SECRETARY_LOGIN_Click(sender As Object, e As EventArgs) Handles SECRETARY_LOGIN.Click
        SECRETARYLogin.Show()
        Me.Hide()
    End Sub

    Private Sub SARPANCH_LOGIN_Click(sender As Object, e As EventArgs) Handles SARPANCH_LOGIN.Click
        SARPANCHLogin.Show()
        Me.Hide()
    End Sub

    Private Sub CITIZEN_LOGIN_Click(sender As Object, e As EventArgs) Handles CITIZEN_LOGIN.Click
        CITIZENLogin.Show()
        Me.Hide()
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconnect()
    End Sub
End Class