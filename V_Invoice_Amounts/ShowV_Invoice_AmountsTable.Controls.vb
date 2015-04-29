﻿
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowV_Invoice_AmountsTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowV_Invoice_AmountsTable

#Region "Section 1: Place your customizations here."

    
Public Class V_Invoice_AmountsTableControlRow
        Inherits BaseV_Invoice_AmountsTableControlRow
        ' The BaseV_Invoice_AmountsTableControlRow implements code for a ROW within the
        ' the V_Invoice_AmountsTableControl table.  The BaseV_Invoice_AmountsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of V_Invoice_AmountsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class V_Invoice_AmountsTableControl
        Inherits BaseV_Invoice_AmountsTableControl

    ' The BaseV_Invoice_AmountsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The V_Invoice_AmountsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the V_Invoice_AmountsTableControlRow control on the ShowV_Invoice_AmountsTable page.
' Do not modify this class. Instead override any method in V_Invoice_AmountsTableControlRow.
Public Class BaseV_Invoice_AmountsTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in V_Invoice_AmountsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in V_Invoice_AmountsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource V_Invoice_Amounts record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseV_Invoice_AmountsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New V_Invoice_AmountsRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in V_Invoice_AmountsTableControlRow.
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
        
            Setcst_amt()
            Setexcise_amt()
            Setgrand_total()
            Setinv_dt()
            Setinv_no()
            Setitem_total()
            Setname()
            Setoth_amt()
            Setsrv_tax()
            Setvat_amt()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setcst_amt()
            
        
            ' Set the cst_amt Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.cst_amt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcst_amt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cst_amtSpecified Then
                				
                ' If the cst_amt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.cst_amt)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cst_amt.Text = formattedValue
              
            Else 
            
                ' cst_amt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cst_amt.Text = V_Invoice_AmountsView.cst_amt.Format(V_Invoice_AmountsView.cst_amt.DefaultValue)
                        		
                End If
                 
            ' If the cst_amt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cst_amt.Text Is Nothing _
                OrElse Me.cst_amt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cst_amt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setexcise_amt()
            
        
            ' Set the excise_amt Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.excise_amt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setexcise_amt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.excise_amtSpecified Then
                				
                ' If the excise_amt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.excise_amt)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.excise_amt.Text = formattedValue
              
            Else 
            
                ' excise_amt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.excise_amt.Text = V_Invoice_AmountsView.excise_amt.Format(V_Invoice_AmountsView.excise_amt.DefaultValue)
                        		
                End If
                 
            ' If the excise_amt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.excise_amt.Text Is Nothing _
                OrElse Me.excise_amt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.excise_amt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgrand_total()
            
        
            ' Set the grand_total Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.grand_total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgrand_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.grand_totalSpecified Then
                				
                ' If the grand_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.grand_total)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.grand_total.Text = formattedValue
              
            Else 
            
                ' grand_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.grand_total.Text = V_Invoice_AmountsView.grand_total.Format(V_Invoice_AmountsView.grand_total.DefaultValue)
                        		
                End If
                 
            ' If the grand_total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.grand_total.Text Is Nothing _
                OrElse Me.grand_total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.grand_total.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setinv_dt()
            
        
            ' Set the inv_dt Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.inv_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_dtSpecified Then
                				
                ' If the inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.inv_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_dt.Text = formattedValue
              
            Else 
            
                ' inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_dt.Text = V_Invoice_AmountsView.inv_dt.Format(V_Invoice_AmountsView.inv_dt.DefaultValue, "d")
                        		
                End If
                 
            ' If the inv_dt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.inv_dt.Text Is Nothing _
                OrElse Me.inv_dt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.inv_dt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setinv_no()
            
        
            ' Set the inv_no Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_noSpecified Then
                				
                ' If the inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_no.Text = formattedValue
              
            Else 
            
                ' inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_no.Text = V_Invoice_AmountsView.inv_no.Format(V_Invoice_AmountsView.inv_no.DefaultValue)
                        		
                End If
                 
            ' If the inv_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.inv_no.Text Is Nothing _
                OrElse Me.inv_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.inv_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setitem_total()
            
        
            ' Set the item_total Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.item_total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_totalSpecified Then
                				
                ' If the item_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.item_total)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.item_total.Text = formattedValue
              
            Else 
            
                ' item_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_total.Text = V_Invoice_AmountsView.item_total.Format(V_Invoice_AmountsView.item_total.DefaultValue)
                        		
                End If
                 
            ' If the item_total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.item_total.Text Is Nothing _
                OrElse Me.item_total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.item_total.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setname()
            
        
            ' Set the name Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.name.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name.Text = V_Invoice_AmountsView.name.Format(V_Invoice_AmountsView.name.DefaultValue)
                        		
                End If
                 
            ' If the name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.name.Text Is Nothing _
                OrElse Me.name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.name.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setoth_amt()
            
        
            ' Set the oth_amt Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.oth_amt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setoth_amt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.oth_amtSpecified Then
                				
                ' If the oth_amt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.oth_amt)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.oth_amt.Text = formattedValue
              
            Else 
            
                ' oth_amt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.oth_amt.Text = V_Invoice_AmountsView.oth_amt.Format(V_Invoice_AmountsView.oth_amt.DefaultValue)
                        		
                End If
                 
            ' If the oth_amt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.oth_amt.Text Is Nothing _
                OrElse Me.oth_amt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.oth_amt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsrv_tax()
            
        
            ' Set the srv_tax Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.srv_tax is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsrv_tax()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.srv_taxSpecified Then
                				
                ' If the srv_tax is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.srv_tax)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.srv_tax.Text = formattedValue
              
            Else 
            
                ' srv_tax is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.srv_tax.Text = V_Invoice_AmountsView.srv_tax.Format(V_Invoice_AmountsView.srv_tax.DefaultValue)
                        		
                End If
                 
            ' If the srv_tax is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.srv_tax.Text Is Nothing _
                OrElse Me.srv_tax.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.srv_tax.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setvat_amt()
            
        
            ' Set the vat_amt Literal on the webpage with value from the
            ' V_Invoice_Amounts database record.

            ' Me.DataSource is the V_Invoice_Amounts record retrieved from the database.
            ' Me.vat_amt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setvat_amt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.vat_amtSpecified Then
                				
                ' If the vat_amt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_Invoice_AmountsView.vat_amt)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.vat_amt.Text = formattedValue
              
            Else 
            
                ' vat_amt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.vat_amt.Text = V_Invoice_AmountsView.vat_amt.Format(V_Invoice_AmountsView.vat_amt.DefaultValue)
                        		
                End If
                 
            ' If the vat_amt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.vat_amt.Text Is Nothing _
                OrElse Me.vat_amt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.vat_amt.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in V_Invoice_AmountsTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "V_Invoice_AmountsTableControl"), V_Invoice_AmountsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "V_Invoice_AmountsTableControl"), V_Invoice_AmountsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in V_Invoice_AmountsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getcst_amt()
            Getexcise_amt()
            Getgrand_total()
            Getinv_dt()
            Getinv_no()
            Getitem_total()
            Getname()
            Getoth_amt()
            Getsrv_tax()
            Getvat_amt()
        End Sub
        
        
        Public Overridable Sub Getcst_amt()
            
        End Sub
                
        Public Overridable Sub Getexcise_amt()
            
        End Sub
                
        Public Overridable Sub Getgrand_total()
            
        End Sub
                
        Public Overridable Sub Getinv_dt()
            
        End Sub
                
        Public Overridable Sub Getinv_no()
            
        End Sub
                
        Public Overridable Sub Getitem_total()
            
        End Sub
                
        Public Overridable Sub Getname()
            
        End Sub
                
        Public Overridable Sub Getoth_amt()
            
        End Sub
                
        Public Overridable Sub Getsrv_tax()
            
        End Sub
                
        Public Overridable Sub Getvat_amt()
            
        End Sub
                
      
        ' To customize, override this method in V_Invoice_AmountsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in V_Invoice_AmountsTableControlRow.
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
        
        Private _DataSource As V_Invoice_AmountsRecord
        Public Property DataSource() As V_Invoice_AmountsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As V_Invoice_AmountsRecord)
            
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
        
        Public ReadOnly Property cst_amt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_amt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property excise_amt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "excise_amt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property grand_total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property item_total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property oth_amt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "oth_amt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property srv_tax() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "srv_tax"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property vat_amt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_amt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As V_Invoice_AmountsRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As V_Invoice_AmountsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
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

  

