#pragma checksum "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1e7e01cfd58f3bfcb8157589ee98bf23a9fe5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkkData.Pages.QA.Pages_QA_Complain), @"mvc.1.0.razor-page", @"/Pages/QA/Complain.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/QA/Complain.cshtml", typeof(tbkkData.Pages.QA.Pages_QA_Complain), null)]
namespace tbkkData.Pages.QA
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1e7e01cfd58f3bfcb8157589ee98bf23a9fe5c", @"/Pages/QA/Complain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d3c344c43d29ae361a89746d7c90e1cb3c17d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_QA_Complain : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Claim"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
  
    ViewData["Title"] = "Complain";

#line default
#line hidden
            BeginContext(93, 89, true);
            WriteLiteral("\r\n<script>\r\n                                document.getElementById(\"name\").innerHTML = \"");
            EndContext();
            BeginContext(183, 39, false);
#line 9 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                        Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(222, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname\").innerHTML = \"");
            EndContext();
            BeginContext(308, 38, false);
#line 10 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                            Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(346, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position\").innerHTML = \"");
            EndContext();
            BeginContext(432, 51, false);
#line 11 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                            Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(483, 82, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"name1\").innerHTML = \"");
            EndContext();
            BeginContext(566, 39, false);
#line 12 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                         Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(605, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname1\").innerHTML = \"");
            EndContext();
            BeginContext(692, 38, false);
#line 13 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                             Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(730, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position1\").innerHTML = \"");
            EndContext();
            BeginContext(817, 51, false);
#line 14 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                             Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(868, 510, true);
            WriteLiteral(@""";
</script>

<div class=""container"">
    <div class=""alert alert-dark text-md-center font-weight-bold"" role=""alert"">Complain</div>
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item active"">Management Cockpit</li>
        <li class=""breadcrumb-item active"">Complain</li>
    </ol>
    <div class=""card mb-3"">
        <div class=""card-header"">
            <div class=""dataTable_length"">
                <i class=""fas fa-table""> Complain</i>
            </div>
        </div>
        ");
            EndContext();
            BeginContext(1378, 2222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65f0c38956f4650ba97a2453a1e84df", async() => {
                BeginContext(1398, 331, true);
                WriteLiteral(@"
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""3"">
                        <thead class=""thead-dark"">
                            <tr class=""text-center"">
                                <th>");
                EndContext();
                BeginContext(1730, 60, false);
#line 35 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                               Write(Html.DisplayNameFor(model => model.Complain[0].DateComplain));

#line default
#line hidden
                EndContext();
                BeginContext(1790, 43, true);
                WriteLiteral("</th>\r\n                                <th>");
                EndContext();
                BeginContext(1834, 54, false);
#line 36 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                               Write(Html.DisplayNameFor(model => model.Complain[0].Status));

#line default
#line hidden
                EndContext();
                BeginContext(1888, 43, true);
                WriteLiteral("</th>\r\n                                <th>");
                EndContext();
                BeginContext(1932, 62, false);
#line 37 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                               Write(Html.DisplayNameFor(model => model.Complain[0].Order.Customer));

#line default
#line hidden
                EndContext();
                BeginContext(1994, 43, true);
                WriteLiteral("</th>\r\n                                <th>");
                EndContext();
                BeginContext(2038, 61, false);
#line 38 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                               Write(Html.DisplayNameFor(model => model.Complain[0].Order.Invoice));

#line default
#line hidden
                EndContext();
                BeginContext(2099, 154, true);
                WriteLiteral("</th>\r\n                                <th></th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
                EndContext();
#line 44 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                             foreach (var item in Model.Complain)
                            {

#line default
#line hidden
                BeginContext(2351, 98, true);
                WriteLiteral("                                <tr class=\"text-center\">\r\n                                    <th>");
                EndContext();
                BeginContext(2450, 47, false);
#line 47 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DateComplain));

#line default
#line hidden
                EndContext();
                BeginContext(2497, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
                BeginContext(2545, 47, false);
#line 48 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Order.Status));

#line default
#line hidden
                EndContext();
                BeginContext(2592, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
                BeginContext(2640, 58, false);
#line 49 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Order.Customer.FirsName));

#line default
#line hidden
                EndContext();
                BeginContext(2698, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2700, 58, false);
#line 49 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                                               Write(Html.DisplayFor(modelItem => item.Order.Customer.LastName));

#line default
#line hidden
                EndContext();
                BeginContext(2758, 47, true);
                WriteLiteral("</th>\r\n                                    <th>");
                EndContext();
                BeginContext(2806, 48, false);
#line 50 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Order.Invoice));

#line default
#line hidden
                EndContext();
                BeginContext(2854, 89, true);
                WriteLiteral("</th>\r\n                                    <td>\r\n                                        ");
                EndContext();
                BeginContext(2943, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5d7086aade04405790339b994133cfe2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 52 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"
                                                                             WriteLiteral(item.ComplainID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3049, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(3362, 82, true);
                WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
                EndContext();
#line 57 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\QA\Complain.cshtml"

                            }

#line default
#line hidden
                BeginContext(3477, 116, true);
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3600, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkkData.Pages.QA.ComplainModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.QA.ComplainModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.QA.ComplainModel>)PageContext?.ViewData;
        public tbkkData.Pages.QA.ComplainModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
