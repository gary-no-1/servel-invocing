' This class is "generated" and will be overwritten.
' Your customizations should be made in Item_groupsSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="Item_groupsSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Item_groupsTable"></see> class.
''' </remarks>
''' <seealso cref="Item_groupsTable"></seealso>
''' <seealso cref="Item_groupsSqlTable"></seealso>

Public Class BaseItem_groupsSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
