#pragma checksum "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "608f7989555e58b03a9334d07111616e6008c38f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Editprofile), @"mvc.1.0.view", @"/Views/Home/Editprofile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608f7989555e58b03a9334d07111616e6008c38f", @"/Views/Home/Editprofile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Editprofile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        <p class=""nav__profile-nickname"">");
#nullable restore
#line 12 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml"
                                    Write(Context.Request.Cookies["FullName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"nav__profile-nickname\">");
#nullable restore
#line 13 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml"
                                    Write(Context.Request.Cookies["NickName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        <button href=""#"" class=""nav__profile-edit btn-style"">
            <i class=""fas fa-user-edit nav__menu-item-icon""></i>
            Edytuj Profil
        </button>
    </div>

    <div class=""nav__menu"">
        <button href=""#"" class=""nav__menu-item btn-style"">
            <i class=""fas fa-comment-dots nav__menu-item-icon""></i> Rozmowy
        </button>

        <button id=""friends"" class=""nav__menu-item btn-style"">
            <i class=""fas fa-users nav__menu-item-icon""></i> Znajomi
        </button>
    </div>
    <div class=""nav__logout"">
        <button class=""nav__logout-item btn-style"" id=""logOut"">
            <i class=""fas fa-sign-out-alt nav__menu-item-icon""></i> Wyloguj
        </button>
        <button class=""nav__logout-item btn-style"">
            <i class=""fas fa-cog nav__menu-item-icon""></i> Ustawienia
        </button>
    </div>
</nav>

<main class=""editprofile"">
    <h1 class=""section-heading"">profil</h1>
    <div class=""editprofile__data"">
        <i");
            WriteLiteral("mg src=\"img/deafultphoto.jpg\" alt=\"profile photo\" class=\"editprofile__data-img\">\r\n        <p class=\"editprofile__data-name\">");
#nullable restore
#line 43 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml"
                                     Write(Context.Request.Cookies["FullName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"editprofile__data-nickname\">(");
#nullable restore
#line 44 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml"
                                          Write(Context.Request.Cookies["NickName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</p>
    </div>
    <div class=""editprofile__buttons"">
        <button class=""btn-style editprofile__buttons-img btn-special-animation"" data-bs-toggle=""modal"" data-bs-target=""#editphoto"">Edytuj zdjęcie</button>

        <button class=""btn-style editprofile__buttons-nickname btn-special-animation"" data-bs-toggle=""modal"" data-bs-target=""#editnickname"">Edytuj nickname</button>

        <button class=""btn-style editprofile__buttons-password btn-special-animation"" data-bs-toggle=""modal"" data-bs-target=""#editpassword"">Zmień hasło</button>

        <button class=""btn-style editprofile__buttons-mail btn-special-animation"" data-bs-toggle=""modal"" data-bs-target=""#editmail"">Zmień mail</button>
    </div>

    <!-- EDYTUJ PHOTO -->
    <div class=""modal fade"" id=""editphoto"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" i");
            WriteLiteral(@"d=""exampleModalLabel"">edytuj zdjęcie</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body editprofile__modal-photo"">
                    <img src=""img/deafultphoto.jpg"" alt=""profile photo"" class=""editprofile__data-img"">
                    <input type=""file"" class=""editprofile__modal-photo-fileinput"" accept=""image/*"">
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn-style addfriends-button btn-special-animation"" data-bs-dismiss=""modal"">zamknij</button>
                </div>
            </div>
        </div>
    </div>

    <!-- EDYTUJ NICKNAME -->
    <div class=""modal fade"" id=""editnickname"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                   ");
            WriteLiteral(@" <h5 class=""modal-title"" id=""exampleModalLabel"">edytuj nickname</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body editprofile__modal-nickname"">
                    <p class=""editprofile__modal-paragraph"">Twój nickname: </p>
                    <p class=""editprofile__modal-paragraph fw-bold"">(adamchick)</p>
                    <p class=""editprofile__modal-paragraph"">Wprowadź nowy nickname: </p>
                    <div class=""editprofile__modal-nickname-input"">
                        <input type=""text"" class=""modal-input"">
                        <button class=""btn-style addfriends-button btn-special-animation"">zatwierdź</button>
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn-style addfriends-button btn-special-animation"" data-bs-dismiss=""modal"">zamknij</button>
      ");
            WriteLiteral(@"          </div>
            </div>
        </div>
    </div>

    <!-- EDYTUJ HASŁO -->
    <div class=""modal fade"" id=""editpassword"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">edytuj hasło</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body editprofile__modal-password"">

                    <div class=""editprofile__modal-password-actual"">
                        <label for=""password"" class=""form-label"">Hasło:  </label>
                        <input type=""password"" id=""password"" class=""form-input rounded"">
                    </div>

                    <div class=""editprofile__modal-password-next"">
                        <label for=""password"" class=""f");
            WriteLiteral(@"orm-label"">Powtórz hasło:  </label>
                        <input type=""password"" id=""password"" class=""form-input rounded"">
                    </div>
                    <button class=""btn-style addfriends-button btn-special-animation"">zatwierdź</button>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn-style addfriends-button btn-special-animation"" data-bs-dismiss=""modal"">zamknij</button>
                </div>
            </div>
        </div>
    </div>

    <!-- EDYTUJ MAIL -->
    <div class=""modal fade"" id=""editmail"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">edytuj mail</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </");
            WriteLiteral(@"div>
                <div class=""modal-body editprofile__modal-mail"">

                    <div class=""editprofile__modal-mail-actual"">
                        <label for=""email"" class=""form-label"">Email:   </label>
                        <input type=""email"" id=""email"" class=""form-input"">
                    </div>

                    <div class=""editprofile__modal-mail-new"">
                        <label for=""email"" class=""form-label"">Powtórz email:   </label>
                        <input type=""email"" id=""email"" class=""form-input"">
                    </div>
                    <button class=""btn-style addfriends-button btn-special-animation"">zatwierdź</button>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn-style addfriends-button btn-special-animation"" data-bs-dismiss=""modal"">zamknij</button>
                </div>
            </div>
        </div>
    </div>
    <a id=""logOutClick"" hidden=""hidden""");
            BeginWriteAttribute("href", " href=\"", 7919, "\"", 7954, 1);
#nullable restore
#line 157 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml"
WriteAttributeValue("", 7926, Url.Action("LogOut","Home"), 7926, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n    <a id=\"friendClick\" hidden=\"hidden\"");
            BeginWriteAttribute("href", " href=\"", 8001, "\"", 8037, 1);
#nullable restore
#line 158 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Editprofile.cshtml"
WriteAttributeValue("", 8008, Url.Action("Friends","Home"), 8008, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n</main>\r\n\r\n");
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
