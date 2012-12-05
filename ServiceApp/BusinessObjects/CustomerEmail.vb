Imports DatabaseHelper
Public Class CustomerEmail
    Inherits HeaderData
#Region " Private Members "

    Private mCustomerID As Integer = 0
    Private mEmailTypeID As Integer = 0
    Private mEmail As String = String.Empty

#End Region

#Region " Public Properties "

    Public Property CustomerID As Integer
        Get
            Return mCustomerID
        End Get
        Set(ByVal value As Integer)
            If mCustomerID <> value Then
                mCustomerID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property EmailTypeID As Integer
        Get
            Return mEmailTypeID
        End Get
        Set(ByVal value As Integer)
            If mEmailTypeID <> value Then
                mEmailTypeID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Email As String
        Get
            Return mEmail
        End Get
        Set(ByVal value As String)
            If mEmail <> value Then
                mEmail = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property


#End Region

#Region " Public Methods "
    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As CustomerEmail
        Try
            Dim result As Boolean = True
            mCustomerID = CustomerID
            If MyBase.IsNew = True AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
                result = Insert(db)
            ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
                result = Delete(db)
            ElseIf MyBase.IsNew = False AndAlso MyBase.IsDirty = True AndAlso IsValid() Then
                result = Update(db)
            End If

            If result = False Then
                Throw New Exception("Customer email Save Failed")
            End If

            Me.IsDirty = False
            Me.IsNew = False
            Return Me
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function IsSavable() As Boolean

        Dim result As Boolean = False
        If MyBase.IsDirty = True AndAlso IsValid() = True Then
            result = True
        Else
            result = False
        End If
        Return result

    End Function

    Public Function GetById(ByVal id As Integer) As CustomerEmail

        Dim database As New Database
        Dim ds As New DataSet
        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.StoredProcedure
        database.Command.CommandText = "tblCustomerEmail_GetById"
        database.Command.Parameters.Add("@Id", SqlDbType.Int).Value = id
        ds = database.ExecuteQuery
        If ds.Tables(0).Rows.Count = 1 Then
            Dim dr As DataRow = ds.Tables(0).Rows(0)
            MyBase.InitializeHeaderData(dr)
            InitializeBusinessData(dr)
            MyBase.IsNew = False
            MyBase.IsDirty = False
            Return Me
        Else
            Throw New Exception("Customer Email Not Found")
        End If

    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mCustomerID = dr("CustomerID")
        mEmailTypeID = dr("EmailTypeID")
        mEmail = dr("Email")

    End Sub

#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database) As Boolean
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblCustomerEmail_INSERT"
            db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = mCustomerID
            db.Command.Parameters.Add("@EmailTypeID", SqlDbType.Int).Value = mEmailTypeID
            db.Command.Parameters.Add("@Email", SqlDbType.VarChar).Value = mEmail

            'setup header data parameters
            MyBase.InitializeParameters(db, 0)

            ' call to execute non query with transaction
            db.ExecuteNonQueryWithTransaction()

            ' pull the header data into the instance of the object
            MyBase.InitializeHeaderData(db.Command)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Private Function Update(ByVal db As Database) As Boolean

        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblCustomerEmail_UPDATE"
            db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = mCustomerID
            db.Command.Parameters.Add("@EmailTypeID", SqlDbType.Int).Value = mEmailTypeID
            db.Command.Parameters.Add("@Email", SqlDbType.VarChar).Value = mEmail

            'update header data parameters
            MyBase.InitializeParameters(db, MyBase.Id)

            ' call to execute non query with transaction
            db.ExecuteNonQueryWithTransaction()

            ' pull the header data into the instance of the object
            MyBase.InitializeHeaderData(db.Command)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function

    Private Function Delete(ByVal db As Database) As Boolean

        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblCustomerEmail_DELETE"

            'update header data parameters 
            MyBase.InitializeParameters(db, MyBase.Id)

            ' call to execute non query with transaction
            db.ExecuteNonQueryWithTransaction()

            ' pull the header data into the instance of the object
            MyBase.InitializeHeaderData(db.Command)
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function

    ' business rules or validation rules
    Private Function IsValid() As Boolean

        Dim result As Boolean = True
        If mEmailTypeID = 0 Then
            result = False
        End If
        If mEmail = String.Empty Then
            result = False
        End If
        Return result
    End Function

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

End Class







