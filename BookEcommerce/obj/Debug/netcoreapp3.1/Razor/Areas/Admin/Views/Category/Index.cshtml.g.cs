#pragma checksum "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f341eee50ae975e36739ccbf3cc60be21963dd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f341eee50ae975e36739ccbf3cc60be21963dd4", @"/Areas/Admin/Views/Category/Index.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookEcommerce.Areas.Admin.Models.AdminCategoryVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container mt-5\">\r\n    <div class=\"text-center\">\r\n        <h1>Kategori Listesi</h1>\r\n    </div>\r\n");
#nullable restore
#line 11 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
     if (TempData["EmptyCategory"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>");
#nullable restore
#line 14 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
          Write(TempData["EmptyCategory"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 16 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-dark\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">#</th>\r\n                    <th scope=\"col\">Kategori Adı</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">1</th>\r\n                        <td><a href=\"#\">");
#nullable restore
#line 31 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 39 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Category\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"d-flex justify-content-end\">\r\n        <a class=\"btn btn-success\" href=\"/Admin/Category/Add\">Yeni Kategori Ekle</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookEcommerce.Areas.Admin.Models.AdminCategoryVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
