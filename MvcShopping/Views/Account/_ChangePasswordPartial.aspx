﻿<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MvcShopping.Models.LocalPasswordModel>" %>

<h3>パスワードの変更</h3>

<% using (Html.BeginForm("Manage", "Account")) { %>
    <%: Html.AntiForgeryToken() %>
    <%: Html.ValidationSummary() %>

    <fieldset>
        <legend>パスワードの変更フォーム</legend>
        <ol>
            <li>
                <%: Html.LabelFor(m => m.OldPassword) %>
                <%: Html.PasswordFor(m => m.OldPassword) %>
            </li>
            <li>
                <%: Html.LabelFor(m => m.NewPassword) %>
                <%: Html.PasswordFor(m => m.NewPassword) %>
            </li>
            <li>
                <%: Html.LabelFor(m => m.ConfirmPassword) %>
                <%: Html.PasswordFor(m => m.ConfirmPassword) %>
            </li>
        </ol>
        <input type="submit" value="パスワードの変更" />
    </fieldset>
<% } %>
