' This class is "generated" and will be overwritten.
' Your customizations should be made in So_itemsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="So_itemsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="So_itemsTable"></see> class.
''' </remarks>
''' <seealso cref="So_itemsTable"></seealso>
''' <seealso cref="So_itemsRecord"></seealso>

<Serializable()> Public Class BaseSo_itemsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As So_itemsTable = So_itemsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Function Getid_so_hdrValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_so_hdrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Function Getid_so_hdrFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_so_hdrColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.id_item field.
	''' </summary>
	Public Function Getid_itemValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_itemColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.id_item field.
	''' </summary>
	Public Function Getid_itemFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_itemColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_item field.
	''' </summary>
	Public Sub Setid_itemFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_itemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_item field.
	''' </summary>
	Public Sub Setid_itemFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_itemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_item field.
	''' </summary>
	Public Sub Setid_itemFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_itemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_item field.
	''' </summary>
	Public Sub Setid_itemFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_itemColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.id_item field.
	''' </summary>
	Public Sub Setid_itemFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_itemColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.item_code field.
	''' </summary>
	Public Function Getitem_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.item_code field.
	''' </summary>
	Public Function Getitem_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.item_description field.
	''' </summary>
	Public Function Getitem_descriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_descriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.item_description field.
	''' </summary>
	Public Function Getitem_descriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_descriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.item_description field.
	''' </summary>
	Public Sub Setitem_descriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.item_description field.
	''' </summary>
	Public Sub Setitem_descriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.uom field.
	''' </summary>
	Public Function GetuomValue() As ColumnValue
		Return Me.GetValue(TableUtils.uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.uom field.
	''' </summary>
	Public Function GetuomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.qty field.
	''' </summary>
	Public Function GetqtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.qtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.qty field.
	''' </summary>
	Public Function GetqtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.qtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.rate field.
	''' </summary>
	Public Function GetrateValue() As ColumnValue
		Return Me.GetValue(TableUtils.rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.rate field.
	''' </summary>
	Public Function GetrateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Function Getass_valueValue() As ColumnValue
		Return Me.GetValue(TableUtils.ass_valueColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Function Getass_valueFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.ass_valueColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Sub Setass_valueFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ass_valueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Sub Setass_valueFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.ass_valueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Sub Setass_valueFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ass_valueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Sub Setass_valueFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ass_valueColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Sub Setass_valueFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ass_valueColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.amount field.
	''' </summary>
	Public Function GetamountValue() As ColumnValue
		Return Me.GetValue(TableUtils.amountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_items_.amount field.
	''' </summary>
	Public Function GetamountFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.amountColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_items_.id_so_hdr field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_items_.id_item field.
	''' </summary>
	Public Property id_item() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_itemColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_itemColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_itemSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_itemColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_itemDefault() As String
        Get
            Return TableUtils.id_itemColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.item_code field.
	''' </summary>
	Public Property item_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.item_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.item_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property item_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.item_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property item_codeDefault() As String
        Get
            Return TableUtils.item_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.item_description field.
	''' </summary>
	Public Property item_description() As String
		Get 
			Return CType(Me.GetValue(TableUtils.item_descriptionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.item_descriptionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property item_descriptionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.item_descriptionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property item_descriptionDefault() As String
        Get
            Return TableUtils.item_descriptionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.uom field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.qty field.
	''' </summary>
	Public Property qty() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.qtyColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.qtyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property qtySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.qtyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property qtyDefault() As String
        Get
            Return TableUtils.qtyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.rate field.
	''' </summary>
	Public Property rate() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.rateColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.rateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property rateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.rateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property rateDefault() As String
        Get
            Return TableUtils.rateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.ass_value field.
	''' </summary>
	Public Property ass_value() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.ass_valueColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.ass_valueColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ass_valueSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ass_valueColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ass_valueDefault() As String
        Get
            Return TableUtils.ass_valueColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_items_.amount field.
	''' </summary>
	Public Property amount() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.amountColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.amountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property amountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.amountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property amountDefault() As String
        Get
            Return TableUtils.amountColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
