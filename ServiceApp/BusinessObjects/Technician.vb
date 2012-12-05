Imports DatabaseHelper
Public Class Technician
    Inherits HeaderData

#Region " Private Members "

    Private mFirstName As String = String.Empty
    Private mLastName As String = String.Empty
    Private mPhone As String = String.Empty
    Private mHireDate As Date = DateTime.MaxValue
    Private mActive As Boolean = False


#End Region

#Region " Public Properties "

    Public Property FirstName As String
        Get
            Return mFirstName
        End Get
        Set(ByVal value As String)
            If value <> mFirstName Then
                mFirstName = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property LastName As String
        Get
            Return mLastName
        End Get
        Set(ByVal value As String)
            If value <> mLastName Then
                mLastName = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Phone As String
        Get
            Return mPhone
        End Get
        Set(ByVal value As String)
            If value <> mPhone Then
                mPhone = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property HireDate As Date
        Get
            Return mHireDate
        End Get
        Set(ByVal value As Date)
            If value <> mHireDate Then
                mHireDate = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Active As Boolean
        Get
            Return mActive
        End Get
        Set(ByVal value As Boolean)
            If value <> mActive Then
                mActive = value
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
            db.Command.CommandText = "tblTechnician_INSERT"
            db.Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = mFirstName
            db.Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = mLastName
            db.Command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = mPhone
            db.Command.Parameters.Add("@HireDate", SqlDbType.Date).Value = mHireDate
            db.Command.Parameters.Add("@Active", SqlDbType.Bit).Value = mActive
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
            db.Command.CommandText = "tblTechnician_DELETE"
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
            db.Command.CommandText = "tblTechnician_UPDATE"
            db.Command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = mFirstName
            db.Command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = mLastName
            db.Command.Parameters.Add("@Phone", SqlDbType.VarChar).Value = mPhone
            db.Command.Parameters.Add("@HireDate", SqlDbType.Date).Value = mHireDate
            db.Command.Parameters.Add("@Active", SqlDbType.Bit).Value = mActive
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

        If mFirstName = String.Empty Then
            result = False
        End If
        If mLastName = String.Empty Then
            result = False
        End If
        If mPhone = String.Empty Then
            result = False
        End If
        If mHireDate = DateTime.MaxValue Then
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

    Public Function Save() As Technician
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

    Public Function GetById(ByVal Id As Integer) As Technician
        Try
            Dim db As New Database
            Dim ds As New DataSet
            db.ConnectionName = My.Settings.ConnectionName
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblTechnician_GetById"
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
                Throw New Exception("GetById: Tecnhician Not Found")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mFirstName = dr("FirstName")
        mLastName = dr("LastName")
        mPhone = dr("Phone")
        mHireDate = dr("HireDate")
        mActive = dr("Active")
    End Sub

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

#Region " Public Event Handlers "

#End Region

End Class



