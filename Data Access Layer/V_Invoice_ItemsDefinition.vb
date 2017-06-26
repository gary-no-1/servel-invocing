Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="V_Invoice_ItemsView">ServelInvocing.V_Invoice_ItemsView</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="V_Invoice_ItemsView"></seealso>

Public Class V_Invoice_ItemsDefinition

#Region "Definition (XML) for V_Invoice_ItemsDefinition table"
	'Next 298 lines contain Table Definition (XML) for table "V_Invoice_ItemsDefinition"
	Private Shared _DefinitionString As String = _
"<XMLDefinition Generator=""Iron Speed Designer"" Version=""7.0"" Type=""VIEW"">"& _
  "<ColumnDefinition>"& _
    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">"& _
      "<columnName>inv_dt</columnName>"& _
      "<columnUIName Source=""User"">Invoice Date</columnUIName>"& _
      "<columnType>Date</columnType>"& _
      "<columnDBType>date</columnDBType>"& _
      "<columnLengthSet></columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>N</columnIndex>"& _
      "<columnUnique>N</columnUnique>"& _
      "<columnFunction></columnFunction>"& _
      "<columnFormat Source=""User"">d</columnFormat>"& _
      "<columnDBFormat>d</columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed Source=""User"">N</columnComputed>"& _
      "<columnIdentity Source=""User"">N</columnIdentity>"& _
      "<columnReadOnly Source=""User"">N</columnReadOnly>"& _
      "<columnRequired>N</columnRequired>"& _
      "<columnNotNull>N</columnNotNull>"& _
      "<columnCaseSensitive Source=""User"">Y</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<columnCodeName></columnCodeName>"& _
      "<InternalName>0</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">"& _
      "<columnName>inv_no</columnName>"& _
      "<columnUIName Source=""User"">Invoice Number</columnUIName>"& _
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
      "<InternalName>1</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">"& _
      "<columnName>item_code</columnName>"& _
      "<columnUIName>Item Code</columnUIName>"& _
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
    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">"& _
      "<columnName>item_description</columnName>"& _
      "<columnUIName>Item Description</columnUIName>"& _
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
    "<Column InternalName=""4"" Priority=""5"" ColumnNum=""4"">"& _
      "<columnName>name</columnName>"& _
      "<columnUIName>Name</columnUIName>"& _
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
    "<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">"& _
      "<columnName>item_group</columnName>"& _
      "<columnUIName>Item Group</columnUIName>"& _
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
      "<columnName>uom</columnName>"& _
      "<columnUIName>Uom</columnUIName>"& _
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
    "<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">"& _
      "<columnName>qty</columnName>"& _
      "<columnUIName>Quantity</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>18.3</columnLengthSet>"& _
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
      "<columnName>rate</columnName>"& _
      "<columnUIName>Rate</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>18.3</columnLengthSet>"& _
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
    "<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">"& _
      "<columnName>amount</columnName>"& _
      "<columnUIName>Amount</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>18.2</columnLengthSet>"& _
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
    "<Column InternalName=""10"" Priority=""11"" ColumnNum=""10"">"& _
      "<columnName>id</columnName>"& _
      "<columnUIName>ID</columnUIName>"& _
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
      "<columnRequired>Y</columnRequired>"& _
      "<columnNotNull>Y</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
    "<Column InternalName=""11"" Priority=""12"" ColumnNum=""11"">"& _
      "<columnName>id2</columnName>"& _
      "<columnUIName>ID 2</columnUIName>"& _
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
      "<columnRequired>Y</columnRequired>"& _
      "<columnNotNull>Y</columnNotNull>"& _
      "<columnCaseSensitive>N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
    "</Column>"& _
  "</ColumnDefinition>"& _
  "<TableName>V_Invoice_Items</TableName>"& _
  "<Version>2</Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>V_Invoice_Items</TableCodeName>"& _
  "<TableAliasName>V_Invoice_Items_</TableAliasName>"& _
  "<ConnectionName>Databaseservel-bill1</ConnectionName>"& _
  "<canCreateRecords Source=""Database"">N</canCreateRecords>"& _
  "<canEditRecords Source=""Database"">N</canEditRecords>"& _
  "<canDeleteRecords Source=""Database"">N</canDeleteRecords>"& _
  "<canViewRecords Source=""Database"">N</canViewRecords>"& _
  "<AppShortName>ServelInvocing</AppShortName>"& _
"</XMLDefinition>"
#End Region
	
	''' <summary>
	''' Gets the embedded schema and configuration data for the  
	''' <see cref="V_Invoice_ItemsView"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
