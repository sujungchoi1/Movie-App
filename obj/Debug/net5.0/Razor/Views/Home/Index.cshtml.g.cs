#pragma checksum "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865b826c5d5b5d7be68185e7c77ef941acd38ae5"
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
#line 1 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865b826c5d5b5d7be68185e7c77ef941acd38ae5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Result>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavbarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "865b826c5d5b5d7be68185e7c77ef941acd38ae54491", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "865b826c5d5b5d7be68185e7c77ef941acd38ae54930", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.13.0/css/all.css"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.13.0/css/v4-shims.css"">
    <link rel=""stylesheet"" href=""/css/index.css"">
    <title>CinePhil</title>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
  
    int[] pages = new int[]
    {
        1,2,3,4,5,6,7,8,9,10
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "865b826c5d5b5d7be68185e7c77ef941acd38ae57325", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper container-fluid\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "865b826c5d5b5d7be68185e7c77ef941acd38ae57636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</partial>\r\n");
                WriteLiteral("\r\n            <div class=\"filterButtons btn-group\" role=\"group\">\r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 32 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 if(ViewBag.upcoming == true)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a href=\"/\" class=\"btn btn-outline-secondary\">Top Rated</a>    \r\n                <a href=\"/upcoming\" class=\"btn btn-secondary\">Upcoming</a>\r\n");
#nullable restore
#line 36 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a href=\"/\" class=\"btn btn-secondary\">Top Rated</a>\r\n                <a href=\"/upcoming\" class=\"btn btn-outline-secondary\">Upcoming</a>\r\n");
#nullable restore
#line 41 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <a href=\"/random\" class=\"btn btn-outline-secondary\">Want Suggestions?</a>\r\n");
                WriteLiteral("            </div>\r\n");
                WriteLiteral("        <div class=\"mainGroup d-flex flex-wrap justify-content-md-between justify-content-center\">\r\n            <div class=\"row row-cols-1 row-cols-sm-2 row-cols-md-4\">\r\n\r\n");
#nullable restore
#line 55 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 foreach (var r in Model)
                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-sm-6 col-md-3\">\r\n                        <div class=\"card\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2301, "\"", 2320, 2);
                WriteAttributeValue("", 2308, "/movie/", 2308, 7, true);
#nullable restore
#line 60 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 2315, r.id, 2315, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 61 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                     if(@r.poster_path == null)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <img src=\"https://image.tmdb.org/t/p/w500/zYPsleQJo1n1rBPlecJBRb3iwSO.jpg\" class=\"card-img-top\"");
                BeginWriteAttribute("alt", " alt=\"", 2563, "\"", 2577, 1);
#nullable restore
#line 63 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 2569, r.title, 2569, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 64 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <img");
                BeginWriteAttribute("src", " src=\"", 2741, "\"", 2793, 2);
                WriteAttributeValue("", 2747, "https://image.tmdb.org/t/p/w500/", 2747, 32, true);
#nullable restore
#line 67 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 2779, r.poster_path, 2779, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\"");
                BeginWriteAttribute("alt", " alt=\"", 2815, "\"", 2829, 1);
#nullable restore
#line 67 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 2821, r.title, 2821, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 68 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </a>
                            
                            <div class=""cardBody card-body"">
                                <div style=""display:flex;justify-content:space-between"">

                                    <div class=""title mb-1 mr-4 card-title"">");
#nullable restore
#line 74 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                                                       Write(r.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 75 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                     if(@r.vote_average > 7)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span class=\"rating card-text\" style=\"border:3px double forestGreen;\">");
#nullable restore
#line 77 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                                                                                     Write(r.vote_average);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 78 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                    }
                                    else if(@r.vote_average > 5)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span class=\"rating card-text\" style=\"border:3px double rgb(216, 203, 54);\">");
#nullable restore
#line 81 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                                                                                           Write(r.vote_average);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 82 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span class=\"rating card-text\" style=\"border:3px double darkOrange;\">");
#nullable restore
#line 85 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                                                                                    Write(r.vote_average);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 86 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n");
                WriteLiteral("                            </div>\r\n");
                WriteLiteral("                            \r\n");
                WriteLiteral("                            \r\n");
                WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 119 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                    
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n        \r\n");
                WriteLiteral("        <div class=\"pages\">\r\n");
#nullable restore
#line 131 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
             if(ViewBag.upcoming != true)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 foreach (var p in pages)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                     if(ViewBag.currentPage == @p || ViewBag.currentPage == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 6149, "\"", 6159, 2);
                WriteAttributeValue("", 6156, "/", 6156, 1, true);
#nullable restore
#line 137 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 6157, p, 6157, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 137 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                 Write(p);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 138 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 6267, "\"", 6277, 2);
                WriteAttributeValue("", 6274, "/", 6274, 1, true);
#nullable restore
#line 141 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 6275, p, 6275, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"text-decoration:underline\">");
#nullable restore
#line 141 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                                                   Write(p);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 142 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 if(@p != 10)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=divider></div>\r\n");
#nullable restore
#line 146 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 
            }
            else if(ViewBag.upcoming == true)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 foreach (var p in pages)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 153 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                     if(ViewBag.upcomingPage == @p || ViewBag.upcomingPage == null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 6752, "\"", 6771, 2);
                WriteAttributeValue("", 6759, "/upcoming/", 6759, 10, true);
#nullable restore
#line 155 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 6769, p, 6769, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 155 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                          Write(p);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 156 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 6879, "\"", 6898, 2);
                WriteAttributeValue("", 6886, "/upcoming/", 6886, 10, true);
#nullable restore
#line 159 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
WriteAttributeValue("", 6896, p, 6896, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"text-decoration:underline\">");
#nullable restore
#line 159 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                                                                            Write(p);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 160 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 if(@p != 10)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=divider></div>\r\n");
#nullable restore
#line 164 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 164 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591