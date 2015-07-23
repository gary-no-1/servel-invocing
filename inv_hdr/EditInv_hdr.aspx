<%@ Register Tagprefix="ServelInvocing" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditInv_hdr.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.EditInv_hdr" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EditInv_hdr" Assembly="ServelInvocing" %>

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

                        <ServelInvocing:Inv_hdrRecordControl runat="server" id="Inv_hdrRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Inv_hdrRecordControlPanelExtender" runat="server" TargetControlid="Inv_hdrRecordControlCollapsibleRegion" ExpandControlID="Inv_hdrRecordControlIcon" CollapseControlID="Inv_hdrRecordControlIcon" ImageControlID="Inv_hdrRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Inv_hdrRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Inv_hdrTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot; Invoice&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Inv_hdrRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Inv_hdrRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="inv_noLabel" Text="Invoice No:">	</asp:Literal></td><td class="dfv" style="font-weight:bold;font-size:10pt"><asp:Literal runat="server" id="inv_no"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="inv_dtLabel" Text="Invoice Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="inv_dt"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="po_noLabel" Text="P.O. No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="po_no" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="po_noTextBoxMaxLengthValidator" ControlToValidate="po_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;P.O. No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="po_dtLabel" Text="P.O. Date">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="po_dt" Columns="20" MaxLength="20" cssclass="field_input" htmlencodevalue="Default"></asp:TextBox></td>
</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="po_dtCalendarExtender" TargetControlID="po_dt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="po_dtTextBoxMaxLengthValidator" ControlToValidate="po_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;P.O. Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="sale_ord_noLabel" Text="O.A. No:">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="sale_ord_no"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="sale_ord_dtLabel" Text="O.A. Date">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="sale_ord_dt"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_partyLabel" Text="Party">	</asp:Literal></td><td class="dfv"><asp:DropDownList runat="server" id="id_party" autopostback="True" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)" width="250px"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_partyFvLlsHyperLink" ControlToUpdate="id_party" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="party" Field="Party_.id" DisplayField="Party_.name"></Selectors:FvLlsHyperLink></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="bill_nameLabel" Text="Bill Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="bill_name" Columns="50" MaxLength="50" cssclass="field_input" htmlencodevalue="Default"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="bill_nameTextBoxMaxLengthValidator" ControlToValidate="bill_name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Bill Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="ship_nameLabel" Text="Ship Name">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="ship_name" Columns="50" MaxLength="50" cssclass="field_input" htmlencodevalue="Default"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ship_nameTextBoxMaxLengthValidator" ControlToValidate="ship_name" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ship Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="bill_addressLabel" Text="Bill Address">	</asp:Literal></td><td class="dfv" style="width:225px"><asp:TextBox runat="server" id="bill_address" Columns="50" MaxLength="50" cssclass="field_input" htmlencodevalue="Default" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="bill_addressTextBoxMaxLengthValidator" ControlToValidate="bill_address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Bill Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="ship_addressLabel" Text="Ship Address">	</asp:Literal></td><td class="dfv" style="width:225px"><asp:TextBox runat="server" id="ship_address" Columns="50" MaxLength="50" cssclass="field_input" htmlencodevalue="Default" rows="3" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ship_addressTextBoxMaxLengthValidator" ControlToValidate="ship_address" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Ship Address&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="tin_noLabel" Text="TIN">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="tin_no" Columns="20" MaxLength="20" cssclass="field_input" htmlencodevalue="Default"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tin_noTextBoxMaxLengthValidator" ControlToValidate="tin_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;TIN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="ecc_noLabel" Text="ECC No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="ecc_no" Columns="20" MaxLength="20" cssclass="field_input" htmlencodevalue="Default"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ecc_noTextBoxMaxLengthValidator" ControlToValidate="ecc_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;ECC No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="remarkLabel" Text="Remark">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="remark" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="remarkTextBoxMaxLengthValidator" ControlToValidate="remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="excise_remarkLabel" Text="Excise Remark">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="excise_remark" Columns="25" MaxLength="25" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="excise_remarkTextBoxMaxLengthValidator" ControlToValidate="excise_remark" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Excise Remark&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls" colspan="4"><hr></hr></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_commodityLabel" Text="Commodity">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:LinkButton runat="server" id="id_commodity" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="fls"><asp:Literal runat="server" id="item_totalLabel" Text="Item Total">	</asp:Literal></td><td class="dfv" style="font-weight:bold;text-align:justify;"><asp:Literal runat="server" id="item_total"></asp:Literal></td></tr><tr><td class="fls"></td><td class="dfv" style="font-weight:bold;text-align:right;"></td><td class="fls"><asp:Literal runat="server" id="grand_totalLabel" Text="Grand Total">	</asp:Literal></td><td class="dfv" style="font-weight:bold;text-align:justify;"><asp:Literal runat="server" id="grand_total"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="inv_issued_dtLabel" Text="Invoice Issued Date &amp; Time">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="inv_issued_dt" Columns="20" MaxLength="20" cssclass="field_input" htmlencodevalue="Default" readonly="True"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">

</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="inv_issued_dtTextBoxMaxLengthValidator" ControlToValidate="inv_issued_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Invoice Issued Date &amp; Time&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</td><td class="fls"><asp:Literal runat="server" id="goods_removed_dtLabel" Text="Goods Removed Date &amp; Time">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="goods_removed_dt" Columns="20" MaxLength="20" cssclass="field_input" readonly="False"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">

