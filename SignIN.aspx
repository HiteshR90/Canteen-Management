<%@ Page Language="C#" MasterPageFile="~/sitemaster.master" AutoEventWireup="true" CodeFile="SignIN.aspx.cs" Inherits="SignIN" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <p>
           Log In Page</p>
                <p>
                    <asp:Label ID="lblerror" runat="server"></asp:Label>
                </p>
    <table align="center"  border="0" style="text-align:left; width:381px;">
        <tr>
            <td class="style2">
                User Name OR Email:</td>
            <td>
                <cc1:OboutTextBox ID="txtusernameoremail" runat="server"></cc1:OboutTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtusernameoremail" 
                    ErrorMessage="Enter User Name Or Email ID">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                Password:</td>
            <td>
                <cc1:OboutTextBox ID="txtpassword" runat="server" TextMode="Password"></cc1:OboutTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtpassword" ErrorMessage="Enter Password">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                <cc1:OboutButton ID="btnlogin" runat="server" Text="Log IN" 
                    onclick="btnlogin_Click1">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btnreset" runat="server" Text="Reset">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
<br />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" 
    style="text-align: center" />
</asp:Content>

