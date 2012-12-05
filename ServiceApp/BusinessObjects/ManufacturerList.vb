Imports System.ComponentModel
Imports DatabaseHelper
Imports SQLHelper
Imports DatatypeHelper.SearchCriteria
Public Class ManufacturerList
#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Manufacturer)
    ' create a new instance of the criteria object from sqlhelper
    Private mCriteria As New Criteria
#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Manufacturer)
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

    ' property when searching by contact 
    Public WriteOnly Property Contact(Optional ByVal searchCriteria As DatatypeHelper.SearchCriteria.Type = Type.String_Contains, Optional ByVal _
                                        boolCriteria As DatatypeHelper.SearchCriteria.Boolean = [Boolean].And, Optional ByVal _
                                        orderByCriteria As DatatypeHelper.SearchCriteria.OrderBy = OrderBy.NONE) As String
        Set(ByVal value As String)
            If value <> String.Empty Then
                mCriteria.Fields.Add("Contact")
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

    Public Function GetAll() As ManufacturerList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturer_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim m As New Manufacturer
            m.InitializeHeaderData(dr)
            m.InitializeBusinessData(dr)
            m.IsNew = False
            m.IsDirty = False
            mList.Add(m)
            AddHandler m.evtIsSavable, AddressOf ManufacturerList_evtIsSavable
        Next
        ' return Manufacturer list
        Return Me
    End Function

    Public Function Search() As ManufacturerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblManufacturer"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.Build(mCriteria)

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim m As New Manufacturer
            m.InitializeHeaderData(dr)
            m.InitializeBusinessData(dr)
            m.IsNew = False
            m.IsDirty = False
            mList.Add(m)
            AddHandler m.evtIsSavable, AddressOf ManufacturerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchAddressList() As ManufacturerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblManufacturerAddress"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildList(mCriteria, "ManufacturerID")

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim m As New Manufacturer
            m = m.GetById(dr("ManufacturerId"))
            m.InitializeHeaderData(m)
            m.InitializeBusinessData(m)
            m.IsNew = False
            m.IsDirty = False
            mList.Add(m)
            AddHandler m.evtIsSavable, AddressOf ManufacturerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchPhoneList() As ManufacturerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblManufacturerPhone"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildList(mCriteria, "ManufacturerID")

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim m As New Manufacturer
            m = m.GetById(dr("ManufacturerId"))
            m.InitializeHeaderData(m)
            m.InitializeBusinessData(m)
            m.IsNew = False
            m.IsDirty = False
            mList.Add(m)
            AddHandler m.evtIsSavable, AddressOf ManufacturerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchEmailList() As ManufacturerList
        Dim db As New Database
        Dim ds As DataSet
        mCriteria.TableName = "tblManufacturerEmail"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildList(mCriteria, "ManufacturerID")

        ds = db.ExecuteQuery
        For Each dr As DataRow In ds.Tables(0).Rows
            Dim m As New Manufacturer
            m = m.GetById(dr("ManufacturerId"))
            m.InitializeHeaderData(m)
            m.InitializeBusinessData(m)
            m.IsNew = False
            m.IsDirty = False
            mList.Add(m)
            AddHandler m.evtIsSavable, AddressOf ManufacturerList_evtIsSavable
        Next
        Return Me
    End Function
    Public Function SearchCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblManufacturer"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildCount(mCriteria)

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function
    Public Function SearchAddressCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblManufacturerAddress"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildListCount(mCriteria, "ManufacturerId")

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function
    Public Function SearchPhoneCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblManufacturerPhone"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildListCount(mCriteria, "ManufacturerId")

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function
    Public Function SearchEmailCount() As Integer
        Dim db As New Database
        mCriteria.TableName = "tblManufacturerEmail"
        db.ConnectionName = My.Settings.ConnectionName
        db.Command.CommandType = CommandType.Text
        db.Command.CommandText = Builder.BuildListCount(mCriteria, "ManufacturerId")

        Dim count As Integer = db.ExecuteScalar
        Return count
    End Function

    Public Function Save() As Boolean
        Dim result As Boolean = True
        For Each m As Manufacturer In mList
            If m.IsSavable = True Then
                m = m.Save
                If m.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each m As Manufacturer In mList
            If m.IsSavable = True Then
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
    Private Sub ManufacturerList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Manufacturer
        AddHandler CType(e.NewObject, Manufacturer).evtIsSavable, AddressOf ManufacturerList_evtIsSavable
    End Sub

#End Region

End Class

