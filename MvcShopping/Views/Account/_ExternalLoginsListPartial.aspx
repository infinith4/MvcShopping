﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<ICollection<Microsoft.Web.WebPages.OAuth.AuthenticationClientData>>" %>

<% if (Model.Count == 0) { %>
    <div class="message-info">
        <p>外部認証サービスが構成されていません。この ASP.NET アプリケーションをセットアップして、外部サービス経由でのログインをサポートする方法の詳細については、
<a href="http://go.microsoft.com/fwlink/?LinkId=252166">この記事</a>を参照してください。</p>
    </div>
<% } else {
    using (Html.BeginForm("ExternalLogin", "Account", new { ReturnUrl = ViewBag.ReturnUrl })) { %>
    <%: Html.AntiForgeryToken() %>
    <fieldset id="socialLoginList">
        <legend>別のサービスを使用してログイン</legend>
        <p>
        <% foreach (Microsoft.Web.WebPages.OAuth.AuthenticationClientData p in Model) { %>
            <button type="submit" name="provider" value="<%: p.AuthenticationClient.ProviderName %>" title="アカウントを使用して <%: p.DisplayName %> ログイン"><%: p.DisplayName%></button>
        <% } %>
        </p>
    </fieldset>
    <% }
} %>
