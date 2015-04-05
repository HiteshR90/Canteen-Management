<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="managetransection.aspx.cs" Inherits="managetransection" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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
        Transaction Management&nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
        Wel-Come
        <asp:Label ID="lbluname" runat="server"></asp:Label>
    </p>
    <br />
    <br />
    <br />
    <table align="center">
        <tr>
            <td colspan=2>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblerror" runat="server" 
                    style="text-align: center; font-family: 'Times New Roman', Times, serif; font-size: large;"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td>
                <cc1:OboutButton ID="btnviewtodaytarnsection" runat="server" 
                    Text="View Transaction" Width="200px" 
                    onclick="btnviewtodaytarnsection_Click" style="top: 0px; left: 1px">
                </cc1:OboutButton>
            </td>
            <td>
                <cc1:OboutButton ID="btnaddammounttouser" runat="server" 
                    Text="Add Amount To User Account" Width="200px" 
                    onclick="btnaddammounttouser_Click">
                </cc1:OboutButton>
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
                <cc1:OboutButton ID="btnviewbyusername" runat="server" 
                    onclick="btnviewbyusername_Click" Text="View Transaction By User Name" 
                    Width="200px" style="top: 0px; left: 0px">
                </cc1:OboutButton>
                <asp:Label ID="lblusername" runat="server" Text="Select User Name:-"></asp:Label>
                <cc1:OboutDropDownList ID="ddlusernameaddamount" runat="server" 
                    AutoPostBack="True" 
                    onselectedindexchanged="ddlusernameaddamount_SelectedIndexChanged" 
                    style="top: 0px; left: -1px" Width="90px">
                </cc1:OboutDropDownList>
            </td>
            <td>
                <cc1:OboutButton ID="btnviewalltransection" runat="server" 
                    onclick="btnviewalltransection_Click" Text="view All Transaction" 
                    Width="200px">
                </cc1:OboutButton>
                <asp:Label ID="lblinseramount" runat="server" Text="InserAmount:-"></asp:Label>
                <cc1:OboutTextBox ID="txtamount" runat="server" MaxLength="4" Width="120px"></cc1:OboutTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblbalance" runat="server" Text="Current Balance is:==&gt;"></asp:Label>
                <asp:Label ID="lblbalancecurrent" runat="server"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <cc1:OboutDropDownList ID="ddlusername" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="ddlusername_SelectedIndexChanged" Width="200px">
                </cc1:OboutDropDownList>
            </td>
            <td>
                <cc1:OboutButton ID="btnfillamount" runat="server" 
                    onclick="btnfillamount_Click" style="top: 1px; left: 0px" Text="OK" 
                    Width="200px">
                </cc1:OboutButton>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td colspan=2>
                <asp:GridView ID="griduserdata" runat="server" AutoGenerateColumns="False" 
                    BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" 
                    CellPadding="3" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:TemplateField HeaderText="Transection ID">
                            <ItemTemplate>
                                <asp:Label ID="lbltid" runat="server" Text='<%# Eval("Tid") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="ItemName">
                            <ItemTemplate>
                                <asp:Label ID="itemname" runat="server" Text='<%# Eval("Itemname") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="QTY">
                            <ItemTemplate>
                                <asp:Label ID="lblqty" runat="server" Text='<%# Eval("QTY") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Price">
                            <ItemTemplate>
                                <asp:Label ID="lblprice" runat="server" Text='<%# Eval("price") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount">
                            <ItemTemplate>
                                <asp:Label ID="lblamount" runat="server" Text='<%# Eval("amount") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Balance">
                            <ItemTemplate>
                                <asp:Label ID="lance" runat="server" Text='<%# Eval("Balance") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="lbldate" runat="server" Text='<%# Eval("date") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Time">
                            <ItemTemplate>
                                <asp:Label ID="lbltime" runat="server" Text='<%# Eval("time") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:GridView ID="gridalldata" runat="server" BackColor="#CCCCCC" 
                    BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" 
                    CellSpacing="2" ForeColor="Black">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <br />
            </td>
            
        </tr>
    </table>
</asp:Content>

