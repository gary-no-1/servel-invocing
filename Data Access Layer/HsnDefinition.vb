﻿Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="HsnTable">ServelInvocing.HsnTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="HsnTable"></seealso>

Public Class HsnDefinition

#Region "Definition (XML) for HsnDefinition table"
	'Next 114 lines contain Table Definition (XML) for table "HsnDefinition"
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
      "<columnFunction>notrim</columnFunction>"& _
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
      "<columnName>hsn</columnName>"& _
      "<columnUIName Source=""User"">HSN</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>10</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>Y</columnIndex>"& _
      "<columnUnique>Y</columnUnique>"& _
      "<columnFunction>upper</columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>N</columnPK>"& _
      "<columnPermanent>N</columnPermanent>"& _
      "<columnComputed Source=""User"">N</columnComputed>"& _
      "<columnIdentity Source=""User"">N</columnIdentity>"& _
      "<columnReadOnly Source=""User"">N</columnReadOnly>"& _
      "<columnRequired>Y</columnRequired>"& _
      "<columnNotNull>Y</columnNotNull>"& _
      "<columnCaseSensitive Source=""User"">N</columnCaseSensitive>"& _
      "<columnVisibleWidth>%ISD_DEFAULT%</columnVisibleWidth>"& _
      "<columnTableAliasName></columnTableAliasName>"& _
      "<columnCodeName></columnCodeName>"& _
      "<InternalName>1</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
    "<Column InternalName=""2"" Priority=""3"" ColumnNum=""2"">"& _
      "<columnName>gst_description</columnName>"& _
      "<columnUIName>Description</columnUIName>"& _
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
    "<Column InternalName=""3"" Priority=""4"" ColumnNum=""3"">"& _
      "<columnName>gst_uom</columnName>"& _
      "<columnUIName Source=""User"">GST UOM</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>10</columnLengthSet>"& _
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
      "<InternalName>3</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
  "</ColumnDefinition>"& _
  "<TableName>hsn</TableName>"& _
  "<Version>1</Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>Hsn</TableCodeName>"& _
  "<TableAliasName>Hsn_</TableAliasName>"& _
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
	''' <see cref="HsnTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
