Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxNavBar

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		ASPxNavBar1.Groups.FindByName("Group2").ItemTemplate = New CustomItemTemplate()
	End Sub
	Protected Function GetButtonDownEnabled(ByVal container As Object) As Boolean
		Dim templateContainer As NavBarGroupTemplateContainer = CType(container, NavBarGroupTemplateContainer)
		Return templateContainer.Group.Index <> ASPxNavBar1.Groups.Count - 1
	End Function
	Protected Function GetButtonUpEnabled(ByVal container As Object) As Boolean
		Dim templateContainer As NavBarGroupTemplateContainer = CType(container, NavBarGroupTemplateContainer)
		Return templateContainer.Group.Index <> 0
	End Function
	Protected Sub buttonUp_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim buttonUp As Button = CType(sender, Button)
		Dim templateContainer As NavBarGroupTemplateContainer = CType(buttonUp.NamingContainer, NavBarGroupTemplateContainer)
		If templateContainer.Group.Index <> 0 Then
			templateContainer.Group.Index -= 1
		End If
	End Sub
	Protected Sub buttonDown_Click(ByVal sender As Object, ByVal e As EventArgs)
		Dim buttonDown As Button = CType(sender, Button)
		Dim templateContainer As NavBarGroupTemplateContainer = CType(buttonDown.NamingContainer, NavBarGroupTemplateContainer)
		If templateContainer.Group.Index <> ASPxNavBar1.Groups.Count - 1 Then
			templateContainer.Group.Index += 1
		End If
	End Sub
End Class