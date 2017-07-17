' This class is "generated" and will be overwritten.
' Your customizations should be made in Item_typesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Item_typesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Item_typesTable"></see> class.
''' </remarks>
''' <seealso cref="Item_typesTable"></seealso>
''' <seealso cref="Item_typesRecord"></seealso>

<Serializable()> Public Class BaseItem_typesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Item_typesTable = Item_typesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_types_.item_type field.
	''' </summary>
	Public Function Getitem_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_types_.item_type field.
	''' </summary>
	Public Function Getitem_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_types_.item_type field.
	''' </summary>
	Public Sub Setitem_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_types_.item_type field.
	''' </summary>
	Public Sub Setitem_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_types_.gst_service field.
	''' </summary>
	Public Function Getgst_serviceValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_serviceColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_types_.gst_service field.
	''' </summary>
	Public Function Getgst_serviceFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.gst_serviceColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_types_.gst_service field.
	''' </summary>
	Public Sub Setgst_serviceFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_serviceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_types_.gst_service field.
	''' </summary>
	Public Sub Setgst_serviceFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.gst_serviceColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_types_.gst_service field.
	''' </summary>
	Public Sub Setgst_serviceFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_serviceColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Item_types_.item_type field.
	''' </summary>
	Public Property item_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.item_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.item_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property item_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.item_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property item_typeDefault() As String
        Get
            Return TableUtils.item_typeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Item_types_.gst_service field.
	''' </summary>
	Public Property gst_service() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.gst_serviceColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.gst_serviceColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gst_serviceSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gst_serviceColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gst_serviceDefault() As String
        Get
            Return TableUtils.gst_serviceColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
