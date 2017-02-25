Imports System.Data.OleDb
Public Class DeletePROJECT
    Private Sub DeletePROJECT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim PID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select PID from DEVELOPMENT_PROJECT", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "PID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim PID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from DEVELOPMENT_PROJECT where PID = '" & PID & "' "
        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = query
            com.ExecuteNonQuery()
            MsgBox("DELETED!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class