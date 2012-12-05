Public Class SearchCriteria
    Public Enum Type
        String_Starts_With = 0
        String_Ends_With = 1
        String_Contains = 2
        IntegerGT = 3
        IntegerLT = 4
        IntegerEQ = 5
        DateTime_Between = 6
        DateTime_LT = 7
        DateTime_GT = 8
        DateTime_EQ = 9
        [Boolean] = 10
        MoneyGT = 11
        MoneyLT = 12
        MoneyEQ = 13
    End Enum

    Public Enum [Boolean]
        [And] = 0
        [Or] = 1
    End Enum

    Public Enum OrderBy
        ASC = 0
        DESC = 1
        NONE = 2
    End Enum
End Class
