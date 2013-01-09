Public Class frmMain

    Private Sub btnCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()

    End Sub

    Private Sub btnEquipment_Click(sender As System.Object, e As System.EventArgs) Handles btnEquipment.Click
        frmEquipment.Show()

    End Sub

    Private Sub btnTech_Click(sender As System.Object, e As System.EventArgs) Handles btnTech.Click
        frmTechnician.Show()

    End Sub

    Private Sub btnManufacturer_Click(sender As System.Object, e As System.EventArgs) Handles btnManufacturer.Click
        frmManufacturer.Show()

    End Sub

    Private Sub btnParts_Click(sender As System.Object, e As System.EventArgs) Handles btnParts.Click
        frmParts.Show()

    End Sub

    Private Sub btnWorkorder_Click(sender As System.Object, e As System.EventArgs) Handles btnWorkorder.Click
        panelWorkorder.Visible = True

    End Sub

    Private Sub btnNewWorkorder_Click(sender As System.Object, e As System.EventArgs) Handles btnNewWorkorder.Click
        frmWorkorderNew.Show()
    End Sub


    Private Sub btnEditWorkorder_Click(sender As System.Object, e As System.EventArgs) Handles btnEditWorkorder.Click
        frmWorkorderEdit.Show()

    End Sub

    Private Sub btnMain_Click(sender As System.Object, e As System.EventArgs) Handles btnMain.Click
        panelWorkorder.Visible = False

    End Sub
End Class