<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowCompany.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.ShowCompany" %>
<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.ShowCompany" Assembly="ServelInvocing" %>

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

                        <ServelInvocing:CompanyRecordControl runat="server" id="CompanyRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="CompanyRecordControlPanelExtender" runat="server" TargetControlid="CompanyRecordControlCollapsibleRegion" ExpandControlID="CompanyRecordControlIcon" CollapseControlID="CompanyRecordControlIcon" ImageControlID="CompanyRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="CompanyRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="CompanyTitle" Text="&lt;%#String.Concat(&quot;Company&quot;) %>">	</asp:Literal></td><td class="dhir"><asp:ImageButton runat="server" id="CompanyDialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="CompanyRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="CompanyRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="nameLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="name"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="addressLabel" Text="Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:Literal runat="server" id="address"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="cityLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="city"></asp:Literal></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="stateLabel" Text="State">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="state"></asp:Literal></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="pincodeLabel" Text="Pin Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pincode"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="phone"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="emailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="email"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="pan_noLabel" Text="PAN">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pan_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tin_no"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="gst_noLabel" Text="GST No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="gst_no"></asp:Literal></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="srv_tax_noLabel" Text="Service Tax No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="srv_tax_no"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="tan_noLabel" Text="TAN">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tan_no"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="rangeLabel" Text="Range">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="range"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="divisionLabel" Text="Division">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="division"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="ecc_noLabel" Text="ECC No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="ecc_no"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="cer_noLabel" Text="CER No.">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="cer_no"></asp:Literal></td></tr><tr><td class="fls" colspan="4"><hr></hr></td></tr><tr><td class="fls"><asp:Literal runat="server" id="fin_year_startLabel" Text="Fin Year Start">	</asp:Literal></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="fin_year_start"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="fin_year_endLabel" Text="Fin Year End">	</asp:Literal></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="fin_year_end"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="inv_pfxLabel" Text="Invoice Prefix">	</asp:Literal></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="inv_pfx"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="inv_sfxLabel" Text="Invoice Suffix">	</asp:Literal></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="inv_sfx"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="next_inv_noLabel" Text="Next Invoice No:">	</asp:Literal></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="next_inv_no"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="pad_inv_noLabel" Text="Invoice Number Length">	</asp:Literal></td><td class="fls" style="text-align:left;"><asp:Literal runat="server" id="pad_inv_no"></asp:Literal></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:CompanyRecordControl>

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
                