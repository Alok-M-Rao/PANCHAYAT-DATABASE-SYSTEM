Imports System.Data.OleDb
Public Class InsertWORK
    Private Sub InsertWORK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DPID As String = Trim(ComboBox1.Text)
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

        Try
            Dim PUID As String = Trim(ComboBox2.Text)
            Dim adapt1 As OleDbDataAdapter
            Dim dt1 As DataTable

            adapt1 = New OleDbDataAdapter("Select UID from CITIZEN", con)
            dt1 = New DataTable
            adapt1.Fill(dt1)
            ComboBox2.DataSource = dt1
            ComboBox2.DisplayMember = "UID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click
        Dim WorkID As String = Trim(TextBox1.Text)
        Dim DPID As String = Trim(ComboBox1.Text)
        Dim PUID As String = Trim(ComboBox2.Text)

        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into WORKS_ON values ('" & WorkID & "' , " & DPID & " , " & PUID & ")"

            com.ExecuteNonQuery()
            MsgBox("INSERTED!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class