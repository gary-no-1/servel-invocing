﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in So_taxesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="So_taxesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="So_taxesTable"></see> class.
''' </remarks>
''' <seealso cref="So_taxesTable"></seealso>
''' <seealso cref="So_taxesRecord"></seealso>

<Serializable()> Public Class BaseSo_taxesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As So_taxesTable = So_taxesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Function Getid_so_hdrValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_so_hdrColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Function Getid_so_hdrFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_so_hdrColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_so_hdr field.
	''' </summary>
	Public Sub Setid_so_hdrFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_so_hdrColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Function Getid_taxesValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_taxesColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Function Getid_taxesFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_taxesColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxesColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Sub Setid_taxesFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_taxesColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_code field.
	''' </summary>
	Public Function Gettax_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_code field.
	''' </summary>
	Public Function Gettax_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_code field.
	''' </summary>
	Public Sub Settax_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_code field.
	''' </summary>
	Public Sub Settax_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_name field.
	''' </summary>
	Public Function Gettax_nameValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_name field.
	''' </summary>
	Public Function Gettax_nameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_name field.
	''' </summary>
	Public Sub Settax_nameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_name field.
	''' </summary>
	Public Sub Settax_nameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_print field.
	''' </summary>
	Public Function Gettax_printValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_printColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_print field.
	''' </summary>
	Public Function Gettax_printFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_printColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_print field.
	''' </summary>
	Public Sub Settax_printFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_printColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_print field.
	''' </summary>
	Public Sub Settax_printFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_printColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Function Gettax_onValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_onColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Function Gettax_onFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_onColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Sub Settax_onFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Sub Settax_onFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Sub Settax_onFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Sub Settax_onFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_onColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Sub Settax_onFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_onColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Function Gettax_amountValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_amountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Function Gettax_amountFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_amountColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Sub Settax_amountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Sub Settax_amountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Sub Settax_amountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Sub Settax_amountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Sub Settax_amountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_amountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_lock field.
	''' </summary>
	Public Function Gettax_lockValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_lockColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_lock field.
	''' </summary>
	Public Function Gettax_lockFieldValue() As Boolean
		Return CType(Me.GetValue(TableUtils.tax_lockColumn).ToBoolean(), Boolean)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_lock field.
	''' </summary>
	Public Sub Settax_lockFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_lockColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_lock field.
	''' </summary>
	Public Sub Settax_lockFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_lockColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_lock field.
	''' </summary>
	Public Sub Settax_lockFieldValue(ByVal val As Boolean)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_lockColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.calc_type field.
	''' </summary>
	Public Function Getcalc_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.calc_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.calc_type field.
	''' </summary>
	Public Function Getcalc_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.calc_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.calc_type field.
	''' </summary>
	Public Sub Setcalc_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.calc_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.calc_type field.
	''' </summary>
	Public Sub Setcalc_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.calc_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Function Getsort_orderValue() As ColumnValue
		Return Me.GetValue(TableUtils.sort_orderColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Function Getsort_orderFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.sort_orderColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.sort_order field.
	''' </summary>
	Public Sub Setsort_orderFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sort_orderColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_type field.
	''' </summary>
	Public Function Gettax_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.tax_type field.
	''' </summary>
	Public Function Gettax_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tax_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_type field.
	''' </summary>
	Public Sub Settax_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.tax_type field.
	''' </summary>
	Public Sub Settax_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Function Getexcise_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.excise_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Function Getexcise_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.excise_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Sub Setexcise_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.excise_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Sub Setexcise_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.excise_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Sub Setexcise_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Sub Setexcise_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Sub Setexcise_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's So_taxes_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.id_so_hdr field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.id_taxes field.
	''' </summary>
	Public Property id_taxes() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.id_taxesColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.id_taxesColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property id_taxesSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.id_taxesColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property id_taxesDefault() As String
        Get
            Return TableUtils.id_taxesColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_code field.
	''' </summary>
	Public Property tax_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_codeDefault() As String
        Get
            Return TableUtils.tax_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_name field.
	''' </summary>
	Public Property tax_name() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_nameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_nameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_nameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_nameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_nameDefault() As String
        Get
            Return TableUtils.tax_nameColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_print field.
	''' </summary>
	Public Property tax_print() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_printColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_printColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_printSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_printColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_printDefault() As String
        Get
            Return TableUtils.tax_printColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_rate field.
	''' </summary>
	Public Property tax_rate() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.tax_rateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_rateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_rateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_rateDefault() As String
        Get
            Return TableUtils.tax_rateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_on field.
	''' </summary>
	Public Property tax_on() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.tax_onColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.tax_onColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_onSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_onColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_onDefault() As String
        Get
            Return TableUtils.tax_onColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_amount field.
	''' </summary>
	Public Property tax_amount() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.tax_amountColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.tax_amountColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_amountSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_amountColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_amountDefault() As String
        Get
            Return TableUtils.tax_amountColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_lock field.
	''' </summary>
	Public Property tax_lock() As Boolean
		Get 
			Return CType(Me.GetValue(TableUtils.tax_lockColumn).ToBoolean(), Boolean)
		End Get
		Set (ByVal val As Boolean) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.tax_lockColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_lockSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_lockColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_lockDefault() As String
        Get
            Return TableUtils.tax_lockColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.calc_type field.
	''' </summary>
	Public Property calc_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.calc_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.calc_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property calc_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.calc_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property calc_typeDefault() As String
        Get
            Return TableUtils.calc_typeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.sort_order field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.tax_type field.
	''' </summary>
	Public Property tax_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tax_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tax_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tax_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tax_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tax_typeDefault() As String
        Get
            Return TableUtils.tax_typeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.item_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.excise_total field.
	''' </summary>
	Public Property excise_total() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.excise_totalColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.excise_totalColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property excise_totalSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.excise_totalColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property excise_totalDefault() As String
        Get
            Return TableUtils.excise_totalColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's So_taxes_.grand_total field.
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
