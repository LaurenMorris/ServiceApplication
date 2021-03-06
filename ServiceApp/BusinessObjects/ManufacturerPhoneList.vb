﻿Imports System.ComponentModel
Imports DatabaseHelper
Public Class ManufacturerPhoneList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of ManufacturerPhone)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of ManufacturerPhone)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As ManufacturerPhoneList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerPhone_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mp As New ManufacturerPhone
            mp.InitializeHeaderData(dr)
            mp.InitializeBusinessData(dr)
            mp.IsNew = False
            mp.IsDirty = False
            mList.Add(mp)
            AddHandler mp.evtIsSavable, AddressOf ManufacturerPhoneList_evtIsSavable
        Next
        ' return manufacturer phone list
        Return Me
    End Function

    Public Function GetByManufacturerID(ByVal id As Integer) As ManufacturerPhoneList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerPhone_GetByManufacturerID"
        db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mp As New ManufacturerPhone
            mp.InitializeHeaderData(dr)
            mp.InitializeBusinessData(dr)
            mp.IsNew = False
            mp.IsDirty = False
            mList.Add(mp)
            AddHandler mp.evtIsSavable, AddressOf ManufacturerPhoneList_evtIsSavable
        Next
        ' return ManufacturerPhone list by manufacturer id
        Return Me
    End Function

    Public Function GetByPhoneTypeID(ByVal id As Integer) As ManufacturerPhoneList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblManufacturerPhone_GetByPhoneTypeID"
        db.Command.Parameters.Add("@PhoneTypeID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mp As New ManufacturerPhone
            mp.InitializeHeaderData(dr)
            mp.InitializeBusinessData(dr)
            mp.IsNew = False
            mp.IsDirty = False
            mList.Add(mp)
            AddHandler mp.evtIsSavable, AddressOf ManufacturerPhoneList_evtIsSavable
        Next
        ' return ManufacturerPhone list by phoneType id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each mp As ManufacturerPhone In mList
            If mp.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal ManufacturerID As Integer) As Boolean

        Dim result As Boolean = True
        For Each mp As ManufacturerPhone In mList
            If mp.IsSavable = True Then
                mp = mp.Save(db, ManufacturerID)
                If mp.IsNew = True Then
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
        db.Command.CommandText = "tblManufacturerPhone_DeleteByManufacturerID"
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

    Public Sub ManufacturerPhoneList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New ManufacturerPhone
        AddHandler CType(e.NewObject, ManufacturerPhone).evtIsSavable, AddressOf ManufacturerPhoneList_evtIsSavable
    End Sub

#End Region


End Class












