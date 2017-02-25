Imports System.Data.OleDb
Module Connect
    Public con As OleDbConnection
    Public Function dbconnect()
        Try
            con = New OleDbConnection("provider=sqloledb;server=ALOK;database=PANCHAYAT;Integrated Security=SSPI")
            con.Open()
            MsgBox("Connected!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function
End Module
