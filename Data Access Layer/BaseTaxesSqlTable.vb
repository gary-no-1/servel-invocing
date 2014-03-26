﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in TaxesSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="TaxesSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="TaxesTable"></see> class.
''' </remarks>
''' <seealso cref="TaxesTable"></seealso>
''' <seealso cref="TaxesSqlTable"></seealso>

Public Class BaseTaxesSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
