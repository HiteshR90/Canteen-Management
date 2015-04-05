<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="manageItems.aspx.cs" Inherits="Admin_manageItems" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 185px;
            height: 371px;
        }
        .style3
        {
            height: 371px;
        }
        .style6
        {
            width: 163px;
        }
	.ob_iDdlITCN
	{
		position: relative;
        display:-moz-inline-stack;
        display:inline-block;
        zoom:1;
        *display:inline;
        height: 21px;
        font-size: 10px;
    	padding: 0px;
    	text-align: center;
    	vertical-align: middle;
	}
	
	.ob_iDdlITCN .ob_iDdlTL
	{
		background-position: 0px 0px;
	}
	
	.ob_iDdlTL
	{
		position: absolute;
    	font-size: 1px;
    	height: 21px;
    	width: 7px;
    	left: 0px;
    	cursor: pointer;
  	}
	
	.ob_iDdlITCN .ob_iDdlTR
	{
		background-position: -7px 0px;
	}
	
	.ob_iDdlTR
	{
		position: absolute;    	
    	font-size: 1px;
    	height: 21px;
		width: 26px;
		right: 0px;
		cursor: pointer;
	}
	
	.ob_iDdlITCN .ob_iDdlTC
	{
		background-position: 0px 0px;
	}
		
	.ob_iDdlTC
	{
		height: 21px;
		line-height: 21px;
		cursor: pointer;
		margin-left: 7px;
		margin-right: 26px;
		position: relative;
	}
	
	.ob_iDdlITCN .ob_iDdlIE
	{
	    color: #2b4c61;
	}
	
	
	
	
	
	.ob_iDdlIE
	{
		width: 100%;
		position: absolute;
		left: 0px;
		right: 0px;
		top:0px;
		display: block;
    	background-color: transparent;
    	border: 0px;
    	margin: 0px;
    	padding: 0px;
    	margin-top: 4px !important;
    	font-family: Verdana !important;
		font-size: 10px !important;
		height: 13px !important;
		cursor: pointer;
	}
	
	.ob_iDdlIC
	{
		width: 100%;
		height: auto;
		font-size: 10px;
		position: absolute;
		top:20px;
		left:0px;
		visibility: hidden;
		z-index: 9999;
		border: 0px;
		padding-bottom: 5px;
	}
	
	.ob_iDdlICH
	{
		position: relative;
    	height: 12px;
    	font-size: 1px;
	}
	
	.ob_iDdlICHCL
	{
		position: absolute;
    	width: 12px;
    	height: 12px;
    	top: 0px;
    	left: -5px;
		background-repeat: no-repeat;
		background-position: 0px 0px;
	}
	
	.ob_iDdlICHCM
	{
		height: 12px;
    	margin-left: 5px;
	    margin-right: 5px;
		background-repeat: repeat-x;
		background-position: 0px -120px;
	}
	
	.ob_iDdlICHCR
	{
		position: absolute;
    	width: 12px;
    	height: 12px;
    	top: 0px;
    	right: -5px;
		background-repeat: no-repeat;
		background-position: 0px -42px;
	}
	
	.ob_iDdlICB
	{
		position: relative;
    	height: 100%;
    	font-size: 1px;
	}
	
	
	.ob_iDdlICBL
	{
		position: absolute;
    	width: 12px;
    	height: 100%;
    	top: 0px;
    	left: -5px;
		background-position: 0px 0px;
		overflow: hidden;
		z-index: 5;
	}
	
	.ob_iDdlICBLI
	{
		position: absolute;
    	width: 6px;
    	height: 30px;
    	top: 0px;
    	left: 6px;
		background-position: -6px -12px;
	}
	
	.ob_iDdlICBC
    {
        position: relative;
    	width: auto;
    	height: 100%;
    	min-height: 42px;
    	overflow: auto;
    	margin-left: 3px;
	    margin-right: 3px;
	    padding-bottom: 4px;
	    background-position: 0px -132px;
    	background-repeat: repeat-x;
	    background-color: #d0dee5;
	    font-size: 10px;
	    z-index: 10;
        padding: 0px;
        margin-top: 0px;
        margin-bottom: 0px;
        list-style-type: none !important;
    }
    
    .ob_iDdlICBC li b
    {
        background-position: 0px 0px;
        background-repeat: no-repeat;
        position: absolute;
        left: -15px;
        padding-left: 18px;
        right: 0px;
        height: 19px;
        line-height: 17px;
        font-weight: normal;
        vertical-align: middle;
        white-space: nowrap;
        overflow: hidden;
        text-align: left !important;
    }
    
    .ob_iDdlICBC li i
    {
        background-position: 0px -38px;
        background-repeat: no-repeat;
        position: absolute;
        right: -15px;
        height: 19px;
        width: 15px;
        text-indent: 20px;
        overflow: hidden;
        font-size: 0px;
        white-space: nowrap;
    }
    
    .ob_iDdlICBR
	{
		position: absolute;
    	width: 12px;
    	height: 100%;
    	top: 0px;
    	right: -5px;
		background-position: -12px 0px;
		overflow: hidden;
		z-index: 5;
	}
	
	.ob_iDdlICBRI
	{
		position: absolute;
    	width: 6px;
    	height: 30px;
    	top: 0px;
    	right: 6px;
		background-position: 0px -54px;
	}
	
	.ob_iDdlICF
	{
		position: absolute;
    	height: 12px;
    	font-size: 1px;
    	width: 100%;
    	left: 0px;
	}
	
	.ob_iDdlICFCL
	{
		position: absolute;
    	width: 12px;
    	height: 12px;
    	top: 0px;
    	left: -5px;
		background-position: 0px -84px;
		background-repeat: no-repeat;
		z-index:2;
	}
	
	.ob_iDdlICFCM
	{
		height: 12px;
    	margin-left: 7px;
	    margin-right: 7px;
		background-position: 0px -96px;
		background-repeat: repeat-x;
		z-index:1;
	}
	
	.ob_iDdlICFCR
	{
		position: absolute;
    	width: 12px;
    	height: 12px;
    	top: 0px;
    	right: -5px;
		background-position: 0px -108px;
		background-repeat: no-repeat;
	}
	
	    .style7
        {
            width: 162px;
        }
	
	    .style8
        {
            width: 138px;
        }
	
	    .style9
        {
            width: 160px;
        }
	
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" border="0">
        <tr>
            <td class="style2">
            </td>
            <td class="style3">
                <table class="style1" border="0">
                    <tr>
                        <td class="style8">
                            &nbsp;</td>
                        <td class="style9">
                            <asp:Label ID="lblerror" runat="server"></asp:Label>
                        </td>
                        <td class="style6">
                            &nbsp;</td> 
                        <td class="style7">
                            &nbsp;</td>       
                    </tr>
                    <tr>
                        <td class="style8">
                            <cc1:OboutButton ID="btnaddnewitem" runat="server" Text="Add New Item" 
                                onclick="btnaddnewitem_Click">
                            </cc1:OboutButton>
                        </td>
                        <td class="style9">
                            <asp:Label ID="lblcattype" runat="server" Text="Cat Type"></asp:Label>
                        </td>
                        <td class="style6">
                            <asp:Label ID="lblitems" runat="server" Text="Items"></asp:Label>
                            <cc1:OboutButton ID="btncategory" runat="server" onclick="btncategory_Click" 
                                Text="Add Category">
                            </cc1:OboutButton>
                        </td> 
                        <td class="style7">
                            <asp:Label ID="lblprice" runat="server" Text="Price"></asp:Label>
                        </td>       
                    </tr>
                    <tr>
                        <td class="style8">
                            <cc1:OboutButton ID="btnshowitemstable" runat="server" Text="Show item List" 
                                onclick="btnshowitemstable_Click1">
                            </cc1:OboutButton>
                        </td>
                        <td class="style9">
                            <cc1:OboutDropDownList ID="ddlitemtype" runat="server">
                            </cc1:OboutDropDownList>
                        </td>
                        <td class="style6">
                            <cc1:OboutTextBox ID="txtitemname" runat="server"></cc1:OboutTextBox>
                        </td>
                        <td class="style7">
                            <cc1:OboutTextBox ID="txtitemprice" runat="server"></cc1:OboutTextBox>
                        </td> 
                        <td>
                            
                            <cc1:OboutButton ID="btnadditem" runat="server" onclick="btnadditem_Click" 
                                Text="ADD">
                            </cc1:OboutButton>
                            
                        </td>       
                    </tr>
                    <tr>
                        <td class="style8">
                            <cc1:OboutButton ID="btnhideitemlist" runat="server" 
                                onclick="btnhideitemlist_Click" Text="Hide Item List">
                            </cc1:OboutButton>
                        </td>
                        <td class="style9">
                            <asp:GridView ID="grvitemlist" runat="server" 
                                onrowcancelingedit="grvitemlist_RowCancelingEdit" 
                                onrowdeleting="grvitemlist_RowDeleting" onrowediting="grvitemlist_RowEditing" 
                                onrowupdating="grvitemlist_RowUpdating">
                                <Columns>
                                    <asp:CommandField ShowEditButton="True" />
                                    <asp:CommandField ShowDeleteButton="True" />
                                </Columns>
                            </asp:GridView>
                        </td>
                        <td class="style8">
                            <cc1:OboutButton ID="btnaddcat" runat="server" onclick="btnaddcat_Click" 
                                Text="OK">
                            </cc1:OboutButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

