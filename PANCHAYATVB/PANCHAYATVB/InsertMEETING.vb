Imports System.Data.OleDb
Public Class InsertMEETING
    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim MID As String = Trim(TextBox1.Text)

        If MID = "" Then
            MsgBox("Enter a MEETING ID!")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If


        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into MEETING values ( '" & MID & "', '" & DateTimePicker1.Text & "')"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class