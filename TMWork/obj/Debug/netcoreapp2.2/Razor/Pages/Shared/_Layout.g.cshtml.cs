#pragma checksum "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0629fd1d8a55e2b348a312c778c61a91de0ad1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TMWork.Pages.Shared.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/_Layout.cshtml", typeof(TMWork.Pages.Shared.Pages_Shared__Layout))]
namespace TMWork.Pages.Shared
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using TMWork;

#line default
#line hidden
#line 2 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using TMWork.Data;

#line default
#line hidden
#line 3 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using TMWork.ViewModels;

#line default
#line hidden
#line 4 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#line 5 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 6 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 7 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http.Authentication;

#line default
#line hidden
#line 8 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 10 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using TMWork.GoogleReCaptcha.Web.Validation;

#line default
#line hidden
#line 13 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using TMWork.Data.Core.Domain;

#line default
#line hidden
#line 17 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0629fd1d8a55e2b348a312c778c61a91de0ad1f", @"/Pages/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28e6fa003f70828dc5c2e2de3130aa3cf86279d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-href", "~/lib/bootstrap/dist/css/bootstrap.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-class", "sr-only", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-property", "position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-value", "absolute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString("sha256-eSi1q2PG6J7g7ib17yAaWMcrr5GrtohYChqibrV7PBE="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/busyload/busyloader.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-src", "~/lib/bootstrap/dist/js/bootstrap.bundle.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test", "window.jQuery && window.jQuery.fn && window.jQuery.fn.modal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString("sha256-E/V4cWE4qvAeO5MOhjtGtqDzPndRO1LBk8lJ/PR7CA4="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/busyload/busyloader.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 3605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f10223", async() => {
                BeginContext(31, 121, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
                EndContext();
                BeginContext(153, 17, false);
#line 6 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(170, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(174, 52, false);
#line 6 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                           Write(configuration.GetSection("SiteSettings")["SiteName"]);

#line default
#line hidden
                EndContext();
                BeginContext(226, 18, true);
                WriteLiteral("</title>\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(244, 471, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f11478", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                WriteLiteral("https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/");
#line 9 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                                                                              WriteLiteral(configuration.GetSection("VersionSettings")["bootstrap"]);

#line default
#line hidden
                WriteLiteral("/css/bootstrap.min.css");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("href", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackHref = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestClass = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestProperty = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestValue = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(715, 30, true);
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 745, "\"", 872, 3);
                WriteAttributeValue("", 752, "https://kendo.cdn.telerik.com/", 752, 30, true);
#line 15 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 782, configuration.GetSection("VersionSettings")["kendo"], 782, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 835, "/styles/kendo.common-material.min.css", 835, 37, true);
                EndWriteAttribute();
                BeginContext(873, 31, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 904, "\"", 1026, 3);
                WriteAttributeValue("", 911, "https://kendo.cdn.telerik.com/", 911, 30, true);
#line 16 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 941, configuration.GetSection("VersionSettings")["kendo"], 941, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 994, "/styles/kendo.mobile.all.min.css", 994, 32, true);
                EndWriteAttribute();
                BeginContext(1027, 31, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1058, "\"", 1178, 3);
                WriteAttributeValue("", 1065, "https://kendo.cdn.telerik.com/", 1065, 30, true);
#line 17 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 1095, configuration.GetSection("VersionSettings")["kendo"], 1095, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 1148, "/styles/kendo.material.min.css", 1148, 30, true);
                EndWriteAttribute();
                BeginContext(1179, 9, true);
                WriteLiteral(" />\r\n    ");
                EndContext();
                BeginContext(1188, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f16599", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1254, 13, true);
                WriteLiteral("\r\n\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1267, "\"", 1382, 3);
                WriteAttributeValue("", 1274, "https://use.fontawesome.com/releases/", 1274, 37, true);
#line 20 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 1311, configuration.GetSection("VersionSettings")["fontawesome"], 1311, 59, false);

#line default
#line hidden
                WriteAttributeValue("", 1370, "/css/all.css", 1370, 12, true);
                EndWriteAttribute();
                BeginContext(1383, 356, true);
                WriteLiteral(@" integrity=""sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/"" crossorigin=""anonymous"" rel=""stylesheet"">


    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/css/alertify.min.css"" />
    <link rel=""stylesheet"" href=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/css/themes/default.min.css"" />

    ");
                EndContext();
                BeginContext(1739, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f18948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1786, 123, true);
                WriteLiteral("\r\n\r\n    <script src=\"https://www.google.com/recaptcha/api.js?onload=renderRecaptcha&render=explicit\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1909, "\"", 2015, 3);
                WriteAttributeValue("", 1915, "https://kendo.cdn.telerik.com/", 1915, 30, true);
#line 29 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 1945, configuration.GetSection("VersionSettings")["kendo"], 1945, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 1998, "/js/jquery.min.js", 1998, 17, true);
                EndWriteAttribute();
                BeginContext(2016, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
                BeginContext(2426, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2430, 458, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f21161", async() => {
                    BeginContext(2873, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/");
#line 36 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                                                              WriteLiteral(configuration.GetSection("VersionSettings")["bootstrap"]);

#line default
#line hidden
                WriteLiteral("/js/bootstrap.bundle.min.js");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackSrc = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.FallbackTestExpression = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2888, 113, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/4.4.0/bootbox.min.js\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3001, "\"", 3106, 3);
                WriteAttributeValue("", 3007, "https://kendo.cdn.telerik.com/", 3007, 30, true);
#line 43 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 3037, configuration.GetSection("VersionSettings")["kendo"], 3037, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 3090, "/js/jszip.min.js", 3090, 16, true);
                EndWriteAttribute();
                BeginContext(3107, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3130, "\"", 3239, 3);
                WriteAttributeValue("", 3136, "https://kendo.cdn.telerik.com/", 3136, 30, true);
#line 44 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 3166, configuration.GetSection("VersionSettings")["kendo"], 3166, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 3219, "/js/kendo.all.min.js", 3219, 20, true);
                EndWriteAttribute();
                BeginContext(3240, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3263, "\"", 3378, 3);
                WriteAttributeValue("", 3269, "https://kendo.cdn.telerik.com/", 3269, 30, true);
#line 45 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 3299, configuration.GetSection("VersionSettings")["kendo"], 3299, 53, false);

#line default
#line hidden
                WriteAttributeValue("", 3352, "/js/kendo.aspnetmvc.min.js", 3352, 26, true);
                EndWriteAttribute();
                BeginContext(3379, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
                BeginContext(3395, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f25948", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3451, 106, true);
                WriteLiteral("\r\n\r\n    <script src=\"//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js\"></script>\r\n\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(3557, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f27319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
#line 52 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3619, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3630, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3632, 1847, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0629fd1d8a55e2b348a312c778c61a91de0ad1f30185", async() => {
                BeginContext(3648, 158, true);
                WriteLiteral("\r\n    <nav class=\"navbar navbar-expand-sm bg-dark navbar-dark fixed-top\">\r\n        <div class=\"container\">\r\n            <a href=\"/Index\" class=\"navbar-brand\">");
                EndContext();
                BeginContext(3807, 52, false);
#line 58 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                                             Write(configuration.GetSection("SiteSettings")["SiteName"]);

#line default
#line hidden
                EndContext();
                BeginContext(3859, 3, true);
                WriteLiteral(" | ");
                EndContext();
                BeginContext(3863, 57, false);
#line 58 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                                                                                                     Write(configuration.GetSection("ContactInfoSettintgs")["Phone"]);

#line default
#line hidden
                EndContext();
                BeginContext(3920, 764, true);
                WriteLiteral(@"</a>
            <button class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarCollapse"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item"">
                        <a href=""#home"" class=""nav-link"">Home</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#our-office-head-section"" class=""nav-link"">Our Office</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""#our-team-head-section"" class=""nav-link"">Our Team</a>
                    </li>
");
                EndContext();
                BeginContext(4848, 67, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        ");
                EndContext();
                BeginContext(4916, 40, false);
#line 77 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                   Write(await Html.PartialAsync("_LoginPartial"));

#line default
#line hidden
                EndContext();
                BeginContext(4956, 109, true);
                WriteLiteral("\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    <div>");
                EndContext();
                BeginContext(5066, 12, false);
#line 83 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
    Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5078, 121, true);
                WriteLiteral("</div>\r\n\r\n\r\n    <footer class=\"border-top footer py-3 text-muted\">\r\n        <div class=\"container \">\r\n            &copy; ");
                EndContext();
                BeginContext(5200, 17, false);
#line 88 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
              Write(DateTime.Now.Year);

#line default
#line hidden
                EndContext();
                BeginContext(5217, 28, true);
                WriteLiteral(" <a target=\"_blank\" href=\"/\"");
                EndContext();
                BeginWriteAttribute("title", " title=\"", 5245, "\"", 5306, 1);
#line 88 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
WriteAttributeValue("", 5253, configuration.GetSection("SiteSettings")["SiteName"], 5253, 53, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5307, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5309, 54, false);
#line 88 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
                                                                                                                           Write(configuration.GetSection("SiteSettings")["SiteDomain"]);

#line default
#line hidden
                EndContext();
                BeginContext(5363, 65, true);
                WriteLiteral("</a>. All Rights Reserved.\r\n        </div>\r\n    </footer>\r\n\r\n    ");
                EndContext();
                BeginContext(5429, 41, false);
#line 92 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(5470, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5479, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public TMWork.Data.Core.IUnitOfWork _unitOfWork { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; }
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
