' This class is "generated" and will be overwritten.
' Your customizations should be made in Tax_group_dtlsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Tax_group_dtlsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Tax_group_dtlsTable"></see> class.
''' </remarks>
''' <seealso cref="Tax_group_dtlsTable"></seealso>
''' <seealso cref="Tax_group_dtlsRecord"></seealso>

<Serializable()> Public Class BaseTax_group_dtlsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Tax_group_dtlsTable = Tax_group_dtlsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_tax_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_tax_groupColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Function Getid_taxesValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Function Getid_taxesFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxesColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxesColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Function Getsort_orderValue() As ColumnValue
		Return Me.GetValue(TableUtils.sort_orderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Function Getsort_orderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.sort_orderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_code field.
	''' </summary>
	Public Function Gettax_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_code field.
	''' </summary>
	Public Function Gettax_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_code field.
	''' </summary>
	Public Sub Settax_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_code field.
	''' </summary>
	Public Sub Settax_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_name field.
	''' </summary>
	Public Function Gettax_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_name field.
	''' </summary>
	Public Function Gettax_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_name field.
	''' </summary>
	Public Sub Settax_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_name field.
	''' </summary>
	Public Sub Settax_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_print field.
	''' </summary>
	Public Function Gettax_printValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_printColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_print field.
	''' </summary>
	Public Function Gettax_printFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_printColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_print field.
	''' </summary>
	Public Sub Settax_printFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_printColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_print field.
	''' </summary>
	Public Sub Settax_printFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_printColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.calc_type field.
	''' </summary>
	Public Function Getcalc_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.calc_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_group_dtls_.calc_type field.
	''' </summary>
	Public Function Getcalc_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.calc_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.calc_type field.
	''' </summary>
	Public Sub Setcalc_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.calc_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_group_dtls_.calc_type field.
	''' </summary>
	Public Sub Setcalc_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.calc_typeColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.id_tax_group field.
	''' </summary>
	Public Property id_tax_group() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_tax_groupColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_tax_groupSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_tax_groupColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_tax_groupDefault() As String
        Get
            Return TableUtils.id_tax_groupColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.id_taxes field.
	''' </summary>
	Public Property id_taxes() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxesColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxesDefault() As String
        Get
            Return TableUtils.id_taxesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.sort_order field.
	''' </summary>
	Public Property sort_order() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.sort_orderColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.sort_orderColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sort_orderSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sort_orderColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sort_orderDefault() As String
        Get
            Return TableUtils.sort_orderColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.tax_code field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.tax_name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.tax_print field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.tax_rate field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tax_group_dtls_.calc_type field.
	''' </summary>
	Public Property calc_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.calc_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.calc_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property calc_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.calc_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property calc_typeDefault() As String
        Get
            Return TableUtils.calc_typeColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
