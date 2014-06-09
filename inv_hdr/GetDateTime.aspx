<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" Assembly="ServelInvocing" %>

<%@ Page Language="vb" EnableEventValidation="false" AutoEventWireup="false" Codebehind="GetDateTime.aspx.vb" Culture="en-IN" MasterPageFile="../Master Pages/Blank.master" Inherits="ServelInvocing.UI.GetDateTime" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
	<!--Requirement jQuery-->
	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js"></script>
	<!--Load Script and Stylesheet -->
	<script type="text/javascript" src="../javascripts/jquery.simple-dtpicker.js"></script>
	<link type="text/css" href="../javascripts/jquery.simple-dtpicker.css" rel="stylesheet" />
	<!---->
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
<table cellpadding="0" cellspacing="0" border="0"><tr><td style="font-size:8pt;font-family:Tahoma;width:100px"><asp:Label runat="server" id="lblDisplay" Text="Date &amp; Time">	</asp:Label></td><td style="font-size:8pt;font-family:Tahoma"><input type="text" name="txtIssue_date" value="">
			<script type="text/javascript">
				$(function(){
					$('*[name=txtIssue_date]').appendDtpicker({
						"closeOnSelected": true,
						"dateFormat": "DD-MM-YYYY hh:mm"
					});
				});
			</script></td></tr></table></ContentTemplate>
</asp:UpdatePanel>

    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>