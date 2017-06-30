' This class is "generated" and will be overwritten.
' Your customizations should be made in CompanyRecord.vb

Imports System.Data.SqlTypes
Imports System.Data
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports ServelInvocing.Data

Namespace ServelInvocing.Business

''' <summary>
''' The generated superclass for the <see cref="CompanyTable"></see> class.
''' Provides access to the schema information and record data of a database table or view named company.
''' </summary>
''' <remarks>
''' The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
''' are resolved at runtime based on the connection string in the application's Web.Config file.
''' <para>
''' This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
''' <see cref="CompanyTable.Instance">CompanyTable.Instance</see>.
''' </para>
''' </remarks>
''' <seealso cref="CompanyTable"></seealso>

<Serializable()> Public Class BaseCompanyTable
    Inherits PrimaryKeyTable
    

    Private ReadOnly TableDefinitionString As String = CompanyDefinition.GetXMLString()







    Protected Sub New()
        MyBase.New()
        Me.Initialize()
    End Sub

    Protected Overridable Sub Initialize()
        Dim def As New XmlTableDefinition(TableDefinitionString)
        Me.TableDefinition = New TableDefinition()
        Me.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.CompanyTable")
        def.InitializeTableDefinition(Me.TableDefinition)
        Me.ConnectionName = def.GetConnectionName()
        Me.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("ServelInvocing.Business", "ServelInvocing.Business.CompanyRecord")
        Me.ApplicationName = "ServelInvocing"
        Me.DataAdapter = New CompanySqlTable()
        Directcast(Me.DataAdapter, CompanySqlTable).ConnectionName = Me.ConnectionName
        
        Me.TableDefinition.AdapterMetaData = Me.DataAdapter.AdapterMetaData
        id0Column.CodeName = "id0"
        nameColumn.CodeName = "name"
        addressColumn.CodeName = "address"
        cityColumn.CodeName = "city"
        pincodeColumn.CodeName = "pincode"
        stateColumn.CodeName = "state"
        phoneColumn.CodeName = "phone"
        emailColumn.CodeName = "email"
        pan_noColumn.CodeName = "pan_no"
        tin_noColumn.CodeName = "tin_no"
        eacColumn.CodeName = "eac"
        rangeColumn.CodeName = "range"
        divisionColumn.CodeName = "division"
        ecc_noColumn.CodeName = "ecc_no"
        cer_noColumn.CodeName = "cer_no"
        cer_codeColumn.CodeName = "cer_code"
        signColumn.CodeName = "sign"
        goodsColumn.CodeName = "goods"
        dutyColumn.CodeName = "duty"
        licenseColumn.CodeName = "license"
        fin_year_startColumn.CodeName = "fin_year_start"
        fin_year_endColumn.CodeName = "fin_year_end"
        inv_pfxColumn.CodeName = "inv_pfx"
        inv_sfxColumn.CodeName = "inv_sfx"
        next_inv_noColumn.CodeName = "next_inv_no"
        pad_inv_noColumn.CodeName = "pad_inv_no"
        inv_declarationColumn.CodeName = "inv_declaration"
        email_fromColumn.CodeName = "email_from"
        email_bccColumn.CodeName = "email_bcc"
        inv_email_bodyColumn.CodeName = "inv_email_body"
        proforma_email_bodyColumn.CodeName = "proforma_email_body"
        print_inv_copy_hdrColumn.CodeName = "print_inv_copy_hdr"
        tan_noColumn.CodeName = "tan_no"
        srv_tax_noColumn.CodeName = "srv_tax_no"
        inv_dt_fixedColumn.CodeName = "inv_dt_fixed"
        next_inv_dtColumn.CodeName = "next_inv_dt"
        gst_noColumn.CodeName = "gst_no"
        id_stateColumn.CodeName = "id_state"
        state_codeColumn.CodeName = "state_code"
        state_nameColumn.CodeName = "state_name"
        
    End Sub

#Region "Properties for columns"

    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.id column object.
    ''' </summary>
    Public ReadOnly Property id0Column() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(0), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.id column object.
    ''' </summary>
    Public Shared ReadOnly Property id0() As BaseClasses.Data.NumberColumn
        Get
            Return CompanyTable.Instance.id0Column
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.name column object.
    ''' </summary>
    Public ReadOnly Property nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(1), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.name column object.
    ''' </summary>
    Public Shared ReadOnly Property name() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.nameColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.address column object.
    ''' </summary>
    Public ReadOnly Property addressColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(2), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.address column object.
    ''' </summary>
    Public Shared ReadOnly Property address() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.addressColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.city column object.
    ''' </summary>
    Public ReadOnly Property cityColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(3), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.city column object.
    ''' </summary>
    Public Shared ReadOnly Property city() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.cityColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.pincode column object.
    ''' </summary>
    Public ReadOnly Property pincodeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(4), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.pincode column object.
    ''' </summary>
    Public Shared ReadOnly Property pincode() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.pincodeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.state column object.
    ''' </summary>
    Public ReadOnly Property stateColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(5), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.state column object.
    ''' </summary>
    Public Shared ReadOnly Property state() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.stateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.phone column object.
    ''' </summary>
    Public ReadOnly Property phoneColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(6), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.phone column object.
    ''' </summary>
    Public Shared ReadOnly Property phone() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.phoneColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.email column object.
    ''' </summary>
    Public ReadOnly Property emailColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(7), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.email column object.
    ''' </summary>
    Public Shared ReadOnly Property email() As BaseClasses.Data.EmailColumn
        Get
            Return CompanyTable.Instance.emailColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.pan_no column object.
    ''' </summary>
    Public ReadOnly Property pan_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(8), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.pan_no column object.
    ''' </summary>
    Public Shared ReadOnly Property pan_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.pan_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.tin_no column object.
    ''' </summary>
    Public ReadOnly Property tin_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(9), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.tin_no column object.
    ''' </summary>
    Public Shared ReadOnly Property tin_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.tin_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.eac column object.
    ''' </summary>
    Public ReadOnly Property eacColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(10), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.eac column object.
    ''' </summary>
    Public Shared ReadOnly Property eac() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.eacColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.range column object.
    ''' </summary>
    Public ReadOnly Property rangeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(11), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.range column object.
    ''' </summary>
    Public Shared ReadOnly Property range() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.rangeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.division column object.
    ''' </summary>
    Public ReadOnly Property divisionColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(12), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.division column object.
    ''' </summary>
    Public Shared ReadOnly Property division() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.divisionColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.ecc_no column object.
    ''' </summary>
    Public ReadOnly Property ecc_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(13), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.ecc_no column object.
    ''' </summary>
    Public Shared ReadOnly Property ecc_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.ecc_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.cer_no column object.
    ''' </summary>
    Public ReadOnly Property cer_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(14), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.cer_no column object.
    ''' </summary>
    Public Shared ReadOnly Property cer_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.cer_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.cer_code column object.
    ''' </summary>
    Public ReadOnly Property cer_codeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(15), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.cer_code column object.
    ''' </summary>
    Public Shared ReadOnly Property cer_code() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.cer_codeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.sign column object.
    ''' </summary>
    Public ReadOnly Property signColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(16), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.sign column object.
    ''' </summary>
    Public Shared ReadOnly Property sign() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.signColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.goods column object.
    ''' </summary>
    Public ReadOnly Property goodsColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(17), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.goods column object.
    ''' </summary>
    Public Shared ReadOnly Property goods() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.goodsColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.duty column object.
    ''' </summary>
    Public ReadOnly Property dutyColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(18), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.duty column object.
    ''' </summary>
    Public Shared ReadOnly Property duty() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.dutyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.license column object.
    ''' </summary>
    Public ReadOnly Property licenseColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(19), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.license column object.
    ''' </summary>
    Public Shared ReadOnly Property license() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.licenseColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.fin_year_start column object.
    ''' </summary>
    Public ReadOnly Property fin_year_startColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(20), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.fin_year_start column object.
    ''' </summary>
    Public Shared ReadOnly Property fin_year_start() As BaseClasses.Data.DateColumn
        Get
            Return CompanyTable.Instance.fin_year_startColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.fin_year_end column object.
    ''' </summary>
    Public ReadOnly Property fin_year_endColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(21), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.fin_year_end column object.
    ''' </summary>
    Public Shared ReadOnly Property fin_year_end() As BaseClasses.Data.DateColumn
        Get
            Return CompanyTable.Instance.fin_year_endColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_pfx column object.
    ''' </summary>
    Public ReadOnly Property inv_pfxColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(22), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_pfx column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_pfx() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.inv_pfxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_sfx column object.
    ''' </summary>
    Public ReadOnly Property inv_sfxColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(23), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_sfx column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_sfx() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.inv_sfxColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.next_inv_no column object.
    ''' </summary>
    Public ReadOnly Property next_inv_noColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(24), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.next_inv_no column object.
    ''' </summary>
    Public Shared ReadOnly Property next_inv_no() As BaseClasses.Data.NumberColumn
        Get
            Return CompanyTable.Instance.next_inv_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.pad_inv_no column object.
    ''' </summary>
    Public ReadOnly Property pad_inv_noColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(25), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.pad_inv_no column object.
    ''' </summary>
    Public Shared ReadOnly Property pad_inv_no() As BaseClasses.Data.NumberColumn
        Get
            Return CompanyTable.Instance.pad_inv_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_declaration column object.
    ''' </summary>
    Public ReadOnly Property inv_declarationColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(26), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_declaration column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_declaration() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.inv_declarationColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.email_from column object.
    ''' </summary>
    Public ReadOnly Property email_fromColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(27), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.email_from column object.
    ''' </summary>
    Public Shared ReadOnly Property email_from() As BaseClasses.Data.EmailColumn
        Get
            Return CompanyTable.Instance.email_fromColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.email_bcc column object.
    ''' </summary>
    Public ReadOnly Property email_bccColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(28), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.email_bcc column object.
    ''' </summary>
    Public Shared ReadOnly Property email_bcc() As BaseClasses.Data.EmailColumn
        Get
            Return CompanyTable.Instance.email_bccColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_email_body column object.
    ''' </summary>
    Public ReadOnly Property inv_email_bodyColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(29), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_email_body column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_email_body() As BaseClasses.Data.EmailColumn
        Get
            Return CompanyTable.Instance.inv_email_bodyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.proforma_email_body column object.
    ''' </summary>
    Public ReadOnly Property proforma_email_bodyColumn() As BaseClasses.Data.EmailColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(30), BaseClasses.Data.EmailColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.proforma_email_body column object.
    ''' </summary>
    Public Shared ReadOnly Property proforma_email_body() As BaseClasses.Data.EmailColumn
        Get
            Return CompanyTable.Instance.proforma_email_bodyColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.print_inv_copy_hdr column object.
    ''' </summary>
    Public ReadOnly Property print_inv_copy_hdrColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(31), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.print_inv_copy_hdr column object.
    ''' </summary>
    Public Shared ReadOnly Property print_inv_copy_hdr() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.print_inv_copy_hdrColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.tan_no column object.
    ''' </summary>
    Public ReadOnly Property tan_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(32), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.tan_no column object.
    ''' </summary>
    Public Shared ReadOnly Property tan_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.tan_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.srv_tax_no column object.
    ''' </summary>
    Public ReadOnly Property srv_tax_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(33), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.srv_tax_no column object.
    ''' </summary>
    Public Shared ReadOnly Property srv_tax_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.srv_tax_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_dt_fixed column object.
    ''' </summary>
    Public ReadOnly Property inv_dt_fixedColumn() As BaseClasses.Data.BooleanColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(34), BaseClasses.Data.BooleanColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.inv_dt_fixed column object.
    ''' </summary>
    Public Shared ReadOnly Property inv_dt_fixed() As BaseClasses.Data.BooleanColumn
        Get
            Return CompanyTable.Instance.inv_dt_fixedColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.next_inv_dt column object.
    ''' </summary>
    Public ReadOnly Property next_inv_dtColumn() As BaseClasses.Data.DateColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(35), BaseClasses.Data.DateColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.next_inv_dt column object.
    ''' </summary>
    Public Shared ReadOnly Property next_inv_dt() As BaseClasses.Data.DateColumn
        Get
            Return CompanyTable.Instance.next_inv_dtColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.gst_no column object.
    ''' </summary>
    Public ReadOnly Property gst_noColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(36), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.gst_no column object.
    ''' </summary>
    Public Shared ReadOnly Property gst_no() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.gst_noColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.id_state column object.
    ''' </summary>
    Public ReadOnly Property id_stateColumn() As BaseClasses.Data.NumberColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(37), BaseClasses.Data.NumberColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.id_state column object.
    ''' </summary>
    Public Shared ReadOnly Property id_state() As BaseClasses.Data.NumberColumn
        Get
            Return CompanyTable.Instance.id_stateColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.state_code column object.
    ''' </summary>
    Public ReadOnly Property state_codeColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(38), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.state_code column object.
    ''' </summary>
    Public Shared ReadOnly Property state_code() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.state_codeColumn
        End Get
    End Property
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.state_name column object.
    ''' </summary>
    Public ReadOnly Property state_nameColumn() As BaseClasses.Data.StringColumn
        Get
            Return CType(Me.TableDefinition.ColumnList(39), BaseClasses.Data.StringColumn)
        End Get
    End Property


    
    ''' <summary>
    ''' This is a convenience property that provides direct access to the table's Company_.state_name column object.
    ''' </summary>
    Public Shared ReadOnly Property state_name() As BaseClasses.Data.StringColumn
        Get
            Return CompanyTable.Instance.state_nameColumn
        End Get
    End Property


#End Region


#Region "Shared helper methods"

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CompanyRecord records using a where clause.
    ''' </summary>
    Public Shared Function GetRecords(ByVal where As String) As CompanyRecord()

        Return GetRecords(where, Nothing, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CompanyRecord records using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As CompanyRecord()

        Return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get an array of CompanyRecord records using a where and order by clause clause with pagination.
    ''' </summary>
    Public Shared Function GetRecords( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As CompanyRecord()
        
        Dim whereFilter As SqlFilter =  Nothing
        If Not where Is Nothing AndAlso where.trim() <> "" Then
            whereFilter =  New SqlFilter(where)
        End If
         
        Dim recList As ArrayList =  CompanyTable.Instance.GetRecordList(whereFilter, orderBy, pageIndex, pageSize)
 
        Return CType(recList.ToArray(GetType(ServelInvocing.Business.CompanyRecord)), CompanyRecord())
    End Function

    Public Shared Function GetRecords( _
     ByVal where As WhereClause, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As CompanyRecord()

        Dim recList As ArrayList = CompanyTable.Instance.GetRecordList(where.GetFilter(), orderBy, pageIndex, pageSize)

        Return CType(recList.ToArray(GetType(ServelInvocing.Business.CompanyRecord)), CompanyRecord())
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get total number of records that will be returned using the where clause.
    ''' </summary>
    Public Shared Function GetRecordCount(ByVal where As String) As Integer

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CInt(CompanyTable.Instance.GetRecordListCount(whereFilter, Nothing))
    End Function

    Public Shared Function GetRecordCount(ByVal where As WhereClause) As Integer
        Return CInt(CompanyTable.Instance.GetRecordListCount(where.GetFilter(), Nothing))
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a CompanyRecord record using a where clause.
    ''' </summary>
    Public Shared Function GetRecord(ByVal where As String) As CompanyRecord
        Dim orderBy As OrderBy = Nothing
        Return GetRecord(where, orderBy)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a CompanyRecord record using a where and order by clause.
    ''' </summary>
    Public Shared Function GetRecord( _
     ByVal where As String, _
     ByVal orderBy As OrderBy) As CompanyRecord

        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Dim recList As ArrayList = CompanyTable.Instance.GetRecordList(whereFilter, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE)

        Dim rec As CompanyRecord = Nothing
        If recList.Count > 0 Then
            rec = CType(recList(0), CompanyRecord)
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

        Return CompanyTable.Instance.GetColumnValues(retCol, where.GetFilter(), orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems)

    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String) As System.Data.DataTable

        Dim recs() As CompanyRecord = GetRecords(where)
        Return CompanyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    ''' </summary>
    Public Shared Function GetDataTable(ByVal where As String, ByVal orderBy As OrderBy) As System.Data.DataTable

        Dim recs() As CompanyRecord = GetRecords(where, orderBy)
        Return CompanyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    ''' </summary>
    Public Shared Function GetDataTable( _
     ByVal where As String, _
     ByVal orderBy As OrderBy, _
     ByVal pageIndex As Integer, _
     ByVal pageSize As Integer) As System.Data.DataTable

        Dim recs() As CompanyRecord = GetRecords(where, orderBy, pageIndex, pageSize)
        Return CompanyTable.Instance.CreateDataTable(recs, Nothing)
    End Function

    ''' <summary>
    ''' This is a shared function that can be used to delete records using a where clause.
    ''' </summary>
    Public Shared Sub DeleteRecords(ByVal where As String)
        If where = Nothing OrElse where.Trim() = "" Then
            Return
        End If

        Dim whereFilter As SqlFilter = New SqlFilter(where)
        CompanyTable.Instance.DeleteRecordList(whereFilter)
    End Sub

    ''' <summary>
    ''' This is a shared function that can be used to export records using a where clause.
    ''' </summary>
    Public Shared Function Export(ByVal where As String) As String
        Dim whereFilter As SqlFilter = Nothing
        If Not where Is Nothing AndAlso where.Trim() <> "" Then
            whereFilter = New SqlFilter(where)
        End If

        Return CompanyTable.Instance.ExportRecordData(whereFilter)
    End Function

    Public Shared Function Export(ByVal where As WhereClause) As String
        Dim whereFilter As BaseFilter = Nothing
        If Not where Is Nothing Then
            whereFilter = where.GetFilter()
        End If

        Return CompanyTable.Instance.ExportRecordData(whereFilter)
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

        Return CompanyTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

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

        Return CompanyTable.Instance.GetColumnStatistics(colSel, where.GetFilter(), orderBy, pageIndex, pageSize)

    End Function

    ''' <summary>
    '''  This method returns the columns in the table.
    ''' </summary>
    Public Shared Function GetColumns() As BaseColumn()
        Return CompanyTable.Instance.TableDefinition.Columns
    End Function

    ''' <summary>
    '''  This method returns the columnlist in the table.
    ''' </summary>  
    Public Shared Function GetColumnList() As ColumnList
        Return CompanyTable.Instance.TableDefinition.ColumnList
    End Function


    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    Public Shared Function CreateNewRecord() As IRecord
        Return CompanyTable.Instance.CreateRecord()
    End Function

    ''' <summary>
    ''' This method creates a new record and returns it to be edited.
    ''' </summary>
    ''' <param name="tempId">ID of the new record.</param>  
    Public Shared Function CreateNewRecord(ByVal tempId As String) As IRecord
        Return CompanyTable.Instance.CreateRecord(tempId)
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
        Dim column As BaseColumn = CompanyTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName)
        Return column
    End Function     

    ' Convenience method for getting a record using a string-based record identifier
    Public Shared Function GetRecord(ByVal id As String, ByVal bMutable As Boolean) As CompanyRecord
        Return CType(CompanyTable.Instance.GetRecordData(id, bMutable), CompanyRecord)
    End Function

    ' Convenience method for getting a record using a KeyValue record identifier
    Public Shared Function GetRecord(ByVal id As KeyValue, ByVal bMutable As Boolean) As CompanyRecord
        Return CType(CompanyTable.Instance.GetRecordData(id, bMutable), CompanyRecord)
    End Function

    ' Convenience method for creating a record
    Public Overloads Function NewRecord( _
        ByVal nameValue As String, _
        ByVal addressValue As String, _
        ByVal cityValue As String, _
        ByVal pincodeValue As String, _
        ByVal stateValue As String, _
        ByVal phoneValue As String, _
        ByVal emailValue As String, _
        ByVal pan_noValue As String, _
        ByVal tin_noValue As String, _
        ByVal eacValue As String, _
        ByVal rangeValue As String, _
        ByVal divisionValue As String, _
        ByVal ecc_noValue As String, _
        ByVal cer_noValue As String, _
        ByVal cer_codeValue As String, _
        ByVal signValue As String, _
        ByVal goodsValue As String, _
        ByVal dutyValue As String, _
        ByVal licenseValue As String, _
        ByVal fin_year_startValue As String, _
        ByVal fin_year_endValue As String, _
        ByVal inv_pfxValue As String, _
        ByVal inv_sfxValue As String, _
        ByVal next_inv_noValue As String, _
        ByVal pad_inv_noValue As String, _
        ByVal inv_declarationValue As String, _
        ByVal email_fromValue As String, _
        ByVal email_bccValue As String, _
        ByVal inv_email_bodyValue As String, _
        ByVal proforma_email_bodyValue As String, _
        ByVal print_inv_copy_hdrValue As String, _
        ByVal tan_noValue As String, _
        ByVal srv_tax_noValue As String, _
        ByVal inv_dt_fixedValue As String, _
        ByVal next_inv_dtValue As String, _
        ByVal gst_noValue As String, _
        ByVal id_stateValue As String, _
        ByVal state_codeValue As String, _
        ByVal state_nameValue As String _
    ) As KeyValue
        Dim rec As IPrimaryKeyRecord = CType(Me.CreateRecord(), IPrimaryKeyRecord)
                rec.SetString(nameValue, nameColumn)
        rec.SetString(addressValue, addressColumn)
        rec.SetString(cityValue, cityColumn)
        rec.SetString(pincodeValue, pincodeColumn)
        rec.SetString(stateValue, stateColumn)
        rec.SetString(phoneValue, phoneColumn)
        rec.SetString(emailValue, emailColumn)
        rec.SetString(pan_noValue, pan_noColumn)
        rec.SetString(tin_noValue, tin_noColumn)
        rec.SetString(eacValue, eacColumn)
        rec.SetString(rangeValue, rangeColumn)
        rec.SetString(divisionValue, divisionColumn)
        rec.SetString(ecc_noValue, ecc_noColumn)
        rec.SetString(cer_noValue, cer_noColumn)
        rec.SetString(cer_codeValue, cer_codeColumn)
        rec.SetString(signValue, signColumn)
        rec.SetString(goodsValue, goodsColumn)
        rec.SetString(dutyValue, dutyColumn)
        rec.SetString(licenseValue, licenseColumn)
        rec.SetString(fin_year_startValue, fin_year_startColumn)
        rec.SetString(fin_year_endValue, fin_year_endColumn)
        rec.SetString(inv_pfxValue, inv_pfxColumn)
        rec.SetString(inv_sfxValue, inv_sfxColumn)
        rec.SetString(next_inv_noValue, next_inv_noColumn)
        rec.SetString(pad_inv_noValue, pad_inv_noColumn)
        rec.SetString(inv_declarationValue, inv_declarationColumn)
        rec.SetString(email_fromValue, email_fromColumn)
        rec.SetString(email_bccValue, email_bccColumn)
        rec.SetString(inv_email_bodyValue, inv_email_bodyColumn)
        rec.SetString(proforma_email_bodyValue, proforma_email_bodyColumn)
        rec.SetString(print_inv_copy_hdrValue, print_inv_copy_hdrColumn)
        rec.SetString(tan_noValue, tan_noColumn)
        rec.SetString(srv_tax_noValue, srv_tax_noColumn)
        rec.SetString(inv_dt_fixedValue, inv_dt_fixedColumn)
        rec.SetString(next_inv_dtValue, next_inv_dtColumn)
        rec.SetString(gst_noValue, gst_noColumn)
        rec.SetString(id_stateValue, id_stateColumn)
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
        CompanyTable.Instance.DeleteOneRecord(kv)
    End Sub

    ''' <summary>
    ''' This method checks if record exist in the database using the keyvalue provided.
    ''' </summary>
    ''' <param name="kv">Key value of the record.</param>
    Public Shared Function DoesRecordExist(ByVal kv As KeyValue) As Boolean
        Dim recordExist As Boolean = True
        Try
            CompanyTable.GetRecord(kv, False)
        Catch ex As Exception
            recordExist = False
        End Try
        Return recordExist
    End Function
    
    ''' <summary>
    '''  This method returns all the primary columns in the table.
    ''' </summary>
    Public Shared Function GetPrimaryKeyColumns() As ColumnList
        If (Not IsNothing(CompanyTable.Instance.TableDefinition.PrimaryKey)) Then
            Return CompanyTable.Instance.TableDefinition.PrimaryKey.Columns
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

        If (Not (IsNothing(CompanyTable.Instance.TableDefinition.PrimaryKey))) Then

            Dim isCompositePrimaryKey As Boolean = False
            isCompositePrimaryKey = CompanyTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey

            If ((isCompositePrimaryKey) AndAlso (key.GetType.IsArray())) Then

                ' If the key is composite, then construct a key value.
                kv = New KeyValue
                Dim fullKeyString As String = ""
                Dim keyArray As Array = CType(key, Array)
                If (Not IsNothing(keyArray)) Then
                    Dim length As Integer = keyArray.Length
                    Dim pkColumns As ColumnList = CompanyTable.Instance.TableDefinition.PrimaryKey.Columns
                    Dim pkColumn As BaseColumn
                    Dim index As Integer = 0
                    For Each pkColumn In pkColumns
                        Dim keyString As String = CType(keyArray.GetValue(index), String)
                        If (CompanyTable.Instance.TableDefinition.TableType = BaseClasses.Data.TableDefinition.TableTypes.Virtual) Then
                            kv.AddElement(pkColumn.UniqueName, keyString)
                        Else
                            kv.AddElement(pkColumn.InternalName, keyString)
                        End If
                        index = index + 1
                    Next pkColumn
                End If

            Else
                ' If the key is not composite, then get the key value.
                kv = CompanyTable.Instance.TableDefinition.PrimaryKey.ParseValue(CType(key, String))
            End If
        End If
        Return kv
    End Function    


#End Region 

End Class
End Namespace
