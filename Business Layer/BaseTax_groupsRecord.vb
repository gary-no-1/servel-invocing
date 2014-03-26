' This class is "generated" and will be overwritten.
' Your customizations should be made in Tax_groupsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Tax_groupsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Tax_groupsTable"></see> class.
''' </remarks>
''' <seealso cref="Tax_groupsTable"></seealso>
''' <seealso cref="Tax_groupsRecord"></seealso>

<Serializable()> Public Class BaseTax_groupsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Tax_groupsTable = Tax_groupsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.tax_group_code field.
	''' </summary>
	Public Function Gettax_group_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_group_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.tax_group_code field.
	''' </summary>
	Public Function Gettax_group_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_group_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.tax_group_code field.
	''' </summary>
	Public Sub Settax_group_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_group_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.tax_group_code field.
	''' </summary>
	Public Sub Settax_group_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_group_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.notes field.
	''' </summary>
	Public Function GetnotesValue() As ColumnValue
		Return Me.GetValue(TableUtils.notesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.notes field.
	''' </summary>
	Public Function GetnotesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.notesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.notes field.
	''' </summary>
	Public Sub SetnotesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.notesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.notes field.
	''' </summary>
	Public Sub SetnotesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.notesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Function Getid_taxes_1Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Function Getid_taxes_1FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_1Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Sub Setid_taxes_1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Sub Setid_taxes_1FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Sub Setid_taxes_1FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Sub Setid_taxes_1FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Sub Setid_taxes_1FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_1Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Function Getid_taxes_2Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Function Getid_taxes_2FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_2Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Sub Setid_taxes_2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Sub Setid_taxes_2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Sub Setid_taxes_2FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Sub Setid_taxes_2FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Sub Setid_taxes_2FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_2Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Function Getid_taxes_3Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Function Getid_taxes_3FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_3Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Sub Setid_taxes_3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Sub Setid_taxes_3FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Sub Setid_taxes_3FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Sub Setid_taxes_3FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Sub Setid_taxes_3FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_3Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Function Getid_taxes_4Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Function Getid_taxes_4FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_4Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Sub Setid_taxes_4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Sub Setid_taxes_4FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Sub Setid_taxes_4FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Sub Setid_taxes_4FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Sub Setid_taxes_4FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_4Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Function Getid_taxes_5Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_5Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Function Getid_taxes_5FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_5Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Sub Setid_taxes_5FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Sub Setid_taxes_5FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Sub Setid_taxes_5FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Sub Setid_taxes_5FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_5Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Sub Setid_taxes_5FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_5Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Function Getid_taxes_6Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_6Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Function Getid_taxes_6FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_6Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Sub Setid_taxes_6FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Sub Setid_taxes_6FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Sub Setid_taxes_6FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Sub Setid_taxes_6FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_6Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Sub Setid_taxes_6FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_6Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Function Getid_taxes_7Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_7Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Function Getid_taxes_7FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_7Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Sub Setid_taxes_7FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Sub Setid_taxes_7FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Sub Setid_taxes_7FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Sub Setid_taxes_7FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_7Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Sub Setid_taxes_7FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_7Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Function Getid_taxes_8Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_8Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Function Getid_taxes_8FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_8Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Sub Setid_taxes_8FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Sub Setid_taxes_8FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Sub Setid_taxes_8FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Sub Setid_taxes_8FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_8Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Sub Setid_taxes_8FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_8Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Function Getid_taxes_9Value() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxes_9Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Function Getid_taxes_9FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxes_9Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Sub Setid_taxes_9FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxes_9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Sub Setid_taxes_9FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxes_9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Sub Setid_taxes_9FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Sub Setid_taxes_9FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_9Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Sub Setid_taxes_9FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxes_9Column)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.tax_group_code field.
	''' </summary>
	Public Property tax_group_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_group_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_group_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_group_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_group_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_group_codeDefault() As String
        Get
            Return TableUtils.tax_group_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.notes field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_1 field.
	''' </summary>
	Public Property id_taxes_1() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_1Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_1Default() As String
        Get
            Return TableUtils.id_taxes_1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_2 field.
	''' </summary>
	Public Property id_taxes_2() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_2Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_2Default() As String
        Get
            Return TableUtils.id_taxes_2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_3 field.
	''' </summary>
	Public Property id_taxes_3() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_3Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_3Default() As String
        Get
            Return TableUtils.id_taxes_3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_4 field.
	''' </summary>
	Public Property id_taxes_4() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_4Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_4Default() As String
        Get
            Return TableUtils.id_taxes_4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_5 field.
	''' </summary>
	Public Property id_taxes_5() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_5Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_5Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_5Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_5Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_5Default() As String
        Get
            Return TableUtils.id_taxes_5Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_6 field.
	''' </summary>
	Public Property id_taxes_6() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_6Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_6Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_6Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_6Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_6Default() As String
        Get
            Return TableUtils.id_taxes_6Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_7 field.
	''' </summary>
	Public Property id_taxes_7() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_7Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_7Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_7Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_7Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_7Default() As String
        Get
            Return TableUtils.id_taxes_7Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_8 field.
	''' </summary>
	Public Property id_taxes_8() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_8Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_8Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_8Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_8Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_8Default() As String
        Get
            Return TableUtils.id_taxes_8Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Tax_groups_.id_taxes_9 field.
	''' </summary>
	Public Property id_taxes_9() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxes_9Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxes_9Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxes_9Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxes_9Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxes_9Default() As String
        Get
            Return TableUtils.id_taxes_9Column.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
