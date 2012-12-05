Imports DatabaseHelper
Public Class CustomerAddress
    Inherits HeaderData
#Region " Private Members "

    Private mCustomerID As Integer = 0
    Private mAddressTypeID As Integer = 0
    Private mAddress As String = String.Empty
    Private mCity As String = String.Empty
    Private mState As String = String.Empty
    Private mZip As String = String.Empty

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

    Public Property AddressTypeID As Integer
        Get
            Return mAddressTypeID
        End Get
        Set(ByVal value As Integer)
            If mAddressTypeID <> value Then
                mAddressTypeID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Address As String
        Get
            Return mAddress
        End Get
        Set(ByVal value As String)
            If mAddress <> value Then
                mAddress = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property City As String
        Get
            Return mCity
        End Get
        Set(ByVal value As String)
            If mCity <> value Then
                mCity = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property State As String
        Get
            Return mState
        End Get
        Set(ByVal value As String)
            If mState <> value Then
                mState = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Zip As String
        Get
            Return mZip
        End Get
        Set(ByVal value As String)
            If mZip <> value Then
                mZip = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property


#End Region

#Region " Public Methods "
    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As CustomerAddress
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
                Throw New Exception("Customer address Save Failed")
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

    Public Function GetById(ByVal id As Integer) As CustomerAddress

        Dim database As New Database
        Dim ds As New DataSet
        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.StoredProcedure
        database.Command.CommandText = "tblCustomerAddress_GetById"
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
            Throw New Exception("Customer Address Not Found")
        End If

    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mCustomerID = dr("CustomerID")
        mAddressTypeID = dr("AddressTypeID")
        mAddress = dr("Address")
        mCity = dr("City")
        mState = dr("State")
        mZip = dr("Zip")

    End Sub

#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database) As Boolean
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblCustomerAddress_INSERT"
            db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = mCustomerID
            db.Command.Parameters.Add("@AddressTypeID", SqlDbType.Int).Value = mAddressTypeID
            db.Command.Parameters.Add("@Address", SqlDbType.VarChar).Value = mAddress
            db.Command.Parameters.Add("@City", SqlDbType.VarChar).Value = mCity
            db.Command.Parameters.Add("@State", SqlDbType.VarChar).Value = mState
            db.Command.Parameters.Add("@Zip", SqlDbType.VarChar).Value = mZip
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
            db.Command.CommandText = "tblCustomerAddress_UPDATE"
            db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = mCustomerID
            db.Command.Parameters.Add("@AddressTypeID", SqlDbType.Int).Value = mAddressTypeID
            db.Command.Parameters.Add("@Address", SqlDbType.VarChar).Value = mAddress
            db.Command.Parameters.Add("@City", SqlDbType.VarChar).Value = mCity
            db.Command.Parameters.Add("@State", SqlDbType.VarChar).Value = mState
            db.Command.Parameters.Add("@Zip", SqlDbType.VarChar).Value = mZip

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
            db.Command.CommandText = "tblCustomerAddress_DELETE"

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
        If mAddressTypeID = 0 Then
            result = False
        End If
        If mAddress = String.Empty Then
            result = False
        End If
        If mCity = String.Empty Then
            result = False
        End If
        If mState = String.Empty Then
            result = False
        End If
        If mZip = String.Empty Then
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









