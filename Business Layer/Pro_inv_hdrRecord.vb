' This is a "safe" class, meaning that it is created once 
' and never overwritten. Any custom code you add to this class 
' will be preserved when you regenerate your application.
'
' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods

Imports System.Data.SqlTypes
Imports BaseClasses
Imports BaseClasses.Data
Imports BaseClasses.Data.SqlProvider

Namespace ServelInvocing.Business

''' <summary>
''' Provides access to the data in a database record.
''' Also provides access to the <see cref="Pro_inv_hdrTable"></see> that each record is associated with.
''' </summary>
''' <remarks>
''' </remarks>
''' <seealso cref="Pro_inv_hdrTable"></seealso>

<Serializable()> Public Class Pro_inv_hdrRecord
	Inherits BasePro_inv_hdrRecord

	' Constructors
	
	Public Sub New()
		MyBase.New()
	End Sub
	


	#Region "Code Customization"
	
	''' <summary>
	''' This custom method is an event handler for the insert event in the Data Access Layer.
	''' </summary>
	Private Sub Audit_Insert(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
	    Handles MyBase.InsertingRecord    
		''' You can modify the following sample code to fit specific need
		   
	    'Dim s As String 
	    's = Trim(Me.created_on & vbCrLf & "Inserted by: " & BaseClasses.Utils.SecurityControls.GetCurrentUserName() & " on " & DateTime.Now.ToString() & ".")
	        
	    'Me.created_on = s
	    
	    'Set values of other fields.
	    'me.UserName= "loggedInUser"
		Dim AuditUserId as string = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
		If String.IsNullOrEmpty(AuditUserId) Then
			AuditUserId = "1"
		End if
		
		'me.id_create_user = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
		me.id_create_user = AuditUserId
		me.created_on = datetime.now()
	End Sub
	    
	#End Region
	
	#Region "Code Customization"
	
	''' <summary>
	''' This custom method is an event handler for the update event in the Data Access layer.
	''' </summary>
	Private Sub Audit_Update(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) _
	    Handles MyBase.UpdatingRecord   
		''' You can modify the following sample code to fit specific need
		   
	    'Dim s As String 
	    's = Trim(Me.id_update_user & vbCrLf & "Inserted by: " & BaseClasses.Utils.SecurityControls.GetCurrentUserName() & " on " & DateTime.Now.ToString() & ".")
	    'Me.id_update_user = s
	    
	    'Update other fields
	    'Me.user= "loggedInUser"    
		Dim AuditUserId as string = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
		If String.IsNullOrEmpty(AuditUserId) Then
			AuditUserId = "1"
		End if
		
		'me.id_create_user = BaseClasses.Utils.SecurityControls.GetCurrentUserID()
		me.id_update_user = AuditUserId
		me.last_updated = datetime.now()
	End Sub
	    
	#End Region
	End Class
End Namespace
