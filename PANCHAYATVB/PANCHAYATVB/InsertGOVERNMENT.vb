Imports System.Data.OleDb
Public Class InsertGOVERNMENT
    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim Sname As String = Trim(TextBox1.Text)
        Dim CM As String = Trim(TextBox2.Text)
        Dim GOV As String = Trim(TextBox3.Text)
        Dim GID As Integer = Val(TextBox6.Text)


        If Sname = "" Then
            MsgBox("Please Enter a State Name!")
            TextBox1.Focus()
            Exit Sub
        End If

        If CM = "" Then
            MsgBox("Please Enter Chief Minister!")
            TextBox2.Focus()
            Exit Sub
        End If

        If GOV = "" Then
            MsgBox("Please Enter Governor!")
            TextBox3.Focus()
            Exit Sub
        End If


        If GID = 0 Then
            MsgBox("Please Enter Government ID!")
            TextBox6.Focus()
            Exit Sub
        End If

        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into GOVERNMENT values ( '" & Sname & "', '" & CM & "', '" & GOV & "' , " & GID & ")"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub InsertGOVERNMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class