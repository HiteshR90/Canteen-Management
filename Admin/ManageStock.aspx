<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="ManageStock.aspx.cs" Inherits="ManageStock" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
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
        <strong><em class="style6">Manages Stock Of Items</em></strong></p>
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
    <p class="style3">
        &nbsp;</p>
    <table align="center">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Select Category Of Items" 
                    style="font-size: medium"></asp:Label>
            </td>
            <td>
                <cc1:OboutDropDownList ID="ddlcategorylist" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlcategorylist_SelectedIndexChanged">
                </cc1:OboutDropDownList>
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
                <asp:Label ID="Label2" runat="server" Text="Select Items Name" 
                    style="font-size: medium"></asp:Label>
            </td>
            <td>
                <cc1:OboutDropDownList ID="ddlitemlist" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlitemlist_SelectedIndexChanged1">
                </cc1:OboutDropDownList>
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
                <asp:Label ID="Label3" runat="server" style="font-size: medium" 
                    Text="Current Stock"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblcurrentstock" runat="server" style="font-size: medium"></asp:Label>
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
                <asp:Label ID="Label4" runat="server" style="font-size: medium" 
                    Text="Add Quantity of new Stock"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <cc1:OboutTextBox ID="txtnewstock" runat="server" AutoPostBack="True" 
                    MaxLength="4"></cc1:OboutTextBox>
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
                <asp:Label ID="Label5" runat="server" style="font-size: medium" 
                    Text="New Stock After Add"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblnewstockafteradd" runat="server" style="font-size: medium"></asp:Label>
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
                <cc1:OboutButton ID="btnsave" runat="server" onclick="btnsave_Click" 
                    style="top: 0px; left: 0px" Text="Save">
                </cc1:OboutButton>
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