' Base class for the V_Invoice_AmountsTableControl control on the ShowV_Invoice_AmountsTable page.
' Do not modify this class. Instead override any method in V_Invoice_AmountsTableControl.
Public Class BaseV_Invoice_AmountsTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
            AddHandler Me.nameFilter.SelectedIndexChanged, AddressOf nameFilter_SelectedIndexChanged
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.inv_dtFromFilter) 				
                    initialVal = Me.GetFromSession(Me.inv_dtFromFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.inv_dtFromFilter.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.inv_dtToFilter) 				
                    initialVal = Me.GetFromSession(Me.inv_dtToFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.inv_dtToFilter.Text = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.nameFilter) 				
                    initialVal = Me.GetFromSession(Me.nameFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.nameFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.nameFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.V_Invoice_AmountsSearch) 				
                    initialVal = Me.GetFromSession(Me.V_Invoice_AmountsSearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.V_Invoice_AmountsSearch.Text = initialVal
                            
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
        
            ' Setup the pagination events.
            
              AddHandler Me.V_Invoice_AmountsPagination.FirstPage.Click, AddressOf V_Invoice_AmountsPagination_FirstPage_Click
              
              AddHandler Me.V_Invoice_AmountsPagination.LastPage.Click, AddressOf V_Invoice_AmountsPagination_LastPage_Click
              
              AddHandler Me.V_Invoice_AmountsPagination.NextPage.Click, AddressOf V_Invoice_AmountsPagination_NextPage_Click
              
              AddHandler Me.V_Invoice_AmountsPagination.PageSizeButton.Click, AddressOf V_Invoice_AmountsPagination_PageSizeButton_Click
            
              AddHandler Me.V_Invoice_AmountsPagination.PreviousPage.Click, AddressOf V_Invoice_AmountsPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.cst_amtLabel.Click, AddressOf cst_amtLabel_Click
            
              AddHandler Me.excise_amtLabel.Click, AddressOf excise_amtLabel_Click
            
              AddHandler Me.grand_totalLabel.Click, AddressOf grand_totalLabel_Click
            
              AddHandler Me.inv_dtLabel.Click, AddressOf inv_dtLabel_Click
            
              AddHandler Me.inv_noLabel1.Click, AddressOf inv_noLabel1_Click
            
              AddHandler Me.item_totalLabel.Click, AddressOf item_totalLabel_Click
            
              AddHandler Me.nameLabel.Click, AddressOf nameLabel_Click
            
              AddHandler Me.oth_amtLabel.Click, AddressOf oth_amtLabel_Click
            
              AddHandler Me.srv_taxLabel.Click, AddressOf srv_taxLabel_Click
            
              AddHandler Me.vat_amtLabel.Click, AddressOf vat_amtLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.V_Invoice_AmountsExportCSVButton.Click, AddressOf V_Invoice_AmountsExportCSVButton_Click
              
              AddHandler Me.V_Invoice_AmountsExportExcelButton.Click, AddressOf V_Invoice_AmountsExportExcelButton_Click
              
              AddHandler Me.V_Invoice_AmountsPDFButton.Click, AddressOf V_Invoice_AmountsPDFButton_Click
              
              AddHandler Me.V_Invoice_AmountsRefreshButton.Click, AddressOf V_Invoice_AmountsRefreshButton_Click
              
              AddHandler Me.V_Invoice_AmountsResetButton.Click, AddressOf V_Invoice_AmountsResetButton_Click
              
              AddHandler Me.V_Invoice_AmountsWordButton.Click, AddressOf V_Invoice_AmountsWordButton_Click
              
            AddHandler Me.V_Invoice_AmountsFilterButton.Button.Click, AddressOf V_Invoice_AmountsFilterButton_Click
        
            AddHandler Me.V_Invoice_AmountsSearchButton.Button.Click, AddressOf V_Invoice_AmountsSearchButton_Click
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_Invoice_AmountsRecord)), V_Invoice_AmountsRecord())
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
                
                Me.TotalRecords = V_Invoice_AmountsView.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_Invoice_AmountsRecord)), V_Invoice_AmountsRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As V_Invoice_AmountsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(V_Invoice_AmountsRecord)), V_Invoice_AmountsRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = V_Invoice_AmountsView.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            

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
           
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            Setcst_amtLabel()
            Setexcise_amtLabel()
            Setgrand_totalLabel()
            Setinv_dtLabel()
            Setinv_dtLabel1()
            Setinv_noLabel1()
            Setitem_totalLabel()
            SetnameFilter()
            
            SetnameLabel()
            SetnameLabel1()
            Setoth_amtLabel()
            Setsrv_taxLabel()
            SetV_Invoice_AmountsSearch()
            
            Setvat_amtLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_Invoice_AmountsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As V_Invoice_AmountsTableControlRow = DirectCast(repItem.FindControl("V_Invoice_AmountsTableControlRow"), V_Invoice_AmountsTableControlRow) 
                recControl.DataSource = Me.DataSource(index)
                If Me.UIData.Count > index Then
                    recControl.PreviousUIData = Me.UIData(index)
                End If				
                recControl.DataBind()
                index += 1
            Next

        
            ' setting the state of expand or collapse alternative rows
      
    
            ' Load data for each record and table UI control.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
                

            ' Initialize other asp controls
            
            Setcst_amtLabel()
            Setexcise_amtLabel()
            Setgrand_totalLabel()
            Setinv_dtLabel()
            Setinv_dtLabel1()
            Setinv_noLabel1()
            Setitem_totalLabel()
            SetnameLabel()
            SetnameLabel1()
            Setoth_amtLabel()
            Setsrv_taxLabel()
            Setvat_amtLabel()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_Invoice_AmountsExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_Invoice_AmountsExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_Invoice_AmountsPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_Invoice_AmountsWordButton"))
                        
        
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
                    
            Me.nameFilter.ClearSelection()
            
            Me.inv_dtFromFilter.Text = ""
            
            Me.inv_dtToFilter.Text = ""
            
            Me.V_Invoice_AmountsSearch.Text = ""
            
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

            ' Bind the buttons for V_Invoice_AmountsTableControl pagination.
        
            Me.V_Invoice_AmountsPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.V_Invoice_AmountsPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_Invoice_AmountsPagination.LastPage.Enabled = False
            End If
          
            Me.V_Invoice_AmountsPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_Invoice_AmountsPagination.NextPage.Enabled = False
            End If
          
            Me.V_Invoice_AmountsPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.V_Invoice_AmountsPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.V_Invoice_AmountsPagination.CurrentPage.Text = "0"
            End If
            Me.V_Invoice_AmountsPagination.PageSize.Text = Me.PageSize.ToString()
            Me.V_Invoice_AmountsPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.V_Invoice_AmountsPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As V_Invoice_AmountsTableControlRow
            For Each recCtl In Me.GetRecordControls()
        
                If recCtl.Visible Then
                    recCtl.SaveData()
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
            V_Invoice_AmountsView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.inv_dtFromFilter) Then
                Dim val As String = MiscUtils.GetSelectedValue(Me.inv_dtFromFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                
                val = d.ToShortDateString & " " & "00:00:00"
                wc.iAND(V_Invoice_AmountsView.inv_dt, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.inv_dtToFilter) Then
                Dim val As String = MiscUtils.GetSelectedValue(Me.inv_dtToFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                
                val = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(V_Invoice_AmountsView.inv_dt, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.nameFilter) Then
                
                wc.iAND(V_Invoice_AmountsView.name, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.nameFilter, Me.GetFromSession(Me.nameFilter)), False, False)
            
                
            End If
                       
            If IsValueSelected(Me.V_Invoice_AmountsSearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.V_Invoice_AmountsSearch.Text.StartsWith("...") Then
                    Me.V_Invoice_AmountsSearch.Text = Me.V_Invoice_AmountsSearch.Text.SubString(3,Me.V_Invoice_AmountsSearch.Text.Length-3)
                End If
                If Me.V_Invoice_AmountsSearch.Text.EndsWith("...") then
                    Me.V_Invoice_AmountsSearch.Text = Me.V_Invoice_AmountsSearch.Text.SubString(0,Me.V_Invoice_AmountsSearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.V_Invoice_AmountsSearch, Me.GetFromSession(Me.V_Invoice_AmountsSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.V_Invoice_AmountsSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(V_Invoice_AmountsView.inv_no, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_Invoice_AmountsSearch, Me.GetFromSession(Me.V_Invoice_AmountsSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            V_Invoice_AmountsView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim inv_dtFromFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "inv_dtFromFilter_Ajax"), String)
            If IsValueSelected(inv_dtFromFilterSelectedValue) Then
                Dim d as DateTime = DateParser.ParseDate(inv_dtFromFilterSelectedValue, DateColumn.DEFAULT_FORMAT)
                inv_dtFromFilterSelectedValue = d.ToShortDateString & " " & "00:00:00"
                wc.iAND(V_Invoice_AmountsView.inv_dt, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, inv_dtFromFilterSelectedValue, False, False)
                    
            End If    
            Dim inv_dtToFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "inv_dtToFilter_Ajax"), String)
            If IsValueSelected(inv_dtToFilterSelectedValue) Then
                Dim d as DateTime = DateParser.ParseDate(inv_dtToFilterSelectedValue, DateColumn.DEFAULT_FORMAT)
                inv_dtToFilterSelectedValue = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(V_Invoice_AmountsView.inv_dt, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, inv_dtToFilterSelectedValue, False, False)
                    
            End If    
            Dim nameFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "nameFilter_Ajax"), String)
            If IsValueSelected(nameFilterSelectedValue) Then
              
                 wc.iAND(V_Invoice_AmountsView.name, BaseFilter.ComparisonOperator.EqualsTo, nameFilterSelectedValue, false, False)
             
             End If
                      
            If IsValueSelected(searchText) and fromSearchControl = "V_Invoice_AmountsSearch" Then
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
                
                        search.iOR(V_Invoice_AmountsView.inv_no, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_Invoice_AmountsView.inv_no, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(V_Invoice_AmountsView.inv_no, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_V_Invoice_AmountsSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"V_Invoice_AmountsSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.V_Invoice_AmountsRecord = V_Invoice_AmountsView.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As V_Invoice_AmountsRecord = Nothing
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
                
                    resultItem = rec.Format(V_Invoice_AmountsView.inv_no)
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
        
            If Me.V_Invoice_AmountsPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.V_Invoice_AmountsPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_Invoice_AmountsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As V_Invoice_AmountsTableControlRow = DirectCast(repItem.FindControl("V_Invoice_AmountsTableControlRow"), V_Invoice_AmountsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As V_Invoice_AmountsRecord = New V_Invoice_AmountsRecord()
        
                        If recControl.cst_amt.Text <> "" Then
                            rec.Parse(recControl.cst_amt.Text, V_Invoice_AmountsView.cst_amt)
                        End If
                        If recControl.excise_amt.Text <> "" Then
                            rec.Parse(recControl.excise_amt.Text, V_Invoice_AmountsView.excise_amt)
                        End If
                        If recControl.grand_total.Text <> "" Then
                            rec.Parse(recControl.grand_total.Text, V_Invoice_AmountsView.grand_total)
                        End If
                        If recControl.inv_dt.Text <> "" Then
                            rec.Parse(recControl.inv_dt.Text, V_Invoice_AmountsView.inv_dt)
                        End If
                        If recControl.inv_no.Text <> "" Then
                            rec.Parse(recControl.inv_no.Text, V_Invoice_AmountsView.inv_no)
                        End If
                        If recControl.item_total.Text <> "" Then
                            rec.Parse(recControl.item_total.Text, V_Invoice_AmountsView.item_total)
                        End If
                        If recControl.name.Text <> "" Then
                            rec.Parse(recControl.name.Text, V_Invoice_AmountsView.name)
                        End If
                        If recControl.oth_amt.Text <> "" Then
                            rec.Parse(recControl.oth_amt.Text, V_Invoice_AmountsView.oth_amt)
                        End If
                        If recControl.srv_tax.Text <> "" Then
                            rec.Parse(recControl.srv_tax.Text, V_Invoice_AmountsView.srv_tax)
                        End If
                        If recControl.vat_amt.Text <> "" Then
                            rec.Parse(recControl.vat_amt.Text, V_Invoice_AmountsView.vat_amt)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New V_Invoice_AmountsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(V_Invoice_AmountsRecord)), V_Invoice_AmountsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub Setcst_amtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setexcise_amtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgrand_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setoth_amtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsrv_taxLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setvat_amtLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetnameFilter()
            
            If (Me.InSession(Me.nameFilter))
                Me.PopulatenameFilter(GetSelectedValue(Me.nameFilter, Me.GetFromSession(Me.nameFilter)), 500)
            Else
                
                Me.PopulatenameFilter(GetSelectedValue(Me.nameFilter,  Nothing), 500)					
                
            End If
                    
        End Sub	
            
        Public Overridable Sub SetV_Invoice_AmountsSearch()
            
        End Sub	
            
        ' Get the filters' data for nameFilter
        Protected Overridable Sub PopulatenameFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
            Me.nameFilter.Items.Clear()
            
            
            ' Setup the WHERE clause, including the base table if needed.
                
            Dim wc As WhereClause = Me.CreateWhereClause_nameFilter()
                  
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(V_Invoice_AmountsView.name, OrderByItem.OrderDir.Asc)

            
            ' Add the All item.
            Me.nameFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ServelInvocing"), "--ANY--"))
                            	


            Dim values() As String = V_Invoice_AmountsView.GetValues(V_Invoice_AmountsView.name, wc, orderBy, maxItems)
            
            Dim itemValue As String
            
            For Each itemValue In values
                ' Create the item and add to the list.
                Dim fvalue As String
          
                If ( V_Invoice_AmountsView.name.IsColumnValueTypeBoolean()) Then
                    fvalue = itemValue
                Else
                    fvalue = V_Invoice_AmountsView.name.Format(itemValue)
                End If
                Dim item As ListItem = New ListItem(fvalue, itemValue)
          
                Me.nameFilter.Items.Add(item)
            Next
                    

                
            ' Set the selected value.
            SetSelectedValue(Me.nameFilter, selectedValue)

                
        End Sub
            
        Public Overridable Function CreateWhereClause_nameFilter() As WhereClause
        
            ' Create a where clause for the filter nameFilter.
            ' This function is called by the Populate method to load the items 
            ' in the nameFilterDropDownList
                   
            Dim wc As WhereClause = new WhereClause()
            ' Add additional where clauses to restrict the items shown in the control.
            ' Examples:
            ' wc.iAND(., BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Return wc
        
        End Function			
            
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
        
            Me.SaveToSession(Me.inv_dtFromFilter, Me.inv_dtFromFilter.Text)
                  
            Me.SaveToSession(Me.inv_dtToFilter, Me.inv_dtToFilter.Text)
                  
            Me.SaveToSession(Me.nameFilter, Me.nameFilter.SelectedValue)
                  
            Me.SaveToSession(Me.V_Invoice_AmountsSearch, Me.V_Invoice_AmountsSearch.Text)
                  
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
      Me.SaveToSession("inv_dtFromFilter_Ajax", Me.inv_dtFromFilter.Text)
              
      Me.SaveToSession("inv_dtToFilter_Ajax", Me.inv_dtToFilter.Text)
              
      Me.SaveToSession("nameFilter_Ajax", Me.nameFilter.SelectedValue)
              
      Me.SaveToSession("V_Invoice_AmountsSearch_Ajax", Me.V_Invoice_AmountsSearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.inv_dtFromFilter)
            Me.RemoveFromSession(Me.inv_dtToFilter)
            Me.RemoveFromSession(Me.nameFilter)
            Me.RemoveFromSession(Me.V_Invoice_AmountsSearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("V_Invoice_AmountsTableControl_OrderBy"), String)
            
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
        
        End Sub

        Protected Overrides Function SaveViewState() As Object
            
            If Me.CurrentSortOrder IsNot Nothing Then
                Me.ViewState("V_Invoice_AmountsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_Invoice_AmountsPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_Invoice_AmountsPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_Invoice_AmountsPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_Invoice_AmountsPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.V_Invoice_AmountsPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.V_Invoice_AmountsPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub V_Invoice_AmountsPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub cst_amtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by cst_amt when clicked.
              
            ' Get previous sorting state for cst_amt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.cst_amt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cst_amt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.cst_amt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cst_amt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub excise_amtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by excise_amt when clicked.
              
            ' Get previous sorting state for excise_amt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.excise_amt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for excise_amt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.excise_amt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by excise_amt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub grand_totalLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by grand_total when clicked.
              
            ' Get previous sorting state for grand_total.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.grand_total)
            If sd Is Nothing Then
                ' First time sort, so add sort order for grand_total.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.grand_total, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by grand_total, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub inv_dtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by inv_dt when clicked.
              
            ' Get previous sorting state for inv_dt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.inv_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for inv_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.inv_dt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by inv_dt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub inv_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by inv_no when clicked.
              
            ' Get previous sorting state for inv_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.inv_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for inv_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.inv_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by inv_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub item_totalLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by item_total when clicked.
              
            ' Get previous sorting state for item_total.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.item_total)
            If sd Is Nothing Then
                ' First time sort, so add sort order for item_total.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.item_total, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by item_total, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub nameLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by name when clicked.
              
            ' Get previous sorting state for name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by name, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub oth_amtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by oth_amt when clicked.
              
            ' Get previous sorting state for oth_amt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.oth_amt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for oth_amt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.oth_amt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by oth_amt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub srv_taxLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by srv_tax when clicked.
              
            ' Get previous sorting state for srv_tax.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.srv_tax)
            If sd Is Nothing Then
                ' First time sort, so add sort order for srv_tax.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.srv_tax, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by srv_tax, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub vat_amtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by vat_amt when clicked.
              
            ' Get previous sorting state for vat_amt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_Invoice_AmountsView.vat_amt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for vat_amt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_Invoice_AmountsView.vat_amt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by vat_amt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_Invoice_AmountsExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       V_Invoice_AmountsView.inv_no, _ 
             V_Invoice_AmountsView.inv_dt, _ 
             V_Invoice_AmountsView.item_total, _ 
             V_Invoice_AmountsView.excise_amt, _ 
             V_Invoice_AmountsView.vat_amt, _ 
             V_Invoice_AmountsView.cst_amt, _ 
             V_Invoice_AmountsView.srv_tax, _ 
             V_Invoice_AmountsView.oth_amt, _ 
             V_Invoice_AmountsView.grand_total, _ 
             V_Invoice_AmountsView.name, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(V_Invoice_AmountsView.Instance, wc, orderBy, columns)
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
        Public Overridable Sub V_Invoice_AmountsExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(V_Invoice_AmountsView.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.inv_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.inv_dt, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.item_total, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.excise_amt, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.vat_amt, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.cst_amt, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.srv_tax, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.oth_amt, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.grand_total, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_Invoice_AmountsView.name, "Default"))

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
        Public Overridable Sub V_Invoice_AmountsPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_Invoice_AmountsTable.V_Invoice_AmountsPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_Invoice_Amounts"
                ' If ShowV_Invoice_AmountsTable.V_Invoice_AmountsPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(V_Invoice_AmountsView.inv_no.Name, ReportEnum.Align.Left, "${inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_Invoice_AmountsView.inv_dt.Name, ReportEnum.Align.Left, "${inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_Invoice_AmountsView.item_total.Name, ReportEnum.Align.Right, "${item_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.excise_amt.Name, ReportEnum.Align.Right, "${excise_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.vat_amt.Name, ReportEnum.Align.Right, "${vat_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.cst_amt.Name, ReportEnum.Align.Right, "${cst_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.srv_tax.Name, ReportEnum.Align.Right, "${srv_tax}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.oth_amt.Name, ReportEnum.Align.Right, "${oth_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.grand_total.Name, ReportEnum.Align.Right, "${grand_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.name.Name, ReportEnum.Align.Left, "${name}", ReportEnum.Align.Left, 30)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = V_Invoice_AmountsView.GetRecordCount(whereClause)
                Dim columns As ColumnList = V_Invoice_AmountsView.GetColumnList()
                Dim records As V_Invoice_AmountsRecord() = Nothing
            
                Do 
                    
                    records = V_Invoice_AmountsView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As V_Invoice_AmountsRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${inv_no}", record.Format(V_Invoice_AmountsView.inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_dt}", record.Format(V_Invoice_AmountsView.inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${item_total}", record.Format(V_Invoice_AmountsView.item_total), ReportEnum.Align.Right, 100)
                             report.AddData("${excise_amt}", record.Format(V_Invoice_AmountsView.excise_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${vat_amt}", record.Format(V_Invoice_AmountsView.vat_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${cst_amt}", record.Format(V_Invoice_AmountsView.cst_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${srv_tax}", record.Format(V_Invoice_AmountsView.srv_tax), ReportEnum.Align.Right, 100)
                             report.AddData("${oth_amt}", record.Format(V_Invoice_AmountsView.oth_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${grand_total}", record.Format(V_Invoice_AmountsView.grand_total), ReportEnum.Align.Right, 100)
                             report.AddData("${name}", record.Format(V_Invoice_AmountsView.name), ReportEnum.Align.Left, 100)

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
        Public Overridable Sub V_Invoice_AmountsRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim V_Invoice_AmountsTableControlObj as V_Invoice_AmountsTableControl = DirectCast(Me.Page.FindControlRecursively("V_Invoice_AmountsTableControl"), V_Invoice_AmountsTableControl)
            V_Invoice_AmountsTableControlObj.ResetData = True
                        
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub V_Invoice_AmountsResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.nameFilter.ClearSelection()
              Me.inv_dtFromFilter.Text = ""
              Me.inv_dtToFilter.Text = ""
              Me.V_Invoice_AmountsSearch.Text = ""
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
        Public Overridable Sub V_Invoice_AmountsWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_Invoice_AmountsTable.V_Invoice_AmountsWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_Invoice_Amounts"
                ' If ShowV_Invoice_AmountsTable.V_Invoice_AmountsWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(V_Invoice_AmountsView.inv_no.Name, ReportEnum.Align.Left, "${inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_Invoice_AmountsView.inv_dt.Name, ReportEnum.Align.Left, "${inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_Invoice_AmountsView.item_total.Name, ReportEnum.Align.Right, "${item_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.excise_amt.Name, ReportEnum.Align.Right, "${excise_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.vat_amt.Name, ReportEnum.Align.Right, "${vat_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.cst_amt.Name, ReportEnum.Align.Right, "${cst_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.srv_tax.Name, ReportEnum.Align.Right, "${srv_tax}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.oth_amt.Name, ReportEnum.Align.Right, "${oth_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.grand_total.Name, ReportEnum.Align.Right, "${grand_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_Invoice_AmountsView.name.Name, ReportEnum.Align.Left, "${name}", ReportEnum.Align.Left, 30)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = V_Invoice_AmountsView.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = V_Invoice_AmountsView.GetColumnList()
                Dim records As V_Invoice_AmountsRecord() = Nothing
                Do
                    records = V_Invoice_AmountsView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As V_Invoice_AmountsRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${inv_no}", record.Format(V_Invoice_AmountsView.inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_dt}", record.Format(V_Invoice_AmountsView.inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${item_total}", record.Format(V_Invoice_AmountsView.item_total), ReportEnum.Align.Right, 100)
                             report.AddData("${excise_amt}", record.Format(V_Invoice_AmountsView.excise_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${vat_amt}", record.Format(V_Invoice_AmountsView.vat_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${cst_amt}", record.Format(V_Invoice_AmountsView.cst_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${srv_tax}", record.Format(V_Invoice_AmountsView.srv_tax), ReportEnum.Align.Right, 100)
                             report.AddData("${oth_amt}", record.Format(V_Invoice_AmountsView.oth_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${grand_total}", record.Format(V_Invoice_AmountsView.grand_total), ReportEnum.Align.Right, 100)
                             report.AddData("${name}", record.Format(V_Invoice_AmountsView.name), ReportEnum.Align.Left, 100)

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
        Public Overridable Sub V_Invoice_AmountsFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
          Me.DataChanged = True
      
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Overridable Sub V_Invoice_AmountsSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        ' event handler for FieldFilter
        Protected Overridable Sub nameFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	   
        End Sub
            
      
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
        
        Private _DataSource() As V_Invoice_AmountsRecord = Nothing
        Public Property DataSource() As V_Invoice_AmountsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As V_Invoice_AmountsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property cst_amtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_amtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property excise_amtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "excise_amtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property grand_totalLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_totalLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtFromFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtFromFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtToFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtToFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property inv_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property item_totalLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_totalLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property nameFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property nameLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property nameLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property oth_amtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "oth_amtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property srv_taxLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "srv_taxLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsFilterButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsFilterButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_Invoice_AmountsPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property V_Invoice_AmountsPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsSearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsSearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_Invoice_AmountsTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property V_Invoice_AmountsWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_Invoice_AmountsWordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property vat_amtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_amtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"
        
        Public Overrides Overloads Function ModifyRedirectUrl(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function
    
        Public Overrides Overloads Function EvaluateExpressions(url As String, arg As String, ByVal bEncrypt As Boolean) As String
            Return EvaluateExpressions(url, arg, Nothing, bEncrypt)
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As V_Invoice_AmountsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As V_Invoice_AmountsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(V_Invoice_AmountsTableControlRow)), V_Invoice_AmountsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As V_Invoice_AmountsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As V_Invoice_AmountsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        ' Localization.
                        Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ServelInvocing"))
                  
                    End If
                    recCtl.Visible = False
                
                Else
                
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:CannotDelRecs", "ServelInvocing"))
                  
                End If
            Next
        End Sub

        Public Function GetRecordControls() As V_Invoice_AmountsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_Invoice_AmountsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As V_Invoice_AmountsTableControlRow = DirectCast(repItem.FindControl("V_Invoice_AmountsTableControlRow"), V_Invoice_AmountsTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(V_Invoice_AmountsTableControlRow)), V_Invoice_AmountsTableControlRow())
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

  