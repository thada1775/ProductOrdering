#pragma checksum "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2890de2ec42603a016f0285c7274b814d38d94a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ordering_ModalPopUp), @"mvc.1.0.view", @"/Views/Ordering/ModalPopUp.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2890de2ec42603a016f0285c7274b814d38d94a", @"/Views/Ordering/ModalPopUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53c8f120ab874b2064519eee0a92c6928762efc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Ordering_ModalPopUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""modal-header"">
    <h4 class=""modal-title"">รายละเอียด</h4>
    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
        <span aria-hidden=""true""><i class=""fa fa-times-circle""></i></span>
    </button>
</div>
<div class=""modal-body"">
    <div>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 14 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProductImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 17 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 20 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                   Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                   Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 33 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f2890de2ec42603a016f0285c7274b814d38d94a6530", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/imageSource/");
#nullable restore
#line 37 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                                        WriteLiteral(item.ProductImage);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 39 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 42 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 45 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a data-dismiss=\"modal\" style=\"color: white;\" class=\"btn btn-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2118, "\"", 2157, 3);
            WriteAttributeValue("", 2128, "SetProductId(", 2128, 13, true);
#nullable restore
#line 54 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
WriteAttributeValue("", 2141, item.ProductId, 2141, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2156, ")", 2156, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"CallBackProduct\">เลือก</a>\r\n                    </tr>\r\n");
#nullable restore
#line 56 "E:\respository\ProductOrdering\ProductOrdering\Views\Ordering\ModalPopUp.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
        <input type=""hidden"" name=""callbackProductId"" id=""callbackProductId""/>
    </div>
</div>
<div class=""modal-footer"">
    <button type=""button"" class=""btn btn-default""
            data-dismiss=""modal"">
        ปิด
    </button>
</div>
<script>
    function SetProductId(productId) {
        console.log(productId+"" IN MODAL"");
        document.getElementById(""callbackProductId"").value = """";
        document.getElementById(""callbackProductId"").value = productId;

        var returnedvalue = """";
        returnedvalue = $('#callbackProductId').val();
        //console.log(returnedvalue);
        //document.getElementById(""ProductId"").value = returnedvalue;

        $.ajax({
            url: 'FindProductSelect',
            data: { ProductId: returnedvalue },
            cache: false,
            type: ""POST"",
            success: function (data) {
                console.log(data);
                
                document.getElementById(""Pr");
            WriteLiteral(@"oductName"").innerHTML = data[""name""];
                var rootSourceImage = ""/imageSource/"";
                var sourceImage = rootSourceImage.concat(data[""productImage""]);
                //console.log(sourceImage);
                document.getElementById(""ProductImageSource"").src = sourceImage;
                document.getElementById(""ProductId"").value = data[""productId""];
                //$(""#Aumphure_id"").html(markup).show();
            },
            error: function (reponse) {
                alert(""error : "" + reponse);
            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
