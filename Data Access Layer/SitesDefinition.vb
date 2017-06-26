Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="SitesTable">ServelInvocing.SitesTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="SitesTable"></seealso>

Public Class SitesDefinition

#Region "Definition (XML) for SitesDefinition table"
	'Next 458 lines contain Table Definition (XML) for table "SitesDefinition"
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
      "<columnName>id_party</columnName>"& _
      "<columnUIName>Party</columnUIName>"& _
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
        "<columnFKName>sites_party_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.PartyTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
    "</Column>"& _
    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">"& _
      "<columnName>party_code</columnName>"& _
      "<columnUIName>Party Code</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>char</columnDBType>"& _
      "<columnLengthSet>4</columnLengthSet>"& _
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
      "<columnName>name</columnName>"& _
      "<columnUIName>Name</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>50</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
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
    "<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">"& _
      "<columnName>address</columnName>"& _
      "<columnUIName>Address</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nvarchar</columnDBType>"& _
      "<columnLengthSet>160</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction>title</columnFunction>"& _
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
      "<columnName>city</columnName>"& _
      "<columnUIName>City</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>40</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction>upper</columnFunction>"& _
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
      "<columnName>contact</columnName>"& _
      "<columnUIName>Contact</columnUIName>"& _
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
      "<columnName>phone</columnName>"& _
      "<columnUIName>Phone</columnUIName>"& _
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
    "<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">"& _
      "<columnName>email</columnName>"& _
      "<columnUIName>Email</columnUIName>"& _
      "<columnType>Email</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>70</columnLengthSet>"& _
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
      "<columnName>vat_no</columnName>"& _
      "<columnUIName Source=""User"">VAT No.</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed Source=""User"">N</columnComputed>"& _
      "<columnIdentity Source=""User"">N</columnIdentity>"& _
      "<columnReadOnly Source=""User"">N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<columnCodeName></columnCodeName>"& _
      "<InternalName>9</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""10"" Priority=""11"" ColumnNum=""10"">"& _
      "<columnName>pan_no</columnName>"& _
      "<columnUIName Source=""Database"">PAN</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>10</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction>upper</columnFunction>"& _
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
    "<Column InternalName=""11"" Priority=""12"" ColumnNum=""11"">"& _
      "<columnName>ecc_no</columnName>"& _
      "<columnUIName Source=""Database"">ECC No:</columnUIName>"& _
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
    "<Column InternalName=""12"" Priority=""13"" ColumnNum=""12"">"& _
      "<columnName>st37_no</columnName>"& _
      "<columnUIName Source=""User"">ST37 No.</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed Source=""User"">N</columnComputed>"& _
      "<columnIdentity Source=""User"">N</columnIdentity>"& _
      "<columnReadOnly Source=""User"">N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<columnCodeName></columnCodeName>"& _
      "<InternalName>12</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""13"" Priority=""14"" ColumnNum=""13"">"& _
      "<columnName>tin_no</columnName>"& _
      "<columnUIName Source=""Database"">TIN</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction>upper</columnFunction>"& _
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
    "<Column InternalName=""14"" Priority=""15"" ColumnNum=""14"">"& _
      "<columnName>gst_no</columnName>"& _
      "<columnUIName Source=""User"">GST No.</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed Source=""User"">N</columnComputed>"& _
      "<columnIdentity Source=""User"">N</columnIdentity>"& _
      "<columnReadOnly Source=""User"">N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<columnCodeName></columnCodeName>"& _
      "<InternalName>14</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""15"" Priority=""16"" ColumnNum=""15"">"& _
      "<columnName>id_states</columnName>"& _
      "<columnUIName Source=""User"">State</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>int</columnDBType>"& _
      "<columnLengthSet>10.0</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed Source=""User"">N</columnComputed>"& _
      "<columnIdentity Source=""User"">N</columnIdentity>"& _
      "<columnReadOnly Source=""User"">N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<foreignKey>"& _
        "<columnFKName>sites_states_FK</columnFKName>"& _
        "<columnFKTable>ServelInvocing.Business.StatesTable, ServelInvocing.Business</columnFKTable>"& _
        "<columnFKOwner>dbo</columnFKOwner>"& _
        "<columnFKColumn>id</columnFKColumn>"& _
        "<columnFKColumnDisplay>state_name</columnFKColumnDisplay>"& _
        "<foreignKeyType>Explicit</foreignKeyType>"& _
      "</foreignKey>"& _
      "<columnCodeName></columnCodeName>"& _
      "<InternalName>15</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""16"" Priority=""17"" ColumnNum=""16"">"& _
      "<columnName>state_code</columnName>"& _
      "<columnUIName>State Code</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>2</columnLengthSet>"& _
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
    "<Column InternalName=""17"" Priority=""18"" ColumnNum=""17"">"& _
      "<columnName>state_name</columnName>"& _
      "<columnUIName>State Name</columnUIName>"& _
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
  "</ColumnDefinition>"& _
  "<TableName>sites</TableName>"& _
  "<Version>3</Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>Sites</TableCodeName>"& _
  "<TableAliasName>Sites_</TableAliasName>"& _
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
	''' <see cref="SitesTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
