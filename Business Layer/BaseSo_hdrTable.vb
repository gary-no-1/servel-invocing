﻿' This class is "generated" and will be overwritten.
' Your customizations should be made in So_hdrRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="So_hdrTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named so_hdr.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="So_hdrTable.Instance">So_hdrTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="So_hdrTable"></seealso>

<Serializable()> Public Class BaseSo_hdrTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = So_hdrDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.So_hdrTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.So_hdrRecord")
        Me.ApplicationName = "ServelInvocing"
        Me.DataAdapter = New So_hdrSqlTable()
        Directcast(Me.DataAdapter, So_hdrSqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        id0Column.CodeName = "id0"
        sale_ord_noColumn.CodeName = "sale_ord_no"
        sale_ord_dtColumn.CodeName = "sale_ord_dt"
        id_partyColumn.CodeName = "id_party"
        bill_nameColumn.CodeName = "bill_name"
        bill_addressColumn.CodeName = "bill_address"
        id_siteColumn.CodeName = "id_site"
        ship_nameColumn.CodeName = "ship_name"
        ship_addressColumn.CodeName = "ship_address"
        tin_noColumn.CodeName = "tin_no"
        po_noColumn.CodeName = "po_no"
        po_dtColumn.CodeName = "po_dt"
        ecc_noColumn.CodeName = "ecc_no"
        id_commodityColumn.CodeName = "id_commodity"
        id_tax_groupColumn.CodeName = "id_tax_group"
        item_totalColumn.CodeName = "item_total"
        grand_totalColumn.CodeName = "grand_total"
        inv_cr8_dtColumn.CodeName = "inv_cr8_dt"
        inv_createdColumn.CodeName = "inv_created"
        emailColumn.CodeName = "email"
        additional_emailColumn.CodeName = "additional_email"
        contactColumn.CodeName = "contact"
        phoneColumn.CodeName = "phone"
        remarkColumn.CodeName = "remark"
        excise_remarkColumn.CodeName = "excise_remark"
        id_create_userColumn.CodeName = "id_create_user"
        created_onColumn.CodeName = "created_on"
        id_update_userColumn.CodeName = "id_update_user"
        last_updatedColumn.CodeName = "last_updated"
        
    End Sub

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id column object.
    ''' </summary>
    Public ReadOnly Property id0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id column object.
    ''' </summary>
    Public Shared ReadOnly Property id0() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.sale_ord_no column object.
    ''' </summary>
    Public ReadOnly Property sale_ord_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.sale_ord_no column object.
    ''' </summary>
    Public Shared ReadOnly Property sale_ord_no() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.sale_ord_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.sale_ord_dt column object.
    ''' </summary>
    Public ReadOnly Property sale_ord_dtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.sale_ord_dt column object.
    ''' </summary>
    Public Shared ReadOnly Property sale_ord_dt() As BaseClasses.Data.DateColumn
        Get
            Return So_hdrTable.Instance.sale_ord_dtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_party column object.
    ''' </summary>
    Public ReadOnly Property id_partyColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_party column object.
    ''' </summary>
    Public Shared ReadOnly Property id_party() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id_partyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.bill_name column object.
    ''' </summary>
    Public ReadOnly Property bill_nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.bill_name column object.
    ''' </summary>
    Public Shared ReadOnly Property bill_name() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.bill_nameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.bill_address column object.
    ''' </summary>
    Public ReadOnly Property bill_addressColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.bill_address column object.
    ''' </summary>
    Public Shared ReadOnly Property bill_address() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.bill_addressColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_site column object.
    ''' </summary>
    Public ReadOnly Property id_siteColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_site column object.
    ''' </summary>
    Public Shared ReadOnly Property id_site() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id_siteColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.ship_name column object.
    ''' </summary>
    Public ReadOnly Property ship_nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.ship_name column object.
    ''' </summary>
    Public Shared ReadOnly Property ship_name() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.ship_nameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.ship_address column object.
    ''' </summary>
    Public ReadOnly Property ship_addressColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.ship_address column object.
    ''' </summary>
    Public Shared ReadOnly Property ship_address() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.ship_addressColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.tin_no column object.
    ''' </summary>
    Public ReadOnly Property tin_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.tin_no column object.
    ''' </summary>
    Public Shared ReadOnly Property tin_no() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.tin_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.po_no column object.
    ''' </summary>
    Public ReadOnly Property po_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.po_no column object.
    ''' </summary>
    Public Shared ReadOnly Property po_no() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.po_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.po_dt column object.
    ''' </summary>
    Public ReadOnly Property po_dtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.po_dt column object.
    ''' </summary>
    Public Shared ReadOnly Property po_dt() As BaseClasses.Data.DateColumn
        Get
            Return So_hdrTable.Instance.po_dtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.ecc_no column object.
    ''' </summary>
    Public ReadOnly Property ecc_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.ecc_no column object.
    ''' </summary>
    Public Shared ReadOnly Property ecc_no() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.ecc_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_commodity column object.
    ''' </summary>
    Public ReadOnly Property id_commodityColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_commodity column object.
    ''' </summary>
    Public Shared ReadOnly Property id_commodity() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id_commodityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_tax_group column object.
    ''' </summary>
    Public ReadOnly Property id_tax_groupColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_tax_group column object.
    ''' </summary>
    Public Shared ReadOnly Property id_tax_group() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id_tax_groupColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.item_total column object.
    ''' </summary>
    Public ReadOnly Property item_totalColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.item_total column object.
    ''' </summary>
    Public Shared ReadOnly Property item_total() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.item_totalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.grand_total column object.
    ''' </summary>
    Public ReadOnly Property grand_totalColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.grand_total column object.
    ''' </summary>
    Public Shared ReadOnly Property grand_total() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.grand_totalColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.inv_cr8_dt column object.
    ''' </summary>
    Public ReadOnly Property inv_cr8_dtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.inv_cr8_dt column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_cr8_dt() As BaseClasses.Data.DateColumn
        Get
            Return So_hdrTable.Instance.inv_cr8_dtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.inv_created column object.
    ''' </summary>
    Public ReadOnly Property inv_createdColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.inv_created column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_created() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.inv_createdColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.email column object.
    ''' </summary>
    Public ReadOnly Property emailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.email column object.
    ''' </summary>
    Public Shared ReadOnly Property email() As BaseClasses.Data.EmailColumn
        Get
            Return So_hdrTable.Instance.emailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.additional_email column object.
    ''' </summary>
    Public ReadOnly Property additional_emailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.additional_email column object.
    ''' </summary>
    Public Shared ReadOnly Property additional_email() As BaseClasses.Data.EmailColumn
        Get
            Return So_hdrTable.Instance.additional_emailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.contact column object.
    ''' </summary>
    Public ReadOnly Property contactColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.contact column object.
    ''' </summary>
    Public Shared ReadOnly Property contact() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.contactColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.phone column object.
    ''' </summary>
    Public ReadOnly Property phoneColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.phone column object.
    ''' </summary>
    Public Shared ReadOnly Property phone() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.phoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.remark column object.
    ''' </summary>
    Public ReadOnly Property remarkColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.remark column object.
    ''' </summary>
    Public Shared ReadOnly Property remark() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.remarkColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.excise_remark column object.
    ''' </summary>
    Public ReadOnly Property excise_remarkColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.excise_remark column object.
    ''' </summary>
    Public Shared ReadOnly Property excise_remark() As BaseClasses.Data.StringColumn
        Get
            Return So_hdrTable.Instance.excise_remarkColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_create_user column object.
    ''' </summary>
    Public ReadOnly Property id_create_userColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_create_user column object.
    ''' </summary>
    Public Shared ReadOnly Property id_create_user() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id_create_userColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.created_on column object.
    ''' </summary>
    Public ReadOnly Property created_onColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.created_on column object.
    ''' </summary>
    Public Shared ReadOnly Property created_on() As BaseClasses.Data.DateColumn
        Get
            Return So_hdrTable.Instance.created_onColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_update_user column object.
    ''' </summary>
    Public ReadOnly Property id_update_userColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.id_update_user column object.
    ''' </summary>
    Public Shared ReadOnly Property id_update_user() As BaseClasses.Data.NumberColumn
        Get
            Return So_hdrTable.Instance.id_update_userColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.last_updated column object.
    ''' </summary>
    Public ReadOnly Property last_updatedColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's So_hdr_.last_updated column object.
    ''' </summary>
    Public Shared ReadOnly Property last_updated() As BaseClasses.Data.DateColumn
        Get
            Return So_hdrTable.Instance.last_updatedColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of So_hdrRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As So_hdrRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of So_hdrRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As So_hdrRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of So_hdrRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As So_hdrRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  So_hdrTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.So_hdrRecord)), So_hdrRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As So_hdrRecord()

        Dim recList As ArrayList = So_hdrTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.So_hdrRecord)), So_hdrRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(So_hdrTable.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(So_hdrTable.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a So_hdrRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As So_hdrRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a So_hdrRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As So_hdrRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = So_hdrTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As So_hdrRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), So_hdrRecord)
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

        Return So_hdrTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As So_hdrRecord = GetRecords(where)
        Return So_hdrTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As So_hdrRecord = GetRecords(where, orderBy)
        Return So_hdrTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As So_hdrRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return So_hdrTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        So_hdrTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return So_hdrTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return So_hdrTable.Instance.ExportRecordData(whereFilter)
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

        Return So_hdrTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

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

        Return So_hdrTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return So_hdrTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return So_hdrTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return So_hdrTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return So_hdrTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = So_hdrTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As So_hdrRecord
        Return CType(So_hdrTable.Instance.GetRecordData(id, bMutable), So_hdrRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As So_hdrRecord
        Return CType(So_hdrTable.Instance.GetRecordData(id, bMutable), So_hdrRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal sale_ord_noValue As String, _
        ByVal sale_ord_dtValue As String, _
        ByVal id_partyValue As String, _
        ByVal bill_nameValue As String, _
        ByVal bill_addressValue As String, _
        ByVal id_siteValue As String, _
        ByVal ship_nameValue As String, _
        ByVal ship_addressValue As String, _
        ByVal tin_noValue As String, _
        ByVal po_noValue As String, _
        ByVal po_dtValue As String, _
        ByVal ecc_noValue As String, _
        ByVal id_commodityValue As String, _
        ByVal id_tax_groupValue As String, _
        ByVal item_totalValue As String, _
        ByVal grand_totalValue As String, _
        ByVal inv_cr8_dtValue As String, _
        ByVal inv_createdValue As String, _
        ByVal emailValue As String, _
        ByVal additional_emailValue As String, _
        ByVal contactValue As String, _
        ByVal phoneValue As String, _
        ByVal remarkValue As String, _
        ByVal excise_remarkValue As String, _
        ByVal id_create_userValue As String, _
        ByVal created_onValue As String, _
        ByVal id_update_userValue As String, _
        ByVal last_updatedValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(sale_ord_noValue, sale_ord_noColumn)
        rec.SetString(sale_ord_dtValue, sale_ord_dtColumn)
        rec.SetString(id_partyValue, id_partyColumn)
        rec.SetString(bill_nameValue, bill_nameColumn)
        rec.SetString(bill_addressValue, bill_addressColumn)
        rec.SetString(id_siteValue, id_siteColumn)
        rec.SetString(ship_nameValue, ship_nameColumn)
        rec.SetString(ship_addressValue, ship_addressColumn)
        rec.SetString(tin_noValue, tin_noColumn)
        rec.SetString(po_noValue, po_noColumn)
        rec.SetString(po_dtValue, po_dtColumn)
        rec.SetString(ecc_noValue, ecc_noColumn)
        rec.SetString(id_commodityValue, id_commodityColumn)
        rec.SetString(id_tax_groupValue, id_tax_groupColumn)
        rec.SetString(item_totalValue, item_totalColumn)
        rec.SetString(grand_totalValue, grand_totalColumn)
        rec.SetString(inv_cr8_dtValue, inv_cr8_dtColumn)
        rec.SetString(inv_createdValue, inv_createdColumn)
        rec.SetString(emailValue, emailColumn)
        rec.SetString(additional_emailValue, additional_emailColumn)
        rec.SetString(contactValue, contactColumn)
        rec.SetString(phoneValue, phoneColumn)
        rec.SetString(remarkValue, remarkColumn)
        rec.SetString(excise_remarkValue, excise_remarkColumn)
        rec.SetString(id_create_userValue, id_create_userColumn)
        rec.SetString(created_onValue, created_onColumn)
        rec.SetString(id_update_userValue, id_update_userColumn)
        rec.SetString(last_updatedValue, last_updatedColumn)


        rec.Create() 'update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

        Dim key As KeyValue = rec.GetID()
        Return key
    End Function

    ''' <summary>
    '''  This method deletes a specified record
    ''' </summary>
    ''' <param name="kv">Keyvalue of the record to be deleted.</param>
    Public Shared Sub DeleteRecord(ByVal kv As KeyValue)
        So_hdrTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            So_hdrTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(So_hdrTable.Instance.TableDefinition.PrimaryKey)) Then
            Return So_hdrTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(So_hdrTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = So_hdrTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = So_hdrTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (So_hdrTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = So_hdrTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


#End Region 

End Class
End Namespace
