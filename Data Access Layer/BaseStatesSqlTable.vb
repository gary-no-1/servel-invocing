' This class is "generated" and will be overwritten.
' Your customizations should be made in StatesSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="StatesSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="StatesTable"></see> class.
''' </remarks>
''' <seealso cref="StatesTable"></seealso>
''' <seealso cref="StatesSqlTable"></seealso>

Public Class BaseStatesSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
