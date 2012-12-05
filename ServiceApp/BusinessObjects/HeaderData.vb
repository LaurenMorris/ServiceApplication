Imports DatabaseHelper
Imports System.Data.SqlClient
Public Class HeaderData
#Region " Private Members "

    Private mId As Integer = 0
    Private mVersion As Integer = 0
    Private mLastUpdated As DateTime = DateTime.MaxValue
    Private mDeleted As Boolean = False

    Private mIsDirty As Boolean = False
    Private mIsNew As Boolean = True

#End Region

#Region " Public Properties "

    Public Property Id As Integer
        Get
            Return mId
        End Get
        Set(ByVal value As Integer)
            mId = value
        End Set
    End Property

    Public Property Version As Integer
        Get
            Return mVersion
        End Get
        Set(ByVal value As Integer)
            mVersion = value
        End Set
    End Property

    Public Property LastUpdated As DateTime
        Get
            Return mLastUpdated
        End Get
        Set(ByVal value As DateTime)
            mLastUpdated = value
        End Set
    End Property

    Public Property Deleted As Boolean
        Get
            Return mDeleted
        End Get
        Set(ByVal value As Boolean)
            mDeleted = value
            mIsDirty = True
        End Set
    End Property

    Public Property IsNew As Boolean
        Get
            Return mIsNew
        End Get
        Set(ByVal value As Boolean)
            mIsNew = value
        End Set
    End Property

    Public Property IsDirty As Boolean
        Get
            Return mIsDirty
        End Get
        Set(ByVal value As Boolean)
            mIsDirty = value
        End Set
    End Property

#End Region

#Region " Public Methods "

    Public Sub InitializeParameters(ByVal database As Database, ByVal Id As Integer)
        Dim parm As New SqlParameter
        parm.ParameterName = "@Id"
        parm.Direction = ParameterDirection.InputOutput
        parm.SqlDbType = SqlDbType.Int
        parm.Value = Id
        database.Command.Parameters.Add(parm)

        parm = New SqlParameter
        parm.ParameterName = "@Version"
        parm.Direction = ParameterDirection.Output
        parm.SqlDbType = SqlDbType.Int
        parm.Value = 0
        database.Command.Parameters.Add(parm)

        parm = New SqlParameter
        parm.ParameterName = "@LastUpdated"
        parm.Direction = ParameterDirection.Output
        parm.SqlDbType = SqlDbType.DateTime
        parm.Value = DateTime.MaxValue
        database.Command.Parameters.Add(parm)

        parm = New SqlParameter
        parm.ParameterName = "@Deleted"
        parm.Direction = ParameterDirection.Output
        parm.SqlDbType = SqlDbType.Bit
        parm.Value = False
        database.Command.Parameters.Add(parm)

    End Sub

    Public Sub InitializeHeaderData(ByVal cmd As SqlCommand)
        mId = cmd.Parameters("@Id").Value
        mVersion = cmd.Parameters("@Version").Value
        mLastUpdated = cmd.Parameters("@LastUpdated").Value
        mDeleted = cmd.Parameters("@Deleted").Value

    End Sub

    Public Sub InitializeHeaderData(ByVal dr As DataRow)
        mId = dr("Id")
        mVersion = dr("Version")
        mLastUpdated = dr("LastUpdated")
        mDeleted = dr("Deleted")
    End Sub
    Public Sub InitializeHeaderData(ByVal o As Object)
        mId = o.Id
        mVersion = o.Version
        mLastUpdated = o.LastUpdated
        mDeleted = o.Deleted
    End Sub
#End Region

#Region " Private Methods "

#End Region

End Class
