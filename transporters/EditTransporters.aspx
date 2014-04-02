<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EditTransporters" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditTransporters.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.EditTransporters" %>
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
<asp:ImageButton id="TransportersRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="TransportersTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot; Transporters&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="TransportersRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="TransportersRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="nameLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="name" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="nameTextBoxMaxLengthValidator" ControlToValidate="name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="addressLabel" Text="Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:TextBox runat="server" id="address" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="addressTextBoxMaxLengthValidator" ControlToValidate="address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="cityLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="city" Columns="40" MaxLength="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="cityTextBoxMaxLengthValidator" ControlToValidate="city" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;City&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="contactLabel" Text="Contact">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="contact" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="contactTextBoxMaxLengthValidator" ControlToValidate="contact" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="phone" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="phoneTextBoxMaxLengthValidator" ControlToValidate="phone" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="emailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="email" MaxLength="50" columns="60" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="emailTextBoxMaxLengthValidator" ControlToValidate="email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="pan_noLabel" Text="Pan Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="pan_no" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pan_noTextBoxMaxLengthValidator" ControlToValidate="pan_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Pan Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="Tin Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="tin_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_noTextBoxMaxLengthValidator" ControlToValidate="tin_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tin Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:TransportersRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                