Imports System.Data.OleDb

Public Class SECRETARYLogin
    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click

        Dim user As Boolean = False
        Dim cmd As OleDbCommand = New OleDbCommand("Select * from SECRETARY Where SecretaryID= '" & TextBox1.Text & "' and AUID= '" & TextBox2.Text & "'", con)
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
        InsertCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem.Click
        InsertMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem.Click
        InsertSARPANCH.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem1.Click
        ModifyCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem1.Click
        ModifyMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem1.Click
        ModifySARPANCH.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem.Click
        ModifySECRETARY.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem2.Click
        ViewCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem2.Click
        ViewMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem2.Click
        ViewSARPANCH.Show()
    End Sub

    Private Sub PANCHAYATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem.Click
        ViewPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem.Click
        ViewGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem1.Click
        ViewSECRETARY.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem.Click
        ViewMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem.Click
        ViewISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem.Click
        ViewLAW.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem.Click
        ViewWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem.Click
        ViewPROJECT.Show()
    End Sub

    Private Sub WORKSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WORKSONToolStripMenuItem.Click
        ViewWORKS.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem3.Click
        SearchCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem3.Click
        SearchMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem3.Click
        SearchSARPANCH.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem4.Click
        DeleteCITIZEN.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem4.Click
        DeleteMEMBER.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem4.Click
        DeleteSARPANCH.Show()
    End Sub
End Class