#pragma checksum "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c879bba61e25a9ac0da08b7d3f34946057fda8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\_ViewImports.cshtml"
using WebQuanLyShopBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\_ViewImports.cshtml"
using WebQuanLyShopBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c879bba61e25a9ac0da08b7d3f34946057fda8b", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e228d9d83787001416fb5c9e862805ae565f503", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebQuanLyShopBanHang.ModelsView.CartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height"" data-bg-image=""assets/images/breadcrumb/bg/1-1-1920x373.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Product Related</h2>
                        <ul>
                            <li>
                                <a href=""/"">Trang ch??? <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li>Gi??? h??ng</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
");
#nullable restore
#line 29 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                     if (Model != null && Model.Count() > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c879bba61e25a9ac0da08b7d3f34946057fda8b5343", async() => {
                WriteLiteral(@"
                            <div class=""table-content table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th class=""product_remove"">X??a</th>
                                            <th class=""product-thumbnail"">H??nh ???nh</th>
                                            <th class=""cart-product-name"">S???n ph???m</th>
                                            <th class=""product-price"">????n gi??</th>
                                            <th class=""product-quantity"">S??? l?????ng</th>
                                            <th class=""product-subtotal"">T???ng ti???n</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 45 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                         if (Model != null && Model.Count() > 0)
                                        {
                                            foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <tr>
                                                    <td class=""product_remove"">
                                                    <input type=""button"" value=""X"" class=""removecart btn btn-primary"" data-mahh=""");
#nullable restore
#line 51 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                                                                                            Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" />
                                                    </td>
                                                    <td class=""product-thumbnail"">
                                                        <a href=""javascript:void(0)"">
                                                            <img");
                BeginWriteAttribute("src", " src=\"", 2914, "\"", 2956, 2);
                WriteAttributeValue("", 2920, "/images/products/", 2920, 17, true);
#nullable restore
#line 55 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2937, item.product.Thumb, 2937, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2957, "\"", 2982, 1);
#nullable restore
#line 55 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2963, item.product.Title, 2963, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        </a>\r\n                                                    </td>\r\n                                                    <td class=\"product-name\"><a href=\"javascript:void(0)\">");
#nullable restore
#line 58 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                                                                     Write(item.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                                    <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 59 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                                                              Write(item.product.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VN??</span></td>
                                                    <td class=""quantity"">
                                                        <div class=""cart-plus-minus"">
                                                            <input data-mahh=""");
#nullable restore
#line 62 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                                         Write(item.product.ProductId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" data-dongia=\"");
#nullable restore
#line 62 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                                                                               Write(item.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" class=\"cartItem cart-plus-minus-box\"");
                BeginWriteAttribute("value", " value=\"", 3744, "\"", 3764, 1);
#nullable restore
#line 62 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3752, item.amount, 3752, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                                                        </div>\r\n                                                    </td>\r\n                                                    <td class=\"product-subtotal\"><span class=\"amount\">");
#nullable restore
#line 65 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                                                                 Write(item.TotalMoney.ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VN??</span></td>\r\n                                                </tr>\r\n");
#nullable restore
#line 67 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                    </tbody>
                                </table>
                            </div>
                            <div class=""row"">
                                <div class=""col-12"">
                                    <div class=""coupon-all"">
                                        <div class=""coupon"">
                                            <input id=""coupon_code"" class=""input-text"" name=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 4660, "\"", 4668, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Coupon code"" type=""text"">
                                            <input class=""button mt-xxs-30"" name=""apply_coupon"" value=""Apply coupon"" type=""submit"">
                                        </div>
                                        <div class=""coupon2"">
                                            <input class=""button"" name=""update_cart"" value=""Update cart"" type=""submit"">
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-5 ml-auto"">
                                    <div class=""cart-page-total"">
                                        <h2>T???ng ????n h??ng</h2>
                                        <ul>
                                            <li>Th??nh ti???n <span>");
#nullable restore
#line 92 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                                                            Write(Model.Sum(x => x.TotalMoney).ToString("#,##0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" VN??</span></li>

                                        </ul>
                                        <a href=""javascript:void(0)"">Proceed to checkout</a>
                                    </div>
                                </div>
                            </div>
                        ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 100 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Ch??a c?? h??ng h??a trong gi??? h??ng</p>\r\n");
#nullable restore
#line 104 "D:\PRN211_Project_Group3\PRN211_Project_Group3\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $(function () {
        function loadHeaderCart() {
            $(""#miniCart"").load(""/AjaxContent/HeaderCart"");
            $(""#numberCart"").load(""/AjaxContent/NumberCart"");

        }
        $("".removecart"").click(function () {
            var productid = $(this).attr(""data-mahh"");
            $.ajax({
                url: '/api/cart/remove',
                type: ""POST"",
                datatype: ""json"",
                data: {
                    productID: productid
                },
                success: function (result) {
                    if (result.success) {
                        loadHeaderCart(); //reload lai gio hang
                        window.location = 'cart.html'
                    }
                },
                error: function (rs) {
                    alert(""Remove Cart Error"");
                }
            });
        });
        $("".cartItem"").click(function () {
            var productid = $(this).attr(""data-mahh"");
       ");
                WriteLiteral(@"     var soluong = parseInt($(this).val());
            $.ajax({
                url: '/api/cart/update',
                type: ""POST"",
                datatype: ""json"",
                data: {
                    productID: productid,
                    amount: soluong
                },
                success: function (result) {
                    if (result.success) {
                        loadHeaderCart(); //reload lai gio hang
                        window.location = 'cart.html'
                    }
                },
                error: function (rs) {
                    alert(""C???p nh???t cart error"");
                }
            });
        });

    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebQuanLyShopBanHang.ModelsView.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
