<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EmailInv_hdr.aspx.vb" Culture="en-IN" MasterPageFile="~/Master Pages/Email.master" Inherits="ServelInvocing.UI.EmailInv_hdr" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EmailInv_hdr" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    
                <table cellpadding="0" cellspacing="0" border="0"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <ServelInvocing:Inv_hdrRecordControl runat="server" id="Inv_hdrRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_hdrTitle" Text="&lt;%#String.Concat(&quot;Inv hdr&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_hdrRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Inv_hdrRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="pro_inv_noLabel" Text="Pro Inv Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pro_inv_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="pro_inv_dtLabel" Text="Pro Inv DT">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pro_inv_dt"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="sale_ord_noLabel" Text="Sale Order No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="sale_ord_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="sale_ord_dtLabel" Text="Sale Order Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="sale_ord_dt"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_partyLabel" Text="Party">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_party"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="bill_nameLabel" Text="Bill Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="bill_name"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="ship_nameLabel" Text="Ship Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ship_name"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tin_no"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="po_noLabel" Text="P.O. No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="po_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="po_dtLabel" Text="P.O. Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="po_dt"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_tax_groupLabel" Text="Tax Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_tax_group"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="item_total"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="grand_total"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="road_permit_noLabel" Text="Road Permit No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="road_permit_no"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="packing_detailsLabel" Text="Packing Details">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="packing_details"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="weightLabel" Text="Weight">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="weight"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="no_of_packagesLabel" Text="No Of Packages">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="no_of_packages"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="id_transporterLabel" Text="Transporter">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="id_transporter"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="gr_rr_noLabel" Text="GR / RR No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="gr_rr_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="gr_rr_dtLabel" Text="GR / RR Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="gr_rr_dt"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="freight_to_payLabel" Text="Freight To Pay">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="freight_to_pay"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="vehicle_noLabel" Text="Vehicle No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="vehicle_no"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="bill_addressLabel" Text="Bill Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:Literal runat="server" id="bill_address"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="ship_addressLabel" Text="Ship Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:Literal runat="server" id="ship_address"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_hdrRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td>
 
  <ServelInvocing:Inv_itemsTableControl runat="server" id="Inv_itemsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_itemsTitle" Text="&lt;%#String.Concat(&quot;Items&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_itemsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="id_itemLabel" Text="Item Code">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_codeLabel" Text="Item Code">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_descriptionLabel" Text="Item Description">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="uomLabel" Text="Uom">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="qtyLabel" Text="Quantity">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="rateLabel" Text="Rate">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="ass_valueLabel" Text="Value">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="amountLabel" Text="Amount">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Inv_itemsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_itemsTableControlRow runat="server" id="Inv_itemsTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="id_item"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="item_code"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="item_description"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="uom"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="qty"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="rate"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="ass_value"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="amount"></asp:Literal> </td></tr></ServelInvocing:Inv_itemsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_itemsTableControl>

 
 
  <ServelInvocing:Inv_taxesTableControl runat="server" id="Inv_taxesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_taxesTitle" Text="&lt;%#String.Concat(&quot;Taxes&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_taxesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="id_taxesLabel" Text="ID Taxes">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_codeLabel" Text="Tax Code">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_nameLabel" Text="Tax Name">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_printLabel" Text="Name">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_rateLabel" Text="Tax Rate">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_onLabel" Text="Tax On">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_amountLabel" Text="Tax Amount">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_lockLabel" Text="Tax Lock">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="calc_typeLabel" Text="Calc Type">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="sort_orderLabel" Text="Sort Order">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tax_typeLabel" Text="Tax Type">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_totalLabel1" Text="Item Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="excise_totalLabel" Text="Excise Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="grand_totalLabel1" Text="Grand Total">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Inv_taxesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_taxesTableControlRow runat="server" id="Inv_taxesTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="id_taxes"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_code"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_name"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_rate"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_on"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_lock"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="calc_type"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="sort_order"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_type"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="item_total1"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="excise_total"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="grand_total1"></asp:Literal> </td></tr></ServelInvocing:Inv_taxesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_taxesTableControl>

 
 
  <ServelInvocing:Inv_termsTableControl runat="server" id="Inv_termsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_termsTitle" Text="&lt;%#String.Concat(&quot;Terms&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_termsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="narrationLabel" Text="Narration">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="sort_orderLabel1" Text="Sort Order">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Inv_termsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_termsTableControlRow runat="server" id="Inv_termsTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="narration"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="sort_order1"></asp:Literal> </td></tr></ServelInvocing:Inv_termsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_termsTableControl>

 
</td></tr></table>
    
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                