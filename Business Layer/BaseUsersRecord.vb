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
	''' This is a convenience method that provides direct access to the value of the record's Users_.UserId field.
	''' </summary>
	Public Function GetUserId0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserId0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.UserId field.
	''' </summary>
	Public Function GetUserId0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.UserName field.
	''' </summary>
	Public Function GetUserName0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserName0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.UserName field.
	''' </summary>
	Public Function GetUserName0FieldValue() As String
		Return CType(Me.GetValue(TableUtils.UserName0Column).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.UserName field.
	''' </summary>
	Public Sub SetUserName0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserName0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.UserName field.
	''' </summary>
	Public Sub SetUserName0FieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserName0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.FullName field.
	''' </summary>
	Public Function GetFullNameValue() As ColumnValue
		Return Me.GetValue(TableUtils.FullNameColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.FullName field.
	''' </summary>
	Public Function GetFullNameFieldValue() As String
		Return CType(Me.GetValue(TableUtils.FullNameColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.FullName field.
	''' </summary>
	Public Sub SetFullNameFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.FullNameColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.FullName field.
	''' </summary>
	Public Sub SetFullNameFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.FullNameColumn)
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
	''' This is a convenience method that provides direct access to the value of the record's Users_.RoleId field.
	''' </summary>
	Public Function GetRoleIdValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Users_.RoleId field.
	''' </summary>
	Public Function GetRoleIdFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIdColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.RoleId field.
	''' </summary>
	Public Sub SetRoleIdFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleIdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.RoleId field.
	''' </summary>
	Public Sub SetRoleIdFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.RoleIdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.RoleId field.
	''' </summary>
	Public Sub SetRoleIdFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.RoleId field.
	''' </summary>
	Public Sub SetRoleIdFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIdColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Users_.RoleId field.
	''' </summary>
	Public Sub SetRoleIdFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleIdColumn)
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



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Users_.UserId field.
	''' </summary>
	Public Property UserId0() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.UserId0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UserId0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UserId0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UserId0Default() As String
        Get
            Return TableUtils.UserId0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Users_.UserName field.
	''' </summary>
	Public Property UserName0() As String
		Get 
			Return CType(Me.GetValue(TableUtils.UserName0Column).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.UserName0Column)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property UserName0Specified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.UserName0Column)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property UserName0Default() As String
        Get
            Return TableUtils.UserName0Column.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Users_.FullName field.
	''' </summary>
	Public Property FullName() As String
		Get 
			Return CType(Me.GetValue(TableUtils.FullNameColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.FullNameColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property FullNameSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.FullNameColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property FullNameDefault() As String
        Get
            Return TableUtils.FullNameColumn.DefaultValue
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
	''' This is a convenience property that provides direct access to the value of the record's Users_.RoleId field.
	''' </summary>
	Public Property RoleId() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.RoleIdColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.RoleIdColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleIdSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleIdColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleIdDefault() As String
        Get
            Return TableUtils.RoleIdColumn.DefaultValue
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



#End Region

End Class
End Namespace
