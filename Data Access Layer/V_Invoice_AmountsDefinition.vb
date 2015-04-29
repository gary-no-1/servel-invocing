Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="V_Invoice_AmountsView">ServelInvocing.V_Invoice_AmountsView</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="V_Invoice_AmountsView"></seealso>

Public Class V_Invoice_AmountsDefinition

#Region "Definition (XML) for V_Invoice_AmountsDefinition table"
	'Next 307 lines contain Table Definition (XML) for table "V_Invoice_AmountsDefinition"
	Private Shared _DefinitionString As String = _
"<XMLDefinition Generator=""Iron Speed Designer"" Version=""7.0"" Type=""VIEW"">"& _
  "<ColumnDefinition>"& _
    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">"& _
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
    "<Column InternalName=""1"" Priority=""2"" ColumnNum=""1"">"& _
      "<columnName>inv_no</columnName>"& _
      "<columnUIName Source=""User"">Invoice No:</columnUIName>"& _
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
      "<InternalName>2</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">"& _
      "<columnName>id_party</columnName>"& _
      "<columnUIName>ID Party</columnUIName>"& _
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
      "<columnName>item_total</columnName>"& _
      "<columnUIName>Item Total</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
    "<Column InternalName=""5"" Priority=""6"" ColumnNum=""5"">"& _
      "<columnName>excise_amt</columnName>"& _
      "<columnUIName>Excise Amount</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
    "<Column InternalName=""6"" Priority=""7"" ColumnNum=""6"">"& _
      "<columnName>vat_amt</columnName>"& _
      "<columnUIName>VAT Amount</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
    "<Column InternalName=""7"" Priority=""8"" ColumnNum=""7"">"& _
      "<columnName>cst_amt</columnName>"& _
      "<columnUIName Source=""User"">CST Amount</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
      "<InternalName>7</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""8"" Priority=""9"" ColumnNum=""8"">"& _
      "<columnName>srv_tax</columnName>"& _
      "<columnUIName Source=""User"">Service Tax</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
      "<InternalName>8</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""9"" Priority=""10"" ColumnNum=""9"">"& _
      "<columnName>oth_amt</columnName>"& _
      "<columnUIName Source=""User"">Other Amount</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
      "<columnName>grand_total</columnName>"& _
      "<columnUIName>Grand Total</columnUIName>"& _
      "<columnType>Number</columnType>"& _
      "<columnDBType>decimal</columnDBType>"& _
      "<columnLengthSet>38.2</columnLengthSet>"& _
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
    "<Column InternalName=""11"" Priority=""12"" ColumnNum=""11"">"& _
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
  "</ColumnDefinition>"& _
  "<TableName>V_Invoice_Amounts</TableName>"& _
  "<Version>1</Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>V_Invoice_Amounts</TableCodeName>"& _
  "<TableAliasName>V_Invoice_Amounts_</TableAliasName>"& _
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
	''' <see cref="V_Invoice_AmountsView"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
