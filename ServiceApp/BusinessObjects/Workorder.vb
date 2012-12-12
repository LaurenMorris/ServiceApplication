Imports DatabaseHelper
Public Class Workorder
    Inherits HeaderData
#Region " Private Members "

    Private mCustomerID As Integer = 0
    Private mMakeModelID As Integer = 0
    Private mSerial As String = String.Empty
    Private mDateOpened As Date = DateTime.MaxValue
    Private mDateClosed As Date = DateTime.MaxValue
    Private mLaborRate As Double = 0.0
    Private mCost As Double = 0.0
    Private mTaxID As Integer = 0
    Private mTotalCost As Double = 0.0
    Private WithEvents mLaborHours As WorkorderLaborList = Nothing
    Private WithEvents mComments As WorkorderCommentList = Nothing
    Private WithEvents mParts As WorkorderPartList = Nothing

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

    Public Property MakeModelID As Integer
        Get
            Return mMakeModelID
        End Get
        Set(ByVal value As Integer)
            If mMakeModelID <> value Then
                mMakeModelID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Serial As String
        Get
            Return mSerial
        End Get
        Set(ByVal value As String)
            If mSerial <> value Then
                mSerial = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property DateOpened As Date
        Get
            Return mDateOpened
        End Get
        Set(ByVal value As Date)
            If mDateOpened <> value Then
                mDateOpened = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property DateClosed As Date
        Get
            Return mDateClosed
        End Get
        Set(ByVal value As Date)
            If mDateClosed <> value Then
                mDateClosed = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property LaborRate As Double
        Get
            Return mLaborRate
        End Get
        Set(ByVal value As Double)
            If mLaborRate <> value Then
                mLaborRate = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property Cost As Double
        Get
            Return mCost
        End Get
        Set(ByVal value As Double)
            If mCost <> value Then
                mCost = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property TaxID As Integer
        Get
            Return mTaxID
        End Get
        Set(ByVal value As Integer)
            If mTaxID <> value Then
                mTaxID = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public Property TotalCost As Double
        Get
            Return mTotalCost
        End Get
        Set(ByVal value As Double)
            If mTotalCost <> value Then
                mTotalCost = value
                MyBase.IsDirty = True
                RaiseEvent evtIsSavable(IsSavable)
            End If
        End Set
    End Property

    Public ReadOnly Property LaborHours As WorkorderLaborList
        Get
            If mLaborHours Is Nothing Then
                mLaborHours = New WorkorderLaborList
                mLaborHours = mLaborHours.GetByWorkorderId(MyBase.Id)
            End If
            Return mLaborHours
        End Get
    End Property

    Public ReadOnly Property Comments As WorkorderCommentList
        Get
            If mComments Is Nothing Then
                mComments = New WorkorderCommentList
                mComments = mComments.GetByWorkorderId(MyBase.Id)
            End If
            Return mComments
        End Get
    End Property

    Public ReadOnly Property Parts As WorkorderPartList
        Get
            If mParts Is Nothing Then
                mParts = New WorkorderPartList
                mParts = mParts.GetByWorkorderId(MyBase.Id)
            End If
            Return mParts
        End Get
    End Property

#End Region

#Region " Public Methods "
    Public Function Save(ByVal db As Database, ByVal CustomerID As Integer) As Workorder
        Try
            Dim result As Boolean = True
            mCustomerID = CustomerID
            If MyBase.IsNew = True AndAlso MyBase.IsDirty = True AndAlso IsValid() = True Then
                result = Insert(db)
            ElseIf MyBase.Deleted = True AndAlso MyBase.IsDirty = True Then
                result = Delete(db)
                If result = True Then
                    result = DeleteTheChildren(db)
                End If
            ElseIf MyBase.IsNew = False AndAlso MyBase.IsDirty = True AndAlso IsValid() Then
                result = Update(db)
            End If


            ' handle the children 
            If result = True AndAlso LaborHours.IsSavable = True Then
                result = mLaborHours.Save(db, MyBase.Id)
            End If

            If result = True AndAlso Comments.IsSavable = True Then
                result = mComments.Save(db, MyBase.Id)
            End If

            If result = True AndAlso Parts.IsSavable = True Then
                result = mParts.Save(db, MyBase.Id)
            End If

            Me.IsDirty = False
            Me.IsNew = False
            Return Me
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function IsSavable() As Boolean

        Dim result As Boolean = True
        If MyBase.IsDirty = True AndAlso IsValid() = True OrElse LaborHours.IsSavable = True OrElse Comments.IsSavable = True OrElse Parts.IsSavable = True Then
            result = True
        Else
            result = False
        End If
        Return result

    End Function

    Public Function GetById(ByVal id As Integer) As Workorder

        Dim database As New Database
        Dim ds As New DataSet
        database.ConnectionName = My.Settings.ConnectionName
        database.Command.CommandType = CommandType.StoredProcedure
        database.Command.CommandText = "tblWorkorder_GetById"
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
            Throw New Exception("Workorder Not Found")
        End If

    End Function

    Public Sub InitializeBusinessData(ByVal dr As DataRow)
        mCustomerID = dr("CustomerID")
        mMakeModelID = dr("MakeModelID")
        mSerial = dr("Serial")
        mDateOpened = dr("DateOpened")
        mDateClosed = dr("DateClosed")
        mLaborRate = dr("LaborRate")
        mCost = dr("Cost")
        mTaxID = dr("TaxID")
        mTotalCost = dr("TotalCost")

    End Sub

