Imports BaseClasses.Data
Imports BaseClasses.Utils.StringUtils
Imports BaseClasses.Utils
Imports BaseClasses.Resources
Imports ServelInvocing.Business
Imports ServelInvocing.Data

Namespace ServelInvocing.UI

' Typical customizations that may be done in this class include
'  - adding custom event handlers
'  - overriding base class methods
'
''' <summary>
''' The superclass (i.e. base class) for all Designer-generated pages in this application.
''' </summary>
''' <remarks>
''' <para>
''' </para>
''' </remarks>


    Public Class BaseApplicationPage
        Inherits BaseClasses.Web.UI.BasePage

        Private _Enctype As String = ""
        Public Property Enctype() As String
            Get
                Return Me._Enctype
            End Get
            Set(ByVal value As String)
                Me._Enctype = value
            End Set
        End Property
            


        'Script to set focus to the last focused control
        Private Const SCRIPT_DOFOCUS As String = "" & _
                       "<script language=""javascript"" type=""text/javascript"">" & _
                       "var ctrl = ""{ControlClientID}""; var ctrlPB = ""{CtrlIDToFocusOnPostBack}""; " & _
                       "function pageLoadedHandler1(sender, args) { " & _
                       "if(!isPostBack()) {setTimeout(""setTimeoutFocus()"", 1000);} " & _
                       "else {setTimeout(""setPostBackFocus()"", 100);}}" & _
                       "function setTimeoutFocus() { setFocus(ctrl); }" & _
                       "function setPostBackFocus() { doFocus(ctrlPB);}" & _
                       "function doFocus(ctrlID) { if((ctrlID == null) || (ctrlID = """")) return;" & _
                       "try { var objToFocus = null; try { objToFocus = document.getElementById(ctrlID); } catch(ex) {}" & _
                       "if(!(!objToFocus ||(objToFocus==null)||(objToFocus==""""))){document.getElementById(objToFocus).focus();}} catch(ex){ }}" & _
                       "function isPostBack() {if (!document.getElementById(""{clientSideIsPostBack}"")) return false;" & _
                       "if (document.getElementById(""{clientSideIsPostBack}"").value == ""Y"") return true;" & _
                       "else return false;}" & _
                       "Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded(pageLoadedHandler1);</script>"


        'Add or remove controls if you do not want to retain focus on them
        Public Sub LoadFocusScripts(ByVal CurrentControl As Control)
            If TypeOf (CurrentControl) Is TextBox OrElse TypeOf (CurrentControl) Is DropDownList OrElse TypeOf (CurrentControl) Is ListBox OrElse _
            TypeOf (CurrentControl) Is Button OrElse TypeOf (CurrentControl) Is ImageButton OrElse TypeOf (CurrentControl) Is RadioButtonList OrElse _
            TypeOf (CurrentControl) Is RadioButton OrElse TypeOf (CurrentControl) Is CheckBox OrElse TypeOf (CurrentControl) Is LinkButton Then
                DirectCast(CurrentControl, WebControl).Attributes.Add("onfocus", "try{document.getElementById(""__LASTFOCUS"").value=this.id;}catch(e){}")
            End If
            If CurrentControl.HasControls() Then
                For Each CurrentChildControl As Control In CurrentControl.Controls
                    Me.LoadFocusScripts(CurrentChildControl)
                Next
            End If
        End Sub

        Public Overridable Sub SetFocusOnLoad()
            Me.SetFocusOnLoad(Nothing)
        End Sub

        '''Sets focus to the control with ctrlClientID. If empty string is passed, sets focus to the first focusable control
        Public Overridable Sub SetFocusOnLoad(ByVal currentControl As Control)
            Dim ctrlClientID As String = ""
            If currentControl IsNot Nothing Then
                ctrlClientID = currentControl.ClientID
                currentControl.Focus()
            End If
            If Not ClientScript.IsStartupScriptRegistered(Page.GetType(), "SetFocusOnLoad") Then
                Dim _clientSideIsPostBack As System.Web.UI.HtmlControls.HtmlInputHidden = DirectCast(Me.FindControlRecursively("_clientSideIsPostBack"), System.Web.UI.HtmlControls.HtmlInputHidden)
                Dim _clientSideIsPostBackID As String = "_clientSideIsPostBack"
                If Not _clientSideIsPostBack Is Nothing Then
                    _clientSideIsPostBackID = _clientSideIsPostBack.ClientID
                End If
                Dim script As String = SCRIPT_DOFOCUS
                script = script.Replace("{ControlClientID}", ctrlClientID)
                script = script.Replace("{clientSideIsPostBack}", _clientSideIsPostBackID)
                Dim id As String =  Request.Item("__LASTFOCUS")
                If String.IsNullOrEmpty(id) Then
                    id = ""
                End If
                script = script.Replace("{CtrlIDToFocusOnPostBack}", id)
                ClientScript.RegisterStartupScript(Page.GetType(), "SetFocusOnLoad", script, False)
            End If
        End Sub

        '''Verifies that this is editable control
        Public Overridable Function IsControlEditable(ByVal ctrl As Control, Optional ByVal includeCheckBox As Boolean = True) As Boolean
            If TypeOf ctrl Is System.Web.UI.WebControls.TextBox OrElse _
               TypeOf ctrl Is System.Web.UI.WebControls.DropDownList OrElse _
               TypeOf ctrl Is System.Web.UI.WebControls.ListBox OrElse _
               TypeOf ctrl Is System.Web.UI.WebControls.FileUpload Then
                Return True
            ElseIf includeCheckBox AndAlso TypeOf ctrl Is System.Web.UI.WebControls.CheckBox Then
                Return True
            End If
            Return False
        End Function

        Public Overridable Function GetSelectedTheme() As String
            'First try to get selected theme from Session
            Dim Session As System.Web.SessionState.HttpSessionState = HttpContext.Current.Session
            Dim selectedTheme As String = DirectCast(Session.Item(NetUtils.CookieSelectedTheme), String)
            If Not String.IsNullOrEmpty(selectedTheme) Then
                Return selectedTheme
            End If
            'There is no theme stored in session, possibly application is opened for the very first time.
            'Try to get theme from the cookie
            selectedTheme = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookieSelectedTheme)
            If Not String.IsNullOrEmpty(selectedTheme) Then
                'make sure theme exists in application
                Try
                    Dim appDir As String = HttpContext.Current.Server.MapPath("/")
                    If Not appDir Is Nothing Then appDir = appDir & "App_Themes"
                    If System.IO.Directory.Exists(appDir) AndAlso _
                    System.IO.Directory.Exists(System.IO.Path.Combine(appDir, selectedTheme)) Then
                        Session.Item(NetUtils.CookieSelectedTheme) = selectedTheme
                        Return selectedTheme
                    Else
                        BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieSelectedTheme, "")
                    End If
                Catch
                    BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieSelectedTheme, "")
                End Try
                
            End If
            Return ""
        End Function

        'Retrieve selected language from session or cookie
        Public Overridable Function GetSelectedLanguage() As String
            'First try to get selected language from Session
            Dim Session As System.Web.SessionState.HttpSessionState = HttpContext.Current.Session
            Dim selectedLanguage As String = DirectCast(Session("AppCultureUI"), String)
            If Not String.IsNullOrEmpty(selectedLanguage) Then Return selectedLanguage
            'There is no theme stored in session, possibly application is opened for the very first time.
            'Try to get theme from the cookie
            selectedLanguage = BaseClasses.Utils.NetUtils.GetCookie(NetUtils.CookieSelectedLanguage)
            If Not String.IsNullOrEmpty(selectedLanguage) Then
                Try
                    Dim culInfo As System.Globalization.CultureInfo = New System.Globalization.CultureInfo(selectedLanguage)
                    Session("AppCultureUI") = selectedLanguage
                    Return selectedLanguage
                Catch
                    'if exception happened this language is not supported
                    BaseClasses.Utils.NetUtils.SetCookie(NetUtils.CookieSelectedLanguage, "")
                    selectedLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name
                    Session("AppCultureUI") = selectedLanguage
                End Try
            Else
                selectedLanguage = System.Threading.Thread.CurrentThread.CurrentUICulture.Name
                Session("AppCultureUI") = selectedLanguage
            End If

            Return selectedLanguage

        End Function

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'commented out because DataBind is being called multiple times.
            '        If (Not Me.IsPostBack) Then
            '            Me.DataBind()
            '        End If
        End Sub

        ' Variable used to prevent infinite loop
        Private _modifyRedirectUrlInProgress As Boolean = False

        ' Constant used for EvaluateExpressions
        Const PREFIX_NO_ENCODE As String = "NoUrlEncode:"

        ''' Allow for migration from earlier versions which did not have url encryption.
        Public Overridable Function ModifyRedirectUrl(ByVal redirectUrl As String, ByVal redirectArgument As String) As String
            Return EvaluateExpressions(redirectUrl, redirectArgument, False)
        End Function

        Public Overridable Function ModifyRedirectUrl(ByVal redirectUrl As String, ByVal redirectArgument As String, ByVal bEncrypt As Boolean) As String
            Return EvaluateExpressions(redirectUrl, redirectArgument, bEncrypt)
        End Function

        Public Overridable Function EvaluateExpressions( _
                ByVal redirectUrl As String, _
                ByVal redirectArgument As String, _
                ByVal bEncrypt As Boolean) As String
            Return EvaluateExpressions(redirectUrl, redirectArgument, bEncrypt, Me)
        End Function

        Public Overridable Function EvaluateExpressions( _
                ByVal redirectUrl As String, _
                ByVal redirectArgument As String, _
                ByVal bEncrypt As Boolean, _
                ByVal targetCtl As Control) As String

            If (_modifyRedirectUrlInProgress) Then
                Return Nothing
            Else
                _modifyRedirectUrlInProgress = True
            End If

            Dim finalRedirectUrl As String = redirectUrl
            Dim finalRedirectArgument As String = redirectArgument


            Dim remainingUrl As String = finalRedirectUrl


            ' encrypt constant value
            If bEncrypt AndAlso targetCtl.GetType() Is Page.GetType() Then
                remainingUrl &= "&"
                finalRedirectUrl &= "&"


                While (remainingUrl.IndexOf("="c) >= 0) And (remainingUrl.IndexOf("&"c) > 0) And _
                   (remainingUrl.IndexOf("="c) < remainingUrl.IndexOf("&"c))

                    Dim leftIndex As Integer = remainingUrl.IndexOf("="c)
                    Dim rightIndex As Integer = remainingUrl.IndexOf("&"c)
                    Dim encryptFrom As String = remainingUrl.Substring(leftIndex + 1, rightIndex - leftIndex - 1)

                    remainingUrl = remainingUrl.Substring(rightIndex + 1)
                    If Not encryptFrom.StartsWith("{") OrElse Not encryptFrom.EndsWith("}") Then


                        ' check if it is already encrypted
                        Dim isEncrypted As Boolean = False
                        Try
                            If Decrypt(encryptFrom) <> "" Then
                                isEncrypted = True
                            End If
                        Catch

                        End Try

                        ' if not, process encryption
                        If Not isEncrypted Then
                            Dim encryptTo As String = DirectCast(Me.Page, BaseApplicationPage).Encrypt(DirectCast(encryptFrom, String))
                            finalRedirectUrl = finalRedirectUrl.Replace("=" & encryptFrom & "&", "=" & encryptTo & "&")
                        End If
                    End If
                End While


                finalRedirectUrl = finalRedirectUrl.Trim("&"c)
            End If

            If (finalRedirectUrl Is Nothing OrElse finalRedirectUrl.Trim = "") Then
                Return ""
            ElseIf (finalRedirectUrl.IndexOf("{"c) < 0) Then
                'RedirectUrl does not contain any format specifiers
                _modifyRedirectUrlInProgress = False
                Return finalRedirectUrl
            Else
                'The old way was to pass separate URL and arguments and use String.Format to
                'do the replacement.  Example:
                '   URL:        EditProductsRecord?Products={0}
                '   Argument:   PK
                'The new way to is pass the arguments directly in the URL.  Example:
                '   URL:        EditProductsRecord?Products={PK}
                'If the old way is passsed, convert it to the new way.
                If (Len(redirectArgument) > 0) Then
                    Dim arguments() As String = Split(redirectArgument, ",")
                    Dim i As Integer
                    For i = 0 To (arguments.Length - 1)
                        finalRedirectUrl = finalRedirectUrl.Replace("{" & i.ToString & "}", "{" & arguments(i) & "}")
                    Next

                    finalRedirectArgument = ""
                End If

                'First find all the table and record controls in the page.
                Dim controlList As New ArrayList()
                GetAllRecordAndTableControls(targetCtl, controlList)
                If controlList.Count = 0 Then
                    Return finalRedirectUrl
                End If

                ' Store the controls in a hashtable using the control unique name
                ' as the key for easy refrence later in the function.
                Dim controlIdList As New Hashtable
                Dim control As System.Web.UI.Control
                Dim found As Boolean = False
                For Each control In controlList
                    Dim uID As String = control.UniqueID
                    Dim pageContentIndex As Integer = uID.IndexOf("$PageContent$")
                    If pageContentIndex > 0 Then
                        If found = False Then
                            'Remove all controls without $PageContent$ prefix, because this page is used with Master Page
                            'and these entries are irrelevant
                            controlIdList.Clear()
                        End If
                        found = True
                    End If
                    If found Then
                        'If we found that Master Page is used for this page construction than disregard all controls
                        'without $PageContent$ prefix
                        If pageContentIndex > 0 Then
                            uID = uID.Substring(pageContentIndex + "$PageContent$".Length)
                            controlIdList.Add(uID, control)
                        End If
                    Else
                        'No Master Page presense found so far
                        controlIdList.Add(uID, control)
                    End If
                Next

                'Look at all of the expressions in the URL and forward processing
                'to the appropriate controls.
                'Expressions can be of the form [ControlName:][NoUrlEncode:]Key[:Value]
                Dim forwardTo As New ArrayList

                remainingUrl = finalRedirectUrl
                While (remainingUrl.IndexOf("{"c) >= 0) And (remainingUrl.IndexOf("}"c) > 0) And _
                   (remainingUrl.IndexOf("{"c) < remainingUrl.IndexOf("}"c))

                    Dim leftIndex As Integer = remainingUrl.IndexOf("{"c)
                    Dim rightIndex As Integer = remainingUrl.IndexOf("}"c)
                    Dim expression As String = remainingUrl.Substring(leftIndex + 1, rightIndex - leftIndex - 1)
                    remainingUrl = remainingUrl.Substring(rightIndex + 1)

                    Dim prefix As String = Nothing
                    If (expression.IndexOf(":") > 0) Then
                        prefix = expression.Substring(0, expression.IndexOf(":"))
                    End If
                    If (Not IsNothing(prefix)) AndAlso (prefix.Length > 0) AndAlso _
                       (Not (InvariantLCase(prefix) = InvariantLCase(PREFIX_NO_ENCODE))) AndAlso _
                       (Not BaseRecord.IsKnownExpressionPrefix(prefix)) Then
                        'The prefix is a control name.  Add it to the list of controls that
                        'need to process the URL.
                        If (controlIdList.Contains(prefix)) And (Not forwardTo.Contains(prefix)) Then
                            forwardTo.Add(prefix)
                        End If
                    End If
                End While

                'Forward the request to each control in the forwardTo list
                Dim containerId As String
                For Each containerId In forwardTo
                    Dim ctl As Control = CType(controlIdList.Item(containerId), Control)
                    If (Not IsNothing(ctl)) Then
                        If TypeOf ctl Is BaseApplicationRecordControl Then
                            finalRedirectUrl = DirectCast(ctl, BaseApplicationRecordControl).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt)
                        ElseIf TypeOf ctl Is BaseApplicationTableControl Then
                            finalRedirectUrl = DirectCast(ctl, BaseApplicationTableControl).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt)
                        End If
                    End If
                Next

                'If there are any unresolved expressions, let the other naming containers
                'have a crack at modifying the URL
                For Each control In controlList
                    If (forwardTo.IndexOf(control.ID) < 0) Then
                        If TypeOf control Is BaseApplicationRecordControl Then
                            finalRedirectUrl = DirectCast(control, BaseApplicationRecordControl).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt)
                        ElseIf TypeOf control Is BaseApplicationTableControl Then
                            finalRedirectUrl = DirectCast(control, BaseApplicationTableControl).EvaluateExpressions(finalRedirectUrl, finalRedirectArgument, bEncrypt)
                        End If
                    End If
                Next
            End If

            _modifyRedirectUrlInProgress = False

            Return finalRedirectUrl
        End Function

        Private Function GetAllRecordAndTableControls() As ArrayList
            Dim controlList As ArrayList = New ArrayList()
            GetAllRecordAndTableControls(Me, controlList)
            Return controlList
        End Function

        Private Sub GetAllRecordAndTableControls(ByVal ctl As Control, ByVal controlList As ArrayList)
            If ctl Is Nothing Then
                Return
            End If

            If TypeOf ctl Is BaseApplicationRecordControl OrElse _
               TypeOf ctl Is BaseApplicationTableControl Then
                controlList.Add(ctl)
            End If

            Dim nextCtl As Control
            For Each nextCtl In ctl.Controls()
                GetAllRecordAndTableControls(nextCtl, controlList)
            Next
        End Sub

        Public Function GetResourceValue(ByVal keyVal As String, ByVal appName As String) As String
            Return AppResources.GetResourceValue(keyVal, appName)
        End Function

        Public Function GetResourceValue(ByVal keyVal As String) As String
            Return AppResources.GetResourceValue(keyVal, Nothing)
        End Function

        Public Function ExpandResourceValue(ByVal keyVal As String) As String
            Return AppResources.ExpandResourceValue(keyVal)
        End Function

        ''' -----------------------------------------------------------------------------
        ''' <summary>
        ''' Register Control buttonCtrl with ScriptManager to perform traditional postback instead of default async postback
        ''' </summary>
        ''' <remarks>
        ''' </remarks>
        ''' <history>
        ''' 	[sramarao]	3/2007	Created
        ''' </history>
        ''' -----------------------------------------------------------------------------
        Public Sub RegisterPostBackTrigger(ByVal buttonCtrl As System.Web.UI.Control, ByVal updatePanelCtrl As System.Web.UI.Control)
            Try
                ' Get current ScriptManager
                Dim scriptMgr As ScriptManager = ScriptManager.GetCurrent(Me.Page)
                ' If Scriptmanager not preset return.
                If scriptMgr Is Nothing Then
                    Return
                End If
                ' If buttonCtrl is not surrounded by an UpdatePanel then return.
                Dim CurrentUpdatePanel As System.Web.UI.UpdatePanel = CType(updatePanelCtrl, UpdatePanel)
                If CurrentUpdatePanel Is Nothing Then
                    Return
                End If
                If buttonCtrl Is Nothing Then
                    Return
                End If
                scriptMgr.RegisterPostBackControl(buttonCtrl)
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Sub RegisterPostBackTrigger(ByVal buttonCtrl As System.Web.UI.Control)
            Try
                ' Get current ScriptManager
                Dim scriptMgr As ScriptManager = ScriptManager.GetCurrent(Me.Page)
                ' If Scriptmanager not preset return.
                If scriptMgr Is Nothing Then
                    Return
                End If
                If buttonCtrl Is Nothing Then
                    Return
                End If
                scriptMgr.RegisterPostBackControl(buttonCtrl)
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Overridable Sub SaveData()

        End Sub



