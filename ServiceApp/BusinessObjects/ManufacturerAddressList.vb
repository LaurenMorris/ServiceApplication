Imports System.ComponentModel
Imports DatabaseHelper
Public Class ManufacturerAddressList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of ManufacturerAddress)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of ManufacturerAddress)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As ManufacturerAddressList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerAddress_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ma As New ManufacturerAddress
            ma.InitializeHeaderData(dr)
            ma.InitializeBusinessData(dr)
            ma.IsNew = False
            ma.IsDirty = False
            mList.Add(ma)
            AddHandler ma.evtIsSavable, AddressOf ManufacturerAddressList_evtIsSavable
        Next
        ' return ManufacturerAddress list
        Return Me
    End Function

    Public Function GetByManufacturerID(ByVal id As Integer) As ManufacturerAddressList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerAddress_GetByManufacturerID"
        db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ma As New ManufacturerAddress
            ma.InitializeHeaderData(dr)
            ma.InitializeBusinessData(dr)
            ma.IsNew = False
            ma.IsDirty = False
            mList.Add(ma)
            AddHandler ma.evtIsSavable, AddressOf ManufacturerAddressList_evtIsSavable
        Next
        ' return ManufacturerAddress list by manufacturer id
        Return Me
    End Function

    Public Function GetByAddressTypeID(ByVal id As Integer) As ManufacturerAddressList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerAddress_GetByAddressTypeID"
        db.Command.Parameters.Add("@AddressTypeID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ma As New ManufacturerAddress
            ma.InitializeHeaderData(dr)
            ma.InitializeBusinessData(dr)
            ma.IsNew = False
            ma.IsDirty = False
            mList.Add(ma)
            AddHandler ma.evtIsSavable, AddressOf ManufacturerAddressList_evtIsSavable
        Next
        ' return ManufacturerAddress list by AddressType id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each ma As ManufacturerAddress In mList
            If ma.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal ManufacturerID As Integer) As Boolean

        Dim result As Boolean = True
        For Each ma As ManufacturerAddress In mList
            If ma.IsSavable = True Then
                ma = ma.Save(db, ManufacturerID)
                If ma.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

    Public Function DeleteByManufacturerID(ByVal db As Database, ByVal id As Integer) As Boolean
        db.Command.Parameters.Clear()
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerAddress_DeleteByManufacturerID"
        db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = id
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

    Public Sub ManufacturerAddressList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New ManufacturerAddress
        AddHandler CType(e.NewObject, ManufacturerAddress).evtIsSavable, AddressOf ManufacturerAddressList_evtIsSavable
    End Sub

#End Region


End Class













