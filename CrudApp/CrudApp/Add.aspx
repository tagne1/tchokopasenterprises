<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="CrudApp.Add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 201px;
        }
        .auto-style2 {
            width: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="auto-style1">First Name</td>
                <td class="auto-style2" style="background-color: #00FFFF">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtFname" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Last Name</td>
                <td class="auto-style2" style="background-color: #00FFFF">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtLname" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Contact</td>
                <td class="auto-style2" style="background-color: #00FFFF">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtContact" runat="server" Width="196px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td class="auto-style2" style="background-color: #00FFFF">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtEmail" runat="server" Width="195px"></asp:TextBox>
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">
                    <asp:Button ID="btnCreate" runat="server" BackColor="#FFFF99" ForeColor="#0033CC" OnClick="btnCreate_Click" Text="Create" />
                </td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
