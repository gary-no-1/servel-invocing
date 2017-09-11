
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowV_GST_item_hsn_taxTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowV_GST_item_hsn_taxTable

#Region "Section 1: Place your customizations here."

    
Public Class V_GST_item_hsn_taxTableControlRow
        Inherits BaseV_GST_item_hsn_taxTableControlRow
        ' The BaseV_GST_item_hsn_taxTableControlRow implements code for a ROW within the
        ' the V_GST_item_hsn_taxTableControl table.  The BaseV_GST_item_hsn_taxTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of V_GST_item_hsn_taxTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class V_GST_item_hsn_taxTableControl
        Inherits BaseV_GST_item_hsn_taxTableControl

    ' The BaseV_GST_item_hsn_taxTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The V_GST_item_hsn_taxTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the V_GST_item_hsn_taxTableControlRow control on the ShowV_GST_item_hsn_taxTable page.
' Do not modify this class. Instead override any method in V_GST_item_hsn_taxTableControlRow.
Public Class BaseV_GST_item_hsn_taxTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in V_GST_item_hsn_taxTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in V_GST_item_hsn_taxTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource V_GST_item_hsn_tax record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseV_GST_item_hsn_taxTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New V_GST_item_hsn_taxRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in V_GST_item_hsn_taxTableControlRow.
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
        
            Setamount()
            Setcgst()
            Sethsn()
            Setigst()
            Setinv_dt()
            Setinv_no()
            Setitem_code()
            Setmonth_year()
            Setqty()
            Setsgst()
            Setuom()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setamount()
            
        
            ' Set the amount Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.amount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setamount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.amountSpecified Then
                				
                ' If the amount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.amount, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.amount.Text = formattedValue
              
            Else 
            
                ' amount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.amount.Text = V_GST_item_hsn_taxView.amount.Format(V_GST_item_hsn_taxView.amount.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the amount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.amount.Text Is Nothing _
                OrElse Me.amount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.amount.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcgst()
            
        
            ' Set the cgst Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.cgst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcgst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cgstSpecified Then
                				
                ' If the cgst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.cgst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cgst.Text = formattedValue
              
            Else 
            
                ' cgst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cgst.Text = V_GST_item_hsn_taxView.cgst.Format(V_GST_item_hsn_taxView.cgst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the cgst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cgst.Text Is Nothing _
                OrElse Me.cgst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cgst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Sethsn()
            
        
            ' Set the hsn Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.hsn is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Sethsn()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.hsnSpecified Then
                				
                ' If the hsn is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.hsn)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.hsn.Text = formattedValue
              
            Else 
            
                ' hsn is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.hsn.Text = V_GST_item_hsn_taxView.hsn.Format(V_GST_item_hsn_taxView.hsn.DefaultValue)
                        		
                End If
                 
            ' If the hsn is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.hsn.Text Is Nothing _
                OrElse Me.hsn.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.hsn.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setigst()
            
        
            ' Set the igst Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.igst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setigst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.igstSpecified Then
                				
                ' If the igst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.igst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.igst.Text = formattedValue
              
            Else 
            
                ' igst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.igst.Text = V_GST_item_hsn_taxView.igst.Format(V_GST_item_hsn_taxView.igst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the igst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.igst.Text Is Nothing _
                OrElse Me.igst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.igst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setinv_dt()
            
        
            ' Set the inv_dt Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.inv_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_dtSpecified Then
                				
                ' If the inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.inv_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_dt.Text = formattedValue
              
            Else 
            
                ' inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_dt.Text = V_GST_item_hsn_taxView.inv_dt.Format(V_GST_item_hsn_taxView.inv_dt.DefaultValue, "d")
                        		
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
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_noSpecified Then
                				
                ' If the inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_no.Text = formattedValue
              
            Else 
            
                ' inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_no.Text = V_GST_item_hsn_taxView.inv_no.Format(V_GST_item_hsn_taxView.inv_no.DefaultValue)
                        		
                End If
                 
            ' If the inv_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.inv_no.Text Is Nothing _
                OrElse Me.inv_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.inv_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setitem_code()
            
        
            ' Set the item_code Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.item_code is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_codeSpecified Then
                				
                ' If the item_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.item_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.item_code.Text = formattedValue
              
            Else 
            
                ' item_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_code.Text = V_GST_item_hsn_taxView.item_code.Format(V_GST_item_hsn_taxView.item_code.DefaultValue)
                        		
                End If
                 
            ' If the item_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.item_code.Text Is Nothing _
                OrElse Me.item_code.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.item_code.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setmonth_year()
            
        
            ' Set the month_year Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.month_year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setmonth_year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.month_yearSpecified Then
                				
                ' If the month_year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.month_year)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.month_year.Text = formattedValue
              
            Else 
            
                ' month_year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.month_year.Text = V_GST_item_hsn_taxView.month_year.Format(V_GST_item_hsn_taxView.month_year.DefaultValue)
                        		
                End If
                 
            ' If the month_year is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.month_year.Text Is Nothing _
                OrElse Me.month_year.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.month_year.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setqty()
            
        
            ' Set the qty Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.qty is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setqty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.qtySpecified Then
                				
                ' If the qty is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.qty)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.qty.Text = formattedValue
              
            Else 
            
                ' qty is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.qty.Text = V_GST_item_hsn_taxView.qty.Format(V_GST_item_hsn_taxView.qty.DefaultValue)
                        		
                End If
                 
            ' If the qty is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.qty.Text Is Nothing _
                OrElse Me.qty.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.qty.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsgst()
            
        
            ' Set the sgst Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.sgst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsgst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sgstSpecified Then
                				
                ' If the sgst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.sgst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sgst.Text = formattedValue
              
            Else 
            
                ' sgst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sgst.Text = V_GST_item_hsn_taxView.sgst.Format(V_GST_item_hsn_taxView.sgst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the sgst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.sgst.Text Is Nothing _
                OrElse Me.sgst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.sgst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setuom()
            
        
            ' Set the uom Literal on the webpage with value from the
            ' V_GST_item_hsn_tax database record.

            ' Me.DataSource is the V_GST_item_hsn_tax record retrieved from the database.
            ' Me.uom is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setuom()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.uomSpecified Then
                				
                ' If the uom is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_item_hsn_taxView.uom)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.uom.Text = formattedValue
              
            Else 
            
                ' uom is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.uom.Text = V_GST_item_hsn_taxView.uom.Format(V_GST_item_hsn_taxView.uom.DefaultValue)
                        		
                End If
                 
            ' If the uom is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.uom.Text Is Nothing _
                OrElse Me.uom.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.uom.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in V_GST_item_hsn_taxTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "V_GST_item_hsn_taxTableControl"), V_GST_item_hsn_taxTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "V_GST_item_hsn_taxTableControl"), V_GST_item_hsn_taxTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in V_GST_item_hsn_taxTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getamount()
            Getcgst()
            Gethsn()
            Getigst()
            Getinv_dt()
            Getinv_no()
            Getitem_code()
            Getmonth_year()
            Getqty()
            Getsgst()
            Getuom()
        End Sub
        
        
        Public Overridable Sub Getamount()
            
        End Sub
                
        Public Overridable Sub Getcgst()
            
        End Sub
                
        Public Overridable Sub Gethsn()
            
        End Sub
                
        Public Overridable Sub Getigst()
            
        End Sub
                
        Public Overridable Sub Getinv_dt()
            
        End Sub
                
        Public Overridable Sub Getinv_no()
            
        End Sub
                
        Public Overridable Sub Getitem_code()
            
        End Sub
                
        Public Overridable Sub Getmonth_year()
            
        End Sub
                
        Public Overridable Sub Getqty()
            
        End Sub
                
        Public Overridable Sub Getsgst()
            
        End Sub
                
        Public Overridable Sub Getuom()
            
        End Sub
                
      
        ' To customize, override this method in V_GST_item_hsn_taxTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in V_GST_item_hsn_taxTableControlRow.
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
        
        Private _DataSource As V_GST_item_hsn_taxRecord
        Public Property DataSource() As V_GST_item_hsn_taxRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As V_GST_item_hsn_taxRecord)
            
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
        
        Public ReadOnly Property amount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "amount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property cgst() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cgst"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property hsn() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "hsn"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property igst() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "igst"), System.Web.UI.WebControls.Literal)
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
            
        Public ReadOnly Property item_code() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_code"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property month_year() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "month_year"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property qty() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "qty"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property sgst() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sgst"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property uom() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "uom"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As V_GST_item_hsn_taxRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As V_GST_item_hsn_taxRecord
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

  

