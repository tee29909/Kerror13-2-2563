#pragma checksum "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a89d4e84f34172311fd42060bc4680e3adcd93a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkkData.Pages.ResultHalf.Pages_ResultHalf_Deliverys), @"mvc.1.0.razor-page", @"/Pages/ResultHalf/Deliverys.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ResultHalf/Deliverys.cshtml", typeof(tbkkData.Pages.ResultHalf.Pages_ResultHalf_Deliverys), null)]
namespace tbkkData.Pages.ResultHalf
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a89d4e84f34172311fd42060bc4680e3adcd93a7", @"/Pages/ResultHalf/Deliverys.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d3c344c43d29ae361a89746d7c90e1cb3c17d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ResultHalf_Deliverys : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateDeliverys", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditDelivery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteDelivery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
  
    ViewData["Title"] = "Deliverys";

#line default
#line hidden
            BeginContext(103, 87, true);
            WriteLiteral("<script>\r\n                                document.getElementById(\"name\").innerHTML = \"");
            EndContext();
            BeginContext(191, 39, false);
#line 8 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                        Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(230, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname\").innerHTML = \"");
            EndContext();
            BeginContext(316, 38, false);
#line 9 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                            Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(354, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position\").innerHTML = \"");
            EndContext();
            BeginContext(440, 51, false);
#line 10 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                            Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(491, 82, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"name1\").innerHTML = \"");
            EndContext();
            BeginContext(574, 39, false);
#line 11 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                         Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(613, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname1\").innerHTML = \"");
            EndContext();
            BeginContext(700, 38, false);
#line 12 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                             Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(738, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position1\").innerHTML = \"");
            EndContext();
            BeginContext(825, 51, false);
#line 13 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                             Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(876, 652, true);
            WriteLiteral(@""";
</script>

<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <div class=""alert alert-dark text-md-center font-weight-bold"" role=""alert"">Deliverys Performance</div>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item active"">Management Cockpit</li>
            <li class=""breadcrumb-item active"">Deliverys Performance</li>
        </ol>
        <div class=""card mb-3"">
            <div class=""card-header"">
                <div class=""dataTable_length"">
                    <i class=""fas fa-table""> Deliverys Performance </i>
                    <div style=""float: right"">
                        ");
            EndContext();
            BeginContext(1528, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5da62128da0c4b84824a1521ca558569", async() => {
                BeginContext(1601, 28, true);
                WriteLiteral("Create Deliverys Performance");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1633, 386, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr class=""text-center"">

                                <th>");
            EndContext();
            BeginContext(2020, 72, false);
#line 38 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                               Write(Html.DisplayNameFor(model => model.Delivery_performance[0].DateDelivery));

#line default
#line hidden
            EndContext();
            BeginContext(2092, 43, true);
            WriteLiteral("</th>\r\n                                <th>");
            EndContext();
            BeginContext(2136, 68, false);
#line 39 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                               Write(Html.DisplayNameFor(model => model.Delivery_performance[0].Employee));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 43, true);
            WriteLiteral("</th>\r\n                                <th>");
            EndContext();
            BeginContext(2248, 78, false);
#line 40 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                               Write(Html.DisplayNameFor(model => model.Delivery_performance[0].Complains_Delivery));

#line default
#line hidden
            EndContext();
            BeginContext(2326, 44, true);
            WriteLiteral("</th>\r\n                                <th> ");
            EndContext();
            BeginContext(2371, 74, false);
#line 41 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                Write(Html.DisplayNameFor(model => model.Delivery_performance[0].Claim_Delivery));

#line default
#line hidden
            EndContext();
            BeginContext(2445, 154, true);
            WriteLiteral("</th>\r\n                                <th></th>\r\n\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                             foreach (var item in Model.Delivery_performance)
                            {

#line default
#line hidden
            BeginContext(2709, 100, true);
            WriteLiteral("                                <tr class=\"text-center\">\r\n\r\n                                    <th>");
            EndContext();
            BeginContext(2810, 47, false);
#line 51 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DateDelivery));

#line default
#line hidden
            EndContext();
            BeginContext(2857, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(2905, 53, false);
#line 52 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Employee.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2958, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2960, 52, false);
#line 52 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                                          Write(Html.DisplayFor(modelItem => item.Employee.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(3012, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(3060, 53, false);
#line 53 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Complains_Delivery));

#line default
#line hidden
            EndContext();
            BeginContext(3113, 47, true);
            WriteLiteral("</th>\r\n                                    <th>");
            EndContext();
            BeginContext(3161, 49, false);
#line 54 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Claim_Delivery));

#line default
#line hidden
            EndContext();
            BeginContext(3210, 89, true);
            WriteLiteral("</th>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3299, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "375abad3c211441495e5d99ef39bc58e", async() => {
                BeginContext(3411, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                       WriteLiteral(item.Delivery_performanceID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3419, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(3461, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f56ccaa4c7142afaad8f9d1425ca1a6", async() => {
                BeginContext(3574, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"
                                                                         WriteLiteral(item.Delivery_performanceID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3584, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 60 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\Deliverys.cshtml"

                            }

#line default
#line hidden
            BeginContext(3701, 164, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkkData.Pages.ResultHalf.DeliverysModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.ResultHalf.DeliverysModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.ResultHalf.DeliverysModel>)PageContext?.ViewData;
        public tbkkData.Pages.ResultHalf.DeliverysModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
