﻿
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EmailInv_hdr.aspx page.  The Row or RecordControl classes are the 
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
        
Imports telerik.reporting
Imports System.IO
Imports System.Text

#End Region

  
Namespace ServelInvocing.UI.Controls.EmailInv_hdr

#Region "Section 1: Place your customizations here."

    
Public Class Inv_itemsTableControlRow
        Inherits BaseInv_itemsTableControlRow
        ' The BaseInv_itemsTableControlRow implements code for a ROW within the
        ' the Inv_itemsTableControl table.  The BaseInv_itemsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Inv_itemsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Inv_itemsTableControl
        Inherits BaseInv_itemsTableControl

    ' The BaseInv_itemsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Inv_itemsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class Inv_taxesTableControlRow
        Inherits BaseInv_taxesTableControlRow
        ' The BaseInv_taxesTableControlRow implements code for a ROW within the
        ' the Inv_taxesTableControl table.  The BaseInv_taxesTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Inv_taxesTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Inv_taxesTableControl
        Inherits BaseInv_taxesTableControl

    ' The BaseInv_taxesTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Inv_taxesTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class Inv_termsTableControlRow
        Inherits BaseInv_termsTableControlRow
        ' The BaseInv_termsTableControlRow implements code for a ROW within the
        ' the Inv_termsTableControl table.  The BaseInv_termsTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of Inv_termsTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class Inv_termsTableControl
        Inherits BaseInv_termsTableControl

    ' The BaseInv_termsTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The Inv_termsTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  
Public Class Inv_hdrRecordControl
        Inherits BaseInv_hdrRecordControl
        ' The BaseInv_hdrRecordControl implements the LoadData, DataBind and other
        ' methods to load and display the data in a table control.

        ' This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        ' CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
		Private Shared Function MakeValidFileName(name As String) As String
			Dim invalidChars As String = Regex.Escape(New String(Path.GetInvalidFileNameChars()))
			Dim invalidReStr As String = String.Format("[{0}]+", invalidChars)
			Return Regex.Replace(name, invalidReStr, "_")
		End Function

    	Public Sub CreateAttachment(ByVal out_file As String)
	
			Try
    	        'Dim sID As String = Page.Session("PrintProInvId").tostring()
    	        Dim sID As String = Me.id1.text
				'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", sID)
				'Dim fs As New ServelInvoicingReportLibrary.ServelInvoice2Copy()
				Dim fs As New ServelInvoicingReportLibrary.ServelInvoiceFinal()
				fs.ReportParameters("PrintProInvId").value = sID
				fs.ReportParameters("CopyName").value = "EXTRA COPY (not for CENVAT)"
				
				Dim reportProcessor As New Telerik.Reporting.Processing.ReportProcessor()
				Dim result As Telerik.Reporting.Processing.RenderingResult 
				result = reportProcessor.RenderReport("PDF", fs, Nothing) 

				Dim filename As String
				filename = out_file
				Dim fstr As New FileStream(filename, FileMode.Create)
				fstr.Write(result.DocumentBytes, 0, result.DocumentBytes.Length)
				fstr.Flush()
				fstr.Close()

			Catch ex As Exception

        'Do Something Here

        	End Try		

		End Sub

		Public Overrides Sub BtnEmail_Click(ByVal sender As Object, ByVal args As EventArgs)

			'222 - marker
            Try
				DbUtils.StartTransaction()
	            If Not me.txtEmail.text Is Nothing Then
                	'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "Hello - 1")
					Dim UserId as string = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
					If String.IsNullOrEmpty(UserId) Then
						UserId = "1"
					End if
                	'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "Hello - 2" + UserId)
					' get user name as well as email id
					Dim srchUserStr As String
					'srchUserStr = "id = '" + UserId.tostring() + "'"
					srchUserStr = "id = '" + UserId + "'"
					Dim UsersCopyRec As UsersRecord = UsersTable.GetRecord(srchUserStr)
		            Dim UserName As string = UsersCopyRec.name
					Dim FromEmail As string = UsersCopyRec.email
				
					' get content body ad bcc address from company
					Dim srchCompanyStr As String
					srchCompanyStr = "id = '1'"
					Dim CompanyCopyRec As CompanyRecord = CompanyTable.GetRecord(srchCompanyStr)
		            Dim ProformaContent As string = CompanyCopyRec.proforma_email_body
					Dim BccEmail As string = CompanyCopyRec.email_bcc

					Dim path As String = Page.Server.MapPath("..\DataFiles\Invoice")
					Dim filename As String
					filename = path + "\SIPL-Inv-"  + MakeValidFileName(Me.inv_no.text) + ".pdf"
				
                	Me.CreateAttachment(filename)
					
	            	Dim email As BaseClasses.Utils.MailSender = New BaseClasses.Utils.MailSender
		            'email.AddFrom("ravi73164@gmail.com")
					email.AddFrom(FromEmail)
                	email.AddTo(me.txtEmail.text)
					'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", fromEmail + "!" + me.txtEmail.text)
					
					' additional_email is more email ids for "cc" mail 
					' regex for email got from http://stackoverflow.com/questions/369543/validating-e-mail-with-regular-expression-vb-net
					Dim cc_email as String = Me.txtAddEmail.text
					Dim ccEmails As String() = Nothing
					If Not String.IsNullOrEmpty(cc_Email) Then
					    Static emailExpression As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
						ccEmails = cc_Email.Split(";"C)
						For Each EmailAddress As string In ccEmails
							If Not String.IsNullOrEmpty(EmailAddress) Then
								If emailExpression.IsMatch(EmailAddress) Then
						    	    email.AddCC(EmailAddress)
								End If	
							End If
						Next
					End If
                	'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "Hello - 4")
		    	    email.AddBCC(BccEmail)
					' sender gets a mail in his mailbox also 
		    	    email.AddBCC(FromEmail)
        			email.SetSubject("Invoice - " + Me.inv_no.text)
			    	email.SetIsHtmlContent(true)
					Dim content As string = ""
					' Me.mail_body.text
					if content.Length = 0
						content = "Here is the Invoice <br /> "
						content = content + "Please find attached our Invoice for the same. <br /> "
						content = content + "Thank you for your interest . <br /> <br />"
					end if 	
					content = content + "<b>" + username + "</b>"
    	        	email.SetContent(content)
			    	email.AddAttachment(filename)
                	'Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", "Hello - 5")
	            	email.SendMessage()

					' create a log of the mail sent for viewing by users
					Dim mail_log_rec As New mail_logRecord
					mail_log_rec.doc_type     = "Invoice"
					mail_log_rec.sent_by      = UsersCopyRec.name
					mail_log_rec.sent_date    = DateTime.Now
					mail_log_rec.sent_to      = Me.txtEmail.text
					mail_log_rec.sent_bcc     = BccEmail
					mail_log_rec.sent_subject = "Invoice - " + Me.inv_no.text
					mail_log_rec.sent_body    = content
					mail_log_rec.sent_attach  = filename
					mail_log_rec.save()
				End if
				DbUtils.CommitTransaction()
			
            Catch ex As Exception
				DbUtils.RollBackTransaction()
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
				DbUtils.EndTransaction()
		
            End Try

			Try
                
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
			' close window after mail sent
			me.page.ClientScript.RegisterStartupScript(GetType(Page), "closePage", "window.close();", True)
        End Sub

		Protected Overrides Sub Control_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) 
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
			me.txtemail.text = me.email.text
		
        End Sub
