﻿Imports System.ComponentModel
Imports DatabaseHelper
Public Class PhoneTypeList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of PhoneType)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of PhoneType)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As PhoneTypeList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPhoneType_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim pt As New PhoneType
            pt.InitializeHeaderData(dr)
            pt.InitializeBusinessData(dr)
            pt.IsNew = False
            pt.IsDirty = False
            mList.Add(pt)
            AddHandler pt.evtIsSavable, AddressOf PhoneTypeList_evtIsSavable
        Next
        ' return phone type list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each pt As PhoneType In mList
            If pt.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As PhoneTypeList


        For Each pt As PhoneType In mList
            If pt.IsSavable = True Then
                pt = pt.Save()

            End If
        Next

        Return Me
    End Function

#End Region

#Region " Private Methods "

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Public Event Handlers "

    Public Sub PhoneTypeList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New PhoneType
        AddHandler CType(e.NewObject, PhoneType).evtIsSavable, AddressOf PhoneTypeList_evtIsSavable
    End Sub

#End Region


End Class







