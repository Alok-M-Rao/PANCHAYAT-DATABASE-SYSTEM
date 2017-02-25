Imports System.Data.OleDb
Public Class ModifyPANCHAYAT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MODIFY.Click

        Dim VNo As Integer = Val(ComboBox1.Text)
        Dim query As String
        Dim modstring As String = Trim(TextBox1.Text)


        If VILLAGE_NAME.Checked = True Then
            query = "Update PANCHAYAT set VillageName= '" & modstring & "' where VNo = " & VNo & " "
        ElseIf DISTRICT_NAME.Checked = True Then
            query = "Update PANCHAYAT set District= '" & modstring & "' where Vno = " & VNo & " "
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

    Private Sub ModifyPANCHAYAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim VNo As Integer = Val(ComboBox1.Text)
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
End Class