</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="goods_removed_dtCalendarExtender" TargetControlID="goods_removed_dt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="goods_removed_dtTextBoxMaxLengthValidator" ControlToValidate="goods_removed_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Goods Removed Date &amp; Time&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
</td></tr><tr><td class="fls" colspan="4"><hr></hr></td></tr><tr><td class="fls"><asp:Literal runat="server" id="packing_detailsLabel" Text="Packing Details">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="packing_details" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="packing_detailsTextBoxMaxLengthValidator" ControlToValidate="packing_details" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Packing Details&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="weightLabel" Text="Weight">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="weight" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="weightTextBoxMaxLengthValidator" ControlToValidate="weight" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Weight&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="no_of_packagesLabel" Text="No Of Packages">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="no_of_packages" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="no_of_packagesTextBoxMaxLengthValidator" ControlToValidate="no_of_packages" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;No Of Packages&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_transporterLabel" Text="Transporter">	</asp:Literal></td><td class="dfv"><asp:DropDownList runat="server" id="id_transporter" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_transporterFvLlsHyperLink" ControlToUpdate="id_transporter" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="transporters" Field="Transporters_.id" DisplayField="Transporters_.name"></Selectors:FvLlsHyperLink></td><td class="fls"><asp:Literal runat="server" id="freight_to_payLabel" Text="Freight To Pay">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="freight_to_pay" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="freight_to_payTextBoxMaxLengthValidator" ControlToValidate="freight_to_pay" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Freight To Pay&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="road_permit_noLabel" Text="Road Permit No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="road_permit_no" Columns="40" MaxLength="40" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="road_permit_noTextBoxMaxLengthValidator" ControlToValidate="road_permit_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Road Permit No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td><td class="fls"><asp:Literal runat="server" id="vehicle_noLabel" Text="Vehicle Number">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="vehicle_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="vehicle_noTextBoxMaxLengthValidator" ControlToValidate="vehicle_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Vehicle Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td></tr><tr><td class="fls"><asp:Literal runat="server" id="gr_rr_noLabel" Text="GR / RR No:">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="gr_rr_no" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="gr_rr_noTextBoxMaxLengthValidator" ControlToValidate="gr_rr_no" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;GR / RR No:&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="gr_rr_dtLabel" Text="GR / RR Date">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="gr_rr_dt" Columns="20" MaxLength="20" cssclass="field_input"></asp:TextBox></td>
</td>
<td>
<Selectors:CalendarExtendarClass runat="server" ID="gr_rr_dtCalendarExtender" TargetControlID="gr_rr_dt" CssClass="MyCalendar" Format="d">
</Selectors:CalendarExtendarClass>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="gr_rr_dtTextBoxMaxLengthValidator" ControlToValidate="gr_rr_dt" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;GR / RR Date&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_hdrRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td><asp:TabContainer runat="server" id="Inv_hdrTabContainer">
 <asp:TabPanel runat="server" id="Inv_itemsTabPanel" HeaderText="Items">	<ContentTemplate>
  <ServelInvocing:Inv_itemsTableControl runat="server" id="Inv_itemsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="Inv_itemsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"><asp:ImageButton runat="server" id="Inv_itemsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="Inv_itemsPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="Inv_itemsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_itemLabel1" Text="Item Code" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="item_descriptionLabel" Text="Item Description" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="uomLabel" Text="Uom" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="qtyLabel" Text="Quantity" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="rateLabel" Text="Rate" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="amountLabel" Text="Amount" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="Inv_itemsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_itemsTableControlRow runat="server" id="Inv_itemsTableControlRow">
<tr><td class="ticwb"><asp:CheckBox runat="server" id="Inv_itemsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style="white-space:nowrap;"><asp:Literal runat="server" id="id_item"></asp:Literal> 
</td><td class="ttc" style=""><asp:Literal runat="server" id="item_description"></asp:Literal> </td><td class="ttc" style=""><asp:Literal runat="server" id="uom"></asp:Literal> </td><td class="ttc" style=""><asp:Literal runat="server" id="qty"></asp:Literal> </td><td class="ttc" style=""><asp:Literal runat="server" id="rate"></asp:Literal> </td><td class="ttc" style=""><asp:Literal runat="server" id="amount"></asp:Literal> </td></tr></ServelInvocing:Inv_itemsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_itemsTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="Inv_taxesTabPanel" HeaderText="Taxes">	<ContentTemplate>
  <ServelInvocing:Inv_taxesTableControl runat="server" id="Inv_taxesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="Inv_taxesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"><asp:ImageButton runat="server" id="Inv_taxesResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="Inv_taxesPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="Inv_taxesToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_printLabel" Text="Name" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_amountLabel" Text="Tax Amount" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="Inv_taxesTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_taxesTableControlRow runat="server" id="Inv_taxesTableControlRow">
<tr><td class="ticwb"><asp:CheckBox runat="server" id="Inv_taxesRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style=""><asp:Literal runat="server" id="tax_print"></asp:Literal> </td><td class="ttc" style="text-align:right;"><asp:Literal runat="server" id="tax_amount"></asp:Literal> </td></tr></ServelInvocing:Inv_taxesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_taxesTableControl>

 </ContentTemplate></asp:TabPanel>
 <asp:TabPanel runat="server" id="Inv_termsTabPanel" HeaderText="Terms">	<ContentTemplate>
  <ServelInvocing:Inv_termsTableControl runat="server" id="Inv_termsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td><asp:panel id="Inv_termsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"></td><td class="prbbc"><asp:ImageButton runat="server" id="Inv_termsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="Inv_termsPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="Inv_termsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="narrationLabel1" Text="Narration" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="Inv_termsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Inv_termsTableControlRow runat="server" id="Inv_termsTableControlRow">
<tr><td class="ticwb"><asp:CheckBox runat="server" id="Inv_termsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style=""><asp:Literal runat="server" id="narration"></asp:Literal> </td></tr></ServelInvocing:Inv_termsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Inv_termsTableControl>

 </ContentTemplate></asp:TabPanel>
</asp:TabContainer></td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>