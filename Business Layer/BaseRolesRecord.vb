' This class is "generated" and will be overwritten.
' Your customizations should be made in RolesRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="RolesRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="RolesTable"></see> class.
''' </remarks>
''' <seealso cref="RolesTable"></seealso>
''' <seealso cref="RolesRecord"></seealso>

<Serializable()> Public Class BaseRolesRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As RolesTable = RolesTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Roles_.RoleId field.
	''' </summary>
	Public Function GetRoleIdValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleIdColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Roles_.RoleId field.
	''' </summary>
	Public Function GetRoleIdFieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.RoleIdColumn).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Roles_.Role field.
	''' </summary>
	Public Function GetRoleValue() As ColumnValue
		Return Me.GetValue(TableUtils.RoleColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Roles_.Role field.
	''' </summary>
	Public Function GetRoleFieldValue() As String
		Return CType(Me.GetValue(TableUtils.RoleColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Roles_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.RoleColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Roles_.Role field.
	''' </summary>
	Public Sub SetRoleFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.RoleColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Roles_.RoleId field.
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
	''' This is a convenience property that provides direct access to the value of the record's Roles_.Role field.
	''' </summary>
	Public Property Role() As String
		Get 
			Return CType(Me.GetValue(TableUtils.RoleColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.RoleColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property RoleSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.RoleColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property RoleDefault() As String
        Get
            Return TableUtils.RoleColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
