' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_invoice_hsn_taxRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_GST_invoice_hsn_taxRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GST_invoice_hsn_taxView"></see> class.
''' </remarks>
''' <seealso cref="V_GST_invoice_hsn_taxView"></seealso>
''' <seealso cref="V_GST_invoice_hsn_taxRecord"></seealso>

<Serializable()> Public Class BaseV_GST_invoice_hsn_taxRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_GST_invoice_hsn_taxView = V_GST_invoice_hsn_taxView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.inv_no field.
	''' </summary>
	Public Function Getinv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.inv_no field.
	''' </summary>
	Public Function Getinv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.item_code field.
	''' </summary>
	Public Function Getitem_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.item_code field.
	''' </summary>
	Public Function Getitem_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.item_code field.
	''' </summary>
	Public Sub Setitem_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.uom field.
	''' </summary>
	Public Function GetuomValue() As ColumnValue
		Return Me.GetValue(TableUtils.uomColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.uom field.
	''' </summary>
	Public Function GetuomFieldValue() As String
		Return CType(Me.GetValue(TableUtils.uomColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.uom field.
	''' </summary>
	Public Sub SetuomFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.uomColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Function GetqtyValue() As ColumnValue
		Return Me.GetValue(TableUtils.qtyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Function GetqtyFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.qtyColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.qty field.
	''' </summary>
	Public Sub SetqtyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.qtyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Function GetamountValue() As ColumnValue
		Return Me.GetValue(TableUtils.amountColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Function GetamountFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.amountColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.amount field.
	''' </summary>
	Public Sub SetamountFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.amountColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.hsn field.
	''' </summary>
	Public Function GethsnValue() As ColumnValue
		Return Me.GetValue(TableUtils.hsnColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.hsn field.
	''' </summary>
	Public Function GethsnFieldValue() As String
		Return CType(Me.GetValue(TableUtils.hsnColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.hsn field.
	''' </summary>
	Public Sub SethsnFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.hsnColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Function GetigstValue() As ColumnValue
		Return Me.GetValue(TableUtils.igstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Function GetigstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.igstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.igst field.
	''' </summary>
	Public Sub SetigstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.igstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Function GetcgstValue() As ColumnValue
		Return Me.GetValue(TableUtils.cgstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Function GetcgstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.cgstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.cgst field.
	''' </summary>
	Public Sub SetcgstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cgstColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Function GetsgstValue() As ColumnValue
		Return Me.GetValue(TableUtils.sgstColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Function GetsgstFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.sgstColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_invoice_hsn_tax_.sgst field.
	''' </summary>
	Public Sub SetsgstFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sgstColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.inv_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.inv_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.item_code field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.uom field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.qty field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.amount field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.hsn field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.igst field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.cgst field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_invoice_hsn_tax_.sgst field.
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



#End Region

End Class
End Namespace
