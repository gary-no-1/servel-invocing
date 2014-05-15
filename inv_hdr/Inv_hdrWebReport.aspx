<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.Inv_hdrWebReport" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Inv_hdrWebReport.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.Inv_hdrWebReport" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style=" position:absolute; padding:30px;">
					<img src="../Images/updating.gif" alt="" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>
				<input type="hidden" id="_clientSideIsPostBack" name="clientSideIsPostBack" runat="server" />

                <table cellpadding="0" cellspacing="0" border="0"><tr><td>
                        <ServelInvocing:Inv_hdrTableControl runat="server" id="Inv_hdrTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Inv_hdrTableControlPanelExtender" runat="server" TargetControlid="Inv_hdrTableControlCollapsibleRegion" ExpandControlID="Inv_hdrTableControlIcon" CollapseControlID="Inv_hdrTableControlIcon" ImageControlID="Inv_hdrTableControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Inv_hdrTableControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_hdrTitle" Text="&lt;%#String.Concat(&quot;Inv hdr&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_hdrTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="pro_inv_noLabel" Text="Pro Inv No:">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="pro_inv_dtLabel" Text="Pro Inv Date">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="sale_ord_noLabel" Text="OA No:">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="sale_ord_dtLabel" Text="OA Date">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="id_partyLabel1" Text="Party">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="bill_nameLabel" Text="Bill Name">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="bill_addressLabel" Text="Bill Address">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="ship_nameLabel" Text="Ship Name">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="ship_addressLabel" Text="Ship Address">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="po_noLabel" Text="P.O. No:">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="po_dtLabel" Text="P.O. Date">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="id_tax_groupLabel1" Text="Tax Code">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="road_permit_noLabel" Text="Road Permit No.">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="packing_detailsLabel" Text="Packing Details">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="weightLabel" Text="Weight">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="no_of_packagesLabel" Text="No Of Packages">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="id_transporterLabel" Text="Transporter">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="gr_rr_noLabel" Text="GR / RR No:">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="gr_rr_dtLabel" Text="GR / RR Date">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="freight_to_payLabel" Text="Freight To Pay">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="vehicle_noLabel" Text="Vehicle No:">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Inv_hdrTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_hdrTableControlRow runat="server" id="Inv_hdrTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="pro_inv_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="pro_inv_dt"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="sale_ord_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="sale_ord_dt"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="id_party"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="bill_name"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="bill_address"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="ship_name"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="ship_address"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tin_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="po_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="po_dt"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="id_tax_group"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="item_total"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="grand_total"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="road_permit_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="packing_details"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="weight"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="no_of_packages"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="id_transporter"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="gr_rr_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="gr_rr_dt"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="freight_to_pay"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="vehicle_no"></asp:Literal> </td></tr></ServelInvocing:Inv_hdrTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_hdrTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                