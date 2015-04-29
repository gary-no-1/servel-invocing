' This class is "generated" and will be overwritten.
' Your customizations should be made in V_Invoice_AmountsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_Invoice_AmountsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="V_Invoice_AmountsView"></see> class.
''' </remarks>
''' <seealso cref="V_Invoice_AmountsView"></seealso>
''' <seealso cref="V_Invoice_AmountsRecord"></seealso>

<Serializable()> Public Class BaseV_Invoice_AmountsRecord
	Inherits KeylessRecord
	

	Public Shared Shadows ReadOnly TableUtils As V_Invoice_AmountsView = V_Invoice_AmountsView.Instance

	' Constructors

	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As KeylessRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id field.
	''' </summary>
	Public Sub Setid0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.inv_no field.
	''' </summary>
	Public Function Getinv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.inv_no field.
	''' </summary>
	Public Function Getinv_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.inv_no field.
	''' </summary>
	Public Sub Setinv_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_dtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.inv_dt field.
	''' </summary>
	Public Function Getinv_dtFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.inv_dtColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.inv_dt field.
	''' </summary>
	Public Sub Setinv_dtFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_dtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Function Getid_partyValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_partyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Function Getid_partyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_partyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Function Getitem_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Function Getitem_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.item_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.item_total field.
	''' </summary>
	Public Sub Setitem_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Function Getexcise_amtValue() As ColumnValue
		Return Me.GetValue(TableUtils.excise_amtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Function Getexcise_amtFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.excise_amtColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Sub Setexcise_amtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.excise_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Sub Setexcise_amtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.excise_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Sub Setexcise_amtFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Sub Setexcise_amtFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Sub Setexcise_amtFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.excise_amtColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Function Getvat_amtValue() As ColumnValue
		Return Me.GetValue(TableUtils.vat_amtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Function Getvat_amtFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.vat_amtColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Sub Setvat_amtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.vat_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Sub Setvat_amtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.vat_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Sub Setvat_amtFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.vat_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Sub Setvat_amtFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.vat_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Sub Setvat_amtFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.vat_amtColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Function Getcst_amtValue() As ColumnValue
		Return Me.GetValue(TableUtils.cst_amtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Function Getcst_amtFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.cst_amtColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Sub Setcst_amtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cst_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Sub Setcst_amtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.cst_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Sub Setcst_amtFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cst_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Sub Setcst_amtFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cst_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Sub Setcst_amtFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cst_amtColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Function Getsrv_taxValue() As ColumnValue
		Return Me.GetValue(TableUtils.srv_taxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Function Getsrv_taxFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.srv_taxColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Sub Setsrv_taxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.srv_taxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Sub Setsrv_taxFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.srv_taxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Sub Setsrv_taxFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.srv_taxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Sub Setsrv_taxFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.srv_taxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Sub Setsrv_taxFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.srv_taxColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Function Getoth_amtValue() As ColumnValue
		Return Me.GetValue(TableUtils.oth_amtColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Function Getoth_amtFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.oth_amtColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Sub Setoth_amtFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.oth_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Sub Setoth_amtFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.oth_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Sub Setoth_amtFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.oth_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Sub Setoth_amtFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.oth_amtColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Sub Setoth_amtFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.oth_amtColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalValue() As ColumnValue
		Return Me.GetValue(TableUtils.grand_totalColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Function Getgrand_totalFieldValue() As Decimal
		Return CType(Me.GetValue(TableUtils.grand_totalColumn).ToDecimal(), Decimal)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.grand_total field.
	''' </summary>
	Public Sub Setgrand_totalFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.grand_totalColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.name field.
	''' </summary>
	Public Function GetnameValue() As ColumnValue
		Return Me.GetValue(TableUtils.nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's V_Invoice_Amounts_.name field.
	''' </summary>
	Public Function GetnameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's V_Invoice_Amounts_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.nameColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.inv_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.inv_dt field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.id_party field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.item_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.excise_amt field.
	''' </summary>
	Public Property excise_amt() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.excise_amtColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.excise_amtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property excise_amtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.excise_amtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property excise_amtDefault() As String
        Get
            Return TableUtils.excise_amtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.vat_amt field.
	''' </summary>
	Public Property vat_amt() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.vat_amtColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.vat_amtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property vat_amtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.vat_amtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property vat_amtDefault() As String
        Get
            Return TableUtils.vat_amtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.cst_amt field.
	''' </summary>
	Public Property cst_amt() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.cst_amtColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.cst_amtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property cst_amtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.cst_amtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property cst_amtDefault() As String
        Get
            Return TableUtils.cst_amtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.srv_tax field.
	''' </summary>
	Public Property srv_tax() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.srv_taxColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.srv_taxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property srv_taxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.srv_taxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property srv_taxDefault() As String
        Get
            Return TableUtils.srv_taxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.oth_amt field.
	''' </summary>
	Public Property oth_amt() As Decimal
		Get 
			Return CType(Me.GetValue(TableUtils.oth_amtColumn).ToDecimal(), Decimal)
		End Get
		Set (ByVal val As Decimal) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.oth_amtColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property oth_amtSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.oth_amtColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property oth_amtDefault() As String
        Get
            Return TableUtils.oth_amtColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.grand_total field.
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
	''' This is a convenience property that provides direct access to the value of the record's V_Invoice_Amounts_.name field.
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



#End Region

End Class
End Namespace
