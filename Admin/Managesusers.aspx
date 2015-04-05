<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="Managesusers.aspx.cs" Inherits="Admin_Managesusers" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
            margin-bottom: 186px;
        }
        .style2
        {
            width: 281px;
            height: 291px;
        }
        .style3
        {
            height: 291px;
        }
        .style4
        {
            width: 100%;
        }
        .style5
        {
            width: 121px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table class="style1" border="0">
        <tr>
            <td class="style2">
            </td>
            <td class="style3">
                
                
                <table class="style4" border="0">
                    <tr>
                        <td class="style5">
                            <cc1:OboutButton ID="btnseeuser" runat="server" onclick="btnseeuser_Click" 
                                Text="See Users">
                            </cc1:OboutButton>
                        </td>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="style5">
                            &nbsp;</td>
                        <td>
                            <asp:GridView ID="grvuserdata" runat="server" 
                                onrowcancelingedit="grvuserdata_RowCancelingEdit" 
                                onrowdeleting="grvuserdata_RowDeleting" onrowediting="grvuserdata_RowEditing" 
                                onrowupdating="grvuserdata_RowUpdating" style="text-align: center">
                                <Columns>
                                    <asp:CommandField ShowEditButton="True" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
                
                
            </td>
        </tr>
    </table>
&nbsp; 
</asp:Content>

