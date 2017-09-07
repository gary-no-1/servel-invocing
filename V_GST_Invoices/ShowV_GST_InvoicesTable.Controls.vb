
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowV_GST_InvoicesTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowV_GST_InvoicesTable

#Region "Section 1: Place your customizations here."

    
Public Class V_GST_InvoicesTableControlRow
        Inherits BaseV_GST_InvoicesTableControlRow
        ' The BaseV_GST_InvoicesTableControlRow implements code for a ROW within the
        ' the V_GST_InvoicesTableControl table.  The BaseV_GST_InvoicesTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of V_GST_InvoicesTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class V_GST_InvoicesTableControl
        Inherits BaseV_GST_InvoicesTableControl

    ' The BaseV_GST_InvoicesTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The V_GST_InvoicesTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.


		Public Overrides Sub V_GST_InvoicesExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       V_GST_InvoicesView.site_gst_no, _ 
             V_GST_InvoicesView.inv_no, _ 
             V_GST_InvoicesView.gst_inv_dt, _ 
             V_GST_InvoicesView.grand_total, _ 
             V_GST_InvoicesView.gst_state, _ 
             V_GST_InvoicesView.reverse_charge, _ 
             V_GST_InvoicesView.invoice_type, _ 
             V_GST_InvoicesView.e_comm, _ 
             V_GST_InvoicesView.tax_rate, _ 
             V_GST_InvoicesView.item_total, _ 
             V_GST_InvoicesView.cess, _ 
             Nothing}
			Dim displayColumn as string = "GSTIN/UIN of Recipient,Invoice Number,Invoice date,Invoice Value,Place Of Supply,Reverse Charge,Invoice Type,E-Commerce GSTIN,Rate,Taxable Value,Cess Amount"
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(V_GST_InvoicesView.Instance, wc, orderBy, columns, displayColumn)
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
    
    
' Base class for the V_GST_InvoicesTableControlRow control on the ShowV_GST_InvoicesTable page.
' Do not modify this class. Instead override any method in V_GST_InvoicesTableControlRow.
Public Class BaseV_GST_InvoicesTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in V_GST_InvoicesTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in V_GST_InvoicesTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource V_GST_Invoices record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseV_GST_InvoicesTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New V_GST_InvoicesRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in V_GST_InvoicesTableControlRow.
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
            Sete_comm()
            Setgrand_total()
            Setgst_inv_dt()
            Setgst_state()
            Setigst()
            Setinv_dt()
            Setinv_no()
            Setinvoice_type()
            Setitem_total()
            Setreverse_charge()
            Setsgst()
            Setsite_gst_no()
            Settax_rate()
      
      
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
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.cess is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcess()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cessSpecified Then
                				
                ' If the cess is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.cess)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cess.Text = formattedValue
              
            Else 
            
                ' cess is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cess.Text = V_GST_InvoicesView.cess.Format(V_GST_InvoicesView.cess.DefaultValue)
                        		
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
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.cgst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcgst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cgstSpecified Then
                				
                ' If the cgst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.cgst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cgst.Text = formattedValue
              
            Else 
            
                ' cgst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cgst.Text = V_GST_InvoicesView.cgst.Format(V_GST_InvoicesView.cgst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the cgst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cgst.Text Is Nothing _
                OrElse Me.cgst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cgst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Sete_comm()
            
        
            ' Set the e_comm Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.e_comm is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Sete_comm()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.e_commSpecified Then
                				
                ' If the e_comm is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.e_comm)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.e_comm.Text = formattedValue
              
            Else 
            
                ' e_comm is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.e_comm.Text = V_GST_InvoicesView.e_comm.Format(V_GST_InvoicesView.e_comm.DefaultValue)
                        		
                End If
                 
            ' If the e_comm is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.e_comm.Text Is Nothing _
                OrElse Me.e_comm.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.e_comm.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgrand_total()
            
        
            ' Set the grand_total Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.grand_total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgrand_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.grand_totalSpecified Then
                				
                ' If the grand_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.grand_total, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.grand_total.Text = formattedValue
              
            Else 
            
                ' grand_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.grand_total.Text = V_GST_InvoicesView.grand_total.Format(V_GST_InvoicesView.grand_total.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the grand_total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.grand_total.Text Is Nothing _
                OrElse Me.grand_total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.grand_total.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_inv_dt()
            
        
            ' Set the gst_inv_dt Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.gst_inv_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_inv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_inv_dtSpecified Then
                				
                ' If the gst_inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.gst_inv_dt)
                            
                If Not formattedValue is Nothing Then
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(100, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(100, Integer)
                         
                        formattedValue = HttpUtility.HtmlEncode(formattedValue) 
                    End If                    
                    If maxLength = CType(100, Integer) Then
                        formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,maxLength))
                        formattedValue = formattedValue & "..."
                            
                    Else
                        formattedValue = "<table border=""0"" cellpadding=""0"" cellspacing=""0""><tr><td>" & formattedValue & "</td></tr></table>"
                    End If
                End If  
                
                Me.gst_inv_dt.Text = formattedValue
              
            Else 
            
                ' gst_inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_inv_dt.Text = V_GST_InvoicesView.gst_inv_dt.Format(V_GST_InvoicesView.gst_inv_dt.DefaultValue)
                        		
                End If
                 
            ' If the gst_inv_dt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_inv_dt.Text Is Nothing _
                OrElse Me.gst_inv_dt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_inv_dt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_state()
            
        
            ' Set the gst_state Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.gst_state is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_state()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_stateSpecified Then
                				
                ' If the gst_state is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.gst_state)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.gst_state.Text = formattedValue
              
            Else 
            
                ' gst_state is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_state.Text = V_GST_InvoicesView.gst_state.Format(V_GST_InvoicesView.gst_state.DefaultValue)
                        		
                End If
                 
            ' If the gst_state is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_state.Text Is Nothing _
                OrElse Me.gst_state.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_state.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setigst()
            
        
            ' Set the igst Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.igst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setigst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.igstSpecified Then
                				
                ' If the igst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.igst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.igst.Text = formattedValue
              
            Else 
            
                ' igst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.igst.Text = V_GST_InvoicesView.igst.Format(V_GST_InvoicesView.igst.DefaultValue, "##,##,##,###.##")
                        		
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
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.inv_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_dtSpecified Then
                				
                ' If the inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.inv_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_dt.Text = formattedValue
              
            Else 
            
                ' inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_dt.Text = V_GST_InvoicesView.inv_dt.Format(V_GST_InvoicesView.inv_dt.DefaultValue, "d")
                        		
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
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_noSpecified Then
                				
                ' If the inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_no.Text = formattedValue
              
            Else 
            
                ' inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_no.Text = V_GST_InvoicesView.inv_no.Format(V_GST_InvoicesView.inv_no.DefaultValue)
                        		
                End If
                 
            ' If the inv_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.inv_no.Text Is Nothing _
                OrElse Me.inv_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.inv_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setinvoice_type()
            
        
            ' Set the invoice_type Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.invoice_type is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinvoice_type()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.invoice_typeSpecified Then
                				
                ' If the invoice_type is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.invoice_type)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.invoice_type.Text = formattedValue
              
            Else 
            
                ' invoice_type is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.invoice_type.Text = V_GST_InvoicesView.invoice_type.Format(V_GST_InvoicesView.invoice_type.DefaultValue)
                        		
                End If
                 
            ' If the invoice_type is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.invoice_type.Text Is Nothing _
                OrElse Me.invoice_type.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.invoice_type.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setitem_total()
            
        
            ' Set the item_total Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.item_total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_totalSpecified Then
                				
                ' If the item_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.item_total, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.item_total.Text = formattedValue
              
            Else 
            
                ' item_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_total.Text = V_GST_InvoicesView.item_total.Format(V_GST_InvoicesView.item_total.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the item_total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.item_total.Text Is Nothing _
                OrElse Me.item_total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.item_total.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setreverse_charge()
            
        
            ' Set the reverse_charge Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.reverse_charge is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setreverse_charge()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.reverse_chargeSpecified Then
                				
                ' If the reverse_charge is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.reverse_charge)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.reverse_charge.Text = formattedValue
              
            Else 
            
                ' reverse_charge is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.reverse_charge.Text = V_GST_InvoicesView.reverse_charge.Format(V_GST_InvoicesView.reverse_charge.DefaultValue)
                        		
                End If
                 
            ' If the reverse_charge is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.reverse_charge.Text Is Nothing _
                OrElse Me.reverse_charge.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.reverse_charge.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsgst()
            
        
            ' Set the sgst Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.sgst is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsgst()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sgstSpecified Then
                				
                ' If the sgst is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.sgst, "##,##,##,###.##")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sgst.Text = formattedValue
              
            Else 
            
                ' sgst is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sgst.Text = V_GST_InvoicesView.sgst.Format(V_GST_InvoicesView.sgst.DefaultValue, "##,##,##,###.##")
                        		
                End If
                 
            ' If the sgst is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.sgst.Text Is Nothing _
                OrElse Me.sgst.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.sgst.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsite_gst_no()
            
        
            ' Set the site_gst_no Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.site_gst_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsite_gst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.site_gst_noSpecified Then
                				
                ' If the site_gst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.site_gst_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.site_gst_no.Text = formattedValue
              
            Else 
            
                ' site_gst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.site_gst_no.Text = V_GST_InvoicesView.site_gst_no.Format(V_GST_InvoicesView.site_gst_no.DefaultValue)
                        		
                End If
                 
            ' If the site_gst_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.site_gst_no.Text Is Nothing _
                OrElse Me.site_gst_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.site_gst_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settax_rate()
            
        
            ' Set the tax_rate Literal on the webpage with value from the
            ' V_GST_Invoices database record.

            ' Me.DataSource is the V_GST_Invoices record retrieved from the database.
            ' Me.tax_rate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_rate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_rateSpecified Then
                				
                ' If the tax_rate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(V_GST_InvoicesView.tax_rate)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tax_rate.Text = formattedValue
              
            Else 
            
                ' tax_rate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_rate.Text = V_GST_InvoicesView.tax_rate.Format(V_GST_InvoicesView.tax_rate.DefaultValue)
                        		
                End If
                 
            ' If the tax_rate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tax_rate.Text Is Nothing _
                OrElse Me.tax_rate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tax_rate.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in V_GST_InvoicesTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "V_GST_InvoicesTableControl"), V_GST_InvoicesTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "V_GST_InvoicesTableControl"), V_GST_InvoicesTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in V_GST_InvoicesTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getcess()
            Getcgst()
            Gete_comm()
            Getgrand_total()
            Getgst_inv_dt()
            Getgst_state()
            Getigst()
            Getinv_dt()
            Getinv_no()
            Getinvoice_type()
            Getitem_total()
            Getreverse_charge()
            Getsgst()
            Getsite_gst_no()
            Gettax_rate()
        End Sub
        
        
        Public Overridable Sub Getcess()
            
        End Sub
                
        Public Overridable Sub Getcgst()
            
        End Sub
                
        Public Overridable Sub Gete_comm()
            
        End Sub
                
        Public Overridable Sub Getgrand_total()
            
        End Sub
                
        Public Overridable Sub Getgst_inv_dt()
            
        End Sub
                
        Public Overridable Sub Getgst_state()
            
        End Sub
                
        Public Overridable Sub Getigst()
            
        End Sub
                
        Public Overridable Sub Getinv_dt()
            
        End Sub
                
        Public Overridable Sub Getinv_no()
            
        End Sub
                
        Public Overridable Sub Getinvoice_type()
            
        End Sub
                
        Public Overridable Sub Getitem_total()
            
        End Sub
                
        Public Overridable Sub Getreverse_charge()
            
        End Sub
                
        Public Overridable Sub Getsgst()
            
        End Sub
                
        Public Overridable Sub Getsite_gst_no()
            
        End Sub
                
        Public Overridable Sub Gettax_rate()
            
        End Sub
                
      
        ' To customize, override this method in V_GST_InvoicesTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in V_GST_InvoicesTableControlRow.
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
        
        Private _DataSource As V_GST_InvoicesRecord
        Public Property DataSource() As V_GST_InvoicesRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As V_GST_InvoicesRecord)
            
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
            
        Public ReadOnly Property e_comm() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "e_comm"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property grand_total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_inv_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_inv_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_state() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_state"), System.Web.UI.WebControls.Literal)
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
            
        Public ReadOnly Property invoice_type() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "invoice_type"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property item_total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property reverse_charge() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "reverse_charge"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property sgst() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sgst"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property site_gst_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "site_gst_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tax_rate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_rate"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As V_GST_InvoicesRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As V_GST_InvoicesRecord
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

  

