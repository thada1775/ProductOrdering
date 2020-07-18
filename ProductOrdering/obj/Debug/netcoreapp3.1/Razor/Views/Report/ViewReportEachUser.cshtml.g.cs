#pragma checksum "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7112c1c4d9dead81a49e9d972170e01cfe281b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_ViewReportEachUser), @"mvc.1.0.view", @"/Views/Report/ViewReportEachUser.cshtml")]
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
#line 1 "E:\respository\ProductOrdering\ProductOrdering\Views\_ViewImports.cshtml"
using ProductOrdering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\respository\ProductOrdering\ProductOrdering\Views\_ViewImports.cshtml"
using ProductOrdering.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
using ProductOrdering.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7112c1c4d9dead81a49e9d972170e01cfe281b0", @"/Views/Report/ViewReportEachUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c8f120ab874b2064519eee0a92c6928762efc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_ViewReportEachUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductOrdering.Models.ViewModels.ReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewReportEachUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
  
    ViewData["Title"] = "ReportViewModel";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .ui-datepicker-calendar {
        display: none;
    }
</style>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/4.4.0/bootbox.min.js"">
</script>
<script type=""text/javascript"" src=""https://www.google.com/jsapi""></script>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<link rel=""stylesheet"" href=""//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"">
");
            WriteLiteral("<script src=\"https://code.jquery.com/ui/1.12.1/jquery-ui.js\"></script>\r\n\r\n<script type=\"text/javascript\">\r\n    var SearchByMonth = \'");
