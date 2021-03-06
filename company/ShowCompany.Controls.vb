﻿
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowCompany.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowCompany

#Region "Section 1: Place your customizations here."

    
Public Class CompanyRecordControl
        Inherits BaseCompanyRecordControl
        ' The BaseCompanyRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the CompanyRecordControl control on the ShowCompany page.
' Do not modify this class. Instead override any method in CompanyRecordControl.
Public Class BaseCompanyRecordControl
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in CompanyRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
        
        End Sub

        '  To customize, override this method in CompanyRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
              ' Setup the pagination events.	  
         
              ' Register the event handlers.
          
              AddHandler Me.CompanyDialogEditButton.Click, AddressOf CompanyDialogEditButton_Click
              
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource company record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = CompanyTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "CompanyRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New CompanyRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As CompanyRecord = CompanyTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = CompanyTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in CompanyRecordControl.
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
        
            Setaddress()
            SetaddressLabel()
            Setcer_no()
            Setcer_noLabel()
            Setcity()
            SetcityLabel()
            Setdivision()
            SetdivisionLabel()
            Setecc_no()
            Setecc_noLabel()
            Setemail()
            SetemailLabel()
            Setfin_year_end()
            Setfin_year_endLabel()
            Setfin_year_start()
            Setfin_year_startLabel()
            Setgst_no()
            Setgst_noLabel()
            Setinv_pfx()
            Setinv_pfxLabel()
            Setinv_sfx()
            Setinv_sfxLabel()
            Setname()
            SetnameLabel()
            Setnext_inv_no()
            Setnext_inv_noLabel()
            Setpad_inv_no()
            Setpad_inv_noLabel()
            Setpan_no()
            Setpan_noLabel()
            Setphone()
            SetphoneLabel()
            Setpincode()
            SetpincodeLabel()
            Setrange()
            SetrangeLabel()
            Setsrv_tax_no()
            Setsrv_tax_noLabel()
            Setstate()
            SetstateLabel()
            Settan_no()
            Settan_noLabel()
            Settin_no()
            Settin_noLabel()
      
      
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
        
        
        Public Overridable Sub Setaddress()
            
        
            ' Set the address Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.address is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.address)
                            
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
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ServelInvocing.Business.CompanyTable, ServelInvocing.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""address\"", \""address\"", \""Address\"", false, 200," _
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
                
                Me.address.Text = formattedValue
              
            Else 
            
                ' address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.address.Text = CompanyTable.address.Format(CompanyTable.address.DefaultValue)
                        		
                End If
                 
            ' If the address is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.address.Text Is Nothing _
                OrElse Me.address.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.address.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcer_no()
            
        
            ' Set the cer_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.cer_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcer_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cer_noSpecified Then
                				
                ' If the cer_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.cer_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cer_no.Text = formattedValue
              
            Else 
            
                ' cer_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cer_no.Text = CompanyTable.cer_no.Format(CompanyTable.cer_no.DefaultValue)
                        		
                End If
                 
            ' If the cer_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cer_no.Text Is Nothing _
                OrElse Me.cer_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cer_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcity()
            
        
            ' Set the city Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.city is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcity()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.citySpecified Then
                				
                ' If the city is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.city)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.city.Text = formattedValue
              
            Else 
            
                ' city is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.city.Text = CompanyTable.city.Format(CompanyTable.city.DefaultValue)
                        		
                End If
                 
            ' If the city is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.city.Text Is Nothing _
                OrElse Me.city.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.city.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setdivision()
            
        
            ' Set the division Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.division is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setdivision()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.divisionSpecified Then
                				
                ' If the division is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.division)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.division.Text = formattedValue
              
            Else 
            
                ' division is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.division.Text = CompanyTable.division.Format(CompanyTable.division.DefaultValue)
                        		
                End If
                 
            ' If the division is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.division.Text Is Nothing _
                OrElse Me.division.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.division.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setecc_no()
            
        
            ' Set the ecc_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.ecc_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.ecc_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ecc_no.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no.Text = CompanyTable.ecc_no.Format(CompanyTable.ecc_no.DefaultValue)
                        		
                End If
                 
            ' If the ecc_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ecc_no.Text Is Nothing _
                OrElse Me.ecc_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ecc_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setemail()
            
        
            ' Set the email Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.email is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.email)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.email.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email.Text = CompanyTable.email.Format(CompanyTable.email.DefaultValue)
                        		
                End If
                 
            ' If the email is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.email.Text Is Nothing _
                OrElse Me.email.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.email.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setfin_year_end()
            
        
            ' Set the fin_year_end Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.fin_year_end is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setfin_year_end()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.fin_year_endSpecified Then
                				
                ' If the fin_year_end is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.fin_year_end, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.fin_year_end.Text = formattedValue
              
            Else 
            
                ' fin_year_end is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.fin_year_end.Text = CompanyTable.fin_year_end.Format(CompanyTable.fin_year_end.DefaultValue, "d")
                        		
                End If
                 
            ' If the fin_year_end is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.fin_year_end.Text Is Nothing _
                OrElse Me.fin_year_end.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.fin_year_end.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setfin_year_start()
            
        
            ' Set the fin_year_start Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.fin_year_start is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setfin_year_start()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.fin_year_startSpecified Then
                				
                ' If the fin_year_start is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.fin_year_start, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.fin_year_start.Text = formattedValue
              
            Else 
            
                ' fin_year_start is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.fin_year_start.Text = CompanyTable.fin_year_start.Format(CompanyTable.fin_year_start.DefaultValue, "d")
                        		
                End If
                 
            ' If the fin_year_start is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.fin_year_start.Text Is Nothing _
                OrElse Me.fin_year_start.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.fin_year_start.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_no()
            
        
            ' Set the gst_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.gst_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_noSpecified Then
                				
                ' If the gst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.gst_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.gst_no.Text = formattedValue
              
            Else 
            
                ' gst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_no.Text = CompanyTable.gst_no.Format(CompanyTable.gst_no.DefaultValue)
                        		
                End If
                 
            ' If the gst_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_no.Text Is Nothing _
                OrElse Me.gst_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setinv_pfx()
            
        
            ' Set the inv_pfx Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.inv_pfx is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_pfx()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_pfxSpecified Then
                				
                ' If the inv_pfx is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.inv_pfx)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_pfx.Text = formattedValue
              
            Else 
            
                ' inv_pfx is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_pfx.Text = CompanyTable.inv_pfx.Format(CompanyTable.inv_pfx.DefaultValue)
                        		
                End If
                 
            ' If the inv_pfx is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.inv_pfx.Text Is Nothing _
                OrElse Me.inv_pfx.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.inv_pfx.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setinv_sfx()
            
        
            ' Set the inv_sfx Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.inv_sfx is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_sfx()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_sfxSpecified Then
                				
                ' If the inv_sfx is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.inv_sfx)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_sfx.Text = formattedValue
              
            Else 
            
                ' inv_sfx is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_sfx.Text = CompanyTable.inv_sfx.Format(CompanyTable.inv_sfx.DefaultValue)
                        		
                End If
                 
            ' If the inv_sfx is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.inv_sfx.Text Is Nothing _
                OrElse Me.inv_sfx.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.inv_sfx.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setname()
            
        
            ' Set the name Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.name.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name.Text = CompanyTable.name.Format(CompanyTable.name.DefaultValue)
                        		
                End If
                 
            ' If the name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.name.Text Is Nothing _
                OrElse Me.name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.name.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setnext_inv_no()
            
        
            ' Set the next_inv_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.next_inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setnext_inv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.next_inv_noSpecified Then
                				
                ' If the next_inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.next_inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.next_inv_no.Text = formattedValue
              
            Else 
            
                ' next_inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.next_inv_no.Text = CompanyTable.next_inv_no.Format(CompanyTable.next_inv_no.DefaultValue)
                        		
                End If
                 
            ' If the next_inv_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.next_inv_no.Text Is Nothing _
                OrElse Me.next_inv_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.next_inv_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpad_inv_no()
            
        
            ' Set the pad_inv_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pad_inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpad_inv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pad_inv_noSpecified Then
                				
                ' If the pad_inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pad_inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pad_inv_no.Text = formattedValue
              
            Else 
            
                ' pad_inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pad_inv_no.Text = CompanyTable.pad_inv_no.Format(CompanyTable.pad_inv_no.DefaultValue)
                        		
                End If
                 
            ' If the pad_inv_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pad_inv_no.Text Is Nothing _
                OrElse Me.pad_inv_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pad_inv_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpan_no()
            
        
            ' Set the pan_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pan_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pan_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pan_no.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no.Text = CompanyTable.pan_no.Format(CompanyTable.pan_no.DefaultValue)
                        		
                End If
                 
            ' If the pan_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pan_no.Text Is Nothing _
                OrElse Me.pan_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pan_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setphone()
            
        
            ' Set the phone Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.phone is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.phone)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.phone.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone.Text = CompanyTable.phone.Format(CompanyTable.phone.DefaultValue)
                        		
                End If
                 
            ' If the phone is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.phone.Text Is Nothing _
                OrElse Me.phone.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.phone.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpincode()
            
        
            ' Set the pincode Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pincode is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpincode()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pincodeSpecified Then
                				
                ' If the pincode is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pincode)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pincode.Text = formattedValue
              
            Else 
            
                ' pincode is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pincode.Text = CompanyTable.pincode.Format(CompanyTable.pincode.DefaultValue)
                        		
                End If
                 
            ' If the pincode is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pincode.Text Is Nothing _
                OrElse Me.pincode.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pincode.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setrange()
            
        
            ' Set the range Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.range is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setrange()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.rangeSpecified Then
                				
                ' If the range is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.range)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.range.Text = formattedValue
              
            Else 
            
                ' range is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.range.Text = CompanyTable.range.Format(CompanyTable.range.DefaultValue)
                        		
                End If
                 
            ' If the range is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.range.Text Is Nothing _
                OrElse Me.range.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.range.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsrv_tax_no()
            
        
            ' Set the srv_tax_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.srv_tax_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsrv_tax_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.srv_tax_noSpecified Then
                				
                ' If the srv_tax_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.srv_tax_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.srv_tax_no.Text = formattedValue
              
            Else 
            
                ' srv_tax_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.srv_tax_no.Text = CompanyTable.srv_tax_no.Format(CompanyTable.srv_tax_no.DefaultValue)
                        		
                End If
                 
            ' If the srv_tax_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.srv_tax_no.Text Is Nothing _
                OrElse Me.srv_tax_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.srv_tax_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setstate()
            
        
            ' Set the state Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.state is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.stateSpecified Then
                				
                ' If the state is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.state)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state.Text = formattedValue
              
            Else 
            
                ' state is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state.Text = CompanyTable.state.Format(CompanyTable.state.DefaultValue)
                        		
                End If
                 
            ' If the state is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state.Text Is Nothing _
                OrElse Me.state.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settan_no()
            
        
            ' Set the tan_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.tan_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settan_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tan_noSpecified Then
                				
                ' If the tan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.tan_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tan_no.Text = formattedValue
              
            Else 
            
                ' tan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tan_no.Text = CompanyTable.tan_no.Format(CompanyTable.tan_no.DefaultValue)
                        		
                End If
                 
            ' If the tan_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tan_no.Text Is Nothing _
                OrElse Me.tan_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tan_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settin_no()
            
        
            ' Set the tin_no Literal on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.tin_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.tin_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = CompanyTable.tin_no.Format(CompanyTable.tin_no.DefaultValue)
                        		
                End If
                 
            ' If the tin_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tin_no.Text Is Nothing _
                OrElse Me.tin_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tin_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub SetaddressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setcer_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcityLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetdivisionLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setecc_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setfin_year_endLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setfin_year_startLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_pfxLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_sfxLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setnext_inv_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpad_inv_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpan_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetpincodeLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetrangeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setsrv_tax_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetstateLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settan_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settin_noLabel()
            
                    
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

      
        
        ' To customize, override this method in CompanyRecordControl.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "CompanyRecordControlPanel"), System.Web.UI.WebControls.Panel)

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

        ' To customize, override this method in CompanyRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getaddress()
            Getcer_no()
            Getcity()
            Getdivision()
            Getecc_no()
            Getemail()
            Getfin_year_end()
            Getfin_year_start()
            Getgst_no()
            Getinv_pfx()
            Getinv_sfx()
            Getname()
            Getnext_inv_no()
            Getpad_inv_no()
            Getpan_no()
            Getphone()
            Getpincode()
            Getrange()
            Getsrv_tax_no()
            Getstate()
            Gettan_no()
            Gettin_no()
        End Sub
        
        
        Public Overridable Sub Getaddress()
            
        End Sub
                
        Public Overridable Sub Getcer_no()
            
        End Sub
                
        Public Overridable Sub Getcity()
            
        End Sub
                
        Public Overridable Sub Getdivision()
            
        End Sub
                
        Public Overridable Sub Getecc_no()
            
        End Sub
                
        Public Overridable Sub Getemail()
            
        End Sub
                
        Public Overridable Sub Getfin_year_end()
            
        End Sub
                
        Public Overridable Sub Getfin_year_start()
            
        End Sub
                
        Public Overridable Sub Getgst_no()
            
        End Sub
                
        Public Overridable Sub Getinv_pfx()
            
        End Sub
                
        Public Overridable Sub Getinv_sfx()
            
        End Sub
                
        Public Overridable Sub Getname()
            
        End Sub
                
        Public Overridable Sub Getnext_inv_no()
            
        End Sub
                
        Public Overridable Sub Getpad_inv_no()
            
        End Sub
                
        Public Overridable Sub Getpan_no()
            
        End Sub
                
        Public Overridable Sub Getphone()
            
        End Sub
                
        Public Overridable Sub Getpincode()
            
        End Sub
                
        Public Overridable Sub Getrange()
            
        End Sub
                
        Public Overridable Sub Getsrv_tax_no()
            
        End Sub
                
        Public Overridable Sub Getstate()
            
        End Sub
                
        Public Overridable Sub Gettan_no()
            
        End Sub
                
        Public Overridable Sub Gettin_no()
            
        End Sub
                
      
        ' To customize, override this method in CompanyRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Dim wc As WhereClause
            CompanyTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
            Dim recId As String = Me.Page.Request.QueryString.Item("Company")
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ServelInvocing").Replace("{URL}", "Company"))
            End If
            HttpContext.Current.Session("QueryString in ShowCompany") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(CompanyTable.id0, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(CompanyTable.id0).ToString())
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(CompanyTable.id0, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            CompanyTable.Instance.InnerFilter = Nothing
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
        

        ' To customize, override this method in CompanyRecordControl.
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
          CompanyTable.DeleteRecord(pkValue)
          
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
            
        ' event handler for ImageButton
        Public Overridable Sub CompanyDialogEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../company/EditCompany.aspx?Company={PK}"
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
                Return CType(Me.ViewState("BaseCompanyRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseCompanyRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As CompanyRecord
        Public Property DataSource() As CompanyRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As CompanyRecord)
            
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
        
        Public ReadOnly Property address() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property addressLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "addressLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property cer_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property cer_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property city() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "city"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property cityLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cityLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CompanyDialogEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyDialogEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property CompanyTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property division() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "division"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property divisionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "divisionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ecc_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ecc_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property email() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property emailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property fin_year_end() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_end"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property fin_year_endLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_endLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property fin_year_start() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_start"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property fin_year_startLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_startLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property gst_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_pfx() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_pfx"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_pfxLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_pfxLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_sfx() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_sfx"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_sfxLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_sfxLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property next_inv_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "next_inv_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property next_inv_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "next_inv_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pad_inv_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pad_inv_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property pad_inv_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pad_inv_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pan_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property pan_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property phone() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property phoneLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phoneLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pincode() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pincode"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property pincodeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pincodeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property range() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "range"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property rangeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rangeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property srv_tax_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "srv_tax_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property srv_tax_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "srv_tax_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property state() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property stateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "stateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tan_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tan_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tan_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tan_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tin_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tin_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As CompanyRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As CompanyRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return CompanyTable.GetRecord(Me.RecordUniqueId, True)
                
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

  