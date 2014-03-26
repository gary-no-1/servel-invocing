Imports Microsoft.VisualBasic
Imports System.IO
Imports BaseClasses.Data
Imports CarlosAg.ExcelXmlWriter

Namespace ServelInvocing

    ''' <summary>
    ''' Base class to export data to CSV or Excel
    ''' </summary>
    Public MustInherit Class ExportDataBaseClass
#Region "Properties"
        Protected pageSize As Integer = 5000

        Protected _headerString As String
        Protected Property HeaderString() As String
            Get
                Return _headerString
            End Get
            Set(ByVal value As String)
                _headerString = value
            End Set
        End Property

        Protected MustOverride ReadOnly Property Title() As String
#End Region

#Region "Constructor"
        Protected Sub New()
            HeaderString = Nothing
        End Sub

        Protected Sub New(ByVal header As String)
            HeaderString = header
        End Sub
#End Region

#Region "Public Methods"

        ''' <summary>
        ''' Sets responce - clears header, sets header and cache
        ''' </summary>
        ''' <param name="response"> System.Web.HttpResponse to write file to. 
        ''' You can pass Page.Response property as a parameter to this function. 
        ''' </param>
        ''' <param name="fileName"> file name</param>
        ''' <remarks></remarks>
        Public Sub SetupResponse(ByVal response As System.Web.HttpResponse, ByVal fileName As String)
            response.ClearHeaders()
            response.Clear()
            response.Cache.SetCacheability(HttpCacheability.Private)
            response.Cache.SetMaxAge(New TimeSpan(0))
            response.Cache.SetExpires(New DateTime(0))
            response.Cache.SetNoServerCaching()
            response.ContentType = "text/plain"
            response.AppendHeader("Content-Disposition", "attachment; filename=""" & fileName & """")
        End Sub

        Public MustOverride Sub Export(ByVal response As System.Web.HttpResponse)
#End Region
    End Class

    ''' <summary>
    ''' The ExportToCSVBaseClass class provides common functionality used for exports to CSV file
    ''' and sends the file to the response stream.
    ''' </summary>
    Public MustInherit Class ExportToCSVBaseClass
        Inherits ExportDataBaseClass
#Region "Properties"

        Private _writer As StreamWriter
        Private Property Writer() As StreamWriter
            Get
                Return _writer
            End Get
            Set(ByVal value As StreamWriter)
                _writer = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Protected Sub New()
            MyBase.New()
        End Sub


        Protected Sub New(ByVal header As String)
            MyBase.New(header)
        End Sub
#End Region

#Region "Private Methods"

        Protected Overridable Function WriteColumnHeader() As Boolean
            ' If the DisplayString is not null then, write the contents of DisplayString as column headers
            If HeaderString IsNot Nothing AndAlso Not (HeaderString = "") Then
                Writer.Write(HeaderString.Replace("""", """"""))
                Return True
            End If

            Return False
        End Function

        Protected separator As String = System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ListSeparator

        Protected Sub WriteColumnTitle(ByVal val As String)
            Writer.Write("""" & val.Replace("""", """""") & """" & separator)
        End Sub
        Friend Sub WriteColumnData(ByVal val As String, ByVal isString As Boolean)
            ' If the value contains a separator, enclose the text in quotes.
            If val IsNot Nothing AndAlso (isString Or val.Contains(separator)) Then
                Writer.Write("""" & val.Replace("""", """""") & """")
            Else
                Writer.Write(val)
            End If

            Writer.Write(separator)
        End Sub


        Friend Sub WriteNewRow()
            Writer.WriteLine()
        End Sub
#End Region

#Region "Public Methods"
        Public Sub StartExport(ByVal response As System.Web.HttpResponse)
            If response Is Nothing Then
                Return
            End If

            Dim fileName As String = Title + ".csv"
            SetupResponse(response, fileName)
            response.ContentType = "text/plain"

            Writer = New StreamWriter(response.OutputStream, System.Text.Encoding.UTF8)

            'First write out the Column Headers
            WriteColumnHeader()

            Writer.WriteLine()
        End Sub

        Public Sub FinishExport(ByVal response As System.Web.HttpResponse)
            Writer.Flush()

            ' Need to call Response.End() so nothing will be attached to a file
            ' System.Web.HttpResponse.End() function will throw System.Threading.ThreadAbortException
            ' indicating that the current response ends prematurely - that's what we want
            response.End()
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' The ExportToExcelBaseClass provides common functionality 
    ''' used for exports to Excel and sends the XLS file to the response stream.
    ''' </summary>
    Public MustInherit Class ExportToExcelBaseClass
        Inherits ExportDataBaseClass
#Region "Properties"

        Private _excelBook As CarlosAg.ExcelXmlWriter.Workbook
        Private Property ExcelBook() As CarlosAg.ExcelXmlWriter.Workbook
            Get
                Return _excelBook
            End Get
            Set(ByVal value As CarlosAg.ExcelXmlWriter.Workbook)
                _excelBook = value
            End Set
        End Property


        Private _excelSheet As CarlosAg.ExcelXmlWriter.Worksheet
        Private Property ExcelSheet() As CarlosAg.ExcelXmlWriter.Worksheet
            Get
                Return _excelSheet
            End Get
            Set(ByVal value As CarlosAg.ExcelXmlWriter.Worksheet)
                _excelSheet = value
            End Set
        End Property

        Private _excelRow As CarlosAg.ExcelXmlWriter.WorksheetRow
        Private Property ExcelRow() As CarlosAg.ExcelXmlWriter.WorksheetRow
            Get
                Return _excelRow
            End Get
            Set(ByVal value As CarlosAg.ExcelXmlWriter.WorksheetRow)
                _excelRow = value
            End Set
        End Property
#End Region

#Region "Constructor"
        Protected Sub New()
            MyBase.New()
        End Sub

        Protected Sub New(ByVal header As String)
            MyBase.New(header)
        End Sub

#End Region

#Region "Protected Methods"
        ''' <summary>
        ''' Add column to excel book, creates style for that column and set's format. 
        ''' Before call to this function empty row needs to be added.
        ''' </summary>
        ''' <param name="column">column number</param>
        ''' <param name="caption">Caption to be used for that column</param>
        ''' <param name="type">Type of data</param>
        ''' <param name="width">width</param>
        ''' <param name="format">a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"</param>
        ''' <remarks></remarks>
        Protected Sub AddColumnToExcelBook(ByVal column As Integer, ByVal caption As String, ByVal type As DataType, ByVal width As Integer, ByVal format As String)
            Dim styleName As String = "Style" 'name of the format style

            If ExcelRow Is Nothing Then
                Return
            End If

            ExcelRow.Cells.Add(New WorksheetCell(caption, "HeaderRowStyle"))
            Dim worksheetColumn As WorksheetColumn = ExcelSheet.Table.Columns.Add(width)

            'Define a unique column style for each column in the table to be exported
            Dim excelColumnStyle As CarlosAg.ExcelXmlWriter.WorksheetStyle = ExcelBook.Styles.Add(styleName & column)
            excelColumnStyle.Font.FontName = "Verdana"
            excelColumnStyle.Font.Size = 8

            If Not format.Equals("Default") Then
                excelColumnStyle.NumberFormat = format
            End If
        End Sub

        ' Add cell with data to existing row
        ' column - column number to set correct format for this cell
        ' name - column name
        ' entityType - EntityType instance, that holds types definitions for this table 
        ' val - data value for this cell
        Protected Sub AddCellToExcelRow(ByVal column As Integer, ByVal type As DataType, ByVal val As String)
            Dim styleName As String = "Style" 'name of the format style

            If ExcelRow Is Nothing Then
                Return
            End If

            ' If the value of the column to be exported is nothing, add an empty cell to the Excel file
            If val Is Nothing Then
                ExcelRow.Cells.Add(New WorksheetCell())
            Else
                ExcelRow.Cells.Add(New WorksheetCell(val, type, (styleName & column)))
            End If
        End Sub

        Protected Sub AddRowToExcelBook()
            If ExcelSheet Is Nothing Then
                Return
            End If

            ExcelRow = ExcelSheet.Table.Rows.Add()
        End Sub

        ' calls SetupResponse to set header and cache and saves Excel file to HttpResponse
        Protected Sub SaveExcelBook(ByVal response As System.Web.HttpResponse)
            Dim fileName As String
            fileName = ExcelBook.Properties.Title + ".xls"

            SetupResponse(response, fileName)
            response.ContentType = "application/vnd.ms-excel"

            ExcelBook.Save(response.OutputStream)

            ' Need to call Response.End() so nothing will be attached to a file
            ' System.Web.HttpResponse.End() function will throw System.Threading.ThreadAbortException
            ' indicating that the current response ends prematurely - that's what we want
            response.End()
        End Sub

        ' Creates Excel Workbook that is used for Export to Excel request.
        Protected Sub CreateExcelBook()
            ExcelBook = New CarlosAg.ExcelXmlWriter.Workbook()

            ExcelBook.Properties.Title = Title

            ExcelBook.Properties.Created = DateTime.Now
            ExcelBook.Properties.Author = ""

            ExcelSheet = ExcelBook.Worksheets.Add("Sheet1")
            ExcelSheet.Options.SplitHorizontal = 1
            ExcelSheet.Options.FreezePanes = True
            ExcelSheet.Options.TopRowBottomPane = 1

            ExcelRow = ExcelSheet.Table.Rows.Add() 'header row

            Dim excelHeaderStyle As CarlosAg.ExcelXmlWriter.WorksheetStyle = ExcelBook.Styles.Add("HeaderRowStyle")
            excelHeaderStyle.Font.Bold = True
            excelHeaderStyle.Font.FontName = "Verdana"
            excelHeaderStyle.Font.Size = 8
            excelHeaderStyle.Font.Color = "#FFFFFF"
            excelHeaderStyle.Interior.Color = "#000000"
            excelHeaderStyle.Interior.Pattern = StyleInteriorPattern.Solid
        End Sub
#End Region
    End Class

    Public Class ExportDataToCSV
        Inherits ExportToCSVBaseClass
#Region "Properties"
        Private data As DataForExport = Nothing

        Protected Overrides ReadOnly Property Title() As String
            Get
                Return data.Title
            End Get
        End Property
#End Region

#Region "Constructor"
        Private Sub New() 'don't use this one!
        End Sub


        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy, ByVal columns() As BaseColumn)
            MyBase.New()
            data = New DataForExport(tbl, wc, orderBy, columns)
        End Sub

        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy)
            MyBase.New()
            data = New DataForExport(tbl, wc, orderBy, Nothing)
        End Sub

        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy, ByVal columns() As BaseColumn, ByVal header As String)
            MyBase.New(header)
            data = New DataForExport(tbl, wc, orderBy, columns)
        End Sub

        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy, ByVal header As String)
            MyBase.New(header)
            data = New DataForExport(tbl, wc, orderBy, Nothing)
        End Sub

#End Region

#Region "Private Methods"
        ''' <summary>
        ''' Retrives data for specific column from record.
        ''' Formats data depending on the type. 
        ''' </summary>
        ''' <param name="col"></param>
        ''' <param name="rec"></param>
        ''' <returns>Data as string that can be exported to a file.</returns>
        ''' <remarks></remarks>
        Private Function GetDataForExport(ByVal col As BaseColumn, ByVal rec As BaseRecord) As String
            Dim val As String = ""

            If col.TableDefinition.IsExpandableNonCompositeForeignKey(col) Then
                '  Foreign Key column, so we will use DFKA and String type.
                val = rec.Format(col)
            Else
                Select Case (col.ColumnType)
                    Case BaseColumn.ColumnTypes.Binary, BaseColumn.ColumnTypes.Image
                        'do nothing

                    Case BaseColumn.ColumnTypes.Percentage, BaseColumn.ColumnTypes.Currency, BaseColumn.ColumnTypes.Number
                        val = rec.Format(col)

                    Case Else
                        val = rec.Format(col)

                End Select
            End If
            Return val
        End Function


        ''' <summary>
        ''' Writes header. If DisplayString was not set, then writes out the Column's name property as the header for each column
        ''' </summary>
        ''' <returns> Always returns true</returns>
        Protected Overrides Function WriteColumnHeader() As Boolean
            If MyBase.WriteColumnHeader() Then
                Return True
            End If

            ' If DisplayString is null, then write out the Column's name property as the header.
            For Each col As BaseColumn In data.ColumnList
                If col IsNot Nothing Then
                    If data.IncludeInExport(col) Then
                        MyBase.WriteColumnTitle(col.Name)
                    End If
                End If
            Next col
            Return True
        End Function

        Protected Sub WriteRows()
            Dim done As Boolean = False

            Dim totalRowsReturned As Integer = 0

            '  Read pageSize records at a time and write out the CSV file.
            While (Not done)
                Dim recList As ArrayList = data.GetRows(pageSize)
                If recList Is Nothing Then
                    Exit While 'no more records we are done
                End If

                totalRowsReturned = recList.Count
                For Each rec As BaseRecord In recList
                    For Each col As BaseColumn In data.ColumnList
                        If col Is Nothing Then
                            Continue For
                        End If

                        If Not data.IncludeInExport(col) Then
                            Continue For
                        End If


                        Dim val As String = GetDataForExport(col, rec)

                        MyBase.WriteColumnData(val, data.IsString(col))
                    Next col
                    MyBase.WriteNewRow()
                Next rec

                '  If we already are below the pageSize, then we are done.
                If totalRowsReturned < pageSize Then
                    done = True
                End If
            End While
        End Sub

#End Region

#Region "Public Methods"
        Public Overrides Sub Export(ByVal response As System.Web.HttpResponse)
            If response Is Nothing Then
                Return
            End If

            StartExport(response)

            WriteRows()

            FinishExport(response)
        End Sub
#End Region
    End Class

    ''' <summary>
    ''' The ExportDataToExcel class class exports to Excel and sends the XLS file to the response stream.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ExportDataToExcel
        Inherits ExportToExcelBaseClass
#Region "Properties"
        Private data As DataForExport = Nothing

        Protected Overrides ReadOnly Property Title() As String
            Get
                Return data.Title
            End Get
        End Property
#End Region

#Region "Constructor"
        Private Sub New() 'don't use this one!
        End Sub

        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy)
            MyBase.New()
            data = New DataForExport(tbl, wc, orderBy, Nothing)
        End Sub
#End Region

#Region "Private Methods"

        Private Function GetDisplayFormat(ByVal col As ExcelColumn) As String
            Return col.DisplayFormat
        End Function

        'return true if type can be included in export data
        Protected Function GetExcelDataType(ByVal col As ExcelColumn) As CarlosAg.ExcelXmlWriter.DataType
            If (col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn)) Then
                Return DataType.String
            End If

            Select Case (col.DisplayColumn.ColumnType)
                Case BaseColumn.ColumnTypes.Number, BaseColumn.ColumnTypes.Percentage
                    Return DataType.Number

                Case BaseColumn.ColumnTypes.Currency
                    Return DataType.Number

                Case BaseColumn.ColumnTypes.Date
                    Return DataType.DateTime

                Case BaseColumn.ColumnTypes.Very_Large_String
                    Return DataType.String

                Case BaseColumn.ColumnTypes.Boolean
                    Return DataType.String

                Case Else
                    Return DataType.String
            End Select
        End Function

        Private Function GetExcelCellWidth(ByVal col As ExcelColumn) As Integer
            If col Is Nothing Then
                Return 0
            End If

            Dim width As Integer = 50
            If col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn) Then
                ' Set width if field is a foreign key field
                width = 100
            Else
                Select Case (col.DisplayColumn.ColumnType)
                    Case BaseColumn.ColumnTypes.Binary, BaseColumn.ColumnTypes.Image
                        '  do nothing for these columns
                        width = 0

                    Case BaseColumn.ColumnTypes.Currency, BaseColumn.ColumnTypes.Number, BaseColumn.ColumnTypes.Percentage
                        width = 60

                    Case BaseColumn.ColumnTypes.String, BaseColumn.ColumnTypes.Very_Large_String
                        width = 110

                    Case Else
                        width = 50
                End Select
            End If

            Return width
        End Function



        Protected Function GetValueForExcelExport(ByVal col As ExcelColumn, ByVal rec As BaseRecord) As String
            Dim val As String = ""
            Dim isNull As Boolean = False
            Dim deciNumber As Decimal

            If col Is Nothing Then
                Return Nothing
            End If


            If col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn) Then
                '  Foreign Key column, so we will use DFKA and String type.
                val = rec.Format(col.DisplayColumn)
            Else
                Select Case (col.DisplayColumn.ColumnType)
                    Case BaseColumn.ColumnTypes.Number, BaseColumn.ColumnTypes.Percentage, BaseColumn.ColumnTypes.Currency
                        Dim numVal As ColumnValue = rec.GetValue(col.DisplayColumn)
                        'If the value of the column to be exported is nothing, add an empty cell to the Excel file
                        If numVal.IsNull Then
                            isNull = True
                        Else
                            deciNumber = numVal.ToDecimal()
                            val = deciNumber.ToString(System.Globalization.CultureInfo.InvariantCulture)
                        End If

                    Case BaseColumn.ColumnTypes.Date
                        Dim dateVal As ColumnValue = rec.GetValue(col.DisplayColumn)
                        If dateVal.IsNull Then
                            isNull = True
                        Else
                            ' Specify the default Excel format for the date field 
                            val = rec.Format(col.DisplayColumn, "s")
                            val += ".000"
                        End If

                    Case BaseColumn.ColumnTypes.Very_Large_String
                        val = rec.GetValue(col.DisplayColumn).ToString()

                    Case BaseColumn.ColumnTypes.Boolean
                        val = rec.Format(col.DisplayColumn)

                    Case Else
                        val = rec.Format(col.DisplayColumn)
                End Select
            End If

            If (isNull) Then
                Return Nothing
            Else
                Return val
            End If

        End Function
#End Region

#Region "Public Methods"
        Public Sub AddColumn(ByVal col As ExcelColumn)
            data.ColumnList.Add(col)
        End Sub

        Public Overrides Sub Export(ByVal response As System.Web.HttpResponse)
            Dim done As Boolean = False
            Dim val As String

            If response Is Nothing Then
                Return
            End If

            CreateExcelBook()

            Dim width As Integer = 0
            Dim columnCounter As Integer = 0

            '  First write out the Column Headers
            For Each col As ExcelColumn In data.ColumnList
                width = GetExcelCellWidth(col)
                If data.IncludeInExport(col) Then
                    AddColumnToExcelBook(columnCounter, col.ToString(), GetExcelDataType(col), width, GetDisplayFormat(col))
                    columnCounter = columnCounter + 1
                End If
            Next col

            ' Read pageSize records at a time and write out the Excel file.
            Dim totalRowsReturned As Integer = 0

            While (Not done)
                Dim recList As ArrayList = data.GetRows(pageSize)

                For Each rec As BaseRecord In recList
                    AddRowToExcelBook()
                    columnCounter = 0
                    For Each col As ExcelColumn In data.ColumnList
                        If Not data.IncludeInExport(col) Then
                            Continue For
                        End If

                        val = GetValueForExcelExport(col, rec)
                        AddCellToExcelRow(columnCounter, GetExcelDataType(col), val)

                        columnCounter = columnCounter + 1
                    Next col
                Next rec

                ' If we already are below the pageSize, then we are done.
                If totalRowsReturned < pageSize Then
                    done = True
                End If
            End While

            SaveExcelBook(response)
        End Sub
#End Region

    End Class

    ''' <summary>
    ''' The DataForExport class is a support class for Exportdata.
    ''' It encapsulate access to data needs to be exported:
    ''' data rows, title, columns.
    ''' </summary>
    Friend Class DataForExport

