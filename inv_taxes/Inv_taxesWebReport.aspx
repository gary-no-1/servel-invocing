<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Inv_taxesWebReport.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.Inv_taxesWebReport" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.Inv_taxesWebReport" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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
                        <ServelInvocing:Inv_taxesTableControl runat="server" id="Inv_taxesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Inv_taxesTableControlPanelExtender" runat="server" TargetControlid="Inv_taxesTableControlCollapsibleRegion" ExpandControlID="Inv_taxesTableControlIcon" CollapseControlID="Inv_taxesTableControlIcon" ImageControlID="Inv_taxesTableControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Inv_taxesTableControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_taxesTitle" Text="&lt;%#String.Concat(&quot;Taxes&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_taxesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="id_inv_hdrLabel1" Text="ID Inv HDR">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="id_taxesLabel1" Text="ID Taxes">	</asp:Literal>
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
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="excise_totalLabel" Text="Excise Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="Inv_taxesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_taxesTableControlRow runat="server" id="Inv_taxesTableControlRow">
<tr><td class="ttc"><asp:Literal runat="server" id="id_inv_hdr"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="id_taxes"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_code"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_name"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_rate"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_on"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_lock"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="calc_type"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="sort_order"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="tax_type"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="item_total"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="excise_total"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="grand_total"></asp:Literal> </td></tr></ServelInvocing:Inv_taxesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_taxesTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                