' Base class for the V_GST_item_hsn_taxTableControl control on the ShowV_GST_item_hsn_taxTable page.
' Do not modify this class. Instead override any method in V_GST_item_hsn_taxTableControl.
Public Class BaseV_GST_item_hsn_taxTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
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
                If  Me.InSession(Me.V_GST_item_hsn_taxSearch) 				
                    initialVal = Me.GetFromSession(Me.V_GST_item_hsn_taxSearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.V_GST_item_hsn_taxSearch.Text = initialVal
                            
                    End If
                
            End If
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_dt, OrderByItem.OrderDir.Asc)
              
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_no, OrderByItem.OrderDir.Asc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.V_GST_item_hsn_taxPagination.FirstPage.Click, AddressOf V_GST_item_hsn_taxPagination_FirstPage_Click
              
              AddHandler Me.V_GST_item_hsn_taxPagination.LastPage.Click, AddressOf V_GST_item_hsn_taxPagination_LastPage_Click
              
              AddHandler Me.V_GST_item_hsn_taxPagination.NextPage.Click, AddressOf V_GST_item_hsn_taxPagination_NextPage_Click
              
              AddHandler Me.V_GST_item_hsn_taxPagination.PageSizeButton.Click, AddressOf V_GST_item_hsn_taxPagination_PageSizeButton_Click
            
              AddHandler Me.V_GST_item_hsn_taxPagination.PreviousPage.Click, AddressOf V_GST_item_hsn_taxPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.amountLabel.Click, AddressOf amountLabel_Click
            
              AddHandler Me.cgstLabel.Click, AddressOf cgstLabel_Click
            
              AddHandler Me.hsnLabel.Click, AddressOf hsnLabel_Click
            
              AddHandler Me.igstLabel.Click, AddressOf igstLabel_Click
            
              AddHandler Me.inv_dtLabel1.Click, AddressOf inv_dtLabel1_Click
            
              AddHandler Me.inv_noLabel1.Click, AddressOf inv_noLabel1_Click
            
              AddHandler Me.item_codeLabel.Click, AddressOf item_codeLabel_Click
            
              AddHandler Me.month_yearLabel.Click, AddressOf month_yearLabel_Click
            
              AddHandler Me.qtyLabel.Click, AddressOf qtyLabel_Click
            
              AddHandler Me.sgstLabel.Click, AddressOf sgstLabel_Click
            
              AddHandler Me.uomLabel.Click, AddressOf uomLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.V_GST_item_hsn_taxExportCSVButton.Click, AddressOf V_GST_item_hsn_taxExportCSVButton_Click
              
              AddHandler Me.V_GST_item_hsn_taxExportExcelButton.Click, AddressOf V_GST_item_hsn_taxExportExcelButton_Click
              
              AddHandler Me.V_GST_item_hsn_taxPDFButton.Click, AddressOf V_GST_item_hsn_taxPDFButton_Click
              
              AddHandler Me.V_GST_item_hsn_taxRefreshButton.Click, AddressOf V_GST_item_hsn_taxRefreshButton_Click
              
              AddHandler Me.V_GST_item_hsn_taxResetButton.Click, AddressOf V_GST_item_hsn_taxResetButton_Click
              
              AddHandler Me.V_GST_item_hsn_taxWordButton.Click, AddressOf V_GST_item_hsn_taxWordButton_Click
              
            AddHandler Me.V_GST_item_hsn_taxFilterButton.Button.Click, AddressOf V_GST_item_hsn_taxFilterButton_Click
        
            AddHandler Me.V_GST_item_hsn_taxSearchButton.Button.Click, AddressOf V_GST_item_hsn_taxSearchButton_Click
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_GST_item_hsn_taxRecord)), V_GST_item_hsn_taxRecord())
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
                
                Me.TotalRecords = V_GST_item_hsn_taxView.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_GST_item_hsn_taxRecord)), V_GST_item_hsn_taxRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As V_GST_item_hsn_taxTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(V_GST_item_hsn_taxRecord)), V_GST_item_hsn_taxRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = V_GST_item_hsn_taxView.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
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
        
            SetamountLabel()
            SetcgstLabel()
            SethsnLabel()
            SetigstLabel()
            Setinv_dtLabel()
            Setinv_dtLabel1()
            Setinv_noLabel1()
            Setitem_codeLabel()
            Setmonth_yearLabel()
            SetqtyLabel()
            SetsgstLabel()
            SetuomLabel()
            SetV_GST_item_hsn_taxSearch()
            
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_item_hsn_taxTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As V_GST_item_hsn_taxTableControlRow = DirectCast(repItem.FindControl("V_GST_item_hsn_taxTableControlRow"), V_GST_item_hsn_taxTableControlRow) 
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
            
            SetamountLabel()
            SetcgstLabel()
            SethsnLabel()
            SetigstLabel()
            Setinv_dtLabel()
            Setinv_dtLabel1()
            Setinv_noLabel1()
            Setitem_codeLabel()
            Setmonth_yearLabel()
            SetqtyLabel()
            SetsgstLabel()
            SetuomLabel()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_item_hsn_taxExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_item_hsn_taxExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_item_hsn_taxPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_item_hsn_taxWordButton"))
                        
        
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
                    
            Me.inv_dtFromFilter.Text = ""
            
            Me.inv_dtToFilter.Text = ""
            
            Me.V_GST_item_hsn_taxSearch.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_dt, OrderByItem.OrderDir.Asc)
              
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_no, OrderByItem.OrderDir.Asc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for V_GST_item_hsn_taxTableControl pagination.
        
            Me.V_GST_item_hsn_taxPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.V_GST_item_hsn_taxPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_GST_item_hsn_taxPagination.LastPage.Enabled = False
            End If
          
            Me.V_GST_item_hsn_taxPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_GST_item_hsn_taxPagination.NextPage.Enabled = False
            End If
          
            Me.V_GST_item_hsn_taxPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.V_GST_item_hsn_taxPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.V_GST_item_hsn_taxPagination.CurrentPage.Text = "0"
            End If
            Me.V_GST_item_hsn_taxPagination.PageSize.Text = Me.PageSize.ToString()
            Me.V_GST_item_hsn_taxPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.V_GST_item_hsn_taxPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As V_GST_item_hsn_taxTableControlRow
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
            V_GST_item_hsn_taxView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.inv_dtFromFilter) Then
                Dim val As String = MiscUtils.GetSelectedValue(Me.inv_dtFromFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                
                val = d.ToShortDateString & " " & "00:00:00"
                wc.iAND(V_GST_item_hsn_taxView.inv_dt, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.inv_dtToFilter) Then
                Dim val As String = MiscUtils.GetSelectedValue(Me.inv_dtToFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                
                val = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(V_GST_item_hsn_taxView.inv_dt, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.V_GST_item_hsn_taxSearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.V_GST_item_hsn_taxSearch.Text.StartsWith("...") Then
                    Me.V_GST_item_hsn_taxSearch.Text = Me.V_GST_item_hsn_taxSearch.Text.SubString(3,Me.V_GST_item_hsn_taxSearch.Text.Length-3)
                End If
                If Me.V_GST_item_hsn_taxSearch.Text.EndsWith("...") then
                    Me.V_GST_item_hsn_taxSearch.Text = Me.V_GST_item_hsn_taxSearch.Text.SubString(0,Me.V_GST_item_hsn_taxSearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.V_GST_item_hsn_taxSearch, Me.GetFromSession(Me.V_GST_item_hsn_taxSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.V_GST_item_hsn_taxSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(V_GST_item_hsn_taxView.inv_no, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_GST_item_hsn_taxSearch, Me.GetFromSession(Me.V_GST_item_hsn_taxSearch)), True, False)
        
                    search.iOR(V_GST_item_hsn_taxView.month_year, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_GST_item_hsn_taxSearch, Me.GetFromSession(Me.V_GST_item_hsn_taxSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            V_GST_item_hsn_taxView.Instance.InnerFilter = Nothing
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
                wc.iAND(V_GST_item_hsn_taxView.inv_dt, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, inv_dtFromFilterSelectedValue, False, False)
                    
            End If    
            Dim inv_dtToFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "inv_dtToFilter_Ajax"), String)
            If IsValueSelected(inv_dtToFilterSelectedValue) Then
                Dim d as DateTime = DateParser.ParseDate(inv_dtToFilterSelectedValue, DateColumn.DEFAULT_FORMAT)
                inv_dtToFilterSelectedValue = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(V_GST_item_hsn_taxView.inv_dt, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, inv_dtToFilterSelectedValue, False, False)
                    
            End If    
            If IsValueSelected(searchText) and fromSearchControl = "V_GST_item_hsn_taxSearch" Then
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
                
                        search.iOR(V_GST_item_hsn_taxView.inv_no, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_GST_item_hsn_taxView.inv_no, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(V_GST_item_hsn_taxView.month_year, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_GST_item_hsn_taxView.month_year, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(V_GST_item_hsn_taxView.inv_no, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(V_GST_item_hsn_taxView.month_year, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_V_GST_item_hsn_taxSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"V_GST_item_hsn_taxSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.V_GST_item_hsn_taxRecord = V_GST_item_hsn_taxView.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As V_GST_item_hsn_taxRecord = Nothing
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
                
                    resultItem = rec.Format(V_GST_item_hsn_taxView.inv_no)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(V_GST_item_hsn_taxView.month_year)
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
        
            If Me.V_GST_item_hsn_taxPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.V_GST_item_hsn_taxPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_item_hsn_taxTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As V_GST_item_hsn_taxTableControlRow = DirectCast(repItem.FindControl("V_GST_item_hsn_taxTableControlRow"), V_GST_item_hsn_taxTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As V_GST_item_hsn_taxRecord = New V_GST_item_hsn_taxRecord()
        
                        If recControl.amount.Text <> "" Then
                            rec.Parse(recControl.amount.Text, V_GST_item_hsn_taxView.amount)
                        End If
                        If recControl.cgst.Text <> "" Then
                            rec.Parse(recControl.cgst.Text, V_GST_item_hsn_taxView.cgst)
                        End If
                        If recControl.hsn.Text <> "" Then
                            rec.Parse(recControl.hsn.Text, V_GST_item_hsn_taxView.hsn)
                        End If
                        If recControl.igst.Text <> "" Then
                            rec.Parse(recControl.igst.Text, V_GST_item_hsn_taxView.igst)
                        End If
                        If recControl.inv_dt.Text <> "" Then
                            rec.Parse(recControl.inv_dt.Text, V_GST_item_hsn_taxView.inv_dt)
                        End If
                        If recControl.inv_no.Text <> "" Then
                            rec.Parse(recControl.inv_no.Text, V_GST_item_hsn_taxView.inv_no)
                        End If
                        If recControl.item_code.Text <> "" Then
                            rec.Parse(recControl.item_code.Text, V_GST_item_hsn_taxView.item_code)
                        End If
                        If recControl.month_year.Text <> "" Then
                            rec.Parse(recControl.month_year.Text, V_GST_item_hsn_taxView.month_year)
                        End If
                        If recControl.qty.Text <> "" Then
                            rec.Parse(recControl.qty.Text, V_GST_item_hsn_taxView.qty)
                        End If
                        If recControl.sgst.Text <> "" Then
                            rec.Parse(recControl.sgst.Text, V_GST_item_hsn_taxView.sgst)
                        End If
                        If recControl.uom.Text <> "" Then
                            rec.Parse(recControl.uom.Text, V_GST_item_hsn_taxView.uom)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New V_GST_item_hsn_taxRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(V_GST_item_hsn_taxRecord)), V_GST_item_hsn_taxRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetamountLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcgstLabel()
            
                    
        End Sub
                
        Public Overridable Sub SethsnLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetigstLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_codeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setmonth_yearLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetqtyLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetsgstLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetuomLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetV_GST_item_hsn_taxSearch()
            
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
        
            Me.SaveToSession(Me.inv_dtFromFilter, Me.inv_dtFromFilter.Text)
                  
            Me.SaveToSession(Me.inv_dtToFilter, Me.inv_dtToFilter.Text)
                  
            Me.SaveToSession(Me.V_GST_item_hsn_taxSearch, Me.V_GST_item_hsn_taxSearch.Text)
                  
            
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
              
      Me.SaveToSession("V_GST_item_hsn_taxSearch_Ajax", Me.V_GST_item_hsn_taxSearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.inv_dtFromFilter)
            Me.RemoveFromSession(Me.inv_dtToFilter)
            Me.RemoveFromSession(Me.V_GST_item_hsn_taxSearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("V_GST_item_hsn_taxTableControl_OrderBy"), String)
            
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
                Me.ViewState("V_GST_item_hsn_taxTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_item_hsn_taxPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_item_hsn_taxPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_item_hsn_taxPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_item_hsn_taxPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.V_GST_item_hsn_taxPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.V_GST_item_hsn_taxPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub V_GST_item_hsn_taxPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub amountLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by amount when clicked.
              
            ' Get previous sorting state for amount.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.amount)
            If sd Is Nothing Then
                ' First time sort, so add sort order for amount.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.amount, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by amount, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub cgstLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by cgst when clicked.
              
            ' Get previous sorting state for cgst.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.cgst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cgst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.cgst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cgst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub hsnLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by hsn when clicked.
              
            ' Get previous sorting state for hsn.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.hsn)
            If sd Is Nothing Then
                ' First time sort, so add sort order for hsn.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.hsn, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by hsn, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub igstLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by igst when clicked.
              
            ' Get previous sorting state for igst.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.igst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for igst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.igst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by igst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub inv_dtLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by inv_dt when clicked.
              
            ' Get previous sorting state for inv_dt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.inv_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for inv_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_dt, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.inv_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for inv_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by inv_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub item_codeLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by item_code when clicked.
              
            ' Get previous sorting state for item_code.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.item_code)
            If sd Is Nothing Then
                ' First time sort, so add sort order for item_code.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.item_code, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by item_code, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub month_yearLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by month_year when clicked.
              
            ' Get previous sorting state for month_year.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.month_year)
            If sd Is Nothing Then
                ' First time sort, so add sort order for month_year.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.month_year, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by month_year, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub qtyLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by qty when clicked.
              
            ' Get previous sorting state for qty.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.qty)
            If sd Is Nothing Then
                ' First time sort, so add sort order for qty.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.qty, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by qty, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub sgstLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by sgst when clicked.
              
            ' Get previous sorting state for sgst.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.sgst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sgst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.sgst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sgst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub uomLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by uom when clicked.
              
            ' Get previous sorting state for uom.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_item_hsn_taxView.uom)
            If sd Is Nothing Then
                ' First time sort, so add sort order for uom.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.uom, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by uom, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_item_hsn_taxExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       V_GST_item_hsn_taxView.inv_no, _ 
             V_GST_item_hsn_taxView.inv_dt, _ 
             V_GST_item_hsn_taxView.month_year, _ 
             V_GST_item_hsn_taxView.item_code, _ 
             V_GST_item_hsn_taxView.uom, _ 
             V_GST_item_hsn_taxView.qty, _ 
             V_GST_item_hsn_taxView.amount, _ 
             V_GST_item_hsn_taxView.hsn, _ 
             V_GST_item_hsn_taxView.igst, _ 
             V_GST_item_hsn_taxView.cgst, _ 
             V_GST_item_hsn_taxView.sgst, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(V_GST_item_hsn_taxView.Instance, wc, orderBy, columns)
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
        Public Overridable Sub V_GST_item_hsn_taxExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(V_GST_item_hsn_taxView.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.inv_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.inv_dt, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.month_year, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.item_code, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.uom, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.qty, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.amount, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.hsn, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.igst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.cgst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_item_hsn_taxView.sgst, "Standard"))

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
        Public Overridable Sub V_GST_item_hsn_taxPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_GST_item_hsn_taxTable.V_GST_item_hsn_taxPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_GST_item_hsn_tax"
                ' If ShowV_GST_item_hsn_taxTable.V_GST_item_hsn_taxPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(V_GST_item_hsn_taxView.inv_no.Name, ReportEnum.Align.Left, "${inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.inv_dt.Name, ReportEnum.Align.Left, "${inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.month_year.Name, ReportEnum.Align.Left, "${month_year}", ReportEnum.Align.Left, 25)
                 report.AddColumn(V_GST_item_hsn_taxView.item_code.Name, ReportEnum.Align.Left, "${item_code}", ReportEnum.Align.Left, 24)
                 report.AddColumn(V_GST_item_hsn_taxView.uom.Name, ReportEnum.Align.Left, "${uom}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_item_hsn_taxView.qty.Name, ReportEnum.Align.Right, "${qty}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.amount.Name, ReportEnum.Align.Right, "${amount}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.hsn.Name, ReportEnum.Align.Left, "${hsn}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_item_hsn_taxView.igst.Name, ReportEnum.Align.Right, "${igst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.cgst.Name, ReportEnum.Align.Right, "${cgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.sgst.Name, ReportEnum.Align.Right, "${sgst}", ReportEnum.Align.Right, 20)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = V_GST_item_hsn_taxView.GetRecordCount(whereClause)
                Dim columns As ColumnList = V_GST_item_hsn_taxView.GetColumnList()
                Dim records As V_GST_item_hsn_taxRecord() = Nothing
            
                Do 
                    
                    records = V_GST_item_hsn_taxView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As V_GST_item_hsn_taxRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${inv_no}", record.Format(V_GST_item_hsn_taxView.inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_dt}", record.Format(V_GST_item_hsn_taxView.inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${month_year}", record.Format(V_GST_item_hsn_taxView.month_year), ReportEnum.Align.Left, 100)
                             report.AddData("${item_code}", record.Format(V_GST_item_hsn_taxView.item_code), ReportEnum.Align.Left, 100)
                             report.AddData("${uom}", record.Format(V_GST_item_hsn_taxView.uom), ReportEnum.Align.Left, 100)
                             report.AddData("${qty}", record.Format(V_GST_item_hsn_taxView.qty), ReportEnum.Align.Right, 100)
                             report.AddData("${amount}", record.Format(V_GST_item_hsn_taxView.amount), ReportEnum.Align.Right, 100)
                             report.AddData("${hsn}", record.Format(V_GST_item_hsn_taxView.hsn), ReportEnum.Align.Left, 100)
                             report.AddData("${igst}", record.Format(V_GST_item_hsn_taxView.igst), ReportEnum.Align.Right, 100)
                             report.AddData("${cgst}", record.Format(V_GST_item_hsn_taxView.cgst), ReportEnum.Align.Right, 100)
                             report.AddData("${sgst}", record.Format(V_GST_item_hsn_taxView.sgst), ReportEnum.Align.Right, 100)

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
        Public Overridable Sub V_GST_item_hsn_taxRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim V_GST_item_hsn_taxTableControlObj as V_GST_item_hsn_taxTableControl = DirectCast(Me.Page.FindControlRecursively("V_GST_item_hsn_taxTableControl"), V_GST_item_hsn_taxTableControl)
            V_GST_item_hsn_taxTableControlObj.ResetData = True
                        
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_item_hsn_taxResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.inv_dtFromFilter.Text = ""
              Me.inv_dtToFilter.Text = ""
              Me.V_GST_item_hsn_taxSearch.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_dt, OrderByItem.OrderDir.Asc)
                
                Me.CurrentSortOrder.Add(V_GST_item_hsn_taxView.inv_no, OrderByItem.OrderDir.Asc)
                
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
        Public Overridable Sub V_GST_item_hsn_taxWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_GST_item_hsn_taxTable.V_GST_item_hsn_taxWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_GST_item_hsn_tax"
                ' If ShowV_GST_item_hsn_taxTable.V_GST_item_hsn_taxWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(V_GST_item_hsn_taxView.inv_no.Name, ReportEnum.Align.Left, "${inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.inv_dt.Name, ReportEnum.Align.Left, "${inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.month_year.Name, ReportEnum.Align.Left, "${month_year}", ReportEnum.Align.Left, 25)
                 report.AddColumn(V_GST_item_hsn_taxView.item_code.Name, ReportEnum.Align.Left, "${item_code}", ReportEnum.Align.Left, 24)
                 report.AddColumn(V_GST_item_hsn_taxView.uom.Name, ReportEnum.Align.Left, "${uom}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_item_hsn_taxView.qty.Name, ReportEnum.Align.Right, "${qty}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.amount.Name, ReportEnum.Align.Right, "${amount}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.hsn.Name, ReportEnum.Align.Left, "${hsn}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_item_hsn_taxView.igst.Name, ReportEnum.Align.Right, "${igst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.cgst.Name, ReportEnum.Align.Right, "${cgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_item_hsn_taxView.sgst.Name, ReportEnum.Align.Right, "${sgst}", ReportEnum.Align.Right, 20)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = V_GST_item_hsn_taxView.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = V_GST_item_hsn_taxView.GetColumnList()
                Dim records As V_GST_item_hsn_taxRecord() = Nothing
                Do
                    records = V_GST_item_hsn_taxView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As V_GST_item_hsn_taxRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${inv_no}", record.Format(V_GST_item_hsn_taxView.inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_dt}", record.Format(V_GST_item_hsn_taxView.inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${month_year}", record.Format(V_GST_item_hsn_taxView.month_year), ReportEnum.Align.Left, 100)
                             report.AddData("${item_code}", record.Format(V_GST_item_hsn_taxView.item_code), ReportEnum.Align.Left, 100)
                             report.AddData("${uom}", record.Format(V_GST_item_hsn_taxView.uom), ReportEnum.Align.Left, 100)
                             report.AddData("${qty}", record.Format(V_GST_item_hsn_taxView.qty), ReportEnum.Align.Right, 100)
                             report.AddData("${amount}", record.Format(V_GST_item_hsn_taxView.amount), ReportEnum.Align.Right, 100)
                             report.AddData("${hsn}", record.Format(V_GST_item_hsn_taxView.hsn), ReportEnum.Align.Left, 100)
                             report.AddData("${igst}", record.Format(V_GST_item_hsn_taxView.igst), ReportEnum.Align.Right, 100)
                             report.AddData("${cgst}", record.Format(V_GST_item_hsn_taxView.cgst), ReportEnum.Align.Right, 100)
                             report.AddData("${sgst}", record.Format(V_GST_item_hsn_taxView.sgst), ReportEnum.Align.Right, 100)

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
        Public Overridable Sub V_GST_item_hsn_taxFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Public Overridable Sub V_GST_item_hsn_taxSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        Private _DataSource() As V_GST_item_hsn_taxRecord = Nothing
        Public Property DataSource() As V_GST_item_hsn_taxRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As V_GST_item_hsn_taxRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property amountLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "amountLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property cgstLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cgstLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property hsnLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "hsnLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property igstLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "igstLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtFromFilter() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtFromFilter"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_dtLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtLabel1"), System.Web.UI.WebControls.LinkButton)
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
        
        Public ReadOnly Property item_codeLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_codeLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property month_yearLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "month_yearLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property qtyLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "qtyLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property sgstLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sgstLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property uomLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "uomLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxFilterButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxFilterButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxSearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxSearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_item_hsn_taxWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_item_hsn_taxWordButton"), System.Web.UI.WebControls.ImageButton)
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
          
        Public Overridable Function GetSelectedRecordControl() As V_GST_item_hsn_taxTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As V_GST_item_hsn_taxTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(V_GST_item_hsn_taxTableControlRow)), V_GST_item_hsn_taxTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As V_GST_item_hsn_taxTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As V_GST_item_hsn_taxTableControlRow
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

        Public Function GetRecordControls() As V_GST_item_hsn_taxTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_item_hsn_taxTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As V_GST_item_hsn_taxTableControlRow = DirectCast(repItem.FindControl("V_GST_item_hsn_taxTableControlRow"), V_GST_item_hsn_taxTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(V_GST_item_hsn_taxTableControlRow)), V_GST_item_hsn_taxTableControlRow())
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

  