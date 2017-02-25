Imports System.Data.OleDb
Public Class DeleteSARPANCH
    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim SID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from SARPANCH where SarpanchID = '" & SID & "' "
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

    Private Sub DeleteSARPANCH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim SID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select SarpanchID from SARPANCH", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "SarpanchID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class