
Option Strict On
Imports System
Imports System.Web.UI.WebControls
Imports System.ComponentModel
Imports BaseClasses
Imports BaseClasses.Utils
Imports BaseClasses.Web.UI.WebControls
        
Imports ServelInvocing.Business
Imports ServelInvocing.Data
        
Namespace ServelInvocing.UI

  ' Code-behind class for the Pagination user control.
Partial Public Class Pagination
        Inherits BaseApplicationUserControl
        Implements IPagination
#Region "Section 1: Place your customizations here."
	   
      Public Sub LoadData()
          ' LoadData reads database data and assigns it to UI controls.
          ' Customize by adding code before or after the call to LoadData_Base()
          ' or replace the call to LoadData_Base().
          LoadData_Base()
                  
      End Sub
      
      Private Function EvaluateFormula(ByVal formula As String, ByVal dataSourceForEvaluate as BaseClasses.Data.BaseRecord) As String
          Return EvaluateFormula_Base(formula, dataSourceForEvaluate)
      End Function
      
      
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
    
      


#End Region

    ' Page Event Handlers - buttons, sort, links
    

    
#End Region

#Region "Section 2: Do not modify this section."

        Protected Overridable Sub Page_InitializeEventHandlers(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Init
            ' Handles MyBase.Init. Registers event handler for any button, sort or links.
            ' You can add additional Init handlers in Section 1.			
	         
            ' Register the Event handler for any Events.
      
      
        End Sub

        Private Sub Base_RegisterPostback()
        
        End Sub

        ' Handles MyBase.Load.  Read database data and put into the UI controls.
        ' If you need to, you can add additional Load handlers in Section 1.
        Protected Overridable Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		
    
            If (Not Me.IsPostBack) Then
            
            End If
            

            ' Load data only when displaying the page for the first time or if postback from child window
            If (Not Me.IsPostBack OrElse Me.Request("__EVENTTARGET") = "ChildWindowPostBack") Then
                ' Read the data for all controls on the page.
                ' To change the behavior, override the DataBind method for the individual
                ' record or table UI controls.
                Me.LoadData()
            End If
        
        
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
        
        #Region "Interface Properties"
        
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property CurrentPage() As System.Web.UI.WebControls.TextBox Implements IPagination.CurrentPage
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_CurrentPage"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property FirstPage() As System.Web.UI.WebControls.ImageButton Implements IPagination.FirstPage
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_FirstPage"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property LastPage() As System.Web.UI.WebControls.ImageButton Implements IPagination.LastPage
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_LastPage"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property NextPage() As System.Web.UI.WebControls.ImageButton Implements IPagination.NextPage
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_NextPage"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property PageSize() As System.Web.UI.WebControls.TextBox Implements IPagination.PageSize
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_PageSize"), System.Web.UI.WebControls.TextBox)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property PageSizeButton() As System.Web.UI.WebControls.LinkButton Implements IPagination.PageSizeButton
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_PageSizeButton"), System.Web.UI.WebControls.LinkButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property PreviousPage() As System.Web.UI.WebControls.ImageButton Implements IPagination.PreviousPage
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_PreviousPage"), System.Web.UI.WebControls.ImageButton)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property TotalItems() As System.Web.UI.WebControls.Label Implements IPagination.TotalItems
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_TotalItems"), System.Web.UI.WebControls.Label)
            End Get
        End Property
                
        <Bindable(True), _
        Category("Behavior"), _
        DefaultValue(""), _
        NotifyParentProperty(True), _
        DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property TotalPages() As System.Web.UI.WebControls.Label Implements IPagination.TotalPages
            Get
                Return CType(BaseClasses.Utils.MiscUtils.FindControlRecursively(Me, "_TotalPages"), System.Web.UI.WebControls.Label)
            End Get
        End Property
                
      Public Overrides Property Visible() As Boolean Implements IPagination.Visible
  
          Get
              Return MyBase.Visible
          End Get
          Set(ByVal value As Boolean)
              MyBase.Visible = value
          End Set
      End Property
            
        #End Region
  
        Public Shadows ReadOnly Property Page() As BaseApplicationPage
            Get
                Return DirectCast(MyBase.Page, BaseApplicationPage)
            End Get
        End Property

            
    
#End Region

  

End Class
  
End Namespace

  