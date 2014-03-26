' This class is "generated" and will be overwritten.
' Your customizations should be made in UnitsofmeasureSqlTable.vb 

Imports BaseClasses.Data
Imports BaseClasses
Imports BaseClasses.Data.SqlProvider


Namespace ServelInvocing.Data

''' <summary>
''' The generated superclass for the <see cref="UnitsofmeasureSqlTable"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="UnitsofmeasureTable"></see> class.
''' </remarks>
''' <seealso cref="UnitsofmeasureTable"></seealso>
''' <seealso cref="UnitsofmeasureSqlTable"></seealso>

Public Class BaseUnitsofmeasureSqlTable
	Inherits DynamicSQLServerAdapter
	
	Public Sub New()
		MyBase.New()
	End Sub

	Public Sub New(ByVal connectionName As String)
		MyBase.New(connectionName)
	End Sub
End Class
End Namespace
