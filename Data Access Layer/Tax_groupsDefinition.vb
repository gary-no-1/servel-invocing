Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="Tax_groupsTable">ServelInvocing.Tax_groupsTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="Tax_groupsTable"></seealso>

Public Class Tax_groupsDefinition

#Region "Definition (XML) for Tax_groupsDefinition table"
	'Next 364 lines contain Table Definition (XML) for table "Tax_groupsDefinition"
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
      "<columnName>tax_group_code</columnName>"& _
      "<columnUIName>Tax Group Code</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>50</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>Y</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction>upper</columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed>N</columnComputed>"& _
      "<columnIdentity>N</columnIdentity>"& _
      "<columnReadOnly>N</columnReadOnly>"& _
      "<columnRequired>Y</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""Database"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">"& _
      "<columnName>notes</columnName>"& _
      "<columnUIName>Notes</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>100</columnLengthSet>"& _
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
    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">"& _
      "<columnName>id_taxes_1</columnName>"& _
      "<columnUIName>Tax Code 1</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_1_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">"& _
      "<columnName>id_taxes_2</columnName>"& _
      "<columnUIName>Tax Code 2</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_2_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">"& _
      "<columnName>id_taxes_3</columnName>"& _
      "<columnUIName>Tax Code 3</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_3_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">"& _
      "<columnName>id_taxes_4</columnName>"& _
      "<columnUIName>Tax Code 4</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_4_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">"& _
      "<columnName>id_taxes_5</columnName>"& _
      "<columnUIName>Tax Code 5</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_5_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">"& _
      "<columnName>id_taxes_6</columnName>"& _
      "<columnUIName>Tax Code 6</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_6_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">"& _
      "<columnName>id_taxes_7</columnName>"& _
      "<columnUIName>Tax Code 7</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_7_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""10"" Priority=""11"" ColumnNum=""10"">"& _
      "<columnName>id_taxes_8</columnName>"& _
      "<columnUIName>Tax Code 8</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_8_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""11"" Priority=""12"" ColumnNum=""11"">"& _
      "<columnName>id_taxes_9</columnName>"& _
      "<columnUIName>Tax Code 9</columnUIName>"& _
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
        "<columnFKName>tax_groups_taxes_id_taxes_9_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.TaxesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>tax_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
  "</ColumnDefinition>"& _
  "<TableName>tax_groups</TableName>"& _
  "<Version>1</Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>Tax_groups</TableCodeName>"& _
  "<TableAliasName>Tax_groups_</TableAliasName>"& _
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
	''' <see cref="Tax_groupsTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
