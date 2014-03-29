
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditPro_inv_taxes.aspx page.  The Row or RecordControl classes are the 
' ideal place to add code customizations. For example, you can override the LoadData, 
' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#Region "Imports statements"

Option Strict On
Imports Microsoft.VisualBasic
Imports BaseClasses.Web.UI.WebControls
Imports System
Imports System.Collections
Imports System.Collections.Generic
        
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Utils
Imports ReportTools.ReportCreator
Imports ReportTools.Shared

  
        
Imports ServelInvocing.Business
Imports ServelInvocing.Data
Imports ServelInvocing.UI
        

#End Region

  
Namespace ServelInvocing.UI.Controls.EditPro_inv_taxes

#Region "Section 1: Place your customizations here."

    
Public Class Pro_inv_taxesRecordControl
        Inherits BasePro_inv_taxesRecordControl
        ' The BasePro_inv_taxesRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Pro_inv_taxesRecordControl control on the EditPro_inv_taxes page.
' Do not modify this class. Instead override any method in Pro_inv_taxesRecordControl.
Public Class BasePro_inv_taxesRecordControl
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Pro_inv_taxesRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
        
        End Sub

        '  To customize, override this method in Pro_inv_taxesRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
              ' Setup the pagination events.	  
         
              ' Register the event handlers.
          
              Me.id_pro_inv_hdrAddRecordLink.PostBackUrl = "../pro_inv_hdr/AddPro_inv_hdr.aspx" & "?Target=" & Me.id_pro_inv_hdr.ClientID & "&DFKA=bill_name"
              Me.id_pro_inv_hdrAddRecordLink.Attributes.Item("onClick") = "window.open('" & Me.id_pro_inv_hdrAddRecordLink.PostBackUrl & "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;"
              
              Me.id_taxesAddRecordLink.PostBackUrl = "../taxes/AddTaxes.aspx" & "?Target=" & Me.id_taxes.ClientID & "&DFKA=tax_code"
              Me.id_taxesAddRecordLink.Attributes.Item("onClick") = "window.open('" & Me.id_taxesAddRecordLink.PostBackUrl & "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;"
              
              AddHandler Me.id_pro_inv_hdr.SelectedIndexChanged, AddressOf id_pro_inv_hdr_SelectedIndexChanged
            
              AddHandler Me.id_taxes.SelectedIndexChanged, AddressOf id_taxes_SelectedIndexChanged
            
              AddHandler Me.tax_amount.TextChanged, AddressOf tax_amount_TextChanged
            
              AddHandler Me.tax_code.TextChanged, AddressOf tax_code_TextChanged
            
              AddHandler Me.tax_name.TextChanged, AddressOf tax_name_TextChanged
            
              AddHandler Me.tax_print.TextChanged, AddressOf tax_print_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource pro_inv_taxes record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Pro_inv_taxesTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New Pro_inv_taxesRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As Pro_inv_taxesRecord = Pro_inv_taxesTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = Pro_inv_taxesTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Pro_inv_taxesRecordControl.
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record.  To do this, it calls the Set methods for 
            ' each of the field displayed on the webpage.  It is better to make 
            ' changes in the Set methods, rather than making changes here.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
        
      
      
            ' Call the Set methods for each controls on the panel
        
            Setid_pro_inv_hdr()
            Setid_pro_inv_hdrLabel()
            Setid_taxes()
            Setid_taxesLabel()
            Settax_amount()
            Settax_amountLabel()
            Settax_code()
            Settax_codeLabel()
            Settax_name()
            Settax_nameLabel()
            Settax_print()
            Settax_printLabel()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setid_pro_inv_hdr()
            
        
            ' Set the id_pro_inv_hdr DropDownList on the webpage with value from the
            ' pro_inv_taxes database record.
            
            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.id_pro_inv_hdr is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_pro_inv_hdr()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_pro_inv_hdrSpecified Then
                            
                ' If the id_pro_inv_hdr is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_pro_inv_hdrDropDownList(Me.DataSource.id_pro_inv_hdr.ToString(), 100)
                
            Else
                
                ' id_pro_inv_hdr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_pro_inv_hdrDropDownList(Nothing, 100)
                Else
                    Me.Populateid_pro_inv_hdrDropDownList(Pro_inv_taxesTable.id_pro_inv_hdr.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setid_taxes()
            
        
            ' Set the id_taxes DropDownList on the webpage with value from the
            ' pro_inv_taxes database record.
            
            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.id_taxes is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxesSpecified Then
                            
                ' If the id_taxes is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_taxesDropDownList(Me.DataSource.id_taxes.ToString(), 100)
                
            Else
                
                ' id_taxes is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_taxesDropDownList(Nothing, 100)
                Else
                    Me.Populateid_taxesDropDownList(Pro_inv_taxesTable.id_taxes.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Settax_amount()
            
        
            ' Set the tax_amount TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_amount is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_amount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_amountSpecified Then
                				
                ' If the tax_amount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_amount)
                            
                Me.tax_amount.Text = formattedValue
              
            Else 
            
                ' tax_amount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_amount.Text = Pro_inv_taxesTable.tax_amount.Format(Pro_inv_taxesTable.tax_amount.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_code()
            
        
            ' Set the tax_code TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_code is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_codeSpecified Then
                				
                ' If the tax_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_code)
                            
                Me.tax_code.Text = formattedValue
              
            Else 
            
                ' tax_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_code.Text = Pro_inv_taxesTable.tax_code.Format(Pro_inv_taxesTable.tax_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_name()
            
        
            ' Set the tax_name TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_nameSpecified Then
                				
                ' If the tax_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_name)
                            
                Me.tax_name.Text = formattedValue
              
            Else 
            
                ' tax_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_name.Text = Pro_inv_taxesTable.tax_name.Format(Pro_inv_taxesTable.tax_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settax_print()
            
        
            ' Set the tax_print TextBox on the webpage with value from the
            ' pro_inv_taxes database record.

            ' Me.DataSource is the pro_inv_taxes record retrieved from the database.
            ' Me.tax_print is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_print()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_printSpecified Then
                				
                ' If the tax_print is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_taxesTable.tax_print)
                            
                Me.tax_print.Text = formattedValue
              
            Else 
            
                ' tax_print is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_print.Text = Pro_inv_taxesTable.tax_print.Format(Pro_inv_taxesTable.tax_print.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_pro_inv_hdrLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxesLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_amountLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_codeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_nameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_printLabel()
            
                    
        End Sub
                
        Public Overridable Sub ResetControl()
          
        End Sub
        
      
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            If dataSourceForEvaluate Is Nothing Then
                
                e.DataSource = Me.DataSource
                
            Else
                e.DataSource = dataSourceForEvaluate
            End If

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing
                Return ""
            End If
            
            If format IsNot Nothing
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function	  
      

        Public Overridable Sub RegisterPostback()
        
        
        End Sub

      
        
        ' To customize, override this method in Pro_inv_taxesRecordControl.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesRecordControlPanel"), System.Web.UI.WebControls.Panel)

          If ((Not IsNothing(Panel)) AndAlso (Not Panel.Visible)) OrElse IsNothing(Me.DataSource) Then
              Return
          End If
          
              
            ' 2. Perform any custom validation.
            Me.Validate()

            
            ' 3. Set the values in the record with data from UI controls.
            ' This calls the Get() method for each of the user interface controls.
            Me.GetUIData()

            ' 4. Save in the database.
            ' We should not save the record if the data did not change. This
            ' will save a database hit and avoid triggering any database triggers.
             
            If Me.DataSource.IsAnyValueChanged Then
                ' Save record to database but do not commit yet.
                ' Auto generated ids are available after saving for use by child (dependent) records.
                Me.DataSource.Save()
              
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Pro_inv_taxesRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getid_pro_inv_hdr()
            Getid_taxes()
            Gettax_amount()
            Gettax_code()
            Gettax_name()
            Gettax_print()
        End Sub
        
        
        Public Overridable Sub Getid_pro_inv_hdr()
         
            ' Retrieve the value entered by the user on the id_pro_inv_hdr ASP:DropDownList, and
            ' save it into the id_pro_inv_hdr field in DataSource pro_inv_taxes record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_pro_inv_hdr), Pro_inv_taxesTable.id_pro_inv_hdr)				
            
        End Sub
                
        Public Overridable Sub Getid_taxes()
         
            ' Retrieve the value entered by the user on the id_taxes ASP:DropDownList, and
            ' save it into the id_taxes field in DataSource pro_inv_taxes record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_taxes), Pro_inv_taxesTable.id_taxes)				
            
        End Sub
                
        Public Overridable Sub Gettax_amount()
            
            ' Retrieve the value entered by the user on the tax_amount ASP:TextBox, and
            ' save it into the tax_amount field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_amount.Text, Pro_inv_taxesTable.tax_amount)			

                      
        End Sub
                
        Public Overridable Sub Gettax_code()
            
            ' Retrieve the value entered by the user on the tax_code ASP:TextBox, and
            ' save it into the tax_code field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_code.Text, Pro_inv_taxesTable.tax_code)			

                      
        End Sub
                
        Public Overridable Sub Gettax_name()
            
            ' Retrieve the value entered by the user on the tax_name ASP:TextBox, and
            ' save it into the tax_name field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_name.Text, Pro_inv_taxesTable.tax_name)			

                      
        End Sub
                
        Public Overridable Sub Gettax_print()
            
            ' Retrieve the value entered by the user on the tax_print ASP:TextBox, and
            ' save it into the tax_print field in DataSource pro_inv_taxes record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tax_print.Text, Pro_inv_taxesTable.tax_print)			

                      
        End Sub
                
      
        ' To customize, override this method in Pro_inv_taxesRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Dim wc As WhereClause
            Pro_inv_taxesTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
            Dim recId As String = Me.Page.Request.QueryString.Item("Pro_inv_taxes")
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ServelInvocing").Replace("{URL}", "Pro_inv_taxes"))
            End If
            HttpContext.Current.Session("QueryString in EditPro_inv_taxes") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(Pro_inv_taxesTable.id0, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(Pro_inv_taxesTable.id0).ToString())
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(Pro_inv_taxesTable.id0, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            Pro_inv_taxesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
       
          
            Return wc
        End Function
          
          
        'Formats the resultItem and adds it to the list of suggestions.
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") and not index = 0 Then
                ' Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                If regex1.IsMatch(resultItem) Then
                    index = regex1.Match(resultItem).Index
                    isFound = True
                End If
                ' If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                If not resultItem(index).ToString() = " " Then
                    ' Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    Dim regex As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    If regex.IsMatch(resultItem) Then
                        index = regex.Match(resultItem).Index
                        isFound = True
                    End If
                 End If
            End If
            ' If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            ' beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            If index = 0 Or isFound Or InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") then
                If InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atbeginningofmatchedstring") Then
                    ' Expression to find beginning of the word which contains prefixText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    '  Find the beginning of the word which contains prefexText
                    If (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") AndAlso regex1.IsMatch(resultItem)) Then
                        index = regex1.Match(resultItem).Index
                        isFound = True
                    End If
                    ' Display string from the index till end of the string if sub string from index till end is less than columnLength value.
                    If Len(resultItem) - index <= columnLength Then
                        If index = 0 Then 
                            itemToAdd = resultItem 
                        Else
                            itemToAdd = "..." & resultItem.Substring(index, Len(resultItem) - index) 
                        End If
                    Else
                        If index = 0 Then
                            itemToAdd = resultItem.Substring(index, (columnLength - 3)) & "..."
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index , columnLength - 6) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("inmiddleofmatchedstring") Then
                    Dim subStringBeginIndex As Integer = CType(columnLength/2, Integer)
                    If Len(resultItem) <= columnLength Then
                        itemToAdd = resultItem
                    Else
                        ' Sanity check at end of the string
                        If index + Len(prefixText) = columnLength Then
                            itemToAdd =  "..." & resultItem.Substring(index-columnLength,index)
                        ElseIf Len(resultItem) - index < subStringBeginIndex Then 
                            ' Display string from the end till columnLength value if, index is closer to the end of the string.
                            itemToAdd =  "..." & resultItem.Substring(Len(resultItem)-columnLength,Len(resultItem))
                        ElseIf index <= subStringBeginIndex Then 
                            ' Sanity chet at beginning of the string
                            itemToAdd =  resultItem.Substring(0, columnLength) & "..."
                        Else
                            ' Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd =  "..." & resultItem.Substring(index - subStringBeginIndex, columnLength) & "..." 
                        End If
                    End If
                ElseIf InvariantLCase(AutoTypeAheadDisplayFoundText).equals("atendofmatchedstring") Then
                     ' Expression to find ending of the word which contains prefexText
                    Dim regex1 As System.Text.RegularExpressions.Regex = new System.Text.RegularExpressions.Regex("\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                    ' Find the ending of the word which contains prefexText
                    If regex1.IsMatch(resultItem, index + 1) Then
                        index = regex1.Match(resultItem, index + 1).Index
                    Else
                        ' If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length
                    End If
                    If index > Len(resultItem) Then
                        index = Len(resultItem)
                    End If
                    ' If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    If  index <= columnLength Then
                        if index = Len(resultItem) then   'Make decision to append "..."
                            itemToAdd = resultItem.Substring(0,index)
                        Else
                            itemToAdd = resultItem.Substring(0,index) & "..."
                        End If
                    Else
                        If index = Len(resultItem) Then
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 3), (columnLength - 3))
                        Else
                            'Truncate the string to show only columnLength - 6 characters as begining and trailing "..." has to be appended.
                            itemToAdd = "..." & resultItem.Substring(index - (columnLength - 6), columnLength - 6) & "..." 
                        End If
                    End If
                End If
                
                ' Remove newline character from itemToAdd
                Dim prefixTextIndex As Integer = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase)
                ' If itemToAdd contains any newline after the search text then show text only till newline
                Dim regex2 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                Dim newLineIndexAfterPrefix As Integer = -1
                If regex2.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexAfterPrefix > -1) Then
                    If itemToAdd.EndsWith("...") Then
                        itemToAdd = (itemToAdd.Substring(0, newLineIndexAfterPrefix) + "...")
                    Else
                        itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix)
                    End If
                End If
                ' If itemToAdd contains any newline before search text then show text which comes after newline
                Dim regex3 As System.Text.RegularExpressions.Regex = New System.Text.RegularExpressions.Regex("(" & vbCrLf & "|" & vbLf & ")", (System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.RightToLeft))
                Dim newLineIndexBeforePrefix As Integer = -1
                If regex3.IsMatch(itemToAdd, prefixTextIndex) Then
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index
                End If
                If (newLineIndexBeforePrefix > -1) Then
                    If itemToAdd.StartsWith("...") Then
                        itemToAdd = ("..." + itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length)))
                    Else
                        itemToAdd = itemToAdd.Substring((newLineIndexBeforePrefix + regex3.Match(itemToAdd, prefixTextIndex).Length))
                    End If
                End If

                If Not itemToAdd is nothing AndAlso Not resultList.Contains(itemToAdd) Then
                    resultList.Add(itemToAdd)
                    isAdded = true
                End If
            End If
            Return isAdded
        End Function
        

        ' To customize, override this method in Pro_inv_taxesRecordControl.
        Public Overridable Sub Validate() 
            ' Add custom validation for any control within this panel.
            ' Example.  If you have a State ASP:Textbox control
            ' If Me.State.Text <> "CA" Then
            '    Throw New Exception("State must be CA (California).")
            ' End If

            ' The Validate method is common across all controls within
            ' this panel so you can validate multiple fields, but report
            ' one error message.
            
                
        End Sub

        Public Overridable Sub Delete()
        
            If Me.IsNewRecord() Then
                Return
            End If

            Dim pkValue As KeyValue = KeyValue.XmlToKey(Me.RecordUniqueId)
          Pro_inv_taxesTable.DeleteRecord(pkValue)
          
        End Sub

        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction()
                Me.RegisterPostback()

                If Not Me.Page.ErrorOnPage AndAlso (Me.Page.IsPageRefresh OrElse Me.DataChanged OrElse Me.ResetData) Then
                    ' Re-load the data and update the web page if necessary.
                    ' This is typically done during a postback (filter, search button, sort, pagination button).
                    ' In each of the other click handlers, simply set DataChanged to True to reload the data.
                    Me.LoadData()
                    Me.DataBind()			
                End If
                						
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction()
            End Try
        End Sub
        
        

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)
            Dim isNewRecord As String = CType(ViewState("IsNewRecord"), String)
            If Not isNewRecord Is Nothing AndAlso isNewRecord.Trim <> "" Then
                Me.IsNewRecord = Boolean.Parse(isNewRecord)
            End If
            
            Dim myCheckSum As String = CType(ViewState("CheckSum"), String)
            If Not myCheckSum Is Nothing AndAlso myCheckSum.Trim <> "" Then
                Me.CheckSum = myCheckSum
            End If
            
        End Sub

        Protected Overrides Function SaveViewState() As Object
            ViewState("IsNewRecord") = Me.IsNewRecord.ToString()
            ViewState("CheckSum") = Me.CheckSum
            
            Return MyBase.SaveViewState()
        End Function
        
        
        ' Generate the event handling functions for pagination events.
            
      
        ' Generate the event handling functions for filter and search events.
            

        Public Overridable Function CreateWhereClause_id_pro_inv_hdrDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the pro_inv_hdr table.
            ' Examples:
            ' wc.iAND(Pro_inv_hdrTable.bill_name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(Pro_inv_hdrTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                

        Public Overridable Function CreateWhereClause_id_taxesDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the taxes table.
            ' Examples:
            ' wc.iAND(TaxesTable.tax_code, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(TaxesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the id_pro_inv_hdr list.
        Protected Overridable Sub Populateid_pro_inv_hdrDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_pro_inv_hdr.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_pro_inv_hdr.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_pro_inv_hdrDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_pro_inv_hdrDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(Pro_inv_hdrTable.bill_name, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As Pro_inv_hdrRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = Pro_inv_hdrTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As Pro_inv_hdrRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(Pro_inv_hdrTable.bill_name)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_pro_inv_hdr.Items.Contains(newItem) Then Me.id_pro_inv_hdr.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_pro_inv_hdr, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_pro_inv_hdr, selectedValue)Then

                ' construct a whereclause to query a record with pro_inv_hdr.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Pro_inv_hdrTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Pro_inv_hdrRecord = Pro_inv_hdrTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_pro_inv_hdr.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_pro_inv_hdr.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' Fill the id_taxes list.
        Protected Overridable Sub Populateid_taxesDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_taxes.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_taxes.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_taxesDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_taxesDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(TaxesTable.tax_code, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
            Dim itemValues() As TaxesRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = TaxesTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As TaxesRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                            fvalue = itemValue.Format(TaxesTable.tax_code)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_taxes.Items.Contains(newItem) Then Me.id_taxes.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_taxes, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_taxes, selectedValue)Then

                ' construct a whereclause to query a record with taxes.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TaxesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TaxesRecord = TaxesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_taxes.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_taxes.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        Protected Overridable Sub id_pro_inv_hdr_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_pro_inv_hdr.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_pro_inv_hdr)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_pro_inv_hdr, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_pro_inv_hdr, selectedValue)Then

                ' construct a whereclause to query a record with pro_inv_hdr.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(Pro_inv_hdrTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As Pro_inv_hdrRecord = Pro_inv_hdrTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_pro_inv_hdr.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_pro_inv_hdr.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub id_taxes_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_taxes.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_taxes)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_taxes, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_taxes, selectedValue)Then

                ' construct a whereclause to query a record with taxes.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(TaxesTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As TaxesRecord = TaxesTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = Pro_inv_taxesTable.id_taxes.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_taxes.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub tax_amount_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_code_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tax_print_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
   
        Private _PreviousUIData As New Hashtable
        Public Overridable Property PreviousUIData() As Hashtable
            Get
                Return _PreviousUIData
            End Get
            Set(ByVal value As Hashtable)
                _PreviousUIData = value
            End Set
        End Property   
   
        Private _IsNewRecord As Boolean = True
        Public Overridable Property IsNewRecord() As Boolean
            Get
                Return Me._IsNewRecord
            End Get
            Set(ByVal value As Boolean)
                Me._IsNewRecord = value
            End Set
        End Property

        Private _DataChanged As Boolean = False
        Public Overridable Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal Value As Boolean)
                Me._DataChanged = Value
            End Set
        End Property

        Private _ResetData As Boolean = False
        Public Overridable Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal Value As Boolean)
                Me._ResetData = Value
            End Set
        End Property
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BasePro_inv_taxesRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePro_inv_taxesRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Pro_inv_taxesRecord
        Public Property DataSource() As Pro_inv_taxesRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Pro_inv_taxesRecord)
            
                Me._DataSource = value
            End Set
        End Property

        

        Private _checkSum As String
        Public Overridable Property CheckSum() As String
            Get
                Return Me._checkSum
            End Get
            Set(ByVal value As String)
                Me._checkSum = value
            End Set
        End Property
        
        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
            End Set
        End Property
        
        Private _PageIndex As Integer
        Public Property PageIndex() As Integer
            Get
                ' Return the PageIndex
                Return Me._PageIndex
            End Get
            Set(ByVal value As Integer)
                Me._PageIndex = value
            End Set
        End Property
    
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
            End Set
        End Property
    
        Private _TotalRecords As Integer
        Public Property TotalRecords() As Integer
            Get
                Return Me._TotalRecords
            End Get
            Set(ByVal value As Integer)
                If Me.PageSize > 0 Then
                    Me.TotalPages = CInt(Math.Ceiling(value / Me.PageSize))
                End If

                Me._TotalRecords = value
            End Set
        End Property
        
        Private _DisplayLastPage As Boolean
        Public Property DisplayLastPage() As Boolean
            Get
                Return Me._DisplayLastPage
            End Get
            Set(ByVal value As Boolean)
                Me._DisplayLastPage = value
            End Set
        End Property
        
        

#Region "Helper Properties"
        
        Public ReadOnly Property id_pro_inv_hdr() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_pro_inv_hdr"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_pro_inv_hdrAddRecordLink() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_pro_inv_hdrAddRecordLink"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property id_pro_inv_hdrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_pro_inv_hdrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_taxesAddRecordLink() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxesAddRecordLink"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxesLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxesLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_taxesTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_taxesTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tax_amount() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_amount"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_amountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_amountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tax_code() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_code"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_codeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_codeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tax_name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tax_print() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_print"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tax_printLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_printLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Pro_inv_taxesRecord = Nothing
             
        
            Try
                rec = Me.GetRecord()
            Catch ex As Exception
                ' Do nothing
            End Try

            If rec Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                ' Localization.
                
            Throw New Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "ServelInvocing"))
                    
            End If
            Return EvaluateExpressions(url, arg, rec, bEncrypt)
        End Function

         
        Public Overridable Function GetRecord() As Pro_inv_taxesRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Pro_inv_taxesTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Throw New Exception(Page.GetResourceValue("Err:RetrieveRec", "ServelInvocing"))
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

#End Region
    
  
End Namespace

  