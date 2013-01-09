Imports BusinessObjects
Public Class frmManufacturer

    Private WithEvents ManufacturerList As New ManufacturerList
    Private addressTypeList As New AddressTypeList
    Private phoneTypeList As New PhoneTypeList
    Private emailTypeList As New EmailTypeList

    Private mNameSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)
    Private mNameOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)
    Private mNameSearchBoolean As New List(Of DatatypeHelper.SearchCriteria.Boolean)

    Private mContactSearchCriteria As New List(Of DatatypeHelper.SearchCriteria.Type)
    Private mContactOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)

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


    Private Sub frmManufacturer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To dgvManufacturer.ColumnCount - 1
            dgvManufacturer.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For i As Integer = 0 To dgvManufacturerEmail.ColumnCount - 1
            dgvManufacturerEmail.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For i As Integer = 0 To dgvManufacturerAddress.ColumnCount - 1
            dgvManufacturerAddress.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        For i As Integer = 0 To dgvManufacturerPhone.ColumnCount - 1
            dgvManufacturerPhone.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next


        Me.dgvManufacturer.AutoGenerateColumns = False
        Me.dgvManufacturerEmail.AutoGenerateColumns = False
        Me.dgvManufacturerPhone.AutoGenerateColumns = False
        Me.dgvManufacturerAddress.AutoGenerateColumns = False
        mnuSave.Enabled = False

        ManufacturerList = ManufacturerList.GetAll
        dgvManufacturer.DataSource = ManufacturerList.List
        addressTypeList = addressTypeList.GetAll
        phoneTypeList = phoneTypeList.GetAll
        emailTypeList = emailTypeList.GetAll

        mNameSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mNameSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mNameSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mNameSearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.And)
        mNameSearchBoolean.Add(DatatypeHelper.SearchCriteria.Boolean.Or)
        mNameOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mNameOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mNameOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

        mContactSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Contains)
        mContactSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Ends_With)
        mContactSearchCriteria.Add(DatatypeHelper.SearchCriteria.Type.String_Starts_With)
        mContactOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.ASC)
        mContactOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.DESC)
        mContactOrderBy.Add(DatatypeHelper.SearchCriteria.OrderBy.NONE)

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
        Me.cboNameBool.DataSource = mNameSearchBoolean
        Me.cboNameOrderBy.DataSource = mNameOrderBy

        Me.cboContactSearch.DataSource = mContactSearchCriteria
        Me.cboContactOrderBy.DataSource = mContactOrderBy

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

    Private Sub dgvManufacturer_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvManufacturer.DataError

    End Sub
    Private Sub dgvManufacturerEmail_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvManufacturerEmail.DataError

    End Sub
    Private Sub dgvManufacturerPhone_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvManufacturerPhone.DataError

    End Sub
    Private Sub dgvManufacturerAddress_DataError(sender As Object, e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvManufacturerAddress.DataError

    End Sub

#End Region


    Private Sub dgvManufacturer_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvManufacturer.KeyDown
        Try
            If Me.dgvManufacturer.SelectedRows IsNot Nothing AndAlso Me.dgvManufacturer.SelectedRows.Count > 0 Then
                Dim m As Manufacturer = Me.dgvManufacturer.SelectedRows(0).DataBoundItem
                m.Deleted = True
                If m.IsSavable Then
                    m.Save()
                    Me.dgvManufacturer.Rows.RemoveAt(Me.dgvManufacturer.SelectedRows(0).Index)
                    Me.dgvManufacturerEmail.DataSource = Nothing
                    Me.dgvManufacturerAddress.DataSource = Nothing
                    Me.dgvManufacturerPhone.DataSource = Nothing
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvManufacturerEmail_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvManufacturerEmail.KeyDown
        Try
            If dgvManufacturerEmail.SelectedRows IsNot Nothing AndAlso dgvManufacturerEmail.SelectedRows.Count > 0 Then
                Dim mane As ManufacturerEmail = dgvManufacturerEmail.SelectedRows(0).DataBoundItem
                mane.Deleted = True
                Dim m As Manufacturer = dgvManufacturer.SelectedRows(0).DataBoundItem
                If m.IsSavable Then
                    m.Save()
                    dgvManufacturerEmail.Rows.RemoveAt(dgvManufacturerEmail.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvManufacturerPhone_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvManufacturerPhone.KeyDown
        Try
            If dgvManufacturerPhone.SelectedRows IsNot Nothing AndAlso dgvManufacturerPhone.SelectedRows.Count > 0 Then
                Dim mp As ManufacturerPhone = dgvManufacturerPhone.SelectedRows(0).DataBoundItem
                mp.Deleted = True
                Dim m As Manufacturer = dgvManufacturer.SelectedRows(0).DataBoundItem
                If m.IsSavable Then
                    m.Save()
                    dgvManufacturerPhone.Rows.RemoveAt(dgvManufacturerPhone.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dgvManufacturerAddress_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvManufacturerAddress.KeyDown
        Try
            If dgvManufacturerAddress.SelectedRows IsNot Nothing AndAlso dgvManufacturerAddress.SelectedRows.Count > 0 Then
                Dim ma As ManufacturerAddress = dgvManufacturerAddress.SelectedRows(0).DataBoundItem
                ma.Deleted = True
                Dim m As Manufacturer = dgvManufacturer.SelectedRows(0).DataBoundItem
                If m.IsSavable Then
                    m.Save()
                    dgvManufacturerAddress.Rows.RemoveAt(dgvManufacturerAddress.SelectedRows(0).Index)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvManufacturer_RowHeaderMouseDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvManufacturer.RowHeaderMouseDoubleClick
        mnuSave.Enabled = False
        Dim m As Manufacturer = Me.dgvManufacturer.SelectedRows(0).DataBoundItem
        Me.dgvManufacturerEmail.DataSource = m.Emails.List
        Me.dgvManufacturerPhone.DataSource = m.Phones.List
        Me.dgvManufacturerAddress.DataSource = m.Addresses.List
    End Sub

    Private Sub ManufacturerList_evtIsSavable(savable As Boolean) Handles ManufacturerList.evtIsSavable
        mnuSave.Enabled = savable
    End Sub

    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        Try
            If ManufacturerList.IsSavable = True Then
                ManufacturerList.Save()
            End If
            Me.dgvManufacturer.Refresh()
            Me.dgvManufacturerPhone.Refresh()
            Me.dgvManufacturerEmail.Refresh()
            Me.dgvManufacturerAddress.Refresh()

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

    Private Sub dgvManufacturerAddress_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvManufacturerAddress.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvManufacturerAddress.DataSource IsNot Nothing Then
            SetAddressTypes(dgvManufacturerAddress.Columns(4))
        End If
    End Sub

    Private Sub dgvManufacturerEmail_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvManufacturerEmail.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvManufacturerEmail.DataSource IsNot Nothing Then
            SetEmailTypes(dgvManufacturerEmail.Columns(4))
        End If
    End Sub

    Private Sub dgvManufacturerPhone_CellFormatting(sender As Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvManufacturerPhone.CellFormatting
        If e.ColumnIndex = 4 AndAlso Me.dgvManufacturerPhone.DataSource IsNot Nothing Then
            SetPhoneTypes(dgvManufacturerPhone.Columns(4))
        End If
    End Sub

    Private Sub btnSearchManufacturer_Click(sender As Object, e As System.EventArgs) Handles btnSearchManufacturer.Click
        Dim bSearch As Boolean = True
        ManufacturerList = New ManufacturerList
        ManufacturerList.Name(Me.cboNameSearch.SelectedValue, Me.cboNameBool.SelectedValue, Me.cboNameOrderBy.SelectedValue) = Me.txtName.Text
        ManufacturerList.Contact(Me.cboContactSearch.SelectedValue, Me.cboContactOrderBy.SelectedValue) = Me.txtContact.Text
        Dim count As Integer = ManufacturerList.SearchCount()
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            ManufacturerList = ManufacturerList.Search()
            Me.dgvManufacturer.DataSource = ManufacturerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub btnSearchAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAddress.Click
        Dim bSearch As Boolean = True
        ManufacturerList = New ManufacturerList
        ManufacturerList.Address(Me.cboAddressSearch.SelectedValue, Me.cboAddressBool.SelectedValue, Me.cboAddressOrderBy.SelectedValue) = Me.txtAddress.Text
        ManufacturerList.City(Me.cboCitySearch.SelectedValue, Me.cboCityBool.SelectedValue, Me.cboCityOrderBy.SelectedValue) = Me.txtCity.Text
        ManufacturerList.State(Me.cboStateSearch.SelectedValue, Me.cboStateBool.SelectedValue, Me.cboStateOrderBy.SelectedValue) = Me.txtState.Text
        ManufacturerList.Zip(Me.cboZipSearch.SelectedValue, Me.cboZipOrderBy.SelectedValue) = Me.txtZip.Text

        Dim count As Integer = ManufacturerList.SearchAddressCount
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            Me.dgvManufacturerEmail.DataSource = Nothing
            Me.dgvManufacturerAddress.DataSource = Nothing
            Me.dgvManufacturerPhone.DataSource = Nothing
            ManufacturerList = ManufacturerList.SearchAddressList()
            Me.dgvManufacturer.DataSource = ManufacturerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub btnSearchPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPhone.Click
        Dim bSearch As Boolean = True
        ManufacturerList = New ManufacturerList
        ManufacturerList.Phone(Me.cboPhoneSearch.SelectedValue, Me.cboPhoneOrderBy.SelectedValue) = Me.txtPhone.Text

        Dim count As Integer = ManufacturerList.SearchPhoneCount
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            Me.dgvManufacturerEmail.DataSource = Nothing
            Me.dgvManufacturerAddress.DataSource = Nothing
            Me.dgvManufacturerPhone.DataSource = Nothing
            ManufacturerList = ManufacturerList.SearchPhoneList()
            Me.dgvManufacturer.DataSource = ManufacturerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

    Private Sub btnSearchEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchEmail.Click
        Dim bSearch As Boolean = True
        ManufacturerList = New ManufacturerList
        ManufacturerList.Email(Me.cboEmailSearch.SelectedValue, Me.cboEmailOrderBy.SelectedValue) = Me.txtEmail.Text

        Dim count As Integer = ManufacturerList.SearchEmailCount
        If count > 10 Then
            If MessageBox.Show(String.Format _
                   ("This query has resulted in {0} records. Do you want to display the records?", count), _
                   "", MessageBoxButtons.YesNo) = DialogResult.No Then
                bSearch = False
            End If
        End If

        If bSearch = True Then
            Me.dgvManufacturerEmail.DataSource = Nothing
            Me.dgvManufacturerAddress.DataSource = Nothing
            Me.dgvManufacturerPhone.DataSource = Nothing
            ManufacturerList = ManufacturerList.SearchEmailList()
            Me.dgvManufacturer.DataSource = ManufacturerList.List
            Me.TabControl1.SelectTab(0)
        End If
    End Sub

End Class