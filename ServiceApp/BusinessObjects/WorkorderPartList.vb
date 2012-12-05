Imports System.ComponentModel
Imports DatabaseHelper
Public Class WorkorderPartList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of WorkorderPart)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of WorkorderPart)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As WorkorderPartList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderPart_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wp As New WorkorderPart
            wp.InitializeHeaderData(dr)
            wp.InitializeBusinessData(dr)
            wp.IsNew = False
            wp.IsDirty = False
            mList.Add(wp)
            AddHandler wp.evtIsSavable, AddressOf WorkorderPartList_evtIsSavable
        Next
        ' return workorder part list
        Return Me
    End Function

    Public Function GetByWorkorderId(ByVal id As Integer) As WorkorderPartList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderPart_GetByWorkorderID"
        db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wp As New WorkorderPart
            wp.InitializeHeaderData(dr)
            wp.InitializeBusinessData(dr)
            wp.IsNew = False
            wp.IsDirty = False
            mList.Add(wp)
            AddHandler wp.evtIsSavable, AddressOf WorkorderPartList_evtIsSavable
        Next
        ' return workorderpart list by workorder id
        Return Me
    End Function

    Public Function GetByPartId(ByVal id As Integer) As WorkorderPartList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderPart_GetByPartID"
        db.Command.Parameters.Add("@PartID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wp As New WorkorderPart
            wp.InitializeHeaderData(dr)
            wp.InitializeBusinessData(dr)
            wp.IsNew = False
            wp.IsDirty = False
            mList.Add(wp)
            AddHandler wp.evtIsSavable, AddressOf WorkorderPartList_evtIsSavable
        Next
        ' return workorderpart list by part id
        Return Me
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each wp As WorkorderPart In mList
            If wp.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal workorderID As Integer) As Boolean
        Dim result As Boolean = True

        For Each wp As WorkorderPart In mList
            If wp.IsSavable = True Then
                wp = wp.Save(db, workorderID)
                If wp.IsNew = True Then
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
        db.Command.CommandText = "tblWorkorderPart_DeleteByWorkorderId"
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

    Public Sub WorkorderPartList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New WorkorderPart
        AddHandler CType(e.NewObject, WorkorderPart).evtIsSavable, AddressOf WorkorderPartList_evtIsSavable
    End Sub

#End Region


End Class




