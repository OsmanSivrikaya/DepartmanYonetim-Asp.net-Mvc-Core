#pragma checksum "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e8576777e8e9fa28b25971f6f356c442c88b6f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_BirimDetay), @"mvc.1.0.view", @"/Views/Depart/BirimDetay.cshtml")]
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
#line 1 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\_ViewImports.cshtml"
using CoreDepartman;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
using CoreDepartman.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e8576777e8e9fa28b25971f6f356c442c88b6f8", @"/Views/Depart/BirimDetay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244fa5d166229326930cbe183019d72d2c0ef836", @"/Views/_ViewImports.cshtml")]
    public class Views_Depart_BirimDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
  
    ViewData["Title"] = "BirimDetay";
    Layout = "~/Views/Shared/_testLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""container"">
    <div class=""row my-2"">
        <div class=""col"">
            <table class=""table table-bordered"">
                <tr>
                    <th>Personel ID</th>
                    <th>Personel Ad</th>
                    <th>Personel Soyad</th>
                    <th>Personel Şehir</th>
                    <th>Personel Departman</th>
                </tr>
");
#nullable restore
#line 19 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                  
                    foreach (var p in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                           Write(p.PersonelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                           Write(p.PerAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 25 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                           Write(p.PerSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                           Write(p.PerSehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                           Write(ViewBag.brmad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\osman\Desktop\CoreDepartman-Asp.net-Mvc-Core\CoreDepartman\Views\Depart\BirimDetay.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
