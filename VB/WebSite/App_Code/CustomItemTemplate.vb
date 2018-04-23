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

Public Class CustomItemTemplate
	Implements ITemplate
	Public Sub New()
	End Sub
	Public Sub InstantiateIn(ByVal container As Control) Implements ITemplate.InstantiateIn
		Dim label As New Label()
		label.Text = "TemplateControl"
		container.Controls.Add(label)
	End Sub
End Class