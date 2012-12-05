Imports System.ComponentModel
Imports DatabaseHelper
Public Class WorkorderLaborList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of WorkorderLabor)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of WorkorderLabor)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As WorkorderLaborList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderLabor_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wl As New WorkorderLabor
            wl.InitializeHeaderData(dr)
            wl.InitializeBusinessData(dr)
            wl.IsNew = False
            wl.IsDirty = False
            mList.Add(wl)
            AddHandler wl.evtIsSavable, AddressOf WorkorderLaborList_evtIsSavable
        Next
        ' return workorder labor list
        Return Me
    End Function

    Public Function GetByWorkorderId(ByVal id As Integer) As WorkorderLaborList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderLabor_GetByWorkorderID"
        db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wl As New WorkorderLabor
            wl.InitializeHeaderData(dr)
            wl.InitializeBusinessData(dr)
            wl.IsNew = False
            wl.IsDirty = False
            mList.Add(wl)
            AddHandler wl.evtIsSavable, AddressOf WorkorderLaborList_evtIsSavable
        Next
        ' return workorderlabor list by workorder id
        Return Me
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each wl As WorkorderLabor In mList
            If wl.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal workorderID As Integer) As Boolean
        Dim result As Boolean = True

        For Each wl As WorkorderLabor In mList
            If wl.IsSavable = True Then
                wl = wl.Save(db, workorderID)
                If wl.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

    Public Function DeleteByWorkorderId(ByVal db As Database, ByVal id As Integer) As Boolean
        db.Command.Parameters.Clear()
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderLabor_DeleteByWorkorderId"
        db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = id
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

    Public Sub WorkorderLaborList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New WorkorderLabor
        AddHandler CType(e.NewObject, WorkorderLabor).evtIsSavable, AddressOf WorkorderLaborList_evtIsSavable
    End Sub

#End Region


End Class



