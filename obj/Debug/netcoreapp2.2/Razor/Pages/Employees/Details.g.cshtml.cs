#pragma checksum "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac34ad66e71a11d8eb65289c0c9ee35320427c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Rejupo.Pages.Employees.Pages_Employees_Details), @"mvc.1.0.razor-page", @"/Pages/Employees/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Details.cshtml", typeof(Rejupo.Pages.Employees.Pages_Employees_Details), null)]
namespace Rejupo.Pages.Employees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\milos\Documents\code\Rejupo\Pages\_ViewImports.cshtml"
using Rejupo;

#line default
#line hidden
#line 2 "C:\Users\milos\Documents\code\Rejupo\Pages\_ViewImports.cshtml"
using Rejupo.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac34ad66e71a11d8eb65289c0c9ee35320427c59", @"/Pages/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6c9905a4f102961316fd003446141d2a474ac2a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Documents/AuthToProcesPers/Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 48, true);
            WriteLiteral("\n<h2>Informacje szczegółowe</h2>\n\n<div>\n    <h4>");
            EndContext();
            BeginContext(139, 24, false);
#line 11 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
   Write(Model.Employee.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(163, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(165, 23, false);
#line 11 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
                             Write(Model.Employee.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(188, 15, true);
            WriteLiteral(", nr konrolny: ");
            EndContext();
            BeginContext(204, 28, false);
#line 11 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
                                                                    Write(Model.Employee.ControlNumber);

#line default
#line hidden
            EndContext();
            BeginContext(232, 73, true);
            WriteLiteral("</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(306, 53, false);
#line 15 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Division));

#line default
#line hidden
            EndContext();
            BeginContext(359, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(400, 49, false);
#line 18 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Division));

#line default
#line hidden
            EndContext();
            BeginContext(449, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(490, 54, false);
#line 21 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(544, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(585, 50, false);
#line 24 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(635, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(676, 53, false);
#line 27 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(729, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(770, 49, false);
#line 30 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(819, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(860, 54, false);
#line 33 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Pos_title));

#line default
#line hidden
            EndContext();
            BeginContext(914, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(955, 50, false);
#line 36 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Pos_title));

#line default
#line hidden
            EndContext();
            BeginContext(1005, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1046, 50, false);
#line 39 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1096, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1137, 46, false);
#line 42 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1224, 56, false);
#line 45 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1321, 52, false);
#line 48 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1414, 53, false);
#line 51 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1467, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1508, 49, false);
#line 54 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.IsActive));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 77, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<hr/>\n<div>\n    <h4>Dokumenty powiązane</h4>\n");
            EndContext();
#line 61 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
     if(@Model.DocumentBase == null)
    {

#line default
#line hidden
            BeginContext(1677, 79, true);
            WriteLiteral("        <p class=\"text-danger\">Brak upoważnienia do przetwarzania.</p>\n        ");
            EndContext();
            BeginContext(1756, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac34ad66e71a11d8eb65289c0c9ee35320427c5911452", async() => {
                BeginContext(1850, 18, true);
                WriteLiteral("Dodaj upoważnienie");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
                                                           WriteLiteral(Model.Employee.ControlNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1872, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 65 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
    }
    else{

#line default
#line hidden
            BeginContext(1889, 77, true);
            WriteLiteral("        <p>Upoważnienie do przetwarzania danych</p>\n        <dt>\n            ");
            EndContext();
            BeginContext(1967, 51, false);
#line 69 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DocumentBase.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2059, 47, false);
#line 72 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.DocumentBase.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2106, 15, true);
            WriteLiteral("\n        </dd>\n");
            EndContext();
#line 74 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2127, 37, true);
            WriteLiteral("    <br/>\n    <hr/>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(2164, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac34ad66e71a11d8eb65289c0c9ee35320427c5915143", async() => {
                BeginContext(2230, 5, true);
                WriteLiteral("Zmień");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\milos\Documents\code\Rejupo\Pages\Employees\Details.cshtml"
                           WriteLiteral(Model.Employee.ControlNumber);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2239, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(2246, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac34ad66e71a11d8eb65289c0c9ee35320427c5917470", async() => {
                BeginContext(2268, 15, true);
                WriteLiteral("Powrót do listy");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2287, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rejupo.Pages_Employees.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rejupo.Pages_Employees.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rejupo.Pages_Employees.DetailsModel>)PageContext?.ViewData;
        public Rejupo.Pages_Employees.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
