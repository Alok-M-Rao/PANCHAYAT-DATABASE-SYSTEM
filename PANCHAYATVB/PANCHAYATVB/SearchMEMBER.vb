﻿Imports System.Data.OleDb
Public Class SearchMEMBER
    Private Sub SEARCH_Click(sender As Object, e As EventArgs) Handles SEARCH.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Enter a MEMBER ID!")
            TextBox1.Focus()
            Exit Sub
        End If

        Dim MID As String = Trim(TextBox1.Text)
        Dim query As String

        query = "Select * from MEMBER where MemberID = '" & MID & "' "

        Dim adapt As OleDbDataAdapter
        Dim dt As DataTable
        Try
            adapt = New OleDbDataAdapter(query, con)
            dt = New DataTable
            adapt.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class