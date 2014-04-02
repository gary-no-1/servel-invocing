
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowTax_groupsTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowTax_groupsTable

#Region "Section 1: Place your customizations here."

    
Public Class Tax_groupsTableControlRow
        Inherits BaseTax_groupsTableControlRow
        ' The BaseTax_groupsTableControlRow implements code for a ROW within the
        ' the Tax_groupsTableControl table.  The BaseTax_groupsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Tax_groupsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Tax_groupsTableControl
        Inherits BaseTax_groupsTableControl

    ' The BaseTax_groupsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Tax_groupsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Tax_groupsTableControlRow control on the ShowTax_groupsTable page.
' Do not modify this class. Instead override any method in Tax_groupsTableControlRow.
Public Class BaseTax_groupsTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Tax_groupsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Tax_groupsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.Tax_groupsRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.Tax_groupsRowCopyButton.Click, AddressOf Tax_groupsRowCopyButton_Click
              
              AddHandler Me.Tax_groupsRowDeleteButton.Click, AddressOf Tax_groupsRowDeleteButton_Click
              
              AddHandler Me.Tax_groupsRowEditButton.Click, AddressOf Tax_groupsRowEditButton_Click
              
              AddHandler Me.Tax_groupsRowViewButton.Click, AddressOf Tax_groupsRowViewButton_Click
              
              AddHandler Me.id_taxes_1.Click, AddressOf id_taxes_1_Click
            
              AddHandler Me.id_taxes_2.Click, AddressOf id_taxes_2_Click
            
              AddHandler Me.id_taxes_3.Click, AddressOf id_taxes_3_Click
            
              AddHandler Me.id_taxes_4.Click, AddressOf id_taxes_4_Click
            
              AddHandler Me.id_taxes_5.Click, AddressOf id_taxes_5_Click
            
              AddHandler Me.id_taxes_6.Click, AddressOf id_taxes_6_Click
            
              AddHandler Me.id_taxes_7.Click, AddressOf id_taxes_7_Click
            
              AddHandler Me.id_taxes_8.Click, AddressOf id_taxes_8_Click
            
              AddHandler Me.id_taxes_9.Click, AddressOf id_taxes_9_Click
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource tax_groups record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Tax_groupsTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseTax_groupsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Tax_groupsRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Tax_groupsTableControlRow.
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
        
            Setid_taxes_1()
            Setid_taxes_2()
            Setid_taxes_3()
            Setid_taxes_4()
            Setid_taxes_5()
            Setid_taxes_6()
            Setid_taxes_7()
            Setid_taxes_8()
            Setid_taxes_9()
            Setnotes()
            Settax_group_code()
      
      
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
        
        
        Public Overridable Sub Setid_taxes_1()
            
        
            ' Set the id_taxes_1 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_1 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_1Specified Then
                				
                ' If the id_taxes_1 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_1)
                            
                Me.id_taxes_1.Text = formattedValue
              
            Else 
            
                ' id_taxes_1 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_1.Text = Tax_groupsTable.id_taxes_1.Format(Tax_groupsTable.id_taxes_1.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_2()
            
        
            ' Set the id_taxes_2 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_2 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_2Specified Then
                				
                ' If the id_taxes_2 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_2)
                            
                Me.id_taxes_2.Text = formattedValue
              
            Else 
            
                ' id_taxes_2 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_2.Text = Tax_groupsTable.id_taxes_2.Format(Tax_groupsTable.id_taxes_2.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_3()
            
        
            ' Set the id_taxes_3 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_3 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_3()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_3Specified Then
                				
                ' If the id_taxes_3 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_3)
                            
                Me.id_taxes_3.Text = formattedValue
              
            Else 
            
                ' id_taxes_3 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_3.Text = Tax_groupsTable.id_taxes_3.Format(Tax_groupsTable.id_taxes_3.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_4()
            
        
            ' Set the id_taxes_4 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_4 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_4()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_4Specified Then
                				
                ' If the id_taxes_4 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_4)
                            
                Me.id_taxes_4.Text = formattedValue
              
            Else 
            
                ' id_taxes_4 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_4.Text = Tax_groupsTable.id_taxes_4.Format(Tax_groupsTable.id_taxes_4.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_5()
            
        
            ' Set the id_taxes_5 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_5 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_5()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_5Specified Then
                				
                ' If the id_taxes_5 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_5)
                            
                Me.id_taxes_5.Text = formattedValue
              
            Else 
            
                ' id_taxes_5 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_5.Text = Tax_groupsTable.id_taxes_5.Format(Tax_groupsTable.id_taxes_5.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_6()
            
        
            ' Set the id_taxes_6 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_6 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_6()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_6Specified Then
                				
                ' If the id_taxes_6 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_6)
                            
                Me.id_taxes_6.Text = formattedValue
              
            Else 
            
                ' id_taxes_6 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_6.Text = Tax_groupsTable.id_taxes_6.Format(Tax_groupsTable.id_taxes_6.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_7()
            
        
            ' Set the id_taxes_7 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_7 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_7()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_7Specified Then
                				
                ' If the id_taxes_7 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_7)
                            
                Me.id_taxes_7.Text = formattedValue
              
            Else 
            
                ' id_taxes_7 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_7.Text = Tax_groupsTable.id_taxes_7.Format(Tax_groupsTable.id_taxes_7.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_8()
            
        
            ' Set the id_taxes_8 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_8 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_8()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_8Specified Then
                				
                ' If the id_taxes_8 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_8)
                            
                Me.id_taxes_8.Text = formattedValue
              
            Else 
            
                ' id_taxes_8 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_8.Text = Tax_groupsTable.id_taxes_8.Format(Tax_groupsTable.id_taxes_8.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_taxes_9()
            
        
            ' Set the id_taxes_9 LinkButton on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.id_taxes_9 is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_taxes_9()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_taxes_9Specified Then
                				
                ' If the id_taxes_9 is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.id_taxes_9)
                            
                Me.id_taxes_9.Text = formattedValue
              
            Else 
            
                ' id_taxes_9 is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_taxes_9.Text = Tax_groupsTable.id_taxes_9.Format(Tax_groupsTable.id_taxes_9.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setnotes()
            
        
            ' Set the notes Literal on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.notes is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setnotes()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.notesSpecified Then
                				
                ' If the notes is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.notes)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                    Dim popupThreshold as Integer = CType(100, Integer)
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(100, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(100, Integer)
                        
                    End If
                                
                    ' For fields values larger than the PopupTheshold on Properties, display a popup.
                    If Len(formattedValue) >= popupThreshold Then
                    
                        formattedValue= "<a onclick = 'gPersist=true;' onmouseout='detailRolloverPopupClose();' " _
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ServelInvocing.Business.Tax_groupsTable, ServelInvocing.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""notes\"", \""notes\"", \""Notes\"", false, 200," _
                            & " 300, true, PopupDisplayWindowCallBackWith20);"", 500);'>" &  NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, maxLength))
                        
                        If (maxLength = CType(100, Integer)) Then
                            formattedValue = formattedValue & "..." & "</a>"
                        Else
                            formattedValue = formattedValue & "</a>"
                            
                        End If
                    Else
                        If maxLength = CType(100, Integer) Then
                            formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,MaxLength))
                            formattedValue = formattedValue & "..."
                            
                        End If
                    End If
                End If  
                
                Me.notes.Text = formattedValue
              
            Else 
            
                ' notes is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.notes.Text = Tax_groupsTable.notes.Format(Tax_groupsTable.notes.DefaultValue)
                        		
                End If
                 
            ' If the notes is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.notes.Text Is Nothing _
                OrElse Me.notes.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.notes.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settax_group_code()
            
        
            ' Set the tax_group_code Literal on the webpage with value from the
            ' tax_groups database record.

            ' Me.DataSource is the tax_groups record retrieved from the database.
            ' Me.tax_group_code is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_group_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_group_codeSpecified Then
                				
                ' If the tax_group_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Tax_groupsTable.tax_group_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tax_group_code.Text = formattedValue
              
            Else 
            
                ' tax_group_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_group_code.Text = Tax_groupsTable.tax_group_code.Format(Tax_groupsTable.tax_group_code.DefaultValue)
                        		
                End If
                 
            ' If the tax_group_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tax_group_code.Text Is Nothing _
                OrElse Me.tax_group_code.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tax_group_code.Text = "&nbsp;"
            End If
                  
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

      
        
        ' To customize, override this method in Tax_groupsTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
              
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
              
                DirectCast(GetParentControlObject(Me, "Tax_groupsTableControl"), Tax_groupsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Tax_groupsTableControl"), Tax_groupsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Tax_groupsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getid_taxes_1()
            Getid_taxes_2()
            Getid_taxes_3()
            Getid_taxes_4()
            Getid_taxes_5()
            Getid_taxes_6()
            Getid_taxes_7()
            Getid_taxes_8()
            Getid_taxes_9()
            Getnotes()
            Gettax_group_code()
        End Sub
        
        
        Public Overridable Sub Getid_taxes_1()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_2()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_3()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_4()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_5()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_6()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_7()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_8()
            
        End Sub
                
        Public Overridable Sub Getid_taxes_9()
            
        End Sub
                
        Public Overridable Sub Getnotes()
            
        End Sub
                
        Public Overridable Sub Gettax_group_code()
            
        End Sub
                
      
        ' To customize, override this method in Tax_groupsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Tax_groupsTableControlRow.
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
          Tax_groupsTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Tax_groupsTableControl"), Tax_groupsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Tax_groupsTableControl"), Tax_groupsTableControl).ResetData = True
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
        
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsRowCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/AddTax_groups.aspx?Tax_groups={PK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                  Me.Delete()
              
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsRowEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/EditTax_groups.aspx?Tax_groups={PK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsRowViewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/ShowTax_groups.aspx?Tax_groups={PK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_1_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_1_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_2_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_2_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_3_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_3_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_4_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_4_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_5_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_5_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_6_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_6_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_7_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_7_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_8_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_8_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for LinkButton
        Public Overridable Sub id_taxes_9_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../taxes/ShowTaxes.aspx?Taxes={Tax_groupsTableControlRow:FK:tax_groups_taxes_id_taxes_9_FK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If
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
                Return CType(Me.ViewState("BaseTax_groupsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseTax_groupsTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Tax_groupsRecord
        Public Property DataSource() As Tax_groupsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Tax_groupsRecord)
            
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
        
        Public ReadOnly Property id_taxes_1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_4() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_4"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_5() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_5"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_6() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_6"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_7() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_7"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_8() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_8"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_taxes_9() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_9"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property notes() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "notes"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tax_group_code() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_group_code"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Tax_groupsRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsRowCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsRowCopyButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsRowEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsRowEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsRowViewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsRowViewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Tax_groupsRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Tax_groupsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Tax_groupsTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Tax_groupsTableControl control on the ShowTax_groupsTable page.
' Do not modify this class. Instead override any method in Tax_groupsTableControl.
Public Class BaseTax_groupsTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.Tax_groupsSearch) 				
                    initialVal = Me.GetFromSession(Me.Tax_groupsSearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.Tax_groupsSearch.Text = initialVal
                            
                    End If
                
            End If
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
              ' Show confirmation message on Click
              Me.Tax_groupsDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.Tax_groupsPagination.FirstPage.Click, AddressOf Tax_groupsPagination_FirstPage_Click
              
              AddHandler Me.Tax_groupsPagination.LastPage.Click, AddressOf Tax_groupsPagination_LastPage_Click
              
              AddHandler Me.Tax_groupsPagination.NextPage.Click, AddressOf Tax_groupsPagination_NextPage_Click
              
              AddHandler Me.Tax_groupsPagination.PageSizeButton.Click, AddressOf Tax_groupsPagination_PageSizeButton_Click
            
              AddHandler Me.Tax_groupsPagination.PreviousPage.Click, AddressOf Tax_groupsPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.id_taxes_1Label1.Click, AddressOf id_taxes_1Label1_Click
            
              AddHandler Me.id_taxes_2Label1.Click, AddressOf id_taxes_2Label1_Click
            
              AddHandler Me.id_taxes_3Label.Click, AddressOf id_taxes_3Label_Click
            
              AddHandler Me.id_taxes_4Label.Click, AddressOf id_taxes_4Label_Click
            
              AddHandler Me.id_taxes_5Label.Click, AddressOf id_taxes_5Label_Click
            
              AddHandler Me.id_taxes_6Label.Click, AddressOf id_taxes_6Label_Click
            
              AddHandler Me.id_taxes_7Label.Click, AddressOf id_taxes_7Label_Click
            
              AddHandler Me.id_taxes_8Label.Click, AddressOf id_taxes_8Label_Click
            
              AddHandler Me.id_taxes_9Label.Click, AddressOf id_taxes_9Label_Click
            
              AddHandler Me.notesLabel.Click, AddressOf notesLabel_Click
            
              AddHandler Me.tax_group_codeLabel.Click, AddressOf tax_group_codeLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.Tax_groupsCopyButton.Click, AddressOf Tax_groupsCopyButton_Click
              
              AddHandler Me.Tax_groupsDeleteButton.Click, AddressOf Tax_groupsDeleteButton_Click
              
              AddHandler Me.Tax_groupsEditButton.Click, AddressOf Tax_groupsEditButton_Click
              
              AddHandler Me.Tax_groupsExportCSVButton.Click, AddressOf Tax_groupsExportCSVButton_Click
              
              AddHandler Me.Tax_groupsExportExcelButton.Click, AddressOf Tax_groupsExportExcelButton_Click
              
              AddHandler Me.Tax_groupsImportButton.Click, AddressOf Tax_groupsImportButton_Click
              
              AddHandler Me.Tax_groupsNewButton.Click, AddressOf Tax_groupsNewButton_Click
              
              AddHandler Me.Tax_groupsPDFButton.Click, AddressOf Tax_groupsPDFButton_Click
              
              AddHandler Me.Tax_groupsRefreshButton.Click, AddressOf Tax_groupsRefreshButton_Click
              
              AddHandler Me.Tax_groupsResetButton.Click, AddressOf Tax_groupsResetButton_Click
              
              AddHandler Me.Tax_groupsWordButton.Click, AddressOf Tax_groupsWordButton_Click
              
            AddHandler Me.Tax_groupsSearchButton.Button.Click, AddressOf Tax_groupsSearchButton_Click
        
          ' Setup events for others
            
        End Sub
        
        
        Public Overridable Sub LoadData()
            ' Read data from database. Returns an array of records that can be assigned
            ' to the DataSource table control property.
            Try	
                
                ' The WHERE clause will be empty when displaying all records in table.
                Dim wc As WhereClause = CreateWhereClause()
                If wc IsNot Nothing AndAlso Not wc.RunQuery Then
                    ' Initialize an empty array of records
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Tax_groupsRecord)), Tax_groupsRecord())
                    ' Add records to the list if needed.
                    Me.AddNewRecords()
                    Return
                End If

                ' Call OrderBy to determine the order - either use the order defined
                ' on the Query Wizard, or specified by user (by clicking on column heading)
                Dim orderBy As OrderBy = CreateOrderBy()
                
                ' Get the pagesize from the pagesize control.
                Me.GetPageSize()
                
                ' Get the total number of records to be displayed.
                
                Me.TotalRecords = Tax_groupsTable.GetRecordCount(wc)
                              
                ' Make sure PageIndex (current page) is within bounds.
                If Me.TotalPages <= 0 OrElse Me.PageIndex < 0 Then
                    Me.PageIndex = 0
                ElseIf Me.DisplayLastPage OrElse Me.PageIndex >= Me.TotalPages Then
                    Me.PageIndex = Me.TotalPages - 1
                End If

                ' Retrieve the records and set the table DataSource.
                ' Only PageSize records are fetched starting at PageIndex (zero based).
                If Me.TotalRecords <= 0 Then
                    ' No records matching query. Initialize an empty array of records
                    
                    Dim alist As New ArrayList(0)
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Tax_groupsRecord)), Tax_groupsRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Tax_groupsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Tax_groupsRecord)), Tax_groupsRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Tax_groupsTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.Tax_groupsToggleAll.Checked = False
            

                ' Initialize the page and grand totals. now
            
            Catch ex As Exception
                ' Report the error message to the end user
                Dim msg As String = ex.Message
                If ex.InnerException IsNot Nothing Then
                    msg = msg & " InnerException: " & ex.InnerException.Message
                End If
                Throw New Exception(msg, ex.InnerException)
            End Try
        End Sub
        
        
        Public Overrides Sub DataBind()
            ' The DataBind method binds the user interface controls to the values
            ' from the database record for each row in the table.  To do this, it calls the
            ' DataBind for each of the rows.
            ' DataBind also populates any filters above the table, and sets the pagination
            ' control to the correct number of records and the current page number.
            
            MyBase.DataBind()

            ' Make sure that the DataSource is initialized.
            If Me.DataSource Is Nothing Then
                Return
            End If
      
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            Setid_taxes_1Label1()
            Setid_taxes_2Label1()
            Setid_taxes_3Label()
            Setid_taxes_4Label()
            Setid_taxes_5Label()
            Setid_taxes_6Label()
            Setid_taxes_7Label()
            Setid_taxes_8Label()
            Setid_taxes_9Label()
            SetnotesLabel()
            Settax_group_codeLabel()
            SetTax_groupsSearch()
            
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Tax_groupsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Tax_groupsTableControlRow = DirectCast(repItem.FindControl("Tax_groupsTableControlRow"), Tax_groupsTableControlRow) 
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If				
                recControl.DataBind()
                recControl.Visible = Not Me.InDeletedRecordIds(recControl)
                index += 1
            Next

        
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                

            ' Initialize other asp controls
            
            Setid_taxes_1Label1()
            Setid_taxes_2Label1()
            Setid_taxes_3Label()
            Setid_taxes_4Label()
            Setid_taxes_5Label()
            Setid_taxes_6Label()
            Setid_taxes_7Label()
            Setid_taxes_8Label()
            Setid_taxes_9Label()
            SetnotesLabel()
            Settax_group_codeLabel()
      End Sub

      
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_1, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_2, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_3, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_4, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_5, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_6, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_7, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_8, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Tax_groupsTable.id_taxes_9, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Tax_groupsExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Tax_groupsExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Tax_groupsPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Tax_groupsWordButton"))
                        
        
        End Sub
        
        Public Overridable Function EvaluateFormula(ByVal formula As String, Optional ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord = Nothing, Optional ByVal format as String = Nothing) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            ' Define the calling control.  This is used to add other 
            ' related table and record controls as variables.
            e.CallingControl = Me

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            If format IsNot Nothing Then
                Return FormulaUtils.Format(resultObj, format)
            Else
                Return resultObj.ToString()
            End If
        End Function			

        Public Overridable Sub ResetControl()
                    
            Me.Tax_groupsSearch.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Tax_groupsTableControl pagination.
        
            Me.Tax_groupsPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.Tax_groupsPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Tax_groupsPagination.LastPage.Enabled = False
            End If
          
            Me.Tax_groupsPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Tax_groupsPagination.NextPage.Enabled = False
            End If
          
            Me.Tax_groupsPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.Tax_groupsPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Tax_groupsPagination.CurrentPage.Text = "0"
            End If
            Me.Tax_groupsPagination.PageSize.Text = Me.PageSize.ToString()
            Me.Tax_groupsPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Tax_groupsPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Tax_groupsTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If Me.InDeletedRecordIds(recCtl) Then
                    ' Delete any pending deletes. 
                    recCtl.Delete()
                Else
                    If recCtl.Visible Then
                        recCtl.SaveData()
                    End If
                End If
          
            Next
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
          
            ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            For Each recCtl In Me.GetRecordControls()
                recCtl.IsNewRecord = False
            Next
    
      
            ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            Me.DeletedRecordIds = Nothing
      
        End Sub

        
          Public Overridable Function CreateOrderBy() As OrderBy
          ' The CurrentSortOrder is initialized to the sort order on the
          ' Query Wizard.  It may be modified by the Click handler for any of
          ' the column heading to sort or reverse sort by that column.
          ' You can add your own sort order, or modify it on the Query Wizard.
          Return Me.CurrentSortOrder
          End Function
      
        Public Overridable Function CreateWhereClause() As WhereClause
            'This CreateWhereClause is used for loading the data.
            Tax_groupsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.Tax_groupsSearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.Tax_groupsSearch.Text.StartsWith("...") Then
                    Me.Tax_groupsSearch.Text = Me.Tax_groupsSearch.Text.SubString(3,Me.Tax_groupsSearch.Text.Length-3)
                End If
                If Me.Tax_groupsSearch.Text.EndsWith("...") then
                    Me.Tax_groupsSearch.Text = Me.Tax_groupsSearch.Text.SubString(0,Me.Tax_groupsSearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.Tax_groupsSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(Tax_groupsTable.tax_group_code, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_1, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_2, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_3, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_4, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_5, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_6, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_7, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_8, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    search.iOR(Tax_groupsTable.id_taxes_9, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Tax_groupsSearch, Me.GetFromSession(Me.Tax_groupsSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Tax_groupsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            If IsValueSelected(searchText) and fromSearchControl = "Tax_groupsSearch" Then
                Dim formatedSearchText as String = searchText
                ' strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If searchText.StartsWith("...") Then
                    formatedSearchText = searchText.SubString(3,searchText.Length-3)
                End If
                If searchText.EndsWith("...") Then
                    formatedSearchText = searchText.SubString(0,searchText.Length-3)
                End If
                'After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim()
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(formatedSearchText) Then
                      ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    If InvariantLCase(AutoTypeAheadSearch).equals("wordsstartingwithsearchstring") Then
                
                        search.iOR(Tax_groupsTable.tax_group_code, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.tax_group_code, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_1, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_1, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_2, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_2, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_3, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_3, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_4, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_4, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_5, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_5, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_6, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_6, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_7, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_7, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_8, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_8, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Tax_groupsTable.id_taxes_9, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_9, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(Tax_groupsTable.tax_group_code, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_1, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_2, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_3, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_4, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_5, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_6, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_7, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_8, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Tax_groupsTable.id_taxes_9, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_Tax_groupsSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"Tax_groupsSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.Tax_groupsRecord = Tax_groupsTable.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As Tax_groupsRecord = Nothing
                Dim resultItem As String = ""
                For Each rec In recordList 
                    ' Exit the loop if recordList count has reached AutoTypeAheadListSize.
                    If resultList.Count >= count then
                        Exit For
                    End If
                    ' If the field is configured to Display as Foreign key, Format() method returns the 
                    ' Display as Forien Key value instead of original field value.
                    ' Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                    ' We need to find relevent field to display which matches the prefixText and is not already present in the result list.
                
                    resultItem = rec.Format(Tax_groupsTable.tax_group_code)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_1)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_2)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_3)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_4)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_5)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_6)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_7)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_8)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Tax_groupsTable.id_taxes_9)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                Next
                ' Exit the loop if number of records found is less as further iteration will not return any more records
                If recordList .Length < 100 Then
                    Exit While
                End If
                iteration += 1
            End While
             
            resultList.Sort()
            Dim result() As String = New String(resultList.Count - 1) {}
            Array.Copy(resultList.ToArray, result, resultList.Count)
            Return result
        End Function
          
          
        Public Overridable Function FormatSuggestions(ByVal prefixText As String, ByVal resultItem As String, _
                                                 ByVal columnLength As Integer, ByVal AutoTypeAheadDisplayFoundText As String, _
                                                 ByVal autoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String, _
                                                 ByVal resultList As ArrayList) As Boolean
                                                 
            'Formats the resultItem and adds it to the list of suggestions.
            Dim index As Integer = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))
            Dim itemToAdd As String = ""
            Dim isFound As Boolean = False
            Dim isAdded As Boolean = False
            ' Get the index where prfixt is at the beginning of resultItem. If not found then, index of word which begins with prefixText.
            If InvariantLCase(autoTypeAheadSearch).equals("wordsstartingwithsearchstring") And Not index = 0 Then
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
                        if index = Len(resultItem) Then   'Make decision to append "..."
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
        
    
        Protected Overridable Sub GetPageSize()
        
            If Me.Tax_groupsPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Tax_groupsPagination.PageSize.Text)
                Catch ex As Exception
                End Try
            End If
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Tax_groupsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Tax_groupsTableControlRow = DirectCast(repItem.FindControl("Tax_groupsTableControlRow"), Tax_groupsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Tax_groupsRecord = New Tax_groupsRecord()
        
                        If recControl.id_taxes_1.Text <> "" Then
                            rec.Parse(recControl.id_taxes_1.Text, Tax_groupsTable.id_taxes_1)
                        End If
                        If recControl.id_taxes_2.Text <> "" Then
                            rec.Parse(recControl.id_taxes_2.Text, Tax_groupsTable.id_taxes_2)
                        End If
                        If recControl.id_taxes_3.Text <> "" Then
                            rec.Parse(recControl.id_taxes_3.Text, Tax_groupsTable.id_taxes_3)
                        End If
                        If recControl.id_taxes_4.Text <> "" Then
                            rec.Parse(recControl.id_taxes_4.Text, Tax_groupsTable.id_taxes_4)
                        End If
                        If recControl.id_taxes_5.Text <> "" Then
                            rec.Parse(recControl.id_taxes_5.Text, Tax_groupsTable.id_taxes_5)
                        End If
                        If recControl.id_taxes_6.Text <> "" Then
                            rec.Parse(recControl.id_taxes_6.Text, Tax_groupsTable.id_taxes_6)
                        End If
                        If recControl.id_taxes_7.Text <> "" Then
                            rec.Parse(recControl.id_taxes_7.Text, Tax_groupsTable.id_taxes_7)
                        End If
                        If recControl.id_taxes_8.Text <> "" Then
                            rec.Parse(recControl.id_taxes_8.Text, Tax_groupsTable.id_taxes_8)
                        End If
                        If recControl.id_taxes_9.Text <> "" Then
                            rec.Parse(recControl.id_taxes_9.Text, Tax_groupsTable.id_taxes_9)
                        End If
                        If recControl.notes.Text <> "" Then
                            rec.Parse(recControl.notes.Text, Tax_groupsTable.notes)
                        End If
                        If recControl.tax_group_code.Text <> "" Then
                            rec.Parse(recControl.tax_group_code.Text, Tax_groupsTable.tax_group_code)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Tax_groupsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Tax_groupsRecord)), Tax_groupsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Tax_groupsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Tax_groupsTableControlRow) As Boolean
            If Me.DeletedRecordIds Is Nothing OrElse Me.DeletedRecordIds.Trim = "" Then
                Return False
            End If

            Return Me.DeletedRecordIds.IndexOf("[" & rec.RecordUniqueId & "]") >= 0
        End Function

        Private _DeletedRecordIds As String
        Public Property DeletedRecordIds() As String
            Get
                Return Me._DeletedRecordIds
            End Get
            Set(ByVal value As String)
                Me._DeletedRecordIds = value
            End Set
        End Property
        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub Setid_taxes_1Label1()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_2Label1()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_3Label()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_4Label()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_5Label()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_6Label()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_7Label()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_8Label()
            
                    
        End Sub
                
        Public Overridable Sub Setid_taxes_9Label()
            
                    
        End Sub
                
        Public Overridable Sub SetnotesLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_group_codeLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetTax_groupsSearch()
            
        End Sub	
            
        Protected Overridable Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.PreRender
            ' PreRender event is raised just before page is being displayed.
            Try
                DbUtils.StartTransaction
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
                DbUtils.EndTransaction
            End Try
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            Me.SaveToSession(Me.Tax_groupsSearch, Me.Tax_groupsSearch.Text)
                  
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
            Me.SaveToSession(Me, "DeletedRecordIds", Me.DeletedRecordIds)  
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
      Me.SaveToSession("Tax_groupsSearch_Ajax", Me.Tax_groupsSearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.Tax_groupsSearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Tax_groupsTableControl_OrderBy"), String)
            
            If orderByStr IsNot Nothing AndAlso orderByStr.Trim <> "" Then
                Me.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr)
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            End If
            
            Dim pageIndex As String = CType(ViewState("Page_Index"), String)
            If pageIndex IsNot Nothing Then
                Me.PageIndex = CInt(pageIndex)
            End If

            Dim pageSize As String = CType(ViewState("Page_Size"), String)
            If Not pageSize Is Nothing Then
                Me.PageSize = CInt(pageSize)
            End If
        
            Me.DeletedRecordIds = CType(Me.ViewState("DeletedRecordIds"), String)
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("Tax_groupsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex = 0
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.DisplayLastPage = True
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Me.PageIndex += 1
            Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for LinkButton
        Public Overridable Sub Tax_groupsPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.Tax_groupsPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.Tax_groupsPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            If Me.PageIndex > 0 Then
                Me.PageIndex -= 1
                Me.DataChanged = True
            End If
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        

        ' Generate the event handling functions for sorting events.
        
        Public Overridable Sub id_taxes_1Label1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_1 when clicked.
              
            ' Get previous sorting state for id_taxes_1.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_1)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_1.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_1, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_1, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_2Label1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_2 when clicked.
              
            ' Get previous sorting state for id_taxes_2.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_2)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_2.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_2, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_2, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_3Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_3 when clicked.
              
            ' Get previous sorting state for id_taxes_3.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_3)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_3.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_3, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_3, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_4Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_4 when clicked.
              
            ' Get previous sorting state for id_taxes_4.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_4)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_4.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_4, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_4, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_5Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_5 when clicked.
              
            ' Get previous sorting state for id_taxes_5.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_5)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_5.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_5, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_5, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_6Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_6 when clicked.
              
            ' Get previous sorting state for id_taxes_6.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_6)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_6.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_6, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_6, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_7Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_7 when clicked.
              
            ' Get previous sorting state for id_taxes_7.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_7)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_7.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_7, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_7, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_8Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_8 when clicked.
              
            ' Get previous sorting state for id_taxes_8.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_8)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_8.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_8, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_8, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_taxes_9Label_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_taxes_9 when clicked.
              
            ' Get previous sorting state for id_taxes_9.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.id_taxes_9)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_taxes_9.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.id_taxes_9, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_taxes_9, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub notesLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by notes when clicked.
              
            ' Get previous sorting state for notes.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.notes)
            If sd Is Nothing Then
                ' First time sort, so add sort order for notes.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.notes, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by notes, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tax_group_codeLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tax_group_code when clicked.
              
            ' Get previous sorting state for tax_group_code.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Tax_groupsTable.tax_group_code)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tax_group_code.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Tax_groupsTable.tax_group_code, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tax_group_code, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/AddTax_groups.aspx?Tax_groups={PK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(False)
          
            End If
      Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/EditTax_groups.aspx?Tax_groups={PK}"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                	
          ' Build the where clause based on the current filter and search criteria
          ' Create the Order By clause based on the user's current sorting preference.
          
              Dim wc As WhereClause = CreateWhereClause
              Dim orderBy As OrderBy = Nothing
              
              orderBy = CreateOrderBy
              
            ' Add each of the columns in order of export.
            Dim columns() as BaseColumn = New BaseColumn() { _
                       Tax_groupsTable.tax_group_code, _ 
             Tax_groupsTable.notes, _ 
             Tax_groupsTable.id_taxes_1, _ 
             Tax_groupsTable.id_taxes_2, _ 
             Tax_groupsTable.id_taxes_3, _ 
             Tax_groupsTable.id_taxes_4, _ 
             Tax_groupsTable.id_taxes_5, _ 
             Tax_groupsTable.id_taxes_6, _ 
             Tax_groupsTable.id_taxes_7, _ 
             Tax_groupsTable.id_taxes_8, _ 
             Tax_groupsTable.id_taxes_9, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(Tax_groupsTable.Instance, wc, orderBy, columns)
            exportData.Export(Me.Page.Response)
        Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            ' To customize the columns or the format, override this function in Section 1 of the page 
            ' and modify it to your liking.
            ' Build the where clause based on the current filter and search criteria
            ' Create the Order By clause based on the user's current sorting preference.
          
              Dim wc As WhereClause = CreateWhereClause
              Dim orderBy As OrderBy = Nothing
              
              orderBy = CreateOrderBy
              
            ' Create an instance of the Excel report class with the table class, where clause and order by.
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(Tax_groupsTable.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.tax_group_code, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.notes, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_1, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_2, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_3, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_4, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_5, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_6, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_7, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_8, "Default"))
             excelReport.AddColumn(New ExcelColumn(Tax_groupsTable.id_taxes_9, "Default"))

            excelReport.Export(Me.Page.Response)
            Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/SelectFileToImport.aspx?TableName=Tax_groups"
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Dim script As String = "window.open('" &  Me.Page.EncryptUrlParameter(url) &  "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes');"
            'If (Not Me.Page.ClientScript.IsStartupScriptRegistered("OpenPopup")) Then
            ScriptManager.RegisterStartupScript(Me.Page, Page.GetType(), "OpenPopup", script, True)
            'End If
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsNewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/AddTax_groups.aspx"
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            url = Me.ModifyRedirectUrl(url, "",False)
            url = Me.Page.ModifyRedirectUrl(url, "",False)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                shouldRedirect = False
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.Page.ShouldSaveControlsToSession = True
                Me.Page.Response.Redirect(url)
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.Page.ShouldSaveControlsToSession = True
            Me.Page.CloseWindow(True)
        
            End If              
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowTax_groupsTable.Tax_groupsPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "tax_groups"
                ' If ShowTax_groupsTable.Tax_groupsPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(Tax_groupsTable.tax_group_code.Name, ReportEnum.Align.Left, "${tax_group_code}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Tax_groupsTable.notes.Name, ReportEnum.Align.Left, "${notes}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Tax_groupsTable.id_taxes_1.Name, ReportEnum.Align.Left, "${id_taxes_1}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_2.Name, ReportEnum.Align.Left, "${id_taxes_2}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_3.Name, ReportEnum.Align.Left, "${id_taxes_3}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_4.Name, ReportEnum.Align.Left, "${id_taxes_4}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_5.Name, ReportEnum.Align.Left, "${id_taxes_5}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_6.Name, ReportEnum.Align.Left, "${id_taxes_6}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_7.Name, ReportEnum.Align.Left, "${id_taxes_7}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_8.Name, ReportEnum.Align.Left, "${id_taxes_8}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_9.Name, ReportEnum.Align.Left, "${id_taxes_9}", ReportEnum.Align.Left, 24)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = Tax_groupsTable.GetRecordCount(whereClause)
                Dim columns As ColumnList = Tax_groupsTable.GetColumnList()
                Dim records As Tax_groupsRecord() = Nothing
            
                Do 
                    
                    records = Tax_groupsTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As Tax_groupsRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${tax_group_code}", record.Format(Tax_groupsTable.tax_group_code), ReportEnum.Align.Left, 100)
                             report.AddData("${notes}", record.Format(Tax_groupsTable.notes), ReportEnum.Align.Left, 100)
                             report.AddData("${id_taxes_1}", record.Format(Tax_groupsTable.id_taxes_1), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_2}", record.Format(Tax_groupsTable.id_taxes_2), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_3}", record.Format(Tax_groupsTable.id_taxes_3), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_4}", record.Format(Tax_groupsTable.id_taxes_4), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_5}", record.Format(Tax_groupsTable.id_taxes_5), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_6}", record.Format(Tax_groupsTable.id_taxes_6), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_7}", record.Format(Tax_groupsTable.id_taxes_7), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_8}", record.Format(Tax_groupsTable.id_taxes_8), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_9}", record.Format(Tax_groupsTable.id_taxes_9), ReportEnum.Align.Left)

                            report.WriteRow 
                        Next 
                        pageNum = pageNum + 1
                        recordCount += records.Length 
                    End If 
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows  AndAlso whereClause.RunQuery 
                
                report.Close 
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim Tax_groupsTableControlObj as Tax_groupsTableControl = DirectCast(Me.Page.FindControlRecursively("Tax_groupsTableControl"), Tax_groupsTableControl)
            Tax_groupsTableControlObj.ResetData = True
                        
            Tax_groupsTableControlObj.RemoveFromSession(Tax_groupsTableControlObj, "DeletedRecordIds")
            Tax_groupsTableControlObj.DeletedRecordIds = Nothing
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.Tax_groupsSearch.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
              End If
              

        ' Setting the DataChanged to True results in the page being refreshed with
        ' the most recent data from the database.  This happens in PreRender event
        ' based on the current sort, search and filter criteria.
        Me.DataChanged = True
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Tax_groupsWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowTax_groupsTable.Tax_groupsWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "tax_groups"
                ' If ShowTax_groupsTable.Tax_groupsWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(Tax_groupsTable.tax_group_code.Name, ReportEnum.Align.Left, "${tax_group_code}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Tax_groupsTable.notes.Name, ReportEnum.Align.Left, "${notes}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Tax_groupsTable.id_taxes_1.Name, ReportEnum.Align.Left, "${id_taxes_1}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_2.Name, ReportEnum.Align.Left, "${id_taxes_2}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_3.Name, ReportEnum.Align.Left, "${id_taxes_3}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_4.Name, ReportEnum.Align.Left, "${id_taxes_4}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_5.Name, ReportEnum.Align.Left, "${id_taxes_5}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_6.Name, ReportEnum.Align.Left, "${id_taxes_6}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_7.Name, ReportEnum.Align.Left, "${id_taxes_7}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_8.Name, ReportEnum.Align.Left, "${id_taxes_8}", ReportEnum.Align.Left, 24)
                 report.AddColumn(Tax_groupsTable.id_taxes_9.Name, ReportEnum.Align.Left, "${id_taxes_9}", ReportEnum.Align.Left, 24)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = Tax_groupsTable.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = Tax_groupsTable.GetColumnList()
                Dim records As Tax_groupsRecord() = Nothing
                Do
                    records = Tax_groupsTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As Tax_groupsRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${tax_group_code}", record.Format(Tax_groupsTable.tax_group_code), ReportEnum.Align.Left, 100)
                             report.AddData("${notes}", record.Format(Tax_groupsTable.notes), ReportEnum.Align.Left, 100)
                             report.AddData("${id_taxes_1}", record.Format(Tax_groupsTable.id_taxes_1), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_2}", record.Format(Tax_groupsTable.id_taxes_2), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_3}", record.Format(Tax_groupsTable.id_taxes_3), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_4}", record.Format(Tax_groupsTable.id_taxes_4), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_5}", record.Format(Tax_groupsTable.id_taxes_5), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_6}", record.Format(Tax_groupsTable.id_taxes_6), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_7}", record.Format(Tax_groupsTable.id_taxes_7), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_8}", record.Format(Tax_groupsTable.id_taxes_8), ReportEnum.Align.Left)
                             report.AddData("${id_taxes_9}", record.Format(Tax_groupsTable.id_taxes_9), ReportEnum.Align.Left)

                            report.WriteRow
                        Next
                        pageNum = pageNum + 1
                        recordCount += records.Length
                    End If
                Loop While Not (records Is Nothing) AndAlso recordCount < totalRows AndAlso whereClause.RunQuery 
                report.save
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(Me.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true)
          Me.Page.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.Page.RollBackTransaction(sender)
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
                  
        End Sub
        
        ' event handler for Button with Layout
        Public Overridable Sub Tax_groupsSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
          Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
      

        ' Generate the event handling functions for filter and search events.
        
      
        ' Generate the event handling functions for others
        
      
        Private _UIData As New System.Collections.Generic.List(Of Hashtable)
        Public Property UIData() As System.Collections.Generic.List(Of Hashtable)
            Get
                Return Me._UIData
            End Get
            Set(ByVal value As System.Collections.Generic.List(Of Hashtable))
                Me._UIData = value
            End Set
        End Property
        
        ' pagination properties
        Private _PageSize As Integer
        Public Property PageSize() As Integer
            Get
                Return Me._PageSize
            End Get
            Set(ByVal value As Integer)
                Me._PageSize = value
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

        Private _TotalPages As Integer
        Public Property TotalPages() As Integer
            Get
                Return Me._TotalPages
            End Get
            Set(ByVal value As Integer)
                Me._TotalPages = value
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

        Private _DataChanged As Boolean = False
        Public Property DataChanged() As Boolean
            Get
                Return Me._DataChanged
            End Get
            Set(ByVal value As Boolean)
                Me._DataChanged = value
            End Set
        End Property
        
        Private _ResetData As Boolean = False
        Public Property ResetData() As Boolean
            Get
                Return Me._ResetData
            End Get
            Set(ByVal value As Boolean)
                Me._ResetData = value
            End Set
        End Property

        Private _AddNewRecord As Integer = 0
        Public Property AddNewRecord() As Integer
            Get
                Return Me._AddNewRecord
            End Get
            Set(ByVal value As Integer)
                Me._AddNewRecord = value
            End Set
        End Property

        
        Private _CurrentSortOrder As OrderBy = Nothing
        Public Property CurrentSortOrder() As OrderBy
            Get
                Return Me._CurrentSortOrder
            End Get
            Set(ByVal value As BaseClasses.Data.OrderBy)
                Me._CurrentSortOrder = value
            End Set
        End Property
        
        Private _DataSource() As Tax_groupsRecord = Nothing
        Public Property DataSource() As Tax_groupsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Tax_groupsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property id_taxes_1Label1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_1Label1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_2Label1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_2Label1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_3Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_3Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_4Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_4Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_5Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_5Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_6Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_6Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_7Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_7Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_8Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_8Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_taxes_9Label() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_taxes_9Label"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property notesLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "notesLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tax_group_codeLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_group_codeLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsCopyButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsNewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsNewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Tax_groupsPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsSearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsSearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property Tax_groupsTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Tax_groupsWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Tax_groupsWordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function
      
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Dim needToProcess As Boolean = AreAnyUrlParametersForMe(url, arg)
            If (needToProcess) Then
                Dim recCtl As Tax_groupsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Tax_groupsRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As Tax_groupsTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Tax_groupsRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As Tax_groupsTableControlRow
            Dim selectedList() As Tax_groupsTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Tax_groupsTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As Tax_groupsTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Tax_groupsRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(Tax_groupsTableControlRow)), Tax_groupsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Tax_groupsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Tax_groupsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.Tax_groupsRecordRowSelection.Checked = False
                
                Else
                
                    recCtl.Delete()
                    
                    ' Setting the DataChanged to True results in the page being refreshed with
                    ' the most recent data from the database.  This happens in PreRender event
                    ' based on the current sort, search and filter criteria.
                    Me.DataChanged = True
                    Me.ResetData = True
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As Tax_groupsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Tax_groupsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Tax_groupsTableControlRow = DirectCast(repItem.FindControl("Tax_groupsTableControlRow"), Tax_groupsTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Tax_groupsTableControlRow)), Tax_groupsTableControlRow())
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

  