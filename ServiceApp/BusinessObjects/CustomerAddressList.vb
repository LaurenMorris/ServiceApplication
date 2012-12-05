Imports System.ComponentModel
Imports DatabaseHelper
Public Class CustomerAddressList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of CustomerAddress)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of CustomerAddress)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As CustomerAddressList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerAddress_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ca As New CustomerAddress
            ca.InitializeHeaderData(dr)
            ca.InitializeBusinessData(dr)
            ca.IsNew = False
            ca.IsDirty = False
            mList.Add(ca)
            AddHandler ca.evtIsSavable, AddressOf CustomerAddressList_evtIsSavable
        Next
        ' return customer address list
        Return Me
    End Function

    Public Function GetByCustomerID(ByVal id As Integer) As CustomerAddressList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerAddress_GetByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ca As New CustomerAddress
            ca.InitializeHeaderData(dr)
            ca.InitializeBusinessData(dr)
            ca.IsNew = False
            ca.IsDirty = False
            mList.Add(ca)
            AddHandler ca.evtIsSavable, AddressOf CustomerAddressList_evtIsSavable
        Next
        ' return customer address list by customer id
        Return Me
    End Function

    Public Function GetByAddressTypeID(ByVal id As Integer) As CustomerAddressList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerAddress_GetByAddressTypeID"
        db.Command.Parameters.Add("@AddressTypeID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ca As New CustomerAddress
            ca.InitializeHeaderData(dr)
            ca.InitializeBusinessData(dr)
            ca.IsNew = False
            ca.IsDirty = False
            mList.Add(ca)
            AddHandler ca.evtIsSavable, AddressOf CustomerAddressList_evtIsSavable
        Next
        ' return CustomerAddress list by AddressType id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each ca As CustomerAddress In mList
            If ca.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As Boolean

        Dim result As Boolean = True
        For Each ca As CustomerAddress In mList
            If ca.IsSavable = True Then
                ca = ca.Save(db, CustomerID)
                If ca.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

    Public Function DeleteByCustomerID(ByVal db As Database, ByVal id As Integer) As Boolean
        db.Command.Parameters.Clear()
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerAddress_DeleteByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
        db.ExecuteNonQueryWithTransaction()
        Return True
    End Function


#End Region

#Region " Private Methods "

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Public Event Handlers "

    Public Sub CustomerAddressList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New CustomerAddress
        AddHandler CType(e.NewObject, CustomerAddress).evtIsSavable, AddressOf CustomerAddressList_evtIsSavable
    End Sub

#End Region


End Class












