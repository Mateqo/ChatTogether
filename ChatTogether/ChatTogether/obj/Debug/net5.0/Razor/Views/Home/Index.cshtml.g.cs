#pragma checksum "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb1ea174df44f9a3afe2c81b8b95d271a9b0cf1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb1ea174df44f9a3afe2c81b8b95d271a9b0cf1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eb1ea174df44f9a3afe2c81b8b95d271a9b0cf13616", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"header\">\r\n    <div class=\"header__img\"></div>\r\n    <div class=\"header__box\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 173, "\"", 207, 1);
#nullable restore
#line 8 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
WriteAttributeValue("", 180, Url.Action("Main", "Home"), 180, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    \r\n            <img src=\"/img/logo.png\" alt=\"logo chatTogether\" class=\"header__box-logo\">\r\n    </a>\r\n            <div class=\"header__box-btns\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 377, "\"", 412, 1);
#nullable restore
#line 13 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
WriteAttributeValue("", 384, Url.Action("Login", "Home"), 384, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"header__box-btn header__box-login\">Logowanie</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 489, "\"", 531, 1);
#nullable restore
#line 14 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\ChatTogether\Views\Home\Index.cshtml"
WriteAttributeValue("", 496, Url.Action("Registration", "Home"), 496, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"header__box-btn header__box-register\">Rejestracja</a>\r\n");
            WriteLiteral(@"            </div>
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
