﻿<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Menu_ItemVertical.ascx.vb" Inherits="ServelInvocing.UI.Menu_ItemVertical" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);" width="100%"><tr><td class="mvTL"><img src="../Images/space.gif" height="5" width="5" alt="" /></td><td class="mvT"><img src="../Images/space.gif" height="5" alt="" /></td><td class="mvTR"><img src="../Images/space.gif" height="5" width="5" alt="" /></td></tr><tr><td class="mvL"><img src="../Images/space.gif" height="18" width="5" alt="" /></td><td class="mvC"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="menu">		
	</asp:LinkButton></td><td class="mvR"><img src="../Images/space.gif" height="18" width="5" alt="" /></td></tr><tr><td class="mvBL"><img src="../Images/space.gif" height="5" width="5" alt="" /></td><td class="mvB"><img src="../Images/space.gif" height="5" alt="" /></td><td class="mvBR"><img src="../Images/space.gif" height="5" width="5" alt="" /></td></tr></table>