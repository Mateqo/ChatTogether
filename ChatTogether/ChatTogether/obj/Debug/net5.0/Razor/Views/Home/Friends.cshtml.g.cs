#pragma checksum "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "457ccd5464ca5aa0e951e6222b7fbab1a72cc605"
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
#line 1 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"457ccd5464ca5aa0e951e6222b7fbab1a72cc605", @"/Views/Home/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatTogether.Application.ViewModels.Friend.FriendsList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hidden", new global::Microsoft.AspNetCore.Html.HtmlString("hidden"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("spinner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/spinner.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:0px; margin-left:200px;height:80px;width:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
        <p class=""nav__profile-nickname mb-0"">");
#nullable restore
#line 13 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                         Write(Context.Request.Cookies["FullName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"nav__profile-nickname\">");
#nullable restore
#line 14 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                    Write(Context.Request.Cookies["NickName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

        <button id=""edit""  class=""nav__profile-edit btn-style""><i class=""fas fa-user-edit nav__menu-item-icon""></i> Edytuj Profil</button>
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


<!-- <div class=""newfriends"">
    <ul class=""newfriends__ul"">
        <h2 class=""newfriends__ul-text"">Lista znajomych: </h2>

        <li class=""ne");
            WriteLiteral(@"wfriends__ul-li""> -->
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

<div class=""friends__header"">
    <h1 class=""section-heading"">znajomi</h1>
    <div class=""friends__header-tools"">
        <button onclick=""openModal()"" class=""friends__header-tools-addfriend btn-style"" data-bs-toggle=""modal"" data-bs-target=""#exampleModal"">Dodaj znajomego</button>
        <input type=""text"" placeholder=""Szukaj znajomego..."" class=""friends__header-tools-findfriend"">
    </div>
</div>

<div class=""newfriends"">
");
#nullable restore
#line 65 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
     if (Model.PendingFriends.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2 class=\"newfriendsUlText\"> nowi znajomi: </h2>\r\n        <ul class=\"newfriends__ul\" id=\"pendingFriendsUl\">\r\n");
#nullable restore
#line 69 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
             foreach (var friend in Model.PendingFriends)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"newfriends__ul-li\"");
            BeginWriteAttribute("id", " id=\"", 2914, "\"", 2937, 2);
            WriteAttributeValue("", 2919, "pending-", 2919, 8, true);
#nullable restore
#line 71 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 2927, friend.Id, 2927, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/img/deafultphoto.jpg\" alt=\"user profile photo\" class=\"profile-photo\">\r\n                    <div class=\"profile-functions\">\r\n                        <p class=\"friends-name\">");
#nullable restore
#line 74 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                           Write(friend.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 74 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                        Write(friend.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 74 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                                         Write(friend.NickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                        <div class=\"friends-buttons\">\r\n                            <button class=\"btn-style friends-button\" data-id=\"");
#nullable restore
#line 76 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                                         Write(friend.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3341, "\"", 3436, 12);
            WriteAttributeValue("", 3351, "acceptUserFunction(", 3351, 19, true);
#nullable restore
#line 76 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3370, friend.Id, 3370, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3380, ",", 3380, 1, true);
            WriteAttributeValue(" ", 3381, "\'", 3382, 2, true);
#nullable restore
#line 76 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3383, friend.NickName, 3383, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3399, "\',", 3399, 2, true);
            WriteAttributeValue(" ", 3401, "\'", 3402, 2, true);
#nullable restore
#line 76 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3403, friend.Name, 3403, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3415, "\',", 3415, 2, true);
            WriteAttributeValue(" ", 3417, "\'", 3418, 2, true);
#nullable restore
#line 76 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3419, friend.Surname, 3419, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3434, "\')", 3434, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-user-plus\"></i></button>\r\n                            <button class=\"btn-style friends-button\" data-id=\"");
#nullable restore
#line 77 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                                         Write(friend.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3570, "\"", 3665, 12);
            WriteAttributeValue("", 3580, "rejectUserFunction(", 3580, 19, true);
#nullable restore
#line 77 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3599, friend.Id, 3599, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3609, ",", 3609, 1, true);
            WriteAttributeValue(" ", 3610, "\'", 3611, 2, true);
#nullable restore
#line 77 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3612, friend.NickName, 3612, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3628, "\',", 3628, 2, true);
            WriteAttributeValue(" ", 3630, "\'", 3631, 2, true);
#nullable restore
#line 77 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3632, friend.Name, 3632, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3644, "\',", 3644, 2, true);
            WriteAttributeValue(" ", 3646, "\'", 3647, 2, true);
