' This class is "generated" and will be overwritten.
' Your customizations should be made in StatesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="StatesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="StatesTable"></see> class.
''' </remarks>
''' <seealso cref="StatesTable"></seealso>
''' <seealso cref="StatesRecord"></seealso>

<Serializable()> Public Class BaseStatesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As StatesTable = StatesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's States_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's States_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's States_.state_code field.
	''' </summary>
	Public Function Getstate_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.state_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's States_.state_code field.
	''' </summary>
	Public Function Getstate_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.state_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's States_.state_code field.
	''' </summary>
	Public Sub Setstate_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.state_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's States_.state_code field.
	''' </summary>
	Public Sub Setstate_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.state_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's States_.state_name field.
	''' </summary>
	Public Function Getstate_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.state_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's States_.state_name field.
	''' </summary>
	Public Function Getstate_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.state_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's States_.state_name field.
	''' </summary>
	Public Sub Setstate_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.state_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's States_.state_name field.
	''' </summary>
	Public Sub Setstate_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.state_nameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's States_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's States_.state_code field.
	''' </summary>
	Public Property state_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.state_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.state_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property state_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.state_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property state_codeDefault() As String
        Get
            Return TableUtils.state_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's States_.state_name field.
	''' </summary>
	Public Property state_name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.state_nameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.state_nameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property state_nameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.state_nameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property state_nameDefault() As String
        Get
            Return TableUtils.state_nameColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
