#pragma checksum "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4963df3741ec2b40283153346cde7f03d97fb06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.ViewModels.Home;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4963df3741ec2b40283153346cde7f03d97fb06", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b15004c464d994246673352a0cc95011cad71f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Group>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\Home\Detail.cshtml"
   
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Car Models</h2>\r\n\r\n<a  href=\"https://turbo.az/autos/6733390-mercedes-e-300\">");
#nullable restore
#line 8 "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\Home\Detail.cshtml"
                                                    Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n<a  href=\"https://turbo.az/autos/6649179-audi-a7-sportback\">");
#nullable restore
#line 9 "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\Home\Detail.cshtml"
                                                       Write(Model.Model1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n<a  href=\"https://turbo.az/autos/6768428-hyundai-venue\">");
#nullable restore
#line 10 "C:\Users\ACER\source\repos\WebApplication3\WebApplication3\Views\Home\Detail.cshtml"
                                                   Write(Model.Model2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Group> Html { get; private set; }
    }
}
#pragma warning restore 1591
