Imports DatabaseHelper
Public Class Tax
    Inherits HeaderData

#Region " Private Members "

    Private mRate As Double = 0.0

#End Region

#Region " Public Properties "

    Public Property Rate As Double
        Get
            Return mRate
        End Get
        Set(ByVal value As Double)
            If value <> mRate Then
                mRate = value
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
            db.Command.CommandText = "tblTax_INSERT"
            db.Command.Parameters.Add("@Rate", SqlDbType.Money).Value = mRate
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
            db.Command.CommandText = "tblTax_DELETE"
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
            db.Command.CommandText = "tblTax_UPDATE"
            db.Command.Parameters.Add("@Rate", SqlDbType.Money).Value = mRate
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

        If mRate = 0.0 Then
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

    Public Function Save() As Tax
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

    Public Function GetById(ByVal Id As Integer) As Tax
        Try
            Dim db As New Database
            Dim ds As New DataSet
            db.ConnectionName = My.Settings.ConnectionName
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblTax_GetById"
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
                Throw New Exception("GetById: Tax Not Found")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mRate = dr("Rate")

    End Sub

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region



End Class
