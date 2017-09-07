' This class is "generated" and will be overwritten.
' Your customizations should be made in HsnRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="HsnRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="HsnTable"></see> class.
''' </remarks>
''' <seealso cref="HsnTable"></seealso>
''' <seealso cref="HsnRecord"></seealso>

<Serializable()> Public Class BaseHsnRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As HsnTable = HsnTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.hsn field.
	''' </summary>
	Public Function GethsnValue() As ColumnValue
		Return Me.GetValue(TableUtils.hsnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.hsn field.
	''' </summary>
	Public Function GethsnFieldValue() As String
		Return CType(Me.GetValue(TableUtils.hsnColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Hsn_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Hsn_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.gst_description field.
	''' </summary>
	Public Function Getgst_descriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_descriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.gst_description field.
	''' </summary>
	Public Function Getgst_descriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gst_descriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Hsn_.gst_description field.
	''' </summary>
	Public Sub Setgst_descriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Hsn_.gst_description field.
	''' </summary>
	Public Sub Setgst_descriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.gst_uom field.
	''' </summary>
	Public Function Getgst_uomValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Hsn_.gst_uom field.
	''' </summary>
	Public Function Getgst_uomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gst_uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Hsn_.gst_uom field.
	''' </summary>
	Public Sub Setgst_uomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Hsn_.gst_uom field.
	''' </summary>
	Public Sub Setgst_uomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_uomColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Hsn_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Hsn_.hsn field.
	''' </summary>
	Public Property hsn() As String
		Get 
			Return CType(Me.GetValue(TableUtils.hsnColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.hsnColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property hsnSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.hsnColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property hsnDefault() As String
        Get
            Return TableUtils.hsnColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Hsn_.gst_description field.
	''' </summary>
	Public Property gst_description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.gst_descriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.gst_descriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gst_descriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gst_descriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gst_descriptionDefault() As String
        Get
            Return TableUtils.gst_descriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Hsn_.gst_uom field.
	''' </summary>
	Public Property gst_uom() As String
		Get 
			Return CType(Me.GetValue(TableUtils.gst_uomColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.gst_uomColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gst_uomSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gst_uomColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gst_uomDefault() As String
        Get
            Return TableUtils.gst_uomColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
