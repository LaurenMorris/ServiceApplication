Imports System.Data.SqlClient ' tells which kind of database to connect to
Imports ConfigurationHelper.Configuration
Public Class Database

#Region " Private Members "

    Private cn As New SqlConnection
    Private cmd As New SqlCommand
    Private da As New SqlDataAdapter
    Private ds As New DataSet

    'name of connection will be passed in and stored here
    Private mConnectionName As String = String.Empty

#End Region

#Region " Public Properties "

    Public Property ConnectionName As String
        Get
            Return mConnectionName
        End Get
        Set(ByVal value As String)
            mConnectionName = value
        End Set
    End Property

    Public ReadOnly Property Command As SqlCommand
        Get
            Return cmd
        End Get
    End Property

#End Region

#Region " Public Methods "
    Public Sub BeginTransaction(ByVal name As String)
        ' get the connection string from the configuration helper
        cn.ConnectionString = GetConnectionString(name)
        ' open the connection string
        cn.Open()
        ' tell the command object about the connection
        cmd.Connection = cn
        ' begin the transaction based on the connection and 
        ' store it in the command object
        cmd.Transaction = cn.BeginTransaction
    End Sub

    Public Sub EndTransaction()
        ' commit to transaction
        cmd.Transaction.Commit()
        ' close the connection
        cn.Close()
    End Sub

    Public Sub RollBack()
        ' undo the transaction
        cmd.Transaction.Rollback()
        ' close the connection
        cn.Close()
    End Sub

    Public Function ExecuteNonQuery() As SqlCommand
        ' setup the connection string
        cn.ConnectionString = GetConnectionString(mConnectionName)
        ' open the connection 
        cn.Open()
        ' tell the command object about the connection
        cmd.Connection = cn
        ' do the work, access database
        cmd.ExecuteNonQuery()
        ' close the connection
        cn.Close()
        ' return the command object
        Return cmd

    End Function

    Public Function ExecuteNonQueryWithTransaction() As SqlCommand
        cmd.ExecuteNonQuery()
        Return cmd
    End Function

    Public Function ExecuteQuery() As DataSet
        ' setup connection string
        cn.ConnectionString = GetConnectionString(mConnectionName)
        ' open connection
        cn.Open()
        ' tell the command object about the connection
        cmd.Connection = cn
        ' tell the data adapter about the command object
        da.SelectCommand = cmd
        ' fill up the dataset with the data adapter
        da.Fill(ds)
        ' close the connection
        cn.Close()
        ' return the dataset
        Return ds
    End Function

    Public Function ExecuteScalar() As Integer
        ' setup connection string
        cn.ConnectionString = GetConnectionString(mConnectionName)
        ' open connection
        cn.Open()
        ' tell the command object about the connection
        cmd.Connection = cn
        ' execute scaler
        Dim count As Integer = cmd.ExecuteScalar()
        ' close the connection
        cn.Close()
        ' return the dataset
        Return count
    End Function

#End Region

#Region " Private Methods "

#End Region

End Class
