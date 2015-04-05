<%@ Page Title="" Language="C#" MasterPageFile="~/sitemaster.master" AutoEventWireup="true" CodeFile="MenuCardF.aspx.cs" Inherits="MenuCardF" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table align="center">
        <tr>
            <td>
                <asp:Label ID="lbluser" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <cc1:OboutDropDownList ID="ddlselectcattype" runat="server" 
                    onselectedindexchanged="ddlselectcattype_SelectedIndexChanged" 
                    AutoPostBack="True">
                </cc1:OboutDropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <cc1:OboutButton ID="btnok1" runat="server" style="top: 0px; left: 0px" 
                    Text="OK" onclick="btnok_Click" Width="150px">
                </cc1:OboutButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvdatatable" runat="server" 
                    onselectedindexchanged="grvdatatable_SelectedIndexChanged" 
                    BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                    CellPadding="3">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" EditText="ADD" 
                            SelectText="ADD Item" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <cc1:OboutButton ID="btncancle" runat="server" onclick="btncancle_Click" 
                    Text="Cancle" Width="150px">
                </cc1:OboutButton>
            </td>
        </tr>
    </table>
</asp:Content>

