Imports System.Data.OleDb
Public Class ModifyCITIZEN
    Private Sub ModifyCITIZEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim MUID As String = Trim(ComboBox1.Text)
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

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim UID As String = Trim(ComboBox1.Text)
        Dim query As String
        Dim modstring As String = Trim(TextBox1.Text)

        If FIRST_NAME.Checked = True Then
            query = "Update CITIZEN set Fname= '" & modstring & "' where UID = " & UID & " "
        ElseIf MIDDLE_NAME.Checked = True Then
            query = "Update CITIZEN set Mname= '" & modstring & "' where UID = " & UID & " "
        ElseIf LAST_NAME.Checked = True Then
            query = "Update CITIZEN set Lname= '" & modstring & "' where UID = " & UID & " "
        ElseIf PHONE.Checked = True Then
            query = "Update CITIZEN set Phone= " & modstring & " where UID = " & UID & " "
        ElseIf ADDRESS.Checked = True Then
            query = "Update CITIZEN set Address= '" & modstring & "' where UID = " & UID & " "
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