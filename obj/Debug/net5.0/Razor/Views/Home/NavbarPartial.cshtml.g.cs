#pragma checksum "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/NavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "589304509188d02941aaa6ef5b3575a0e7db4718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NavbarPartial), @"mvc.1.0.view", @"/Views/Home/NavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"589304509188d02941aaa6ef5b3575a0e7db4718", @"/Views/Home/NavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0301d5cca4a9345895d039cc67d16e7b77f0437f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\n    .header {\n    color: white;\n    background-color: rgb(33, 33, 33, 0.8);\n    height: 12vh;\n");
            WriteLiteral("    }\n    .userHeader {\n    display: flex;\n");
            WriteLiteral(@"    align-items: baseline;
    style=""font-family: 'Nunito', sans-serif;""
    }
    .userHeader p {
        margin-right: 20px;
        font-size: 1.4vw;
    }
    .userHeader i {
        font-size: 1.5vw;
        margin: 7px 10px 0 14px;
    }
    .github_icon{
        color:white;
        font-size: 23px;
        margin-right: 22px;
    }
</style>

<nav class=""header navbar fixed-top navbar-expand-lg navbar-light"">
            <div class=""container-fluid"">
                <a class=""navbar-brand"" href=""/"" style=""color:white;font-size:34px""><i class=""fa fa-video"" style=""margin-right: 10px""></i>CinePhil</a>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
");
            WriteLiteral("                    \n\n                        <li class=\"nav-item\">\n                \n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "589304509188d02941aaa6ef5b3575a0e7db47184966", async() => {
                WriteLiteral("\n                        \n                        <input name=\"searchTitle\" class=\"form-control me-2\" type=\"search\" placeholder=\"Search by movie title\" style=\"width: 230px;margin-left:20px\">\n");
                WriteLiteral("                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1330, "/search/{", 1330, 9, true);
#nullable restore
#line 43 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/NavbarPartial.cshtml"
AddHtmlAttributeValue("", 1339, ViewBag.title, 1339, 14, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1353, "}", 1353, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n");
            WriteLiteral(@"                    

                        </li>
                    
                    
                        
                        <li class=""nav-item""><a href=""https://www.themoviedb.org"" style=""margin-left:25px"" target=""_blank"" rel=""noreferrer noopener"">
                            <img src=""/img/blue_square.svg"" alt=""tmdbIcon"" style=""width:60px"">
                            </a> </li>
                    </ul>
                    <div class=""justify-content-end collapse navbar-collapse"">
                        <ul class=""navbar-nav"">
                        <li class=""nav-item"">
");
#nullable restore
#line 63 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/NavbarPartial.cshtml"
                             if(ViewBag.currentUser == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <a href=""https://github.com/sujungchoi1/Movie-App"" class=""github_icon"" target=""_blank"" rel=""noreferrer noopener""><i class=""fa fa-github""></i></a>
                            <a href=""/login"" class=""btn btn-primary"" style=""font-family: 'Nunito', sans-serif;"">SIGN IN</a>
");
#nullable restore
#line 67 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/NavbarPartial.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"userHeader\">\n\n                                <p>Welcome, ");
#nullable restore
#line 72 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/NavbarPartial.cshtml"
                                       Write(ViewBag.currentUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("! <a href=\"/dashboard\"><i class=\"far fa-list-alt\"></i>Dashboard</a></p>\n                                <a href=\"/logout\" class=\"btn btn-danger\" style=\"font-family: \'Nunito\', sans-serif;\">LOG OUT</a>\n                                </div>\n");
#nullable restore
#line 75 "/Users/sujungchoi/Desktop/Coding/C#/MovieApp/Views/Home/NavbarPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </li>\n                    </ul>\n                    </div>\n                </div>\n            </div>\n        </nav>");
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