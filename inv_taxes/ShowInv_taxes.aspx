<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowInv_taxes.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.ShowInv_taxes" %>
<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.ShowInv_taxes" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

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

                <table cellpadding="0" cellspacing="0" border="0"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <ServelInvocing:Inv_taxesRecordControl runat="server" id="Inv_taxesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Inv_taxesRecordControlPanelExtender" runat="server" TargetControlid="Inv_taxesRecordControlCollapsibleRegion" ExpandControlID="Inv_taxesRecordControlIcon" CollapseControlID="Inv_taxesRecordControlIcon" ImageControlID="Inv_taxesRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Inv_taxesRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_taxesTitle" Text="&lt;%#String.Concat(&quot;Taxes&quot;) %>">	</asp:Literal></td><td class="dhir"><asp:ImageButton runat="server" id="Inv_taxesDialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_taxesRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Inv_taxesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="id_inv_hdrLabel" Text="ID Inv HDR">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="id_inv_hdr" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="fls"><asp:Literal runat="server" id="id_taxesLabel" Text="ID Taxes">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="id_taxes" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_codeLabel" Text="Tax Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_code"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_nameLabel" Text="Tax Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_name"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_printLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_rateLabel" Text="Tax Rate">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_rate"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_onLabel" Text="Tax On">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_on"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_amountLabel" Text="Tax Amount">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_lockLabel" Text="Tax Lock">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_lock"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="calc_typeLabel" Text="Calc Type">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="calc_type"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="sort_orderLabel" Text="Sort Order">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="sort_order"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_typeLabel" Text="Tax Type">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_type"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="item_total"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="excise_totalLabel" Text="Excise Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="excise_total"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="grand_total"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_taxesRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                