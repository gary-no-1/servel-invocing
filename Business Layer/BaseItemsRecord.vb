' This class is "generated" and will be overwritten.
' Your customizations should be made in ItemsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="ItemsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="ItemsTable"></see> class.
''' </remarks>
''' <seealso cref="ItemsTable"></seealso>
''' <seealso cref="ItemsRecord"></seealso>

<Serializable()> Public Class BaseItemsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As ItemsTable = ItemsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.item_code field.
	''' </summary>
	Public Function Getitem_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.item_code field.
	''' </summary>
	Public Function Getitem_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.item_description field.
	''' </summary>
	Public Function Getitem_descriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_descriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.item_description field.
	''' </summary>
	Public Function Getitem_descriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_descriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.item_description field.
	''' </summary>
	Public Sub Setitem_descriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.item_description field.
	''' </summary>
	Public Sub Setitem_descriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Function Getid_item_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_item_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Function Getid_item_groupFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_item_groupColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Sub Setid_item_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Sub Setid_item_groupFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Sub Setid_item_groupFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Sub Setid_item_groupFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Sub Setid_item_groupFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_item_groupColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.item_type field.
	''' </summary>
	Public Function Getitem_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.item_type field.
	''' </summary>
	Public Function Getitem_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.item_type field.
	''' </summary>
	Public Sub Setitem_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.item_type field.
	''' </summary>
	Public Sub Setitem_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.uom field.
	''' </summary>
	Public Function GetuomValue() As ColumnValue
		Return Me.GetValue(TableUtils.uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.uom field.
	''' </summary>
	Public Function GetuomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.material_category field.
	''' </summary>
	Public Function Getmaterial_categoryValue() As ColumnValue
		Return Me.GetValue(TableUtils.material_categoryColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.material_category field.
	''' </summary>
	Public Function Getmaterial_categoryFieldValue() As String
		Return CType(Me.GetValue(TableUtils.material_categoryColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.material_category field.
	''' </summary>
	Public Sub Setmaterial_categoryFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.material_categoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.material_category field.
	''' </summary>
	Public Sub Setmaterial_categoryFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.material_categoryColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.tariff_no field.
	''' </summary>
	Public Function Gettariff_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tariff_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.tariff_no field.
	''' </summary>
	Public Function Gettariff_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tariff_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.tariff_no field.
	''' </summary>
	Public Sub Settariff_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tariff_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.tariff_no field.
	''' </summary>
	Public Sub Settariff_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tariff_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.specification field.
	''' </summary>
	Public Function GetspecificationValue() As ColumnValue
		Return Me.GetValue(TableUtils.specificationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.specification field.
	''' </summary>
	Public Function GetspecificationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.specificationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.specification field.
	''' </summary>
	Public Sub SetspecificationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.specificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.specification field.
	''' </summary>
	Public Sub SetspecificationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.specificationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Function Getclosing_stockValue() As ColumnValue
		Return Me.GetValue(TableUtils.closing_stockColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Function Getclosing_stockFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.closing_stockColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Sub Setclosing_stockFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.closing_stockColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Sub Setclosing_stockFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.closing_stockColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Sub Setclosing_stockFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.closing_stockColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Sub Setclosing_stockFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.closing_stockColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Sub Setclosing_stockFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.closing_stockColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.hsn field.
	''' </summary>
	Public Function GethsnValue() As ColumnValue
		Return Me.GetValue(TableUtils.hsnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Items_.hsn field.
	''' </summary>
	Public Function GethsnFieldValue() As String
		Return CType(Me.GetValue(TableUtils.hsnColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Items_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.hsnColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Items_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Items_.item_code field.
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
	''' This is a convenience property that provides direct access to the value of the record's Items_.item_description field.
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
	''' This is a convenience property that provides direct access to the value of the record's Items_.id_item_group field.
	''' </summary>
	Public Property id_item_group() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_item_groupColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_item_groupColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_item_groupSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_item_groupColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_item_groupDefault() As String
        Get
            Return TableUtils.id_item_groupColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Items_.item_type field.
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
	''' This is a convenience property that provides direct access to the value of the record's Items_.uom field.
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
	''' This is a convenience property that provides direct access to the value of the record's Items_.material_category field.
	''' </summary>
	Public Property material_category() As String
		Get 
			Return CType(Me.GetValue(TableUtils.material_categoryColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.material_categoryColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property material_categorySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.material_categoryColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property material_categoryDefault() As String
        Get
            Return TableUtils.material_categoryColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Items_.tariff_no field.
	''' </summary>
	Public Property tariff_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tariff_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tariff_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tariff_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tariff_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tariff_noDefault() As String
        Get
            Return TableUtils.tariff_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Items_.specification field.
	''' </summary>
	Public Property specification() As String
		Get 
			Return CType(Me.GetValue(TableUtils.specificationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.specificationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property specificationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.specificationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property specificationDefault() As String
        Get
            Return TableUtils.specificationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Items_.closing_stock field.
	''' </summary>
	Public Property closing_stock() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.closing_stockColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.closing_stockColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property closing_stockSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.closing_stockColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property closing_stockDefault() As String
        Get
            Return TableUtils.closing_stockColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Items_.hsn field.
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



#End Region

End Class
End Namespace
