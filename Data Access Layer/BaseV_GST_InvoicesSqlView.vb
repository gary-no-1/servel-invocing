' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_InvoicesSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="V_GST_InvoicesSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GST_InvoicesView"></see> class.
''' </remarks>
''' <seealso cref="V_GST_InvoicesView"></seealso>
''' <seealso cref="V_GST_InvoicesSqlView"></seealso>

Public Class BaseV_GST_InvoicesSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
