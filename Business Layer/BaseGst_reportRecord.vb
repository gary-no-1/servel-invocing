' This class is "generated" and will be overwritten.
' Your customizations should be made in Gst_reportRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Gst_reportRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Gst_reportTable"></see> class.
''' </remarks>
''' <seealso cref="Gst_reportTable"></seealso>
''' <seealso cref="Gst_reportRecord"></seealso>

<Serializable()> Public Class BaseGst_reportRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Gst_reportTable = Gst_reportTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Gst_report_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Gst_report_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Gst_report_.start_date field.
	''' </summary>
	Public Function Getstart_dateValue() As ColumnValue
		Return Me.GetValue(TableUtils.start_dateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Gst_report_.start_date field.
	''' </summary>
	Public Function Getstart_dateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.start_dateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Gst_report_.start_date field.
	''' </summary>
	Public Sub Setstart_dateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.start_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Gst_report_.start_date field.
	''' </summary>
	Public Sub Setstart_dateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.start_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Gst_report_.start_date field.
	''' </summary>
	Public Sub Setstart_dateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.start_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Gst_report_.end_date field.
	''' </summary>
	Public Function Getend_dateValue() As ColumnValue
		Return Me.GetValue(TableUtils.end_dateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Gst_report_.end_date field.
	''' </summary>
	Public Function Getend_dateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.end_dateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Gst_report_.end_date field.
	''' </summary>
	Public Sub Setend_dateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.end_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Gst_report_.end_date field.
	''' </summary>
	Public Sub Setend_dateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.end_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Gst_report_.end_date field.
	''' </summary>
	Public Sub Setend_dateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.end_dateColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Gst_report_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Gst_report_.start_date field.
	''' </summary>
	Public Property start_date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.start_dateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.start_dateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property start_dateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.start_dateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property start_dateDefault() As String
        Get
            Return TableUtils.start_dateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Gst_report_.end_date field.
	''' </summary>
	Public Property end_date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.end_dateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.end_dateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property end_dateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.end_dateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property end_dateDefault() As String
        Get
            Return TableUtils.end_dateColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
