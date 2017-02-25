Imports System.Data.OleDb
Public Class InsertSARPANCH
    Private Sub InsertSARPANCH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim SUID As String = Trim(ComboBox1.Text)
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

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim SarpanchID As String = Trim(TextBox1.Text)
        Dim SUID As String = Trim(ComboBox1.Text)
        Dim Salary As Integer = Val(TextBox2.Text)

        If SarpanchID = "" Then
            MsgBox("Please Enter a SARPANCH ID!")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If

        If SarpanchID.Length <> 10 Then
            MsgBox("SARPANCH ID should contain 10 characters")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If


        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into SARPANCH values ( '" & SarpanchID & "', '" & SUID & "', " & Salary & ")"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class