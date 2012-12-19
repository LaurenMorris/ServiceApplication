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
        frmWorkorder.Show()

    End Sub
End Class