' Base class for the V_GST_InvoicesTableControl control on the ShowV_GST_InvoicesTable page.
' Do not modify this class. Instead override any method in V_GST_InvoicesTableControl.
Public Class BaseV_GST_InvoicesTableControl
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
                If  Me.InSession(Me.V_GST_InvoicesSearch) 				
                    initialVal = Me.GetFromSession(Me.V_GST_InvoicesSearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.V_GST_InvoicesSearch.Text = initialVal
                            
                    End If
                
            End If
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_dt, OrderByItem.OrderDir.Asc)
              
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_no, OrderByItem.OrderDir.Asc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
              AddHandler Me.V_GST_InvoicesPagination.FirstPage.Click, AddressOf V_GST_InvoicesPagination_FirstPage_Click
              
              AddHandler Me.V_GST_InvoicesPagination.LastPage.Click, AddressOf V_GST_InvoicesPagination_LastPage_Click
              
              AddHandler Me.V_GST_InvoicesPagination.NextPage.Click, AddressOf V_GST_InvoicesPagination_NextPage_Click
              
              AddHandler Me.V_GST_InvoicesPagination.PageSizeButton.Click, AddressOf V_GST_InvoicesPagination_PageSizeButton_Click
            
              AddHandler Me.V_GST_InvoicesPagination.PreviousPage.Click, AddressOf V_GST_InvoicesPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.cessLabel.Click, AddressOf cessLabel_Click
            
              AddHandler Me.cgstLabel.Click, AddressOf cgstLabel_Click
            
              AddHandler Me.e_commLabel.Click, AddressOf e_commLabel_Click
            
              AddHandler Me.grand_totalLabel.Click, AddressOf grand_totalLabel_Click
            
              AddHandler Me.gst_inv_dtLabel.Click, AddressOf gst_inv_dtLabel_Click
            
              AddHandler Me.gst_stateLabel.Click, AddressOf gst_stateLabel_Click
            
              AddHandler Me.igstLabel.Click, AddressOf igstLabel_Click
            
              AddHandler Me.inv_dtLabel.Click, AddressOf inv_dtLabel_Click
            
              AddHandler Me.inv_noLabel1.Click, AddressOf inv_noLabel1_Click
            
              AddHandler Me.invoice_typeLabel.Click, AddressOf invoice_typeLabel_Click
            
              AddHandler Me.item_totalLabel.Click, AddressOf item_totalLabel_Click
            
              AddHandler Me.reverse_chargeLabel.Click, AddressOf reverse_chargeLabel_Click
            
              AddHandler Me.sgstLabel.Click, AddressOf sgstLabel_Click
            
              AddHandler Me.site_gst_noLabel1.Click, AddressOf site_gst_noLabel1_Click
            
              AddHandler Me.tax_rateLabel.Click, AddressOf tax_rateLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.V_GST_InvoicesExportCSVButton.Click, AddressOf V_GST_InvoicesExportCSVButton_Click
              
              AddHandler Me.V_GST_InvoicesExportExcelButton.Click, AddressOf V_GST_InvoicesExportExcelButton_Click
              
              AddHandler Me.V_GST_InvoicesPDFButton.Click, AddressOf V_GST_InvoicesPDFButton_Click
              
              AddHandler Me.V_GST_InvoicesRefreshButton.Click, AddressOf V_GST_InvoicesRefreshButton_Click
              
              AddHandler Me.V_GST_InvoicesResetButton.Click, AddressOf V_GST_InvoicesResetButton_Click
              
              AddHandler Me.V_GST_InvoicesWordButton.Click, AddressOf V_GST_InvoicesWordButton_Click
              
            AddHandler Me.V_GST_InvoicesFilterButton.Button.Click, AddressOf V_GST_InvoicesFilterButton_Click
        
            AddHandler Me.V_GST_InvoicesSearchButton.Button.Click, AddressOf V_GST_InvoicesSearchButton_Click
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_GST_InvoicesRecord)), V_GST_InvoicesRecord())
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
                
                Me.TotalRecords = V_GST_InvoicesView.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(V_GST_InvoicesRecord)), V_GST_InvoicesRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As V_GST_InvoicesTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(V_GST_InvoicesRecord)), V_GST_InvoicesRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = V_GST_InvoicesView.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
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
            Sete_commLabel()
            Setgrand_totalLabel()
            Setgst_inv_dtLabel()
            Setgst_stateLabel()
            SetigstLabel()
            Setinv_dtLabel()
            Setinv_dtLabel1()
            Setinv_noLabel1()
            Setinvoice_typeLabel()
            Setitem_totalLabel()
            Setreverse_chargeLabel()
            SetsgstLabel()
            Setsite_gst_noLabel1()
            Settax_rateLabel()
            SetV_GST_InvoicesSearch()
            
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_InvoicesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As V_GST_InvoicesTableControlRow = DirectCast(repItem.FindControl("V_GST_InvoicesTableControlRow"), V_GST_InvoicesTableControlRow) 
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
            Sete_commLabel()
            Setgrand_totalLabel()
            Setgst_inv_dtLabel()
            Setgst_stateLabel()
            SetigstLabel()
            Setinv_dtLabel()
            Setinv_dtLabel1()
            Setinv_noLabel1()
            Setinvoice_typeLabel()
            Setitem_totalLabel()
            Setreverse_chargeLabel()
            SetsgstLabel()
            Setsite_gst_noLabel1()
            Settax_rateLabel()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_InvoicesExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_InvoicesExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_InvoicesPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"V_GST_InvoicesWordButton"))
                        
        
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
            
            Me.V_GST_InvoicesSearch.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_dt, OrderByItem.OrderDir.Asc)
              
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_no, OrderByItem.OrderDir.Asc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for V_GST_InvoicesTableControl pagination.
        
            Me.V_GST_InvoicesPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.V_GST_InvoicesPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_GST_InvoicesPagination.LastPage.Enabled = False
            End If
          
            Me.V_GST_InvoicesPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.V_GST_InvoicesPagination.NextPage.Enabled = False
            End If
          
            Me.V_GST_InvoicesPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.V_GST_InvoicesPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.V_GST_InvoicesPagination.CurrentPage.Text = "0"
            End If
            Me.V_GST_InvoicesPagination.PageSize.Text = Me.PageSize.ToString()
            Me.V_GST_InvoicesPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.V_GST_InvoicesPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As V_GST_InvoicesTableControlRow
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
            V_GST_InvoicesView.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.inv_dtFromFilter) Then
                Dim val As String = MiscUtils.GetSelectedValue(Me.inv_dtFromFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                
                val = d.ToShortDateString & " " & "00:00:00"
                wc.iAND(V_GST_InvoicesView.inv_dt, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.inv_dtToFilter) Then
                Dim val As String = MiscUtils.GetSelectedValue(Me.inv_dtToFilter, "")
                Dim d As DateTime = DateParser.ParseDate(val, DateColumn.DEFAULT_FORMAT)
                
                val = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(V_GST_InvoicesView.inv_dt, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, val, False, False)
                    
            End If    
            If IsValueSelected(Me.V_GST_InvoicesSearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.V_GST_InvoicesSearch.Text.StartsWith("...") Then
                    Me.V_GST_InvoicesSearch.Text = Me.V_GST_InvoicesSearch.Text.SubString(3,Me.V_GST_InvoicesSearch.Text.Length-3)
                End If
                If Me.V_GST_InvoicesSearch.Text.EndsWith("...") then
                    Me.V_GST_InvoicesSearch.Text = Me.V_GST_InvoicesSearch.Text.SubString(0,Me.V_GST_InvoicesSearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.V_GST_InvoicesSearch, Me.GetFromSession(Me.V_GST_InvoicesSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.V_GST_InvoicesSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(V_GST_InvoicesView.site_gst_no, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_GST_InvoicesSearch, Me.GetFromSession(Me.V_GST_InvoicesSearch)), True, False)
        
                    search.iOR(V_GST_InvoicesView.inv_no, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.V_GST_InvoicesSearch, Me.GetFromSession(Me.V_GST_InvoicesSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            V_GST_InvoicesView.Instance.InnerFilter = Nothing
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
                wc.iAND(V_GST_InvoicesView.inv_dt, BaseFilter.ComparisonOperator.Greater_Than_Or_Equal, inv_dtFromFilterSelectedValue, False, False)
                    
            End If    
            Dim inv_dtToFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "inv_dtToFilter_Ajax"), String)
            If IsValueSelected(inv_dtToFilterSelectedValue) Then
                Dim d as DateTime = DateParser.ParseDate(inv_dtToFilterSelectedValue, DateColumn.DEFAULT_FORMAT)
                inv_dtToFilterSelectedValue = d.ToShortDateString & " " & "23:59:59"
                wc.iAND(V_GST_InvoicesView.inv_dt, BaseFilter.ComparisonOperator.Less_Than_Or_Equal, inv_dtToFilterSelectedValue, False, False)
                    
            End If    
            If IsValueSelected(searchText) and fromSearchControl = "V_GST_InvoicesSearch" Then
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
                
                        search.iOR(V_GST_InvoicesView.site_gst_no, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_GST_InvoicesView.site_gst_no, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(V_GST_InvoicesView.inv_no, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(V_GST_InvoicesView.inv_no, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(V_GST_InvoicesView.site_gst_no, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(V_GST_InvoicesView.inv_no, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_V_GST_InvoicesSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"V_GST_InvoicesSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.V_GST_InvoicesRecord = V_GST_InvoicesView.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As V_GST_InvoicesRecord = Nothing
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
                
                    resultItem = rec.Format(V_GST_InvoicesView.site_gst_no)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(V_GST_InvoicesView.inv_no)
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
        
            If Me.V_GST_InvoicesPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.V_GST_InvoicesPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_InvoicesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As V_GST_InvoicesTableControlRow = DirectCast(repItem.FindControl("V_GST_InvoicesTableControlRow"), V_GST_InvoicesTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As V_GST_InvoicesRecord = New V_GST_InvoicesRecord()
        
                        If recControl.cess.Text <> "" Then
                            rec.Parse(recControl.cess.Text, V_GST_InvoicesView.cess)
                        End If
                        If recControl.cgst.Text <> "" Then
                            rec.Parse(recControl.cgst.Text, V_GST_InvoicesView.cgst)
                        End If
                        If recControl.e_comm.Text <> "" Then
                            rec.Parse(recControl.e_comm.Text, V_GST_InvoicesView.e_comm)
                        End If
                        If recControl.grand_total.Text <> "" Then
                            rec.Parse(recControl.grand_total.Text, V_GST_InvoicesView.grand_total)
                        End If
                        If recControl.gst_inv_dt.Text <> "" Then
                            rec.Parse(recControl.gst_inv_dt.Text, V_GST_InvoicesView.gst_inv_dt)
                        End If
                        If recControl.gst_state.Text <> "" Then
                            rec.Parse(recControl.gst_state.Text, V_GST_InvoicesView.gst_state)
                        End If
                        If recControl.igst.Text <> "" Then
                            rec.Parse(recControl.igst.Text, V_GST_InvoicesView.igst)
                        End If
                        If recControl.inv_dt.Text <> "" Then
                            rec.Parse(recControl.inv_dt.Text, V_GST_InvoicesView.inv_dt)
                        End If
                        If recControl.inv_no.Text <> "" Then
                            rec.Parse(recControl.inv_no.Text, V_GST_InvoicesView.inv_no)
                        End If
                        If recControl.invoice_type.Text <> "" Then
                            rec.Parse(recControl.invoice_type.Text, V_GST_InvoicesView.invoice_type)
                        End If
                        If recControl.item_total.Text <> "" Then
                            rec.Parse(recControl.item_total.Text, V_GST_InvoicesView.item_total)
                        End If
                        If recControl.reverse_charge.Text <> "" Then
                            rec.Parse(recControl.reverse_charge.Text, V_GST_InvoicesView.reverse_charge)
                        End If
                        If recControl.sgst.Text <> "" Then
                            rec.Parse(recControl.sgst.Text, V_GST_InvoicesView.sgst)
                        End If
                        If recControl.site_gst_no.Text <> "" Then
                            rec.Parse(recControl.site_gst_no.Text, V_GST_InvoicesView.site_gst_no)
                        End If
                        If recControl.tax_rate.Text <> "" Then
                            rec.Parse(recControl.tax_rate.Text, V_GST_InvoicesView.tax_rate)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New V_GST_InvoicesRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(V_GST_InvoicesRecord)), V_GST_InvoicesRecord())
              
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
                
        Public Overridable Sub Sete_commLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgrand_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_inv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_stateLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetigstLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setinvoice_typeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setreverse_chargeLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetsgstLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsite_gst_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Settax_rateLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetV_GST_InvoicesSearch()
            
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
                  
            Me.SaveToSession(Me.V_GST_InvoicesSearch, Me.V_GST_InvoicesSearch.Text)
                  
            
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
              
      Me.SaveToSession("V_GST_InvoicesSearch_Ajax", Me.V_GST_InvoicesSearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.inv_dtFromFilter)
            Me.RemoveFromSession(Me.inv_dtToFilter)
            Me.RemoveFromSession(Me.V_GST_InvoicesSearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("V_GST_InvoicesTableControl_OrderBy"), String)
            
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
                Me.ViewState("V_GST_InvoicesTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_InvoicesPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_InvoicesPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_InvoicesPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub V_GST_InvoicesPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.V_GST_InvoicesPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.V_GST_InvoicesPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub V_GST_InvoicesPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.cess)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cess.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.cess, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.cgst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cgst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.cgst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cgst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub e_commLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by e_comm when clicked.
              
            ' Get previous sorting state for e_comm.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.e_comm)
            If sd Is Nothing Then
                ' First time sort, so add sort order for e_comm.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.e_comm, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by e_comm, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.grand_total)
            If sd Is Nothing Then
                ' First time sort, so add sort order for grand_total.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.grand_total, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by grand_total, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_inv_dtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_inv_dt when clicked.
              
            ' Get previous sorting state for gst_inv_dt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.gst_inv_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_inv_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.gst_inv_dt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_inv_dt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_stateLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_state when clicked.
              
            ' Get previous sorting state for gst_state.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.gst_state)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_state.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.gst_state, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_state, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.igst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for igst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.igst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by igst, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.inv_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for inv_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_dt, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.inv_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for inv_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by inv_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub invoice_typeLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by invoice_type when clicked.
              
            ' Get previous sorting state for invoice_type.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.invoice_type)
            If sd Is Nothing Then
                ' First time sort, so add sort order for invoice_type.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.invoice_type, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by invoice_type, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.item_total)
            If sd Is Nothing Then
                ' First time sort, so add sort order for item_total.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.item_total, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by item_total, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub reverse_chargeLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by reverse_charge when clicked.
              
            ' Get previous sorting state for reverse_charge.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.reverse_charge)
            If sd Is Nothing Then
                ' First time sort, so add sort order for reverse_charge.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.reverse_charge, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by reverse_charge, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.sgst)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sgst.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.sgst, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sgst, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub site_gst_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by site_gst_no when clicked.
              
            ' Get previous sorting state for site_gst_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.site_gst_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for site_gst_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.site_gst_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by site_gst_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tax_rateLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tax_rate when clicked.
              
            ' Get previous sorting state for tax_rate.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(V_GST_InvoicesView.tax_rate)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tax_rate.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.tax_rate, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tax_rate, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_InvoicesExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       V_GST_InvoicesView.site_gst_no, _ 
             V_GST_InvoicesView.inv_no, _ 
             V_GST_InvoicesView.inv_dt, _ 
             V_GST_InvoicesView.gst_inv_dt, _ 
             V_GST_InvoicesView.grand_total, _ 
             V_GST_InvoicesView.gst_state, _ 
             V_GST_InvoicesView.reverse_charge, _ 
             V_GST_InvoicesView.invoice_type, _ 
             V_GST_InvoicesView.e_comm, _ 
             V_GST_InvoicesView.tax_rate, _ 
             V_GST_InvoicesView.item_total, _ 
             V_GST_InvoicesView.igst, _ 
             V_GST_InvoicesView.cgst, _ 
             V_GST_InvoicesView.sgst, _ 
             V_GST_InvoicesView.cess, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(V_GST_InvoicesView.Instance, wc, orderBy, columns)
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
        Public Overridable Sub V_GST_InvoicesExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(V_GST_InvoicesView.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.site_gst_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.inv_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.inv_dt, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.gst_inv_dt, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.grand_total, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.gst_state, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.reverse_charge, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.invoice_type, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.e_comm, "Default"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.tax_rate, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.item_total, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.igst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.cgst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.sgst, "Standard"))
             excelReport.AddColumn(New ExcelColumn(V_GST_InvoicesView.cess, "0"))

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
        Public Overridable Sub V_GST_InvoicesPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_GST_InvoicesTable.V_GST_InvoicesPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_GST_Invoices"
                ' If ShowV_GST_InvoicesTable.V_GST_InvoicesPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(V_GST_InvoicesView.site_gst_no.Name, ReportEnum.Align.Left, "${site_gst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_InvoicesView.inv_no.Name, ReportEnum.Align.Left, "${inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_InvoicesView.inv_dt.Name, ReportEnum.Align.Left, "${inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_InvoicesView.gst_inv_dt.Name, ReportEnum.Align.Left, "${gst_inv_dt}", ReportEnum.Align.Left, 30)
                 report.AddColumn(V_GST_InvoicesView.grand_total.Name, ReportEnum.Align.Right, "${grand_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.gst_state.Name, ReportEnum.Align.Left, "${gst_state}", ReportEnum.Align.Left, 23)
                 report.AddColumn(V_GST_InvoicesView.reverse_charge.Name, ReportEnum.Align.Left, "${reverse_charge}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_InvoicesView.invoice_type.Name, ReportEnum.Align.Left, "${invoice_type}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_InvoicesView.e_comm.Name, ReportEnum.Align.Left, "${e_comm}", ReportEnum.Align.Left, 16)
                 report.AddColumn(V_GST_InvoicesView.tax_rate.Name, ReportEnum.Align.Right, "${tax_rate}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.item_total.Name, ReportEnum.Align.Right, "${item_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.igst.Name, ReportEnum.Align.Right, "${igst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.cgst.Name, ReportEnum.Align.Right, "${cgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.sgst.Name, ReportEnum.Align.Right, "${sgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.cess.Name, ReportEnum.Align.Right, "${cess}", ReportEnum.Align.Right, 15)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = V_GST_InvoicesView.GetRecordCount(whereClause)
                Dim columns As ColumnList = V_GST_InvoicesView.GetColumnList()
                Dim records As V_GST_InvoicesRecord() = Nothing
            
                Do 
                    
                    records = V_GST_InvoicesView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As V_GST_InvoicesRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${site_gst_no}", record.Format(V_GST_InvoicesView.site_gst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_no}", record.Format(V_GST_InvoicesView.inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_dt}", record.Format(V_GST_InvoicesView.inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_inv_dt}", record.Format(V_GST_InvoicesView.gst_inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${grand_total}", record.Format(V_GST_InvoicesView.grand_total), ReportEnum.Align.Right, 100)
                             report.AddData("${gst_state}", record.Format(V_GST_InvoicesView.gst_state), ReportEnum.Align.Left, 100)
                             report.AddData("${reverse_charge}", record.Format(V_GST_InvoicesView.reverse_charge), ReportEnum.Align.Left, 100)
                             report.AddData("${invoice_type}", record.Format(V_GST_InvoicesView.invoice_type), ReportEnum.Align.Left, 100)
                             report.AddData("${e_comm}", record.Format(V_GST_InvoicesView.e_comm), ReportEnum.Align.Left, 100)
                             report.AddData("${tax_rate}", record.Format(V_GST_InvoicesView.tax_rate), ReportEnum.Align.Right, 100)
                             report.AddData("${item_total}", record.Format(V_GST_InvoicesView.item_total), ReportEnum.Align.Right, 100)
                             report.AddData("${igst}", record.Format(V_GST_InvoicesView.igst), ReportEnum.Align.Right, 100)
                             report.AddData("${cgst}", record.Format(V_GST_InvoicesView.cgst), ReportEnum.Align.Right, 100)
                             report.AddData("${sgst}", record.Format(V_GST_InvoicesView.sgst), ReportEnum.Align.Right, 100)
                             report.AddData("${cess}", record.Format(V_GST_InvoicesView.cess), ReportEnum.Align.Right, 100)

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
        Public Overridable Sub V_GST_InvoicesRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim V_GST_InvoicesTableControlObj as V_GST_InvoicesTableControl = DirectCast(Me.Page.FindControlRecursively("V_GST_InvoicesTableControl"), V_GST_InvoicesTableControl)
            V_GST_InvoicesTableControlObj.ResetData = True
                        
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub V_GST_InvoicesResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.inv_dtFromFilter.Text = ""
              Me.inv_dtToFilter.Text = ""
              Me.V_GST_InvoicesSearch.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_dt, OrderByItem.OrderDir.Asc)
                
                Me.CurrentSortOrder.Add(V_GST_InvoicesView.inv_no, OrderByItem.OrderDir.Asc)
                
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
        Public Overridable Sub V_GST_InvoicesWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowV_GST_InvoicesTable.V_GST_InvoicesWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "V_GST_Invoices"
                ' If ShowV_GST_InvoicesTable.V_GST_InvoicesWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(V_GST_InvoicesView.site_gst_no.Name, ReportEnum.Align.Left, "${site_gst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_InvoicesView.inv_no.Name, ReportEnum.Align.Left, "${inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_InvoicesView.inv_dt.Name, ReportEnum.Align.Left, "${inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(V_GST_InvoicesView.gst_inv_dt.Name, ReportEnum.Align.Left, "${gst_inv_dt}", ReportEnum.Align.Left, 30)
                 report.AddColumn(V_GST_InvoicesView.grand_total.Name, ReportEnum.Align.Right, "${grand_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.gst_state.Name, ReportEnum.Align.Left, "${gst_state}", ReportEnum.Align.Left, 23)
                 report.AddColumn(V_GST_InvoicesView.reverse_charge.Name, ReportEnum.Align.Left, "${reverse_charge}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_InvoicesView.invoice_type.Name, ReportEnum.Align.Left, "${invoice_type}", ReportEnum.Align.Left, 15)
                 report.AddColumn(V_GST_InvoicesView.e_comm.Name, ReportEnum.Align.Left, "${e_comm}", ReportEnum.Align.Left, 16)
                 report.AddColumn(V_GST_InvoicesView.tax_rate.Name, ReportEnum.Align.Right, "${tax_rate}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.item_total.Name, ReportEnum.Align.Right, "${item_total}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.igst.Name, ReportEnum.Align.Right, "${igst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.cgst.Name, ReportEnum.Align.Right, "${cgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.sgst.Name, ReportEnum.Align.Right, "${sgst}", ReportEnum.Align.Right, 20)
                 report.AddColumn(V_GST_InvoicesView.cess.Name, ReportEnum.Align.Right, "${cess}", ReportEnum.Align.Right, 15)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = V_GST_InvoicesView.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = V_GST_InvoicesView.GetColumnList()
                Dim records As V_GST_InvoicesRecord() = Nothing
                Do
                    records = V_GST_InvoicesView.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As V_GST_InvoicesRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${site_gst_no}", record.Format(V_GST_InvoicesView.site_gst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_no}", record.Format(V_GST_InvoicesView.inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${inv_dt}", record.Format(V_GST_InvoicesView.inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_inv_dt}", record.Format(V_GST_InvoicesView.gst_inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${grand_total}", record.Format(V_GST_InvoicesView.grand_total), ReportEnum.Align.Right, 100)
                             report.AddData("${gst_state}", record.Format(V_GST_InvoicesView.gst_state), ReportEnum.Align.Left, 100)
                             report.AddData("${reverse_charge}", record.Format(V_GST_InvoicesView.reverse_charge), ReportEnum.Align.Left, 100)
                             report.AddData("${invoice_type}", record.Format(V_GST_InvoicesView.invoice_type), ReportEnum.Align.Left, 100)
                             report.AddData("${e_comm}", record.Format(V_GST_InvoicesView.e_comm), ReportEnum.Align.Left, 100)
                             report.AddData("${tax_rate}", record.Format(V_GST_InvoicesView.tax_rate), ReportEnum.Align.Right, 100)
                             report.AddData("${item_total}", record.Format(V_GST_InvoicesView.item_total), ReportEnum.Align.Right, 100)
                             report.AddData("${igst}", record.Format(V_GST_InvoicesView.igst), ReportEnum.Align.Right, 100)
                             report.AddData("${cgst}", record.Format(V_GST_InvoicesView.cgst), ReportEnum.Align.Right, 100)
                             report.AddData("${sgst}", record.Format(V_GST_InvoicesView.sgst), ReportEnum.Align.Right, 100)
                             report.AddData("${cess}", record.Format(V_GST_InvoicesView.cess), ReportEnum.Align.Right, 100)

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
        Public Overridable Sub V_GST_InvoicesFilterButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Public Overridable Sub V_GST_InvoicesSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        
        Private _DataSource() As V_GST_InvoicesRecord = Nothing
        Public Property DataSource() As V_GST_InvoicesRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As V_GST_InvoicesRecord)
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
        
        Public ReadOnly Property e_commLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "e_commLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property grand_totalLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_totalLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_inv_dtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_inv_dtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_stateLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_stateLabel"), System.Web.UI.WebControls.LinkButton)
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
        
        Public ReadOnly Property invoice_typeLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "invoice_typeLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property item_totalLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_totalLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property reverse_chargeLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "reverse_chargeLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property sgstLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sgstLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property site_gst_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "site_gst_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tax_rateLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_rateLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesFilterButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesFilterButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_InvoicesPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_InvoicesPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesSearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesSearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property V_GST_InvoicesTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property V_GST_InvoicesWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "V_GST_InvoicesWordButton"), System.Web.UI.WebControls.ImageButton)
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
          
        Public Overridable Function GetSelectedRecordControl() As V_GST_InvoicesTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As V_GST_InvoicesTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(V_GST_InvoicesTableControlRow)), V_GST_InvoicesTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As V_GST_InvoicesTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As V_GST_InvoicesTableControlRow
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

        Public Function GetRecordControls() As V_GST_InvoicesTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("V_GST_InvoicesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As V_GST_InvoicesTableControlRow = DirectCast(repItem.FindControl("V_GST_InvoicesTableControlRow"), V_GST_InvoicesTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(V_GST_InvoicesTableControlRow)), V_GST_InvoicesTableControlRow())
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

  