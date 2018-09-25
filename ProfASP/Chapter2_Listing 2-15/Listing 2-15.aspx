<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing 2-15.aspx.cs" Inherits="Chapter2_Listing_2_15.Listing_2_15" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Callback Page</title>

    <script type="text/javascript">
        function GetNumber(){
            UseCallback();
        }
        function GetRandomNumberFromServer(TextBox1, context){
            document.forms[0].TextBox1.value = TextBox1;
        }
</script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="Button1" type="button" value="Get Random Number" onclick="GetNumber()" />
             <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           
        </div>
    </form>
</body>
</html>
