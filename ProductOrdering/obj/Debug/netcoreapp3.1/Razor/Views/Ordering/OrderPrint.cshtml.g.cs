#pragma checksum "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb2cb889f7e6e264522cdc15d81522d8e7af120"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordering_OrderPrint), @"mvc.1.0.view", @"/Views/Ordering/OrderPrint.cshtml")]
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
#line 2 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
using ProductOrdering.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb2cb889f7e6e264522cdc15d81522d8e7af120", @"/Views/Ordering/OrderPrint.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c8f120ab874b2064519eee0a92c6928762efc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Ordering_OrderPrint : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ordering>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
  
    Layout = null;
    //bool IsOpenTR = true;
    int countOrder = Model.Count();
    countOrder--;
    List<Ordering> orderings = new List<Ordering>();

#line default
#line hidden
#nullable disable
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb2cb889f7e6e264522cdc15d81522d8e7af1205014", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3eb2cb889f7e6e264522cdc15d81522d8e7af1205276", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3eb2cb889f7e6e264522cdc15d81522d8e7af1206454", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.0/css/all.css"" integrity=""sha384-lZN37f5QGtY3VHgisS14W3ExzMWZxybE1SJSEsQp9S+oqd12jhcu+A56Ebc1zFSJ"" crossorigin=""anonymous"">
    <title>พิมพ์รายการสั่งซื้อ</title>
    <style>
        /*tr.title td {
            border-left: 0px solid;
            border-right: 0px solid;
        }
        div.label{
            border: 3px outset;
            width: 50%;
            padding: 10px;
        }*/
        .inline {
            display: inline-block;
            border: 3px solid black;
            padding: 3px;
            width: 45%;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb2cb889f7e6e264522cdc15d81522d8e7af1208996", async() => {
                WriteLiteral("\r\n    <table align=\"center\" width=\"90%\" border=\"1\">\r\n        \r\n");
#nullable restore
#line 37 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
         for (int i = 0; i <= countOrder; i++)
        {
            orderings.Add(Model[i]);
            if (orderings.Count() == 2 || i == countOrder)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n");
#nullable restore
#line 43 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
             foreach (var item in orderings)
            {
                if (countOrder == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td width=\"50%\" style=\"padding: 20px;\">\r\n                        <span style=\"font-size: 15px;\">\r\n                            <span style=\"font-size: 20px;\">");
#nullable restore
#line 49 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                                                       Write(item.Receiver.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 49 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                                                                             Write(item.Receiver.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <br>\r\n                            เบอร์โทร ");
#nullable restore
#line 51 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                                 Write(item.Receiver.Tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <br>\r\n                            ");
#nullable restore
#line 53 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                        Write(item.Receiver.FullAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </td>\r\n                    <td width=\"50%\" style=\"padding: 20px;\"></td>\r\n");
#nullable restore
#line 57 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td style=\"padding: 20px\">\r\n                        <span style=\"font-size: 15px;\">\r\n                            <span style=\"font-size: 20px;\">");
#nullable restore
#line 62 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                                                       Write(item.Receiver.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 62 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                                                                             Write(item.Receiver.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            <br>\r\n                            เบอร์โทร ");
#nullable restore
#line 64 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                                 Write(item.Receiver.Tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <br>\r\n                            ");
#nullable restore
#line 66 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                        Write(item.Receiver.FullAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </span>\r\n                    </td>\r\n");
#nullable restore
#line 69 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                }


            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tr>\r\n");
#nullable restore
#line 74 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\OrderPrint.cshtml"
                orderings = new List<Ordering>();
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ordering>> Html { get; private set; }
    }
}
#pragma warning restore 1591
