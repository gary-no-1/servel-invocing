<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="AddTax_groups.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/VerticalMenu.master" Inherits="ServelInvocing.UI.AddTax_groups" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Register Tagprefix="ServelInvocing" Namespace="ServelInvocing.UI.Controls.AddTax_groups" Assembly="ServelInvocing" %>

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

                        <ServelInvocing:Tax_groupsRecordControl runat="server" id="Tax_groupsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dheci" valign="middle"><asp:CollapsiblePanelExtender id="Tax_groupsRecordControlPanelExtender" runat="server" TargetControlid="Tax_groupsRecordControlCollapsibleRegion" ExpandControlID="Tax_groupsRecordControlIcon" CollapseControlID="Tax_groupsRecordControlIcon" ImageControlID="Tax_groupsRecordControlIcon" ExpandedImage="../images/icon_panelcollapse.gif" CollapsedImage="../images/icon_panelexpand.gif" SuppressPostBack="true" />
<asp:ImageButton id="Tax_groupsRecordControlIcon" runat="server" ToolTip="&lt;%# GetResourceValue(&quot;Btn:ExpandCollapse&quot;) %&gt;" causesvalidation="False" imageurl="../images/icon_panelcollapse.gif" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="Tax_groupsTitle" Text="&lt;%#String.Concat(GetResourceValue(&quot;Title:Add&quot;),&quot; Tax Groups&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td></tr><tr><td><asp:panel id="Tax_groupsRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="Tax_groupsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="tax_group_codeLabel" Text="Tax Group Code">	</asp:Literal></td><td class="dfv"><asp:TextBox runat="server" id="tax_group_code" Columns="50" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="tax_group_codeTextBoxMaxLengthValidator" ControlToValidate="tax_group_code" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Tax Group Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_1Label" Text="Tax Code 1">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_FvLlsHyperLink" ControlToUpdate="id_taxes_" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_1AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_2Label" Text="Tax Code 2">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_2" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_2FvLlsHyperLink" ControlToUpdate="id_taxes_2" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_2AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_3Label" Text="Tax Code 3">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_1" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_1FvLlsHyperLink" ControlToUpdate="id_taxes_1" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_3AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_4Label" Text="Tax Code 4">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_4" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_4FvLlsHyperLink" ControlToUpdate="id_taxes_4" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_4AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_5Label" Text="Tax Code 5">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_3" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_3FvLlsHyperLink" ControlToUpdate="id_taxes_3" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_5AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_6Label" Text="Tax Code 6">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_6" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_6FvLlsHyperLink" ControlToUpdate="id_taxes_6" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_6AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_7Label" Text="Tax Code 7">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_5" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_5FvLlsHyperLink" ControlToUpdate="id_taxes_5" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_7AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_8Label" Text="Tax Code 8">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_8" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_8FvLlsHyperLink" ControlToUpdate="id_taxes_8" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_8AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="fls"></td><td class="dfv" style="white-space:nowrap;"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="id_taxes_9Label" Text="Tax Code 9">	</asp:Literal></td><td class="dfv" style="white-space:nowrap;"><asp:DropDownList runat="server" id="id_taxes_7" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList>
<Selectors:FvLlsHyperLink runat="server" id="id_taxes_7FvLlsHyperLink" ControlToUpdate="id_taxes_7" Text="&lt;%# GetResourceValue(&quot;LLS:Text&quot;, &quot;ServelInvocing&quot;) %>" MinListItems="100" Table="taxes" Field="Taxes_.id" DisplayField="Taxes_.tax_name"></Selectors:FvLlsHyperLink> 
<asp:ImageButton runat="server" id="id_taxes_9AddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;ServelInvocing&quot;) %>">		
	</asp:ImageButton> </td><td class="dfv"></td><td class="dfv"></td></tr><tr><td class="fls"><asp:Literal runat="server" id="notesLabel" Text="Notes">	</asp:Literal></td><td class="dfv" colspan="3"><asp:TextBox runat="server" id="notes" MaxLength="50" columns="60" cssclass="field_input" rows="2" textmode="MultiLine"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="notesTextBoxMaxLengthValidator" ControlToValidate="notes" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;ServelInvocing&quot;).Replace(&quot;{FieldName}&quot;, &quot;Notes&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel></td></tr></table>
</ServelInvocing:Tax_groupsRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><ServelInvocing:ThemeButton runat="server" id="SaveButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="SaveAndNewButton" button-causesvalidation="True" button-commandname="UpdateData" button-text="&lt;%# GetResourceValue(&quot;Btn:SaveNNew&quot;, &quot;ServelInvocing&quot;) %>" postback="True"></ServelInvocing:ThemeButton></td><td><ServelInvocing:ThemeButton runat="server" id="CancelButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Cancel&quot;, &quot;ServelInvocing&quot;) %>" postback="False"></ServelInvocing:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                