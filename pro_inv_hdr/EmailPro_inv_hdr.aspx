<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EmailPro_inv_hdr" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EmailPro_inv_hdr.aspx.vb" Culture="en-IN" MasterPageFile="~/Master Pages/Email.master" Inherits="ServelInvocing.UI.EmailPro_inv_hdr" %>
<%@ Register Tagprefix="ServelInvocing" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    
                <table cellpadding="0" cellspacing="0" border="0"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <ServelInvocing:Pro_inv_hdrRecordControl runat="server" id="Pro_inv_hdrRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Pro_inv_hdrTitle" Text="&lt;%#String.Concat(&quot;Pro Inv HDR&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Pro_inv_hdrRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Pro_inv_hdrRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="pro_inv_noLabel" Text="Pro Inv No:">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pro_inv_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="pro_inv_dtLabel" Text="Pro Inv Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pro_inv_dt"></asp:Literal> </td><td class="dfv"><asp:Literal runat="server" id="id1" visible="True"></asp:Literal></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="bill_nameLabel" Text="Bill Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="bill_name"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="bill_addressLabel" Text="Bill Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:Literal runat="server" id="bill_address"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="ship_nameLabel" Text="Ship Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ship_name"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="ship_addressLabel" Text="Ship Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:Literal runat="server" id="ship_address"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tin_no"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td><td class="dfv"></td><td class="dfv"><ServelInvocing:ThemeButton runat="server" id="BtnEmail" button-causesvalidation="False" button-commandname="Redirect" button-text="Send Email" postback="True"></ServelInvocing:ThemeButton></td></tr><tr><td class="fls"><asp:Literal runat="server" id="emailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="txtEmail">	</asp:TextBox></td><td class="fls"><asp:Literal runat="server" id="email" visible="False"></asp:Literal></td><td class="dfv"></td><td class="dfv"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="additional_emailLabel" Text="Additional Email">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="txtAddEmail">	</asp:TextBox></td><td class="fls"><asp:Literal runat="server" id="additional_email" visible="False"></asp:Literal></td><td class="dfv"></td><td class="dfv"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="phone"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="contactLabel" Text="Contact">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="contact"></asp:Literal></td><td class="dfv"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="item_total"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="grand_total"></asp:Literal></td><td class="dfv"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Pro_inv_hdrRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td>
 
  <ServelInvocing:Pro_inv_itemsTableControl runat="server" id="Pro_inv_itemsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Pro_inv_itemsTitle" Text="&lt;%#String.Concat(&quot;Pro Inv Items&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Pro_inv_itemsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="id_itemLabel" Text="Item Code">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_descriptionLabel" Text="Item Description">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="uomLabel" Text="Uom">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="qtyLabel" Text="Quantity">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="rateLabel" Text="Rate">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="amountLabel" Text="Amount">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Pro_inv_itemsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Pro_inv_itemsTableControlRow runat="server" id="Pro_inv_itemsTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="id_item"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="item_description"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="uom"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="qty"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="rate"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="amount"></asp:Literal> </td></tr></ServelInvocing:Pro_inv_itemsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Pro_inv_itemsTableControl>

 
 
  <ServelInvocing:Pro_inv_taxesTableControl runat="server" id="Pro_inv_taxesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Pro_inv_taxesTitle" Text="&lt;%#String.Concat(&quot;Pro Inv Taxes&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Pro_inv_taxesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="tax_printLabel" Text="Tax Print">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_rateLabel" Text="Tax Rate">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_onLabel" Text="Tax On">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_amountLabel" Text="Tax Amount">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Pro_inv_taxesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Pro_inv_taxesTableControlRow runat="server" id="Pro_inv_taxesTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_rate"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_on"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td></tr></ServelInvocing:Pro_inv_taxesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Pro_inv_taxesTableControl>

 
 
</td></tr></table>
    
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                