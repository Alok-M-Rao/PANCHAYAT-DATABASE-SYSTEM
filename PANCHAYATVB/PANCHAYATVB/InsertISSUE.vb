Imports System.Data.OleDb
Public Class InsertISSUE
    Private Sub InsertISSUE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim IUID As String = Trim(ComboBox1.Text)
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

        Try
            Dim MeetID As String = Trim(ComboBox2.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select MID from MEETING", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "MID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("1", "ROBERRY")
        comboSource.Add("2", "CHILD LABOUR")
        comboSource.Add("3", "LAND DISPUTE")
        comboSource.Add("4", "HARRASMENT")
        comboSource.Add("5", "DOMESTIC VIOLENCE")
        comboSource.Add("6", "HUMAN TRAFFICKING")
        comboSource.Add("7", "PROPERTY DISPUTE")
        comboSource.Add("8", "DISCRIMINATION")
        ComboBox3.DataSource = New BindingSource(comboSource, Nothing)
        ComboBox3.DisplayMember = "Value"
        ComboBox3.ValueMember = "Key"

    End Sub

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click
        Dim IID As String = Trim(TextBox1.Text)
        Dim IUID As String = Trim(ComboBox1.Text)
        Dim IType As String = Trim(ComboBox3.Text)
        Dim MeetID As String = Trim(ComboBox2.Text)

        Dim key As String = DirectCast(ComboBox3.SelectedItem, KeyValuePair(Of String, String)).Key
        Dim value As String = DirectCast(ComboBox3.SelectedItem, KeyValuePair(Of String, String)).Value

        If IID = "" Then
            MsgBox("Please Enter ISSUE ID!")
            TextBox1.Focus()
            Exit Sub
        End If


        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into ISSUE values ('" & IID & "', '" & IUID & "', '" & IType & "', '" & MeetID & "')"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class