End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the Inv_itemsTableControlRow control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_itemsTableControlRow.
Public Class BaseInv_itemsTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Inv_itemsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Inv_itemsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource inv_items record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Inv_itemsTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseInv_itemsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Inv_itemsRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Inv_itemsTableControlRow.
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
            Setid_item()
            Setitem_description()
            Setqty()
            Setrate()
            Setuom()
      
      
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
        
        
        Public Overridable Sub Setamount()
            
        
            ' Set the amount Literal on the webpage with value from the
            ' inv_items database record.

            ' Me.DataSource is the inv_items record retrieved from the database.
            ' Me.amount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setamount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.amountSpecified Then
                				
                ' If the amount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_itemsTable.amount, "c")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.amount.Text = formattedValue
              
            Else 
            
                ' amount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.amount.Text = Inv_itemsTable.amount.Format(Inv_itemsTable.amount.DefaultValue, "c")
                        		
                End If
                 
            ' If the amount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.amount.Text Is Nothing _
                OrElse Me.amount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.amount.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setid_item()
            
        
            ' Set the id_item Literal on the webpage with value from the
            ' inv_items database record.

            ' Me.DataSource is the inv_items record retrieved from the database.
            ' Me.id_item is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid_item()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id_itemSpecified Then
                				
                ' If the id_item is non-NULL, then format the value.

                ' The Format method will return the Display Foreign Key As (DFKA) value
                                Dim formattedValue As String = Me.DataSource.Format(Inv_itemsTable.id_item)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.id_item.Text = formattedValue
              
            Else 
            
                ' id_item is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id_item.Text = Inv_itemsTable.id_item.Format(Inv_itemsTable.id_item.DefaultValue)
                        		
                End If
                 
            ' If the id_item is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.id_item.Text Is Nothing _
                OrElse Me.id_item.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.id_item.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setitem_description()
            
        
            ' Set the item_description Literal on the webpage with value from the
            ' inv_items database record.

            ' Me.DataSource is the inv_items record retrieved from the database.
            ' Me.item_description is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_descriptionSpecified Then
                				
                ' If the item_description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_itemsTable.item_description)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.item_description.Text = formattedValue
              
            Else 
            
                ' item_description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_description.Text = Inv_itemsTable.item_description.Format(Inv_itemsTable.item_description.DefaultValue)
                        		
                End If
                 
            ' If the item_description is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.item_description.Text Is Nothing _
                OrElse Me.item_description.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.item_description.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setqty()
            
        
            ' Set the qty Literal on the webpage with value from the
            ' inv_items database record.

            ' Me.DataSource is the inv_items record retrieved from the database.
            ' Me.qty is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setqty()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.qtySpecified Then
                				
                ' If the qty is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_itemsTable.qty)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.qty.Text = formattedValue
              
            Else 
            
                ' qty is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.qty.Text = Inv_itemsTable.qty.Format(Inv_itemsTable.qty.DefaultValue)
                        		
                End If
                 
            ' If the qty is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.qty.Text Is Nothing _
                OrElse Me.qty.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.qty.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setrate()
            
        
            ' Set the rate Literal on the webpage with value from the
            ' inv_items database record.

            ' Me.DataSource is the inv_items record retrieved from the database.
            ' Me.rate is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setrate()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.rateSpecified Then
                				
                ' If the rate is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_itemsTable.rate)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.rate.Text = formattedValue
              
            Else 
            
                ' rate is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.rate.Text = Inv_itemsTable.rate.Format(Inv_itemsTable.rate.DefaultValue)
                        		
                End If
                 
            ' If the rate is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.rate.Text Is Nothing _
                OrElse Me.rate.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.rate.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setuom()
            
        
            ' Set the uom Literal on the webpage with value from the
            ' inv_items database record.

            ' Me.DataSource is the inv_items record retrieved from the database.
            ' Me.uom is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setuom()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.uomSpecified Then
                				
                ' If the uom is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_itemsTable.uom)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.uom.Text = formattedValue
              
            Else 
            
                ' uom is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.uom.Text = Inv_itemsTable.uom.Format(Inv_itemsTable.uom.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in Inv_itemsTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As Inv_hdrRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("Inv_hdrRecordControl"), Inv_hdrRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_inv_hdr = parentCtrl.DataSource.id0
              
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
              
                DirectCast(GetParentControlObject(Me, "Inv_itemsTableControl"), Inv_itemsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Inv_itemsTableControl"), Inv_itemsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Inv_itemsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getamount()
            Getid_item()
            Getitem_description()
            Getqty()
            Getrate()
            Getuom()
        End Sub
        
        
        Public Overridable Sub Getamount()
            
        End Sub
                
        Public Overridable Sub Getid_item()
            
        End Sub
                
        Public Overridable Sub Getitem_description()
            
        End Sub
                
        Public Overridable Sub Getqty()
            
        End Sub
                
        Public Overridable Sub Getrate()
            
        End Sub
                
        Public Overridable Sub Getuom()
            
        End Sub
                
      
        ' To customize, override this method in Inv_itemsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Inv_itemsTableControlRow.
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
          Inv_itemsTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Inv_itemsTableControl"), Inv_itemsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Inv_itemsTableControl"), Inv_itemsTableControl).ResetData = True
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
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseInv_itemsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseInv_itemsTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Inv_itemsRecord
        Public Property DataSource() As Inv_itemsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Inv_itemsRecord)
            
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
            
        Public ReadOnly Property id_item() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_item"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property item_description() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_description"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property qty() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "qty"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property rate() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rate"), System.Web.UI.WebControls.Literal)
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
            
            Dim rec As Inv_itemsRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Inv_itemsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Inv_itemsTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Inv_itemsTableControl control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_itemsTableControl.
