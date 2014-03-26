<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Control Language="vb" AutoEventWireup="false" Codebehind="ThemeButton.ascx.vb" Inherits="ServelInvocing.UI.ThemeButton" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table class="buttonPadding" cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);"><tr><td class="bTL"></td><td class="bT"></td><td class="bTR"></td></tr><tr><td class="bL"></td><td class="bC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="button_link">		
	</asp:LinkButton></td><td class="bR"></td></tr><tr><td class="bBL"></td><td class="bB"></td><td class="bBR"></td></tr></table>