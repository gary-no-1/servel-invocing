<%@ Page Language="vb" AutoEventWireup="false" Inherits="ServelInvocing.UI.BaseApplicationPage" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml"><head runat="server">
<script runat="server" language="VB">
Public Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
    Dim selectedTheme As String = Me.GetSelectedTheme()
    If Not String.IsNullOrEmpty(selectedTheme) Then Me.Page.Theme = selectedTheme
End Sub
</script>
<title>Configuring Your Application Start Page</title>
</head><body>
<table cellspacing="0" cellpadding="0" border="0" class="pageBackground">
  <tr>
  <td class="pageAlignment">
    <table cellspacing="0" cellpadding="0" border="0" class="borderTable">
      <tr>
        <td class="pageBorderTL"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
        <td class="pageBorderT"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
        <td class="pageBorderTR"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
      </tr>
      <tr>
        <td class="pageBorderL"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
        <td class="pageBorderC">
	<table cellspacing="0" cellpadding="0" border="0">
	 <tr>
	  <td class="page_yellow">
		<table border="0" cellpadding="0" cellspacing="0" style="border-collapse: collapse" width="600" id="AutoNumber1">
		  <tr>
		  	<td class="dialog_header" colspan="3">
				<table cellpadding="0" cellspacing="0" border="0" width="100%">
				  <tr>
				    <td class="dialogHeaderEdgeL"><img src="../Images/space.gif" alt="" /></td>
				    <td class="dhb">
				        <table border="0" cellpadding="0" cellspacing="0">
				            <tr>
            					<td class="dialog_header_text">Configuring Your Application Start Page</td>
				            </tr>
				        </table>
				    </td>				    
				    <td class="dialogHeaderEdgeR"><img src="../Images/space.gif" alt="" /></td>
				  </tr>
				</table>
		  	</td>
		  </tr>
		  <tr>
		  	<td style="width: 20px;"></td>
			<td class="configureErrorPagesText"><br />
				Your application does not currently have a default start page.&nbsp; You need to configure a start page to be displayed whenever you access:<br /><br /> 
			      <blockquote>http://&lt;machine name&gt;/&lt;application name&gt;<br /><br /></blockquote>
			    To configure your application's start page, select Configure Start Page from the Tools menu.<br /><br />
		    </td>
		  	<td style="width: 20px;"></td>
		  </tr>
		</table>
	  </td>
	 </tr>
	</table>
      </td>
      <td class="pageBorderR"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
    </tr>
    <tr>
      <td class="pageBorderBL"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
      <td class="pageBorderB"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
      <td class="pageBorderBR"><img src="../Images/space.gif" height="1" width="1" alt="" /></td>
    </tr>
  </table>
  </td>
  </tr>
</table>
</body></html>