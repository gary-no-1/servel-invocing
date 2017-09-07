' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_InvoicesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_GST_InvoicesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GST_InvoicesView"></see> class.
''' </remarks>
''' <seealso cref="V_GST_InvoicesView"></seealso>
''' <seealso cref="V_GST_InvoicesRecord"></seealso>

<Serializable()> Public Class BaseV_GST_InvoicesRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_GST_InvoicesView = V_GST_InvoicesView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.site_gst_no field.
	''' </summary>
	Public Function Getsite_gst_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.site_gst_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.site_gst_no field.
	''' </summary>
	Public Function Getsite_gst_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.site_gst_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.site_gst_no field.
	''' </summary>
	Public Sub Setsite_gst_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.site_gst_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.site_gst_no field.
	''' </summary>
	Public Sub Setsite_gst_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.site_gst_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.inv_no field.
	''' </summary>
	Public Function Getinv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.inv_no field.
	''' </summary>
	Public Function Getinv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.gst_inv_dt field.
	''' </summary>
	Public Function Getgst_inv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.gst_inv_dt field.
	''' </summary>
	Public Function Getgst_inv_dtFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gst_inv_dtColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.gst_inv_dt field.
	''' </summary>
	Public Sub Setgst_inv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.gst_inv_dt field.
	''' </summary>
	Public Sub Setgst_inv_dtFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.gst_state field.
	''' </summary>
	Public Function Getgst_stateValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_stateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.gst_state field.
	''' </summary>
	Public Function Getgst_stateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gst_stateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.gst_state field.
	''' </summary>
	Public Sub Setgst_stateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_stateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.gst_state field.
	''' </summary>
	Public Sub Setgst_stateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_stateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.reverse_charge field.
	''' </summary>
	Public Function Getreverse_chargeValue() As ColumnValue
		Return Me.GetValue(TableUtils.reverse_chargeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.reverse_charge field.
	''' </summary>
	Public Function Getreverse_chargeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.reverse_chargeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.reverse_charge field.
	''' </summary>
	Public Sub Setreverse_chargeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.reverse_chargeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.reverse_charge field.
	''' </summary>
	Public Sub Setreverse_chargeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.reverse_chargeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.invoice_type field.
	''' </summary>
	Public Function Getinvoice_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.invoice_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.invoice_type field.
	''' </summary>
	Public Function Getinvoice_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.invoice_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.invoice_type field.
	''' </summary>
	Public Sub Setinvoice_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.invoice_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.invoice_type field.
	''' </summary>
	Public Sub Setinvoice_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.invoice_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.e_comm field.
	''' </summary>
	Public Function Gete_commValue() As ColumnValue
		Return Me.GetValue(TableUtils.e_commColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.e_comm field.
	''' </summary>
	Public Function Gete_commFieldValue() As String
		Return CType(Me.GetValue(TableUtils.e_commColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.e_comm field.
	''' </summary>
	Public Sub Sete_commFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.e_commColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.e_comm field.
	''' </summary>
	Public Sub Sete_commFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.e_commColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Function GetigstValue() As ColumnValue
		Return Me.GetValue(TableUtils.igstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Function GetigstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.igstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Function GetcgstValue() As ColumnValue
		Return Me.GetValue(TableUtils.cgstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Function GetcgstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.cgstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Function GetsgstValue() As ColumnValue
		Return Me.GetValue(TableUtils.sgstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Function GetsgstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.sgstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Function GetcessValue() As ColumnValue
		Return Me.GetValue(TableUtils.cessColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Function GetcessFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.cessColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.site_gst_no field.
	''' </summary>
	Public Property site_gst_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.site_gst_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.site_gst_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property site_gst_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.site_gst_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property site_gst_noDefault() As String
        Get
            Return TableUtils.site_gst_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.inv_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.inv_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.gst_inv_dt field.
	''' </summary>
	Public Property gst_inv_dt() As String
		Get 
			Return CType(Me.GetValue(TableUtils.gst_inv_dtColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.gst_inv_dtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gst_inv_dtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gst_inv_dtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gst_inv_dtDefault() As String
        Get
            Return TableUtils.gst_inv_dtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.grand_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.gst_state field.
	''' </summary>
	Public Property gst_state() As String
		Get 
			Return CType(Me.GetValue(TableUtils.gst_stateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.gst_stateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property gst_stateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.gst_stateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property gst_stateDefault() As String
        Get
            Return TableUtils.gst_stateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.reverse_charge field.
	''' </summary>
	Public Property reverse_charge() As String
		Get 
			Return CType(Me.GetValue(TableUtils.reverse_chargeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.reverse_chargeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property reverse_chargeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.reverse_chargeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property reverse_chargeDefault() As String
        Get
            Return TableUtils.reverse_chargeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.invoice_type field.
	''' </summary>
	Public Property invoice_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.invoice_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.invoice_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property invoice_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.invoice_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property invoice_typeDefault() As String
        Get
            Return TableUtils.invoice_typeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.e_comm field.
	''' </summary>
	Public Property e_comm() As String
		Get 
			Return CType(Me.GetValue(TableUtils.e_commColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.e_commColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property e_commSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.e_commColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property e_commDefault() As String
        Get
            Return TableUtils.e_commColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.tax_rate field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.item_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.igst field.
	''' </summary>
	Public Property igst() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.igstColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.igstColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property igstSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.igstColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property igstDefault() As String
        Get
            Return TableUtils.igstColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.cgst field.
	''' </summary>
	Public Property cgst() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.cgstColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.cgstColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property cgstSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.cgstColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property cgstDefault() As String
        Get
            Return TableUtils.cgstColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.sgst field.
	''' </summary>
	Public Property sgst() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.sgstColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.sgstColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sgstSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sgstColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sgstDefault() As String
        Get
            Return TableUtils.sgstColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Invoices_.cess field.
	''' </summary>
	Public Property cess() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.cessColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.cessColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property cessSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.cessColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property cessDefault() As String
        Get
            Return TableUtils.cessColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
