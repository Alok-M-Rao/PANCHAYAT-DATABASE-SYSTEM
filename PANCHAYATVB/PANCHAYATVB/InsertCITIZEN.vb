Imports System.Data.OleDb
Public Class InsertCITIZEN
    Private Sub InsertCITIZEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim VNumber As Integer = Val(ComboBox1.Text)
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

        Dim Fname As String = Trim(TextBox1.Text)
        Dim Mname As String = Trim(TextBox2.Text)
        Dim Lname As String = Trim(TextBox3.Text)
        Dim UID As String = Trim(TextBox4.Text)
        Dim Sex As Char = "M"
        Dim Phone As String = Trim(TextBox5.Text)
        Dim Address As String = Trim(TextBox6.Text)
        Dim VNumber As Integer = Val(ComboBox1.Text)

        If MALE.Checked = True Then
            Sex = "M"
        Else
            Sex = "F"
        End If


        If Fname = "" Then
            MsgBox("Please Enter a Valid Name!")
            TextBox1.Focus()
            Exit Sub
        End If

        If UID = "" Then
            MsgBox("Enter your Aadhaar Number!")
            TextBox4.Focus()
            TextBox4.SelectAll()
            Exit Sub
        End If


        Dim phone_val As Integer = 1
        If IsNumeric(Phone) Then
            phone_val = 0
        End If

        If Phone.Length = 10 Then
            If phone_val = 1 Then
                MsgBox("Invalid Phone Number!")
                Exit Sub
            End If
        End If

        If Phone = "" Then
            MsgBox("Enter a Phone Number!")
            TextBox5.Focus()
            TextBox5.SelectAll()
            Exit Sub
        End If



        If Address = "" Then
            MsgBox("Please Enter a Valid Address!")
            TextBox6.Focus()
            TextBox6.SelectAll()
            Exit Sub
        End If



        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = "Insert into CITIZEN values ( '" & Fname & "', '" & Mname & "', '" & Lname & "', '" & UID & "','" & Sex & "', '" & DateTimePicker1.Text & "', " & Phone & ", '" & Address & "' , '" & VNumber & "')"

            com.ExecuteNonQuery()
            MsgBox("Inserted!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class