#pragma checksum "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a4f2b0ff9991154906e4d62765fd1f4046fe4b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/_ViewImports.cshtml"
using RandomPasscode;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/_ViewImports.cshtml"
using RandomPasscode.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a4f2b0ff9991154906e4d62765fd1f4046fe4b6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e42cd7b8af8768fe262a1b538d625ccb9051478f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Passcode Generator";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"jumbotron\"> Random Passcode Generator! (passcode # ");
#nullable restore
#line 7 "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/Home/Index.cshtml"
                                                             Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</h1>\r\n        <div>\r\n            <h3>");
#nullable restore
#line 9 "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/Home/Index.cshtml"
           Write(ViewBag.Passcode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3> \r\n        </div>\r\n    <br>\r\n    <a href=\"/Generate\" class=\"btn btn-md btn-info\" > Generate Passcode! ");
#nullable restore
#line 12 "/Users/franco/coding_dojo/c#/ASP.NET_Core/RandomPasscode/Views/Home/Index.cshtml"
                                                                    Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n    <a href=\"/Reset\" class=\"btn btn-danger\" > Reset Count </a>\r\n</div>\r\n\r\n");
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