' This class is "generated" and will be overwritten.
' Your customizations should be made in UnitsofmeasureRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="UnitsofmeasureRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="UnitsofmeasureTable"></see> class.
''' </remarks>
''' <seealso cref="UnitsofmeasureTable"></seealso>
''' <seealso cref="UnitsofmeasureRecord"></seealso>

<Serializable()> Public Class BaseUnitsofmeasureRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As UnitsofmeasureTable = UnitsofmeasureTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Unitsofmeasure_.uom field.
	''' </summary>
	Public Function GetuomValue() As ColumnValue
		Return Me.GetValue(TableUtils.uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Unitsofmeasure_.uom field.
	''' </summary>
	Public Function GetuomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Unitsofmeasure_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Unitsofmeasure_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.uomColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Unitsofmeasure_.uom field.
	''' </summary>
	Public Property uom() As String
		Get 
			Return CType(Me.GetValue(TableUtils.uomColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.uomColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property uomSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.uomColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property uomDefault() As String
        Get
            Return TableUtils.uomColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
