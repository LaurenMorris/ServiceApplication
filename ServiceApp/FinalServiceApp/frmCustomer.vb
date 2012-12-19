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
End Class