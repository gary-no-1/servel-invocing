
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditCompany.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.EditCompany

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
    
    
' Base class for the CompanyRecordControl control on the EditCompany page.
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
          
              AddHandler Me.address1.TextChanged, AddressOf address1_TextChanged
            
              AddHandler Me.cer_no1.TextChanged, AddressOf cer_no1_TextChanged
            
              AddHandler Me.city.TextChanged, AddressOf city_TextChanged
            
              AddHandler Me.division1.TextChanged, AddressOf division1_TextChanged
            
              AddHandler Me.ecc_no1.TextChanged, AddressOf ecc_no1_TextChanged
            
              AddHandler Me.email.TextChanged, AddressOf email_TextChanged
            
              AddHandler Me.email_bcc.TextChanged, AddressOf email_bcc_TextChanged
            
              AddHandler Me.email_from.TextChanged, AddressOf email_from_TextChanged
            
              AddHandler Me.fin_year_end1.TextChanged, AddressOf fin_year_end1_TextChanged
            
              AddHandler Me.fin_year_start1.TextChanged, AddressOf fin_year_start1_TextChanged
            
              AddHandler Me.inv_declaration.TextChanged, AddressOf inv_declaration_TextChanged
            
              AddHandler Me.inv_email_body.TextChanged, AddressOf inv_email_body_TextChanged
            
              AddHandler Me.inv_pfx1.TextChanged, AddressOf inv_pfx1_TextChanged
            
              AddHandler Me.inv_sfx1.TextChanged, AddressOf inv_sfx1_TextChanged
            
              AddHandler Me.name.TextChanged, AddressOf name_TextChanged
            
              AddHandler Me.next_inv_no1.TextChanged, AddressOf next_inv_no1_TextChanged
            
              AddHandler Me.pad_inv_no1.TextChanged, AddressOf pad_inv_no1_TextChanged
            
              AddHandler Me.pan_no1.TextChanged, AddressOf pan_no1_TextChanged
            
              AddHandler Me.phone.TextChanged, AddressOf phone_TextChanged
            
              AddHandler Me.pincode.TextChanged, AddressOf pincode_TextChanged
            
              AddHandler Me.print_inv_copy_hdr.TextChanged, AddressOf print_inv_copy_hdr_TextChanged
            
              AddHandler Me.proforma_email_body.TextChanged, AddressOf proforma_email_body_TextChanged
            
              AddHandler Me.range1.TextChanged, AddressOf range1_TextChanged
            
              AddHandler Me.srv_tax_no.TextChanged, AddressOf srv_tax_no_TextChanged
            
              AddHandler Me.state.TextChanged, AddressOf state_TextChanged
            
              AddHandler Me.tan_no.TextChanged, AddressOf tan_no_TextChanged
            
              AddHandler Me.tin_no1.TextChanged, AddressOf tin_no1_TextChanged
            
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
        
            Setaddress1()
            SetaddressLabel1()
            Setcer_no1()
            Setcer_noLabel1()
            Setcity()
            SetcityLabel()
            Setdivision1()
            SetdivisionLabel1()
            Setecc_no1()
            Setecc_noLabel1()
            Setemail()
            Setemail_bcc()
            Setemail_bccLabel()
            Setemail_from()
            Setemail_fromLabel()
            SetemailLabel()
            Setfin_year_end1()
            Setfin_year_endLabel1()
            Setfin_year_start1()
            Setfin_year_startLabel1()
            Setinv_declaration()
            Setinv_declarationLabel()
            Setinv_email_body()
            Setinv_email_bodyLabel()
            Setinv_pfx1()
            Setinv_pfxLabel1()
            Setinv_sfx1()
            Setinv_sfxLabel1()
            Setname()
            SetnameLabel()
            Setnext_inv_no1()
            Setnext_inv_noLabel1()
            Setpad_inv_no1()
            Setpad_inv_noLabel1()
            Setpan_no1()
            Setpan_noLabel1()
            Setphone()
            SetphoneLabel()
            Setpincode()
            SetpincodeLabel()
            Setprint_inv_copy_hdr()
            Setprint_inv_copy_hdrLabel()
            Setproforma_email_body()
            Setproforma_email_bodyLabel()
            Setrange1()
            SetrangeLabel1()
            Setsrv_tax_no()
            Setsrv_tax_noLabel()
            Setstate()
            SetstateLabel()
            Settan_no()
            Settan_noLabel()
            Settin_no1()
            Settin_noLabel1()
      
      
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
        
        
        Public Overridable Sub Setaddress1()
            
        
            ' Set the address TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.address1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.address)
                            
                Me.address1.Text = formattedValue
              
            Else 
            
                ' address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.address1.Text = CompanyTable.address.Format(CompanyTable.address.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcer_no1()
            
        
            ' Set the cer_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.cer_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcer_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cer_noSpecified Then
                				
                ' If the cer_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.cer_no)
                            
                Me.cer_no1.Text = formattedValue
              
            Else 
            
                ' cer_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cer_no1.Text = CompanyTable.cer_no.Format(CompanyTable.cer_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcity()
            
        
            ' Set the city TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.city is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcity()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.citySpecified Then
                				
                ' If the city is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.city)
                            
                Me.city.Text = formattedValue
              
            Else 
            
                ' city is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.city.Text = CompanyTable.city.Format(CompanyTable.city.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setdivision1()
            
        
            ' Set the division TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.division1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setdivision1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.divisionSpecified Then
                				
                ' If the division is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.division)
                            
                Me.division1.Text = formattedValue
              
            Else 
            
                ' division is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.division1.Text = CompanyTable.division.Format(CompanyTable.division.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setecc_no1()
            
        
            ' Set the ecc_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.ecc_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.ecc_no)
                            
                Me.ecc_no1.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no1.Text = CompanyTable.ecc_no.Format(CompanyTable.ecc_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setemail()
            
        
            ' Set the email TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.email is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.email)
                            
                Me.email.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email.Text = CompanyTable.email.Format(CompanyTable.email.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setemail_bcc()
            
        
            ' Set the email_bcc TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.email_bcc is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail_bcc()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.email_bccSpecified Then
                				
                ' If the email_bcc is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.email_bcc)
                            
                Me.email_bcc.Text = formattedValue
              
            Else 
            
                ' email_bcc is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email_bcc.Text = CompanyTable.email_bcc.Format(CompanyTable.email_bcc.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setemail_from()
            
        
            ' Set the email_from TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.email_from is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail_from()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.email_fromSpecified Then
                				
                ' If the email_from is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.email_from)
                            
                Me.email_from.Text = formattedValue
              
            Else 
            
                ' email_from is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email_from.Text = CompanyTable.email_from.Format(CompanyTable.email_from.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setfin_year_end1()
            
        
            ' Set the fin_year_end TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.fin_year_end1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setfin_year_end1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.fin_year_endSpecified Then
                				
                ' If the fin_year_end is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.fin_year_end, "d")
                            
                Me.fin_year_end1.Text = formattedValue
              
            Else 
            
                ' fin_year_end is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.fin_year_end1.Text = CompanyTable.fin_year_end.Format(CompanyTable.fin_year_end.DefaultValue, "d")
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setfin_year_start1()
            
        
            ' Set the fin_year_start TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.fin_year_start1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setfin_year_start1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.fin_year_startSpecified Then
                				
                ' If the fin_year_start is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.fin_year_start, "d")
                            
                Me.fin_year_start1.Text = formattedValue
              
            Else 
            
                ' fin_year_start is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.fin_year_start1.Text = CompanyTable.fin_year_start.Format(CompanyTable.fin_year_start.DefaultValue, "d")
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setinv_declaration()
            
        
            ' Set the inv_declaration TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.inv_declaration is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_declaration()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_declarationSpecified Then
                				
                ' If the inv_declaration is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.inv_declaration)
                            
                Me.inv_declaration.Text = formattedValue
              
            Else 
            
                ' inv_declaration is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_declaration.Text = CompanyTable.inv_declaration.Format(CompanyTable.inv_declaration.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setinv_email_body()
            
        
            ' Set the inv_email_body TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.inv_email_body is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_email_body()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_email_bodySpecified Then
                				
                ' If the inv_email_body is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.inv_email_body)
                            
                Me.inv_email_body.Text = formattedValue
              
            Else 
            
                ' inv_email_body is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_email_body.Text = CompanyTable.inv_email_body.Format(CompanyTable.inv_email_body.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setinv_pfx1()
            
        
            ' Set the inv_pfx TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.inv_pfx1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_pfx1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_pfxSpecified Then
                				
                ' If the inv_pfx is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.inv_pfx)
                            
                Me.inv_pfx1.Text = formattedValue
              
            Else 
            
                ' inv_pfx is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_pfx1.Text = CompanyTable.inv_pfx.Format(CompanyTable.inv_pfx.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setinv_sfx1()
            
        
            ' Set the inv_sfx TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.inv_sfx1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_sfx1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_sfxSpecified Then
                				
                ' If the inv_sfx is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.inv_sfx)
                            
                Me.inv_sfx1.Text = formattedValue
              
            Else 
            
                ' inv_sfx is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_sfx1.Text = CompanyTable.inv_sfx.Format(CompanyTable.inv_sfx.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setname()
            
        
            ' Set the name TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.name)
                            
                Me.name.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name.Text = CompanyTable.name.Format(CompanyTable.name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setnext_inv_no1()
            
        
            ' Set the next_inv_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.next_inv_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setnext_inv_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.next_inv_noSpecified Then
                				
                ' If the next_inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.next_inv_no)
                            
                Me.next_inv_no1.Text = formattedValue
              
            Else 
            
                ' next_inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.next_inv_no1.Text = CompanyTable.next_inv_no.Format(CompanyTable.next_inv_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpad_inv_no1()
            
        
            ' Set the pad_inv_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pad_inv_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpad_inv_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pad_inv_noSpecified Then
                				
                ' If the pad_inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pad_inv_no)
                            
                Me.pad_inv_no1.Text = formattedValue
              
            Else 
            
                ' pad_inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pad_inv_no1.Text = CompanyTable.pad_inv_no.Format(CompanyTable.pad_inv_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpan_no1()
            
        
            ' Set the pan_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pan_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pan_no)
                            
                Me.pan_no1.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no1.Text = CompanyTable.pan_no.Format(CompanyTable.pan_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setphone()
            
        
            ' Set the phone TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.phone is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.phone)
                            
                Me.phone.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone.Text = CompanyTable.phone.Format(CompanyTable.phone.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpincode()
            
        
            ' Set the pincode TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pincode is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpincode()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pincodeSpecified Then
                				
                ' If the pincode is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pincode)
                            
                Me.pincode.Text = formattedValue
              
            Else 
            
                ' pincode is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pincode.Text = CompanyTable.pincode.Format(CompanyTable.pincode.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setprint_inv_copy_hdr()
            
        
            ' Set the print_inv_copy_hdr TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.print_inv_copy_hdr is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setprint_inv_copy_hdr()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.print_inv_copy_hdrSpecified Then
                				
                ' If the print_inv_copy_hdr is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.print_inv_copy_hdr)
                            
                Me.print_inv_copy_hdr.Text = formattedValue
              
            Else 
            
                ' print_inv_copy_hdr is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.print_inv_copy_hdr.Text = CompanyTable.print_inv_copy_hdr.Format(CompanyTable.print_inv_copy_hdr.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setproforma_email_body()
            
        
            ' Set the proforma_email_body TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.proforma_email_body is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setproforma_email_body()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.proforma_email_bodySpecified Then
                				
                ' If the proforma_email_body is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.proforma_email_body)
                            
                Me.proforma_email_body.Text = formattedValue
              
            Else 
            
                ' proforma_email_body is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.proforma_email_body.Text = CompanyTable.proforma_email_body.Format(CompanyTable.proforma_email_body.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setrange1()
            
        
            ' Set the range TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.range1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setrange1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.rangeSpecified Then
                				
                ' If the range is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.range)
                            
                Me.range1.Text = formattedValue
              
            Else 
            
                ' range is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.range1.Text = CompanyTable.range.Format(CompanyTable.range.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setsrv_tax_no()
            
        
            ' Set the srv_tax_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.srv_tax_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsrv_tax_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.srv_tax_noSpecified Then
                				
                ' If the srv_tax_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.srv_tax_no)
                            
                Me.srv_tax_no.Text = formattedValue
              
            Else 
            
                ' srv_tax_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.srv_tax_no.Text = CompanyTable.srv_tax_no.Format(CompanyTable.srv_tax_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate()
            
        
            ' Set the state TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.state is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.stateSpecified Then
                				
                ' If the state is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.state)
                            
                Me.state.Text = formattedValue
              
            Else 
            
                ' state is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state.Text = CompanyTable.state.Format(CompanyTable.state.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settan_no()
            
        
            ' Set the tan_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.tan_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settan_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tan_noSpecified Then
                				
                ' If the tan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.tan_no)
                            
                Me.tan_no.Text = formattedValue
              
            Else 
            
                ' tan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tan_no.Text = CompanyTable.tan_no.Format(CompanyTable.tan_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settin_no1()
            
        
            ' Set the tin_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.tin_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.tin_no)
                            
                Me.tin_no1.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no1.Text = CompanyTable.tin_no.Format(CompanyTable.tin_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetaddressLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setcer_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetcityLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetdivisionLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setecc_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setemail_bccLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setemail_fromLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setfin_year_endLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setfin_year_startLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_declarationLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_email_bodyLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_pfxLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_sfxLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setnext_inv_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setpad_inv_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setpan_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetpincodeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setprint_inv_copy_hdrLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setproforma_email_bodyLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetrangeLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setsrv_tax_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetstateLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settan_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settin_noLabel1()
            
                    
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
        
            Getaddress1()
            Getcer_no1()
            Getcity()
            Getdivision1()
            Getecc_no1()
            Getemail()
            Getemail_bcc()
            Getemail_from()
            Getfin_year_end1()
            Getfin_year_start1()
            Getinv_declaration()
            Getinv_email_body()
            Getinv_pfx1()
            Getinv_sfx1()
            Getname()
            Getnext_inv_no1()
            Getpad_inv_no1()
            Getpan_no1()
            Getphone()
            Getpincode()
            Getprint_inv_copy_hdr()
            Getproforma_email_body()
            Getrange1()
            Getsrv_tax_no()
            Getstate()
            Gettan_no()
            Gettin_no1()
        End Sub
        
        
        Public Overridable Sub Getaddress1()
            
            ' Retrieve the value entered by the user on the address ASP:TextBox, and
            ' save it into the address field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.address1.Text, CompanyTable.address)			

                      
        End Sub
                
        Public Overridable Sub Getcer_no1()
            
            ' Retrieve the value entered by the user on the cer_no ASP:TextBox, and
            ' save it into the cer_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.cer_no1.Text, CompanyTable.cer_no)			

                      
        End Sub
                
        Public Overridable Sub Getcity()
            
            ' Retrieve the value entered by the user on the city ASP:TextBox, and
            ' save it into the city field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.city.Text, CompanyTable.city)			

                      
        End Sub
                
        Public Overridable Sub Getdivision1()
            
            ' Retrieve the value entered by the user on the division ASP:TextBox, and
            ' save it into the division field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.division1.Text, CompanyTable.division)			

                      
        End Sub
                
        Public Overridable Sub Getecc_no1()
            
            ' Retrieve the value entered by the user on the ecc_no ASP:TextBox, and
            ' save it into the ecc_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ecc_no1.Text, CompanyTable.ecc_no)			

                      
        End Sub
                
        Public Overridable Sub Getemail()
            
            ' Retrieve the value entered by the user on the email ASP:TextBox, and
            ' save it into the email field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email.Text, CompanyTable.email)			

                      
        End Sub
                
        Public Overridable Sub Getemail_bcc()
            
            ' Retrieve the value entered by the user on the email_bcc ASP:TextBox, and
            ' save it into the email_bcc field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email_bcc.Text, CompanyTable.email_bcc)			

                      
        End Sub
                
        Public Overridable Sub Getemail_from()
            
            ' Retrieve the value entered by the user on the email_from ASP:TextBox, and
            ' save it into the email_from field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email_from.Text, CompanyTable.email_from)			

                      
        End Sub
                
        Public Overridable Sub Getfin_year_end1()
            
            ' Retrieve the value entered by the user on the fin_year_end ASP:TextBox, and
            ' save it into the fin_year_end field in DataSource company record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.fin_year_end1.Text, CompanyTable.fin_year_end)			

                      
        End Sub
                
        Public Overridable Sub Getfin_year_start1()
            
            ' Retrieve the value entered by the user on the fin_year_start ASP:TextBox, and
            ' save it into the fin_year_start field in DataSource company record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.fin_year_start1.Text, CompanyTable.fin_year_start)			

                      
        End Sub
                
        Public Overridable Sub Getinv_declaration()
            
            ' Retrieve the value entered by the user on the inv_declaration ASP:TextBox, and
            ' save it into the inv_declaration field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.inv_declaration.Text, CompanyTable.inv_declaration)			

                      
        End Sub
                
        Public Overridable Sub Getinv_email_body()
            
            ' Retrieve the value entered by the user on the inv_email_body ASP:TextBox, and
            ' save it into the inv_email_body field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.inv_email_body.Text, CompanyTable.inv_email_body)			

                      
        End Sub
                
        Public Overridable Sub Getinv_pfx1()
            
            ' Retrieve the value entered by the user on the inv_pfx ASP:TextBox, and
            ' save it into the inv_pfx field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.inv_pfx1.Text, CompanyTable.inv_pfx)			

                      
        End Sub
                
        Public Overridable Sub Getinv_sfx1()
            
            ' Retrieve the value entered by the user on the inv_sfx ASP:TextBox, and
            ' save it into the inv_sfx field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.inv_sfx1.Text, CompanyTable.inv_sfx)			

                      
        End Sub
                
        Public Overridable Sub Getname()
            
            ' Retrieve the value entered by the user on the name ASP:TextBox, and
            ' save it into the name field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.name.Text, CompanyTable.name)			

                      
        End Sub
                
        Public Overridable Sub Getnext_inv_no1()
            
            ' Retrieve the value entered by the user on the next_inv_no ASP:TextBox, and
            ' save it into the next_inv_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.next_inv_no1.Text, CompanyTable.next_inv_no)			

                      
        End Sub
                
        Public Overridable Sub Getpad_inv_no1()
            
            ' Retrieve the value entered by the user on the pad_inv_no ASP:TextBox, and
            ' save it into the pad_inv_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pad_inv_no1.Text, CompanyTable.pad_inv_no)			

                      
        End Sub
                
        Public Overridable Sub Getpan_no1()
            
            ' Retrieve the value entered by the user on the pan_no ASP:TextBox, and
            ' save it into the pan_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pan_no1.Text, CompanyTable.pan_no)			

                      
        End Sub
                
        Public Overridable Sub Getphone()
            
            ' Retrieve the value entered by the user on the phone ASP:TextBox, and
            ' save it into the phone field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.phone.Text, CompanyTable.phone)			

                      
        End Sub
                
        Public Overridable Sub Getpincode()
            
            ' Retrieve the value entered by the user on the pincode ASP:TextBox, and
            ' save it into the pincode field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pincode.Text, CompanyTable.pincode)			

                      
        End Sub
                
        Public Overridable Sub Getprint_inv_copy_hdr()
            
            ' Retrieve the value entered by the user on the print_inv_copy_hdr ASP:TextBox, and
            ' save it into the print_inv_copy_hdr field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.print_inv_copy_hdr.Text, CompanyTable.print_inv_copy_hdr)			

                      
        End Sub
                
        Public Overridable Sub Getproforma_email_body()
            
            ' Retrieve the value entered by the user on the proforma_email_body ASP:TextBox, and
            ' save it into the proforma_email_body field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.proforma_email_body.Text, CompanyTable.proforma_email_body)			

                      
        End Sub
                
        Public Overridable Sub Getrange1()
            
            ' Retrieve the value entered by the user on the range ASP:TextBox, and
            ' save it into the range field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.range1.Text, CompanyTable.range)			

                      
        End Sub
                
        Public Overridable Sub Getsrv_tax_no()
            
            ' Retrieve the value entered by the user on the srv_tax_no ASP:TextBox, and
            ' save it into the srv_tax_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.srv_tax_no.Text, CompanyTable.srv_tax_no)			

                      
        End Sub
                
        Public Overridable Sub Getstate()
            
            ' Retrieve the value entered by the user on the state ASP:TextBox, and
            ' save it into the state field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state.Text, CompanyTable.state)			

                      
        End Sub
                
        Public Overridable Sub Gettan_no()
            
            ' Retrieve the value entered by the user on the tan_no ASP:TextBox, and
            ' save it into the tan_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tan_no.Text, CompanyTable.tan_no)			

                      
        End Sub
                
        Public Overridable Sub Gettin_no1()
            
            ' Retrieve the value entered by the user on the tin_no ASP:TextBox, and
            ' save it into the tin_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tin_no1.Text, CompanyTable.tin_no)			

                      
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
            HttpContext.Current.Session("QueryString in EditCompany") = recId
              
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
            
        Protected Overridable Sub address1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub cer_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub city_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub division1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub ecc_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email_bcc_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email_from_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub fin_year_end1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub fin_year_start1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub inv_declaration_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub inv_email_body_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub inv_pfx1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub inv_sfx1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub next_inv_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pad_inv_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pan_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub phone_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pincode_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub print_inv_copy_hdr_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub proforma_email_body_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub range1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub srv_tax_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tan_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tin_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
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
        
        Public ReadOnly Property address1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property addressLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "addressLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property cer_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property cer_noLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_noLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property city() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "city"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property cityLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cityLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property CompanyTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "CompanyTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property division1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "division1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property divisionLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "divisionLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ecc_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ecc_noLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_noLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property email() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property email_bcc() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email_bcc"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property email_bccLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email_bccLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property email_from() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email_from"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property email_fromLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email_fromLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property emailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property fin_year_end1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_end1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property fin_year_endLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_endLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property fin_year_start1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_start1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property fin_year_startLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "fin_year_startLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_declaration() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_declaration"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property inv_declarationLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_declarationLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_email_body() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_email_body"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property inv_email_bodyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_email_bodyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_pfx1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_pfx1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property inv_pfxLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_pfxLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_sfx1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_sfx1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property inv_sfxLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_sfxLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property next_inv_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "next_inv_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property next_inv_noLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "next_inv_noLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pad_inv_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pad_inv_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pad_inv_noLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pad_inv_noLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pan_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pan_noLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_noLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property phone() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property phoneLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phoneLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property pincode() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pincode"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pincodeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pincodeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property print_inv_copy_hdr() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "print_inv_copy_hdr"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property print_inv_copy_hdrLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "print_inv_copy_hdrLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property proforma_email_body() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "proforma_email_body"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property proforma_email_bodyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "proforma_email_bodyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property range1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "range1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property rangeLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rangeLabel1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property srv_tax_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "srv_tax_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property srv_tax_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "srv_tax_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property state() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property stateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "stateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tan_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tan_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tan_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tan_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tin_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tin_noLabel1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_noLabel1"), System.Web.UI.WebControls.Literal)
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

  