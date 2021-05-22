#pragma checksum "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\Shared\_AlertPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7fd378773c5c7d7b5c3f485d468900964a7b662"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AlertPanel), @"mvc.1.0.view", @"/Views/Shared/_AlertPanel.cshtml")]
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
#line 1 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\_ViewImports.cshtml"
using ChatTogether.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7fd378773c5c7d7b5c3f485d468900964a7b662", @"/Views/Shared/_AlertPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ea32190b369d64de46f753db5efb27fb9df60dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AlertPanel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\Shared\_AlertPanel.cshtml"
  
    string GetCss(ChatTogether.Application.ViewModels.Base.MessageType type)
    {
        switch (type)
        {
            case ChatTogether.Application.ViewModels.Base.MessageType.Success:
                return "alert-success";
            case ChatTogether.Application.ViewModels.Base.MessageType.Info:
                return "alert-info";
            case ChatTogether.Application.ViewModels.Base.MessageType.Warning:
                return "alert-warning";
            case ChatTogether.Application.ViewModels.Base.MessageType.Error:
                return "alert-danger";
            default:
                return String.Empty;
        };
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\Shared\_AlertPanel.cshtml"
 if (TempData["SM"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 723, "\"", 815, 2);
            WriteAttributeValue("", 731, "alert", 731, 5, true);
#nullable restore
#line 22 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\Shared\_AlertPanel.cshtml"
WriteAttributeValue(" ", 736, GetCss((ChatTogether.Application.ViewModels.Base.MessageType)TempData["SMT"]), 737, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        ");
#nullable restore
#line 23 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\Shared\_AlertPanel.cshtml"
   Write(TempData["SM"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 25 "C:\Users\adamchick3010\Source\Repos\ChatTogether\ChatTogether\Views\Shared\_AlertPanel.cshtml"
}

#line default
#line hidden
#nullable disable
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
