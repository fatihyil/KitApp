#pragma checksum "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe13676aeb29dbe4cb7c89957a5b9ea1ec9d5f1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe13676aeb29dbe4cb7c89957a5b9ea1ec9d5f1b", @"/Areas/Admin/Views/Order/Index.cshtml")]
    public class Areas_Admin_Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookEcommerce.Areas.Admin.Models.AdminOrdersVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"text-center font-weight-bold mt-2\">\r\n    <h1>Siparişler</h1>\r\n\r\n</div>\r\n");
#nullable restore
#line 15 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
 if (TempData["EmptyOrder"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-5 alert alert-danger text-center\">\r\n        <p>");
#nullable restore
#line 18 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
      Write(TempData["EmptyOrder"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 20 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mt-4\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <div class=\"card\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 28 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                          Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Siparişi</h5>
                        <p class=""card-text"">Sipariş detayı</p>
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Sipriş Numarası</th>
                                    <th scope=""col"">Kitap Adı</th>
                                    <th scope=""col"">Kitap Fiyatı</th>
                                    <th scope=""col"">Kitap Adeti</th>
                                    <th>Kitap Detayı</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 41 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                 foreach (var detail in item.OrderDetailVMs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\">");
#nullable restore
#line 44 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                                   Write(detail.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(detail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 46 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(detail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 47 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                       Write(detail.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe13676aeb29dbe4cb7c89957a5b9ea1ec9d5f1b8206", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                                                                                                                   WriteLiteral(detail.BookId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"card-body\">\r\n                        <strong>Toplam Fiyat :</strong> <p class=\"card-text\">");
#nullable restore
#line 59 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
                                                                        Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <small>TL</small></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 63 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Order\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookEcommerce.Areas.Admin.Models.AdminOrdersVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
