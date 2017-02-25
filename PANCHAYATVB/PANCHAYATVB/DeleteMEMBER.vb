Imports System.Data.OleDb
Public Class DeleteMEMBER
    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim MID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from MEMBER where MemeberID = '" & MID & "' "
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

    Private Sub DeleteMEMBER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim MID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select MemeberID from MEMBER", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "MemberID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class