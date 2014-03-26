
Imports Microsoft.VisualBasic
Imports BaseClasses.Utils.DbUtils
  
Namespace ServelInvocing.UI

  

    Public Interface IHeader

#Region "Interface Properties"
        
        ReadOnly Property Divider0() As System.Web.UI.WebControls.Image
        ReadOnly Property Divider1() As System.Web.UI.WebControls.Image
        ReadOnly Property Divider2() As System.Web.UI.WebControls.Image
        ReadOnly Property LanguageSelector() As System.Web.UI.WebControls.DropDownList
        ReadOnly Property LeftImage() As System.Web.UI.WebControls.Image
        ReadOnly Property Logo() As System.Web.UI.WebControls.Image
        ReadOnly Property RightImage() As System.Web.UI.WebControls.Image
        ReadOnly Property SignIn() As System.Web.UI.WebControls.LinkButton
        ReadOnly Property SignInBarPrintButton() As System.Web.UI.WebControls.Image
        ReadOnly Property SIOImage() As System.Web.UI.WebControls.ImageButton
        ReadOnly Property SkipNavigationLinks() As System.Web.UI.WebControls.HyperLink
        ReadOnly Property ThemeSelector() As System.Web.UI.WebControls.DropDownList
        ReadOnly Property UserStatusLbl() As System.Web.UI.WebControls.Label
      Property Visible() as Boolean
         

#End Region

    End Interface

  
End Namespace
  