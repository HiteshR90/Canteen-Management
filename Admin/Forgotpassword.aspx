<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="Forgotpassword.aspx.cs" Inherits="Forgotpassword" Title="Untitled Page" %>
<%@ Import Namespace="System.Web.Mail" %>
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
            font-size: x-large;
        }
        .style3
        {
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
                         

                         

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
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <br />
    </p>
    <p class="style2">
        Enter Email ID 
        &amp; User Name In Below Box</p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        <asp:Label ID="lblerror" runat="server" 
            style="font-size: medium; font-family: 'Times New Roman', Times, serif"></asp:Label>
    </p>
    <p class="style1">
        &nbsp;</p>
    <table align="center">
        <tr>
            <td class="style3">
                User Name:</td>
            <td>
                <cc1:OboutTextBox ID="txtusername" runat="server" style="top: 0px; left: 0px"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td class="style3">
                EmailID:</td>
            <td>
                <cc1:OboutTextBox ID="txtemailid" runat="server"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <cc1:OboutButton ID="btnEmail" runat="server" onclick="btnEmail_Click" 
                    Text="Send" Width="150px">
                </cc1:OboutButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
                         

                         

</asp:Content>


