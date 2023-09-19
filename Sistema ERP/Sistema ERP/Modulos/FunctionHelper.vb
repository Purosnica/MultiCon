Imports System.Text.RegularExpressions

Public Class FunctionHelper


    Public Function emailaddresscheck(ByVal emailaddress As String) As Boolean
        Dim pattern As String = "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
        Dim emailAddressMatch As Match = Regex.Match(emailaddress, pattern)
        If emailAddressMatch.Success Then
            emailaddresscheck = True
        Else
            emailaddresscheck = False
        End If
    End Function


    Public Function CadenaInsert(ByRef _Table As String, ByRef _Type As String) As String
        Dim _Result As String
        Dim _SqlStr As String = ""

        Select Case _Type
            Case 1 : _SqlStr = "Insert into " + _Table + " ( "

            Case 2 : _SqlStr = " Delete from " + _Table + ""
            Case Else
                _SqlStr = " Update " + _Table + " set "

        End Select
        _Result = _SqlStr.ToString
        Return _Result

    End Function

End Class
