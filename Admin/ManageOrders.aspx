<%@ Page Language="C#" MasterPageFile="~/Admin/adminmaster.master" AutoEventWireup="true" CodeFile="ManageOrders.aspx.cs" Inherits="Admin_ManageOrders" Title="Untitled Page" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%@ Register assembly="obout_Interface" namespace="Obout.Interface" tagprefix="cc1" %>

<%@ Register assembly="obout_Calendar2_Net" namespace="OboutInc.Calendar2" tagprefix="obout" %>

<%--<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--<meta http-equiv="refresh" content="5" />
    --%>
    <style type="text/css">

        .style4
        {
            text-align: center;
        }
        .style5
        {
            text-align: center;
            font-family: "Times New Roman", Times, serif;
            font-size: xx-large;
        }
        .style7
        {
            width: 100%;
        }
        .style8
        {
            font-family: "Times New Roman", Times, serif;
            font-size: medium;
        }
    </style>
    <style type="text/css">
/*Calendar Control CSS*/
.cal_Theme1 .ajax__calendar_container   {
background-color: #DEF1F4;
border:solid 1px #77D5F7;
}

.cal_Theme1 .ajax__calendar_header  {
background-color: #ffffff;
margin-bottom: 4px;
}

.cal_Theme1 .ajax__calendar_title,
.cal_Theme1 .ajax__calendar_next,
.cal_Theme1 .ajax__calendar_prev    {
color: #004080;
padding-top: 3px;
}

.cal_Theme1 .ajax__calendar_body    {
background-color: #ffffff;
border: solid 1px #77D5F7;
}

.cal_Theme1 .ajax__calendar_dayname {
text-align:center;
font-weight:bold;
margin-bottom: 4px;
margin-top: 2px;
color: #004080;
}

.cal_Theme1 .ajax__calendar_day {
color: #004080;
text-align:center;
}

.cal_Theme1 .ajax__calendar_hover .ajax__calendar_day,
.cal_Theme1 .ajax__calendar_hover .ajax__calendar_month,
.cal_Theme1 .ajax__calendar_hover .ajax__calendar_year,
.cal_Theme1 .ajax__calendar_active  {
color: #004080;
font-weight: bold;
background-color: #DEF1F4;
}

.cal_Theme1 .ajax__calendar_today   {
font-weight:bold;
}

.cal_Theme1 .ajax__calendar_other,
.cal_Theme1 .ajax__calendar_hover .ajax__calendar_today,
.cal_Theme1 .ajax__calendar_hover .ajax__calendar_title {
color: #bbbbbb;
}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <p>
        <br />
    </p>
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
    <p class="style5">
        Order Table</p>
    <p class="style5">
        &nbsp;</p>
    <p class="style5">
        Wel-Come
        <asp:Label ID="lblusername" runat="server"></asp:Label>
    </p>
    <p class="style1">
        &nbsp;</p>
    <p class="style4">
        <asp:Label ID="lblerror" runat="server" 
            style="font-family: 'Times New Roman', Times, serif; font-size: medium"></asp:Label>
    </p>
    <p class="style1">
        &nbsp;</p>
    <table align="center">
        
        <tr>
           <td>

               <table class="style7">
                   <tr>
            <td class="style8">
                
                <cc1:OboutButton ID="btnshowbyuser" runat="server" 
                    onclick="btnshowbyuser_Click" Text="See By UserName" Width="150px">
                </cc1:OboutButton>
                       </td>
            <td class="style6">
                
                <cc1:OboutButton ID="btntoday" runat="server" onclick="btntoday_Click" 
                    Text="SEE Today Order" Width="150px" style="top: 0px; left: -1px">
                </cc1:OboutButton>
                       </td>
            <td>
            
                <span class="style8">
                <cc1:OboutButton ID="btnhideall" runat="server" onclick="btnhideall_Click" 
                    Text="Hide All" Width="150px">
                </cc1:OboutButton>
                </span></td>
        </tr>
                   <tr>
            <td class="style8">
                
                &nbsp;</td>
            <td class="style6">
                
                &nbsp;</td>
            <td>
            
                &nbsp;</td>
        </tr>
                   <tr>
            <td class="style8">
                
                <asp:Label ID="lbluname" runat="server" Text="User Name:-"></asp:Label>
                
                <br />
                       </td>
            <td class="style6">
                
                <span class="style8"> <cc1:OboutDropDownList ID="ddlusernames" runat="server" AutoPostBack="True" 
                    style="top: 0px; left: -2px; width: 152px">
                </cc1:OboutDropDownList>
            
                       </td>
            <td>
            
                &nbsp;</td>
        </tr>
                   <tr>
            <td class="style8">
                
                &nbsp;</td>
            <td class="style6">
                
                &nbsp;</td>
            <td>
            
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                
                <span class="style8">
                <asp:Label ID="lbldate" runat="server" Text="Select Date:-"></asp:Label>
                </span></td>
            <td class="style6">
                <asp:ScriptManager ID="script" runat="server">
</asp:ScriptManager>
                <span class="style8">
                <cc1:OboutTextBox ID="txtDate" runat="server" AutoPostBack="True" 
                    style="top: 0px; left: -1px"></cc1:OboutTextBox>
                <ajaxToolkit:CalendarExtender 
                ID="ceCalendar" 
                runat="server"
                PopupButtonID="ibtnCalendar"
                TargetControlID="txtDate" Format="dd-MM-yyyy">
            </ajaxToolkit:CalendarExtender> 
                </span>
                

            </td>
            <td>
            
                &nbsp;</td>
            
        </tr>
        <tr>
            <td class="style6">
                
                &nbsp;</td>
            <td class="style6">
                
                &nbsp;</td>
            <td>
            
                &nbsp;</td>
            
        </tr>
        <tr>
            
            <td colspan=3>
                
                <span class="style8">
                <br />

               <asp:GridView ID="gridorderdata" runat="server" BackColor="White" 
                   BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                   GridLines="Vertical" onrowdeleting="gridorderdata_RowDeleting" 
                   ForeColor="Black">
                   <AlternatingRowStyle BackColor="White" />
                   <FooterStyle BackColor="#CCCC99" />
                   <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                   <RowStyle BackColor="#F7F7DE" />
                   <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                   <SortedAscendingCellStyle BackColor="#FBFBF2" />
                   <SortedAscendingHeaderStyle BackColor="#848384" />
                   <SortedDescendingCellStyle BackColor="#EAEAD3" />
                   <SortedDescendingHeaderStyle BackColor="#575357" />
               </asp:GridView>

                <asp:GridView ID="gridtoday" runat="server" BackColor="White" 
                   BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                   ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="White" />
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
                <br />
            </td>
            
            
        </tr>
        <tr>
            
            <td colspan=3>
                
                &nbsp;</td>
            
            
        </tr>
        <tr>
            <td class="style6">
                
                &nbsp;</td>
            <td class="style6">
                

                <span class="style8">
               <cc1:OboutButton ID="btnprint" runat="server" Text="Make Bill" Width="150px" 
                    onclick="btnprint_Click">
               </cc1:OboutButton>
            </td>
            <td>
            
                &nbsp;</td>
            
        </tr>
               </table>
            </td>
        </tr>
        <tr>
           <td>

               &nbsp;</td>
        </tr>
        <tr>
           <td>

               &nbsp;</td>
        </tr>
        <tr>
        <td>
         

                &nbsp;</td>
        </tr>
        </table>
    <p>
    </p>
    <p>
    </p>
    
</asp:Content>

