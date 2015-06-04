' This class is "generated" and will be overwritten.
' Your customizations should be made in So_termsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="So_termsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="So_termsTable"></see> class.
''' </remarks>
''' <seealso cref="So_termsTable"></seealso>
''' <seealso cref="So_termsRecord"></seealso>

<Serializable()> Public Class BaseSo_termsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As So_termsTable = So_termsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Function Getid_so_hdrValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_so_hdrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Function Getid_so_hdrFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_so_hdrColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.narration field.
	''' </summary>
	Public Function GetnarrationValue() As ColumnValue
		Return Me.GetValue(TableUtils.narrationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.narration field.
	''' </summary>
	Public Function GetnarrationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.narrationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.narration field.
	''' </summary>
	Public Sub SetnarrationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.narrationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.narration field.
	''' </summary>
	Public Sub SetnarrationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.narrationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Function Getsort_orderValue() As ColumnValue
		Return Me.GetValue(TableUtils.sort_orderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Function Getsort_orderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.sort_orderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_terms_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_terms_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_terms_.id_so_hdr field.
	''' </summary>
	Public Property id_so_hdr() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_so_hdrColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_so_hdrSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_so_hdrColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_so_hdrDefault() As String
        Get
            Return TableUtils.id_so_hdrColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_terms_.narration field.
	''' </summary>
	Public Property narration() As String
		Get 
			Return CType(Me.GetValue(TableUtils.narrationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.narrationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property narrationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.narrationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property narrationDefault() As String
        Get
            Return TableUtils.narrationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_terms_.sort_order field.
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



#End Region

End Class
End Namespace
