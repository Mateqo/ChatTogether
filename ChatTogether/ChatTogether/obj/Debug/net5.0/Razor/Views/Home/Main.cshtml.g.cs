#pragma checksum "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eca38a7e5d8ae32cbea173a1e13dc94eae41c324"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eca38a7e5d8ae32cbea173a1e13dc94eae41c324", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- NAVIGATION  -->

<button class=""burger"">
    <i class=""fas fa-bars""></i>
    <i class=""fas fa-times  hide""></i>
</button>
<div class=""nav-shadow""></div>
<nav class=""nav"">
    <div class=""nav__profile"">
        <img src=""/img/deafultphoto.jpg"" alt=""profile photo"" class=""nav__profile-img"">
        <div class=""nav__profile-imgcover""></div>
        <p class=""nav__profile-nickname"">Bartosz Adamczyk</p>
        <button href=""#"" class=""nav__profile-edit btn-style""><i class=""fas fa-user-edit nav__menu-item-icon""></i> Edytuj Profil</button>
    </div>

    <div class=""nav__menu"">
        <button href=""#"" class=""nav__menu-item btn-style"">
            <i class=""fas fa-comment-dots nav__menu-item-icon""></i> Rozmowy
        </button>

        <button href=""#"" class=""nav__menu-item btn-style"">
            <i class=""fas fa-users nav__menu-item-icon""></i> Znajomi
        </button>
    </div>
    <div class=""nav__logout"">
        <button href=""#"" class=""nav__logout-item btn-style"">
            <");
            WriteLiteral(@"i class=""fas fa-sign-out-alt nav__menu-item-icon""></i> Wyloguj
        </button>
        <button href=""#"" class=""nav__logout-item btn-style"">
            <i class=""fas fa-cog nav__menu-item-icon""></i> Ustawienia
        </button>
    </div>
</nav>

<main class=""main"">
    <div class=""main__logo wrapper"">
        <img src=""/img/logo.png"" alt=""chattogether logo"" class=""main__logo-img"">
    </div>
    <div class=""main__buttons"">
        <div class=""main__buttons-btn btn-style""><i class=""far fa-comments"" style=""margin-right: 5px;""></i> Rozpocznij chat</div>
        <div class=""main__buttons-btn btn-style""><i class=""fas fa-user-plus"" style=""margin-right: 5px;""></i> Dodaj Znajomego</div>

    </div>
</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
