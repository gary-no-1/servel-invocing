
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' ShowStates.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.ShowStates

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
    
    
' Base class for the PartyTableControlRow control on the ShowStates page.
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
          
              AddHandler Me.PartyRowCopyButton.Click, AddressOf PartyRowCopyButton_Click
              
              AddHandler Me.PartyRowDeleteButton.Click, AddressOf PartyRowDeleteButton_Click
              
              AddHandler Me.PartyRowEditButton.Click, AddressOf PartyRowEditButton_Click
              
              AddHandler Me.PartyRowViewButton.Click, AddressOf PartyRowViewButton_Click
              
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
            
        
            ' Set the address Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.address is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.address)
                            
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
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ServelInvocing.Business.PartyTable, ServelInvocing.Business\"",\""" _
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
        
                Me.address.Text = PartyTable.address.Format(PartyTable.address.DefaultValue)
                        		
                End If
                 
            ' If the address is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.address.Text Is Nothing _
                OrElse Me.address.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.address.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcity()
            
        
            ' Set the city Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.city is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcity()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.citySpecified Then
                				
                ' If the city is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.city)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.city.Text = formattedValue
              
            Else 
            
                ' city is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.city.Text = PartyTable.city.Format(PartyTable.city.DefaultValue)
                        		
                End If
                 
            ' If the city is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.city.Text Is Nothing _
                OrElse Me.city.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.city.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcontact()
            
        
            ' Set the contact Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.contact is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcontact()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.contactSpecified Then
                				
                ' If the contact is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.contact)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.contact.Text = formattedValue
              
            Else 
            
                ' contact is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.contact.Text = PartyTable.contact.Format(PartyTable.contact.DefaultValue)
                        		
                End If
                 
            ' If the contact is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.contact.Text Is Nothing _
                OrElse Me.contact.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.contact.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcst_date()
            
        
            ' Set the cst_date Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.cst_date is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcst_date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cst_dateSpecified Then
                				
                ' If the cst_date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.cst_date, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cst_date.Text = formattedValue
              
            Else 
            
                ' cst_date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cst_date.Text = PartyTable.cst_date.Format(PartyTable.cst_date.DefaultValue, "d")
                        		
                End If
                 
            ' If the cst_date is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cst_date.Text Is Nothing _
                OrElse Me.cst_date.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cst_date.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcst_no()
            
        
            ' Set the cst_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.cst_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.cst_noSpecified Then
                				
                ' If the cst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.cst_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.cst_no.Text = formattedValue
              
            Else 
            
                ' cst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.cst_no.Text = PartyTable.cst_no.Format(PartyTable.cst_no.DefaultValue)
                        		
                End If
                 
            ' If the cst_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.cst_no.Text Is Nothing _
                OrElse Me.cst_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.cst_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setecc_no()
            
        
            ' Set the ecc_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.ecc_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.ecc_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ecc_no.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no.Text = PartyTable.ecc_no.Format(PartyTable.ecc_no.DefaultValue)
                        		
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
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.email is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.email)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.email.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email.Text = PartyTable.email.Format(PartyTable.email.DefaultValue)
                        		
                End If
                 
            ' If the email is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.email.Text Is Nothing _
                OrElse Me.email.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.email.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_no()
            
        
            ' Set the gst_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.gst_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_noSpecified Then
                				
                ' If the gst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.gst_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.gst_no.Text = formattedValue
              
            Else 
            
                ' gst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_no.Text = PartyTable.gst_no.Format(PartyTable.gst_no.DefaultValue)
                        		
                End If
                 
            ' If the gst_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_no.Text Is Nothing _
                OrElse Me.gst_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setlst_date()
            
        
            ' Set the lst_date Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.lst_date is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setlst_date()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.lst_dateSpecified Then
                				
                ' If the lst_date is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.lst_date, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.lst_date.Text = formattedValue
              
            Else 
            
                ' lst_date is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.lst_date.Text = PartyTable.lst_date.Format(PartyTable.lst_date.DefaultValue, "d")
                        		
                End If
                 
            ' If the lst_date is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.lst_date.Text Is Nothing _
                OrElse Me.lst_date.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.lst_date.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setlst_no()
            
        
            ' Set the lst_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.lst_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setlst_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.lst_noSpecified Then
                				
                ' If the lst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.lst_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.lst_no.Text = formattedValue
              
            Else 
            
                ' lst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.lst_no.Text = PartyTable.lst_no.Format(PartyTable.lst_no.DefaultValue)
                        		
                End If
                 
            ' If the lst_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.lst_no.Text Is Nothing _
                OrElse Me.lst_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.lst_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setname()
            
        
            ' Set the name Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.name.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name.Text = PartyTable.name.Format(PartyTable.name.DefaultValue)
                        		
                End If
                 
            ' If the name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.name.Text Is Nothing _
                OrElse Me.name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.name.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpan_no()
            
        
            ' Set the pan_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.pan_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.pan_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pan_no.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no.Text = PartyTable.pan_no.Format(PartyTable.pan_no.DefaultValue)
                        		
                End If
                 
            ' If the pan_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pan_no.Text Is Nothing _
                OrElse Me.pan_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pan_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setparty_code()
            
        
            ' Set the party_code Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.party_code is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setparty_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.party_codeSpecified Then
                				
                ' If the party_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.party_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.party_code.Text = formattedValue
              
            Else 
            
                ' party_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.party_code.Text = PartyTable.party_code.Format(PartyTable.party_code.DefaultValue)
                        		
                End If
                 
            ' If the party_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.party_code.Text Is Nothing _
                OrElse Me.party_code.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.party_code.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setphone()
            
        
            ' Set the phone Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.phone is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.phone)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.phone.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone.Text = PartyTable.phone.Format(PartyTable.phone.DefaultValue)
                        		
                End If
                 
            ' If the phone is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.phone.Text Is Nothing _
                OrElse Me.phone.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.phone.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setst37_no()
            
        
            ' Set the st37_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.st37_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setst37_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.st37_noSpecified Then
                				
                ' If the st37_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.st37_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.st37_no.Text = formattedValue
              
            Else 
            
                ' st37_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.st37_no.Text = PartyTable.st37_no.Format(PartyTable.st37_no.DefaultValue)
                        		
                End If
                 
            ' If the st37_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.st37_no.Text Is Nothing _
                OrElse Me.st37_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.st37_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setstate_code1()
            
        
            ' Set the state_code Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.state_code1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_code1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_codeSpecified Then
                				
                ' If the state_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.state_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state_code1.Text = formattedValue
              
            Else 
            
                ' state_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_code1.Text = PartyTable.state_code.Format(PartyTable.state_code.DefaultValue)
                        		
                End If
                 
            ' If the state_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state_code1.Text Is Nothing _
                OrElse Me.state_code1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state_code1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setstate_name1()
            
        
            ' Set the state_name Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.state_name1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_name1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_nameSpecified Then
                				
                ' If the state_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.state_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state_name1.Text = formattedValue
              
            Else 
            
                ' state_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_name1.Text = PartyTable.state_name.Format(PartyTable.state_name.DefaultValue)
                        		
                End If
                 
            ' If the state_name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state_name1.Text Is Nothing _
                OrElse Me.state_name1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state_name1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settin_no()
            
        
            ' Set the tin_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.tin_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.tin_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = PartyTable.tin_no.Format(PartyTable.tin_no.DefaultValue)
                        		
                End If
                 
            ' If the tin_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tin_no.Text Is Nothing _
                OrElse Me.tin_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tin_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setvat_no()
            
        
            ' Set the vat_no Literal on the webpage with value from the
            ' party database record.

            ' Me.DataSource is the party record retrieved from the database.
            ' Me.vat_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setvat_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.vat_noSpecified Then
                				
                ' If the vat_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(PartyTable.vat_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.vat_no.Text = formattedValue
              
            Else 
            
                ' vat_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.vat_no.Text = PartyTable.vat_no.Format(PartyTable.vat_no.DefaultValue)
                        		
                End If
                 
            ' If the vat_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.vat_no.Text Is Nothing _
                OrElse Me.vat_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.vat_no.Text = "&nbsp;"
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
            
        End Sub
                
        Public Overridable Sub Getcity()
            
        End Sub
                
        Public Overridable Sub Getcontact()
            
        End Sub
                
        Public Overridable Sub Getcst_date()
            
        End Sub
                
        Public Overridable Sub Getcst_no()
            
        End Sub
                
        Public Overridable Sub Getecc_no()
            
        End Sub
                
        Public Overridable Sub Getemail()
            
        End Sub
                
        Public Overridable Sub Getgst_no()
            
        End Sub
                
        Public Overridable Sub Getlst_date()
            
        End Sub
                
        Public Overridable Sub Getlst_no()
            
        End Sub
                
        Public Overridable Sub Getname()
            
        End Sub
                
        Public Overridable Sub Getpan_no()
            
        End Sub
                
        Public Overridable Sub Getparty_code()
            
        End Sub
                
        Public Overridable Sub Getphone()
            
        End Sub
                
        Public Overridable Sub Getst37_no()
            
        End Sub
                
        Public Overridable Sub Getstate_code1()
            
        End Sub
                
        Public Overridable Sub Getstate_name1()
            
        End Sub
                
        Public Overridable Sub Gettin_no()
            
        End Sub
                
        Public Overridable Sub Getvat_no()
            
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
        Public Overridable Sub PartyRowCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/AddParty.aspx?Party={PK}"
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
        Public Overridable Sub PartyRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public ReadOnly Property address() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property city() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "city"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property contact() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contact"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property cst_date() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_date"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property cst_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "cst_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ecc_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property email() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property lst_date() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lst_date"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property lst_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "lst_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property pan_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property party_code() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "party_code"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property PartyRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property PartyRowCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRowCopyButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property phone() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property st37_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "st37_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property state_code1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_code1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property state_name1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_name1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tin_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property vat_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_no"), System.Web.UI.WebControls.Literal)
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

  

' Base class for the PartyTableControl control on the ShowStates page.
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
          
              AddHandler Me.PartyCopyButton.Click, AddressOf PartyCopyButton_Click
              
              AddHandler Me.PartyDeleteButton.Click, AddressOf PartyDeleteButton_Click
              
              AddHandler Me.PartyEditButton.Click, AddressOf PartyEditButton_Click
              
              AddHandler Me.PartyExportCSVButton.Click, AddressOf PartyExportCSVButton_Click
              
              AddHandler Me.PartyExportExcelButton.Click, AddressOf PartyExportExcelButton_Click
              
              AddHandler Me.PartyImportButton.Click, AddressOf PartyImportButton_Click
              
              AddHandler Me.PartyNewButton.Click, AddressOf PartyNewButton_Click
              
              AddHandler Me.PartyPDFButton.Click, AddressOf PartyPDFButton_Click
              
              AddHandler Me.PartyRefreshButton.Click, AddressOf PartyRefreshButton_Click
              
              AddHandler Me.PartyResetButton.Click, AddressOf PartyResetButton_Click
              
              AddHandler Me.PartyWordButton.Click, AddressOf PartyWordButton_Click
              
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
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PartyExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PartyExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PartyPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"PartyWordButton"))
                        
        
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
        Public Overridable Sub PartyCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/AddParty.aspx?Party={PK}"
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
        Public Overridable Sub PartyDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub PartyExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       PartyTable.party_code, _ 
             PartyTable.name, _ 
             PartyTable.address, _ 
             PartyTable.city, _ 
             PartyTable.contact, _ 
             PartyTable.phone, _ 
             PartyTable.email, _ 
             PartyTable.lst_no, _ 
             PartyTable.cst_no, _ 
             PartyTable.lst_date, _ 
             PartyTable.cst_date, _ 
             PartyTable.vat_no, _ 
             PartyTable.pan_no, _ 
             PartyTable.ecc_no, _ 
             PartyTable.st37_no, _ 
             PartyTable.tin_no, _ 
             PartyTable.gst_no, _ 
             PartyTable.state_code, _ 
             PartyTable.state_name, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(PartyTable.Instance, wc, orderBy, columns)
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
        Public Overridable Sub PartyExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(PartyTable.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(PartyTable.party_code, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.name, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.address, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.city, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.contact, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.phone, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.email, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.lst_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.cst_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.lst_date, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.cst_date, "Short Date"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.vat_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.pan_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.ecc_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.st37_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.tin_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.gst_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.state_code, "Default"))
             excelReport.AddColumn(New ExcelColumn(PartyTable.state_name, "Default"))

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
        Public Overridable Sub PartyImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/SelectFileToImport.aspx?TableName=Party"
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
        Public Overridable Sub PartyNewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/AddParty.aspx"
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
        Public Overridable Sub PartyPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowStates.PartyPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "party"
                ' If ShowStates.PartyPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(PartyTable.party_code.Name, ReportEnum.Align.Left, "${party_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(PartyTable.name.Name, ReportEnum.Align.Left, "${name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.address.Name, ReportEnum.Align.Left, "${address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.city.Name, ReportEnum.Align.Left, "${city}", ReportEnum.Align.Left, 28)
                 report.AddColumn(PartyTable.contact.Name, ReportEnum.Align.Left, "${contact}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.phone.Name, ReportEnum.Align.Left, "${phone}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.email.Name, ReportEnum.Align.Left, "${email}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.lst_no.Name, ReportEnum.Align.Left, "${lst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.cst_no.Name, ReportEnum.Align.Left, "${cst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.lst_date.Name, ReportEnum.Align.Left, "${lst_date}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.cst_date.Name, ReportEnum.Align.Left, "${cst_date}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.vat_no.Name, ReportEnum.Align.Left, "${vat_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.pan_no.Name, ReportEnum.Align.Left, "${pan_no}", ReportEnum.Align.Left, 15)
                 report.AddColumn(PartyTable.ecc_no.Name, ReportEnum.Align.Left, "${ecc_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.st37_no.Name, ReportEnum.Align.Left, "${st37_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.tin_no.Name, ReportEnum.Align.Left, "${tin_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.gst_no.Name, ReportEnum.Align.Left, "${gst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.state_code.Name, ReportEnum.Align.Left, "${state_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(PartyTable.state_name.Name, ReportEnum.Align.Left, "${state_name}", ReportEnum.Align.Left, 24)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = PartyTable.GetRecordCount(whereClause)
                Dim columns As ColumnList = PartyTable.GetColumnList()
                Dim records As PartyRecord() = Nothing
            
                Do 
                    
                    records = PartyTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As PartyRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${party_code}", record.Format(PartyTable.party_code), ReportEnum.Align.Left, 100)
                             report.AddData("${name}", record.Format(PartyTable.name), ReportEnum.Align.Left, 100)
                             report.AddData("${address}", record.Format(PartyTable.address), ReportEnum.Align.Left, 100)
                             report.AddData("${city}", record.Format(PartyTable.city), ReportEnum.Align.Left, 100)
                             report.AddData("${contact}", record.Format(PartyTable.contact), ReportEnum.Align.Left, 100)
                             report.AddData("${phone}", record.Format(PartyTable.phone), ReportEnum.Align.Left, 100)
                             report.AddData("${email}", record.Format(PartyTable.email), ReportEnum.Align.Left, 100)
                             report.AddData("${lst_no}", record.Format(PartyTable.lst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${cst_no}", record.Format(PartyTable.cst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${lst_date}", record.Format(PartyTable.lst_date), ReportEnum.Align.Left, 100)
                             report.AddData("${cst_date}", record.Format(PartyTable.cst_date), ReportEnum.Align.Left, 100)
                             report.AddData("${vat_no}", record.Format(PartyTable.vat_no), ReportEnum.Align.Left, 100)
                             report.AddData("${pan_no}", record.Format(PartyTable.pan_no), ReportEnum.Align.Left, 100)
                             report.AddData("${ecc_no}", record.Format(PartyTable.ecc_no), ReportEnum.Align.Left, 100)
                             report.AddData("${st37_no}", record.Format(PartyTable.st37_no), ReportEnum.Align.Left, 100)
                             report.AddData("${tin_no}", record.Format(PartyTable.tin_no), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_no}", record.Format(PartyTable.gst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${state_code}", record.Format(PartyTable.state_code), ReportEnum.Align.Left, 100)
                             report.AddData("${state_name}", record.Format(PartyTable.state_name), ReportEnum.Align.Left, 100)

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
        Public Overridable Sub PartyRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim PartyTableControlObj as PartyTableControl = DirectCast(Me.Page.FindControlRecursively("PartyTableControl"), PartyTableControl)
            PartyTableControlObj.ResetData = True
                        
            PartyTableControlObj.RemoveFromSession(PartyTableControlObj, "DeletedRecordIds")
            PartyTableControlObj.DeletedRecordIds = Nothing
            
            Dim SitesTableControlObj as SitesTableControl = DirectCast(Me.Page.FindControlRecursively("SitesTableControl"), SitesTableControl)
            SitesTableControlObj.ResetData = True
                        
            SitesTableControlObj.RemoveFromSession(SitesTableControlObj, "DeletedRecordIds")
            SitesTableControlObj.DeletedRecordIds = Nothing
            
            Dim StatesRecordControlObj as StatesRecordControl = DirectCast(Me.Page.FindControlRecursively("StatesRecordControl"), StatesRecordControl)
            StatesRecordControlObj.ResetData = True
                        
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
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
        
        ' event handler for ImageButton
        Public Overridable Sub PartyWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowStates.PartyWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "party"
                ' If ShowStates.PartyWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(PartyTable.party_code.Name, ReportEnum.Align.Left, "${party_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(PartyTable.name.Name, ReportEnum.Align.Left, "${name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.address.Name, ReportEnum.Align.Left, "${address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.city.Name, ReportEnum.Align.Left, "${city}", ReportEnum.Align.Left, 28)
                 report.AddColumn(PartyTable.contact.Name, ReportEnum.Align.Left, "${contact}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.phone.Name, ReportEnum.Align.Left, "${phone}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.email.Name, ReportEnum.Align.Left, "${email}", ReportEnum.Align.Left, 30)
                 report.AddColumn(PartyTable.lst_no.Name, ReportEnum.Align.Left, "${lst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.cst_no.Name, ReportEnum.Align.Left, "${cst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.lst_date.Name, ReportEnum.Align.Left, "${lst_date}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.cst_date.Name, ReportEnum.Align.Left, "${cst_date}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.vat_no.Name, ReportEnum.Align.Left, "${vat_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.pan_no.Name, ReportEnum.Align.Left, "${pan_no}", ReportEnum.Align.Left, 15)
                 report.AddColumn(PartyTable.ecc_no.Name, ReportEnum.Align.Left, "${ecc_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.st37_no.Name, ReportEnum.Align.Left, "${st37_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.tin_no.Name, ReportEnum.Align.Left, "${tin_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.gst_no.Name, ReportEnum.Align.Left, "${gst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(PartyTable.state_code.Name, ReportEnum.Align.Left, "${state_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(PartyTable.state_name.Name, ReportEnum.Align.Left, "${state_name}", ReportEnum.Align.Left, 24)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = PartyTable.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = PartyTable.GetColumnList()
                Dim records As PartyRecord() = Nothing
                Do
                    records = PartyTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As PartyRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${party_code}", record.Format(PartyTable.party_code), ReportEnum.Align.Left, 100)
                             report.AddData("${name}", record.Format(PartyTable.name), ReportEnum.Align.Left, 100)
                             report.AddData("${address}", record.Format(PartyTable.address), ReportEnum.Align.Left, 100)
                             report.AddData("${city}", record.Format(PartyTable.city), ReportEnum.Align.Left, 100)
                             report.AddData("${contact}", record.Format(PartyTable.contact), ReportEnum.Align.Left, 100)
                             report.AddData("${phone}", record.Format(PartyTable.phone), ReportEnum.Align.Left, 100)
                             report.AddData("${email}", record.Format(PartyTable.email), ReportEnum.Align.Left, 100)
                             report.AddData("${lst_no}", record.Format(PartyTable.lst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${cst_no}", record.Format(PartyTable.cst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${lst_date}", record.Format(PartyTable.lst_date), ReportEnum.Align.Left, 100)
                             report.AddData("${cst_date}", record.Format(PartyTable.cst_date), ReportEnum.Align.Left, 100)
                             report.AddData("${vat_no}", record.Format(PartyTable.vat_no), ReportEnum.Align.Left, 100)
                             report.AddData("${pan_no}", record.Format(PartyTable.pan_no), ReportEnum.Align.Left, 100)
                             report.AddData("${ecc_no}", record.Format(PartyTable.ecc_no), ReportEnum.Align.Left, 100)
                             report.AddData("${st37_no}", record.Format(PartyTable.st37_no), ReportEnum.Align.Left, 100)
                             report.AddData("${tin_no}", record.Format(PartyTable.tin_no), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_no}", record.Format(PartyTable.gst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${state_code}", record.Format(PartyTable.state_code), ReportEnum.Align.Left, 100)
                             report.AddData("${state_name}", record.Format(PartyTable.state_name), ReportEnum.Align.Left, 100)

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
        
        Public ReadOnly Property PartyCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyCopyButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property PartyExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyNewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyNewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property PartyPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property PartyRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyRefreshButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property PartyWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "PartyWordButton"), System.Web.UI.WebControls.ImageButton)
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

  
' Base class for the SitesTableControlRow control on the ShowStates page.
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
          
              AddHandler Me.SitesRowCopyButton.Click, AddressOf SitesRowCopyButton_Click
              
              AddHandler Me.SitesRowDeleteButton.Click, AddressOf SitesRowDeleteButton_Click
              
              AddHandler Me.SitesRowEditButton.Click, AddressOf SitesRowEditButton_Click
              
              AddHandler Me.SitesRowViewButton.Click, AddressOf SitesRowViewButton_Click
              
              AddHandler Me.id_party.Click, AddressOf id_party_Click
            
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
            
        
            ' Set the address Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.address1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setaddress1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.addressSpecified Then
                				
                ' If the address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.address)
                            
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
                            & "onmouseover='SaveMousePosition(event); delayRolloverPopup(""PageMethods.GetRecordFieldValue(\""ServelInvocing.Business.SitesTable, ServelInvocing.Business\"",\""" _
                            & (HttpUtility.UrlEncode(Me.DataSource.GetID.ToString())).Replace("\","\\\\") & "\"", \""address\"", \""address1\"", \""Address\"", false, 200," _
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
                
                Me.address1.Text = formattedValue
              
            Else 
            
                ' address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.address1.Text = SitesTable.address.Format(SitesTable.address.DefaultValue)
                        		
                End If
                 
            ' If the address is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.address1.Text Is Nothing _
                OrElse Me.address1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.address1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcity1()
            
        
            ' Set the city Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.city1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcity1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.citySpecified Then
                				
                ' If the city is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.city)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.city1.Text = formattedValue
              
            Else 
            
                ' city is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.city1.Text = SitesTable.city.Format(SitesTable.city.DefaultValue)
                        		
                End If
                 
            ' If the city is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.city1.Text Is Nothing _
                OrElse Me.city1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.city1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcontact1()
            
        
            ' Set the contact Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.contact1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcontact1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.contactSpecified Then
                				
                ' If the contact is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.contact)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.contact1.Text = formattedValue
              
            Else 
            
                ' contact is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.contact1.Text = SitesTable.contact.Format(SitesTable.contact.DefaultValue)
                        		
                End If
                 
            ' If the contact is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.contact1.Text Is Nothing _
                OrElse Me.contact1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.contact1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setecc_no1()
            
        
            ' Set the ecc_no Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.ecc_no1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setecc_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ecc_noSpecified Then
                				
                ' If the ecc_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.ecc_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ecc_no1.Text = formattedValue
              
            Else 
            
                ' ecc_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ecc_no1.Text = SitesTable.ecc_no.Format(SitesTable.ecc_no.DefaultValue)
                        		
                End If
                 
            ' If the ecc_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.ecc_no1.Text Is Nothing _
                OrElse Me.ecc_no1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.ecc_no1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setemail1()
            
        
            ' Set the email Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.email1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.email)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.email1.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email1.Text = SitesTable.email.Format(SitesTable.email.DefaultValue)
                        		
                End If
                 
            ' If the email is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.email1.Text Is Nothing _
                OrElse Me.email1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.email1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgst_no1()
            
        
            ' Set the gst_no Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.gst_no1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_noSpecified Then
                				
                ' If the gst_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.gst_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.gst_no1.Text = formattedValue
              
            Else 
            
                ' gst_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_no1.Text = SitesTable.gst_no.Format(SitesTable.gst_no.DefaultValue)
                        		
                End If
                 
            ' If the gst_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.gst_no1.Text Is Nothing _
                OrElse Me.gst_no1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.gst_no1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setid_party()
            
        
            ' Set the id_party LinkButton on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.id_party is the ASP:LinkButton on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_party()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_partySpecified Then
                				
                ' If the id_party is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.id_party)
                            
                Me.id_party.Text = formattedValue
              
            Else 
            
                ' id_party is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_party.Text = SitesTable.id_party.Format(SitesTable.id_party.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setname1()
            
        
            ' Set the name Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.name1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setname1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.nameSpecified Then
                				
                ' If the name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.name1.Text = formattedValue
              
            Else 
            
                ' name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.name1.Text = SitesTable.name.Format(SitesTable.name.DefaultValue)
                        		
                End If
                 
            ' If the name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.name1.Text Is Nothing _
                OrElse Me.name1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.name1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpan_no1()
            
        
            ' Set the pan_no Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.pan_no1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpan_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.pan_noSpecified Then
                				
                ' If the pan_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.pan_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.pan_no1.Text = formattedValue
              
            Else 
            
                ' pan_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.pan_no1.Text = SitesTable.pan_no.Format(SitesTable.pan_no.DefaultValue)
                        		
                End If
                 
            ' If the pan_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.pan_no1.Text Is Nothing _
                OrElse Me.pan_no1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.pan_no1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setparty_code1()
            
        
            ' Set the party_code Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.party_code1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setparty_code1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.party_codeSpecified Then
                				
                ' If the party_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.party_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.party_code1.Text = formattedValue
              
            Else 
            
                ' party_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.party_code1.Text = SitesTable.party_code.Format(SitesTable.party_code.DefaultValue)
                        		
                End If
                 
            ' If the party_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.party_code1.Text Is Nothing _
                OrElse Me.party_code1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.party_code1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setphone1()
            
        
            ' Set the phone Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.phone1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.phone)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.phone1.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone1.Text = SitesTable.phone.Format(SitesTable.phone.DefaultValue)
                        		
                End If
                 
            ' If the phone is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.phone1.Text Is Nothing _
                OrElse Me.phone1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.phone1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setst37_no1()
            
        
            ' Set the st37_no Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.st37_no1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setst37_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.st37_noSpecified Then
                				
                ' If the st37_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.st37_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.st37_no1.Text = formattedValue
              
            Else 
            
                ' st37_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.st37_no1.Text = SitesTable.st37_no.Format(SitesTable.st37_no.DefaultValue)
                        		
                End If
                 
            ' If the st37_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.st37_no1.Text Is Nothing _
                OrElse Me.st37_no1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.st37_no1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setstate_code2()
            
        
            ' Set the state_code Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.state_code2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_code2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_codeSpecified Then
                				
                ' If the state_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.state_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state_code2.Text = formattedValue
              
            Else 
            
                ' state_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_code2.Text = SitesTable.state_code.Format(SitesTable.state_code.DefaultValue)
                        		
                End If
                 
            ' If the state_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state_code2.Text Is Nothing _
                OrElse Me.state_code2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state_code2.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setstate_name2()
            
        
            ' Set the state_name Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.state_name2 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_name2()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_nameSpecified Then
                				
                ' If the state_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.state_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state_name2.Text = formattedValue
              
            Else 
            
                ' state_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_name2.Text = SitesTable.state_name.Format(SitesTable.state_name.DefaultValue)
                        		
                End If
                 
            ' If the state_name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state_name2.Text Is Nothing _
                OrElse Me.state_name2.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state_name2.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settin_no1()
            
        
            ' Set the tin_no Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.tin_no1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.tin_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tin_no1.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no1.Text = SitesTable.tin_no.Format(SitesTable.tin_no.DefaultValue)
                        		
                End If
                 
            ' If the tin_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tin_no1.Text Is Nothing _
                OrElse Me.tin_no1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tin_no1.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setvat_no1()
            
        
            ' Set the vat_no Literal on the webpage with value from the
            ' sites database record.

            ' Me.DataSource is the sites record retrieved from the database.
            ' Me.vat_no1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setvat_no1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.vat_noSpecified Then
                				
                ' If the vat_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(SitesTable.vat_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.vat_no1.Text = formattedValue
              
            Else 
            
                ' vat_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.vat_no1.Text = SitesTable.vat_no.Format(SitesTable.vat_no.DefaultValue)
                        		
                End If
                 
            ' If the vat_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.vat_no1.Text Is Nothing _
                OrElse Me.vat_no1.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.vat_no1.Text = "&nbsp;"
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
            
        End Sub
                
        Public Overridable Sub Getcity1()
            
        End Sub
                
        Public Overridable Sub Getcontact1()
            
        End Sub
                
        Public Overridable Sub Getecc_no1()
            
        End Sub
                
        Public Overridable Sub Getemail1()
            
        End Sub
                
        Public Overridable Sub Getgst_no1()
            
        End Sub
                
        Public Overridable Sub Getid_party()
            
        End Sub
                
        Public Overridable Sub Getname1()
            
        End Sub
                
        Public Overridable Sub Getpan_no1()
            
        End Sub
                
        Public Overridable Sub Getparty_code1()
            
        End Sub
                
        Public Overridable Sub Getphone1()
            
        End Sub
                
        Public Overridable Sub Getst37_no1()
            
        End Sub
                
        Public Overridable Sub Getstate_code2()
            
        End Sub
                
        Public Overridable Sub Getstate_name2()
            
        End Sub
                
        Public Overridable Sub Gettin_no1()
            
        End Sub
                
        Public Overridable Sub Getvat_no1()
            
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
        
        
        ' event handler for ImageButton
        Public Overridable Sub SitesRowCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../sites/AddSites.aspx?Sites={PK}"
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
        Public Overridable Sub SitesRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        ' event handler for LinkButton
        Public Overridable Sub id_party_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../party/ShowParty.aspx?Party={SitesTableControlRow:FK:sites_party_FK}"
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
        
        Public ReadOnly Property address1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "address1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property city1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "city1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property contact1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contact1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ecc_no1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ecc_no1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property email1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "email1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property gst_no1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_no1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property id_party() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_party"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
            
        Public ReadOnly Property name1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "name1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property pan_no1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "pan_no1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property party_code1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "party_code1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property phone1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "phone1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property SitesRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property SitesRowCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRowCopyButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property st37_no1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "st37_no1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property state_code2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_code2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property state_name2() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_name2"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tin_no1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tin_no1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property vat_no1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "vat_no1"), System.Web.UI.WebControls.Literal)
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

  

' Base class for the SitesTableControl control on the ShowStates page.
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
          
              AddHandler Me.SitesCopyButton.Click, AddressOf SitesCopyButton_Click
              
              AddHandler Me.SitesDeleteButton.Click, AddressOf SitesDeleteButton_Click
              
              AddHandler Me.SitesEditButton.Click, AddressOf SitesEditButton_Click
              
              AddHandler Me.SitesExportCSVButton.Click, AddressOf SitesExportCSVButton_Click
              
              AddHandler Me.SitesExportExcelButton.Click, AddressOf SitesExportExcelButton_Click
              
              AddHandler Me.SitesImportButton.Click, AddressOf SitesImportButton_Click
              
              AddHandler Me.SitesNewButton.Click, AddressOf SitesNewButton_Click
              
              AddHandler Me.SitesPDFButton.Click, AddressOf SitesPDFButton_Click
              
              AddHandler Me.SitesRefreshButton.Click, AddressOf SitesRefreshButton_Click
              
              AddHandler Me.SitesResetButton.Click, AddressOf SitesResetButton_Click
              
              AddHandler Me.SitesWordButton.Click, AddressOf SitesWordButton_Click
              
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
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SitesExportCSVButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SitesExportExcelButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SitesPDFButton"))
                        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SitesWordButton"))
                        
        
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
                        If recControl.id_party.Text <> "" Then
                            rec.Parse(recControl.id_party.Text, SitesTable.id_party)
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
        Public Overridable Sub SitesCopyButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../sites/AddSites.aspx?Sites={PK}"
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
        Public Overridable Sub SitesDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub SitesExportCSVButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
                       SitesTable.id_party, _ 
             SitesTable.party_code, _ 
             SitesTable.name, _ 
             SitesTable.address, _ 
             SitesTable.city, _ 
             SitesTable.contact, _ 
             SitesTable.phone, _ 
             SitesTable.email, _ 
             SitesTable.vat_no, _ 
             SitesTable.pan_no, _ 
             SitesTable.ecc_no, _ 
             SitesTable.st37_no, _ 
             SitesTable.tin_no, _ 
             SitesTable.gst_no, _ 
             SitesTable.state_code, _ 
             SitesTable.state_name, _ 
             Nothing}
            Dim  exportData as ExportDataToCSV = New ExportDataToCSV(SitesTable.Instance, wc, orderBy, columns)
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
        Public Overridable Sub SitesExportExcelButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
            Dim excelReport As ExportDataToExcel = New ExportDataToExcel(SitesTable.Instance, wc, orderBy)
            ' Add each of the columns in order of export.
            ' To customize the data type, change the second parameter of the new ExcelColumn to be
            ' a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"
             excelReport.AddColumn(New ExcelColumn(SitesTable.id_party, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.party_code, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.name, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.address, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.city, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.contact, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.phone, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.email, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.vat_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.pan_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.ecc_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.st37_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.tin_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.gst_no, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.state_code, "Default"))
             excelReport.AddColumn(New ExcelColumn(SitesTable.state_name, "Default"))

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
        Public Overridable Sub SitesImportButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/SelectFileToImport.aspx?TableName=Sites"
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
        Public Overridable Sub SitesNewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../sites/AddSites.aspx"
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
        Public Overridable Sub SitesPDFButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As PDFReport = New PDFReport() 
                report.SpecificReportFileName = Page.Server.MapPath("ShowStates.SitesPDFButton.report")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "sites"
                ' If ShowStates.SitesPDFButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.   
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column   			
                 report.AddColumn(SitesTable.id_party.Name, ReportEnum.Align.Left, "${id_party}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.party_code.Name, ReportEnum.Align.Left, "${party_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SitesTable.name.Name, ReportEnum.Align.Left, "${name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.address.Name, ReportEnum.Align.Left, "${address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.city.Name, ReportEnum.Align.Left, "${city}", ReportEnum.Align.Left, 28)
                 report.AddColumn(SitesTable.contact.Name, ReportEnum.Align.Left, "${contact}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.phone.Name, ReportEnum.Align.Left, "${phone}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.email.Name, ReportEnum.Align.Left, "${email}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.vat_no.Name, ReportEnum.Align.Left, "${vat_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.pan_no.Name, ReportEnum.Align.Left, "${pan_no}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SitesTable.ecc_no.Name, ReportEnum.Align.Left, "${ecc_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.st37_no.Name, ReportEnum.Align.Left, "${st37_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.tin_no.Name, ReportEnum.Align.Left, "${tin_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.gst_no.Name, ReportEnum.Align.Left, "${gst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.state_code.Name, ReportEnum.Align.Left, "${state_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SitesTable.state_name.Name, ReportEnum.Align.Left, "${state_name}", ReportEnum.Align.Left, 24)

          
                Dim rowsPerQuery As Integer = 5000 
                Dim recordCount As Integer = 0 
                                
                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)
            
                Dim whereClause As WhereClause = CreateWhereClause
                Dim orderBy As OrderBy = CreateOrderBy
            
                Dim pageNum As Integer = 0 
                Dim totalRows As Integer = SitesTable.GetRecordCount(whereClause)
                Dim columns As ColumnList = SitesTable.GetColumnList()
                Dim records As SitesRecord() = Nothing
            
                Do 
                    
                    records = SitesTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then 
                        For Each record As SitesRecord In records 
                    
                            ' AddData method takes four parameters   
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                                                         report.AddData("${id_party}", record.Format(SitesTable.id_party), ReportEnum.Align.Left)
                             report.AddData("${party_code}", record.Format(SitesTable.party_code), ReportEnum.Align.Left, 100)
                             report.AddData("${name}", record.Format(SitesTable.name), ReportEnum.Align.Left, 100)
                             report.AddData("${address}", record.Format(SitesTable.address), ReportEnum.Align.Left, 100)
                             report.AddData("${city}", record.Format(SitesTable.city), ReportEnum.Align.Left, 100)
                             report.AddData("${contact}", record.Format(SitesTable.contact), ReportEnum.Align.Left, 100)
                             report.AddData("${phone}", record.Format(SitesTable.phone), ReportEnum.Align.Left, 100)
                             report.AddData("${email}", record.Format(SitesTable.email), ReportEnum.Align.Left, 100)
                             report.AddData("${vat_no}", record.Format(SitesTable.vat_no), ReportEnum.Align.Left, 100)
                             report.AddData("${pan_no}", record.Format(SitesTable.pan_no), ReportEnum.Align.Left, 100)
                             report.AddData("${ecc_no}", record.Format(SitesTable.ecc_no), ReportEnum.Align.Left, 100)
                             report.AddData("${st37_no}", record.Format(SitesTable.st37_no), ReportEnum.Align.Left, 100)
                             report.AddData("${tin_no}", record.Format(SitesTable.tin_no), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_no}", record.Format(SitesTable.gst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${state_code}", record.Format(SitesTable.state_code), ReportEnum.Align.Left, 100)
                             report.AddData("${state_name}", record.Format(SitesTable.state_name), ReportEnum.Align.Left, 100)

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
        Public Overridable Sub SitesRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim PartyTableControlObj as PartyTableControl = DirectCast(Me.Page.FindControlRecursively("PartyTableControl"), PartyTableControl)
            PartyTableControlObj.ResetData = True
                        
            PartyTableControlObj.RemoveFromSession(PartyTableControlObj, "DeletedRecordIds")
            PartyTableControlObj.DeletedRecordIds = Nothing
            
            Dim SitesTableControlObj as SitesTableControl = DirectCast(Me.Page.FindControlRecursively("SitesTableControl"), SitesTableControl)
            SitesTableControlObj.ResetData = True
                        
            SitesTableControlObj.RemoveFromSession(SitesTableControlObj, "DeletedRecordIds")
            SitesTableControlObj.DeletedRecordIds = Nothing
            
            Dim StatesRecordControlObj as StatesRecordControl = DirectCast(Me.Page.FindControlRecursively("StatesRecordControl"), StatesRecordControl)
            StatesRecordControlObj.ResetData = True
                        
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
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
        
        ' event handler for ImageButton
        Public Overridable Sub SitesWordButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
                Dim report As WordReport = New WordReport
                report.SpecificReportFileName = Page.Server.MapPath("ShowStates.SitesWordButton.word")
                ' report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "sites"
                ' If ShowStates.SitesWordButton.report specifies a valid report template,
                ' AddColumn method will generate a report template.
                ' Each AddColumn method-call specifies a column
                ' The 1st parameter represents the text of the column header
                ' The 2nd parameter represents the horizontal alignment of the column header
                ' The 3rd parameter represents the text format of the column detail
                ' The 4th parameter represents the horizontal alignment of the column detail
                ' The 5th parameter represents the relative width of the column
                 report.AddColumn(SitesTable.id_party.Name, ReportEnum.Align.Left, "${id_party}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.party_code.Name, ReportEnum.Align.Left, "${party_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SitesTable.name.Name, ReportEnum.Align.Left, "${name}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.address.Name, ReportEnum.Align.Left, "${address}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.city.Name, ReportEnum.Align.Left, "${city}", ReportEnum.Align.Left, 28)
                 report.AddColumn(SitesTable.contact.Name, ReportEnum.Align.Left, "${contact}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.phone.Name, ReportEnum.Align.Left, "${phone}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.email.Name, ReportEnum.Align.Left, "${email}", ReportEnum.Align.Left, 30)
                 report.AddColumn(SitesTable.vat_no.Name, ReportEnum.Align.Left, "${vat_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.pan_no.Name, ReportEnum.Align.Left, "${pan_no}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SitesTable.ecc_no.Name, ReportEnum.Align.Left, "${ecc_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.st37_no.Name, ReportEnum.Align.Left, "${st37_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.tin_no.Name, ReportEnum.Align.Left, "${tin_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.gst_no.Name, ReportEnum.Align.Left, "${gst_no}", ReportEnum.Align.Left, 20)
                 report.AddColumn(SitesTable.state_code.Name, ReportEnum.Align.Left, "${state_code}", ReportEnum.Align.Left, 15)
                 report.AddColumn(SitesTable.state_name.Name, ReportEnum.Align.Left, "${state_name}", ReportEnum.Align.Left, 24)

              Dim whereClause As WhereClause = CreateWhereClause
              
              Dim orderBy As OrderBy = CreateOrderBy
                
                Dim rowsPerQuery As Integer = 5000
                Dim pageNum As Integer = 0
                Dim recordCount As Integer = 0
                Dim totalRows As Integer = SitesTable.GetRecordCount(whereClause)

                report.Page = Page.GetResourceValue("Txt:Page", "ServelInvocing")
                report.ApplicationPath = Me.Page.MapPath(Page.Request.ApplicationPath)

                Dim columns As ColumnList = SitesTable.GetColumnList()
                Dim records As SitesRecord() = Nothing
                Do
                    records = SitesTable.GetRecords(whereClause, orderBy, pageNum, rowsPerQuery)
                    If Not (records Is Nothing) AndAlso records.Length > 0 AndAlso whereClause.RunQuery Then
                        For Each record As SitesRecord In records
                            ' AddData method takes four parameters
                            ' The 1st parameters represent the data format
                            ' The 2nd parameters represent the data value
                            ' The 3rd parameters represent the default alignment of column using the data
                            ' The 4th parameters represent the maximum length of the data value being shown
                             report.AddData("${id_party}", record.Format(SitesTable.id_party), ReportEnum.Align.Left)
                             report.AddData("${party_code}", record.Format(SitesTable.party_code), ReportEnum.Align.Left, 100)
                             report.AddData("${name}", record.Format(SitesTable.name), ReportEnum.Align.Left, 100)
                             report.AddData("${address}", record.Format(SitesTable.address), ReportEnum.Align.Left, 100)
                             report.AddData("${city}", record.Format(SitesTable.city), ReportEnum.Align.Left, 100)
                             report.AddData("${contact}", record.Format(SitesTable.contact), ReportEnum.Align.Left, 100)
                             report.AddData("${phone}", record.Format(SitesTable.phone), ReportEnum.Align.Left, 100)
                             report.AddData("${email}", record.Format(SitesTable.email), ReportEnum.Align.Left, 100)
                             report.AddData("${vat_no}", record.Format(SitesTable.vat_no), ReportEnum.Align.Left, 100)
                             report.AddData("${pan_no}", record.Format(SitesTable.pan_no), ReportEnum.Align.Left, 100)
                             report.AddData("${ecc_no}", record.Format(SitesTable.ecc_no), ReportEnum.Align.Left, 100)
                             report.AddData("${st37_no}", record.Format(SitesTable.st37_no), ReportEnum.Align.Left, 100)
                             report.AddData("${tin_no}", record.Format(SitesTable.tin_no), ReportEnum.Align.Left, 100)
                             report.AddData("${gst_no}", record.Format(SitesTable.gst_no), ReportEnum.Align.Left, 100)
                             report.AddData("${state_code}", record.Format(SitesTable.state_code), ReportEnum.Align.Left, 100)
                             report.AddData("${state_name}", record.Format(SitesTable.state_name), ReportEnum.Align.Left, 100)

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
        
        Public ReadOnly Property SitesCopyButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesCopyButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property SitesExportCSVButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesExportCSVButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesExportExcelButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesExportExcelButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesImportButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesImportButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesNewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesNewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property SitesPDFButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesPDFButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property SitesRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesRefreshButton"), System.Web.UI.WebControls.ImageButton)
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
        
        Public ReadOnly Property SitesWordButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "SitesWordButton"), System.Web.UI.WebControls.ImageButton)
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

  
' Base class for the StatesRecordControl control on the ShowStates page.
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
          
              AddHandler Me.StatesDialogEditButton.Click, AddressOf StatesDialogEditButton_Click
              
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
            
        
            ' Set the state_code Literal on the webpage with value from the
            ' states database record.

            ' Me.DataSource is the states record retrieved from the database.
            ' Me.state_code is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_code()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_codeSpecified Then
                				
                ' If the state_code is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(StatesTable.state_code)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state_code.Text = formattedValue
              
            Else 
            
                ' state_code is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_code.Text = StatesTable.state_code.Format(StatesTable.state_code.DefaultValue)
                        		
                End If
                 
            ' If the state_code is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state_code.Text Is Nothing _
                OrElse Me.state_code.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state_code.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setstate_name()
            
        
            ' Set the state_name Literal on the webpage with value from the
            ' states database record.

            ' Me.DataSource is the states record retrieved from the database.
            ' Me.state_name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setstate_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.state_nameSpecified Then
                				
                ' If the state_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(StatesTable.state_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.state_name.Text = formattedValue
              
            Else 
            
                ' state_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.state_name.Text = StatesTable.state_name.Format(StatesTable.state_name.DefaultValue)
                        		
                End If
                 
            ' If the state_name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.state_name.Text Is Nothing _
                OrElse Me.state_name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.state_name.Text = "&nbsp;"
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
            
        End Sub
                
        Public Overridable Sub Getstate_name()
            
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
            HttpContext.Current.Session("QueryString in ShowStates") = recId
              
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
            
        ' event handler for ImageButton
        Public Overridable Sub StatesDialogEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../states/EditStates.aspx?States={PK}"
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
        
        Public ReadOnly Property state_code() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_code"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property state_codeLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_codeLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property state_name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property state_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "state_nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property StatesDialogEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "StatesDialogEditButton"), System.Web.UI.WebControls.ImageButton)
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

  