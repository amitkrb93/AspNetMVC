<%@ Page Title="" Language="C#" MasterPageFile="~/MLCP.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MLCP.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome to MLCP Slot Booking</h1>
                <p>
                   Use your &nbsp;&bull;&nbsp; TCS Web Mail &nbsp;&bull;&nbsp; to Login &nbsp;&nbsp
                </p>
               <%-- <ul style="display:inline">--%>
                    <asp:Label ID="lblempid" runat="server" Text="EmpId:"></asp:Label>
                    <asp:TextBox ID="txtempid" runat="server" style="background-color:aqua;"></asp:TextBox>
                    <asp:Label ID="lblpass" runat="server" Text="Password:"></asp:Label>
                    <asp:TextBox ID="txtpass" runat="server" style="background-color:aqua;" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="lblmobile" runat="server" Text="Mobile:"></asp:Label>
                    <asp:TextBox ID="txtmobile" runat="server" style="background-color:aqua;"></asp:TextBox>
              <%--  </ul>--%>
                <asp:Button ID="btnsubmit" runat="server" Text="Login" OnClick="btnsubmit_Click" />
                <asp:Button ID="btnreset" runat="server" Text="Reset" />
</asp:Content>
