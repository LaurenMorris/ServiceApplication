Imports System.ComponentModel
Imports DatabaseHelper
Public Class MakeList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Make)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Make)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As MakeList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblMake_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mk As New Make
            mk.InitializeHeaderData(dr)
            mk.InitializeBusinessData(dr)
            mk.IsNew = False
            mk.IsDirty = False
            mList.Add(mk)
            AddHandler mk.evtIsSavable, AddressOf MakeList_evtIsSavable
        Next
        ' return make list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each mk As Make In mList
            If mk.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As MakeList


        For Each mk As Make In mList
            If mk.IsSavable = True Then
                mk = mk.Save()

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

    Public Sub MakeList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Make
        AddHandler CType(e.NewObject, Make).evtIsSavable, AddressOf MakeList_evtIsSavable
    End Sub

#End Region


End Class










