Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="Tax_group_dtlsTable">ServelInvocing.Tax_group_dtlsTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="Tax_group_dtlsTable"></seealso>

Public Class Tax_group_dtlsDefinition

#Region "Definition (XML) for Tax_group_dtlsDefinition table"
	'Next 262 lines contain Table Definition (XML) for table "Tax_group_dtlsDefinition"
	Private Shared _DefinitionString As String = _
"<XMLDefinition Generator=""Iron Speed Designer"" Version=""7.0"" Type=""GENERIC"">"& _
  "<ColumnDefinition>"& _
    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">"& _
      "<columnName>id</columnName>"& _
      "<columnUIName>ID</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>int</columnDBType>"& _
      "<columnLengthSet>10.0</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>Y</columnIndex>"& _
      "<columnUnique>Y</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>Y</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>Y</columnComputed>"& _
      "<columnIdentity>Y</columnIdentity>"& _
      "<columnReadOnly>Y</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>Y</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">"& _
      "<columnName>id_tax_group</columnName>"& _
      "<columnUIName>ID Tax Group</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>int</columnDBType>"& _
      "<columnLengthSet>10.0</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<foreignKey>"& _
        "<columnFKName>tax_group_dtls_tax_groups_id_tax_group_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.Tax_groupsTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_group_code</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">"& _
      "<columnName>id_taxes</columnName>"& _
      "<columnUIName>ID Taxes</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>int</columnDBType>"& _
      "<columnLengthSet>10.0</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<foreignKey>"& _
        "<columnFKName>tax_group_dtls_taxes_id_taxes_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">"& _
      "<columnName>sort_order</columnName>"& _
      "<columnUIName>Sort Order</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>int</columnDBType>"& _
      "<columnLengthSet>10.0</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">"& _
      "<columnName>tax_code</columnName>"& _
      "<columnUIName>Tax Code</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>10</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">"& _
      "<columnName>tax_name</columnName>"& _
      "<columnUIName>Tax Name</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>30</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">"& _
      "<columnName>tax_print</columnName>"& _
      "<columnUIName>Tax Print</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>50</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">"& _
      "<columnName>tax_rate</columnName>"& _
      "<columnUIName>Tax Rate</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>10.3</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">"& _
      "<columnName>calc_type</columnName>"& _
      "<columnUIName>Calc Type</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">"& _
      "<columnName>tax_type</columnName>"& _
      "<columnUIName>Tax Type</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
  "</ColumnDefinition>"& _
  "<TableName>tax_group_dtls</TableName>"& _
  "<Version>3</Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>Tax_group_dtls</TableCodeName>"& _
  "<TableAliasName>Tax_group_dtls_</TableAliasName>"& _
  "<ConnectionName>Databaseservel-bill1</ConnectionName>"& _
  "<canCreateRecords Source=""Database"">Y</canCreateRecords>"& _
  "<canEditRecords Source=""Database"">Y</canEditRecords>"& _
  "<canDeleteRecords Source=""Database"">Y</canDeleteRecords>"& _
  "<canViewRecords Source=""Database"">Y</canViewRecords>"& _
  "<ConcurrencyMethod>BinaryChecksum</ConcurrencyMethod>"& _
  "<AppShortName>ServelInvocing</AppShortName>"& _
"</XMLDefinition>"
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="Tax_group_dtlsTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
