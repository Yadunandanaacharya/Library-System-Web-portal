<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Library_System_Web_portal.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


   
    <asp:TextBox ID="txtAuthorID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>
     <asp:Button ID="btnGo" CssClass="btn btn-primary" runat="server" Text="Go" OnClick="btnGo_Click"></asp:Button>
   
    <input />
    <h2>This is Webform content</h2>
</asp:Content>
