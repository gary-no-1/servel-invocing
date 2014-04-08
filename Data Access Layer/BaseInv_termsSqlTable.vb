' This class is "generated" and will be overwritten.
' Your customizations should be made in Inv_termsSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="Inv_termsSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Inv_termsTable"></see> class.
''' </remarks>
''' <seealso cref="Inv_termsTable"></seealso>
''' <seealso cref="Inv_termsSqlTable"></seealso>

Public Class BaseInv_termsSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
