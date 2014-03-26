' This class is "generated" and will be overwritten.
' Your customizations should be made in Item_groupsRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Item_groupsRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Item_groupsTable"></see> class.
''' </remarks>
''' <seealso cref="Item_groupsTable"></seealso>
''' <seealso cref="Item_groupsRecord"></seealso>

<Serializable()> Public Class BaseItem_groupsRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Item_groupsTable = Item_groupsTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_groups_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_groups_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_groups_.item_group field.
	''' </summary>
	Public Function Getitem_groupValue() As ColumnValue
		Return Me.GetValue(TableUtils.item_groupColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_groups_.item_group field.
	''' </summary>
	Public Function Getitem_groupFieldValue() As String
		Return CType(Me.GetValue(TableUtils.item_groupColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_groups_.item_group field.
	''' </summary>
	Public Sub Setitem_groupFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_groups_.item_group field.
	''' </summary>
	Public Sub Setitem_groupFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.item_groupColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_groups_.tariff_no field.
	''' </summary>
	Public Function Gettariff_noValue() As ColumnValue
		Return Me.GetValue(TableUtils.tariff_noColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Item_groups_.tariff_no field.
	''' </summary>
	Public Function Gettariff_noFieldValue() As String
		Return CType(Me.GetValue(TableUtils.tariff_noColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_groups_.tariff_no field.
	''' </summary>
	Public Sub Settariff_noFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.tariff_noColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Item_groups_.tariff_no field.
	''' </summary>
	Public Sub Settariff_noFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.tariff_noColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Item_groups_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Item_groups_.item_group field.
	''' </summary>
	Public Property item_group() As String
		Get 
			Return CType(Me.GetValue(TableUtils.item_groupColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.item_groupColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property item_groupSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.item_groupColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property item_groupDefault() As String
        Get
            Return TableUtils.item_groupColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Item_groups_.tariff_no field.
	''' </summary>
	Public Property tariff_no() As String
		Get 
			Return CType(Me.GetValue(TableUtils.tariff_noColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.tariff_noColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property tariff_noSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.tariff_noColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property tariff_noDefault() As String
        Get
            Return TableUtils.tariff_noColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