#Region " Methods to manage saving and retrieving control values to session. "
        Private _ShouldSaveControlsToSession As Boolean = False
        Public Property ShouldSaveControlsToSession() As Boolean
            Get
                Return Me._ShouldSaveControlsToSession
            End Get
            Set(ByVal value As Boolean)
                Me._ShouldSaveControlsToSession = value
            End Set
        End Property

        Protected Sub Page_SaveControls_Unload(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Unload
            If Me.ShouldSaveControlsToSession Then
                Me.SaveControlsToSession()
            End If
        End Sub

        Protected Overridable Sub SaveControlsToSession()
        End Sub

        Protected Sub Control_ClearControls_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.PreRender
            Me.ClearControlsFromSession()
        End Sub

        Protected Overridable Sub ClearControlsFromSession()
        End Sub

        Public Sub SaveToSession( _
            ByVal control As Control, _
            ByVal value As String)

            SaveToSession(control.UniqueID, value)
        End Sub

        Public Function GetFromSession( _
            ByVal control As Control, _
            ByVal defaultValue As String) As String

            Return GetFromSession(control.UniqueID, defaultValue)
        End Function

        Public Function GetFromSession(ByVal control As Control) As String
            Return GetFromSession(control.UniqueID, Nothing)
        End Function

        Public Sub RemoveFromSession(ByVal control As Control)
            RemoveFromSession(control.UniqueID)
        End Sub

        Public Function InSession(ByVal control As Control) As Boolean
            Return InSession(control.UniqueID)
        End Function

        Public Sub SaveToSession( _
            ByVal control As Control, _
            ByVal variable As String, _
            ByVal value As String)

            SaveToSession(control.UniqueID & variable, value)
        End Sub

        Public Function GetFromSession( _
            ByVal control As Control, _
            ByVal variable As String, _
            ByVal defaultValue As String) As String

            Return GetFromSession(control.UniqueID & variable, defaultValue)
        End Function

        Public Sub RemoveFromSession( _
            ByVal control As Control, _
            ByVal variable As String)

            RemoveFromSession(control.UniqueID & variable)
        End Sub

        Public Function InSession( _
            ByVal control As Control, _
            ByVal variable As String) As Boolean

            Return InSession(control.UniqueID & variable)
        End Function

        Public Sub SaveToSession( _
            ByVal name As String, _
            ByVal value As String)

            Me.Session()(GetValueKey(name)) = value
        End Sub

        Public Function GetFromSession( _
            ByVal name As String, _
            ByVal defaultValue As String) As String

            Dim value As String = CType(Me.Session()(GetValueKey(name)), String)
            If value Is Nothing OrElse value.Trim() = "" Then
                value = defaultValue
            End If

            Return value
        End Function

        Public Function GetFromSession(ByVal name As String) As String
            Return GetFromSession(name, Nothing)
        End Function

        Public Sub RemoveFromSession(ByVal name As String)
            Me.Session.Remove(GetValueKey(name))
        End Sub

        Public Function InSession(ByVal name As String) As Boolean
            Return (Not Me.Session(GetValueKey(name)) Is Nothing)
        End Function

        Public Function GetValueKey(ByVal name As String) As String
            Return Me.Session.SessionID & Me.AppRelativeVirtualPath & name
        End Function
#End Region
#Region " Methods to encrypt and decrypt URL parameters "


        ' The URLEncryptionKey is specified in the web.config.  The rightmost three characters of the current
        ' Session Id are concatenated with the URLEncryptionKey to provide added protection.  You can change
        ' this to anything you like by changing this function for the application.
        ' This function is private and not overridable because each page cannot have its own key - it must
        ' be common across the entire application.
        Public Overridable Function Encrypt(ByVal Source As String) As String
                Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
            Return CheckCrypto.Encrypt(Source)
        End Function

        Public Overridable Function Decrypt(ByVal Source As String) As String
            Dim CheckCrypto As Crypto = New Crypto(Crypto.Providers.DES)
            Return CheckCrypto.Decrypt(Source)
        End Function

        ' Encrypt url parameter which is enclosed in {}. For eg:..\Shared\SelectFileToImport?TableName=Employees
        Public Function EncryptUrlParameter(ByVal url As String) As String
            If (url Is Nothing) Then
                Return ""
            End If

            If ((url.IndexOf(Microsoft.VisualBasic.ChrW(61)) > 0)) Then
                Dim queryString() As String = url.Split(Microsoft.VisualBasic.ChrW(61))
                Dim expression As String = queryString(1)
                Dim encryptedValue As String = Encrypt(expression)
                url = url.Replace(expression, encryptedValue)

            End If
            Return url
        End Function
#End Region
    End Class

End Namespace
