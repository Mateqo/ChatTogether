#pragma checksum "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "575d6988593396f44f6b64a5bfa0cc06733a7c13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Friends), @"mvc.1.0.view", @"/Views/Home/Friends.cshtml")]
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
#line 1 "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"575d6988593396f44f6b64a5bfa0cc06733a7c13", @"/Views/Home/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        <img src=""img/deafultphoto.jpg"" alt=""profile photo"" class=""nav__profile-img"">
        <div class=""nav__profile-imgcover""></div>
        <p class=""nav__profile-nickname"">Bartosz Adamczyk</p>
        <button href=""#"" class=""nav__profile-edit btn-style"">
            <i class=""fas fa-user-edit nav__menu-item-icon""></i>
            Edytuj Profil
        </button>
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
        <button href=""#"" class=""nav__lo");
            WriteLiteral(@"gout-item btn-style"">
            <i class=""fas fa-sign-out-alt nav__menu-item-icon""></i> Wyloguj
        </button>
        <button href=""#"" class=""nav__logout-item btn-style"">
            <i class=""fas fa-cog nav__menu-item-icon""></i> Ustawienia
        </button>
    </div>
</nav>

<!-- <div class=""newfriends"">
    <ul class=""newfriends__ul"">
        <h2 class=""newfriends__ul-text"">Lista znajomych: </h2>

        <li class=""newfriends__ul-li""> -->
<!-- <img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo"">
                <div class=""profile-functions"">
                    <p class=""friends-name"">Bartosz Adamczyk</p>
                    <div class=""friends-buttons"">
                        <button class=""btn-style friends-button""><i class=""fas fa-user-plus""></i></button>
                        <button class=""btn-style friends-button""><i class=""fas fa-times""></i></button>
                    </div>
                </div>
        </li>
    </ul>
</div> -->
<d");
            WriteLiteral(@"iv class=""friends__header"">
    <h1 class=""section-heading"">znajomi</h1>
    <div class=""friends__header-tools"">
        <button class=""friends__header-tools-addfriend btn-style"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">Dodaj znajomego</button>
        <input type=""text"" placeholder=""Szukaj znajomego..."" class=""friends__header-tools-findfriend"">
    </div>
</div>

<div class=""newfriends"">
    <ul class=""newfriends__ul"">
        <h2 class=""newfriendsUlText""> nowi znajomi: </h2>

        <!-- <li class=""newfriends__ul-li"">
                <img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo"">
                <div class=""profile-functions"">
                    <p class=""friends-name"">Bartosz Adamczyk</p>
                    <div class=""friends-buttons"">
                        <button class=""btn-style friends-button""><i class=""fas fa-user-plus""></i></button>
                        <button class=""btn-style friends-button""><i class=""fas fa-times""></i></butt");
            WriteLiteral(@"on>
                    </div>
                </div>
        </li> -->
    </ul>
</div>

<main class=""friends"">
    <ul class=""friends__ul"">
        <h2 class=""friends__ul-text"">Lista znajomych: </h2>
        <p class=""nofriends"">Twoja lista znajomych jest pusta. </p>
        <!-- <li class=""friends__ul-li"">
                <img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo"">
                <div class=""profile-functions"">
                    <p class=""friends-name"">Bartosz Adamczyk</p>
                    <div class=""friends-buttons"">
                        <button class=""btn-style friends-button""><i class=""fas fa-comment""></i></button>
                        <button class=""btn-style friends-button""><i class=""fas fa-users-slash""></i></button>
                    </div>
                </div>
        </li> -->
    </ul>
</main>



<!-- ADD FRIEND MODAL -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-");
            WriteLiteral(@"hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">dodaj znajomego</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-input"">
                <input type=""text"" placeholder=""Szukaj znajomego..."" class=""friends__header-tools-findfriend"">
            </div>
            <div class=""modal-body"">
                <ul class=""addfriends__ul"">
                    <h2 class=""addfriends__ul-text"">Lista: </h2>
                    <!-- <p class=""addfriends__ul-alertinfo"">Nie ma takiego użytkownika. </p> -->
                    <li class=""friends__ul-li"">
                        <img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo"">
                        <div class=""profile-functions"">
                            <p class=""addfriends-name");
            WriteLiteral(@""">Bartosz Adamczyk</p>
                            <div class=""friends-buttons"">
                                <button class=""btn-style addfriends-button""><i class=""fas fa-user-plus""></i></button>
                            </div>
                        </div>
                    </li>
                </ul>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn-style addfriends-button"" data-bs-dismiss=""modal"">zamknij</button>
            </div>
        </div>
    </div>
</div>");
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
