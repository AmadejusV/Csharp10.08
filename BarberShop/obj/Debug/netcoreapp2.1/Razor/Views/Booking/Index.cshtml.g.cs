#pragma checksum "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1a6d064c4a4f6ae5a6d29f8a1ff42a01f9fd57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Index), @"mvc.1.0.view", @"/Views/Booking/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Index.cshtml", typeof(AspNetCore.Views_Booking_Index))]
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
#line 2 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\_ViewImports.cshtml"
using BarberShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1a6d064c4a4f6ae5a6d29f8a1ff42a01f9fd57", @"/Views/Booking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"474866b33f049e4c4d843d78523150c894d43008", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 335, true);
            WriteLiteral(@"
<h2>Available bookings</h2>

<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Barber</th>
            <th scope=""col"">Time</th>
            <th scope=""col"">Status</th>
            <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
           
            int i = 0;
        

#line default
#line hidden
            BeginContext(450, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 24 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
         foreach(var item in Model)
        {
          i++;

#line default
#line hidden
            BeginContext(514, 42, true);
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
            EndContext();
            BeginContext(557, 1, false);
#line 28 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
                       Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(558, 23, true);
            WriteLiteral("</th>\r\n            <td>");
            EndContext();
            BeginContext(582, 16, false);
#line 29 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
           Write(item.Barber.Name);

#line default
#line hidden
            EndContext();
            BeginContext(598, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(622, 29, false);
#line 30 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
           Write(item.AvailableTime.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(651, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(675, 29, false);
#line 31 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
           Write(item.BookingStatus.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(704, 70, true);
            WriteLiteral("</td>\r\n            <td><a href=\"#\">more info</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "C:\Users\Moksleivis\source\repos\BarberShop\BarberShop\Views\Booking\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(785, 32, true);
            WriteLiteral("        \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
