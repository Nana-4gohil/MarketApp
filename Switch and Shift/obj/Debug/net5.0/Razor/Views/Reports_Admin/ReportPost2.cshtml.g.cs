#pragma checksum "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "edd23ba38f60c9eb2586b074b6875e5d24c634ead5d0dc1e8be73565c8e0ddad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_Admin_ReportPost2), @"mvc.1.0.view", @"/Views/Reports_Admin/ReportPost2.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\_ViewImports.cshtml"
using Switch_and_Shift

#nullable disable
    ;
#nullable restore
#line 2 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\_ViewImports.cshtml"
using Switch_and_Shift.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"edd23ba38f60c9eb2586b074b6875e5d24c634ead5d0dc1e8be73565c8e0ddad", @"/Views/Reports_Admin/ReportPost2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"eeb6432898813bdb323f18361b7eb5a1e7fccc221ac2d7daaacbe60d970701ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reports_Admin_ReportPost2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Switch_and_Shift.Models.Reports_Admin>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/website_images/box.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my_image_class"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width: 80%;display: block; margin-left: auto; margin-right:\r\n    auto; width: 25%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("img2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px; width:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/website_images/complain.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layouts/_AdminLayout.cshtml";
    int checkIfEmpty = Model.Count();

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n    <h1>REPORTED USER LIST</h1>\r\n\r\n");
#nullable restore
#line 12 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
     if (checkIfEmpty == 0)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        <h1 style=""text-align: center; color:#6406B2;margin-top: 5%;
font-family: Saira Semi Condensed, sans-serif; font-weight: bold; margin-bottom: 5%;"">
            NO DATA
        </h1>
        <div class=""banner-image image-container"" style=""background-color: #F2F2F2;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "edd23ba38f60c9eb2586b074b6875e5d24c634ead5d0dc1e8be73565c8e0ddad6831", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n");
#nullable restore
#line 23 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n");
#nullable restore
#line 26 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        <div class=""section2-product-details"" style=""margin: 70px; margin-left: 10%; margin-right: 10%"">
            <div class=""container"">

                <div class=""row"">

                    <div class=""col-lg-5 col-md-5 col-sm-12 col-xs-12"">

                        <div class=""card mb-3"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-5"">
                                        <h5 class=""mb-0 seller_name"">Reporter Name :</h5>
                                    </div>
                                    <div class=""col-sm-7 text-secondary"">");
            Write(
#nullable restore
#line 41 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
                                                                          Html.DisplayFor(model => item.reporter_name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-sm-5"">
                                        <h5 class=""mb-0 seller_email"">Reporter Email :</h5>
                                    </div>
                                    <div class=""col-sm-7 text-secondary"">");
            Write(
#nullable restore
#line 48 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
                                                                          Html.DisplayFor(model => item.reporter_email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                                </div>
                            </div>
                        </div>

                    </div>
                    <div class=""col-lg-2 col-md-2 col-sm-12 col-xs-12"">
                        <div class=""box2 box2-modified"" style=""margin-top:5%"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edd23ba38f60c9eb2586b074b6875e5d24c634ead5d0dc1e8be73565c8e0ddad10779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                    </div>

                    <div class=""col-lg-5 col-md-5 col-sm-12 col-xs-12"">


                        <div class=""card mb-3"">
                            <div class=""card-body"">
                                <div class=""row"">
                                    <div class=""col-sm-5"">
                                        <h5 class=""mb-0 seller_name"">Reportee Name :</h5>
                                    </div>
                                    <div class=""col-sm-7 text-secondary"">");
            Write(
#nullable restore
#line 69 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
                                                                          Html.DisplayFor(model => item.reportee_name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-sm-5"">
                                        <h5 class=""mb-0 seller_email"">Reportee Email :</h5>
                                    </div>
                                    <div class=""col-sm-7 text-secondary"">");
            Write(
#nullable restore
#line 76 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
                                                                          Html.DisplayFor(model => item.reportee_email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n               \r\n\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 88 "D:\Switch-and-Swift-Market-App\Switch and Shift\Views\Reports_Admin\ReportPost2.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"


    <!-- jQuery -->
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""></script>


























");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Switch_and_Shift.Models.Reports_Admin>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
