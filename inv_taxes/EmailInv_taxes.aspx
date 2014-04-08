<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EmailInv_taxes" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EmailInv_taxes.aspx.vb" Culture="en-IN" MasterPageFile="~/Master Pages/Email.master" Inherits="ServelInvocing.UI.EmailInv_taxes" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    
                <table cellpadding="0" cellspacing="0" border="0"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <ServelInvocing:Inv_taxesRecordControl runat="server" id="Inv_taxesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_taxesTitle" Text="&lt;%#String.Concat(&quot;Taxes&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_taxesRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Inv_taxesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="id_inv_hdrLabel" Text="ID Inv HDR">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_inv_hdr"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="id_taxesLabel" Text="ID Taxes">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_taxes"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_codeLabel" Text="Tax Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_code"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_nameLabel" Text="Tax Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_name"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_printLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_rateLabel" Text="Tax Rate">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_rate"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_onLabel" Text="Tax On">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_on"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_amountLabel" Text="Tax Amount">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_lockLabel" Text="Tax Lock">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_lock"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="calc_typeLabel" Text="Calc Type">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="calc_type"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="sort_orderLabel" Text="Sort Order">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="sort_order"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_typeLabel" Text="Tax Type">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_type"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="item_total"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="excise_totalLabel" Text="Excise Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="excise_total"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="grand_total"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_taxesRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr></table>
    
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                