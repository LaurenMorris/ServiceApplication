Imports BusinessObjects
Public Class frmLabor
    Dim WithEvents ll As New LaborList
    Private Sub frmLabor_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ll = ll.GetAll
        Me.dgvLabor.DataSource = ll.List
    End Sub

    Private Sub ll_evtIsSavable(savable As Boolean) Handles ll.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As System.EventArgs) Handles mnuSave.Click

        Try
            If ll.IsSavable = True Then
                ll = ll.Save
            End If
            Me.dgvLabor.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvLabor_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvLabor.DataError

    End Sub

    Private Sub dgvLabor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvLabor.KeyDown
        Try
            Dim l As Labor = dgvLabor.SelectedRows(0).DataBoundItem
            l.Deleted = True
            If l.IsSavable Then
                l.Save()
                dgvLabor.Rows.RemoveAt(dgvLabor.SelectedRows(0).Index)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class