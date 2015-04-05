<%@ Page Title="" Language="C#" MasterPageFile="~/sitemaster.master" AutoEventWireup="true" CodeFile="MenucardF1.aspx.cs" Inherits="MenucardF1" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <span class="style1">Final Bill</p>
    <p>
        <asp:Label ID="lblerror" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="stockerror" runat="server"></asp:Label>
        </span>
    </p>
    <table align="center">
        <tr>
            <td>
                <asp:Label ID="lbluser" runat="server"></asp:Label>
            </td>
            <td>
                Select Place To Deliver:-</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblstock" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvfinal" runat="server" onrowdeleting="grvfinal_RowDeleting" 
                    BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" 
                    CellPadding="3" CellSpacing="1" GridLines="None" 
                    AutoGenerateColumns="False">
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" DeleteText="Remove" />
                        <asp:TemplateField HeaderText="ItemName">
                            <ItemTemplate>
                                <asp:Label ID="lblitemname" runat="server" Text='<%# Eval("itemname") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Price">
                            <ItemTemplate>
                                <asp:Label ID="lblprice" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="QTY">
                            <ItemTemplate>
                                <cc1:OboutTextBox ID="txtqty" runat="server" ControlsToEnable="" FolderStyle="" 
                                     WatermarkText="" AutoPostBack="True" MaxLength="2">1</cc1:OboutTextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Total">
                            <ItemTemplate>
                                <asp:Label ID="lbltotalp" runat="server"></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                    <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                    
                </asp:GridView>
            </td>
            <td>
                BuildIng Name:-<asp:DropDownList ID="ddlplacemain" runat="server" 
                    AutoPostBack="True" 
                    onselectedindexchanged="ddlplacemain_SelectedIndexChanged1">
                    <asp:ListItem>Select</asp:ListItem>
                </asp:DropDownList>
                <br />
                Office:-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="ddlplacesub" runat="server">
                    <asp:ListItem>Select</asp:ListItem>
                </asp:DropDownList>
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
                Total==&gt;</td>
            <td>
                <asp:Label ID="lbltotal" runat="server"></asp:Label>
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
                <cc1:OboutButton ID="btnfinish" runat="server" Text="Finish" 
                    onclick="btnfinish_Click" Width="150px" style="top: 0px; left: 1px">
                </cc1:OboutButton>
                <cc1:OboutButton ID="btnback" runat="server" onclick="btnback_Click" 
                    Text="Continue To By " style="top: 0px; left: 1px" Width="150px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btncancel" runat="server" Text="Cancel" 
                    onclick="btncancel_Click" style="top: 0px; left: 0px; width: 60px" 
                    Width="150px">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
</asp:Content>

