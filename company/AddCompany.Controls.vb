
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' AddCompany.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.AddCompany

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
    
    
' Base class for the CompanyRecordControl control on the AddCompany page.
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
          
              AddHandler Me.address.TextChanged, AddressOf address_TextChanged
            
              AddHandler Me.cer_code.TextChanged, AddressOf cer_code_TextChanged
            
              AddHandler Me.cer_no.TextChanged, AddressOf cer_no_TextChanged
            
              AddHandler Me.city.TextChanged, AddressOf city_TextChanged
            
              AddHandler Me.division.TextChanged, AddressOf division_TextChanged
            
              AddHandler Me.duty.TextChanged, AddressOf duty_TextChanged
            
              AddHandler Me.eac.TextChanged, AddressOf eac_TextChanged
            
              AddHandler Me.ecc_no.TextChanged, AddressOf ecc_no_TextChanged
            
              AddHandler Me.email.TextChanged, AddressOf email_TextChanged
            
              AddHandler Me.goods.TextChanged, AddressOf goods_TextChanged
            
              AddHandler Me.license.TextChanged, AddressOf license_TextChanged
            
              AddHandler Me.name.TextChanged, AddressOf name_TextChanged
            
              AddHandler Me.pan_no.TextChanged, AddressOf pan_no_TextChanged
            
              AddHandler Me.phone.TextChanged, AddressOf phone_TextChanged
            
              AddHandler Me.pincode.TextChanged, AddressOf pincode_TextChanged
            
              AddHandler Me.range.TextChanged, AddressOf range_TextChanged
            
              AddHandler Me.sign.TextChanged, AddressOf sign_TextChanged
            
              AddHandler Me.state.TextChanged, AddressOf state_TextChanged
            
              AddHandler Me.tin_no.TextChanged, AddressOf tin_no_TextChanged
            
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
          
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New CompanyRecord()
            
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As CompanyRecord = CompanyTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = CType(CompanyRecord.Copy(recList(0), False), CompanyRecord)
                  
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
            Setcer_code()
            Setcer_codeLabel()
            Setcer_no()
            Setcer_noLabel()
            Setcity()
            SetcityLabel()
            Setdivision()
            SetdivisionLabel()
            Setduty()
            SetdutyLabel()
            Seteac()
            SeteacLabel()
            Setecc_no()
            Setecc_noLabel()
            Setemail()
            SetemailLabel()
            Setgoods()
            SetgoodsLabel()
            Setlicense()
            SetlicenseLabel()
            Setname()
            SetnameLabel()
            Setpan_no()
            Setpan_noLabel()
            Setphone()
            SetphoneLabel()
            Setpincode()
            SetpincodeLabel()
            Setrange()
            SetrangeLabel()
            Setsign()
            SetsignLabel()
            Setstate()
            SetstateLabel()
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
            
        
            ' Set the address TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.address is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.address)
                            
                Me.address.Text = formattedValue
              
            Else 
            
                ' address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.address.Text = CompanyTable.address.Format(CompanyTable.address.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcer_code()
            
        
            ' Set the cer_code TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.cer_code is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcer_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cer_codeSpecified Then
                				
                ' If the cer_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.cer_code)
                            
                Me.cer_code.Text = formattedValue
              
            Else 
            
                ' cer_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cer_code.Text = CompanyTable.cer_code.Format(CompanyTable.cer_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcer_no()
            
        
            ' Set the cer_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.cer_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcer_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cer_noSpecified Then
                				
                ' If the cer_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.cer_no)
                            
                Me.cer_no.Text = formattedValue
              
            Else 
            
                ' cer_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cer_no.Text = CompanyTable.cer_no.Format(CompanyTable.cer_no.DefaultValue)
                        		
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
                
        Public Overridable Sub Setdivision()
            
        
            ' Set the division TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.division is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setdivision()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.divisionSpecified Then
                				
                ' If the division is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.division)
                            
                Me.division.Text = formattedValue
              
            Else 
            
                ' division is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.division.Text = CompanyTable.division.Format(CompanyTable.division.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setduty()
            
        
            ' Set the duty TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.duty is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setduty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.dutySpecified Then
                				
                ' If the duty is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.duty)
                            
                Me.duty.Text = formattedValue
              
            Else 
            
                ' duty is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.duty.Text = CompanyTable.duty.Format(CompanyTable.duty.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Seteac()
            
        
            ' Set the eac TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.eac is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Seteac()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.eacSpecified Then
                				
                ' If the eac is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.eac)
                            
                Me.eac.Text = formattedValue
              
            Else 
            
                ' eac is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.eac.Text = CompanyTable.eac.Format(CompanyTable.eac.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setecc_no()
            
        
            ' Set the ecc_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.ecc_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.ecc_no)
                            
                Me.ecc_no.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no.Text = CompanyTable.ecc_no.Format(CompanyTable.ecc_no.DefaultValue)
                        		
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
                
        Public Overridable Sub Setgoods()
            
        
            ' Set the goods TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.goods is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgoods()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.goodsSpecified Then
                				
                ' If the goods is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.goods)
                            
                Me.goods.Text = formattedValue
              
            Else 
            
                ' goods is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.goods.Text = CompanyTable.goods.Format(CompanyTable.goods.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setlicense()
            
        
            ' Set the license TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.license is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setlicense()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.licenseSpecified Then
                				
                ' If the license is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.license)
                            
                Me.license.Text = formattedValue
              
            Else 
            
                ' license is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.license.Text = CompanyTable.license.Format(CompanyTable.license.DefaultValue)
                        		
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
                
        Public Overridable Sub Setpan_no()
            
        
            ' Set the pan_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.pan_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.pan_no)
                            
                Me.pan_no.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no.Text = CompanyTable.pan_no.Format(CompanyTable.pan_no.DefaultValue)
                        		
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
                
        Public Overridable Sub Setrange()
            
        
            ' Set the range TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.range is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setrange()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.rangeSpecified Then
                				
                ' If the range is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.range)
                            
                Me.range.Text = formattedValue
              
            Else 
            
                ' range is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.range.Text = CompanyTable.range.Format(CompanyTable.range.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setsign()
            
        
            ' Set the sign TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.sign is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsign()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.signSpecified Then
                				
                ' If the sign is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.sign)
                            
                Me.sign.Text = formattedValue
              
            Else 
            
                ' sign is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sign.Text = CompanyTable.sign.Format(CompanyTable.sign.DefaultValue)
                        		
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
                
        Public Overridable Sub Settin_no()
            
        
            ' Set the tin_no TextBox on the webpage with value from the
            ' company database record.

            ' Me.DataSource is the company record retrieved from the database.
            ' Me.tin_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(CompanyTable.tin_no)
                            
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = CompanyTable.tin_no.Format(CompanyTable.tin_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub SetaddressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setcer_codeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setcer_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcityLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetdivisionLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetdutyLabel()
            
                    
        End Sub
                
        Public Overridable Sub SeteacLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setecc_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetgoodsLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetlicenseLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpan_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetpincodeLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetrangeLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetsignLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetstateLabel()
            
                    
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
            
            Dim clearDataSource As Boolean = False
            Dim col As BaseColumn
            
            For Each col In CompanyRecord.TableUtils.TableDefinition.Columns()
                If col.ColumnType.Equals(BaseColumn.ColumnTypes.Unique_Identifier) Then
                    clearDataSource = True
                End If
            Next
            

            If clearDataSource Then
                
                Me.DataSource = New CompanyRecord()
            
            End If
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getaddress()
            Getcer_code()
            Getcer_no()
            Getcity()
            Getdivision()
            Getduty()
            Geteac()
            Getecc_no()
            Getemail()
            Getgoods()
            Getlicense()
            Getname()
            Getpan_no()
            Getphone()
            Getpincode()
            Getrange()
            Getsign()
            Getstate()
            Gettin_no()
        End Sub
        
        
        Public Overridable Sub Getaddress()
            
            ' Retrieve the value entered by the user on the address ASP:TextBox, and
            ' save it into the address field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.address.Text, CompanyTable.address)			

                      
        End Sub
                
        Public Overridable Sub Getcer_code()
            
            ' Retrieve the value entered by the user on the cer_code ASP:TextBox, and
            ' save it into the cer_code field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.cer_code.Text, CompanyTable.cer_code)			

                      
        End Sub
                
        Public Overridable Sub Getcer_no()
            
            ' Retrieve the value entered by the user on the cer_no ASP:TextBox, and
            ' save it into the cer_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.cer_no.Text, CompanyTable.cer_no)			

                      
        End Sub
                
        Public Overridable Sub Getcity()
            
            ' Retrieve the value entered by the user on the city ASP:TextBox, and
            ' save it into the city field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.city.Text, CompanyTable.city)			

                      
        End Sub
                
        Public Overridable Sub Getdivision()
            
            ' Retrieve the value entered by the user on the division ASP:TextBox, and
            ' save it into the division field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.division.Text, CompanyTable.division)			

                      
        End Sub
                
        Public Overridable Sub Getduty()
            
            ' Retrieve the value entered by the user on the duty ASP:TextBox, and
            ' save it into the duty field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.duty.Text, CompanyTable.duty)			

                      
        End Sub
                
        Public Overridable Sub Geteac()
            
            ' Retrieve the value entered by the user on the eac ASP:TextBox, and
            ' save it into the eac field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.eac.Text, CompanyTable.eac)			

                      
        End Sub
                
        Public Overridable Sub Getecc_no()
            
            ' Retrieve the value entered by the user on the ecc_no ASP:TextBox, and
            ' save it into the ecc_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ecc_no.Text, CompanyTable.ecc_no)			

                      
        End Sub
                
        Public Overridable Sub Getemail()
            
            ' Retrieve the value entered by the user on the email ASP:TextBox, and
            ' save it into the email field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email.Text, CompanyTable.email)			

                      
        End Sub
                
        Public Overridable Sub Getgoods()
            
            ' Retrieve the value entered by the user on the goods ASP:TextBox, and
            ' save it into the goods field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.goods.Text, CompanyTable.goods)			

                      
        End Sub
                
        Public Overridable Sub Getlicense()
            
            ' Retrieve the value entered by the user on the license ASP:TextBox, and
            ' save it into the license field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.license.Text, CompanyTable.license)			

                      
        End Sub
                
        Public Overridable Sub Getname()
            
            ' Retrieve the value entered by the user on the name ASP:TextBox, and
            ' save it into the name field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.name.Text, CompanyTable.name)			

                      
        End Sub
                
        Public Overridable Sub Getpan_no()
            
            ' Retrieve the value entered by the user on the pan_no ASP:TextBox, and
            ' save it into the pan_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pan_no.Text, CompanyTable.pan_no)			

                      
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
                
        Public Overridable Sub Getrange()
            
            ' Retrieve the value entered by the user on the range ASP:TextBox, and
            ' save it into the range field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.range.Text, CompanyTable.range)			

                      
        End Sub
                
        Public Overridable Sub Getsign()
            
            ' Retrieve the value entered by the user on the sign ASP:TextBox, and
            ' save it into the sign field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.sign.Text, CompanyTable.sign)			

                      
        End Sub
                
        Public Overridable Sub Getstate()
            
            ' Retrieve the value entered by the user on the state ASP:TextBox, and
            ' save it into the state field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state.Text, CompanyTable.state)			

                      
        End Sub
                
        Public Overridable Sub Gettin_no()
            
            ' Retrieve the value entered by the user on the tin_no ASP:TextBox, and
            ' save it into the tin_no field in DataSource company record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tin_no.Text, CompanyTable.tin_no)			

                      
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
                
                Return Nothing
                
            End If
              
            HttpContext.Current.Session("QueryString in AddCompany") = recId
                
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
            
        Protected Overridable Sub address_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub cer_code_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub cer_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub city_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub division_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub duty_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub eac_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub ecc_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub goods_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub license_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pan_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub phone_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pincode_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub range_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub sign_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tin_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
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
        
        Public ReadOnly Property address() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property addressLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "addressLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property cer_code() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_code"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property cer_codeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_codeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property cer_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property cer_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cer_noLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property division() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "division"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property divisionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "divisionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property duty() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "duty"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property dutyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "dutyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property eac() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "eac"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property eacLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "eacLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ecc_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ecc_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property email() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property emailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property goods() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "goods"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property goodsLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "goodsLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property license() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "license"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property licenseLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "licenseLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property pan_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pan_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_noLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property range() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "range"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property rangeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rangeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property sign() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sign"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property signLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "signLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property tin_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no"), System.Web.UI.WebControls.TextBox)
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
            
            
            Return New CompanyRecord()
            
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

  