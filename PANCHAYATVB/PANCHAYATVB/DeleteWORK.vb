﻿Imports System.Data.OleDb
Public Class DeleteWORK
    Private Sub DeleteWORK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim WID As String = Trim(ComboBox1.Text)
            Dim adapt As OleDbDataAdapter
            Dim dt As DataTable

            adapt = New OleDbDataAdapter("Select WorkID from WORKS_ON", con)
            dt = New DataTable
            adapt.Fill(dt)
            ComboBox1.DataSource = dt
            ComboBox1.DisplayMember = "WorkID"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETE.Click

        Dim WID As String = Trim(ComboBox1.Text)

        Dim query As String = "Delete  from WORKS_ON where WorkID = '" & WID & "' "
        Dim com As OleDbCommand
        com = New OleDbCommand

        Try
            com.Connection = con
            com.CommandText = query
            com.ExecuteNonQuery()
            MsgBox("DELETED!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class