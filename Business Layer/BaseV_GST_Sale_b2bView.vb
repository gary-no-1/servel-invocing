' This class is "generated" and will be overwritten.
' Your customizations should be made in V_GST_Sale_b2bView.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="V_GST_Sale_b2bView"></see> class.
''' Provides access to the schema information and record data of a database table or view named V_GST_Sale_b2b.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="V_GST_Sale_b2bView.Instance">V_GST_Sale_b2bView.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="V_GST_Sale_b2bView"></seealso>

<Serializable()> Public Class BaseV_GST_Sale_b2bView
	Inherits KeylessTable
	

	Private ReadOnly TableDefinitionString As String = V_GST_Sale_b2bDefinition.GetXMLString()







	Protected Sub New()
		MyBase.New()
		Me.Initialize()
	End Sub

	Protected Overridable Sub Initialize()
		Dim def As New XmlTableDefinition(TableDefinitionString)
		Me.TableDefinition = New TableDefinition()
		Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.V_GST_Sale_b2bView")
		def.InitializeTableDefinition(Me.TableDefinition)
		Me.ConnectionName = def.GetConnectionName()
		Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.V_GST_Sale_b2bRecord")
		Me.ApplicationName = "ServelInvocing"
		Me.DataAdapter = New V_GST_Sale_b2bSqlView()
		Directcast(Me.DataAdapter, V_GST_Sale_b2bSqlView).ConnectionName = Me.ConnectionName
		
		Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        Expr1Column.CodeName = "Expr1"
        Expr2Column.CodeName = "Expr2"
        Expr3Column.CodeName = "Expr3"
        grand_totalColumn.CodeName = "grand_total"
        Expr4Column.CodeName = "Expr4"
        reverse_chargeColumn.CodeName = "reverse_charge"
        invoice_typeColumn.CodeName = "invoice_type"
        e_commColumn.CodeName = "e_comm"
        tax_rateColumn.CodeName = "tax_rate"
        item_totalColumn.CodeName = "item_total"
        cessColumn.CodeName = "cess"
		
	End Sub
	
#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr1 column object.
    ''' </summary>
    Public ReadOnly Property Expr1Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr1 column object.
    ''' </summary>
    Public Shared ReadOnly Property Expr1() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.Expr1Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr2 column object.
    ''' </summary>
    Public ReadOnly Property Expr2Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr2 column object.
    ''' </summary>
    Public Shared ReadOnly Property Expr2() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.Expr2Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr3 column object.
    ''' </summary>
    Public ReadOnly Property Expr3Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr3 column object.
    ''' </summary>
    Public Shared ReadOnly Property Expr3() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.Expr3Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.grand_total column object.
    ''' </summary>
    Public ReadOnly Property grand_totalColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.grand_total column object.
    ''' </summary>
    Public Shared ReadOnly Property grand_total() As BaseClasses.Data.NumberColumn
        Get
            Return V_GST_Sale_b2bView.Instance.grand_totalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr4 column object.
    ''' </summary>
    Public ReadOnly Property Expr4Column() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.Expr4 column object.
    ''' </summary>
    Public Shared ReadOnly Property Expr4() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.Expr4Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.reverse_charge column object.
    ''' </summary>
    Public ReadOnly Property reverse_chargeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.reverse_charge column object.
    ''' </summary>
    Public Shared ReadOnly Property reverse_charge() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.reverse_chargeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.invoice_type column object.
    ''' </summary>
    Public ReadOnly Property invoice_typeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.invoice_type column object.
    ''' </summary>
    Public Shared ReadOnly Property invoice_type() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.invoice_typeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.e_comm column object.
    ''' </summary>
    Public ReadOnly Property e_commColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.e_comm column object.
    ''' </summary>
    Public Shared ReadOnly Property e_comm() As BaseClasses.Data.StringColumn
        Get
            Return V_GST_Sale_b2bView.Instance.e_commColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.tax_rate column object.
    ''' </summary>
    Public ReadOnly Property tax_rateColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.tax_rate column object.
    ''' </summary>
    Public Shared ReadOnly Property tax_rate() As BaseClasses.Data.NumberColumn
        Get
            Return V_GST_Sale_b2bView.Instance.tax_rateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.item_total column object.
    ''' </summary>
    Public ReadOnly Property item_totalColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.item_total column object.
    ''' </summary>
    Public Shared ReadOnly Property item_total() As BaseClasses.Data.NumberColumn
        Get
            Return V_GST_Sale_b2bView.Instance.item_totalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.cess column object.
    ''' </summary>
    Public ReadOnly Property cessColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's V_GST_Sale_b2b_.cess column object.
    ''' </summary>
    Public Shared ReadOnly Property cess() As BaseClasses.Data.NumberColumn
        Get
            Return V_GST_Sale_b2bView.Instance.cessColumn
        End Get
    End Property


#End Region

#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_GST_Sale_b2bRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As V_GST_Sale_b2bRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_GST_Sale_b2bRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_GST_Sale_b2bRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of V_GST_Sale_b2bRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_GST_Sale_b2bRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  V_GST_Sale_b2bView.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.V_GST_Sale_b2bRecord)), V_GST_Sale_b2bRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As V_GST_Sale_b2bRecord()

        Dim recList As ArrayList = V_GST_Sale_b2bView.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.V_GST_Sale_b2bRecord)), V_GST_Sale_b2bRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(V_GST_Sale_b2bView.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(V_GST_Sale_b2bView.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_GST_Sale_b2bRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As V_GST_Sale_b2bRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a V_GST_Sale_b2bRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As V_GST_Sale_b2bRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = V_GST_Sale_b2bView.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As V_GST_Sale_b2bRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), V_GST_Sale_b2bRecord)
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

        Return V_GST_Sale_b2bView.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As V_GST_Sale_b2bRecord = GetRecords(where)
        Return V_GST_Sale_b2bView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As V_GST_Sale_b2bRecord = GetRecords(where, orderBy)
        Return V_GST_Sale_b2bView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As V_GST_Sale_b2bRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return V_GST_Sale_b2bView.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        V_GST_Sale_b2bView.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return V_GST_Sale_b2bView.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return V_GST_Sale_b2bView.Instance.ExportRecordData(whereFilter)
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

        Return V_GST_Sale_b2bView.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

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

        Return V_GST_Sale_b2bView.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return V_GST_Sale_b2bView.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return V_GST_Sale_b2bView.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return V_GST_Sale_b2bView.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return V_GST_Sale_b2bView.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = V_GST_Sale_b2bView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

#End Region	

End Class
End Namespace
