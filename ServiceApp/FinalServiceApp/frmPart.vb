Imports BusinessObjects

Public Class frmPart
    Dim WithEvents pl As New PartList
    Private Sub frmPart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        pl = pl.GetAll
        Me.dgvPart.DataSource = pl.List
    End Sub

    Private Sub pl_evtIsSavable(ByVal savable As Boolean) Handles pl.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub

    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click

        Try
            If pl.IsSavable = True Then
                pl = pl.Save
            End If
            Me.dgvPart.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvPart_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvPart.DataError

    End Sub
    Private Sub dgvPart_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvPart.KeyDown
        Try
            Dim p As Part = dgvPart.SelectedRows(0).DataBoundItem
            p.Deleted = True
            If p.IsSavable Then
                p.Save()
                dgvPart.Rows.RemoveAt(dgvPart.SelectedRows(0).Index)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class