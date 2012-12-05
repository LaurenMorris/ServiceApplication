Imports System.ComponentModel
Imports DatabaseHelper
Public Class EmailTypeList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of EmailType)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of EmailType)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As EmailTypeList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblEmailType_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim et As New EmailType
            et.InitializeHeaderData(dr)
            et.InitializeBusinessData(dr)
            et.IsNew = False
            et.IsDirty = False
            mList.Add(et)
            AddHandler et.evtIsSavable, AddressOf EmailTypeList_evtIsSavable
        Next
        ' return EmailType list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each et As EmailType In mList
            If et.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As EmailTypeList


        For Each et As EmailType In mList
            If et.IsSavable = True Then
                et = et.Save()

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

    Public Sub EmailTypeList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New EmailType
        AddHandler CType(e.NewObject, EmailType).evtIsSavable, AddressOf EmailTypeList_evtIsSavable
    End Sub

#End Region


End Class








