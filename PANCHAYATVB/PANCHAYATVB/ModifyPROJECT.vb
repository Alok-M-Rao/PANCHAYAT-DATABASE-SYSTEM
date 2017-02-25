Imports System.Data.OleDb
Public Class ModifyPROJECT
    Private Sub ModifyPROJECT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim PID As String = Trim(ComboBox1.Text)
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

    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim PID As String = Trim(ComboBox1.Text)
        Dim query As String
        Dim modstring As String = Trim(TextBox1.Text)


        If LEAD_ENGINEER.Checked = True Then
            query = "Update DEVELOPMENT_PROJECT set LeadEngineer= '" & modstring & "' where PID = '" & PID & "' "
        ElseIf FUNDING.Checked = True Then
            query = "Update DEVELOPMENT_PROJECT set Funding= '" & modstring & "' where PID = '" & PID & "' "
        ElseIf LAND_ALLOTED.Checked = True Then
            query = "Update DEVELOPMENT_PROJECT set LandAlloted= '" & modstring & "' where PID ='" & PID & "' "
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