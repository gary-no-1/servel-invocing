﻿<%@ Register Tagprefix="ServelInvocing" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EditParty" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditParty.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.EditParty" %>
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

                        <ServelInvocing:PartyRecordControl runat="server" id="PartyRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PartyRecordControlPanelExtender" runat="server" TargetControlid="PartyRecordControlCollapsibleRegion" ExpandControlID="PartyRecordControlIcon" CollapseControlID="PartyRecordControlIcon" ImageControlID="PartyRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="PartyRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="PartyTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot; Party&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="PartyRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="PartyRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="nameLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="name" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="nameTextBoxMaxLengthValidator" ControlToValidate="name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="addressLabel" Text="Address">	</asp:Literal></td><td class="dfv" colspan="2"><asp:TextBox runat="server" id="address" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="addressTextBoxMaxLengthValidator" ControlToValidate="address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="cityLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="city" Columns="40" MaxLength="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="cityTextBoxMaxLengthValidator" ControlToValidate="city" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;City&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="id_statesLabel" Text="State">	</asp:Literal></td><td class="dfv"><asp:DropDownList runat="server" id="id_states" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_statesFvLlsHyperLink" ControlToUpdate="id_states" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="states" Field="States_.id" DisplayField="States_.state_name"></Selectors:FvLlsHyperLink></td></tr><tr><td class="fls"><asp:Literal runat="server" id="contactLabel" Text="Contact">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="contact" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="contactTextBoxMaxLengthValidator" ControlToValidate="contact" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="emailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="email" MaxLength="50" columns="60" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="emailTextBoxMaxLengthValidator" ControlToValidate="email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="phone" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="phoneTextBoxMaxLengthValidator" ControlToValidate="phone" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="tin_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_noTextBoxMaxLengthValidator" ControlToValidate="tin_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;TIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="gst_noLabel" Text="GST No.">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="gst_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="gst_noTextBoxMaxLengthValidator" ControlToValidate="gst_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;GST No.&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="pan_noLabel" Text="PAN">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="pan_no" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pan_noTextBoxMaxLengthValidator" ControlToValidate="pan_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;PAN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="ecc_noLabel" Text="ECC No.">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="ecc_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ecc_noTextBoxMaxLengthValidator" ControlToValidate="ecc_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;ECC No.&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:PartyRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><asp:TabContainer runat="server" id="PartyTabContainer">
 <asp:TabPanel runat="server" id="SitesTabPanel" HeaderText="Sites">	<ContentTemplate>
  <ServelInvocing:SitesTableControl runat="server" id="SitesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="SitesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><asp:ImageButton runat="server" id="SitesAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="SitesEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="SitesDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="SitesResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="SitesPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="SitesToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="nameLabel2" Text="Name" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="addressLabel1" Text="Address" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="cityLabel1" Text="City" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="contactLabel1" Text="Contact" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="phoneLabel1" Text="Phone" CausesValidation="False">	</asp:LinkButton></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="emailLabel1" Text="Email" CausesValidation="False">	</asp:LinkButton></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tin_noLabel1" Text="TIN" CausesValidation="False">	</asp:LinkButton></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="gst_noLabel1" Text="GST No." CausesValidation="False">	</asp:LinkButton></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="pan_noLabel1" Text="Pan Number" CausesValidation="False">	</asp:LinkButton></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="ecc_noLabel1" Text="ECC No." CausesValidation="False">	</asp:LinkButton></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_statesLabel1" Text="State" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="SitesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:SitesTableControlRow runat="server" id="SitesTableControlRow">
<tr><td class="ticwb"><asp:CheckBox runat="server" id="SitesRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style=""><asp:TextBox runat="server" id="name1" Columns="50" MaxLength="50" cssclass="field_input" width="150px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="name1TextBoxMaxLengthValidator" ControlToValidate="name1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="address1" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine" width="200px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="address1TextBoxMaxLengthValidator" ControlToValidate="address1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="city1" Columns="40" MaxLength="40" cssclass="field_input" width="100px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="city1TextBoxMaxLengthValidator" ControlToValidate="city1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;City&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="contact1" Columns="50" MaxLength="50" cssclass="field_input" width="75px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="contact1TextBoxMaxLengthValidator" ControlToValidate="contact1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="phone1" Columns="50" MaxLength="50" cssclass="field_input" width="75px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="phone1TextBoxMaxLengthValidator" ControlToValidate="phone1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" style=""><asp:TextBox runat="server" id="email1" MaxLength="50" columns="60" cssclass="field_input" rows="2" textmode="SingleLine" width="150px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="email1TextBoxMaxLengthValidator" ControlToValidate="email1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" style=""><asp:TextBox runat="server" id="tin_no1" Columns="20" MaxLength="20" cssclass="field_input" width="75px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_no1TextBoxMaxLengthValidator" ControlToValidate="tin_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;TIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" style=""><asp:TextBox runat="server" id="gst_no1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="gst_no1TextBoxMaxLengthValidator" ControlToValidate="gst_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;GST No.&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" style=""><asp:TextBox runat="server" id="pan_no1" Columns="10" MaxLength="10" cssclass="field_input" width="75px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pan_no1TextBoxMaxLengthValidator" ControlToValidate="pan_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Pan Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" style=""><asp:TextBox runat="server" id="ecc_no1" Columns="20" MaxLength="20" cssclass="field_input" width="75px"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ecc_no1TextBoxMaxLengthValidator" ControlToValidate="ecc_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;ECC No.&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="ttc" style=""><asp:DropDownList runat="server" id="id_states1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_states1FvLlsHyperLink" ControlToUpdate="id_states1" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="states" Field="States_.id" DisplayField="States_.state_name"></Selectors:FvLlsHyperLink></td></tr></ServelInvocing:SitesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:SitesTableControl>

 </ContentTemplate></asp:TabPanel>
</asp:TabContainer></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                