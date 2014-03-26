
' This file implements the code-behind class for AddItems.aspx.
' AddItems.Controls.vb contains the Table, Row and Record control classes
' for the page.  Best practices calls for overriding methods in the Row or Record control classes.

#Region "Imports statements"

Option Strict On
Imports System
Imports System.Data
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
        
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider
Imports BaseClasses.Data.OrderByItem.OrderDir
Imports BaseClasses.Data.BaseFilter
Imports BaseClasses.Data.BaseFilter.ComparisonOperator
Imports BaseClasses.Web.UI.WebControls
        
Imports ServelInvocing.Business
Imports ServelInvocing.Data
        

#End Region

  
Namespace ServelInvocing.UI
  
Partial Public Class AddItems
        Inherits BaseApplicationPage
' Code-behind class for the AddItems page.
' Place your customizations in Section 1. Do not modify Section 2.
        
#Region "Section 1: Place your customizations here."
	  
      Public Sub SetPageFocus()
		  'load scripts to all controls on page so that they will retain focus on PostBack
		  Me.LoadFocusScripts(Me.Page)	  
          'To set focus on page load to a specific control pass this control to the SetStartupFocus method. To get a hold of  a control
          'use FindControlRecursively method. For example:
          'Dim controlToFocus As System.Web.UI.WebControls.TextBox = DirectCast(Me.FindControlRecursively("ProductsSearch"), System.Web.UI.WebControls.TextBox)
          'Me.SetFocusOnLoad(controlToFocus)
          'If no control is passed or control does not exist this method will set focus on the first focusable control on the page.
          Me.SetFocusOnLoad()  
      End Sub
       
      Public Sub LoadData()
          ' LoadData reads database data and assigns it to UI controls.
          ' Customize by adding code before or after the call to LoadData_Base()
          ' or replace the call to LoadData_Base().
          LoadData_Base()
                  
      End Sub
      
      Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord) As String
          Return EvaluateFormula_Base(formula, dataSourceForEvaluate)
      End Function
      
      
      Public Overrides Sub SaveData()
          Me.SaveData_Base()
      End Sub
               
    
      Public Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
          'Override call to PreInit_Base() here to change top level master page used by this page, for example uncomment
          'next line to use Microsoft SharePoint default master page
          'If Not Me.Master Is Nothing Then Me.Master.MasterPageFile = Microsoft.SharePoint.SPContext.Current.Web.MasterUrl	
          'You may change here assignment of application theme
		  Try
              Me.PreInit_Base()
          Catch ex As Exception
              Try
                  'when running application in Live preview or outside of Microsoft SharePoint environment use proforma top level master.
                  Me.Master.MasterPageFile = "../Master Pages/SharePointMaster.master"
              Catch ex1 As Exception
              End Try
          End Try			  
      End Sub
      
