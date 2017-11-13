<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTask.aspx.cs" Inherits="Task_Manager.AddTask" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Panel ID="Panel1" runat="server" BackColor="#F6F6F6" Height="479px" Style="margin-left: 149px" Width="499px">
                <table>
                    <tr>
                        <td>Title
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox runat="server" ID="txt_title" Width="484px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Details
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox runat="server" ID="txt_details" Width="484px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Summary
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox runat="server" ID="txt_summary" Height="252px" Width="482px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button runat="server" ID="btn_save" Text="Save" OnClick="btn_save_Click" />
                        </td>
                    </tr>
                </table>
            </asp:Panel>

        </div>
    </form>
</body>
</html>
