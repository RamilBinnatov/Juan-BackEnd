#pragma checksum "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "289f5d1e049703418fa9fe1e20f3b96078937034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"289f5d1e049703418fa9fe1e20f3b96078937034", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec375141e8725e18c046d7a8821e4f60111ffe5", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketDetailVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" d-block d-md-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";

    decimal endTotal = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Cart</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Cart</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-main-wrapper section-padding"">
        <div class=""container"">
            <div class=""section-bg-color"">
                <div class=""row"">
                    <div class=""col-lg-12"">
          ");
            WriteLiteral(@"              <div class=""cart-table table-responsive"">
                            <table class=""table table-bordered"">
                                <thead>
                                    <tr>
                                        <th class=""pro-thumbnail"">Thumbnail</th>
                                        <th class=""pro-title"">Product</th>
                                        <th class=""pro-price"">Price</th>
                                        <th class=""pro-quantity"">Quantity</th>
                                        <th class=""pro-subtotal"">Total</th>
                                        <th class=""pro-remove"">Remove</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 45 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td class=\"pro-thumbnail\"><a href=\"#\"><img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 2177, "\"", 2213, 2);
            WriteAttributeValue("", 2183, "assets/img/product/", 2183, 19, true);
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
WriteAttributeValue("", 2202, item.Image, 2202, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Product\" /></a></td>\r\n                                            <td class=\"pro-title\"><a href=\"#\">");
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
                                                                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                            <td class=\"pro-price\"><span>$ ");
#nullable restore
#line 50 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
                                                                      Write((item.Price-((item.Price/100)*item.Discount)).ToString("##.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></td>
                                            <td class=""pro-quantity"">
                                                <div class=""pro-qty""><input type=""text"" value=""1""></div>
                                            </td>
                                            <td class=""pro-subtotal""><span>$");
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
                                                                       Write(item.Total.ToString("0.#####"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td class=\"pro-remove\"><a href=\"#\"><i class=\"fa fa-trash-o\"></i></a></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
                                        endTotal += item.Total;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                        <div class=""cart-update-option d-block d-md-flex justify-content-between"">
                            <div class=""apply-coupon-wrapper"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "289f5d1e049703418fa9fe1e20f3b960789370349620", async() => {
                WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Enter Your Coupon Code\" required />\r\n                                    <button class=\"btn\">Apply Coupon</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""cart-update"">
                                <a href=""#"" class=""btn"">Update Cart</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-5 ml-auto"">
                        <!-- Cart Calculation Area -->
                        <div class=""cart-calculator-wrapper"">
                            <div class=""cart-calculate-items"">
                                <h3>Cart Totals</h3>
                                <div class=""table-responsive"">
                                    <table class=""table"">
                                        <tr>
                                            <td>Total</td>
                                            <td>$ ");
#nullable restore
#line 85 "C:\Users\ASUS\Desktop\Juan-BackEnd\Juan\Juan\Views\Basket\Index.cshtml"
                                             Write(endTotal.ToString("0.#####"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <a href=""checkout.html"" class=""btn d-block"">Proceed Checkout</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
