' This class is "generated" and will be overwritten.
' Your customizations should be made in Tax_typesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Tax_typesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Tax_typesTable"></see> class.
''' </remarks>
''' <seealso cref="Tax_typesTable"></seealso>
''' <seealso cref="Tax_typesRecord"></seealso>

<Serializable()> Public Class BaseTax_typesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Tax_typesTable = Tax_typesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_types_.tax_type field.
	''' </summary>
	Public Function Gettax_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_types_.tax_type field.
	''' </summary>
	Public Function Gettax_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_types_.tax_type field.
	''' </summary>
	Public Sub Settax_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_types_.tax_type field.
	''' </summary>
	Public Sub Settax_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_typeColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_types_.tax_type field.
	''' </summary>
	Public Property tax_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_typeDefault() As String
        Get
            Return TableUtils.tax_typeColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
