Imports DatabaseHelper
Public Class WorkorderPart
    Inherits HeaderData
#Region " Private Members "

    Private mWorkorderID As Integer = 0
    Private mPartID As Integer = 0
    Private mQuantity As Integer = 0
    Private mCostPrice As Double = 0.0

#End Region

#Region " Public Properties "

    Public Property WorkorderID As Integer
        Get
            Return mWorkorderID
        End Get
        Set(ByVal value As Integer)
            If mWorkorderID <> value Then
                mWorkorderID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property PartID As Integer
        Get
            Return mPartID
        End Get
        Set(ByVal value As Integer)
            If mPartID <> value Then
                mPartID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Quantity As Integer
        Get
            Return mQuantity
        End Get
        Set(ByVal value As Integer)
            If mQuantity <> value Then
                mQuantity = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property CostPrice As Double
        Get
            Return mCostPrice
        End Get
        Set(ByVal value As Double)
            If mCostPrice <> value Then
                mCostPrice = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property


#End Region

#Region " Public Methods "

    Public Function Save(ByVal db As Database, ByVal WorkorderID As Integer) As WorkorderPart
        Try
            Dim result As Boolean = True
            mWorkorderID = WorkorderID
            If MyBase.IsNew = True AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
                result = Insert(db)
            ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
                result = Delete(db)
            ElseIf MyBase.IsNew = False AndAlso MyBase.IsDirty = True AndAlso IsValid() Then
                result = Update(db)
            End If

            If result = False Then
                Throw New Exception("Work Order Part Save Failed")
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

    Public Function GetById(ByVal id As Integer) As WorkorderPart

        Dim database As New Database
        Dim ds As New DataSet
        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.StoredProcedure
        database.Command.CommandText = "tblWorkorderPart_GetById"
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
            Throw New Exception("Workorder Part Not Found")
        End If

    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mWorkorderID = dr("WorkorderID")
        mPartID = dr("PartID")
        mQuantity = dr("Quantity")
        mCostPrice = dr("CostPrice")

    End Sub

#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database) As Boolean
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblWorkorderPart_INSERT"
            db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = mWorkorderID
            db.Command.Parameters.Add("@PartID", SqlDbType.Int).Value = mPartID
            db.Command.Parameters.Add("@Quantity", SqlDbType.Int).Value = mQuantity
            db.Command.Parameters.Add("@CostPrice", SqlDbType.Money).Value = mCostPrice

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
            db.Command.CommandText = "tblWorkorderPart_UPDATE"
            db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = mWorkorderID
            db.Command.Parameters.Add("@PartID", SqlDbType.Int).Value = mPartID
            db.Command.Parameters.Add("@Quantity", SqlDbType.Int).Value = mQuantity
            db.Command.Parameters.Add("@CostPrice", SqlDbType.Money).Value = mCostPrice

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
            db.Command.CommandText = "tblWorkorderPart_DELETE"

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
       
        If mPartID = 0 Then
            result = False
        End If
        If mQuantity = 0 Then
            result = False
        End If
        If mCostPrice = 0.0 Then
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





