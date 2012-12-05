Imports DatatypeHelper.SearchCriteria
Public Class Criteria

#Region " Private Members "
    Private mTableName As String = String.Empty
    Private mFields As New List(Of String)
    Private mValues As New List(Of String)
    Private mTypes As New List(Of Type)
    Private mBoolean As New List(Of DatatypeHelper.SearchCriteria.Boolean)
    Private mOrderBy As New List(Of DatatypeHelper.SearchCriteria.OrderBy)

#End Region

#Region " Public Properties "
    Public Property TableName As String
        Get
            Return mTableName
        End Get
        Set(ByVal value As String)
            mTableName = value
        End Set
    End Property

    Public ReadOnly Property Fields As List(Of String)
        Get
            Return mFields
        End Get
    End Property

    Public ReadOnly Property Values As List(Of String)
        Get
            Return mValues
        End Get
    End Property

    Public ReadOnly Property Types As List(Of Type)
        Get
            Return mTypes
        End Get
    End Property

    Public ReadOnly Property [Boolean] As List(Of [Boolean])
        Get
            Return mBoolean
        End Get
    End Property

    Public ReadOnly Property OrderBy As List(Of OrderBy)
        Get
            Return mOrderBy
        End Get
    End Property
#End Region

#Region " Construction "
    ' whenever creating a new instance of the criteria class, forces you to put parameter 
    'to pass the table name in when creating the instance

#End Region

End Class
