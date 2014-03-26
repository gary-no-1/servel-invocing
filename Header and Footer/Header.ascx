<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Header.ascx.vb" Inherits="ServelInvocing.UI.Header" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table cellpadding="0" cellspacing="0" border="0" width="100%" class="logoBG"><tr><td style="vertical-align:top;"><asp:HyperLink runat="server" id="_SkipNavigationLinks" cssclass="skipNavigationLinks" navigateurl="#StartOfPageContent" text="&lt;%# GetResourceValue(&quot;Txt:SkipNavigation&quot;, &quot;ServelInvocing&quot;) %>" tooltip="&lt;%# GetResourceValue(&quot;Txt:SkipNavigation&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:HyperLink></td><td style="text-align:right; vertical-align:top;" rowspan="2"><table cellpadding="0" cellspacing="0" border="0"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td style="width:100%;"></td><td><asp:Image runat="server" id="_LeftImage" height="23" imageurl="../Images/SignInBarL.gif" width="36">		
	</asp:Image></td><td class="signInBar"><asp:dropdownlist id="LanguageSelector" runat="server" cssclass="Filter_Input" AutoPostBack="true"></asp:dropdownlist></td><td><asp:Image runat="server" id="_Divider1" imageurl="../Images/SignInBarDivider.gif">		
	</asp:Image></td><td class="signInBar"><asp:dropdownlist id="ThemeSelector" runat="server" cssclass="Filter_Input" AutoPostBack="true"></asp:dropdownlist></td><td><asp:Image runat="server" id="_Divider0" imageurl="../Images/SignInBarDivider.gif">		
	</asp:Image></td><td class="signInBar"><asp:LinkButton runat="server" id="_SignIn" causesvalidation="False" commandname="ShowSignIn">		
	</asp:LinkButton></td><td><asp:ImageButton runat="server" id="_SIOImage" causesvalidation="False" commandname="ShowSIOImage" imageurl="../Images/SignInBarSignIn.gif">		
	</asp:ImageButton></td><td><asp:Image runat="server" id="_Divider2" imageurl="../Images/SignInBarDivider.gif">		
	</asp:Image></td><td><a href="javascript:printPage();" /><asp:Image runat="server" id="_SignInBarPrintButton" imageurl="../Images/SignInBarPrint.gif" onmouseout="this.src='../Images/SignInBarPrint.gif';" onmouseover="this.src='../Images/SignInBarPrintOver.gif';" tooltip="&lt;%# GetResourceValue(&quot;Txt:PrintPage&quot;, &quot;ServelInvocing&quot;) %>" style="border:0px;">		
	</asp:Image></td><td><asp:Image runat="server" id="_RightImage" height="23" imageurl="../Images/SignInBarR.gif" width="36">		
	</asp:Image></td></tr></table>
</td></tr><tr><td class="signInBarStatus"><asp:Label runat="server" id="_UserStatusLbl" width="300">	</asp:Label></td></tr></table>
</td></tr><tr><td><asp:Image runat="server" id="_Logo" alternatetext="&lt;%# GetResourceValue(&quot;Txt:PageHeader&quot;, &quot;ServelInvocing&quot;) %>" imageurl="../Images/Logo.gif" style="border-width:0px;">		
	</asp:Image></td></tr></table>