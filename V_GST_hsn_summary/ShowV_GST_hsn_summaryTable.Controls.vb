
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowV_GST_hsn_summaryTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowV_GST_hsn_summaryTable

#Region "Section 1: Place your customizations here."

    
Public Class V_GST_hsn_summaryTableControlRow
        Inherits BaseV_GST_hsn_summaryTableControlRow
        ' The BaseV_GST_hsn_summaryTableControlRow implements code for a ROW within the
        ' the V_GST_hsn_summaryTableControl table.  The BaseV_GST_hsn_summaryTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of V_GST_hsn_summaryTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class V_GST_hsn_summaryTableControl
        Inherits BaseV_GST_hsn_summaryTableControl

    ' The BaseV_GST_hsn_summaryTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The V_GST_hsn_summaryTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


		Public Overrides Sub V_GST_hsn_summaryExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
             V_GST_hsn_summaryView.hsn, _ 
             V_GST_hsn_summaryView.gst_description, _ 
             V_GST_hsn_summaryView.gst_uom, _ 
             V_GST_hsn_summaryView.qty, _ 
             V_GST_hsn_summaryView.total_amt, _ 
             V_GST_hsn_summaryView.taxable_amt, _ 
             V_GST_hsn_summaryView.igst, _ 
             V_GST_hsn_summaryView.cgst, _ 
             V_GST_hsn_summaryView.sgst, _ 
             V_GST_hsn_summaryView.cess, _ 
             Nothing}
			Dim displayColumn as string = "HSN,Description,UQC,Total Quantity,Total Value,Taxable Value,Integrated Tax Amount,Central Tax Amount,State/UT Tax Amount,Cess Amount"
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(V_GST_hsn_summaryView.Instance, wc, orderBy, columns, displayColumn)
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
End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the V_GST_hsn_summaryTableControlRow control on the ShowV_GST_hsn_summaryTable page.
' Do not modify this class. Instead override any method in V_GST_hsn_summaryTableControlRow.
Public Class BaseV_GST_hsn_summaryTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in V_GST_hsn_summaryTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in V_GST_hsn_summaryTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource V_GST_hsn_summary record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseV_GST_hsn_summaryTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New V_GST_hsn_summaryRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in V_GST_hsn_summaryTableControlRow.
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
        
            Setcess()
            Setcgst()
            Setgst_description()
            Setgst_uom()
            Sethsn()
            Setigst()
            Setmonth_year()
            Setqty()
            Setsgst()
            Settaxable_amt()
            Settotal_amt()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
                  
        End Sub
        
        
        Public Overridable Sub Setcess()
            
        
            ' Set the cess Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.cess is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcess()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cessSpecified Then
                				
                ' If the cess is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.cess, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cess.Text = formattedValue
              
            Else 
            
                ' cess is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cess.Text = V_GST_hsn_summaryView.cess.Format(V_GST_hsn_summaryView.cess.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the cess is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cess.Text Is Nothing _
                OrElse Me.cess.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cess.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcgst()
            
        
            ' Set the cgst Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.cgst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcgst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cgstSpecified Then
                				
                ' If the cgst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.cgst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cgst.Text = formattedValue
              
            Else 
            
                ' cgst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cgst.Text = V_GST_hsn_summaryView.cgst.Format(V_GST_hsn_summaryView.cgst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the cgst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cgst.Text Is Nothing _
                OrElse Me.cgst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cgst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_description()
            
        
            ' Set the gst_description Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.gst_description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_descriptionSpecified Then
                				
                ' If the gst_description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.gst_description)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.gst_description.Text = formattedValue
              
            Else 
            
                ' gst_description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_description.Text = V_GST_hsn_summaryView.gst_description.Format(V_GST_hsn_summaryView.gst_description.DefaultValue)
                        		
                End If
                 
            ' If the gst_description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_description.Text Is Nothing _
                OrElse Me.gst_description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_description.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_uom()
            
        
            ' Set the gst_uom Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.gst_uom is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_uom()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_uomSpecified Then
                				
                ' If the gst_uom is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.gst_uom)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.gst_uom.Text = formattedValue
              
            Else 
            
                ' gst_uom is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_uom.Text = V_GST_hsn_summaryView.gst_uom.Format(V_GST_hsn_summaryView.gst_uom.DefaultValue)
                        		
                End If
                 
            ' If the gst_uom is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_uom.Text Is Nothing _
                OrElse Me.gst_uom.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_uom.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Sethsn()
            
        
            ' Set the hsn Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.hsn is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Sethsn()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.hsnSpecified Then
                				
                ' If the hsn is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.hsn)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.hsn.Text = formattedValue
              
            Else 
            
                ' hsn is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.hsn.Text = V_GST_hsn_summaryView.hsn.Format(V_GST_hsn_summaryView.hsn.DefaultValue)
                        		
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
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.igst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setigst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.igstSpecified Then
                				
                ' If the igst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.igst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.igst.Text = formattedValue
              
            Else 
            
                ' igst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.igst.Text = V_GST_hsn_summaryView.igst.Format(V_GST_hsn_summaryView.igst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the igst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.igst.Text Is Nothing _
                OrElse Me.igst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.igst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setmonth_year()
            
        
            ' Set the month_year Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.month_year is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setmonth_year()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.month_yearSpecified Then
                				
                ' If the month_year is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.month_year)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.month_year.Text = formattedValue
              
            Else 
            
                ' month_year is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.month_year.Text = V_GST_hsn_summaryView.month_year.Format(V_GST_hsn_summaryView.month_year.DefaultValue)
                        		
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
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.qty is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setqty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.qtySpecified Then
                				
                ' If the qty is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.qty)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.qty.Text = formattedValue
              
            Else 
            
                ' qty is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.qty.Text = V_GST_hsn_summaryView.qty.Format(V_GST_hsn_summaryView.qty.DefaultValue)
                        		
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
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.sgst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsgst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sgstSpecified Then
                				
                ' If the sgst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.sgst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sgst.Text = formattedValue
              
            Else 
            
                ' sgst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sgst.Text = V_GST_hsn_summaryView.sgst.Format(V_GST_hsn_summaryView.sgst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the sgst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.sgst.Text Is Nothing _
                OrElse Me.sgst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.sgst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settaxable_amt()
            
        
            ' Set the taxable_amt Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.taxable_amt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settaxable_amt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.taxable_amtSpecified Then
                				
                ' If the taxable_amt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.taxable_amt, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.taxable_amt.Text = formattedValue
              
            Else 
            
                ' taxable_amt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.taxable_amt.Text = V_GST_hsn_summaryView.taxable_amt.Format(V_GST_hsn_summaryView.taxable_amt.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the taxable_amt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.taxable_amt.Text Is Nothing _
                OrElse Me.taxable_amt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.taxable_amt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settotal_amt()
            
        
            ' Set the total_amt Literal on the webpage with value from the
            ' V_GST_hsn_summary database record.

            ' Me.DataSource is the V_GST_hsn_summary record retrieved from the database.
            ' Me.total_amt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settotal_amt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.total_amtSpecified Then
                				
                ' If the total_amt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_hsn_summaryView.total_amt, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.total_amt.Text = formattedValue
              
            Else 
            
                ' total_amt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.total_amt.Text = V_GST_hsn_summaryView.total_amt.Format(V_GST_hsn_summaryView.total_amt.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the total_amt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.total_amt.Text Is Nothing _
                OrElse Me.total_amt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.total_amt.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in V_GST_hsn_summaryTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "V_GST_hsn_summaryTableControl"), V_GST_hsn_summaryTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "V_GST_hsn_summaryTableControl"), V_GST_hsn_summaryTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in V_GST_hsn_summaryTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getcess()
            Getcgst()
            Getgst_description()
            Getgst_uom()
            Gethsn()
            Getigst()
            Getmonth_year()
            Getqty()
            Getsgst()
            Gettaxable_amt()
            Gettotal_amt()
        End Sub
        
        
        Public Overridable Sub Getcess()
            
        End Sub
                
        Public Overridable Sub Getcgst()
            
        End Sub
                
        Public Overridable Sub Getgst_description()
            
        End Sub
                
        Public Overridable Sub Getgst_uom()
            
        End Sub
                
        Public Overridable Sub Gethsn()
            
        End Sub
                
        Public Overridable Sub Getigst()
            
        End Sub
                
        Public Overridable Sub Getmonth_year()
            
        End Sub
                
        Public Overridable Sub Getqty()
            
        End Sub
                
        Public Overridable Sub Getsgst()
            
        End Sub
                
        Public Overridable Sub Gettaxable_amt()
            
        End Sub
                
        Public Overridable Sub Gettotal_amt()
            
        End Sub
                
      
        ' To customize, override this method in V_GST_hsn_summaryTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in V_GST_hsn_summaryTableControlRow.
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
        
        Private _DataSource As V_GST_hsn_summaryRecord
        Public Property DataSource() As V_GST_hsn_summaryRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As V_GST_hsn_summaryRecord)
            
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
        
        Public ReadOnly Property cess() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cess"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property cgst() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cgst"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_uom() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_uom"), System.Web.UI.WebControls.Literal)
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
            
        Public ReadOnly Property taxable_amt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "taxable_amt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property total_amt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "total_amt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As V_GST_hsn_summaryRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As V_GST_hsn_summaryRecord
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

  

