' This class is "generated" and will be overwritten.
' Your customizations should be made in Inv_hdrRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Inv_hdrRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Inv_hdrTable"></see> class.
''' </remarks>
''' <seealso cref="Inv_hdrTable"></seealso>
''' <seealso cref="Inv_hdrRecord"></seealso>

<Serializable()> Public Class BaseInv_hdrRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Inv_hdrTable = Inv_hdrTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.inv_no field.
	''' </summary>
	Public Function Getinv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.inv_no field.
	''' </summary>
	Public Function Getinv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Function Getpro_inv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.pro_inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Function Getpro_inv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.pro_inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Sub Setpro_inv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pro_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.pro_inv_no field.
	''' </summary>
	Public Sub Setpro_inv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pro_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Function Getpro_inv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.pro_inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Function Getpro_inv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.pro_inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Sub Setpro_inv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pro_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Sub Setpro_inv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.pro_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.pro_inv_dt field.
	''' </summary>
	Public Sub Setpro_inv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pro_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Function Getsale_ord_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.sale_ord_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Function Getsale_ord_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sale_ord_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Sub Setsale_ord_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sale_ord_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.sale_ord_no field.
	''' </summary>
	Public Sub Setsale_ord_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sale_ord_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Function Getsale_ord_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.sale_ord_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Function Getsale_ord_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.sale_ord_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.sale_ord_dt field.
	''' </summary>
	Public Sub Setsale_ord_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sale_ord_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Function Getid_partyValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_partyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Function Getid_partyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_partyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Function Getid_siteValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_siteColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Function Getid_siteFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_siteColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_siteColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_site field.
	''' </summary>
	Public Sub Setid_siteFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_siteColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.bill_name field.
	''' </summary>
	Public Function Getbill_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.bill_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.bill_name field.
	''' </summary>
	Public Function Getbill_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.bill_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.bill_name field.
	''' </summary>
	Public Sub Setbill_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.bill_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.bill_name field.
	''' </summary>
	Public Sub Setbill_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.bill_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.bill_address field.
	''' </summary>
	Public Function Getbill_addressValue() As ColumnValue
		Return Me.GetValue(TableUtils.bill_addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.bill_address field.
	''' </summary>
	Public Function Getbill_addressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.bill_addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.bill_address field.
	''' </summary>
	Public Sub Setbill_addressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.bill_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.bill_address field.
	''' </summary>
	Public Sub Setbill_addressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.bill_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.ship_name field.
	''' </summary>
	Public Function Getship_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.ship_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.ship_name field.
	''' </summary>
	Public Function Getship_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ship_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.ship_name field.
	''' </summary>
	Public Sub Setship_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ship_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.ship_name field.
	''' </summary>
	Public Sub Setship_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ship_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.ship_address field.
	''' </summary>
	Public Function Getship_addressValue() As ColumnValue
		Return Me.GetValue(TableUtils.ship_addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.ship_address field.
	''' </summary>
	Public Function Getship_addressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ship_addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.ship_address field.
	''' </summary>
	Public Sub Setship_addressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ship_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.ship_address field.
	''' </summary>
	Public Sub Setship_addressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ship_addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.tin_no field.
	''' </summary>
	Public Function Gettin_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tin_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.tin_no field.
	''' </summary>
	Public Function Gettin_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tin_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.email field.
	''' </summary>
	Public Function GetemailValue() As ColumnValue
		Return Me.GetValue(TableUtils.emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.email field.
	''' </summary>
	Public Function GetemailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.additional_email field.
	''' </summary>
	Public Function Getadditional_emailValue() As ColumnValue
		Return Me.GetValue(TableUtils.additional_emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.additional_email field.
	''' </summary>
	Public Function Getadditional_emailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.additional_emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.additional_email field.
	''' </summary>
	Public Sub Setadditional_emailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.additional_emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.additional_email field.
	''' </summary>
	Public Sub Setadditional_emailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.additional_emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.contact field.
	''' </summary>
	Public Function GetcontactValue() As ColumnValue
		Return Me.GetValue(TableUtils.contactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.contact field.
	''' </summary>
	Public Function GetcontactFieldValue() As String
		Return CType(Me.GetValue(TableUtils.contactColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.contact field.
	''' </summary>
	Public Sub SetcontactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.contactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.contact field.
	''' </summary>
	Public Sub SetcontactFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.contactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.phone field.
	''' </summary>
	Public Function GetphoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.phoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.phone field.
	''' </summary>
	Public Function GetphoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.phoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.po_no field.
	''' </summary>
	Public Function Getpo_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.po_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.po_no field.
	''' </summary>
	Public Function Getpo_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.po_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.po_no field.
	''' </summary>
	Public Sub Setpo_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.po_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.po_no field.
	''' </summary>
	Public Sub Setpo_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.po_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.po_dt field.
	''' </summary>
	Public Function Getpo_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.po_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.po_dt field.
	''' </summary>
	Public Function Getpo_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.po_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.po_dt field.
	''' </summary>
	Public Sub Setpo_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.po_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Function Getid_commodityValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_commodityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Function Getid_commodityFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_commodityColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_commodityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_commodity field.
	''' </summary>
	Public Sub Setid_commodityFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_commodityColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_tax_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Function Getid_tax_groupFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_tax_groupColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_tax_group field.
	''' </summary>
	Public Sub Setid_tax_groupFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_tax_groupColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.road_permit_no field.
	''' </summary>
	Public Function Getroad_permit_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.road_permit_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.road_permit_no field.
	''' </summary>
	Public Function Getroad_permit_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.road_permit_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.road_permit_no field.
	''' </summary>
	Public Sub Setroad_permit_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.road_permit_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.road_permit_no field.
	''' </summary>
	Public Sub Setroad_permit_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.road_permit_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.packing_details field.
	''' </summary>
	Public Function Getpacking_detailsValue() As ColumnValue
		Return Me.GetValue(TableUtils.packing_detailsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.packing_details field.
	''' </summary>
	Public Function Getpacking_detailsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.packing_detailsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.packing_details field.
	''' </summary>
	Public Sub Setpacking_detailsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.packing_detailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.packing_details field.
	''' </summary>
	Public Sub Setpacking_detailsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.packing_detailsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.weight field.
	''' </summary>
	Public Function GetweightValue() As ColumnValue
		Return Me.GetValue(TableUtils.weightColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.weight field.
	''' </summary>
	Public Function GetweightFieldValue() As String
		Return CType(Me.GetValue(TableUtils.weightColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.weight field.
	''' </summary>
	Public Sub SetweightFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.weightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.weight field.
	''' </summary>
	Public Sub SetweightFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.weightColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.no_of_packages field.
	''' </summary>
	Public Function Getno_of_packagesValue() As ColumnValue
		Return Me.GetValue(TableUtils.no_of_packagesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.no_of_packages field.
	''' </summary>
	Public Function Getno_of_packagesFieldValue() As String
		Return CType(Me.GetValue(TableUtils.no_of_packagesColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.no_of_packages field.
	''' </summary>
	Public Sub Setno_of_packagesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.no_of_packagesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.no_of_packages field.
	''' </summary>
	Public Sub Setno_of_packagesFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.no_of_packagesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Function Getid_transporterValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_transporterColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Function Getid_transporterFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_transporterColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Sub Setid_transporterFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_transporterColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Sub Setid_transporterFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_transporterColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Sub Setid_transporterFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_transporterColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Sub Setid_transporterFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_transporterColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Sub Setid_transporterFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_transporterColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.gr_rr_no field.
	''' </summary>
	Public Function Getgr_rr_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.gr_rr_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.gr_rr_no field.
	''' </summary>
	Public Function Getgr_rr_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gr_rr_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.gr_rr_no field.
	''' </summary>
	Public Sub Setgr_rr_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gr_rr_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.gr_rr_no field.
	''' </summary>
	Public Sub Setgr_rr_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gr_rr_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.gr_rr_dt field.
	''' </summary>
	Public Function Getgr_rr_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.gr_rr_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.gr_rr_dt field.
	''' </summary>
	Public Function Getgr_rr_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.gr_rr_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.gr_rr_dt field.
	''' </summary>
	Public Sub Setgr_rr_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gr_rr_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.gr_rr_dt field.
	''' </summary>
	Public Sub Setgr_rr_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.gr_rr_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.gr_rr_dt field.
	''' </summary>
	Public Sub Setgr_rr_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gr_rr_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.freight_to_pay field.
	''' </summary>
	Public Function Getfreight_to_payValue() As ColumnValue
		Return Me.GetValue(TableUtils.freight_to_payColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.freight_to_pay field.
	''' </summary>
	Public Function Getfreight_to_payFieldValue() As String
		Return CType(Me.GetValue(TableUtils.freight_to_payColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.freight_to_pay field.
	''' </summary>
	Public Sub Setfreight_to_payFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.freight_to_payColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.freight_to_pay field.
	''' </summary>
	Public Sub Setfreight_to_payFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.freight_to_payColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.vehicle_no field.
	''' </summary>
	Public Function Getvehicle_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.vehicle_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.vehicle_no field.
	''' </summary>
	Public Function Getvehicle_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.vehicle_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.vehicle_no field.
	''' </summary>
	Public Sub Setvehicle_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.vehicle_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.vehicle_no field.
	''' </summary>
	Public Sub Setvehicle_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.vehicle_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Function Getid_create_userValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_create_userColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Function Getid_create_userFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_create_userColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_create_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_create_user field.
	''' </summary>
	Public Sub Setid_create_userFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_create_userColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.created_on field.
	''' </summary>
	Public Function Getcreated_onValue() As ColumnValue
		Return Me.GetValue(TableUtils.created_onColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.created_on field.
	''' </summary>
	Public Function Getcreated_onFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.created_onColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.created_on field.
	''' </summary>
	Public Sub Setcreated_onFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.created_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.created_on field.
	''' </summary>
	Public Sub Setcreated_onFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.created_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.created_on field.
	''' </summary>
	Public Sub Setcreated_onFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.created_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Function Getid_update_userValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_update_userColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Function Getid_update_userFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_update_userColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_update_userColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.id_update_user field.
	''' </summary>
	Public Sub Setid_update_userFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_update_userColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.last_updated field.
	''' </summary>
	Public Function Getlast_updatedValue() As ColumnValue
		Return Me.GetValue(TableUtils.last_updatedColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Inv_hdr_.last_updated field.
	''' </summary>
	Public Function Getlast_updatedFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.last_updatedColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.last_updated field.
	''' </summary>
	Public Sub Setlast_updatedFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.last_updatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.last_updated field.
	''' </summary>
	Public Sub Setlast_updatedFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.last_updatedColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Inv_hdr_.last_updated field.
	''' </summary>
	Public Sub Setlast_updatedFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.last_updatedColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.inv_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.inv_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.pro_inv_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.pro_inv_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.sale_ord_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.sale_ord_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_party field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_site field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.bill_name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.bill_address field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.ship_name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.ship_address field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.tin_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.email field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.additional_email field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.contact field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.phone field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.po_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.po_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_commodity field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_tax_group field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.item_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.grand_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.road_permit_no field.
	''' </summary>
	Public Property road_permit_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.road_permit_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.road_permit_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property road_permit_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.road_permit_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property road_permit_noDefault() As String
        Get
            Return TableUtils.road_permit_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.packing_details field.
	''' </summary>
	Public Property packing_details() As String
		Get 
			Return CType(Me.GetValue(TableUtils.packing_detailsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.packing_detailsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property packing_detailsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.packing_detailsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property packing_detailsDefault() As String
        Get
            Return TableUtils.packing_detailsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.weight field.
	''' </summary>
	Public Property weight() As String
		Get 
			Return CType(Me.GetValue(TableUtils.weightColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.weightColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property weightSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.weightColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property weightDefault() As String
        Get
            Return TableUtils.weightColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.no_of_packages field.
	''' </summary>
	Public Property no_of_packages() As String
		Get 
			Return CType(Me.GetValue(TableUtils.no_of_packagesColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.no_of_packagesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property no_of_packagesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.no_of_packagesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property no_of_packagesDefault() As String
        Get
            Return TableUtils.no_of_packagesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_transporter field.
	''' </summary>
	Public Property id_transporter() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_transporterColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_transporterColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_transporterSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_transporterColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_transporterDefault() As String
        Get
            Return TableUtils.id_transporterColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.gr_rr_no field.
	''' </summary>
	Public Property gr_rr_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.gr_rr_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.gr_rr_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gr_rr_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gr_rr_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gr_rr_noDefault() As String
        Get
            Return TableUtils.gr_rr_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.gr_rr_dt field.
	''' </summary>
	Public Property gr_rr_dt() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.gr_rr_dtColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.gr_rr_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gr_rr_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gr_rr_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gr_rr_dtDefault() As String
        Get
            Return TableUtils.gr_rr_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.freight_to_pay field.
	''' </summary>
	Public Property freight_to_pay() As String
		Get 
			Return CType(Me.GetValue(TableUtils.freight_to_payColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.freight_to_payColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property freight_to_paySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.freight_to_payColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property freight_to_payDefault() As String
        Get
            Return TableUtils.freight_to_payColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.vehicle_no field.
	''' </summary>
	Public Property vehicle_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.vehicle_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.vehicle_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property vehicle_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.vehicle_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property vehicle_noDefault() As String
        Get
            Return TableUtils.vehicle_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_create_user field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.created_on field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.id_update_user field.
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
	''' This is a convenience property that provides direct access to the value of the record's Inv_hdr_.last_updated field.
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
