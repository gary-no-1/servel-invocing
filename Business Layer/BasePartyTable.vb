' This class is "generated" and will be overwritten.
' Your customizations should be made in PartyRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="PartyTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named party.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="PartyTable.Instance">PartyTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="PartyTable"></seealso>

<Serializable()> Public Class BasePartyTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = PartyDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.PartyTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.PartyRecord")
        Me.ApplicationName = "ServelInvocing"
        Me.DataAdapter = New PartySqlTable()
        Directcast(Me.DataAdapter, PartySqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        id0Column.CodeName = "id0"
        party_codeColumn.CodeName = "party_code"
        nameColumn.CodeName = "name"
        addressColumn.CodeName = "address"
        cityColumn.CodeName = "city"
        contactColumn.CodeName = "contact"
        phoneColumn.CodeName = "phone"
        emailColumn.CodeName = "email"
        lst_noColumn.CodeName = "lst_no"
        cst_noColumn.CodeName = "cst_no"
        lst_dateColumn.CodeName = "lst_date"
        cst_dateColumn.CodeName = "cst_date"
        vat_noColumn.CodeName = "vat_no"
        pan_noColumn.CodeName = "pan_no"
        ecc_noColumn.CodeName = "ecc_no"
        st37_noColumn.CodeName = "st37_no"
        tin_noColumn.CodeName = "tin_no"
        gst_noColumn.CodeName = "gst_no"
        id_statesColumn.CodeName = "id_states"
        state_codeColumn.CodeName = "state_code"
        state_nameColumn.CodeName = "state_name"
        
    End Sub

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.id column object.
    ''' </summary>
    Public ReadOnly Property id0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.id column object.
    ''' </summary>
    Public Shared ReadOnly Property id0() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.id0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.party_code column object.
    ''' </summary>
    Public ReadOnly Property party_codeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.party_code column object.
    ''' </summary>
    Public Shared ReadOnly Property party_code() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.party_codeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.name column object.
    ''' </summary>
    Public ReadOnly Property nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.name column object.
    ''' </summary>
    Public Shared ReadOnly Property name() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.nameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.address column object.
    ''' </summary>
    Public ReadOnly Property addressColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.address column object.
    ''' </summary>
    Public Shared ReadOnly Property address() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.addressColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.city column object.
    ''' </summary>
    Public ReadOnly Property cityColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.city column object.
    ''' </summary>
    Public Shared ReadOnly Property city() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.cityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.contact column object.
    ''' </summary>
    Public ReadOnly Property contactColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.contact column object.
    ''' </summary>
    Public Shared ReadOnly Property contact() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.contactColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.phone column object.
    ''' </summary>
    Public ReadOnly Property phoneColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.phone column object.
    ''' </summary>
    Public Shared ReadOnly Property phone() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.phoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.email column object.
    ''' </summary>
    Public ReadOnly Property emailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.email column object.
    ''' </summary>
    Public Shared ReadOnly Property email() As BaseClasses.Data.EmailColumn
        Get
            Return PartyTable.Instance.emailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.lst_no column object.
    ''' </summary>
    Public ReadOnly Property lst_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.lst_no column object.
    ''' </summary>
    Public Shared ReadOnly Property lst_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.lst_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.cst_no column object.
    ''' </summary>
    Public ReadOnly Property cst_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.cst_no column object.
    ''' </summary>
    Public Shared ReadOnly Property cst_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.cst_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.lst_date column object.
    ''' </summary>
    Public ReadOnly Property lst_dateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.lst_date column object.
    ''' </summary>
    Public Shared ReadOnly Property lst_date() As BaseClasses.Data.DateColumn
        Get
            Return PartyTable.Instance.lst_dateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.cst_date column object.
    ''' </summary>
    Public ReadOnly Property cst_dateColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.cst_date column object.
    ''' </summary>
    Public Shared ReadOnly Property cst_date() As BaseClasses.Data.DateColumn
        Get
            Return PartyTable.Instance.cst_dateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.vat_no column object.
    ''' </summary>
    Public ReadOnly Property vat_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.vat_no column object.
    ''' </summary>
    Public Shared ReadOnly Property vat_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.vat_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.pan_no column object.
    ''' </summary>
    Public ReadOnly Property pan_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.pan_no column object.
    ''' </summary>
    Public Shared ReadOnly Property pan_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.pan_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ecc_no column object.
    ''' </summary>
    Public ReadOnly Property ecc_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.ecc_no column object.
    ''' </summary>
    Public Shared ReadOnly Property ecc_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.ecc_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.st37_no column object.
    ''' </summary>
    Public ReadOnly Property st37_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.st37_no column object.
    ''' </summary>
    Public Shared ReadOnly Property st37_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.st37_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.tin_no column object.
    ''' </summary>
    Public ReadOnly Property tin_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.tin_no column object.
    ''' </summary>
    Public Shared ReadOnly Property tin_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.tin_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.gst_no column object.
    ''' </summary>
    Public ReadOnly Property gst_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.gst_no column object.
    ''' </summary>
    Public Shared ReadOnly Property gst_no() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.gst_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.id_states column object.
    ''' </summary>
    Public ReadOnly Property id_statesColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.id_states column object.
    ''' </summary>
    Public Shared ReadOnly Property id_states() As BaseClasses.Data.NumberColumn
        Get
            Return PartyTable.Instance.id_statesColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.state_code column object.
    ''' </summary>
    Public ReadOnly Property state_codeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.state_code column object.
    ''' </summary>
    Public Shared ReadOnly Property state_code() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.state_codeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.state_name column object.
    ''' </summary>
    Public ReadOnly Property state_nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Party_.state_name column object.
    ''' </summary>
    Public Shared ReadOnly Property state_name() As BaseClasses.Data.StringColumn
        Get
            Return PartyTable.Instance.state_nameColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As PartyRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of PartyRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  PartyTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.PartyRecord)), PartyRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As PartyRecord()

        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.PartyRecord)), PartyRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(PartyTable.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(PartyTable.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As PartyRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a PartyRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As PartyRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = PartyTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As PartyRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), PartyRecord)
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

        Return PartyTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(where)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(where, orderBy)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As PartyRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return PartyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        PartyTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return PartyTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return PartyTable.Instance.ExportRecordData(whereFilter)
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

        Return PartyTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

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

        Return PartyTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return PartyTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return PartyTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return PartyTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return PartyTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = PartyTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As PartyRecord
        Return CType(PartyTable.Instance.GetRecordData(id, bMutable), PartyRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As PartyRecord
        Return CType(PartyTable.Instance.GetRecordData(id, bMutable), PartyRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal party_codeValue As String, _
        ByVal nameValue As String, _
        ByVal addressValue As String, _
        ByVal cityValue As String, _
        ByVal contactValue As String, _
        ByVal phoneValue As String, _
        ByVal emailValue As String, _
        ByVal lst_noValue As String, _
        ByVal cst_noValue As String, _
        ByVal lst_dateValue As String, _
        ByVal cst_dateValue As String, _
        ByVal vat_noValue As String, _
        ByVal pan_noValue As String, _
        ByVal ecc_noValue As String, _
        ByVal st37_noValue As String, _
        ByVal tin_noValue As String, _
        ByVal gst_noValue As String, _
        ByVal id_statesValue As String, _
        ByVal state_codeValue As String, _
        ByVal state_nameValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(party_codeValue, party_codeColumn)
        rec.SetString(nameValue, nameColumn)
        rec.SetString(addressValue, addressColumn)
        rec.SetString(cityValue, cityColumn)
        rec.SetString(contactValue, contactColumn)
        rec.SetString(phoneValue, phoneColumn)
        rec.SetString(emailValue, emailColumn)
        rec.SetString(lst_noValue, lst_noColumn)
        rec.SetString(cst_noValue, cst_noColumn)
        rec.SetString(lst_dateValue, lst_dateColumn)
        rec.SetString(cst_dateValue, cst_dateColumn)
        rec.SetString(vat_noValue, vat_noColumn)
        rec.SetString(pan_noValue, pan_noColumn)
        rec.SetString(ecc_noValue, ecc_noColumn)
        rec.SetString(st37_noValue, st37_noColumn)
        rec.SetString(tin_noValue, tin_noColumn)
        rec.SetString(gst_noValue, gst_noColumn)
        rec.SetString(id_statesValue, id_statesColumn)
        rec.SetString(state_codeValue, state_codeColumn)
        rec.SetString(state_nameValue, state_nameColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        PartyTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            PartyTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(PartyTable.Instance.TableDefinition.PrimaryKey)) Then
            Return PartyTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(PartyTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = PartyTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = PartyTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (PartyTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = PartyTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


#End Region 

End Class
End Namespace
