<!-- default file list -->
*Files to look at*:

* [CustomItemTemplate.cs](./CS/WebSite/App_Code/CustomItemTemplate.cs) (VB: [CustomItemTemplate.vb](./VB/WebSite/App_Code/CustomItemTemplate.vb))
* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to reorder ASPxNavBar groups


<p>This sample illustrates how to change the order of groups at runtime by means of custom buttons integrated in the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxNavBarASPxNavBar_GroupHeaderTemplatetopic">GroupHeaderTemplate</a>.</p>


<h3>Description</h3>

<p>1. The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxNavBarASPxNavBar_GroupHeaderTemplatetopic">ASPxNavBar.GroupHeaderTemplate</a> contains two buttons (to move the group up and down).  Each button initiates a postback and changes the group position by modifying its Index property.</p><p>2. To avoid reloading the entire page, we&#39;ve put the ASPxNavBar in an <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.updatepanel.aspx">MS AJAX UpdatePanel</a>.</p><p>3. One group contains an <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxNavBarASPxNavBar_ItemTemplatetopic">ItemTemplate</a> defined.  When reordering groups, you should be picky of correctly handling this template.  In particular, it&#39;s necessary to set it at runtime, for the reasons described in report <a data-ticket="Q248285">ASPxNavBar - Group loses its ItemTempate when changing its Index</a>.</p>

<br/>


