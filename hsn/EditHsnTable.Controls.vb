
' This file implements the TableControl, TableControlRow, and RecordControl classes for the 
' EditHsnTable.aspx page.  The Row or RecordControl classes are the 
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

  
Namespace ServelInvocing.UI.Controls.EditHsnTable

#Region "Section 1: Place your customizations here."

    
Public Class HsnTableControlRow
        Inherits BaseHsnTableControlRow
        ' The BaseHsnTableControlRow implements code for a ROW within the
        ' the HsnTableControl table.  The BaseHsnTableControlRow implements the DataBind and SaveData methods.
        ' The loading of data is actually performed by the LoadData method in the base class of HsnTableControl.

        ' This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        ' SaveData, GetUIData, and Validate methods.
        

End Class

  

Public Class HsnTableControl
        Inherits BaseHsnTableControl

    ' The BaseHsnTableControl class implements the LoadData, DataBind, CreateWhereClause
    ' and other methods to load and display the data in a table control.

    ' This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    ' The HsnTableControlRow class offers another place where you can customize
    ' the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

End Class

  

#End Region

  

#Region "Section 2: Do not modify this section."
    
    
' Base class for the HsnTableControlRow control on the EditHsnTable page.
' Do not modify this class. Instead override any method in HsnTableControlRow.
Public Class BaseHsnTableControlRow
        Inherits ServelInvocing.UI.BaseApplicationRecordControl

        '  To customize, override this method in HsnTableControlRow.
        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
      
        End Sub

        '  To customize, override this method in HsnTableControlRow.
        Protected Overridable Sub Control_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			'Call LoadFocusScripts from repeater so that onfocus attribute could be added to elements
			Me.Page.LoadFocusScripts(Me)
		
              ' Show confirmation message on Click
              Me.HsnRowDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteRecordConfirm", "ServelInvocing") & "'));")
              ' Register the event handlers.
          
              AddHandler Me.HsnRowDeleteButton.Click, AddressOf HsnRowDeleteButton_Click
              
              AddHandler Me.HsnRowEditButton.Click, AddressOf HsnRowEditButton_Click
              
              AddHandler Me.HsnRowViewButton.Click, AddressOf HsnRowViewButton_Click
              
              AddHandler Me.gst_description.TextChanged, AddressOf gst_description_TextChanged
            
              AddHandler Me.gst_uom.TextChanged, AddressOf gst_uom_TextChanged
            
              AddHandler Me.hsn.TextChanged, AddressOf hsn_TextChanged
            
        End Sub

        
        Public Overridable Sub LoadData()        
            ' Load the data from the database into the DataSource hsn record.
            ' It is better to make changes to functions called by LoadData such as
            ' CreateWhereClause, rather than making changes here.
    
            ' The RecordUniqueId is set the first time a record is loaded, and is
            ' used during a PostBack to load the record.
          
            If Me.RecordUniqueId IsNot Nothing AndAlso Me.RecordUniqueId.Trim <> "" Then
                Me.DataSource = HsnTable.GetRecord(Me.RecordUniqueId, True)
          
                Return
            End If
        
            ' Since this is a row in the table, the data for this row is loaded by the 
            ' LoadData method of the BaseHsnTableControl when the data for the entire
            ' table is loaded.
            
            Me.DataSource = New HsnRecord()
          
        End Sub

        ' Populate the UI controls using the DataSource.  To customize, override this method in HsnTableControlRow.
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
        
            Setgst_description()
            Setgst_uom()
            Sethsn()
      
      
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
        
        
        Public Overridable Sub Setgst_description()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.gst_description.ID) Then
            
                Me.gst_description.Text = Me.PreviousUIData(Me.gst_description.ID).ToString()
              
                Return
            End If
            
        
            ' Set the gst_description TextBox on the webpage with value from the
            ' hsn database record.

            ' Me.DataSource is the hsn record retrieved from the database.
            ' Me.gst_description is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_description()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_descriptionSpecified Then
                				
                ' If the gst_description is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(HsnTable.gst_description)
                            
                Me.gst_description.Text = formattedValue
              
            Else 
            
                ' gst_description is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_description.Text = HsnTable.gst_description.Format(HsnTable.gst_description.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Setgst_uom()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.gst_uom.ID) Then
            
                Me.gst_uom.Text = Me.PreviousUIData(Me.gst_uom.ID).ToString()
              
                Return
            End If
            
        
            ' Set the gst_uom TextBox on the webpage with value from the
            ' hsn database record.

            ' Me.DataSource is the hsn record retrieved from the database.
            ' Me.gst_uom is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Setgst_uom()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.gst_uomSpecified Then
                				
                ' If the gst_uom is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(HsnTable.gst_uom)
                            
                Me.gst_uom.Text = formattedValue
              
            Else 
            
                ' gst_uom is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.gst_uom.Text = HsnTable.gst_uom.Format(HsnTable.gst_uom.DefaultValue)
                        		
                End If
                 
        End Sub
                
        Public Overridable Sub Sethsn()
            					
            ' If data was retrieved from UI previously, restore it
            If Me.PreviousUIData.ContainsKey(Me.hsn.ID) Then
            
                Me.hsn.Text = Me.PreviousUIData(Me.hsn.ID).ToString()
              
                Return
            End If
            
        
            ' Set the hsn TextBox on the webpage with value from the
            ' hsn database record.

            ' Me.DataSource is the hsn record retrieved from the database.
            ' Me.hsn is the ASP:TextBox on the webpage.
            
            ' You can modify this method directly, or replace it with a call to
            '     MyBase.Sethsn()
            ' and add your own code before or after the call to the MyBase function.

            
                  
            If Me.DataSource IsNot Nothing AndAlso Me.DataSource.hsnSpecified Then
                				
                ' If the hsn is non-NULL, then format the value.

                ' The Format method will use the Display Format
                                Dim formattedValue As String = Me.DataSource.Format(HsnTable.hsn)
                            
                Me.hsn.Text = formattedValue
              
            Else 
            
                ' hsn is NULL in the database, so use the Default Value.  
                ' Default Value could also be NULL.
        
                Me.hsn.Text = HsnTable.hsn.Format(HsnTable.hsn.DefaultValue)
                        		
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

      
        
        ' To customize, override this method in HsnTableControlRow.
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
              
                DirectCast(GetParentControlObject(Me, "HsnTableControl"), HsnTableControl).DataChanged = True
                DirectCast(GetParentControlObject(Me, "HsnTableControl"), HsnTableControl).ResetData = True
            End If
            
      
            ' update session or cookie by formula
                                    
      
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
            Me.ResetData = True
            
            ' For Master-Detail relationships, save data on the Detail table(s)
          
        End Sub

        ' To customize, override this method in HsnTableControlRow.
        Public Overridable Sub GetUIData()
            ' The GetUIData method retrieves the updated values from the user interface 
            ' controls into a database record in preparation for saving or updating.
            ' To do this, it calls the Get methods for each of the field displayed on 
            ' the webpage.  It is better to make changes in the Get methods, rather 
            ' than making changes here.
            
      
            ' Call the Get methods for each of the user interface controls.
        
            Getgst_description()
            Getgst_uom()
            Gethsn()
        End Sub
        
        
        Public Overridable Sub Getgst_description()
            
            ' Retrieve the value entered by the user on the gst_description ASP:TextBox, and
            ' save it into the gst_description field in DataSource hsn record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.gst_description.Text, HsnTable.gst_description)			

                      
        End Sub
                
        Public Overridable Sub Getgst_uom()
            
            ' Retrieve the value entered by the user on the gst_uom ASP:TextBox, and
            ' save it into the gst_uom field in DataSource hsn record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.gst_uom.Text, HsnTable.gst_uom)			

                      
        End Sub
                
        Public Overridable Sub Gethsn()
            
            ' Retrieve the value entered by the user on the hsn ASP:TextBox, and
            ' save it into the hsn field in DataSource hsn record.
            
            ' Custom validation should be performed in Validate, not here.
            
            'Save the value to data source
            Me.DataSource.Parse(Me.hsn.Text, HsnTable.hsn)			

                      
        End Sub
                
      
        ' To customize, override this method in HsnTableControlRow.
        
        Public Overridable Function CreateWhereClause() As WhereClause
        
            Return Nothing
            
        End Function
        

        ' To customize, override this method in HsnTableControlRow.
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
          HsnTable.DeleteRecord(pkValue)
          
            DirectCast(GetParentControlObject(Me, "HsnTableControl"), HsnTableControl).DataChanged = True
            DirectCast(GetParentControlObject(Me, "HsnTableControl"), HsnTableControl).ResetData = True
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
        Public Overridable Sub HsnRowDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
            If(Not Me.Page.IsPageRefresh) Then
        
                Dim tc As HsnTableControl = DirectCast(GetParentControlObject(Me, "HsnTableControl"), HsnTableControl)
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
        Public Overridable Sub HsnRowEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/ConfigureEditRecord.aspx"
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
        Public Overridable Sub HsnRowViewButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/ConfigureViewRecord.aspx"
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
        
        Protected Overridable Sub gst_description_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub gst_uom_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
        End Sub
            
        Protected Overridable Sub hsn_TextChanged(ByVal sender As Object, ByVal args As EventArgs)                
                    				
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
                Return CType(Me.ViewState("BaseHsnTableControlRow_Rec"), String)
            End Get
            Set(ByVal value As String)
                Me.ViewState("BaseHsnTableControlRow_Rec") = value
            End Set
        End Property
        
        Private _DataSource As HsnRecord
        Public Property DataSource() As HsnRecord     
            Get
                Return Me._DataSource
            End Get
            
            Set(ByVal value As HsnRecord)
            
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
        
        Public ReadOnly Property gst_description() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_description"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property gst_uom() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_uom"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property hsn() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "hsn"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
            
        Public ReadOnly Property HsnRecordRowSelection() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnRecordRowSelection"), System.Web.UI.WebControls.CheckBox)
            End Get
        End Property
        
        Public ReadOnly Property HsnRowDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnRowDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnRowEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnRowEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnRowViewButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnRowViewButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
