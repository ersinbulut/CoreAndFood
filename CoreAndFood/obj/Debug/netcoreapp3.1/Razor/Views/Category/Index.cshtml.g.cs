#pragma checksum "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c97faa1037b6323e339f44c912b7de4097ab8dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c97faa1037b6323e339f44c912b7de4097ab8dd", @"/Views/Category/Index.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Category List</h1>\r\n<br />\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>CATEGORY NAME</th>\r\n        <th>STATUS</th>\r\n        <th>UPDATE</th>\r\n        <th>DELETE</th>\r\n    </tr>\r\n");
#nullable restore
#line 17 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
     foreach (var X in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 20 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(X.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(X.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
           Write(X.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a href=\"#\" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 600, "\"", 642, 2);
            WriteAttributeValue("", 607, "/Category/CategoryGet/", 607, 22, true);
#nullable restore
#line 24 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
WriteAttributeValue("", 629, X.CategoryID, 629, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "D:\YAPTIĞIM PROJELER\Net.Core Projeleri\CoreAndFood\CoreAndFood\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/Category/CategoryAdd\" class=\"btn btn-primary\">New Category</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
