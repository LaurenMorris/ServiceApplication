Imports System.ComponentModel
Imports DatabaseHelper
Public Class CustomerPhoneList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of CustomerPhone)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of CustomerPhone)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As CustomerPhoneList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerPhone_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim cp As New CustomerPhone
            cp.InitializeHeaderData(dr)
            cp.InitializeBusinessData(dr)
            cp.IsNew = False
            cp.IsDirty = False
            mList.Add(cp)
            AddHandler cp.evtIsSavable, AddressOf CustomerPhoneList_evtIsSavable
        Next
        ' return customer phone list
        Return Me
    End Function

    Public Function GetByCustomerID(ByVal id As Integer) As CustomerPhoneList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerPhone_GetByCustomerID"
        db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim cp As New CustomerPhone
            cp.InitializeHeaderData(dr)
            cp.InitializeBusinessData(dr)
            cp.IsNew = False
            cp.IsDirty = False
            mList.Add(cp)
            AddHandler cp.evtIsSavable, AddressOf CustomerPhoneList_evtIsSavable
        Next
        ' return CustomerPhone list by customer id
        Return Me
    End Function

    Public Function GetByPhoneTypeID(ByVal id As Integer) As CustomerPhoneList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblCustomerPhone_GetByPhoneTypeID"
        db.Command.Parameters.Add("@PhoneTypeID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim cp As New CustomerPhone
            cp.InitializeHeaderData(dr)
            cp.InitializeBusinessData(dr)
            cp.IsNew = False
            cp.IsDirty = False
            mList.Add(cp)
            AddHandler cp.evtIsSavable, AddressOf CustomerPhoneList_evtIsSavable
        Next
        ' return CustomerPhone list by phoneType id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each cp As CustomerPhone In mList
            If cp.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As Boolean

        Dim result As Boolean = True
        For Each cp As CustomerPhone In mList
            If cp.IsSavable = True Then
                cp = cp.Save(db, CustomerID)
                If cp.IsNew = True Then
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
        db.Command.CommandText = "tblCustomerPhone_DeleteByCustomerID"
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

    Public Sub CustomerPhoneList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New CustomerPhone
        AddHandler CType(e.NewObject, CustomerPhone).evtIsSavable, AddressOf CustomerPhoneList_evtIsSavable
    End Sub

#End Region


End Class











