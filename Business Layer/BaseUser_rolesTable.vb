﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in User_rolesRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="User_rolesTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named user_roles.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="User_rolesTable.Instance">User_rolesTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="User_rolesTable"></seealso>

<Serializable()> Public Class BaseUser_rolesTable
    Inherits PrimaryKeyTable
    Implements IUserRoleTable


    Private ReadOnly TableDefinitionString As String = User_rolesDefinition.GetXMLString()

#Region "IUserTable Members"

	' Get the column that specifies the user's unique identifier
	Public ReadOnly Property UserId() As BaseColumn Implements IUserTable.UserIdColumn
		Get
			Return Me.TableDefinition.ColumnList.GetByNumber(1)
		End Get
	End Property

	' Get a list of records that match the criteria specified in a filter
	Public Overloads Function GetRecordList( _
		ByVal userId As String, _
		ByVal filter As BaseFilter, _
		ByVal orderBy As OrderBy, _
		ByVal pageNumber As Integer, _
		ByVal batchSize As Integer, _
		Optional ByRef totalRows As Integer = Nothing _
	) As ArrayList
		If (Not IsNothing(userId)) Then
			filter = BaseFilter.CombineFilters( _
				CompoundFilter.CompoundingOperators.And_Operator, _
				filter, _
				BaseFilter.CreateUserIdFilter(CType(Me, IUserTable), userId))
		End If
		Return CType(Me, ITable).GetRecordList(filter, orderBy, pageNumber, batchSize, totalRows)
	End Function

#End Region





#Region "IUserRoleTable Members"

	' Get the column that specifies role values
	Public ReadOnly Property UserRole() As BaseColumn Implements IUserRoleTable.UserRoleColumn
		Get
			Return Me.TableDefinition.ColumnList.GetByNumber(2)
		End Get
	End Property

#End Region


    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.User_rolesTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.User_rolesRecord")
        Me.ApplicationName = "ServelInvocing"
        Me.DataAdapter = New User_rolesSqlTable()
        Directcast(Me.DataAdapter, User_rolesSqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        id0Column.CodeName = "id0"
        user_idColumn.CodeName = "user_id"
        role_idColumn.CodeName = "role_id"
        
    End Sub

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's User_roles_.id column object.
    ''' </summary>
    Public ReadOnly Property id0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's User_roles_.id column object.
    ''' </summary>
    Public Shared ReadOnly Property id0() As BaseClasses.Data.NumberColumn
        Get
            Return User_rolesTable.Instance.id0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's User_roles_.user_id column object.
    ''' </summary>
    Public ReadOnly Property user_idColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's User_roles_.user_id column object.
    ''' </summary>
    Public Shared ReadOnly Property user_id() As BaseClasses.Data.NumberColumn
        Get
            Return User_rolesTable.Instance.user_idColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's User_roles_.role_id column object.
    ''' </summary>
    Public ReadOnly Property role_idColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's User_roles_.role_id column object.
    ''' </summary>
    Public Shared ReadOnly Property role_id() As BaseClasses.Data.NumberColumn
        Get
            Return User_rolesTable.Instance.role_idColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of User_rolesRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As User_rolesRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of User_rolesRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As User_rolesRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of User_rolesRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As User_rolesRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  User_rolesTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.User_rolesRecord)), User_rolesRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As User_rolesRecord()

        Dim recList As ArrayList = User_rolesTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.User_rolesRecord)), User_rolesRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(User_rolesTable.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(User_rolesTable.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a User_rolesRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As User_rolesRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a User_rolesRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As User_rolesRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = User_rolesTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As User_rolesRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), User_rolesRecord)
        End If

        Return rec
    End Function

    Public Shared Function GetValues( _
        ByVal col As BaseColumn, _
         ByVal where As WhereClause, _
         ByVal orderBy As OrderBy, _
         ByVal maxItems As Integer) As String()

        ' Create the filter list.
        Dim retCol As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, True)
        retCol.AddColumn(col)

        Return User_rolesTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As User_rolesRecord = GetRecords(where)
        Return User_rolesTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As User_rolesRecord = GetRecords(where, orderBy)
        Return User_rolesTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As User_rolesRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return User_rolesTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        User_rolesTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return User_rolesTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return User_rolesTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function GetSum( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum)

        Return User_rolesTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function
    
    Public Shared Function GetCount( _
        ByVal col As BaseColumn, _
        ByVal where As WhereClause, _
        ByVal orderBy As OrderBy, _
        ByVal pageIndex As Integer, _
        ByVal pageSize As Integer) _
        As String

        Dim colSel As SqlBuilderColumnSelection = New SqlBuilderColumnSelection(False, False)
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count)

        Return User_rolesTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return User_rolesTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return User_rolesTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return User_rolesTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return User_rolesTable.Instance.CreateRecord(tempId)
    End Function

    ''' <summary>
    ''' This method checks if column is editable.
    ''' </summary>
    ''' <param name="columnName">Name of the column to check.</param>
    Public Shared Function isReadOnlyColumn(ByVal columnName As String) As Boolean
        Dim column As BaseColumn = GetColumn(columnName)
        If (Not IsNothing(column)) Then
            Return column.IsValuesReadOnly
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' This method gets the specified column.
    ''' </summary>
    ''' <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    Public Shared Function GetColumn(ByVal uniqueColumnName As String) As BaseColumn
        Dim column As BaseColumn = User_rolesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As User_rolesRecord
        Return CType(User_rolesTable.Instance.GetRecordData(id, bMutable), User_rolesRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As User_rolesRecord
        Return CType(User_rolesTable.Instance.GetRecordData(id, bMutable), User_rolesRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal user_idValue As String, _
        ByVal role_idValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(user_idValue, user_idColumn)
        rec.SetString(role_idValue, role_idColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        User_rolesTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            User_rolesTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(User_rolesTable.Instance.TableDefinition.PrimaryKey)) Then
            Return User_rolesTable.Instance.TableDefinition.PrimaryKey.Columns
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' This method takes a key and returns a keyvalue.
    ''' </summary>
    ''' <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
    Public Shared Function GetKeyValue(ByVal key As Object) As KeyValue
        Dim kv As KeyValue = Nothing

        If (Not (IsNothing(User_rolesTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = User_rolesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = User_rolesTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (User_rolesTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = User_rolesTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


#End Region 

End Class
End Namespace
