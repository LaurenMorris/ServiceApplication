Imports DatatypeHelper.SearchCriteria
Public Class Builder
    Public Shared Function Build(ByVal crit As Criteria) As String

        Dim sql As String = String.Empty
        If crit.TableName <> String.Empty Then
            sql = "SELECT * FROM " + crit.TableName
            ' add the where clause to select fields from table
            ' if there are no fields entered, give the whole table 
            If crit.Fields.Count = 0 Then
                sql = sql + " WHERE [Deleted] = 'false'"
            Else
                sql = sql + " WHERE "
            End If

            For i As Integer = 0 To crit.Fields.Count - 1
                If crit.Types(i) = Type.String_Contains Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Starts_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Ends_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "'"
                End If

                If i < crit.Fields.Count - 1 Then
                    If crit.Boolean(i) = [Boolean].And Then
                        sql = sql + " AND "
                    Else
                        sql = sql + " OR "
                    End If
                Else
                    sql = sql + " AND Deleted = 'false'"
                End If
            Next

            If crit.OrderBy.Count > 0 Then
                sql = sql + " ORDER BY "
                For i As Integer = 0 To crit.OrderBy.Count - 1
                    If crit.OrderBy(i) = OrderBy.ASC Then
                        sql = sql + crit.Fields(i) + " ASC "
                    ElseIf crit.OrderBy(i) = OrderBy.DESC Then
                        sql = sql + crit.Fields(i) + " DESC "
                    End If
                    If i < crit.OrderBy.Count - 1 Then
                        sql = sql + " , "
                    End If
                Next
            End If
        Else
            Throw New Exception("Table name not specified in criteria object")
        End If
        Return sql
    End Function

    Public Shared Function BuildCount(ByVal crit As Criteria) As String

        Dim sql As String = String.Empty
        If crit.TableName <> String.Empty Then
            sql = "SELECT COUNT(*) FROM " + crit.TableName
            ' add the where clause to select fields from table
            ' if there are no fields entered, give the whole table 
            If crit.Fields.Count = 0 Then
                sql = sql + " WHERE [Deleted] = 'false'"
            Else
                sql = sql + " WHERE "
            End If

            For i As Integer = 0 To crit.Fields.Count - 1
                If crit.Types(i) = Type.String_Contains Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Starts_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Ends_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "'"
                End If

                If i < crit.Fields.Count - 1 Then
                    If crit.Boolean(i) = [Boolean].And Then
                        sql = sql + " AND "
                    Else
                        sql = sql + " OR "
                    End If
                Else
                    sql = sql + " AND Deleted = 'false'"
                End If
            Next

        Else
            Throw New Exception("Table name not specified in criteria object")
        End If
        Return sql
    End Function
    Public Shared Function BuildListCount(ByVal crit As Criteria, ByVal fieldName As String) As String

        Dim sql As String = String.Empty
        If crit.TableName <> String.Empty Then
            sql = "SELECT COUNT(Distinct " + fieldName + ") FROM " + crit.TableName
            ' add the where clause to select fields from table
            ' if there are no fields entered, give the whole table 
            If crit.Fields.Count = 0 Then
                sql = sql + " WHERE [Deleted] = 'false'"
            Else
                sql = sql + " WHERE "
            End If

            For i As Integer = 0 To crit.Fields.Count - 1
                If crit.Types(i) = Type.String_Contains Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Starts_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Ends_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "'"
                End If

                If i < crit.Fields.Count - 1 Then
                    If crit.Boolean(i) = [Boolean].And Then
                        sql = sql + " AND "
                    Else
                        sql = sql + " OR "
                    End If
                Else
                    sql = sql + " AND Deleted = 'false'"
                End If
            Next

        Else
            Throw New Exception("Table name not specified in criteria object")
        End If
        Return sql
    End Function
    Public Shared Function BuildList(ByVal crit As Criteria, ByVal fieldName As String) As String

        Dim sql As String = String.Empty
        If crit.TableName <> String.Empty Then
            sql = "SELECT Distinct " + fieldName + " FROM " + crit.TableName
            ' add the where clause to select fields from table
            ' if there are no fields entered, give the whole table 
            If crit.Fields.Count = 0 Then
                sql = sql + " WHERE [Deleted] = 'false'"
            Else
                sql = sql + " WHERE "
            End If

            For i As Integer = 0 To crit.Fields.Count - 1
                If crit.Types(i) = Type.String_Contains Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Starts_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '" + crit.Values(i) + "%'"
                ElseIf crit.Types(i) = Type.String_Ends_With Then
                    sql = sql + "[" + crit.Fields(i) + "]" + " LIKE '%" + crit.Values(i) + "'"
                End If

                If i < crit.Fields.Count - 1 Then
                    If crit.Boolean(i) = [Boolean].And Then
                        sql = sql + " AND "
                    Else
                        sql = sql + " OR "
                    End If
                Else
                    sql = sql + " AND Deleted = 'false'"
                End If
            Next

        Else
            Throw New Exception("Table name not specified in criteria object")
        End If
        Return sql
    End Function
End Class