#nullable restore
#line 21 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                    Write(Model.SearchByMonth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var resultChart = null;\r\n    SearchByMonth = SearchByMonth.toString().toLowerCase();\r\n    console.log(SearchByMonth);\r\n    if (SearchByMonth === \"false\") {\r\n        $(document).ready(function () {\r\n            var _userId = \'");
#nullable restore
#line 27 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                      Write(Model.UserDetail.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n            $.ajax({\r\n                type: \"GET\",\r\n                data: { userId: _userId },\r\n                dataType: \"json\",\r\n                contentType: \"application/json\",\r\n                url: \'");
#nullable restore
#line 33 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                 Write(Url.Action("GenerateUserSalesOneYearChart", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                success: function (result) {
                    resultChart = result;
                    google.charts.load('current', {
                        'packages': ['corechart']
                    });
                    google.charts.setOnLoadCallback(function () {
                        drawChart(result);
                    });
                }
            });
        });

        function drawChart(result) {
            title = ");
#nullable restore
#line 47 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
               Write(Model.DisplayingTime.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" + 543;
            console.log(result);
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Month');
            data.addColumn('number', 'Quantity');
            var dataArray = [];

            $.each(result, function (i, obj) {
                dataArray.push([obj.month, obj.quantity]);
            });
            data.addRows(dataArray);

            var columnChartOptions = {
                title: ""ยอดขายประจำปี พ.ศ. "" + title,
                //width: 1000,
                //height: 400,
                bar: { groupWidth: ""20%"" },
            };

            var columnChart = new google.visualization.ColumnChart(document
                .getElementById('columnchart_div'));

            columnChart.draw(data, columnChartOptions);
        }
    }
    else
    {
        $(document).ready(function () {
            google.charts.load('current', {
                'packages': ['corechart']
            });
            google.charts.s");
            WriteLiteral("etOnLoadCallback(function () {\r\n                var JsonResult = ");
#nullable restore
#line 79 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                            Write(Json.Serialize(Model.orderingsByMonthJson));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                console.log(JsonResult);
                resultChart = JsonResult;
                drawChart(JsonResult);
            });
        });

        function drawChart(result) {
            console.log(result);
            var showingTime = '");
#nullable restore
#line 88 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                          Write(Html.Raw(Model.ShowingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';
            abc = ""ไก่ 2556"";
            console.log(showingTime);
            console.log(abc);
            var data = new google.visualization.DataTable();
            data.addColumn('number', 'NumDay');
            data.addColumn('number', 'Quantity');
            var dataArray = [];

            $.each(result.value, function (i, obj) {
                dataArray.push([obj.numDay, obj.quantity]);
            });
            data.addRows(dataArray);

            var columnChartOptions = {
                title: ""ยอดขาย "" + showingTime,
                //width: 1000,
                //height: 400,
                bar: { groupWidth: ""20%"" },
            };

            var columnChart = new google.visualization.LineChart(document
                .getElementById('columnchart_div'));

            columnChart.draw(data, columnChartOptions);
        }
    }


    $(function () {
        $('.date-picker').datepicker({
            changeMonth: true,
            changeYear: true,
");
            WriteLiteral(@"            showButtonPanel: true,
            dateFormat: 'MM yy',
            onClose: function (dateText, inst) {
                $(this).datepicker('setDate', new Date(inst.selectedYear, inst.selectedMonth, 1));
            }
        });
    });


</script>

<h1>สรุปยอดการสั่งซื้อ</h1>
<br>

<div style=""display: flex; justify-content: flex-end"">
    <div class=""form-inline"">
        <label for=""startDate"">เดือน/ปี :</label> &nbsp;
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7112c1c4d9dead81a49e9d972170e01cfe281b010390", async() => {
                WriteLiteral("\r\n\r\n            <input name=\"dateSearch\" id=\"startDate\" class=\"date-picker form-control\" />\r\n            <button type=\"submit\" class=\"btn btn-primary\">ค้นหา</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n<br>\r\n\r\n<div class=\"card border-dark mb-3\" style=\"max-width: 25rem;\">\r\n");
            WriteLiteral("    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">");
#nullable restore
#line 151 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                          Write(Html.DisplayFor(model => model.UserDetail.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 151 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                                                                                Write(Html.DisplayFor(model => model.UserDetail.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p class=\"card-text\">\r\n            เบอร์: ");
#nullable restore
#line 153 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
              Write(Html.DisplayFor(model => model.UserDetail.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br>\r\n            ที่อยู่ : ");
#nullable restore
#line 154 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                 Write(Html.DisplayFor(model => model.UserDetail.FullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n<div class=\"card text-white bg-success mb-12\">\r\n    <center>\r\n        <div class=\"card-header\"><h3>รายการสั่งซื้อที่ส่งสำเร็จ</h3></div>\r\n        <div class=\"card-body\">\r\n            <h2 class=\"card-text\">");
#nullable restore
#line 162 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                             Write(Model.orderingCompleteOfUser.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
        </div>
    </center>
</div>
<br>
<div class=""row"">
    <div class=""col-sm-4"">
        <div class=""card text-white bg-primary"">
            <div class=""card-header"">รายการสั่งซื้อทั้งหมด</div>
            <div class=""card-body"">
                <p class=""card-text""><h4>");
#nullable restore
#line 172 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                                    Write(Model.orderings.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></p>
            </div>
        </div>
    </div>

    <div class=""col-sm-4"">
        <div class=""card bg-light"">
            <div class=""card-header"">รายการสั่งซื้อที่กำลังดำเนินการส่ง</div>
            <div class=""card-body"">
                <p class=""card-text""><h4>");
#nullable restore
#line 181 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                                    Write(Model.orderingSendingOfUser.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></p>
            </div>
        </div>
    </div>

    <div class=""col-sm-4"">
        <div class=""card text-white bg-danger"">
            <div class=""card-header"">รายการสั่งซื้อที่ถูกยกเลิก</div>
            <div class=""card-body"">
                <p class=""card-text""><h4>");
#nullable restore
#line 190 "E:\respository\ProductOrdering\ProductOrdering\Views\Report\ViewReportEachUser.cshtml"
                                    Write(Model.orderingCancelOfUser.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4></p>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-sm-12"">
        <div style=""width: 100%; height: 400px;"" id=""columnchart_div""></div>
    </div>
</div>


<script>
    $(window).resize(function () {
        google.charts.load('current', {
            'packages': ['corechart']
        });
        google.charts.setOnLoadCallback(function () {
            //console.log(resultChart);
            drawChart(resultChart);
        });
        
    });

</script>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductOrdering.Models.ViewModels.ReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
