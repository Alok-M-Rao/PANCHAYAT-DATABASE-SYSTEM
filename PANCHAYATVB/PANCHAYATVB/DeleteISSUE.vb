Imports System.Data.OleDb
Public Class DeleteISSUE
    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim IID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from ISSUE where IID = '" & IID & "' "
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

    Private Sub DeleteISSUE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim IID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select IID from ISSUE", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "IID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class