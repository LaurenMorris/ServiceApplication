Imports System.ComponentModel
Imports DatabaseHelper
Public Class WorkorderList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Workorder)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Workorder)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As WorkorderList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorder_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim w As New Workorder
            w.InitializeHeaderData(dr)
            w.InitializeBusinessData(dr)
            w.IsNew = False
            w.IsDirty = False
            mList.Add(w)
            AddHandler w.evtIsSavable, AddressOf WorkorderList_evtIsSavable
        Next
        ' return workorder list
        Return Me
    End Function

    Public Function GetByCustomerID(ByVal id As Integer) As WorkorderList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorder_GetByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim w As New Workorder
            w.InitializeHeaderData(dr)
            w.InitializeBusinessData(dr)
            w.IsNew = False
            w.IsDirty = False
            mList.Add(w)
            AddHandler w.evtIsSavable, AddressOf WorkorderList_evtIsSavable
        Next
        ' return workorder list by customer id
        Return Me
    End Function

    Public Function DeleteByCustomerID(ByVal db As Database, ByVal id As Integer) As Boolean
        db.Command.Parameters.Clear()
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorder_DeleteByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
        db.ExecuteNonQueryWithTransaction()
        Return True
    End Function

    Public Function GetByMakeModelID(ByVal id As Integer) As WorkorderList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblWorkorder_GetByMakeModelID"
        db.Command.Parameters.Add("@MakeModelID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim w As New Workorder
            w.InitializeHeaderData(dr)
            w.InitializeBusinessData(dr)
            w.IsNew = False
            w.IsDirty = False
            mList.Add(w)
            AddHandler w.evtIsSavable, AddressOf WorkorderList_evtIsSavable
        Next
        ' return workorder list by makemodel id
        Return Me
    End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each w As Workorder In mList
            If w.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As Boolean


        Dim result As Boolean = True
        For Each w As Workorder In mList
            If w.IsSavable = True Then
                w = w.Save(db, CustomerID)
                If w.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

#End Region

#Region " Private Methods "

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Public Event Handlers "

    Public Sub WorkorderList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Workorder
        AddHandler CType(e.NewObject, Workorder).evtIsSavable, AddressOf WorkorderList_evtIsSavable
    End Sub

#End Region


End Class









