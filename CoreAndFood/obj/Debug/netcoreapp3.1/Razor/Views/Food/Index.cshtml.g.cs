#pragma checksum "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7a231a4bedfd81bddf3932ce5186bf5489e28a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7a231a4bedfd81bddf3932ce5186bf5489e28a1", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>


<h1>Category List</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>FOOD NAME</th>
        <th>PRİCE</th>
        <th>STOCK</th>
        <th>CATEGORY NAME</th>
        <th>UPDATE</th>
        <th>DELETE</th>
        <th>DETAİLS</th>
    </tr>
");
#nullable restore
#line 24 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var X in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 27 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(X.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 28 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(X.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(X.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(X.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
           Write(X.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-success\">Update</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-info\">Details</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"#\" class=\"btn btn-primary\">New Food</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
