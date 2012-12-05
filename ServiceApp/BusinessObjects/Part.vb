﻿Imports DatabaseHelper
Public Class Part
    Inherits HeaderData

#Region " Private Members "

    Private mManufacturerID As Integer = 0
    Private mListPrice As Double = 0.0
    Private mMarkup As Double = 0.0

#End Region

#Region " Public Properties "

    Public Property ManufacturerID As Integer
        Get
            Return mManufacturerID
        End Get
        Set(ByVal value As Integer)
            If value <> mManufacturerID Then
                mManufacturerID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property ListPrice As Double
        Get
            Return mListPrice
        End Get
        Set(ByVal value As Double)
            If value <> mListPrice Then
                mListPrice = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Markup As Double
        Get
            Return mMarkup
        End Get
        Set(ByVal value As Double)
            If value <> mMarkup Then
                mMarkup = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database)
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblPart_INSERT"
            db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = mManufacturerID
            db.Command.Parameters.Add("@ListPrice", SqlDbType.Money).Value = mListPrice
            db.Command.Parameters.Add("@Markup", SqlDbType.Money).Value = mMarkup
            MyBase.InitializeParameters(db, 0)
            db.ExecuteNonQuery()
            MyBase.InitializeHeaderData(db.Command)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Private Function Delete(ByVal db As Database)
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblPart_DELETE"
            MyBase.InitializeParameters(db, MyBase.Id)
            db.ExecuteNonQuery()
            MyBase.InitializeHeaderData(db.Command)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function

    Private Function Update(ByVal db As Database)
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblPart_UPDATE"
            db.Command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = mManufacturerID
            db.Command.Parameters.Add("@ListPrice", SqlDbType.Money).Value = mListPrice
            db.Command.Parameters.Add("@Markup", SqlDbType.Money).Value = mMarkup
            MyBase.InitializeParameters(db, MyBase.Id)
            db.ExecuteNonQuery()
            MyBase.InitializeHeaderData(db.Command)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function


    Private Function IsValid() As Boolean
        Dim result As Boolean = True

        If mManufacturerID = 0 Then
            result = False
        End If
        If mListPrice = 0.0 Then
            result = False
        End If
        If mMarkup = 0.0 Then
            result = False
        End If
        Return result
    End Function

#End Region

#Region " Public Methods "

    Public Function IsSavable() As Boolean
        Dim result As Boolean = True
        If MyBase.IsDirty = True AndAlso IsValid() = True Then
            result = True
        Else
            result = False
        End If
        Return result
    End Function

    Public Function Save() As Part
        Dim result As Boolean = True
        Try
            Dim database As New Database
            database.ConnectionName = My.Settings.ConnectionName

            If MyBase.IsNew = True AndAlso IsSavable() = True Then
                result = Insert(database)
            ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
                result = Delete(database)
            ElseIf MyBase.IsNew = False AndAlso IsSavable() = True Then
                result = Update(database)
            End If

            MyBase.IsDirty = False
            MyBase.IsNew = False
            Return Me
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function GetById(ByVal Id As Integer) As Part
        Try
            Dim db As New Database
            Dim ds As New DataSet
            db.ConnectionName = My.Settings.ConnectionName
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblPart_GetById"
            db.Command.Parameters.Add("@Id", SqlDbType.Int).Value = Id
            ds = db.ExecuteQuery

            If ds.Tables(0).Rows.Count = 1 Then
                Dim dr As DataRow = ds.Tables(0).Rows(0)
                MyBase.InitializeHeaderData(dr)
                InitializeBusinessData(dr)
                MyBase.IsNew = False
                MyBase.IsDirty = False
                Return Me
            Else
                Throw New Exception("GetById: Part Not Found")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mManufacturerID = dr("ManufacturerID")
        mListPrice = dr("ListPrice")
        mMarkup = dr("Markup")
    End Sub

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Public Event Handlers "

#End Region

End Class


