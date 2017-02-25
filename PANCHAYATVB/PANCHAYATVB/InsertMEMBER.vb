Imports System.Data.OleDb
Public Class InsertMEMBER
    Private Sub InsertMEMBER_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("1", "EDUCATION")
        comboSource.Add("2", "HEALTHCARE")
        comboSource.Add("3", "HOUSING")
        comboSource.Add("4", "SECURITY")
        ComboBox2.DataSource = New BindingSource(comboSource, Nothing)
        ComboBox2.DisplayMember = "Value"
        ComboBox2.ValueMember = "Key"

    End Sub

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim MemberID As String = Trim(TextBox1.Text)
        Dim MUID As String = Trim(ComboBox1.Text)
        Dim Department As String = Trim(ComboBox2.Text)
        Dim Salary As Integer = Val(TextBox3.Text)

        Dim key As String = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(ComboBox2.SelectedItem, KeyValuePair(Of String, String)).Value

        If MemberID = "" Then
            MsgBox("Please Enter a MEMBER ID!")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If

        If MemberID.Length <> 10 Then
            MsgBox("MEMBER ID should contain 10 characters")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If

        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into MEMBER values ( '" & MemberID & "', '" & MUID & "', '" & Department & "', " & Salary & ")"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class