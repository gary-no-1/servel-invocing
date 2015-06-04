<%@ Register Tagprefix="ServelInvocing" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EditSo_hdr" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditSo_hdr.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.EditSo_hdr" %>
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

                        <ServelInvocing:So_hdrRecordControl runat="server" id="So_hdrRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="So_hdrRecordControlPanelExtender" runat="server" TargetControlid="So_hdrRecordControlCollapsibleRegion" ExpandControlID="So_hdrRecordControlIcon" CollapseControlID="So_hdrRecordControlIcon" ImageControlID="So_hdrRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="So_hdrRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="So_hdrTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot; So hdr&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="So_hdrRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="So_hdrRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="sale_ord_noLabel" Text="Sale Order No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="sale_ord_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="sale_ord_noTextBoxMaxLengthValidator" ControlToValidate="sale_ord_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sale Order No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="sale_ord_dtLabel" Text="Sale Order Date">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="sale_ord_dt" Columns="20" MaxLength="20" onkeyup="DateFormat(this, this.value, event.keyCode, 'dd-mm-yyyy')" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("sale_ord_dt"),"DateTextBox","dd-mm-yyyy","","") %>
</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="sale_ord_dtCalendarExtender" TargetControlID="sale_ord_dt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="sale_ord_dtTextBoxMaxLengthValidator" ControlToValidate="sale_ord_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sale Order Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_partyLabel" Text="Party">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_party" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_partyFvLlsHyperLink" ControlToUpdate="id_party" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="party" Field="Party_.id" DisplayField="Party_.name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_partyAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"><asp:Literal runat="server" id="bill_nameLabel" Text="Bill Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="bill_name" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="bill_nameTextBoxMaxLengthValidator" ControlToValidate="bill_name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Bill Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_siteLabel" Text="Site">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_site" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_siteFvLlsHyperLink" ControlToUpdate="id_site" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="sites" Field="Sites_.id" DisplayField="Sites_.name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_siteAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"><asp:Literal runat="server" id="ship_nameLabel" Text="Ship Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="ship_name" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ship_nameTextBoxMaxLengthValidator" ControlToValidate="ship_name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ship Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="tin_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_noTextBoxMaxLengthValidator" ControlToValidate="tin_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;TIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="po_noLabel" Text="P.O. No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="po_no" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="po_noTextBoxMaxLengthValidator" ControlToValidate="po_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;P.O. No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="po_dtLabel" Text="P.O. Date">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="po_dt" Columns="20" MaxLength="20" onkeyup="DateFormat(this, this.value, event.keyCode, 'dd-mm-yyyy')" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("po_dt"),"DateTextBox","dd-mm-yyyy","","") %>
</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="po_dtCalendarExtender" TargetControlID="po_dt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="po_dtTextBoxMaxLengthValidator" ControlToValidate="po_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;P.O. Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="fls"><asp:Literal runat="server" id="ecc_noLabel" Text="ECC No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="ecc_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ecc_noTextBoxMaxLengthValidator" ControlToValidate="ecc_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;ECC No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_commodityLabel" Text="Commodity">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_commodity" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_commodityFvLlsHyperLink" ControlToUpdate="id_commodity" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="commodity" Field="Commodity_.id" DisplayField="Commodity_.commodity"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_commodityAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"><asp:Literal runat="server" id="id_tax_groupLabel" Text="Tax">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_tax_group" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_tax_groupFvLlsHyperLink" ControlToUpdate="id_tax_group" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="tax_groups" Field="Tax_groups_.id" DisplayField="Tax_groups_.tax_group_code"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_tax_groupAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="item_total" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("item_total"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="item_totalTextBoxMaxLengthValidator" ControlToValidate="item_total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="fls"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="grand_total" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("grand_total"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="grand_totalTextBoxMaxLengthValidator" ControlToValidate="grand_total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Grand Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="inv_cr8_dtLabel" Text="8">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="inv_cr8_dt" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">

</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="inv_cr8_dtCalendarExtender" TargetControlID="inv_cr8_dt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="inv_cr8_dtTextBoxMaxLengthValidator" ControlToValidate="inv_cr8_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;8&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="fls"><asp:Literal runat="server" id="inv_createdLabel" Text="Created">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="inv_created" Columns="3" MaxLength="3" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="inv_createdTextBoxMaxLengthValidator" ControlToValidate="inv_created" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="emailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="email" MaxLength="50" columns="60" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="emailTextBoxMaxLengthValidator" ControlToValidate="email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="additional_emailLabel" Text="Additional Email">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="additional_email" MaxLength="50" columns="60" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="additional_emailTextBoxMaxLengthValidator" ControlToValidate="additional_email" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Additional Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="contactLabel" Text="Contact">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="contact" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="contactTextBoxMaxLengthValidator" ControlToValidate="contact" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Contact&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="phoneLabel" Text="Phone">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="phone" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="phoneTextBoxMaxLengthValidator" ControlToValidate="phone" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="remarkLabel" Text="Remark">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="remark" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="remarkTextBoxMaxLengthValidator" ControlToValidate="remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="excise_remarkLabel" Text="Excise Remark">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="excise_remark" Columns="25" MaxLength="25" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="excise_remarkTextBoxMaxLengthValidator" ControlToValidate="excise_remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Excise Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_create_userLabel" Text="ID Create User">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_create_user" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_create_userFvLlsHyperLink" ControlToUpdate="id_create_user" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="users" Field="Users_.id" DisplayField="Users_.name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_create_userAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"><asp:Literal runat="server" id="created_onLabel" Text="Created On">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="created_on" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">

</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="created_onCalendarExtender" TargetControlID="created_on" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="created_onTextBoxMaxLengthValidator" ControlToValidate="created_on" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Created On&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_update_userLabel" Text="ID Update User">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_update_user" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_update_userFvLlsHyperLink" ControlToUpdate="id_update_user" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="users" Field="Users_.id" DisplayField="Users_.name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_update_userAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"><asp:Literal runat="server" id="last_updatedLabel" Text="Last Updated">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="last_updated" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">

</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="last_updatedCalendarExtender" TargetControlID="last_updated" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="last_updatedTextBoxMaxLengthValidator" ControlToValidate="last_updated" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Last Updated&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="bill_addressLabel" Text="Bill Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:TextBox runat="server" id="bill_address" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="bill_addressTextBoxMaxLengthValidator" ControlToValidate="bill_address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Bill Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="ship_addressLabel" Text="Ship Address">	</asp:Literal></td><td class="dfv" colspan="3"><asp:TextBox runat="server" id="ship_address" MaxLength="50" columns="60" cssclass="field_input" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ship_addressTextBoxMaxLengthValidator" ControlToValidate="ship_address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ship Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:So_hdrRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><asp:TabContainer runat="server" id="So_hdrTabContainer">
 <asp:TabPanel runat="server" id="So_itemsTabPanel" HeaderText="Items">	<ContentTemplate>
  <ServelInvocing:So_itemsTableControl runat="server" id="So_itemsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="So_itemsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><asp:ImageButton runat="server" id="So_itemsAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_itemsEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_itemsDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_itemsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="So_itemsPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="So_itemsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_itemLabel1" Text="ID Item" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="item_codeLabel1" Text="Item Code" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="item_descriptionLabel" Text="Item Description" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="uomLabel" Text="Uom" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="qtyLabel" Text="Quantity" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="rateLabel" Text="Rate" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="ass_valueLabel" Text="Value" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="amountLabel" Text="Amount" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="So_itemsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:So_itemsTableControlRow runat="server" id="So_itemsTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_itemsRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_itemsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_itemsRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticwb"><asp:CheckBox runat="server" id="So_itemsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_item" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_itemFvLlsHyperLink" ControlToUpdate="id_item" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="items" Field="Items_.id" DisplayField="Items_.item_description"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_itemAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="ttc" style=""><asp:TextBox runat="server" id="item_code" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="item_codeTextBoxMaxLengthValidator" ControlToValidate="item_code" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="item_description" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="item_descriptionTextBoxMaxLengthValidator" ControlToValidate="item_description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="uom" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="uomTextBoxMaxLengthValidator" ControlToValidate="uom" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Uom&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="qty" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("qty"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="qtyTextBoxMaxLengthValidator" ControlToValidate="qty" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Quantity&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="rate" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("rate"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="rateTextBoxMaxLengthValidator" ControlToValidate="rate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Rate&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="ass_value" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("ass_value"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ass_valueTextBoxMaxLengthValidator" ControlToValidate="ass_value" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Value&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="amount" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("amount"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="amountTextBoxMaxLengthValidator" ControlToValidate="amount" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Amount&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr></ServelInvocing:So_itemsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:So_itemsTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="So_taxesTabPanel" HeaderText="Taxes">	<ContentTemplate>
  <ServelInvocing:So_taxesTableControl runat="server" id="So_taxesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="So_taxesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><asp:ImageButton runat="server" id="So_taxesAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_taxesEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_taxesDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_taxesResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="So_taxesPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="So_taxesToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxesLabel1" Text="ID Taxes" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_codeLabel1" Text="Tax Code" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_nameLabel" Text="Tax Name" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_printLabel" Text="Tax Print" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_rateLabel" Text="Tax Rate" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_onLabel" Text="Tax On" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_amountLabel" Text="Tax Amount" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_lockLabel" Text="Tax Lock" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="calc_typeLabel" Text="Calc Type" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="sort_orderLabel" Text="Sort Order" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_typeLabel" Text="Tax Type" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="item_totalLabel1" Text="Item Total" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="excise_totalLabel" Text="Excise Total" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="grand_totalLabel1" Text="Grand Total" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="So_taxesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:So_taxesTableControlRow runat="server" id="So_taxesTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_taxesRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_taxesRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_taxesRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticwb"><asp:CheckBox runat="server" id="So_taxesRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxesFvLlsHyperLink" ControlToUpdate="id_taxes" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxesAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="ttc" style=""><asp:TextBox runat="server" id="tax_code" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_codeTextBoxMaxLengthValidator" ControlToValidate="tax_code" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="tax_name" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_nameTextBoxMaxLengthValidator" ControlToValidate="tax_name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="tax_print" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_printTextBoxMaxLengthValidator" ControlToValidate="tax_print" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Print&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="tax_rate" Columns="16" MaxLength="16" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("tax_rate"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_rateTextBoxMaxLengthValidator" ControlToValidate="tax_rate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Rate&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="tax_on" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("tax_on"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_onTextBoxMaxLengthValidator" ControlToValidate="tax_on" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax On&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="tax_amount" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("tax_amount"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_amountTextBoxMaxLengthValidator" ControlToValidate="tax_amount" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Amount&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc"><asp:CheckBox runat="server" id="tax_lock"></asp:CheckBox> </td><td class="ttc" style=""><asp:TextBox runat="server" id="calc_type" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="calc_typeTextBoxMaxLengthValidator" ControlToValidate="calc_type" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Calc Type&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="sort_order" Columns="14" MaxLength="14" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("sort_order"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="sort_orderTextBoxMaxLengthValidator" ControlToValidate="sort_order" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sort Order&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><asp:TextBox runat="server" id="tax_type" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_typeTextBoxMaxLengthValidator" ControlToValidate="tax_type" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Type&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="item_total1" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("item_total1"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="item_total1TextBoxMaxLengthValidator" ControlToValidate="item_total1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="excise_total" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("excise_total"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="excise_totalTextBoxMaxLengthValidator" ControlToValidate="excise_total" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Excise Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="grand_total1" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("grand_total1"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="grand_total1TextBoxMaxLengthValidator" ControlToValidate="grand_total1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Grand Total&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr></ServelInvocing:So_taxesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:So_taxesTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="So_termsTabPanel" HeaderText="Terms">	<ContentTemplate>
  <ServelInvocing:So_termsTableControl runat="server" id="So_termsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="So_termsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><asp:ImageButton runat="server" id="So_termsAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_termsEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_termsDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="So_termsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="So_termsPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="So_termsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="narrationLabel1" Text="Narration" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="sort_orderLabel2" Text="Sort Order" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="So_termsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:So_termsTableControlRow runat="server" id="So_termsTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_termsRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_termsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="So_termsRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticwb"><asp:CheckBox runat="server" id="So_termsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style=""><asp:TextBox runat="server" id="narration" MaxLength="50" columns="60" cssclass="field_input" rows="5" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="narrationTextBoxMaxLengthValidator" ControlToValidate="narration" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Narration&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="sort_order1" Columns="14" MaxLength="14" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, Container.FindControl("sort_order1"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="sort_order1TextBoxMaxLengthValidator" ControlToValidate="sort_order1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Sort Order&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr></ServelInvocing:So_termsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:So_termsTableControl>

 </ContentTemplate></asp:TabPanel>
</asp:TabContainer></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                