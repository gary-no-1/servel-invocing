<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="AddParty.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.AddParty" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.AddParty" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

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

                        <ServelInvocing:PartyRecordControl runat="server" id="PartyRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="PartyRecordControlPanelExtender" runat="server" TargetControlid="PartyRecordControlCollapsibleRegion" ExpandControlID="PartyRecordControlIcon" CollapseControlID="PartyRecordControlIcon" ImageControlID="PartyRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="PartyRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="PartyTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot; Party&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="PartyRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="PartyRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="party_codeLabel" Text="Party Code">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="party_code" Columns="4" MaxLength="4" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="party_codeTextBoxMaxLengthValidator" ControlToValidate="party_code" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Party Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="nameLabel" Text="Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="name" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="nameTextBoxMaxLengthValidator" ControlToValidate="name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="cityLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="city" Columns="40" MaxLength="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="cityTextBoxMaxLengthValidator" ControlToValidate="city" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;City&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="contactLabel" Text="Contact">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="contact" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="contactTextBoxMaxLengthValidator" ControlToValidate="contact" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="phone" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="phoneTextBoxMaxLengthValidator" ControlToValidate="phone" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="lst_noLabel" Text="Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="lst_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="lst_noTextBoxMaxLengthValidator" ControlToValidate="lst_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="cst_noLabel" Text="Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="cst_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="cst_noTextBoxMaxLengthValidator" ControlToValidate="cst_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="lst_dateLabel" Text="Date">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="lst_date" Columns="20" MaxLength="20" onkeyup="DateFormat(this, this.value, event.keyCode, 'dd-mm-yyyy')" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("lst_date"),"DateTextBox","dd-mm-yyyy","","") %>
</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="lst_dateCalendarExtender" TargetControlID="lst_date" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="lst_dateTextBoxMaxLengthValidator" ControlToValidate="lst_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="cst_dateLabel" Text="Date">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="cst_date" Columns="20" MaxLength="20" onkeyup="DateFormat(this, this.value, event.keyCode, 'dd-mm-yyyy')" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("cst_date"),"DateTextBox","dd-mm-yyyy","","") %>
</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="cst_dateCalendarExtender" TargetControlID="cst_date" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="cst_dateTextBoxMaxLengthValidator" ControlToValidate="cst_date" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="fls"><asp:Literal runat="server" id="vat_noLabel" Text="VAT Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="vat_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="vat_noTextBoxMaxLengthValidator" ControlToValidate="vat_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;VAT Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="pan_noLabel" Text="Pan Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="pan_no" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pan_noTextBoxMaxLengthValidator" ControlToValidate="pan_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Pan Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="ecc_noLabel" Text="ECC Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="ecc_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ecc_noTextBoxMaxLengthValidator" ControlToValidate="ecc_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;ECC Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="st37_noLabel" Text="37 Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="st37_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="st37_noTextBoxMaxLengthValidator" ControlToValidate="st37_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;37 Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="Tin Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="tin_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_noTextBoxMaxLengthValidator" ControlToValidate="tin_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tin Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="addressLabel" Text="Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:TextBox runat="server" id="address" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="addressTextBoxMaxLengthValidator" ControlToValidate="address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
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
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="SitesDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="SitesResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="SitesPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="1"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="SitesToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="party_codeLabel2" Text="Party Code" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="nameLabel2" Text="Name" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="addressLabel1" Text="Address" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="cityLabel1" Text="City" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="contactLabel1" Text="Contact" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="phoneLabel1" Text="Phone" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="vat_noLabel1" Text="VAT Number" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="pan_noLabel1" Text="Pan Number" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="ecc_noLabel1" Text="Number" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="st37_noLabel1" Text="37 Number" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tin_noLabel1" Text="Tin Number" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="SitesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:SitesTableControlRow runat="server" id="SitesTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="SitesRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticwb"><asp:CheckBox runat="server" id="SitesRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style=""><asp:TextBox runat="server" id="party_code1" Columns="4" MaxLength="4" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="party_code1TextBoxMaxLengthValidator" ControlToValidate="party_code1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Party Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="name1" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="name1TextBoxMaxLengthValidator" ControlToValidate="name1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="address1" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="address1TextBoxMaxLengthValidator" ControlToValidate="address1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="city1" Columns="40" MaxLength="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="city1TextBoxMaxLengthValidator" ControlToValidate="city1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;City&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="contact1" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="contact1TextBoxMaxLengthValidator" ControlToValidate="contact1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="phone1" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="phone1TextBoxMaxLengthValidator" ControlToValidate="phone1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="vat_no1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="vat_no1TextBoxMaxLengthValidator" ControlToValidate="vat_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;VAT Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="pan_no1" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="pan_no1TextBoxMaxLengthValidator" ControlToValidate="pan_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Pan Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="ecc_no1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ecc_no1TextBoxMaxLengthValidator" ControlToValidate="ecc_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="st37_no1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="st37_no1TextBoxMaxLengthValidator" ControlToValidate="st37_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;37 Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="tin_no1" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_no1TextBoxMaxLengthValidator" ControlToValidate="tin_no1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tin Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></ServelInvocing:SitesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:SitesTableControl>

 </ContentTemplate></asp:TabPanel>
</asp:TabContainer></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="SaveAndNewButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                