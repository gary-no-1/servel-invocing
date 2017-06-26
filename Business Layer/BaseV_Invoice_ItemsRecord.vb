' This class is "generated" and will be overwritten.
' Your customizations should be made in V_Invoice_ItemsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_Invoice_ItemsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_Invoice_ItemsView"></see> class.
''' </remarks>
''' <seealso cref="V_Invoice_ItemsView"></seealso>
''' <seealso cref="V_Invoice_ItemsRecord"></seealso>

<Serializable()> Public Class BaseV_Invoice_ItemsRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_Invoice_ItemsView = V_Invoice_ItemsView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.inv_no field.
	''' </summary>
	Public Function Getinv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.inv_no field.
	''' </summary>
	Public Function Getinv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.item_code field.
	''' </summary>
	Public Function Getitem_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.item_code field.
	''' </summary>
	Public Function Getitem_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.item_description field.
	''' </summary>
	Public Function Getitem_descriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_descriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.item_description field.
	''' </summary>
	Public Function Getitem_descriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_descriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.item_description field.
	''' </summary>
	Public Sub Setitem_descriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.item_description field.
	''' </summary>
	Public Sub Setitem_descriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.name field.
	''' </summary>
	Public Function GetnameValue() As ColumnValue
		Return Me.GetValue(TableUtils.nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.name field.
	''' </summary>
	Public Function GetnameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.item_group field.
	''' </summary>
	Public Function Getitem_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.item_group field.
	''' </summary>
	Public Function Getitem_groupFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_groupColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.item_group field.
	''' </summary>
	Public Sub Setitem_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.item_group field.
	''' </summary>
	Public Sub Setitem_groupFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.uom field.
	''' </summary>
	Public Function GetuomValue() As ColumnValue
		Return Me.GetValue(TableUtils.uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.uom field.
	''' </summary>
	Public Function GetuomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Function GetqtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.qtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Function GetqtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.qtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Function GetrateValue() As ColumnValue
		Return Me.GetValue(TableUtils.rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Function GetrateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.rate field.
	''' </summary>
	Public Sub SetrateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Function GetamountValue() As ColumnValue
		Return Me.GetValue(TableUtils.amountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Function GetamountFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.amountColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Function Getid2Value() As ColumnValue
		Return Me.GetValue(TableUtils.id2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Function Getid2FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id2Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Sub Setid2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Sub Setid2FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Sub Setid2FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Sub Setid2FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Sub Setid2FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id2Column)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.inv_dt field.
	''' </summary>
	Public Property inv_dt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.inv_dtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.inv_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_dtDefault() As String
        Get
            Return TableUtils.inv_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.inv_no field.
	''' </summary>
	Public Property inv_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.inv_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.inv_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_noDefault() As String
        Get
            Return TableUtils.inv_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.item_code field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.item_description field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.name field.
	''' </summary>
	Public Property name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.nameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.nameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property nameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.nameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property nameDefault() As String
        Get
            Return TableUtils.nameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.item_group field.
	''' </summary>
	Public Property item_group() As String
		Get 
			Return CType(Me.GetValue(TableUtils.item_groupColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.item_groupColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property item_groupSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.item_groupColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property item_groupDefault() As String
        Get
            Return TableUtils.item_groupColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.uom field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.qty field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.rate field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.amount field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Items_.id2 field.
	''' </summary>
	Public Property id2() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id2Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id2Default() As String
        Get
            Return TableUtils.id2Column.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
