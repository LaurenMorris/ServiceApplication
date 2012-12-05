Imports System.ComponentModel
Imports DatabaseHelper
Imports SQLHelper
Imports DatatypeHelper.SearchCriteria
Public Class CustomerList
#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Customer)
    ' create a new instance of the criteria object from sqlhelper
    Private mCriteria As New Criteria
#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Customer)
        Get
            Return mList
        End Get
    End Property

    ' property when searching by name 
    Public WriteOnly Property Name(Optional ByVal _
                                        searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                                        boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                                        orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("Name")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property State(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                                    boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                                    orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("State")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property Address(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                                boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                                orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("Address")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property City(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                                boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                                orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("City")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property Zip(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                                boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                                orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("Zip")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property Phone(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                            boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                            orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("Phone")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property

    Public WriteOnly Property Email(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                        boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                        orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("Email")
                mCriteria.Values.Add(value)
                mCriteria.Types.Add(searchCriteria)
                mCriteria.Boolean.Add(boolCriteria)
                If orderByCriteria <> OrderBy.NONE Then
                    mCriteria.OrderBy.Add(orderByCriteria)
                End If
            End If
        End Set
    End Property
#End Region

#Region " Private Methods "

#End Region

#Region " Public Methods "

    Public Function GetAll() As CustomerList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomer_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim c As New Customer
            c.InitializeHeaderData(dr)
            c.InitializeBusinessData(dr)
            c.IsNew = False
            c.IsDirty = False
            mList.Add(c)
            AddHandler c.evtIsSavable, AddressOf CustomerList_evtIsSavable
        Next
        ' return Customer list
        Return Me
    End Function

    Public Function Search() As CustomerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblCustomer"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.Build(mCriteria)

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim c As New Customer
            c.InitializeHeaderData(dr)
            c.InitializeBusinessData(dr)
            c.IsNew = False
            c.IsDirty = False
            mList.Add(c)
            AddHandler c.evtIsSavable, AddressOf CustomerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchAddressList() As CustomerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblCustomerAddress"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildList(mCriteria, "CustomerID")

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim c As New Customer
            c = c.GetById(dr("CustomerId"))
            c.InitializeHeaderData(c)
            c.InitializeBusinessData(c)
            c.IsNew = False
            c.IsDirty = False
            mList.Add(c)
            AddHandler c.evtIsSavable, AddressOf CustomerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchPhoneList() As CustomerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblCustomerPhone"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildList(mCriteria, "CustomerID")

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim c As New Customer
            c = c.GetById(dr("CustomerId"))
            c.InitializeHeaderData(c)
            c.InitializeBusinessData(c)
            c.IsNew = False
            c.IsDirty = False
            mList.Add(c)
            AddHandler c.evtIsSavable, AddressOf CustomerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchEmailList() As CustomerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblCustomerEmail"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildList(mCriteria, "CustomerID")

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim c As New Customer
            c = c.GetById(dr("CustomerId"))
            c.InitializeHeaderData(c)
            c.InitializeBusinessData(c)
            c.IsNew = False
            c.IsDirty = False
            mList.Add(c)
            AddHandler c.evtIsSavable, AddressOf CustomerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblCustomer"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildCount(mCriteria)

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function
    Public Function SearchAddressCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblCustomerAddress"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildListCount(mCriteria, "CustomerId")

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function
    Public Function SearchPhoneCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblCustomerPhone"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildListCount(mCriteria, "CustomerId")

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function
    Public Function SearchEmailCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblCustomerEmail"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildListCount(mCriteria, "CustomerId")

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function

    Public Function Save() As Boolean
        Dim result As Boolean = True
        For Each c As Customer In mList
            If c.IsSavable = True Then
                c = c.Save
                If c.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each c As Customer In mList
            If c.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Private Event Handlers "
    Private Sub CustomerList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Customer
        AddHandler CType(e.NewObject, Customer).evtIsSavable, AddressOf CustomerList_evtIsSavable
    End Sub

#End Region

End Class


