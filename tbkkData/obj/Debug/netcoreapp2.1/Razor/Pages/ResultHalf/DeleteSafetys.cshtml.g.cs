#pragma checksum "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "914c31c80d10d837807d8fa311a99a93c081e3ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkkData.Pages.ResultHalf.Pages_ResultHalf_DeleteSafetys), @"mvc.1.0.razor-page", @"/Pages/ResultHalf/DeleteSafetys.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ResultHalf/DeleteSafetys.cshtml", typeof(tbkkData.Pages.ResultHalf.Pages_ResultHalf_DeleteSafetys), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"914c31c80d10d837807d8fa311a99a93c081e3ad", @"/Pages/ResultHalf/DeleteSafetys.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d3c344c43d29ae361a89746d7c90e1cb3c17d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ResultHalf_DeleteSafetys : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
  
    ViewData["Title"] = "DeleteSafetys";

#line default
#line hidden
            BeginContext(111, 87, true);
            WriteLiteral("<script>\r\n                                document.getElementById(\"name\").innerHTML = \"");
            EndContext();
            BeginContext(199, 39, false);
#line 8 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                                                        Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(238, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname\").innerHTML = \"");
            EndContext();
            BeginContext(324, 38, false);
#line 9 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                                                            Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(362, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position\").innerHTML = \"");
            EndContext();
            BeginContext(448, 51, false);
#line 10 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                                                            Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(499, 82, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"name1\").innerHTML = \"");
            EndContext();
            BeginContext(582, 39, false);
#line 11 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                                                         Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(621, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname1\").innerHTML = \"");
            EndContext();
            BeginContext(708, 38, false);
#line 12 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                                                             Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(746, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position1\").innerHTML = \"");
            EndContext();
            BeginContext(833, 51, false);
#line 13 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                                                             Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(884, 349, true);
            WriteLiteral(@""";
</script>


<div class=""container"">
    <div class=""alert alert-dark text-md-center font-weight-bold"" role=""alert"">
        Delete Safety
    </div>
    <div class=""card"">
        <br />

        <p class=""text-center text-danger"">Are you sure you want to delete this?</p>
        <hr />
        <div class=""card-body"">
            ");
            EndContext();
            BeginContext(1233, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6095de470c7945ab9039ff3d93b6758a", async() => {
                BeginContext(1259, 120, true);
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <p>Date Incident :  ");
                EndContext();
                BeginContext(1380, 51, false);
#line 30 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                       Write(Html.DisplayFor(model => model.Safety.DateIncident));

#line default
#line hidden
                EndContext();
                BeginContext(1431, 111, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <p>Incident : ");
                EndContext();
                BeginContext(1543, 47, false);
#line 33 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                 Write(Html.DisplayFor(model => model.Safety.incident));

#line default
#line hidden
                EndContext();
                BeginContext(1590, 117, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col\">\r\n                        <p>Total Incident : ");
                EndContext();
                BeginContext(1708, 53, false);
#line 36 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
                                       Write(Html.DisplayFor(model => model.Safety.Total_Incident));

#line default
#line hidden
                EndContext();
                BeginContext(1761, 70, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1838, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1852, 285, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dbaa4079dda45d9ac6733eea91224fc", async() => {
                BeginContext(1872, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1890, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3e5e6056087a468a839dfd011bcead7e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 41 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\ResultHalf\DeleteSafetys.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Safety.SafetyID);

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
                BeginContext(1939, 191, true);
                WriteLiteral("\r\n                <div style=\"text-align:center\">\r\n                    <button type=\"submit\" value=\"Delete\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2137, 52, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkkData.Pages.ResultHalf.DeleteSafetysModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.ResultHalf.DeleteSafetysModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.ResultHalf.DeleteSafetysModel>)PageContext?.ViewData;
        public tbkkData.Pages.ResultHalf.DeleteSafetysModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
