#pragma checksum "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00b0720e842fed9c2754069177fd80f40af253a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkkData.Pages.RedWall.Pages_RedWall_Index), @"mvc.1.0.razor-page", @"/Pages/RedWall/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/RedWall/Index.cshtml", typeof(tbkkData.Pages.RedWall.Pages_RedWall_Index), null)]
namespace tbkkData.Pages.RedWall
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00b0720e842fed9c2754069177fd80f40af253a7", @"/Pages/RedWall/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795d3c344c43d29ae361a89746d7c90e1cb3c17d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RedWall_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 89, true);
            WriteLiteral("\r\n<script>\r\n                                document.getElementById(\"name\").innerHTML = \"");
            EndContext();
            BeginContext(182, 39, false);
#line 9 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                                        Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(221, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname\").innerHTML = \"");
            EndContext();
            BeginContext(307, 38, false);
#line 10 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                                            Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(345, 85, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position\").innerHTML = \"");
            EndContext();
            BeginContext(431, 51, false);
#line 11 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                                            Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(482, 82, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"name1\").innerHTML = \"");
            EndContext();
            BeginContext(565, 39, false);
#line 12 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                                         Write(Model.Employees[0].FirstName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(604, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"lastname1\").innerHTML = \"");
            EndContext();
            BeginContext(691, 38, false);
#line 13 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                                             Write(Model.Employees[0].LastName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(729, 86, true);
            WriteLiteral("\";\r\n                                document.getElementById(\"position1\").innerHTML = \"");
            EndContext();
            BeginContext(816, 51, false);