#nullable restore
#line 77 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 3648, friend.Surname, 3648, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3663, "\')", 3663, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-times\"></i></button>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 81 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <!-- <li class=""newfriends__ul-li"">
                    <img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo"">
                    <div class=""profile-functions"">
                        <p class=""friends-name"">Bartosz Adamczyk</p>
                        <div class=""friends-buttons"">
                            <button class=""btn-style friends-button""><i class=""fas fa-user-plus""></i></button>
                            <button class=""btn-style friends-button""><i class=""fas fa-times""></i></button>
                        </div>
                    </div>
            </li> -->
        </ul>
");
#nullable restore
#line 94 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<main class=\"friends\">\r\n    <h2 class=\"friends__ul-text\">Lista znajomych: </h2>\r\n");
#nullable restore
#line 99 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
     if (Model.Friends.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"nofriends\">Twoja lista znajomych jest pusta. </p>\r\n");
#nullable restore
#line 102 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <ul class=\"friends__ul\" id=\"newFriendsUl\">\r\n");
#nullable restore
#line 105 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
             foreach (var friend in Model.Friends)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"friends__ul-li\"");
            BeginWriteAttribute("id", " id=\"", 4835, "\"", 4858, 2);
            WriteAttributeValue("", 4840, "friends-", 4840, 8, true);
#nullable restore
#line 107 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 4848, friend.Id, 4848, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img src=\"/img/deafultphoto.jpg\" alt=\"user profile photo\" class=\"profile-photo\">\r\n                    <div class=\"profile-functions\">\r\n                        <p class=\"friends-name\">");
#nullable restore
#line 110 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                           Write(friend.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 110 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                        Write(friend.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  (");
#nullable restore
#line 110 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                                          Write(friend.NickName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                        <div class=\"friends-buttons\">\r\n                            <button class=\"btn-style friends-button\" data-id=\"");
#nullable restore
#line 112 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                                         Write(friend.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5263, "\"", 5348, 3);
            WriteAttributeValue("", 5273, "location.href=\'", 5273, 15, true);
#nullable restore
#line 112 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 5288, Url.Action("Chat", "Home",  new { friendId = @friend.Id }), 5288, 59, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5347, "\'", 5347, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-comment\"></i></button>\r\n                            <button class=\"btn-style friends-button\" data-id=\"");
#nullable restore
#line 113 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
                                                                         Write(friend.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5480, "\"", 5520, 3);
            WriteAttributeValue("", 5490, "removeUserFunction(", 5490, 19, true);
#nullable restore
#line 113 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 5509, friend.Id, 5509, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5519, ")", 5519, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-users-slash\"></i></button>\r\n                        </div>\r\n                    </div>\r\n                </li>\r\n");
#nullable restore
#line 117 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    
</main>



