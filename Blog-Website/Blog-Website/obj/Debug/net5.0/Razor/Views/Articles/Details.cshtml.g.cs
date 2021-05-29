#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ebce1abcf16d294d36c9ae0f69cf1cada3ed003"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Articles_Details), @"mvc.1.0.view", @"/Views/Articles/Details.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\_ViewImports.cshtml"
using Blog_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\_ViewImports.cshtml"
using Blog_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebce1abcf16d294d36c9ae0f69cf1cada3ed003", @"/Views/Articles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ce68408b60501a57e44302d66da5f8e6f51ba7", @"/Views/_ViewImports.cshtml")]
    public class Views_Articles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
  
    var Articles = (List<ArticlesModel>) ViewData["Articles"];
    var authors =(List<UserModel>)ViewData["authors"];
    var id = (int)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
 foreach (var Article in Articles)
{
    if (id == Article.Article_id)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card mb-3\">\r\n            <img");
            BeginWriteAttribute("src", " src=", 296, "", 323, 1);
#nullable restore
#line 13 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
WriteAttributeValue("", 301, Article.Article_image, 301, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\" style=\"max-height:550px\">\r\n            <div class=\"card-body\">\r\n                <h1 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
                                  Write(Article.Article_title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                <p>\r\n                    ");
#nullable restore
#line 18 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
               Write(Article.Article_content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n");
#nullable restore
#line 20 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
                 foreach (var author in authors)
                {
                    if (Article.User_id == author.User_id)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <br />\r\n                        <p class=\"fw-light\" style=\"font-weight:bold\">");
#nullable restore
#line 25 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
                                                                Write(author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"card-text\"><small class=\"text-muted\">Create At ");
#nullable restore
#line 28 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"
                                                                    Write(Article.Created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project01_ASP.NET_MVC\Blog-Website\Blog-Website\Views\Articles\Details.cshtml"

    }



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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