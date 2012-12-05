Imports System.ComponentModel
Imports DatabaseHelper
Public Class ModelList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Model)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Model)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As ModelList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblModel_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim m As New Model
            m.InitializeHeaderData(dr)
            m.InitializeBusinessData(dr)
            m.IsNew = False
            m.IsDirty = False
            mList.Add(m)
            AddHandler m.evtIsSavable, AddressOf ModelList_evtIsSavable
        Next
        ' return model list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each m As Model In mList
            If m.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As ModelList


        For Each m As Model In mList
            If m.IsSavable = True Then
                m = m.Save()

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

    Public Sub ModelList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Model
        AddHandler CType(e.NewObject, Model).evtIsSavable, AddressOf ModelList_evtIsSavable
    End Sub

#End Region


End Class









