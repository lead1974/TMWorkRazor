#pragma checksum "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\EditorTemplates\EmailAddress.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb68265b784159313443a794b12f043ad9c33712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TMWork.Pages.Shared.EditorTemplates.Pages_Shared_EditorTemplates_EmailAddress), @"mvc.1.0.view", @"/Pages/Shared/EditorTemplates/EmailAddress.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/EditorTemplates/EmailAddress.cshtml", typeof(TMWork.Pages.Shared.EditorTemplates.Pages_Shared_EditorTemplates_EmailAddress))]
namespace TMWork.Pages.Shared.EditorTemplates
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb68265b784159313443a794b12f043ad9c33712", @"/Pages/Shared/EditorTemplates/EmailAddress.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f28e6fa003f70828dc5c2e2de3130aa3cf86279d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_EditorTemplates_EmailAddress : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(17, 72, false);
#line 3 "C:\Andrey\WebApps\TMWorkRazor\TMWork\Pages\Shared\EditorTemplates\EmailAddress.cshtml"
Write(Html.TextBoxFor(model => model, new {@class="k-textbox", type="email" }));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
