<%@ Page Language="C#" MasterPageFile="~/sitemaster.master" AutoEventWireup="true" CodeFile="changepassword.aspx.cs" Inherits="changepassword" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 561px;
        }
        .style3
        {
            width: 565px;
        }
    .ob_iTCN
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
    	color: #2b4c61;
    	vertical-align: middle;
	}
	
	.ob_iTCN .ob_iTL
	{
		background-position: 0px 0px;
	}
	
	.ob_iTL
	{
		position: absolute;
    	font-size: 1px;
    	height: 21px;
    	width: 10px;
    	left: 0px;
    }
	
	.ob_iTCN .ob_iTR
	{
		background-position: -10px 0px;
	}
	
	
	
	
	.ob_iTR
	{
		position: absolute;    	
    	font-size: 1px;
    	height: 21px;
		width: 10px;
		right: 0px;
	}
	
	.ob_iTCN .ob_iTC
	{
		background-position: 0px -84px;
	}
	
	.ob_iTC
	{
		height: 21px;
		line-height: 21px;
		margin-left: 10px;
		margin-right: 10px;
		position: relative;
	}
	
	.ob_iTCN .ob_iTIE
	{
	    color: #2b4c61;
	}
		
	.ob_iTIE
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
		outline: 0;
	}
	
	.ob_iBCN
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
	
	.ob_iBCN .ob_iBL
	{
		background-position: 0px 0px;
	}
	
	.ob_iBL
	{
    	position: absolute;
    	font-size: 1px;
    	height: 21px;
    	width: 12px;
    	left: 0px;
    }
	
	.ob_iBCN .ob_iBR
	{
		background-position: -12px 0px;
	}
	
	
	
	.ob_iBR
	{
		position: absolute;
		right: 0px;
    	font-size: 1px;
    	height: 21px;
    	width: 12px;
    	right: 0px;
    }
	
	.ob_iBCN .ob_iBC
	{
		background-position: 0px -147px;
		color: #2b4c61;
	}
		
	.ob_iBC
	{
		margin-left: 12px;
	    margin-right: 12px;
	    font-family: Verdana !important;
		font-size: 10px !important;
		font-weight: normal !important;
		height: 21px;
		line-height: 18px;
		-moz-user-select: none;
		background-repeat: repeat-x;
		zoom: 1;
		overflow: hidden;
		display: block !important;
	}
	
	.ob_iBOv
	{
	    position: absolute;
	    left: 0px;
	    bottom: 0px;
	    top: 0px;
	    right: 0px;
	    width: 100%;
	    height: 21px;
        float: left;	    
	}
	
	
	
	
	
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td align="left" colspan="2" valign="top">
                <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Italic="False" Font-Names="Verdana"
                    Font-Size="8pt" Font-Underline="False" ForeColor="Purple" Text="Welcome :"></asp:Label><asp:Label ID="UserNameLabel" runat="server" Font-Bold="False" Font-Italic="False"
                    Font-Names="Verdana" Font-Size="8pt" Font-Underline="False" ForeColor="Purple"></asp:Label></td>
            <td align="right" colspan="2" valign="top">
                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click" ForeColor="Purple" Font-Bold="False" Font-Names="Verdana" Font-Size="8pt" Font-Underline="False" Width="30px">Back</asp:LinkButton><asp:LinkButton ID="LogOutLinkButton" runat="server" Font-Bold="False" Font-Italic="False"
                    Font-Names="Verdana" Font-Size="8pt" Font-Underline="False" ForeColor="Purple"
                    OnClick="LogOutLinkButton_Click" CausesValidation="False" Width="50px">LogOut</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td align="left" colspan="4" valign="top" style="height: 21px; text-align: center;">
                <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Verdana"
                    Font-Overline="False" Font-Size="12pt" Font-Underline="False" ForeColor="Purple">-: Change Password :-</asp:Label></td>
        </tr>
        <tr>
            <td align="left" colspan="4" style="height: 21px" valign="top">
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td align="right" valign="top" style="width: 333px">
                <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="8pt"
                    Text="Current Password* :"></asp:Label>&nbsp;</td>
            <td align="left" valign="top">
                        <cc1:OboutTextBox ID="txtcurrentpassword" runat="server" 
                    TextMode="Password"></cc1:OboutTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcurrentpassword"
                    ErrorMessage="*Required" Font-Names="Verdana" Font-Size="8pt"></asp:RequiredFieldValidator></td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td style="height: 21px;" align="right">
            </td>
            <td align="right" style="height: 21px; width: 333px;" valign="top">
                <asp:Label ID="Label2" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="8pt"
                    Text="New Password* :"></asp:Label>&nbsp;</td>
            <td align="left" style="height: 21px;" valign="top" colspan="2">
                        <cc1:OboutTextBox ID="txtnewpassword" runat="server" 
                    TextMode="Password"></cc1:OboutTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnewpassword"
                    Display="Dynamic" ErrorMessage="*Required" SetFocusOnError="True" 
                    Font-Names="Verdana" Font-Size="8pt"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td style="height: 21px" align="right">
            </td>
            <td align="right" style="height: 21px; width: 333px;" valign="top">
                <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="8pt"
                    Text="Retype Password* :"></asp:Label>&nbsp;</td>
            <td align="left" style="height: 21px" valign="top" colspan="2">
                        <cc1:OboutTextBox ID="txtconfirmpassword" runat="server" 
                    TextMode="Password"></cc1:OboutTextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtconfirmpassword"
                    Display="Dynamic" ErrorMessage="*Required" SetFocusOnError="True" 
                    Font-Names="Verdana" Font-Size="8pt"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtnewpassword"
                    ControlToValidate="txtconfirmpassword" Display="Dynamic" ErrorMessage="* Password Must Be same."
                    SetFocusOnError="True" Font-Names="Verdana" Font-Size="8pt"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td align="right" style="height: 21px">
            </td>
            <td align="right" style="height: 21px; width: 333px;" valign="top">
            </td>
            <td align="left" style="height: 21px" valign="top">
                &nbsp;</td>
            <td style="width: 100px; height: 21px">
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 21px">
            </td>
            <td align="right" style="height: 21px; width: 333px;" valign="top">
            </td>
            <td align="left" style="height: 21px" valign="top">
                        <cc1:OboutButton ID="btnconfirm" runat="server" onclick="btnregister_Click" 
                            style="text-align: right; top: 1px; left: 0px;" Text="Confirme">
                        </cc1:OboutButton>
                    </td>
            <td style="width: 100px; height: 21px">
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td align="center" colspan="3" valign="top">
                <asp:Label ID="errmsgLabel" runat="server" ForeColor="Red" Visible="False" Font-Names="Verdana" Font-Size="8pt"></asp:Label></td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td align="center" colspan="2" style="width: 150px" valign="top">
            </td>
            <td style="width: 100px">
            </td>
        </tr>
        <tr>
            <td align="right">
            </td>
            <td align="center" colspan="2" valign="top" style="width: 150px">
                </td>
            <td style="width: 100px">
            </td>
        </tr>
    </table>
</asp:Content>

