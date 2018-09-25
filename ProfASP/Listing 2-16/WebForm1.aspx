<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Listing_2_16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Service Callback</title>
  <script type="text/javascript">
function GetTemp() {
    var zipcode = document.forms[0].TextBox1.value;
    UseCallback(zipcode, "");
}

function GetTempFromServer(TextBox2, context) {
    document.forms[0].TextBox2.value = "Zipcode: " +
        document.forms[0].TextBox1.value + " | Temp: " + TextBox2;
}
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" Runat="server">
            </asp:TextBox>
            <br />
            <input id="Button1" type="button" value="Get Temp" onclick="GetTemp()" />
            <br />
            <asp:TextBox ID="TextBox2" Runat="server" Width="400px">
            </asp:TextBox>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