#End Region

#Region " Private Methods "

    Private Function Insert(ByVal db As Database) As Boolean
        Try
            db.Command.Parameters.Clear()
            db.Command.CommandType = CommandType.StoredProcedure
            db.Command.CommandText = "tblWorkorder_INSERT"
            db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = mCustomerID
            db.Command.Parameters.Add("@MakeModelID", SqlDbType.Int).Value = mMakeModelID
            db.Command.Parameters.Add("@Serial", SqlDbType.VarChar).Value = mSerial
            db.Command.Parameters.Add("@DateOpened", SqlDbType.Date).Value = mDateOpened
            db.Command.Parameters.Add("@DateClosed", SqlDbType.Date).Value = mDateClosed
            'db.Command.Parameters.Add("@LaborRate", SqlDbType.Money).Value = mLaborRate
            db.Command.Parameters.Add("@Cost", SqlDbType.Money).Value = mCost
            db.Command.Parameters.Add("@TaxID", SqlDbType.Int).Value = mTaxID
            db.Command.Parameters.Add("@TotalCost", SqlDbType.Money).Value = mTotalCost


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
            db.Command.CommandText = "tblWorkorder_UPDATE"
            db.Command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = mCustomerID
            db.Command.Parameters.Add("@MakeModelID", SqlDbType.Int).Value = mMakeModelID
            db.Command.Parameters.Add("@Serial", SqlDbType.VarChar).Value = mSerial
            db.Command.Parameters.Add("@DateOpened", SqlDbType.Date).Value = mDateOpened
            db.Command.Parameters.Add("@DateClosed", SqlDbType.Date).Value = mDateClosed
            db.Command.Parameters.Add("@LaborRate", SqlDbType.Money).Value = mLaborRate
            db.Command.Parameters.Add("@Cost", SqlDbType.Money).Value = mCost
            db.Command.Parameters.Add("@TaxID", SqlDbType.Int).Value = mTaxID
            db.Command.Parameters.Add("@TotalCost", SqlDbType.Money).Value = mTotalCost

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
            db.Command.CommandText = "tblWorkorder_DELETE"

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
        If mMakeModelID = 0 Then
            result = False
        End If
        If mSerial = String.Empty Then
            result = False
        End If
        If mTotalCost = 0.0 Then
            result = False
        End If
        If mLaborRate = 0.0 Then
            result = False
        End If
        If mCost = 0.0 Then
            result = False
        End If
        Return result
    End Function

    Private Function DeleteTheChildren(ByVal db As Database) As Boolean

        Try
            Dim result As Boolean = False
            result = LaborHours.DeleteByWorkorderId(db, MyBase.Id)
            If result = True Then
                result = Comments.DeleteByWorkorderId(db, MyBase.Id)
            End If
            If result = True Then
                result = Parts.DeleteByWorkorderId(db, MyBase.Id)
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

    Private Sub mComments_evtIsSavable(savable As Boolean) Handles mComments.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mLaborHours_evtIsSavable(savable As Boolean) Handles mLaborHours.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub

    Private Sub mParts_evtIsSavable(savable As Boolean) Handles mParts.evtIsSavable
        RaiseEvent evtIsSavable(savable)
    End Sub
End Class






