#pragma checksum "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c25d14172e0647e379129b45ae5e6b970cb9be02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StoreFront_Index), @"mvc.1.0.view", @"/Views/StoreFront/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StoreFront/Index.cshtml", typeof(AspNetCore.Views_StoreFront_Index))]
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
#line 1 "C:\dev\StoreFront\StoreFront\StoreFront\Views\_ViewImports.cshtml"
using StoreFront;

#line default
#line hidden
#line 2 "C:\dev\StoreFront\StoreFront\StoreFront\Views\_ViewImports.cshtml"
using StoreFront.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c25d14172e0647e379129b45ae5e6b970cb9be02", @"/Views/StoreFront/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b69af709270e91d24f70fedcc324573d65d2a20", @"/Views/_ViewImports.cshtml")]
    public class Views_StoreFront_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreFront.ViewModels.StoreFrontData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/StoreFront.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Custom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "250a07f821b64f169d8eda0462640df3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 8 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(171, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(173, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d428ddda96409ea86d0a52e0dd2e7c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(234, 19, true);
            WriteLiteral("\r\n\r\n<h1>Welcome to ");
            EndContext();
            BeginContext(254, 23, false);
#line 11 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
          Write(Model.MyStore.StoreName);

#line default
#line hidden
            EndContext();
            BeginContext(277, 197, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>New Releases</h1>\r\n        </div>\r\n    </div>\r\n    <div id=\"ProductReleased\" class=\"row\">\r\n");
            EndContext();
#line 20 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
         foreach (var product in Model.MyProducts)
        {
            

#line default
#line hidden
#line 22 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
             if (product.myProduct.ReleaseDate <= Model.CurrentDate)
            {

#line default
#line hidden
            BeginContext(622, 331, true);
            WriteLiteral(@"                <div class=""col-lg-6"">
                    <div class=""container-fluid productFrame"">
                        <div class=""row"">
                            <div class=""col-lg-5"">
                                <div class=""imageProductContainer"">
                                    <img class=""img-responsive""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 953, "\"", 986, 1);
#line 29 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
WriteAttributeValue("", 959, product.myProduct.ImageURL, 959, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(987, 325, true);
            WriteLiteral(@" />
                                </div>
                            </div>
                            <div class=""col-lg-7 centerText"">
                                <div class=""container-fluid"">
                                    <div class=""row"">
                                        <h3 class=""headerItem"">");
            EndContext();
            BeginContext(1313, 23, false);
#line 35 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                                          Write(product.myProduct.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1336, 46, true);
            WriteLiteral("</h3> <h5 class=\"headerItem productPublisher\">");
            EndContext();
            BeginContext(1383, 33, false);
#line 35 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                                                                                                                Write(product.myPublisher.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 149, true);
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <div class=\"row\">\r\n                                        <p>");
            EndContext();
            BeginContext(1566, 29, false);
#line 38 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                      Write(product.myProduct.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 374, true);
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-5""></div>
                            <div class=""col-lg-7"">
                                <button class=""btn btn-success""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1969, "\"", 2023, 3);
            WriteAttributeValue("", 1979, "CreatePurchase(\'", 1979, 16, true);
#line 46 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
WriteAttributeValue("", 1995, product.myProduct.Title, 1995, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 2021, "\')", 2021, 2, true);
            EndWriteAttribute();
            BeginContext(2024, 140, true);
            WriteLiteral(">Buy Now!</button>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 51 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
            }

#line default
#line hidden
#line 51 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2190, 177, true);
            WriteLiteral("    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <h1>Coming Soon</h1>\r\n        </div>\r\n    </div>\r\n    <div id=\"ProductsComingSoon\" class=\"row\">\r\n");
            EndContext();
#line 60 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
         foreach (var product in Model.MyProducts)
        {
            

#line default
#line hidden
#line 62 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
             if (product.myProduct.ReleaseDate > Model.CurrentDate)
            {

#line default
#line hidden
            BeginContext(2514, 331, true);
            WriteLiteral(@"                <div class=""col-lg-6"">
                    <div class=""container-fluid productFrame"">
                        <div class=""row"">
                            <div class=""col-lg-5"">
                                <div class=""imageProductContainer"">
                                    <img class=""img-responsive""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2845, "\"", 2878, 1);
#line 69 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
WriteAttributeValue("", 2851, product.myProduct.ImageURL, 2851, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2879, 325, true);
            WriteLiteral(@" />
                                </div>
                            </div>
                            <div class=""col-lg-7 centerText"">
                                <div class=""container-fluid"">
                                    <div class=""row"">
                                        <h3 class=""headerItem"">");
            EndContext();
            BeginContext(3205, 23, false);
#line 75 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                                          Write(product.myProduct.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3228, 46, true);
            WriteLiteral("</h3> <h5 class=\"headerItem productPublisher\">");
            EndContext();
            BeginContext(3275, 33, false);
#line 75 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                                                                                                                Write(product.myPublisher.PublisherName);

#line default
#line hidden
            EndContext();
            BeginContext(3308, 149, true);
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <div class=\"row\">\r\n                                        <p>");
            EndContext();
            BeginContext(3458, 29, false);
#line 78 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                      Write(product.myProduct.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3487, 393, true);
            WriteLiteral(@"</p>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-5"">

                            </div>
                            <div class=""col-lg-7"">
                                <h4>Release Date: ");
            EndContext();
            BeginContext(3881, 33, false);
#line 88 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                             Write(product.myProduct.ReleaseDate.Day);

#line default
#line hidden
            EndContext();
            BeginContext(3914, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(3916, 35, false);
#line 88 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                                                                Write(product.myProduct.ReleaseDate.Month);

#line default
#line hidden
            EndContext();
            BeginContext(3951, 1, true);
            WriteLiteral("-");
            EndContext();
            BeginContext(3953, 34, false);
#line 88 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
                                                                                                                     Write(product.myProduct.ReleaseDate.Year);

#line default
#line hidden
            EndContext();
            BeginContext(3987, 127, true);
            WriteLiteral("</h4>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 93 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
            }

#line default
#line hidden
#line 93 "C:\dev\StoreFront\StoreFront\StoreFront\Views\StoreFront\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(4140, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreFront.ViewModels.StoreFrontData> Html { get; private set; }
    }
}
#pragma warning restore 1591
