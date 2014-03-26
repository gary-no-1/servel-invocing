' This class is "generated" and will be overwritten.
' Your customizations should be made in TaxesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="TaxesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="TaxesTable"></see> class.
''' </remarks>
''' <seealso cref="TaxesTable"></seealso>
''' <seealso cref="TaxesRecord"></seealso>

<Serializable()> Public Class BaseTaxesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As TaxesTable = TaxesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_code field.
	''' </summary>
	Public Function Gettax_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_code field.
	''' </summary>
	Public Function Gettax_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_code field.
	''' </summary>
	Public Sub Settax_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_code field.
	''' </summary>
	Public Sub Settax_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_name field.
	''' </summary>
	Public Function Gettax_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_name field.
	''' </summary>
	Public Function Gettax_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_name field.
	''' </summary>
	Public Sub Settax_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_name field.
	''' </summary>
	Public Sub Settax_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_print field.
	''' </summary>
	Public Function Gettax_printValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_printColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_print field.
	''' </summary>
	Public Function Gettax_printFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_printColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_print field.
	''' </summary>
	Public Sub Settax_printFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_printColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_print field.
	''' </summary>
	Public Sub Settax_printFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_printColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_type field.
	''' </summary>
	Public Function Gettax_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.tax_type field.
	''' </summary>
	Public Function Gettax_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_type field.
	''' </summary>
	Public Sub Settax_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.tax_type field.
	''' </summary>
	Public Sub Settax_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.notes field.
	''' </summary>
	Public Function GetnotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.notesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Taxes_.notes field.
	''' </summary>
	Public Function GetnotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.notesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.notes field.
	''' </summary>
	Public Sub SetnotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.notesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Taxes_.notes field.
	''' </summary>
	Public Sub SetnotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.notesColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.id field.
	''' </summary>
	Public Property id0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id0Default() As String
        Get
            Return TableUtils.id0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.tax_code field.
	''' </summary>
	Public Property tax_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_codeDefault() As String
        Get
            Return TableUtils.tax_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.tax_name field.
	''' </summary>
	Public Property tax_name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_nameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_nameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_nameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_nameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_nameDefault() As String
        Get
            Return TableUtils.tax_nameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.tax_print field.
	''' </summary>
	Public Property tax_print() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_printColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_printColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_printSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_printColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_printDefault() As String
        Get
            Return TableUtils.tax_printColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.tax_rate field.
	''' </summary>
	Public Property tax_rate() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.tax_rateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_rateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_rateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_rateDefault() As String
        Get
            Return TableUtils.tax_rateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.tax_type field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Taxes_.notes field.
	''' </summary>
	Public Property notes() As String
		Get 
			Return CType(Me.GetValue(TableUtils.notesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.notesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property notesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.notesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property notesDefault() As String
        Get
            Return TableUtils.notesColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
