div style="width: auto; background-color: #739ea9;">{
    
    if (Request.IsAuthenticated) }
    {
        <strong>@Html.Encode(User.Identity.Name)</strong>
        @Html.ActionLink("Sign Out", "Logout", "User")
    }
    else {
        @Html.ActionLink("Register", "Register", "User")
        <span> | </span>
        @Html.ActionLink("Sign In", "Login", "User")
    }
