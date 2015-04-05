<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 307px;
            height: 200px;
        }
        .style3
        {
            height: 200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <table class="style1" border="0">
        <tr>
            <td class="style2">
                </td>
            <td class="style3">
                &nbsp;
                <asp:LoginView ID="LoginView1" runat="server">
    <AnonymousTemplate>
        <a href="adminlogin.aspx">LogIn</a>
        <a href="Adminregister.aspx">Register</a>
    </AnonymousTemplate>
        <LoggedInTemplate>
          Welcome Back 
               <asp:LoginName ID="LoginName1" runat="server" />
            <a href="ChangAdminpassword.aspx">Chang Password</a>
            </LoggedInTemplate>
    </asp:LoginView>
                </td>
        </tr>
    </table>
    
</asp:Content>

