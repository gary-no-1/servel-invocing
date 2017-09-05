
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditStates.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.EditStates

#Region "Section 1: Place your customizations here."

    
Public Class PartyTableControlRow
        Inherits BasePartyTableControlRow
        ' The BasePartyTableControlRow implements code for a ROW within the
        ' the PartyTableControl table.  The BasePartyTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of PartyTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class PartyTableControl
        Inherits BasePartyTableControl

    ' The BasePartyTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The PartyTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class SitesTableControlRow
        Inherits BaseSitesTableControlRow
        ' The BaseSitesTableControlRow implements code for a ROW within the
        ' the SitesTableControl table.  The BaseSitesTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of SitesTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class SitesTableControl
        Inherits BaseSitesTableControl

    ' The BaseSitesTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The SitesTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class StatesRecordControl
        Inherits BaseStatesRecordControl
        ' The BaseStatesRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the PartyTableControlRow control on the EditStates page.
' Do not modify this class. Instead override any method in PartyTableControlRow.
Public Class BasePartyTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in PartyTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in PartyTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.PartyRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.PartyRowDeleteButton.Click, AddressOf PartyRowDeleteButton_Click
              
              AddHandler Me.PartyRowEditButton.Click, AddressOf PartyRowEditButton_Click
              
              AddHandler Me.PartyRowViewButton.Click, AddressOf PartyRowViewButton_Click
              
              AddHandler Me.address.TextChanged, AddressOf address_TextChanged
            
              AddHandler Me.city.TextChanged, AddressOf city_TextChanged
            
              AddHandler Me.contact.TextChanged, AddressOf contact_TextChanged
            
              AddHandler Me.cst_date.TextChanged, AddressOf cst_date_TextChanged
            
              AddHandler Me.cst_no.TextChanged, AddressOf cst_no_TextChanged
            
              AddHandler Me.ecc_no.TextChanged, AddressOf ecc_no_TextChanged
            
              AddHandler Me.email.TextChanged, AddressOf email_TextChanged
            
              AddHandler Me.gst_no.TextChanged, AddressOf gst_no_TextChanged
            
              AddHandler Me.lst_date.TextChanged, AddressOf lst_date_TextChanged
            
              AddHandler Me.lst_no.TextChanged, AddressOf lst_no_TextChanged
            
              AddHandler Me.name.TextChanged, AddressOf name_TextChanged
            
              AddHandler Me.pan_no.TextChanged, AddressOf pan_no_TextChanged
            
              AddHandler Me.party_code.TextChanged, AddressOf party_code_TextChanged
            
              AddHandler Me.phone.TextChanged, AddressOf phone_TextChanged
            
              AddHandler Me.st37_no.TextChanged, AddressOf st37_no_TextChanged
            
              AddHandler Me.state_code1.TextChanged, AddressOf state_code1_TextChanged
            
              AddHandler Me.state_name1.TextChanged, AddressOf state_name1_TextChanged
            
              AddHandler Me.tin_no.TextChanged, AddressOf tin_no_TextChanged
            
              AddHandler Me.vat_no.TextChanged, AddressOf vat_no_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource party record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = PartyTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BasePartyTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New PartyRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in PartyTableControlRow.
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
            Setcity()
            Setcontact()
            Setcst_date()
            Setcst_no()
            Setecc_no()
            Setemail()
            Setgst_no()
            Setlst_date()
            Setlst_no()
            Setname()
            Setpan_no()
            Setparty_code()
            Setphone()
            Setst37_no()
            Setstate_code1()
            Setstate_name1()
            Settin_no()
            Setvat_no()
      
      
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
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.address.ID) Then
            
                Me.address.Text = Me.PreviousUIData(Me.address.ID).ToString()
              
                Return
            End If
            
        
            ' Set the address TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.address is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.address)
                            
                Me.address.Text = formattedValue
              
            Else 
            
                ' address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.address.Text = PartyTable.address.Format(PartyTable.address.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcity()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.city.ID) Then
            
                Me.city.Text = Me.PreviousUIData(Me.city.ID).ToString()
              
                Return
            End If
            
        
            ' Set the city TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.city is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcity()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.citySpecified Then
                				
                ' If the city is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.city)
                            
                Me.city.Text = formattedValue
              
            Else 
            
                ' city is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.city.Text = PartyTable.city.Format(PartyTable.city.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcontact()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.contact.ID) Then
            
                Me.contact.Text = Me.PreviousUIData(Me.contact.ID).ToString()
              
                Return
            End If
            
        
            ' Set the contact TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.contact is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcontact()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.contactSpecified Then
                				
                ' If the contact is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.contact)
                            
                Me.contact.Text = formattedValue
              
            Else 
            
                ' contact is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.contact.Text = PartyTable.contact.Format(PartyTable.contact.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcst_date()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.cst_date.ID) Then
            
                Me.cst_date.Text = Me.PreviousUIData(Me.cst_date.ID).ToString()
              
                Return
            End If
            
        
            ' Set the cst_date TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.cst_date is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcst_date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cst_dateSpecified Then
                				
                ' If the cst_date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.cst_date, "d")
                            
                Me.cst_date.Text = formattedValue
              
            Else 
            
                ' cst_date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cst_date.Text = PartyTable.cst_date.Format(PartyTable.cst_date.DefaultValue, "d")
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcst_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.cst_no.ID) Then
            
                Me.cst_no.Text = Me.PreviousUIData(Me.cst_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the cst_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.cst_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cst_noSpecified Then
                				
                ' If the cst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.cst_no)
                            
                Me.cst_no.Text = formattedValue
              
            Else 
            
                ' cst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cst_no.Text = PartyTable.cst_no.Format(PartyTable.cst_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setecc_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.ecc_no.ID) Then
            
                Me.ecc_no.Text = Me.PreviousUIData(Me.ecc_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the ecc_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.ecc_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.ecc_no)
                            
                Me.ecc_no.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no.Text = PartyTable.ecc_no.Format(PartyTable.ecc_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setemail()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.email.ID) Then
            
                Me.email.Text = Me.PreviousUIData(Me.email.ID).ToString()
              
                Return
            End If
            
        
            ' Set the email TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.email is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.email)
                            
                Me.email.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email.Text = PartyTable.email.Format(PartyTable.email.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgst_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.gst_no.ID) Then
            
                Me.gst_no.Text = Me.PreviousUIData(Me.gst_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the gst_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.gst_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_noSpecified Then
                				
                ' If the gst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.gst_no)
                            
                Me.gst_no.Text = formattedValue
              
            Else 
            
                ' gst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_no.Text = PartyTable.gst_no.Format(PartyTable.gst_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setlst_date()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.lst_date.ID) Then
            
                Me.lst_date.Text = Me.PreviousUIData(Me.lst_date.ID).ToString()
              
                Return
            End If
            
        
            ' Set the lst_date TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.lst_date is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setlst_date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.lst_dateSpecified Then
                				
                ' If the lst_date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.lst_date, "d")
                            
                Me.lst_date.Text = formattedValue
              
            Else 
            
                ' lst_date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.lst_date.Text = PartyTable.lst_date.Format(PartyTable.lst_date.DefaultValue, "d")
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setlst_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.lst_no.ID) Then
            
                Me.lst_no.Text = Me.PreviousUIData(Me.lst_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the lst_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.lst_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setlst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.lst_noSpecified Then
                				
                ' If the lst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.lst_no)
                            
                Me.lst_no.Text = formattedValue
              
            Else 
            
                ' lst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.lst_no.Text = PartyTable.lst_no.Format(PartyTable.lst_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setname()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.name.ID) Then
            
                Me.name.Text = Me.PreviousUIData(Me.name.ID).ToString()
              
                Return
            End If
            
        
            ' Set the name TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.name)
                            
                Me.name.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name.Text = PartyTable.name.Format(PartyTable.name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpan_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.pan_no.ID) Then
            
                Me.pan_no.Text = Me.PreviousUIData(Me.pan_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the pan_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.pan_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.pan_no)
                            
                Me.pan_no.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no.Text = PartyTable.pan_no.Format(PartyTable.pan_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setparty_code()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.party_code.ID) Then
            
                Me.party_code.Text = Me.PreviousUIData(Me.party_code.ID).ToString()
              
                Return
            End If
            
        
            ' Set the party_code TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.party_code is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setparty_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.party_codeSpecified Then
                				
                ' If the party_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.party_code)
                            
                Me.party_code.Text = formattedValue
              
            Else 
            
                ' party_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.party_code.Text = PartyTable.party_code.Format(PartyTable.party_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setphone()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.phone.ID) Then
            
                Me.phone.Text = Me.PreviousUIData(Me.phone.ID).ToString()
              
                Return
            End If
            
        
            ' Set the phone TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.phone is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.phone)
                            
                Me.phone.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone.Text = PartyTable.phone.Format(PartyTable.phone.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setst37_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.st37_no.ID) Then
            
                Me.st37_no.Text = Me.PreviousUIData(Me.st37_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the st37_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.st37_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setst37_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.st37_noSpecified Then
                				
                ' If the st37_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.st37_no)
                            
                Me.st37_no.Text = formattedValue
              
            Else 
            
                ' st37_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.st37_no.Text = PartyTable.st37_no.Format(PartyTable.st37_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate_code1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.state_code1.ID) Then
            
                Me.state_code1.Text = Me.PreviousUIData(Me.state_code1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the state_code TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.state_code1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_code1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_codeSpecified Then
                				
                ' If the state_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.state_code)
                            
                Me.state_code1.Text = formattedValue
              
            Else 
            
                ' state_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_code1.Text = PartyTable.state_code.Format(PartyTable.state_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate_name1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.state_name1.ID) Then
            
                Me.state_name1.Text = Me.PreviousUIData(Me.state_name1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the state_name TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.state_name1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_name1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_nameSpecified Then
                				
                ' If the state_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.state_name)
                            
                Me.state_name1.Text = formattedValue
              
            Else 
            
                ' state_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_name1.Text = PartyTable.state_name.Format(PartyTable.state_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settin_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tin_no.ID) Then
            
                Me.tin_no.Text = Me.PreviousUIData(Me.tin_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tin_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.tin_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.tin_no)
                            
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = PartyTable.tin_no.Format(PartyTable.tin_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setvat_no()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.vat_no.ID) Then
            
                Me.vat_no.Text = Me.PreviousUIData(Me.vat_no.ID).ToString()
              
                Return
            End If
            
        
            ' Set the vat_no TextBox on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.vat_no is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setvat_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.vat_noSpecified Then
                				
                ' If the vat_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.vat_no)
                            
                Me.vat_no.Text = formattedValue
              
            Else 
            
                ' vat_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.vat_no.Text = PartyTable.vat_no.Format(PartyTable.vat_no.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in PartyTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As StatesRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("StatesRecordControl"), StatesRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_states = parentCtrl.DataSource.id0
              
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
              
                DirectCast(GetParentControlObject(Me, "PartyTableControl"), PartyTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "PartyTableControl"), PartyTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in PartyTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getaddress()
            Getcity()
            Getcontact()
            Getcst_date()
            Getcst_no()
            Getecc_no()
            Getemail()
            Getgst_no()
            Getlst_date()
            Getlst_no()
            Getname()
            Getpan_no()
            Getparty_code()
            Getphone()
            Getst37_no()
            Getstate_code1()
            Getstate_name1()
            Gettin_no()
            Getvat_no()
        End Sub
        
        
        Public Overridable Sub Getaddress()
            
            ' Retrieve the value entered by the user on the address ASP:TextBox, and
            ' save it into the address field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.address.Text, PartyTable.address)			

                      
        End Sub
                
        Public Overridable Sub Getcity()
            
            ' Retrieve the value entered by the user on the city ASP:TextBox, and
            ' save it into the city field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.city.Text, PartyTable.city)			

                      
        End Sub
                
        Public Overridable Sub Getcontact()
            
            ' Retrieve the value entered by the user on the contact ASP:TextBox, and
            ' save it into the contact field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.contact.Text, PartyTable.contact)			

                      
        End Sub
                
        Public Overridable Sub Getcst_date()
            
            ' Retrieve the value entered by the user on the cst_date ASP:TextBox, and
            ' save it into the cst_date field in DataSource party record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.cst_date.Text, PartyTable.cst_date)			

                      
        End Sub
                
        Public Overridable Sub Getcst_no()
            
            ' Retrieve the value entered by the user on the cst_no ASP:TextBox, and
            ' save it into the cst_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.cst_no.Text, PartyTable.cst_no)			

                      
        End Sub
                
        Public Overridable Sub Getecc_no()
            
            ' Retrieve the value entered by the user on the ecc_no ASP:TextBox, and
            ' save it into the ecc_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ecc_no.Text, PartyTable.ecc_no)			

                      
        End Sub
                
        Public Overridable Sub Getemail()
            
            ' Retrieve the value entered by the user on the email ASP:TextBox, and
            ' save it into the email field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email.Text, PartyTable.email)			

                      
        End Sub
                
        Public Overridable Sub Getgst_no()
            
            ' Retrieve the value entered by the user on the gst_no ASP:TextBox, and
            ' save it into the gst_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.gst_no.Text, PartyTable.gst_no)			

                      
        End Sub
                
        Public Overridable Sub Getlst_date()
            
            ' Retrieve the value entered by the user on the lst_date ASP:TextBox, and
            ' save it into the lst_date field in DataSource party record.
            ' Parse will also validate the date to ensure it is of the proper format
            ' and a valid date.  The format is verified based on the current culture 
            ' settings including the order of month, day and year and the separator character.
            ' Parse throws an exception if the date is invalid.
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.lst_date.Text, PartyTable.lst_date)			

                      
        End Sub
                
        Public Overridable Sub Getlst_no()
            
            ' Retrieve the value entered by the user on the lst_no ASP:TextBox, and
            ' save it into the lst_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.lst_no.Text, PartyTable.lst_no)			

                      
        End Sub
                
        Public Overridable Sub Getname()
            
            ' Retrieve the value entered by the user on the name ASP:TextBox, and
            ' save it into the name field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.name.Text, PartyTable.name)			

                      
        End Sub
                
        Public Overridable Sub Getpan_no()
            
            ' Retrieve the value entered by the user on the pan_no ASP:TextBox, and
            ' save it into the pan_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pan_no.Text, PartyTable.pan_no)			

                      
        End Sub
                
        Public Overridable Sub Getparty_code()
            
            ' Retrieve the value entered by the user on the party_code ASP:TextBox, and
            ' save it into the party_code field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.party_code.Text, PartyTable.party_code)			

                      
        End Sub
                
        Public Overridable Sub Getphone()
            
            ' Retrieve the value entered by the user on the phone ASP:TextBox, and
            ' save it into the phone field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.phone.Text, PartyTable.phone)			

                      
        End Sub
                
        Public Overridable Sub Getst37_no()
            
            ' Retrieve the value entered by the user on the st37_no ASP:TextBox, and
            ' save it into the st37_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.st37_no.Text, PartyTable.st37_no)			

                      
        End Sub
                
        Public Overridable Sub Getstate_code1()
            
            ' Retrieve the value entered by the user on the state_code ASP:TextBox, and
            ' save it into the state_code field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state_code1.Text, PartyTable.state_code)			

                      
        End Sub
                
        Public Overridable Sub Getstate_name1()
            
            ' Retrieve the value entered by the user on the state_name ASP:TextBox, and
            ' save it into the state_name field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state_name1.Text, PartyTable.state_name)			

                      
        End Sub
                
        Public Overridable Sub Gettin_no()
            
            ' Retrieve the value entered by the user on the tin_no ASP:TextBox, and
            ' save it into the tin_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tin_no.Text, PartyTable.tin_no)			

                      
        End Sub
                
        Public Overridable Sub Getvat_no()
            
            ' Retrieve the value entered by the user on the vat_no ASP:TextBox, and
            ' save it into the vat_no field in DataSource party record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.vat_no.Text, PartyTable.vat_no)			

                      
        End Sub
                
      
        ' To customize, override this method in PartyTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in PartyTableControlRow.
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
          PartyTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "PartyTableControl"), PartyTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "PartyTableControl"), PartyTableControl).ResetData = True
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
        Public Overridable Sub PartyRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As PartyTableControl = DirectCast(GetParentControlObject(Me, "PartyTableControl"), PartyTableControl)
                If Not (IsNothing(tc)) Then
                    
                    Me.Visible = False
                End If
              
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
        Public Overridable Sub PartyRowEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/EditParty.aspx?Party={PK}"
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
        Public Overridable Sub PartyRowViewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/ShowParty.aspx?Party={PK}"
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
        
        Protected Overridable Sub address_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub city_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub contact_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub cst_date_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub cst_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub ecc_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub gst_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub lst_date_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub lst_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pan_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub party_code_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub phone_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub st37_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_code1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_name1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tin_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub vat_no_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
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
                Return CType(Me.ViewState("BasePartyTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BasePartyTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As PartyRecord
        Public Property DataSource() As PartyRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As PartyRecord)
            
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
        
        Public ReadOnly Property address() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property city() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "city"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property contact() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contact"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property cst_date() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_date"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property cst_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ecc_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property email() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property gst_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property lst_date() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lst_date"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property lst_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lst_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pan_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property party_code() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "party_code"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property PartyRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property PartyRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyRowEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRowEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyRowViewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRowViewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property phone() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property st37_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "st37_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property state_code1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_code1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property state_name1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_name1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tin_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property vat_no() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_no"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As PartyRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As PartyRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return PartyTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the PartyTableControl control on the EditStates page.
' Do not modify this class. Instead override any method in PartyTableControl.
Public Class BasePartyTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
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
              Me.PartyDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.PartyPagination.FirstPage.Click, AddressOf PartyPagination_FirstPage_Click
              
              AddHandler Me.PartyPagination.LastPage.Click, AddressOf PartyPagination_LastPage_Click
              
              AddHandler Me.PartyPagination.NextPage.Click, AddressOf PartyPagination_NextPage_Click
              
              AddHandler Me.PartyPagination.PageSizeButton.Click, AddressOf PartyPagination_PageSizeButton_Click
            
              AddHandler Me.PartyPagination.PreviousPage.Click, AddressOf PartyPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.addressLabel.Click, AddressOf addressLabel_Click
            
              AddHandler Me.cityLabel.Click, AddressOf cityLabel_Click
            
              AddHandler Me.contactLabel.Click, AddressOf contactLabel_Click
            
              AddHandler Me.cst_dateLabel.Click, AddressOf cst_dateLabel_Click
            
              AddHandler Me.cst_noLabel.Click, AddressOf cst_noLabel_Click
            
              AddHandler Me.ecc_noLabel.Click, AddressOf ecc_noLabel_Click
            
              AddHandler Me.emailLabel.Click, AddressOf emailLabel_Click
            
              AddHandler Me.gst_noLabel.Click, AddressOf gst_noLabel_Click
            
              AddHandler Me.lst_dateLabel.Click, AddressOf lst_dateLabel_Click
            
              AddHandler Me.lst_noLabel.Click, AddressOf lst_noLabel_Click
            
              AddHandler Me.nameLabel1.Click, AddressOf nameLabel1_Click
            
              AddHandler Me.pan_noLabel.Click, AddressOf pan_noLabel_Click
            
              AddHandler Me.party_codeLabel1.Click, AddressOf party_codeLabel1_Click
            
              AddHandler Me.phoneLabel.Click, AddressOf phoneLabel_Click
            
              AddHandler Me.st37_noLabel.Click, AddressOf st37_noLabel_Click
            
              AddHandler Me.state_codeLabel1.Click, AddressOf state_codeLabel1_Click
            
              AddHandler Me.state_nameLabel1.Click, AddressOf state_nameLabel1_Click
            
              AddHandler Me.tin_noLabel.Click, AddressOf tin_noLabel_Click
            
              AddHandler Me.vat_noLabel.Click, AddressOf vat_noLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.PartyAddButton.Click, AddressOf PartyAddButton_Click
              
              AddHandler Me.PartyDeleteButton.Click, AddressOf PartyDeleteButton_Click
              
              AddHandler Me.PartyEditButton.Click, AddressOf PartyEditButton_Click
              
              AddHandler Me.PartyResetButton.Click, AddressOf PartyResetButton_Click
              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(PartyRecord)), PartyRecord())
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
                
                Me.TotalRecords = PartyTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(PartyRecord)), PartyRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As PartyTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(PartyRecord)), PartyRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = PartyTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.PartyToggleAll.Checked = False
            

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
        
            SetaddressLabel()
            SetcityLabel()
            SetcontactLabel()
            Setcst_dateLabel()
            Setcst_noLabel()
            Setecc_noLabel()
            SetemailLabel()
            Setgst_noLabel()
            Setlst_dateLabel()
            Setlst_noLabel()
            SetnameLabel1()
            Setpan_noLabel()
            Setparty_codeLabel1()
            SetphoneLabel()
            Setst37_noLabel()
            Setstate_codeLabel1()
            Setstate_nameLabel1()
            Settin_noLabel()
            Setvat_noLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("PartyTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As PartyTableControlRow = DirectCast(repItem.FindControl("PartyTableControlRow"), PartyTableControlRow) 
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
            
            SetaddressLabel()
            SetcityLabel()
            SetcontactLabel()
            Setcst_dateLabel()
            Setcst_noLabel()
            Setecc_noLabel()
            SetemailLabel()
            Setgst_noLabel()
            Setlst_dateLabel()
            Setlst_noLabel()
            SetnameLabel1()
            Setpan_noLabel()
            Setparty_codeLabel1()
            SetphoneLabel()
            Setst37_noLabel()
            Setstate_codeLabel1()
            Setstate_nameLabel1()
            Settin_noLabel()
            Setvat_noLabel()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
        
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

            ' Bind the buttons for PartyTableControl pagination.
        
            Me.PartyPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.PartyPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.PartyPagination.LastPage.Enabled = False
            End If
          
            Me.PartyPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.PartyPagination.NextPage.Enabled = False
            End If
          
            Me.PartyPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.PartyPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.PartyPagination.CurrentPage.Text = "0"
            End If
            Me.PartyPagination.PageSize.Text = Me.PageSize.ToString()
            Me.PartyPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.PartyPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As PartyTableControlRow
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
            PartyTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim statesRecordControlObj As StatesRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "StatesRecordControl"), StatesRecordControl)
              
                If (Not IsNothing(statesRecordControlObj) AndAlso Not IsNothing(statesRecordControlObj.GetRecord()) AndAlso Not IsNothing(statesRecordControlObj.GetRecord().id0))
                    wc.iAND(PartyTable.id_states, BaseFilter.ComparisonOperator.EqualsTo, statesRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(PartyTable.id_states.InternalName, statesRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("PartyTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            PartyTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInStatesRecordControl as String = DirectCast(HttpContext.Current.Session("PartyTableControlWhereClause"), String)
            
            If Not selectedRecordInStatesRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInStatesRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInStatesRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(PartyTable.id_states) Then
            wc.iAND(PartyTable.id_states, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(PartyTable.id_states).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Return wc
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
        
            If Me.PartyPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.PartyPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("PartyTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As PartyTableControlRow = DirectCast(repItem.FindControl("PartyTableControlRow"), PartyTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As PartyRecord = New PartyRecord()
        
                        If recControl.address.Text <> "" Then
                            rec.Parse(recControl.address.Text, PartyTable.address)
                        End If
                        If recControl.city.Text <> "" Then
                            rec.Parse(recControl.city.Text, PartyTable.city)
                        End If
                        If recControl.contact.Text <> "" Then
                            rec.Parse(recControl.contact.Text, PartyTable.contact)
                        End If
                        If recControl.cst_date.Text <> "" Then
                            rec.Parse(recControl.cst_date.Text, PartyTable.cst_date)
                        End If
                        If recControl.cst_no.Text <> "" Then
                            rec.Parse(recControl.cst_no.Text, PartyTable.cst_no)
                        End If
                        If recControl.ecc_no.Text <> "" Then
                            rec.Parse(recControl.ecc_no.Text, PartyTable.ecc_no)
                        End If
                        If recControl.email.Text <> "" Then
                            rec.Parse(recControl.email.Text, PartyTable.email)
                        End If
                        If recControl.gst_no.Text <> "" Then
                            rec.Parse(recControl.gst_no.Text, PartyTable.gst_no)
                        End If
                        If recControl.lst_date.Text <> "" Then
                            rec.Parse(recControl.lst_date.Text, PartyTable.lst_date)
                        End If
                        If recControl.lst_no.Text <> "" Then
                            rec.Parse(recControl.lst_no.Text, PartyTable.lst_no)
                        End If
                        If recControl.name.Text <> "" Then
                            rec.Parse(recControl.name.Text, PartyTable.name)
                        End If
                        If recControl.pan_no.Text <> "" Then
                            rec.Parse(recControl.pan_no.Text, PartyTable.pan_no)
                        End If
                        If recControl.party_code.Text <> "" Then
                            rec.Parse(recControl.party_code.Text, PartyTable.party_code)
                        End If
                        If recControl.phone.Text <> "" Then
                            rec.Parse(recControl.phone.Text, PartyTable.phone)
                        End If
                        If recControl.st37_no.Text <> "" Then
                            rec.Parse(recControl.st37_no.Text, PartyTable.st37_no)
                        End If
                        If recControl.state_code1.Text <> "" Then
                            rec.Parse(recControl.state_code1.Text, PartyTable.state_code)
                        End If
                        If recControl.state_name1.Text <> "" Then
                            rec.Parse(recControl.state_name1.Text, PartyTable.state_name)
                        End If
                        If recControl.tin_no.Text <> "" Then
                            rec.Parse(recControl.tin_no.Text, PartyTable.tin_no)
                        End If
                        If recControl.vat_no.Text <> "" Then
                            rec.Parse(recControl.vat_no.Text, PartyTable.vat_no)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New PartyRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(PartyRecord)), PartyRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As PartyTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As PartyTableControlRow) As Boolean
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
        
        Public Overridable Sub SetaddressLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcityLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcontactLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setcst_dateLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setcst_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setecc_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setlst_dateLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setlst_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setpan_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setparty_codeLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setst37_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setstate_codeLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setstate_nameLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Settin_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setvat_noLabel()
            
                    
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
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("PartyTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
			    'Load scripts to table rows
                Me.Page.LoadFocusScripts(repItem)
                Dim recControl As PartyTableControlRow = DirectCast(repItem.FindControl("PartyTableControlRow"), PartyTableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
						    'set focus on the first editable field in the new row
						    field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            
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
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("PartyTableControl_OrderBy"), String)
            
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
                Me.ViewState("PartyTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub PartyPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub PartyPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub PartyPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub PartyPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.PartyPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.PartyPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub PartyPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub addressLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by address when clicked.
              
            ' Get previous sorting state for address.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.address)
            If sd Is Nothing Then
                ' First time sort, so add sort order for address.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.address, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by address, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub cityLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by city when clicked.
              
            ' Get previous sorting state for city.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.city)
            If sd Is Nothing Then
                ' First time sort, so add sort order for city.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.city, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by city, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub contactLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by contact when clicked.
              
            ' Get previous sorting state for contact.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.contact)
            If sd Is Nothing Then
                ' First time sort, so add sort order for contact.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.contact, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by contact, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub cst_dateLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by cst_date when clicked.
              
            ' Get previous sorting state for cst_date.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.cst_date)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cst_date.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.cst_date, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cst_date, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub cst_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by cst_no when clicked.
              
            ' Get previous sorting state for cst_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.cst_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for cst_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.cst_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by cst_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub ecc_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by ecc_no when clicked.
              
            ' Get previous sorting state for ecc_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.ecc_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for ecc_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.ecc_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by ecc_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub emailLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by email when clicked.
              
            ' Get previous sorting state for email.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.email)
            If sd Is Nothing Then
                ' First time sort, so add sort order for email.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.email, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by email, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_no when clicked.
              
            ' Get previous sorting state for gst_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.gst_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.gst_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub lst_dateLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by lst_date when clicked.
              
            ' Get previous sorting state for lst_date.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.lst_date)
            If sd Is Nothing Then
                ' First time sort, so add sort order for lst_date.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.lst_date, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by lst_date, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub lst_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by lst_no when clicked.
              
            ' Get previous sorting state for lst_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.lst_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for lst_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.lst_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by lst_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub nameLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by name when clicked.
              
            ' Get previous sorting state for name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by name, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub pan_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by pan_no when clicked.
              
            ' Get previous sorting state for pan_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.pan_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for pan_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.pan_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by pan_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub party_codeLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by party_code when clicked.
              
            ' Get previous sorting state for party_code.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.party_code)
            If sd Is Nothing Then
                ' First time sort, so add sort order for party_code.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.party_code, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by party_code, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub phoneLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by phone when clicked.
              
            ' Get previous sorting state for phone.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.phone)
            If sd Is Nothing Then
                ' First time sort, so add sort order for phone.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.phone, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by phone, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub st37_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by st37_no when clicked.
              
            ' Get previous sorting state for st37_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.st37_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for st37_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.st37_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by st37_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub state_codeLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by state_code when clicked.
              
            ' Get previous sorting state for state_code.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.state_code)
            If sd Is Nothing Then
                ' First time sort, so add sort order for state_code.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.state_code, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by state_code, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub state_nameLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by state_name when clicked.
              
            ' Get previous sorting state for state_name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.state_name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for state_name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.state_name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by state_name, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.tin_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tin_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.tin_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tin_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub vat_noLabel_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by vat_no when clicked.
              
            ' Get previous sorting state for vat_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(PartyTable.vat_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for vat_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(PartyTable.vat_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by vat_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub PartyAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
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
        Public Overridable Sub PartyDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
          
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
        Public Overridable Sub PartyEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/EditParty.aspx?Party={PK}"
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
        Public Overridable Sub PartyResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
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
        
        Private _DataSource() As PartyRecord = Nothing
        Public Property DataSource() As PartyRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As PartyRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property addressLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "addressLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property cityLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cityLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property contactLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contactLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property cst_dateLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_dateLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property cst_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property ecc_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property emailLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property lst_dateLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lst_dateLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property lst_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lst_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property nameLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property pan_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property party_codeLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "party_codeLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property PartyResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property phoneLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phoneLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property st37_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "st37_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property state_codeLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_codeLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property state_nameLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_nameLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tin_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_noLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property vat_noLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_noLabel"), System.Web.UI.WebControls.LinkButton)
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
                Dim recCtl As PartyTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As PartyRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As PartyTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.PartyRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As PartyTableControlRow
            Dim selectedList() As PartyTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As PartyTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As PartyTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.PartyRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(PartyTableControlRow)), PartyTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As PartyTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As PartyTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.PartyRecordRowSelection.Checked = False
                
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

        Public Function GetRecordControls() As PartyTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("PartyTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As PartyTableControlRow = DirectCast(repItem.FindControl("PartyTableControlRow"), PartyTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(PartyTableControlRow)), PartyTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the SitesTableControlRow control on the EditStates page.
' Do not modify this class. Instead override any method in SitesTableControlRow.
Public Class BaseSitesTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in SitesTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in SitesTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.SitesRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              Me.id_partyAddRecordLink.PostBackUrl = "../party/AddParty.aspx" & "?Target=" & Me.id_party.ClientID & "&DFKA=name"
              Me.id_partyAddRecordLink.Attributes.Item("onClick") = "window.open('" & Me.id_partyAddRecordLink.PostBackUrl & "','_blank', 'width=900, height=700, resizable, scrollbars, modal=yes'); return false;"
              
              AddHandler Me.SitesRowDeleteButton.Click, AddressOf SitesRowDeleteButton_Click
              
              AddHandler Me.SitesRowEditButton.Click, AddressOf SitesRowEditButton_Click
              
              AddHandler Me.SitesRowViewButton.Click, AddressOf SitesRowViewButton_Click
              
              AddHandler Me.id_party.SelectedIndexChanged, AddressOf id_party_SelectedIndexChanged
            
              AddHandler Me.address1.TextChanged, AddressOf address1_TextChanged
            
              AddHandler Me.city1.TextChanged, AddressOf city1_TextChanged
            
              AddHandler Me.contact1.TextChanged, AddressOf contact1_TextChanged
            
              AddHandler Me.ecc_no1.TextChanged, AddressOf ecc_no1_TextChanged
            
              AddHandler Me.email1.TextChanged, AddressOf email1_TextChanged
            
              AddHandler Me.gst_no1.TextChanged, AddressOf gst_no1_TextChanged
            
              AddHandler Me.name1.TextChanged, AddressOf name1_TextChanged
            
              AddHandler Me.pan_no1.TextChanged, AddressOf pan_no1_TextChanged
            
              AddHandler Me.party_code1.TextChanged, AddressOf party_code1_TextChanged
            
              AddHandler Me.phone1.TextChanged, AddressOf phone1_TextChanged
            
              AddHandler Me.st37_no1.TextChanged, AddressOf st37_no1_TextChanged
            
              AddHandler Me.state_code2.TextChanged, AddressOf state_code2_TextChanged
            
              AddHandler Me.state_name2.TextChanged, AddressOf state_name2_TextChanged
            
              AddHandler Me.tin_no1.TextChanged, AddressOf tin_no1_TextChanged
            
              AddHandler Me.vat_no1.TextChanged, AddressOf vat_no1_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource sites record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = SitesTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseSitesTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New SitesRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in SitesTableControlRow.
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
            Setcity1()
            Setcontact1()
            Setecc_no1()
            Setemail1()
            Setgst_no1()
            Setid_party()
            Setname1()
            Setpan_no1()
            Setparty_code1()
            Setphone1()
            Setst37_no1()
            Setstate_code2()
            Setstate_name2()
            Settin_no1()
            Setvat_no1()
      
      
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
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.address1.ID) Then
            
                Me.address1.Text = Me.PreviousUIData(Me.address1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the address TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.address1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.address)
                            
                Me.address1.Text = formattedValue
              
            Else 
            
                ' address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.address1.Text = SitesTable.address.Format(SitesTable.address.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcity1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.city1.ID) Then
            
                Me.city1.Text = Me.PreviousUIData(Me.city1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the city TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.city1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcity1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.citySpecified Then
                				
                ' If the city is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.city)
                            
                Me.city1.Text = formattedValue
              
            Else 
            
                ' city is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.city1.Text = SitesTable.city.Format(SitesTable.city.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setcontact1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.contact1.ID) Then
            
                Me.contact1.Text = Me.PreviousUIData(Me.contact1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the contact TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.contact1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcontact1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.contactSpecified Then
                				
                ' If the contact is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.contact)
                            
                Me.contact1.Text = formattedValue
              
            Else 
            
                ' contact is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.contact1.Text = SitesTable.contact.Format(SitesTable.contact.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setecc_no1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.ecc_no1.ID) Then
            
                Me.ecc_no1.Text = Me.PreviousUIData(Me.ecc_no1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the ecc_no TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.ecc_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.ecc_no)
                            
                Me.ecc_no1.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no1.Text = SitesTable.ecc_no.Format(SitesTable.ecc_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setemail1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.email1.ID) Then
            
                Me.email1.Text = Me.PreviousUIData(Me.email1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the email TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.email1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.email)
                            
                Me.email1.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email1.Text = SitesTable.email.Format(SitesTable.email.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgst_no1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.gst_no1.ID) Then
            
                Me.gst_no1.Text = Me.PreviousUIData(Me.gst_no1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the gst_no TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.gst_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_noSpecified Then
                				
                ' If the gst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.gst_no)
                            
                Me.gst_no1.Text = formattedValue
              
            Else 
            
                ' gst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_no1.Text = SitesTable.gst_no.Format(SitesTable.gst_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setid_party()
            							
            ' If selection was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.id_party.ID) Then
                If Me.PreviousUIData(Me.id_party.ID) Is Nothing
                    Me.Populateid_partyDropDownList(Nothing, 100)
                Else
                    Me.Populateid_partyDropDownList(Me.PreviousUIData(Me.id_party.ID).ToString(), 100)
                End If
                Return
            End If
            
        
            ' Set the id_party DropDownList on the webpage with value from the
            ' sites database record.
            
            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.id_party is the ASP:DropDownList on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_party()
            ' and add your own code before or after the call to the MyBase function.

            
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_partySpecified Then
                            
                ' If the id_party is non-NULL, then format the value.
                ' The Format method will return the Display Foreign Key As (DFKA) value
                Me.Populateid_partyDropDownList(Me.DataSource.id_party.ToString(), 100)
                
            Else
                
                ' id_party is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
                If Me.DataSource IsNot Nothing AndAlso Me.DataSource.IsCreated Then
                    Me.Populateid_partyDropDownList(Nothing, 100)
                Else
                    Me.Populateid_partyDropDownList(SitesTable.id_party.DefaultValue, 100)
                End If
                				
            End If			
                
        End Sub
                
        Public Overridable Sub Setname1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.name1.ID) Then
            
                Me.name1.Text = Me.PreviousUIData(Me.name1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the name TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.name1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.name)
                            
                Me.name1.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name1.Text = SitesTable.name.Format(SitesTable.name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setpan_no1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.pan_no1.ID) Then
            
                Me.pan_no1.Text = Me.PreviousUIData(Me.pan_no1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the pan_no TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.pan_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.pan_no)
                            
                Me.pan_no1.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no1.Text = SitesTable.pan_no.Format(SitesTable.pan_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setparty_code1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.party_code1.ID) Then
            
                Me.party_code1.Text = Me.PreviousUIData(Me.party_code1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the party_code TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.party_code1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setparty_code1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.party_codeSpecified Then
                				
                ' If the party_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.party_code)
                            
                Me.party_code1.Text = formattedValue
              
            Else 
            
                ' party_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.party_code1.Text = SitesTable.party_code.Format(SitesTable.party_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setphone1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.phone1.ID) Then
            
                Me.phone1.Text = Me.PreviousUIData(Me.phone1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the phone TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.phone1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.phone)
                            
                Me.phone1.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone1.Text = SitesTable.phone.Format(SitesTable.phone.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setst37_no1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.st37_no1.ID) Then
            
                Me.st37_no1.Text = Me.PreviousUIData(Me.st37_no1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the st37_no TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.st37_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setst37_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.st37_noSpecified Then
                				
                ' If the st37_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.st37_no)
                            
                Me.st37_no1.Text = formattedValue
              
            Else 
            
                ' st37_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.st37_no1.Text = SitesTable.st37_no.Format(SitesTable.st37_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate_code2()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.state_code2.ID) Then
            
                Me.state_code2.Text = Me.PreviousUIData(Me.state_code2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the state_code TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.state_code2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_code2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_codeSpecified Then
                				
                ' If the state_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.state_code)
                            
                Me.state_code2.Text = formattedValue
              
            Else 
            
                ' state_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_code2.Text = SitesTable.state_code.Format(SitesTable.state_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate_name2()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.state_name2.ID) Then
            
                Me.state_name2.Text = Me.PreviousUIData(Me.state_name2.ID).ToString()
              
                Return
            End If
            
        
            ' Set the state_name TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.state_name2 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_name2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_nameSpecified Then
                				
                ' If the state_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.state_name)
                            
                Me.state_name2.Text = formattedValue
              
            Else 
            
                ' state_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_name2.Text = SitesTable.state_name.Format(SitesTable.state_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Settin_no1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.tin_no1.ID) Then
            
                Me.tin_no1.Text = Me.PreviousUIData(Me.tin_no1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the tin_no TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.tin_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.tin_no)
                            
                Me.tin_no1.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no1.Text = SitesTable.tin_no.Format(SitesTable.tin_no.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setvat_no1()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.vat_no1.ID) Then
            
                Me.vat_no1.Text = Me.PreviousUIData(Me.vat_no1.ID).ToString()
              
                Return
            End If
            
        
            ' Set the vat_no TextBox on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.vat_no1 is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setvat_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.vat_noSpecified Then
                				
                ' If the vat_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.vat_no)
                            
                Me.vat_no1.Text = formattedValue
              
            Else 
            
                ' vat_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.vat_no1.Text = SitesTable.vat_no.Format(SitesTable.vat_no.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in SitesTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As StatesRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("StatesRecordControl"), StatesRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_states = parentCtrl.DataSource.id0
              
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
              
                DirectCast(GetParentControlObject(Me, "SitesTableControl"), SitesTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "SitesTableControl"), SitesTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in SitesTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getaddress1()
            Getcity1()
            Getcontact1()
            Getecc_no1()
            Getemail1()
            Getgst_no1()
            Getid_party()
            Getname1()
            Getpan_no1()
            Getparty_code1()
            Getphone1()
            Getst37_no1()
            Getstate_code2()
            Getstate_name2()
            Gettin_no1()
            Getvat_no1()
        End Sub
        
        
        Public Overridable Sub Getaddress1()
            
            ' Retrieve the value entered by the user on the address ASP:TextBox, and
            ' save it into the address field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.address1.Text, SitesTable.address)			

                      
        End Sub
                
        Public Overridable Sub Getcity1()
            
            ' Retrieve the value entered by the user on the city ASP:TextBox, and
            ' save it into the city field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.city1.Text, SitesTable.city)			

                      
        End Sub
                
        Public Overridable Sub Getcontact1()
            
            ' Retrieve the value entered by the user on the contact ASP:TextBox, and
            ' save it into the contact field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.contact1.Text, SitesTable.contact)			

                      
        End Sub
                
        Public Overridable Sub Getecc_no1()
            
            ' Retrieve the value entered by the user on the ecc_no ASP:TextBox, and
            ' save it into the ecc_no field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.ecc_no1.Text, SitesTable.ecc_no)			

                      
        End Sub
                
        Public Overridable Sub Getemail1()
            
            ' Retrieve the value entered by the user on the email ASP:TextBox, and
            ' save it into the email field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.email1.Text, SitesTable.email)			

                      
        End Sub
                
        Public Overridable Sub Getgst_no1()
            
            ' Retrieve the value entered by the user on the gst_no ASP:TextBox, and
            ' save it into the gst_no field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.gst_no1.Text, SitesTable.gst_no)			

                      
        End Sub
                
        Public Overridable Sub Getid_party()
         
            ' Retrieve the value entered by the user on the id_party ASP:DropDownList, and
            ' save it into the id_party field in DataSource sites record.
                        
            ' Custom validation should be performed in Validate, not here.
            
            Me.DataSource.Parse(GetValueSelectedPageRequest(Me.id_party), SitesTable.id_party)				
            
        End Sub
                
        Public Overridable Sub Getname1()
            
            ' Retrieve the value entered by the user on the name ASP:TextBox, and
            ' save it into the name field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.name1.Text, SitesTable.name)			

                      
        End Sub
                
        Public Overridable Sub Getpan_no1()
            
            ' Retrieve the value entered by the user on the pan_no ASP:TextBox, and
            ' save it into the pan_no field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.pan_no1.Text, SitesTable.pan_no)			

                      
        End Sub
                
        Public Overridable Sub Getparty_code1()
            
            ' Retrieve the value entered by the user on the party_code ASP:TextBox, and
            ' save it into the party_code field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.party_code1.Text, SitesTable.party_code)			

                      
        End Sub
                
        Public Overridable Sub Getphone1()
            
            ' Retrieve the value entered by the user on the phone ASP:TextBox, and
            ' save it into the phone field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.phone1.Text, SitesTable.phone)			

                      
        End Sub
                
        Public Overridable Sub Getst37_no1()
            
            ' Retrieve the value entered by the user on the st37_no ASP:TextBox, and
            ' save it into the st37_no field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.st37_no1.Text, SitesTable.st37_no)			

                      
        End Sub
                
        Public Overridable Sub Getstate_code2()
            
            ' Retrieve the value entered by the user on the state_code ASP:TextBox, and
            ' save it into the state_code field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state_code2.Text, SitesTable.state_code)			

                      
        End Sub
                
        Public Overridable Sub Getstate_name2()
            
            ' Retrieve the value entered by the user on the state_name ASP:TextBox, and
            ' save it into the state_name field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state_name2.Text, SitesTable.state_name)			

                      
        End Sub
                
        Public Overridable Sub Gettin_no1()
            
            ' Retrieve the value entered by the user on the tin_no ASP:TextBox, and
            ' save it into the tin_no field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.tin_no1.Text, SitesTable.tin_no)			

                      
        End Sub
                
        Public Overridable Sub Getvat_no1()
            
            ' Retrieve the value entered by the user on the vat_no ASP:TextBox, and
            ' save it into the vat_no field in DataSource sites record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.vat_no1.Text, SitesTable.vat_no)			

                      
        End Sub
                
      
        ' To customize, override this method in SitesTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in SitesTableControlRow.
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
          SitesTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "SitesTableControl"), SitesTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "SitesTableControl"), SitesTableControl).ResetData = True
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
        
        

        Public Overridable Function CreateWhereClause_id_partyDropDownList() As WhereClause
            ' By default, we simply return a new WhereClause.
            ' Add additional where clauses to restrict the items shown in the dropdown list.
            						
            ' This WhereClause is for the party table.
            ' Examples:
            ' wc.iAND(PartyTable.name, BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(PartyTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            
            Dim wc As WhereClause = New WhereClause()
            Return wc
            				
        End Function
        
                
        ' Fill the id_party list.
        Protected Overridable Sub Populateid_partyDropDownList( _
                ByVal selectedValue As String, _
                ByVal maxItems As Integer)
            		  					                
            Me.id_party.Items.Clear()
            
            ' This is a four step process.
            ' 1. Setup the static list items
            ' 2. Set up the WHERE and the ORDER BY clause
            ' 3. Read a total of maxItems from the database and insert them
            ' 4. Set the selected value (insert if not already present).
                    
            ' 1. Setup the static list items
            														
            Me.id_party.Items.Add(New ListItem(Me.Page.ExpandResourceValue("{Txt:PleaseSelect}"), "--PLEASE_SELECT--"))							
                            		  			
            ' 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_id_partyDropDownList function.
            ' It is better to customize the where clause there.
            
            Dim wc As WhereClause = CreateWhereClause_id_partyDropDownList()
            ' Create the ORDER BY clause to sort based on the displayed value.			
                
      
      
            Dim orderBy As OrderBy = New OrderBy(false, true)			
        
            orderBy.Add(PartyTable.name, OrderByItem.OrderDir.Asc)				
            
            ' 3. Read a total of maxItems from the database and insert them		
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
                            If counter < maxItems AndAlso Not Me.id_party.Items.Contains(newItem) Then Me.id_party.Items.Add(newItem)
                            counter += 1
                        End If
                    Next
                    pageNum += 1
                Loop While (itemValues.Length = maxItems AndAlso counter < maxItems)
            End If
                            
                    
            ' 4. Set the selected value (insert if not already present).
              
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_party, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_party, selectedValue)Then

                ' construct a whereclause to query a record with party.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(PartyTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As PartyRecord = PartyTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = SitesTable.id_party.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_party.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
                
        End Sub
                
        ' event handler for ImageButton
        Public Overridable Sub SitesRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As SitesTableControl = DirectCast(GetParentControlObject(Me, "SitesTableControl"), SitesTableControl)
                If Not (IsNothing(tc)) Then
                    
                    Me.Visible = False
                End If
              
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
        Public Overridable Sub SitesRowEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../sites/EditSites.aspx?Sites={PK}"
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
        Public Overridable Sub SitesRowViewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../sites/ShowSites.aspx?Sites={PK}"
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
        
        Protected Overridable Sub id_party_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
            ' If a large list selector or a Quick Add link is used, the dropdown list
            ' will contain an item that was not in the original (smaller) list.  During postbacks,
            ' this new item will not be in the list - since the list is based on the original values
            ' read from the database. This function adds the value back if necessary.
            ' In addition, This dropdown can be used on make/model/year style dropdowns.  Make filters the result of Model.
            ' Mode filters the result of Year.  When users change the value of Make, Model and Year are repopulated.
            ' When this function is fire for Make or Model, we don't want the following code executed.
            ' Therefore, we check this situation using Items.Count > 1			
            If Me.id_party.Items.Count > 1 Then
                Dim selectedValue As String = MiscUtils.GetValueSelectedPageRequest(Me.id_party)
                 
            If Not selectedValue Is Nothing AndAlso _
                selectedValue.Trim <> "" AndAlso _
                Not SetSelectedValue(Me.id_party, selectedValue) AndAlso _
                Not SetSelectedDisplayText(Me.id_party, selectedValue)Then

                ' construct a whereclause to query a record with party.id = selectedValue
                Dim filter2 As CompoundFilter = New CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, Nothing)
                Dim whereClause2 As WhereClause = New WhereClause()
                filter2.AddFilter(New BaseClasses.Data.ColumnValueFilter(PartyTable.id0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, False))
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator)

                Try
                    ' Execute the query
                    Dim rc() As PartyRecord = PartyTable.GetRecords(whereClause2, New OrderBy(False, False), 0, 1)

                    ' if find a record, add it to the dropdown and set it as selected item
                    If rc IsNot Nothing AndAlso rc.Length = 1 Then
                        
                        Dim fvalue As String = SitesTable.id_party.Format(selectedValue)																			
                            
                        If fvalue Is Nothing OrElse fvalue.Trim() = "" Then fvalue = selectedValue
                        Dim item As ListItem = New ListItem(fvalue, selectedValue)
                        item.Selected = True
                        Me.id_party.Items.Add(item)
                    End If
                Catch
                End Try

            End If					
                        
            End If
          									
                
                
        End Sub
            
        Protected Overridable Sub address1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub city1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub contact1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub ecc_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub email1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub gst_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub name1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub pan_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub party_code1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub phone1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub st37_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_code2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_name2_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub tin_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub vat_no1_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
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
                Return CType(Me.ViewState("BaseSitesTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseSitesTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As SitesRecord
        Public Property DataSource() As SitesRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As SitesRecord)
            
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
        
        Public ReadOnly Property address1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property city1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "city1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property contact1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contact1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property ecc_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property email1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property gst_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property id_party() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_party"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
            
        Public ReadOnly Property id_partyAddRecordLink() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_partyAddRecordLink"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property name1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property pan_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property party_code1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "party_code1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property phone1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property SitesRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property SitesRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesRowEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRowEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesRowViewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRowViewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property st37_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "st37_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property state_code2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_code2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property state_name2() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_name2"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property tin_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property vat_no1() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_no1"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As SitesRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As SitesRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return SitesTable.GetRecord(Me.RecordUniqueId, True)
                
            End If
            
            ' Localization.
            
            Return Nothing
                
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

End Class

  

' Base class for the SitesTableControl control on the EditStates page.
' Do not modify this class. Instead override any method in SitesTableControl.
Public Class BaseSitesTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
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
              Me.SitesDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.SitesPagination.FirstPage.Click, AddressOf SitesPagination_FirstPage_Click
              
              AddHandler Me.SitesPagination.LastPage.Click, AddressOf SitesPagination_LastPage_Click
              
              AddHandler Me.SitesPagination.NextPage.Click, AddressOf SitesPagination_NextPage_Click
              
              AddHandler Me.SitesPagination.PageSizeButton.Click, AddressOf SitesPagination_PageSizeButton_Click
            
              AddHandler Me.SitesPagination.PreviousPage.Click, AddressOf SitesPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.addressLabel1.Click, AddressOf addressLabel1_Click
            
              AddHandler Me.cityLabel1.Click, AddressOf cityLabel1_Click
            
              AddHandler Me.contactLabel1.Click, AddressOf contactLabel1_Click
            
              AddHandler Me.ecc_noLabel1.Click, AddressOf ecc_noLabel1_Click
            
              AddHandler Me.emailLabel1.Click, AddressOf emailLabel1_Click
            
              AddHandler Me.gst_noLabel1.Click, AddressOf gst_noLabel1_Click
            
              AddHandler Me.id_partyLabel1.Click, AddressOf id_partyLabel1_Click
            
              AddHandler Me.nameLabel2.Click, AddressOf nameLabel2_Click
            
              AddHandler Me.pan_noLabel1.Click, AddressOf pan_noLabel1_Click
            
              AddHandler Me.party_codeLabel3.Click, AddressOf party_codeLabel3_Click
            
              AddHandler Me.phoneLabel1.Click, AddressOf phoneLabel1_Click
            
              AddHandler Me.st37_noLabel1.Click, AddressOf st37_noLabel1_Click
            
              AddHandler Me.state_codeLabel2.Click, AddressOf state_codeLabel2_Click
            
              AddHandler Me.state_nameLabel2.Click, AddressOf state_nameLabel2_Click
            
              AddHandler Me.tin_noLabel1.Click, AddressOf tin_noLabel1_Click
            
              AddHandler Me.vat_noLabel1.Click, AddressOf vat_noLabel1_Click
            
            ' Setup the button events.
          
              AddHandler Me.SitesAddButton.Click, AddressOf SitesAddButton_Click
              
              AddHandler Me.SitesDeleteButton.Click, AddressOf SitesDeleteButton_Click
              
              AddHandler Me.SitesEditButton.Click, AddressOf SitesEditButton_Click
              
              AddHandler Me.SitesResetButton.Click, AddressOf SitesResetButton_Click
              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(SitesRecord)), SitesRecord())
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
                
                Me.TotalRecords = SitesTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(SitesRecord)), SitesRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As SitesTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(SitesRecord)), SitesRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = SitesTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.SitesToggleAll.Checked = False
            

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
        
            SetaddressLabel1()
            SetcityLabel1()
            SetcontactLabel1()
            Setecc_noLabel1()
            SetemailLabel1()
            Setgst_noLabel1()
            Setid_partyLabel1()
            SetnameLabel2()
            Setpan_noLabel1()
            Setparty_codeLabel3()
            SetphoneLabel1()
            Setst37_noLabel1()
            Setstate_codeLabel2()
            Setstate_nameLabel2()
            Settin_noLabel1()
            Setvat_noLabel1()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("SitesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As SitesTableControlRow = DirectCast(repItem.FindControl("SitesTableControlRow"), SitesTableControlRow) 
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
            
            SetaddressLabel1()
            SetcityLabel1()
            SetcontactLabel1()
            Setecc_noLabel1()
            SetemailLabel1()
            Setgst_noLabel1()
            Setid_partyLabel1()
            SetnameLabel2()
            Setpan_noLabel1()
            Setparty_codeLabel3()
            SetphoneLabel1()
            Setst37_noLabel1()
            Setstate_codeLabel2()
            Setstate_nameLabel2()
            Settin_noLabel1()
            Setvat_noLabel1()
      End Sub

      
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(SitesTable.id_party, Me.DataSource)
          
          End Sub
        
      
        Public Overridable Sub RegisterPostback()
        
        
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

            ' Bind the buttons for SitesTableControl pagination.
        
            Me.SitesPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.SitesPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.SitesPagination.LastPage.Enabled = False
            End If
          
            Me.SitesPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.SitesPagination.NextPage.Enabled = False
            End If
          
            Me.SitesPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.SitesPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.SitesPagination.CurrentPage.Text = "0"
            End If
            Me.SitesPagination.PageSize.Text = Me.PageSize.ToString()
            Me.SitesPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.SitesPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As SitesTableControlRow
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
            SitesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim statesRecordControlObj As StatesRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "StatesRecordControl"), StatesRecordControl)
              
                If (Not IsNothing(statesRecordControlObj) AndAlso Not IsNothing(statesRecordControlObj.GetRecord()) AndAlso Not IsNothing(statesRecordControlObj.GetRecord().id0))
                    wc.iAND(SitesTable.id_states, BaseFilter.ComparisonOperator.EqualsTo, statesRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(SitesTable.id_states.InternalName, statesRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("SitesTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            SitesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInStatesRecordControl as String = DirectCast(HttpContext.Current.Session("SitesTableControlWhereClause"), String)
            
            If Not selectedRecordInStatesRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInStatesRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInStatesRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(SitesTable.id_states) Then
            wc.iAND(SitesTable.id_states, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(SitesTable.id_states).ToString())
       End If
      
            End If
          
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Return wc
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
        
            If Me.SitesPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.SitesPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("SitesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As SitesTableControlRow = DirectCast(repItem.FindControl("SitesTableControlRow"), SitesTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As SitesRecord = New SitesRecord()
        
                        If recControl.address1.Text <> "" Then
                            rec.Parse(recControl.address1.Text, SitesTable.address)
                        End If
                        If recControl.city1.Text <> "" Then
                            rec.Parse(recControl.city1.Text, SitesTable.city)
                        End If
                        If recControl.contact1.Text <> "" Then
                            rec.Parse(recControl.contact1.Text, SitesTable.contact)
                        End If
                        If recControl.ecc_no1.Text <> "" Then
                            rec.Parse(recControl.ecc_no1.Text, SitesTable.ecc_no)
                        End If
                        If recControl.email1.Text <> "" Then
                            rec.Parse(recControl.email1.Text, SitesTable.email)
                        End If
                        If recControl.gst_no1.Text <> "" Then
                            rec.Parse(recControl.gst_no1.Text, SitesTable.gst_no)
                        End If
                        If MiscUtils.IsValueSelected(recControl.id_party) Then
                            rec.Parse(recControl.id_party.SelectedItem.Value, SitesTable.id_party)
                        End If
                        If recControl.name1.Text <> "" Then
                            rec.Parse(recControl.name1.Text, SitesTable.name)
                        End If
                        If recControl.pan_no1.Text <> "" Then
                            rec.Parse(recControl.pan_no1.Text, SitesTable.pan_no)
                        End If
                        If recControl.party_code1.Text <> "" Then
                            rec.Parse(recControl.party_code1.Text, SitesTable.party_code)
                        End If
                        If recControl.phone1.Text <> "" Then
                            rec.Parse(recControl.phone1.Text, SitesTable.phone)
                        End If
                        If recControl.st37_no1.Text <> "" Then
                            rec.Parse(recControl.st37_no1.Text, SitesTable.st37_no)
                        End If
                        If recControl.state_code2.Text <> "" Then
                            rec.Parse(recControl.state_code2.Text, SitesTable.state_code)
                        End If
                        If recControl.state_name2.Text <> "" Then
                            rec.Parse(recControl.state_name2.Text, SitesTable.state_name)
                        End If
                        If recControl.tin_no1.Text <> "" Then
                            rec.Parse(recControl.tin_no1.Text, SitesTable.tin_no)
                        End If
                        If recControl.vat_no1.Text <> "" Then
                            rec.Parse(recControl.vat_no1.Text, SitesTable.vat_no)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New SitesRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(SitesRecord)), SitesRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As SitesTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As SitesTableControlRow) As Boolean
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
        
        Public Overridable Sub SetaddressLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetcityLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetcontactLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setecc_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setid_partyLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SetnameLabel2()
            
                    
        End Sub
                
        Public Overridable Sub Setpan_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setparty_codeLabel3()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setst37_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setstate_codeLabel2()
            
                    
        End Sub
                
        Public Overridable Sub Setstate_nameLabel2()
            
                    
        End Sub
                
        Public Overridable Sub Settin_noLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setvat_noLabel1()
            
                    
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
                    Dim added As Boolean = Me.AddNewRecord > 0
                    Me.LoadData()
                    Me.DataBind()
                    
                    If added Then
                        Me.SetFocusToAddedRow()
                    End If
                    
                End If
                				
            Catch ex As Exception
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
        End Sub
        
        'this function sets focus to the first editable element in the new added row in the editable table	
        Protected Overridable Sub SetFocusToAddedRow()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("SitesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
			    'Load scripts to table rows
                Me.Page.LoadFocusScripts(repItem)
                Dim recControl As SitesTableControlRow = DirectCast(repItem.FindControl("SitesTableControlRow"), SitesTableControlRow)
                If recControl.IsNewRecord Then
                    For Each field As Control In recControl.Controls
                        If field.Visible AndAlso Me.Page.IsControlEditable(field, False) Then
						    'set focus on the first editable field in the new row
						    field.Focus()
                            Dim updPan As UpdatePanel = DirectCast(Me.Page.FindControlRecursively("UpdatePanel1"), UpdatePanel)
                            If Not updPan Is Nothing Then updPan.Update()
                            Return
                        End If
                    Next
                    Return
                End If
            Next
        End Sub
        
        
        Protected Overrides Sub SaveControlsToSession()
            MyBase.SaveControlsToSession()

            ' Save filter controls to values to session.
        
            
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
          
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("SitesTableControl_OrderBy"), String)
            
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
                Me.ViewState("SitesTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub SitesPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub SitesPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub SitesPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub SitesPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.SitesPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.SitesPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub SitesPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub addressLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by address when clicked.
              
            ' Get previous sorting state for address.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.address)
            If sd Is Nothing Then
                ' First time sort, so add sort order for address.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.address, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by address, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub cityLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by city when clicked.
              
            ' Get previous sorting state for city.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.city)
            If sd Is Nothing Then
                ' First time sort, so add sort order for city.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.city, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by city, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub contactLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by contact when clicked.
              
            ' Get previous sorting state for contact.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.contact)
            If sd Is Nothing Then
                ' First time sort, so add sort order for contact.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.contact, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by contact, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub ecc_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by ecc_no when clicked.
              
            ' Get previous sorting state for ecc_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.ecc_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for ecc_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.ecc_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by ecc_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub emailLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by email when clicked.
              
            ' Get previous sorting state for email.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.email)
            If sd Is Nothing Then
                ' First time sort, so add sort order for email.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.email, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by email, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_no when clicked.
              
            ' Get previous sorting state for gst_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.gst_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.gst_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_no, so just reverse.
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.id_party)
            If sd Is Nothing Then
                ' First time sort, so add sort order for id_party.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.id_party, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by id_party, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub nameLabel2_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by name when clicked.
              
            ' Get previous sorting state for name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by name, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub pan_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by pan_no when clicked.
              
            ' Get previous sorting state for pan_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.pan_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for pan_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.pan_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by pan_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub party_codeLabel3_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by party_code when clicked.
              
            ' Get previous sorting state for party_code.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.party_code)
            If sd Is Nothing Then
                ' First time sort, so add sort order for party_code.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.party_code, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by party_code, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub phoneLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by phone when clicked.
              
            ' Get previous sorting state for phone.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.phone)
            If sd Is Nothing Then
                ' First time sort, so add sort order for phone.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.phone, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by phone, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub st37_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by st37_no when clicked.
              
            ' Get previous sorting state for st37_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.st37_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for st37_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.st37_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by st37_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub state_codeLabel2_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by state_code when clicked.
              
            ' Get previous sorting state for state_code.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.state_code)
            If sd Is Nothing Then
                ' First time sort, so add sort order for state_code.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.state_code, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by state_code, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub state_nameLabel2_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by state_name when clicked.
              
            ' Get previous sorting state for state_name.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.state_name)
            If sd Is Nothing Then
                ' First time sort, so add sort order for state_name.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.state_name, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by state_name, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub tin_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by tin_no when clicked.
              
            ' Get previous sorting state for tin_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.tin_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for tin_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.tin_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by tin_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub vat_noLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by vat_no when clicked.
              
            ' Get previous sorting state for vat_no.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(SitesTable.vat_no)
            If sd Is Nothing Then
                ' First time sort, so add sort order for vat_no.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(SitesTable.vat_no, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by vat_no, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub SitesAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            Me.AddNewRecord = 1
            Me.DataChanged = True
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
        Public Overridable Sub SitesDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Me.DeleteSelectedRecords(True)
          
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
        Public Overridable Sub SitesEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../sites/EditSites.aspx?Sites={PK}"
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
        Public Overridable Sub SitesResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
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
        
        Private _DataSource() As SitesRecord = Nothing
        Public Property DataSource() As SitesRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As SitesRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property addressLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "addressLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property cityLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cityLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property contactLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contactLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property ecc_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property emailLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "emailLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property id_partyLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_partyLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property nameLabel2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "nameLabel2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property pan_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property party_codeLabel3() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "party_codeLabel3"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property phoneLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phoneLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property SitesResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesToggleAll"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property st37_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "st37_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property state_codeLabel2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_codeLabel2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property state_nameLabel2() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_nameLabel2"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property tin_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_noLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property vat_noLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_noLabel1"), System.Web.UI.WebControls.LinkButton)
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
                Dim recCtl As SitesTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As SitesRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As SitesTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.SitesRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As SitesTableControlRow
            Dim selectedList() As SitesTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As SitesTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As SitesTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.SitesRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(SitesTableControlRow)), SitesTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As SitesTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As SitesTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.SitesRecordRowSelection.Checked = False
                
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

        Public Function GetRecordControls() As SitesTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("SitesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As SitesTableControlRow = DirectCast(repItem.FindControl("SitesTableControlRow"), SitesTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(SitesTableControlRow)), SitesTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the StatesRecordControl control on the EditStates page.
' Do not modify this class. Instead override any method in StatesRecordControl.
Public Class BaseStatesRecordControl
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in StatesRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
        
        End Sub

        '  To customize, override this method in StatesRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
              ' Setup the pagination events.	  
         
              ' Register the event handlers.
          
              AddHandler Me.state_code.TextChanged, AddressOf state_code_TextChanged
            
              AddHandler Me.state_name.TextChanged, AddressOf state_name_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource states record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = StatesTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "StatesRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New StatesRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As StatesRecord = StatesTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = StatesTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in StatesRecordControl.
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
        
            Setstate_code()
            Setstate_codeLabel()
            Setstate_name()
            Setstate_nameLabel()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        Dim recPartyTableControl as PartyTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "PartyTableControl"), PartyTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recPartyTableControl.ResetControl()
            End IF
        
        recPartyTableControl.LoadData()
        recPartyTableControl.DataBind()
        
        Dim recSitesTableControl as SitesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SitesTableControl"), SitesTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recSitesTableControl.ResetControl()
            End IF
        
        recSitesTableControl.LoadData()
        recSitesTableControl.DataBind()
              
        End Sub
        
        
        Public Overridable Sub Setstate_code()
            
        
            ' Set the state_code TextBox on the webpage with value from the
            ' states database record.

            ' Me.DataSource is the states record retrieved from the database.
            ' Me.state_code is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_codeSpecified Then
                				
                ' If the state_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(StatesTable.state_code)
                            
                Me.state_code.Text = formattedValue
              
            Else 
            
                ' state_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_code.Text = StatesTable.state_code.Format(StatesTable.state_code.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate_name()
            
        
            ' Set the state_name TextBox on the webpage with value from the
            ' states database record.

            ' Me.DataSource is the states record retrieved from the database.
            ' Me.state_name is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_nameSpecified Then
                				
                ' If the state_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(StatesTable.state_name)
                            
                Me.state_name.Text = formattedValue
              
            Else 
            
                ' state_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_name.Text = StatesTable.state_name.Format(StatesTable.state_name.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setstate_codeLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setstate_nameLabel()
            
                    
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

      
        
        ' To customize, override this method in StatesRecordControl.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "StatesRecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        Dim recPartyTableControl as PartyTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "PartyTableControl"), PartyTableControl)
        recPartyTableControl.SaveData()
        
        Dim recSitesTableControl as SitesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "SitesTableControl"), SitesTableControl)
        recSitesTableControl.SaveData()
        
        End Sub

        ' To customize, override this method in StatesRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getstate_code()
            Getstate_name()
        End Sub
        
        
        Public Overridable Sub Getstate_code()
            
            ' Retrieve the value entered by the user on the state_code ASP:TextBox, and
            ' save it into the state_code field in DataSource states record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state_code.Text, StatesTable.state_code)			

                      
        End Sub
                
        Public Overridable Sub Getstate_name()
            
            ' Retrieve the value entered by the user on the state_name ASP:TextBox, and
            ' save it into the state_name field in DataSource states record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.state_name.Text, StatesTable.state_name)			

                      
        End Sub
                
      
        ' To customize, override this method in StatesRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Dim wc As WhereClause
            StatesTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
            Dim recId As String = Me.Page.Request.QueryString.Item("States")
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ServelInvocing").Replace("{URL}", "States"))
            End If
            HttpContext.Current.Session("QueryString in EditStates") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(StatesTable.id0, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(StatesTable.id0).ToString())
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(StatesTable.id0, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            StatesTable.Instance.InnerFilter = Nothing
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
        

        ' To customize, override this method in StatesRecordControl.
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
          StatesTable.DeleteRecord(pkValue)
          
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
            
        Protected Overridable Sub state_code_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub state_name_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
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
                Return CType(Me.ViewState("BaseStatesRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseStatesRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As StatesRecord
        Public Property DataSource() As StatesRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As StatesRecord)
            
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
        
        Public ReadOnly Property state_code() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_code"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property state_codeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_codeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property state_name() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_name"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property state_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property StatesTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "StatesTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As StatesRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As StatesRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return StatesTable.GetRecord(Me.RecordUniqueId, True)
                
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

  