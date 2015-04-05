<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="Adminregister.aspx.cs" Inherits="Admin_Adminregister" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            text-align: center;
            font-family: "Times New Roman", Times, serif;
            font-size: xx-large;
        }
        .style4
        {
            font-family: "Times New Roman", Times, serif;
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
    <p class="style2">
        Register</p>
    <p class="style2">
        &nbsp;</p>
    <p class="style2">
        WelCome
        <asp:Label ID="lblname" runat="server"></asp:Label>
    </p>
    <p class="style2">
        &nbsp;</p>
    <p class="style2">
        <asp:Label ID="lblerror" runat="server"></asp:Label>
    </p>
    <p class="style2">
        &nbsp;</p>
    <table align="center">
        <tr>
            <td class="style4">
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
            <td class="style4">
                First Name:</td>
            <td>
                <cc1:OboutTextBox ID="txtfname" runat="server"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Last Name:</td>
            <td>
                <cc1:OboutTextBox ID="txtlname" runat="server"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                EmailID:</td>
            <td>
                <cc1:OboutTextBox ID="txtemail" runat="server" style="top: 0px; left: 0px"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                PhoneNo:</td>
            <td>
                <cc1:OboutTextBox ID="txtphoneno" runat="server"></cc1:OboutTextBox>
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
                <cc1:OboutButton ID="btnregister" runat="server" onclick="btnregister_Click" 
                    Text="Register" Width="150px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btncancel" runat="server" Text="Cancle" Width="150px">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
    <p class="style1">
        &nbsp;</p>
    
</asp:Content>