<!-- ADD FRIEND MODAL -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">dodaj znajomego</h5>
                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""> ");
            WriteLiteral(@"</button>
            </div>
            <div class=""modal-input"">
                <input type=""text"" placeholder=""Szukaj znajomego..."" class=""friends__header-tools-findfriend"" id=""inputSearch"">
                <button id=""searchUser"" class=""btn-style"" onclick=""searchUserFunction()""><i class=""fas fa-search""></i></button>
            </div>
            <div class=""modal-body"">
                <h2 class=""addfriends__ul-text"">Lista: </h2>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "457ccd5464ca5aa0e951e6222b7fbab1a72cc60521977", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <ul class=\"addfriends__ul\" id=\"addfriendsUl\">\r\n                    <!-- <p class=\"addfriends__ul-alertinfo\">Nie ma takiego użytkownika. </p> -->\r\n");
            WriteLiteral(@"                </ul>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn-style addfriends-button"" data-bs-dismiss=""modal"">zamknij</button>
            </div>
        </div>
    </div>
</div>
<p id=""test""></p>

<a id=""logOutClick"" hidden=""hidden""");
            BeginWriteAttribute("href", " href=\"", 8497, "\"", 8532, 1);
#nullable restore
#line 172 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 8504, Url.Action("LogOut","Home"), 8504, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n<a id=\"friendClick\" hidden=\"hidden\"");
            BeginWriteAttribute("href", " href=\"", 8575, "\"", 8611, 1);
#nullable restore
#line 173 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 8582, Url.Action("Friends","Home"), 8582, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n<a id=\"editClick\" hidden=\"hidden\"");
            BeginWriteAttribute("href", " href=\"", 8652, "\"", 8692, 1);
#nullable restore
#line 174 "D:\Users\User\Desktop\repozytorium\ChatTogether\ChatTogether\ChatTogether\Views\Home\Friends.cshtml"
WriteAttributeValue("", 8659, Url.Action("Editprofile","Home"), 8659, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "457ccd5464ca5aa0e951e6222b7fbab1a72cc60525099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""//code.jquery.com/ui/1.12.1/jquery-ui.js""></script>
<script type=""text/javascript"">
    function openModal() {
        $('#addfriendsUl').empty();
        document.getElementById('inputSearch').value = """";
    }
    function searchUserFunction() {
        $('#addfriendsUl').empty();
        $('#spinner').removeAttr('hidden');
        let cos = document.getElementById('inputSearch').value;
        setTimeout(() => {
            $.ajax({
                url: '/Home/FindUsers',
                data: { input: cos },
                type: 'GET',
                dataType: 'json',
                success: function (response) {
                    console.log(response)
                    for (var i = 0; i < response.length; i++) {
                        console.log(response[i].isSend)
                    }
                    for (var i = 0; i < response.length; i++) {
                     ");
            WriteLiteral(@"   if (response[i].isSend == false)
                            $(""#addfriendsUl"").append('<li id=""' + ""userList"" + response[i].id + '"" class=""friends__ul-li""><img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo""><div class=""profile-functions""><p class=""addfriends-name"">' + response[i].name + ' ' + response[i].surname + ' ' + '(' + response[i].nickName + ')' + '</p><div id=""searchDiv' + response[i].id + '"" class=""friends-buttons""><button id=""searchBtn' + response[i].id + '"" class=""btn-style addfriends-button"" data-id=""' + response[i].id + '"" onclick=""addUserFunction(' + response[i].id + ')""><i class=""fas fa-user-plus""></i></button></div></div></li>');
                        else
                            $(""#addfriendsUl"").append('<li id=""' + ""userList"" + response[i].id + '"" class=""friends__ul-li""><img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo""><div class=""profile-functions""><p class=""addfriends-name"">' + response[i].name + ' ' + response[i].surn");
            WriteLiteral(@"ame + ' ' + '(' + response[i].nickName + ')' + '</p><div class=""friends-buttons""><i class=""fas fa-sign-in-alt""></i></div></div></li>');
                    }
                },
                error: function (xhr, status) {
                    alert('Przepraszamy, wystąpił problem!');
                },
                complete: function (xhr, status) {
                    $('#spinner').attr('hidden', 'hidden');
                }
            });
        }, 400);

    }

    function addUserFunction(id) {
        $.ajax({
            url: '/Home/AddFriend',
            data: { friendId: id },
            type: 'GET',
            dataType: 'json',
            success: function (response) {
                //$(""#newFriendsUl"").append('<li class=""friends__ul-li""><img src=""/img/deafultphoto.jpg"" alt=""user profile photo"" class=""profile-photo""><div class=""profile-functions""><p class=""addfriends-name"">' + response[i].name + ' ' + response[i].surname + ' ' + '(' + response[i].nickName + ')' + '</");
            WriteLiteral(@"p><div class=""friends-buttons""><button class=""btn-style addfriends-button"" id=""addFriendBtn""><i class=""fas fa-user-plus""></i></button></div></div></li>');
            },
            error: function (xhr, status) {


            },
            complete: function (xhr, status) {
                $('#searchBtn' + id).remove();
                $('#searchDiv' + id).append('<i class=""fas fa-sign-in-alt""></i>')
            }
        });
    }

    function acceptUserFunction(id,nickname,name,surname) {
        $.ajax({
            url: '/Home/AcceptFriend',
            data: { friendId: id },
            type: 'GET',
            dataType: 'json',
            success: function (response) {

            },
            error: function (xhr, status) {

            },
            complete: function (xhr, status) {
                $('#pending-' + id).remove();
                $('#newFriendsUl').append('<li class=""friends__ul-li"" id=""friends-' + id + '""><img src=""/img/deafultphoto.jpg"" alt=""user p");
            WriteLiteral(@"rofile photo"" class=""profile-photo""><div class=""profile-functions""><p class=""friends-name"">' + name + ' ' + surname + ' ' + '(' + nickname + ')' + '</p><div class=""friends-buttons""><button class=""btn-style friends-button"" data-id=""' + id + '"" onclick=""messageUserFunction(' + id + ')""><i class=""fas fa-comment""></i></button><button class=""btn-style friends-button"" data-id=""' + id + '"" onclick=""removeUserFunction(' + id + ')""><i class=""fas fa-users-slash""></i></button></div></div></li>');
            }
        });
    }

    function rejectUserFunction(id) {
        $.ajax({
            url: '/Home/RejectFriend',
            data: { friendId: id },
            type: 'GET',
            dataType: 'json',
            success: function (response) {
            },
            error: function (xhr, status) {
            },
            complete: function (xhr, status) {
                $('#pending-' + id).remove();
            }
        });
    }

    function removeUserFunction(id) {
            ");
            WriteLiteral(@"$.ajax({
                url: '/Home/RemoveFriend',
                data: { friendId: id },
                type: 'GET',
                dataType: 'json',
                success: function (response) {
                },
                error: function (xhr, status) {
                },
                complete: function (xhr, status) {
                    $('#friends-' + id).remove()
                }
            });
        }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatTogether.Application.ViewModels.Friend.FriendsList> Html { get; private set; }
    }
}
#pragma warning restore 1591
