' This class is "generated" and will be overwritten.
' Your customizations should be made in So_itemsSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="So_itemsSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="So_itemsTable"></see> class.
''' </remarks>
''' <seealso cref="So_itemsTable"></seealso>
''' <seealso cref="So_itemsSqlTable"></seealso>

Public Class BaseSo_itemsSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
