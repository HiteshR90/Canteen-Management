<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="ChangAdminpassword.aspx.cs" Inherits="Admin_ChangAdminpassword" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style3
        {
            text-align: center;
            font-family: "Times New Roman", Times, serif;
        }
        .style5
        {
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        <strong>Change Password</strong></p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        Wel-Come
        <asp:Label ID="lbluserid" runat="server"></asp:Label>
    </p>
    <p class="style1">
        &nbsp;</p>
    <p class="style1">
        <asp:Label ID="lblerror" runat="server"></asp:Label>
    </p>

    <p class="style1">
        &nbsp;</p>
    <table align="center">
        <tr>
            <td class="style5">
                Current Password:</td>
            <td>
                <cc1:OboutTextBox ID="txtcureenpass" runat="server" TextMode="Password"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                New Password:</td>
            <td>
                <cc1:OboutTextBox ID="txtnewpass" runat="server" TextMode="Password"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                Confirm Password:</td>
            <td>
                <cc1:OboutTextBox ID="txtconfpass" runat="server" TextMode="Password"></cc1:OboutTextBox>
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
                <cc1:OboutButton ID="btnChangepass" runat="server" Text="Save" Width="150px" 
                    onclick="btnChangepass_Click">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btncancel" runat="server" Text="Cancel" Width="150px" 
                    onclick="btncancel_Click">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
    </asp:Content>

