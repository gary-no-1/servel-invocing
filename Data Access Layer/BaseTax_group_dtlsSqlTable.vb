' This class is "generated" and will be overwritten.
' Your customizations should be made in Tax_group_dtlsSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="Tax_group_dtlsSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Tax_group_dtlsTable"></see> class.
''' </remarks>
''' <seealso cref="Tax_group_dtlsTable"></seealso>
''' <seealso cref="Tax_group_dtlsSqlTable"></seealso>

Public Class BaseTax_group_dtlsSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