#Region "Ajax Functions"

        <Services.WebMethod()> _
        Public Shared Function GetRecordFieldValue(ByVal tableName As String, _
                                                  ByVal recordID As String, _
                                                  ByVal columnName As String, _
                                                  ByVal fieldName As String, _
                                                  ByVal title As String, _
                                                  ByVal persist As Boolean, _
                                                  ByVal popupWindowHeight As Integer, _
                                                  ByVal popupWindowWidth As Integer, _
                                                  ByVal popupWindowScrollBar As Boolean _
                                                  ) As Object()
            ' GetRecordFieldValue gets the pop up window content from the column specified by
            ' columnName in the record specified by the recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetRecordFieldValue_Base()
            ' or replace the call to  GetRecordFieldValue_Base().
            Return GetRecordFieldValue_Base(tableName, recordID, columnName, fieldName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function

        <Services.WebMethod()> _
        Public Shared Function GetImage(ByVal tableName As String, _
                                        ByVal recordID As String, _
                                        ByVal columnName As String, _
                                        ByVal title As String, _
                                        ByVal persist As Boolean, _
                                        ByVal popupWindowHeight As Integer, _
                                        ByVal popupWindowWidth As Integer, _
                                        ByVal popupWindowScrollBar As Boolean _
                                        ) As Object()
            ' GetImage gets the Image url for the image in the column "columnName" and
            ' in the record specified by recordID in data base table specified by tableName.
            ' Customize by adding code before or after the call to  GetImage_Base()
            ' or replace the call to  GetImage_Base().
            Return GetImage_Base(tableName, recordID, columnName, title, persist, popupWindowHeight, popupWindowWidth, popupWindowScrollBar)
        End Function
    
      Protected Overloads Overrides Sub BasePage_PreRender(ByVal sender As Object, ByVal e As EventArgs)
          MyBase.BasePage_PreRender(sender, e)
          RegisterPostback()
      End Sub
      
      Protected Sub RegisterPostback()
          Base_RegisterPostback()
      End Sub
    
      


#End Region

    ' Page Event Handlers - buttons, sort, links
    
        Public Sub CancelButton_Click(ByVal sender As Object, ByVal args As EventArgs)
            
          ' Click handler for CancelButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          CancelButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
        
        Public Sub SaveAndNewButton_Click(ByVal sender As Object, ByVal args As EventArgs)
            
          ' Click handler for SaveAndNewButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          SaveAndNewButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
        
        Public Sub SaveButton_Click(ByVal sender As Object, ByVal args As EventArgs)
            
          ' Click handler for SaveButton.
          ' Customize by adding code before the call or replace the call to the Base function with your own code.
          SaveButton_Click_Base(sender, args)
          ' NOTE: If the Base function redirects to another page, any code here will not be executed.
        End Sub
        

    
#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents CancelButton As ThemeButton
        Public WithEvents closing_stockLabel As System.Web.UI.WebControls.Literal
        Public WithEvents id_item_group As System.Web.UI.WebControls.DropDownList
        Public WithEvents id_item_groupAddRecordLink As System.Web.UI.WebControls.ImageButton
        Public WithEvents id_item_groupLabel As System.Web.UI.WebControls.Literal
        Public WithEvents item_codeLabel As System.Web.UI.WebControls.Literal
        Public WithEvents item_descriptionLabel As System.Web.UI.WebControls.Literal
        Public WithEvents item_type As System.Web.UI.WebControls.DropDownList
        Public WithEvents item_typeLabel As System.Web.UI.WebControls.Literal
        Public WithEvents ItemsRecordControl As ServelInvocing.UI.Controls.AddItems.ItemsRecordControl
        Public WithEvents ItemsTitle As System.Web.UI.WebControls.Literal
        Public WithEvents material_categoryLabel As System.Web.UI.WebControls.Literal
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents SaveAndNewButton As ThemeButton
        Public WithEvents SaveButton As ThemeButton
        Public WithEvents specificationLabel As System.Web.UI.WebControls.Literal
        Public WithEvents tariff_noLabel As System.Web.UI.WebControls.Literal
        Public WithEvents uom As System.Web.UI.WebControls.DropDownList
        Public WithEvents uomAddRecordLink As System.Web.UI.WebControls.ImageButton
        Public WithEvents uomLabel As System.Web.UI.WebControls.Literal
        Public WithEvents ValidationSummary1 As ValidationSummary
    
  
        Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. Registers event handler for any button, sort or links.
            ' You can add additional Init handlers in Section 1.			
	         
			' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
			'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
			If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
					
            ' Register the Event handler for any Events.
      
            AddHandler Me.CancelButton.Button.Click, AddressOf CancelButton_Click
        
            AddHandler Me.SaveAndNewButton.Button.Click, AddressOf SaveAndNewButton_Click
        
            Me.SaveAndNewButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.GetResourceValue("Txt:SaveRecord", "ServelInvocing") & """);")
        
            AddHandler Me.SaveButton.Button.Click, AddressOf SaveButton_Click
        
            Me.SaveButton.Button.Attributes.Add("onclick", "SubmitHRefOnce(this, """ & Me.GetResourceValue("Txt:SaveRecord", "ServelInvocing") & """);")
        
      
        End Sub

        Private Sub Base_RegisterPostback()
        
              Me.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SaveAndNewButton"))
                        
              Me.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(Me,"SaveButton"))
                        
        End Sub

        ' Handles MyBase.Load.  Read database data and put into the UI controls.
        ' If you need to, you can add additional Load handlers in Section 1.
        Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			Me.SetPageFocus()
		
            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("")
    
            If (Not Me.IsPostBack) Then
            
                ' Setup the header text for the validation summary control.
                Me.ValidationSummary1.HeaderText = GetResourceValue("ValidationSummaryHeaderText", "ServelInvocing")
              
            End If
            
            'set value of the hidden control depending on the postback. It will be used by SetFocus script on the client side.	
            Dim clientSideIsPostBack As System.Web.UI.HtmlControls.HtmlInputHidden = DirectCast(Me.FindControlRecursively("_clientSideIsPostBack"), System.Web.UI.HtmlControls.HtmlInputHidden)
            If Not clientSideIsPostBack Is Nothing Then
                If Me.IsPostBack AndAlso Not Me.Request("__EVENTTARGET") = "ChildWindowPostBack" Then
                    clientSideIsPostBack.Value = "Y"
                Else
                    clientSideIsPostBack.Value = "N"
                End If
            End If

            ' Load data only when displaying the page for the first time or if postback from child window
            If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then
                ' Read the data for all controls on the page.
                ' To change the behavior, override the DataBind method for the individual
                ' record or table UI controls.
                Me.LoadData()
            End If
        
        
            Page.Title = GetResourceValue("Title:Add") + " Items"
        End Sub

    Public Shared Function GetRecordFieldValue_Base(ByVal tableName As String, _
                                                ByVal recordID As String, _
                                                ByVal columnName As String, _
                                                ByVal fieldName As String, _
                                                ByVal title As String, _
                                                ByVal persist As Boolean, _
                                                ByVal popupWindowHeight As Integer, _
                                                ByVal popupWindowWidth As Integer, _
                                                ByVal popupWindowScrollBar As Boolean _
                                                ) As Object()
        If Not IsNothing(recordID) Then
            recordID = System.Web.HttpUtility.UrlDecode(recordID)
        End If
        Dim content as String = BaseClasses.Utils.MiscUtils.GetFieldData(tableName, recordID, columnName)
    
        content = NetUtils.EncodeStringForHtmlDisplay(content)

        'returnValue is an array of string values.
        'returnValue(0) represents title of the pop up window
        'returnValue(1) represents content of the pop up window
        ' retrunValue(2) represents whether pop up window should be made persistant
        ' or it should closes as soon as mouse moved out.
        ' returnValue(5) represents whether pop up window should contain scroll bar.
        ' returnValue(3), (4) represents pop up window height and width respectivly
        ' (0),(2),(3),(4) and (5)  is initially set as pass through attribute.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(6) As Object
        returnValue(0) = title
        returnValue(1) = content
        returnValue(2) = persist
        returnValue(3) = popupWindowWidth
        returnValue(4) = popupWindowHeight
        returnValue(5) = popupWindowScrollBar
        Return returnValue
    End Function


    Public Shared Function GetImage_Base(ByVal tableName As String, _
                                    ByVal recordID As String, _
                                    ByVal columnName As String, _
                                    ByVal title As String, _
                                    ByVal persist As Boolean, _
                                    ByVal popupWindowHeight As Integer, _
                                    ByVal popupWindowWidth As Integer, _
                                    ByVal popupWindowScrollBar As Boolean _
                                    ) As Object()
        Dim content As String = "<IMG src =" & """../Shared/ExportFieldValue.aspx?Table=" & tableName & "&Field=" & columnName & "&Record=" & recordID & """/>"
        'returnValue is an array of string values.
        'returnValue(0) represents title of the pop up window.
        'returnValue(1) represents content ie, image url.
        ' retrunValue(2) represents whether pop up window should be made persistant
        ' or it should closes as soon as mouse moved out.
        ' returnValue(3), (4) represents pop up window height and width respectivly
        ' returnValue(5) represents whether pop up window should contain scroll bar.
        ' (0),(2),(3),(4) and (5) is initially set as pass through attribute.
        ' They can be modified by going to Attribute tab of the properties window of the control in aspx page.
        Dim returnValue(6) As Object
        returnValue(0) = title
        returnValue(1) = content
        returnValue(2) = persist
        returnValue(3) = popupWindowWidth
        returnValue(4) = popupWindowHeight
        returnValue(5) = popupWindowScrollBar
        Return returnValue
    End Function
        
        
    
      
      Public Sub SaveData_Base()
              
        Me.ItemsRecordControl.SaveData()
        
      End Sub
      
        
      Public Sub PreInit_Base()
      'If it is SharePoint application this function performs dynamic Master Page assignment.
      'If application uses multi-color theme this function performs dynamic theme assignment.
      
      End Sub
      
        ' Load data from database into UI controls.
        ' Modify LoadData in Section 1 above to customize.  Or override DataBind() in
        ' the individual table and record controls to customize.
        Public Sub LoadData_Base()
            Try
              
                If Not Me.IsPostBack Then
                    ' Must start a transaction before performing database operations
                    DbUtils.StartTransaction()
                End If
      

                ' Load data for each record and table UI control.
                ' Ordering is important because child controls get
                ' their parent ids from their parent UI controls.
                        
        Me.ItemsRecordControl.LoadData()
        
      
                Me.DataBind()
            
                
                

            Catch ex As Exception
                ' An error has occured so display an error message.
                Utils.RegisterJScriptAlert(Me, "Page_Load_Error_Message", ex.Message)
            Finally
                If Not Me.IsPostBack Then
                    ' End database transaction
                      DbUtils.EndTransaction()
                End If
            End Try
        End Sub
        
        Private Function EvaluateFormula_Base(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord) As String
            Dim e As FormulaEvaluator = New FormulaEvaluator()

            ' All variables referred to in the formula are expected to be
            ' properties of the DataSource.  For example, referring to
            ' UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate

            Dim resultObj As Object = e.Evaluate(formula)
            If resultObj Is Nothing Then
                Return ""
            End If
            
            Return resultObj.ToString()
        End Function			
        

        ' Write out event methods for the page events
        
        ' event handler for Button with Layout
        Public Sub CancelButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                

                TargetKey = Me.Page.Request.QueryString.Item("Target")
                If Not TargetKey Is Nothing Then
                   shouldRedirect = False
                End If
      
            Catch ex As Exception
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
    
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.RedirectBack()
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
            
        ' event handler for Button with Layout
        Public Sub SaveAndNewButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
        
              If (Not Me.IsPageRefresh) Then         
                  Me.SaveData()
              End If        
        
            Me.CommitTransaction(sender)
          
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.RollBackTransaction(sender)
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
    
        End Sub
            
        ' event handler for Button with Layout
        Public Sub SaveButton_Click_Base(ByVal sender As Object, ByVal args As EventArgs)
              
            Dim shouldRedirect As Boolean = True
            Dim TargetKey As String = Nothing
            Dim DFKA As String = Nothing
            Dim id As String = Nothing
            Dim value As String = Nothing
            Try
                ' Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction
                
        
              If (Not Me.IsPageRefresh) Then         
                  Me.SaveData()
              End If        
        
            Me.CommitTransaction(sender)
          
            TargetKey = Me.Page.Request.QueryString.Item("Target")

            If Not TargetKey Is Nothing Then
                  
                DFKA = Me.Page.Request.QueryString.Item("DFKA")
                If Not Me.ItemsRecordControl Is Nothing AndAlso Not Me.ItemsRecordControl.DataSource Is Nothing Then
                      
                      id = Me.ItemsRecordControl.DataSource.id0.ToString
                      value = Me.ItemsRecordControl.DataSource.GetValue(Me.ItemsRecordControl.DataSource.TableAccess.TableDefinition.ColumnList.GetByAnyName(DFKA)).ToString
                      If value is Nothing Then
                            value = id
                      End If
                      
                      Dim Formula As String = Me.Page.Request.QueryString.Item("Formula")							
                      If Not Formula Is Nothing Then
                            value = EvaluateFormula(Formula, Me.ItemsRecordControl.DataSource)
                      End If

                      BaseClasses.Utils.MiscUtils.RegisterAddButtonScript(Me, TargetKey, id, value)
                End If
                shouldRedirect = False
                        
            End If
        
            Catch ex As Exception
                ' Upon error, rollback the transaction
                Me.RollBackTransaction(sender)
                shouldRedirect = False
                Me.ErrorOnPage = True
    
                ' Report the error message to the end user
                Utils.MiscUtils.RegisterJScriptAlert(Me, "BUTTON_CLICK_MESSAGE", ex.Message)
            Finally
                DbUtils.EndTransaction
            End Try
            If shouldRedirect Then
                Me.ShouldSaveControlsToSession = True
                Me.RedirectBack()
            ElseIf Not TargetKey Is Nothing AndAlso _
                        Not shouldRedirect Then
            Me.ShouldSaveControlsToSession = True
            Me.CloseWindow(True)
        
            End If
        End Sub
                
    
#End Region

  
End Class
  
End Namespace
  