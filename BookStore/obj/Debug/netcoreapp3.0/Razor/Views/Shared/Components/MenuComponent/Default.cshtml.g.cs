#pragma checksum "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24b6960fb7ad257172d125e26ca4a2b1b65aa59c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MenuComponent/Default.cshtml")]
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
#line 1 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24b6960fb7ad257172d125e26ca4a2b1b65aa59c", @"/Views/Shared/Components/MenuComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<BookStore.Models.Menu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"main-navigation flex-lg-right\">\r\n        <ul class=\"main-menu menu-right li-last-0\">\r\n");
#nullable restore
#line 6 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
             foreach (Menu menu in Model.Where(m => m.ParentId == 0))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 274, "\"", 365, 2);
            WriteAttributeValue("", 282, "menu-item", 282, 9, true);
#nullable restore
#line 8 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
WriteAttributeValue(" ", 291, menu.ChildMenus != null && menu.ChildMenus.Count > 0?"has-children":"", 292, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a href=\"javascript:void(0)\">\r\n                        ");
#nullable restore
#line 10 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                   Write(menu.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 11 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                         if (menu.ChildMenus != null && menu.ChildMenus.Count > 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fas fa-chevron-down dropdown-arrow\"></i>\r\n");
#nullable restore
#line 14 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </a>\r\n");
#nullable restore
#line 16 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                     if (menu.ChildMenus != null && menu.ChildMenus.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul class=\"sub-menu\">\r\n");
#nullable restore
#line 19 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                             foreach (Menu sub in menu.ChildMenus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li> <a href=\"#\">");
#nullable restore
#line 21 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                                            Write(sub.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 22 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n");
#nullable restore
#line 24 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 26 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\MenuComponent\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<BookStore.Models.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
