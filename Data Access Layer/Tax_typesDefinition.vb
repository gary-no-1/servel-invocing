Namespace ServelInvocing.Business
''' <summary>
''' Contains embedded schema and configuration data that is used by the 
''' <see cref="Tax_typesTable">ServelInvocing.Tax_typesTable</see> class
''' to initialize the class's TableDefinition.
''' </summary>
''' <seealso cref="Tax_typesTable"></seealso>

Public Class Tax_typesDefinition

#Region "Definition (XML) for Tax_typesDefinition table"
	'Next 42 lines contain Table Definition (XML) for table "Tax_typesDefinition"
	Private Shared _DefinitionString As String = _
"<XMLDefinition Generator=""Iron Speed Designer"" Version=""7.0"" Type=""GENERIC"">"& _
  "<ColumnDefinition>"& _
    "<Column InternalName=""0"" Priority=""1"" ColumnNum=""0"">"& _
      "<columnName>tax_type</columnName>"& _
      "<columnUIName Source=""User"">Tax Type</columnUIName>"& _
      "<columnType>String</columnType>"& _
      "<columnDBType>nchar</columnDBType>"& _
      "<columnLengthSet>20</columnLengthSet>"& _
      "<columnDefault></columnDefault>"& _
      "<columnDBDefault Source=""User""></columnDBDefault>"& _
      "<columnIndex>Y</columnIndex>"& _
      "<columnUnique>Y</columnUnique>"& _
      "<columnFunction>notrim,upper</columnFunction>"& _
      "<columnDBFormat></columnDBFormat>"& _
      "<columnPK>Y</columnPK>"& _
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
      "<InternalName>0</InternalName>"& _
      "<columnTableClassName></columnTableClassName>"& _
    "</Column>"& _
  "</ColumnDefinition>"& _
  "<TableName>tax_types</TableName>"& _
  "<Version></Version>"& _
  "<Owner>dbo</Owner>"& _
  "<TableCodeName>Tax_types</TableCodeName>"& _
  "<TableAliasName>Tax_types_</TableAliasName>"& _
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
	''' <see cref="Tax_typesTable"></see>
	''' class's TableDefinition.
	''' </summary>
	''' <remarks>This function is only called once at runtime.</remarks>
	''' <returns>An XML string.</returns>
	Public Shared Function GetXMLString() As String
		Return _DefinitionString
	End Function

End Class
End Namespace
