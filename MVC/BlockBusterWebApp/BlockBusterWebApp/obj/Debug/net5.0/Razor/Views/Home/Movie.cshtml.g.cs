#pragma checksum "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\Home\Movie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aba39ea3917cef5e119469251bcef88921c98ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Movie), @"mvc.1.0.view", @"/Views/Home/Movie.cshtml")]
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
#line 1 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\_ViewImports.cshtml"
using BlockBusterWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\_ViewImports.cshtml"
using BlockBusterWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5aba39ea3917cef5e119469251bcef88921c98ad", @"/Views/Home/Movie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d10c8c8c48ad826dfa57ae5a563a1455809aff8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Movie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\Home\Movie.cshtml"
    ViewData["title"] = "Movies";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\Home\Movie.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Here are a list of Movies</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 10 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\Home\Movie.cshtml"
       foreach (var movie in ViewBag.movie)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 12 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\Home\Movie.cshtml"
           Write(movie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 13 "C:\Users\008007049\source\repos\Advanced.Net\MVC\BlockBusterWebApp\BlockBusterWebApp\Views\Home\Movie.cshtml"
        }

    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
