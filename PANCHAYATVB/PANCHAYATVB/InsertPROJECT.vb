Imports System.Data.OleDb
Public Class InsertPROJECT
    Private Sub InsertPROJECT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim ViNum As Integer = Val(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select VillageNumber from GRAMA_SABHA", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "VillageNumber"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim PID As String = Trim(TextBox1.Text)
        Dim ViNum As Integer = Val(ComboBox1.Text)
        Dim LEName As String = Trim(TextBox2.Text)
        Dim Funding As Integer = Val(TextBox3.Text)
        Dim LA As Integer = Val(TextBox4.Text)

        If PID = "" Then
            MsgBox("Please Enter Project ID!")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If

        If LEName = "" Then
            MsgBox("Please Enter Lead ENgineer Name!")
            TextBox2.Focus()
            TextBox2.SelectAll()
            Exit Sub
        End If

        If Funding = 0 Then
            MsgBox("Please Enter Funding Amount!")
            TextBox3.Focus()
            TextBox3.SelectAll()
            Exit Sub
        End If



        If LA = 0 Then
            MsgBox("Please Enter Land Alloted!")
            TextBox4.Focus()
            TextBox4.SelectAll()
            Exit Sub
        End If



        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into DEVELOPMENT_PROJECT values ('" & PID & "' , " & ViNum & " , '" & LEName & "', " & Funding & " , " & LA & ")"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class