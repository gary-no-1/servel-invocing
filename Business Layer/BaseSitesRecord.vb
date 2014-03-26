' This class is "generated" and will be overwritten.
' Your customizations should be made in SitesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="SitesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="SitesTable"></see> class.
''' </remarks>
''' <seealso cref="SitesTable"></seealso>
''' <seealso cref="SitesRecord"></seealso>

<Serializable()> Public Class BaseSitesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As SitesTable = SitesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.id_party field.
	''' </summary>
	Public Function Getid_partyValue() As ColumnValue
		Return Me.GetValue(TableUtils.id_partyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.id_party field.
	''' </summary>
	Public Function Getid_partyFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id_partyColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.id_party field.
	''' </summary>
	Public Sub Setid_partyFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.id_partyColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.party_code field.
	''' </summary>
	Public Function Getparty_codeValue() As ColumnValue
		Return Me.GetValue(TableUtils.party_codeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.party_code field.
	''' </summary>
	Public Function Getparty_codeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.party_codeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.party_code field.
	''' </summary>
	Public Sub Setparty_codeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.party_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.party_code field.
	''' </summary>
	Public Sub Setparty_codeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.party_codeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.name field.
	''' </summary>
	Public Function GetnameValue() As ColumnValue
		Return Me.GetValue(TableUtils.nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.name field.
	''' </summary>
	Public Function GetnameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.address field.
	''' </summary>
	Public Function GetaddressValue() As ColumnValue
		Return Me.GetValue(TableUtils.addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.address field.
	''' </summary>
	Public Function GetaddressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.address field.
	''' </summary>
	Public Sub SetaddressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.address field.
	''' </summary>
	Public Sub SetaddressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.city field.
	''' </summary>
	Public Function GetcityValue() As ColumnValue
		Return Me.GetValue(TableUtils.cityColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.city field.
	''' </summary>
	Public Function GetcityFieldValue() As String
		Return CType(Me.GetValue(TableUtils.cityColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.city field.
	''' </summary>
	Public Sub SetcityFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.cityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.city field.
	''' </summary>
	Public Sub SetcityFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.cityColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.contact field.
	''' </summary>
	Public Function GetcontactValue() As ColumnValue
		Return Me.GetValue(TableUtils.contactColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.contact field.
	''' </summary>
	Public Function GetcontactFieldValue() As String
		Return CType(Me.GetValue(TableUtils.contactColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.contact field.
	''' </summary>
	Public Sub SetcontactFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.contactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.contact field.
	''' </summary>
	Public Sub SetcontactFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.contactColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.phone field.
	''' </summary>
	Public Function GetphoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.phoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.phone field.
	''' </summary>
	Public Function GetphoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.phoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.email field.
	''' </summary>
	Public Function GetemailValue() As ColumnValue
		Return Me.GetValue(TableUtils.emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.email field.
	''' </summary>
	Public Function GetemailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.vat_no field.
	''' </summary>
	Public Function Getvat_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.vat_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.vat_no field.
	''' </summary>
	Public Function Getvat_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.vat_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.vat_no field.
	''' </summary>
	Public Sub Setvat_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.vat_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.vat_no field.
	''' </summary>
	Public Sub Setvat_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.vat_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.pan_no field.
	''' </summary>
	Public Function Getpan_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.pan_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.pan_no field.
	''' </summary>
	Public Function Getpan_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.pan_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.pan_no field.
	''' </summary>
	Public Sub Setpan_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.pan_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.pan_no field.
	''' </summary>
	Public Sub Setpan_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.pan_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.ecc_no field.
	''' </summary>
	Public Function Getecc_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.ecc_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.ecc_no field.
	''' </summary>
	Public Function Getecc_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.ecc_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.ecc_no field.
	''' </summary>
	Public Sub Setecc_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.ecc_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.ecc_no field.
	''' </summary>
	Public Sub Setecc_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.ecc_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.st37_no field.
	''' </summary>
	Public Function Getst37_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.st37_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.st37_no field.
	''' </summary>
	Public Function Getst37_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.st37_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.st37_no field.
	''' </summary>
	Public Sub Setst37_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.st37_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.st37_no field.
	''' </summary>
	Public Sub Setst37_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.st37_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.tin_no field.
	''' </summary>
	Public Function Gettin_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tin_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Sites_.tin_no field.
	''' </summary>
	Public Function Gettin_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tin_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tin_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Sites_.tin_no field.
	''' </summary>
	Public Sub Settin_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tin_noColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sites_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.id_party field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.party_code field.
	''' </summary>
	Public Property party_code() As String
		Get 
			Return CType(Me.GetValue(TableUtils.party_codeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.party_codeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property party_codeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.party_codeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property party_codeDefault() As String
        Get
            Return TableUtils.party_codeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sites_.name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.address field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.city field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.contact field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.phone field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.email field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.vat_no field.
	''' </summary>
	Public Property vat_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.vat_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.vat_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property vat_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.vat_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property vat_noDefault() As String
        Get
            Return TableUtils.vat_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sites_.pan_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.ecc_no field.
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
	''' This is a convenience property that provides direct access to the value of the record's Sites_.st37_no field.
	''' </summary>
	Public Property st37_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.st37_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.st37_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property st37_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.st37_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property st37_noDefault() As String
        Get
            Return TableUtils.st37_noColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Sites_.tin_no field.
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



#End Region

End Class
End Namespace
