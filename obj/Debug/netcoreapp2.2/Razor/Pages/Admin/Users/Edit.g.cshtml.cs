#pragma checksum "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9540e00bd694e8d37bcca62eec0cb3fe1267caaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Rejupo.Pages.Admin.Users.Pages_Admin_Users_Edit), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Users/Edit.cshtml", typeof(Rejupo.Pages.Admin.Users.Pages_Admin_Users_Edit), null)]
namespace Rejupo.Pages.Admin.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\_ViewImports.cshtml"
using Rejupo;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9540e00bd694e8d37bcca62eec0cb3fe1267caaf", @"/Pages/Admin/Users/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a2427429a31fe7622fa7a8e51438eb78f3747c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(92, 120, true);
            WriteLiteral("\r\n<h2>Autoryzacja</h2>\r\n\r\n<h4>Użytkownik</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        \r\n        ");
            EndContext();
            BeginContext(212, 2288, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9540e00bd694e8d37bcca62eec0cb3fe1267caaf4787", async() => {
                BeginContext(232, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(246, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9540e00bd694e8d37bcca62eec0cb3fe1267caaf5181", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 16 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RejupoUserID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(292, 84, true);
                WriteLiteral("\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(377, 56, false);
#line 19 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.RejupoUser.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(433, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(501, 52, false);
#line 22 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayFor(model => model.RejupoUser.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(553, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(621, 55, false);
#line 25 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.RejupoUser.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(676, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(744, 51, false);
#line 28 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayFor(model => model.RejupoUser.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(795, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(863, 55, false);
#line 31 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.RejupoUser.Division));

#line default
#line hidden
                EndContext();
                BeginContext(918, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(986, 51, false);
#line 34 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayFor(model => model.RejupoUser.Division));

#line default
#line hidden
                EndContext();
                BeginContext(1037, 69, true);
                WriteLiteral("\r\n                </dd>\r\n\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(1107, 52, false);
#line 38 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.RejupoUser.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1159, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(1227, 48, false);
#line 41 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayFor(model => model.RejupoUser.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1275, 69, true);
                WriteLiteral("\r\n                </dd>\r\n\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(1345, 58, false);
#line 45 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.RejupoUser.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(1403, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(1471, 54, false);
#line 48 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayFor(model => model.RejupoUser.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(1525, 147, true);
                WriteLiteral("\r\n                </dd>\r\n\r\n            </dl>\r\n            <br/>\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(1673, 54, false);
#line 55 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.Input.IsSuperAdmin));

#line default
#line hidden
                EndContext();
                BeginContext(1727, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(1795, 51, false);
#line 58 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.CheckBoxFor(model => model.Input.IsSuperAdmin));

#line default
#line hidden
                EndContext();
                BeginContext(1846, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(1914, 49, false);
#line 61 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.Input.IsAdmin));

#line default
#line hidden
                EndContext();
                BeginContext(1963, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(2031, 46, false);
#line 64 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.CheckBoxFor(model => model.Input.IsAdmin));

#line default
#line hidden
                EndContext();
                BeginContext(2077, 67, true);
                WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
                EndContext();
                BeginContext(2145, 48, false);
#line 67 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.DisplayNameFor(model => model.Input.IsUser));

#line default
#line hidden
                EndContext();
                BeginContext(2193, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(2261, 45, false);
#line 70 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Edit.cshtml"
               Write(Html.CheckBoxFor(model => model.Input.IsUser));

#line default
#line hidden
                EndContext();
                BeginContext(2306, 187, true);
                WriteLiteral("\r\n                </dd>\r\n            \r\n\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Zapisz\" class=\"btn btn-default\" />\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2500, 35, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2535, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9540e00bd694e8d37bcca62eec0cb3fe1267caaf15957", async() => {
                BeginContext(2557, 15, true);
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
            BeginContext(2576, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rejupo.Pages_Admin_Users.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rejupo.Pages_Admin_Users.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rejupo.Pages_Admin_Users.EditModel>)PageContext?.ViewData;
        public Rejupo.Pages_Admin_Users.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591