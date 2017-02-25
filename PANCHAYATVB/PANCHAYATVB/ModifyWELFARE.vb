Imports System.Data.OleDb
Public Class ModifyWELFARE
    Private Sub ModifyWELFARE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim WID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select WID from WELFARE", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "WID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim WID As String = Trim(ComboBox1.Text)
        Dim query As String
        Dim modstring As String = Trim(TextBox1.Text)


        If AMOUNT.Checked = True Then
            query = "Update WELFARE set Amount= '" & modstring & "' where WID = '" & WID & "' "
        ElseIf DURATION.Checked = True Then
            query = "Update WELFARE set Duration= '" & modstring & "' where WID = '" & WID & "' "
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