<%@ Control Language="vb" AutoEventWireup="false" Codebehind="EmailHeader.ascx.vb" Inherits="ServelInvocing.UI.EmailHeader" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table cellpadding="0" cellspacing="0" border="0" width="100%" class="logoEmailBG"><tr><td><asp:Image runat="server" id="_Logo" alternatetext="&lt;%# GetResourceValue(&quot;Txt:PageHeader&quot;, &quot;ServelInvocing&quot;) %>" imageurl="../Images/logoEmail.gif" style="border-width:0px;">		
	</asp:Image></td></tr></table>