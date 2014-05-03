' This class is "generated" and will be overwritten.
' Your customizations should be made in CompanyRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="CompanyRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="CompanyTable"></see> class.
''' </remarks>
''' <seealso cref="CompanyTable"></seealso>
''' <seealso cref="CompanyRecord"></seealso>

<Serializable()> Public Class BaseCompanyRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As CompanyTable = CompanyTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.name field.
	''' </summary>
	Public Function GetnameValue() As ColumnValue
		Return Me.GetValue(TableUtils.nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.name field.
	''' </summary>
	Public Function GetnameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.address field.
	''' </summary>
	Public Function GetaddressValue() As ColumnValue
		Return Me.GetValue(TableUtils.addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.address field.
	''' </summary>
	Public Function GetaddressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.address field.
	''' </summary>
	Public Sub SetaddressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.address field.
	''' </summary>
	Public Sub SetaddressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.city field.
	''' </summary>
	Public Function GetcityValue() As ColumnValue
		Return Me.GetValue(TableUtils.cityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.city field.
	''' </summary>
	Public Function GetcityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.cityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.city field.
	''' </summary>
	Public Sub SetcityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.city field.
	''' </summary>
	Public Sub SetcityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.pincode field.
	''' </summary>
	Public Function GetpincodeValue() As ColumnValue
		Return Me.GetValue(TableUtils.pincodeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.pincode field.
	''' </summary>
	Public Function GetpincodeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.pincodeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pincode field.
	''' </summary>
	Public Sub SetpincodeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pincodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pincode field.
	''' </summary>
	Public Sub SetpincodeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pincodeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.state field.
	''' </summary>
	Public Function GetstateValue() As ColumnValue
		Return Me.GetValue(TableUtils.stateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.state field.
	''' </summary>
	Public Function GetstateFieldValue() As String
		Return CType(Me.GetValue(TableUtils.stateColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.state field.
	''' </summary>
	Public Sub SetstateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.stateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.state field.
	''' </summary>
	Public Sub SetstateFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.stateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.phone field.
	''' </summary>
	Public Function GetphoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.phoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.phone field.
	''' </summary>
	Public Function GetphoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.phoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.email field.
	''' </summary>
	Public Function GetemailValue() As ColumnValue
		Return Me.GetValue(TableUtils.emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.email field.
	''' </summary>
	Public Function GetemailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.pan_no field.
	''' </summary>
	Public Function Getpan_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.pan_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.pan_no field.
	''' </summary>
	Public Function Getpan_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.pan_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pan_no field.
	''' </summary>
	Public Sub Setpan_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pan_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pan_no field.
	''' </summary>
	Public Sub Setpan_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pan_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.tin_no field.
	''' </summary>
	Public Function Gettin_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tin_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.tin_no field.
	''' </summary>
	Public Function Gettin_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tin_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.eac field.
	''' </summary>
	Public Function GeteacValue() As ColumnValue
		Return Me.GetValue(TableUtils.eacColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.eac field.
	''' </summary>
	Public Function GeteacFieldValue() As String
		Return CType(Me.GetValue(TableUtils.eacColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.eac field.
	''' </summary>
	Public Sub SeteacFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.eacColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.eac field.
	''' </summary>
	Public Sub SeteacFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.eacColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.range field.
	''' </summary>
	Public Function GetrangeValue() As ColumnValue
		Return Me.GetValue(TableUtils.rangeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.range field.
	''' </summary>
	Public Function GetrangeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.rangeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.range field.
	''' </summary>
	Public Sub SetrangeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.rangeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.range field.
	''' </summary>
	Public Sub SetrangeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.rangeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.division field.
	''' </summary>
	Public Function GetdivisionValue() As ColumnValue
		Return Me.GetValue(TableUtils.divisionColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.division field.
	''' </summary>
	Public Function GetdivisionFieldValue() As String
		Return CType(Me.GetValue(TableUtils.divisionColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.division field.
	''' </summary>
	Public Sub SetdivisionFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.divisionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.division field.
	''' </summary>
	Public Sub SetdivisionFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.divisionColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.ecc_no field.
	''' </summary>
	Public Function Getecc_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.ecc_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.ecc_no field.
	''' </summary>
	Public Function Getecc_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ecc_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ecc_no field.
	''' </summary>
	Public Sub Setecc_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ecc_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.ecc_no field.
	''' </summary>
	Public Sub Setecc_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ecc_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.cer_no field.
	''' </summary>
	Public Function Getcer_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.cer_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.cer_no field.
	''' </summary>
	Public Function Getcer_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.cer_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.cer_no field.
	''' </summary>
	Public Sub Setcer_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cer_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.cer_no field.
	''' </summary>
	Public Sub Setcer_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cer_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.cer_code field.
	''' </summary>
	Public Function Getcer_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.cer_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.cer_code field.
	''' </summary>
	Public Function Getcer_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.cer_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.cer_code field.
	''' </summary>
	Public Sub Setcer_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cer_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.cer_code field.
	''' </summary>
	Public Sub Setcer_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cer_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.sign field.
	''' </summary>
	Public Function GetsignValue() As ColumnValue
		Return Me.GetValue(TableUtils.signColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.sign field.
	''' </summary>
	Public Function GetsignFieldValue() As String
		Return CType(Me.GetValue(TableUtils.signColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.sign field.
	''' </summary>
	Public Sub SetsignFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.signColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.sign field.
	''' </summary>
	Public Sub SetsignFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.signColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.goods field.
	''' </summary>
	Public Function GetgoodsValue() As ColumnValue
		Return Me.GetValue(TableUtils.goodsColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.goods field.
	''' </summary>
	Public Function GetgoodsFieldValue() As String
		Return CType(Me.GetValue(TableUtils.goodsColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.goods field.
	''' </summary>
	Public Sub SetgoodsFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.goodsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.goods field.
	''' </summary>
	Public Sub SetgoodsFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.goodsColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.duty field.
	''' </summary>
	Public Function GetdutyValue() As ColumnValue
		Return Me.GetValue(TableUtils.dutyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.duty field.
	''' </summary>
	Public Function GetdutyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.dutyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.duty field.
	''' </summary>
	Public Sub SetdutyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.dutyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.duty field.
	''' </summary>
	Public Sub SetdutyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.dutyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.license field.
	''' </summary>
	Public Function GetlicenseValue() As ColumnValue
		Return Me.GetValue(TableUtils.licenseColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.license field.
	''' </summary>
	Public Function GetlicenseFieldValue() As String
		Return CType(Me.GetValue(TableUtils.licenseColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.license field.
	''' </summary>
	Public Sub SetlicenseFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.licenseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.license field.
	''' </summary>
	Public Sub SetlicenseFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.licenseColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.fin_year_start field.
	''' </summary>
	Public Function Getfin_year_startValue() As ColumnValue
		Return Me.GetValue(TableUtils.fin_year_startColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.fin_year_start field.
	''' </summary>
	Public Function Getfin_year_startFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.fin_year_startColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.fin_year_start field.
	''' </summary>
	Public Sub Setfin_year_startFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.fin_year_startColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.fin_year_start field.
	''' </summary>
	Public Sub Setfin_year_startFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.fin_year_startColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.fin_year_start field.
	''' </summary>
	Public Sub Setfin_year_startFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.fin_year_startColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.fin_year_end field.
	''' </summary>
	Public Function Getfin_year_endValue() As ColumnValue
		Return Me.GetValue(TableUtils.fin_year_endColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.fin_year_end field.
	''' </summary>
	Public Function Getfin_year_endFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.fin_year_endColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.fin_year_end field.
	''' </summary>
	Public Sub Setfin_year_endFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.fin_year_endColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.fin_year_end field.
	''' </summary>
	Public Sub Setfin_year_endFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.fin_year_endColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.fin_year_end field.
	''' </summary>
	Public Sub Setfin_year_endFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.fin_year_endColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_pfx field.
	''' </summary>
	Public Function Getinv_pfxValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_pfxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_pfx field.
	''' </summary>
	Public Function Getinv_pfxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_pfxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_pfx field.
	''' </summary>
	Public Sub Setinv_pfxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_pfxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_pfx field.
	''' </summary>
	Public Sub Setinv_pfxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_pfxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_sfx field.
	''' </summary>
	Public Function Getinv_sfxValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_sfxColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_sfx field.
	''' </summary>
	Public Function Getinv_sfxFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_sfxColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_sfx field.
	''' </summary>
	Public Sub Setinv_sfxFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_sfxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_sfx field.
	''' </summary>
	Public Sub Setinv_sfxFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_sfxColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Function Getnext_inv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.next_inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Function Getnext_inv_noFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.next_inv_noColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Sub Setnext_inv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.next_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Sub Setnext_inv_noFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.next_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Sub Setnext_inv_noFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.next_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Sub Setnext_inv_noFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.next_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Sub Setnext_inv_noFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.next_inv_noColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Function Getpad_inv_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.pad_inv_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Function Getpad_inv_noFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.pad_inv_noColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Sub Setpad_inv_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pad_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Sub Setpad_inv_noFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.pad_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Sub Setpad_inv_noFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pad_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Sub Setpad_inv_noFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pad_inv_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Sub Setpad_inv_noFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pad_inv_noColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_declaration field.
	''' </summary>
	Public Function Getinv_declarationValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_declarationColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_declaration field.
	''' </summary>
	Public Function Getinv_declarationFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_declarationColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_declaration field.
	''' </summary>
	Public Sub Setinv_declarationFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_declarationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_declaration field.
	''' </summary>
	Public Sub Setinv_declarationFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_declarationColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.email_from field.
	''' </summary>
	Public Function Getemail_fromValue() As ColumnValue
		Return Me.GetValue(TableUtils.email_fromColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.email_from field.
	''' </summary>
	Public Function Getemail_fromFieldValue() As String
		Return CType(Me.GetValue(TableUtils.email_fromColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.email_from field.
	''' </summary>
	Public Sub Setemail_fromFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.email_fromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.email_from field.
	''' </summary>
	Public Sub Setemail_fromFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.email_fromColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.email_bcc field.
	''' </summary>
	Public Function Getemail_bccValue() As ColumnValue
		Return Me.GetValue(TableUtils.email_bccColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.email_bcc field.
	''' </summary>
	Public Function Getemail_bccFieldValue() As String
		Return CType(Me.GetValue(TableUtils.email_bccColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.email_bcc field.
	''' </summary>
	Public Sub Setemail_bccFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.email_bccColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.email_bcc field.
	''' </summary>
	Public Sub Setemail_bccFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.email_bccColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_email_body field.
	''' </summary>
	Public Function Getinv_email_bodyValue() As ColumnValue
		Return Me.GetValue(TableUtils.inv_email_bodyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Company_.inv_email_body field.
	''' </summary>
	Public Function Getinv_email_bodyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.inv_email_bodyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_email_body field.
	''' </summary>
	Public Sub Setinv_email_bodyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.inv_email_bodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Company_.inv_email_body field.
	''' </summary>
	Public Sub Setinv_email_bodyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.inv_email_bodyColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.address field.
	''' </summary>
	Public Property address() As String
		Get 
			Return CType(Me.GetValue(TableUtils.addressColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.addressColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property addressSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.addressColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property addressDefault() As String
        Get
            Return TableUtils.addressColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.city field.
	''' </summary>
	Public Property city() As String
		Get 
			Return CType(Me.GetValue(TableUtils.cityColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.cityColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property citySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.cityColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property cityDefault() As String
        Get
            Return TableUtils.cityColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.pincode field.
	''' </summary>
	Public Property pincode() As String
		Get 
			Return CType(Me.GetValue(TableUtils.pincodeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.pincodeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property pincodeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.pincodeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property pincodeDefault() As String
        Get
            Return TableUtils.pincodeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.state field.
	''' </summary>
	Public Property state() As String
		Get 
			Return CType(Me.GetValue(TableUtils.stateColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.stateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property stateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.stateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property stateDefault() As String
        Get
            Return TableUtils.stateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.phone field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.email field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.pan_no field.
	''' </summary>
	Public Property pan_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.pan_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.pan_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property pan_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.pan_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property pan_noDefault() As String
        Get
            Return TableUtils.pan_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.tin_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.eac field.
	''' </summary>
	Public Property eac() As String
		Get 
			Return CType(Me.GetValue(TableUtils.eacColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.eacColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property eacSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.eacColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property eacDefault() As String
        Get
            Return TableUtils.eacColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.range field.
	''' </summary>
	Public Property range() As String
		Get 
			Return CType(Me.GetValue(TableUtils.rangeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.rangeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property rangeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.rangeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property rangeDefault() As String
        Get
            Return TableUtils.rangeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.division field.
	''' </summary>
	Public Property division() As String
		Get 
			Return CType(Me.GetValue(TableUtils.divisionColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.divisionColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property divisionSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.divisionColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property divisionDefault() As String
        Get
            Return TableUtils.divisionColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.ecc_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Company_.cer_no field.
	''' </summary>
	Public Property cer_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.cer_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.cer_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property cer_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.cer_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property cer_noDefault() As String
        Get
            Return TableUtils.cer_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.cer_code field.
	''' </summary>
	Public Property cer_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.cer_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.cer_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property cer_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.cer_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property cer_codeDefault() As String
        Get
            Return TableUtils.cer_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.sign field.
	''' </summary>
	Public Property sign() As String
		Get 
			Return CType(Me.GetValue(TableUtils.signColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.signColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property signSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.signColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property signDefault() As String
        Get
            Return TableUtils.signColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.goods field.
	''' </summary>
	Public Property goods() As String
		Get 
			Return CType(Me.GetValue(TableUtils.goodsColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.goodsColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property goodsSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.goodsColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property goodsDefault() As String
        Get
            Return TableUtils.goodsColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.duty field.
	''' </summary>
	Public Property duty() As String
		Get 
			Return CType(Me.GetValue(TableUtils.dutyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.dutyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property dutySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.dutyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property dutyDefault() As String
        Get
            Return TableUtils.dutyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.license field.
	''' </summary>
	Public Property license() As String
		Get 
			Return CType(Me.GetValue(TableUtils.licenseColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.licenseColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property licenseSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.licenseColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property licenseDefault() As String
        Get
            Return TableUtils.licenseColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.fin_year_start field.
	''' </summary>
	Public Property fin_year_start() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.fin_year_startColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.fin_year_startColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property fin_year_startSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.fin_year_startColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property fin_year_startDefault() As String
        Get
            Return TableUtils.fin_year_startColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.fin_year_end field.
	''' </summary>
	Public Property fin_year_end() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.fin_year_endColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.fin_year_endColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property fin_year_endSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.fin_year_endColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property fin_year_endDefault() As String
        Get
            Return TableUtils.fin_year_endColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.inv_pfx field.
	''' </summary>
	Public Property inv_pfx() As String
		Get 
			Return CType(Me.GetValue(TableUtils.inv_pfxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.inv_pfxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_pfxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_pfxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_pfxDefault() As String
        Get
            Return TableUtils.inv_pfxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.inv_sfx field.
	''' </summary>
	Public Property inv_sfx() As String
		Get 
			Return CType(Me.GetValue(TableUtils.inv_sfxColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.inv_sfxColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_sfxSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_sfxColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_sfxDefault() As String
        Get
            Return TableUtils.inv_sfxColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.next_inv_no field.
	''' </summary>
	Public Property next_inv_no() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.next_inv_noColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.next_inv_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property next_inv_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.next_inv_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property next_inv_noDefault() As String
        Get
            Return TableUtils.next_inv_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.pad_inv_no field.
	''' </summary>
	Public Property pad_inv_no() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.pad_inv_noColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.pad_inv_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property pad_inv_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.pad_inv_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property pad_inv_noDefault() As String
        Get
            Return TableUtils.pad_inv_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.inv_declaration field.
	''' </summary>
	Public Property inv_declaration() As String
		Get 
			Return CType(Me.GetValue(TableUtils.inv_declarationColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.inv_declarationColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_declarationSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_declarationColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_declarationDefault() As String
        Get
            Return TableUtils.inv_declarationColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.email_from field.
	''' </summary>
	Public Property email_from() As String
		Get 
			Return CType(Me.GetValue(TableUtils.email_fromColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.email_fromColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property email_fromSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.email_fromColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property email_fromDefault() As String
        Get
            Return TableUtils.email_fromColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.email_bcc field.
	''' </summary>
	Public Property email_bcc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.email_bccColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.email_bccColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property email_bccSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.email_bccColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property email_bccDefault() As String
        Get
            Return TableUtils.email_bccColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Company_.inv_email_body field.
	''' </summary>
	Public Property inv_email_body() As String
		Get 
			Return CType(Me.GetValue(TableUtils.inv_email_bodyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.inv_email_bodyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property inv_email_bodySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.inv_email_bodyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property inv_email_bodyDefault() As String
        Get
            Return TableUtils.inv_email_bodyColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
