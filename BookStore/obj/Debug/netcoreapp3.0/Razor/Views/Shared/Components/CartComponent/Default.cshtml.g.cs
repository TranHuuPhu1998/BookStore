#pragma checksum "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\CartComponent\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cf8dc60a1440176dea4ede4d6453a2ad94989a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CartComponent_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CartComponent/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cf8dc60a1440176dea4ede4d6453a2ad94989a4", @"/Views/Shared/Components/CartComponent/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CartComponent_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<BookStore.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/products/cart-product-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div>\r\n");
#nullable restore
#line 3 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\CartComponent\Default.cshtml"
     foreach(
        Book book in Model
    ){

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"single-cart-block \">\r\n        <div class=\"cart-product\">\r\n            <a href=\"product-details.html\" class=\"image\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4cf8dc60a1440176dea4ede4d6453a2ad94989a44350", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </a>\r\n            <div class=\"content\">\r\n                <h3 class=\"title\">\r\n                    <a href=\"product-details.html\">\r\n                        ");
#nullable restore
#line 13 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\CartComponent\Default.cshtml"
                   Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                </h3>\r\n                <p class=\"price\"><span class=\"qty\"></span> $");
#nullable restore
#line 16 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\CartComponent\Default.cshtml"
                                                       Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <button class=\"cross-btn\"><i class=\"fas fa-times\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 720, "\"", 771, 1);
#nullable restore
#line 18 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\CartComponent\Default.cshtml"
WriteAttributeValue("", 727, Url.Action(" RemoveProduct", new {book.Id}), 727, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                    </i></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 23 "E:\DOT_NET_CORE\DotNetMVC\BookStore\Views\Shared\Components\CartComponent\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<BookStore.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591