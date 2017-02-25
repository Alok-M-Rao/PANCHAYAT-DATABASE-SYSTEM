Imports System.Data.OleDb
Public Class SARPANCHLogin
    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click

        Dim user As Boolean = False
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from SARPANCH Where SarpanchID= '" & TextBox1.Text & "' and SUID= '" & TextBox2.Text & "'", con)
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

    Private Sub MEETINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem.Click
        InsertMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem.Click
        InsertISSUE.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem.Click
        InsertWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem.Click
        InsertPROJECT.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem1.Click
        ModifyMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem1.Click
        ModifyISSUE.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem1.Click
        ModifyWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem1.Click
        ModifyPROJECT.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem.Click
        ViewCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem.Click
        ViewMEMBER.Show()
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

    Private Sub MEETINGToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem2.Click
        ViewMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem2.Click
        ViewISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem.Click
        ViewLAW.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem2.Click
        ViewWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem2.Click
        ViewPROJECT.Show()
    End Sub

    Private Sub WORKSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WORKSONToolStripMenuItem.Click
        ViewWORKS.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem1.Click
        SearchCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem1.Click
        SearchMEMBER.Show()
    End Sub

    Private Sub PANCHAYATToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem1.Click
        SearchPANCHAYAT.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem3.Click
        SearchMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem3.Click
        SearchISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem1.Click
        SearchLAW.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem3.Click
        SearchWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem3.Click
        SearchPROJECT.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem4.Click
        DeleteMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem4.Click
        DeleteISSUE.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem4.Click
        DeleteWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem4.Click
        DeletePROJECT.Show()
    End Sub

End Class