Imports System.Data.OleDb
Public Class InsertPANCHAYAT
    Private Sub InsertPANCHAYAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim SarID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select SarpanchID from SARPANCH", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "SarpanchID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim VNo As Integer = Val(ComboBox2.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select VillageNumber from GRAMA_SABHA", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox2.DataSource = dt
            ComboBox2.DisplayMember = "VillageNumber"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub INSERT_Click(sender As Object, e As EventArgs) Handles INSERT.Click

        Dim VillageName As String = Trim(TextBox1.Text)
        Dim DName As String = Trim(TextBox2.Text)
        Dim SarID As String = Trim(ComboBox1.Text)
        Dim VNo As Integer = Val(ComboBox2.Text)


        If VillageName = "" Then
            MsgBox("Please Enter a Village Name!")
            TextBox1.Focus()
            TextBox1.SelectAll()
            Exit Sub
        End If

        If DName = "" Then
            MsgBox("Please Enter a Taluk!")
            TextBox2.Focus()
            TextBox2.SelectAll()
            Exit Sub
        End If


        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into PANCHAYAT values ( '" & VillageName & "', '" & DName & "', '" & SarID & "' , " & VNo & ")"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class