#pragma checksum "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b615b23d81438803ea85224f4a2bf89bda87a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b615b23d81438803ea85224f4a2bf89bda87a9", @"/Areas/Admin/Views/Home/Index.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookEcommerce.Areas.Admin.Models.MainPageVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h1 class=""text-center"">Sistem Bilgileri</h1>
<div class=""container mt-5"">
    
    <ul class=""list-group"">
        <li class=""list-group-item d-flex justify-content-between align-items-center"">
            Toplam Kitap Sayısı
            <span class=""badge badge-primary badge-pill"">");
#nullable restore
#line 13 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Home\Index.cshtml"
                                                    Write(Model.BookCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n            Toplam Yazar Sayısı\r\n            <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 17 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Home\Index.cshtml"
                                                    Write(Model.AuthorCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n            Toplam Yayınevi Sayısı\r\n            <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 21 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Home\Index.cshtml"
                                                    Write(Model.PublisherCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n        <li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n            Toplam Sipariş Sayısı\r\n            <span class=\"badge badge-primary badge-pill\">");
#nullable restore
#line 25 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Home\Index.cshtml"
                                                    Write(Model.OrderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n    </ul>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookEcommerce.Areas.Admin.Models.MainPageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
