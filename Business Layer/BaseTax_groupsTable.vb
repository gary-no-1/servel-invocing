' This class is "generated" and will be overwritten.
' Your customizations should be made in Tax_groupsRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Tax_groupsTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named tax_groups.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="Tax_groupsTable.Instance">Tax_groupsTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="Tax_groupsTable"></seealso>

<Serializable()> Public Class BaseTax_groupsTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = Tax_groupsDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.Tax_groupsTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.Tax_groupsRecord")
        Me.ApplicationName = "ServelInvocing"
        Me.DataAdapter = New Tax_groupsSqlTable()
        Directcast(Me.DataAdapter, Tax_groupsSqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        id0Column.CodeName = "id0"
        tax_group_codeColumn.CodeName = "tax_group_code"
        notesColumn.CodeName = "notes"
        id_taxes_1Column.CodeName = "id_taxes_1"
        id_taxes_2Column.CodeName = "id_taxes_2"
        id_taxes_3Column.CodeName = "id_taxes_3"
        id_taxes_4Column.CodeName = "id_taxes_4"
        id_taxes_5Column.CodeName = "id_taxes_5"
        id_taxes_6Column.CodeName = "id_taxes_6"
        id_taxes_7Column.CodeName = "id_taxes_7"
        id_taxes_8Column.CodeName = "id_taxes_8"
        id_taxes_9Column.CodeName = "id_taxes_9"
        
    End Sub

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id column object.
    ''' </summary>
    Public ReadOnly Property id0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id column object.
    ''' </summary>
    Public Shared ReadOnly Property id0() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.tax_group_code column object.
    ''' </summary>
    Public ReadOnly Property tax_group_codeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.tax_group_code column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_group_code() As BaseClasses.Data.StringColumn
        Get
            Return Tax_groupsTable.Instance.tax_group_codeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.notes column object.
    ''' </summary>
    Public ReadOnly Property notesColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.notes column object.
    ''' </summary>
    Public Shared ReadOnly Property notes() As BaseClasses.Data.StringColumn
        Get
            Return Tax_groupsTable.Instance.notesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_1 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_1Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_1 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_1() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_2 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_2Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_2 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_2() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_3 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_3Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_3 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_3() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_4 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_4Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_4 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_4() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_5 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_5Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_5 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_5() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_5Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_6 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_6Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_6 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_6() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_6Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_7 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_7Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_7 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_7() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_7Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_8 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_8Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_8 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_8() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_8Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_9 column object.
    ''' </summary>
    Public ReadOnly Property id_taxes_9Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Tax_groups_.id_taxes_9 column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes_9() As BaseClasses.Data.NumberColumn
        Get
            Return Tax_groupsTable.Instance.id_taxes_9Column
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Tax_groupsRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As Tax_groupsRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Tax_groupsRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Tax_groupsRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Tax_groupsRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Tax_groupsRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  Tax_groupsTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.Tax_groupsRecord)), Tax_groupsRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Tax_groupsRecord()

        Dim recList As ArrayList = Tax_groupsTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.Tax_groupsRecord)), Tax_groupsRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(Tax_groupsTable.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(Tax_groupsTable.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Tax_groupsRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As Tax_groupsRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Tax_groupsRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Tax_groupsRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = Tax_groupsTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Tax_groupsRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Tax_groupsRecord)
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

        Return Tax_groupsTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As Tax_groupsRecord = GetRecords(where)
        Return Tax_groupsTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Tax_groupsRecord = GetRecords(where, orderBy)
        Return Tax_groupsTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As Tax_groupsRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return Tax_groupsTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        Tax_groupsTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return Tax_groupsTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return Tax_groupsTable.Instance.ExportRecordData(whereFilter)
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

        Return Tax_groupsTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

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

        Return Tax_groupsTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return Tax_groupsTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return Tax_groupsTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return Tax_groupsTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return Tax_groupsTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = Tax_groupsTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As Tax_groupsRecord
        Return CType(Tax_groupsTable.Instance.GetRecordData(id, bMutable), Tax_groupsRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As Tax_groupsRecord
        Return CType(Tax_groupsTable.Instance.GetRecordData(id, bMutable), Tax_groupsRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal tax_group_codeValue As String, _
        ByVal notesValue As String, _
        ByVal id_taxes_1Value As String, _
        ByVal id_taxes_2Value As String, _
        ByVal id_taxes_3Value As String, _
        ByVal id_taxes_4Value As String, _
        ByVal id_taxes_5Value As String, _
        ByVal id_taxes_6Value As String, _
        ByVal id_taxes_7Value As String, _
        ByVal id_taxes_8Value As String, _
        ByVal id_taxes_9Value As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(tax_group_codeValue, tax_group_codeColumn)
        rec.SetString(notesValue, notesColumn)
        rec.SetString(id_taxes_1Value, id_taxes_1Column)
        rec.SetString(id_taxes_2Value, id_taxes_2Column)
        rec.SetString(id_taxes_3Value, id_taxes_3Column)
        rec.SetString(id_taxes_4Value, id_taxes_4Column)
        rec.SetString(id_taxes_5Value, id_taxes_5Column)
        rec.SetString(id_taxes_6Value, id_taxes_6Column)
        rec.SetString(id_taxes_7Value, id_taxes_7Column)
        rec.SetString(id_taxes_8Value, id_taxes_8Column)
        rec.SetString(id_taxes_9Value, id_taxes_9Column)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        Tax_groupsTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            Tax_groupsTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(Tax_groupsTable.Instance.TableDefinition.PrimaryKey)) Then
            Return Tax_groupsTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(Tax_groupsTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = Tax_groupsTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = Tax_groupsTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (Tax_groupsTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = Tax_groupsTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


#End Region 

End Class
End Namespace
