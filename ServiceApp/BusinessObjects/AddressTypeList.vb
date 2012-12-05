Imports System.ComponentModel
Imports DatabaseHelper
Public Class AddressTypeList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of AddressType)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of AddressType)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As AddressTypeList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblAddressType_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim at As New AddressType
            at.InitializeHeaderData(dr)
            at.InitializeBusinessData(dr)
            at.IsNew = False
            at.IsDirty = False
            mList.Add(at)
            AddHandler at.evtIsSavable, AddressOf AddressTypeList_evtIsSavable
        Next
        ' return address type list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each at As AddressType In mList
            If at.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As AddressTypeList


        For Each at As AddressType In mList
            If at.IsSavable = True Then
                at = at.Save()

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

    Public Sub AddressTypeList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New AddressType
        AddHandler CType(e.NewObject, AddressType).evtIsSavable, AddressOf AddressTypeList_evtIsSavable
    End Sub

#End Region


End Class






