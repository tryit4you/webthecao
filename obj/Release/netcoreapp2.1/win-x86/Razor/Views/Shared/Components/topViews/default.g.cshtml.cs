#pragma checksum "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d69f4fd21555108edc11fe14977d41061c8fede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_topViews_default), @"mvc.1.0.view", @"/Views/Shared/Components/topViews/default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/topViews/default.cshtml", typeof(AspNetCore.Views_Shared_Components_topViews_default))]
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
#line 1 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\_ViewImports.cshtml"
using WebTheCao;

#line default
#line hidden
#line 2 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#line 3 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\_ViewImports.cshtml"
using WebTheCao.Data.Models;

#line default
#line hidden
#line 4 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\_ViewImports.cshtml"
using WebTheCao.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d69f4fd21555108edc11fe14977d41061c8fede", @"/Views/Shared/Components/topViews/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be7b95835a93f517da478f2d45900646913a45c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_topViews_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 154, true);
            WriteLiteral("<strong class=\"light-blue-text\">Bài viết được xem nhiều</strong>\r\n<hr />\r\n<ul class=\"collection\" style=\"border: none;border-bottom: 1px solid #e0e0e0;\">\r\n");
            EndContext();
#line 4 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
     foreach (var post in Model)
    {
        var url = "/khuyen-mai/" + post.MetaName + "/" + post.Id;

#line default
#line hidden
            BeginContext(262, 93, true);
            WriteLiteral("        <li class=\"collection-item avatar topview\" style=\"min-height:58px\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 355, "\"", 373, 1);
#line 8 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
WriteAttributeValue("", 361, post.Avatar, 361, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 374, "\"", 390, 1);
#line 8 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
WriteAttributeValue("", 380, post.Name, 380, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(391, 32, true);
            WriteLiteral(" class=\"circle\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 423, "\"", 434, 1);
#line 9 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
WriteAttributeValue("", 430, url, 430, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 435, "\"", 453, 1);
#line 9 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
WriteAttributeValue("", 443, post.Name, 443, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(454, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(456, 9, false);
#line 9 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
                                         Write(post.Name);

#line default
#line hidden
            EndContext();
            BeginContext(465, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 11 "D:\IDE-VisualStudio\WebTheCao\WebTheCao\Views\Shared\Components\topViews\default.cshtml"
    }

#line default
#line hidden
            BeginContext(493, 5, true);
            WriteLiteral("</ul>");
            EndContext();
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