#End Region

#Region "Helper Functions"

        Public Overrides Overloads Function ModifyRedirectUrl(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            Return Me.Page.EvaluateExpressions(url, arg, bEncrypt, Me)
        End Function

        Public Overrides Overloads Function EvaluateExpressions(ByVal url As String, ByVal arg As String, ByVal bEncrypt As Boolean) As String
            
            Dim rec As HsnRecord = Nothing
             
        
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

         
        Public Overridable Function GetRecord() As HsnRecord
            If Not Me.DataSource Is Nothing Then
                Return Me.DataSource
            End If
            
            If Not Me.RecordUniqueId Is Nothing Then
                
                Return HsnTable.GetRecord(Me.RecordUniqueId, True)
                
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

  

' Base class for the HsnTableControl control on the EditHsnTable page.
' Do not modify this class. Instead override any method in HsnTableControl.
Public Class BaseHsnTableControl
        Inherits ServelInvocing.UI.BaseApplicationTableControl

        

        Protected Overridable Sub Control_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
  
      	  	  
      
           ' Setup the filter and search events.
        
            AddHandler Me.gst_descriptionFilter.SelectedIndexChanged, AddressOf gst_descriptionFilter_SelectedIndexChanged
            AddHandler Me.gst_uomFilter.SelectedIndexChanged, AddressOf gst_uomFilter_SelectedIndexChanged
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.gst_descriptionFilter) 				
                    initialVal = Me.GetFromSession(Me.gst_descriptionFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.gst_descriptionFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.gst_descriptionFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.gst_uomFilter) 				
                    initialVal = Me.GetFromSession(Me.gst_uomFilter)
                
                End If
                If initialVal <> ""				
                        
                        Me.gst_uomFilter.Items.Add(New ListItem(initialVal, initialVal))
                            
                        Me.gst_uomFilter.SelectedValue = initialVal
                            
                    End If
                
            End If
            If Not Me.Page.IsPostBack Then
                Dim initialVal As String = ""
                If  Me.InSession(Me.HsnSearch) 				
                    initialVal = Me.GetFromSession(Me.HsnSearch)
                
                End If
                If initialVal <> ""				
                        
                        Me.HsnSearch.Text = initialVal
                            
                    End If
                
            End If
      
      
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
              Me.HsnDeleteButton.Attributes.Add("onClick", "return (confirm('" & (CType(Me.Page,BaseApplicationPage)).GetResourceValue("DeleteConfirm", "ServelInvocing") & "'));")
            ' Setup the pagination events.
            
              AddHandler Me.HsnPagination.FirstPage.Click, AddressOf HsnPagination_FirstPage_Click
              
              AddHandler Me.HsnPagination.LastPage.Click, AddressOf HsnPagination_LastPage_Click
              
              AddHandler Me.HsnPagination.NextPage.Click, AddressOf HsnPagination_NextPage_Click
              
              AddHandler Me.HsnPagination.PageSizeButton.Click, AddressOf HsnPagination_PageSizeButton_Click
            
              AddHandler Me.HsnPagination.PreviousPage.Click, AddressOf HsnPagination_PreviousPage_Click
              
            ' Setup the sorting events.
          
              AddHandler Me.gst_descriptionLabel1.Click, AddressOf gst_descriptionLabel1_Click
            
              AddHandler Me.gst_uomLabel1.Click, AddressOf gst_uomLabel1_Click
            
              AddHandler Me.hsnLabel.Click, AddressOf hsnLabel_Click
            
            ' Setup the button events.
          
              AddHandler Me.HsnAddButton.Click, AddressOf HsnAddButton_Click
              
              AddHandler Me.HsnDeleteButton.Click, AddressOf HsnDeleteButton_Click
              
              AddHandler Me.HsnEditButton.Click, AddressOf HsnEditButton_Click
              
              AddHandler Me.HsnRefreshButton.Click, AddressOf HsnRefreshButton_Click
              
              AddHandler Me.HsnResetButton.Click, AddressOf HsnResetButton_Click
              
              AddHandler Me.HsnSaveButton.Click, AddressOf HsnSaveButton_Click
              
            Me.HsnSaveButton.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.Page.GetResourceValue("Txt:SaveRecord", "ServelInvocing") & """);")
        
            AddHandler Me.HsnSearchButton.Button.Click, AddressOf HsnSearchButton_Click
        
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(HsnRecord)), HsnRecord())
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
                
                Me.TotalRecords = HsnTable.GetRecordCount(wc)
                              
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
                    Me.DataSource = DirectCast(alist.ToArray(GetType(HsnRecord)), HsnRecord())
                    
                ElseIf Me.AddNewRecord > 0 Then
                ' Make sure to preserve the previously entered data on new rows.
                
                    Dim postdata As New ArrayList
                    For Each rc As HsnTableControlRow In Me.GetRecordControls()
                        If Not rc.IsNewRecord Then
                            rc.DataSource = rc.GetRecord()
                            rc.GetUIData()
                            postdata.Add(rc.DataSource)
                            UIData.Add(rc.PreservedUIData())							
                        End If
                    Next
                    Me.DataSource = DirectCast(postdata.ToArray(GetType(HsnRecord)), HsnRecord())
                
                Else  ' Get the records from the database	
                    Me.DataSource = HsnTable.GetRecords(wc, orderBy, Me.PageIndex, Me.PageSize) 
                End If
                
                ' Add any new rows desired by the user.
                Me.AddNewRecords()
            
                ' Turn off the ToggleAll checkbox
                Me.HsnToggleAll.Checked = False
            

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
        
            Setgst_descriptionFilter()
            
            Setgst_descriptionLabel()
            Setgst_descriptionLabel1()
            Setgst_uomFilter()
            
            Setgst_uomLabel()
            Setgst_uomLabel1()
            SethsnLabel()
            SetHsnSearch()
            
      
  

            ' Bind the repeater with the list of records to expand the UI.
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("HsnTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return
            rep.DataSource = DataSource()
            rep.DataBind()

            Dim index As Integer = 0
            For Each repItem As System.Web.UI.WebControls.RepeaterItem In rep.Items
                ' Loop through all rows in the table, set its DataSource and call DataBind().
                Dim recControl As HsnTableControlRow = DirectCast(repItem.FindControl("HsnTableControlRow"), HsnTableControlRow) 
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
            
            Setgst_descriptionLabel()
            Setgst_descriptionLabel1()
            Setgst_uomLabel()
            Setgst_uomLabel1()
            SethsnLabel()
      End Sub

      
      
        Public Overridable Sub RegisterPostback()
        
              Me.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"HsnSaveButton"))
                        
        
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
                    
            Me.gst_descriptionFilter.ClearSelection()
            
            Me.gst_uomFilter.ClearSelection()
            
            Me.HsnSearch.Text = ""
            
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

            ' Bind the buttons for HsnTableControl pagination.
        
            Me.HsnPagination.FirstPage.Enabled = Not (Me.PageIndex = 0)
            Me.HsnPagination.LastPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.HsnPagination.LastPage.Enabled = False
            End If
          
            Me.HsnPagination.NextPage.Enabled = Not (Me.PageIndex = Me.TotalPages - 1)
            If Me.TotalPages = 0 Then
                Me.HsnPagination.NextPage.Enabled = False
            End If
          
            Me.HsnPagination.PreviousPage.Enabled = Not (Me.PageIndex = 0)

            ' Bind the pagination labels.
        
            If Me.TotalPages > 0 Then
                Me.HsnPagination.CurrentPage.Text = (Me.PageIndex + 1).ToString()
            Else
                Me.HsnPagination.CurrentPage.Text = "0"
            End If
            Me.HsnPagination.PageSize.Text = Me.PageSize.ToString()
            Me.HsnPagination.TotalItems.Text = Me.TotalRecords.ToString()
            Me.HsnPagination.TotalPages.Text = Me.TotalPages.ToString()
        End Sub

        Public Overridable Sub SaveData()
            ' Save the data from the entire table.  Calls each row's Save Data
            ' to save their data.  This function is called by the Click handler of the
            ' Save button.  The button handler should Start/Commit/End a transaction.
            
            Dim recCtl As HsnTableControlRow
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
            HsnTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
              
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.

              
            If IsValueSelected(Me.gst_descriptionFilter) Then
                
                wc.iAND(HsnTable.gst_description, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.gst_descriptionFilter, Me.GetFromSession(Me.gst_descriptionFilter)), False, False)
            
                
            End If
                       
            If IsValueSelected(Me.gst_uomFilter) Then
                
                wc.iAND(HsnTable.gst_uom, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(Me.gst_uomFilter, Me.GetFromSession(Me.gst_uomFilter)), False, False)
            
                
            End If
                       
            If IsValueSelected(Me.HsnSearch) Then
                ' Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                If Me.HsnSearch.Text.StartsWith("...") Then
                    Me.HsnSearch.Text = Me.HsnSearch.Text.SubString(3,Me.HsnSearch.Text.Length-3)
                End If
                If Me.HsnSearch.Text.EndsWith("...") then
                    Me.HsnSearch.Text = Me.HsnSearch.Text.SubString(0,Me.HsnSearch.Text.Length-3)
                End If
                
                Dim formatedSearchText As String = MiscUtils.GetSelectedValue(Me.HsnSearch, Me.GetFromSession(Me.HsnSearch))
                
                ' After stripping "..." see if the search text is null or empty.
                If IsValueSelected(Me.HsnSearch) Then 
        ' These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                    
                    Dim search As WhereClause = New WhereClause()
                    
                    search.iOR(HsnTable.hsn, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.HsnSearch, Me.GetFromSession(Me.HsnSearch)), True, False)
        
                    search.iOR(HsnTable.gst_description, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(Me.HsnSearch, Me.GetFromSession(Me.HsnSearch)), True, False)
        
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
        
    
        Public Overridable Function CreateWhereClause(ByVal searchText as String, ByVal fromSearchControl as String, ByVal AutoTypeAheadSearch as String, ByVal AutoTypeAheadWordSeparators as String) As WhereClause
            ' This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            HsnTable.Instance.InnerFilter = Nothing
            Dim wc As WhereClause = New WhereClause()
        
            ' Compose the WHERE clause consiting of:
            ' 1. Static clause defined at design time.
            ' 2. User selected search criteria.
            ' 3. User selected filter criteria.
            
            Dim appRelativeVirtualPath As String = CType(HttpContext.Current.Session("AppRelativeVirtualPath"), String)
            
            ' Adds clauses if values are selected in Filter controls which are configured in the page.
          
            Dim gst_descriptionFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "gst_descriptionFilter_Ajax"), String)
            If IsValueSelected(gst_descriptionFilterSelectedValue) Then
              
                 wc.iAND(HsnTable.gst_description, BaseFilter.ComparisonOperator.EqualsTo, gst_descriptionFilterSelectedValue, false, False)
             
             End If
                      
            Dim gst_uomFilterSelectedValue As String = CType(HttpContext.Current.Session()(HttpContext.Current.Session.SessionID & appRelativeVirtualPath & "gst_uomFilter_Ajax"), String)
            If IsValueSelected(gst_uomFilterSelectedValue) Then
              
                 wc.iAND(HsnTable.gst_uom, BaseFilter.ComparisonOperator.EqualsTo, gst_uomFilterSelectedValue, false, False)
             
             End If
                      
            If IsValueSelected(searchText) and fromSearchControl = "HsnSearch" Then
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
                
                        search.iOR(HsnTable.hsn, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(HsnTable.hsn, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                        search.iOR(HsnTable.gst_description, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, True, False)
                        search.iOR(HsnTable.gst_description, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators & formatedSearchText, True, False)
                
                    Else
                        
                        search.iOR(HsnTable.hsn, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                        search.iOR(HsnTable.gst_description, BaseFilter.ComparisonOperator.Contains, formatedSearchText, True, False)
                    End If
                    wc.iAND(search)
                  
                End If
            End If
                  
            Return wc
        End Function
          
        Public Overridable Function GetAutoCompletionList_HsnSearch(ByVal prefixText As String, ByVal count As Integer) As String()
            Dim resultList As ArrayList = New ArrayList
            Dim wordList As ArrayList = New ArrayList
            Dim iteration As Integer = 0
            
            Dim wc As WhereClause = CreateWhereClause(prefixText,"HsnSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]")
            While (resultList.Count < count AndAlso iteration < 5)
                ' Fetch 100 records in each iteration
                Dim recordList () As ServelInvocing.Business.HsnRecord = HsnTable.GetRecords(wc, Nothing, iteration, 100)
                Dim rec As HsnRecord = Nothing
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
                
                    resultItem = rec.Format(HsnTable.hsn)
                    If resultItem IsNot Nothing AndAlso resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))  Then
      
                        Dim isAdded As Boolean = FormatSuggestions(prefixText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList)
                        If isAdded Then
                            Continue For
                        End If
                    End If
      
                    resultItem = rec.Format(HsnTable.gst_description)
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
        
            If Me.HsnPagination.PageSize.Text.Trim <> "" Then
                Try
                    'Me.PageSize = Integer.Parse(Me.HsnPagination.PageSize.Text)
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
                Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("HsnTableControlRepeater"), System.Web.UI.WebControls.Repeater)
                If rep Is Nothing Then Return

                Dim repItem As System.Web.UI.WebControls.RepeaterItem
                For Each repItem In rep.Items
                    ' Loop through all rows in the table, set its DataSource and call DataBind().
                    Dim recControl As HsnTableControlRow = DirectCast(repItem.FindControl("HsnTableControlRow"), HsnTableControlRow)

                    If recControl.Visible AndAlso recControl.IsNewRecord() Then
                    
                        Dim rec As HsnRecord = New HsnRecord()
        
                        If recControl.gst_description.Text <> "" Then
                            rec.Parse(recControl.gst_description.Text, HsnTable.gst_description)
                        End If
                        If recControl.gst_uom.Text <> "" Then
                            rec.Parse(recControl.gst_uom.Text, HsnTable.gst_uom)
                        End If
                        If recControl.hsn.Text <> "" Then
                            rec.Parse(recControl.hsn.Text, HsnTable.hsn)
                        End If
                        newUIDataList.Add(recControl.PreservedUIData())	  
                        newRecordList.Add(rec)
                    End If
                Next
            End If

            ' Add any new record to the list.
            Dim index As Integer = 0
            For index = 1 To Me.AddNewRecord
            
                newRecordList.Insert(0, New HsnRecord())
                newUIDataList.Insert(0, New Hashtable())				
              
            Next
            Me.AddNewRecord = 0

            ' Finally, add any new records to the DataSource.
            If newRecordList.Count > 0 Then
            
                Dim finalList As ArrayList = New ArrayList(Me.DataSource)
                finalList.InsertRange(0, newRecordList)

                Me.DataSource = DirectCast(finalList.ToArray(GetType(HsnRecord)), HsnRecord())
              
            End If
            
            ' Add the existing UI data to this hash table
            If newUIDataList.Count > 0 Then
                Me.UIData.InsertRange(0, newUIDataList)
            End If
            
        End Sub

        
        Public Sub AddToDeletedRecordIds(ByVal rec As HsnTableControlRow)
            If rec.IsNewRecord() Then
                Return
            End If

            If Not Me.DeletedRecordIds Is Nothing AndAlso Me.DeletedRecordIds.Trim <> "" Then
                Me.DeletedRecordIds &= ","
            End If

            Me.DeletedRecordIds &= "[" & rec.RecordUniqueId & "]"
        End Sub

        Protected Overridable Function InDeletedRecordIds(ByVal rec As HsnTableControlRow) As Boolean
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
        
        Public Overridable Sub Setgst_descriptionLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_descriptionLabel1()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_uomLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_uomLabel1()
            
                    
        End Sub
                
        Public Overridable Sub SethsnLabel()
            
                    
        End Sub
                
        Public Overridable Sub Setgst_descriptionFilter()
            
            If (Me.InSession(Me.gst_descriptionFilter))
                Me.Populategst_descriptionFilter(GetSelectedValue(Me.gst_descriptionFilter, Me.GetFromSession(Me.gst_descriptionFilter)), 500)
            Else
                
                Me.Populategst_descriptionFilter(GetSelectedValue(Me.gst_descriptionFilter,  Nothing), 500)					
                
            End If
                    
        End Sub	
            
        Public Overridable Sub Setgst_uomFilter()
            
            If (Me.InSession(Me.gst_uomFilter))
                Me.Populategst_uomFilter(GetSelectedValue(Me.gst_uomFilter, Me.GetFromSession(Me.gst_uomFilter)), 500)
            Else
                
                Me.Populategst_uomFilter(GetSelectedValue(Me.gst_uomFilter,  Nothing), 500)					
                
            End If
                    
        End Sub	
            
        Public Overridable Sub SetHsnSearch()
            
        End Sub	
            
        ' Get the filters' data for gst_descriptionFilter
        Protected Overridable Sub Populategst_descriptionFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
            Me.gst_descriptionFilter.Items.Clear()
            
            
            ' Setup the WHERE clause, including the base table if needed.
                
            Dim wc As WhereClause = Me.CreateWhereClause_gst_descriptionFilter()
                  
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(HsnTable.gst_description, OrderByItem.OrderDir.Asc)

            
            ' Add the All item.
            Me.gst_descriptionFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ServelInvocing"), "--ANY--"))
                            	


            Dim values() As String = HsnTable.GetValues(HsnTable.gst_description, wc, orderBy, maxItems)
            
            Dim itemValue As String
            
            For Each itemValue In values
                ' Create the item and add to the list.
                Dim fvalue As String
          
                If ( HsnTable.gst_description.IsColumnValueTypeBoolean()) Then
                    fvalue = itemValue
                Else
                    fvalue = HsnTable.gst_description.Format(itemValue)
                End If
                Dim item As ListItem = New ListItem(fvalue, itemValue)
          
                Me.gst_descriptionFilter.Items.Add(item)
            Next
                    

                
            ' Set the selected value.
            SetSelectedValue(Me.gst_descriptionFilter, selectedValue)

                
        End Sub
            
        ' Get the filters' data for gst_uomFilter
        Protected Overridable Sub Populategst_uomFilter(ByVal selectedValue As String, ByVal maxItems As Integer)
                    
                
            Me.gst_uomFilter.Items.Clear()
            
            
            ' Setup the WHERE clause, including the base table if needed.
                
            Dim wc As WhereClause = Me.CreateWhereClause_gst_uomFilter()
                  
            Dim orderBy As OrderBy = New OrderBy(False, True)
            orderBy.Add(HsnTable.gst_uom, OrderByItem.OrderDir.Asc)

            
            ' Add the All item.
            Me.gst_uomFilter.Items.Insert(0, new ListItem(Me.Page.GetResourceValue("Txt:All", "ServelInvocing"), "--ANY--"))
                            	


            Dim values() As String = HsnTable.GetValues(HsnTable.gst_uom, wc, orderBy, maxItems)
            
            Dim itemValue As String
            
            For Each itemValue In values
                ' Create the item and add to the list.
                Dim fvalue As String
          
                If ( HsnTable.gst_uom.IsColumnValueTypeBoolean()) Then
                    fvalue = itemValue
                Else
                    fvalue = HsnTable.gst_uom.Format(itemValue)
                End If
                Dim item As ListItem = New ListItem(fvalue, itemValue)
          
                Me.gst_uomFilter.Items.Add(item)
            Next
                    

                
            ' Set the selected value.
            SetSelectedValue(Me.gst_uomFilter, selectedValue)

                
        End Sub
            
        Public Overridable Function CreateWhereClause_gst_descriptionFilter() As WhereClause
        
            ' Create a where clause for the filter gst_descriptionFilter.
            ' This function is called by the Populate method to load the items 
            ' in the gst_descriptionFilterDropDownList
                   
            Dim wc As WhereClause = new WhereClause()
            ' Add additional where clauses to restrict the items shown in the control.
            ' Examples:
            ' wc.iAND(., BaseFilter.ComparisonOperator.EqualsTo, "XYZ")
            ' wc.iAND(.Active, BaseFilter.ComparisonOperator.EqualsTo, "1")
            Return wc
        
        End Function			
            
        Public Overridable Function CreateWhereClause_gst_uomFilter() As WhereClause
        
            ' Create a where clause for the filter gst_uomFilter.
            ' This function is called by the Populate method to load the items 
            ' in the gst_uomFilterDropDownList
                   
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
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("HsnTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing OrElse rep.Items.Count = 0 Then Return
            Dim repItem As System.Web.UI.WebControls.RepeaterItem
            For Each repItem In rep.Items  
			    'Load scripts to table rows
                Me.Page.LoadFocusScripts(repItem)
                Dim recControl As HsnTableControlRow = DirectCast(repItem.FindControl("HsnTableControlRow"), HsnTableControlRow)
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
        
            Me.SaveToSession(Me.gst_descriptionFilter, Me.gst_descriptionFilter.SelectedValue)
                  
            Me.SaveToSession(Me.gst_uomFilter, Me.gst_uomFilter.SelectedValue)
                  
            Me.SaveToSession(Me.HsnSearch, Me.HsnSearch.Text)
                  
            
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
          
      Me.SaveToSession("gst_descriptionFilter_Ajax", Me.gst_descriptionFilter.SelectedValue)
              
      Me.SaveToSession("gst_uomFilter_Ajax", Me.gst_uomFilter.SelectedValue)
              
      Me.SaveToSession("HsnSearch_Ajax", Me.HsnSearch.Text)
              
            HttpContext.Current.Session("AppRelativeVirtualPath") = Me.Page.AppRelativeVirtualPath
         
        End Sub
        
        Protected Overrides Sub ClearControlsFromSession()
            MyBase.ClearControlsFromSession()

            ' Clear filter controls values from the session.
        
            Me.RemoveFromSession(Me.gst_descriptionFilter)
            Me.RemoveFromSession(Me.gst_uomFilter)
            Me.RemoveFromSession(Me.HsnSearch)
            
            ' Clear table properties from the session.
            Me.RemoveFromSession(Me, "Order_By")
            Me.RemoveFromSession(Me, "Page_Index")
            Me.RemoveFromSession(Me, "Page_Size")
            
            Me.RemoveFromSession(Me, "DeletedRecordIds")  
            
        End Sub

        Protected Overrides Sub LoadViewState(ByVal savedState As Object)
            MyBase.LoadViewState(savedState)

            Dim orderByStr As String = CType(ViewState("HsnTableControl_OrderBy"), String)
            
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
                Me.ViewState("HsnTableControl_OrderBy") = Me.CurrentSortOrder.ToXmlString()
            End If
                      
            Me.ViewState("Page_Index") = Me.PageIndex
            Me.ViewState("Page_Size") = Me.PageSize
        
            Me.ViewState("DeletedRecordIds") = Me.DeletedRecordIds
        
            Return MyBase.SaveViewState()
        End Function

        ' Generate the event handling functions for pagination events.
        
        ' event handler for ImageButton
        Public Overridable Sub HsnPagination_FirstPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub HsnPagination_LastPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub HsnPagination_NextPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub HsnPagination_PageSizeButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                
            Me.DataChanged = True
      
            Me.PageSize = Integer.Parse(Me.HsnPagination.PageSize.Text)
      
            Me.PageIndex = Integer.Parse(Me.HsnPagination.CurrentPage.Text) - 1
          
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
    
        End Sub
            
        ' event handler for ImageButton
        Public Overridable Sub HsnPagination_PreviousPage_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        
        Public Overridable Sub gst_descriptionLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_description when clicked.
              
            ' Get previous sorting state for gst_description.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(HsnTable.gst_description)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_description.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(HsnTable.gst_description, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by gst_description, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            
        Public Overridable Sub gst_uomLabel1_Click(ByVal sender As Object, ByVal args As EventArgs)
            ' Sorts by gst_uom when clicked.
              
            ' Get previous sorting state for gst_uom.
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(HsnTable.gst_uom)
            If sd Is Nothing Then
                ' First time sort, so add sort order for gst_uom.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(HsnTable.gst_uom, OrderByItem.OrderDir.Asc)
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
            
            Dim sd As OrderByItem = Me.CurrentSortOrder.Find(HsnTable.hsn)
            If sd Is Nothing Then
                ' First time sort, so add sort order for hsn.
                Me.CurrentSortOrder.Reset()
                Me.CurrentSortOrder.Add(HsnTable.hsn, OrderByItem.OrderDir.Asc)
            Else
                ' Previously sorted by hsn, so just reverse.
                sd.Reverse()
            End If
            
            ' Setting the DataChanged to True results in the page being refreshed with
            ' the most recent data from the database.  This happens in PreRender event
            ' based on the current sort, search and filter criteria.
            Me.DataChanged = True
              
        End Sub
            

        ' Generate the event handling functions for button events.
        
        ' event handler for ImageButton
        Public Overridable Sub HsnAddButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub HsnDeleteButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
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
        Public Overridable Sub HsnEditButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            ' The redirect URL is set on the Properties, Bindings.
            ' The ModifyRedirectURL call resolves the parameters before the
            ' Response.Redirect redirects the page to the URL.  
            ' Any code after the Response.Redirect call will not be executed, since the page is
            ' redirected to the URL.
            Dim url As String = "../Shared/ConfigureEditRecord.aspx"
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
        Public Overridable Sub HsnRefreshButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
            Dim HsnTableControlObj as HsnTableControl = DirectCast(Me.Page.FindControlRecursively("HsnTableControl"), HsnTableControl)
            HsnTableControlObj.ResetData = True
                        
            HsnTableControlObj.RemoveFromSession(HsnTableControlObj, "DeletedRecordIds")
            HsnTableControlObj.DeletedRecordIds = Nothing
            
            Catch ex As Exception
                Me.Page.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
                  
        End Sub
        
        ' event handler for ImageButton
        Public Overridable Sub HsnResetButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                
              Me.gst_descriptionFilter.ClearSelection()
              Me.gst_uomFilter.ClearSelection()
              Me.HsnSearch.Text = ""
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
        Public Overridable Sub HsnSaveButton_Click(ByVal sender As Object, ByVal args As ImageClickEventArgs)
        
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
        
              If (Not Me.Page.IsPageRefresh) Then         
                  Me.SaveData()
              End If        
        
            Me.Page.CommitTransaction(sender)
          
          ' Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
          Dim recCtl As HsnTableControlRow
          For Each recCtl in Me.GetRecordControls()
            
            recCtl.IsNewRecord = False
          Next
    
      
          ' Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
          
                Me.DeletedRecordIds = Nothing
            
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
        Public Overridable Sub HsnSearchButton_Click(ByVal sender As Object, ByVal args As EventArgs)
              
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
        Protected Overridable Sub gst_descriptionFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
           ' Setting the DataChanged to True results in the page being refreshed with
           ' the most recent data from the database.  This happens in PreRender event
           ' based on the current sort, search and filter criteria.
           Me.DataChanged = True
           
          	   
        End Sub
            
        ' event handler for FieldFilter
        Protected Overridable Sub gst_uomFilter_SelectedIndexChanged(ByVal sender As Object, ByVal args As EventArgs)
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
        
        Private _DataSource() As HsnRecord = Nothing
        Public Property DataSource() As HsnRecord ()
            Get
                Return Me._DataSource
            End Get
            Set(ByVal value() As HsnRecord)
                Me._DataSource = value
            End Set
        End Property
       
#Region "Helper Properties"
        
        Public ReadOnly Property gst_descriptionFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_descriptionFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property gst_descriptionLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_descriptionLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property gst_descriptionLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_descriptionLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property gst_uomFilter() As System.Web.UI.WebControls.DropDownList
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_uomFilter"), System.Web.UI.WebControls.DropDownList)
            End Get
        End Property
        
        Public ReadOnly Property gst_uomLabel() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_uomLabel"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property gst_uomLabel1() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "gst_uomLabel1"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnAddButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnAddButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnDeleteButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnDeleteButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnEditButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnEditButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property hsnLabel() As System.Web.UI.WebControls.LinkButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "hsnLabel"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnPagination() As ServelInvocing.UI.IPagination
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnPagination"), ServelInvocing.UI.IPagination)
          End Get
          End Property
        
        Public ReadOnly Property HsnRefreshButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnRefreshButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnResetButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnResetButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnSaveButton() As System.Web.UI.WebControls.ImageButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnSaveButton"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
        
        Public ReadOnly Property HsnSearch() As System.Web.UI.WebControls.TextBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnSearch"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
        
        Public ReadOnly Property HsnSearchButton() As ServelInvocing.UI.IThemeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnSearchButton"), ServelInvocing.UI.IThemeButton)
          End Get
          End Property
        
        Public ReadOnly Property HsnTitle() As System.Web.UI.WebControls.Literal
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnTitle"), System.Web.UI.WebControls.Literal)
            End Get
        End Property
        
        Public ReadOnly Property HsnToggleAll() As System.Web.UI.WebControls.CheckBox
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "HsnToggleAll"), System.Web.UI.WebControls.CheckBox)
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
                Dim recCtl As HsnTableControlRow = Me.GetSelectedRecordControl()
                If recCtl Is Nothing AndAlso url.IndexOf("{") >= 0 Then
                    ' Localization.
                    Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
                End If
                Dim rec As HsnRecord = Nothing     
                If recCtl IsNot Nothing Then
                    rec = recCtl.GetRecord()
                End If
                Return EvaluateExpressions(url, arg, rec, bEncrypt)
            End If
            Return url
        End Function
          
        Public Overridable Function GetSelectedRecordIndex() As Integer
            Dim counter As Integer = 0
            Dim recControl As HsnTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.HsnRecordRowSelection.Checked Then
                    Return counter
                End If
                counter += 1
            Next
            Return -1
        End Function
        
        Public Overridable Function GetSelectedRecordControl() As HsnTableControlRow
            Dim selectedList() As HsnTableControlRow = Me.GetSelectedRecordControls()
            If selectedList.Length = 0 Then
                Return Nothing
            End If
            Return selectedList(0)
          
        End Function

        Public Overridable Function GetSelectedRecordControls() As HsnTableControlRow()
        
            Dim selectedList As ArrayList = New ArrayList(25)
            Dim recControl As HsnTableControlRow
            For Each recControl In Me.GetRecordControls()
                If recControl.HsnRecordRowSelection.Checked Then
                    selectedList.Add(recControl)
                End If
            Next
            Return DirectCast(selectedList.ToArray(GetType(HsnTableControlRow)), HsnTableControlRow())
          
        End Function

        Public Overridable Sub DeleteSelectedRecords(ByVal deferDeletion As Boolean)
            Dim recList() As HsnTableControlRow = Me.GetSelectedRecordControls()
            If recList.Length = 0 Then
                ' Localization.
                Throw New Exception(Page.GetResourceValue("Err:NoRecSelected", "ServelInvocing"))
            End If
            
            Dim recCtl As HsnTableControlRow
            For Each recCtl In recList
                If deferDeletion Then
                    If Not recCtl.IsNewRecord Then
                
                        Me.AddToDeletedRecordIds(recCtl)
                  
                    End If
                    recCtl.Visible = False
                
                    recCtl.HsnRecordRowSelection.Checked = False
                
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

        Public Function GetRecordControls() As HsnTableControlRow()
            Dim recList As ArrayList = New ArrayList()
            Dim rep As System.Web.UI.WebControls.Repeater = CType(Me.FindControl("HsnTableControlRepeater"), System.Web.UI.WebControls.Repeater)
            If rep Is Nothing Then Return Nothing
            Dim repItem As System.Web.UI.WebControls.RepeaterItem

            For Each repItem In rep.Items
                Dim recControl As HsnTableControlRow = DirectCast(repItem.FindControl("HsnTableControlRow"), HsnTableControlRow)
                recList.Add(recControl)
            Next

            Return DirectCast(recList.ToArray(GetType(HsnTableControlRow)), HsnTableControlRow())
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

  