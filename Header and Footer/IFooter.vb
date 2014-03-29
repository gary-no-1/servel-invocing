
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ServelInvocing.UI

  

    Public Interface IFooter

#Region "Interface Properties"
        
        ReadOnly Property Copyright() As System.Web.UI.WebControls.Literal
        ReadOnly Property Literal() As System.Web.UI.WebControls.Literal
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  