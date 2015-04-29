<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ViewMasters.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.ViewMasters" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

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

                <table cellpadding="0" cellspacing="0" border="0"><tr><td><table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="BlankPanelWithHeaderPanelExtender" runat="server" TargetControlid="BlankPanelWithHeaderCollapsibleRegion" ExpandControlID="BlankPanelWithHeaderIcon" CollapseControlID="BlankPanelWithHeaderIcon" ImageControlID="BlankPanelWithHeaderIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="BlankPanelWithHeaderIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle">All the Masters</td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="BlankPanelWithHeaderCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0"><tr><td><asp:Button runat="server" id="btnCompany" bordercolor="#0" borderstyle="NotSet" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2&lt;/PRoles>" text="Company" width="205px">		
	</asp:Button></td><td></td><td></td></tr><tr><td colspan="3"><hr></hr></td></tr><tr><td><asp:Button runat="server" id="btnItemType" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2;4&lt;/PRoles>" text="Item Type" width="205px">		
	</asp:Button></td><td><asp:Button runat="server" id="btnItemGroup" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2;4&lt;/PRoles>" text="Item Group" width="205px">		
	</asp:Button></td><td><asp:Button runat="server" id="btnCommodity" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2;4&lt;/PRoles>" text="Commodity" width="205px">		
	</asp:Button></td></tr><tr><td colspan="3"><hr></hr></td></tr><tr><td><asp:Button runat="server" id="btnSalesPerson" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" text="Sale Person" width="205px">		
	</asp:Button></td><td><asp:Button runat="server" id="btnUOM" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2;3;4&lt;/PRoles>" text="Units Of Measure" width="205px">		
	</asp:Button></td><td><asp:Button runat="server" id="btnTerms" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2&lt;/PRoles>" text="Terms" width="205px">		
	</asp:Button></td></tr><tr><td colspan="3"><hr></hr></td></tr><tr><td><asp:Button runat="server" id="btnTaxTypes" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2&lt;/PRoles>" text="Tax Types" width="205px">		
	</asp:Button></td><td><asp:Button runat="server" id="btnTaxes" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2;4&lt;/PRoles>" text="Taxes" width="205px">		
	</asp:Button></td><td><asp:Button runat="server" id="btnTaxGroups" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2&lt;/PRoles>" text="Tax Groups" width="205px">		
	</asp:Button></td></tr><tr><td colspan="3"><hr></hr></td></tr><tr><td><asp:Button runat="server" id="btnTransporter" causesvalidation="False" commandname="Redirect" consumers="page" height="50px" requiredroles="&lt;PRoles>1;2;4&lt;/PRoles>" text="Transporters" width="205px">		
	</asp:Button></td><td></td><td></td></tr></table>
</td></tr></table>
</asp:panel></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                