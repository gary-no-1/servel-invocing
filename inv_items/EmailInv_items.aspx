<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EmailInv_items" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EmailInv_items.aspx.vb" Culture="en-IN" MasterPageFile="~/Master Pages/Email.master" Inherits="ServelInvocing.UI.EmailInv_items" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    
                <table cellpadding="0" cellspacing="0" border="0"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <ServelInvocing:Inv_itemsRecordControl runat="server" id="Inv_itemsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_itemsTitle" Text="&lt;%#String.Concat(&quot;Items&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_itemsRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Inv_itemsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="id_inv_hdrLabel" Text="ID Inv HDR">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_inv_hdr"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="id_itemLabel" Text="Item Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_item"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="item_codeLabel" Text="Item Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="item_code"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="item_descriptionLabel" Text="Item Description">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="item_description"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="uomLabel" Text="Uom">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="uom"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="qtyLabel" Text="Quantity">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="qty"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="rateLabel" Text="Rate">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="rate"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="ass_valueLabel" Text="Value">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ass_value"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="amountLabel" Text="Amount">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="amount"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_itemsRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
    
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                