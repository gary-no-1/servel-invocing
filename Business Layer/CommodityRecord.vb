' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' Provides access to the data in a database record.
''' Also provides access to the <see cref="CommodityTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="CommodityTable"></seealso>

<Serializable()> Public Class CommodityRecord
	Inherits BaseCommodityRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	

End Class
End Namespace
