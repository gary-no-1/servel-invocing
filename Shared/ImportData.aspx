<%@ Register Tagprefix="ServelInvocing" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="VB" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ImportData.aspx.vb" Inherits="ServelInvocing.UI.ImportData" %>
<%@ Register Tagprefix="Selectors" Namespace="ServelInvocing" %>

<%@ Register TagPrefix="FCKeditorV2" Namespace="FredCK.FCKeditorV2" Assembly="FredCK.FCKeditorV2" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">
    <title>ImportData</title>
     <base target="_self" />
    </head>
    <body id="Body1" runat="server" class="pBack">
    <form id="Form1" method="post" runat="server"><BaseClasses:ScrollCoordinates id="ScrollCoordinates" runat="server"></BaseClasses:ScrollCoordinates>
        <BaseClasses:BasePageSettings id="PageSettings" runat="server"></BaseClasses:BasePageSettings>
        <script language="JavaScript" type="text/javascript">clearRTL()</script>
        <script language='javascript' type='text/javascript'>function CloseWindow(msg,msg2){ alert(msg.concat("\r\n",msg2));window.opener.__doPostBack('ChildWindowPostBack', ''); window.opener.focus();window.close();}</script>
		<asp:ScriptManager ID="scriptManager1" runat="server" EnablePartialRendering="True" EnablePageMethods="True" />
		
        <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
		  <table  cellpadding="0" cellspacing="0" border="0"><tr>
			<td class="pcTL"></td>
			<td class="pcT"></td>
			<td class="pcTR"></td>
		  </tr>
		  <tr>
			<td class="pcL"></td>
			<td class="pcC">
				<table class="dv" cellpadding="0" cellspacing="0" border="0">
					<tr>
						<td class="dBody" style="width:100%; height:100%">			
							<table>
							<tr>
							<td><asp:Literal id="ImportSelectColumns" runat="server" Text='<%# GetResourceValue("Txt:ImportSelectColumns") %>'/>
							<%-- Select and assign the data columns you wish to import.--%>
							</td>
							</tr>
							    <tr>
									<td><asp:checkbox id="ImportFirstRowCheckBox" runat="server" Text=""/>&nbsp;&nbsp;
									
									
								</td></tr>
								<tr><td>
										<asp:Table id="DisplayTable" runat="server" CellSpacing="0" CellPadding="3"	GridLines="Both" BorderStyle="Solid" BorderWidth="1" CssClass="ttc">
										</asp:Table>
									</td>
								</tr>
								
								
							</table>
							<table>
								<tr>
									<td><ServelInvocing:ThemeButton runat="server" id="PreviousButton" Button-Text="&lt;%# GetResourceValue(&quot;Import:Previous&quot;) %>" Button-ToolTip="&lt;%# GetResourceValue(&quot;Import:Previous&quot;, &quot;ServelInvocing&quot;) %>">
		</ServelInvocing:ThemeButton></td>
									<td><ServelInvocing:ThemeButton runat="server" id="ImportButton" Button-Text="&lt;%# GetResourceValue(&quot;Import:Import&quot;) %>" Button-ToolTip="&lt;%# GetResourceValue(&quot;Import:Import&quot;, &quot;ServelInvocing&quot;) %>">
		</ServelInvocing:ThemeButton></td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		  	<td class="pcR"></td>
		  </tr>
		  <tr>
		  	<td class="pcBL"></td>
		  	<td class="pcB"></td>
		  	<td class="pcBR"></td>
		  </tr>
		  </table>
        <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary></form>
    </body>
</html>
