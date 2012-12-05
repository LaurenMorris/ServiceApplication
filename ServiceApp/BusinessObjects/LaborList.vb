Imports System.ComponentModel
Imports DatabaseHelper
Public Class LaborList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Labor)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Labor)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As LaborList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblLabor_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim l As New Labor
            l.InitializeHeaderData(dr)
            l.InitializeBusinessData(dr)
            l.IsNew = False
            l.IsDirty = False
            mList.Add(l)
            AddHandler l.evtIsSavable, AddressOf LaborList_evtIsSavable
        Next
        ' return labor list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each l As Labor In mList
            If l.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As LaborList


        For Each l As Labor In mList
            If l.IsSavable = True Then
                l = l.Save()

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

    Public Sub LaborList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Labor
        AddHandler CType(e.NewObject, Labor).evtIsSavable, AddressOf LaborList_evtIsSavable
    End Sub

#End Region


End Class








