#pragma checksum "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bdec4bacaedf820f45a2ce7ff409a113ba6ef2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\_ViewImports.cshtml"
using BookEcommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\_ViewImports.cshtml"
using BookEcommerce.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\_ViewImports.cshtml"
using BookEcommerce.Areas.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bdec4bacaedf820f45a2ce7ff409a113ba6ef2d", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69351e9f8baa2d5322a6e4c777b4d79ba9ad7209", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container  text-dark pt-5 border border-dark mt-5 \">\r\n        <div class=\"ml-5\">\r\n            <div class=\"row\">\r\n                <div class=\"col-12 col-sm-6 ml-4\">\r\n                    <h1>Kayıt Ol</h1>\r\n                    ");
#nullable restore
#line 14 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
               Write(Html.ValidationMessage("Kayıt Hatası"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\" form-group\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.Label(null, "Email"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 17 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.Email, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 18 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Email, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\" form-group\">\r\n                        ");
#nullable restore
#line 21 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.Label(null, "Kullanıcı Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 22 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.UserName, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 23 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserName, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\" form-group\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.Label(null, "Adı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 27 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.FirstName, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 28 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.FirstName, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\" form-group\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.Label(null, "Soyadı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 32 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.LastName, null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 33 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.LastName, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\" form-group\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.Label(null, "Şifre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 37 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.Password, null, new { @class = " form-control", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Password, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\" form-group\">\r\n                        ");
#nullable restore
#line 42 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.Label(null, "Şifre Tekrarı"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 43 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.TextBoxFor(x => x.ConfirmPassword, null, new { @class = " form-control", type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.ConfirmPassword, null, new { @class = "col-md-3 text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>

                    <div class=""form-group d-flex justify-content-end"">
                        <input type=""submit"" value=""Kaydol"" class=""btn btn-success"" />
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 54 "C:\Users\Fatih\Desktop\BookEcommerce\BookEcommerce\Views\Account\Register.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
