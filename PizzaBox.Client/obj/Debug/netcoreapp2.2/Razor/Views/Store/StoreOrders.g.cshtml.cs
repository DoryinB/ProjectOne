#pragma checksum "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1817eea78d105dbd067ca7be91742c7f5bd2c0e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_StoreOrders), @"mvc.1.0.view", @"/Views/Store/StoreOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Store/StoreOrders.cshtml", typeof(AspNetCore.Views_Store_StoreOrders))]
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
#line 1 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
using PizzaBox.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1817eea78d105dbd067ca7be91742c7f5bd2c0e0", @"/Views/Store/StoreOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_StoreOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Int32>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 46, true);
            WriteLiteral("\r\n<!-- model List<PizzaBox.Domain.Pizza> -->\r\n");
            EndContext();
            BeginContext(89, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
  
  Layout = "../Shared/_NewLayoutHome.cshtml"; 
  PizzaBoxDbContext _db = new PizzaBoxDbContext();

#line default
#line hidden
            BeginContext(198, 60, true);
            WriteLiteral("\r\n<div class=\"col-md-6\">\r\n<h2>You have selected a</h2>\r\n  \r\n");
            EndContext();
#line 14 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
    
    foreach(var p in _db.Pizza.ToList())
    {
      foreach(var o in _db.Order.ToList())
      {
        foreach(var l in _db.Location.ToList())
        {
          if(l.StoreId==Model)
          {
            if(o.LocationId==l.LocationId)
            {
              if(p.OrderId==o.OrderId)
              
              {
                foreach (var s in _db.Size.ToList())
                {
                  if(s.SizeId==p.SizeId)
                  {

#line default
#line hidden
            BeginContext(737, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(741, 10, false);
#line 31 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
                 Write(s.SizeName);

#line default
#line hidden
            EndContext();
            BeginContext(751, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 31 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
                                     }
                }
                foreach (var c in _db.Crust.ToList())
                {
                  if(c.CrustId==@p.CrustId)
                  {

#line default
#line hidden
            BeginContext(915, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(919, 11, false);
#line 36 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
                 Write(c.CrustName);

#line default
#line hidden
            EndContext();
            BeginContext(930, 48, true);
            WriteLiteral("</p>\r\n                   <p>crust pizza with</p>");
            EndContext();
#line 37 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
                                          }
                }
          //----------------
              foreach (var tO in _db.ToppingsOrder.ToList())
              {
                if (p.PizzaId==tO.PizzaId)
                {
                  foreach (var top in _db.Topping.ToList())
                  {
                    if(tO.ToppingId==top.ToppingId)
                    {

#line default
#line hidden
            BeginContext(1328, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(1332, 16, false);
#line 47 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
                   Write(top.ToppingsName);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 4, true);
            WriteLiteral("</p>");
            EndContext();
#line 47 "C:\Revature\ProjectOne\PizzaBox.Client\Views\Store\StoreOrders.cshtml"
                                             }
                  }
                }
              }
        //----------------
              }
            }
          }
        }
      }
    }
  

#line default
#line hidden
            BeginContext(1517, 173, true);
            WriteLiteral("\r\n  <!-- <h2>Model.SizeId</h2>\r\n  <h2>Model.CrustId</h2> -->\r\n  \r\n  \r\n\r\n  \r\n\r\n\r\n<!-- <a href=\"/Home/Login\" >User</a> -->\r\n<a href=\"/Home/Index\" >Home</a>\r\n\r\n</div>\r\n<hr>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Int32> Html { get; private set; }
    }
}
#pragma warning restore 1591
