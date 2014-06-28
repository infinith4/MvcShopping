<%@ Import Namespace="MvcShopping.Models" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<CartModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    title cart
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Index</h2>
    <table>
        <tr>
            <td>商品ID</td>
            <td>商品名</td>
            <td>価格</td>
            <td>数量</td>
        </tr>
        <% foreach (CartItem item in Model.Items ) { %>
        <tr>
            <td><%: item.ID %></td>
            <td><%: item.Name %></td>
            <td><%: item.Price %></td>
            <td><%: item.Count %></td>
        </tr>
        <% }%>
    </table>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ScriptsSection" runat="server">
</asp:Content>
