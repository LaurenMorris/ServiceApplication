Imports System.ComponentModel
Imports DatabaseHelper
Public Class WorkorderCommentList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of WorkorderComment)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of WorkorderComment)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As WorkorderCommentList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderComment_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wc As New WorkorderComment
            wc.InitializeHeaderData(dr)
            wc.InitializeBusinessData(dr)
            wc.IsNew = False
            wc.IsDirty = False
            mList.Add(wc)
            AddHandler wc.evtIsSavable, AddressOf WorkorderCommentList_evtIsSavable
        Next
        ' return workorder comment list
        Return Me
    End Function

    Public Function GetByWorkorderId(ByVal id As Integer) As WorkorderCommentList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorderComment_GetByWorkorderID"
        db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim wc As New WorkorderComment
            wc.InitializeHeaderData(dr)
            wc.InitializeBusinessData(dr)
            wc.IsNew = False
            wc.IsDirty = False
            mList.Add(wc)
            AddHandler wc.evtIsSavable, AddressOf WorkorderCommentList_evtIsSavable
        Next
        ' return workordercomment list by workorder id
        Return Me
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each wc As WorkorderComment In mList
            If wc.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal workorderID As Integer) As Boolean
        Dim result As Boolean = True

        For Each wc As WorkorderComment In mList
            If wc.IsSavable = True Then
                wc = wc.Save(db, workorderID)
                If wc.IsNew = True Then
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
        db.Command.CommandText = "tblWorkorderComment_DeleteByWorkorderId"
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

    Public Sub WorkorderCommentList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New WorkorderComment
        AddHandler CType(e.NewObject, WorkorderComment).evtIsSavable, AddressOf WorkorderCommentList_evtIsSavable
    End Sub

#End Region


End Class





