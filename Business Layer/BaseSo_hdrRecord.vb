' This class is "generated" and will be overwritten.
' Your customizations should be made in So_hdrRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="So_hdrRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="So_hdrTable"></see> class.
''' </remarks>
''' <seealso cref="So_hdrTable"></seealso>
''' <seealso cref="So_hdrRecord"></seealso>

<Serializable()> Public Class BaseSo_hdrRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As So_hdrTable = So_hdrTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.sale_ord_no field.
	''' </summary>
	Public Function Getsale_ord_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.sale_ord_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.sale_ord_no field.
	''' </summary>
	Public Function Getsale_ord_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sale_ord_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.sale_ord_no field.
	''' </summary>
	Public Sub Setsale_ord_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sale_ord_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.sale_ord_no field.
	''' </summary>
	Public Sub Setsale_ord_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sale_ord_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.sale_ord_dt field.
	''' </summary>
	Public Function Getsale_ord_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.sale_ord_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.sale_ord_dt field.
	''' </summary>
	Public Function Getsale_ord_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.sale_ord_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Function Getid_partyValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_partyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Function Getid_partyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_partyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.bill_name field.
	''' </summary>
	Public Function Getbill_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.bill_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.bill_name field.
	''' </summary>
	Public Function Getbill_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.bill_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.bill_name field.
	''' </summary>
	Public Sub Setbill_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.bill_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.bill_name field.
	''' </summary>
	Public Sub Setbill_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.bill_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.bill_address field.
	''' </summary>
	Public Function Getbill_addressValue() As ColumnValue
		Return Me.GetValue(TableUtils.bill_addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.bill_address field.
	''' </summary>
	Public Function Getbill_addressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.bill_addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.bill_address field.
	''' </summary>
	Public Sub Setbill_addressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.bill_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.bill_address field.
	''' </summary>
	Public Sub Setbill_addressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.bill_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Function Getid_siteValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_siteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Function Getid_siteFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_siteColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_siteColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.ship_name field.
	''' </summary>
	Public Function Getship_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ship_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.ship_name field.
	''' </summary>
	Public Function Getship_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ship_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.ship_name field.
	''' </summary>
	Public Sub Setship_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ship_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.ship_name field.
	''' </summary>
	Public Sub Setship_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ship_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.ship_address field.
	''' </summary>
	Public Function Getship_addressValue() As ColumnValue
		Return Me.GetValue(TableUtils.ship_addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.ship_address field.
	''' </summary>
	Public Function Getship_addressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ship_addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.ship_address field.
	''' </summary>
	Public Sub Setship_addressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ship_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.ship_address field.
	''' </summary>
	Public Sub Setship_addressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ship_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.tin_no field.
	''' </summary>
	Public Function Gettin_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tin_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.tin_no field.
	''' </summary>
	Public Function Gettin_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tin_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.po_no field.
	''' </summary>
	Public Function Getpo_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.po_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.po_no field.
	''' </summary>
	Public Function Getpo_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.po_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.po_no field.
	''' </summary>
	Public Sub Setpo_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.po_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.po_no field.
	''' </summary>
	Public Sub Setpo_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.po_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.po_dt field.
	''' </summary>
	Public Function Getpo_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.po_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.po_dt field.
	''' </summary>
	Public Function Getpo_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.po_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.ecc_no field.
	''' </summary>
	Public Function Getecc_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.ecc_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.ecc_no field.
	''' </summary>
	Public Function Getecc_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ecc_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.ecc_no field.
	''' </summary>
	Public Sub Setecc_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ecc_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.ecc_no field.
	''' </summary>
	Public Sub Setecc_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ecc_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Function Getid_commodityValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_commodityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Function Getid_commodityFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_commodityColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_commodityColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_tax_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_tax_groupColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.inv_cr8_dt field.
	''' </summary>
	Public Function Getinv_cr8_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_cr8_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.inv_cr8_dt field.
	''' </summary>
	Public Function Getinv_cr8_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.inv_cr8_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.inv_cr8_dt field.
	''' </summary>
	Public Sub Setinv_cr8_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_cr8_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.inv_cr8_dt field.
	''' </summary>
	Public Sub Setinv_cr8_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.inv_cr8_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.inv_cr8_dt field.
	''' </summary>
	Public Sub Setinv_cr8_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_cr8_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.inv_created field.
	''' </summary>
	Public Function Getinv_createdValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_createdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.inv_created field.
	''' </summary>
	Public Function Getinv_createdFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_createdColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.inv_created field.
	''' </summary>
	Public Sub Setinv_createdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_createdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.inv_created field.
	''' </summary>
	Public Sub Setinv_createdFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_createdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.email field.
	''' </summary>
	Public Function GetemailValue() As ColumnValue
		Return Me.GetValue(TableUtils.emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.email field.
	''' </summary>
	Public Function GetemailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.additional_email field.
	''' </summary>
	Public Function Getadditional_emailValue() As ColumnValue
		Return Me.GetValue(TableUtils.additional_emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.additional_email field.
	''' </summary>
	Public Function Getadditional_emailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.additional_emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.additional_email field.
	''' </summary>
	Public Sub Setadditional_emailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.additional_emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.additional_email field.
	''' </summary>
	Public Sub Setadditional_emailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.additional_emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.contact field.
	''' </summary>
	Public Function GetcontactValue() As ColumnValue
		Return Me.GetValue(TableUtils.contactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.contact field.
	''' </summary>
	Public Function GetcontactFieldValue() As String
		Return CType(Me.GetValue(TableUtils.contactColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.contact field.
	''' </summary>
	Public Sub SetcontactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.contactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.contact field.
	''' </summary>
	Public Sub SetcontactFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.contactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.phone field.
	''' </summary>
	Public Function GetphoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.phoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.phone field.
	''' </summary>
	Public Function GetphoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.phoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.remark field.
	''' </summary>
	Public Function GetremarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.remarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.remark field.
	''' </summary>
	Public Function GetremarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.remarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.remark field.
	''' </summary>
	Public Sub SetremarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.remarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.remark field.
	''' </summary>
	Public Sub SetremarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.remarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.excise_remark field.
	''' </summary>
	Public Function Getexcise_remarkValue() As ColumnValue
		Return Me.GetValue(TableUtils.excise_remarkColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.excise_remark field.
	''' </summary>
	Public Function Getexcise_remarkFieldValue() As String
		Return CType(Me.GetValue(TableUtils.excise_remarkColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.excise_remark field.
	''' </summary>
	Public Sub Setexcise_remarkFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.excise_remarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.excise_remark field.
	''' </summary>
	Public Sub Setexcise_remarkFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_remarkColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Function Getid_create_userValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_create_userColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Function Getid_create_userFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_create_userColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_create_userColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.created_on field.
	''' </summary>
	Public Function Getcreated_onValue() As ColumnValue
		Return Me.GetValue(TableUtils.created_onColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.created_on field.
	''' </summary>
	Public Function Getcreated_onFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.created_onColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.created_on field.
	''' </summary>
	Public Sub Setcreated_onFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.created_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.created_on field.
	''' </summary>
	Public Sub Setcreated_onFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.created_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.created_on field.
	''' </summary>
	Public Sub Setcreated_onFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.created_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Function Getid_update_userValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_update_userColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Function Getid_update_userFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_update_userColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_update_userColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.last_updated field.
	''' </summary>
	Public Function Getlast_updatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.last_updatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_hdr_.last_updated field.
	''' </summary>
	Public Function Getlast_updatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.last_updatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.last_updated field.
	''' </summary>
	Public Sub Setlast_updatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.last_updatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.last_updated field.
	''' </summary>
	Public Sub Setlast_updatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.last_updatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_hdr_.last_updated field.
	''' </summary>
	Public Sub Setlast_updatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.last_updatedColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.sale_ord_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.sale_ord_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id_party field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.bill_name field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.bill_address field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id_site field.
	''' </summary>
	Public Property id_site() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_siteColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_siteColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_siteSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_siteColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_siteDefault() As String
        Get
            Return TableUtils.id_siteColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.ship_name field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.ship_address field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.tin_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.po_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.po_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.ecc_no field.
	''' </summary>
	Public Property ecc_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.ecc_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.ecc_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property ecc_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.ecc_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property ecc_noDefault() As String
        Get
            Return TableUtils.ecc_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id_commodity field.
	''' </summary>
	Public Property id_commodity() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_commodityColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_commodityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_commoditySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_commodityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_commodityDefault() As String
        Get
            Return TableUtils.id_commodityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id_tax_group field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.item_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.grand_total field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.inv_cr8_dt field.
	''' </summary>
	Public Property inv_cr8_dt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.inv_cr8_dtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.inv_cr8_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_cr8_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_cr8_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_cr8_dtDefault() As String
        Get
            Return TableUtils.inv_cr8_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.inv_created field.
	''' </summary>
	Public Property inv_created() As String
		Get 
			Return CType(Me.GetValue(TableUtils.inv_createdColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.inv_createdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_createdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_createdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_createdDefault() As String
        Get
            Return TableUtils.inv_createdColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.email field.
	''' </summary>
	Public Property email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.emailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.emailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property emailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.emailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property emailDefault() As String
        Get
            Return TableUtils.emailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.additional_email field.
	''' </summary>
	Public Property additional_email() As String
		Get 
			Return CType(Me.GetValue(TableUtils.additional_emailColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.additional_emailColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property additional_emailSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.additional_emailColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property additional_emailDefault() As String
        Get
            Return TableUtils.additional_emailColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.contact field.
	''' </summary>
	Public Property contact() As String
		Get 
			Return CType(Me.GetValue(TableUtils.contactColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.contactColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property contactSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.contactColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property contactDefault() As String
        Get
            Return TableUtils.contactColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.phone field.
	''' </summary>
	Public Property phone() As String
		Get 
			Return CType(Me.GetValue(TableUtils.phoneColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.phoneColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property phoneSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.phoneColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property phoneDefault() As String
        Get
            Return TableUtils.phoneColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.remark field.
	''' </summary>
	Public Property remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.remarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.remarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property remarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.remarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property remarkDefault() As String
        Get
            Return TableUtils.remarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.excise_remark field.
	''' </summary>
	Public Property excise_remark() As String
		Get 
			Return CType(Me.GetValue(TableUtils.excise_remarkColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.excise_remarkColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property excise_remarkSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.excise_remarkColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property excise_remarkDefault() As String
        Get
            Return TableUtils.excise_remarkColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id_create_user field.
	''' </summary>
	Public Property id_create_user() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_create_userColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_create_userColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_create_userSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_create_userColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_create_userDefault() As String
        Get
            Return TableUtils.id_create_userColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.created_on field.
	''' </summary>
	Public Property created_on() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.created_onColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.created_onColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property created_onSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.created_onColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property created_onDefault() As String
        Get
            Return TableUtils.created_onColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.id_update_user field.
	''' </summary>
	Public Property id_update_user() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_update_userColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_update_userColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_update_userSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_update_userColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_update_userDefault() As String
        Get
            Return TableUtils.id_update_userColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_hdr_.last_updated field.
	''' </summary>
	Public Property last_updated() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.last_updatedColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.last_updatedColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property last_updatedSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.last_updatedColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property last_updatedDefault() As String
        Get
            Return TableUtils.last_updatedColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
