<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EditPro_inv_items" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditPro_inv_items.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.EditPro_inv_items" %>
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

                        <ServelInvocing:Pro_inv_itemsRecordControl runat="server" id="Pro_inv_itemsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Pro_inv_itemsRecordControlPanelExtender" runat="server" TargetControlid="Pro_inv_itemsRecordControlCollapsibleRegion" ExpandControlID="Pro_inv_itemsRecordControlIcon" CollapseControlID="Pro_inv_itemsRecordControlIcon" ImageControlID="Pro_inv_itemsRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Pro_inv_itemsRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Pro_inv_itemsTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Edit&quot;),&quot; Pro Inv Items&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Pro_inv_itemsRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Pro_inv_itemsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="id_pro_inv_hdrLabel" Text="ID Pro Inv HDR">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_pro_inv_hdr" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_pro_inv_hdrFvLlsHyperLink" ControlToUpdate="id_pro_inv_hdr" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="pro_inv_hdr" Field="Pro_inv_hdr_.id" DisplayField="Pro_inv_hdr_.bill_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_pro_inv_hdrAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"><asp:Literal runat="server" id="id_itemLabel" Text="Item Code">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_item" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_itemFvLlsHyperLink" ControlToUpdate="id_item" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="items" Field="Items_.id" DisplayField="Items_.item_code"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_itemAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="item_codeLabel" Text="Item Code">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="item_code" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="item_codeTextBoxMaxLengthValidator" ControlToValidate="item_code" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="item_descriptionLabel" Text="Item Description">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="item_description" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="item_descriptionTextBoxMaxLengthValidator" ControlToValidate="item_description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Item Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="uomLabel" Text="Uom">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="uom" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="uomTextBoxMaxLengthValidator" ControlToValidate="uom" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Uom&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"><asp:Literal runat="server" id="qtyLabel" Text="Quantity">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="qty" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("qty"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="qtyTextBoxMaxLengthValidator" ControlToValidate="qty" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Quantity&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="rateLabel" Text="Rate">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="rate" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("rate"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="rateTextBoxMaxLengthValidator" ControlToValidate="rate" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Rate&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="fls"><asp:Literal runat="server" id="ass_valueLabel" Text="Value">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="ass_value" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("ass_value"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="ass_valueTextBoxMaxLengthValidator" ControlToValidate="ass_value" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Value&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td></tr><tr><td class="fls"><asp:Literal runat="server" id="amountLabel" Text="Amount">	</asp:Literal></td><td class="dfv"><table border="0" cellpadding="0" cellspacing="0">
<tr>
<td style="padding-right: 5px; vertical-align:top">
<asp:TextBox runat="server" id="amount" Columns="20" MaxLength="20" onkeyup="adjustInteger(this, event.keyCode)" cssclass="field_input"></asp:TextBox></td>
<td style="padding-right: 5px; white-space:nowrap;">
<%# SystemUtils.GenerateIncrementDecrementButtons(true, FindControlRecursively("amount"),"NumberTextBox","","","") %>
</td>
<td>
&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="amountTextBoxMaxLengthValidator" ControlToValidate="amount" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Amount&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></td>
</tr>
</table>
 </td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Pro_inv_itemsRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                