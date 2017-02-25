Imports System.Data.OleDb
Public Class ModifyMEETING
    Private Sub ModifyMEETING_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim MID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select MID from MEETING", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "MID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim MID As String = Trim(ComboBox1.Text)
        Dim query As String

        query = "Update MEETING set Info= '" & DateTimePicker1.Text & "' where MID = '" & MID & "' "


        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = query
            com.ExecuteNonQuery()
            MsgBox("MODIFIED!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class