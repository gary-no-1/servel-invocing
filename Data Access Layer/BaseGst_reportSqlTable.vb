﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in Gst_reportSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="Gst_reportSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Gst_reportTable"></see> class.
''' </remarks>
''' <seealso cref="Gst_reportTable"></seealso>
''' <seealso cref="Gst_reportSqlTable"></seealso>

Public Class BaseGst_reportSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
