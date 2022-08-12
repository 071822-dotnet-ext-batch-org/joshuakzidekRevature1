model Creating_a_custom_user_login_form.Models.User
{
    ViewBag.Title = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";
}
using (Html.BeginForm())
{
    Html.ValidationSummary(true, "Login failed. Check your login details.");
    <div>
        <fieldset>
            <legend>Login</legend>
             Public class="editor-label">
             class="editor-field">
                Html.TextBoxFor(u => u.UserName)
                Html.ValidationMessageFor(u => u.UserName)
            
            class="editor-label">
                @Html.LabelFor(u => u.Password)
        
            class="editor-field">
                @Html.PasswordFor(u => u.Password)
                @Html.ValidationMessageFor(u => u.Password)
        
            class="editor-label">
                @Html.CheckBoxFor(u => u.RememberMe)
                @Html.LabelFor(u => u.RememberMe)
            
            <input type="submit" value="Log In" />
        </fieldset>
    
}
