#pragma checksum "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b793fb08b0664cfe96c8235030bbdea2b83f1bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Newsfeed), @"mvc.1.0.view", @"/Views/User/Newsfeed.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Newsfeed.cshtml", typeof(AspNetCore.Views_User_Newsfeed))]
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
#line 1 "C:\Users\amyno\source\repos\meldboek\Views\_ViewImports.cshtml"
using meldboek;

#line default
#line hidden
#line 2 "C:\Users\amyno\source\repos\meldboek\Views\_ViewImports.cshtml"
using meldboek.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b793fb08b0664cfe96c8235030bbdea2b83f1bca", @"/Views/User/Newsfeed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b303f695a79eb6d1dfd699c250715c9df1ce1a57", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Newsfeed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Topbar_Sidenav.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("general"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("general"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("add-article"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<!-- model IEnumerable<Newspost> -->\r\n");
            EndContext();
            BeginContext(54, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(81, 3374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b793fb08b0664cfe96c8235030bbdea2b83f1bca7468", async() => {
                BeginContext(87, 35, true);
                WriteLiteral("\r\n    <title>Newsfeed</title>\r\n    ");
                EndContext();
                BeginContext(122, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b793fb08b0664cfe96c8235030bbdea2b83f1bca7884", async() => {
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
                BeginContext(193, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(199, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b793fb08b0664cfe96c8235030bbdea2b83f1bca9304", async() => {
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
                BeginContext(258, 3190, true);
                WriteLiteral(@"
    <style>
        body {
            font-family: 'Trebuchet MS', sans-serif;
            background-color: #ffffff;
        }

        .topbar {
            background-color: #3bb546;
        }

        .navbtn {
            background-color: #3bb546;
        }

        .overlay {
            background-color: #3bb546;
        }

        .overlay a:hover, .overlay a:focus, .logout a:hover, .logout a:focus {
            color: #9ee0a4;
        }

        .newsfeed-content {
            width: 100%;
            overflow: hidden;
            padding-top: 100px;
            padding-bottom: 50px;
        }

        /* Categories list */
        .categories {
            position: fixed;
            float: left;
            width: 200px;
            height: 550px;
            padding-top: 80px;
            padding-left: 50px;
            border-right: 2px solid #3bb546;
        }

        .categories a {
            color: #000000;
            font-size: 24px;
       ");
                WriteLiteral(@"     text-decoration: none;
            display: block;
            padding-bottom: 15px;
            width: 105px;
        }

        .categories a:hover {
             color: #9ee0a4;
        }

        .page-title {
            font-size: 28px;
            padding-bottom: 20px;
        }

        /* Articles list */
        .articles-list {
            padding-top: 40px;
            margin-left: 350px;
        }

        /* Single article */
        .article {
            width: 90%;
            overflow: hidden;
            padding-bottom: 5px;
            border-bottom: 1px solid #3bb546;
        }

        /* Article content consists of title (h1) and author + date (h3). */
        .article-content {
            float: left;
        }

        .article-content h1 {
            font-size: 28px;
            padding-bottom: 15px;
            padding-top: 40px;
        }

        .article-content h3 {
            font-size: 20px;
            padding-bottom: 10px;
 ");
                WriteLiteral(@"       }
        
        .article-content p {
            color: #000000;
            font-size: 18px;
            padding-bottom: 10px;
        }

        /* Form to add an article'. */
        .add-article {
            width: 90%;
            font-size: 18px;
            padding-bottom: 20px;
        }

        input[type=text], select, textarea {
            font-family: 'Trebuchet MS', sans-serif;
            font-size: 16px;
            width: 100%;
            padding: 12px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
            margin-top: 6px;
            margin-bottom: 16px;
            resize: vertical;
        }

        input[type=submit] {
            font-family: 'Trebuchet MS', sans-serif;
            background-color: #3bb546;
            color: white;
            font-size: 18px;
            border-radius: 25px;
            padding: 10px 15px;
            border: none;
            cursor: pointe");
                WriteLiteral("r;\r\n        }\r\n\r\n        input[type=submit]:hover {\r\n            background-color: #9ee0a4;\r\n        }\r\n    </style>\r\n");
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
            BeginContext(3455, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3457, 3238, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b793fb08b0664cfe96c8235030bbdea2b83f1bca14754", async() => {
                BeginContext(3463, 348, true);
                WriteLiteral(@"
    <!-- Colored bar at the top of the page -->
    <div class=""topbar"">

        <!-- The button that opens the sidemenu -->
        <span class=""navbtn"" onclick=""nav()"">&#9776; </span>

        <!-- Page title -->
        <h1>Newsfeed</h1>

        <!-- Account information button -->
        <a href=""#accountinfo""><img id=""acc-icon""");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 3811, "\"", 3854, 1);
#line 151 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
WriteAttributeValue("", 3817, Url.Content("~/Content/account.png"), 3817, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3855, 690, true);
                WriteLiteral(@"/></a>
    </div>

    <!-- Sidemenu overlay -->
    <div id=""nav"" class=""overlay"">
        <div class=""overlay-content"">
            <p style=""color: #9ee0a4;"">Newsfeed</p>
            <br>
            <a onclick=""nav()"" href=""#forums"">Forums</a>
            <br>
            <a onclick=""nav()"" href=""#chat"">Chat</a>
            <br>
            <a onclick=""nav()"" href=""#groups"">Groepen</a>
        </div>
        <div class=""logout""><a onclick=""nav()"" href=""#logout"">Log uit</a></div>
    </div>

    <!-- All the actual content of the page -->
    <div class=""newsfeed-content"">

        <!-- Newsfeed categories -->
        <div class=""categories"">
            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4545, "\"", 4612, 1);
#line 173 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
WriteAttributeValue("", 4552, Url.Action("FilteredNewsfeed", new { filter = "Algemeen" }), 4552, 60, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4613, 21, true);
                WriteLiteral(">Algemeen</a>\r\n    \r\n");
                EndContext();
#line 175 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
             foreach (var group in Model.Group)
            {

#line default
#line hidden
                BeginContext(4698, 18, true);
                WriteLiteral("                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4716, "\"", 4788, 1);
#line 177 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
WriteAttributeValue("", 4723, Url.Action("FilteredNewsfeed", new { filter = group.GroupName }), 4723, 65, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4789, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(4791, 15, false);
#line 177 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                                                                                       Write(group.GroupName);

#line default
#line hidden
                EndContext();
                BeginContext(4806, 6, true);
                WriteLiteral("</a>\r\n");
                EndContext();
#line 178 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
            }

#line default
#line hidden
                BeginContext(4827, 16, true);
                WriteLiteral("\r\n            <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4843, "\"", 4909, 1);
#line 180 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
WriteAttributeValue("", 4850, Url.Action("FilteredNewsfeed", new { filter = "Vrienden"}), 4850, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4910, 114, true);
                WriteLiteral(">Vrienden</a> \r\n        </div>\r\n\r\n        <div class=\"articles-list\">\r\n           <h1 class=\"page-title\">Nieuws - ");
                EndContext();
                BeginContext(5025, 16, false);
#line 184 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                                      Write(TempData["Page"]);

#line default
#line hidden
                EndContext();
                BeginContext(5041, 128, true);
                WriteLiteral("</h1>\r\n\r\n            <!-- The form to add a newspost links to a function in the UserController called AddPost. -->\r\n            ");
                EndContext();
                BeginContext(5169, 926, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b793fb08b0664cfe96c8235030bbdea2b83f1bca19616", async() => {
                    BeginContext(5226, 276, true);
                    WriteLiteral(@"
                <label for=""title"">Titel</label>
                <input type=""text"" id=""title"" name=""title"" placeholder=""Titel nieuwsbericht"">

                <label for=""category"">Categorie</label>
                <select id=""group"" name=""group"">
                    ");
                    EndContext();
                    BeginContext(5502, 53, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b793fb08b0664cfe96c8235030bbdea2b83f1bca20311", async() => {
                        BeginContext(5538, 8, true);
                        WriteLiteral("Algemeen");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5555, 4, true);
                    WriteLiteral("\r\n\r\n");
                    EndContext();
#line 195 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                     foreach (var group in Model.Group)
                    {

#line default
#line hidden
                    BeginContext(5639, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(5663, 79, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b793fb08b0664cfe96c8235030bbdea2b83f1bca22172", async() => {
                        BeginContext(5718, 15, false);
#line 197 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                                                                         Write(group.GroupName);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 197 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
AddHtmlAttributeValue("", 5675, group.GroupName, 5675, 16, false);

#line default
#line hidden
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 197 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
AddHtmlAttributeValue("", 5699, group.GroupName, 5699, 16, false);

#line default
#line hidden
                    EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5742, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 198 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                    }

#line default
#line hidden
                    BeginContext(5767, 321, true);
                    WriteLiteral(@"
                </select>

                <label for=""description"">Beschrijving</label>
                <textarea id=""description"" name=""description"" value=""description"" placeholder=""Beschrijving nieuwsbericht"" style=""height:200px""></textarea>

                <input type=""submit"" value=""Voeg toe"">
            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6095, 126, true);
                WriteLiteral("\r\n\r\n            <!-- Single post attribute; Here all the posts from GetFeed() or FilteredNewsfeed() are put on the page. -->\r\n");
                EndContext();
#line 209 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                 foreach (var post in Model.Post)
                {

#line default
#line hidden
                BeginContext(6291, 130, true);
                WriteLiteral("                    <div class=\"article\">\r\n                        <div class=\"article-content\">\r\n                            <h1>");
                EndContext();
                BeginContext(6422, 10, false);
#line 213 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                           Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6432, 39, true);
                WriteLiteral("</h1>\r\n                            <h3>");
                EndContext();
                BeginContext(6472, 14, false);
#line 214 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                           Write(post.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(6486, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(6488, 13, false);
#line 214 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                                           Write(post.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(6501, 2, true);
                WriteLiteral(", ");
                EndContext();
                BeginContext(6504, 14, false);
#line 214 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                                                           Write(post.DateAdded);

#line default
#line hidden
                EndContext();
                BeginContext(6518, 38, true);
                WriteLiteral("</h3>\r\n                            <p>");
                EndContext();
                BeginContext(6557, 16, false);
#line 215 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                          Write(post.Description);

#line default
#line hidden
                EndContext();
                BeginContext(6573, 66, true);
                WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 218 "C:\Users\amyno\source\repos\meldboek\Views\User\Newsfeed.cshtml"
                }

#line default
#line hidden
                BeginContext(6658, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
            BeginContext(6695, 9, true);
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
