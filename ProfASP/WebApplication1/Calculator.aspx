<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebApplication1.App_Code.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
            font-family: Verdana, Geneva, Tahoma, sans-serif;
            font-size: medium;
            font-weight: bold;
            font-style: oblique;
            font-variant: normal;
            text-transform: capitalize;
            color: #ff0000;
            text-decoration: underline;
            line-height: normal;
            text-align: center;
            background-color: #FFFF00;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
             <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
             <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
             <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
             <br />

        </div>
    </form>
    
</body>
</html>
