<%@ Page Language="C#" MasterPageFile="~/sitemaster.master" AutoEventWireup="true" CodeFile="Contactus.aspx.cs" Inherits="Contactus" Title="Untitled Page" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style2
    {
        text-align: left;
    }
        .style3
        {
            width: 100%;
        }
        .style4
        {
            width: 189px;
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
<asp:Content ID="Content2" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
            Welcome 
            <asp:Label ID="lblmaster" runat="server" Text="Guest"></asp:Label>
           
        <div id="templatemo_content_wrapper" class="style2">
    <div id="templatemo_content" class="style2">
        <div class="style2">
        <div id="main_content" class="style2">
            <h1 class="style2">
                Contact Us</h1>
            <p class="style2">
                For more information you can contact us on below address you can also call as 
                for our service. Please enter email address with name with your message or quary 
                and send us...</p>
            <div class="cleaner_h30">
            </div>
            <h3 class="style2">
                Address</h3>
            <div class="style2">
                Opp. Hotel Shivshakti<br />
                Village: Anandpar<br//>
                Kalawad Road<br//>
                <br />
                Rajkot - 361 162</div>
            <div class="cleaner_h30">
            </div>
            <h3 class="style2">
                Quick Contact</h3>
            <div id="contact_form" class="style2">
                <div class="style2">
                        
                    <table class="style3">
                        <tr>
                            <td class="style4">
                                Name:</td>
                            <td>
                                <cc1:OboutTextBox ID="txtname" runat="server"></cc1:OboutTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ControlToValidate="txtname" ErrorMessage="Please Enter Your Name">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Email ID:</td>
                            <td>
                                <cc1:OboutTextBox ID="txtemail" runat="server"></cc1:OboutTextBox>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ControlToValidate="txtemail" ErrorMessage="Enter Vaild EmailId" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                                    ControlToValidate="txtemail" ErrorMessage="Email address Require">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Mobile No:</td>
                            <td>
                                <cc1:OboutTextBox ID="txtphone" runat="server"></cc1:OboutTextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                                    ControlToValidate="txtphone" ErrorMessage="Mobile No Require">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="style4">
                                Message:</td>
                                                <td>
                                                    <cc1:OboutTextBox ID="txtmessage" runat="server" TextMode="MultiLine"></cc1:OboutTextBox>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                                                        ControlToValidate="txtmessage" ErrorMessage="Please Enter Your Messge">*</asp:RequiredFieldValidator>
                                                </td>
                                            </tr>
                        <tr>
                            <td class="style4">
                                <cc1:OboutButton ID="btnsend" runat="server" Text="Send" OnClick="btnsend_Click">
                                        </cc1:OboutButton>
                                &nbsp;</td>
                                                <td>
                                                  <cc1:OboutButton ID="btnreset" runat="server" Text="Reset" OnClick="btnreset_Click">
                    </cc1:OboutButton>  
                                                    &nbsp;</td>
                                            </tr>
                        <tr>
                            <td class="style4">
                                &nbsp;</td>
                                                <td>
                                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                            </td>
                                            </tr>
                                        </table>
                        
                </div>
                
                <div class="cleaner_h10">
                </div>
                <div class="style2">
                    
                    
                </div>
                       
            </div>
        </div>
        <!-- end of main_content -->
        
        <div id="sidebar">
            <div id="sidebar_featured_project">
                <h3 class="style2">
                    &nbsp;</h3>
            </div>
        </div>
        <!-- end of sidebar -->

		</div>

		<div class="cleaner">
        </div>
    </div>
    <!-- end of content -->
    
</div>

</asp:Content>


