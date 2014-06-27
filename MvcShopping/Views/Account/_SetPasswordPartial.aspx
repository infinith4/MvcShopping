﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcShopping.Models.LocalPasswordModel>" %>

<p>
    このサイトのローカル パスワードがありません。外部ログイン
なしでログインできるように、ローカル パスワードを追加してください。
</p>

<% using (Html.BeginForm("Manage", "Account")) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary() %>

    <fieldset>
        <legend>パスワードの設定フォーム</legend>
        <ol>
            <li>
                <%: Html.LabelFor(m => m.NewPassword) %>
                <%: Html.PasswordFor(m => m.NewPassword) %>
            </li>
            <li>
                <%: Html.LabelFor(m => m.ConfirmPassword) %>
                <%: Html.PasswordFor(m => m.ConfirmPassword) %>
            </li>
        </ol>
        <input type="submit" value="パスワードの設定" />
    </fieldset>
<% } %>
