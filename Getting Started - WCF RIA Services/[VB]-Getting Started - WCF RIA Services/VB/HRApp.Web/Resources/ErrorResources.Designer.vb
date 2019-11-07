﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30128.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Public Class ErrorResources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("HRApp.ErrorResources", GetType(ErrorResources).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Public Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The user name or password is incorrect.
    '''</summary>
    Public Shared ReadOnly Property ErrorBadUserNameOrPassword() As String
        Get
            Return ResourceManager.GetString("ErrorBadUserNameOrPassword", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to A user name for that e-mail address already exists. Please enter a different e-mail address..
    '''</summary>
    Public Shared ReadOnly Property MembershipCreateStatusDuplicateEmail() As String
        Get
            Return ResourceManager.GetString("MembershipCreateStatusDuplicateEmail", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to User name already exists. Please enter a different user name..
    '''</summary>
    Public Shared ReadOnly Property MembershipCreateStatusDuplicateUserName() As String
        Get
            Return ResourceManager.GetString("MembershipCreateStatusDuplicateUserName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator..
    '''</summary>
    Public Shared ReadOnly Property MembershipCreateStatusProviderError() As String
        Get
            Return ResourceManager.GetString("MembershipCreateStatusProviderError", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator..
    '''</summary>
    Public Shared ReadOnly Property MembershipCreateStatusUserRejected() As String
        Get
            Return ResourceManager.GetString("MembershipCreateStatusUserRejected", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The friendly name cannot be more than 255 characters long.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorBadFriendlyNameLength() As String
        Get
            Return ResourceManager.GetString("ValidationErrorBadFriendlyNameLength", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Password must be at least 7 and at most 50 characters long.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorBadPasswordLength() As String
        Get
            Return ResourceManager.GetString("ValidationErrorBadPasswordLength", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to A password needs to contain at least one special character e.g. @ or #.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorBadPasswordStrength() As String
        Get
            Return ResourceManager.GetString("ValidationErrorBadPasswordStrength", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to The user name must be at least 4 and at most 255 characters long.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorBadUserNameLength() As String
        Get
            Return ResourceManager.GetString("ValidationErrorBadUserNameLength", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Invalid email. An email must use the format user@company.com.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorInvalidEmail() As String
        Get
            Return ResourceManager.GetString("ValidationErrorInvalidEmail", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Invalid user name. It must contain only alphanumeric characters.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorInvalidUserName() As String
        Get
            Return ResourceManager.GetString("ValidationErrorInvalidUserName", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to Passwords do not match.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorPasswordConfirmationMismatch() As String
        Get
            Return ResourceManager.GetString("ValidationErrorPasswordConfirmationMismatch", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to This field is required.
    '''</summary>
    Public Shared ReadOnly Property ValidationErrorRequiredField() As String
        Get
            Return ResourceManager.GetString("ValidationErrorRequiredField", resourceCulture)
        End Get
    End Property
End Class
