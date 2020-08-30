#pragma checksum "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "965d5e4e1dd332d4e0d6e2dd01b9dc3f65357f75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"965d5e4e1dd332d4e0d6e2dd01b9dc3f65357f75", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c8f120ab874b2064519eee0a92c6928762efc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductOrdering.Models.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imageSource/UserImage/DefaultUserImage/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/chart.js/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/AdminLTE/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Small boxes (Stat box) -->\r\n<div class=\"row\">\r\n    <div class=\"col-lg-3 col-6\">\r\n        <!-- small box -->\r\n        <div class=\"small-box bg-primary\">\r\n            <div class=\"inner\">\r\n                <h3>");
#nullable restore
#line 12 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
               Write(Model.AllOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>รายการสั่งซื้อทั้งหมด</p>
            </div>
            <div class=""icon"">
                <i class=""fas fa-toolbox""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
    <div class=""col-lg-3 col-6"">
        <!-- small box -->
        <div class=""small-box bg-success"">
            <div class=""inner"">
                <h3>");
#nullable restore
#line 27 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
               Write(Model.CompleteOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>รายการสั่งซื้อที่ส่งสำเร็จ</p>
            </div>
            <div class=""icon"">
                <i class=""fas fa-splotch""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
    <div class=""col-lg-3 col-6"">
        <!-- small box -->
        <div class=""small-box bg-info"">
            <div class=""inner"">
                <h3>");
#nullable restore
#line 42 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
               Write(Model.SendingOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>รายการสั่งซื้อที่กำลังส่ง</p>
            </div>
            <div class=""icon"">
                <i class=""fas fa-spinner""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
    <div class=""col-lg-3 col-6"">
        <!-- small box -->
        <div class=""small-box bg-danger"">
            <div class=""inner"">
                <h3>");
#nullable restore
#line 57 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
               Write(Model.CancelOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>

                <p>รายการสั่งซื้อที่ถูกยกเลิก</p>
            </div>
            <div class=""icon"">
                <i class=""fas fa-calendar-times""></i>
            </div>
            <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
        </div>
    </div>
    <!-- ./col -->
</div>
<div class=""row"">
    <div class=""col-md-6"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">สมาชิก</h3>

                <div class=""card-tools"">
                    <span class=""badge badge-danger"">8 New Members</span>
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"">
                        <i class=""fas fa-minus""></i>
                    </button>
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"">
                        <i class=""fas fa-times""></i>
                    </button>
                </div>
            ");
            WriteLiteral("</div>\r\n            <!-- /.card-header -->\r\n            <div class=\"card-body p-0\">\r\n                <ul class=\"users-list clearfix\">\r\n");
#nullable restore
#line 88 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                     foreach (var item in Model.AllUser)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n");
#nullable restore
#line 91 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                             if (item.UserDetail.UserImage != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "965d5e4e1dd332d4e0d6e2dd01b9dc3f65357f759023", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3326, "~/imageSource/UserImage/", 3326, 24, true);
#nullable restore
#line 93 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
AddHtmlAttributeValue("", 3350, item.UserDetail.UserImage, 3350, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 94 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "965d5e4e1dd332d4e0d6e2dd01b9dc3f65357f7510927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 98 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a class=\"users-list-name\" href=\"#\">");
#nullable restore
#line 100 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                                                           Write(item.UserDetail.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;");
#nullable restore
#line 100 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                                                                                                 Write(item.UserDetail.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
            WriteLiteral("                        </li>\r\n");
#nullable restore
#line 103 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>
                <!-- /.users-list -->
            </div>
            <!-- /.card-body -->
            <div class=""card-footer text-center"">
                <a href=""javascript::"">View All Users</a>
            </div>
            <!-- /.card-footer -->
        </div>
        <!--/.card -->
    </div>

    <!-- /.col-md-6 -->
    <div class=""col-md-6"">
        <div class=""card"">
            <div class=""card-header border-0"">
                <div class=""d-flex justify-content-between"">
                    <h3 class=""card-title"">Sales</h3>
                    <a href=""javascript:void(0);"">View Report</a>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""d-flex"">
                    <p class=""d-flex flex-column"">
");
            WriteLiteral("                        <span>Sales Over Time</span>\r\n                    </p>\r\n");
            WriteLiteral(@"                </div>
                <!-- /.d-flex -->

                <div class=""position-relative mb-4"">
                    <canvas id=""sales-chart"" height=""200""></canvas>
                </div>

                <div class=""d-flex flex-row justify-content-end"">
                    <span class=""mr-2"">
                        <i class=""fas fa-square text-primary""></i> This year
                    </span>

                    <span>
                        <i class=""fas fa-square text-gray""></i> Last year
                    </span>
                </div>
            </div>
        </div>
        <!-- /.card -->
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "965d5e4e1dd332d4e0d6e2dd01b9dc3f65357f7514896", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(function () {
        'use strict'

        var ticksStyle = {
            fontColor: '#495057',
            fontStyle: 'bold'
        }

        var mode = 'index'
        var intersect = true
        var $salesChart = $('#sales-chart')
        console.log(");
#nullable restore
#line 171 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
               Write(Html.Raw(Json.Serialize(Model.OrderCurrentYear)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
        var salesChart = new Chart($salesChart, {
            type: 'bar',
            data: {
                labels: ['JAN','FEB','MAR','APL','MAY','JUN', 'JUL', 'AUG', 'SEP', 'OCT', 'NOV', 'DEC'],
                datasets: [
                    {
                        backgroundColor: '#007bff',
                        borderColor: '#007bff',
                        data: ");
#nullable restore
#line 180 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                         Write(Html.Raw(Json.Serialize(Model.OrderLastYear)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        //data: [1000, 2000, 3000, 2500, 2700, 2500, 3000]
                    },
                    {
                        backgroundColor: '#ced4da',
                        borderColor: '#ced4da',
                        data: ");
#nullable restore
#line 186 "E:\respository\ProductOrdering\ProductOrdering\Views\Home\Dashboard.cshtml"
                         Write(Html.Raw(Json.Serialize(Model.OrderCurrentYear)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        //data: [700, 1700, 2700, 2000, 1800, 1500, 2000]
                    }
                ]
            },
            options: {
                maintainAspectRatio: false,
                tooltips: {
                    mode: mode,
                    intersect: intersect
                },
                hover: {
                    mode: mode,
                    intersect: intersect
                },
                legend: {
                    display: false
                },
                scales: {
                    yAxes: [{
                        // display: false,
                        gridLines: {
                            display: true,
                            lineWidth: '4px',
                            color: 'rgba(0, 0, 0, .2)',
                            zeroLineColor: 'transparent'
                        },
                        ticks: $.extend({
                            beginAtZero: true,

                         ");
            WriteLiteral(@"   // Include a dollar sign in the ticks
                            callback: function (value, index, values) {
                                if (value >= 1000) {
                                    value /= 1000
                                    value += 'k'
                                }
                                return value
                            }
                        }, ticksStyle)
                    }],
                    xAxes: [{
                        display: true,
                        gridLines: {
                            display: false
                        },
                        ticks: ticksStyle
                    }]
                }
            }
        })
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductOrdering.Models.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591