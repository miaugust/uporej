#pragma checksum "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380d2f81128bfb72a1905524813a3efca03d2520"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Rejupo.Data.Pages_Admin_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Users/Index.cshtml", typeof(Rejupo.Data.Pages_Admin_Users_Index), null)]
namespace Rejupo.Data
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
#line 2 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\_ViewImports.cshtml"
using Rejupo.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380d2f81128bfb72a1905524813a3efca03d2520", @"/Pages/Admin/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64bc609ce419053e7dbc2ff21b56745434fa533", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(118, 119, true);
            WriteLiteral("\r\n<h2>Lista Użytkowników</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(238, 59, false);
#line 16 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RejupoUser[0].FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 58, false);
#line 19 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RejupoUser[0].LastName));

#line default
#line hidden
            EndContext();
            BeginContext(411, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(467, 58, false);
#line 22 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RejupoUser[0].Division));

#line default
#line hidden
            EndContext();
            BeginContext(525, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(583, 55, false);
#line 26 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RejupoUser[0].Email));

#line default
#line hidden
            EndContext();
            BeginContext(638, 69, true);
            WriteLiteral("\r\n            </th>\r\n            \r\n            <th>\r\n                ");
            EndContext();
            BeginContext(708, 61, false);
#line 30 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RejupoUser[0].PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(769, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(827, 13, false);
#line 34 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(SD.SuperAdmin);

#line default
#line hidden
            EndContext();
            BeginContext(840, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(896, 8, false);
#line 37 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(SD.Admin);

#line default
#line hidden
            EndContext();
            BeginContext(904, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(960, 7, false);
#line 40 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(SD.User);

#line default
#line hidden
            EndContext();
            BeginContext(967, 125, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                Akcja\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 49 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
 foreach (var item in Model.RejupoUser) {

#line default
#line hidden
            BeginContext(1135, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1184, 44, false);
#line 52 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1284, 43, false);
#line 55 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1383, 43, false);
#line 58 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Division));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1484, 40, false);
#line 62 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1582, 46, false);
#line 66 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1684, 109, false);
#line 69 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.CheckBox("id", await Model.UserManager.IsInRoleAsync(item, SD.SuperAdmin), new { disabled = "disabled"}));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1849, 103, false);
#line 72 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.CheckBox("id", await Model.UserManager.IsInRoleAsync(item, SD.Admin),new { disabled = "disabled"}));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2008, 102, false);
#line 75 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
           Write(Html.CheckBox("id", await Model.UserManager.IsInRoleAsync(item, SD.User),new { disabled = "disabled"}));

#line default
#line hidden
            EndContext();
            BeginContext(2110, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2167, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380d2f81128bfb72a1905524813a3efca03d252011403", async() => {
                BeginContext(2212, 11, true);
                WriteLiteral("Autoryzacja");
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
#line 79 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2227, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2247, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380d2f81128bfb72a1905524813a3efca03d252013750", async() => {
                BeginContext(2294, 4, true);
                WriteLiteral("Usuń");
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
#line 80 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2302, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\maugustynski\Documents\code\Rejupo\Pages\Admin\Users\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2341, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rejupo.Pages_Admin_Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rejupo.Pages_Admin_Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Rejupo.Pages_Admin_Users.IndexModel>)PageContext?.ViewData;
        public Rejupo.Pages_Admin_Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
