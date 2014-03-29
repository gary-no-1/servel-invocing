<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.ShowPro_inv_taxes" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowPro_inv_taxes.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.ShowPro_inv_taxes" %>
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

                        <ServelInvocing:Pro_inv_taxesRecordControl runat="server" id="Pro_inv_taxesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Pro_inv_taxesRecordControlPanelExtender" runat="server" TargetControlid="Pro_inv_taxesRecordControlCollapsibleRegion" ExpandControlID="Pro_inv_taxesRecordControlIcon" CollapseControlID="Pro_inv_taxesRecordControlIcon" ImageControlID="Pro_inv_taxesRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Pro_inv_taxesRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Pro_inv_taxesTitle" Text="&lt;%#String.Concat(&quot;Pro Inv Taxes&quot;) %>">	</asp:Literal></td><td class="dhir"><asp:ImageButton runat="server" id="Pro_inv_taxesDialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Pro_inv_taxesRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Pro_inv_taxesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="id_pro_inv_hdrLabel" Text="ID Pro Inv HDR">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="id_pro_inv_hdr" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="fls"><asp:Literal runat="server" id="id_taxesLabel" Text="Tax Code">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="id_taxes" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_codeLabel" Text="Tax Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_code"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_nameLabel" Text="Tax Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_name"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tax_printLabel" Text="Tax Print">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tax_amountLabel" Text="Tax Amount">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Pro_inv_taxesRecordControl>

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
                