
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowPro_inv_hdrTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowPro_inv_hdrTable

#Region "Section 1: Place your customizations here."

    
Public Class Pro_inv_hdrTableControlRow
        Inherits BasePro_inv_hdrTableControlRow
        ' The BasePro_inv_hdrTableControlRow implements code for a ROW within the
        ' the Pro_inv_hdrTableControl table.  The BasePro_inv_hdrTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Pro_inv_hdrTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Pro_inv_hdrTableControl
        Inherits BasePro_inv_hdrTableControl

    ' The BasePro_inv_hdrTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Pro_inv_hdrTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Pro_inv_hdrTableControlRow control on the ShowPro_inv_hdrTable page.
' Do not modify this class. Instead override any method in Pro_inv_hdrTableControlRow.
Public Class BasePro_inv_hdrTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Pro_inv_hdrTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Pro_inv_hdrTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.Pro_inv_hdrRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.Pro_inv_hdrRowCopyButton.Click, AddressOf Pro_inv_hdrRowCopyButton_Click
              
              AddHandler Me.Pro_inv_hdrRowDeleteButton.Click, AddressOf Pro_inv_hdrRowDeleteButton_Click
              
              AddHandler Me.Pro_inv_hdrRowEditButton.Click, AddressOf Pro_inv_hdrRowEditButton_Click
              
              AddHandler Me.Pro_inv_hdrRowViewButton.Click, AddressOf Pro_inv_hdrRowViewButton_Click
              
              AddHandler Me.id_party.Click, AddressOf id_party_Click
            
              AddHandler Me.id_tax_group.Click, AddressOf id_tax_group_Click
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource pro_inv_hdr record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Pro_inv_hdrTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BasePro_inv_hdrTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Pro_inv_hdrRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Pro_inv_hdrTableControlRow.
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
        
            Setbill_address()
            Setbill_name()
            Setid_party()
            Setid_tax_group()
            Setpo_dt()
            Setpo_no()
            Setpro_inv_dt()
            Setpro_inv_no()
            Setsale_ord_dt()
            Setsale_ord_no()
            Setship_address()
            Setship_name()
            Settin_no()
      
      
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
        
        
        Public Overridable Sub Setbill_address()
            
        
            ' Set the bill_address Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.bill_address is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setbill_address()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.bill_addressSpecified Then
                				
                ' If the bill_address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.bill_address)
                            
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
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ServelInvocing.Business.Pro_inv_hdrTable, ServelInvocing.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""bill_address\"", \""bill_address\"", \""Bill Address\"", false, 200," _
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
                
                Me.bill_address.Text = formattedValue
              
            Else 
            
                ' bill_address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.bill_address.Text = Pro_inv_hdrTable.bill_address.Format(Pro_inv_hdrTable.bill_address.DefaultValue)
                        		
                End If
                 
            ' If the bill_address is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.bill_address.Text Is Nothing _
                OrElse Me.bill_address.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.bill_address.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setbill_name()
            
        
            ' Set the bill_name Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.bill_name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setbill_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.bill_nameSpecified Then
                				
                ' If the bill_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.bill_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.bill_name.Text = formattedValue
              
            Else 
            
                ' bill_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.bill_name.Text = Pro_inv_hdrTable.bill_name.Format(Pro_inv_hdrTable.bill_name.DefaultValue)
                        		
                End If
                 
            ' If the bill_name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.bill_name.Text Is Nothing _
                OrElse Me.bill_name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.bill_name.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setid_party()
            
        
            ' Set the id_party LinkButton on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_party is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_party()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_partySpecified Then
                				
                ' If the id_party is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.id_party)
                            
                Me.id_party.Text = formattedValue
              
            Else 
            
                ' id_party is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_party.Text = Pro_inv_hdrTable.id_party.Format(Pro_inv_hdrTable.id_party.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_tax_group()
            
        
            ' Set the id_tax_group LinkButton on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.id_tax_group is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_tax_group()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_tax_groupSpecified Then
                				
                ' If the id_tax_group is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.id_tax_group)
                            
                Me.id_tax_group.Text = formattedValue
              
            Else 
            
                ' id_tax_group is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_tax_group.Text = Pro_inv_hdrTable.id_tax_group.Format(Pro_inv_hdrTable.id_tax_group.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpo_dt()
            
        
            ' Set the po_dt Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.po_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpo_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.po_dtSpecified Then
                				
                ' If the po_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.po_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.po_dt.Text = formattedValue
              
            Else 
            
                ' po_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.po_dt.Text = Pro_inv_hdrTable.po_dt.Format(Pro_inv_hdrTable.po_dt.DefaultValue, "d")
                        		
                End If
                 
            ' If the po_dt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.po_dt.Text Is Nothing _
                OrElse Me.po_dt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.po_dt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpo_no()
            
        
            ' Set the po_no Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.po_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpo_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.po_noSpecified Then
                				
                ' If the po_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.po_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.po_no.Text = formattedValue
              
            Else 
            
                ' po_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.po_no.Text = Pro_inv_hdrTable.po_no.Format(Pro_inv_hdrTable.po_no.DefaultValue)
                        		
                End If
                 
            ' If the po_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.po_no.Text Is Nothing _
                OrElse Me.po_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.po_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpro_inv_dt()
            
        
            ' Set the pro_inv_dt Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.pro_inv_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpro_inv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pro_inv_dtSpecified Then
                				
                ' If the pro_inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.pro_inv_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pro_inv_dt.Text = formattedValue
              
            Else 
            
                ' pro_inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pro_inv_dt.Text = Pro_inv_hdrTable.pro_inv_dt.Format(Pro_inv_hdrTable.pro_inv_dt.DefaultValue, "d")
                        		
                End If
                 
            ' If the pro_inv_dt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pro_inv_dt.Text Is Nothing _
                OrElse Me.pro_inv_dt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pro_inv_dt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpro_inv_no()
            
        
            ' Set the pro_inv_no Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.pro_inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpro_inv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pro_inv_noSpecified Then
                				
                ' If the pro_inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.pro_inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pro_inv_no.Text = formattedValue
              
            Else 
            
                ' pro_inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pro_inv_no.Text = Pro_inv_hdrTable.pro_inv_no.Format(Pro_inv_hdrTable.pro_inv_no.DefaultValue)
                        		
                End If
                 
            ' If the pro_inv_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pro_inv_no.Text Is Nothing _
                OrElse Me.pro_inv_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pro_inv_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsale_ord_dt()
            
        
            ' Set the sale_ord_dt Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.sale_ord_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsale_ord_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sale_ord_dtSpecified Then
                				
                ' If the sale_ord_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.sale_ord_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sale_ord_dt.Text = formattedValue
              
            Else 
            
                ' sale_ord_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sale_ord_dt.Text = Pro_inv_hdrTable.sale_ord_dt.Format(Pro_inv_hdrTable.sale_ord_dt.DefaultValue, "d")
                        		
                End If
                 
            ' If the sale_ord_dt is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.sale_ord_dt.Text Is Nothing _
                OrElse Me.sale_ord_dt.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.sale_ord_dt.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsale_ord_no()
            
        
            ' Set the sale_ord_no Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.sale_ord_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsale_ord_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sale_ord_noSpecified Then
                				
                ' If the sale_ord_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.sale_ord_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sale_ord_no.Text = formattedValue
              
            Else 
            
                ' sale_ord_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sale_ord_no.Text = Pro_inv_hdrTable.sale_ord_no.Format(Pro_inv_hdrTable.sale_ord_no.DefaultValue)
                        		
                End If
                 
            ' If the sale_ord_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.sale_ord_no.Text Is Nothing _
                OrElse Me.sale_ord_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.sale_ord_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setship_address()
            
        
            ' Set the ship_address Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.ship_address is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setship_address()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ship_addressSpecified Then
                				
                ' If the ship_address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.ship_address)
                            
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
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ServelInvocing.Business.Pro_inv_hdrTable, ServelInvocing.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""ship_address\"", \""ship_address\"", \""Ship Address\"", false, 200," _
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
                
                Me.ship_address.Text = formattedValue
              
            Else 
            
                ' ship_address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ship_address.Text = Pro_inv_hdrTable.ship_address.Format(Pro_inv_hdrTable.ship_address.DefaultValue)
                        		
                End If
                 
            ' If the ship_address is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ship_address.Text Is Nothing _
                OrElse Me.ship_address.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ship_address.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setship_name()
            
        
            ' Set the ship_name Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.ship_name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setship_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ship_nameSpecified Then
                				
                ' If the ship_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.ship_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ship_name.Text = formattedValue
              
            Else 
            
                ' ship_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ship_name.Text = Pro_inv_hdrTable.ship_name.Format(Pro_inv_hdrTable.ship_name.DefaultValue)
                        		
                End If
                 
            ' If the ship_name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ship_name.Text Is Nothing _
                OrElse Me.ship_name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ship_name.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settin_no()
            
        
            ' Set the tin_no Literal on the webpage with value from the
            ' pro_inv_hdr database record.

            ' Me.DataSource is the pro_inv_hdr record retrieved from the database.
            ' Me.tin_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Pro_inv_hdrTable.tin_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = Pro_inv_hdrTable.tin_no.Format(Pro_inv_hdrTable.tin_no.DefaultValue)
                        		
                End If
                 
            ' If the tin_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tin_no.Text Is Nothing _
                OrElse Me.tin_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tin_no.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in Pro_inv_hdrTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "Pro_inv_hdrTableControl"), Pro_inv_hdrTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Pro_inv_hdrTableControl"), Pro_inv_hdrTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Pro_inv_hdrTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getbill_address()
            Getbill_name()
            Getid_party()
            Getid_tax_group()
            Getpo_dt()
            Getpo_no()
            Getpro_inv_dt()
            Getpro_inv_no()
            Getsale_ord_dt()
            Getsale_ord_no()
            Getship_address()
            Getship_name()
            Gettin_no()
        End Sub
        
        
        Public Overridable Sub Getbill_address()
            
        End Sub
                
        Public Overridable Sub Getbill_name()
            
        End Sub
                
        Public Overridable Sub Getid_party()
            
        End Sub
                
        Public Overridable Sub Getid_tax_group()
            
        End Sub
                
        Public Overridable Sub Getpo_dt()
            
        End Sub
                
        Public Overridable Sub Getpo_no()
            
        End Sub
                
        Public Overridable Sub Getpro_inv_dt()
            
        End Sub
                
        Public Overridable Sub Getpro_inv_no()
            
        End Sub
                
        Public Overridable Sub Getsale_ord_dt()
            
        End Sub
                
        Public Overridable Sub Getsale_ord_no()
            
        End Sub
                
        Public Overridable Sub Getship_address()
            
        End Sub
                
        Public Overridable Sub Getship_name()
            
        End Sub
                
        Public Overridable Sub Gettin_no()
            
        End Sub
                
      
        ' To customize, override this method in Pro_inv_hdrTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Pro_inv_hdrTableControlRow.
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
          Pro_inv_hdrTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Pro_inv_hdrTableControl"), Pro_inv_hdrTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Pro_inv_hdrTableControl"), Pro_inv_hdrTableControl).ResetData = True
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
        Public Overridable Sub Pro_inv_hdrRowCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../pro_inv_hdr/AddPro_inv_hdr.aspx?Pro_inv_hdr={PK}"
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
        Public Overridable Sub Pro_inv_hdrRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub Pro_inv_hdrRowEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../pro_inv_hdr/EditPro_inv_hdr.aspx?Pro_inv_hdr={PK}"
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
        Public Overridable Sub Pro_inv_hdrRowViewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../pro_inv_hdr/ShowPro_inv_hdr.aspx?Pro_inv_hdr={PK}"
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
        Public Overridable Sub id_party_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/ShowParty.aspx?Party={Pro_inv_hdrTableControlRow:FK:pro_inv_hdr_party_id_party_FK}"
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
        Public Overridable Sub id_tax_group_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../tax_groups/ShowTax_groups.aspx?Tax_groups={Pro_inv_hdrTableControlRow:FK:pro_inv_hdr_tax_groups_id_tax_group_FK}"
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
                Return CType(Me.ViewState("BasePro_inv_hdrTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePro_inv_hdrTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Pro_inv_hdrRecord
        Public Property DataSource() As Pro_inv_hdrRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Pro_inv_hdrRecord)
            
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
        
        Public ReadOnly Property bill_address() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_address"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property bill_name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property id_party() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_party"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property id_tax_group() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_tax_group"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property po_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property po_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property pro_inv_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property Pro_inv_hdrRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrRowCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrRowCopyButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrRowEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrRowEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrRowViewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrRowViewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property pro_inv_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property sale_ord_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property sale_ord_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ship_address() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_address"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ship_name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tin_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Pro_inv_hdrRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Pro_inv_hdrRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Pro_inv_hdrTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Pro_inv_hdrTableControl control on the ShowPro_inv_hdrTable page.
' Do not modify this class. Instead override any method in Pro_inv_hdrTableControl.
Public Class BasePro_inv_hdrTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
            AddHandler Me.id_partyFilter.SelectedIndexChanged, AddressOf id_partyFilter_SelectedIndexChanged
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.id_partyFilter) 				
                    initialVal = Me.GetFromSession(Me.id_partyFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.id_partyFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.id_partyFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.Pro_inv_hdrSearch) 				
                    initialVal = Me.GetFromSession(Me.Pro_inv_hdrSearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.Pro_inv_hdrSearch.Text = initialVal
                            
                    End If
                
            End If
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.pro_inv_no, OrderByItem.OrderDir.Desc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "10"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
              ' Show confirmation message on Click
              Me.Pro_inv_hdrDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.Pro_inv_hdrPagination.FirstPage.Click, AddressOf Pro_inv_hdrPagination_FirstPage_Click
              
              AddHandler Me.Pro_inv_hdrPagination.LastPage.Click, AddressOf Pro_inv_hdrPagination_LastPage_Click
              
              AddHandler Me.Pro_inv_hdrPagination.NextPage.Click, AddressOf Pro_inv_hdrPagination_NextPage_Click
              
              AddHandler Me.Pro_inv_hdrPagination.PageSizeButton.Click, AddressOf Pro_inv_hdrPagination_PageSizeButton_Click
            
              AddHandler Me.Pro_inv_hdrPagination.PreviousPage.Click, AddressOf Pro_inv_hdrPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.bill_addressLabel.Click, AddressOf bill_addressLabel_Click
            
              AddHandler Me.bill_nameLabel.Click, AddressOf bill_nameLabel_Click
            
              AddHandler Me.id_partyLabel1.Click, AddressOf id_partyLabel1_Click
            
              AddHandler Me.id_tax_groupLabel1.Click, AddressOf id_tax_groupLabel1_Click
            
              AddHandler Me.po_dtLabel.Click, AddressOf po_dtLabel_Click
            
              AddHandler Me.po_noLabel.Click, AddressOf po_noLabel_Click
            
              AddHandler Me.pro_inv_dtLabel.Click, AddressOf pro_inv_dtLabel_Click
            
              AddHandler Me.pro_inv_noLabel.Click, AddressOf pro_inv_noLabel_Click
            
              AddHandler Me.sale_ord_dtLabel.Click, AddressOf sale_ord_dtLabel_Click
            
              AddHandler Me.sale_ord_noLabel.Click, AddressOf sale_ord_noLabel_Click
            
              AddHandler Me.ship_addressLabel.Click, AddressOf ship_addressLabel_Click
            
              AddHandler Me.ship_nameLabel.Click, AddressOf ship_nameLabel_Click
            
              AddHandler Me.tin_noLabel.Click, AddressOf tin_noLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.Pro_inv_hdrCopyButton.Click, AddressOf Pro_inv_hdrCopyButton_Click
              
              AddHandler Me.Pro_inv_hdrDeleteButton.Click, AddressOf Pro_inv_hdrDeleteButton_Click
              
              AddHandler Me.Pro_inv_hdrEditButton.Click, AddressOf Pro_inv_hdrEditButton_Click
              
              AddHandler Me.Pro_inv_hdrExportCSVButton.Click, AddressOf Pro_inv_hdrExportCSVButton_Click
              
              AddHandler Me.Pro_inv_hdrExportExcelButton.Click, AddressOf Pro_inv_hdrExportExcelButton_Click
              
              AddHandler Me.Pro_inv_hdrImportButton.Click, AddressOf Pro_inv_hdrImportButton_Click
              
              AddHandler Me.Pro_inv_hdrNewButton.Click, AddressOf Pro_inv_hdrNewButton_Click
              
              AddHandler Me.Pro_inv_hdrPDFButton.Click, AddressOf Pro_inv_hdrPDFButton_Click
              
              AddHandler Me.Pro_inv_hdrRefreshButton.Click, AddressOf Pro_inv_hdrRefreshButton_Click
              
              AddHandler Me.Pro_inv_hdrResetButton.Click, AddressOf Pro_inv_hdrResetButton_Click
              
              AddHandler Me.Pro_inv_hdrWordButton.Click, AddressOf Pro_inv_hdrWordButton_Click
              
            AddHandler Me.Pro_inv_hdrSearchButton.Button.Click, AddressOf Pro_inv_hdrSearchButton_Click
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_hdrRecord)), Pro_inv_hdrRecord())
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
                
                Me.TotalRecords = Pro_inv_hdrTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Pro_inv_hdrRecord)), Pro_inv_hdrRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Pro_inv_hdrTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Pro_inv_hdrRecord)), Pro_inv_hdrRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Pro_inv_hdrTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.Pro_inv_hdrToggleAll.Checked = False
            

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
        
            Setbill_addressLabel()
            Setbill_nameLabel()
            Setid_partyFilter()
            
            Setid_partyLabel()
            Setid_partyLabel1()
            Setid_tax_groupLabel1()
            Setpo_dtLabel()
            Setpo_noLabel()
            Setpro_inv_dtLabel()
            SetPro_inv_hdrSearch()
            
            Setpro_inv_noLabel()
            Setsale_ord_dtLabel()
            Setsale_ord_noLabel()
            Setship_addressLabel()
            Setship_nameLabel()
            Settin_noLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_hdrTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Pro_inv_hdrTableControlRow = DirectCast(repItem.FindControl("Pro_inv_hdrTableControlRow"), Pro_inv_hdrTableControlRow) 
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
            
            Setbill_addressLabel()
            Setbill_nameLabel()
            Setid_partyLabel()
            Setid_partyLabel1()
            Setid_tax_groupLabel1()
            Setpo_dtLabel()
            Setpo_noLabel()
            Setpro_inv_dtLabel()
            Setpro_inv_noLabel()
            Setsale_ord_dtLabel()
            Setsale_ord_noLabel()
            Setship_addressLabel()
            Setship_nameLabel()
            Settin_noLabel()
      End Sub

      
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Pro_inv_hdrTable.id_party, Me.DataSource)
          
            Me.Page.PregetDfkaRecords(Pro_inv_hdrTable.id_tax_group, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Pro_inv_hdrExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Pro_inv_hdrExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Pro_inv_hdrPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"Pro_inv_hdrWordButton"))
                        
        
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
                    
            Me.id_partyFilter.ClearSelection()
            
            Me.Pro_inv_hdrSearch.Text = ""
            
            Me.CurrentSortOrder.Reset()
            If (Me.InSession(Me, "Order_By")) Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(true, true)
            
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.pro_inv_no, OrderByItem.OrderDir.Desc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Pro_inv_hdrTableControl pagination.
        
            Me.Pro_inv_hdrPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.Pro_inv_hdrPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_hdrPagination.LastPage.Enabled = False
            End If
          
            Me.Pro_inv_hdrPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.Pro_inv_hdrPagination.NextPage.Enabled = False
            End If
          
            Me.Pro_inv_hdrPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.Pro_inv_hdrPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.Pro_inv_hdrPagination.CurrentPage.Text = "0"
            End If
            Me.Pro_inv_hdrPagination.PageSize.Text = Me.PageSize.ToString()
            Me.Pro_inv_hdrPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.Pro_inv_hdrPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Pro_inv_hdrTableControlRow
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
            Pro_inv_hdrTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.id_partyFilter) Then
                
                wc.iAND(Pro_inv_hdrTable.id_party, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.id_partyFilter, Me.GetFromSession(Me.id_partyFilter)), False, False)
            
                
            End If
                       
            If IsValueSelected(Me.Pro_inv_hdrSearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.Pro_inv_hdrSearch.Text.StartsWith("...") Then
                    Me.Pro_inv_hdrSearch.Text = Me.Pro_inv_hdrSearch.Text.SubString(3,Me.Pro_inv_hdrSearch.Text.Length-3)
                End If
                If Me.Pro_inv_hdrSearch.Text.EndsWith("...") then
                    Me.Pro_inv_hdrSearch.Text = Me.Pro_inv_hdrSearch.Text.SubString(0,Me.Pro_inv_hdrSearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.Pro_inv_hdrSearch, Me.GetFromSession(Me.Pro_inv_hdrSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.Pro_inv_hdrSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(Pro_inv_hdrTable.id_tax_group, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Pro_inv_hdrSearch, Me.GetFromSession(Me.Pro_inv_hdrSearch)), True, False)
        
                    search.iOR(Pro_inv_hdrTable.pro_inv_no, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.Pro_inv_hdrSearch, Me.GetFromSession(Me.Pro_inv_hdrSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Pro_inv_hdrTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim id_partyFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "id_partyFilter_Ajax"), String)
            If IsValueSelected(id_partyFilterSelectedValue) Then
              
                 wc.iAND(Pro_inv_hdrTable.id_party, BaseFilter.ComparisonOperator.EqualsTo, id_partyFilterSelectedValue, false, False)
             
             End If
                      
            If IsValueSelected(searchText) and fromSearchControl = "Pro_inv_hdrSearch" Then
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
                
                        search.iOR(Pro_inv_hdrTable.id_tax_group, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Pro_inv_hdrTable.id_tax_group, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(Pro_inv_hdrTable.pro_inv_no, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(Pro_inv_hdrTable.pro_inv_no, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(Pro_inv_hdrTable.id_tax_group, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(Pro_inv_hdrTable.pro_inv_no, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_Pro_inv_hdrSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"Pro_inv_hdrSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.Pro_inv_hdrRecord = Pro_inv_hdrTable.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As Pro_inv_hdrRecord = Nothing
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
                
                    resultItem = rec.Format(Pro_inv_hdrTable.id_tax_group)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(Pro_inv_hdrTable.pro_inv_no)
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
        
            If Me.Pro_inv_hdrPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.Pro_inv_hdrPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_hdrTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Pro_inv_hdrTableControlRow = DirectCast(repItem.FindControl("Pro_inv_hdrTableControlRow"), Pro_inv_hdrTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Pro_inv_hdrRecord = New Pro_inv_hdrRecord()
        
                        If recControl.bill_address.Text <> "" Then
                            rec.Parse(recControl.bill_address.Text, Pro_inv_hdrTable.bill_address)
                        End If
                        If recControl.bill_name.Text <> "" Then
                            rec.Parse(recControl.bill_name.Text, Pro_inv_hdrTable.bill_name)
                        End If
                        If recControl.id_party.Text <> "" Then
                            rec.Parse(recControl.id_party.Text, Pro_inv_hdrTable.id_party)
                        End If
                        If recControl.id_tax_group.Text <> "" Then
                            rec.Parse(recControl.id_tax_group.Text, Pro_inv_hdrTable.id_tax_group)
                        End If
                        If recControl.po_dt.Text <> "" Then
                            rec.Parse(recControl.po_dt.Text, Pro_inv_hdrTable.po_dt)
                        End If
                        If recControl.po_no.Text <> "" Then
                            rec.Parse(recControl.po_no.Text, Pro_inv_hdrTable.po_no)
                        End If
                        If recControl.pro_inv_dt.Text <> "" Then
                            rec.Parse(recControl.pro_inv_dt.Text, Pro_inv_hdrTable.pro_inv_dt)
                        End If
                        If recControl.pro_inv_no.Text <> "" Then
                            rec.Parse(recControl.pro_inv_no.Text, Pro_inv_hdrTable.pro_inv_no)
                        End If
                        If recControl.sale_ord_dt.Text <> "" Then
                            rec.Parse(recControl.sale_ord_dt.Text, Pro_inv_hdrTable.sale_ord_dt)
                        End If
                        If recControl.sale_ord_no.Text <> "" Then
                            rec.Parse(recControl.sale_ord_no.Text, Pro_inv_hdrTable.sale_ord_no)
                        End If
                        If recControl.ship_address.Text <> "" Then
                            rec.Parse(recControl.ship_address.Text, Pro_inv_hdrTable.ship_address)
                        End If
                        If recControl.ship_name.Text <> "" Then
                            rec.Parse(recControl.ship_name.Text, Pro_inv_hdrTable.ship_name)
                        End If
                        If recControl.tin_no.Text <> "" Then
                            rec.Parse(recControl.tin_no.Text, Pro_inv_hdrTable.tin_no)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Pro_inv_hdrRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Pro_inv_hdrRecord)), Pro_inv_hdrRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Pro_inv_hdrTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Pro_inv_hdrTableControlRow) As Boolean
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
        
        Public Overridable Sub Setbill_addressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setbill_nameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_partyLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_partyLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setid_tax_groupLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setpo_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpo_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpro_inv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpro_inv_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsale_ord_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsale_ord_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setship_addressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setship_nameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settin_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_partyFilter()
            
            If (Me.InSession(Me.id_partyFilter))
                Me.Populateid_partyFilter(GetSelectedValue(Me.id_partyFilter, Me.GetFromSession(Me.id_partyFilter)), 500)
            Else
                
                Me.Populateid_partyFilter(GetSelectedValue(Me.id_partyFilter,  Nothing), 500)					
                
            End If
                    
        End Sub	
            
        Public Overridable Sub SetPro_inv_hdrSearch()
            
        End Sub	
            
        ' Get the filters' data for id_partyFilter
        Protected Overridable Sub Populateid_partyFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
            Me.id_partyFilter.Items.Clear()
            
            
            'Setup the WHERE clause.
            Dim wc As WhereClause = Me.CreateWhereClause_id_partyFilter()
            
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(PartyTable.name, OrderByItem.OrderDir.Asc)				
            
            ' Add the All item.
            Me.id_partyFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ServelInvocing"), "--ANY--"))
                            	

            Dim noValueFormat As String = Page.GetResourceValue("Txt:Other", "ServelInvocing")
            

            Dim itemValues() As PartyRecord = Nothing
            If wc.RunQuery
                Dim counter As Integer = 0
                Dim pageNum As Integer = 0
                Do
                    itemValues = PartyTable.GetRecords(wc, orderBy, pageNum, 500)
                    For each itemValue As PartyRecord In itemValues
                        ' Create the item and add to the list.
                        Dim cvalue As String = Nothing
                        Dim fvalue As String = Nothing
                        If itemValue.id0Specified Then
                            cvalue = itemValue.id0.ToString()
                                
                            fvalue = itemValue.Format(PartyTable.name)
                                    
                            If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = cvalue
                            Dim newItem As New ListItem(fvalue, cvalue)
                            If counter < maxItems AndAlso Not Me.id_partyFilter.Items.Contains(newItem) Then Me.id_partyFilter.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If			
            
            

                
            ' Set the selected value.
            SetSelectedValue(Me.id_partyFilter, selectedValue)

                
        End Sub
            
        Public Overridable Function CreateWhereClause_id_partyFilter() As WhereClause
        
            ' Create a where clause for the filter id_partyFilter.
            ' This function is called by the Populate method to load the items 
            ' in the id_partyFilterDropDownList
                   
            Dim wc As WhereClause = new WhereClause()
            ' Add additional where clauses to restrict the items shown in the control.
            ' Examples:
            ' wc.iAND(PartyTable.name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(PartyTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
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
        
            Me.SaveToSession(Me.id_partyFilter, Me.id_partyFilter.SelectedValue)
                  
            Me.SaveToSession(Me.Pro_inv_hdrSearch, Me.Pro_inv_hdrSearch.Text)
                  
            
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
          
      Me.SaveToSession("id_partyFilter_Ajax", Me.id_partyFilter.SelectedValue)
              
      Me.SaveToSession("Pro_inv_hdrSearch_Ajax", Me.Pro_inv_hdrSearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.id_partyFilter)
            Me.RemoveFromSession(Me.Pro_inv_hdrSearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("Pro_inv_hdrTableControl_OrderBy"), String)
            
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
                Me.ViewState("Pro_inv_hdrTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_hdrPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub Pro_inv_hdrPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub Pro_inv_hdrPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub Pro_inv_hdrPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.Pro_inv_hdrPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.Pro_inv_hdrPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_hdrPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub bill_addressLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by bill_address when clicked.
              
            ' Get previous sorting state for bill_address.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.bill_address)
            If sd Is Nothing Then
                ' First time sort, so add sort order for bill_address.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.bill_address, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by bill_address, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub bill_nameLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by bill_name when clicked.
              
            ' Get previous sorting state for bill_name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.bill_name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for bill_name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.bill_name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by bill_name, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_partyLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_party when clicked.
              
            ' Get previous sorting state for id_party.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.id_party)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_party.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.id_party, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_party, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub id_tax_groupLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by id_tax_group when clicked.
              
            ' Get previous sorting state for id_tax_group.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.id_tax_group)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_tax_group.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.id_tax_group, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_tax_group, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub po_dtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by po_dt when clicked.
              
            ' Get previous sorting state for po_dt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.po_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for po_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.po_dt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by po_dt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub po_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by po_no when clicked.
              
            ' Get previous sorting state for po_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.po_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for po_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.po_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by po_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub pro_inv_dtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by pro_inv_dt when clicked.
              
            ' Get previous sorting state for pro_inv_dt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.pro_inv_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for pro_inv_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.pro_inv_dt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by pro_inv_dt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub pro_inv_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by pro_inv_no when clicked.
              
            ' Get previous sorting state for pro_inv_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.pro_inv_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for pro_inv_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.pro_inv_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by pro_inv_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub sale_ord_dtLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by sale_ord_dt when clicked.
              
            ' Get previous sorting state for sale_ord_dt.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.sale_ord_dt)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sale_ord_dt.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.sale_ord_dt, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sale_ord_dt, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub sale_ord_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by sale_ord_no when clicked.
              
            ' Get previous sorting state for sale_ord_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.sale_ord_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for sale_ord_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.sale_ord_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by sale_ord_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub ship_addressLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by ship_address when clicked.
              
            ' Get previous sorting state for ship_address.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.ship_address)
            If sd Is Nothing Then
                ' First time sort, so add sort order for ship_address.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.ship_address, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by ship_address, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub ship_nameLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by ship_name when clicked.
              
            ' Get previous sorting state for ship_name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.ship_name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for ship_name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.ship_name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by ship_name, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tin_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tin_no when clicked.
              
            ' Get previous sorting state for tin_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(Pro_inv_hdrTable.tin_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tin_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.tin_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tin_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_hdrCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../pro_inv_hdr/AddPro_inv_hdr.aspx?Pro_inv_hdr={PK}"
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
        Public Overridable Sub Pro_inv_hdrDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub Pro_inv_hdrEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../pro_inv_hdr/EditPro_inv_hdr.aspx?Pro_inv_hdr={PK}"
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
        Public Overridable Sub Pro_inv_hdrExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       Pro_inv_hdrTable.pro_inv_no, _ 
             Pro_inv_hdrTable.pro_inv_dt, _ 
             Pro_inv_hdrTable.sale_ord_no, _ 
             Pro_inv_hdrTable.sale_ord_dt, _ 
             Pro_inv_hdrTable.id_party, _ 
             Pro_inv_hdrTable.bill_name, _ 
             Pro_inv_hdrTable.bill_address, _ 
             Pro_inv_hdrTable.ship_name, _ 
             Pro_inv_hdrTable.ship_address, _ 
             Pro_inv_hdrTable.tin_no, _ 
             Pro_inv_hdrTable.po_no, _ 
             Pro_inv_hdrTable.po_dt, _ 
             Pro_inv_hdrTable.id_tax_group, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(Pro_inv_hdrTable.Instance, wc, orderBy, columns)
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
        Public Overridable Sub Pro_inv_hdrExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(Pro_inv_hdrTable.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.pro_inv_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.pro_inv_dt, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.sale_ord_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.sale_ord_dt, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.id_party, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.bill_name, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.bill_address, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.ship_name, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.ship_address, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.tin_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.po_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.po_dt, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(Pro_inv_hdrTable.id_tax_group, "Default"))

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
        Public Overridable Sub Pro_inv_hdrImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/SelectFileToImport.aspx?TableName=Pro_inv_hdr"
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
        Public Overridable Sub Pro_inv_hdrNewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../pro_inv_hdr/AddPro_inv_hdr.aspx"
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
        Public Overridable Sub Pro_inv_hdrPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowPro_inv_hdrTable.Pro_inv_hdrPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "pro_inv_hdr"
                ' If ShowPro_inv_hdrTable.Pro_inv_hdrPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(Pro_inv_hdrTable.pro_inv_no.Name, ReportEnum.Align.Left, "${pro_inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.pro_inv_dt.Name, ReportEnum.Align.Left, "${pro_inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.sale_ord_no.Name, ReportEnum.Align.Left, "${sale_ord_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.sale_ord_dt.Name, ReportEnum.Align.Left, "${sale_ord_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.id_party.Name, ReportEnum.Align.Left, "${id_party}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.bill_name.Name, ReportEnum.Align.Left, "${bill_name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.bill_address.Name, ReportEnum.Align.Left, "${bill_address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.ship_name.Name, ReportEnum.Align.Left, "${ship_name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.ship_address.Name, ReportEnum.Align.Left, "${ship_address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.tin_no.Name, ReportEnum.Align.Left, "${tin_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.po_no.Name, ReportEnum.Align.Left, "${po_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.po_dt.Name, ReportEnum.Align.Left, "${po_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.id_tax_group.Name, ReportEnum.Align.Left, "${id_tax_group}", ReportEnum.Align.Left, 20)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = Pro_inv_hdrTable.GetRecordCount(whereClause)
                Dim columns As ColumnList = Pro_inv_hdrTable.GetColumnList()
                Dim records As Pro_inv_hdrRecord() = Nothing
            
                Do 
                    
                    records = Pro_inv_hdrTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As Pro_inv_hdrRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${pro_inv_no}", record.Format(Pro_inv_hdrTable.pro_inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${pro_inv_dt}", record.Format(Pro_inv_hdrTable.pro_inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${sale_ord_no}", record.Format(Pro_inv_hdrTable.sale_ord_no), ReportEnum.Align.Left, 100)
                             report.AddData("${sale_ord_dt}", record.Format(Pro_inv_hdrTable.sale_ord_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${id_party}", record.Format(Pro_inv_hdrTable.id_party), ReportEnum.Align.Left)
                             report.AddData("${bill_name}", record.Format(Pro_inv_hdrTable.bill_name), ReportEnum.Align.Left, 100)
                             report.AddData("${bill_address}", record.Format(Pro_inv_hdrTable.bill_address), ReportEnum.Align.Left, 100)
                             report.AddData("${ship_name}", record.Format(Pro_inv_hdrTable.ship_name), ReportEnum.Align.Left, 100)
                             report.AddData("${ship_address}", record.Format(Pro_inv_hdrTable.ship_address), ReportEnum.Align.Left, 100)
                             report.AddData("${tin_no}", record.Format(Pro_inv_hdrTable.tin_no), ReportEnum.Align.Left, 100)
                             report.AddData("${po_no}", record.Format(Pro_inv_hdrTable.po_no), ReportEnum.Align.Left, 100)
                             report.AddData("${po_dt}", record.Format(Pro_inv_hdrTable.po_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${id_tax_group}", record.Format(Pro_inv_hdrTable.id_tax_group), ReportEnum.Align.Left)

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
        Public Overridable Sub Pro_inv_hdrRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim Pro_inv_hdrTableControlObj as Pro_inv_hdrTableControl = DirectCast(Me.Page.FindControlRecursively("Pro_inv_hdrTableControl"), Pro_inv_hdrTableControl)
            Pro_inv_hdrTableControlObj.ResetData = True
                        
            Pro_inv_hdrTableControlObj.RemoveFromSession(Pro_inv_hdrTableControlObj, "DeletedRecordIds")
            Pro_inv_hdrTableControlObj.DeletedRecordIds = Nothing
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub Pro_inv_hdrResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.id_partyFilter.ClearSelection()
              Me.Pro_inv_hdrSearch.Text = ""
              Me.CurrentSortOrder.Reset()
              If Me.InSession(Me, "Order_By") Then
                  Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
              Else
                  Me.CurrentSortOrder = New OrderBy(True, True)
              
                Me.CurrentSortOrder.Add(Pro_inv_hdrTable.pro_inv_no, OrderByItem.OrderDir.Desc)
                
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
        Public Overridable Sub Pro_inv_hdrWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowPro_inv_hdrTable.Pro_inv_hdrWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "pro_inv_hdr"
                ' If ShowPro_inv_hdrTable.Pro_inv_hdrWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(Pro_inv_hdrTable.pro_inv_no.Name, ReportEnum.Align.Left, "${pro_inv_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.pro_inv_dt.Name, ReportEnum.Align.Left, "${pro_inv_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.sale_ord_no.Name, ReportEnum.Align.Left, "${sale_ord_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.sale_ord_dt.Name, ReportEnum.Align.Left, "${sale_ord_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.id_party.Name, ReportEnum.Align.Left, "${id_party}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.bill_name.Name, ReportEnum.Align.Left, "${bill_name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.bill_address.Name, ReportEnum.Align.Left, "${bill_address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.ship_name.Name, ReportEnum.Align.Left, "${ship_name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.ship_address.Name, ReportEnum.Align.Left, "${ship_address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(Pro_inv_hdrTable.tin_no.Name, ReportEnum.Align.Left, "${tin_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.po_no.Name, ReportEnum.Align.Left, "${po_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.po_dt.Name, ReportEnum.Align.Left, "${po_dt}", ReportEnum.Align.Left, 20)
                 report.AddColumn(Pro_inv_hdrTable.id_tax_group.Name, ReportEnum.Align.Left, "${id_tax_group}", ReportEnum.Align.Left, 20)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = Pro_inv_hdrTable.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = Pro_inv_hdrTable.GetColumnList()
                Dim records As Pro_inv_hdrRecord() = Nothing
                Do
                    records = Pro_inv_hdrTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As Pro_inv_hdrRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${pro_inv_no}", record.Format(Pro_inv_hdrTable.pro_inv_no), ReportEnum.Align.Left, 100)
                             report.AddData("${pro_inv_dt}", record.Format(Pro_inv_hdrTable.pro_inv_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${sale_ord_no}", record.Format(Pro_inv_hdrTable.sale_ord_no), ReportEnum.Align.Left, 100)
                             report.AddData("${sale_ord_dt}", record.Format(Pro_inv_hdrTable.sale_ord_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${id_party}", record.Format(Pro_inv_hdrTable.id_party), ReportEnum.Align.Left)
                             report.AddData("${bill_name}", record.Format(Pro_inv_hdrTable.bill_name), ReportEnum.Align.Left, 100)
                             report.AddData("${bill_address}", record.Format(Pro_inv_hdrTable.bill_address), ReportEnum.Align.Left, 100)
                             report.AddData("${ship_name}", record.Format(Pro_inv_hdrTable.ship_name), ReportEnum.Align.Left, 100)
                             report.AddData("${ship_address}", record.Format(Pro_inv_hdrTable.ship_address), ReportEnum.Align.Left, 100)
                             report.AddData("${tin_no}", record.Format(Pro_inv_hdrTable.tin_no), ReportEnum.Align.Left, 100)
                             report.AddData("${po_no}", record.Format(Pro_inv_hdrTable.po_no), ReportEnum.Align.Left, 100)
                             report.AddData("${po_dt}", record.Format(Pro_inv_hdrTable.po_dt), ReportEnum.Align.Left, 100)
                             report.AddData("${id_tax_group}", record.Format(Pro_inv_hdrTable.id_tax_group), ReportEnum.Align.Left)

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
        Public Overridable Sub Pro_inv_hdrSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub id_partyFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
        
        Private _DataSource() As Pro_inv_hdrRecord = Nothing
        Public Property DataSource() As Pro_inv_hdrRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Pro_inv_hdrRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property bill_addressLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_addressLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property bill_nameLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_nameLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_partyFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_partyFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property id_partyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_partyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_partyLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_partyLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_tax_groupLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_tax_groupLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property po_dtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_dtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property po_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property pro_inv_dtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_dtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrCopyButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrNewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrNewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property Pro_inv_hdrPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrSearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrSearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property Pro_inv_hdrTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property Pro_inv_hdrWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Pro_inv_hdrWordButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property pro_inv_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pro_inv_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property sale_ord_dtLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_dtLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property sale_ord_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property ship_addressLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_addressLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property ship_nameLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_nameLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tin_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_noLabel"), System.Web.UI.WebControls.LinkButton)
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
                Dim recCtl As Pro_inv_hdrTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Pro_inv_hdrRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As Pro_inv_hdrTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_hdrRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As Pro_inv_hdrTableControlRow
            Dim selectedList() As Pro_inv_hdrTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Pro_inv_hdrTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As Pro_inv_hdrTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.Pro_inv_hdrRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(Pro_inv_hdrTableControlRow)), Pro_inv_hdrTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Pro_inv_hdrTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Pro_inv_hdrTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.Pro_inv_hdrRecordRowSelection.Checked = False
                
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

        Public Function GetRecordControls() As Pro_inv_hdrTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Pro_inv_hdrTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Pro_inv_hdrTableControlRow = DirectCast(repItem.FindControl("Pro_inv_hdrTableControlRow"), Pro_inv_hdrTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Pro_inv_hdrTableControlRow)), Pro_inv_hdrTableControlRow())
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

  