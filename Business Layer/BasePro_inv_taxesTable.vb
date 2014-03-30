' This class is "generated" and will be overwritten.
' Your customizations should be made in Pro_inv_taxesRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="Pro_inv_taxesTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named pro_inv_taxes.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="Pro_inv_taxesTable.Instance">Pro_inv_taxesTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="Pro_inv_taxesTable"></seealso>

<Serializable()> Public Class BasePro_inv_taxesTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = Pro_inv_taxesDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.Pro_inv_taxesTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.Pro_inv_taxesRecord")
        Me.ApplicationName = "ServelInvocing"
        Me.DataAdapter = New Pro_inv_taxesSqlTable()
        Directcast(Me.DataAdapter, Pro_inv_taxesSqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        id0Column.CodeName = "id0"
        id_pro_inv_hdrColumn.CodeName = "id_pro_inv_hdr"
        id_taxesColumn.CodeName = "id_taxes"
        tax_codeColumn.CodeName = "tax_code"
        tax_nameColumn.CodeName = "tax_name"
        tax_printColumn.CodeName = "tax_print"
        tax_rateColumn.CodeName = "tax_rate"
        tax_onColumn.CodeName = "tax_on"
        tax_amountColumn.CodeName = "tax_amount"
        tax_lockColumn.CodeName = "tax_lock"
        calc_typeColumn.CodeName = "calc_type"
        sort_orderColumn.CodeName = "sort_order"
        
    End Sub

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.id column object.
    ''' </summary>
    Public ReadOnly Property id0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.id column object.
    ''' </summary>
    Public Shared ReadOnly Property id0() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.id0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.id_pro_inv_hdr column object.
    ''' </summary>
    Public ReadOnly Property id_pro_inv_hdrColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.id_pro_inv_hdr column object.
    ''' </summary>
    Public Shared ReadOnly Property id_pro_inv_hdr() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.id_pro_inv_hdrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.id_taxes column object.
    ''' </summary>
    Public ReadOnly Property id_taxesColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.id_taxes column object.
    ''' </summary>
    Public Shared ReadOnly Property id_taxes() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.id_taxesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_code column object.
    ''' </summary>
    Public ReadOnly Property tax_codeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_code column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_code() As BaseClasses.Data.StringColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_codeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_name column object.
    ''' </summary>
    Public ReadOnly Property tax_nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_name column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_name() As BaseClasses.Data.StringColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_nameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_print column object.
    ''' </summary>
    Public ReadOnly Property tax_printColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_print column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_print() As BaseClasses.Data.StringColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_printColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_rate column object.
    ''' </summary>
    Public ReadOnly Property tax_rateColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_rate column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_rate() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_rateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_on column object.
    ''' </summary>
    Public ReadOnly Property tax_onColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_on column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_on() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_onColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_amount column object.
    ''' </summary>
    Public ReadOnly Property tax_amountColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_amount column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_amount() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_amountColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_lock column object.
    ''' </summary>
    Public ReadOnly Property tax_lockColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.tax_lock column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_lock() As BaseClasses.Data.BooleanColumn
        Get
            Return Pro_inv_taxesTable.Instance.tax_lockColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.calc_type column object.
    ''' </summary>
    Public ReadOnly Property calc_typeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.calc_type column object.
    ''' </summary>
    Public Shared ReadOnly Property calc_type() As BaseClasses.Data.StringColumn
        Get
            Return Pro_inv_taxesTable.Instance.calc_typeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.sort_order column object.
    ''' </summary>
    Public ReadOnly Property sort_orderColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Pro_inv_taxes_.sort_order column object.
    ''' </summary>
    Public Shared ReadOnly Property sort_order() As BaseClasses.Data.NumberColumn
        Get
            Return Pro_inv_taxesTable.Instance.sort_orderColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Pro_inv_taxesRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As Pro_inv_taxesRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Pro_inv_taxesRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Pro_inv_taxesRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of Pro_inv_taxesRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Pro_inv_taxesRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  Pro_inv_taxesTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As Pro_inv_taxesRecord()

        Dim recList As ArrayList = Pro_inv_taxesTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.Pro_inv_taxesRecord)), Pro_inv_taxesRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(Pro_inv_taxesTable.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(Pro_inv_taxesTable.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Pro_inv_taxesRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As Pro_inv_taxesRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a Pro_inv_taxesRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As Pro_inv_taxesRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = Pro_inv_taxesTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As Pro_inv_taxesRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), Pro_inv_taxesRecord)
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

        Return Pro_inv_taxesTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As Pro_inv_taxesRecord = GetRecords(where)
        Return Pro_inv_taxesTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As Pro_inv_taxesRecord = GetRecords(where, orderBy)
        Return Pro_inv_taxesTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As Pro_inv_taxesRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return Pro_inv_taxesTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        Pro_inv_taxesTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return Pro_inv_taxesTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return Pro_inv_taxesTable.Instance.ExportRecordData(whereFilter)
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

        Return Pro_inv_taxesTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

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

        Return Pro_inv_taxesTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return Pro_inv_taxesTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return Pro_inv_taxesTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return Pro_inv_taxesTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return Pro_inv_taxesTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = Pro_inv_taxesTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As Pro_inv_taxesRecord
        Return CType(Pro_inv_taxesTable.Instance.GetRecordData(id, bMutable), Pro_inv_taxesRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As Pro_inv_taxesRecord
        Return CType(Pro_inv_taxesTable.Instance.GetRecordData(id, bMutable), Pro_inv_taxesRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal id_pro_inv_hdrValue As String, _
        ByVal id_taxesValue As String, _
        ByVal tax_codeValue As String, _
        ByVal tax_nameValue As String, _
        ByVal tax_printValue As String, _
        ByVal tax_rateValue As String, _
        ByVal tax_onValue As String, _
        ByVal tax_amountValue As String, _
        ByVal tax_lockValue As String, _
        ByVal calc_typeValue As String, _
        ByVal sort_orderValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(id_pro_inv_hdrValue, id_pro_inv_hdrColumn)
        rec.SetString(id_taxesValue, id_taxesColumn)
        rec.SetString(tax_codeValue, tax_codeColumn)
        rec.SetString(tax_nameValue, tax_nameColumn)
        rec.SetString(tax_printValue, tax_printColumn)
        rec.SetString(tax_rateValue, tax_rateColumn)
        rec.SetString(tax_onValue, tax_onColumn)
        rec.SetString(tax_amountValue, tax_amountColumn)
        rec.SetString(tax_lockValue, tax_lockColumn)
        rec.SetString(calc_typeValue, calc_typeColumn)
        rec.SetString(sort_orderValue, sort_orderColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        Pro_inv_taxesTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            Pro_inv_taxesTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(Pro_inv_taxesTable.Instance.TableDefinition.PrimaryKey)) Then
            Return Pro_inv_taxesTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(Pro_inv_taxesTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = Pro_inv_taxesTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = Pro_inv_taxesTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (Pro_inv_taxesTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = Pro_inv_taxesTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


#End Region 

End Class
End Namespace
