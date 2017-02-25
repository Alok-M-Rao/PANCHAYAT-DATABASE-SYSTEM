Imports System.Data.OleDb
Public Class ViewPANCHAYAT
    Private Sub ViewPANCHAYAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter("Select * from PANCHAYAT", con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class