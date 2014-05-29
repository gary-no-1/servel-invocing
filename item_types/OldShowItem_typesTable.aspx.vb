
' This file implements the code-behind class for OldShowItem_typesTable.aspx.
' OldShowItem_typesTable.Controls.vb contains the Table, Row and Record control classes
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
  
Partial Public Class OldShowItem_typesTable
        Inherits BaseApplicationPage
' Code-behind class for the OldShowItem_typesTable page.
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
    
      <Services.WebMethod()> _
      Public Shared Function GetAutoCompletionList_Item_typesSearch(ByVal prefixText As String, ByVal count As Integer) As String()
      ' GetItem_typesSearchCompletionList gets the list of suggestions from the database.
      ' prefixText is the search text typed by the user .
      ' count specifies the number of suggestions to be returned.
      ' Customize by adding code before or after the call to  GetAutoCompletionList_Item_typesSearch()
      ' or replace the call to GetAutoCompletionList_Item_typesSearch().
      Return GetAutoCompletionList_Item_typesSearch_Base(prefixText, count)
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
    

    
#End Region

#Region "Section 2: Do not modify this section."

        Public WithEvents item_typeLabel As System.Web.UI.WebControls.Literal
        Public WithEvents item_typeLabel1 As System.Web.UI.WebControls.LinkButton
        Public WithEvents Item_typesCopyButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesDeleteButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesEditButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesExportCSVButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesExportExcelButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesImportButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesNewButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesPagination As Pagination
        Public WithEvents Item_typesPDFButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesRefreshButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesResetButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents Item_typesSearch As System.Web.UI.WebControls.TextBox
        Public WithEvents Item_typesSearchButton As ThemeButton
        Public WithEvents Item_typesTableControl As ServelInvocing.UI.Controls.OldShowItem_typesTable.Item_typesTableControl
        Public WithEvents Item_typesTitle As System.Web.UI.WebControls.Literal
        Public WithEvents Item_typesToggleAll As System.Web.UI.WebControls.CheckBox
        Public WithEvents Item_typesWordButton As System.Web.UI.WebControls.ImageButton
        Public WithEvents PageTitle As System.Web.UI.WebControls.Literal
        Public WithEvents ValidationSummary1 As ValidationSummary
    
  
        Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. Registers event handler for any button, sort or links.
            ' You can add additional Init handlers in Section 1.			
	         
			' This page does not have FileInput  control inside repeater which requires "multipart/form-data" form encoding, but it might
			'include ascx controls which in turn do have FileInput controls inside repeater. So check if they set Enctype property.
			If Not String.IsNullOrEmpty(Me.Enctype) Then Me.Page.Form.Enctype = Me.Enctype
					
            ' Register the Event handler for any Events.
      
      
        End Sub

        Private Sub Base_RegisterPostback()
        
        End Sub

        ' Handles MyBase.Load.  Read database data and put into the UI controls.
        ' If you need to, you can add additional Load handlers in Section 1.
        Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
			Me.SetPageFocus()
		
            ' Check if user has access to this page.  Redirects to either sign-in page
            ' or 'no access' page if not. Does not do anything if role-based security
            ' is not turned on, but you can override to add your own security.
            Me.Authorize("NOT_ANONYMOUS")
    
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
        
        
            Page.Title = "Item Types"
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
              
        Me.Item_typesTableControl.SaveData()
        
      End Sub
      
        
      Public Sub PreInit_Base()
      'If it is SharePoint application this function performs dynamic Master Page assignment.
      'If application uses multi-color theme this function performs dynamic theme assignment.
      
      End Sub
      
        Public Shared Function GetAutoCompletionList_Item_typesSearch_Base(ByVal prefixText As String, ByVal count As Integer) As String()
            ' Since this method is a shared/static method it does not maintain information about page or controls within the page.
            ' Hence we can not invoke any method associated with any controls.
            ' So, if we need to use any control in the page we need to instantiate it.
            Dim control as ServelInvocing.UI.Controls.OldShowItem_typesTable.Item_typesTableControl 
            control = new ServelInvocing.UI.Controls.OldShowItem_typesTable.Item_typesTableControl()
            
            Return control.GetAutoCompletionList_Item_typesSearch(prefixText, count)
              
        End Function
          
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
                        
        Me.Item_typesTableControl.LoadData()
        
      
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
            
    
#End Region

  
End Class
  
End Namespace
  