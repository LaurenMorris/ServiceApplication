Imports System.ComponentModel
Imports DatabaseHelper
Public Class TaxList

#Region " Private Members "

    Private WithEvents mList As New BindingList(Of Tax)

#End Region

#Region " Public Properties "

    Public ReadOnly Property List As BindingList(Of Tax)
        Get
            Return mList
        End Get
    End Property

#End Region

#Region " Public Methods "

    Public Function GetAll() As TaxList
        Dim db As New Database
        db.ConnectionName = My.Settings.ConnectionName
        Dim ds As DataSet
        db.Command.CommandType = CommandType.StoredProcedure
        db.Command.CommandText = "tblTax_GetAll"
        ' get data back from the database
        ds = db.ExecuteQuery

        For Each dr As DataRow In ds.Tables(0).Rows
            Dim tx As New Tax
            tx.InitializeHeaderData(dr)
            tx.InitializeBusinessData(dr)
            tx.IsNew = False
            tx.IsDirty = False
            mList.Add(tx)
            AddHandler tx.evtIsSavable, AddressOf TaxList_evtIsSavable
        Next
        ' return tax list
        Return Me
    End Function


    Public Function IsSavable() As Boolean
        Dim result As Boolean = False

        For Each tx As Tax In mList
            If tx.IsSavable = True Then
                result = True
                Exit For
            End If
        Next

        Return result
    End Function

    Public Function Save() As TaxList


        For Each tx As Tax In mList
            If tx.IsSavable = True Then
                tx = tx.Save()

            End If
        Next

        Return Me
    End Function

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Public Event Handlers "

    Public Sub TaxList_evtIsSavable(ByVal savable As Boolean)
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mList_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mList.AddingNew
        e.NewObject = New Tax
        AddHandler CType(e.NewObject, Tax).evtIsSavable, AddressOf TaxList_evtIsSavable
    End Sub

#End Region

End Class
