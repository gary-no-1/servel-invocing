<%@ Register Tagprefix="ServelInvocing" TagName="Pagination" Src="../Shared/Pagination.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowTax_groupsTable.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.ShowTax_groupsTable" %>
<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.ShowTax_groupsTable" Assembly="ServelInvocing" %>

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

                <table cellpadding="0" cellspacing="0" border="0"><tr><td>
                        <ServelInvocing:Tax_groupsTableControl runat="server" id="Tax_groupsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Tax_groupsTableControlPanelExtender" runat="server" TargetControlid="Tax_groupsTableControlCollapsibleRegion" ExpandControlID="Tax_groupsTableControlIcon" CollapseControlID="Tax_groupsTableControlIcon" ImageControlID="Tax_groupsTableControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Tax_groupsTableControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Tax_groupsTitle" Text="&lt;%#String.Concat(&quot;Tax Groups&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Tax_groupsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fila"><%# GetResourceValue("Txt:SearchFor", "ServelInvocing") %></td><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("Tax_groupsSearchButton"))%>
<asp:TextBox runat="server" id="Tax_groupsSearch" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="Tax_groupsSearchAutoCompleteExtender" runat="server" TargetControlID="Tax_groupsSearch" ServiceMethod="GetAutoCompletionList_Tax_groupsSearch" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("Tax_groupsSearchButton"))%>
</td><td class="filbc"><ServelInvocing:ThemeButton runat="server" id="Tax_groupsSearchButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr><tr><td class="pr"><table cellpadding="0" cellspacing="0" border="0"><tr><td><img src="../Images/paginationRowEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeL.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarDividerL.gif" alt="" /></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsNewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src='../Images/ButtonBarNew.gif'" onmouseover="this.src='../Images/ButtonBarNewOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarEdit.gif" onmouseout="this.src='../Images/ButtonBarEdit.gif'" onmouseover="this.src='../Images/ButtonBarEditOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsCopyButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarCopy.gif" onmouseout="this.src='../Images/ButtonBarCopy.gif'" onmouseover="this.src='../Images/ButtonBarCopyOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Copy&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsDeleteButton" causesvalidation="False" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src='../Images/ButtonBarDelete.gif'" onmouseover="this.src='../Images/ButtonBarDeleteOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsPDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src='../Images/ButtonBarPDFExport.gif'" onmouseover="this.src='../Images/ButtonBarPDFExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsWordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src='../Images/ButtonBarWordExport.gif'" onmouseover="this.src='../Images/ButtonBarWordExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsExportExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src='../Images/ButtonBarExcelExport.gif'" onmouseover="this.src='../Images/ButtonBarExcelExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsExportCSVButton" causesvalidation="False" commandname="ExportData" imageurl="../Images/ButtonBarCSVExport.gif" onmouseout="this.src='../Images/ButtonBarCSVExport.gif'" onmouseover="this.src='../Images/ButtonBarCSVExportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Export&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src='../Images/ButtonBarImport.gif'" onmouseover="this.src='../Images/ButtonBarImportOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsRefreshButton" causesvalidation="False" commandname="ResetData" imageurl="../Images/ButtonBarRefresh.gif" onmouseout="this.src='../Images/ButtonBarRefresh.gif'" onmouseover="this.src='../Images/ButtonBarRefreshOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Refresh&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><asp:ImageButton runat="server" id="Tax_groupsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarReset.gif" onmouseout="this.src='../Images/ButtonBarReset.gif'" onmouseover="this.src='../Images/ButtonBarResetOver.gif'" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="prbbc"><img src="../Images/ButtonBarDividerR.gif" alt="" /></td><td class="prbbc"><img src="../Images/ButtonBarEdgeR.gif" alt="" /></td><td class="pra"><ServelInvocing:Pagination runat="server" id="Tax_groupsPagination"></ServelInvocing:Pagination></td><td><img src="../Images/paginationRowEdgeR.gif" alt="" /></td><td width="100%">&nbsp;</td></tr></table>
</td></tr><tr><td class="tre"><table cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="4"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thcwb" style="padding:0px;vertical-align:middle;"><asp:CheckBox runat="server" id="Tax_groupsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thc" scope="col"><asp:LinkButton runat="server" id="tax_group_codeLabel" Text="Tax Group Code" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="notesLabel" Text="Notes" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_1Label1" Text="Tax Code 1" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_2Label1" Text="Tax Code 2" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_3Label" Text="Tax Code 3" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_4Label" Text="Tax Code 4" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_5Label" Text="Tax Code 5" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_6Label" Text="Tax Code 6" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_7Label" Text="Tax Code 7" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_8Label" Text="Tax Code 8" CausesValidation="False">	</asp:LinkButton>
                        </th><th class="thc" scope="col"><asp:LinkButton runat="server" id="id_taxes_9Label" Text="Tax Code 9" CausesValidation="False">	</asp:LinkButton>
                        </th></tr><asp:Repeater runat="server" id="Tax_groupsTableControlRepeater">		<ITEMTEMPLATE>		<ServelInvocing:Tax_groupsTableControlRow runat="server" id="Tax_groupsTableControlRow">
<tr><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="Tax_groupsRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="Tax_groupsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="Tax_groupsRowCopyButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_copy.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:CopyRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticnb" scope="row"><asp:ImageButton runat="server" id="Tax_groupsRowDeleteButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton></td><td class="ticwb"><asp:CheckBox runat="server" id="Tax_groupsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox></td><td class="ttc"><asp:Literal runat="server" id="tax_group_code"></asp:Literal> </td><td class="ttc"><asp:Literal runat="server" id="notes"></asp:Literal> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_1" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_2" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_3" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_4" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_5" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_6" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_7" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_8" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="ttc"><asp:LinkButton runat="server" id="id_taxes_9" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td></tr></ServelInvocing:Tax_groupsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Tax_groupsTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                