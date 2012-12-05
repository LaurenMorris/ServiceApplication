Imports DatabaseHelper
Public Class Customer
    Inherits HeaderData
#Region " Private Members "

    Private mName As String = String.Empty
    Private WithEvents mEmails As CustomerEmailList = Nothing
    Private WithEvents mPhones As CustomerPhoneList = Nothing
    Private WithEvents mAddresses As CustomerAddressList = Nothing
    Private WithEvents mWorkorders As WorkorderList = Nothing

#End Region

#Region " Public Properties "

    Public Property Name As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            If mName <> value Then
                mName = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property


    Public ReadOnly Property Emails As CustomerEmailList
        Get
            If mEmails Is Nothing Then
                mEmails = New CustomerEmailList
                mEmails = mEmails.GetByCustomerID(MyBase.Id)
            End If
            Return mEmails
        End Get
    End Property

    Public ReadOnly Property Phones As CustomerPhoneList
        Get
            If mPhones Is Nothing Then
                mPhones = New CustomerPhoneList
                mPhones = mPhones.GetByCustomerID(MyBase.Id)
            End If
            Return mPhones
        End Get
    End Property

    Public ReadOnly Property Addresses As CustomerAddressList
        Get
            If mAddresses Is Nothing Then
                mAddresses = New CustomerAddressList
                mAddresses = mAddresses.GetByCustomerID(MyBase.Id)
            End If
            Return mAddresses
        End Get
    End Property

    Public ReadOnly Property Workorders As WorkorderList
        Get
            If mWorkorders Is Nothing Then
                mWorkorders = New WorkorderList
                mWorkorders = mWorkorders.GetByCustomerID(MyBase.Id)
            End If
            Return mWorkorders
        End Get
    End Property

#End Region

#Region " Public Methods "
    Public Function Save() As Customer
        Dim result As Boolean = True
        Try
            Dim database As New Database
            database.BeginTransaction(My.Settings.ConnectionName)

            If MyBase.IsNew = True AndAlso IsSavable() = True Then
                result = Insert(database)
            ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
                result = Delete(database)
                If result = True Then
                    result = DeleteTheChildren(database)
                End If
            ElseIf MyBase.IsNew = False AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
                result = Update(database)
            End If

            ' handle the children 
            If result = True AndAlso Emails.IsSavable = True Then
                result = mEmails.Save(database, MyBase.Id)
            End If

            If result = True AndAlso Phones.IsSavable = True Then
                result = mPhones.Save(database, MyBase.Id)
            End If

            If result = True AndAlso Addresses.IsSavable = True Then
                result = mAddresses.Save(database, MyBase.Id)
            End If

            If result = True AndAlso Workorders.IsSavable = True Then
                result = mWorkorders.Save(database, MyBase.Id)
            End If

            If result = True Then
                database.EndTransaction()
            Else : database.RollBack()
            End If

            Return Me
        Catch ex As Exception
            Throw ex

        End Try

    End Function

    Public Function IsSavable() As Boolean

        Dim result As Boolean = True
        If MyBase.IsDirty = True AndAlso IsValid() = True OrElse Emails.IsSavable = True OrElse Phones.IsSavable = True OrElse Addresses.IsSavable = True OrElse Workorders.IsSavable = True Then
            result = True
        Else
            result = False
        End If
        Return result

    End Function

    Public Function GetById(ByVal id As Integer) As Customer

        Dim database As New Database
        Dim ds As New DataSet
        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.StoredProcedure
        database.Command.CommandText = "tblCustomer_GetById"
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
            Throw New Exception("Customer Not Found")
        End If

    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mName = dr("Name")

    End Sub
    Public Sub InitializeBusinessData(ByVal o As Object)
        mName = o.Name

    End Sub
#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database) As Boolean
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblCustomer_INSERT"
            db.Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = mName
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
            db.Command.CommandText = "tblCustomer_UPDATE"
            db.Command.Parameters.Add("@Name", SqlDbType.VarChar).Value = mName

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
            db.Command.CommandText = "tblCustomer_DELETE"

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
        If mName = String.Empty Then
            result = False
        End If
        Return result
    End Function

    Private Function DeleteTheChildren(ByVal db As Database) As Boolean

        Try
            Dim result As Boolean = False
            result = Emails.DeleteByCustomerID(db, MyBase.Id)
            If result = True Then
                result = Phones.DeleteByCustomerID(db, MyBase.Id)
            End If
            If result = True Then
                result = Addresses.DeleteByCustomerID(db, MyBase.Id)
            End If
            If result = True Then
                result = Workorders.DeleteByCustomerID(db, MyBase.Id)
            End If
            Return result
        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region " Public Events "

    Public Delegate Sub eIsSavable(ByVal savable As Boolean)
    Public Event evtIsSavable As eIsSavable

#End Region

    Public Sub mEmails_evtIsSavable(savable As Boolean) Handles mEmails.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mAddresses_evtIsSavable(savable As Boolean) Handles mAddresses.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mPhones_evtIsSavable(savable As Boolean) Handles mPhones.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mWorkorders_evtIsSavable(savable As Boolean) Handles mWorkorders.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub
End Class








