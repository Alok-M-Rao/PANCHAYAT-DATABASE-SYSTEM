Imports System.Data.OleDb
Public Class DeleteSECRETARY
    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim SID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from SECRETARY where SecretaryID = '" & SID & "' "
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

    Private Sub DeleteSECRETARY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim SID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select SecretaryID from SECRETARY", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "SecretaryID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class