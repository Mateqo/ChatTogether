#pragma checksum "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313e7dcc5aaeb02e0c106b01bd9a357ec761086e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313e7dcc5aaeb02e0c106b01bd9a357ec761086e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""header"">
    <div class=""header__img""></div>
    <div class=""header__box"">
        <div class=""header__box-card"">
            <img src=""/img/logo.png"" alt=""logo chatTogether"" class=""header__box-logo"">
            <div class=""header__box-btns"">
                <a");
            BeginWriteAttribute("href", " href=\"", 327, "\"", 362, 1);
#nullable restore
#line 11 "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
WriteAttributeValue("", 334, Url.Action("Login", "Home"), 334, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"header__box-btn header__box-login\">Logowanie</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 439, "\"", 481, 1);
#nullable restore
#line 12 "C:\Users\flx70\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
WriteAttributeValue("", 446, Url.Action("Registration", "Home"), 446, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""header__box-btn header__box-register"">Rejestracja</a>
            </div>
        </div>
    </div>
</div>







    <script type=""text/javascript"" src=""//code.jquery.com/jquery-1.11.0.min.js""></script>
    <script type=""text/javascript"" src=""//code.jquery.com/jquery-migrate-1.2.1.min.js""></script>
    <script type=""text/javascript"" src=""//cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick.min.js""></script>
    <script src=""js/slick.js""></script>
    <script src=""js/main.js""></script>");
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
