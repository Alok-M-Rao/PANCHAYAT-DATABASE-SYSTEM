Public Class ADMINLogin
    Private Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click

        If TextBox1.Text = "CS003" And TextBox2.Text = "CS016" Then
            MsgBox("LOGIN SUCCESSFUL!")
            MenuStrip2.Enabled = True
        Else
            MsgBox("LOGIN UNSUCCESSFUL!")
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

    Private Sub PANCHAYATToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem.Click
        InsertPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem.Click
        InsertGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem.Click
        InsertSECRETARY.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem.Click
        InsertMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem.Click
        InsertISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem.Click
        InsertLAW.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem.Click
        InsertWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem.Click
        InsertPROJECT.Show()
    End Sub

    Private Sub WORKSONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WORKSONToolStripMenuItem.Click
        InsertWORK.Show()
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

    Private Sub PANCHAYATToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem1.Click
        ModifyPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem1.Click
        ModifyGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem1.Click
        ModifySECRETARY.Show()
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

    Private Sub PROJECTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROJECTToolStripMenuItem.Click
        ModifyPROJECT.Show()
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

    Private Sub PANCHAYATToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem2.Click
        ViewPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem2.Click
        ViewGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem2.Click
        ViewSECRETARY.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem2.Click
        ViewMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem2.Click
        ViewISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem1.Click
        ViewLAW.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem2.Click
        ViewWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem1.Click
        ViewPROJECT.Show()
    End Sub

    Private Sub WORKSONToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WORKSONToolStripMenuItem1.Click
        ViewWORKS.Show()
    End Sub

    Private Sub CITIZENToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles CITIZENToolStripMenuItem3.Click
        SearchCITIZEN.Show()
    End Sub

    Private Sub SARPANCHToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SARPANCHToolStripMenuItem3.Click
        SearchSARPANCH.Show()
    End Sub

    Private Sub MEMBERToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MEMBERToolStripMenuItem3.Click
        SearchMEMBER.Show()
    End Sub

    Private Sub PANCHAYATToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles PANCHAYATToolStripMenuItem3.Click
        SearchPANCHAYAT.Show()
    End Sub

    Private Sub GOVERNMENTToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles GOVERNMENTToolStripMenuItem3.Click
        SearchGOVERNMENT.Show()
    End Sub

    Private Sub SECRETARYToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem3.Click
        SearchSECRETARY.Show()
    End Sub

    Private Sub MEETINGToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles MEETINGToolStripMenuItem3.Click
        SearchMEETING.Show()
    End Sub

    Private Sub ISSUEToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ISSUEToolStripMenuItem3.Click
        SearchISSUE.Show()
    End Sub

    Private Sub LAWToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LAWToolStripMenuItem2.Click
        SearchLAW.Show()
    End Sub

    Private Sub WELFAREToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles WELFAREToolStripMenuItem3.Click
        SearchWELFARE.Show()
    End Sub

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem2.Click
        SearchPROJECT.Show()
    End Sub

    Private Sub WORKSONToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles WORKSONToolStripMenuItem2.Click
        SearchWORK.Show()
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

    Private Sub SECRETARYToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles SECRETARYToolStripMenuItem4.Click
        DeleteSECRETARY.Show()
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

    Private Sub DEVELOPMENTPROJECTToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DEVELOPMENTPROJECTToolStripMenuItem3.Click
        DeletePROJECT.Show()
    End Sub

    Private Sub WORKSONToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles WORKSONToolStripMenuItem3.Click
        DeleteWORK.Show()
    End Sub

    Private Sub ADMINLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip2.Enabled = False


    End Sub

End Class