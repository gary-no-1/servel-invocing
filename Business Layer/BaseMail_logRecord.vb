' This class is "generated" and will be overwritten.
' Your customizations should be made in Mail_logRecord.vb

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Mail_logRecord"></see> class.
''' </summary>
''' <remarks>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, 
''' use the methods of the <see cref="Mail_logTable"></see> class.
''' </remarks>
''' <seealso cref="Mail_logTable"></seealso>
''' <seealso cref="Mail_logRecord"></seealso>

<Serializable()> Public Class BaseMail_logRecord
	Inherits PrimaryKeyRecord
	

	Public Shared Shadows ReadOnly TableUtils As Mail_logTable = Mail_logTable.Instance

	' Constructors
 
	Protected Sub New()
		MyBase.New(TableUtils)
	End Sub

	Protected Sub New(ByVal record As PrimaryKeyRecord)
		MyBase.New(record, TableUtils)
	End Sub







#Region "Convenience methods to get/set values of fields"

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.id field.
	''' </summary>
	Public Function Getid0Value() As ColumnValue
		Return Me.GetValue(TableUtils.id0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.id field.
	''' </summary>
	Public Function Getid0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.id0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.doc_type field.
	''' </summary>
	Public Function Getdoc_typeValue() As ColumnValue
		Return Me.GetValue(TableUtils.doc_typeColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.doc_type field.
	''' </summary>
	Public Function Getdoc_typeFieldValue() As String
		Return CType(Me.GetValue(TableUtils.doc_typeColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.doc_type field.
	''' </summary>
	Public Sub Setdoc_typeFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.doc_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.doc_type field.
	''' </summary>
	Public Sub Setdoc_typeFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.doc_typeColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Function GetUserId0Value() As ColumnValue
		Return Me.GetValue(TableUtils.UserId0Column)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Function GetUserId0FieldValue() As Int32
		Return CType(Me.GetValue(TableUtils.UserId0Column).ToInt32(), Int32)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Double)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Decimal)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.userid field.
	''' </summary>
	Public Sub SetUserId0FieldValue(ByVal val As Int64)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.UserId0Column)
	End Sub
	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_by field.
	''' </summary>
	Public Function Getsent_byValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_byColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_by field.
	''' </summary>
	Public Function Getsent_byFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_byColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_by field.
	''' </summary>
	Public Sub Setsent_byFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_byColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_by field.
	''' </summary>
	Public Sub Setsent_byFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_byColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_date field.
	''' </summary>
	Public Function Getsent_dateValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_dateColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_date field.
	''' </summary>
	Public Function Getsent_dateFieldValue() As DateTime
		Return CType(Me.GetValue(TableUtils.sent_dateColumn).ToDateTime(), DateTime)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_date field.
	''' </summary>
	Public Sub Setsent_dateFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_date field.
	''' </summary>
	Public Sub Setsent_dateFieldValue(ByVal val As String)
		Me.SetString(val, TableUtils.sent_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_date field.
	''' </summary>
	Public Sub Setsent_dateFieldValue(ByVal val As DateTime)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_dateColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_to field.
	''' </summary>
	Public Function Getsent_toValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_toColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_to field.
	''' </summary>
	Public Function Getsent_toFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_toColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_to field.
	''' </summary>
	Public Sub Setsent_toFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_toColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_to field.
	''' </summary>
	Public Sub Setsent_toFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_toColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_cc field.
	''' </summary>
	Public Function Getsent_ccValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_ccColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_cc field.
	''' </summary>
	Public Function Getsent_ccFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_ccColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_cc field.
	''' </summary>
	Public Sub Setsent_ccFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_ccColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_cc field.
	''' </summary>
	Public Sub Setsent_ccFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_ccColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_bcc field.
	''' </summary>
	Public Function Getsent_bccValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_bccColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_bcc field.
	''' </summary>
	Public Function Getsent_bccFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_bccColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_bcc field.
	''' </summary>
	Public Sub Setsent_bccFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_bccColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_bcc field.
	''' </summary>
	Public Sub Setsent_bccFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_bccColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_subject field.
	''' </summary>
	Public Function Getsent_subjectValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_subjectColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_subject field.
	''' </summary>
	Public Function Getsent_subjectFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_subjectColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_subject field.
	''' </summary>
	Public Sub Setsent_subjectFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_subjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_subject field.
	''' </summary>
	Public Sub Setsent_subjectFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_subjectColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_body field.
	''' </summary>
	Public Function Getsent_bodyValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_bodyColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_body field.
	''' </summary>
	Public Function Getsent_bodyFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_bodyColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_body field.
	''' </summary>
	Public Sub Setsent_bodyFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_bodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_body field.
	''' </summary>
	Public Sub Setsent_bodyFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_bodyColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_attach field.
	''' </summary>
	Public Function Getsent_attachValue() As ColumnValue
		Return Me.GetValue(TableUtils.sent_attachColumn)
	End Function

	''' <summary>
	''' This is a convenience method that provides direct access to the value of the record's Mail_log_.sent_attach field.
	''' </summary>
	Public Function Getsent_attachFieldValue() As String
		Return CType(Me.GetValue(TableUtils.sent_attachColumn).ToString(), String)
	End Function

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_attach field.
	''' </summary>
	Public Sub Setsent_attachFieldValue(ByVal val As ColumnValue)
		Me.SetValue(val, TableUtils.sent_attachColumn)
	End Sub

	''' <summary>
	''' This is a convenience method that allows direct modification of the value of the record's Mail_log_.sent_attach field.
	''' </summary>
	Public Sub Setsent_attachFieldValue(ByVal val As String)
		Dim colValue As ColumnValue = New ColumnValue(val)
		Me.SetValue(colValue, TableUtils.sent_attachColumn)
	End Sub



