<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowTransporters.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.ShowTransporters" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.ShowTransporters" Assembly="ServelInvocing" %>

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

                        <ServelInvocing:TransportersRecordControl runat="server" id="TransportersRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="TransportersRecordControlPanelExtender" runat="server" TargetControlid="TransportersRecordControlCollapsibleRegion" ExpandControlID="TransportersRecordControlIcon" CollapseControlID="TransportersRecordControlIcon" ImageControlID="TransportersRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="TransportersRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="TransportersTitle" Text="&lt;%#String.Concat(&quot;Transporters&quot;) %>">	</asp:Literal></td><td class="dhir"><asp:ImageButton runat="server" id="TransportersDialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="TransportersRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="TransportersRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="nameLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="name"></asp:Literal></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="addressLabel" Text="Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:Literal runat="server" id="address"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="cityLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="city"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="contactLabel" Text="Contact">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="contact"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="phone"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="emailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="email"></asp:Literal></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="pan_noLabel" Text="Pan Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="pan_no"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="Tin Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="tin_no"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:TransportersRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                