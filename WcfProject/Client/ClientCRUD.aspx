<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientCRUD.aspx.cs" Inherits="Client.ClientCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">  
    <div>  
        <table>  
            <tr>                   
                <td>  
                   <asp:Label ID="lbl_id" Visible="false" runat="server"></asp:Label>  
                </td>  
            </tr>  
            <tr>  
                <td>  
                    Last Name:

                </td>  
                <td>  
                    <asp:TextBox runat="server" ID="txt_name" Width="200px"></asp:TextBox>  
                </td>  
            </tr>
            <tr>  
                <td>  
                    First Mid Name:  
                </td>  
                <td>  
                    <asp:TextBox runat="server" ID="txt_FM_name" Width="200px"></asp:TextBox>  
                </td>  
            </tr>
            <tr>  
                <td>  
                    Email:  
                </td>  
                <td>  
                    <asp:TextBox runat="server" ID="txt_email" Width="200px"></asp:TextBox>  
                </td>  
            </tr>
             <tr>  
                <td>  
                    Company Name:  
                </td>  
                <td>  
                    <asp:TextBox runat="server" ID="txt_company" Width="200px"></asp:TextBox>  
                </td>  
            </tr>  
             <tr>  
                <td>  
                    Department:  
                </td>  
                <td>  
                    <asp:TextBox runat="server" ID="txt_dept" Width="200px"></asp:TextBox>  
                </td>  
            </tr>  
             <tr>  
                <td>  
                    Location:  
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
         
            <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Width="700px" AutoGenerateColumns="False" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" DataSourceID="SqlDataSource1">  
               <Columns>  
                   <asp:TemplateField HeaderText="EMPLOYEE ID">  
                        
                       <ItemTemplate>  
                           <asp:Label ID="lbl_empid" runat="server" Text='<%# Bind("EmpId") %>'></asp:Label>  
                       </ItemTemplate>  
                       <ItemStyle Width="150px" />  
                   </asp:TemplateField>  
                   <asp:TemplateField HeaderText="EMPLOYEE Last NAME">  
                        
                       <ItemTemplate>  
                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("EmpLastName") %>'></asp:Label>  
                       </ItemTemplate>  
                       <ItemStyle Width="150px" />  
                   </asp:TemplateField>  
                   <asp:TemplateField HeaderText="EMPLOYEE First NAME">  
                        
                       <ItemTemplate>  
                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("EmpFirstMidName") %>'></asp:Label>  
                       </ItemTemplate>  
                       <ItemStyle Width="150px" />  
                   </asp:TemplateField> 
                    <asp:TemplateField HeaderText="EMPLOYEE Email">  
                        
                       <ItemTemplate>  
                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("EmpEmail") %>'></asp:Label>  
                       </ItemTemplate>  
                       <ItemStyle Width="150px" />  
                   </asp:TemplateField> 
                   <asp:TemplateField HeaderText="COMPANY NAME">  
                        
                       <ItemTemplate>  
                           <asp:Label ID="Label3" runat="server" Text='<%# Bind("CompanyName") %>'></asp:Label>  
                       </ItemTemplate>  
                       <ItemStyle Width="100px" />  
                   </asp:TemplateField>  
                   <asp:TemplateField HeaderText="LOCATION">  
                        
                       <ItemTemplate>  
                           <asp:Label ID="Label4" runat="server" Text='<%# Bind("Location1") %>'></asp:Label>  
                       </ItemTemplate>  
                       <ItemStyle Width="150px" />  
                   </asp:TemplateField>  
  
                    <asp:TemplateField HeaderText="DEPARTMENT">  
                      
                       <ItemTemplate>  
                           <asp:Label ID="Label5" runat="server" Text='<%# Bind("Dept") %>'></asp:Label>  
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
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />  
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />  
                <RowStyle BackColor="White" />  
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />  
                <SortedAscendingCellStyle BackColor="#F1F1F1" />  
                <SortedAscendingHeaderStyle BackColor="#808080" />  
                <SortedDescendingCellStyle BackColor="#CAC9C9" />  
                <SortedDescendingHeaderStyle BackColor="#383838" />  
            </asp:GridView>  
  
        </div>  
        
    </form>
</body>
</html>