<%@ Page Title="" Language="C#" MasterPageFile="~/Basic/Basic.Master" AutoEventWireup="true" CodeBehind="Colors.aspx.cs" Inherits="Lab5.Basic.Colors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ListType" runat="server">
    Colors that I like - am ramas la Transferul controlului intre pagini
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ListEntries" runat="server">
    <asp:Repeater SelectMethod ="GetColors" ItemType ="System.String" runat ="server">
        <ItemTemplate>
            <li > <%#: Item %> </li>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
