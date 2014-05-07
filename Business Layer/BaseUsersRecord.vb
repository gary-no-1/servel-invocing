' This class is "generated" and will be overwritten.
' Your customizations should be made in UsersRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="UsersRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="UsersTable"></see> class.
''' </remarks>
''' <seealso cref="UsersTable"></seealso>
''' <seealso cref="UsersRecord"></seealso>

<Serializable()> Public Class BaseUsersRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As UsersTable = UsersTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.name field.
	''' </summary>
	Public Function GetnameValue() As ColumnValue
		Return Me.GetValue(TableUtils.nameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.name field.
	''' </summary>
	Public Function GetnameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.nameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.name field.
	''' </summary>
	Public Sub SetnameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.nameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.email field.
	''' </summary>
	Public Function GetemailValue() As ColumnValue
		Return Me.GetValue(TableUtils.emailColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.email field.
	''' </summary>
	Public Function GetemailFieldValue() As String
		Return CType(Me.GetValue(TableUtils.emailColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.email field.
	''' </summary>
	Public Sub SetemailFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.emailColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.password field.
	''' </summary>
	Public Function GetpasswordValue() As ColumnValue
		Return Me.GetValue(TableUtils.passwordColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.password field.
	''' </summary>
	Public Function GetpasswordFieldValue() As String
		Return CType(Me.GetValue(TableUtils.passwordColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.password field.
	''' </summary>
	Public Sub SetpasswordFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.passwordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.password field.
	''' </summary>
	Public Sub SetpasswordFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.passwordColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.mobile field.
	''' </summary>
	Public Function GetmobileValue() As ColumnValue
		Return Me.GetValue(TableUtils.mobileColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.mobile field.
	''' </summary>
	Public Function GetmobileFieldValue() As String
		Return CType(Me.GetValue(TableUtils.mobileColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.mobile field.
	''' </summary>
	Public Sub SetmobileFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.mobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.mobile field.
	''' </summary>
	Public Sub SetmobileFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.mobileColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.phone field.
	''' </summary>
	Public Function GetphoneValue() As ColumnValue
		Return Me.GetValue(TableUtils.phoneColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.phone field.
	''' </summary>
	Public Function GetphoneFieldValue() As String
		Return CType(Me.GetValue(TableUtils.phoneColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.phone field.
	''' </summary>
	Public Sub SetphoneFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.phoneColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.address field.
	''' </summary>
	Public Function GetaddressValue() As ColumnValue
		Return Me.GetValue(TableUtils.addressColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.address field.
	''' </summary>
	Public Function GetaddressFieldValue() As String
		Return CType(Me.GetValue(TableUtils.addressColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.address field.
	''' </summary>
	Public Sub SetaddressFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.addressColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.address field.
	''' </summary>
	Public Sub SetaddressFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.addressColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Users_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Users_.name field.
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
	''' This is a convenience property that provides direct access to the value of the record's Users_.email field.
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
	''' This is a convenience property that provides direct access to the value of the record's Users_.password field.
	''' </summary>
	Public Property password() As String
		Get 
			Return CType(Me.GetValue(TableUtils.passwordColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.passwordColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property passwordSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.passwordColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property passwordDefault() As String
        Get
            Return TableUtils.passwordColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Users_.mobile field.
	''' </summary>
	Public Property mobile() As String
		Get 
			Return CType(Me.GetValue(TableUtils.mobileColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.mobileColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property mobileSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.mobileColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property mobileDefault() As String
        Get
            Return TableUtils.mobileColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Users_.phone field.
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
	''' This is a convenience property that provides direct access to the value of the record's Users_.address field.
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



#End Region

End Class
End Namespace