Public Class BaseInv_itemsTableControl
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
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "1000"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
            ' Setup the sorting events.
          
            ' Setup the button events.
          
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Inv_itemsRecord)), Inv_itemsRecord())
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
                
                Me.TotalRecords = Inv_itemsTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Inv_itemsRecord)), Inv_itemsRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Inv_itemsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Inv_itemsRecord)), Inv_itemsRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Inv_itemsTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
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
      
          ' Improve performance by prefetching display as records.
          Me.PreFetchForeignKeyValues()
             
            ' Setup the pagination controls.
            BindPaginationControls()

            ' Call the Set methods for each controls on the panel
        
            SetamountLabel()
            Setid_itemLabel()
            Setitem_descriptionLabel()
            SetqtyLabel()
            SetrateLabel()
            SetuomLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Inv_itemsTableControlRow = DirectCast(repItem.FindControl("Inv_itemsTableControlRow"), Inv_itemsTableControlRow) 
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
            
            SetamountLabel()
            Setid_itemLabel()
            Setitem_descriptionLabel()
            SetqtyLabel()
            SetrateLabel()
            SetuomLabel()
      End Sub

      
          Public Sub PreFetchForeignKeyValues()
          If (IsNothing(Me.DataSource))
            Return
          End If
          
            Me.Page.PregetDfkaRecords(Inv_itemsTable.id_item, Me.DataSource)
          
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

            ' Bind the buttons for Inv_itemsTableControl pagination.
        

            ' Bind the pagination labels.
        
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Inv_itemsTableControlRow
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
            Inv_itemsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim inv_hdrRecordControlObj As Inv_hdrRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_hdrRecordControl"), Inv_hdrRecordControl)
              
                If (Not IsNothing(inv_hdrRecordControlObj) AndAlso Not IsNothing(inv_hdrRecordControlObj.GetRecord()) AndAlso Not IsNothing(inv_hdrRecordControlObj.GetRecord().id0))
                    wc.iAND(Inv_itemsTable.id_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, inv_hdrRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(Inv_itemsTable.id_inv_hdr.InternalName, inv_hdrRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("Inv_itemsTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Inv_itemsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInInv_hdrRecordControl as String = DirectCast(HttpContext.Current.Session("Inv_itemsTableControlWhereClause"), String)
            
            If Not selectedRecordInInv_hdrRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInInv_hdrRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInInv_hdrRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Inv_itemsTable.id_inv_hdr) Then
            wc.iAND(Inv_itemsTable.id_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Inv_itemsTable.id_inv_hdr).ToString())
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
        
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Inv_itemsTableControlRow = DirectCast(repItem.FindControl("Inv_itemsTableControlRow"), Inv_itemsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Inv_itemsRecord = New Inv_itemsRecord()
        
                        If recControl.amount.Text <> "" Then
                            rec.Parse(recControl.amount.Text, Inv_itemsTable.amount)
                        End If
                        If recControl.id_item.Text <> "" Then
                            rec.Parse(recControl.id_item.Text, Inv_itemsTable.id_item)
                        End If
                        If recControl.item_description.Text <> "" Then
                            rec.Parse(recControl.item_description.Text, Inv_itemsTable.item_description)
                        End If
                        If recControl.qty.Text <> "" Then
                            rec.Parse(recControl.qty.Text, Inv_itemsTable.qty)
                        End If
                        If recControl.rate.Text <> "" Then
                            rec.Parse(recControl.rate.Text, Inv_itemsTable.rate)
                        End If
                        If recControl.uom.Text <> "" Then
                            rec.Parse(recControl.uom.Text, Inv_itemsTable.uom)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Inv_itemsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Inv_itemsRecord)), Inv_itemsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Inv_itemsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Inv_itemsTableControlRow) As Boolean
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
        
        Public Overridable Sub SetamountLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setid_itemLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_descriptionLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetqtyLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetrateLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetuomLabel()
            
                    
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

            Dim orderByStr As String = CType(ViewState("Inv_itemsTableControl_OrderBy"), String)
            
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
                Me.ViewState("Inv_itemsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

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
        
        Private _DataSource() As Inv_itemsRecord = Nothing
        Public Property DataSource() As Inv_itemsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Inv_itemsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property amountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "amountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id_itemLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id_itemLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Inv_itemsTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Inv_itemsTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property item_descriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_descriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property qtyLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "qtyLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property rateLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "rateLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property uomLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "uomLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As Inv_itemsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Inv_itemsRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As Inv_itemsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Inv_itemsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Inv_itemsTableControlRow)), Inv_itemsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Inv_itemsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Inv_itemsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
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

        Public Function GetRecordControls() As Inv_itemsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_itemsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Inv_itemsTableControlRow = DirectCast(repItem.FindControl("Inv_itemsTableControlRow"), Inv_itemsTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Inv_itemsTableControlRow)), Inv_itemsTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the Inv_taxesTableControlRow control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_taxesTableControlRow.
Public Class BaseInv_taxesTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Inv_taxesTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Inv_taxesTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource inv_taxes record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Inv_taxesTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseInv_taxesTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Inv_taxesRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Inv_taxesTableControlRow.
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
        
            Settax_amount()
            Settax_print()
      
      
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
        
        
        Public Overridable Sub Settax_amount()
            
        
            ' Set the tax_amount Literal on the webpage with value from the
            ' inv_taxes database record.

            ' Me.DataSource is the inv_taxes record retrieved from the database.
            ' Me.tax_amount is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_amount()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_amountSpecified Then
                				
                ' If the tax_amount is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_taxesTable.tax_amount, "c")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tax_amount.Text = formattedValue
              
            Else 
            
                ' tax_amount is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_amount.Text = Inv_taxesTable.tax_amount.Format(Inv_taxesTable.tax_amount.DefaultValue, "c")
                        		
                End If
                 
            ' If the tax_amount is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tax_amount.Text Is Nothing _
                OrElse Me.tax_amount.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tax_amount.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Settax_print()
            
        
            ' Set the tax_print Literal on the webpage with value from the
            ' inv_taxes database record.

            ' Me.DataSource is the inv_taxes record retrieved from the database.
            ' Me.tax_print is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settax_print()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tax_printSpecified Then
                				
                ' If the tax_print is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_taxesTable.tax_print)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tax_print.Text = formattedValue
              
            Else 
            
                ' tax_print is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tax_print.Text = Inv_taxesTable.tax_print.Format(Inv_taxesTable.tax_print.DefaultValue)
                        		
                End If
                 
            ' If the tax_print is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tax_print.Text Is Nothing _
                OrElse Me.tax_print.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tax_print.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in Inv_taxesTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As Inv_hdrRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("Inv_hdrRecordControl"), Inv_hdrRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_inv_hdr = parentCtrl.DataSource.id0
              
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
              
                DirectCast(GetParentControlObject(Me, "Inv_taxesTableControl"), Inv_taxesTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Inv_taxesTableControl"), Inv_taxesTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Inv_taxesTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Gettax_amount()
            Gettax_print()
        End Sub
        
        
        Public Overridable Sub Gettax_amount()
            
        End Sub
                
        Public Overridable Sub Gettax_print()
            
        End Sub
                
      
        ' To customize, override this method in Inv_taxesTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Inv_taxesTableControlRow.
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
          Inv_taxesTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Inv_taxesTableControl"), Inv_taxesTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Inv_taxesTableControl"), Inv_taxesTableControl).ResetData = True
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
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseInv_taxesTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseInv_taxesTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Inv_taxesRecord
        Public Property DataSource() As Inv_taxesRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Inv_taxesRecord)
            
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
        
        Public ReadOnly Property tax_amount() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_amount"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property tax_print() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_print"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Inv_taxesRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Inv_taxesRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Inv_taxesTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Inv_taxesTableControl control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_taxesTableControl.
