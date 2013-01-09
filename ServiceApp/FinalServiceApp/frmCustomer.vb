Imports BusinessObjects

Public Class frmCustomer
    Private WithEvents customerList As New CustomerList
    Private addressTypeList As New AddressTypeList
    Private phoneTypeList As New PhoneTypeList
    Private emailTypeList As New EmailTypeList

    Private WithEvents workorderList As New WorkorderList
    Private workorderPartList As New WorkorderPartList
    Private workorderLaborList As New WorkorderLaborList
    Private workorderCommentList As New WorkorderCommentList

    Private mNameSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)
    Private mNameOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)

    Private mAddressSearchBoolean As New List(Of DatatypeHelper.SearchCriteria.Boolean)
    Private mAddressOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mAddressSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)

    Private mCitySearchBoolean As New List(Of DatatypeHelper.SearchCriteria.Boolean)
    Private mCityOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mCitySearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)

    Private mStateSearchBoolean As New List(Of DatatypeHelper.SearchCriteria.Boolean)
    Private mStateOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mStateSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)

    Private mZipOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mZipSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)

    Private mPhoneOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mPhoneSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)

    Private mEmailOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mEmailSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)

    Private Sub frmCustomer_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        For i As Integer = 0 To dgvCustomer.ColumnCount - 1
            dgvCustomer.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For i As Integer = 0 To dgvCustomerEmail.ColumnCount - 1
            dgvCustomerEmail.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For i As Integer = 0 To dgvCustomerAddress.ColumnCount - 1
            dgvCustomerAddress.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For i As Integer = 0 To dgvCustomerPhone.ColumnCount - 1
            dgvCustomerPhone.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomerEmail.AutoGenerateColumns = False
        Me.dgvCustomerPhone.AutoGenerateColumns = False
        Me.dgvCustomerAddress.AutoGenerateColumns = False
        mnuSave.Enabled = False

        Me.dgvWorkorder.AutoGenerateColumns = False
        Me.dgvWorkorderPart.AutoGenerateColumns = False
        Me.dgvWorkorderLabor.AutoGenerateColumns = False
        Me.dgvWorkorderComment.AutoGenerateColumns = False

        'WorkorderList = WorkorderList.GetAll
        'dgvWorkorder.DataSource = WorkorderList.List
        'WorkorderPartList = WorkorderPartList.GetAll
        'WorkorderLaborList = WorkorderLaborList.GetAll
        'WorkorderCommentList = WorkorderCommentList.GetAll

        customerList = customerList.GetAll
        dgvCustomer.DataSource = customerList.List
        addressTypeList = addressTypeList.GetAll
        phoneTypeList = phoneTypeList.GetAll
        emailTypeList = emailTypeList.GetAll

        mNameSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mNameSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mNameSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mNameOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mNameOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mNameOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mAddressSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mAddressSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mAddressSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mAddressSearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.And)
        mAddressSearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.Or)
        mAddressOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mAddressOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mAddressOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mCitySearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mCitySearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mCitySearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mCitySearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.And)
        mCitySearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.Or)
        mCityOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mCityOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mCityOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mStateSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mStateSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mStateSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mStateSearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.And)
        mStateSearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.Or)
        mStateOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mStateOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mStateOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mZipSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mZipSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mZipSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mZipOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mZipOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mZipOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mPhoneSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mPhoneSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mPhoneSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mPhoneOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mPhoneOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mPhoneOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mEmailSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mEmailSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mEmailSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mEmailOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mEmailOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mEmailOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        Me.cboNameSearch.DataSource = mNameSearchCriteria
        Me.cboNameOrderBy.DataSource = mNameOrderBy

        Me.cboAddressSearch.DataSource = mAddressSearchCriteria
        Me.cboAddressBool.DataSource = mAddressSearchBoolean
        Me.cboAddressOrderBy.DataSource = mAddressOrderBy

        Me.cboCitySearch.DataSource = mCitySearchCriteria
        Me.cboCityBool.DataSource = mCitySearchBoolean
        Me.cboCityOrderBy.DataSource = mCityOrderBy

        Me.cboStateSearch.DataSource = mStateSearchCriteria
        Me.cboStateBool.DataSource = mStateSearchBoolean
        Me.cboStateOrderBy.DataSource = mStateOrderBy

        Me.cboZipSearch.DataSource = mZipSearchCriteria
        Me.cboZipOrderBy.DataSource = mZipOrderBy

        Me.cboPhoneSearch.DataSource = mZipSearchCriteria
        Me.cboPhoneOrderBy.DataSource = mZipOrderBy

        Me.cboEmailSearch.DataSource = mZipSearchCriteria
        Me.cboEmailOrderBy.DataSource = mZipOrderBy
    End Sub

