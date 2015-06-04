<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.V_Invoice_AmountsWebReport" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="V_Invoice_AmountsWebReport.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.V_Invoice_AmountsWebReport" %>
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
                        <ServelInvocing:V_Invoice_AmountsTableControl runat="server" id="V_Invoice_AmountsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="V_Invoice_AmountsTableControlPanelExtender" runat="server" TargetControlid="V_Invoice_AmountsTableControlCollapsibleRegion" ExpandControlID="V_Invoice_AmountsTableControlIcon" CollapseControlID="V_Invoice_AmountsTableControlIcon" ImageControlID="V_Invoice_AmountsTableControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="V_Invoice_AmountsTableControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="V_Invoice_AmountsTitle" Text="&lt;%#String.Concat(&quot;Invoice Amounts&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="V_Invoice_AmountsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" scope="col"><asp:Literal runat="server" id="idLabel1" Text="ID">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="inv_noLabel1" Text="Invoice No:">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="inv_dtLabel" Text="Invoice Date">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="id_partyLabel" Text="Party">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="excise_amtLabel" Text="Excise Amount">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="vat_amtLabel" Text="VAT Amount">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="cst_amtLabel" Text="CST Amount">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="srv_taxLabel" Text="Service Tax">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="oth_amtLabel" Text="Other Amount">	</asp:Literal>
                        </th><th class="thc" scope="col"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal>
                        </th></tr><asp:Repeater runat="server" id="V_Invoice_AmountsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:V_Invoice_AmountsTableControlRow runat="server" id="V_Invoice_AmountsTableControlRow">
<tr><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="id1"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="inv_no"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="inv_dt"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="id_party"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="item_total"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="excise_amt"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="vat_amt"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="cst_amt"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="srv_tax"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="oth_amt"></asp:Literal> </td><td class="ttc" style="text-align: right;"><asp:Literal runat="server" id="grand_total"></asp:Literal> </td></tr></ServelInvocing:V_Invoice_AmountsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:V_Invoice_AmountsTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                