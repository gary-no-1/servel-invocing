' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_invoice_hsn_taxSqlView.vb  

Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="V_GST_invoice_hsn_taxSqlView"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GST_invoice_hsn_taxView"></see> class.
''' </remarks>
''' <seealso cref="V_GST_invoice_hsn_taxView"></seealso>
''' <seealso cref="V_GST_invoice_hsn_taxSqlView"></seealso>

Public Class BaseV_GST_invoice_hsn_taxSqlView
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
	End Sub
	
	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