#Region "Data Error"

    Private Sub dgvCustomer_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCustomer.DataError

    End Sub

    Private Sub dgvCustomerAddress_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCustomerAddress.DataError

    End Sub

    Private Sub dgvCustomerEmail_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCustomerEmail.DataError

    End Sub

    Private Sub dgvCustomerPhone_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCustomerPhone.DataError

    End Sub

    Private Sub dgvWorkorder_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub dgvWorkorderComment_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub dgvWorkorderLabor_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

    Private Sub dgvWorkorderPart_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs)

    End Sub

#End Region


    Private Sub dgvCustomer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCustomer.KeyDown
        Try
            If Me.dgvCustomer.SelectedRows IsNot Nothing AndAlso Me.dgvCustomer.SelectedRows.Count > 0 Then
                Dim c As Customer = Me.dgvCustomer.SelectedRows(0).DataBoundItem
                c.Deleted = True
                If c.IsSavable Then
                    c.Save()
                    Me.dgvCustomer.Rows.RemoveAt(Me.dgvCustomer.SelectedRows(0).Index)
                    Me.dgvCustomerEmail.DataSource = Nothing
                    Me.dgvCustomerAddress.DataSource = Nothing
                    Me.dgvCustomerPhone.DataSource = Nothing
                    Me.dgvWorkorder.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvCustomerAddress_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCustomerAddress.KeyDown
        Try
            If dgvCustomerAddress.SelectedRows IsNot Nothing AndAlso dgvCustomerAddress.SelectedRows.Count > 0 Then
                Dim ca As CustomerAddress = dgvCustomerAddress.SelectedRows(0).DataBoundItem
                ca.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    dgvCustomerAddress.Rows.RemoveAt(dgvCustomerAddress.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvCustomerEmail_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCustomerEmail.KeyDown
        Try
            If dgvCustomerEmail.SelectedRows IsNot Nothing AndAlso dgvCustomerEmail.SelectedRows.Count > 0 Then
                Dim ce As CustomerEmail = dgvCustomerEmail.SelectedRows(0).DataBoundItem
                ce.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    dgvCustomerEmail.Rows.RemoveAt(dgvCustomerEmail.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvCustomerPhone_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvCustomerPhone.KeyDown
        Try
            If dgvCustomerPhone.SelectedRows IsNot Nothing AndAlso dgvCustomerPhone.SelectedRows.Count > 0 Then
                Dim cp As CustomerPhone = dgvCustomerPhone.SelectedRows(0).DataBoundItem
                cp.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    dgvCustomerPhone.Rows.RemoveAt(dgvCustomerPhone.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvWorkorder_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvWorkorder.KeyDown
        Try
            If Me.dgvWorkorder.SelectedRows IsNot Nothing AndAlso Me.dgvWorkorder.SelectedRows.Count > 0 Then
                Dim w As Workorder = Me.dgvWorkorder.SelectedRows(0).DataBoundItem
                w.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    Me.dgvWorkorder.Rows.RemoveAt(Me.dgvWorkorder.SelectedRows(0).Index)
                    Me.dgvWorkorderPart.DataSource = Nothing
                    Me.dgvWorkorderLabor.DataSource = Nothing
                    Me.dgvWorkorderComment.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvWorkorderComment_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvWorkorderComment.KeyDown
        Try
            If dgvWorkorderComment.SelectedRows IsNot Nothing AndAlso dgvWorkorderComment.SelectedRows.Count > 0 Then
                Dim wc As WorkorderComment = dgvWorkorderComment.SelectedRows(0).DataBoundItem
                wc.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    dgvWorkorderComment.Rows.RemoveAt(dgvWorkorderComment.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvWorkorderLabor_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvWorkorderLabor.KeyDown
        Try
            If dgvWorkorderLabor.SelectedRows IsNot Nothing AndAlso dgvWorkorderLabor.SelectedRows.Count > 0 Then
                Dim wl As WorkorderLabor = dgvWorkorderLabor.SelectedRows(0).DataBoundItem
                wl.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    dgvWorkorderLabor.Rows.RemoveAt(dgvWorkorderLabor.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvWorkorderPart_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvWorkorderPart.KeyDown
        Try
            If dgvWorkorderPart.SelectedRows IsNot Nothing AndAlso dgvWorkorderPart.SelectedRows.Count > 0 Then
                Dim wp As WorkorderPart = dgvWorkorderPart.SelectedRows(0).DataBoundItem
                wp.Deleted = True
                Dim c As Customer = dgvCustomer.SelectedRows(0).DataBoundItem
                If c.IsSavable Then
                    c.Save()
                    dgvWorkorderPart.Rows.RemoveAt(dgvWorkorderPart.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub dgvCustomer_RowHeaderMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCustomer.RowHeaderMouseDoubleClick
        mnuSave.Enabled = False
        Dim c As Customer = Me.dgvCustomer.SelectedRows(0).DataBoundItem
        Me.dgvCustomerEmail.DataSource = c.Emails.List
        Me.dgvCustomerPhone.DataSource = c.Phones.List
        Me.dgvCustomerAddress.DataSource = c.Addresses.List
        Me.dgvWorkorder.DataSource = c.Workorders.List

    End Sub

    Private Sub dgvWorkorder_RowHeaderMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvWorkorder.RowHeaderMouseDoubleClick
        mnuSave.Enabled = False
        Dim w As Workorder = Me.dgvWorkorder.SelectedRows(0).DataBoundItem
        Me.dgvWorkorderPart.DataSource = w.Parts.List
        Me.dgvWorkorderLabor.DataSource = w.LaborHours.List
        Me.dgvWorkorderComment.DataSource = w.Comments.List
    End Sub

    Private Sub customerList_evtIsSavable(savable As Boolean) Handles customerList.evtIsSavable
        mnuSave.Enabled = savable
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As System.EventArgs) Handles mnuSave.Click
        Try
            If customerList.IsSavable = True Then
                customerList.Save()
            End If

            Me.dgvCustomer.Refresh()
            Me.dgvCustomerPhone.Refresh()
            Me.dgvCustomerEmail.Refresh()
            Me.dgvCustomerAddress.Refresh()
            'Me.dgvWorkorder.Refresh()
            'Me.dgvWorkorderPart.Refresh()
            'Me.dgvWorkorderLabor.Refresh()
            'Me.dgvWorkorderComment.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


#Region " Combo Box Columns "

    Private Sub SetEmailTypes(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = emailTypeList.List
                .DisplayMember = "Type"
                .ValueMember = "Id"
            End If
        End With
    End Sub

    Private Sub SetPhoneTypes(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = phoneTypeList.List
                .DisplayMember = "Type"
                .ValueMember = "Id"
            End If
        End With
    End Sub

    Private Sub SetAddressTypes(ByVal column As DataGridViewComboBoxColumn)
        With column
            If .DataSource Is Nothing Then
                .DataSource = addressTypeList.List
                .DisplayMember = "Type"
                .ValueMember = "Id"
            End If
        End With
    End Sub

#End Region

    Private Sub dgvCustomerAddress_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCustomerAddress.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvCustomerAddress.DataSource IsNot Nothing Then
            SetAddressTypes(dgvCustomerAddress.Columns(4))
        End If
    End Sub

    Private Sub dgvCustomerEmail_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCustomerEmail.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvCustomerEmail.DataSource IsNot Nothing Then
            SetEmailTypes(dgvCustomerEmail.Columns(4))
        End If
    End Sub

    Private Sub dgvCustomerPhone_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCustomerPhone.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvCustomerPhone.DataSource IsNot Nothing Then
            SetPhoneTypes(dgvCustomerPhone.Columns(4))
        End If
    End Sub


    Private Sub btnSearchCustomer_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCustomer.Click
        Dim bSearch As Boolean = True
        customerList = New CustomerList
        customerList.Name(Me.cboNameSearch.SelectedValue, Me.cboNameOrderBy.SelectedValue) = Me.txtName.Text
        Dim count As Integer = customerList.SearchCount()
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            customerList = customerList.Search()
            Me.dgvCustomer.DataSource = customerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub btnSearchAddress_Click(sender As Object, e As System.EventArgs) Handles btnSearchAddress.Click
        Dim bSearch As Boolean = True
        customerList = New CustomerList
        customerList.Address(Me.cboAddressSearch.SelectedValue, Me.cboAddressBool.SelectedValue, Me.cboAddressOrderBy.SelectedValue) = Me.txtAddress.Text
        customerList.City(Me.cboCitySearch.SelectedValue, Me.cboCityBool.SelectedValue, Me.cboCityOrderBy.SelectedValue) = Me.txtCity.Text
        customerList.State(Me.cboStateSearch.SelectedValue, Me.cboStateBool.SelectedValue, Me.cboStateOrderBy.SelectedValue) = Me.txtState.Text
        customerList.Zip(Me.cboZipSearch.SelectedValue, Me.cboZipOrderBy.SelectedValue) = Me.txtZip.Text

        Dim count As Integer = customerList.SearchAddressCount
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            Me.dgvCustomerEmail.DataSource = Nothing
            Me.dgvCustomerAddress.DataSource = Nothing
            Me.dgvCustomerPhone.DataSource = Nothing
            customerList = customerList.SearchAddressList()
            Me.dgvCustomer.DataSource = customerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub btnSearchEmail_Click(sender As Object, e As System.EventArgs) Handles btnSearchEmail.Click
        Dim bSearch As Boolean = True
        customerList = New CustomerList
        customerList.Email(Me.cboEmailSearch.SelectedValue, Me.cboEmailOrderBy.SelectedValue) = Me.txtEmail.Text

        Dim count As Integer = customerList.SearchEmailCount
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            Me.dgvCustomerEmail.DataSource = Nothing
            Me.dgvCustomerAddress.DataSource = Nothing
            Me.dgvCustomerPhone.DataSource = Nothing
            customerList = customerList.SearchEmailList()
            Me.dgvCustomer.DataSource = customerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub btnSearchPhone_Click(sender As Object, e As System.EventArgs) Handles btnSearchPhone.Click
        Dim bSearch As Boolean = True
        customerList = New CustomerList
        customerList.Phone(Me.cboPhoneSearch.SelectedValue, Me.cboPhoneOrderBy.SelectedValue) = Me.txtPhone.Text

        Dim count As Integer = customerList.SearchPhoneCount
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            Me.dgvCustomerEmail.DataSource = Nothing
            Me.dgvCustomerAddress.DataSource = Nothing
            Me.dgvCustomerPhone.DataSource = Nothing
            customerList = customerList.SearchPhoneList()
            Me.dgvCustomer.DataSource = customerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

End Class