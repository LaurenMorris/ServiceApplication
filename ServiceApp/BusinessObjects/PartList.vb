Imports System.ComponentModel
Imports DatabaseHelper
Public Class PartList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Part)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Part)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As PartList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPart_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim p As New Part
            p.InitializeHeaderData(dr)
            p.InitializeBusinessData(dr)
            p.IsNew = False
            p.IsDirty = False
            mList.Add(p)
            AddHandler p.evtIsSavable, AddressOf PartList_evtIsSavable
        Next
        ' return part list 
        Return Me
    End Function
    Public Function GetByManufacturerId(ByVal id As Integer) As PartList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblPart_GetByManufacturerID"
        db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = id
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim p As New Part
            p.InitializeHeaderData(dr)
            p.InitializeBusinessData(dr)
            p.IsNew = False
            p.IsDirty = False
            mList.Add(p)
            AddHandler p.evtIsSavable, AddressOf PartList_evtIsSavable
        Next
        ' return part list by manufacturer id
        Return Me
    End Function

    ''Public Function GetByWorkorderPartId(ByVal id As Integer) As PartList
    ''    Dim db As New Database
    ''    db.ConnectionName = My.Settings.ConnectionName
    ''    Dim ds As DataSet
    ''    db.Command.CommandType = CommandType.StoredProcedure
    ''    db.Command.CommandText = "tblPart_GetByWorkorderPartID"
    ''    db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = id
    ''    ' get data back from the database
    ''    ds = db.ExecuteQuery

    ''    For Each dr As DataRow In ds.Tables(0).Rows
    ''        Dim p As New Part
    ''        p.InitializeHeaderData(dr)
    ''        p.InitializeBusinessData(dr)
    ''        p.IsNew = False
    ''        p.IsDirty = False
    ''        mList.Add(p)
    ''        AddHandler p.evtIsSavable, AddressOf PartList_evtIsSavable
    ''    Next
    ''    ' return part list by workorderpart id
    ''    Return Me
    ''End Function

    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each p As Part In mList
            If p.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As PartList


        For Each p As Part In mList
            If p.IsSavable = True Then
                p = p.Save()
               
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

    Public Sub PartList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Part
        AddHandler CType(e.NewObject, Part).evtIsSavable, AddressOf PartList_evtIsSavable
    End Sub

#End Region


End Class