Public Class BaseInv_taxesTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(Inv_taxesTable.sort_order, OrderByItem.OrderDir.Asc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "1000"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
            ' Setup the sorting events.
          
            ' Setup the button events.
          
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Inv_taxesRecord)), Inv_taxesRecord())
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
                
                Me.TotalRecords = Inv_taxesTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Inv_taxesRecord)), Inv_taxesRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Inv_taxesTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Inv_taxesRecord)), Inv_taxesRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Inv_taxesTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
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
        
            Settax_amountLabel()
            Settax_printLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Inv_taxesTableControlRow = DirectCast(repItem.FindControl("Inv_taxesTableControlRow"), Inv_taxesTableControlRow) 
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
            
            Settax_amountLabel()
            Settax_printLabel()
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
            
                Me.CurrentSortOrder.Add(Inv_taxesTable.sort_order, OrderByItem.OrderDir.Asc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Inv_taxesTableControl pagination.
        

            ' Bind the pagination labels.
        
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Inv_taxesTableControlRow
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
            Inv_taxesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim inv_hdrRecordControlObj As Inv_hdrRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_hdrRecordControl"), Inv_hdrRecordControl)
              
                If (Not IsNothing(inv_hdrRecordControlObj) AndAlso Not IsNothing(inv_hdrRecordControlObj.GetRecord()) AndAlso Not IsNothing(inv_hdrRecordControlObj.GetRecord().id0))
                    wc.iAND(Inv_taxesTable.id_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, inv_hdrRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(Inv_taxesTable.id_inv_hdr.InternalName, inv_hdrRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("Inv_taxesTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Inv_taxesTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInInv_hdrRecordControl as String = DirectCast(HttpContext.Current.Session("Inv_taxesTableControlWhereClause"), String)
            
            If Not selectedRecordInInv_hdrRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInInv_hdrRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInInv_hdrRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Inv_taxesTable.id_inv_hdr) Then
            wc.iAND(Inv_taxesTable.id_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Inv_taxesTable.id_inv_hdr).ToString())
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
        
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Inv_taxesTableControlRow = DirectCast(repItem.FindControl("Inv_taxesTableControlRow"), Inv_taxesTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Inv_taxesRecord = New Inv_taxesRecord()
        
                        If recControl.tax_amount.Text <> "" Then
                            rec.Parse(recControl.tax_amount.Text, Inv_taxesTable.tax_amount)
                        End If
                        If recControl.tax_print.Text <> "" Then
                            rec.Parse(recControl.tax_print.Text, Inv_taxesTable.tax_print)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Inv_taxesRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Inv_taxesRecord)), Inv_taxesRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Inv_taxesTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Inv_taxesTableControlRow) As Boolean
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
        
        Public Overridable Sub Settax_amountLabel()
            
                    
        End Sub
                
        Public Overridable Sub Settax_printLabel()
            
                    
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

            Dim orderByStr As String = CType(ViewState("Inv_taxesTableControl_OrderBy"), String)
            
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
                Me.ViewState("Inv_taxesTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

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
        
        Private _DataSource() As Inv_taxesRecord = Nothing
        Public Property DataSource() As Inv_taxesRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Inv_taxesRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Inv_taxesTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Inv_taxesTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tax_amountLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_amountLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property tax_printLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "tax_printLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As Inv_taxesTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Inv_taxesRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As Inv_taxesTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Inv_taxesTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Inv_taxesTableControlRow)), Inv_taxesTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Inv_taxesTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Inv_taxesTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
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

        Public Function GetRecordControls() As Inv_taxesTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_taxesTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Inv_taxesTableControlRow = DirectCast(repItem.FindControl("Inv_taxesTableControlRow"), Inv_taxesTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Inv_taxesTableControlRow)), Inv_taxesTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the Inv_termsTableControlRow control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_termsTableControlRow.
