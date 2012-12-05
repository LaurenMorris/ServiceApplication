Imports BusinessObjects
Public Class frmTechnician
    Dim WithEvents tl As New TechnicianList
    Private Sub frmTechnician_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        tl = tl.GetAll
        Me.dgvTechnician.DataSource = tl.List
    End Sub

    Private Sub tl_evtIsSavable(ByVal savable As Boolean) Handles tl.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub

    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click

        Try
            If tl.IsSavable = True Then
                tl = tl.Save
            End If
            Me.dgvTechnician.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvTechnician_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvTechnician.DataError

    End Sub

    Private Sub dgvTechnician_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvTechnician.KeyDown
        Try
            Dim t As Technician = dgvTechnician.SelectedRows(0).DataBoundItem
            t.Deleted = True
            If t.IsSavable Then
                t.Save()
                dgvTechnician.Rows.RemoveAt(dgvTechnician.SelectedRows(0).Index)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class