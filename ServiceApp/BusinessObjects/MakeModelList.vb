Imports System.ComponentModel
Imports DatabaseHelper
Public Class MakeModelList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of MakeModel)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of MakeModel)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As MakeModelList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblMakeModel_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mkm As New MakeModel
            mkm.InitializeHeaderData(dr)
            mkm.InitializeBusinessData(dr)
            mkm.IsNew = False
            mkm.IsDirty = False
            mList.Add(mkm)
            AddHandler mkm.evtIsSavable, AddressOf MakeModelList_evtIsSavable
        Next
        ' return make/model list
        Return Me
    End Function


    Public Function GetByMakeID(ByVal id As Integer) As MakeModelList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblMakeModel_GetByMakeID"
        db.Command.Parameters.Add("@MakeID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mkm As New MakeModel
            mkm.InitializeHeaderData(dr)
            mkm.InitializeBusinessData(dr)
            mkm.IsNew = False
            mkm.IsDirty = False
            mList.Add(mkm)
            AddHandler mkm.evtIsSavable, AddressOf MakeModelList_evtIsSavable
        Next
        ' return MakeModel list by make id
        Return Me
    End Function

    Public Function GetByModelID(ByVal id As Integer) As MakeModelList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblMakeModel_GetByModelID"
        db.Command.Parameters.Add("@ModelID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim mkm As New MakeModel
            mkm.InitializeHeaderData(dr)
            mkm.InitializeBusinessData(dr)
            mkm.IsNew = False
            mkm.IsDirty = False
            mList.Add(mkm)
            AddHandler mkm.evtIsSavable, AddressOf MakeModelList_evtIsSavable
        Next
        ' return MakeModel list by model id
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each mkm As MakeModel In mList
            If mkm.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As MakeModelList


        For Each mkm As MakeModel In mList
            If mkm.IsSavable = True Then
                mkm = mkm.Save()

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

    Public Sub MakeModelList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New MakeModel
        AddHandler CType(e.NewObject, MakeModel).evtIsSavable, AddressOf MakeModelList_evtIsSavable
    End Sub

#End Region


End Class











