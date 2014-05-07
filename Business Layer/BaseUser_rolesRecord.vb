' This class is "generated" and will be overwritten.
' Your customizations should be made in User_rolesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="User_rolesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="User_rolesTable"></see> class.
''' </remarks>
''' <seealso cref="User_rolesTable"></seealso>
''' <seealso cref="User_rolesRecord"></seealso>

<Serializable()> Public Class BaseUser_rolesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As User_rolesTable = User_rolesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's User_roles_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's User_roles_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Function Getuser_idValue() As ColumnValue
		Return Me.GetValue(TableUtils.user_idColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Function Getuser_idFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.user_idColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Sub Setuser_idFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.user_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Sub Setuser_idFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.user_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Sub Setuser_idFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.user_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Sub Setuser_idFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.user_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Sub Setuser_idFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.user_idColumn)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Function Getrole_idValue() As ColumnValue
		Return Me.GetValue(TableUtils.role_idColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Function Getrole_idFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.role_idColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Sub Setrole_idFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.role_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Sub Setrole_idFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.role_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Sub Setrole_idFieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.role_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Sub Setrole_idFieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.role_idColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Sub Setrole_idFieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.role_idColumn)
	End Sub


#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's User_roles_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's User_roles_.user_id field.
	''' </summary>
	Public Property user_id() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.user_idColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.user_idColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property user_idSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.user_idColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property user_idDefault() As String
        Get
            Return TableUtils.user_idColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's User_roles_.role_id field.
	''' </summary>
	Public Property role_id() As Int32
		Get 
			Return CType(Me.GetValue(TableUtils.role_idColumn).ToInt32(), Int32)
		End Get
		Set (ByVal val As Int32) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.role_idColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property role_idSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.role_idColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property role_idDefault() As String
        Get
            Return TableUtils.role_idColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
