Imports System.ComponentModel
Imports DatabaseHelper
Public Class TechnicianList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Technician)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Technician)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As TechnicianList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblTechnician_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim t As New Technician
            t.InitializeHeaderData(dr)
            t.InitializeBusinessData(dr)
            t.IsNew = False
            t.IsDirty = False
            mList.Add(t)
            AddHandler t.evtIsSavable, AddressOf TechnicianList_evtIsSavable
        Next
        ' return technician list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each t As Technician In mList
            If t.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As TechnicianList


        For Each t As Technician In mList
            If t.IsSavable = True Then
                t = t.Save()

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

    Public Sub TechnicianList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Technician
        AddHandler CType(e.NewObject, Technician).evtIsSavable, AddressOf TechnicianList_evtIsSavable
    End Sub

#End Region


End Class










