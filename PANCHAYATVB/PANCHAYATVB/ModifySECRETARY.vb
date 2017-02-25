Imports System.Data.OleDb
Public Class ModifySECRETARY
    Private Sub ModifySECRETARY_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim SID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select SecretaryID from SECRETARY", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "SecretaryID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim SID As String = Trim(ComboBox1.Text)
        Dim query As String
        Dim modstring As String = Trim(TextBox1.Text)


        If FIRST_NAME.Checked = True Then
            query = "Update SECRETARY set FName= '" & modstring & "' where SecretaryID = '" & SID & "' "
        ElseIf MIDDLE_NAME.Checked = True Then
            query = "Update SECRETARY set MName= '" & modstring & "' where SecretaryID = '" & SID & "' "
        ElseIf LAST_NAME.Checked = True Then
            query = "Update SECRETARY set LName= '" & modstring & "' where SecretaryID = '" & SID & "' "
        ElseIf PHONE.Checked = True Then
            query = "Update SECRETARY set Phone= '" & modstring & "' where SecretaryID = '" & SID & "' "
        ElseIf SALARY.Checked = True Then
            query = "Update SECRETARY set Salary= '" & modstring & "' where SecretaryID = '" & SID & "' "
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