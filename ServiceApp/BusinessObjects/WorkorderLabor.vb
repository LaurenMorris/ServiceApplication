Imports DatabaseHelper
Public Class WorkorderLabor
    Inherits HeaderData
#Region " Private Members "

    Private mWorkorderID As Integer = 0
    Private mTechID As Integer = 0
    Private mDate As Date = DateTime.MaxValue
    Private mLaborHours As Double = 0.0

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

    Public Property TechID As Integer
        Get
            Return mTechID
        End Get
        Set(ByVal value As Integer)
            If mTechID <> value Then
                mTechID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property [Date] As Date
        Get
            Return mDate
        End Get
        Set(ByVal value As Date)
            If mDate <> value Then
                mDate = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property LaborHours As Double
        Get
            Return mLaborHours
        End Get
        Set(ByVal value As Double)
            If mLaborHours <> value Then
                mLaborHours = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

#End Region

#Region " Public Methods "
    Public Function Save(ByVal db As Database, ByVal WorkorderID As Integer) As WorkorderLabor
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
                Throw New Exception("Work Order Labor Save Failed")
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

    Public Function GetById(ByVal id As Integer) As WorkorderLabor

        Dim database As New Database
        Dim ds As New DataSet
        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.StoredProcedure
        database.Command.CommandText = "tblWorkorderLabor_GetById"
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
            Throw New Exception("Workorder Labor Not Found")
        End If

    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mWorkorderID = dr("WorkorderID")
        mTechID = dr("TechID")
        mDate = dr("Date")
        mLaborHours = dr("LaborHours")

    End Sub

#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database) As Boolean
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblWorkorderLabor_INSERT"
            db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = mWorkorderID
            db.Command.Parameters.Add("@TechID", SqlDbType.Int).Value = mTechID
            db.Command.Parameters.Add("@Date", SqlDbType.Date).Value = mDate
            db.Command.Parameters.Add("@LaborHours", SqlDbType.Decimal).Value = mLaborHours


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
            db.Command.CommandText = "tblWorkorderLabor_UPDATE"
            db.Command.Parameters.Add("@WorkorderID", SqlDbType.Int).Value = mWorkorderID
            db.Command.Parameters.Add("@TechID", SqlDbType.Int).Value = mTechID
            db.Command.Parameters.Add("@Date", SqlDbType.Date).Value = mDate
            db.Command.Parameters.Add("@LaborHours", SqlDbType.Decimal).Value = mLaborHours

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
            db.Command.CommandText = "tblWordorderLabor_DELETE"

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
        
        If mTechID = 0 Then
            result = False
        End If
        If mDate = DateTime.MaxValue Then
            result = False
        End If
        If mLaborHours = 0.0 Then
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



