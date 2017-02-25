Imports System.Data.OleDb
Public Class CITIZENLogin
    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click

        Dim user As Boolean = False
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from CITIZEN Where UID= '" & TextBox1.Text & "' and DOB= '" & DateTimePicker1.Text & "'", con)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            user = True
        End While

        If user = True Then
            MsgBox("Login Successful!")
            MenuStrip1.Enabled = True
            user = False
        Else
            MsgBox("Wrong Credentials!")
        End If

    End Sub

    Private Sub CITIZENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem.Click
        ModifyCITIZEN.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem1.Click
        ViewCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem.Click
        ViewMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem.Click
        ViewSARPANCH.Show()
    End Sub

    Private Sub PANCHAYATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem.Click
        ViewPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem.Click
        ViewGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem.Click
        ViewSECRETARY.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem.Click
        ViewMEETING.Show()
    End Sub

    Private Sub LAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem.Click
        ViewLAW.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem.Click
        ViewPROJECT.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem2.Click
        SearchCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem1.Click
        SearchMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem1.Click
        SearchSARPANCH.Show()
    End Sub

    Private Sub PANCHAYATToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem1.Click
        SearchPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem1.Click
        SearchGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem1.Click
        SearchSECRETARY.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem1.Click
        SearchMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem.Click
        SearchISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem1.Click
        SearchLAW.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem1.Click
        SearchPROJECT.Show()
    End Sub
End Class