<%@ Page Title="" Language="C#" MasterPageFile="~/OurSite.Master" AutoEventWireup="true" CodeBehind="CachingEx.aspx.cs" Inherits="WebAppSecureSM.Secure.CachingEx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h2>Cache Example</h2>
    <asp:Label ID="LblCash" runat="server" Text="Label"></asp:Label>
    <asp:Button ID="btnClickMe" runat="server" Text="Click Here" OnClick="btnClickMe_Click" />
    
</asp:Content>
