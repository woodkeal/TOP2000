#pragma checksum "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd5e3558c7c9e9a7e53d84df5fd388a0eccd5274"
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
#line 1 "C:\TOP2000\TOP2000\TOP2000UI\Views\_ViewImports.cshtml"
using TOP2000UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\TOP2000\TOP2000\TOP2000UI\Views\_ViewImports.cshtml"
using TOP2000UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd5e3558c7c9e9a7e53d84df5fd388a0eccd5274", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5617acac5264267667bdc0710e76fbef5cac25", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TOP2000UI.ViewModels.Top2000ViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
Write(Html.DisplayFor(modelItem => Model.First().ListYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"list-display\">\r\n");
            WriteLiteral("\r\n    <ul>\r\n");
#nullable restore
#line 29 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"list-item position\">\r\n                    ");
#nullable restore
#line 33 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-item title\">\r\n                    ");
#nullable restore
#line 36 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-item artist-name\">\r\n                    ");
#nullable restore
#line 39 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ArtistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"list-item year\">\r\n                    ");
#nullable restore
#line 42 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </li>\r\n");
#nullable restore
#line 45 "C:\TOP2000\TOP2000\TOP2000UI\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TOP2000UI.ViewModels.Top2000ViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
