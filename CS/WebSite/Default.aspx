<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v9.3, Version=9.3.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxNavBar" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="mainForm" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    <dx:ASPxNavBar ID="ASPxNavBar1" runat="server">
                        <Groups>
                            <dx:NavBarGroup Text="Group1" Name="Group1">
                                <Items>
                                    <dx:NavBarItem Text="Item1">
                                    </dx:NavBarItem>
                                    <dx:NavBarItem Text="Item2">
                                    </dx:NavBarItem>
                                </Items>
                            </dx:NavBarGroup>
                            <dx:NavBarGroup Text="Group2" Name="Group2">
                                <Items>
                                    <dx:NavBarItem>
                                    </dx:NavBarItem>
                                </Items>
                            </dx:NavBarGroup>
                            <dx:NavBarGroup Text="Group3" Name="Group3">
                                <Items>
                                    <dx:NavBarItem Text="Item3">
                                    </dx:NavBarItem>
                                    <dx:NavBarItem Text="Item4">
                                    </dx:NavBarItem>
                                </Items>
                            </dx:NavBarGroup>
                        </Groups>
                        <GroupHeaderTemplate>
                            <table cellpadding="1" cellspacing="1">
                                <tr>
                                    <td>
                                        <asp:Label ID="lblGroupName" runat="server" Text='<%#Container.Group.Name%>' />
                                    </td>
                                    <td>
                                        <asp:Button ID="buttonUp" runat="server" Text="Up" OnClick="buttonUp_Click" UseSubmitBehavior="false"
                                            Enabled='<%#GetButtonUpEnabled(Container)%>' />
                                    </td>
                                    <td>
                                        <asp:Button ID="buttonDown" runat="server" Text="Down" OnClick="buttonDown_Click" UseSubmitBehavior="false"
                                            Enabled='<%#GetButtonDownEnabled(Container)%>' />
                                    </td>
                                </tr>
                            </table>
                        </GroupHeaderTemplate>
                    </dx:ASPxNavBar>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>