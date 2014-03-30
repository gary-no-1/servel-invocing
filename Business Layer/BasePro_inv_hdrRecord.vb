' This class is "generated" and will be overwritten.
' Your customizations should be made in Pro_inv_hdrRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Pro_inv_hdrRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Pro_inv_hdrTable"></see> class.
''' </remarks>
''' <seealso cref="Pro_inv_hdrTable"></seealso>
''' <seealso cref="Pro_inv_hdrRecord"></seealso>

<Serializable()> Public Class BasePro_inv_hdrRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Pro_inv_hdrTable = Pro_inv_hdrTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Function Getpro_inv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.pro_inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Function Getpro_inv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.pro_inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Sub Setpro_inv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pro_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Sub Setpro_inv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pro_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Function Getpro_inv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.pro_inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Function Getpro_inv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.pro_inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Sub Setpro_inv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pro_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Sub Setpro_inv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.pro_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Sub Setpro_inv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pro_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Function Getsale_ord_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.sale_ord_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Function Getsale_ord_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sale_ord_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Sub Setsale_ord_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sale_ord_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Sub Setsale_ord_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sale_ord_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Function Getsale_ord_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.sale_ord_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Function Getsale_ord_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.sale_ord_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Function Getid_partyValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_partyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Function Getid_partyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_partyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.bill_name field.
	''' </summary>
	Public Function Getbill_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.bill_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.bill_name field.
	''' </summary>
	Public Function Getbill_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.bill_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.bill_name field.
	''' </summary>
	Public Sub Setbill_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.bill_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.bill_name field.
	''' </summary>
	Public Sub Setbill_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.bill_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.bill_address field.
	''' </summary>
	Public Function Getbill_addressValue() As ColumnValue
		Return Me.GetValue(TableUtils.bill_addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.bill_address field.
	''' </summary>
	Public Function Getbill_addressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.bill_addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.bill_address field.
	''' </summary>
	Public Sub Setbill_addressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.bill_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.bill_address field.
	''' </summary>
	Public Sub Setbill_addressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.bill_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.ship_name field.
	''' </summary>
	Public Function Getship_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ship_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.ship_name field.
	''' </summary>
	Public Function Getship_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ship_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.ship_name field.
	''' </summary>
	Public Sub Setship_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ship_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.ship_name field.
	''' </summary>
	Public Sub Setship_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ship_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.ship_address field.
	''' </summary>
	Public Function Getship_addressValue() As ColumnValue
		Return Me.GetValue(TableUtils.ship_addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.ship_address field.
	''' </summary>
	Public Function Getship_addressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ship_addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.ship_address field.
	''' </summary>
	Public Sub Setship_addressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ship_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.ship_address field.
	''' </summary>
	Public Sub Setship_addressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ship_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.tin_no field.
	''' </summary>
	Public Function Gettin_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tin_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.tin_no field.
	''' </summary>
	Public Function Gettin_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tin_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.po_no field.
	''' </summary>
	Public Function Getpo_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.po_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.po_no field.
	''' </summary>
	Public Function Getpo_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.po_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.po_no field.
	''' </summary>
	Public Sub Setpo_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.po_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.po_no field.
	''' </summary>
	Public Sub Setpo_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.po_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.po_dt field.
	''' </summary>
	Public Function Getpo_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.po_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.po_dt field.
	''' </summary>
	Public Function Getpo_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.po_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_tax_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_tax_groupColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Property pro_inv_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.pro_inv_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.pro_inv_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property pro_inv_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.pro_inv_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property pro_inv_noDefault() As String
        Get
            Return TableUtils.pro_inv_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Property pro_inv_dt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.pro_inv_dtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.pro_inv_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property pro_inv_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.pro_inv_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property pro_inv_dtDefault() As String
        Get
            Return TableUtils.pro_inv_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Property sale_ord_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sale_ord_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sale_ord_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sale_ord_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sale_ord_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sale_ord_noDefault() As String
        Get
            Return TableUtils.sale_ord_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Property sale_ord_dt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.sale_ord_dtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.sale_ord_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sale_ord_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sale_ord_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sale_ord_dtDefault() As String
        Get
            Return TableUtils.sale_ord_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.id_party field.
	''' </summary>
	Public Property id_party() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_partyColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_partyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_partySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_partyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_partyDefault() As String
        Get
            Return TableUtils.id_partyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.bill_name field.
	''' </summary>
	Public Property bill_name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.bill_nameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.bill_nameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property bill_nameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.bill_nameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property bill_nameDefault() As String
        Get
            Return TableUtils.bill_nameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.bill_address field.
	''' </summary>
	Public Property bill_address() As String
		Get 
			Return CType(Me.GetValue(TableUtils.bill_addressColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.bill_addressColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property bill_addressSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.bill_addressColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property bill_addressDefault() As String
        Get
            Return TableUtils.bill_addressColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.ship_name field.
	''' </summary>
	Public Property ship_name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ship_nameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ship_nameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ship_nameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ship_nameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ship_nameDefault() As String
        Get
            Return TableUtils.ship_nameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.ship_address field.
	''' </summary>
	Public Property ship_address() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ship_addressColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ship_addressColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ship_addressSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ship_addressColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ship_addressDefault() As String
        Get
            Return TableUtils.ship_addressColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.tin_no field.
	''' </summary>
	Public Property tin_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tin_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tin_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tin_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tin_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tin_noDefault() As String
        Get
            Return TableUtils.tin_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.po_no field.
	''' </summary>
	Public Property po_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.po_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.po_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property po_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.po_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property po_noDefault() As String
        Get
            Return TableUtils.po_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.po_dt field.
	''' </summary>
	Public Property po_dt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.po_dtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.po_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property po_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.po_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property po_dtDefault() As String
        Get
            Return TableUtils.po_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.id_tax_group field.
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
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.item_total field.
	''' </summary>
	Public Property item_total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.item_totalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property item_totalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.item_totalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property item_totalDefault() As String
        Get
            Return TableUtils.item_totalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Pro_inv_hdr_.grand_total field.
	''' </summary>
	Public Property grand_total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.grand_totalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property grand_totalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.grand_totalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property grand_totalDefault() As String
        Get
            Return TableUtils.grand_totalColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
