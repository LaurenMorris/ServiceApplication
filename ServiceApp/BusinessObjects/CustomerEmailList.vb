Imports System.ComponentModel
Imports DatabaseHelper
Public Class CustomerEmailList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of CustomerEmail)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of CustomerEmail)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As CustomerEmailList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerEmail_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ce As New CustomerEmail
            ce.InitializeHeaderData(dr)
            ce.InitializeBusinessData(dr)
            ce.IsNew = False
            ce.IsDirty = False
            mList.Add(ce)
            AddHandler ce.evtIsSavable, AddressOf CustomerEmailList_evtIsSavable
        Next
        ' return customer email list
        Return Me
    End Function

    Public Function GetByCustomerID(ByVal id As Integer) As CustomerEmailList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerEmail_GetByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim ce As New CustomerEmail
            ce.InitializeHeaderData(dr)
            ce.InitializeBusinessData(dr)
            ce.IsNew = False
            ce.IsDirty = False
            mList.Add(ce)
            AddHandler ce.evtIsSavable, AddressOf CustomerEmailList_evtIsSavable
        Next
        ' return CustomerEmail list by customer id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each ce As CustomerEmail In mList
            If ce.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As Boolean

        Dim result As Boolean = True
        For Each ce As CustomerEmail In mList
            If ce.IsSavable = True Then
                ce = ce.Save(db, CustomerID)
                If ce.IsNew = True Then
                    result = False
                    Exit For
                End If
            End If
        Next

        Return result
    End Function

    Public Function DeleteByCustomerID(ByVal db As Database, ByVal id As Integer) As Boolean
        db.Command.Parameters.Clear()
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerEmail_DeleteByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
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

    Public Sub CustomerEmailList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New CustomerEmail
        AddHandler CType(e.NewObject, CustomerEmail).evtIsSavable, AddressOf CustomerEmailList_evtIsSavable
    End Sub

#End Region


End Class










