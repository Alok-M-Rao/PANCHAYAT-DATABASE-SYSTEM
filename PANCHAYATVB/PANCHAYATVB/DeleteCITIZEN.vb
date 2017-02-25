Imports System.Data.OleDb
Public Class DeleteCITIZEN
    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim UID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from CITIZEN where UID = '" & UID & "' "
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

    Private Sub DeleteCITIZEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim UID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select UID from CITIZEN", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "UID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class