#line 14 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                                             Write(Model.Employees[0].Position.PositionName.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(867, 1331, true);
            WriteLiteral(@""";
</script>


<link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
<link rel=""stylesheet"" href=""https://www.w3schools.com/w3css/4/w3.css"">
<link rel=""stylesheet"" href=""https://uicdn.toast.com/tui.chart/latest/tui-chart.min.css"">
<link rel=""stylesheet"" href=""https://www.gstatic.com/charts/loader.js"">

<!--CanvasJS Chart-->
<script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script src=""https://code.jquery.com/jquery.js""></script>
<script src=""Scripts/bootstrap.js""></script>
<script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>

<div id=""content-wrapper"">

    <div class=""container-fluid"">
        <div class=""alert alert-info text-md-center font-weight-bold"" role=""alert"">Red Wall</div>
        <br />
        <div class=""row state-overview center-block"">
            <div class=""col-lg-6 col-sm-6"">
                <section cl");
            WriteLiteral(@"ass=""card"" style=""background-color:#DAC6A3"">
                    <div class=""symbol terques"" style=""background-color:#AF291E"">
                        <i class=""fa fa-user-plus""></i>
                    </div>
                    <div class=""value"">
                        <h1 class=""count text-dark"">");
            EndContext();
            BeginContext(2199, 35, false);
#line 42 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                               Write(Model.Customer.Count.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2234, 519, true);
            WriteLiteral(@"</h1>
                        <p class=""text-dark"">Customers</p>
                    </div>
                </section>
            </div>
            <div class=""col-lg-6 col-sm-6"">
                <section class=""card"" style=""background-color:#CADACD"">
                    <div class=""symbol red"" style=""background-color:#EA7053"">
                        <i class=""fas fa-landmark""></i>
                    </div>
                    <div class=""value"">
                        <h1 class=""count2 text-dark"">");
            EndContext();
            BeginContext(2754, 32, false);
#line 53 "C:\Users\admin\Desktop\tital\tbkkData\tbkkData\Pages\RedWall\Index.cshtml"
                                                Write(Model.Rival.Count.ToString("N0"));

#line default
#line hidden
            EndContext();
            BeginContext(2786, 1357, true);
            WriteLiteral(@"</h1>
                        <p class=""text-dark"">Rival</p>
                    </div>
                </section>
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col"" style=""height:350px; width:100%"">
                <!-- Avg ProductRival -->
                <div class=""card shadow"">
                    <div class=""card-body"" style=""border:hidden"">
                        <div id=""AvgProductRival"" style=""height: 300px; width: 100%;""></div>
                    </div>
                </div>
            </div>
            <!-- Safety Environmental -->
            <div class=""col"" style=""height:350px; width:100%"">
                <div class=""card shadow"">
                    <div class=""card-body"" style=""border:hidden"">
                        <div id=""SafetyEnvironmental"" style=""height: 300px; width: 100%;""></div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col"" style=""height:3");
            WriteLiteral(@"50px; width:100%"">
            <!-- Customer Claim -->
            <div class=""card shadow"">
                <div class=""card-body"" style=""border:hidden"">
                    <div id=""Rival"" style=""height: 300px; width: 100%;""></div>
                </div>
            </div>
        </div>
    </div><br />

</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4161, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
                BeginContext(4189, 3035, true);
                WriteLiteral(@"    <script>
        var options = {
            animationEnabled: true,
            theme: ""light2"",
            title: {
                text: ""Customer Claims""
            },
            axisX: {
                valueFormatString: ""MMM "",
                interval: 1,
                intervalType: ""month"",
                //labelAngle: -20
            },
            axisY: {

            },
            toolTip: {
                shared: true
            },
            legend: {
                cursor: ""pointer"",
                itemclick: toggleDataSeries
            },
            data: [
            ]
        };

        var ctx1 = document.getElementById(""CustomerClaims"");
        $().ready(function () {
            {
                $.get('/api/complains').done(function (response) {
                    //$.each(dataPoints, function (index, d) {
                    //    d.x = new Date(d.year, d.month-1, 01)
                    //})
                    let data = {
    ");
                WriteLiteral(@"                    type: ""line"",
                        name: ""Claim"",
                        showInLegend: true,
                        xValueFormatString: ""MMMM YYYY"",
                        yValueFormatString: ""#,##0"",
                        dataPoints: []
                    };
                    $.each(response[0], function (index, d) {
                        data.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    console.log(data);
                    options.data.push(data);
                    data2 = {
                        type: ""column"",
                        name: ""Complain"",
                        showInLegend: true,
                        xValueFormatString: ""MMMM YYYY"",
                        yValueFormatString: ""#,##0"",
                        dataPoints: []
                    };
                    $.each(response[1], function (index, d) {
                        data2.dataPoints.push({ y: d.y, x: new Date(d.x) });
 ");
                WriteLiteral(@"                   })
                    options.data.push(data2);

                    console.log(data);
                    var chart = new CanvasJS.Chart(""CustomerClaims"", options);
                    chart.render();
                });
            }
        });
        function addSymbols(e) {
            var suffixes = [""B""];
            var order = Math.max(Math.floor(Math.log(e.value) / Math.log(1000)), 0);

            if (order > suffixes.length - 1)
                order = suffixes.length - 1;

            var suffix = suffixes[order];
            return CanvasJS.formatNumber(e.value / Math.pow(1000, order)) + suffix;
        }
        function toggleDataSeries(e) {
            if (typeof (e.dataSeries.visible) === ""undefined"" || e.dataSeries.visible) {
                e.dataSeries.visible = false;
            } else {
                e.dataSeries.visible = true;
            }
            e.chart.render();
        }
    </script>

");
                EndContext();
                BeginContext(7251, 4788, true);
                WriteLiteral(@"    <script>
        var options2 = {
            animationEnabled: true,
            theme: ""light2"",
            title: {
                text: ""Avg Product Rival""
            },
            axisX: {
                valueFormatString: ""MMM""
            },
            axisY: {
            },
            toolTip: {
                shared: true
            },
            legend: {
                cursor: ""pointer"",
                verticalAlign: ""bottom"",
                itemclick: toogleDataSeries
            },
            data: []
        };
        var ctx2 = document.getElementById(""AvgProductRival"");
        $().ready(function () {
            {
                $.get('/api/AvgProductRival').done(function (response) {
                    let data3 = {
                        type: ""spline"",
                        showInLegend: true,
                        name: ""Hydraulic cylinder"",
                        markerType: ""square"",
                        indexLabel: ""{y}"",
 ");
                WriteLiteral(@"                       color: ""#F08080"",
                        dataPoints: []
                    };
                    $.each(response[0], function (index, d) {
                        data3.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    console.log(data3);
                    options2.data.push(data3);

                    let data4 = {
                        type: ""spline"",
                        showInLegend: true,
                        name: ""Shock absorber"",
                        lineDashType: ""dash"",
                        indexLabel: ""{y}"",
                        dataPoints: []
                    };
                    $.each(response[1], function (index, d) {
                        data4.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    options2.data.push(data4);
                    console.log(data4);

                    let data5 = {
                        type: ""spline"",
     ");
                WriteLiteral(@"                   showInLegend: true,
                        name: ""Brake cylinder"",
                        lineDashType: ""dash"",
                        indexLabel: ""{y}"",
                        dataPoints: []
                    };
                    $.each(response[2], function (index, d) {
                        data5.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    options2.data.push(data5);
                    console.log(data5);

                    let data6 = {
                        type: ""spline"",
                        showInLegend: true,
                        name: ""Caliper"",
                        lineDashType: ""dash"",
                        indexLabel: ""{y}"",
                        dataPoints: []
                    };
                    $.each(response[3], function (index, d) {
                        data6.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    options2.data.push(da");
                WriteLiteral(@"ta6);
                    console.log(data6);

                    let data7 = {
                        type: ""spline"",
                        showInLegend: true,
                        name: ""Caliper"",
                        lineDashType: ""dash"",
                        indexLabel: ""{y}"",
                        dataPoints: []
                    };
                    $.each(response[4], function (index, d) {
                        data7.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    options2.data.push(data7);
                    console.log(data7);

                    let data8 = {
                        type: ""spline"",
                        showInLegend: true,
                        name: ""Disc brakes"",
                        lineDashType: ""dash"",
                        indexLabel: ""{y}"",
                        dataPoints: []
                    };
                    $.each(response[5], function (index, d) {
               ");
                WriteLiteral(@"         data8.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    options2.data.push(data8);
                    console.log(data8);

                    var chart = new CanvasJS.Chart(""AvgProductRival"", options2);
                    chart.render();
                });
            }
        });
        chart.render();
        function toogleDataSeries(e) {
            if (typeof (e.dataSeries.visible) === ""undefined"" || e.dataSeries.visible) {
                e.dataSeries.visible = false;
            } else {
                e.dataSeries.visible = true;
            }
            chart.render();
        }
    </script>



");
                EndContext();
                BeginContext(12068, 5803, true);
                WriteLiteral(@"
    <script>
        var options1 = {
            animationEnabled: true,
            title: {
                text: ""Safety Environmental""
            },

            ////axisX: {
            ////    interval: 1,
            ////},
            axisY: {
                // suffix: ""%""
                interval: 5,
            },
            axisY2: {
                interval: 5,
            },
            axisX: {
                valueFormatString: ""MMM""
            },
            toolTip: {
                shared: true
            },
            legend: {
                reversed: true,
                //verticalAlign: ""center"",
                // horizontalAlign: ""right""
            },
            data: []

        };
        var ctx2 = document.getElementById(""SafetyEnvironmental"");
        $().ready(function () {
            {
                $.get('/api/Safety_Environmental').done(function (response) {
                    let data3 = {
                        type: ""co");
                WriteLiteral(@"lumn"",
                        name: ""Safety"",
                        showInLegend: true,
                        indexLabel: ""{y}"",
                        yValueFormatString: ""#,##0"",
                        dataPoints: []
                    };
                    $.each(response[0], function (index, d) {
                        data3.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    console.log(data3);
                    options1.data.push(data3);

                    let data4 = {
                        type: ""line"",
                        showInLegend: true,
                        name: ""Total Incident"",
                        lineDashType: ""dash"",
                        dataPoints: []
                    };
                    $.each(response[1], function (index, d) {
                        data4.dataPoints.push({ y: d.y, x: new Date(d.x) });
                    })
                    console.log(data4);
                    options");
                WriteLiteral(@"1.data.push(data4);

                    function createPareto() {
                        var dps = [];
                        var yValue, yTotal = 0, yPercent = 0;

                        for (var i = 0; i < chart.data[0].dataPoints.length; i++)
                            yTotal += chart.data[0].dataPoints[i].y;

                        for (var i = 0; i < chart.data[0].dataPoints.length; i++) {
                            yValue = chart.data[0].dataPoints[i].y;
                            yPercent += (yValue / yTotal * yTotal);
                            dps.push({ x: chart.data[0].dataPoints[i].x, y: yPercent });
                        }

                        chart.addTo(""data"", { type: ""line"", yValueFormatString: ""0.##\""\"""", name: ""Total Incident"", dataPoints: dps });
                        chart.data[1].set(""axisYType"", ""secondary"", false);
                        chart.axisY[0].set(""maximum"", yTotal);
                        chart.axisY2[0].set(""maximum"", yTotal);
          ");
                WriteLiteral(@"          }

                    var chart = new CanvasJS.Chart(""SafetyEnvironmental"", options1);
                    chart.render();
                    createPareto();
                });
            }
        });
    </script>

    <script>
        var options5 = {
            animationEnabled: true,
            title: {
                text: ""Compare competitors' product prices""
            },
            axisY: {
                title: ""Price"",
                titleFontColor: ""#4F81BC"",
                lineColor: ""#4F81BC"",
                labelFontColor: ""#4F81BC"",
                tickColor: ""#4F81BC""
            },
            axisX: {
                interval: 1,
            },
            toolTip: {
                shared: true
            },
            legend: {
                cursor: ""pointer"",
                itemclick: toggleDataSeries
            },
            data: []
        };
        var ctx7 = document.getElementById(""Rival"");
        $().ready(functio");
                WriteLiteral(@"n () {
            {
                $.get('/api/Rival_Product').done(function (response) {
                    let data6 = {
                        type: ""column"",
                        name: ""Company"",
                        legendText: ""Company"",
                        showInLegend: true,
                        dataPoints: []
                    };
                    $.each(response[0], function (index, d) {
                        data6.dataPoints.push({ y: d.y, x: d.x });
                    })
                    console.log(data6);
                    options5.data.push(data6);


                    let data8 = {
                        type: ""column"",
                        name: ""Avg Rival"",
                        legendText: ""Avg Rival"",
                        //axisYType: ""secondary"",
                        showInLegend: true,
                        dataPoints: []
                    };
                    $.each(response[1], function (index, d) {
             ");
                WriteLiteral(@"           data8.dataPoints.push({ y: d.y, x: d.x });
                    })
                    console.log(data8);
                    options5.data.push(data8);

                    var chart = new CanvasJS.Chart(""Rival"", options5);
                    chart.render();
                });
            }
        });
        chart.render();
        function toggleDataSeries(e) {
            if (typeof (e.dataSeries.visible) === ""undefined"" || e.dataSeries.visible) {
                e.dataSeries.visible = false;
            }
            else {
                e.dataSeries.visible = true;
            }
            chart.render();
        }

    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkkData.Pages.RedWall.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.RedWall.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkkData.Pages.RedWall.IndexModel>)PageContext?.ViewData;
        public tbkkData.Pages.RedWall.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
