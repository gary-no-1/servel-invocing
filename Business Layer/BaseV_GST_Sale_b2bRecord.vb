' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_Sale_b2bRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_GST_Sale_b2bRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_GST_Sale_b2bView"></see> class.
''' </remarks>
''' <seealso cref="V_GST_Sale_b2bView"></seealso>
''' <seealso cref="V_GST_Sale_b2bRecord"></seealso>

<Serializable()> Public Class BaseV_GST_Sale_b2bRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_GST_Sale_b2bView = V_GST_Sale_b2bView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr1 field.
	''' </summary>
	Public Function GetExpr1Value() As ColumnValue
		Return Me.GetValue(TableUtils.Expr1Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr1 field.
	''' </summary>
	Public Function GetExpr1FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Expr1Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr1 field.
	''' </summary>
	Public Sub SetExpr1FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Expr1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr1 field.
	''' </summary>
	Public Sub SetExpr1FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Expr1Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr2 field.
	''' </summary>
	Public Function GetExpr2Value() As ColumnValue
		Return Me.GetValue(TableUtils.Expr2Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr2 field.
	''' </summary>
	Public Function GetExpr2FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Expr2Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr2 field.
	''' </summary>
	Public Sub SetExpr2FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Expr2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr2 field.
	''' </summary>
	Public Sub SetExpr2FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Expr2Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr3 field.
	''' </summary>
	Public Function GetExpr3Value() As ColumnValue
		Return Me.GetValue(TableUtils.Expr3Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr3 field.
	''' </summary>
	Public Function GetExpr3FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Expr3Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr3 field.
	''' </summary>
	Public Sub SetExpr3FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Expr3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr3 field.
	''' </summary>
	Public Sub SetExpr3FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Expr3Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr4 field.
	''' </summary>
	Public Function GetExpr4Value() As ColumnValue
		Return Me.GetValue(TableUtils.Expr4Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr4 field.
	''' </summary>
	Public Function GetExpr4FieldValue() As String
		Return CType(Me.GetValue(TableUtils.Expr4Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr4 field.
	''' </summary>
	Public Sub SetExpr4FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.Expr4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.Expr4 field.
	''' </summary>
	Public Sub SetExpr4FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.Expr4Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.reverse_charge field.
	''' </summary>
	Public Function Getreverse_chargeValue() As ColumnValue
		Return Me.GetValue(TableUtils.reverse_chargeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.reverse_charge field.
	''' </summary>
	Public Function Getreverse_chargeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.reverse_chargeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.reverse_charge field.
	''' </summary>
	Public Sub Setreverse_chargeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.reverse_chargeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.reverse_charge field.
	''' </summary>
	Public Sub Setreverse_chargeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.reverse_chargeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.invoice_type field.
	''' </summary>
	Public Function Getinvoice_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.invoice_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.invoice_type field.
	''' </summary>
	Public Function Getinvoice_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.invoice_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.invoice_type field.
	''' </summary>
	Public Sub Setinvoice_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.invoice_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.invoice_type field.
	''' </summary>
	Public Sub Setinvoice_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.invoice_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.e_comm field.
	''' </summary>
	Public Function Gete_commValue() As ColumnValue
		Return Me.GetValue(TableUtils.e_commColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.e_comm field.
	''' </summary>
	Public Function Gete_commFieldValue() As String
		Return CType(Me.GetValue(TableUtils.e_commColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.e_comm field.
	''' </summary>
	Public Sub Sete_commFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.e_commColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.e_comm field.
	''' </summary>
	Public Sub Sete_commFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.e_commColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateValue() As ColumnValue
		Return Me.GetValue(TableUtils.tax_rateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Function Gettax_rateFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.tax_rateColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.tax_rate field.
	''' </summary>
	Public Sub Settax_rateFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tax_rateColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Function GetcessValue() As ColumnValue
		Return Me.GetValue(TableUtils.cessColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Function GetcessFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.cessColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_GST_Sale_b2b_.cess field.
	''' </summary>
	Public Sub SetcessFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cessColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr1 field.
	''' </summary>
	Public Property Expr1() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Expr1Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Expr1Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Expr1Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Expr1Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Expr1Default() As String
        Get
            Return TableUtils.Expr1Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr2 field.
	''' </summary>
	Public Property Expr2() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Expr2Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Expr2Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Expr2Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Expr2Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Expr2Default() As String
        Get
            Return TableUtils.Expr2Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr3 field.
	''' </summary>
	Public Property Expr3() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Expr3Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Expr3Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Expr3Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Expr3Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Expr3Default() As String
        Get
            Return TableUtils.Expr3Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.grand_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.Expr4 field.
	''' </summary>
	Public Property Expr4() As String
		Get 
			Return CType(Me.GetValue(TableUtils.Expr4Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.Expr4Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property Expr4Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.Expr4Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property Expr4Default() As String
        Get
            Return TableUtils.Expr4Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.reverse_charge field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.invoice_type field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.e_comm field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.tax_rate field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.item_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_GST_Sale_b2b_.cess field.
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