#Region "Properties"
        Private _tbl As BaseTable
        Public Property DBTable() As BaseTable
            Get
                Return Me._tbl
            End Get
            Set(ByVal value As BaseTable)
                Me._tbl = value
            End Set
        End Property

        Private _wc As WhereClause
        Public Property SelectWhereClause() As WhereClause
            Get
                Return Me._wc
            End Get
            Set(ByVal value As WhereClause)
                Me._wc = value
            End Set
        End Property

        Private _orderby As OrderBy
        Public Property SelectOrderBy() As OrderBy
            Get
                Return Me._orderby
            End Get
            Set(ByVal value As OrderBy)
                Me._orderby = value
            End Set
        End Property

        Public ColumnList As ArrayList = New ArrayList

        Public ReadOnly Property Title() As String
            Get
                If DBTable.TableDefinition Is Nothing Then
                    Return "Unnamed"
                End If

                Return DBTable.TableDefinition.Name
            End Get
        End Property
#End Region
        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy, ByVal columns() As BaseColumn)
            DBTable = tbl
            SelectWhereClause = wc
            SelectOrderBy = orderBy
            If columns IsNot Nothing Then
                ColumnList.AddRange(columns)
            End If
        End Sub

        Private pageIndex As Integer = 0
        Public Function GetRows(ByVal pageSize As Integer) As ArrayList
            Dim totalRows As Integer = 0

            '  Read pageSize records at a time and write out the CSV file.
            Dim recList As ArrayList = Nothing
            If SelectWhereClause.RunQuery Then
                recList = DBTable.GetRecordList(SelectWhereClause.GetFilter(), SelectOrderBy, pageIndex, pageSize, totalRows)
                pageIndex = pageIndex + 1
            End If

            Return recList
        End Function



        Public Function IsString(ByVal col As BaseColumn) As Boolean
            If col Is Nothing Then
                Return False
            End If

            Select Case (col.ColumnType)
                Case BaseColumn.ColumnTypes.Binary, BaseColumn.ColumnTypes.Image, _
                     BaseColumn.ColumnTypes.Currency, BaseColumn.ColumnTypes.Number, BaseColumn.ColumnTypes.Percentage
                    Return False
            End Select

            Return True
        End Function

        Public Function IsString(ByVal col As ExcelColumn) As Boolean
            If col Is Nothing Then
                Return False
            End If

            Return IsString(col.DisplayColumn)
        End Function

        Public Function IncludeInExport(ByVal col As BaseColumn) As Boolean
            If col Is Nothing Then
                Return False
            End If

            Select Case (col.ColumnType)
                Case BaseColumn.ColumnTypes.Binary, BaseColumn.ColumnTypes.Image
                    '  Skip - do nothing for these columns
                    Return False
            End Select

            Return True
        End Function

        Public Function IncludeInExport(ByVal col As ExcelColumn) As Boolean
            If col Is Nothing Then
                Return False
            End If

            Return IncludeInExport(col.DisplayColumn)
        End Function

    End Class

    ''' <summary>
    ''' ExcelColumn class is used to set Excel format for BaseClolumn to be used for exporting data to Excel file.
    ''' </summary>
    Public Class ExcelColumn
#Region "Constructor"

        ''' <summary>
        ''' Cretes new ExcelColumn
        ''' </summary>
        ''' <param name="col">BaseColumn</param>
        ''' <param name="format">a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"</param>
        ''' <remarks></remarks>
        Public Sub New(ByVal col As BaseColumn, ByVal format As String)
            DisplayColumn = col
            DisplayFormat = format
        End Sub
#End Region
#Region "Properties"
        Private _column As BaseColumn
        Public Property DisplayColumn() As BaseColumn
            Get
                Return _column
            End Get
            Set(ByVal value As BaseColumn)
                Me._column = value
            End Set
        End Property

        Private _format As String
        Public Property DisplayFormat() As String
            Get
                Return _format
            End Get
            Set(ByVal value As String)
                Me._format = value
            End Set
        End Property
#End Region

#Region "Public Methods"
        Public Overrides Function ToString() As String
            Return DisplayColumn.Name
        End Function
#End Region

    End Class

    ''' <summary>
    ''' This class is redundant. It is left here for backward compatibility.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ExportData

#Region "Private members"
        Private _exportDataToCSV As ExportDataToCSV = Nothing
        Private _exportDataToExcel As ExportDataToExcel = Nothing
#End Region

#Region "Constructor"
        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy, ByVal columns() As BaseColumn)
            _exportDataToCSV = New ExportDataToCSV(tbl, wc, orderBy, columns)
        End Sub

        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy)
            _exportDataToCSV = New ExportDataToCSV(tbl, wc, orderBy)
            _exportDataToExcel = New ExportDataToExcel(tbl, wc, orderBy)
        End Sub

        Public Sub New(ByVal tbl As BaseTable, ByVal wc As WhereClause, ByVal orderBy As OrderBy, ByVal columns() As BaseColumn, ByVal header As String)
            _exportDataToCSV = New ExportDataToCSV(tbl, wc, orderBy, columns, header)
        End Sub
#End Region
        Public Sub AddColumn(ByVal col As ExcelColumn)
            If _exportDataToExcel IsNot Nothing Then
                _exportDataToExcel.AddColumn(col)
            End If
        End Sub

        Public Sub ExportToCSV(ByVal response As System.Web.HttpResponse)
            If _exportDataToCSV IsNot Nothing Then
                _exportDataToCSV.Export(response)
            End If
        End Sub

        Public Sub ExportToExcel(ByVal response As System.Web.HttpResponse)
            If _exportDataToExcel IsNot Nothing Then
                _exportDataToExcel.Export(response)
            End If
        End Sub
    End Class

End Namespace