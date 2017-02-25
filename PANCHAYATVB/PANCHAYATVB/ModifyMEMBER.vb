Imports System.Data.OleDb
Public Class ModifyMEMBER
    Private Sub ModifyMEMBER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim MID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select MemberID from MEMBER", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "MemberID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("1", "EDUCATION")
        comboSource.Add("2", "HEALTHCARE")
        comboSource.Add("3", "HOUSING")
        comboSource.Add("4", "SECURITY")
        ComboBox2.DataSource = New BindingSource(comboSource, Nothing)
        ComboBox2.DisplayMember = "Value"
        ComboBox2.ValueMember = "Key"

    End Sub

    Private Sub MODIFY_Click(sender As Object, e As EventArgs) Handles MODIFY.Click
        Dim MID As String = Trim(ComboBox1.Text)
        Dim query As String
        Dim modstring1 As String = Trim(ComboBox2.Text)
        Dim modstring2 As String = Trim(TextBox1.Text)

        Dim key As String = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Value

        If DEPARTMENT.Checked = True Then
            query = "Update MEMBER set Department= '" & modstring1 & "' where MemberID = '" & MID & "' "
        ElseIf SALARY.Checked = True Then
            query = "Update MEMBER set Salary= '" & modstring2 & "' where MemberID = '" & MID & "' "
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