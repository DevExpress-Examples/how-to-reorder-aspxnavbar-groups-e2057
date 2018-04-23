using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxNavBar;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        ASPxNavBar1.Groups.FindByName("Group2").ItemTemplate = new CustomItemTemplate();
    }
    protected bool GetButtonDownEnabled(object container) {
        NavBarGroupTemplateContainer templateContainer = (NavBarGroupTemplateContainer)container;
        return templateContainer.Group.Index != ASPxNavBar1.Groups.Count - 1;
    }
    protected bool GetButtonUpEnabled(object container) {
        NavBarGroupTemplateContainer templateContainer = (NavBarGroupTemplateContainer)container;
        return templateContainer.Group.Index != 0;
    }
    protected void buttonUp_Click(object sender, EventArgs e) {
        Button buttonUp = (Button)sender;
        NavBarGroupTemplateContainer templateContainer = (NavBarGroupTemplateContainer)buttonUp.NamingContainer;
        if (templateContainer.Group.Index != 0)
            templateContainer.Group.Index--;
    }
    protected void buttonDown_Click(object sender, EventArgs e) {
        Button buttonDown = (Button)sender;
        NavBarGroupTemplateContainer templateContainer = (NavBarGroupTemplateContainer)buttonDown.NamingContainer;
        if (templateContainer.Group.Index != ASPxNavBar1.Groups.Count - 1)
            templateContainer.Group.Index++;
    }
}