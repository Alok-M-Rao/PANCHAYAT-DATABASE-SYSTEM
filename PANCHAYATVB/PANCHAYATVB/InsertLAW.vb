Imports System.Data.OleDb
Public Class InsertLAW
    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim LNo As String = Trim(TextBox1.Text)
        Dim Info As String = Trim(TextBox2.Text)

        If LNo = "" Then
            MsgBox("Enter a Law Number!")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If


        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into LAW values ( '" & LNo & "', '" & Info & "')"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class