#pragma checksum "C:\Revature\ProjectOne\PizzaBox.Client\Views\User\ViewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b94c7712cd67ead7c55a2f4eea457fa086b86a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewUser), @"mvc.1.0.view", @"/Views/User/ViewUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/ViewUser.cshtml", typeof(AspNetCore.Views_User_ViewUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b94c7712cd67ead7c55a2f4eea457fa086b86a01", @"/Views/User/ViewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaBox.Domain.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 30, true);
            WriteLiteral("<!-- STRONGLY TYPED VIEW -->\r\n");
            EndContext();
            BeginContext(65, 5, true);
            WriteLiteral("<!-- ");
            EndContext();
            BeginContext(71, 5, false);
#line 3 "C:\Revature\ProjectOne\PizzaBox.Client\Views\User\ViewUser.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(76, 21, true);
            WriteLiteral(" List<string> -->\r\n\r\n");
            EndContext();
#line 5 "C:\Revature\ProjectOne\PizzaBox.Client\Views\User\ViewUser.cshtml"
  
  Layout = "../Shared/_NewLayoutHome.cshtml"; //"../Shared/_NewLayout.cshtml";

#line default
#line hidden
            BeginContext(184, 37, true);
            WriteLiteral("\r\n<!-- Dynamic List -->\r\n\r\n      <ul>");
            EndContext();
#line 11 "C:\Revature\ProjectOne\PizzaBox.Client\Views\User\ViewUser.cshtml"
            
      
      foreach (var item in Model)
      {

#line default
#line hidden
            BeginContext(277, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(290, 13, false);
#line 15 "C:\Revature\ProjectOne\PizzaBox.Client\Views\User\ViewUser.cshtml"
       Write(item.Username);

#line default
#line hidden
            EndContext();
            BeginContext(303, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 16 "C:\Revature\ProjectOne\PizzaBox.Client\Views\User\ViewUser.cshtml"
      }
    

#line default
#line hidden
            BeginContext(324, 93, true);
            WriteLiteral("</ul>\r\n\r\n    \r\n<a title=\"home\" href=\"/home/index\" >Home</a>\r\n\r\n<div class=\"col-md-6\"></div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaBox.Domain.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
