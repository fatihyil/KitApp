#pragma checksum "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3c5c2c414adfe8d5b17e11201ab9547ac09fd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Book_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Book/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c3c5c2c414adfe8d5b17e11201ab9547ac09fd5", @"/Areas/Admin/Views/Book/Edit.cshtml")]
    public class Areas_Admin_Views_Book_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookEcommerce.Areas.Admin.Models.AdminBookEditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"mt-5\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
     using (Html.BeginForm(FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container border border-dark p-3\">\r\n            <div class=\"row form-group ml-5\">\r\n                ");
#nullable restore
#line 12 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, "Kitap Id :", new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 13 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, Model.Id.ToString(), new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 14 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row form-group ml-5\">\r\n                ");
#nullable restore
#line 17 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, "Kitap Adı :", new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, Model.BookName.ToString(), new { @class = "col-md-5" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.HiddenFor(x => x.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row form-group ml-5\">\r\n                ");
#nullable restore
#line 22 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, "Kitap Fiyatı :", new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 23 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.Price, null, new { @class = "col-md-5 form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row form-group ml-5\">\r\n                ");
#nullable restore
#line 26 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, "Kitap Sayfası :", new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.TextBoxFor(x => x.BookPages, null, new { @class = "col-md-5 form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"row form-group ml-5\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.Label(null, "Kitap Açıklaması :", new { @class = "col-md-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 31 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
           Write(Html.TextAreaFor(x => x.Description, 10, 10, new { @class = "col-md-5 form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"d-flex justify-content-end\">\r\n                <input class=\"btn btn-success\" type=\"submit\" value=\"Güncelle\" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
     if (TempData["IslemBasarili"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container mt-2 text-center\">\r\n            <p class=\"alert alert-success font-weight-bolder\">");
#nullable restore
#line 41 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
                                                         Write(TempData["IslemBasarili"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <a class=\"btn btn-primary\" href=\"/Admin/Home/Index\">Kitap Listesi</a>\r\n        </div>\r\n");
#nullable restore
#line 44 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
     if (TempData["IslemBasarisiz"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container mt-2 text-center\">\r\n            <p class=\"alert alert-danger font-weight-bolder\">");
#nullable restore
#line 48 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
                                                        Write(TempData["IslemBasarisiz"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Areas\Admin\Views\Book\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookEcommerce.Areas.Admin.Models.AdminBookEditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
