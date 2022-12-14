#pragma checksum "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a8abee9d9c37b42c2065e9d3b412817c16e72c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Se256_RazorExam_AndrewDiClerico.Pages.Admin.Pages_Admin_ControlPanel), @"mvc.1.0.razor-page", @"/Pages/Admin/ControlPanel.cshtml")]
namespace Se256_RazorExam_AndrewDiClerico.Pages.Admin
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
#line 1 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\_ViewImports.cshtml"
using Se256_RazorExam_AndrewDiClerico;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a8abee9d9c37b42c2065e9d3b412817c16e72c1", @"/Pages/Admin/ControlPanel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d3b0cf45d4dd8097616d700f28549aa486348d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_ControlPanel : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
  
    ViewData["Title"] = "Control Panel";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-2"">Admin Control Panel</h1>
    <h2 class=""display-4"">Cemetary Plot Information</h2>

    <table class=""table-bordered table-striped"">

        <thead>
            <tr>
                <th>ID</th>
                <th>Plot Number</th>
                <th>First Name</th>
                <th>Middle Name</th>
                <th>Last Name</th>
                <th>Date Of Birth</th>
                <th>Date Of Death</th>
                <th>Stone Condition</th>
                <th>Plot Condition</th>
                <th>Attention Needed?</th>
                <th>Reviewer Email</th>
                <th>Date Of Last Reviewed</th>
                <th colspan=""2"">ADMIN</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 32 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"12\" class=\"text-center\">No Data</td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                 foreach (var r in Model.recs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.PlotID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.PlotNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.DOD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.StoneCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.PlotCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                         if (r.NeedsAttention == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Yes</td>\r\n");
#nullable restore
#line 55 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                        }
                        else if (r.NeedsAttention == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>No</td>\r\n");
#nullable restore
#line 59 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 60 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.RevEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 61 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                       Write(r.DOLastRev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8abee9d9c37b42c2065e9d3b412817c16e72c19645", async() => {
                WriteLiteral("Edit");
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
#nullable restore
#line 62 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                                                        WriteLiteral(r.PlotID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a8abee9d9c37b42c2065e9d3b412817c16e72c111853", async() => {
                WriteLiteral("Delete");
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
#nullable restore
#line 63 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                                                          WriteLiteral(r.PlotID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 65 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Admin\ControlPanel.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Se256_RazorExam_AndrewDiClerico.Pages.Admin.ControlPanelModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Se256_RazorExam_AndrewDiClerico.Pages.Admin.ControlPanelModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Se256_RazorExam_AndrewDiClerico.Pages.Admin.ControlPanelModel>)PageContext?.ViewData;
        public Se256_RazorExam_AndrewDiClerico.Pages.Admin.ControlPanelModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
