#pragma checksum "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Shared\Components\Comment\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ccf75d583d0513abc1e31d32c5ca5a4ed67ab18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Comment_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Comment/Default.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\_ViewImports.cshtml"
using Juan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ccf75d583d0513abc1e31d32c5ca5a4ed67ab18", @"/Views/Shared/Components/Comment/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb1030be5de95d240de52d5c4f3aad74a4c1400", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Comment_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Shared\Components\Comment\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"total-reviews\">\r\n        <div class=\"rev-avatar\">\r\n            <img src=\"assets/img/about/avatar.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 181, "\"", 187, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        </div>
        <div class=""review-box"">
            <div class=""ratings"">
                <span class=""good""><i class=""fa fa-star""></i></span>
                <span class=""good""><i class=""fa fa-star""></i></span>
                <span class=""good""><i class=""fa fa-star""></i></span>
                <span class=""good""><i class=""fa fa-star""></i></span>
                <span><i class=""fa fa-star""></i></span>
            </div>
            <div class=""post-author"">
                <p><span>");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Shared\Components\Comment\Default.cshtml"
                    Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -</span>");
#nullable restore
#line 18 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Shared\Components\Comment\Default.cshtml"
                                           Write(item.AddingTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <p>");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Shared\Components\Comment\Default.cshtml"
          Write(item.CommentDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Shared\Components\Comment\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
