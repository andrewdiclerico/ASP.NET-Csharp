#pragma checksum "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd60e4cb56a8aa93e83914868218688b973ae2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Se256_RazorExam_AndrewDiClerico.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Se256_RazorExam_AndrewDiClerico.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fd60e4cb56a8aa93e83914868218688b973ae2a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d3b0cf45d4dd8097616d700f28549aa486348d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Cemetary Plot Information</h1>

    <table class=""table-bordered table-striped"">

        <thead>
            <tr>
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
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 30 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
             if(Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"12\" class=\"text-center\">No Data</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                 foreach (var r in Model.recs)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 41 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.PlotNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 43 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.MiddleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.DOB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.DOD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.StoneCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.PlotCondition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                         if (r.NeedsAttention == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Yes</td>\r\n");
#nullable restore
#line 52 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                        }
                        else if(r.NeedsAttention == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>No</td>\r\n");
#nullable restore
#line 56 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 57 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.RevEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                       Write(r.DOLastRev);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\dicle\source\repos\Se256_RazorExam_AndrewDiClerico\Pages\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591