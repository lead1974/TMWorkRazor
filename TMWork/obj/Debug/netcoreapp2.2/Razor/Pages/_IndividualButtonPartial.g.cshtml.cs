#pragma checksum "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_IndividualButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "979d9612649c660fc42c7e94523e19b60aac6982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TMWork.Pages.Pages__IndividualButtonPartial), @"mvc.1.0.view", @"/Pages/_IndividualButtonPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_IndividualButtonPartial.cshtml", typeof(TMWork.Pages.Pages__IndividualButtonPartial))]
namespace TMWork.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"979d9612649c660fc42c7e94523e19b60aac6982", @"/Pages/_IndividualButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28e6fa003f70828dc5c2e2de3130aa3cf86279d", @"/Pages/_ViewImports.cshtml")]
    public class Pages__IndividualButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TMWork.Data.Core.Domain.IndividualButtonPartial>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("busyLoadShow()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "979d9612649c660fc42c7e94523e19b60aac69824839", async() => {
                BeginContext(225, 11, true);
                WriteLiteral("\r\n    <span");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 236, "\"", 262, 3);
                WriteAttributeValue("", 244, "fa", 244, 2, true);
                WriteAttributeValue(" ", 246, "fa-", 247, 4, true);
#line 6 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_IndividualButtonPartial.cshtml"
WriteAttributeValue("", 250, Model.Glyph, 250, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(263, 10, true);
                WriteLiteral("></span>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 74, "btn", 74, 3, true);
#line 4 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_IndividualButtonPartial.cshtml"
AddHtmlAttributeValue(" ", 77, Model.ButtonType, 78, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 4 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_IndividualButtonPartial.cshtml"
                               WriteLiteral(Model.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 5 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_IndividualButtonPartial.cshtml"
     WriteLiteral(Model.ActionParameters);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 5 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\_IndividualButtonPartial.cshtml"
                                                  WriteLiteral(Model.pagetype);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pagetype"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pagetype", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pagetype"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TMWork.Data.Core.Domain.IndividualButtonPartial> Html { get; private set; }
    }
}
#pragma warning restore 1591