Public Class BaseInv_termsTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Inv_termsTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in Inv_termsTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Register the event handlers.
          
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource inv_terms record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Inv_termsTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseInv_termsTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New Inv_termsRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Inv_termsTableControlRow.
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
        
            Setnarration()
      
      
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
        
        
        Public Overridable Sub Setnarration()
            
        
            ' Set the narration Literal on the webpage with value from the
            ' inv_terms database record.

            ' Me.DataSource is the inv_terms record retrieved from the database.
            ' Me.narration is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setnarration()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.narrationSpecified Then
                				
                ' If the narration is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_termsTable.narration)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(100, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(100, Integer)
                        
                    End If                    
                    If maxLength = CType(100, Integer) Then
                        formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,maxLength))
                        formattedValue = formattedValue & "..."
                            
                    End If
                End If  
                
                Me.narration.Text = formattedValue
              
            Else 
            
                ' narration is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.narration.Text = Inv_termsTable.narration.Format(Inv_termsTable.narration.DefaultValue)
                        		
                End If
                 
            ' If the narration is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.narration.Text Is Nothing _
                OrElse Me.narration.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.narration.Text = "&nbsp;"
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

      
        
        ' To customize, override this method in Inv_termsTableControlRow.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
        Dim parentCtrl As Inv_hdrRecordControl
          
          
          parentCtrl = DirectCast(Me.Page.FindControlRecursively("Inv_hdrRecordControl"), Inv_hdrRecordControl)				  
              
          If (Not IsNothing(parentCtrl) AndAlso IsNothing(parentCtrl.DataSource)) 
                ' Load the record if it is not loaded yet.
                parentCtrl.LoadData()
            End If
            If (IsNothing(parentCtrl) OrElse IsNothing(parentCtrl.DataSource)) 
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:NoParentRecId", "ServelInvocing"))
            End If
            
            Me.DataSource.id_inv_hdr = parentCtrl.DataSource.id0
              
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
              
                DirectCast(GetParentControlObject(Me, "Inv_termsTableControl"), Inv_termsTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "Inv_termsTableControl"), Inv_termsTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in Inv_termsTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getnarration()
        End Sub
        
        
        Public Overridable Sub Getnarration()
            
        End Sub
                
      
        ' To customize, override this method in Inv_termsTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in Inv_termsTableControlRow.
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
          Inv_termsTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "Inv_termsTableControl"), Inv_termsTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "Inv_termsTableControl"), Inv_termsTableControl).ResetData = True
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
        
        Public Property RecordUniqueId() As String
            Get
                Return CType(Me.ViewState("BaseInv_termsTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseInv_termsTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Inv_termsRecord
        Public Property DataSource() As Inv_termsRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Inv_termsRecord)
            
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
        
        Public ReadOnly Property narration() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "narration"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Inv_termsRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Inv_termsRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Inv_termsTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the Inv_termsTableControl control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_termsTableControl.
Public Class BaseInv_termsTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
      
      
            ' Control Initializations.
            ' Initialize the table's current sort order.
            
            If Me.InSession(Me, "Order_By") Then
                Me.CurrentSortOrder = OrderBy.FromXmlString(Me.GetFromSession(Me, "Order_By", Nothing))
            Else
                Me.CurrentSortOrder = New OrderBy(True, True)
            
                Me.CurrentSortOrder.Add(Inv_termsTable.sort_order, OrderByItem.OrderDir.Asc)
              
            End If

            ' Setup default pagination settings.
        
            Me.PageSize = CInt(Me.GetFromSession(Me, "Page_Size", "1000"))
            Me.PageIndex = CInt(Me.GetFromSession(Me, "Page_Index", "0"))
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
            SaveControlsToSession_Ajax()
        
            ' Setup the pagination events.
            
            ' Setup the sorting events.
          
            ' Setup the button events.
          
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Inv_termsRecord)), Inv_termsRecord())
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
                
                Me.TotalRecords = Inv_termsTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(Inv_termsRecord)), Inv_termsRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As Inv_termsTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(Inv_termsRecord)), Inv_termsRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = Inv_termsTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
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
        
            SetnarrationLabel()
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As Inv_termsTableControlRow = DirectCast(repItem.FindControl("Inv_termsTableControlRow"), Inv_termsTableControlRow) 
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
            
            SetnarrationLabel()
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
            
                Me.CurrentSortOrder.Add(Inv_termsTable.sort_order, OrderByItem.OrderDir.Asc)
              
            End If
                
            Me.PageIndex = 0
        End Sub

        Protected Overridable Sub BindPaginationControls()
            ' Setup the pagination controls.

            ' Bind the buttons for Inv_termsTableControl pagination.
        

            ' Bind the pagination labels.
        
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As Inv_termsTableControlRow
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
            Inv_termsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
      Dim selectedRecordKeyValue as KeyValue = New KeyValue()
    
              Dim inv_hdrRecordControlObj As Inv_hdrRecordControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_hdrRecordControl"), Inv_hdrRecordControl)
              
                If (Not IsNothing(inv_hdrRecordControlObj) AndAlso Not IsNothing(inv_hdrRecordControlObj.GetRecord()) AndAlso Not IsNothing(inv_hdrRecordControlObj.GetRecord().id0))
                    wc.iAND(Inv_termsTable.id_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, inv_hdrRecordControlObj.GetRecord().id0.ToString())
                    selectedRecordKeyValue.AddElement(Inv_termsTable.id_inv_hdr.InternalName, inv_hdrRecordControlObj.GetRecord().id0.ToString())
                Else
                    wc.RunQuery = False
                    Return wc
                End If
              
      HttpContext.Current.Session("Inv_termsTableControlWhereClause") = selectedRecordKeyValue.ToXmlString()
    
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Inv_termsTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            Dim selectedRecordInInv_hdrRecordControl as String = DirectCast(HttpContext.Current.Session("Inv_termsTableControlWhereClause"), String)
            
            If Not selectedRecordInInv_hdrRecordControl Is Nothing AndAlso KeyValue.IsXmlKey(selectedRecordInInv_hdrRecordControl) Then
                Dim selectedRecordKeyValue as KeyValue = KeyValue.XmlToKey(selectedRecordInInv_hdrRecordControl)
                
       If Not IsNothing(selectedRecordKeyValue) AndAlso selectedRecordKeyValue.ContainsColumn(Inv_termsTable.id_inv_hdr) Then
            wc.iAND(Inv_termsTable.id_inv_hdr, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(Inv_termsTable.id_inv_hdr).ToString())
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
        
        End Sub

        Protected Overridable Sub AddNewRecords()
            
            Dim newRecordList As ArrayList = New ArrayList()
          
            Dim newUIDataList As System.Collections.Generic.List(Of Hashtable) = New System.Collections.Generic.List(Of Hashtable)()
      
            ' Loop though all the record controls and if the record control
            ' does not have a unique record id set, then create a record
            ' and add to the list.
            If Not Me.ResetData Then
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As Inv_termsTableControlRow = DirectCast(repItem.FindControl("Inv_termsTableControlRow"), Inv_termsTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As Inv_termsRecord = New Inv_termsRecord()
        
                        If recControl.narration.Text <> "" Then
                            rec.Parse(recControl.narration.Text, Inv_termsTable.narration)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New Inv_termsRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(Inv_termsRecord)), Inv_termsRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As Inv_termsTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As Inv_termsTableControlRow) As Boolean
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
        
        Public Overridable Sub SetnarrationLabel()
            
                    
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

            Dim orderByStr As String = CType(ViewState("Inv_termsTableControl_OrderBy"), String)
            
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
                Me.ViewState("Inv_termsTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        

        ' Generate the event handling functions for sorting events.
        

        ' Generate the event handling functions for button events.
        
      

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
        
        Private _DataSource() As Inv_termsRecord = Nothing
        Public Property DataSource() As Inv_termsRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As Inv_termsRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property Inv_termsTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Inv_termsTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property narrationLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "narrationLabel"), System.Web.UI.WebControls.Literal)
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
                Dim recCtl As Inv_termsTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As Inv_termsRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordControl() As Inv_termsTableControlRow
            Return Nothing
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As Inv_termsTableControlRow()
        
            Return DirectCast((new ArrayList()).ToArray(GetType(Inv_termsTableControlRow)), Inv_termsTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As Inv_termsTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As Inv_termsTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
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

        Public Function GetRecordControls() As Inv_termsTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("Inv_termsTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As Inv_termsTableControlRow = DirectCast(repItem.FindControl("Inv_termsTableControlRow"), Inv_termsTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(Inv_termsTableControlRow)), Inv_termsTableControlRow())
        End Function

        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

#End Region

    

End Class

  
' Base class for the Inv_hdrRecordControl control on the EmailInv_hdr page.
' Do not modify this class. Instead override any method in Inv_hdrRecordControl.
Public Class BaseInv_hdrRecordControl
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in Inv_hdrRecordControl.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
            ' Setup the filter and search events.
        					
              AddHandler Me.txtAddEmail.TextChanged, AddressOf txtAddEmail_TextChanged
                    					
              AddHandler Me.txtEmail.TextChanged, AddressOf txtEmail_TextChanged
                    
        End Sub

        '  To customize, override this method in Inv_hdrRecordControl.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
              ' Setup the pagination events.	  
         
              ' Register the event handlers.
          
            AddHandler Me.BtnEmail.Button.Click, AddressOf BtnEmail_Click
        					
              AddHandler Me.txtAddEmail.TextChanged, AddressOf txtAddEmail_TextChanged
                    					
              AddHandler Me.txtEmail.TextChanged, AddressOf txtEmail_TextChanged
                    
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource inv_hdr record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = Inv_hdrTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' This is the first time a record is being retrieved from the database.
            ' So create a Where Clause based on the staic Where clause specified
            ' on the Query wizard and the dynamic part specified by the end user
            ' on the search and filter controls (if any).
            
            Dim wc As WhereClause = Me.CreateWhereClause()
          
            Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Inv_hdrRecordControlPanel"), System.Web.UI.WebControls.Panel)
            If Not Panel is Nothing Then
                Panel.visible = True
            End If
            
            ' If there is no Where clause, then simply create a new, blank record.
             
            If wc Is Nothing OrElse Not wc.RunQuery Then
                Me.DataSource = New Inv_hdrRecord()
            
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
          
            ' Retrieve the record from the database.  It is possible
            
            Dim recList() As Inv_hdrRecord = Inv_hdrTable.GetRecords(wc, Nothing, 0, 2)
            If recList.Length = 0 Then
                ' There is no data for this Where clause.
                wc.RunQuery = False
                
                If Not Panel is Nothing Then
                    Panel.visible = False
                End If
                
                Return
            End If
            
            ' Set DataSource based on record retrieved from the database.
            Me.DataSource = Inv_hdrTable.GetRecord(recList(0).GetID.ToXmlString(), True)
                  
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in Inv_hdrRecordControl.
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
        
            Setadditional_email()
            Setadditional_emailLabel()
            Setbill_address()
            Setbill_addressLabel()
            Setbill_name()
            Setbill_nameLabel()
            Setcontact()
            SetcontactLabel()
            Setemail()
            SetemailLabel()
            Setgrand_total()
            Setgrand_totalLabel()
            Setid1()
            Setinv_dt()
            Setinv_dtLabel()
            Setinv_no()
            Setinv_noLabel()
            Setitem_total()
            Setitem_totalLabel()
            Setphone()
            SetphoneLabel()
            Setpo_dt()
            Setpo_dtLabel()
            Setpo_no()
            Setpo_noLabel()
            Setsale_ord_dt()
            Setsale_ord_dtLabel()
            Setsale_ord_no()
            Setsale_ord_noLabel()
            Setship_address()
            Setship_addressLabel()
            Setship_name()
            Setship_nameLabel()
            Settin_no()
            Settin_noLabel()
            SettxtAddEmail()
            SettxtEmail()
      
      
            Me.IsNewRecord = True
            
            If Me.DataSource.IsCreated Then
                Me.IsNewRecord = False
                
                Me.RecordUniqueId = Me.DataSource.GetID.ToXmlString()
            End If
          
            ' Now load data for each record and table child UI controls.
            ' Ordering is important because child controls get 
            ' their parent ids from their parent UI controls.
            Dim shouldResetControl As Boolean = False
            
        Dim recInv_itemsTableControl as Inv_itemsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_itemsTableControl"), Inv_itemsTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recInv_itemsTableControl.ResetControl()
            End IF
        
        recInv_itemsTableControl.LoadData()
        recInv_itemsTableControl.DataBind()
        
        Dim recInv_taxesTableControl as Inv_taxesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_taxesTableControl"), Inv_taxesTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recInv_taxesTableControl.ResetControl()
            End IF
        
        recInv_taxesTableControl.LoadData()
        recInv_taxesTableControl.DataBind()
        
        Dim recInv_termsTableControl as Inv_termsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_termsTableControl"), Inv_termsTableControl)
        
            If (shouldResetControl OrElse Me.Page.IsPageRefresh)
              recInv_termsTableControl.ResetControl()
            End IF
        
        recInv_termsTableControl.LoadData()
        recInv_termsTableControl.DataBind()
              
        End Sub
        
        
        Public Overridable Sub Setadditional_email()
            
        
            ' Set the additional_email Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.additional_email is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setadditional_email()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.additional_emailSpecified Then
                				
                ' If the additional_email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.additional_email)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.additional_email.Text = formattedValue
              
            Else 
            
                ' additional_email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.additional_email.Text = Inv_hdrTable.additional_email.Format(Inv_hdrTable.additional_email.DefaultValue)
                        		
                End If
                 
            ' If the additional_email is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.additional_email.Text Is Nothing _
                OrElse Me.additional_email.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.additional_email.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setbill_address()
            
        
            ' Set the bill_address Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.bill_address is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setbill_address()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.bill_addressSpecified Then
                				
                ' If the bill_address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.bill_address)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(100, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(100, Integer)
                        
                    End If                    
                    If maxLength = CType(100, Integer) Then
                        formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,maxLength))
                        formattedValue = formattedValue & "..."
                            
                    End If
                End If  
                
                Me.bill_address.Text = formattedValue
              
            Else 
            
                ' bill_address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.bill_address.Text = Inv_hdrTable.bill_address.Format(Inv_hdrTable.bill_address.DefaultValue)
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.bill_name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setbill_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.bill_nameSpecified Then
                				
                ' If the bill_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.bill_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.bill_name.Text = formattedValue
              
            Else 
            
                ' bill_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.bill_name.Text = Inv_hdrTable.bill_name.Format(Inv_hdrTable.bill_name.DefaultValue)
                        		
                End If
                 
            ' If the bill_name is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.bill_name.Text Is Nothing _
                OrElse Me.bill_name.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.bill_name.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setcontact()
            
        
            ' Set the contact Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.contact is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setcontact()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.contactSpecified Then
                				
                ' If the contact is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.contact)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.contact.Text = formattedValue
              
            Else 
            
                ' contact is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.contact.Text = Inv_hdrTable.contact.Format(Inv_hdrTable.contact.DefaultValue)
                        		
                End If
                 
            ' If the contact is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.contact.Text Is Nothing _
                OrElse Me.contact.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.contact.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setemail()
            
        
            ' Set the email Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.email is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setemail()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.emailSpecified Then
                				
                ' If the email is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.email)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.email.Text = formattedValue
              
            Else 
            
                ' email is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.email.Text = Inv_hdrTable.email.Format(Inv_hdrTable.email.DefaultValue)
                        		
                End If
                 
            ' If the email is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.email.Text Is Nothing _
                OrElse Me.email.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.email.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setgrand_total()
            
        
            ' Set the grand_total Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.grand_total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgrand_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.grand_totalSpecified Then
                				
                ' If the grand_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.grand_total, "c")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.grand_total.Text = formattedValue
              
            Else 
            
                ' grand_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.grand_total.Text = Inv_hdrTable.grand_total.Format(Inv_hdrTable.grand_total.DefaultValue, "c")
                        		
                End If
                 
            ' If the grand_total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.grand_total.Text Is Nothing _
                OrElse Me.grand_total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.grand_total.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setid1()
            
        
            ' Set the id Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.id1 is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setid1()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.id0Specified Then
                				
                ' If the id is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.id0)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.id1.Text = formattedValue
              
            Else 
            
                ' id is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.id1.Text = Inv_hdrTable.id0.Format(Inv_hdrTable.id0.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setinv_dt()
            
        
            ' Set the inv_dt Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.inv_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_dtSpecified Then
                				
                ' If the inv_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.inv_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_dt.Text = formattedValue
              
            Else 
            
                ' inv_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_dt.Text = Inv_hdrTable.inv_dt.Format(Inv_hdrTable.inv_dt.DefaultValue, "d")
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.inv_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setinv_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.inv_noSpecified Then
                				
                ' If the inv_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.inv_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.inv_no.Text = formattedValue
              
            Else 
            
                ' inv_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.inv_no.Text = Inv_hdrTable.inv_no.Format(Inv_hdrTable.inv_no.DefaultValue)
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.item_total is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setitem_total()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.item_totalSpecified Then
                				
                ' If the item_total is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.item_total, "c")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.item_total.Text = formattedValue
              
            Else 
            
                ' item_total is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.item_total.Text = Inv_hdrTable.item_total.Format(Inv_hdrTable.item_total.DefaultValue, "c")
                        		
                End If
                 
            ' If the item_total is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.item_total.Text Is Nothing _
                OrElse Me.item_total.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.item_total.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setphone()
            
        
            ' Set the phone Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.phone is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setphone()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.phoneSpecified Then
                				
                ' If the phone is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.phone)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.phone.Text = formattedValue
              
            Else 
            
                ' phone is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.phone.Text = Inv_hdrTable.phone.Format(Inv_hdrTable.phone.DefaultValue)
                        		
                End If
                 
            ' If the phone is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.phone.Text Is Nothing _
                OrElse Me.phone.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.phone.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setpo_dt()
            
        
            ' Set the po_dt Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.po_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpo_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.po_dtSpecified Then
                				
                ' If the po_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.po_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.po_dt.Text = formattedValue
              
            Else 
            
                ' po_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.po_dt.Text = Inv_hdrTable.po_dt.Format(Inv_hdrTable.po_dt.DefaultValue, "d")
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.po_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setpo_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.po_noSpecified Then
                				
                ' If the po_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.po_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.po_no.Text = formattedValue
              
            Else 
            
                ' po_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.po_no.Text = Inv_hdrTable.po_no.Format(Inv_hdrTable.po_no.DefaultValue)
                        		
                End If
                 
            ' If the po_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.po_no.Text Is Nothing _
                OrElse Me.po_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.po_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setsale_ord_dt()
            
        
            ' Set the sale_ord_dt Literal on the webpage with value from the
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.sale_ord_dt is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsale_ord_dt()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sale_ord_dtSpecified Then
                				
                ' If the sale_ord_dt is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.sale_ord_dt, "d")
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sale_ord_dt.Text = formattedValue
              
            Else 
            
                ' sale_ord_dt is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sale_ord_dt.Text = Inv_hdrTable.sale_ord_dt.Format(Inv_hdrTable.sale_ord_dt.DefaultValue, "d")
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.sale_ord_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setsale_ord_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.sale_ord_noSpecified Then
                				
                ' If the sale_ord_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.sale_ord_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.sale_ord_no.Text = formattedValue
              
            Else 
            
                ' sale_ord_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.sale_ord_no.Text = Inv_hdrTable.sale_ord_no.Format(Inv_hdrTable.sale_ord_no.DefaultValue)
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.ship_address is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setship_address()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ship_addressSpecified Then
                				
                ' If the ship_address is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.ship_address)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                If Not formattedValue is Nothing Then
                              
                    Dim maxLength as Integer = Len(formattedValue)
                    If (maxLength > CType(100, Integer)) Then
                        ' Truncate based on FieldMaxLength on Properties.
                        maxLength = CType(100, Integer)
                        
                    End If                    
                    If maxLength = CType(100, Integer) Then
                        formattedValue= NetUtils.EncodeStringForHtmlDisplay(formattedValue.SubString(0,maxLength))
                        formattedValue = formattedValue & "..."
                            
                    End If
                End If  
                
                Me.ship_address.Text = formattedValue
              
            Else 
            
                ' ship_address is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ship_address.Text = Inv_hdrTable.ship_address.Format(Inv_hdrTable.ship_address.DefaultValue)
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.ship_name is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setship_name()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.ship_nameSpecified Then
                				
                ' If the ship_name is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.ship_name)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.ship_name.Text = formattedValue
              
            Else 
            
                ' ship_name is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.ship_name.Text = Inv_hdrTable.ship_name.Format(Inv_hdrTable.ship_name.DefaultValue)
                        		
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
            ' inv_hdr database record.

            ' Me.DataSource is the inv_hdr record retrieved from the database.
            ' Me.tin_no is the ASP:Literal on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Settin_no()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.tin_noSpecified Then
                				
                ' If the tin_no is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(Inv_hdrTable.tin_no)
                            
                formattedValue = HttpUtility.HtmlEncode(formattedValue)
                Me.tin_no.Text = formattedValue
              
            Else 
            
                ' tin_no is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.tin_no.Text = Inv_hdrTable.tin_no.Format(Inv_hdrTable.tin_no.DefaultValue)
                        		
                End If
                 
            ' If the tin_no is NULL or blank, then use the value specified  
            ' on Properties.
            If Me.tin_no.Text Is Nothing _
                OrElse Me.tin_no.Text.Trim() = "" Then
                ' Set the value specified on the Properties.
                Me.tin_no.Text = "&nbsp;"
            End If
                  
        End Sub
                
        Public Overridable Sub Setadditional_emailLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setbill_addressLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setbill_nameLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetcontactLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetemailLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgrand_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setinv_noLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setitem_totalLabel()
            
                    
        End Sub
                
        Public Overridable Sub SetphoneLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpo_dtLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setpo_noLabel()
            
                    
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
                
        Public Overridable Sub SettxtAddEmail()
            
                    
        End Sub
                
        Public Overridable Sub SettxtEmail()
            
                    
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

      
        
        ' To customize, override this method in Inv_hdrRecordControl.
        Public Overridable Sub SaveData()
            ' Saves the associated record in the database.
            ' SaveData calls Validate and Get methods - so it may be more appropriate to
            ' customize those methods.

            ' 1. Load the existing record from the database. Since we save the entire record, this ensures 
            ' that fields that are not displayed are also properly initialized.
            Me.LoadData()
        
          Dim Panel As System.Web.UI.WebControls.Panel = CType(MiscUtils.FindControlRecursively(Me, "Inv_hdrRecordControlPanel"), System.Web.UI.WebControls.Panel)

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
          
        Dim recInv_itemsTableControl as Inv_itemsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_itemsTableControl"), Inv_itemsTableControl)
        recInv_itemsTableControl.SaveData()
        
        Dim recInv_taxesTableControl as Inv_taxesTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_taxesTableControl"), Inv_taxesTableControl)
        recInv_taxesTableControl.SaveData()
        
        Dim recInv_termsTableControl as Inv_termsTableControl = DirectCast(MiscUtils.FindControlRecursively(Me.Page, "Inv_termsTableControl"), Inv_termsTableControl)
        recInv_termsTableControl.SaveData()
        
        End Sub

        ' To customize, override this method in Inv_hdrRecordControl.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getadditional_email()
            Getbill_address()
            Getbill_name()
            Getcontact()
            Getemail()
            Getgrand_total()
            Getid1()
            Getinv_dt()
            Getinv_no()
            Getitem_total()
            Getphone()
            Getpo_dt()
            Getpo_no()
            Getsale_ord_dt()
            Getsale_ord_no()
            Getship_address()
            Getship_name()
            Gettin_no()
        End Sub
        
        
        Public Overridable Sub Getadditional_email()
            
        End Sub
                
        Public Overridable Sub Getbill_address()
            
        End Sub
                
        Public Overridable Sub Getbill_name()
            
        End Sub
                
        Public Overridable Sub Getcontact()
            
        End Sub
                
        Public Overridable Sub Getemail()
            
        End Sub
                
        Public Overridable Sub Getgrand_total()
            
        End Sub
                
        Public Overridable Sub Getid1()
            
        End Sub
                
        Public Overridable Sub Getinv_dt()
            
        End Sub
                
        Public Overridable Sub Getinv_no()
            
        End Sub
                
        Public Overridable Sub Getitem_total()
            
        End Sub
                
        Public Overridable Sub Getphone()
            
        End Sub
                
        Public Overridable Sub Getpo_dt()
            
        End Sub
                
        Public Overridable Sub Getpo_no()
            
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
                
      
        ' To customize, override this method in Inv_hdrRecordControl.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Dim wc As WhereClause
            Inv_hdrTable.Instance.InnerFilter = Nothing
            wc = New WhereClause()
            
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected filter criteria.
            ' 3. User selected search criteria.

            
            ' Retrieve the record id from the URL parameter.
              
            Dim recId As String = Me.Page.Request.QueryString.Item("Inv_hdr")
                
            If recId Is Nothing OrElse recId.Trim = "" Then
                ' Get the error message from the application resource file.
                Throw New Exception(Page.GetResourceValue("Err:UrlParamMissing", "ServelInvocing").Replace("{URL}", "Inv_hdr"))
            End If
            HttpContext.Current.Session("QueryString in EmailInv_hdr") = recId
              
            If KeyValue.IsXmlKey(recId) Then
                ' Keys are typically passed as XML structures to handle composite keys.
                ' If XML, then add a Where clause based on the Primary Key in the XML.
                Dim pkValue As KeyValue = KeyValue.XmlToKey(recId)
                
                wc.iAND(Inv_hdrTable.id0, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValue(Inv_hdrTable.id0).ToString())
        
            Else
                ' The URL parameter contains the actual value, not an XML structure.
                
                wc.iAND(Inv_hdrTable.id0, BaseFilter.ComparisonOperator.EqualsTo, recId)
        
            End If
              
            
            Return wc
          
        End Function
        
        ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
        
        Public Overridable Function CreateWhereClause(ByVal searchText As String, ByVal fromSearchControl As String, ByVal AutoTypeAheadSearch As String, ByVal AutoTypeAheadWordSeparators As String) As WhereClause
            Inv_hdrTable.Instance.InnerFilter = Nothing
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
        

        ' To customize, override this method in Inv_hdrRecordControl.
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
          Inv_hdrTable.DeleteRecord(pkValue)
          
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
            
        ' event handler for Button with Layout
        Public Overridable Sub BtnEmail_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            		
        Protected Overridable Sub txtAddEmail_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
             
        End Sub
                    		
        Protected Overridable Sub txtEmail_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
             
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
                Return CType(Me.ViewState("BaseInv_hdrRecordControl_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseInv_hdrRecordControl_Rec") = value
            End Set
        End Property
        
        Private _DataSource As Inv_hdrRecord
        Public Property DataSource() As Inv_hdrRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As Inv_hdrRecord)
            
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
        
        Public ReadOnly Property additional_email() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "additional_email"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property additional_emailLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "additional_emailLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property bill_address() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_address"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property bill_addressLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_addressLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property bill_name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property bill_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "bill_nameLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property BtnEmail() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "BtnEmail"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property contact() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contact"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property contactLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "contactLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property grand_total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property grand_totalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "grand_totalLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property id1() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "id1"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property Inv_hdrTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "Inv_hdrTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property inv_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property inv_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "inv_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property item_total() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_total"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property item_totalLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "item_totalLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property po_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property po_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property po_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property po_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "po_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property sale_ord_dt() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_dt"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property sale_ord_dtLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_dtLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property sale_ord_no() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_no"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property sale_ord_noLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "sale_ord_noLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ship_address() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_address"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ship_addressLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_addressLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property ship_name() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_name"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
            
        Public ReadOnly Property ship_nameLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "ship_nameLabel"), System.Web.UI.WebControls.Literal)
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
        
        Public ReadOnly Property txtAddEmail() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "txtAddEmail"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property txtEmail() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "txtEmail"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As Inv_hdrRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As Inv_hdrRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return Inv_hdrTable.GetRecord(Me.RecordUniqueId, True)
                
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

  