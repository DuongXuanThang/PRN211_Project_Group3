#pragma checksum "C:\Users\Duong Xuan Thang\source\repos\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Areas\Admin\Views\Shared\_SideNavPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bae541503d486caccd89a859f3ea3e506d655e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__SideNavPartialView), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_SideNavPartialView.cshtml")]
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
#line 1 "C:\Users\Duong Xuan Thang\source\repos\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Areas\Admin\Views\_ViewImports.cshtml"
using WebQuanLyShopBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Duong Xuan Thang\source\repos\WebQuanLyShopBanHang\WebQuanLyShopBanHang\Areas\Admin\Views\_ViewImports.cshtml"
using WebQuanLyShopBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bae541503d486caccd89a859f3ea3e506d655e1", @"/Areas/Admin/Views/Shared/_SideNavPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e228d9d83787001416fb5c9e862805ae565f503", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__SideNavPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdminRoles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"side-nav\">\r\n    <div class=\"side-nav-inner\">\r\n        <ul class=\"side-nav-menu scrollable\">\r\n            <li class=\"nav-item dropdown open\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bae541503d486caccd89a859f3ea3e506d655e15029", async() => {
                WriteLiteral("\r\n                    <span class=\"icon-holder\">\r\n                        <i class=\"anticon anticon-dashboard\"></i>\r\n                    </span>\r\n                    <span class=\"title\">Dashboard</span>\r\n                   \r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
               
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-appstore""></i>
                    </span>
                    <span class=""title"">Quản lý đơn hàng</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""app-chat.html"">Chat</a>
                    </li>
                    <li>
                        <a href=""app-file-manager.html"">File Manager</a>
                    </li>
                    <li>
                        <a href=""app-mail.html"">Mail</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                ");
            WriteLiteral(@"            <span>Projects</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a href=""app-project-list.html"">Project List</a>
                            </li>
                            <li>
                                <a href=""app-project-details.html"">Project Details</a>
                            </li>
                        </ul>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <span>E-commerce</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
    ");
            WriteLiteral(@"                        <li>
                                <a href=""app-e-commerce-order-list.html"">Orders List</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products.html"">Products</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products-list.html"">Products List</a>
                            </li>
                            <li>
                                <a href=""app-e-commerce-products-edit.html"">Products Edit</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-build""></i>
                    </span>
                    <span class");
            WriteLiteral(@"=""title"">Quản lý sản phẩm</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""avatar.html"">Avatar</a>
                    </li>
                    <li>
                        <a href=""alert.html"">Alert</a>
                    </li>
                    <li>
                        <a href=""badge.html"">Badge</a>
                    </li>
                    <li>
                        <a href=""buttons.html"">Buttons</a>
                    </li>
                    <li>
                        <a href=""cards.html"">Cards</a>
                    </li>
                    <li>
                        <a href=""icons.html"">Icons</a>
                    </li>
                    <li>
                        <a href=""lists.html"">Lists</a>
                    </li>
                    <li>
      ");
            WriteLiteral(@"                  <a href=""typography.html"">Typography</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-hdd""></i>
                    </span>
                    <span class=""title"">Quản lý khách hàng</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""accordion.html"">Accordion</a>
                    </li>
                    <li>
                        <a href=""carousel.html"">Carousel</a>
                    </li>
                    <li>
                        <a href=""dropdown.html"">Dropdown</a>
                    </li>
                    <li>
            ");
            WriteLiteral(@"            <a href=""modals.html"">Modals</a>
                    </li>
                    <li>
                        <a href=""toasts.html"">Toasts</a>
                    </li>
                    <li>
                        <a href=""popover.html"">Popover</a>
                    </li>
                    <li>
                        <a href=""slider-progress.html"">Slider & Progress</a>
                    </li>
                    <li>
                        <a href=""tabs.html"">Tabs</a>
                    </li>
                    <li>
                        <a href=""tooltips.html"">Tooltips</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-form""></i>
                    </span>
                    <span class=""title"">Doanh số</span>
                    ");
            WriteLiteral(@"<span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""form-elements.html"">Form Elements</a>
                    </li>
                    <li>
                        <a href=""form-layouts.html"">Form Layouts</a>
                    </li>
                    <li>
                        <a href=""form-validation.html"">Form Validation</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-table""></i>
                    </span>
                    <span class=""title"">Tables</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
  ");
            WriteLiteral(@"              </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""basic-table.html"">Basic Table</a>
                    </li>
                    <li>
                        <a href=""data-table.html"">Data Table</a>
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-pie-chart""></i>
                    </span>
                    <span class=""title"">Quản lí hệ thống</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""chartist.html"">Quản lý tài khoản</a>
                    </li>
                    <li>
              ");
            WriteLiteral("          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bae541503d486caccd89a859f3ea3e506d655e115489", async() => {
                WriteLiteral("Quản lý quyển truy cập");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </li>
                </ul>
            </li>
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-file""></i>
                    </span>
                    <span class=""title"">Quản lý tin tức</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""profile.html"">Profile</a>
                    </li>
                    <li>
                        <a href=""invoice.html"">Invoice</a>
                    </li>
                    <li>
                        <a href=""members.html"">Members</a>
                    </li>
                    <li>
                        <a href=""pricing.html"">Pricing</a>
                    ");
            WriteLiteral(@"</li>
                    <li>
                        <a href=""setting.html"">Setting</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a href=""javascript:void(0);"">
                            <span>Blog</span>
                            <span class=""arrow"">
                                <i class=""arrow-icon""></i>
                            </span>
                        </a>
                        <ul class=""dropdown-menu"">
                            <li>
                                <a href=""blog-grid.html"">Blog Grid</a>
                            </li>
                            <li>
                                <a href=""blog-list.html"">Blog List</a>
                            </li>
                            <li>
                                <a href=""blog-post.html"">Blog Post</a>
                            </li>
                        </ul>
                    </li>
                </ul>
            </li");
            WriteLiteral(@">
            <li class=""nav-item dropdown"">
                <a class=""dropdown-toggle"" href=""javascript:void(0);"">
                    <span class=""icon-holder"">
                        <i class=""anticon anticon-lock""></i>
                    </span>
                    <span class=""title"">Quản lý Shipper</span>
                    <span class=""arrow"">
                        <i class=""arrow-icon""></i>
                    </span>
                </a>
                <ul class=""dropdown-menu"">
                    <li>
                        <a href=""login-1.html"">Login 1</a>
                    </li>
                    <li>
                        <a href=""login-2.html"">Login 2</a>
                    </li>
                    <li>
                        <a href=""login-3.html"">Login 3</a>
                    </li>
                    <li>
                        <a href=""sign-up-1.html"">Sign Up 1</a>
                    </li>
                    <li>
                        <a href");
            WriteLiteral(@"=""sign-up-2.html"">Sign Up 2</a>
                    </li>
                    <li>
                        <a href=""sign-up-3.html"">Sign Up 3</a>
                    </li>
                    <li>
                        <a href=""error-1.html"">Error 1</a>
                    </li>
                    <li>
                        <a href=""error-2.html"">Error 2</a>
                    </li>
                </ul>
            </li>
        </ul>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
