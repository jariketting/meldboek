#pragma checksum "C:\Users\amyno\source\repos\meldboek\Views\Person\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d50a2e7d14510bc3b676e5a8dee93e80c71f6521"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Home), @"mvc.1.0.view", @"/Views/Person/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Home.cshtml", typeof(AspNetCore.Views_Person_Home))]
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
#line 1 "C:\Users\jurri\Desktop\webdev\meldboek3\Views\_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "C:\Users\jurri\Desktop\webdev\meldboek3\Views\_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d50a2e7d14510bc3b676e5a8dee93e80c71f6521", @"/Views/Person/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b303f695a79eb6d1dfd699c250715c9df1ce1a57", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Topbar_Sidenav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 1729, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a2e7d14510bc3b676e5a8dee93e80c71f65215213", async() => {
                BeginContext(31, 31, true);
                WriteLiteral("\r\n    <title>Home</title>\r\n    ");
                EndContext();
                BeginContext(62, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d50a2e7d14510bc3b676e5a8dee93e80c71f65215624", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(133, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(139, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a2e7d14510bc3b676e5a8dee93e80c71f65217044", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(198, 1549, true);
                WriteLiteral(@"
    <style>
        body {
            font-family: 'Trebuchet MS', sans-serif;
            background-color: #ffffff;
        }

        .topbar {
            background-color: #ffffff;
        }

        .content {
            position: relative;
            margin-top: 8%;
        }

        .options {
            padding-left: 37%;
        }

        .button {
            display: block;
            width: 400px;
            color: #ffffff;
            text-decoration: none;
            font-size: 35px;
            text-align: center;
            border: none;
            border-radius: 30px;
            margin-bottom: 30px;
            padding-top: 25px;
            padding-bottom: 25px;
            transition: 0.2s;
        }

        #newsfeed {
            background-color: #3bb546;
        }

        #newsfeed:hover {
            background-color: #9ee0a4;
        }

        #forums {
            background-color: #ff3398;
        }

        #forums:hov");
                WriteLiteral(@"er {
            background-color: #ffa1d0;
        }

        #chat {
            background-color: #0085fe;
        }

        #chat:hover {
            background-color: #9cd0ff;
        }

        #groups {
            background-color: #ff5252;
        }

        #groups:hover {
            background-color: #ffa6a6;
        }

        #personlist {
            background-color: #e947ff;
        }

        #personlist:hover {
            background-color: #f4a3ff;
        }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(1754, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1756, 736, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d50a2e7d14510bc3b676e5a8dee93e80c71f652110767", async() => {
                BeginContext(1762, 165, true);
                WriteLiteral("\r\n    <!-- Bar at the top of the page -->\r\n    <div class=\"topbar\">\r\n\r\n        <!-- Account information button -->\r\n        <a href=\"#accountinfo\"><img id=\"acc-icon\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1927, "\"", 1970, 1);
#line 87 "C:\Users\amyno\source\repos\meldboek\Views\Person\Home.cshtml"
WriteAttributeValue("", 1933, Url.Content("~/Content/account.png"), 1933, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1971, 93, true);
                WriteLiteral(" /></a>\r\n    </div>\r\n    <div class=\"content\">\r\n        <div class=\"options\">\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2064, "\"", 2094, 1);
#line 91 "C:\Users\amyno\source\repos\meldboek\Views\Person\Home.cshtml"
WriteAttributeValue("", 2071, Url.Action("Newsfeed"), 2071, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2095, 190, true);
                WriteLiteral(" class=\"button\" id=\"newsfeed\">Newsfeed</a>\r\n            <a href=\"#forums\" class=\"button\" id=\"forums\">Forums</a>\r\n            <a href=\"#chat\" class=\"button\" id=\"chat\">Chat</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2285, "\"", 2314, 1);
#line 94 "C:\Users\amyno\source\repos\meldboek\Views\Person\Home.cshtml"
WriteAttributeValue("", 2292, Url.Action("Groepen"), 2292, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2315, 55, true);
                WriteLiteral(" class=\"button\" id=\"groups\">Groepen</a>\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2370, "\"", 2402, 1);
#line 95 "C:\Users\amyno\source\repos\meldboek\Views\Person\Home.cshtml"
WriteAttributeValue("", 2377, Url.Action("Personlist"), 2377, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2403, 82, true);
                WriteLiteral(" class=\"button\" id=\"personlist\">Gebruikers</a>\r\n        </div>\r\n    </div>\r\n    \r\n");
                EndContext();
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
            EndContext();
            BeginContext(2492, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
