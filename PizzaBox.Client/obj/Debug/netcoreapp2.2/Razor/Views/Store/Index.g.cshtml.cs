#pragma checksum "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "146db4066b2ed618f42a7a8b6eee1a34cd341742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Index), @"mvc.1.0.view", @"/Views/Store/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/Index.cshtml", typeof(AspNetCore.Views_Store_Index))]
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
#line 1 "C:\Revature\ProjectOne\PizzaBox.Client\Views\_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#line 2 "C:\Revature\ProjectOne\PizzaBox.Client\Views\_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"146db4066b2ed618f42a7a8b6eee1a34cd341742", @"/Views/Store/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Domain.Crust>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\Index.cshtml"
  
  Layout = "../Shared/_NewLayoutHome.cshtml"; 

#line default
#line hidden
            BeginContext(85, 214, true);
            WriteLiteral("\r\n<div class=\"col-md-6\">\r\n<h2>Welcome</h2>\r\n\r\n\r\n<!-- <a href=\"/Home/Login\" >User</a> -->\r\n<a href=\"/Store/StoreOrders\" >See Orders</a>\r\n<!-- <a href=\"/Home/Index\" >Store - Not in service</a> -->\r\n\r\n</div>\r\n<hr>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Domain.Crust> Html { get; private set; }
    }
}
#pragma warning restore 1591
