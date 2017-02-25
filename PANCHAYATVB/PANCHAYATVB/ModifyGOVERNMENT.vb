Imports System.Data.OleDb
Public Class ModifyGOVERNMENT
    Private Sub ModifyGOVERNMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim GID As Integer = Val(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select GID from GOVERNMENT", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "GID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim GID As Integer = Val(ComboBox1.Text)
        Dim query As String
        Dim modstring As String = Trim(TextBox1.Text)


        If STATE_NAME.Checked = True Then
            query = "Update GOVERNMENT set StateName= '" & modstring & "' where GID = " & GID & " "
        ElseIf CHIEF_MINISTER.Checked = True Then
            query = "Update GOVERNMENT set ChiefMinister= '" & modstring & "' where GID = " & GID & " "
        ElseIf GOVERNOR.Checked = True Then
            query = "Update GOVERNMENT set Governor= '" & modstring & "' where GID = " & GID & " "
        End If


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