<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="Admin_adminlogin" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <style type="text/css">
        .style1
        {
            text-align: center;
            font-family: "Times New Roman", Times, serif;
            font-size: x-large;
        }
        .style3
        {
            font-size: medium;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    
   
    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p class="style1">
        LOGIN</p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        <asp:Label ID="lblerror" runat="server"></asp:Label>
    </p>
    <p class="style1">
        &nbsp;</p>
    <table align="center">
        <tr>
            <td class="style3">
                UserName:</td>
            <td>
                <cc1:OboutTextBox ID="txtusername" runat="server"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style3">
                Password:</td>
            <td>
                <cc1:OboutTextBox ID="txtpassword" runat="server" TextMode="Password"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <cc1:OboutButton ID="btnlogin" runat="server" Text="LogIn" Width="100px" 
                    onclick="btnlogin_Click">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btncancle" runat="server" Text="Cancel" Width="100px" 
                    onclick="btncancle_Click" style="top: 1px; left: 0px">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
    <p>
    </p>
    <p>
    </p>
   
    
   
</asp:Content>

