<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="ControlPanel.aspx.cs" Inherits="ControlPanel" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            text-align: center;
            font-family: Papyrus;
            font-size: x-large;
        }
        .style3
        {
            text-align: center;
            font-family: "Times New Roman", Times, serif;
            font-size: x-large;
        }
        .style5
        {
            width: 166px;
        }
        .style6
        {
            font-size: xx-large;
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
        <strong><em class="style6">CONTROL PANEL</em></strong></p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        &nbsp;</p>
    <p class="style3">
        Wel-Come
        <asp:Label ID="lbluserid" runat="server"></asp:Label>
    </p>
    <p class="style3">
        &nbsp;</p>
    <table align="center">
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5">
                <cc1:OboutButton ID="btnmanageusers" runat="server" style="top: 0px; left: 0px" 
                    Text="ManagesUsers" onclick="btnmanageusers_Click" Width="150px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btnmanageitemlist" runat="server" 
                    style="top: 0px; left: 0px; height: 50px;" Text="Manage Item List" 
                    onclick="btnmanageitemlist_Click" Width="150px">
                </cc1:OboutButton>
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
                <cc1:OboutButton ID="btnaddplace" runat="server" style="top: 0px; left: 0px" 
                    Text="Add New Place" onclick="btnaddplace_Click" Width="150px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btnvieworders" runat="server" style="top: 0px; left: 0px" 
                    Text="View Orders" onclick="btnvieworders_Click" Width="150px">
                </cc1:OboutButton>
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
                <cc1:OboutButton ID="btnviewtransection" runat="server" 
                    style="top: 0px; left: 0px" Text="View Transaction" 
                    onclick="btnviewtransection_Click" Width="150px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btnchangepassword" runat="server" 
                    style="top: 0px; left: 0px" Text="Change Password" 
                    onclick="btnchangepassword_Click" Width="150px">
                </cc1:OboutButton>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style5" colspan=2>
                <cc1:OboutButton ID="btnmanagesstock" runat="server" 
                    onclick="btnmanagesstock_Click" style="top: 0px; left: 0px" 
                    Text="Manages Stock Of Items">
                </cc1:OboutButton>
            </td>
            
        </tr>
    </table>
    <p class="style1">
        &nbsp;</p>
</asp:Content>

