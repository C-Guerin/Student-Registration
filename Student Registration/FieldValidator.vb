Imports System.Text.RegularExpressions
Public Class FieldValidator

    Public Function ValidateStudentNum(s As String) As Boolean
        'Used to validate the Student Number.
        'Returns true if the field consists solely of 6 numbers
        Dim rgx As Regex = New Regex("^\d+$")
        If rgx.Match(s.ToString).Success AndAlso s.Length = 6 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ValidateName(s As String) As Boolean
        'Used to validate the FirstName and Surname fields
        'Returns true if string is in title case and consists only of letters
        Dim rgx As Regex = New Regex("^[A-Z][a-z]")
        Return rgx.Match(s).Success
    End Function


End Class