#pragma checksum "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5afc3803a2d036b2b54370753707c52340e1b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5afc3803a2d036b2b54370753707c52340e1b8", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Watch>
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
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5afc3803a2d036b2b54370753707c52340e1b84494", async() => {
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f5afc3803a2d036b2b54370753707c52340e1b84925", async() => {
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
    <link rel=""stylesheet"" href=""/css/dashboard.css"">
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
            WriteLiteral("\n");
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5afc3803a2d036b2b54370753707c52340e1b87092", async() => {
                WriteLiteral("\n    <div class=\"wrapper container-fluid\">\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6f5afc3803a2d036b2b54370753707c52340e1b87399", async() => {
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
                WriteLiteral("</partial>\n");
                WriteLiteral("        <div class=\"main\">\n            <h1 class=\"dashboardHeader\">Check out your saved movies, ");
#nullable restore
#line 22 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                                                                Write(ViewBag.CurrentUser.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("!</h1>\n        <table class=\"table\">\n            <tr>\n                <th>Movie Title</th>\n");
                WriteLiteral("                <th>Movie Added at</th>\n                <th>Action</th>\n            </tr>\n");
#nullable restore
#line 30 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
             foreach(var w in ViewBag.MoviesToWatch)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                 if(@ViewBag.CurrentUser.UserId == w.UserWhoWatches.UserId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1264, "\"", 1288, 2);
                WriteAttributeValue("", 1271, "/movie/", 1271, 7, true);
#nullable restore
#line 35 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1278, w.MovieId, 1278, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 35 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                                               Write(w.MovieTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\n");
                WriteLiteral("\n");
                WriteLiteral("                    <td>");
#nullable restore
#line 40 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                   Write(w.CreatedAt.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1532, "\"", 1576, 5);
                WriteAttributeValue("", 1539, "watch/", 1539, 6, true);
#nullable restore
#line 41 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1545, w.MovieId, 1545, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1555, "/", 1555, 1, true);
#nullable restore
#line 41 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1556, w.MovieTitle, 1556, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1569, "/delete", 1569, 7, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-trash-alt\"></i></a></td> \n                    </tr>\n");
#nullable restore
#line 43 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                 
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\n\n        <ul class=\"likeClass\"><i class=\"fa fa-heart\" style=\"color: pink\"></i> by you \n");
#nullable restore
#line 48 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
             foreach (var l in ViewBag.MovieLikes)
            {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
             if(@ViewBag.CurrentUser.UserId == l.UserWhoLikes.UserId)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <li class=\"likeLiClass\"><a");
                BeginWriteAttribute("href", " href=\"", 1977, "\"", 2001, 2);
                WriteAttributeValue("", 1984, "/movie/", 1984, 7, true);
#nullable restore
#line 52 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1991, l.MovieId, 1991, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 52 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
                                                               Write(l.MovieTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a> <a");
                BeginWriteAttribute("href", " href=\"", 2023, "\"", 2066, 5);
                WriteAttributeValue("", 2030, "like/", 2030, 5, true);
#nullable restore
#line 52 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2035, l.MovieId, 2035, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2045, "/", 2045, 1, true);
#nullable restore
#line 52 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2046, l.MovieTitle, 2046, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2059, "/delete", 2059, 7, true);
                EndWriteAttribute();
                WriteLiteral("><i class=\"fa fa-heart-broken\"></i></a> </li>\n");
#nullable restore
#line 53 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/sujungchoi/Desktop/Coding/C#/Movie-App/Views/Home/Dashboard.cshtml"
             
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </ul>\n            \n        </div>\n\n\n\n\n\n    </div>\n");
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
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Watch> Html { get; private set; }
    }
}
#pragma warning restore 1591
