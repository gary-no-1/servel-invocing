' This class is "generated" and will be overwritten.
' Your customizations should be made in Pro_inv_hdrSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="Pro_inv_hdrSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Pro_inv_hdrTable"></see> class.
''' </remarks>
''' <seealso cref="Pro_inv_hdrTable"></seealso>
''' <seealso cref="Pro_inv_hdrSqlTable"></seealso>

Public Class BasePro_inv_hdrSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
