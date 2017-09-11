' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_hsn_summaryRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_GST_hsn_summaryRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GST_hsn_summaryView"></see> class.
''' </remarks>
''' <seealso cref="V_GST_hsn_summaryView"></seealso>
''' <seealso cref="V_GST_hsn_summaryRecord"></seealso>

<Serializable()> Public Class BaseV_GST_hsn_summaryRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_GST_hsn_summaryView = V_GST_hsn_summaryView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.month_start field.
	''' </summary>
	Public Function Getmonth_startValue() As ColumnValue
		Return Me.GetValue(TableUtils.month_startColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.month_start field.
	''' </summary>
	Public Function Getmonth_startFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.month_startColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.month_start field.
	''' </summary>
	Public Sub Setmonth_startFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.month_startColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.month_start field.
	''' </summary>
	Public Sub Setmonth_startFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.month_startColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.month_start field.
	''' </summary>
	Public Sub Setmonth_startFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.month_startColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.month_year field.
	''' </summary>
	Public Function Getmonth_yearValue() As ColumnValue
		Return Me.GetValue(TableUtils.month_yearColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.month_year field.
	''' </summary>
	Public Function Getmonth_yearFieldValue() As String
		Return CType(Me.GetValue(TableUtils.month_yearColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.month_year field.
	''' </summary>
	Public Sub Setmonth_yearFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.month_yearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.month_year field.
	''' </summary>
	Public Sub Setmonth_yearFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.month_yearColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.hsn field.
	''' </summary>
	Public Function GethsnValue() As ColumnValue
		Return Me.GetValue(TableUtils.hsnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.hsn field.
	''' </summary>
	Public Function GethsnFieldValue() As String
		Return CType(Me.GetValue(TableUtils.hsnColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.gst_description field.
	''' </summary>
	Public Function Getgst_descriptionValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_descriptionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.gst_description field.
	''' </summary>
	Public Function Getgst_descriptionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gst_descriptionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.gst_description field.
	''' </summary>
	Public Sub Setgst_descriptionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.gst_description field.
	''' </summary>
	Public Sub Setgst_descriptionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_descriptionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.gst_uom field.
	''' </summary>
	Public Function Getgst_uomValue() As ColumnValue
		Return Me.GetValue(TableUtils.gst_uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.gst_uom field.
	''' </summary>
	Public Function Getgst_uomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.gst_uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.gst_uom field.
	''' </summary>
	Public Sub Setgst_uomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.gst_uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.gst_uom field.
	''' </summary>
	Public Sub Setgst_uomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.gst_uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Function GetqtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.qtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Function GetqtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.qtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Function Gettotal_amtValue() As ColumnValue
		Return Me.GetValue(TableUtils.total_amtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Function Gettotal_amtFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.total_amtColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Sub Settotal_amtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.total_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Sub Settotal_amtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.total_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Sub Settotal_amtFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.total_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Sub Settotal_amtFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.total_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Sub Settotal_amtFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.total_amtColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Function Gettaxable_amtValue() As ColumnValue
		Return Me.GetValue(TableUtils.taxable_amtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Function Gettaxable_amtFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.taxable_amtColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Sub Settaxable_amtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.taxable_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Sub Settaxable_amtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.taxable_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Sub Settaxable_amtFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.taxable_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Sub Settaxable_amtFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.taxable_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Sub Settaxable_amtFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.taxable_amtColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Function GetigstValue() As ColumnValue
		Return Me.GetValue(TableUtils.igstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Function GetigstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.igstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Function GetcgstValue() As ColumnValue
		Return Me.GetValue(TableUtils.cgstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Function GetcgstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.cgstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Function GetsgstValue() As ColumnValue
		Return Me.GetValue(TableUtils.sgstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Function GetsgstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.sgstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Function GetcessValue() As ColumnValue
		Return Me.GetValue(TableUtils.cessColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Function GetcessFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.cessColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_hsn_summary_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.month_start field.
	''' </summary>
	Public Property month_start() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.month_startColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.month_startColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property month_startSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.month_startColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property month_startDefault() As String
        Get
            Return TableUtils.month_startColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.month_year field.
	''' </summary>
	Public Property month_year() As String
		Get 
			Return CType(Me.GetValue(TableUtils.month_yearColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.month_yearColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property month_yearSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.month_yearColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property month_yearDefault() As String
        Get
            Return TableUtils.month_yearColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.hsn field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.gst_description field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.gst_uom field.
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

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.qty field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.total_amt field.
	''' </summary>
	Public Property total_amt() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.total_amtColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.total_amtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property total_amtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.total_amtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property total_amtDefault() As String
        Get
            Return TableUtils.total_amtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.taxable_amt field.
	''' </summary>
	Public Property taxable_amt() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.taxable_amtColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.taxable_amtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property taxable_amtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.taxable_amtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property taxable_amtDefault() As String
        Get
            Return TableUtils.taxable_amtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.igst field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.cgst field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.sgst field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_hsn_summary_.cess field.
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
