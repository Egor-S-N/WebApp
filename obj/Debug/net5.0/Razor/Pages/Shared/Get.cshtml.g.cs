#pragma checksum "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1207aa77ab8a14bdda05ca014de30b9ba1ee6bfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_Get), @"mvc.1.0.view", @"/Pages/Shared/Get.cshtml")]
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
#line 1 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
using WebProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1207aa77ab8a14bdda05ca014de30b9ba1ee6bfe", @"/Pages/Shared/Get.cshtml")]
    public class Pages_Shared_Get : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProject.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Таблица пользоватаелей</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 12 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
       Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
     foreach (var item in ViewBag.UserName) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 23 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
           Write(item.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        <td>\r\n");
            WriteLiteral("        </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "D:\VS_PROJECTS\WebProject\Pages\Shared\Get.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProject.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
