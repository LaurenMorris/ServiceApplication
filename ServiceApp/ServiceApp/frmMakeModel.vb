Imports BusinessObjects
Public Class frmMakeModel
    Dim WithEvents mml As New MakeModelList
    Dim WithEvents mkl As New MakeList
    Dim WithEvents mdl As New ModelList

    Private Sub frmMakeModel_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.dgvMakeModel.AutoGenerateColumns = False
        mml = mml.GetAll
        Me.dgvMakeModel.DataSource = mml.List

        mkl = mkl.GetAll
        Me.dgvMake.DataSource = mkl.List

        mdl = mdl.GetAll
        Me.dgvModel.DataSource = mdl.List

        mnuSave.Enabled = False

    End Sub

    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        Try
            If Me.TabControl1.SelectedIndex = 0 Then
                If mml.IsSavable = True Then
                    mml = mml.Save
                End If
                Me.dgvMakeModel.Refresh()
            End If

            If Me.TabControl1.SelectedIndex = 1 Then
                If mkl.IsSavable = True Then
                    mkl = mkl.Save
                End If
                Me.dgvMake.Refresh()
            End If

            If Me.TabControl1.SelectedIndex = 2 Then
                If mdl.IsSavable = True Then
                    mdl = mdl.Save
                End If
                Me.dgvModel.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
#Region "Drop Down Lists"

    Private Sub SetMake(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = mkl.List
                .DisplayMember = "Name"
                .ValueMember = "Id"
            End If
        End With
    End Sub

    Private Sub SetModel(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = mdl.List
                .DisplayMember = "Name"
                .ValueMember = "Id"
            End If
        End With
    End Sub

#End Region


    Private Sub mml_evtIsSavable(savable As Boolean) Handles mml.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub

    Private Sub mkl_evtIsSavable(savable As Boolean) Handles mkl.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub

    Private Sub mdl_evtIsSavable(savable As Boolean) Handles mdl.evtIsSavable
        Me.mnuSave.Enabled = savable
    End Sub

    Private Sub dgvMakeModel_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvMakeModel.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvMakeModel.DataSource IsNot Nothing Then
            SetMake(dgvMakeModel.Columns(4))
        End If

        If e.ColumnIndex = 5 AndAlso Me.dgvMakeModel.DataSource IsNot Nothing Then
            SetModel(dgvMakeModel.Columns(5))
        End If
    End Sub

#Region "Data Error"

    Private Sub dgvMake_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvMake.DataError

    End Sub

    Private Sub dgvMakeModel_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvMakeModel.DataError

    End Sub

    Private Sub dgvModel_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvModel.DataError

    End Sub

#End Region

#Region "Delete"

    Private Sub dgvMakeModel_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvMakeModel.KeyDown
        Try
            Dim mm As MakeModel = dgvMakeModel.SelectedRows(0).DataBoundItem
            mm.Deleted = True
            If mm.IsSavable Then
                mm.Save()
                dgvMakeModel.Rows.RemoveAt(dgvMakeModel.SelectedRows(0).Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvMake_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvMake.KeyDown
        Try
            Dim mk As Make = dgvMake.SelectedRows(0).DataBoundItem
            mk.Deleted = True
            If mk.IsSavable Then
                mk.Save()
                dgvMake.Rows.RemoveAt(dgvMake.SelectedRows(0).Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvModel_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvModel.KeyDown
        Try
            Dim md As Model = dgvModel.SelectedRows(0).DataBoundItem
            md.Deleted = True
            If md.IsSavable Then
                md.Save()
                dgvModel.Rows.RemoveAt(dgvModel.SelectedRows(0).Index)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

#End Region

End Class
