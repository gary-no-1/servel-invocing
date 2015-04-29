' This class is "generated" and will be overwritten.
' Your customizations should be made in V_Invoice_ItemsSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="V_Invoice_ItemsSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_Invoice_ItemsView"></see> class.
''' </remarks>
''' <seealso cref="V_Invoice_ItemsView"></seealso>
''' <seealso cref="V_Invoice_ItemsSqlView"></seealso>

Public Class BaseV_Invoice_ItemsSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
