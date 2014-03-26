Option Strict On
Imports Microsoft.VisualBasic
Imports System.IO
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils

Namespace ServelInvocing.Data

    ''' <summary>
    ''' The FormulaUtils class contains a set of functions that are available
    ''' in the Formula editor.  You can specify any of these functions after
    ''' the = sign.
    ''' For example, you can say:
    '''     = IsEven(32)
    ''' These functions throw an exception on an error.  The formula evaluator
    ''' catches this exception and returns the error string to the user interface.
    '''
    ''' All of the functions operate as a Decimal.  The Decimal data type is better
    ''' then Double or Single since it provides a more accurate value as compared to
    ''' Double, and a larger value as compared to a Single.  All integers, doubles, etc.
    ''' are converted to Decimals as part of these functions.
    '''
    ''' Function names are not case sensitive. So you can use ROUND, Round, round, etc.
    '''
    ''' </summary>
    ''' <remarks></remarks>
    Public Class BaseFormulaUtils


#Region "Information Functions"

        ''' <summary>
        ''' Check if the number is Even or not.  
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">Number to be checked</param>
        ''' <returns>True if the input is even, False otherwise.</returns>
        Public Shared Function IsEven(ByVal val As Object) As Boolean
            Dim valDecimal As Decimal = 0
            Try
                valDecimal = ParseDecimal(val)
                Return (valDecimal Mod 2 = 0)
            Catch ex As Exception
                Throw New Exception("ISEVEN(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Check if the input is odd or not
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">Number to be checked</param>
        ''' <returns>True if the input is odd, False otherwise.</returns>
        Public Shared Function IsOdd(ByVal val As Object) As Boolean
            Dim valDecimal As Decimal
            Try
                valDecimal = ParseDecimal(val)
                Return (valDecimal Mod 2 <> 0)
            Catch ex As Exception
                Throw New Exception("ISODD(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Check if the input is a number or not
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">Number to be checked</param>
        ''' <returns>True if the input is a number, False otherwise.</returns>
        Public Shared Function IsNumber(ByVal val As Object) As Boolean
            Dim valDecimal As Decimal
            Try
                valDecimal = ParseDecimal(val)
                ' If we are successfully parsing the number, then return True
                Return True
            Catch
                ' Ignore exception, just fall through and return false
            End Try
            Return False
        End Function

        ''' <summary>
        ''' Check if the input is logical or not
        ''' </summary>
        ''' <param name="val">Value to be checked</param>
        ''' <returns>True if the input is a boolean, False otherwise.</returns>
        Public Shared Function IsLogical(ByVal val As Object) As Boolean
            Dim valBoolean As Boolean
            Try
                valBoolean = Convert.ToBoolean(val)
                ' If we are able to successfully convert the value, then return True
                Return True
            Catch
                ' Ignore exception, just fall through and return false
            End Try
            Return False
        End Function

        ''' <summary>
        ''' Check if the input is null or not
        ''' </summary>
        ''' <param name="val">Value to be checked</param>
        ''' <returns>True if the input is null</returns>
        Public Shared Function IsNull(ByVal val As Object) As Boolean
            ' If val is nothing, then return True
            Return (IsNothing(val))
        End Function

        ''' <summary>
        ''' Check if the value entered is blank or not.  A NULL value is considered blank.
        ''' </summary>
        ''' <param name="val">Value to be checked</param>
        ''' <returns>True if the input is blank</returns>
        Public Shared Function IsBlank(ByVal val As Object) As Boolean
            If IsNothing(val) Then Return True

            If val.GetType Is GetType(String) AndAlso CType(val, String).Trim.Length = 0 Then Return True

            Return False
        End Function

        ''' <summary>
        ''' Check if the value entered is a text or not
        ''' </summary>
        ''' <param name="val">Value to be checked</param>
        ''' <returns>True if the input is text</returns>
        Public Shared Function IsText(ByVal val As Object) As Boolean
            If IsNothing(val) Then Return False

            If (val.GetType() Is GetType(String)) Then Return True

            Return False
        End Function

#End Region

#Region "Mathematical Functions"

        ''' <summary>
        ''' Calculate the absolute value of the argument passed
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">The input whose absolute value is to be found.</param>
        ''' <returns>The absolute value of the number.</returns>
        Public Shared Function Abs(ByVal val As Object) As Decimal
            Try
                Return Math.Abs(ParseDecimal(val))
            Catch ex As Exception
                Throw New Exception("ABS(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculate the ceiling value of the argument passed
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">The input whose ceiling value is to be calculated.</param>
        ''' <returns>The ceiling value of the number.</returns>
        Public Shared Function Ceiling(ByVal val As Object) As Decimal
            Try
                Return Math.Ceiling(ParseDecimal(val))
            Catch ex As Exception
                Throw New Exception("CEILING(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculates the exponential value of the input
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">The input whose exponential value to be calculated</param>
        ''' <returns>
        ''' The exponential value of the input
        ''' </returns>
        Public Shared Function Exp(ByVal val As Object) As Decimal
            Try
                Return Convert.ToDecimal(Math.Exp(ParseDecimal(val)))
            Catch ex As Exception
                Throw New Exception("EXP(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculates the floor value of the input
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">The input whose floor value to be calculated</param>
        ''' <returns>
        ''' The floor value of the input
        ''' </returns>
        Public Shared Function Floor(ByVal val As Object) As Decimal
            Try
                Return Math.Floor(ParseDecimal(val))
            Catch ex As Exception
                Throw New Exception("FLOOR(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculates the mod value of the division 
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="dividend">The dividend</param>
        ''' <param name="divisor">The divisor</param>
        ''' <returns>
        ''' The mod value of the division.
        ''' </returns>
        Public Shared Function Modulus(ByVal dividend As Object, ByVal divisor As Object) As Decimal
            Dim dividendDecimal As Decimal = 0
            Dim divisorDecimal As Decimal = 0
            Try
                dividendDecimal = ParseDecimal(dividend)
                divisorDecimal = ParseDecimal(divisor)
                Return dividendDecimal Mod divisorDecimal
            Catch ex As Exception
                Throw New Exception("MODULUS(" & GetStr(dividendDecimal) & ", " & GetStr(divisorDecimal) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculate the value of val1 raised to the power of val2
        ''' The number can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val1">The base</param>
        ''' <param name="val2">The power</param>
        ''' <returns>
        ''' The val1 raised to the power of val2
        ''' </returns>
        Public Shared Function Power(ByVal val1 As Object, ByVal val2 As Object) As Decimal
            Try
                Return Convert.ToDecimal(Math.Pow(ParseDecimal(val1), ParseDecimal(val2)))
            Catch ex As Exception
                Throw New Exception("POWER(" & GetStr(val1) & ", " & GetStr(val2) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Return the value of PI as a Decimal.
        ''' </summary>
        Public Shared Function Pi() As Decimal
            Return Convert.ToDecimal(Math.PI)
        End Function

        ''' <summary>
        ''' Calculate the quotient of the division 
        ''' The number(s) can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="dividend">The dividend of the division</param>
        ''' <param name="divisor">The divisor of the division</param>
        ''' <returns>
        ''' The quotient of the division.
        ''' </returns>
        Public Shared Function Quotient(ByVal dividend As Object, ByVal divisor As Object) As Decimal
            Try
                ' \ is used for integer value of division
                Return Convert.ToDecimal(CInt(dividend) \ CInt(divisor))
            Catch ex As Exception
                Throw New Exception("QUOTIENT(" & GetStr(dividend) & ", " & GetStr(divisor) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Round value up to the specified number of decimal places
        ''' The number(s) can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="number">Number to be rounded</param>
        ''' <param name="numberOfDigits">Number of decimals to be rounded upto</param>
        ''' <returns>The rounded up value.</returns>
        Public Shared Function Round(ByVal number As Object, ByVal numberOfDigits As Object) As Decimal
            Try
                Return Math.Round(ParseDecimal(number), CInt(ParseInteger(numberOfDigits)))
            Catch ex As Exception
                Throw New Exception("ROUND(" & GetStr(number) & ", " & GetStr(numberOfDigits) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculate the square root value of the input
        ''' The number(s) can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">The argument whose square root is to be calculated</param>
        ''' <returns>The square root.</returns>
        Public Shared Function Sqrt(ByVal val As Object) As Decimal
            Try
                Return Convert.ToDecimal(Math.Sqrt(ParseDecimal(val)))
            Catch ex As Exception
                Throw New Exception("SQRT(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculate the truncated value of the input
        ''' The number(s) can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val">The argument whose truncated value is to be calculated</param>
        ''' <returns>The truncated value.</returns>
        Public Shared Function Trunc(ByVal val As Object) As Decimal
            Try
                Return Convert.ToDecimal(Math.Truncate(ParseDecimal(val)))
            Catch ex As Exception
                Throw New Exception("TRUNC(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculate the logarithmic value to the specified base
        ''' The number(s) can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val1">The argument whose log value is to be calculated</param>
        ''' <param name="val2">The base of the log value</param>
        ''' <returns>The log value</returns>
        Public Shared Function Log(ByVal val1 As Object, ByVal val2 As Object) As Decimal
            Try
                Return Convert.ToDecimal(Math.Log(ParseDecimal(val1), ParseDecimal(val2)))
            Catch ex As Exception
                Throw New Exception("LOG(" & GetStr(val1) & ", " & GetStr(val2) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Calculate the logarithmic value to the base 10
        ''' The number(s) can be specified as an integer (e.g., 37), a decimal 
        ''' value (e.g., 37.48), as a string with an optional currency symbol and 
        ''' separators ("1,234.56", "$1,234.56"), or as the value of a 
        ''' variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="val1">The argument whose log value is to be calculated</param>
        ''' <returns>The log value.</returns>
        Public Shared Function Log(ByVal val As Object) As Decimal
            Try
                Return Convert.ToDecimal(Math.Log10(ParseDecimal(val)))
            Catch ex As Exception
                Throw New Exception("LOG(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

#End Region

#Region "Boolean Functions"

        ''' <summary>
        ''' Calculate the AND value of the input array
        ''' The value can be specified as a decimal value (e.g., 37.48), 
        ''' as a string (“True”), as a Boolean (e.g., True), as an expression (e.g., 1+1=2), 
        ''' or as the value of a variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="args">The array of booleans whose AND value is to be calculated</param>
        ''' <returns>The and value.</returns>
        Public Shared Function And1(ByVal ParamArray args As Object()) As Boolean
            Dim andValue As Boolean = True
            ' Iterate the loop to get the individual values from the group of parameters
            For Each booleanValue As Object In args
                If (Not IsNothing(booleanValue)) Then
                    Try
                        andValue = andValue AndAlso Convert.ToBoolean(booleanValue)
                        If (andValue = False) Then Return andValue
                    Catch
                        'if a value is non-boolean, we will ignore this value.
                    End Try
                End If
            Next
            Return andValue
        End Function

        ''' <summary>
        ''' Calculate the OR value of the input array
        ''' The value can be specified as a decimal value (e.g., 37.48), 
        ''' as a string (“True”), as a Boolean (e.g., True), as an expression (e.g., 1+1=2), 
        ''' or as the value of a variable (e.g, UnitPrice).
        ''' </summary>
        ''' <param name="args">The array of booleans whose OR value is to be calculated</param>
        ''' <returns>The or value.</returns>
        Public Shared Function Or1(ByVal ParamArray args As Object()) As Boolean
            Dim orValue As Boolean = False
            ' Iterate the loop to get the individual values from the group of parameters
            For Each booleanValue As Object In args
                If (Not IsNothing(booleanValue)) Then
                    Try
                        orValue = orValue OrElse Convert.ToBoolean(booleanValue)
                        If (orValue = False) Then Return orValue
                    Catch
                        'if a value is non-boolean, we will ignore this value.
                    End Try
                End If
            Next
            Return orValue
        End Function

        ''' <summary>
        ''' Calculate the NOT value of the specified boolean value
        ''' </summary>
        ''' <param name="value">The boolean value whose NOT is to be determined</param>
        ''' <returns>The not value.</returns>
        Public Shared Function Not1(ByVal value As Object) As Boolean
            Dim notValue As Boolean = False
            Try
                Return Not Convert.ToBoolean(value)
            Catch ex As Exception
                Throw New Exception("NOT1(" & GetStr(value) & "): " & ex.Message)
            End Try
        End Function
#End Region

#Region "String Functions"

        ''' <summary>
        ''' Return a character for the corresponding ascii value
        ''' </summary>
        ''' <param name="val">Ascii Value</param>
        ''' <returns>Charcter for the corresponding ascii value</returns>
        Public Shared Function Character(ByVal val As Object) As Char
            Try
                Return Convert.ToChar(val)
            Catch ex As Exception
                Throw New Exception("CHARACTER(" & GetStr(val) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Check if two strings are exactly same or not
        ''' </summary>
        ''' <param name="val1">1st String</param>
        ''' <param name="val2">2nd String</param>
        ''' <returns>True if the two strings are exactly same else returns false</returns>
        Public Shared Function Exact(ByVal val1 As Object, ByVal val2 As Object) As Boolean
            Try
                val1 = GetStr(val1)
                val2 = GetStr(val2)
                If (val1.Equals(val2)) Then
                    Return True
                Else : Return False
                End If
            Catch ex As Exception
                Throw New Exception("EXACT(" & GetStr(val1) & ", " & GetStr(val2) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Find the index of the occurrence of the 1st string in the 2nd string specified
        ''' </summary>
        ''' <param name="val1">String to be searched</param>
        ''' <param name="val2">String to be searched in</param>
        ''' <returns>The index of the occurrence of the 1st string in the 2nd string and -1 if the string not found</returns>
        Public Shared Function Find(ByVal val1 As Object, ByVal val2 As Object) As Integer
            Dim val1String As String = String.Empty
            Dim val2String As String = String.Empty
            Try
                If Not IsNothing(val1) Then val1String = val1.ToString
                If Not IsNothing(val2) Then val2String = val2.ToString

                Return val2String.IndexOf(val1String, 0)
            Catch ex As Exception
                Throw New Exception("FIND(" & GetStr(val1) & ", " & GetStr(val2) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Find the index of the occurrence of the 1st string in the 2nd string,
        ''' the search starts after a specified start position
        ''' </summary>
        ''' <param name="val1">String to be searched</param>
        ''' <param name="val2">String to be searched in</param>
        ''' <param name="index">The position after which the search should start</param>
        ''' <returns>The index of the occurrence of the 1st string in the 2nd string and -1 if the string is not found</returns>
        Public Shared Function Find(ByVal val1 As Object, ByVal val2 As Object, ByVal index As Integer) As Integer
            Dim val1String As String = String.Empty
            Dim val2String As String = String.Empty
            Try
                If Not IsNothing(val1) Then val1String = val1.ToString
                If Not IsNothing(val2) Then val2String = val2.ToString

                Return val2String.IndexOf(val1String, index)
            Catch ex As Exception
                Throw New Exception("FIND(" & GetStr(val1) & ", " & GetStr(val2) & ", " & index & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Returns the  string from left till the index mentioned
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <param name="length">The length of string to be returned</param>
        ''' <returns>The string of specified length from the start</returns>
        Public Shared Function Left(ByVal str As Object, ByVal length As Integer) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString

                Return inputString.Substring(0, length)
            Catch ex As Exception
                Throw New Exception("LEFT(" & GetStr(str) & ", " & length & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Returns the specified number of characters from the right end of the string
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <param name="length">The number of characters</param>
        ''' <returns>The specified number of characters from the right end of the string</returns>
        Public Shared Function Right(ByVal str As Object, ByVal length As Integer) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString

                Return inputString.Substring(inputString.Length - length, length)
            Catch ex As Exception
                Throw New Exception("RIGHT(" & GetStr(str) & ", " & length & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Returns the left most character of the string
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>The first character of string</returns>
        Public Shared Function Left(ByVal str As Object) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.Substring(0, 1)
            Catch ex As Exception
                Throw New Exception("LEFT(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Returns the right most character of the string
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>The last character of a string</returns>
        Public Shared Function Right(ByVal str As Object) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.Substring(inputString.Length - 1, 1)
            Catch ex As Exception
                Throw New Exception("RIGHT(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Returns the length of the string
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>The length of the string</returns>
        Public Shared Function Len(ByVal str As Object) As Integer
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.Length
            Catch ex As Exception
                Throw New Exception("LEN(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Converts the string to lower case  
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>The string which is lower case</returns>
        Public Shared Function Lower(ByVal str As Object) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.ToLower()
            Catch ex As Exception
                Throw New Exception("LOWER(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Converts the string to upper case
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>The string which is upper case</returns>
        Public Shared Function Upper(ByVal str As Object) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.ToUpper()
            Catch ex As Exception
                Throw New Exception("UPPER(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Retrieves the substring from the specified index and of specified length
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <param name="startIndex">The start index of retrieval</param>
        ''' <param name="length">Length of the string to be retrieved</param>
        ''' <returns>The substring</returns>
        Public Shared Function Mid(ByVal str As Object, ByVal startIndex As Integer, ByVal length As Integer) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.Substring(startIndex, length)
            Catch ex As Exception
                Throw New Exception("MID(" & GetStr(str) & ", " & startIndex & ", " & length & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Retrieves the substring from the specified index and of specified length
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <param name="startIndex">The start index of retrieval</param>
        ''' <param name="length">Length of the string to be retrieved</param>
        ''' <returns>The substring</returns>
        Public Shared Function Substring(ByVal str As Object, ByVal startIndex As Integer, ByVal length As Integer) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                Return inputString.Substring(startIndex, length)
            Catch ex As Exception
                Throw New Exception("SUBSTRING(" & GetStr(str) & ", " & startIndex & ", " & length & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Retrieves the substring from the specified index till the end of the string
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <param name="startIndex">The start index of retrieval</param>
        ''' <returns>The substring</returns>
        Public Shared Function Substring(ByVal str As Object, ByVal startIndex As Integer) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                ' As we are using a 1 based indexing we are using .Length 
                ' which returns the exact length
                Return inputString.Substring(startIndex, inputString.Length - startIndex)
            Catch ex As Exception
                Throw New Exception("SUBSTRING(" & GetStr(str) & ", " & startIndex & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Capitalizes the first character of the string passed.
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>The Capitalized string</returns>
        Public Shared Function Capitalize(ByVal str As Object) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(str) Then inputString = str.ToString
                ' As we are using a 1 based indexing we are using .Length 
                ' which returns the exact length
                Return inputString.Substring(0, 1).ToUpper & inputString.Substring(1, inputString.Length - 1)
            Catch ex As Exception
                Throw New Exception("CAPITALIZE(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Replaces the specified part of a string with a new string
        ''' </summary>
        ''' <param name="oldString">String to be operated upon</param>
        ''' <param name="startIndex">The start index of the part to be replaced</param>
        ''' <param name="length">The length of the part to be replaced</param>
        ''' <param name="newString">The new string which replaces the old string.</param>
        ''' <returns>The replaced string</returns>
        Public Shared Function Replace(ByVal oldString As Object, ByVal startIndex As Integer, ByVal length As Integer, ByVal newString As Object) As String
            Dim inputString As String = String.Empty
            Try
                If Not IsNothing(oldString) Then inputString = oldString.ToString
                Return inputString.Substring(0, startIndex) & newString.ToString & inputString.Substring(startIndex + length)
            Catch ex As Exception
                Throw New Exception("REPLACE(" & GetStr(oldString) & ", " & startIndex & ", " & length & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        '''  Repeats the specified text specified number of times 
        ''' </summary>
        ''' <param name="text">Text to be repeated</param>
        ''' <param name="numberOfTimes">The number of times text is to be repeated</param>
        ''' <returns>The string with repeatetive text in it</returns>
        Public Shared Function Rept(ByVal text As Object, ByVal numberOfTimes As Integer) As String
            Dim textStr As String = String.Empty
            Dim finalString As String = String.Empty
            Dim i As Integer = 0
            ' We are using a 1 based indexing in this function
            If Not IsNothing(text) Then textStr = text.ToString
            Try
                For i = 0 To numberOfTimes - 1
                    finalString = finalString & textStr
                Next
                Return finalString
            Catch ex As Exception
                Throw New Exception("REPT(" & GetStr(text) & ", " & numberOfTimes & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Concatenates the arguments in the array
        ''' </summary>
        ''' <param name="args">Array of arguments</param>
        ''' <returns>Concatenated string</returns>
        Public Shared Function Concatenate(ByVal ParamArray args As Object()) As String
            Dim finalString As String = String.Empty
            ' We are using a 1 based indexing in this function
            Try
                For Each str As Object In args
                    If Not IsNothing(str) Then finalString = finalString & str.ToString
                Next
                Return finalString
            Catch ex As Exception
                Throw New Exception("CONCATENATE(" & GetStr(args) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Trims the leading and trailing spaces
        ''' </summary>
        ''' <param name="str">String to be operated upon</param>
        ''' <returns>Trimmed string</returns>
        Public Shared Function Trim(ByVal str As Object) As String
            Try
                Dim finalString As String = String.Empty
                If Not IsNothing(str) Then finalString = str.ToString.Trim()
                Return finalString
            Catch ex As Exception
                Throw New Exception("TRIM(" & GetStr(str) & "): " & ex.Message)
            End Try
        End Function
#End Region

#Region "DateTime Functions"

        ''' <summary>
        ''' Retrieves the hours from the date
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The hour part of the date and if date is empty string then returns today's hours</returns>
        Public Shared Function Hour(ByVal valDate As Object) As Decimal
            Dim finalDate As DateTime = DateTime.Now
            Try
                If (Not DateTime.TryParse(valDate.ToString, finalDate)) Then Return DateTime.Now.Hour
                Return finalDate.Hour
            Catch ex As Exception
                Throw New Exception("HOUR(" & GetStr(valDate) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Retrieves the minutes from the date
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The minutes part of the date and if date is empty string then returns minutes now</returns>
        Public Shared Function Minute(ByVal valDate As Object) As Decimal
            Dim finalDate As DateTime = DateTime.Now
            Try
                If (Not DateTime.TryParse(valDate.ToString, finalDate)) Then Return DateTime.Now.Minute
                Return finalDate.Minute
            Catch ex As Exception
                Throw New Exception("MINUTE(" & GetStr(valDate) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Retrieves the years from the date
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The years part of the date and if date is empty string then returns years now</returns>
        Public Shared Function Year(ByVal valDate As Object) As Decimal
            Dim finalDate As DateTime = DateTime.Today
            Try
                If (Not DateTime.TryParse(valDate.ToString, finalDate)) Then Return DateTime.Now.Year
                Return finalDate.Year
            Catch ex As Exception
                Throw New Exception("YEAR(" & GetStr(valDate) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Retrieves the month from the date
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The month part of the date and if date is empty string then returns this month</returns>
        Public Shared Function Month(ByVal valDate As Object) As Decimal
            Dim finalDate As DateTime = DateTime.Today
            Try
                If (Not DateTime.TryParse(valDate.ToString, finalDate)) Then Return DateTime.Now.Month
                Return finalDate.Month
            Catch ex As Exception
                Throw New Exception("MONTH(" & GetStr(valDate) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Retrieves the seconds from the date
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The seconds part of the date and if date is empty string then returns seconds now</returns>
        Public Shared Function Second(ByVal valDate As Object) As Decimal
            Dim finalDate As DateTime = DateTime.Now
            Try
                If (Not DateTime.TryParse(valDate.ToString, finalDate)) Then Return DateTime.Now.Second
                Return finalDate.Second
            Catch ex As Exception
                Throw New Exception("SECOND(" & GetStr(valDate) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Returns a datevalue specifying the hours minutes and seconds
        ''' </summary>
        ''' <param name="valHour">The number of hours</param>
        ''' <param name="valMinute">The number of minutes</param>
        ''' <param name="valSecond">The number of seconds</param>
        ''' <returns>The seconds part of the date and if date is empty string then returns seconds now</returns>
        Public Shared Function Time1(ByVal valHour As Object, ByVal valMinute As Object, ByVal valSecond As Object) As DateTime
            'The date would be set relative to January 1 of the year 1.
            Dim finalDate As DateTime = DateTime.Today
            Try
                If (Not finalDate = TimeSerial(Convert.ToInt32(valHour), Convert.ToInt32(valMinute), Convert.ToInt32(valSecond))) Then
                    Return DateTime.Today
                End If
                Return finalDate
            Catch ex As Exception
                Throw New Exception("TIME1(" & GetStr(valHour) & ", " & GetStr(valMinute) & ", " & GetStr(valSecond) & "): " & ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Returns today's date with current time
        ''' </summary>
        ''' <returns>Today's date with current time.</returns>
        Public Shared Function Now() As DateTime
            Return DateTime.Now
        End Function

        ''' <summary>
        ''' Returns today's date, the time would be 12:00 AM 
        ''' </summary>
        ''' <returns>Today's date, the time would be 12:00 AM</returns>
        Public Shared Function Today() As DateTime
            Return DateTime.Today
        End Function

        ''' <summary>
        ''' Retrieves yesterday's date
        ''' </summary>
        ''' <returns>Yesterday's date</returns>
        Public Shared Function Yesterday() As DateTime
            Return DateTime.Today.AddDays(-1)
        End Function

        ''' <summary>
        ''' Retrieve  the date of start of the week
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The start date of the week</returns>
        Public Shared Function StartOfWeek(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            inputDate = inputDate.AddDays(0 - inputDate.DayOfWeek)
            Return New DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 0, 0, 0)
        End Function

        ''' <summary>
        ''' Retrieve  the date of end of the week
        ''' </summary>
        ''' <param name="valDate">The date to be operated upon</param>
        ''' <returns>The end date of the week</returns>
        Public Shared Function EndOfWeek(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            inputDate = inputDate.AddDays(6 - inputDate.DayOfWeek)
            Return New DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 23, 59, 59)
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the current week
        ''' </summary>
        ''' <returns>The start date of the current week</returns>
        Public Shared Function StartOfCurrentWeek() As DateTime
            Dim inputDate As DateTime = DateTime.Today
            inputDate = inputDate.AddDays(0 - inputDate.DayOfWeek)
            Return New DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 0, 0, 0)
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the current week
        ''' </summary>
        ''' <returns>The end date of the current week</returns>
        Public Shared Function EndOfCurrentWeek() As DateTime
            Dim inputDate As DateTime = DateTime.Today
            inputDate = inputDate.AddDays(6 - inputDate.DayOfWeek)
            Return New DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 23, 59, 59)
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the previous week
        ''' </summary>
        ''' <returns>The start date of the previous week</returns>
        Public Shared Function StartOfLastWeek() As DateTime
            Dim inputDate As DateTime = DateTime.Today
            inputDate = inputDate.AddDays(-7 - inputDate.DayOfWeek)
            Return New DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 0, 0, 0)
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the previous week
        ''' </summary>
        ''' <returns>The end date of the previous week</returns>
        Public Shared Function EndOfLastWeek() As DateTime
            Dim inputDate As DateTime = DateTime.Today
            inputDate = inputDate.AddDays(-1 - inputDate.DayOfWeek)
            Return New DateTime(inputDate.Year, inputDate.Month, inputDate.Day, 23, 59, 59)
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the month for the specified date
        ''' </summary>
        ''' <param name="valDate">The date whose start date of month is to be found</param>
        ''' <returns>The start date of the month</returns>
        Public Shared Function StartOfMonth(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            Dim startDate As DateTime = New DateTime(inputDate.Year, inputDate.Month, 1)
            Return startDate
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the month for the specified date
        ''' </summary>
        ''' <param name="valDate">The date whose end date of month is to be found</param>
        ''' <returns>The end date of the month</returns>
        Public Shared Function EndOfMonth(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            Dim endDate As DateTime = inputDate.AddMonths(1)
            endDate = New DateTime(endDate.Year, endDate.Month, 1, 23, 59, 59).AddDays(-1)
            Return endDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the current month
        ''' </summary>
        ''' <returns>The start date of the current month</returns>
        Public Shared Function StartOfCurrentMonth() As DateTime
            Dim startDate As DateTime = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1)
            Return startDate
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the current month
        ''' </summary>
        ''' <returns>The end date of the current month</returns>
        Public Shared Function EndOfCurrentMonth() As DateTime
            Dim endDate As DateTime = DateTime.Today.AddMonths(1)
            endDate = New DateTime(endDate.Year, endDate.Month, 1, 23, 59, 59).AddDays(-1)
            Return endDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the last month
        ''' </summary>
        ''' <returns>The start date of the last month</returns>
        Public Shared Function StartOfLastMonth() As DateTime
            Dim prevMonthDate As DateTime = DateTime.Today.AddMonths(-1)
            Return New DateTime(prevMonthDate.Year, prevMonthDate.Month, 1)
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the last month
        ''' </summary>
        ''' <returns>The end date of the last month</returns>
        Public Shared Function EndOfLastMonth() As DateTime
            Dim endDate As DateTime = DateTime.Today
            endDate = New DateTime(DateTime.Today.Year, DateTime.Today.Month, 1, 23, 59, 59)
            endDate = endDate.AddDays(-1)
            Return endDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the quarter for the specified date
        ''' </summary>
        ''' <param name="valDate">The date whose start date of quarter is to be found</param>
        ''' <returns>The start date of the quarter</returns>
        Public Shared Function StartOfQuarter(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            Dim quarter As Integer = (inputDate.Month - 1) \ 3 + 1
            Dim startQuarterDate As DateTime = New DateTime(inputDate.Year, 3 * quarter - 2, 1)
            Return startQuarterDate
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the quarter for the specified date
        ''' </summary>
        ''' <param name="valDate">The date whose end date of quarter is to be found</param>
        ''' <returns>The end date of the quarter</returns>
        Public Shared Function EndOfQuarter(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            Dim quarter As Integer = (inputDate.Month - 1) \ 3 + 1
            Dim quarterLastDate As DateTime = New DateTime(inputDate.Year, 3 * quarter, 1, 23, 59, 59).AddMonths(1).AddDays(-1)
            Return quarterLastDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the current quarter
        ''' </summary>
        ''' <returns>The start date of the current quarter</returns>
        Public Shared Function StartOfCurrentQuarter() As DateTime
            Dim dateToday As DateTime = DateTime.Today
            Dim currQuarter As Integer = (DateTime.Today.Month - 1) \ 3 + 1
            Dim dtFirstDay As DateTime = New DateTime(DateTime.Today.Year, 3 * currQuarter - 2, 1)
            Return dtFirstDay
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the current quarter
        ''' </summary>
        ''' <returns>The end date of the current quarter</returns>
        Public Shared Function EndOfCurrentQuarter() As DateTime
            Dim dateToday As DateTime = DateTime.Today
            Dim currQuarter As Integer = (DateTime.Today.Month - 1) \ 3 + 1
            Dim quarterLastDate As DateTime = New DateTime(DateTime.Today.Year, 3 * currQuarter, 1, 23, 59, 59).AddMonths(1).AddDays(-1)
            Return quarterLastDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the last quarter
        ''' </summary>
        ''' <returns>The start date of the last quarter</returns>
        Public Shared Function StartOfLastQuarter() As DateTime
            Dim currQuarter As Integer = (DateTime.Today.Month - 1) \ 3 + 1
            Dim lastQuarterStartDate As DateTime = New DateTime(DateTime.Today.Year, 3 * currQuarter - 2, 1).AddMonths(-3)
            Return lastQuarterStartDate
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the last quarter
        ''' </summary>
        ''' <returns>The end date of the last quarter</returns>
        Public Shared Function EndOfLastQuarter() As DateTime
            Dim currQuarter As Integer = (DateTime.Today.Month - 1) \ 3 + 1
            Dim lastQuarterEndDate As DateTime = New DateTime(DateTime.Today.Year, 3 * currQuarter - 2, 1, 23, 59, 59).AddDays(-1)
            Return lastQuarterEndDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the year for the specified  date
        ''' </summary>
        ''' <param name="valDate">The date whose start date of year is to be found</param>
        ''' <returns>The start date of the year</returns>
        Public Shared Function StartOfYear(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            Dim dtFirstDate As DateTime = New DateTime(inputDate.Year, 1, 1)
            Return dtFirstDate
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the year for the date passed
        ''' </summary>
        ''' <returns>The end date of the year</returns>
        Public Shared Function EndOfYear(ByVal valDate As Object) As DateTime
            Dim inputDate As DateTime = DateTime.Today
            If Not (DateTime.TryParse(valDate.ToString, inputDate)) Then inputDate = DateTime.Today
            Dim dtLastDate As DateTime = New DateTime(inputDate.Year, 12, 31, 23, 59, 59)
            Return dtLastDate
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the current year
        ''' </summary>
        ''' <returns>The start date of the current year</returns>
        Public Shared Function StartOfCurrentYear() As DateTime
            Dim dtFirstDay As DateTime = New DateTime(DateTime.Today.Year, 1, 1)
            Return dtFirstDay
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the current year
        ''' </summary>
        ''' <returns>The end date of the current year</returns>
        Public Shared Function EndOfCurrentYear() As DateTime
            Dim dtLastDay As DateTime = New DateTime(DateTime.Today.Year, 12, 31, 23, 59, 59)
            Return dtLastDay
        End Function

        ''' <summary>
        ''' Retrieve  the start date of the last year
        ''' </summary>
        ''' <returns>The start date of the last year</returns>
        Public Shared Function StartOfLastYear() As DateTime
            Dim dtFirstDay As DateTime = New DateTime(DateTime.Today.Year - 1, 1, 1)
            Return dtFirstDay
        End Function

        ''' <summary>
        ''' Retrieve  the end date of the last year
        ''' </summary>
        ''' <returns>The end date of the last year</returns>
        Public Shared Function EndOfLastYear() As DateTime
            Dim dtFirstDay As DateTime = New DateTime(DateTime.Today.Year - 1, 12, 31, 23, 59, 59)
            Return dtFirstDay
        End Function

#End Region

#Region "Format Functions"

        ''' <summary>
        ''' Formats the arguments according to the format string
        ''' </summary>
        ''' <param name="val">The value to be formatted</param>
        ''' <param name="formatString">The format string needed to specify the format type</param>
        ''' <returns>The formatted string</returns>
        Public Shared Function Format(ByVal val As Object, ByVal formatString As String) As String
            Dim valDecimal As Decimal
            Dim valDate As DateTime
            If (IsNothing(val)) Then
                Return String.Empty
            End If

            Try

                Try
                    valDecimal = ParseDecimal(val)
                    Return valDecimal.ToString(formatString)
                Catch
                    ' Ignore
                End Try

                If DateTime.TryParse(val.ToString, valDate) Then
                    Return valDate.ToString(formatString)
                End If

                Return ParseDecimal(val).ToString(formatString)
            Catch
                Return val.ToString
            End Try
        End Function
#End Region

#Region "Parse Functions"

        ''' <summary>
        ''' Converts the object to its Decimal equivalent.
        ''' </summary>
        ''' <param name="val">The value to be converted</param>
        ''' <returns>The converted value</returns>
        Public Shared Function ParseDecimal(ByVal val As Object) As Decimal
            Dim valDecimal As Decimal = 0
            Try
                valDecimal = StringUtils.ParseDecimal(val)
                Return valDecimal
            Catch ex As Exception
                Throw New Exception(("PARSEDECIMAL(" & GetStr(val) & "): ") + ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Converts the object to its integer equivalent.
        ''' </summary>
        ''' <param name="val">The value to be converted</param>
        ''' <returns>The converted value</returns>
        Public Shared Function ParseInteger(ByVal val As Object) As Integer
            Dim valInteger As Integer = 0
            Try
                valInteger = CInt(ParseDecimal(val))
                Return valInteger
            Catch ex As Exception
                Throw New Exception(("PARSEINTEGER(" & GetStr(val) & "): ") + ex.Message)
            End Try
        End Function

        ''' <summary>
        ''' Converts the object to its date equivalent.
        ''' </summary>
        ''' <param name="val">The value to be converted</param>
        ''' <returns>The converted value.</returns>
        Public Shared Function parseDate(ByVal val As Object) As DateTime
            Dim valDate As DateTime = DateTime.Today
            Try
                valDate = DateTime.Parse(val.ToString())
                Return valDate
            Catch ex As Exception
                Throw New Exception(("PARSEDATE(" & GetStr(val) & "): ") + ex.Message)
            End Try
        End Function
#End Region

#Region "Session, Cookie, URL and other Functions"

        ''' <summary>
        ''' Return the value of the variable from the session.
        ''' </summary>
        ''' <param name="var">The name of the session variable</param>
        ''' <returns>The session variable value.</returns>
        Public Shared Function Session(ByVal var As String) As String
            If (IsNothing(var) OrElse IsNothing(System.Web.HttpContext.Current.Session(var))) Then Return String.Empty
            Return System.Web.HttpContext.Current.Session(var).ToString
        End Function

        ''' <summary>
        ''' Return the value of the variable from the cookie.
        ''' </summary>
        ''' <param name="var">The name of the cookie variable</param>
        ''' <returns>The cookie variable value.</returns>
        Public Shared Function Cookie(ByVal var As String) As String
            If (IsNothing(var) OrElse IsNothing(System.Web.HttpContext.Current.Request.Cookies(var))) Then Return String.Empty
            Return System.Web.HttpContext.Current.Request.Cookies(var).Value
        End Function

        ''' <summary>
        ''' Return the value of the variable from the cache.
        ''' </summary>
        ''' <param name="var">The name of the cache variable</param>
        ''' <returns>The cache variable value.</returns>
        Public Shared Function Cache(ByVal var As String) As String
            If (IsNothing(var) OrElse IsNothing(System.Web.HttpContext.Current.Cache(var))) Then Return String.Empty
            Return System.Web.HttpContext.Current.Cache(var).ToString()
        End Function

        ''' <summary>
        ''' Return the value of the URL parameter passed to the current page.
        ''' </summary>
        ''' <param name="var">The name of the URL variable</param>
        ''' <returns>The URL variable value.</returns>
        Public Shared Function URL(ByVal var As String) As String
            Dim val As String
            If (IsNothing(var)) Then Return String.Empty

            val = System.Web.HttpContext.Current.Request.QueryString.Item(var)

            ' It is possible that the URL value is encrypted - so try to
            ' decrypt.  If we do not get an exception, then we know it was
            ' encrypted - otherwise if we get an exception, then the value was
            ' not encrypted in the first place, so return the actual value.
            Try
                val = Decrypt(val)
            Catch
                ' Ignore exception and return original value
            End Try

            If KeyValue.IsXmlKey(val) Then
                ' URL values are typically passed as XML structures to handle composite keys.
                ' If XML, then we will see if there is one element in the XML. If there is only one
                ' element, we will return that element.  Otherwise we will return the full XML.
                Dim key As KeyValue = KeyValue.XmlToKey(val)
                If key.Count = 1 Then
                    val = key.ColumnValue(0)
                End If
            End If

            Return val
        End Function

        ''' <summary>
        ''' Return the value of the URL parameter passed to the current page.
        ''' If the URL is a Key Value pair, return the column value of the XML structure
        ''' </summary>
        ''' <param name="var">The name of the URL variable</param>
        ''' <returns>The URL variable value.</returns>
        Public Shared Function URL(ByVal var As String, ByVal column As String) As String
            Dim val As String
            If (IsNothing(var)) Then Return String.Empty

            val = System.Web.HttpContext.Current.Request.QueryString.Item(var)

            ' It is possible that the URL value is encrypted - so try to
            ' decrypt.  If we do not get an exception, then we know it was
            ' encrypted - otherwise if we get an exception, then the value was
            ' not encrypted in the first place, so return the actual value.
            Try
                val = Decrypt(val)
            Catch ex As Exception
                ' Ignore exception and return original value
            End Try

            If KeyValue.IsXmlKey(val) Then
                ' URL values are typically passed as XML structures to handle composite keys.
                ' If XML, then we will see if retrieve the value for the column name passed in
                ' to the function.
                Dim key As KeyValue = KeyValue.XmlToKey(val)
                val = key.ColumnValueByName(column)
            End If

            Return val
        End Function

        ''' <summary>
        ''' Return the value of the resource key.  Only the application resources
        ''' are returned by this function.  Resources in the BaseClasses.resx file
        ''' are not accessible through this function.
        ''' </summary>
        ''' <param name="var">The name of the resource key</param>
        ''' <returns>The resource value.</returns>
        Public Shared Function Resource(ByVal var As String) As String
            If (IsNothing(var)) Then Return String.Empty
            Try
                Dim appname As String = BaseClasses.Configuration.ApplicationSettings.Current.GetAppSetting(BaseClasses.Configuration.ApplicationSettings.ConfigurationKey.ApplicationName)
                Dim resObj As Object = System.Web.HttpContext.GetGlobalResourceObject(appname, var)
                If Not resObj Is Nothing Then
                    Return resObj.ToString()
                End If
            Catch
                ' If we cannot find the resource, simply return the variable that was passed-in.
            End Try
            Return var
        End Function

        ''' <summary>
        ''' Return the encrypted value of the string passed in.
        ''' </summary>
        ''' <param name="str">The string to encrypt</param>
        ''' <returns>The encrypted value of the string.</returns>
        Public Shared Function Encrypt(ByVal str As String) As String
            If (IsNothing(str)) Then Return String.Empty
            Dim CheckCrypto As Crypto = New Crypto()
            Return CheckCrypto.Encrypt(str)
        End Function

        ''' <summary>
        ''' Return the decrypted value of the string passed in.
        ''' </summary>
        ''' <param name="str">The string to decrypt</param>
        ''' <returns>The decrypted value of the string.</returns>
        Public Shared Function Decrypt(ByVal str As String) As String
            If (IsNothing(str)) Then Return String.Empty
            Dim CheckCrypto As Crypto = New Crypto()
            Return CheckCrypto.Decrypt(str)
        End Function

        ''' <summary>
        ''' Return the currently logged in user id
        ''' </summary>
        ''' <returns>The user id of the currently logged in user.</returns>
        Public Shared Function UserId() As String
            Return BaseClasses.Utils.SecurityControls.GetCurrentUserID()
        End Function

        ''' <summary>
        ''' Return the currently logged in user ma,e
        ''' </summary>
        ''' <returns>The user name of the currently logged in user.</returns>
        Public Shared Function UserName() As String
            Return BaseClasses.Utils.SecurityControls.GetCurrentUserName()
        End Function

        ''' <summary>
        ''' Return the currently logged in user's roles.  The roles are returned
        ''' as a string array, so you can do something like 
        '''     = If("Engineering" in Roles(), "Good", "Bad")
        ''' </summary>
        ''' <returns>The roles of the currently logged in user.</returns>
        Public Shared Function Roles() As String()
            Dim rStr As String = BaseClasses.Utils.SecurityControls.GetCurrentUserRoles()
            If IsNothing(rStr) Then Return New String() {}
            Return rStr.Split(";"c)
        End Function

        ''' <summary>
        ''' Return the value of the column from the currently logged in user's database 
        ''' record.  Allows access to any fields on the user record (e.g., email address)
        ''' by simply doing something like UserRecord("EmailAddress")
        ''' NOTE: This function ONLY applies to Database Role security.  Does NOT
        ''' apply to Active Directory, SharePoint, Windows Authentication or .NET Membership Roles
        ''' </summary>
        ''' <returns>The user record of the currently logged in user.</returns>
        Public Shared Function UserRecord(ByVal colName As String) As Object
            Dim rec As IUserIdentityRecord
            rec = BaseClasses.Utils.SecurityControls.GetUserRecord()
            If IsNothing(rec) Then Return String.Empty

            Dim col As BaseColumn
            col = rec.TableAccess.TableDefinition.ColumnList.GetByCodeName(colName)
            If IsNothing(col) Then Return String.Empty

            Return rec.GetValue(col).Value
        End Function
#End Region

#Region "Database Access Functions"
        ''' <summary>
        ''' Return the value of the column from the database record specified by the key.  The
        ''' key can be either an XML KeyValue structure or just a string that is the Id of the record.
        ''' Only works for tables with a primary key or a virtual primary key.
        ''' </summary>
        ''' <returns>The value for the given field as an Object.</returns>
        Public Shared Function GetColumnValue(ByVal tableName As String, ByVal key As Decimal, ByVal fieldName As String) As Object
            Return GetColumnValue(tableName, key.ToString(), fieldName)
        End Function


        ''' <summary>
        ''' Return the value of the column from the database record specified by the key.  The
        ''' key can be either an XML KeyValue structure or just a string that is the Id of the record.
        ''' Only works for tables with a primary key or a virtual primary key.
        ''' </summary>
        ''' <returns>The value for the given field as an Object.</returns>
        Public Shared Function GetColumnValue(ByVal tableName As String, ByVal key As String, ByVal fieldName As String) As Object
            ' Find a specific value from the database for the given record.
            Dim bt As PrimaryKeyTable
            bt = CType(DatabaseObjects.GetTableObject(tableName), PrimaryKeyTable)
            If IsNothing(bt) Then
                Throw New Exception("GETCOLUMNVALUE(" & tableName & ", " & key & ", " & fieldName & "): " & Resource("Err:NoRecRetrieved"))
            End If

            Dim rec As IRecord = Nothing
            Try
                ' Always start a transaction since we do not know if the calling function did.
                DbUtils.StartTransaction()
                rec = bt.GetRecordData(key, False)
            Catch
                ' Ignore exception - throw an exception below if no record received.
            Finally
                DbUtils.EndTransaction()
            End Try
            If IsNothing(rec) Then
                Throw New Exception("GETCOLUMNVALUE(" & tableName & ", " & key & ", " & fieldName & "): " & Resource("Err:NoRecRetrieved"))
            End If

            Dim col As BaseColumn = bt.TableDefinition.ColumnList.GetByCodeName(fieldName)
            If IsNothing(col) Then
                Throw New Exception("GETCOLUMNVALUE(" & tableName & ", " & key & ", " & fieldName & "): " & Resource("Err:NoRecRetrieved"))
            End If

            ' The value can be null.  In this case, return an empty string since
            ' that is an acceptable value.
            Dim fieldData As ColumnValue = rec.GetValue(col)
            If IsNothing(fieldData) Then
                Return String.Empty
            End If

            Return fieldData.Value

        End Function

        ''' <summary>
        ''' Return an array of values from the database.  The values returned are DISTINCT values.
        ''' For example, GetColumnValues("Employees", "City") will return a list of all Cities
        ''' from the Employees table. There will be no duplicates in the list.
        ''' You can use the IN operator to compare the values.  You can also use the resulting array to display
        ''' such as String.Join(", ", GetColumnValues("Employees", "City")
        ''' to display: New York, Chicago, Los Angeles, San Francisco
        ''' </summary>
        ''' <returns>An array of values for the given field as an Object.</returns>
        Public Shared Function GetColumnValues(ByVal tableName As String, ByVal fieldName As String) As String()
            Return GetColumnValues(tableName, fieldName, String.Empty)
        End Function

        ''' <summary>
        ''' Return an array of values from the database.  The values returned are DISTINCT values.
        ''' For example, GetColumnValues("Employees", "City") will return a list of all Cities
        ''' from the Employees table. There will be no duplicates in the list.
        ''' This function adds a Where Clause.  So you can say something like "Country = 'USA'" and in this
        ''' case only cities in the US will be returned.
        ''' You can use the IN operator to compare the values.  You can also use the resulting array to display
        ''' such as String.Join(", ", GetColumnValues("Employees", "City", "Country = 'USA'")
        ''' to display: New York, Chicago, Los Angeles, San Francisco
        ''' </summary>
        ''' <returns>An array of values for the given field as an Object.</returns>
        Public Shared Function GetColumnValues(ByVal tableName As String, ByVal fieldName As String, ByVal whereStr As String) As String()
            ' Find the 
            Dim bt As PrimaryKeyTable
            bt = CType(DatabaseObjects.GetTableObject(tableName), PrimaryKeyTable)
            If IsNothing(bt) Then
                Throw New Exception("GETCOLUMNVALUES(" & tableName & ", " & fieldName & ", " & whereStr & "): " & Resource("Err:NoRecRetrieved"))
            End If

            Dim col As BaseColumn = bt.TableDefinition.ColumnList.GetByCodeName(fieldName)
            If IsNothing(col) Then
                Throw New Exception("GETCOLUMNVALUES(" & tableName & ", " & fieldName & ", " & whereStr & "): " & Resource("Err:NoRecRetrieved"))
            End If

            Dim values As String() = Nothing

            Try
                ' Always start a transaction since we do not know if the calling function did.
                DbUtils.StartTransaction()
                Dim sqlCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
                sqlCol.AddColumn(col)

                Dim wc As WhereClause = New WhereClause
                If Not (IsNothing(whereStr)) AndAlso whereStr.Trim.Length > 0 Then
                    wc.iAND(whereStr)
                End If

                values = bt.GetColumnValues(sqlCol, wc.GetFilter(), Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)

            Catch
                ' Ignore exception - throw an exception below if no record received.
            Finally
                DbUtils.EndTransaction()
            End Try

            ' The value can be null.  In this case, return an empty array since
            ' that is an acceptable value.
            If IsNothing(values) Then
                values = New String() {}
            End If

            Return values

        End Function
#End Region

#Region "Private Convenience Functions"
        ''' <summary>
        ''' Convert an object to string
        ''' </summary>
        ''' <param name="str">The input to be converted</param>
        ''' <returns>The converted string.</returns>
        Private Shared Function GetStr(ByVal str As Object) As String
            If (IsNothing(str)) Then Return String.Empty
            Return str.ToString
        End Function


#End Region



    End Class

End Namespace