#End Region

#Region "Convenience methods to get field names"

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.id field.
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
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.doc_type field.
	''' </summary>
	Public Property doc_type() As String
		Get 
			Return CType(Me.GetValue(TableUtils.doc_typeColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.doc_typeColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property doc_typeSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.doc_typeColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property doc_typeDefault() As String
        Get
            Return TableUtils.doc_typeColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.userid field.
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
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_by field.
	''' </summary>
	Public Property sent_by() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_byColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_byColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_bySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_byColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_byDefault() As String
        Get
            Return TableUtils.sent_byColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_date field.
	''' </summary>
	Public Property sent_date() As DateTime
		Get 
			Return CType(Me.GetValue(TableUtils.sent_dateColumn).ToDateTime(), DateTime)
		End Get
		Set (ByVal val As DateTime) 
			Dim colValue As ColumnValue = New ColumnValue(val)
			Me.SetValue(colValue, TableUtils.sent_dateColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_dateSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_dateColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_dateDefault() As String
        Get
            Return TableUtils.sent_dateColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_to field.
	''' </summary>
	Public Property sent_to() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_toColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_toColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_toSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_toColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_toDefault() As String
        Get
            Return TableUtils.sent_toColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_cc field.
	''' </summary>
	Public Property sent_cc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_ccColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_ccColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_ccSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_ccColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_ccDefault() As String
        Get
            Return TableUtils.sent_ccColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_bcc field.
	''' </summary>
	Public Property sent_bcc() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_bccColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_bccColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_bccSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_bccColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_bccDefault() As String
        Get
            Return TableUtils.sent_bccColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_subject field.
	''' </summary>
	Public Property sent_subject() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_subjectColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_subjectColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_subjectSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_subjectColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_subjectDefault() As String
        Get
            Return TableUtils.sent_subjectColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_body field.
	''' </summary>
	Public Property sent_body() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_bodyColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_bodyColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_bodySpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_bodyColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_bodyDefault() As String
        Get
            Return TableUtils.sent_bodyColumn.DefaultValue
        End Get
    End Property

	''' <summary>
	''' This is a convenience property that provides direct access to the value of the record's Mail_log_.sent_attach field.
	''' </summary>
	Public Property sent_attach() As String
		Get 
			Return CType(Me.GetValue(TableUtils.sent_attachColumn).ToString(), String)
		End Get
		Set (ByVal Value As String) 
			Me.SetString(value, TableUtils.sent_attachColumn)
		End Set
	End Property


	''' <summary>
	''' This is a convenience method that can be used to determine that the column is set.
	''' </summary>
	Public ReadOnly Property sent_attachSpecified() As Boolean
        Get
            Dim val As ColumnValue = Me.GetValue(TableUtils.sent_attachColumn)
            If val Is Nothing OrElse val.IsNull Then
                Return False
            End If
            Return True
        End Get
    End Property

	''' <summary>
	''' This is a convenience method that can be used to get the default value of a column.
	''' </summary>
    Public ReadOnly Property sent_attachDefault() As String
        Get
            Return TableUtils.sent_attachColumn.DefaultValue
        End Get
    End Property



#End Region

End Class
End Namespace
