#pragma checksum "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5269c53a57377650409317b270803a67c1e99dc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkkData.Pages.Rivals.Pages_Rivals_Details), @"mvc.1.0.razor-page", @"/Pages/Rivals/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Rivals/Details.cshtml", typeof(tbkkData.Pages.Rivals.Pages_Rivals_Details), null)]
namespace tbkkData.Pages.Rivals
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5269c53a57377650409317b270803a67c1e99dc8", @"/Pages/Rivals/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d3c344c43d29ae361a89746d7c90e1cb3c17d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rivals_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(95, 93, true);
            WriteLiteral("\r\n    <script>\r\n                                document.getElementById(\"name\").innerHTML = \"");
            EndContext();
            BeginContext(189, 39, false);
#line 9 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                                                                        Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(228, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname\").innerHTML = \"");
            EndContext();
            BeginContext(314, 38, false);
#line 10 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                                                                            Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(352, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position\").innerHTML = \"");
            EndContext();
            BeginContext(438, 51, false);
#line 11 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                                                                            Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(489, 82, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"name1\").innerHTML = \"");
            EndContext();
            BeginContext(572, 39, false);
#line 12 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                                                                         Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(611, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname1\").innerHTML = \"");
            EndContext();
            BeginContext(698, 38, false);
#line 13 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                                                                             Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(736, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position1\").innerHTML = \"");
            EndContext();
            BeginContext(823, 51, false);
#line 14 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                                                                             Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(874, 164, true);
            WriteLiteral("\";\r\n    </script>\r\n\r\n\r\n<h2>Details</h2>\r\n\r\n    <div>\r\n        <h4>Rival</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1039, 46, false);
#line 25 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Rival.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1141, 42, false);
#line 28 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayFor(model => model.Rival.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1183, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1239, 49, false);
#line 31 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Rival.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1344, 45, false);
#line 34 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayFor(model => model.Rival.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1445, 47, false);
#line 37 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Rival.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1548, 43, false);
#line 40 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayFor(model => model.Rival.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1591, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1647, 51, false);
#line 43 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Rival.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1754, 47, false);
#line 46 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
           Write(Html.DisplayFor(model => model.Rival.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 67, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(1868, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ce7f5e3ae84ce4af52aed60cbb1b16", async() => {
                BeginContext(1924, 4, true);
                WriteLiteral("Edit");
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
#line 51 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\Rivals\Details.cshtml"
                               WriteLiteral(Model.Rival.RivaID);

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
            BeginContext(1932, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(1944, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caea2284e7f44993a4e287a515265053", async() => {
                BeginContext(1966, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1982, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkkData.Pages.Rivals.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.Rivals.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.Rivals.DetailsModel>)PageContext?.ViewData;
        public tbkkData.Pages.Rivals.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
