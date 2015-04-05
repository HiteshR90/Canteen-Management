<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="AddPlace.aspx.cs" Inherits="AddPlace" %>

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
        }
        .style3
        {
            font-size: xx-large;
        }
        .style4
        {
            width: 100%;
        }
        .style5
        {
            text-align: center;
            font-size: x-large;
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
    <p class="style2">
        <strong><em class="style3">MANAGE PLACES</em></strong></p>
    <p class="style1">
        &nbsp;</p>
    <p class="style5">
        &nbsp;</p>
    <p class="style5">
        Wel-Come
        <asp:Label ID="lbluserid" runat="server"></asp:Label>
    </p>
     <p class="style1">
         &nbsp;</p>
     <p class="style1">
         <asp:Label ID="lblerror" runat="server" style="font-size: medium"></asp:Label>
     </p>
    <table align="center">
        <tr>
            <td>
                <cc1:OboutButton ID="btnaddBuilding" runat="server" Text="ADD New Building" 
                    onclick="addBuilding_Click" Width="150px" style="top: 0px; left: 0px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutTextBox ID="txtbuilding" runat="server" style="top: 0px; left: 0px"></cc1:OboutTextBox>
            </td>
            <td>
                <cc1:OboutButton ID="btnOkBuilding" runat="server" Text="OK" 
                    onclick="btnOkBuilding_Click">
                </cc1:OboutButton>
            </td>
        </tr>
        <tr>
            <td>
                <cc1:OboutButton ID="btnaddplace" runat="server" Text="Add New Place" 
                    onclick="btnaddplace_Click" Width="150px" style="top: -1px; left: 0px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutDropDownList ID="ddlbuildingnames" runat="server">
                </cc1:OboutDropDownList>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <cc1:OboutTextBox ID="txtplace" runat="server"></cc1:OboutTextBox>
            </td>
            <td>
                <cc1:OboutButton ID="btnokplace" runat="server" Text="OK" 
                    onclick="btnokplace_Click">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
</asp:Content>