' Base class for the V_GST_hsn_summaryTableControl control on the ShowV_GST_hsn_summaryTable page.
' Do not modify this class. Instead override any method in V_GST_hsn_summaryTableControl.
Public Class BaseV_GST_hsn_summaryTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
            AddHandler Me.month_yearFilter.SelectedIndexChanged, AddressOf month_yearFilter_SelectedIndexChanged
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.month_yearFilter) 				
                    initialVal = Me.GetFromSession(Me.month_yearFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.month_yearFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.month_yearFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.V_GST_hsn_summarySearch) 				
                    initialVal = Me.GetFromSession(Me.V_GST_hsn_summarySearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.V_GST_hsn_summarySearch.Text = initialVal
                            
                    End If
                
            End If
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.month_start, OrderByItem.OrderDir.Asc)
              
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.hsn, OrderByItem.OrderDir.Asc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.V_GST_hsn_summaryPagination.FirstPage.Click, AddressOf V_GST_hsn_summaryPagination_FirstPage_Click
              
              AddHandler Me.V_GST_hsn_summaryPagination.LastPage.Click, AddressOf V_GST_hsn_summaryPagination_LastPage_Click
              
              AddHandler Me.V_GST_hsn_summaryPagination.NextPage.Click, AddressOf V_GST_hsn_summaryPagination_NextPage_Click
              
              AddHandler Me.V_GST_hsn_summaryPagination.PageSizeButton.Click, AddressOf V_GST_hsn_summaryPagination_PageSizeButton_Click
            
              AddHandler Me.V_GST_hsn_summaryPagination.PreviousPage.Click, AddressOf V_GST_hsn_summaryPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.cessLabel.Click, AddressOf cessLabel_Click
            
              AddHandler Me.cgstLabel.Click, AddressOf cgstLabel_Click
            
              AddHandler Me.gst_descriptionLabel.Click, AddressOf gst_descriptionLabel_Click
            
              AddHandler Me.gst_uomLabel.Click, AddressOf gst_uomLabel_Click
            
              AddHandler Me.hsnLabel.Click, AddressOf hsnLabel_Click
            
              AddHandler Me.igstLabel.Click, AddressOf igstLabel_Click
            
              AddHandler Me.month_yearLabel1.Click, AddressOf month_yearLabel1_Click
            
              AddHandler Me.qtyLabel.Click, AddressOf qtyLabel_Click
            
              AddHandler Me.sgstLabel.Click, AddressOf sgstLabel_Click
            
              AddHandler Me.taxable_amtLabel.Click, AddressOf taxable_amtLabel_Click
            
              AddHandler Me.total_amtLabel.Click, AddressOf total_amtLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.V_GST_hsn_summaryExportCSVButton.Click, AddressOf V_GST_hsn_summaryExportCSVButton_Click
              
              AddHandler Me.V_GST_hsn_summaryExportExcelButton.Click, AddressOf V_GST_hsn_summaryExportExcelButton_Click
              
              AddHandler Me.V_GST_hsn_summaryPDFButton.Click, AddressOf V_GST_hsn_summaryPDFButton_Click
              
              AddHandler Me.V_GST_hsn_summaryRefreshButton.Click, AddressOf V_GST_hsn_summaryRefreshButton_Click
              
              AddHandler Me.V_GST_hsn_summaryResetButton.Click, AddressOf V_GST_hsn_summaryResetButton_Click
              
              AddHandler Me.V_GST_hsn_summaryWordButton.Click, AddressOf V_GST_hsn_summaryWordButton_Click
              
            AddHandler Me.V_GST_hsn_summaryFilterButton.Button.Click, AddressOf V_GST_hsn_summaryFilterButton_Click
        
            AddHandler Me.V_GST_hsn_summarySearchButton.Button.Click, AddressOf V_GST_hsn_summarySearchButton_Click
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_GST_hsn_summaryRecord)), V_GST_hsn_summaryRecord())
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
                
                Me.TotalRecords = V_GST_hsn_summaryView.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_GST_hsn_summaryRecord)), V_GST_hsn_summaryRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As V_GST_hsn_summaryTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(V_GST_hsn_summaryRecord)), V_GST_hsn_summaryRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = V_GST_hsn_summaryView.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
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
        
            SetcessLabel()
            SetcgstLabel()
            Setgst_descriptionLabel()
            Setgst_uomLabel()
            SethsnLabel()
            SetigstLabel()
            Setmonth_yearFilter()
            
            Setmonth_yearLabel()
            Setmonth_yearLabel1()
            SetqtyLabel()
            SetsgstLabel()
            Settaxable_amtLabel()
            Settotal_amtLabel()
            SetV_GST_hsn_summarySearch()
            
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_hsn_summaryTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As V_GST_hsn_summaryTableControlRow = DirectCast(repItem.FindControl("V_GST_hsn_summaryTableControlRow"), V_GST_hsn_summaryTableControlRow) 
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
            
            SetcessLabel()
            SetcgstLabel()
            Setgst_descriptionLabel()
            Setgst_uomLabel()
            SethsnLabel()
            SetigstLabel()
            Setmonth_yearLabel()
            Setmonth_yearLabel1()
            SetqtyLabel()
            SetsgstLabel()
            Settaxable_amtLabel()
            Settotal_amtLabel()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_hsn_summaryExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_hsn_summaryExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_hsn_summaryPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_hsn_summaryWordButton"))
                        
        
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
                    
            Me.month_yearFilter.ClearSelection()
            
            Me.V_GST_hsn_summarySearch.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.month_start, OrderByItem.OrderDir.Asc)
              
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.hsn, OrderByItem.OrderDir.Asc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for V_GST_hsn_summaryTableControl pagination.
        
            Me.V_GST_hsn_summaryPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.V_GST_hsn_summaryPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_GST_hsn_summaryPagination.LastPage.Enabled = False
            End If
          
            Me.V_GST_hsn_summaryPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_GST_hsn_summaryPagination.NextPage.Enabled = False
            End If
          
            Me.V_GST_hsn_summaryPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.V_GST_hsn_summaryPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.V_GST_hsn_summaryPagination.CurrentPage.Text = "0"
            End If
            Me.V_GST_hsn_summaryPagination.PageSize.Text = Me.PageSize.ToString()
            Me.V_GST_hsn_summaryPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.V_GST_hsn_summaryPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As V_GST_hsn_summaryTableControlRow
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
            V_GST_hsn_summaryView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.month_yearFilter) Then
                
                wc.iAND(V_GST_hsn_summaryView.month_year, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.month_yearFilter, Me.GetFromSession(Me.month_yearFilter)), False, False)
            
                
            End If
                       
            If IsValueSelected(Me.V_GST_hsn_summarySearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.V_GST_hsn_summarySearch.Text.StartsWith("...") Then
                    Me.V_GST_hsn_summarySearch.Text = Me.V_GST_hsn_summarySearch.Text.SubString(3,Me.V_GST_hsn_summarySearch.Text.Length-3)
                End If
                If Me.V_GST_hsn_summarySearch.Text.EndsWith("...") then
                    Me.V_GST_hsn_summarySearch.Text = Me.V_GST_hsn_summarySearch.Text.SubString(0,Me.V_GST_hsn_summarySearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.V_GST_hsn_summarySearch, Me.GetFromSession(Me.V_GST_hsn_summarySearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.V_GST_hsn_summarySearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(V_GST_hsn_summaryView.month_year, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_GST_hsn_summarySearch, Me.GetFromSession(Me.V_GST_hsn_summarySearch)), True, False)
        
                    search.iOR(V_GST_hsn_summaryView.hsn, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_GST_hsn_summarySearch, Me.GetFromSession(Me.V_GST_hsn_summarySearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            V_GST_hsn_summaryView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim month_yearFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "month_yearFilter_Ajax"), String)
            If IsValueSelected(month_yearFilterSelectedValue) Then
              
                 wc.iAND(V_GST_hsn_summaryView.month_year, BaseFilter.ComparisonOperator.EqualsTo, month_yearFilterSelectedValue, false, False)
             
             End If
                      
            If IsValueSelected(searchText) and fromSearchControl = "V_GST_hsn_summarySearch" Then
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
                
                        search.iOR(V_GST_hsn_summaryView.month_year, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_GST_hsn_summaryView.month_year, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(V_GST_hsn_summaryView.hsn, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_GST_hsn_summaryView.hsn, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(V_GST_hsn_summaryView.month_year, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(V_GST_hsn_summaryView.hsn, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_V_GST_hsn_summarySearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"V_GST_hsn_summarySearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.V_GST_hsn_summaryRecord = V_GST_hsn_summaryView.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As V_GST_hsn_summaryRecord = Nothing
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
                
                    resultItem = rec.Format(V_GST_hsn_summaryView.month_year)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(V_GST_hsn_summaryView.hsn)
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
        
            If Me.V_GST_hsn_summaryPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.V_GST_hsn_summaryPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_hsn_summaryTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As V_GST_hsn_summaryTableControlRow = DirectCast(repItem.FindControl("V_GST_hsn_summaryTableControlRow"), V_GST_hsn_summaryTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As V_GST_hsn_summaryRecord = New V_GST_hsn_summaryRecord()
        
                        If recControl.cess.Text <> "" Then
                            rec.Parse(recControl.cess.Text, V_GST_hsn_summaryView.cess)
                        End If
                        If recControl.cgst.Text <> "" Then
                            rec.Parse(recControl.cgst.Text, V_GST_hsn_summaryView.cgst)
                        End If
                        If recControl.gst_description.Text <> "" Then
                            rec.Parse(recControl.gst_description.Text, V_GST_hsn_summaryView.gst_description)
                        End If
                        If recControl.gst_uom.Text <> "" Then
                            rec.Parse(recControl.gst_uom.Text, V_GST_hsn_summaryView.gst_uom)
                        End If
                        If recControl.hsn.Text <> "" Then
                            rec.Parse(recControl.hsn.Text, V_GST_hsn_summaryView.hsn)
                        End If
                        If recControl.igst.Text <> "" Then
                            rec.Parse(recControl.igst.Text, V_GST_hsn_summaryView.igst)
                        End If
                        If recControl.month_year.Text <> "" Then
                            rec.Parse(recControl.month_year.Text, V_GST_hsn_summaryView.month_year)
                        End If
                        If recControl.qty.Text <> "" Then
                            rec.Parse(recControl.qty.Text, V_GST_hsn_summaryView.qty)
                        End If
                        If recControl.sgst.Text <> "" Then
                            rec.Parse(recControl.sgst.Text, V_GST_hsn_summaryView.sgst)
                        End If
                        If recControl.taxable_amt.Text <> "" Then
                            rec.Parse(recControl.taxable_amt.Text, V_GST_hsn_summaryView.taxable_amt)
                        End If
                        If recControl.total_amt.Text <> "" Then
                            rec.Parse(recControl.total_amt.Text, V_GST_hsn_summaryView.total_amt)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New V_GST_hsn_summaryRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(V_GST_hsn_summaryRecord)), V_GST_hsn_summaryRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
      
        ' Create Set, WhereClause, and Populate Methods
        
        Public Overridable Sub SetcessLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcgstLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_descriptionLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_uomLabel()
            
                    
        End Sub
                
        Public Overridable Sub SethsnLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetigstLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setmonth_yearLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setmonth_yearLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetqtyLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetsgstLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settaxable_amtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settotal_amtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setmonth_yearFilter()
            
            If (Me.InSession(Me.month_yearFilter))
                Me.Populatemonth_yearFilter(GetSelectedValue(Me.month_yearFilter, Me.GetFromSession(Me.month_yearFilter)), 500)
            Else
                
                Me.Populatemonth_yearFilter(GetSelectedValue(Me.month_yearFilter,  Nothing), 500)					
                
            End If
                    
        End Sub	
            
        Public Overridable Sub SetV_GST_hsn_summarySearch()
            
        End Sub	
            
        ' Get the filters' data for month_yearFilter
        Protected Overridable Sub Populatemonth_yearFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
            Me.month_yearFilter.Items.Clear()
            
            
            ' Setup the WHERE clause, including the base table if needed.
                
            Dim wc As WhereClause = Me.CreateWhereClause_month_yearFilter()
                  
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(V_GST_hsn_summaryView.month_year, OrderByItem.OrderDir.Asc)

            
            ' Add the All item.
            Me.month_yearFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ServelInvocing"), "--ANY--"))
                            	


            Dim values() As String = V_GST_hsn_summaryView.GetValues(V_GST_hsn_summaryView.month_year, wc, orderBy, maxItems)
            
            Dim itemValue As String
            
            For Each itemValue In values
                ' Create the item and add to the list.
                Dim fvalue As String
          
                If ( V_GST_hsn_summaryView.month_year.IsColumnValueTypeBoolean()) Then
                    fvalue = itemValue
                Else
                    fvalue = V_GST_hsn_summaryView.month_year.Format(itemValue)
                End If
                Dim item As ListItem = New ListItem(fvalue, itemValue)
          
                Me.month_yearFilter.Items.Add(item)
            Next
                    

                
            ' Set the selected value.
            SetSelectedValue(Me.month_yearFilter, selectedValue)

                
        End Sub
            
        Public Overridable Function CreateWhereClause_month_yearFilter() As WhereClause
        
            ' Create a where clause for the filter month_yearFilter.
            ' This function is called by the Populate method to load the items 
            ' in the month_yearFilterDropDownList
                   
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
        
            Me.SaveToSession(Me.month_yearFilter, Me.month_yearFilter.SelectedValue)
                  
            Me.SaveToSession(Me.V_GST_hsn_summarySearch, Me.V_GST_hsn_summarySearch.Text)
                  
            
            ' Save table control properties to the session.
            If Not Me.CurrentSortOrder Is Nothing Then
            Me.SaveToSession(Me, "Order_By", Me.CurrentSortOrder.ToXmlString())
            End If
            Me.SaveToSession(Me, "Page_Index", Me.PageIndex.ToString())
            Me.SaveToSession(Me, "Page_Size", Me.PageSize.ToString())
        
        End Sub
        
        Protected  Sub SaveControlsToSession_Ajax()
            ' Save filter controls to values to session.
          
      Me.SaveToSession("month_yearFilter_Ajax", Me.month_yearFilter.SelectedValue)
              
      Me.SaveToSession("V_GST_hsn_summarySearch_Ajax", Me.V_GST_hsn_summarySearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.month_yearFilter)
            Me.RemoveFromSession(Me.V_GST_hsn_summarySearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("V_GST_hsn_summaryTableControl_OrderBy"), String)
            
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
                Me.ViewState("V_GST_hsn_summaryTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_hsn_summaryPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_hsn_summaryPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_hsn_summaryPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_hsn_summaryPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.V_GST_hsn_summaryPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.V_GST_hsn_summaryPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub V_GST_hsn_summaryPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub cessLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by cess when clicked.
              
            ' Get previous sorting state for cess.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.cess)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cess.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.cess, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cess, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.cgst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cgst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.cgst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cgst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_descriptionLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_description when clicked.
              
            ' Get previous sorting state for gst_description.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.gst_description)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_description.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.gst_description, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_description, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_uomLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_uom when clicked.
              
            ' Get previous sorting state for gst_uom.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.gst_uom)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_uom.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.gst_uom, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_uom, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.hsn)
            If sd Is Nothing Then
                ' First time sort, so add sort order for hsn.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.hsn, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.igst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for igst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.igst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by igst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub month_yearLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by month_year when clicked.
              
            ' Get previous sorting state for month_year.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.month_year)
            If sd Is Nothing Then
                ' First time sort, so add sort order for month_year.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.month_year, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.qty)
            If sd Is Nothing Then
                ' First time sort, so add sort order for qty.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.qty, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.sgst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sgst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.sgst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sgst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub taxable_amtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by taxable_amt when clicked.
              
            ' Get previous sorting state for taxable_amt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.taxable_amt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for taxable_amt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.taxable_amt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by taxable_amt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub total_amtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by total_amt when clicked.
              
            ' Get previous sorting state for total_amt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_hsn_summaryView.total_amt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for total_amt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.total_amt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by total_amt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_hsn_summaryExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       V_GST_hsn_summaryView.month_year, _ 
             V_GST_hsn_summaryView.hsn, _ 
             V_GST_hsn_summaryView.gst_description, _ 
             V_GST_hsn_summaryView.gst_uom, _ 
             V_GST_hsn_summaryView.qty, _ 
             V_GST_hsn_summaryView.total_amt, _ 
             V_GST_hsn_summaryView.taxable_amt, _ 
             V_GST_hsn_summaryView.igst, _ 
             V_GST_hsn_summaryView.cgst, _ 
             V_GST_hsn_summaryView.sgst, _ 
             V_GST_hsn_summaryView.cess, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(V_GST_hsn_summaryView.Instance, wc, orderBy, columns)
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
        Public Overridable Sub V_GST_hsn_summaryExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(V_GST_hsn_summaryView.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.month_year, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.hsn, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.gst_description, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.gst_uom, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.qty, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.total_amt, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.taxable_amt, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.igst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.cgst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.sgst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_hsn_summaryView.cess, "0"))

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
        Public Overridable Sub V_GST_hsn_summaryPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_GST_hsn_summaryTable.V_GST_hsn_summaryPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_GST_hsn_summary"
                ' If ShowV_GST_hsn_summaryTable.V_GST_hsn_summaryPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(V_GST_hsn_summaryView.month_year.Name, ReportEnum.Align.Left, "${month_year}", ReportEnum.Align.Left, 25)
                 report.AddColumn(V_GST_hsn_summaryView.hsn.Name, ReportEnum.Align.Left, "${hsn}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_hsn_summaryView.gst_description.Name, ReportEnum.Align.Left, "${gst_description}", ReportEnum.Align.Left, 30)
                 report.AddColumn(V_GST_hsn_summaryView.gst_uom.Name, ReportEnum.Align.Left, "${gst_uom}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_hsn_summaryView.qty.Name, ReportEnum.Align.Right, "${qty}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.total_amt.Name, ReportEnum.Align.Right, "${total_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.taxable_amt.Name, ReportEnum.Align.Right, "${taxable_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.igst.Name, ReportEnum.Align.Right, "${igst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.cgst.Name, ReportEnum.Align.Right, "${cgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.sgst.Name, ReportEnum.Align.Right, "${sgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.cess.Name, ReportEnum.Align.Right, "${cess}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = V_GST_hsn_summaryView.GetRecordCount(whereClause)
                Dim columns As ColumnList = V_GST_hsn_summaryView.GetColumnList()
                Dim records As V_GST_hsn_summaryRecord() = Nothing
            
                Do 
                    
                    records = V_GST_hsn_summaryView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As V_GST_hsn_summaryRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${month_year}", record.Format(V_GST_hsn_summaryView.month_year), ReportEnum.Align.Left, 100)
                             report.AddData("${hsn}", record.Format(V_GST_hsn_summaryView.hsn), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_description}", record.Format(V_GST_hsn_summaryView.gst_description), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_uom}", record.Format(V_GST_hsn_summaryView.gst_uom), ReportEnum.Align.Left, 100)
                             report.AddData("${qty}", record.Format(V_GST_hsn_summaryView.qty), ReportEnum.Align.Right, 100)
                             report.AddData("${total_amt}", record.Format(V_GST_hsn_summaryView.total_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${taxable_amt}", record.Format(V_GST_hsn_summaryView.taxable_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${igst}", record.Format(V_GST_hsn_summaryView.igst), ReportEnum.Align.Right, 100)
                             report.AddData("${cgst}", record.Format(V_GST_hsn_summaryView.cgst), ReportEnum.Align.Right, 100)
                             report.AddData("${sgst}", record.Format(V_GST_hsn_summaryView.sgst), ReportEnum.Align.Right, 100)
                             report.AddData("${cess}", record.Format(V_GST_hsn_summaryView.cess), ReportEnum.Align.Right, 100)

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
        Public Overridable Sub V_GST_hsn_summaryRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim V_GST_hsn_summaryTableControlObj as V_GST_hsn_summaryTableControl = DirectCast(Me.Page.FindControlRecursively("V_GST_hsn_summaryTableControl"), V_GST_hsn_summaryTableControl)
            V_GST_hsn_summaryTableControlObj.ResetData = True
                        
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_hsn_summaryResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.month_yearFilter.ClearSelection()
              Me.V_GST_hsn_summarySearch.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.month_start, OrderByItem.OrderDir.Asc)
                
                Me.CurrentSortOrder.Add(V_GST_hsn_summaryView.hsn, OrderByItem.OrderDir.Asc)
                
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
        Public Overridable Sub V_GST_hsn_summaryWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_GST_hsn_summaryTable.V_GST_hsn_summaryWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_GST_hsn_summary"
                ' If ShowV_GST_hsn_summaryTable.V_GST_hsn_summaryWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(V_GST_hsn_summaryView.month_year.Name, ReportEnum.Align.Left, "${month_year}", ReportEnum.Align.Left, 25)
                 report.AddColumn(V_GST_hsn_summaryView.hsn.Name, ReportEnum.Align.Left, "${hsn}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_hsn_summaryView.gst_description.Name, ReportEnum.Align.Left, "${gst_description}", ReportEnum.Align.Left, 30)
                 report.AddColumn(V_GST_hsn_summaryView.gst_uom.Name, ReportEnum.Align.Left, "${gst_uom}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_hsn_summaryView.qty.Name, ReportEnum.Align.Right, "${qty}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.total_amt.Name, ReportEnum.Align.Right, "${total_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.taxable_amt.Name, ReportEnum.Align.Right, "${taxable_amt}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.igst.Name, ReportEnum.Align.Right, "${igst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.cgst.Name, ReportEnum.Align.Right, "${cgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.sgst.Name, ReportEnum.Align.Right, "${sgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_hsn_summaryView.cess.Name, ReportEnum.Align.Right, "${cess}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = V_GST_hsn_summaryView.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = V_GST_hsn_summaryView.GetColumnList()
                Dim records As V_GST_hsn_summaryRecord() = Nothing
                Do
                    records = V_GST_hsn_summaryView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As V_GST_hsn_summaryRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${month_year}", record.Format(V_GST_hsn_summaryView.month_year), ReportEnum.Align.Left, 100)
                             report.AddData("${hsn}", record.Format(V_GST_hsn_summaryView.hsn), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_description}", record.Format(V_GST_hsn_summaryView.gst_description), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_uom}", record.Format(V_GST_hsn_summaryView.gst_uom), ReportEnum.Align.Left, 100)
                             report.AddData("${qty}", record.Format(V_GST_hsn_summaryView.qty), ReportEnum.Align.Right, 100)
                             report.AddData("${total_amt}", record.Format(V_GST_hsn_summaryView.total_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${taxable_amt}", record.Format(V_GST_hsn_summaryView.taxable_amt), ReportEnum.Align.Right, 100)
                             report.AddData("${igst}", record.Format(V_GST_hsn_summaryView.igst), ReportEnum.Align.Right, 100)
                             report.AddData("${cgst}", record.Format(V_GST_hsn_summaryView.cgst), ReportEnum.Align.Right, 100)
                             report.AddData("${sgst}", record.Format(V_GST_hsn_summaryView.sgst), ReportEnum.Align.Right, 100)
                             report.AddData("${cess}", record.Format(V_GST_hsn_summaryView.cess), ReportEnum.Align.Right, 100)

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
        Public Overridable Sub V_GST_hsn_summaryFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Public Overridable Sub V_GST_hsn_summarySearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub month_yearFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
        
        Private _DataSource() As V_GST_hsn_summaryRecord = Nothing
        Public Property DataSource() As V_GST_hsn_summaryRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As V_GST_hsn_summaryRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property cessLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cessLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property cgstLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cgstLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_descriptionLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_descriptionLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_uomLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_uomLabel"), System.Web.UI.WebControls.LinkButton)
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
        
        Public ReadOnly Property month_yearFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "month_yearFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property month_yearLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "month_yearLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property month_yearLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "month_yearLabel1"), System.Web.UI.WebControls.LinkButton)
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
        
        Public ReadOnly Property taxable_amtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "taxable_amtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property total_amtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "total_amtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summaryExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summaryExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summaryFilterButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryFilterButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_hsn_summaryPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_hsn_summaryPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summaryRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summaryResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summarySearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summarySearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summarySearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summarySearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_hsn_summaryTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_hsn_summaryWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_hsn_summaryWordButton"), System.Web.UI.WebControls.ImageButton)
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
          
        Public Overridable Function GetSelectedRecordControl() As V_GST_hsn_summaryTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As V_GST_hsn_summaryTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(V_GST_hsn_summaryTableControlRow)), V_GST_hsn_summaryTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As V_GST_hsn_summaryTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As V_GST_hsn_summaryTableControlRow
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

        Public Function GetRecordControls() As V_GST_hsn_summaryTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_hsn_summaryTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As V_GST_hsn_summaryTableControlRow = DirectCast(repItem.FindControl("V_GST_hsn_summaryTableControlRow"), V_GST_hsn_summaryTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(V_GST_hsn_summaryTableControlRow)), V_GST_hsn_summaryTableControlRow())
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

  