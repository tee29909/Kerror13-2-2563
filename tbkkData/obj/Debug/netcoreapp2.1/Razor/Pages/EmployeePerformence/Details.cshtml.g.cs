#pragma checksum "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875e8253cd6450f40be4f13b7840a2cf80d4dd31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkkData.Pages.EmployeePerformence.Pages_EmployeePerformence_Details), @"mvc.1.0.razor-page", @"/Pages/EmployeePerformence/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeePerformence/Details.cshtml", typeof(tbkkData.Pages.EmployeePerformence.Pages_EmployeePerformence_Details), null)]
namespace tbkkData.Pages.EmployeePerformence
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\_ViewImports.cshtml"
using tbkkData;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"875e8253cd6450f40be4f13b7840a2cf80d4dd31", @"/Pages/EmployeePerformence/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d3c344c43d29ae361a89746d7c90e1cb3c17d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmployeePerformence_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(108, 89, true);
            WriteLiteral("\r\n<script>\r\n                                document.getElementById(\"name\").innerHTML = \"");
            EndContext();
            BeginContext(198, 39, false);
#line 9 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                        Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(237, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname\").innerHTML = \"");
            EndContext();
            BeginContext(323, 38, false);
#line 10 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                            Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(361, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position\").innerHTML = \"");
            EndContext();
            BeginContext(447, 51, false);
#line 11 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                            Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(498, 82, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"name1\").innerHTML = \"");
            EndContext();
            BeginContext(581, 39, false);
#line 12 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                         Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(620, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname1\").innerHTML = \"");
            EndContext();
            BeginContext(707, 38, false);
#line 13 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                             Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(745, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position1\").innerHTML = \"");
            EndContext();
            BeginContext(832, 51, false);
#line 14 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                             Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(883, 523, true);
            WriteLiteral(@""";
</script>


<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <div class=""alert alert-dark text-md-center font-weight-bold"" role=""alert"">Detail Employee</div>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item active"">Management Cockpit</li>
            <li class=""breadcrumb-item active"">Employee Performence</li>
            <li class=""breadcrumb-item active"">Detail</li>
        </ol>
        <div class=""card"">
            <div class=""card-body"">
                ");
            EndContext();
            BeginContext(1406, 2273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "525bb00fe61f42128b5577361a73dda3", async() => {
                BeginContext(1412, 115, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col\">\r\n                            <p>");
                EndContext();
                BeginContext(1528, 54, false);
#line 31 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1582, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(1586, 50, false);
#line 31 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                    Write(Html.DisplayFor(model => model.Employee.FirstName));

#line default
#line hidden
                EndContext();
                BeginContext(1636, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(1674, 52, false);
#line 32 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Address));

#line default
#line hidden
                EndContext();
                BeginContext(1726, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(1730, 48, false);
#line 32 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Employee.Address));

#line default
#line hidden
                EndContext();
                BeginContext(1778, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(1816, 50, false);
#line 33 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1866, 4, true);
                WriteLiteral(" :  ");
                EndContext();
                BeginContext(1871, 46, false);
#line 33 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1917, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(1955, 53, false);
#line 34 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Birthday));

#line default
#line hidden
                EndContext();
                BeginContext(2008, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(2012, 49, false);
#line 34 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.Employee.Birthday));

#line default
#line hidden
                EndContext();
                BeginContext(2061, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(2099, 51, false);
#line 35 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Gender));

#line default
#line hidden
                EndContext();
                BeginContext(2150, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(2154, 47, false);
#line 35 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Employee.Gender));

#line default
#line hidden
                EndContext();
                BeginContext(2201, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(2239, 51, false);
#line 36 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(2290, 4, true);
                WriteLiteral(" :  ");
                EndContext();
                BeginContext(2295, 47, false);
#line 36 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Employee.Salary));

#line default
#line hidden
                EndContext();
                BeginContext(2342, 112, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                        <div class=\"col\">\r\n                            <p>");
                EndContext();
                BeginContext(2455, 53, false);
#line 39 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2508, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(2512, 49, false);
#line 39 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.Employee.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2561, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(2599, 54, false);
#line 40 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Telephone));

#line default
#line hidden
                EndContext();
                BeginContext(2653, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(2657, 50, false);
#line 40 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                    Write(Html.DisplayFor(model => model.Employee.Telephone));

#line default
#line hidden
                EndContext();
                BeginContext(2707, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(2745, 52, false);
#line 41 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Company));

#line default
#line hidden
                EndContext();
                BeginContext(2797, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(2801, 60, false);
#line 41 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Employee.Company.CompanyName));

#line default
#line hidden
                EndContext();
                BeginContext(2861, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2863, 57, false);
#line 41 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                                                                                Write(Html.DisplayFor(model => model.Employee.Company.Category));

#line default
#line hidden
                EndContext();
                BeginContext(2920, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(2958, 63, false);
#line 42 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Date_of_employment));

#line default
#line hidden
                EndContext();
                BeginContext(3021, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(3025, 59, false);
#line 42 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                             Write(Html.DisplayFor(model => model.Employee.Date_of_employment));

#line default
#line hidden
                EndContext();
                BeginContext(3084, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(3122, 51, false);
#line 43 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Status));

#line default
#line hidden
                EndContext();
                BeginContext(3173, 4, true);
                WriteLiteral(" :  ");
                EndContext();
                BeginContext(3178, 47, false);
#line 43 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Employee.Status));

#line default
#line hidden
                EndContext();
                BeginContext(3225, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(3263, 74, false);
#line 44 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.EmployeeType.EmployeeTypeName));

#line default
#line hidden
                EndContext();
                BeginContext(3337, 3, true);
                WriteLiteral(" : ");
                EndContext();
                BeginContext(3341, 70, false);
#line 44 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                                        Write(Html.DisplayFor(model => model.Employee.EmployeeType.EmployeeTypeName));

#line default
#line hidden
                EndContext();
                BeginContext(3411, 37, true);
                WriteLiteral("</p>\r\n                            <p>");
                EndContext();
                BeginContext(3449, 70, false);
#line 45 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Employee.Department.DepartmentName));

#line default
#line hidden
                EndContext();
                BeginContext(3519, 4, true);
                WriteLiteral(" :  ");
                EndContext();
                BeginContext(3524, 66, false);
#line 45 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\EmployeePerformence\Details.cshtml"
                                                                                                     Write(Html.DisplayFor(model => model.Employee.Department.DepartmentName));

#line default
#line hidden
                EndContext();
                BeginContext(3590, 82, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3679, 74, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkkData.Pages.EmployeePerformence.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.EmployeePerformence.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.EmployeePerformence.DetailsModel>)PageContext?.ViewData;
        public tbkkData.Pages.EmployeePerformence.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
