<%@ Register Tagprefix="ServelInvocing" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.EditHsnTable" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="ServelInvocing" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditHsnTable.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.EditHsnTable" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0"><tr><td>
                        <ServelInvocing:HsnTableControl runat="server" id="HsnTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="HsnTableControlPanelExtender" runat="server" TargetControlid="HsnTableControlCollapsibleRegion" ExpandControlID="HsnTableControlIcon" CollapseControlID="HsnTableControlIcon" ImageControlID="HsnTableControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="HsnTableControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="HsnTitle" Text="&lt;%#String.Concat(&quot;HSN&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="HsnTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fila"><%# GetResourceValue("Txt:SearchFor", "ServelInvocing") %></td><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("HsnSearchButton"))%>
<asp:TextBox runat="server" id="HsnSearch" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="HsnSearchAutoCompleteExtender" runat="server" TargetControlID="HsnSearch" ServiceMethod="GetAutoCompletionList_HsnSearch" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("HsnSearchButton"))%>
</td><td class="filbc"><ServelInvocing:ThemeButton runat="server" id="HsnSearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr><tr><td class="fila"><asp:Literal runat="server" id="gst_uomLabel" Text="Gst uom">	</asp:Literal></td><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("HsnFilterButton"))%>
<asp:DropDownList runat="server" id="gst_uomFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("HsnFilterButton"))%>
</td><td class="filbc" rowspan="2"></td></tr><tr><td class="fila"><asp:Literal runat="server" id="gst_descriptionLabel" Text="Description">	</asp:Literal></td><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("HsnFilterButton"))%>
<asp:DropDownList runat="server" id="gst_descriptionFilter" autopostback="True" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("HsnFilterButton"))%>
</td></tr></table>
</td></tr><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><asp:ImageButton runat="server" id="HsnAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="HsnEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="HsnDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="HsnSaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/ButtonBarSave.gif" onmouseout="this.src='../Images/ButtonBarSave.gif'" onmouseover="this.src='../Images/ButtonBarSaveOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="HsnRefreshButton" causesvalidation="False" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="HsnResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="HsnPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="HsnToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="hsnLabel" Text="HSN" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="gst_descriptionLabel1" Text="Description" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="gst_uomLabel1" Text="Gst uom" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="HsnTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:HsnTableControlRow runat="server" id="HsnTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HsnRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HsnRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="HsnRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticwb"><asp:CheckBox runat="server" id="HsnRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc" style=""><asp:TextBox runat="server" id="hsn" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<asp:RequiredFieldValidator runat="server" id="hsnRequiredFieldValidator" ControlToValidate="hsn" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;HSN&quot;) %>" enabled="True" text="*"></asp:RequiredFieldValidator>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="hsnTextBoxMaxLengthValidator" ControlToValidate="hsn" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;HSN&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="gst_description" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="gst_descriptionTextBoxMaxLengthValidator" ControlToValidate="gst_description" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Description&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="ttc" style=""><asp:TextBox runat="server" id="gst_uom" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="gst_uomTextBoxMaxLengthValidator" ControlToValidate="gst_uom" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Gst uom&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></ServelInvocing:HsnTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:HsnTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                