#pragma checksum "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b308ae4dfc74f9389bbef49bcf431a3bb7d3c1f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowTreatmentPlan), @"mvc.1.0.view", @"/Views/Home/ShowTreatmentPlan.cshtml")]
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
#line 1 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\_ViewImports.cshtml"
using IPTreatmentManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\_ViewImports.cshtml"
using IPTreatmentManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b308ae4dfc74f9389bbef49bcf431a3bb7d3c1f0", @"/Views/Home/ShowTreatmentPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a8e97e1e9eb8f273a8d6bd2573af5fc22aa3f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowTreatmentPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IPTreatmentManagementPortal.Models.TreatmentPlan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
  
    ViewData["Title"] = "ShowTreatmentPlan";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowTreatmentPlan</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.PlanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.PatientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.AilmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.PackageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.TestDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.SpecialistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.TreatmentCommencementDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayNameFor(model => model.TreatmentEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("     \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlanId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.PatientId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.AilmentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.PackageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.TestDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.SpecialistName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.TreatmentCommencementDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
           Write(Html.DisplayFor(modelItem => item.TreatmentEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("          \r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\vaidy\Desktop\IPTreatmentManagementPortal\Views\Home\ShowTreatmentPlan.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b308ae4dfc74f9389bbef49bcf431a3bb7d3c1f010413", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IPTreatmentManagementPortal.Models.TreatmentPlan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
