#pragma checksum "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f60cc249158ce994e0afd290d77c406fbb5a6d9da3968ddf58903531e0389824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessageNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\_ViewImports.cshtml"
using StajProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\_ViewImports.cshtml"
using StajProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f60cc249158ce994e0afd290d77c406fbb5a6d9da3968ddf58903531e0389824", @"/Views/Shared/Components/WriterMessageNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4d8656fe9b109d26623f7d187450488263bd01290b8ab33a910f51884621c14b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterMessageNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n\t<h6 class=\"p-3 mb-0\">Mesajlar</h6>\r\n\t<div class=\"dropdown-divider\"></div>\r\n");
#nullable restore
#line 7 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
  foreach(var item in Model)
	{	

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<a class=\"dropdown-item preview-item\">\r\n\t\t<div class=\"preview-thumbnail\">\r\n\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 360, "\"", 394, 1);
#nullable restore
#line 11 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
WriteAttributeValue("", 366, item.SenderUser.WriterImage, 366, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"image\" class=\"profile-pic\">\r\n\t\t</div>\r\n\t\t<div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n\t\t\t<h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 14 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                                                           Write(item.SenderUser.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" sana mesaj gönderdi</h6>\r\n\t\t\t<p class=\"text-gray mb-0\"> ");
#nullable restore
#line 15 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
                         Write(item.MessageDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\t\t</div>\r\n\t</a>\r\n");
#nullable restore
#line 18 "C:\Users\e_741\source\repos\StajProje\StajProje\Views\Shared\Components\WriterMessageNotification\Default.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"dropdown-divider\"></div>\r\n\t<h6 class=\"p-3 mb-0 text-center\">3 Yeni Mesaj</h6>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
