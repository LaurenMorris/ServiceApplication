Imports System.ComponentModel
Imports DatabaseHelper
Public Class ManufacturerEmailList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of ManufacturerEmail)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of ManufacturerEmail)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As ManufacturerEmailList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerEmail_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mne As New ManufacturerEmail
            mne.InitializeHeaderData(dr)
            mne.InitializeBusinessData(dr)
            mne.IsNew = False
            mne.IsDirty = False
            mList.Add(mne)
            AddHandler mne.evtIsSavable, AddressOf ManufacturerEmailList_evtIsSavable
        Next
        ' return ManufacturerEmail list
        Return Me
    End Function

    Public Function GetByManufacturerID(ByVal id As Integer) As ManufacturerEmailList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerEmail_GetByManufacturerID"
        db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mne As New ManufacturerEmail
            mne.InitializeHeaderData(dr)
            mne.InitializeBusinessData(dr)
            mne.IsNew = False
            mne.IsDirty = False
            mList.Add(mne)
            AddHandler mne.evtIsSavable, AddressOf ManufacturerEmailList_evtIsSavable
        Next
        ' return ManufacturerEmail list by manufacturer id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each mne As ManufacturerEmail In mList
            If mne.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal ManufacturerID As Integer) As Boolean

        Dim result As Boolean = True
        For Each mne As ManufacturerEmail In mList
            If mne.IsSavable = True Then
                mne = mne.Save(db, ManufacturerID)
                If mne.IsNew = True Then
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
        db.Command.CommandText = "tblManufacturerEmail_DeleteByManufacturerID"
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

    Public Sub ManufacturerEmailList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New ManufacturerEmail
        AddHandler CType(e.NewObject, ManufacturerEmail).evtIsSavable, AddressOf ManufacturerEmailList_evtIsSavable
    End Sub

#End Region


End Class










