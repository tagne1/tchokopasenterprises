<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="WebClient.aspx.cs" Inherits="ClientCRUD.WebClient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    
    <div class="jumbotron">
        <h1>Windows Communication Foundation</h1>
        <p class="lead">Building RESTful Web Services with WCF</p>
    </div>

    <form id="form1" runat="server">
        <div class="container">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lbl_id" Visible="false" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Last Name:  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_name" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>First Mid Name:  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_FM_name" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email:  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_email" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Company Name:  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_company" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Department:  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_dept" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Location:  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txt_location" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" ID="btn_save" Text="SAVE" OnClick="Btn_save_Click" />
                    </td>
                </tr>

            </table>

            <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCFF" BorderColor="#999999" BorderStyle="Solid" BorderWidth="2px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="700px" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="EMP ID">

                        <ItemTemplate>
                            <asp:Label ID="lbl_empid" runat="server" Text='<%# Bind("EmpId") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Last Name">

                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("EmpLastName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="First Name">

                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("EmpFirstMidName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="EMP Email">

                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("EmpEmail") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Company Name">

                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("CompanyName") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Location">

                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Location1") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Department">

                        <ItemTemplate>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("Dept") %>'></asp:Label>
                        </ItemTemplate>
                        <ItemStyle Width="150px" />
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="EDIT" ShowHeader="False">

                        <ItemTemplate>
                            <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="DELETE">
                        <ItemTemplate>
                            <asp:Button ID="Button2" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="#CC33FF" Font-Bold="True" ForeColor="Black" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>

        </div>

    </form>

</asp:Content>
