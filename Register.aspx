<%@ Page Language="C#" MasterPageFile="~/sitemaster.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" Title="Untitled Page" %>

<%@ Register Assembly="AspXtremeCaptcha" Namespace="Cforge.Web.UI.WebControls" TagPrefix="aspX" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        
    <style type="text/css">
        .style1
        {
            text-align: center;
        }
        .style2
        {
            width: 113px;
        }
        .style3
        {
            width: 268px;
        }
        .style4
        {
            text-align: center;
            font-weight: bold;
            font-family: "Bodoni MT Black";
            font-size: xx-large;
        }
        .style5
        {
            width: 113px;
            font-size: medium;
            font-family: "Times New Roman", Times, serif;
        }
    </style>
        
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        
        <p class="style4">
            Registration Form</p>
        <p class="style4">
                        <asp:Label ID="lblerrormessage" runat="server" 
                style="font-size: medium; font-family: 'Times New Roman', Times, serif"></asp:Label>
                        
                    </p>
        <p class="style1">
            <table border="0" style="text-align:left; width:381px;" align="center">
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        First Name:</td>
                    <td class="style3">
                        <cc1:OboutTextBox ID="txtfname" runat="server"></cc1:OboutTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="txtfname" ErrorMessage="Enter First Name">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        Last Name:</td>
                    <td class="style3">
                        <cc1:OboutTextBox ID="txtlname" runat="server" style="top: 1px; left: 0px"></cc1:OboutTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="txtlname" ErrorMessage="Enter Last Name">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        User Name:</td>
                    <td class="style3">
                        <cc1:OboutTextBox ID="txtusername" runat="server"></cc1:OboutTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="txtusername" ErrorMessage="Enter User  Name">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        Email ID:</td>
                    <td class="style3">
                        <cc1:OboutTextBox ID="txtemailid" runat="server"></cc1:OboutTextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="txtemailid" ErrorMessage="Enter Valid Email Address" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                            ControlToValidate="txtemailid" ErrorMessage="Enter Email ID">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        User Type:</td>
                    <td class="style3">
                        <cc1:OboutDropDownList ID="ddlusertype" runat="server" 
                            onselectedindexchanged="ddlusertype_SelectedIndexChanged" 
                            AutoPostBack="True">
                        </cc1:OboutDropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="ddlusertype" ErrorMessage="Select User Type">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        Branch:</td>
                    <td class="style3">
                        <cc1:OboutDropDownList ID="ddlbranch" runat="server">
                        </cc1:OboutDropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                            ControlToValidate="ddlbranch" ErrorMessage="select Branch">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        Semester:</td>
                    <td class="style3">
                        <cc1:OboutDropDownList ID="ddlsemester" runat="server" 
                            style="top: 1px; left: 0px">
                        </cc1:OboutDropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                            ControlToValidate="ddlsemester" ErrorMessage="Select Semester">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style5">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style5">
                        Phone No:</td>
                    <td class="style3">
                        <cc1:OboutTextBox ID="txtphoneno" runat="server"></cc1:OboutTextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                            ControlToValidate="txtphoneno" ErrorMessage="Enter Phone No">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="txtphoneno" ErrorMessage="Phono is not correct" 
                            ValidationExpression="^[0-9]{10}">*</asp:RegularExpressionValidator>
                        </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td class="style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <%--<td>
                        <aspX:XtremeCaptcha ID="Captcha" runat="server" />
                    </td>--%>
                    <%--<td>
                        
                        <cc1:OboutTextBox ID="txtcaptcha" runat="server"></cc1:OboutTextBox>
                        
                    </td>--%>
                </tr>
                <tr>
                    <td class="style2">
                        <cc1:OboutButton ID="btnregister" runat="server" onclick="btnregister_Click" 
                            style="text-align: right; top: 1px; left: 0px;" Text="Register">
                        </cc1:OboutButton>
                    </td>
                    <td class="style3">
                        <cc1:OboutButton ID="btnreset" runat="server" onclick="btnreset_Click" 
                            Text="Reset">
                        </cc1:OboutButton>
                    </td>
                </tr>
                
            </table>
            </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            style="text-align: center" />
        <p>
            &nbsp; &nbsp;</p>

        
        </asp:Content>

