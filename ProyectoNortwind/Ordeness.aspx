
<%@ Page Title="Ordeness" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ordeness.aspx.cs" Inherits="ProyectoNortwind.Ordeness" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </h2>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>
